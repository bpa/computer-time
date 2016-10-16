package Permissions::linux;

use parent 'Permissions';
use File::Slurp;
use Time::Piece;

use constant DATA_DIR => "/var/lib/computer-time/";
mkdir DATA_DIR;

sub apply {
    my ($self, $user, $data) = @_;
    my $t = localtime;
    my $d = ($t->wday + 5) % 7;

    if ($data->{active} && $data->{open}[$d]{$t->hour}) {
        $self->unlock($user);
    }
    else {
        $self->lock($user);
    }
}

sub discover {
    my ($self, $user) = @_;
    if ($self->{user}{$user}) {
        return;
    }

    open my $grp, '/etc/group';
    my $adm = grep { /^(?:adm|sudo):.*$user$/} <$grp>;
    close $grp;
    return if $adm;

    my $shadow = read_file('/etc/shadow');
    my ($pass) = $shadow =~ /^$user:(.)/m;

    return unless $pass;

    return {
        active => $pass ne '!',
        open => [{},{},{},{},{},{},{}]
    };
}

sub lock {
	my ($self, $user) = @_;
    system('/usr/sbin/usermod', '-L', $user);
	my $uid = getpwnam($user);
	opendir(my $dh, '/proc') || die;
	while(readdir $dh) {
		next unless /^\d+$/;
		next unless (stat("/proc/$_"))[4] == $uid;
		my $cmd = read_file("/proc/$_/cmdline");
		if ($cmd =~ /dbus-daemon.*--address=([^\0]+)/) {
			$ENV{DBUS_SESSION_BUS_ADDRESS} = $1;
			system(qw!/usr/bin/dbus-send --type=method_call --dest=org.gnome.ScreenSaver /org/gnome/ScreenSaver org.gnome.ScreenSaver.Lock!);
			last;
		}
	}
	closedir $dh;
}

sub unlock {
	my ($self, $user) = @_;
    system('/usr/sbin/usermod', '-U', $user);
}

1;

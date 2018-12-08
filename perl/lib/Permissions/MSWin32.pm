package Permissions::MSWin32;

use parent 'Permissions';
use Time::Piece;
use Win32::API ();

my @days = ('M','T','W','Th','F','Sa','Su');
my %day = (
	Monday    => 0,
	Tuesday   => 1,
	Wednesday => 2,
	Thursday  => 3,
	Friday    => 4,
	Saturday  => 5,
	Sunday    => 6,
);

sub apply {
	my ($self, $login, $user) = @_;
	my @times;
	my $cmd = "net user $login ";
	$cmd .= $user->{active} ? '/active:yes' : '/active:no';
	for my $i (0 .. 6) {
		if (scalar(%{$user->{open}[$i]})) {
			my (@periods, $last);
			for my $h (sort keys %{$user->{open}[$i]}) {
				if ($h > $last) {
					push @periods, [$h];
				}
				$last = $h + 1;
				$periods[-1][1] = $last;
			}
			push @times, join(',', $days[$i], map { join '-', @$_ } @periods);
		}
	}
	if (@times) {
		$cmd .= ' /times:' . join(';', @times);
	}
	`$cmd`;
}

sub lock {
	#	my $current_user = `WMIC COMPUTERSYSTEM GET USERNAME`;
	#	if ($current_user =~ /$login/i) {
	#		print "Logged in\n";
	#		print WTSQueryUserToken(WTSGetActiveConsoleSessionId());
	#		#LockWorkStation()
	#		   #or die("Unable to lock workstation: $^E\n");
	#	}
	#}
}

sub discover {
	my ($self, $user) = @_;
	my $times = 0;
	my %user = ( open => [map {{}} 0..6] );
	for (split(/\n/, `net user $user`)) {
		if (/Account active.*(yes|no)/i) {
			$user{active} = lc($1) eq 'yes';
			next;
		}
		if (/Logon hours/) {
			$times = 1;
		}
		if ($times) {
			if (/(\w+)\s+(\d+).*([ap]m).*?(\d+).*([ap]m)/i) {
				my $i = $day{$1};
				my $start = $2;
				$start += 12 if lc($3) eq 'pm';
				my $end = $4;
				$end += 12 if lc($5) eq 'pm';
				for ($start .. $end-1) {
					$user{open}[$i]{$_} = 1;
				}
			}
			else {
				$times = 0;
			}
			next;
		}
		if (/Memberships.*Administrators/) {
			#We don't want to touch admin accounts
			return;
		}
	}
	return \%user;
}

1;

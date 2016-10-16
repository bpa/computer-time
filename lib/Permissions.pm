package Permissions;

=head1 NAME

Permissions - Restrict computer times

=cut

our $VERSION = '1.0';

use DB_File;
use Storable qw/freeze thaw/;

sub new {
    my $pkg = "Permissions::$^O";
    my $path = "Permissions/$^O.pm";
    require $path;
    my $X = tie my %user, 'DB_File', 'users.db';
    return bless {
        X    => $X,
        user => \%user
    }, $pkg;
}

sub apply {
    die ref($_[0]) . " does not implement apply";
}

sub get {
    my ($self, $id) = @_;
    return thaw($self->{user}{$id});
}

sub set {
    my ($self, $id, $data) = @_;
    $self->{user}{$id} = freeze($data);
    $self->{X}->sync;
    $self->apply($id, $data);
}

sub users {
    my $self = shift;
    return keys %{$self->{user}};
}

sub refresh {
    while (my ($id, $bin) = each %{$self->{user}}) {
        $self->apply($id, thaw($bin));
    }
}

1;

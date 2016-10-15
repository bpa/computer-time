package Permissions;

=head1 NAME

Permissions - Restrict computer times

=cut

our $VERSION = '1.0';

sub new {
    my $pkg = "Permissions::$^O";
    my $path = "Permissions/$^O.pm";
    require $path;
    return bless {}, $pkg;
}

sub apply {
    die ref($_[0]) . " does not implement apply";
}

sub lock {
}

sub unlock {
}

1;

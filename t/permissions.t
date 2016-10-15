use Test::More;

use lib 't';
require_ok('Permissions');

$^O = 'Test';
my $test_permissions = Permissions->new;
eval {
    $test_permissions->apply('user', {});
};
like($@, qr/Permissions::Test does not implement/);

done_testing();

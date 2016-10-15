#!perl

$^O = 'dev' if grep { /-dev/ } @ARGV;

use Dancer2;
use DB_File;
use Storable qw/freeze thaw/;
use Data::Dumper;
use Permissions;

my $p = Permissions->new;
my $X = tie my %user, 'DB_File', 'users.db';

get '/' => sub {
    send_file 'index.html';
};

get '/user' => sub {
    return [sort keys %user];
};

get '/user/:id' => sub {
    return thaw($user{param('id')});
};

get '/discover/:id' => sub {
    my $data = $p->discover(param('id'));
    $user{param('id')} = freeze($data);
    return $data;
};

post '/user/:id' => sub {
    $user{param('id')} = freeze(request->data);
    $X->sync;
    $p->apply(param('id'), request->data);
    return {}
};

dance;

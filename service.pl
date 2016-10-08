#! /usr/bin/perl

use Dancer2;
use DB_File;
use Storable qw/freeze thaw/;
use Data::Dumper;

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

get '/adduser/:id' => sub {
    $user{param('id')} = freeze({});
    return {}
};

post '/user/:id' => sub {
    $user{param('id')} = freeze(request->data);
    $X->sync;
    return {}
};

dance;

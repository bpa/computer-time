#!perl

$^O = 'dev' if grep { /-dev/ } @ARGV;

use Dancer2;
use Permissions;
use JSON::XS;
use LWP::UserAgent;

my $ua = LWP::UserAgent->new;
my $p = Permissions->new;

if (config->{master}) {
    my $baseURL = 'http://' . config->{master} . ':' . config->{port};
    eval {
        for my $id (decode_json($ua->get("$baseURL/user"))) {
            $p->set($id, decode_json($ua->get("$baseURL/user/$id")));
        }
    }
}

get '/' => sub {
    send_file 'index.html';
};

get '/user' => sub {
    return [sort $p->users];
};

get '/user/:id' => sub {
    return $p->get(param('id'));
};

get '/discover/:id' => sub {
    my $data = $p->discover(param('id'));
    if ($data) {
        $p->set(param('id'), $data);
    }
    return $data;
};

get '/refresh' => sub {
    $p->refresh;
};

post '/user/:id' => sub {
    $p->set(param('id'), request->data);
    if (config->{slaves}) {
        for my $s (@{config->{slaves}}) {
            eval {
                $ua->post("http://$s:" . config->{port} . '/user/' . param('id'),
                'Content-Type' => 'application/json', encode_json(request->data));
            }
        }
    }
    return {};
};

dance;

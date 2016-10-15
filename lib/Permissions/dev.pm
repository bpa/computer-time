package Permissions::dev;

use parent 'Permissions';

sub apply { }

sub discover {
    return {
        open => [
            { 19 => 1 },
            { 19 => 1 },
            { 19 => 1 },
            { 19 => 1 },
            { 19 => 1 },
            {},
            {} ],
        active => 1 };
}

1;

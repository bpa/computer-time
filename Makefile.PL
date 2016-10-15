use 5.022001;
use ExtUtils::MakeMaker;
WriteMakefile(
    NAME              => 'computer-time',
    VERSION_FROM      => 'lib/Permissions.pm',
    PREREQ_PM         => {},
    EXE_FILES         => ['service.pl'],
    AUTHOR            => 'Bruce Armstrong <bruce@fortressofgeekdom.org>',
    LICENSE           => 'MIT',
);

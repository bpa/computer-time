use FindBin '$Bin';
use Win32::Daemon;

chdir($Bin);
open(STDOUT, ">> service.log") or die "Couldn't open service.log for appending: $!\n";
open(STDERR, ">&STDOUT");
$|=1;

Win32::Daemon::RegisterCallbacks({
	start => sub {
		Win32::Daemon::State( SERVICE_RUNNING );
		require 'service.pl';
	},
	stop => sub {
		$ENV{'psgix.harakiri.commit'} = 1;
		Win32::Daemon::State( SERVICE_STOPPED );
	}
});
Win32::Daemon::StartService();

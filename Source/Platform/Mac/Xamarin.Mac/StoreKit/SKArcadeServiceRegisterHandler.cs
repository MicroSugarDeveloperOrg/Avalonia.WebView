using Foundation;

namespace StoreKit;

public delegate void SKArcadeServiceRegisterHandler(NSData randomFromFP, uint randomFromFPLength, NSData cmacOfAppPid, uint cmacOfAppPidLength, NSError error);

using Foundation;

namespace GameKit;

public delegate void GKIdentityVerificationSignatureHandler(NSUrl publicKeyUrl, NSData signature, NSData salt, ulong timestamp, NSError error);

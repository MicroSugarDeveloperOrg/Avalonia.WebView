using Foundation;

namespace GameKit;

public delegate void GKFetchItemsForIdentityVerificationSignatureCompletionHandler(NSUrl publicKeyUrl, NSData signature, NSData salt, ulong timestamp, NSError error);

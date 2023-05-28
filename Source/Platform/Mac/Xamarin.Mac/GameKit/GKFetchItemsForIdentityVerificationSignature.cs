using Foundation;

namespace GameKit;

public class GKFetchItemsForIdentityVerificationSignature
{
	public NSUrl PublicKeyUrl { get; set; }

	public NSData Signature { get; set; }

	public NSData Salt { get; set; }

	public ulong Timestamp { get; set; }

	public GKFetchItemsForIdentityVerificationSignature(NSUrl publicKeyUrl, NSData signature, NSData salt, ulong timestamp)
	{
		PublicKeyUrl = publicKeyUrl;
		Signature = signature;
		Salt = salt;
		Timestamp = timestamp;
	}
}

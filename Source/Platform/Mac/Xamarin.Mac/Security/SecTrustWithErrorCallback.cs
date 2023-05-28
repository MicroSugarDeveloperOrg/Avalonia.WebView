using Foundation;

namespace Security;

public delegate void SecTrustWithErrorCallback(SecTrust trust, bool result, NSError error);

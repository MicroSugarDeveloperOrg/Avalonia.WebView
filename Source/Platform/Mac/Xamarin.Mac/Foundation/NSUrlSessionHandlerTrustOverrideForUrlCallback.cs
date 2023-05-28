using Security;

namespace Foundation;

public delegate bool NSUrlSessionHandlerTrustOverrideForUrlCallback(NSUrlSessionHandler sender, string url, SecTrust trust);

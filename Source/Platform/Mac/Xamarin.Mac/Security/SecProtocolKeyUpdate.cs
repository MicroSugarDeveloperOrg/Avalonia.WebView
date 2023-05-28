using System;

namespace Security;

public delegate void SecProtocolKeyUpdate(SecProtocolMetadata metadata, Action complete);

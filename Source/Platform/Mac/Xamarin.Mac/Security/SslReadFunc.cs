using System;

namespace Security;

internal delegate SslStatus SslReadFunc(IntPtr connection, IntPtr data, ref nint dataLength);

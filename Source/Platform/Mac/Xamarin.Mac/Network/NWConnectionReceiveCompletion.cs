using System;

namespace Network;

public delegate void NWConnectionReceiveCompletion(IntPtr data, nuint dataSize, NWContentContext context, bool isComplete, NWError error);

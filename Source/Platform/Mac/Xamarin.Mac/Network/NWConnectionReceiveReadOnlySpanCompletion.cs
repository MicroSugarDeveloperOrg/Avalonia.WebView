using System;

namespace Network;

public delegate void NWConnectionReceiveReadOnlySpanCompletion(ReadOnlySpan<byte> data, NWContentContext context, bool isComplete, NWError error);

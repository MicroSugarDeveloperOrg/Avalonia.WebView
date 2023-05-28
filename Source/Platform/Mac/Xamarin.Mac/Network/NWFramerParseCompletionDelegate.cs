using System;

namespace Network;

public delegate nuint NWFramerParseCompletionDelegate(Memory<byte> buffer, bool isCompleted);

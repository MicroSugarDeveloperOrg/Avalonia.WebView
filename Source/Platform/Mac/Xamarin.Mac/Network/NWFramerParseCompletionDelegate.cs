using Xamarin.Mac.System.Mac;

namespace Network;

public delegate nuint NWFramerParseCompletionDelegate(Memory<byte> buffer, bool isCompleted);

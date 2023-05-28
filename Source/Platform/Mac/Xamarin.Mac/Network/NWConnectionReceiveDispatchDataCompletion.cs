using CoreFoundation;

namespace Network;

public delegate void NWConnectionReceiveDispatchDataCompletion(DispatchData data, NWContentContext context, bool isComplete, NWError error);

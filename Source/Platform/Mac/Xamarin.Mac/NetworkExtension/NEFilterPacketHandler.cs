using Xamarin.Mac.System.Mac;

namespace NetworkExtension;

public delegate NEFilterPacketProviderVerdict NEFilterPacketHandler(NEFilterPacketContext context, IntPtr @interface, NETrafficDirection directiom, IntPtr packetBytes, nuint packetLength);

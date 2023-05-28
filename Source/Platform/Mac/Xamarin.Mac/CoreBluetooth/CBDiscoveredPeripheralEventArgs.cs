using System;
using Foundation;

namespace CoreBluetooth;

public class CBDiscoveredPeripheralEventArgs : EventArgs
{
	public NSNumber RSSI { get; set; }

	public NSDictionary AdvertisementData { get; set; }

	public CBPeripheral Peripheral { get; set; }

	public CBDiscoveredPeripheralEventArgs(CBPeripheral peripheral, NSDictionary advertisementData, NSNumber RSSI)
	{
		this.RSSI = RSSI;
		AdvertisementData = advertisementData;
		Peripheral = peripheral;
	}
}

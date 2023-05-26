namespace AudioToolbox;

public enum AudioConverterError
{
	None = 0,
	FormatNotSupported = 1718449215,
	OperationNotSupported = 1869627199,
	PropertyNotSupported = 1886547824,
	InvalidInputSize = 1768846202,
	InvalidOutputSize = 1869902714,
	UnspecifiedError = 2003329396,
	BadPropertySizeError = 561211770,
	RequiresPacketDescriptionsError = 561015652,
	InputSampleRateOutOfRange = 560558962,
	OutputSampleRateOutOfRange = 560952178,
	HardwareInUse = 1752656245,
	NoHardwarePermission = 1885696621
}

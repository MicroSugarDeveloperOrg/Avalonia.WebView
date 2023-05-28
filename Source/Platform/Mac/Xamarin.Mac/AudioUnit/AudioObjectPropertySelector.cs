namespace AudioUnit;

public enum AudioObjectPropertySelector : uint
{
	PropertyDevices = 1684370979u,
	Devices = 1684370979u,
	DefaultInputDevice = 1682533920u,
	DefaultOutputDevice = 1682929012u,
	DefaultSystemOutputDevice = 1934587252u,
	TranslateUIDToDevice = 1969841252u,
	MixStereoToMono = 1937010031u,
	PlugInList = 1886152483u,
	TranslateBundleIDToPlugIn = 1651074160u,
	TransportManagerList = 1953326883u,
	TranslateBundleIDToTransportManager = 1953325673u,
	BoxList = 1651472419u,
	TranslateUIDToBox = 1969841250u,
	ProcessIsMaster = 1835103092u,
	IsInitingOrExiting = 1768845172u,
	UserIDChanged = 1702193508u,
	ProcessIsAudible = 1886221684u,
	SleepingIsAllowed = 1936483696u,
	UnloadingIsAllowed = 1970170980u,
	HogModeIsAllowed = 1752131442u,
	UserSessionIsActiveOrHeadless = 1970496882u,
	ServiceRestarted = 1936880500u,
	PowerHint = 1886353256u
}

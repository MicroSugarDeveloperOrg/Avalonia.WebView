using ObjCRuntime;

namespace AudioUnit;

public enum AudioUnitStatus
{
	NoError = 0,
	OK = 0,
	FileNotFound = -43,
	ParameterError = -50,
	InvalidProperty = -10879,
	InvalidParameter = -10878,
	InvalidElement = -10877,
	NoConnection = -10876,
	FailedInitialization = -10875,
	TooManyFramesToProcess = -10874,
	InvalidFile = -10871,
	FormatNotSupported = -10868,
	Uninitialized = -10867,
	InvalidScope = -10866,
	PropertyNotWritable = -10865,
	CannotDoInCurrentContext = -10863,
	InvalidPropertyValue = -10851,
	PropertyNotInUse = -10850,
	Initialized = -10849,
	InvalidOfflineRender = -10848,
	Unauthorized = -10847,
	[iOS(11, 0)]
	[Mac(10, 13)]
	[TV(11, 0)]
	[NoWatch]
	MidiOutputBufferFull = -66753,
	[iOS(11, 3)]
	[Mac(10, 13, 4)]
	[TV(11, 3)]
	[NoWatch]
	InvalidParameterValue = -66743,
	[iOS(11, 0)]
	[Mac(10, 13)]
	[TV(11, 0)]
	[NoWatch]
	ExtensionNotFound = -66744
}

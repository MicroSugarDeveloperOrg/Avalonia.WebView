using System;

namespace AudioUnit;

public class AudioUnitException : Exception
{
	private static string Lookup(int k)
	{
		return (AudioUnitStatus)k switch
		{
			AudioUnitStatus.InvalidProperty => "Invalid Property", 
			AudioUnitStatus.InvalidParameter => "Invalid Parameter", 
			AudioUnitStatus.InvalidElement => "Invalid Element", 
			AudioUnitStatus.NoConnection => "No Connection", 
			AudioUnitStatus.FailedInitialization => "Failed Initialization", 
			AudioUnitStatus.TooManyFramesToProcess => "Too Many Frames To Process", 
			AudioUnitStatus.InvalidFile => "Invalid File", 
			AudioUnitStatus.FormatNotSupported => "Format Not Supported", 
			AudioUnitStatus.Uninitialized => "Uninitialized", 
			AudioUnitStatus.InvalidScope => "Invalid Scope", 
			AudioUnitStatus.PropertyNotWritable => "Property Not Writable", 
			AudioUnitStatus.CannotDoInCurrentContext => "Cannot Do In Current Context", 
			AudioUnitStatus.InvalidPropertyValue => "Invalid Property Value", 
			AudioUnitStatus.PropertyNotInUse => "Property Not In Use", 
			AudioUnitStatus.Initialized => "Initialized", 
			AudioUnitStatus.InvalidOfflineRender => "Invalid Offline Render", 
			AudioUnitStatus.Unauthorized => "Unauthorized", 
			_ => $"Unknown error code: 0x{k:x}", 
		};
	}

	internal AudioUnitException(int k)
		: base(Lookup(k))
	{
	}
}

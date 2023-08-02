using System;

namespace AudioToolbox;

public class AudioSessionException : Exception
{
	public AudioSessionErrors ErrorCode { get; private set; }

	private static string Lookup(int k)
	{
		return (AudioSessionErrors)k switch
		{
			AudioSessionErrors.NotInitialized => "AudioSession.Initialize has not been called", 
			AudioSessionErrors.AlreadyInitialized => "You called AudioSession.Initialize more than once", 
			AudioSessionErrors.InitializationError => "There was an error during the AudioSession.initialization", 
			AudioSessionErrors.UnsupportedPropertyError => "The audio session property is not supported", 
			AudioSessionErrors.BadPropertySizeError => "The size of the audio property was not correct", 
			AudioSessionErrors.NotActiveError => "Application Audio Session is not active", 
			AudioSessionErrors.NoHardwareError => "The device has no Audio Input capability", 
			AudioSessionErrors.IncompatibleCategory => "The specified AudioSession.Category can not be used with this audio operation", 
			AudioSessionErrors.NoCategorySet => "This operation requries AudioSession.Category to be explicitly set", 
			_ => $"Unknown error code: {k}", 
		};
	}

	internal AudioSessionException(int k)
		: base(Lookup(k))
	{
		ErrorCode = (AudioSessionErrors)k;
	}
}

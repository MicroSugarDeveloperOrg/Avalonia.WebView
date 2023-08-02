using System;
using Foundation;
using ObjCRuntime;

namespace AudioToolbox;

public class AudioSessionRouteChangeEventArgs : EventArgs
{
	private static IntPtr route_change_key;

	private static IntPtr previous_route_key;

	private static IntPtr current_route_key;

	public NSDictionary Dictionary { get; private set; }

	public AudioSessionRouteChangeReason Reason
	{
		get
		{
			using NSNumber nSNumber = new NSNumber(Dictionary.LowlevelObjectForKey(route_change_key));
			return (AudioSessionRouteChangeReason)nSNumber.Int32Value;
		}
	}

	public AudioSessionInputRouteKind PreviousInputRoute
	{
		get
		{
			using NSArray arr = Extract(previous_route_key, AudioSession.AudioRouteKey_Inputs);
			return AudioSession.GetInputRoute(arr);
		}
	}

	public AudioSessionOutputRouteKind[] PreviousOutputRoutes
	{
		get
		{
			using NSArray arr = Extract(previous_route_key, AudioSession.AudioRouteKey_Outputs);
			return AudioSession.GetOutputRoutes(arr);
		}
	}

	public AudioSessionInputRouteKind CurrentInputRoute
	{
		get
		{
			using NSArray arr = Extract(current_route_key, AudioSession.AudioRouteKey_Inputs);
			return AudioSession.GetInputRoute(arr);
		}
	}

	public AudioSessionOutputRouteKind[] CurrentOutputRoutes
	{
		get
		{
			using NSArray arr = Extract(current_route_key, AudioSession.AudioRouteKey_Outputs);
			return AudioSession.GetOutputRoutes(arr);
		}
	}

	static AudioSessionRouteChangeEventArgs()
	{
		IntPtr handle = Dlfcn.dlopen("/System/Library/Frameworks/AudioToolbox.framework/AudioToolbox", 0);
		route_change_key = Dlfcn.GetIntPtr(handle, "kAudioSession_RouteChangeKey_Reason");
		previous_route_key = Dlfcn.GetIntPtr(handle, "kAudioSession_AudioRouteChangeKey_PreviousRouteDescription");
		current_route_key = Dlfcn.GetIntPtr(handle, "kAudioSession_AudioRouteChangeKey_CurrentRouteDescription");
		Dlfcn.dlclose(handle);
	}

	public AudioSessionRouteChangeEventArgs(IntPtr dictHandle)
	{
		Dictionary = new NSDictionary(dictHandle);
	}

	private NSArray Extract(IntPtr key, NSString secondKey)
	{
		IntPtr intPtr = Dictionary.LowlevelObjectForKey(key);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		using NSDictionary nSDictionary = new NSDictionary(intPtr);
		IntPtr intPtr2 = nSDictionary.LowlevelObjectForKey(secondKey.Handle);
		if (intPtr2 == IntPtr.Zero)
		{
			return null;
		}
		return new NSArray(intPtr2);
	}
}

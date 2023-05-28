using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureDeviceDiscoverySession", true)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVCaptureDeviceDiscoverySession : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDevices = "devices";

	private static readonly IntPtr selDevicesHandle = Selector.GetHandle("devices");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscoverySessionWithDeviceTypes_MediaType_Position_ = "discoverySessionWithDeviceTypes:mediaType:position:";

	private static readonly IntPtr selDiscoverySessionWithDeviceTypes_MediaType_Position_Handle = Selector.GetHandle("discoverySessionWithDeviceTypes:mediaType:position:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVCaptureDeviceDiscoverySession");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVCaptureDevice[] Devices
	{
		[Export("devices")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVCaptureDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, selDevicesHandle));
			}
			return NSArray.ArrayFromHandle<AVCaptureDevice>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDevicesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVCaptureDeviceDiscoverySession(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCaptureDeviceDiscoverySession(IntPtr handle)
		: base(handle)
	{
	}

	[Export("discoverySessionWithDeviceTypes:mediaType:position:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static AVCaptureDeviceDiscoverySession _Create(NSArray deviceTypes, string? mediaType, AVCaptureDevicePosition position)
	{
		if (deviceTypes == null)
		{
			throw new ArgumentNullException("deviceTypes");
		}
		IntPtr arg = NSString.CreateNative(mediaType);
		AVCaptureDeviceDiscoverySession nSObject = Runtime.GetNSObject<AVCaptureDeviceDiscoverySession>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_Int64(class_ptr, selDiscoverySessionWithDeviceTypes_MediaType_Position_Handle, deviceTypes.Handle, arg, (long)position));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}

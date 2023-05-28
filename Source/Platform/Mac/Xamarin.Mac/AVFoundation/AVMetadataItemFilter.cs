using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMetadataItemFilter", true)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVMetadataItemFilter : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadataItemFilterForSharing = "metadataItemFilterForSharing";

	private static readonly IntPtr selMetadataItemFilterForSharingHandle = Selector.GetHandle("metadataItemFilterForSharing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVMetadataItemFilter");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMetadataItemFilter ForSharing
	{
		[Export("metadataItemFilterForSharing")]
		get
		{
			return Runtime.GetNSObject<AVMetadataItemFilter>(Messaging.IntPtr_objc_msgSend(class_ptr, selMetadataItemFilterForSharingHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVMetadataItemFilter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVMetadataItemFilter(IntPtr handle)
		: base(handle)
	{
	}
}

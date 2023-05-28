using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CAEDRMetadata", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class CAEdrMetadata : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHDR10MetadataWithDisplayInfo_ContentInfo_OpticalOutputScale_ = "HDR10MetadataWithDisplayInfo:contentInfo:opticalOutputScale:";

	private static readonly IntPtr selHDR10MetadataWithDisplayInfo_ContentInfo_OpticalOutputScale_Handle = Selector.GetHandle("HDR10MetadataWithDisplayInfo:contentInfo:opticalOutputScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHDR10MetadataWithMinLuminance_MaxLuminance_OpticalOutputScale_ = "HDR10MetadataWithMinLuminance:maxLuminance:opticalOutputScale:";

	private static readonly IntPtr selHDR10MetadataWithMinLuminance_MaxLuminance_OpticalOutputScale_Handle = Selector.GetHandle("HDR10MetadataWithMinLuminance:maxLuminance:opticalOutputScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHLGMetadata = "HLGMetadata";

	private static readonly IntPtr selHLGMetadataHandle = Selector.GetHandle("HLGMetadata");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CAEDRMetadata");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CAEdrMetadata HlgMetadata
	{
		[Export("HLGMetadata", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<CAEdrMetadata>(Messaging.IntPtr_objc_msgSend(class_ptr, selHLGMetadataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CAEdrMetadata(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CAEdrMetadata(IntPtr handle)
		: base(handle)
	{
	}

	[Export("HDR10MetadataWithDisplayInfo:contentInfo:opticalOutputScale:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CAEdrMetadata GetHdr10Metadata(NSData? displayData, NSData? contentData, float scale)
	{
		return Runtime.GetNSObject<CAEdrMetadata>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_float(class_ptr, selHDR10MetadataWithDisplayInfo_ContentInfo_OpticalOutputScale_Handle, displayData?.Handle ?? IntPtr.Zero, contentData?.Handle ?? IntPtr.Zero, scale));
	}

	[Export("HDR10MetadataWithMinLuminance:maxLuminance:opticalOutputScale:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CAEdrMetadata GetHdr10Metadata(float minNits, float maxNits, float scale)
	{
		return Runtime.GetNSObject<CAEdrMetadata>(Messaging.IntPtr_objc_msgSend_float_float_float(class_ptr, selHDR10MetadataWithMinLuminance_MaxLuminance_OpticalOutputScale_Handle, minNits, maxNits, scale));
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetReaderOutputMetadataAdaptor", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class AVAssetReaderOutputMetadataAdaptor : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetReaderOutputMetadataAdaptorWithAssetReaderTrackOutput_ = "assetReaderOutputMetadataAdaptorWithAssetReaderTrackOutput:";

	private static readonly IntPtr selAssetReaderOutputMetadataAdaptorWithAssetReaderTrackOutput_Handle = Selector.GetHandle("assetReaderOutputMetadataAdaptorWithAssetReaderTrackOutput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetReaderTrackOutput = "assetReaderTrackOutput";

	private static readonly IntPtr selAssetReaderTrackOutputHandle = Selector.GetHandle("assetReaderTrackOutput");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAssetReaderTrackOutput_ = "initWithAssetReaderTrackOutput:";

	private static readonly IntPtr selInitWithAssetReaderTrackOutput_Handle = Selector.GetHandle("initWithAssetReaderTrackOutput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextTimedMetadataGroup = "nextTimedMetadataGroup";

	private static readonly IntPtr selNextTimedMetadataGroupHandle = Selector.GetHandle("nextTimedMetadataGroup");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAssetReaderOutputMetadataAdaptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAssetReaderTrackOutput AssetReaderTrackOutput
	{
		[Export("assetReaderTrackOutput")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAssetReaderTrackOutput>(Messaging.IntPtr_objc_msgSend(base.Handle, selAssetReaderTrackOutputHandle));
			}
			return Runtime.GetNSObject<AVAssetReaderTrackOutput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAssetReaderTrackOutputHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAssetReaderOutputMetadataAdaptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAssetReaderOutputMetadataAdaptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAssetReaderTrackOutput:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetReaderOutputMetadataAdaptor(AVAssetReaderTrackOutput trackOutput)
		: base(NSObjectFlag.Empty)
	{
		if (trackOutput == null)
		{
			throw new ArgumentNullException("trackOutput");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithAssetReaderTrackOutput_Handle, trackOutput.Handle), "initWithAssetReaderTrackOutput:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithAssetReaderTrackOutput_Handle, trackOutput.Handle), "initWithAssetReaderTrackOutput:");
		}
	}

	[Export("assetReaderOutputMetadataAdaptorWithAssetReaderTrackOutput:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAssetReaderOutputMetadataAdaptor Create(AVAssetReaderTrackOutput trackOutput)
	{
		if (trackOutput == null)
		{
			throw new ArgumentNullException("trackOutput");
		}
		return Runtime.GetNSObject<AVAssetReaderOutputMetadataAdaptor>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAssetReaderOutputMetadataAdaptorWithAssetReaderTrackOutput_Handle, trackOutput.Handle));
	}

	[Export("nextTimedMetadataGroup")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVTimedMetadataGroup? NextTimedMetadataGroup()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVTimedMetadataGroup>(Messaging.IntPtr_objc_msgSend(base.Handle, selNextTimedMetadataGroupHandle));
		}
		return Runtime.GetNSObject<AVTimedMetadataGroup>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNextTimedMetadataGroupHandle));
	}
}

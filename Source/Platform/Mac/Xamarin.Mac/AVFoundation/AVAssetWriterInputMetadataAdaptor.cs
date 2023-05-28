using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetWriterInputMetadataAdaptor", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class AVAssetWriterInputMetadataAdaptor : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendTimedMetadataGroup_ = "appendTimedMetadataGroup:";

	private static readonly IntPtr selAppendTimedMetadataGroup_Handle = Selector.GetHandle("appendTimedMetadataGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetWriterInput = "assetWriterInput";

	private static readonly IntPtr selAssetWriterInputHandle = Selector.GetHandle("assetWriterInput");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetWriterInputMetadataAdaptorWithAssetWriterInput_ = "assetWriterInputMetadataAdaptorWithAssetWriterInput:";

	private static readonly IntPtr selAssetWriterInputMetadataAdaptorWithAssetWriterInput_Handle = Selector.GetHandle("assetWriterInputMetadataAdaptorWithAssetWriterInput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAssetWriterInput_ = "initWithAssetWriterInput:";

	private static readonly IntPtr selInitWithAssetWriterInput_Handle = Selector.GetHandle("initWithAssetWriterInput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAssetWriterInputMetadataAdaptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAssetWriterInput AssetWriterInput
	{
		[Export("assetWriterInput")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAssetWriterInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selAssetWriterInputHandle));
			}
			return Runtime.GetNSObject<AVAssetWriterInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAssetWriterInputHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAssetWriterInputMetadataAdaptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAssetWriterInputMetadataAdaptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAssetWriterInput:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetWriterInputMetadataAdaptor(AVAssetWriterInput assetWriterInput)
		: base(NSObjectFlag.Empty)
	{
		if (assetWriterInput == null)
		{
			throw new ArgumentNullException("assetWriterInput");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithAssetWriterInput_Handle, assetWriterInput.Handle), "initWithAssetWriterInput:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithAssetWriterInput_Handle, assetWriterInput.Handle), "initWithAssetWriterInput:");
		}
	}

	[Export("appendTimedMetadataGroup:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AppendTimedMetadataGroup(AVTimedMetadataGroup timedMetadataGroup)
	{
		if (timedMetadataGroup == null)
		{
			throw new ArgumentNullException("timedMetadataGroup");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selAppendTimedMetadataGroup_Handle, timedMetadataGroup.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendTimedMetadataGroup_Handle, timedMetadataGroup.Handle);
	}

	[Export("assetWriterInputMetadataAdaptorWithAssetWriterInput:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAssetWriterInputMetadataAdaptor Create(AVAssetWriterInput input)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		return Runtime.GetNSObject<AVAssetWriterInputMetadataAdaptor>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAssetWriterInputMetadataAdaptorWithAssetWriterInput_Handle, input.Handle));
	}
}

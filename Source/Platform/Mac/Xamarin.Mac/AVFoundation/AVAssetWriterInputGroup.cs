using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetWriterInputGroup", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class AVAssetWriterInputGroup : AVMediaSelectionGroup
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetWriterInputGroupWithInputs_DefaultInput_ = "assetWriterInputGroupWithInputs:defaultInput:";

	private static readonly IntPtr selAssetWriterInputGroupWithInputs_DefaultInput_Handle = Selector.GetHandle("assetWriterInputGroupWithInputs:defaultInput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultInput = "defaultInput";

	private static readonly IntPtr selDefaultInputHandle = Selector.GetHandle("defaultInput");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithInputs_DefaultInput_ = "initWithInputs:defaultInput:";

	private static readonly IntPtr selInitWithInputs_DefaultInput_Handle = Selector.GetHandle("initWithInputs:defaultInput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputs = "inputs";

	private static readonly IntPtr selInputsHandle = Selector.GetHandle("inputs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAssetWriterInputGroup");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAssetWriterInput? DefaultInput
	{
		[Export("defaultInput", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAssetWriterInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultInputHandle));
			}
			return Runtime.GetNSObject<AVAssetWriterInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultInputHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAssetWriterInput[] Inputs
	{
		[Export("inputs")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVAssetWriterInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputsHandle));
			}
			return NSArray.ArrayFromHandle<AVAssetWriterInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAssetWriterInputGroup(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAssetWriterInputGroup(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithInputs:defaultInput:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetWriterInputGroup(AVAssetWriterInput[] inputs, AVAssetWriterInput? defaultInput)
		: base(NSObjectFlag.Empty)
	{
		if (inputs == null)
		{
			throw new ArgumentNullException("inputs");
		}
		NSArray nSArray = NSArray.FromNSObjects(inputs);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithInputs_DefaultInput_Handle, nSArray.Handle, defaultInput?.Handle ?? IntPtr.Zero), "initWithInputs:defaultInput:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithInputs_DefaultInput_Handle, nSArray.Handle, defaultInput?.Handle ?? IntPtr.Zero), "initWithInputs:defaultInput:");
		}
		nSArray.Dispose();
	}

	[Export("assetWriterInputGroupWithInputs:defaultInput:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAssetWriterInputGroup Create(AVAssetWriterInput[] inputs, AVAssetWriterInput? defaultInput)
	{
		if (inputs == null)
		{
			throw new ArgumentNullException("inputs");
		}
		NSArray nSArray = NSArray.FromNSObjects(inputs);
		AVAssetWriterInputGroup nSObject = Runtime.GetNSObject<AVAssetWriterInputGroup>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selAssetWriterInputGroupWithInputs_DefaultInput_Handle, nSArray.Handle, defaultInput?.Handle ?? IntPtr.Zero));
		nSArray.Dispose();
		return nSObject;
	}
}

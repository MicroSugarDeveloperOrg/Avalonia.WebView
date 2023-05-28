using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

[Register("ICScannerFeatureRange", true)]
public class ICScannerFeatureRange : ICScannerFeature
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentValue = "currentValue";

	private static readonly IntPtr selCurrentValueHandle = Selector.GetHandle("currentValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultValue = "defaultValue";

	private static readonly IntPtr selDefaultValueHandle = Selector.GetHandle("defaultValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxValue = "maxValue";

	private static readonly IntPtr selMaxValueHandle = Selector.GetHandle("maxValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinValue = "minValue";

	private static readonly IntPtr selMinValueHandle = Selector.GetHandle("minValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentValue_ = "setCurrentValue:";

	private static readonly IntPtr selSetCurrentValue_Handle = Selector.GetHandle("setCurrentValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStepSize = "stepSize";

	private static readonly IntPtr selStepSizeHandle = Selector.GetHandle("stepSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ICScannerFeatureRange");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat CurrentValue
	{
		[Export("currentValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selCurrentValueHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selCurrentValueHandle);
		}
		[Export("setCurrentValue:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetCurrentValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetCurrentValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat DefaultValue
	{
		[Export("defaultValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selDefaultValueHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selDefaultValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MaxValue
	{
		[Export("maxValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMaxValueHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMaxValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MinValue
	{
		[Export("minValue")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMinValueHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMinValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat StepSize
	{
		[Export("stepSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selStepSizeHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selStepSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected ICScannerFeatureRange(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ICScannerFeatureRange(IntPtr handle)
		: base(handle)
	{
	}
}

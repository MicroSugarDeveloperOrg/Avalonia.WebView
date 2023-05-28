using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreML;

[Register("MLMetricKey", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MLMetricKey : MLKey
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEpochIndex = "epochIndex";

	private static readonly IntPtr selEpochIndexHandle = Selector.GetHandle("epochIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLossValue = "lossValue";

	private static readonly IntPtr selLossValueHandle = Selector.GetHandle("lossValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMiniBatchIndex = "miniBatchIndex";

	private static readonly IntPtr selMiniBatchIndexHandle = Selector.GetHandle("miniBatchIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MLMetricKey");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLMetricKey EpochIndex
	{
		[Export("epochIndex")]
		get
		{
			return Runtime.GetNSObject<MLMetricKey>(Messaging.IntPtr_objc_msgSend(class_ptr, selEpochIndexHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLMetricKey LossValue
	{
		[Export("lossValue")]
		get
		{
			return Runtime.GetNSObject<MLMetricKey>(Messaging.IntPtr_objc_msgSend(class_ptr, selLossValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLMetricKey MiniBatchIndex
	{
		[Export("miniBatchIndex")]
		get
		{
			return Runtime.GetNSObject<MLMetricKey>(Messaging.IntPtr_objc_msgSend(class_ptr, selMiniBatchIndexHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MLMetricKey(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MLMetricKey(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MLMetricKey(IntPtr handle)
		: base(handle)
	{
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Register("GKConstantNoiseSource", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class GKConstantNoiseSource : GKNoiseSource
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstantNoiseWithValue_ = "constantNoiseWithValue:";

	private static readonly IntPtr selConstantNoiseWithValue_Handle = Selector.GetHandle("constantNoiseWithValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithValue_ = "initWithValue:";

	private static readonly IntPtr selInitWithValue_Handle = Selector.GetHandle("initWithValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_ = "setValue:";

	private static readonly IntPtr selSetValue_Handle = Selector.GetHandle("setValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValue = "value";

	private static readonly IntPtr selValueHandle = Selector.GetHandle("value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKConstantNoiseSource");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Value
	{
		[Export("value")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selValueHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selValueHandle);
		}
		[Export("setValue:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetValue_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetValue_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKConstantNoiseSource(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKConstantNoiseSource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithValue:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKConstantNoiseSource(double value)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_Double(base.Handle, selInitWithValue_Handle, value), "initWithValue:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Double(base.SuperHandle, selInitWithValue_Handle, value), "initWithValue:");
		}
	}

	[Export("constantNoiseWithValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKConstantNoiseSource Create(double value)
	{
		return Runtime.GetNSObject<GKConstantNoiseSource>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selConstantNoiseWithValue_Handle, value));
	}
}

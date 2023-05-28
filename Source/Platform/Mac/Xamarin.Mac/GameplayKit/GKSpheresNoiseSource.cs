using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Register("GKSpheresNoiseSource", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class GKSpheresNoiseSource : GKNoiseSource
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrequency = "frequency";

	private static readonly IntPtr selFrequencyHandle = Selector.GetHandle("frequency");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrequency_ = "initWithFrequency:";

	private static readonly IntPtr selInitWithFrequency_Handle = Selector.GetHandle("initWithFrequency:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrequency_ = "setFrequency:";

	private static readonly IntPtr selSetFrequency_Handle = Selector.GetHandle("setFrequency:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpheresNoiseWithFrequency_ = "spheresNoiseWithFrequency:";

	private static readonly IntPtr selSpheresNoiseWithFrequency_Handle = Selector.GetHandle("spheresNoiseWithFrequency:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKSpheresNoiseSource");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Frequency
	{
		[Export("frequency")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selFrequencyHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selFrequencyHandle);
		}
		[Export("setFrequency:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetFrequency_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetFrequency_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKSpheresNoiseSource(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKSpheresNoiseSource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrequency:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKSpheresNoiseSource(double frequency)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_Double(base.Handle, selInitWithFrequency_Handle, frequency), "initWithFrequency:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Double(base.SuperHandle, selInitWithFrequency_Handle, frequency), "initWithFrequency:");
		}
	}

	[Export("spheresNoiseWithFrequency:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKSpheresNoiseSource Create(double frequency)
	{
		return Runtime.GetNSObject<GKSpheresNoiseSource>(Messaging.IntPtr_objc_msgSend_Double(class_ptr, selSpheresNoiseWithFrequency_Handle, frequency));
	}
}

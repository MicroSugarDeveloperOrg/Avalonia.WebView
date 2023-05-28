using System;
using System.ComponentModel;
using AppKit;
using AudioUnit;
using Foundation;
using ObjCRuntime;

namespace CoreAudioKit;

[Register("AUPannerView", true)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class AUPannerView : NSView
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAUPannerViewWithAudioUnit_ = "AUPannerViewWithAudioUnit:";

	private static readonly IntPtr selAUPannerViewWithAudioUnit_Handle = Selector.GetHandle("AUPannerViewWithAudioUnit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioUnit = "audioUnit";

	private static readonly IntPtr selAudioUnitHandle = Selector.GetHandle("audioUnit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AUPannerView");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual global::AudioUnit.AudioUnit AudioUnit
	{
		[Export("audioUnit")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioUnitHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selAudioUnitHandle));
			return (intPtr == IntPtr.Zero) ? null : new global::AudioUnit.AudioUnit(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AUPannerView(NSCoder coder)
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
	protected AUPannerView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AUPannerView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("AUPannerViewWithAudioUnit:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AUPannerView Create(global::AudioUnit.AudioUnit au)
	{
		if (au == null)
		{
			throw new ArgumentNullException("au");
		}
		return Runtime.GetNSObject<AUPannerView>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAUPannerViewWithAudioUnit_Handle, au.Handle));
	}
}

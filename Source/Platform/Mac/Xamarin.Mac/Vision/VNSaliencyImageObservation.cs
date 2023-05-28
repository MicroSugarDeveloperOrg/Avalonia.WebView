using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Vision;

[Register("VNSaliencyImageObservation", true)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class VNSaliencyImageObservation : VNPixelBufferObservation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSalientObjects = "salientObjects";

	private static readonly IntPtr selSalientObjectsHandle = Selector.GetHandle("salientObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("VNSaliencyImageObservation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual VNRectangleObservation[]? SalientObjects
	{
		[Export("salientObjects")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<VNRectangleObservation>(Messaging.IntPtr_objc_msgSend(base.Handle, selSalientObjectsHandle));
			}
			return NSArray.ArrayFromHandle<VNRectangleObservation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSalientObjectsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public VNSaliencyImageObservation(NSCoder coder)
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
	protected VNSaliencyImageObservation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal VNSaliencyImageObservation(IntPtr handle)
		: base(handle)
	{
	}
}

using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace Vision;

[Register("VNImageBasedRequest", true)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public abstract class VNImageBasedRequest : VNRequest
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCompletionHandler_ = "initWithCompletionHandler:";

	private static readonly IntPtr selInitWithCompletionHandler_Handle = Selector.GetHandle("initWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegionOfInterest = "regionOfInterest";

	private static readonly IntPtr selRegionOfInterestHandle = Selector.GetHandle("regionOfInterest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRegionOfInterest_ = "setRegionOfInterest:";

	private static readonly IntPtr selSetRegionOfInterest_Handle = Selector.GetHandle("setRegionOfInterest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("VNImageBasedRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect RegionOfInterest
	{
		[Export("regionOfInterest", ArgumentSemantic.Assign)]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selRegionOfInterestHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRegionOfInterestHandle);
			}
			return retval;
		}
		[Export("setRegionOfInterest:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetRegionOfInterest_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetRegionOfInterest_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected VNImageBasedRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal VNImageBasedRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCompletionHandler:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe VNImageBasedRequest([BlockProxy(typeof(Trampolines.NIDVNRequestCompletionHandler))] VNRequestCompletionHandler? completionHandler)
		: base(NSObjectFlag.Empty)
	{
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDVNRequestCompletionHandler.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithCompletionHandler_Handle, (IntPtr)ptr), "initWithCompletionHandler:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithCompletionHandler_Handle, (IntPtr)ptr), "initWithCompletionHandler:");
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}
}

using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace MediaPlayer;

[Register("MPMediaItemArtwork", true)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
public class MPMediaItemArtwork : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBounds = "bounds";

	private static readonly IntPtr selBoundsHandle = Selector.GetHandle("bounds");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithSize_ = "imageWithSize:";

	private static readonly IntPtr selImageWithSize_Handle = Selector.GetHandle("imageWithSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithBoundsSize_RequestHandler_ = "initWithBoundsSize:requestHandler:";

	private static readonly IntPtr selInitWithBoundsSize_RequestHandler_Handle = Selector.GetHandle("initWithBoundsSize:requestHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPMediaItemArtwork");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect Bounds
	{
		[Export("bounds")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selBoundsHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selBoundsHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPMediaItemArtwork(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPMediaItemArtwork(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithBoundsSize:requestHandler:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe MPMediaItemArtwork(CGSize boundsSize, [BlockProxy(typeof(Trampolines.NIDFuncArity2V2))] Func<CGSize, NSImage> requestHandler)
		: base(NSObjectFlag.Empty)
	{
		if (requestHandler == null)
		{
			throw new ArgumentNullException("requestHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDFuncArity2V2.Handler, requestHandler);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGSize_IntPtr(base.Handle, selInitWithBoundsSize_RequestHandler_Handle, boundsSize, (IntPtr)ptr), "initWithBoundsSize:requestHandler:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGSize_IntPtr(base.SuperHandle, selInitWithBoundsSize_RequestHandler_Handle, boundsSize, (IntPtr)ptr), "initWithBoundsSize:requestHandler:");
		}
		ptr->CleanupBlock();
	}

	[Export("imageWithSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage? ImageWithSize(CGSize size)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend_CGSize(base.Handle, selImageWithSize_Handle, size));
		}
		return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper_CGSize(base.SuperHandle, selImageWithSize_Handle, size));
	}
}

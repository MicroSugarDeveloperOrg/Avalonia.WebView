using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSEPSImageRep", true)]
public class NSEPSImageRep : NSImageRep
{
	private static readonly IntPtr selEPSRepresentationHandle = Selector.GetHandle("EPSRepresentation");

	private static readonly IntPtr selBoundingBoxHandle = Selector.GetHandle("boundingBox");

	private static readonly IntPtr selImageRepWithData_Handle = Selector.GetHandle("imageRepWithData:");

	private static readonly IntPtr selInitWithData_Handle = Selector.GetHandle("initWithData:");

	private static readonly IntPtr selPrepareGStateHandle = Selector.GetHandle("prepareGState");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSEPSImageRep");

	private object __mt_EPSRepresentation_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSData EPSRepresentation
	{
		[Export("EPSRepresentation")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSData)(__mt_EPSRepresentation_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEPSRepresentationHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selEPSRepresentationHandle)))));
		}
	}

	public virtual CGRect BoundingBox
	{
		[Export("boundingBox")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selBoundingBoxHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selBoundingBoxHandle);
			}
			return retval;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSEPSImageRep(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSEPSImageRep(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSEPSImageRep(IntPtr handle)
		: base(handle)
	{
	}

	[Export("imageRepWithData:")]
	public static NSObject FromData(NSData epsData)
	{
		NSApplication.EnsureUIThread();
		if (epsData == null)
		{
			throw new ArgumentNullException("epsData");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageRepWithData_Handle, epsData.Handle));
	}

	[Export("initWithData:")]
	public NSEPSImageRep(NSData epsData)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (epsData == null)
		{
			throw new ArgumentNullException("epsData");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithData_Handle, epsData.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithData_Handle, epsData.Handle);
		}
	}

	[Export("prepareGState")]
	public virtual void PrepareGState()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPrepareGStateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPrepareGStateHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_EPSRepresentation_var = null;
		}
	}
}

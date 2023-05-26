using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIFeature", true)]
public class CIFeature : NSObject
{
	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	private static readonly IntPtr selBoundsHandle = Selector.GetHandle("bounds");

	private static readonly IntPtr class_ptr = Class.GetHandle("CIFeature");

	private object __mt_Type_var;

	private static NSString _TypeFace;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSString Type
	{
		[Export("type")]
		get
		{
			return (NSString)(__mt_Type_var = ((!IsDirectBinding) ? ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypeHandle))) : ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTypeHandle)))));
		}
	}

	public virtual CGRect Bounds
	{
		[Export("bounds")]
		get
		{
			CGRect retval;
			if (IsDirectBinding)
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

	[Field("CIFeatureTypeFace", "CoreImage")]
	public static NSString TypeFace
	{
		get
		{
			if (_TypeFace == null)
			{
				_TypeFace = Dlfcn.GetStringConstant(Libraries.CoreImage.Handle, "CIFeatureTypeFace");
			}
			return _TypeFace;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIFeature(NSCoder coder)
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
	public CIFeature(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CIFeature(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Type_var = null;
		}
	}
}

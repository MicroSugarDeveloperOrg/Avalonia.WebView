using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSInvocation", true)]
public class NSInvocation : NSObject
{
	private static readonly IntPtr selSelectorHandle = Selector.GetHandle("selector");

	private static readonly IntPtr selSetSelector_Handle = Selector.GetHandle("setSelector:");

	private static readonly IntPtr selTargetHandle = Selector.GetHandle("target");

	private static readonly IntPtr selSetTarget_Handle = Selector.GetHandle("setTarget:");

	private static readonly IntPtr selMethodSignatureHandle = Selector.GetHandle("methodSignature");

	private static readonly IntPtr selSetArgumentAtIndex_Handle = Selector.GetHandle("setArgument:atIndex:");

	private static readonly IntPtr selGetArgumentAtIndex_Handle = Selector.GetHandle("getArgument:atIndex:");

	private static readonly IntPtr selSetReturnValue_Handle = Selector.GetHandle("setReturnValue:");

	private static readonly IntPtr selGetReturnValue_Handle = Selector.GetHandle("getReturnValue:");

	private static readonly IntPtr selInvokeHandle = Selector.GetHandle("invoke");

	private static readonly IntPtr selInvokeWithTarget_Handle = Selector.GetHandle("invokeWithTarget:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSInvocation");

	private object __mt_Target_var;

	private object __mt_MethodSignature_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual Selector Selector
	{
		[Export("selector")]
		get
		{
			if (IsDirectBinding)
			{
				return Selector.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectorHandle));
			}
			return Selector.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectorHandle));
		}
		[Export("setSelector:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSelector_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelector_Handle, value.Handle);
			}
		}
	}

	public virtual NSObject Target
	{
		[Export("target")]
		get
		{
			return (NSObject)(__mt_Target_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTargetHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTargetHandle))));
		}
		[Export("setTarget:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTarget_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTarget_Handle, value.Handle);
			}
			__mt_Target_var = value;
		}
	}

	public virtual NSMethodSignature MethodSignature
	{
		[Export("methodSignature")]
		get
		{
			return (NSMethodSignature)(__mt_MethodSignature_var = ((!IsDirectBinding) ? ((NSMethodSignature)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMethodSignatureHandle))) : ((NSMethodSignature)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMethodSignatureHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSInvocation(NSCoder coder)
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
	public NSInvocation(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSInvocation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setArgument:atIndex:")]
	internal virtual void _SetArgument(IntPtr buffer, int index)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int(base.Handle, selSetArgumentAtIndex_Handle, buffer, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selSetArgumentAtIndex_Handle, buffer, index);
		}
	}

	[Export("getArgument:atIndex:")]
	internal virtual void _GetArgument(IntPtr buffer, int index)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int(base.Handle, selGetArgumentAtIndex_Handle, buffer, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selGetArgumentAtIndex_Handle, buffer, index);
		}
	}

	[Export("setReturnValue:")]
	internal virtual void _SetReturnValue(IntPtr buffer)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetReturnValue_Handle, buffer);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetReturnValue_Handle, buffer);
		}
	}

	[Export("getReturnValue:")]
	internal virtual void _GetReturnValue(IntPtr buffer)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGetReturnValue_Handle, buffer);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetReturnValue_Handle, buffer);
		}
	}

	[Export("invoke")]
	public virtual void Invoke()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvokeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvokeHandle);
		}
	}

	[Export("invokeWithTarget:")]
	public virtual void Invoke(NSObject target)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInvokeWithTarget_Handle, target.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInvokeWithTarget_Handle, target.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Target_var = null;
			__mt_MethodSignature_var = null;
		}
	}
}

using System.ComponentModel;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSInvocation", true)]
public class NSInvocation : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetArgument_AtIndex_ = "getArgument:atIndex:";

	private static readonly IntPtr selGetArgument_AtIndex_Handle = ObjCRuntime.Selector.GetHandle("getArgument:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetReturnValue_ = "getReturnValue:";

	private static readonly IntPtr selGetReturnValue_Handle = ObjCRuntime.Selector.GetHandle("getReturnValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvoke = "invoke";

	private static readonly IntPtr selInvokeHandle = ObjCRuntime.Selector.GetHandle("invoke");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvokeWithTarget_ = "invokeWithTarget:";

	private static readonly IntPtr selInvokeWithTarget_Handle = ObjCRuntime.Selector.GetHandle("invokeWithTarget:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMethodSignature = "methodSignature";

	private static readonly IntPtr selMethodSignatureHandle = ObjCRuntime.Selector.GetHandle("methodSignature");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelector = "selector";

	private static readonly IntPtr selSelectorHandle = ObjCRuntime.Selector.GetHandle("selector");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetArgument_AtIndex_ = "setArgument:atIndex:";

	private static readonly IntPtr selSetArgument_AtIndex_Handle = ObjCRuntime.Selector.GetHandle("setArgument:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReturnValue_ = "setReturnValue:";

	private static readonly IntPtr selSetReturnValue_Handle = ObjCRuntime.Selector.GetHandle("setReturnValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelector_ = "setSelector:";

	private static readonly IntPtr selSetSelector_Handle = ObjCRuntime.Selector.GetHandle("setSelector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTarget_ = "setTarget:";

	private static readonly IntPtr selSetTarget_Handle = ObjCRuntime.Selector.GetHandle("setTarget:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTarget = "target";

	private static readonly IntPtr selTargetHandle = ObjCRuntime.Selector.GetHandle("target");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSInvocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Target_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMethodSignature MethodSignature
	{
		[Export("methodSignature")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMethodSignature>(Messaging.IntPtr_objc_msgSend(base.Handle, selMethodSignatureHandle));
			}
			return Runtime.GetNSObject<NSMethodSignature>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMethodSignatureHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Selector Selector
	{
		[Export("selector")]
		get
		{
			if (base.IsDirectBinding)
			{
				return ObjCRuntime.Selector.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectorHandle));
			}
			return ObjCRuntime.Selector.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectorHandle));
		}
		[Export("setSelector:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSelector_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelector_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? Target
	{
		[Export("target", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTargetHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTargetHandle)));
			MarkDirty();
			__mt_Target_var = nSObject;
			return nSObject;
		}
		[Export("setTarget:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTarget_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTarget_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_Target_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSInvocation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSInvocation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("invoke")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Invoke()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvokeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvokeHandle);
		}
	}

	[Export("invokeWithTarget:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Invoke(NSObject target)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInvokeWithTarget_Handle, target.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInvokeWithTarget_Handle, target.Handle);
		}
	}

	[Export("getArgument:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _GetArgument(IntPtr buffer, nint index)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selGetArgument_AtIndex_Handle, buffer, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selGetArgument_AtIndex_Handle, buffer, index);
		}
	}

	[Export("getReturnValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _GetReturnValue(IntPtr buffer)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGetReturnValue_Handle, buffer);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetReturnValue_Handle, buffer);
		}
	}

	[Export("setArgument:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _SetArgument(IntPtr buffer, nint index)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selSetArgument_AtIndex_Handle, buffer, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selSetArgument_AtIndex_Handle, buffer, index);
		}
	}

	[Export("setReturnValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _SetReturnValue(IntPtr buffer)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetReturnValue_Handle, buffer);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetReturnValue_Handle, buffer);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Target_var = null;
		}
	}
}

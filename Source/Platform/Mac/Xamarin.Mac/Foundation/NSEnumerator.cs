using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSEnumerator", SkipRegistration = true)]
public sealed class NSEnumerator<TKey> : NSEnumerator where TKey : class, INativeObject
{
	public NSEnumerator()
	{
	}

	internal NSEnumerator(IntPtr handle)
		: base(handle)
	{
	}

	public new TKey NextObject()
	{
		return (TKey)(object)base.NextObject();
	}
}
[Register("NSEnumerator", true)]
public class NSEnumerator : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextObject = "nextObject";

	private static readonly IntPtr selNextObjectHandle = Selector.GetHandle("nextObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSEnumerator");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSEnumerator()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSEnumerator(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSEnumerator(IntPtr handle)
		: base(handle)
	{
	}

	[Export("nextObject")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject NextObject()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selNextObjectHandle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNextObjectHandle));
	}
}

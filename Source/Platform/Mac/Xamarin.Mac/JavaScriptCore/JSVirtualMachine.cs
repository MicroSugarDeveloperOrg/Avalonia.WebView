using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace JavaScriptCore;

[Register("JSVirtualMachine", true)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class JSVirtualMachine : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddManagedReference_WithOwner_ = "addManagedReference:withOwner:";

	private static readonly IntPtr selAddManagedReference_WithOwner_Handle = Selector.GetHandle("addManagedReference:withOwner:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveManagedReference_WithOwner_ = "removeManagedReference:withOwner:";

	private static readonly IntPtr selRemoveManagedReference_WithOwner_Handle = Selector.GetHandle("removeManagedReference:withOwner:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("JSVirtualMachine");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected JSVirtualMachine(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal JSVirtualMachine(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public JSVirtualMachine()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInitHandle), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitHandle), "init");
		}
	}

	[Export("addManagedReference:withOwner:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddManagedReference(NSObject obj, NSObject owner)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (owner == null)
		{
			throw new ArgumentNullException("owner");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddManagedReference_WithOwner_Handle, obj.Handle, owner.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddManagedReference_WithOwner_Handle, obj.Handle, owner.Handle);
		}
	}

	[Export("removeManagedReference:withOwner:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveManagedReference(NSObject obj, NSObject owner)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (owner == null)
		{
			throw new ArgumentNullException("owner");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRemoveManagedReference_WithOwner_Handle, obj.Handle, owner.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRemoveManagedReference_WithOwner_Handle, obj.Handle, owner.Handle);
		}
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

internal sealed class SCNActionableWrapper : BaseWrapper, ISCNActionable, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SCNActionableWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("runAction:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void RunAction(SCNAction action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("runAction:"), action.Handle);
	}

	[Export("runAction:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void RunAction(SCNAction action, [BlockProxy(typeof(Trampolines.NIDAction))] Action? block)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		BlockLiteral* ptr;
		if (block == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, block);
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("runAction:completionHandler:"), action.Handle, (IntPtr)ptr);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Export("runAction:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void RunAction(SCNAction action, string? key)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		IntPtr intPtr = NSString.CreateNative(key);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("runAction:forKey:"), action.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[Export("runAction:forKey:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void RunAction(SCNAction action, string? key, [BlockProxy(typeof(Trampolines.NIDAction))] Action? block)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		IntPtr intPtr = NSString.CreateNative(key);
		BlockLiteral* ptr;
		if (block == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, block);
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("runAction:forKey:completionHandler:"), action.Handle, intPtr, (IntPtr)ptr);
		NSString.ReleaseNative(intPtr);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Export("hasActions")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool HasActions()
	{
		return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("hasActions"));
	}

	[Export("actionForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SCNAction GetAction(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr intPtr = NSString.CreateNative(key);
		SCNAction nSObject = Runtime.GetNSObject<SCNAction>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("actionForKey:"), intPtr));
		NSString.ReleaseNative(intPtr);
		return nSObject;
	}

	[Export("removeActionForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void RemoveAction(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr intPtr = NSString.CreateNative(key);
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("removeActionForKey:"), intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[Export("removeAllActions")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void RemoveAllActions()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("removeAllActions"));
	}
}

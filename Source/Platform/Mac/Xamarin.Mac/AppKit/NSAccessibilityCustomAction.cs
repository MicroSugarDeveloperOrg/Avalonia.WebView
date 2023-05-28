using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSAccessibilityCustomAction", true)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class NSAccessibilityCustomAction : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHandler = "handler";

	private static readonly IntPtr selHandlerHandle = ObjCRuntime.Selector.GetHandle("handler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_Handler_ = "initWithName:handler:";

	private static readonly IntPtr selInitWithName_Handler_Handle = ObjCRuntime.Selector.GetHandle("initWithName:handler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithName_Target_Selector_ = "initWithName:target:selector:";

	private static readonly IntPtr selInitWithName_Target_Selector_Handle = ObjCRuntime.Selector.GetHandle("initWithName:target:selector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = ObjCRuntime.Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelector = "selector";

	private static readonly IntPtr selSelectorHandle = ObjCRuntime.Selector.GetHandle("selector");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHandler_ = "setHandler:";

	private static readonly IntPtr selSetHandler_Handle = ObjCRuntime.Selector.GetHandle("setHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = ObjCRuntime.Selector.GetHandle("setName:");

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
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSAccessibilityCustomAction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Target_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Func<bool>? Handler
	{
		[Export("handler", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDFuncArity1V0))]
		get
		{
			NSApplication.EnsureUIThread();
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHandlerHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selHandlerHandle));
			return Trampolines.NIDFuncArity1V0.Create(block);
		}
		[Export("setHandler:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDFuncArity1V0))]
		set
		{
			NSApplication.EnsureUIThread();
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDFuncArity1V0.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHandler_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHandler_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Name
	{
		[Export("name")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
		[Export("setName:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("It must conform to one of the following signatures: 'bool ActionMethod ()' or 'bool ActionMethod (NSAccessibilityCustomAction)' and be decorated with a corresponding [Export].")]
	public virtual Selector? Selector
	{
		[Export("selector", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return ObjCRuntime.Selector.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectorHandle));
			}
			return ObjCRuntime.Selector.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectorHandle));
		}
		[Export("setSelector:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSelector_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelector_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? Target
	{
		[Export("target", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTargetHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTargetHandle)));
			MarkDirty();
			__mt_Target_var = nSObject;
			return nSObject;
		}
		[Export("setTarget:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
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
	[Export("init")]
	public NSAccessibilityCustomAction()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, ObjCRuntime.Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, ObjCRuntime.Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSAccessibilityCustomAction(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSAccessibilityCustomAction(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithName:handler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe NSAccessibilityCustomAction(string name, [BlockProxy(typeof(Trampolines.NIDFuncArity1V0))] Func<bool>? handler)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		BlockLiteral* ptr;
		if (handler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDFuncArity1V0.Handler, handler);
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithName_Handler_Handle, arg, (IntPtr)ptr), "initWithName:handler:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithName_Handler_Handle, arg, (IntPtr)ptr), "initWithName:handler:");
		}
		NSString.ReleaseNative(arg);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Export("initWithName:target:selector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAccessibilityCustomAction(string name, NSObject target, Selector selector)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithName_Target_Selector_Handle, arg, target.Handle, selector.Handle), "initWithName:target:selector:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithName_Target_Selector_Handle, arg, target.Handle, selector.Handle), "initWithName:target:selector:");
		}
		NSString.ReleaseNative(arg);
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

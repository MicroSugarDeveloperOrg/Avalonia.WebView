using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSliderAccessoryBehavior", true)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class NSSliderAccessoryBehavior : NSObject, INSCoding, INativeObject, IDisposable, INSCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutomaticBehavior = "automaticBehavior";

	private static readonly IntPtr selAutomaticBehaviorHandle = Selector.GetHandle("automaticBehavior");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBehaviorWithHandler_ = "behaviorWithHandler:";

	private static readonly IntPtr selBehaviorWithHandler_Handle = Selector.GetHandle("behaviorWithHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBehaviorWithTarget_Action_ = "behaviorWithTarget:action:";

	private static readonly IntPtr selBehaviorWithTarget_Action_Handle = Selector.GetHandle("behaviorWithTarget:action:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHandleAction_ = "handleAction:";

	private static readonly IntPtr selHandleAction_Handle = Selector.GetHandle("handleAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueResetBehavior = "valueResetBehavior";

	private static readonly IntPtr selValueResetBehaviorHandle = Selector.GetHandle("valueResetBehavior");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueStepBehavior = "valueStepBehavior";

	private static readonly IntPtr selValueStepBehaviorHandle = Selector.GetHandle("valueStepBehavior");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSSliderAccessoryBehavior");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSSliderAccessoryBehavior AutomaticBehavior
	{
		[Export("automaticBehavior", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSSliderAccessoryBehavior>(Messaging.IntPtr_objc_msgSend(class_ptr, selAutomaticBehaviorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSSliderAccessoryBehavior ValueResetBehavior
	{
		[Export("valueResetBehavior", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSSliderAccessoryBehavior>(Messaging.IntPtr_objc_msgSend(class_ptr, selValueResetBehaviorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSSliderAccessoryBehavior ValueStepBehavior
	{
		[Export("valueStepBehavior", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSSliderAccessoryBehavior>(Messaging.IntPtr_objc_msgSend(class_ptr, selValueStepBehaviorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSliderAccessoryBehavior()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSSliderAccessoryBehavior(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSSliderAccessoryBehavior(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSliderAccessoryBehavior(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSApplication.EnsureUIThread();
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("behaviorWithTarget:action:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSSliderAccessoryBehavior CreateBehavior(NSObject? target, Selector action)
	{
		NSApplication.EnsureUIThread();
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		return Runtime.GetNSObject<NSSliderAccessoryBehavior>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selBehaviorWithTarget_Action_Handle, target?.Handle ?? IntPtr.Zero, action.Handle));
	}

	[Export("behaviorWithHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static NSSliderAccessoryBehavior CreateBehavior([BlockProxy(typeof(Trampolines.NIDActionArity1V12))] Action<NSSliderAccessory> handler)
	{
		NSApplication.EnsureUIThread();
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V12.Handler, handler);
		NSSliderAccessoryBehavior nSObject = Runtime.GetNSObject<NSSliderAccessoryBehavior>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selBehaviorWithHandler_Handle, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("handleAction:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void HandleAction(NSSliderAccessory sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selHandleAction_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selHandleAction_Handle, sender.Handle);
		}
	}
}

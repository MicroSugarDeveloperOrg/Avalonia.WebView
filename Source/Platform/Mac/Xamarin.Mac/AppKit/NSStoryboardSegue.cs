using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSStoryboardSegue", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NSStoryboardSegue : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationController = "destinationController";

	private static readonly IntPtr selDestinationControllerHandle = Selector.GetHandle("destinationController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIdentifier_Source_Destination_ = "initWithIdentifier:source:destination:";

	private static readonly IntPtr selInitWithIdentifier_Source_Destination_Handle = Selector.GetHandle("initWithIdentifier:source:destination:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerform = "perform";

	private static readonly IntPtr selPerformHandle = Selector.GetHandle("perform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSegueWithIdentifier_Source_Destination_PerformHandler_ = "segueWithIdentifier:source:destination:performHandler:";

	private static readonly IntPtr selSegueWithIdentifier_Source_Destination_PerformHandler_Handle = Selector.GetHandle("segueWithIdentifier:source:destination:performHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceController = "sourceController";

	private static readonly IntPtr selSourceControllerHandle = Selector.GetHandle("sourceController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSStoryboardSegue");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject DestinationController
	{
		[Export("destinationController", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDestinationControllerHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDestinationControllerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Identifier
	{
		[Export("identifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject SourceController
	{
		[Export("sourceController", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceControllerHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceControllerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSStoryboardSegue()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSStoryboardSegue(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSStoryboardSegue(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithIdentifier:source:destination:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSStoryboardSegue(string identifier, NSObject sourceController, NSObject destinationController)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (sourceController == null)
		{
			throw new ArgumentNullException("sourceController");
		}
		if (destinationController == null)
		{
			throw new ArgumentNullException("destinationController");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithIdentifier_Source_Destination_Handle, arg, sourceController.Handle, destinationController.Handle), "initWithIdentifier:source:destination:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithIdentifier_Source_Destination_Handle, arg, sourceController.Handle, destinationController.Handle), "initWithIdentifier:source:destination:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("segueWithIdentifier:source:destination:performHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static NSStoryboardSegue FromIdentifier(string identifier, NSObject sourceController, NSObject destinationController, [BlockProxy(typeof(Trampolines.NIDAction))] Action performHandler)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (sourceController == null)
		{
			throw new ArgumentNullException("sourceController");
		}
		if (destinationController == null)
		{
			throw new ArgumentNullException("destinationController");
		}
		if (performHandler == null)
		{
			throw new ArgumentNullException("performHandler");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, performHandler);
		NSStoryboardSegue nSObject = Runtime.GetNSObject<NSStoryboardSegue>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(class_ptr, selSegueWithIdentifier_Source_Destination_PerformHandler_Handle, arg, sourceController.Handle, destinationController.Handle, (IntPtr)ptr));
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
		return nSObject;
	}

	[Export("perform")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Perform()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPerformHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPerformHandle);
		}
	}
}

using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace FileProviderUI;

[Register("FPUIActionExtensionViewController", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class FPUIActionExtensionViewController : NSViewController
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtensionContext = "extensionContext";

	private static readonly IntPtr selExtensionContextHandle = Selector.GetHandle("extensionContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithNibName_Bundle_ = "initWithNibName:bundle:";

	private static readonly IntPtr selInitWithNibName_Bundle_Handle = Selector.GetHandle("initWithNibName:bundle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareForActionWithIdentifier_ItemIdentifiers_ = "prepareForActionWithIdentifier:itemIdentifiers:";

	private static readonly IntPtr selPrepareForActionWithIdentifier_ItemIdentifiers_Handle = Selector.GetHandle("prepareForActionWithIdentifier:itemIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareForError_ = "prepareForError:";

	private static readonly IntPtr selPrepareForError_Handle = Selector.GetHandle("prepareForError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("FPUIActionExtensionViewController");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual FPUIActionExtensionContext ExtensionContext
	{
		[Export("extensionContext", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<FPUIActionExtensionContext>(Messaging.IntPtr_objc_msgSend(base.Handle, selExtensionContextHandle));
			}
			return Runtime.GetNSObject<FPUIActionExtensionContext>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExtensionContextHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public FPUIActionExtensionViewController()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public FPUIActionExtensionViewController(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
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
	protected FPUIActionExtensionViewController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal FPUIActionExtensionViewController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithNibName:bundle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public FPUIActionExtensionViewController(string? nibName, NSBundle? bundle)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = NSString.CreateNative(nibName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithNibName_Bundle_Handle, arg, bundle?.Handle ?? IntPtr.Zero), "initWithNibName:bundle:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithNibName_Bundle_Handle, arg, bundle?.Handle ?? IntPtr.Zero), "initWithNibName:bundle:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("prepareForError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Prepare(NSError error)
	{
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPrepareForError_Handle, error.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPrepareForError_Handle, error.Handle);
		}
	}

	[Export("prepareForActionWithIdentifier:itemIdentifiers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Prepare(string actionIdentifier, NSString[] itemIdentifiers)
	{
		if (actionIdentifier == null)
		{
			throw new ArgumentNullException("actionIdentifier");
		}
		if (itemIdentifiers == null)
		{
			throw new ArgumentNullException("itemIdentifiers");
		}
		IntPtr arg = NSString.CreateNative(actionIdentifier);
		NSArray nSArray = NSArray.FromNSObjects(itemIdentifiers);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selPrepareForActionWithIdentifier_ItemIdentifiers_Handle, arg, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPrepareForActionWithIdentifier_ItemIdentifiers_Handle, arg, nSArray.Handle);
		}
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSStoryboard", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NSStoryboard : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInstantiateControllerWithIdentifier_ = "instantiateControllerWithIdentifier:";

	private static readonly IntPtr selInstantiateControllerWithIdentifier_Handle = Selector.GetHandle("instantiateControllerWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInstantiateControllerWithIdentifier_Creator_ = "instantiateControllerWithIdentifier:creator:";

	private static readonly IntPtr selInstantiateControllerWithIdentifier_Creator_Handle = Selector.GetHandle("instantiateControllerWithIdentifier:creator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInstantiateInitialController = "instantiateInitialController";

	private static readonly IntPtr selInstantiateInitialControllerHandle = Selector.GetHandle("instantiateInitialController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInstantiateInitialControllerWithCreator_ = "instantiateInitialControllerWithCreator:";

	private static readonly IntPtr selInstantiateInitialControllerWithCreator_Handle = Selector.GetHandle("instantiateInitialControllerWithCreator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMainStoryboard = "mainStoryboard";

	private static readonly IntPtr selMainStoryboardHandle = Selector.GetHandle("mainStoryboard");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStoryboardWithName_Bundle_ = "storyboardWithName:bundle:";

	private static readonly IntPtr selStoryboardWithName_Bundle_Handle = Selector.GetHandle("storyboardWithName:bundle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSStoryboard");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static NSStoryboard? MainStoryboard
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("mainStoryboard", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSStoryboard>(Messaging.IntPtr_objc_msgSend(class_ptr, selMainStoryboardHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSStoryboard()
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
	protected NSStoryboard(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSStoryboard(IntPtr handle)
		: base(handle)
	{
	}

	[Export("storyboardWithName:bundle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSStoryboard FromName(string name, NSBundle? storyboardBundleOrNil)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSStoryboard nSObject = Runtime.GetNSObject<NSStoryboard>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selStoryboardWithName_Bundle_Handle, arg, storyboardBundleOrNil?.Handle ?? IntPtr.Zero));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("instantiateControllerWithIdentifier:creator:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSViewController InstantiateController(string identifier, [BlockProxy(typeof(Trampolines.NIDNSStoryboardControllerCreator))] NSStoryboardControllerCreator? handler)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		BlockLiteral* ptr;
		if (handler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDNSStoryboardControllerCreator.Handler, handler);
		}
		NSViewController result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInstantiateControllerWithIdentifier_Creator_Handle, arg, (IntPtr)ptr)) : Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInstantiateControllerWithIdentifier_Creator_Handle, arg, (IntPtr)ptr)));
		NSString.ReleaseNative(arg);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
		return result;
	}

	[Export("instantiateControllerWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject InstantiateControllerWithIdentifier(string identifier)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInstantiateControllerWithIdentifier_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInstantiateControllerWithIdentifier_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("instantiateInitialController")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject InstantiateInitialController()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selInstantiateInitialControllerHandle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInstantiateInitialControllerHandle));
	}

	[Export("instantiateInitialControllerWithCreator:")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSViewController? InstantiateInitialController([BlockProxy(typeof(Trampolines.NIDNSStoryboardControllerCreator))] NSStoryboardControllerCreator? handler)
	{
		NSApplication.EnsureUIThread();
		BlockLiteral* ptr;
		if (handler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDNSStoryboardControllerCreator.Handler, handler);
		}
		NSViewController result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInstantiateInitialControllerWithCreator_Handle, (IntPtr)ptr)) : Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInstantiateInitialControllerWithCreator_Handle, (IntPtr)ptr)));
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
		return result;
	}
}

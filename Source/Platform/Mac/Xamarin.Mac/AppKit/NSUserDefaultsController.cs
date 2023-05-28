using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSUserDefaultsController", true)]
public class NSUserDefaultsController : NSController
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppliesImmediately = "appliesImmediately";

	private static readonly IntPtr selAppliesImmediatelyHandle = Selector.GetHandle("appliesImmediately");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaults = "defaults";

	private static readonly IntPtr selDefaultsHandle = Selector.GetHandle("defaults");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasUnappliedChanges = "hasUnappliedChanges";

	private static readonly IntPtr selHasUnappliedChangesHandle = Selector.GetHandle("hasUnappliedChanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDefaults_InitialValues_ = "initWithDefaults:initialValues:";

	private static readonly IntPtr selInitWithDefaults_InitialValues_Handle = Selector.GetHandle("initWithDefaults:initialValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitialValues = "initialValues";

	private static readonly IntPtr selInitialValuesHandle = Selector.GetHandle("initialValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRevert_ = "revert:";

	private static readonly IntPtr selRevert_Handle = Selector.GetHandle("revert:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRevertToInitialValues_ = "revertToInitialValues:";

	private static readonly IntPtr selRevertToInitialValues_Handle = Selector.GetHandle("revertToInitialValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSave_ = "save:";

	private static readonly IntPtr selSave_Handle = Selector.GetHandle("save:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAppliesImmediately_ = "setAppliesImmediately:";

	private static readonly IntPtr selSetAppliesImmediately_Handle = Selector.GetHandle("setAppliesImmediately:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInitialValues_ = "setInitialValues:";

	private static readonly IntPtr selSetInitialValues_Handle = Selector.GetHandle("setInitialValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedUserDefaultsController = "sharedUserDefaultsController";

	private static readonly IntPtr selSharedUserDefaultsControllerHandle = Selector.GetHandle("sharedUserDefaultsController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValues = "values";

	private static readonly IntPtr selValuesHandle = Selector.GetHandle("values");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSUserDefaultsController");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AppliesImmediately
	{
		[Export("appliesImmediately")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAppliesImmediatelyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAppliesImmediatelyHandle);
		}
		[Export("setAppliesImmediately:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAppliesImmediately_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAppliesImmediately_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUserDefaults Defaults
	{
		[Export("defaults", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUserDefaults>(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultsHandle));
			}
			return Runtime.GetNSObject<NSUserDefaults>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasUnappliedChanges
	{
		[Export("hasUnappliedChanges")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasUnappliedChangesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasUnappliedChangesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary InitialValues
	{
		[Export("initialValues", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selInitialValuesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitialValuesHandle));
		}
		[Export("setInitialValues:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInitialValues_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInitialValues_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUserDefaultsController SharedUserDefaultsController
	{
		[Export("sharedUserDefaultsController")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSUserDefaultsController>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedUserDefaultsControllerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject Values
	{
		[Export("values", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selValuesHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValuesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUserDefaultsController()
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
	public NSUserDefaultsController(NSCoder coder)
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
	protected NSUserDefaultsController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUserDefaultsController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDefaults:initialValues:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUserDefaultsController(NSUserDefaults? defaults, NSDictionary? initialValues)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDefaults_InitialValues_Handle, defaults?.Handle ?? IntPtr.Zero, initialValues?.Handle ?? IntPtr.Zero), "initWithDefaults:initialValues:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDefaults_InitialValues_Handle, defaults?.Handle ?? IntPtr.Zero, initialValues?.Handle ?? IntPtr.Zero), "initWithDefaults:initialValues:");
		}
	}

	[Export("revert:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Revert(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRevert_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRevert_Handle, sender.Handle);
		}
	}

	[Export("revertToInitialValues:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RevertToInitialValues(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRevertToInitialValues_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRevertToInitialValues_Handle, sender.Handle);
		}
	}

	[Export("save:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Save(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSave_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSave_Handle, sender.Handle);
		}
	}
}

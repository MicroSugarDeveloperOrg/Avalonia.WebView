using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INStartVideoCallIntent", true)]
[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'INStartCallIntent' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'INStartCallIntent' instead.")]
[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'INStartCallIntent' instead.")]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class INStartVideoCallIntent : INIntent
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContacts = "contacts";

	private static readonly IntPtr selContactsHandle = Selector.GetHandle("contacts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContacts_ = "initWithContacts:";

	private static readonly IntPtr selInitWithContacts_Handle = Selector.GetHandle("initWithContacts:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INStartVideoCallIntent");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INPerson[]? Contacts
	{
		[Export("contacts", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<INPerson>(Messaging.IntPtr_objc_msgSend(base.Handle, selContactsHandle));
			}
			return NSArray.ArrayFromHandle<INPerson>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContactsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public INStartVideoCallIntent()
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
	public INStartVideoCallIntent(NSCoder coder)
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
	protected INStartVideoCallIntent(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INStartVideoCallIntent(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithContacts:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INStartVideoCallIntent(INPerson[]? contacts)
		: base(NSObjectFlag.Empty)
	{
		NSArray nSArray = ((contacts == null) ? null : NSArray.FromNSObjects(contacts));
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithContacts_Handle, nSArray?.Handle ?? IntPtr.Zero), "initWithContacts:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithContacts_Handle, nSArray?.Handle ?? IntPtr.Zero), "initWithContacts:");
		}
		nSArray?.Dispose();
	}
}

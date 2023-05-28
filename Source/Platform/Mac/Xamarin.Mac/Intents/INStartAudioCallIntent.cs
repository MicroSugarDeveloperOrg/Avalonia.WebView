using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INStartAudioCallIntent", true)]
[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'INStartCallIntent' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'INStartCallIntent' instead.")]
[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'INStartCallIntent' instead.")]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
public class INStartAudioCallIntent : INIntent
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContacts = "contacts";

	private static readonly IntPtr selContactsHandle = Selector.GetHandle("contacts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationType = "destinationType";

	private static readonly IntPtr selDestinationTypeHandle = Selector.GetHandle("destinationType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContacts_ = "initWithContacts:";

	private static readonly IntPtr selInitWithContacts_Handle = Selector.GetHandle("initWithContacts:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDestinationType_Contacts_ = "initWithDestinationType:contacts:";

	private static readonly IntPtr selInitWithDestinationType_Contacts_Handle = Selector.GetHandle("initWithDestinationType:contacts:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INStartAudioCallIntent");

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
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual INCallDestinationType DestinationType
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("destinationType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (INCallDestinationType)Messaging.Int64_objc_msgSend(base.Handle, selDestinationTypeHandle);
			}
			return (INCallDestinationType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDestinationTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public INStartAudioCallIntent()
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
	public INStartAudioCallIntent(NSCoder coder)
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
	protected INStartAudioCallIntent(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INStartAudioCallIntent(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithContacts:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use '.ctor (INCallDestinationType, INPerson [])' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use '.ctor (INCallDestinationType, INPerson [])' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use '.ctor (INCallDestinationType, INPerson [])' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INStartAudioCallIntent(INPerson[]? contacts)
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

	[Export("initWithDestinationType:contacts:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INStartAudioCallIntent(INCallDestinationType destinationType, INPerson[]? contacts)
		: base(NSObjectFlag.Empty)
	{
		NSArray nSArray = ((contacts == null) ? null : NSArray.FromNSObjects(contacts));
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_Int64_IntPtr(base.Handle, selInitWithDestinationType_Contacts_Handle, (long)destinationType, nSArray?.Handle ?? IntPtr.Zero), "initWithDestinationType:contacts:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Int64_IntPtr(base.SuperHandle, selInitWithDestinationType_Contacts_Handle, (long)destinationType, nSArray?.Handle ?? IntPtr.Zero), "initWithDestinationType:contacts:");
		}
		nSArray?.Dispose();
	}
}

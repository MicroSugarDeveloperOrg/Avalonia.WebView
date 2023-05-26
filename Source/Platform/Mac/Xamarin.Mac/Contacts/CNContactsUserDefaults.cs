using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace Contacts;

[Register("CNContactsUserDefaults", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class CNContactsUserDefaults : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCountryCode = "countryCode";

	private static readonly IntPtr selCountryCodeHandle = Selector.GetHandle("countryCode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedDefaults = "sharedDefaults";

	private static readonly IntPtr selSharedDefaultsHandle = Selector.GetHandle("sharedDefaults");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSortOrder = "sortOrder";

	private static readonly IntPtr selSortOrderHandle = Selector.GetHandle("sortOrder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CNContactsUserDefaults");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CountryCode
	{
		[Export("countryCode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCountryCodeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCountryCodeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CNContactSortOrder SortOrder
	{
		[Export("sortOrder")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (CNContactSortOrder)Messaging.Int64_objc_msgSend(base.Handle, selSortOrderHandle);
			}
			return (CNContactSortOrder)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSortOrderHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CNContactsUserDefaults()
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
	protected CNContactsUserDefaults(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CNContactsUserDefaults(IntPtr handle)
		: base(handle)
	{
	}

	[Export("sharedDefaults")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CNContactsUserDefaults GetSharedDefaults()
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<CNContactsUserDefaults>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedDefaultsHandle));
	}
}

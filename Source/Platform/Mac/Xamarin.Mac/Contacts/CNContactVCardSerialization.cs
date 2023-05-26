using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Contacts;

[Register("CNContactVCardSerialization", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class CNContactVCardSerialization : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContactsWithData_Error_ = "contactsWithData:error:";

	private static readonly IntPtr selContactsWithData_Error_Handle = Selector.GetHandle("contactsWithData:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataWithContacts_Error_ = "dataWithContacts:error:";

	private static readonly IntPtr selDataWithContacts_Error_Handle = Selector.GetHandle("dataWithContacts:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptorForRequiredKeys = "descriptorForRequiredKeys";

	private static readonly IntPtr selDescriptorForRequiredKeysHandle = Selector.GetHandle("descriptorForRequiredKeys");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CNContactVCardSerialization");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CNContactVCardSerialization()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CNContactVCardSerialization(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CNContactVCardSerialization(IntPtr handle)
		: base(handle)
	{
	}

	[Export("contactsWithData:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CNContact[]? GetContactsFromData(NSData data, out NSError error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		CNContact[] result = NSArray.ArrayFromHandle<CNContact>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selContactsWithData_Error_Handle, data.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("dataWithContacts:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData? GetDataFromContacts(CNContact[] contacts, out NSError error)
	{
		if (contacts == null)
		{
			throw new ArgumentNullException("contacts");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(contacts);
		NSData nSObject = Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selDataWithContacts_Error_Handle, nSArray.Handle, ref arg));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("descriptorForRequiredKeys")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static ICNKeyDescriptor GetDescriptorFromRequiredKeys()
	{
		return Runtime.GetINativeObject<ICNKeyDescriptor>(Messaging.IntPtr_objc_msgSend(class_ptr, selDescriptorForRequiredKeysHandle), owns: false);
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Contacts;

[Register("CNSaveRequest", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class CNSaveRequest : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddContact_ToContainerWithIdentifier_ = "addContact:toContainerWithIdentifier:";

	private static readonly IntPtr selAddContact_ToContainerWithIdentifier_Handle = Selector.GetHandle("addContact:toContainerWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddGroup_ToContainerWithIdentifier_ = "addGroup:toContainerWithIdentifier:";

	private static readonly IntPtr selAddGroup_ToContainerWithIdentifier_Handle = Selector.GetHandle("addGroup:toContainerWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddMember_ToGroup_ = "addMember:toGroup:";

	private static readonly IntPtr selAddMember_ToGroup_Handle = Selector.GetHandle("addMember:toGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddSubgroup_ToGroup_ = "addSubgroup:toGroup:";

	private static readonly IntPtr selAddSubgroup_ToGroup_Handle = Selector.GetHandle("addSubgroup:toGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteContact_ = "deleteContact:";

	private static readonly IntPtr selDeleteContact_Handle = Selector.GetHandle("deleteContact:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteGroup_ = "deleteGroup:";

	private static readonly IntPtr selDeleteGroup_Handle = Selector.GetHandle("deleteGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveMember_FromGroup_ = "removeMember:fromGroup:";

	private static readonly IntPtr selRemoveMember_FromGroup_Handle = Selector.GetHandle("removeMember:fromGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveSubgroup_FromGroup_ = "removeSubgroup:fromGroup:";

	private static readonly IntPtr selRemoveSubgroup_FromGroup_Handle = Selector.GetHandle("removeSubgroup:fromGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateContact_ = "updateContact:";

	private static readonly IntPtr selUpdateContact_Handle = Selector.GetHandle("updateContact:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateGroup_ = "updateGroup:";

	private static readonly IntPtr selUpdateGroup_Handle = Selector.GetHandle("updateGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CNSaveRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CNSaveRequest()
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
	protected CNSaveRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CNSaveRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addContact:toContainerWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddContact(CNMutableContact contact, string? identifier)
	{
		if (contact == null)
		{
			throw new ArgumentNullException("contact");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddContact_ToContainerWithIdentifier_Handle, contact.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddContact_ToContainerWithIdentifier_Handle, contact.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("addGroup:toContainerWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddGroup(CNMutableGroup group, string? identifier)
	{
		if (group == null)
		{
			throw new ArgumentNullException("group");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddGroup_ToContainerWithIdentifier_Handle, group.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddGroup_ToContainerWithIdentifier_Handle, group.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("addMember:toGroup:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddMember(CNContact contact, CNGroup group)
	{
		if (contact == null)
		{
			throw new ArgumentNullException("contact");
		}
		if (group == null)
		{
			throw new ArgumentNullException("group");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddMember_ToGroup_Handle, contact.Handle, group.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddMember_ToGroup_Handle, contact.Handle, group.Handle);
		}
	}

	[Export("addSubgroup:toGroup:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddSubgroup(CNGroup subgroup, CNGroup group)
	{
		if (subgroup == null)
		{
			throw new ArgumentNullException("subgroup");
		}
		if (group == null)
		{
			throw new ArgumentNullException("group");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddSubgroup_ToGroup_Handle, subgroup.Handle, group.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddSubgroup_ToGroup_Handle, subgroup.Handle, group.Handle);
		}
	}

	[Export("deleteContact:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeleteContact(CNMutableContact contact)
	{
		if (contact == null)
		{
			throw new ArgumentNullException("contact");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDeleteContact_Handle, contact.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDeleteContact_Handle, contact.Handle);
		}
	}

	[Export("deleteGroup:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeleteGroup(CNMutableGroup group)
	{
		if (group == null)
		{
			throw new ArgumentNullException("group");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDeleteGroup_Handle, group.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDeleteGroup_Handle, group.Handle);
		}
	}

	[Export("removeMember:fromGroup:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveMember(CNContact contact, CNGroup group)
	{
		if (contact == null)
		{
			throw new ArgumentNullException("contact");
		}
		if (group == null)
		{
			throw new ArgumentNullException("group");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRemoveMember_FromGroup_Handle, contact.Handle, group.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRemoveMember_FromGroup_Handle, contact.Handle, group.Handle);
		}
	}

	[Export("removeSubgroup:fromGroup:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveSubgroup(CNGroup subgroup, CNGroup group)
	{
		if (subgroup == null)
		{
			throw new ArgumentNullException("subgroup");
		}
		if (group == null)
		{
			throw new ArgumentNullException("group");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRemoveSubgroup_FromGroup_Handle, subgroup.Handle, group.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRemoveSubgroup_FromGroup_Handle, subgroup.Handle, group.Handle);
		}
	}

	[Export("updateContact:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateContact(CNMutableContact contact)
	{
		if (contact == null)
		{
			throw new ArgumentNullException("contact");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUpdateContact_Handle, contact.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUpdateContact_Handle, contact.Handle);
		}
	}

	[Export("updateGroup:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateGroup(CNMutableGroup group)
	{
		if (group == null)
		{
			throw new ArgumentNullException("group");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUpdateGroup_Handle, group.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUpdateGroup_Handle, group.Handle);
		}
	}
}

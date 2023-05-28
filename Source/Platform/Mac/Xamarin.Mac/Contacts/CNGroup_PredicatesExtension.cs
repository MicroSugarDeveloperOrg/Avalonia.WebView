using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Contacts;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public static class CNGroup_PredicatesExtension
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateForGroupsInContainerWithIdentifier_ = "predicateForGroupsInContainerWithIdentifier:";

	private static readonly IntPtr selPredicateForGroupsInContainerWithIdentifier_Handle = Selector.GetHandle("predicateForGroupsInContainerWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateForGroupsWithIdentifiers_ = "predicateForGroupsWithIdentifiers:";

	private static readonly IntPtr selPredicateForGroupsWithIdentifiers_Handle = Selector.GetHandle("predicateForGroupsWithIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateForSubgroupsInGroupWithIdentifier_ = "predicateForSubgroupsInGroupWithIdentifier:";

	private static readonly IntPtr selPredicateForSubgroupsInGroupWithIdentifier_Handle = Selector.GetHandle("predicateForSubgroupsInGroupWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("CNGroup");

	[Export("predicateForGroupsWithIdentifiers:")]
	[Obsolete("Use 'CNGroup.CreatePredicateForGroups' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPredicate GetPredicateForGroups(this CNGroup This, string[] identifiers)
	{
		if (identifiers == null)
		{
			throw new ArgumentNullException("identifiers");
		}
		NSArray nSArray = NSArray.FromStrings(identifiers);
		NSPredicate nSObject = Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPredicateForGroupsWithIdentifiers_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("predicateForGroupsInContainerWithIdentifier:")]
	[Obsolete("Use 'CNGroup.CreatePredicateForGroupsInContainer' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPredicate GetPredicateForGroupsInContainer(this CNGroup This, string containerIdentifier)
	{
		if (containerIdentifier == null)
		{
			throw new ArgumentNullException("containerIdentifier");
		}
		IntPtr intPtr = NSString.CreateNative(containerIdentifier);
		NSPredicate nSObject = Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPredicateForGroupsInContainerWithIdentifier_Handle, intPtr));
		NSString.ReleaseNative(intPtr);
		return nSObject;
	}

	[Export("predicateForSubgroupsInGroupWithIdentifier:")]
	[Obsolete("Use 'CNGroup.CreatePredicateForSubgroupsInGroup' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPredicate GetPredicateForSubgroupsInGroup(this CNGroup This, string parentGroupIdentifier)
	{
		if (parentGroupIdentifier == null)
		{
			throw new ArgumentNullException("parentGroupIdentifier");
		}
		IntPtr intPtr = NSString.CreateNative(parentGroupIdentifier);
		NSPredicate nSObject = Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPredicateForSubgroupsInGroupWithIdentifier_Handle, intPtr));
		NSString.ReleaseNative(intPtr);
		return nSObject;
	}
}

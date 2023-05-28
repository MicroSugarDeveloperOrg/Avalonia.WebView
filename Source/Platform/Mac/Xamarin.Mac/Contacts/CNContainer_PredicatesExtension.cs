using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Contacts;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public static class CNContainer_PredicatesExtension
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateForContainerOfContactWithIdentifier_ = "predicateForContainerOfContactWithIdentifier:";

	private static readonly IntPtr selPredicateForContainerOfContactWithIdentifier_Handle = Selector.GetHandle("predicateForContainerOfContactWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateForContainerOfGroupWithIdentifier_ = "predicateForContainerOfGroupWithIdentifier:";

	private static readonly IntPtr selPredicateForContainerOfGroupWithIdentifier_Handle = Selector.GetHandle("predicateForContainerOfGroupWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicateForContainersWithIdentifiers_ = "predicateForContainersWithIdentifiers:";

	private static readonly IntPtr selPredicateForContainersWithIdentifiers_Handle = Selector.GetHandle("predicateForContainersWithIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("CNContainer");

	[Export("predicateForContainerOfContactWithIdentifier:")]
	[Obsolete("Use 'CNContainer.CreatePredicateForContainerOfContact' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPredicate GetPredicateForContainerOfContact(this CNContainer This, string contactIdentifier)
	{
		if (contactIdentifier == null)
		{
			throw new ArgumentNullException("contactIdentifier");
		}
		IntPtr intPtr = NSString.CreateNative(contactIdentifier);
		NSPredicate nSObject = Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPredicateForContainerOfContactWithIdentifier_Handle, intPtr));
		NSString.ReleaseNative(intPtr);
		return nSObject;
	}

	[Export("predicateForContainerOfGroupWithIdentifier:")]
	[Obsolete("Use 'CNContainer.CreatePredicateForContainerOfGroup' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPredicate GetPredicateForContainerOfGroup(this CNContainer This, string groupIdentifier)
	{
		if (groupIdentifier == null)
		{
			throw new ArgumentNullException("groupIdentifier");
		}
		IntPtr intPtr = NSString.CreateNative(groupIdentifier);
		NSPredicate nSObject = Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPredicateForContainerOfGroupWithIdentifier_Handle, intPtr));
		NSString.ReleaseNative(intPtr);
		return nSObject;
	}

	[Export("predicateForContainersWithIdentifiers:")]
	[Obsolete("Use 'CNContainer.CreatePredicateForContainers' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPredicate GetPredicateForContainers(this CNContainer This, string[] identifiers)
	{
		if (identifiers == null)
		{
			throw new ArgumentNullException("identifiers");
		}
		NSArray nSArray = NSArray.FromStrings(identifiers);
		NSPredicate nSObject = Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPredicateForContainersWithIdentifiers_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}
}

using System;
using ObjCRuntime;

namespace Foundation;

public static class NSPredicateSupport_NSOrderedSet
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilteredOrderedSetUsingPredicate_ = "filteredOrderedSetUsingPredicate:";

	private static readonly IntPtr selFilteredOrderedSetUsingPredicate_Handle = Selector.GetHandle("filteredOrderedSetUsingPredicate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSOrderedSet");

	[Export("filteredOrderedSetUsingPredicate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSOrderedSet FilterUsingPredicate(this NSOrderedSet This, NSPredicate p)
	{
		if (p == null)
		{
			throw new ArgumentNullException("p");
		}
		return Runtime.GetNSObject<NSOrderedSet>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, selFilteredOrderedSetUsingPredicate_Handle, p.Handle));
	}
}

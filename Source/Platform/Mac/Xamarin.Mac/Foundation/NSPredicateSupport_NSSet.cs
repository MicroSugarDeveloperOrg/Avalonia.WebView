using System;
using ObjCRuntime;

namespace Foundation;

public static class NSPredicateSupport_NSSet
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilteredSetUsingPredicate_ = "filteredSetUsingPredicate:";

	private static readonly IntPtr selFilteredSetUsingPredicate_Handle = Selector.GetHandle("filteredSetUsingPredicate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSSet");

	[Export("filteredSetUsingPredicate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSSet FilterUsingPredicate(this NSSet This, NSPredicate predicate)
	{
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, selFilteredSetUsingPredicate_Handle, predicate.Handle));
	}
}

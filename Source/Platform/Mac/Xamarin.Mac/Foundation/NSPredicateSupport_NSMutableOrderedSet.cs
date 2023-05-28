using System;
using ObjCRuntime;

namespace Foundation;

public static class NSPredicateSupport_NSMutableOrderedSet
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilterUsingPredicate_ = "filterUsingPredicate:";

	private static readonly IntPtr selFilterUsingPredicate_Handle = Selector.GetHandle("filterUsingPredicate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSMutableOrderedSet");

	[Export("filterUsingPredicate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FilterUsingPredicate(this NSMutableOrderedSet This, NSPredicate p)
	{
		if (p == null)
		{
			throw new ArgumentNullException("p");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, selFilterUsingPredicate_Handle, p.Handle);
	}
}

using System;
using ObjCRuntime;

namespace Foundation;

public static class NSPredicateSupport_NSArray
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilteredArrayUsingPredicate_ = "filteredArrayUsingPredicate:";

	private static readonly IntPtr selFilteredArrayUsingPredicate_Handle = Selector.GetHandle("filteredArrayUsingPredicate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSArray");

	[Export("filteredArrayUsingPredicate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSArray FilterUsingPredicate(this NSArray This, NSArray array)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, selFilteredArrayUsingPredicate_Handle, array.Handle));
	}
}

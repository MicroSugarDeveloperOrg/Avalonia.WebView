using System;
using ObjCRuntime;

namespace Foundation;

public static class NSKeyValueSorting_NSMutableOrderedSet
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSortUsingDescriptors_ = "sortUsingDescriptors:";

	private static readonly IntPtr selSortUsingDescriptors_Handle = Selector.GetHandle("sortUsingDescriptors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSMutableOrderedSet");

	[Export("sortUsingDescriptors:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SortUsingDescriptors(this NSMutableOrderedSet This, NSSortDescriptor[] sortDescriptors)
	{
		if (sortDescriptors == null)
		{
			throw new ArgumentNullException("sortDescriptors");
		}
		NSArray nSArray = NSArray.FromNSObjects(sortDescriptors);
		Messaging.void_objc_msgSend_IntPtr(This.Handle, selSortUsingDescriptors_Handle, nSArray.Handle);
		nSArray.Dispose();
	}
}

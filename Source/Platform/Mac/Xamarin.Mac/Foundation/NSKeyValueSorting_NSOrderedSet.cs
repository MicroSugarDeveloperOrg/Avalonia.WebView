using System;
using ObjCRuntime;

namespace Foundation;

public static class NSKeyValueSorting_NSOrderedSet
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSortedArrayUsingDescriptors_ = "sortedArrayUsingDescriptors:";

	private static readonly IntPtr selSortedArrayUsingDescriptors_Handle = Selector.GetHandle("sortedArrayUsingDescriptors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSOrderedSet");

	[Export("sortedArrayUsingDescriptors:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject[] GetSortedArray(this NSOrderedSet This, NSSortDescriptor[] sortDescriptors)
	{
		if (sortDescriptors == null)
		{
			throw new ArgumentNullException("sortDescriptors");
		}
		NSArray nSArray = NSArray.FromNSObjects(sortDescriptors);
		NSObject[] result = NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, selSortedArrayUsingDescriptors_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}
}

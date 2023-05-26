using System;
using Foundation;

namespace AddressBook;

public class ABMutableMultiValue<T> : ABMultiValue<T>
{
	public override bool IsReadOnly
	{
		get
		{
			AssertValid();
			return false;
		}
	}

	internal ABMutableMultiValue(IntPtr handle)
		: base(handle)
	{
	}

	internal ABMutableMultiValue(IntPtr handle, Converter<IntPtr, T> toManaged, Converter<T, IntPtr> toNative)
		: base(handle, toManaged, toNative)
	{
	}

	public bool Add(T value, NSString label)
	{
		int outIdentifier;
		return ABMultiValue.AddValueAndLabel(base.Handle, toNative(value), ABMultiValue.ToIntPtr(label), out outIdentifier);
	}

	public bool Insert(int index, T value, NSString label)
	{
		int outIdentifier;
		return ABMultiValue.InsertValueAndLabelAtIndex(base.Handle, toNative(value), ABMultiValue.ToIntPtr(label), index, out outIdentifier);
	}

	public bool RemoveAt(int index)
	{
		return ABMultiValue.RemoveValueAndLabelAtIndex(base.Handle, index);
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace AddressBook;

public struct ABMultiValueEntry<T>
{
	private ABMultiValue<T> self;

	private int index;

	public bool IsReadOnly => self.IsReadOnly;

	public T Value
	{
		get
		{
			AssertValid();
			return self.toManaged(ABMultiValue.CopyValueAtIndex(self.Handle, index));
		}
		set
		{
			if (IsReadOnly)
			{
				throw CreateNotSupportedException();
			}
			AssertValid();
			if (!ABMultiValue.ReplaceValueAtIndex(self.Handle, ToIntPtr(value), index))
			{
				throw new ArgumentException("Value cannot be set");
			}
		}
	}

	public NSString Label
	{
		get
		{
			AssertValid();
			return (NSString)Runtime.GetNSObject(ABMultiValue.CopyLabelAtIndex(self.Handle, index));
		}
		set
		{
			if (IsReadOnly)
			{
				throw CreateNotSupportedException();
			}
			AssertValid();
			ABMultiValue.ReplaceLabelAtIndex(self.Handle, ABMultiValue.ToIntPtr(value), index);
		}
	}

	public int Identifier
	{
		get
		{
			AssertValid();
			return ABMultiValue.GetIdentifierAtIndex(self.Handle, index);
		}
	}

	internal ABMultiValueEntry(ABMultiValue<T> self, int index)
	{
		this.self = self;
		this.index = index;
	}

	internal void AssertValid()
	{
		if (self == null)
		{
			throw new InvalidOperationException();
		}
	}

	private IntPtr ToIntPtr(T value)
	{
		return ((self as ABMutableMultiValue<T>) ?? throw CreateNotSupportedException()).toNative(value);
	}

	private static Exception CreateNotSupportedException()
	{
		return new NotSupportedException("ABMultiValue record is read-only. To update properties, use an ABMutableMultiValue<T>. See ABMultiValue<T>.ToMutableMultiValue().");
	}
}

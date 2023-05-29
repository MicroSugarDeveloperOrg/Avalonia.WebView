using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace AddressBook;

internal static class ABMultiValue
{
	public const int Mask = 256;

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook", EntryPoint = "ABMultiValueCopyValueAtIndex")]
	public static extern IntPtr CopyValueAtIndex(IntPtr multiValue, int index);

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook", EntryPoint = "ABMultiValueCopyLabelAtIndex")]
	public static extern IntPtr CopyLabelAtIndex(IntPtr multiValue, int index);

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook", EntryPoint = "ABMultiValueGetIdentifierAtIndex")]
	public static extern int GetIdentifierAtIndex(IntPtr multiValue, int index);

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook", EntryPoint = "ABMultiValueCopyArrayOfAllValues")]
	public static extern IntPtr CopyArrayOfAllValues(IntPtr multiValue);

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook", EntryPoint = "ABMultiValueGetCount")]
	public static extern int GetCount(IntPtr multiValue);

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook", EntryPoint = "ABMultiValueGetFirstIndexOfValue")]
	public static extern int GetFirstIndexOfValue(IntPtr multiValue, IntPtr value);

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook", EntryPoint = "ABMultiValueGetIndexForIdentifier")]
	public static extern int GetIndexForIdentifier(IntPtr multiValue, int identifier);

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook", EntryPoint = "ABMultiValueGetPropertyType")]
	public static extern ABPropertyType GetPropertyType(IntPtr multiValue);

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook", EntryPoint = "ABMultiValueCreateMutable")]
	public static extern IntPtr CreateMutable(ABPropertyType type);

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook", EntryPoint = "ABMultiValueCreateMutableCopy")]
	public static extern IntPtr CreateMutableCopy(IntPtr multiValue);

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook", EntryPoint = "ABMultiValueAddValueAndLabel")]
	public static extern bool AddValueAndLabel(IntPtr multiValue, IntPtr value, IntPtr label, out int outIdentifier);

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook", EntryPoint = "ABMultiValueReplaceValueAtIndex")]
	public static extern bool ReplaceValueAtIndex(IntPtr multiValue, IntPtr value, int index);

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook", EntryPoint = "ABMultiValueReplaceLabelAtIndex")]
	public static extern bool ReplaceLabelAtIndex(IntPtr multiValue, IntPtr value, int index);

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook", EntryPoint = "ABMultiValueInsertValueAndLabelAtIndex")]
	public static extern bool InsertValueAndLabelAtIndex(IntPtr multiValue, IntPtr value, IntPtr label, int index, out int outIdentifier);

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook", EntryPoint = "ABMultiValueRemoveValueAndLabelAtIndex")]
	public static extern bool RemoveValueAndLabelAtIndex(IntPtr multiValue, int index);

	public static IntPtr ToIntPtr(NSObject value)
	{
		return value?.Handle ?? IntPtr.Zero;
	}
}
public class ABMultiValue<T> : INativeObject, IDisposable, IEnumerable<ABMultiValueEntry<T>>, IEnumerable
{
	private IntPtr handle;

	internal Converter<IntPtr, T> toManaged;

	internal Converter<T, IntPtr> toNative;

	public IntPtr Handle
	{
		get
		{
			AssertValid();
			return handle;
		}
	}

	public virtual bool IsReadOnly
	{
		get
		{
			AssertValid();
			return true;
		}
	}

	public ABPropertyType PropertyType => ABMultiValue.GetPropertyType(Handle);

	public int Count => ABMultiValue.GetCount(Handle);

	public ABMultiValueEntry<T> this[int index]
	{
		get
		{
			if (index < 0 || index >= Count)
			{
				throw new ArgumentOutOfRangeException();
			}
			return new ABMultiValueEntry<T>(this, index);
		}
	}

	internal ABMultiValue(IntPtr handle)
		: this(handle, (Converter<IntPtr, T>)((IntPtr v) => (T)(object)Runtime.GetNSObject(v)), (Converter<T, IntPtr>)((T v) => (v != null) ? ((INativeObject)(object)v).Handle : IntPtr.Zero))
	{
		if (!typeof(NSObject).IsAssignableFrom(typeof(T)))
		{
			throw new InvalidOperationException("T must be an NSObject!");
		}
	}

	internal ABMultiValue(IntPtr handle, Converter<IntPtr, T> toManaged, Converter<T, IntPtr> toNative)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentException("Handle must not be null.", "handle");
		}
		if (toManaged == null)
		{
			throw new ArgumentNullException("toManaged");
		}
		if (toNative == null)
		{
			throw new ArgumentNullException("toNative");
		}
		this.handle = handle;
		this.toManaged = toManaged;
		this.toNative = toNative;
	}

	~ABMultiValue()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
		}
		handle = IntPtr.Zero;
	}

	internal void AssertValid()
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("");
		}
	}

	public T[] GetValues()
	{
		return NSArray.ArrayFromHandle(ABMultiValue.CopyArrayOfAllValues(Handle), toManaged) ?? new T[0];
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<ABMultiValueEntry<T>> GetEnumerator()
	{
		int c = Count;
		int i = 0;
		while (i < c)
		{
			yield return this[i];
			int num = i + 1;
			i = num;
		}
	}

	public int GetFirstIndexOfValue(NSObject value)
	{
		return ABMultiValue.GetFirstIndexOfValue(Handle, value.Handle);
	}

	public int GetIndexForIdentifier(int identifier)
	{
		return ABMultiValue.GetIndexForIdentifier(Handle, identifier);
	}

	public ABMutableMultiValue<T> ToMutableMultiValue()
	{
		return new ABMutableMultiValue<T>(ABMultiValue.CreateMutableCopy(Handle), toManaged, toNative);
	}
}

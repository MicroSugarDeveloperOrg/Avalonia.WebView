using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace AddressBook;

public abstract class ABRecord : INativeObject, IDisposable
{
	public const int InvalidRecordId = -1;

	public const int InvalidPropertyId = -1;

	private IntPtr handle;

	internal ABAddressBook AddressBook { get; set; }

	public IntPtr Handle
	{
		get
		{
			AssertValid();
			return handle;
		}
		internal set
		{
			handle = value;
		}
	}

	public int Id => ABRecordGetRecordID(Handle);

	public ABRecordType Type => ABRecordGetRecordType(Handle);

	internal ABRecord(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
		this.handle = handle;
	}

	internal static ABRecord FromHandle(IntPtr handle, ABAddressBook addressbook, bool owns = true)
	{
		if (handle == IntPtr.Zero)
		{
			throw new ArgumentNullException("handle");
		}
		ABRecord aBRecord = ABRecordGetRecordType(handle) switch
		{
			ABRecordType.Person => new ABPerson(handle, owns), 
			ABRecordType.Group => new ABGroup(handle, owns), 
			ABRecordType.Source => new ABSource(handle, owns), 
			_ => throw new NotSupportedException("Could not determine record type."), 
		};
		aBRecord.AddressBook = addressbook;
		return aBRecord;
	}

	~ABRecord()
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
		AddressBook = null;
	}

	private void AssertValid()
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("");
		}
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern int ABRecordGetRecordID(IntPtr record);

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern ABRecordType ABRecordGetRecordType(IntPtr record);

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABRecordCopyCompositeName(IntPtr record);

	public override string ToString()
	{
		using NSString nSString = new NSString(ABRecordCopyCompositeName(Handle));
		return nSString.ToString();
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern bool ABRecordSetValue(IntPtr record, int property, IntPtr value, out IntPtr error);

	internal void SetValue(int property, IntPtr value)
	{
		if (!ABRecordSetValue(Handle, property, value, out var error))
		{
			throw CFException.FromCFError(error);
		}
	}

	internal void SetValue(int property, NSObject value)
	{
		SetValue(property, value?.Handle ?? IntPtr.Zero);
	}

	internal void SetValue(int property, string value)
	{
		using NSObject value2 = ((value == null) ? null : new NSString(value));
		SetValue(property, value2);
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABRecordCopyValue(IntPtr record, int property);

	internal IntPtr CopyValue(int property)
	{
		return ABRecordCopyValue(Handle, property);
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern bool ABRecordRemoveValue(IntPtr record, int property, out IntPtr error);

	internal void RemoveValue(int property)
	{
		if (!ABRecordRemoveValue(Handle, property, out var error) && error != IntPtr.Zero)
		{
			throw CFException.FromCFError(error);
		}
	}

	internal T PropertyTo<T>(int id) where T : NSObject
	{
		IntPtr intPtr = CopyValue(id);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return (T)Runtime.GetNSObject(intPtr);
	}

	internal string PropertyToString(int id)
	{
		IntPtr intPtr = CopyValue(id);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		using NSString nSString = new NSString(intPtr);
		return nSString.ToString();
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace AddressBook;

public class ABGroup : ABRecord, IEnumerable<ABRecord>, IEnumerable
{
	public string Name
	{
		get
		{
			return PropertyToString(ABGroupProperty.Name);
		}
		set
		{
			SetValue(ABGroupProperty.Name, value);
		}
	}

	[Since(4, 0)]
	public ABRecord Source
	{
		get
		{
			IntPtr intPtr = ABGroupCopySource(base.Handle);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return ABRecord.FromHandle(intPtr, null);
		}
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABGroupCreate();

	public ABGroup()
		: base(ABGroupCreate(), owns: true)
	{
		InitConstants.Init();
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABGroupCreateInSource(IntPtr source);

	[Since(4, 0)]
	public ABGroup(ABRecord source)
		: base(IntPtr.Zero, owns: true)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		base.Handle = ABGroupCreateInSource(source.Handle);
	}

	internal ABGroup(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	internal ABGroup(IntPtr handle, ABAddressBook addressbook)
		: base(handle, owns: false)
	{
		base.AddressBook = addressbook;
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABGroupCopySource(IntPtr group);

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern bool ABGroupAddMember(IntPtr group, IntPtr person, out IntPtr error);

	public void Add(ABRecord person)
	{
		if (person == null)
		{
			throw new ArgumentNullException("person");
		}
		if (!ABGroupAddMember(base.Handle, person.Handle, out var error))
		{
			throw CFException.FromCFError(error);
		}
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABGroupCopyArrayOfAllMembers(IntPtr group);

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<ABRecord> GetEnumerator()
	{
		IntPtr intPtr = ABGroupCopyArrayOfAllMembers(base.Handle);
		IEnumerable<ABRecord> enumerable = null;
		enumerable = ((!(intPtr == IntPtr.Zero)) ? NSArray.ArrayFromHandle(intPtr, (IntPtr h) => ABRecord.FromHandle(h, base.AddressBook)) : new ABRecord[0]);
		return enumerable.GetEnumerator();
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABGroupCopyArrayOfAllMembersWithSortOrdering(IntPtr group, ABPersonSortBy sortOrdering);

	public ABRecord[] GetMembers(ABPersonSortBy sortOrdering)
	{
		IntPtr intPtr = ABGroupCopyArrayOfAllMembersWithSortOrdering(base.Handle, sortOrdering);
		if (intPtr == IntPtr.Zero)
		{
			return new ABRecord[0];
		}
		return NSArray.ArrayFromHandle(intPtr, (IntPtr h) => ABRecord.FromHandle(h, base.AddressBook));
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern bool ABGroupRemoveMember(IntPtr group, IntPtr member, out IntPtr error);

	public void Remove(ABRecord member)
	{
		if (member == null)
		{
			throw new ArgumentNullException("member");
		}
		if (!ABGroupRemoveMember(base.Handle, member.Handle, out var error))
		{
			throw CFException.FromCFError(error);
		}
	}
}

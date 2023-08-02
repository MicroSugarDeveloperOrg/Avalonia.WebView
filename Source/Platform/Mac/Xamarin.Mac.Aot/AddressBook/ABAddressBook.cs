using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace AddressBook;

public class ABAddressBook : INativeObject, IDisposable, IEnumerable<ABRecord>, IEnumerable
{
	internal delegate void InnerCompleted(IntPtr block, bool success, IntPtr error);

	private delegate void ABExternalChangeCallback(IntPtr addressBook, IntPtr info, IntPtr context);

	public static readonly NSString ErrorDomain;

	private IntPtr handle;

	private GCHandle sender;

	private static readonly InnerCompleted static_completionHandler;

	private object eventLock = new object();

	private EventHandler<ExternalChangeEventArgs> externalChange;

	public IntPtr Handle
	{
		get
		{
			AssertValid();
			return handle;
		}
	}

	public bool HasUnsavedChanges
	{
		get
		{
			AssertValid();
			return ABAddressBookHasUnsavedChanges(Handle);
		}
	}

	public int PeopleCount
	{
		get
		{
			AssertValid();
			return ABAddressBookGetPersonCount(Handle);
		}
	}

	public int GroupCount
	{
		get
		{
			AssertValid();
			return ABAddressBookGetGroupCount(Handle);
		}
	}

	public event EventHandler<ExternalChangeEventArgs> ExternalChange
	{
		add
		{
			lock (eventLock)
			{
				if (externalChange == null)
				{
					sender = GCHandle.Alloc(this);
					ABAddressBookRegisterExternalChangeCallback(Handle, ExternalChangeCallback, GCHandle.ToIntPtr(sender));
				}
				externalChange = (EventHandler<ExternalChangeEventArgs>)Delegate.Combine(externalChange, value);
			}
		}
		remove
		{
			lock (eventLock)
			{
				externalChange = (EventHandler<ExternalChangeEventArgs>)Delegate.Remove(externalChange, value);
				if (externalChange == null)
				{
					ABAddressBookUnregisterExternalChangeCallback(Handle, ExternalChangeCallback, GCHandle.ToIntPtr(sender));
					sender.Free();
				}
			}
		}
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	[Obsolete("Deprecated in iOS 6.0")]
	internal static extern IntPtr ABAddressBookCreate();

	[Obsolete("Deprecated in iOS 6.0. Use static Create method instead")]
	public ABAddressBook()
	{
		handle = ABAddressBookCreate();
		InitConstants.Init();
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	internal static extern IntPtr ABAddressBookCreateWithOptions(IntPtr dictionary, out IntPtr cfError);

	[Since(6, 0)]
	public static ABAddressBook Create(out NSError error)
	{
		IntPtr cfError;
		IntPtr intPtr = ABAddressBookCreateWithOptions(IntPtr.Zero, out cfError);
		if (intPtr == IntPtr.Zero)
		{
			error = new NSError(cfError);
			return null;
		}
		error = null;
		return new ABAddressBook(intPtr, owns: true);
	}

	internal ABAddressBook(IntPtr handle, bool owns)
	{
		InitConstants.Init();
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
		this.handle = handle;
	}

	internal ABAddressBook(IntPtr handle)
	{
		InitConstants.Init();
		this.handle = handle;
	}

	static ABAddressBook()
	{
		static_completionHandler = TrampolineCompletionHandler;
		IntPtr intPtr = Dlfcn.dlopen("/System/Library/Frameworks/AddressBook.framework/AddressBook", 0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		try
		{
			ErrorDomain = Dlfcn.GetStringConstant(intPtr, "ABAddressBookErrorDomain");
		}
		finally
		{
			Dlfcn.dlclose(intPtr);
		}
	}

	~ABAddressBook()
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
		if (sender.IsAllocated)
		{
			sender.Free();
		}
		handle = IntPtr.Zero;
	}

	private void AssertValid()
	{
		if (handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("");
		}
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern ABAuthorizationStatus ABAddressBookGetAuthorizationStatus();

	[Since(6, 0)]
	public static ABAuthorizationStatus GetAuthorizationStatus()
	{
		return ABAddressBookGetAuthorizationStatus();
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private unsafe static extern void ABAddressBookRequestAccessWithCompletion(IntPtr addressbook, void* completion);

	[Since(6, 0)]
	public unsafe void RequestAccess(Action<bool, NSError> onCompleted)
	{
		if (onCompleted == null)
		{
			throw new ArgumentNullException("onCompleted");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(static_completionHandler, onCompleted);
		ABAddressBookRequestAccessWithCompletion(Handle, ptr);
		ptr->CleanupBlock();
	}

	[MonoPInvokeCallback(typeof(InnerCompleted))]
	private unsafe static void TrampolineCompletionHandler(IntPtr block, bool success, IntPtr error)
	{
		BlockLiteral* ptr = (BlockLiteral*)(void*)block;
		((Action<bool, NSError>)((ptr->global_handle != IntPtr.Zero) ? GCHandle.FromIntPtr(ptr->global_handle).Target : GCHandle.FromIntPtr(ptr->local_handle).Target))?.Invoke(success, (error == IntPtr.Zero) ? null : ((NSError)Runtime.GetNSObject(error)));
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern bool ABAddressBookHasUnsavedChanges(IntPtr addressBook);

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern bool ABAddressBookSave(IntPtr addressBook, out IntPtr error);

	public void Save()
	{
		AssertValid();
		if (!ABAddressBookSave(Handle, out var error))
		{
			throw CFException.FromCFError(error);
		}
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern void ABAddressBookRevert(IntPtr addressBook);

	public void Revert()
	{
		AssertValid();
		ABAddressBookRevert(Handle);
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern bool ABAddressBookAddRecord(IntPtr addressBook, IntPtr record, out IntPtr error);

	public void Add(ABRecord record)
	{
		if (record == null)
		{
			throw new ArgumentNullException("record");
		}
		AssertValid();
		if (!ABAddressBookAddRecord(Handle, record.Handle, out var error))
		{
			throw CFException.FromCFError(error);
		}
		record.AddressBook = this;
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern bool ABAddressBookRemoveRecord(IntPtr addressBook, IntPtr record, out IntPtr error);

	public void Remove(ABRecord record)
	{
		if (record == null)
		{
			throw new ArgumentNullException("record");
		}
		AssertValid();
		if (!ABAddressBookRemoveRecord(Handle, record.Handle, out var error))
		{
			throw CFException.FromCFError(error);
		}
		record.AddressBook = null;
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern int ABAddressBookGetPersonCount(IntPtr addressBook);

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABAddressBookCopyArrayOfAllPeople(IntPtr addressBook);

	public ABPerson[] GetPeople()
	{
		AssertValid();
		return NSArray.ArrayFromHandle(ABAddressBookCopyArrayOfAllPeople(Handle), (IntPtr h) => new ABPerson(h, this));
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABAddressBookCopyArrayOfAllPeopleInSource(IntPtr addressBook, IntPtr source);

	[Since(4, 0)]
	public ABPerson[] GetPeople(ABRecord source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		AssertValid();
		return NSArray.ArrayFromHandle(ABAddressBookCopyArrayOfAllPeopleInSource(Handle, source.Handle), (IntPtr l) => new ABPerson(l, this));
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABAddressBookCopyArrayOfAllPeopleInSourceWithSortOrdering(IntPtr addressBook, IntPtr source, ABPersonSortBy sortOrdering);

	[Since(4, 0)]
	public ABPerson[] GetPeople(ABRecord source, ABPersonSortBy sortOrdering)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		AssertValid();
		return NSArray.ArrayFromHandle(ABAddressBookCopyArrayOfAllPeopleInSourceWithSortOrdering(Handle, source.Handle, sortOrdering), (IntPtr l) => new ABPerson(l, this));
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern int ABAddressBookGetGroupCount(IntPtr addressBook);

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABAddressBookCopyArrayOfAllGroups(IntPtr addressBook);

	public ABGroup[] GetGroups()
	{
		AssertValid();
		return NSArray.ArrayFromHandle(ABAddressBookCopyArrayOfAllGroups(Handle), (IntPtr h) => new ABGroup(h, this));
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABAddressBookCopyArrayOfAllGroupsInSource(IntPtr addressBook, IntPtr source);

	[Since(4, 0)]
	public ABGroup[] GetGroups(ABRecord source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		AssertValid();
		return NSArray.ArrayFromHandle(ABAddressBookCopyArrayOfAllGroupsInSource(Handle, source.Handle), (IntPtr l) => new ABGroup(l, this));
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABAddressBookCopyLocalizedLabel(IntPtr label);

	public static string LocalizedLabel(NSString label)
	{
		if (label == null)
		{
			throw new ArgumentNullException("label");
		}
		using NSString nSString = new NSString(ABAddressBookCopyLocalizedLabel(label.Handle));
		return nSString.ToString();
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern void ABAddressBookRegisterExternalChangeCallback(IntPtr addressBook, ABExternalChangeCallback callback, IntPtr context);

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern void ABAddressBookUnregisterExternalChangeCallback(IntPtr addressBook, ABExternalChangeCallback callback, IntPtr context);

	[MonoPInvokeCallback(typeof(ABExternalChangeCallback))]
	private static void ExternalChangeCallback(IntPtr addressBook, IntPtr info, IntPtr context)
	{
		if (GCHandle.FromIntPtr(context).Target is ABAddressBook aBAddressBook)
		{
			aBAddressBook.OnExternalChange(new ExternalChangeEventArgs(new ABAddressBook(addressBook, owns: false), (NSDictionary)Runtime.GetNSObject(info)));
		}
	}

	protected virtual void OnExternalChange(ExternalChangeEventArgs e)
	{
		AssertValid();
		externalChange?.Invoke(this, e);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IEnumerator<ABRecord> GetEnumerator()
	{
		AssertValid();
		ABPerson[] people = GetPeople();
		for (int i = 0; i < people.Length; i++)
		{
			yield return people[i];
		}
		ABGroup[] groups = GetGroups();
		for (int i = 0; i < groups.Length; i++)
		{
			yield return groups[i];
		}
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABAddressBookGetGroupWithRecordID(IntPtr addressBook, int recordId);

	public ABGroup GetGroup(int recordId)
	{
		IntPtr intPtr = ABAddressBookGetGroupWithRecordID(Handle, recordId);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new ABGroup(intPtr, this);
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABAddressBookGetPersonWithRecordID(IntPtr addressBook, int recordId);

	public ABPerson GetPerson(int recordId)
	{
		IntPtr intPtr = ABAddressBookGetPersonWithRecordID(Handle, recordId);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new ABPerson(intPtr, this);
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABAddressBookCopyPeopleWithName(IntPtr addressBook, IntPtr name);

	public ABPerson[] GetPeopleWithName(string name)
	{
		IntPtr intPtr;
		using (NSString nSString = new NSString(name))
		{
			intPtr = ABAddressBookCopyPeopleWithName(Handle, nSString.Handle);
		}
		return NSArray.ArrayFromHandle(intPtr, (IntPtr h) => new ABPerson(h, this));
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABAddressBookCopyArrayOfAllSources(IntPtr addressBook);

	public ABSource[] GetAllSources()
	{
		AssertValid();
		return NSArray.ArrayFromHandle(ABAddressBookCopyArrayOfAllSources(Handle), (IntPtr h) => new ABSource(h, this));
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABAddressBookCopyDefaultSource(IntPtr addressBook);

	public ABSource GetDefaultSource()
	{
		AssertValid();
		IntPtr intPtr = ABAddressBookCopyDefaultSource(Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new ABSource(intPtr, this);
	}

	[DllImport("/System/Library/Frameworks/AddressBook.framework/AddressBook")]
	private static extern IntPtr ABAddressBookGetSourceWithRecordID(IntPtr addressBook, int sourceID);

	public ABSource GetSource(int sourceID)
	{
		AssertValid();
		IntPtr intPtr = ABAddressBookGetSourceWithRecordID(Handle, sourceID);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new ABSource(intPtr, this);
	}
}

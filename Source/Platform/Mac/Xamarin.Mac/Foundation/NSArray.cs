using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Foundation;

[Register("NSArray", true)]
public class NSArray : NSObject
{
	private static readonly IntPtr selCountHandle = Selector.GetHandle("count");

	private static readonly IntPtr selObjectAtIndex_Handle = Selector.GetHandle("objectAtIndex:");

	private static readonly IntPtr selArrayWithObjectsCount_Handle = Selector.GetHandle("arrayWithObjects:count:");

	private static readonly IntPtr selValueForKey_Handle = Selector.GetHandle("valueForKey:");

	private static readonly IntPtr selSetValueForKey_Handle = Selector.GetHandle("setValue:forKey:");

	private static readonly IntPtr selWriteToFileAtomically_Handle = Selector.GetHandle("writeToFile:atomically:");

	private static readonly IntPtr selArrayWithContentsOfFile_Handle = Selector.GetHandle("arrayWithContentsOfFile:");

	private static readonly IntPtr selSortedArrayUsingComparator_Handle = Selector.GetHandle("sortedArrayUsingComparator:");

	private static readonly IntPtr selFilteredArrayUsingPredicate_Handle = Selector.GetHandle("filteredArrayUsingPredicate:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSArray");

	public override IntPtr ClassHandle => class_ptr;

	public virtual ulong Count
	{
		[Export("count")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selCountHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCountHandle);
		}
	}

	internal NSArray(bool empty)
	{
		base.Handle = IntPtr.Zero;
	}

	public static NSArray FromNSObjects(params NSObject[] items)
	{
		return FromNSObjects((IList<NSObject>)items);
	}

	public static NSArray FromNSObjects(int count, params NSObject[] items)
	{
		if (items.Length < count)
		{
			throw new ArgumentException("count is larger than the number of items", "count");
		}
		return FromNSObjects(items, count);
	}

	public static NSArray FromObjects(params object[] items)
	{
		if (items == null)
		{
			return new NSArray(empty: true);
		}
		return FromObjects(items.Length, items);
	}

	public static NSArray FromObjects(int count, params object[] items)
	{
		if (items == null)
		{
			return new NSArray(empty: true);
		}
		if (count > items.Length)
		{
			throw new ArgumentException("count is larger than the number of items", "count");
		}
		NSObject[] array = new NSObject[count];
		for (int i = 0; i < count; i++)
		{
			NSObject nSObject = NSObject.FromObject(items[i]);
			if (nSObject == null)
			{
				throw new ArgumentException($"Do not know how to marshal object of type '{items[i].GetType()}' to an NSObject");
			}
			array[i] = nSObject;
		}
		return FromNSObjects(array);
	}

	public static NSArray FromObjects(IntPtr array, int count)
	{
		return FromObjects(array, (ulong)count);
	}

	internal static NSArray FromNSObjects(IList<NSObject> items)
	{
		if (items == null)
		{
			return new NSArray(empty: true);
		}
		IntPtr intPtr = Marshal.AllocHGlobal(items.Count * IntPtr.Size);
		for (int i = 0; i < items.Count; i++)
		{
			Marshal.WriteIntPtr(intPtr, i * IntPtr.Size, items[i].Handle);
		}
		NSArray result = FromObjects(intPtr, items.Count);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	internal static NSArray FromNSObjects(IList<NSObject> items, int count)
	{
		if (items == null)
		{
			return new NSArray(empty: true);
		}
		IntPtr intPtr = Marshal.AllocHGlobal(items.Count * IntPtr.Size);
		for (int i = 0; i < count; i++)
		{
			Marshal.WriteIntPtr(intPtr, i * IntPtr.Size, items[i].Handle);
		}
		NSArray result = FromObjects(intPtr, count);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public static NSArray FromStrings(params string[] items)
	{
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(items.Length * IntPtr.Size);
		try
		{
			NSString[] array = new NSString[items.Length];
			for (int i = 0; i < items.Length; i++)
			{
				if (items[i] == null)
				{
					throw new ArgumentNullException($"items[{i}]");
				}
				array[i] = new NSString(items[i]);
				IntPtr val = array[i].Handle;
				Marshal.WriteIntPtr(intPtr, i * IntPtr.Size, val);
			}
			NSArray result = FromObjects(intPtr, items.Length);
			NSString[] array2 = array;
			for (int j = 0; j < array2.Length; j++)
			{
				array2[j].Dispose();
			}
			return result;
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	public static NSArray FromIntPtrs(IntPtr[] vals)
	{
		if (vals == null)
		{
			throw new ArgumentNullException("vals");
		}
		int num = vals.Length;
		IntPtr intPtr = Marshal.AllocHGlobal(num * IntPtr.Size);
		for (int i = 0; i < num; i++)
		{
			Marshal.WriteIntPtr(intPtr, i * IntPtr.Size, vals[i]);
		}
		NSArray result = FromObjects(intPtr, vals.Length);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	public static string[] StringArrayFromHandle(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			return null;
		}
		uint num = Messaging.UInt32_objc_msgSend(handle, selCountHandle);
		string[] array = new string[num];
		for (uint num2 = 0u; num2 < num; num2++)
		{
			IntPtr usrhandle = Messaging.IntPtr_objc_msgSend_UInt32(handle, selObjectAtIndex_Handle, num2);
			array[num2] = NSString.FromHandle(usrhandle);
		}
		return array;
	}

	public static T[] ArrayFromHandle<T>(IntPtr handle) where T : NSObject
	{
		if (handle == IntPtr.Zero)
		{
			return null;
		}
		uint num = Messaging.UInt32_objc_msgSend(handle, selCountHandle);
		T[] array = new T[num];
		for (uint num2 = 0u; num2 < num; num2++)
		{
			IntPtr ptr = Messaging.IntPtr_objc_msgSend_UInt32(handle, selObjectAtIndex_Handle, num2);
			array[num2] = (T)Runtime.GetNSObject(ptr);
			array[num2].Handle = ptr;
		}
		return array;
	}

	public static T[] FromArray<T>(NSArray weakArray) where T : NSObject
	{
		if (weakArray == null || weakArray.Handle == IntPtr.Zero)
		{
			return null;
		}
		try
		{
			ulong count = weakArray.Count;
			T[] array = new T[count];
			for (ulong num = 0uL; num < count; num++)
			{
				array[num] = (T)Runtime.GetNSObject(weakArray.ValueAt(num));
			}
			return array;
		}
		catch
		{
			return null;
		}
	}

	public static T[] ArrayFromHandleFunc<T>(IntPtr handle, Func<IntPtr, T> createObject)
	{
		if (handle == IntPtr.Zero)
		{
			return null;
		}
		uint num = Messaging.UInt32_objc_msgSend(handle, selCountHandle);
		T[] array = new T[num];
		for (uint num2 = 0u; num2 < num; num2++)
		{
			IntPtr arg = Messaging.IntPtr_objc_msgSend_UInt32(handle, selObjectAtIndex_Handle, num2);
			array[num2] = createObject(arg);
		}
		return array;
	}

	public static T[] ArrayFromHandle<T>(IntPtr handle, Converter<IntPtr, T> creator)
	{
		if (handle == IntPtr.Zero)
		{
			return null;
		}
		uint num = Messaging.UInt32_objc_msgSend(handle, selCountHandle);
		T[] array = new T[num];
		for (uint num2 = 0u; num2 < num; num2++)
		{
			IntPtr input = Messaging.IntPtr_objc_msgSend_UInt32(handle, selObjectAtIndex_Handle, num2);
			array[num2] = creator(input);
		}
		return array;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSArray()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSArray(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSArray(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSArray(IntPtr handle)
		: base(handle)
	{
	}

	[Export("objectAtIndex:")]
	public virtual IntPtr ValueAt(ulong idx)
	{
		if (IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selObjectAtIndex_Handle, idx);
		}
		return Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selObjectAtIndex_Handle, idx);
	}

	[Export("arrayWithObjects:count:")]
	internal static NSArray FromObjects(IntPtr array, ulong count)
	{
		return (NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(class_ptr, selArrayWithObjectsCount_Handle, array, count));
	}

	[Export("valueForKey:")]
	public new virtual NSObject ValueForKey(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selValueForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selValueForKey_Handle, key.Handle));
	}

	[Export("setValue:forKey:")]
	public new virtual void SetValueForKey(NSObject value, NSString key)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetValueForKey_Handle, value.Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetValueForKey_Handle, value.Handle, key.Handle);
		}
	}

	[Export("writeToFile:atomically:")]
	public virtual bool WriteToFile(string path, bool useAuxiliaryFile)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selWriteToFileAtomically_Handle, arg, useAuxiliaryFile) : Messaging.bool_objc_msgSend_IntPtr_bool(base.Handle, selWriteToFileAtomically_Handle, arg, useAuxiliaryFile));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("arrayWithContentsOfFile:")]
	public static NSArray FromFile(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSArray result = (NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selArrayWithContentsOfFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("sortedArrayUsingComparator:")]
	public unsafe virtual NSArray Sort(NSComparator cmptr)
	{
		if (cmptr == null)
		{
			throw new ArgumentNullException("cmptr");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSComparator.Handler, cmptr);
		NSArray result = ((!IsDirectBinding) ? ((NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSortedArrayUsingComparator_Handle, (IntPtr)ptr))) : ((NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSortedArrayUsingComparator_Handle, (IntPtr)ptr))));
		ptr->CleanupBlock();
		return result;
	}

	[Export("filteredArrayUsingPredicate:")]
	public virtual NSArray Filter(NSPredicate predicate)
	{
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		if (IsDirectBinding)
		{
			return (NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFilteredArrayUsingPredicate_Handle, predicate.Handle));
		}
		return (NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFilteredArrayUsingPredicate_Handle, predicate.Handle));
	}
}

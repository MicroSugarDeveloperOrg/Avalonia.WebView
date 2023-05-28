using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using CloudKit;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSArray", true)]
public class NSArray : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSMutableCopying, INSSecureCoding, ICKRecordValue
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddObserver_ToObjectsAtIndexes_ForKeyPath_Options_Context_ = "addObserver:toObjectsAtIndexes:forKeyPath:options:context:";

	private static readonly IntPtr selAddObserver_ToObjectsAtIndexes_ForKeyPath_Options_Context_Handle = Selector.GetHandle("addObserver:toObjectsAtIndexes:forKeyPath:options:context:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArrayWithContentsOfFile_ = "arrayWithContentsOfFile:";

	private static readonly IntPtr selArrayWithContentsOfFile_Handle = Selector.GetHandle("arrayWithContentsOfFile:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArrayWithContentsOfURL_Error_ = "arrayWithContentsOfURL:error:";

	private static readonly IntPtr selArrayWithContentsOfURL_Error_Handle = Selector.GetHandle("arrayWithContentsOfURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArrayWithObjects_Count_ = "arrayWithObjects:count:";

	private static readonly IntPtr selArrayWithObjects_Count_Handle = Selector.GetHandle("arrayWithObjects:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainsObject_ = "containsObject:";

	private static readonly IntPtr selContainsObject_Handle = Selector.GetHandle("containsObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCount = "count";

	private static readonly IntPtr selCountHandle = Selector.GetHandle("count");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilteredArrayUsingPredicate_ = "filteredArrayUsingPredicate:";

	private static readonly IntPtr selFilteredArrayUsingPredicate_Handle = Selector.GetHandle("filteredArrayUsingPredicate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfObject_ = "indexOfObject:";

	private static readonly IntPtr selIndexOfObject_Handle = Selector.GetHandle("indexOfObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMutableCopyWithZone_ = "mutableCopyWithZone:";

	private static readonly IntPtr selMutableCopyWithZone_Handle = Selector.GetHandle("mutableCopyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectAtIndex_ = "objectAtIndex:";

	private static readonly IntPtr selObjectAtIndex_Handle = Selector.GetHandle("objectAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObserver_FromObjectsAtIndexes_ForKeyPath_ = "removeObserver:fromObjectsAtIndexes:forKeyPath:";

	private static readonly IntPtr selRemoveObserver_FromObjectsAtIndexes_ForKeyPath_Handle = Selector.GetHandle("removeObserver:fromObjectsAtIndexes:forKeyPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObserver_FromObjectsAtIndexes_ForKeyPath_Context_ = "removeObserver:fromObjectsAtIndexes:forKeyPath:context:";

	private static readonly IntPtr selRemoveObserver_FromObjectsAtIndexes_ForKeyPath_Context_Handle = Selector.GetHandle("removeObserver:fromObjectsAtIndexes:forKeyPath:context:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_ForKey_ = "setValue:forKey:";

	private static readonly IntPtr selSetValue_ForKey_Handle = Selector.GetHandle("setValue:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSortedArrayUsingComparator_ = "sortedArrayUsingComparator:";

	private static readonly IntPtr selSortedArrayUsingComparator_Handle = Selector.GetHandle("sortedArrayUsingComparator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueForKey_ = "valueForKey:";

	private static readonly IntPtr selValueForKey_Handle = Selector.GetHandle("valueForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToFile_Atomically_ = "writeToFile:atomically:";

	private static readonly IntPtr selWriteToFile_Atomically_Handle = Selector.GetHandle("writeToFile:atomically:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToURL_Error_ = "writeToURL:error:";

	private static readonly IntPtr selWriteToURL_Error_Handle = Selector.GetHandle("writeToURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSArray");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Count
	{
		[Export("count")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selCountHandle);
		}
	}

	public static NSArray FromNSObjects(params NSObject[] items)
	{
		return FromNativeObjects(items);
	}

	public static NSArray FromNSObjects(int count, params NSObject[] items)
	{
		return FromNativeObjects(items, count);
	}

	public static NSArray FromNSObjects(params INativeObject[] items)
	{
		return FromNativeObjects(items);
	}

	public static NSArray FromNSObjects(int count, params INativeObject[] items)
	{
		return FromNativeObjects(items, count);
	}

	public static NSArray FromNSObjects<T>(params T[] items) where T : class, INativeObject
	{
		return FromNativeObjects(items);
	}

	public static NSArray FromNSObjects<T>(params T[][] items) where T : class, INativeObject
	{
		if (items == null)
		{
			return null;
		}
		NSMutableArray nSMutableArray = new NSMutableArray((nuint)items.Length);
		for (int i = 0; i < items.Length; i++)
		{
			T[] array = items[i];
			if (array == null)
			{
				throw new ArgumentNullException("items", $"Element [{i}] is null");
			}
			for (int j = 0; j < array.Length; j++)
			{
				T val = array[j];
				if (val == null)
				{
					throw new ArgumentNullException("items", $"Element [{i}][{j}] is null");
				}
			}
			nSMutableArray.Add(FromNSObjects(array));
		}
		return nSMutableArray;
	}

	public static NSArray FromNSObjects<T>(T[,] items) where T : class, INativeObject
	{
		if (items == null)
		{
			return null;
		}
		int length = items.GetLength(0);
		int length2 = items.GetLength(1);
		T[][] array = new T[length2][];
		for (int i = 0; i < length2; i++)
		{
			T[] array2 = new T[length];
			for (int j = 0; j < length; j++)
			{
				array2[j] = items[j, i];
			}
			array[i] = array2;
		}
		return FromNSObjects(array);
	}

	public static NSArray FromNSObjects<T>(int count, params T[] items) where T : class, INativeObject
	{
		return FromNativeObjects(items, count);
	}

	public static NSArray FromNSObjects<T>(Func<T, NSObject> nsobjectificator, params T[] items)
	{
		if (nsobjectificator == null)
		{
			throw new ArgumentNullException("nsobjectificator");
		}
		if (items == null)
		{
			return null;
		}
		NSObject[] array = new NSObject[items.Length];
		for (int i = 0; i < items.Length; i++)
		{
			array[i] = nsobjectificator(items[i]);
		}
		return FromNativeObjects(array);
	}

	public static NSArray FromObjects(params object[] items)
	{
		return From(items, -1L);
	}

	public static NSArray FromObjects(nint count, params object[] items)
	{
		return From(items, count);
	}

	internal static NSArray From<T>(T[] items, long count = -1L)
	{
		if (items == null || count == 0)
		{
			return new NSArray();
		}
		if (count == -1)
		{
			count = items.Length;
		}
		else if (count > items.Length)
		{
			throw new ArgumentException("count is larger than the number of items", "count");
		}
		NSObject[] array = new NSObject[count];
		for (nint nint = 0; (long)nint < count; ++nint)
		{
			NSObject nSObject = NSObject.FromObject(items[(long)nint]);
			if (nSObject == null)
			{
				throw new ArgumentException($"Do not know how to marshal object of type '{items[(long)nint].GetType()}' to an NSObject");
			}
			array[(long)nint] = nSObject;
		}
		return FromNSObjects(array);
	}

	internal static NSArray FromNativeObjects<T>(T[] items) where T : class, INativeObject
	{
		if (items == null)
		{
			return new NSArray();
		}
		return FromNativeObjects(items, items.Length);
	}

	internal static NSArray FromNativeObjects<T>(T[] items, nint count) where T : class, INativeObject
	{
		if (items == null)
		{
			return new NSArray();
		}
		if (count > items.Length)
		{
			throw new ArgumentException("count is larger than the number of items", "count");
		}
		IntPtr intPtr = Marshal.AllocHGlobal((IntPtr)(count * IntPtr.Size));
		for (nint nint = 0; nint < count; ++nint)
		{
			IntPtr val = items[(long)nint]?.Handle ?? NSNull.Null.Handle;
			Marshal.WriteIntPtr(intPtr, (int)(nint * IntPtr.Size), val);
		}
		NSArray nSObject = Runtime.GetNSObject<NSArray>(FromObjects(intPtr, count));
		Marshal.FreeHGlobal(intPtr);
		return nSObject;
	}

	internal static NSArray FromNSObjects(IList<NSObject> items)
	{
		if (items == null)
		{
			return new NSArray();
		}
		int count = items.Count;
		IntPtr intPtr = Marshal.AllocHGlobal(count * IntPtr.Size);
		for (int i = 0; i < count; i++)
		{
			Marshal.WriteIntPtr(intPtr, i * IntPtr.Size, items[i].Handle);
		}
		NSArray nSObject = Runtime.GetNSObject<NSArray>(FromObjects(intPtr, count));
		Marshal.FreeHGlobal(intPtr);
		return nSObject;
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
			for (int i = 0; i < items.Length; i++)
			{
				Marshal.WriteIntPtr(val: (items[i] != null) ? NSString.CreateNative(items[i], autorelease: true) : NSNull.Null.Handle, ptr: intPtr, ofs: i * IntPtr.Size);
			}
			return Runtime.GetNSObject<NSArray>(FromObjects(intPtr, items.Length));
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
		NSArray nSObject = Runtime.GetNSObject<NSArray>(FromObjects(intPtr, vals.Length));
		Marshal.FreeHGlobal(intPtr);
		return nSObject;
	}

	internal static nuint GetCount(IntPtr handle)
	{
		return Messaging.nuint_objc_msgSend(handle, selCountHandle);
	}

	internal static IntPtr GetAtIndex(IntPtr handle, nuint i)
	{
		return Messaging.IntPtr_objc_msgSend_nuint(handle, selObjectAtIndex_Handle, i);
	}

	public static string[] StringArrayFromHandle(IntPtr handle)
	{
		if (handle == IntPtr.Zero)
		{
			return null;
		}
		nuint count = GetCount(handle);
		string[] array = new string[(ulong)count];
		for (nuint nuint = (byte)0; nuint < count; ++nuint)
		{
			array[(ulong)nuint] = NSString.FromHandle(GetAtIndex(handle, nuint));
		}
		return array;
	}

	public static T[] ArrayFromHandle<T>(IntPtr handle) where T : class, INativeObject
	{
		if (handle == IntPtr.Zero)
		{
			return null;
		}
		nuint count = GetCount(handle);
		T[] array = new T[(ulong)count];
		for (uint num = 0u; num < count; num++)
		{
			array[num] = UnsafeGetItem<T>(handle, num);
		}
		return array;
	}

    #region

    public static T[] ArrayFromHandleEx<T>(IntPtr handle, Converter<IntPtr, T> creator)
    {
        if (handle == IntPtr.Zero)
            return (T[])null;
        uint length = Messaging.UInt32_objc_msgSend(handle, NSArray.selCountHandle);
        T[] objArray = new T[(int)length];
        for (uint index = 0; index < length; ++index)
        {
            IntPtr num = Messaging.IntPtr_objc_msgSend_UInt32(handle, NSArray.selObjectAtIndex_Handle, index);
            objArray[(int)index] = creator.Invoke(num);
        }
        return objArray;
    }

    public static string[] StringArrayFromHandleEx(IntPtr handle)
    {
        if (handle == IntPtr.Zero)
            return (string[])null;
        uint length = Messaging.UInt32_objc_msgSend(handle, NSArray.selCountHandle);
        string[] strArray = new string[(int)length];
        for (uint index = 0; index < length; ++index)
        {
            IntPtr usrhandle = Messaging.IntPtr_objc_msgSend_UInt32(handle, NSArray.selObjectAtIndex_Handle, index);
            strArray[(int)index] = NSString.FromHandle(usrhandle);
        }
        return strArray;
    }

    #endregion

    public static T[] EnumsFromHandle<T>(IntPtr handle) where T : struct, IConvertible
	{
		if (handle == IntPtr.Zero)
		{
			return null;
		}
		if (!typeof(T).IsEnum)
		{
			throw new ArgumentException("T must be an enum");
		}
		nuint count = GetCount(handle);
		T[] array = new T[(ulong)count];
		for (uint num = 0u; num < count; num++)
		{
			array[num] = (T)Convert.ChangeType(UnsafeGetItem<NSNumber>(handle, num).LongValue, typeof(T));
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
			nuint count = weakArray.Count;
			T[] array = new T[(ulong)count];
			for (nuint nuint = (byte)0; nuint < count; ++nuint)
			{
				array[(ulong)nuint] = Runtime.GetNSObject<T>(weakArray.ValueAt(nuint));
			}
			return array;
		}
		catch
		{
			return null;
		}
	}

	public static T[] FromArrayNative<T>(NSArray weakArray) where T : class, INativeObject
	{
		if (weakArray == null || weakArray.Handle == IntPtr.Zero)
		{
			return null;
		}
		try
		{
			nuint count = weakArray.Count;
			T[] array = new T[(ulong)count];
			for (nuint nuint = (byte)0; nuint < count; ++nuint)
			{
				array[(ulong)nuint] = Runtime.GetINativeObject<T>(weakArray.ValueAt(nuint), owns: false);
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
		nuint count = GetCount(handle);
		T[] array = new T[(ulong)count];
		for (uint num = 0u; num < count; num++)
		{
			array[num] = createObject(GetAtIndex(handle, num));
		}
		return array;
	}

	public static T[] ArrayFromHandle<T>(IntPtr handle, Converter<IntPtr, T> creator)
	{
		if (handle == IntPtr.Zero)
		{
			return null;
		}
		nuint count = GetCount(handle);
		T[] array = new T[(ulong)count];
		for (uint num = 0u; num < count; num++)
		{
			array[num] = creator(GetAtIndex(handle, num));
		}
		return array;
	}

	private static T UnsafeGetItem<T>(IntPtr handle, nuint index) where T : class, INativeObject
	{
		IntPtr atIndex = GetAtIndex(handle, index);
		if (atIndex == NSNull.Null.Handle)
		{
			return null;
		}
		return Runtime.GetINativeObject<T>(atIndex, owns: false);
	}

	public T GetItem<T>(nuint index) where T : class, INativeObject
	{
		if (index >= GetCount(base.Handle))
		{
			throw new ArgumentOutOfRangeException("index");
		}
		return UnsafeGetItem<T>(base.Handle, index);
	}

	public static NSObject[][] FromArrayOfArray(NSArray weakArray)
	{
		if (weakArray == null || weakArray.Handle == IntPtr.Zero)
		{
			return null;
		}
		try
		{
			nuint count = weakArray.Count;
			NSObject[][] array = new NSObject[(ulong)count][];
			for (nuint nuint = (byte)0; nuint < count; ++nuint)
			{
				array[(ulong)nuint] = FromArray<NSObject>(weakArray.GetItem<NSArray>(nuint));
			}
			return array;
		}
		catch
		{
			return null;
		}
	}

	public static NSArray From(NSObject[][] items)
	{
		if (items == null)
		{
			return null;
		}
		try
		{
			NSMutableArray nSMutableArray = new NSMutableArray((nuint)items.Length);
			for (int i = 0; i < items.Length; i++)
			{
				nSMutableArray.Add(FromNSObjects(items[i]));
			}
			return nSMutableArray;
		}
		catch
		{
			return null;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSArray()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSArray(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSArray(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSArray(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addObserver:toObjectsAtIndexes:forKeyPath:options:context:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddObserver(NSObject observer, NSIndexSet indexes, string keyPath, NSKeyValueObservingOptions options, IntPtr context)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (keyPath == null)
		{
			throw new ArgumentNullException("keyPath");
		}
		IntPtr arg = NSString.CreateNative(keyPath);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt64_IntPtr(base.Handle, selAddObserver_ToObjectsAtIndexes_ForKeyPath_Options_Context_Handle, observer.Handle, indexes.Handle, arg, (ulong)options, context);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt64_IntPtr(base.SuperHandle, selAddObserver_ToObjectsAtIndexes_ForKeyPath_Options_Context_Handle, observer.Handle, indexes.Handle, arg, (ulong)options, context);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("containsObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Contains(NSObject anObject)
	{
		if (anObject == null)
		{
			throw new ArgumentNullException("anObject");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selContainsObject_Handle, anObject.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selContainsObject_Handle, anObject.Handle);
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("filteredArrayUsingPredicate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray Filter(NSPredicate predicate)
	{
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFilteredArrayUsingPredicate_Handle, predicate.Handle));
		}
		return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFilteredArrayUsingPredicate_Handle, predicate.Handle));
	}

	[Export("arrayWithContentsOfFile:")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'NSMutableArray.FromFile' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'NSMutableArray.FromFile' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'NSMutableArray.FromFile' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'NSMutableArray.FromFile' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSArray FromFile(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSArray nSObject = Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selArrayWithContentsOfFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("arrayWithObjects:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static IntPtr FromObjects(IntPtr array, nint count)
	{
		return Messaging.IntPtr_objc_msgSend_IntPtr_nint(class_ptr, selArrayWithObjects_Count_Handle, array, count);
	}

	[Export("arrayWithContentsOfURL:error:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSArray? FromUrl(NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSObject = Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selArrayWithContentsOfURL_Error_Handle, url.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("indexOfObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint IndexOf(NSObject anObject)
	{
		if (anObject == null)
		{
			throw new ArgumentNullException("anObject");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr(base.Handle, selIndexOfObject_Handle, anObject.Handle);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfObject_Handle, anObject.Handle);
	}

	[Export("mutableCopyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject MutableCopy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("removeObserver:fromObjectsAtIndexes:forKeyPath:context:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveObserver(NSObject observer, NSIndexSet indexes, string keyPath, IntPtr context)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (keyPath == null)
		{
			throw new ArgumentNullException("keyPath");
		}
		IntPtr arg = NSString.CreateNative(keyPath);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selRemoveObserver_FromObjectsAtIndexes_ForKeyPath_Context_Handle, observer.Handle, indexes.Handle, arg, context);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRemoveObserver_FromObjectsAtIndexes_ForKeyPath_Context_Handle, observer.Handle, indexes.Handle, arg, context);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removeObserver:fromObjectsAtIndexes:forKeyPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveObserver(NSObject observer, NSIndexSet indexes, string keyPath)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (keyPath == null)
		{
			throw new ArgumentNullException("keyPath");
		}
		IntPtr arg = NSString.CreateNative(keyPath);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRemoveObserver_FromObjectsAtIndexes_ForKeyPath_Handle, observer.Handle, indexes.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRemoveObserver_FromObjectsAtIndexes_ForKeyPath_Handle, observer.Handle, indexes.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setValue:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetValue_ForKey_Handle, value.Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetValue_ForKey_Handle, value.Handle, key.Handle);
		}
	}

	[Export("sortedArrayUsingComparator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSArray Sort([BlockProxy(typeof(Trampolines.NIDNSComparator))] NSComparator cmptr)
	{
		if (cmptr == null)
		{
			throw new ArgumentNullException("cmptr");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSComparator.Handler, cmptr);
		NSArray result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSortedArrayUsingComparator_Handle, (IntPtr)ptr)) : Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSortedArrayUsingComparator_Handle, (IntPtr)ptr)));
		ptr->CleanupBlock();
		return result;
	}

	[Export("objectAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr ValueAt(nuint idx)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selObjectAtIndex_Handle, idx);
		}
		return Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selObjectAtIndex_Handle, idx);
	}

	[Export("valueForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSObject ValueForKey(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.xamarin_IntPtr_objc_msgSend_IntPtr(base.Handle, selValueForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.xamarin_IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selValueForKey_Handle, key.Handle));
	}

	[Export("writeToURL:error:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Write(NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selWriteToURL_Error_Handle, url.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selWriteToURL_Error_Handle, url.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("writeToFile:atomically:")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'Write (NSUrl, out NSError)' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'Write (NSUrl, out NSError)' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'Write (NSUrl, out NSError)' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'Write (NSUrl, out NSError)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WriteToFile(string path, bool useAuxiliaryFile)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selWriteToFile_Atomically_Handle, arg, useAuxiliaryFile) : Messaging.bool_objc_msgSend_IntPtr_bool(base.Handle, selWriteToFile_Atomically_Handle, arg, useAuxiliaryFile));
		NSString.ReleaseNative(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal bool _Contains(IntPtr anObject)
	{
		return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selContainsObject_Handle, anObject);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal nuint _IndexOf(IntPtr anObject)
	{
		return Messaging.nuint_objc_msgSend_IntPtr(base.Handle, selIndexOfObject_Handle, anObject);
	}
}
[Register(SkipRegistration = true)]
public sealed class NSArray<TKey> : NSArray, IEnumerable<TKey>, IEnumerable where TKey : class, INativeObject
{
	public TKey this[nint idx] => GetItem<TKey>((nuint)idx);

	public NSArray()
	{
	}

	public NSArray(NSCoder coder)
		: base(coder)
	{
	}

	internal NSArray(IntPtr handle)
		: base(handle)
	{
	}

	public static NSArray<TKey> FromNSObjects(params TKey[] items)
	{
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		return FromNSObjects(items.Length, items);
	}

	public static NSArray<TKey> FromNSObjects(int count, params TKey[] items)
	{
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		if (count > items.Length)
		{
			throw new ArgumentException("count is larger than the number of items", "count");
		}
		IntPtr intPtr = Marshal.AllocHGlobal((IntPtr)(count * IntPtr.Size));
		for (nint nint = 0; nint < count; ++nint)
		{
			IntPtr val = items[(long)nint]?.Handle ?? NSNull.Null.Handle;
			Marshal.WriteIntPtr(intPtr, (int)(nint * IntPtr.Size), val);
		}
		IntPtr ptr = NSArray.FromObjects(intPtr, count);
		NSArray<TKey> nSObject = Runtime.GetNSObject<NSArray<TKey>>(ptr);
		Marshal.FreeHGlobal(intPtr);
		return nSObject;
	}

	IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator()
	{
		return new NSFastEnumerator<TKey>(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new NSFastEnumerator<TKey>(this);
	}
}

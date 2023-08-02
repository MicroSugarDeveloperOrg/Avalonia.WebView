using ObjCRuntime;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;

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

    #region
    private const string selAddObserver_ToObjectsAtIndexes_ForKeyPath_Options_Context_ = "addObserver:toObjectsAtIndexes:forKeyPath:options:context:";
    private static readonly IntPtr selAddObserver_ToObjectsAtIndexes_ForKeyPath_Options_Context_Handle = Selector.GetHandle(selAddObserver_ToObjectsAtIndexes_ForKeyPath_Options_Context_);

    private const string selArrayWithContentsOfURL_Error_ = "arrayWithContentsOfURL:error:";
    private static readonly IntPtr selArrayWithContentsOfURL_Error_Handle = Selector.GetHandle(selArrayWithContentsOfURL_Error_);

    private const string selCopyWithZone_ = "copyWithZone:";
    private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle(selCopyWithZone_);

    private const string selWriteToURL_Error_ = "writeToURL:error:";
    private static readonly IntPtr selWriteToURL_Error_Handle = Selector.GetHandle(selWriteToURL_Error_);

    private const string selContainsObject_ = "containsObject:";
    private static readonly IntPtr selContainsObject_Handle = Selector.GetHandle(selContainsObject_);

    private const string selIndexOfObject_ = "indexOfObject:";
    private static readonly IntPtr selIndexOfObject_Handle = Selector.GetHandle("indexOfObject:");

    private const string selMutableCopyWithZone_ = "mutableCopyWithZone:";
    private static readonly IntPtr selMutableCopyWithZone_Handle = Selector.GetHandle(selMutableCopyWithZone_);

    private const string selRemoveObserver_FromObjectsAtIndexes_ForKeyPath_ = "removeObserver:fromObjectsAtIndexes:forKeyPath:";
    private static readonly IntPtr selRemoveObserver_FromObjectsAtIndexes_ForKeyPath_Handle = Selector.GetHandle(selRemoveObserver_FromObjectsAtIndexes_ForKeyPath_);

    private const string selRemoveObserver_FromObjectsAtIndexes_ForKeyPath_Context_ = "removeObserver:fromObjectsAtIndexes:forKeyPath:context:";
    private static readonly IntPtr selRemoveObserver_FromObjectsAtIndexes_ForKeyPath_Context_Handle = Selector.GetHandle(selRemoveObserver_FromObjectsAtIndexes_ForKeyPath_Context_);

    #endregion

    private static readonly IntPtr class_ptr = Class.GetHandle("NSArray");

    public override IntPtr ClassHandle => class_ptr;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public NSArray()
    : base(NSObjectFlag.Empty)
    {
        if (IsDirectBinding)
        {
            Handle = Messaging.IntPtr_objc_msgSend(Handle, Selector.Init);
        }
        else
        {
            Handle = Messaging.IntPtr_objc_msgSendSuper(SuperHandle, Selector.Init);
        }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("initWithCoder:")]
    public NSArray(NSCoder coder)
        : base(NSObjectFlag.Empty)
    {
        if (IsDirectBinding)
        {
            Handle = Messaging.IntPtr_objc_msgSend_IntPtr(Handle, Selector.InitWithCoder, coder.Handle);
        }
        else
        {
            Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, Selector.InitWithCoder, coder.Handle);
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

    public virtual ulong Count
    {
        [Export("count")]
        get
        {
            if (IsDirectBinding)
            {
                return Messaging.UInt64_objc_msgSend(Handle, selCountHandle);
            }
            return Messaging.UInt64_objc_msgSendSuper(SuperHandle, selCountHandle);
        }
    }

    internal NSArray(bool empty)
    {
        Handle = IntPtr.Zero;
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

    [Export("objectAtIndex:")]
    public virtual IntPtr ValueAt(ulong idx)
    {
        if (IsDirectBinding)
        {
            return Messaging.IntPtr_objc_msgSend_UInt64(Handle, selObjectAtIndex_Handle, idx);
        }
        return Messaging.IntPtr_objc_msgSendSuper_UInt64(SuperHandle, selObjectAtIndex_Handle, idx);
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
            return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selValueForKey_Handle, key.Handle));
        }
        return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selValueForKey_Handle, key.Handle));
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
            Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selSetValueForKey_Handle, value.Handle, key.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selSetValueForKey_Handle, value.Handle, key.Handle);
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
        bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool(SuperHandle, selWriteToFileAtomically_Handle, arg, useAuxiliaryFile) : Messaging.bool_objc_msgSend_IntPtr_bool(Handle, selWriteToFileAtomically_Handle, arg, useAuxiliaryFile));
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
        NSArray result = ((!IsDirectBinding) ? ((NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selSortedArrayUsingComparator_Handle, (IntPtr)ptr))) : ((NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selSortedArrayUsingComparator_Handle, (IntPtr)ptr))));
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
            return (NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selFilteredArrayUsingPredicate_Handle, predicate.Handle));
        }
        return (NSArray)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selFilteredArrayUsingPredicate_Handle, predicate.Handle));
    }

    #region

    internal static IntPtr GetAtIndex(IntPtr handle, nuint i)
    {
        return Messaging.IntPtr_objc_msgSend_nuint(handle, selObjectAtIndex_Handle, i);
    }

    internal static uint GetCount(IntPtr handle)
    {
        return Messaging.UInt32_objc_msgSend(handle, selCountHandle);
    }

    internal static NSArray From<T>(T[] items, long count = -1L)
    {
        if (items == null || count == 0)
            return new NSArray();

        if (count == -1)
            count = items.Length;
        else if (count > items.Length)
            throw new ArgumentException("count is larger than the number of items", "count");

        NSObject[] array = new NSObject[count];
        for (long nint = 0; nint < count; ++nint)
        {
            NSObject nSObject = NSObject.FromObject(items[nint]);
            if (nSObject == null)
                throw new ArgumentException($"Do not know how to marshal object of type '{items[nint].GetType()}' to an NSObject");

            array[nint] = nSObject;
        }
        return FromNSObjects(array);
    }

    public static T[] ArrayFromNativeHandle<T>(IntPtr handle) where T : class, INativeObject
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
            array[num2] = Runtime.GetNativeObject<T>(ptr);
        }
        return array;
    }

    public static NSArray FromNSObjectsTx<T>(params T[] items) where T : class, INativeObject
    {
        return FromNativeObjectsTx(items);
    }

    internal static NSArray FromNativeObjectsTx<T>(T[] items) where T : class, INativeObject
    {
        if (items == null)
            return new NSArray();

        return FromNativeObjectsTx(items, items.Length);
    }

    internal static NSArray FromNativeObjectsTx<T>(T[] items, long count) where T : class, INativeObject
    {
        if (items == null)
            return new NSArray();

        if (count > items.Length)
            throw new ArgumentException("count is larger than the number of items", "count");

        IntPtr intPtr = Marshal.AllocHGlobal((IntPtr)(count * IntPtr.Size));
        for (nint nint = 0; nint < count; ++nint)
        {
            IntPtr val = items[(long)nint]?.Handle ?? NSNull.Null.Handle;
            Marshal.WriteIntPtr(intPtr, (int)(nint * IntPtr.Size), val);
        }
        NSArray nSObject = Runtime.GetNSObjectTx<NSArray>(_FromObjects(intPtr, count));
        Marshal.FreeHGlobal(intPtr);
        return nSObject;
    }

    private static T UnsafeGetItem<T>(IntPtr handle, nuint index) where T : class, INativeObject
    {
        IntPtr atIndex = GetAtIndex(handle, index);
        if (atIndex == NSNull.Null.Handle)
            return null;

        return Runtime.GetNativeObject<T>(atIndex);
    }

    public T GetItem<T>(nuint index) where T : class, INativeObject
    {
        if (index >= GetCount(Handle))
            throw new ArgumentOutOfRangeException("index");

        return UnsafeGetItem<T>(Handle, index);
    }

    [Export(selAddObserver_ToObjectsAtIndexes_ForKeyPath_Options_Context_)]
    public virtual void AddObserver(NSObject observer, NSIndexSet indexes, string keyPath, NSKeyValueObservingOptions options, IntPtr context)
    {
        if (observer == null)
            throw new ArgumentNullException("observer");

        if (indexes == null)
            throw new ArgumentNullException("indexes");

        if (keyPath == null)
            throw new ArgumentNullException("keyPath");

        IntPtr arg = NSString.CreateNative(keyPath);
        if (IsDirectBinding)
            Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt64_IntPtr(Handle, selAddObserver_ToObjectsAtIndexes_ForKeyPath_Options_Context_Handle, observer.Handle, indexes.Handle, arg, (ulong)options, context);

        else
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt64_IntPtr(SuperHandle, selAddObserver_ToObjectsAtIndexes_ForKeyPath_Options_Context_Handle, observer.Handle, indexes.Handle, arg, (ulong)options, context);

        NSString.ReleaseNative(arg);
    }

    [Export(selArrayWithContentsOfURL_Error_)]
    public static NSArray? FromUrl(NSUrl url, out NSError error)
    {
        if (url == null)
            throw new ArgumentNullException("url");

        IntPtr arg = IntPtr.Zero;
        NSArray nSObject = Runtime.GetNSObjectTx<NSArray>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selArrayWithContentsOfURL_Error_Handle, url.Handle, ref arg));
        error = Runtime.GetNSObjectTx<NSError>(arg);
        return nSObject;
    }

    [Export(selCopyWithZone_)]
    public virtual NSObject Copy(NSZone? zone)
    {
        NSObject nSObject = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
        if (nSObject != null)
            Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));

        return nSObject;
    }

    [Export(selWriteToURL_Error_)]
    public virtual bool Write(NSUrl url, out NSError error)
    {
        if (url == null)
            throw new ArgumentNullException("url");

        IntPtr arg = IntPtr.Zero;
        bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(SuperHandle, selWriteToURL_Error_Handle, url.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(Handle, selWriteToURL_Error_Handle, url.Handle, ref arg));
        error = Runtime.GetNSObjectTx<NSError>(arg);
        return result;
    }

    [Export(selContainsObject_)]
    public virtual bool Contains(NSObject anObject)
    {
        if (anObject == null)
            throw new ArgumentNullException("anObject");

        if (IsDirectBinding)
            return Messaging.bool_objc_msgSend_IntPtr(Handle, selContainsObject_Handle, anObject.Handle);

        return Messaging.bool_objc_msgSendSuper_IntPtr(SuperHandle, selContainsObject_Handle, anObject.Handle);
    }

    [Export(selIndexOfObject_)]
    public virtual nuint IndexOf(NSObject anObject)
    {
        if (anObject == null)
            throw new ArgumentNullException("anObject");

        if (IsDirectBinding)
            return Messaging.nuint_objc_msgSend_IntPtr(Handle, selIndexOfObject_Handle, anObject.Handle);

        return Messaging.nuint_objc_msgSendSuper_IntPtr(SuperHandle, selIndexOfObject_Handle, anObject.Handle);
    }

    [Export(selMutableCopyWithZone_)]
    public virtual NSObject MutableCopy(NSZone? zone)
    {
        NSObject nSObject = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
        if (nSObject != null)
            Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));

        return nSObject;
    }

    [Export(selRemoveObserver_FromObjectsAtIndexes_ForKeyPath_)]
    public virtual void RemoveObserver(NSObject observer, NSIndexSet indexes, string keyPath)
    {
        if (observer == null)
            throw new ArgumentNullException("observer");

        if (indexes == null)
            throw new ArgumentNullException("indexes");

        if (keyPath == null)
            throw new ArgumentNullException("keyPath");

        IntPtr arg = NSString.CreateNative(keyPath);
        if (IsDirectBinding)
            Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(Handle, selRemoveObserver_FromObjectsAtIndexes_ForKeyPath_Handle, observer.Handle, indexes.Handle, arg);
        else
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(SuperHandle, selRemoveObserver_FromObjectsAtIndexes_ForKeyPath_Handle, observer.Handle, indexes.Handle, arg);

        NSString.ReleaseNative(arg);
    }

    [Export("removeObserver:fromObjectsAtIndexes:forKeyPath:context:")]
    public virtual void RemoveObserver(NSObject observer, NSIndexSet indexes, string keyPath, IntPtr context)
    {
        if (observer == null)
            throw new ArgumentNullException("observer");

        if (indexes == null)
            throw new ArgumentNullException("indexes");

        if (keyPath == null)
            throw new ArgumentNullException("keyPath");

        IntPtr arg = NSString.CreateNative(keyPath);
        if (IsDirectBinding)
            Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(Handle, selRemoveObserver_FromObjectsAtIndexes_ForKeyPath_Context_Handle, observer.Handle, indexes.Handle, arg, context);
        else
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(SuperHandle, selRemoveObserver_FromObjectsAtIndexes_ForKeyPath_Context_Handle, observer.Handle, indexes.Handle, arg, context);

        NSString.ReleaseNative(arg);
    }

    internal bool _Contains(IntPtr anObject)
    {
        return Messaging.bool_objc_msgSend_IntPtr(Handle, selContainsObject_Handle, anObject);
    }

    internal nuint _IndexOf(IntPtr anObject)
    {
        return Messaging.nuint_objc_msgSend_IntPtr(Handle, selIndexOfObject_Handle, anObject);
    }

    internal static IntPtr _FromObjects(IntPtr array, long count)
    {
        return Messaging.IntPtr_objc_msgSend_IntPtr_long(class_ptr, selArrayWithObjectsCount_Handle, array, count);
    }

    #endregion
}

[Register("NSArray", SkipRegistration = true)]
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
        IntPtr ptr = NSArray._FromObjects(intPtr, count);
        NSArray<TKey> nSObject = Runtime.GetNSObjectTx<NSArray<TKey>>(ptr);
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
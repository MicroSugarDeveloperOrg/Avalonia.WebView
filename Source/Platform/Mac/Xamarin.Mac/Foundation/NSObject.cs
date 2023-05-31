using CoreGraphics;
using ObjCRuntime;
using System.Reflection;
using System.Runtime.InteropServices;
using Xamarin.Utiles;

namespace Foundation;

[StructLayout(LayoutKind.Sequential)]
[Register("NSObject", true)]
public class NSObject : INativeObject, IDisposable
{
    [Flags]
    internal enum Flags : byte
    {
        Disposed = 1,
        NativeRef = 2,
        IsDirectBinding = 4,
        RegisteredToggleRef = 8,
        InFinalizerQueue = 0x10,
        HasManagedRef = 0x20,
        IsCustomType = 0x80
    }

    private struct objc_super
    {
        public IntPtr receiver;

        public IntPtr super;
    }

    [Register("__NSObject_Disposer")]
    [Preserve(AllMembers = true)]
    internal class NSObject_Disposer : NSObject
    {
        private static readonly List<NSObject> drainList1 = new List<NSObject>();

        private static readonly List<NSObject> drainList2 = new List<NSObject>();

        private static List<NSObject> handles = drainList1;

        private new static readonly IntPtr class_ptr = Class.GetHandle("__NSObject_Disposer");

        private static readonly IntPtr drainHandle = Selector.GetHandle("drain:");

        private new static readonly object lock_obj = new object();

        private NSObject_Disposer()
        {
        }

        internal static void Add(NSObject handle)
        {
            bool flag;
            lock (lock_obj)
            {
                handles.Add(handle);
                flag = handles.Count == 1;
            }
            if (flag)
            {
                Messaging.void_objc_msgSend_intptr_intptr_bool(class_ptr, Selector.PerformSelectorOnMainThreadWithObjectWaitUntilDoneHandle, drainHandle, IntPtr.Zero, arg3: false);
            }
        }

        [Export("drain:")]
        private static void Drain(NSObject ctx)
        {
            List<NSObject> list;
            lock (lock_obj)
            {
                list = handles;
                if (handles == drainList1)
                {
                    handles = drainList2;
                }
                else
                {
                    handles = drainList1;
                }
            }
            foreach (NSObject item in list)
            {
                item.ReleaseManagedRef();
            }
            list.Clear();
        }
    }

    private delegate IntPtr RetainTrampolineDelegate(IntPtr @this, IntPtr sel);

    private delegate void ReleaseTrampolineDelegate(IntPtr @this, IntPtr sel);

    private const string selConformsToProtocol = "conformsToProtocol:";

    private const string selEncodeWithCoder = "encodeWithCoder:";

    private const string selAwakeFromNib = "awakeFromNib";

    private const string selRespondsToSelector = "respondsToSelector:";

    private static IntPtr selConformsToProtocolHandle = Selector.GetHandle("conformsToProtocol:");

    private static IntPtr selEncodeWithCoderHandle = Selector.GetHandle("encodeWithCoder:");

    private static IntPtr selAwakeFromNibHandle = Selector.GetHandle("awakeFromNib");

    private static IntPtr selRespondsToSelectorHandle = Selector.GetHandle("respondsToSelector:");

    private IntPtr handle;

    private IntPtr super;

    private bool disposed;

    internal bool IsDirectBinding;

    public static readonly Assembly MonoMacAssembly = typeof(NSObject).Assembly;

    private IntPtr gchandle;

    private bool has_managed_ref;

    private static object lock_obj = new object();

    private static IntPtr RetainTrampolineFunctionPointer;

    private static IntPtr ReleaseTrampolineFunctionPointer;

    private static RetainTrampolineDelegate retainTrampoline;

    private static ReleaseTrampolineDelegate releaseTrampoline;

    private static readonly IntPtr selDescriptionHandle = Selector.GetHandle("description");

    private static readonly IntPtr selDebugDescriptionHandle = Selector.GetHandle("debugDescription");

    private static readonly IntPtr selObserveValueForKeyPathOfObjectChangeContext_Handle = Selector.GetHandle("observeValueForKeyPath:ofObject:change:context:");

    private static readonly IntPtr selAddObserverForKeyPathOptionsContext_Handle = Selector.GetHandle("addObserver:forKeyPath:options:context:");

    private static readonly IntPtr selRemoveObserverForKeyPath_Handle = Selector.GetHandle("removeObserver:forKeyPath:");

    private static readonly IntPtr selWillChangeValueForKey_Handle = Selector.GetHandle("willChangeValueForKey:");

    private static readonly IntPtr selDidChangeValueForKey_Handle = Selector.GetHandle("didChangeValueForKey:");

    private static readonly IntPtr selWillChangeValuesAtIndexesForKey_Handle = Selector.GetHandle("willChange:valuesAtIndexes:forKey:");

    private static readonly IntPtr selDidChangeValuesAtIndexesForKey_Handle = Selector.GetHandle("didChange:valuesAtIndexes:forKey:");

    private static readonly IntPtr selWillChangeValueForKeyWithSetMutationUsingObjects_Handle = Selector.GetHandle("willChangeValueForKey:withSetMutation:usingObjects:");

    private static readonly IntPtr selDidChangeValueForKeyWithSetMutationUsingObjects_Handle = Selector.GetHandle("didChangeValueForKey:withSetMutation:usingObjects:");

    private static readonly IntPtr selKeyPathsForValuesAffectingValueForKey_Handle = Selector.GetHandle("keyPathsForValuesAffectingValueForKey:");

    private static readonly IntPtr selAutomaticallyNotifiesObserversForKey_Handle = Selector.GetHandle("automaticallyNotifiesObserversForKey:");

    private static readonly IntPtr selValueForKey_Handle = Selector.GetHandle("valueForKey:");

    private static readonly IntPtr selSetValueForKey_Handle = Selector.GetHandle("setValue:forKey:");

    private static readonly IntPtr selValueForKeyPath_Handle = Selector.GetHandle("valueForKeyPath:");

    private static readonly IntPtr selSetValueForKeyPath_Handle = Selector.GetHandle("setValue:forKeyPath:");

    private static readonly IntPtr selValueForUndefinedKey_Handle = Selector.GetHandle("valueForUndefinedKey:");

    private static readonly IntPtr selSetValueForUndefinedKey_Handle = Selector.GetHandle("setValue:forUndefinedKey:");

    private static readonly IntPtr selSetNilValueForKey_Handle = Selector.GetHandle("setNilValueForKey:");

    private static readonly IntPtr selDictionaryWithValuesForKeys_Handle = Selector.GetHandle("dictionaryWithValuesForKeys:");

    private static readonly IntPtr selSetValuesForKeysWithDictionary_Handle = Selector.GetHandle("setValuesForKeysWithDictionary:");

    private static readonly IntPtr selExposedBindingsHandle = Selector.GetHandle("exposedBindings");

    private static readonly IntPtr selValueClassForBinding_Handle = Selector.GetHandle("valueClassForBinding:");

    private static readonly IntPtr selBindToObjectWithKeyPathOptions_Handle = Selector.GetHandle("bind:toObject:withKeyPath:options:");

    private static readonly IntPtr selUnbind_Handle = Selector.GetHandle("unbind:");

    private static readonly IntPtr selInfoForBinding_Handle = Selector.GetHandle("infoForBinding:");

    private static readonly IntPtr selOptionDescriptionsForBinding_Handle = Selector.GetHandle("optionDescriptionsForBinding:");

    private static readonly IntPtr selDefaultPlaceholderForMarkerWithBinding_Handle = Selector.GetHandle("defaultPlaceholderForMarker:withBinding:");

    private static readonly IntPtr selSetDefaultPlaceholderForMarkerWithBinding_Handle = Selector.GetHandle("setDefaultPlaceholder:forMarker:withBinding:");

    private static readonly IntPtr selObjectDidEndEditing_Handle = Selector.GetHandle("objectDidEndEditing:");

    private static readonly IntPtr selCommitEditingHandle = Selector.GetHandle("commitEditing");

    private static readonly IntPtr selCommitEditingWithDelegateDidCommitSelectorContextInfo_Handle = Selector.GetHandle("commitEditingWithDelegate:didCommitSelector:contextInfo:");

    private static readonly IntPtr selCopyHandle = Selector.GetHandle("copy");

    private static readonly IntPtr selMutableCopyHandle = Selector.GetHandle("mutableCopy");

    private static readonly IntPtr selPerformSelectorWithObjectAfterDelayInModes_Handle = Selector.GetHandle("performSelector:withObject:afterDelay:inModes:");

    private static readonly IntPtr selPerformSelectorOnThreadWithObjectWaitUntilDone_Handle = Selector.GetHandle("performSelector:onThread:withObject:waitUntilDone:");

    private static readonly IntPtr selPerformSelectorOnThreadWithObjectWaitUntilDoneModes_Handle = Selector.GetHandle("performSelector:onThread:withObject:waitUntilDone:modes:");

    private static readonly IntPtr selCancelPreviousPerformRequestsWithTarget_Handle = Selector.GetHandle("cancelPreviousPerformRequestsWithTarget:");

    private static readonly IntPtr selCancelPreviousPerformRequestsWithTargetSelectorObject_Handle = Selector.GetHandle("cancelPreviousPerformRequestsWithTarget:selector:object:");

    private static readonly IntPtr class_ptr = Class.GetHandle("NSObject");

    private static NSString _ChangeKindKey;

    private static NSString _ChangeNewKey;

    private static NSString _ChangeOldKey;

    private static NSString _ChangeIndexesKey;

    private static NSString _ChangeNotificationIsPriorKey;

    private static IntPtr fl = Dlfcn.dlopen("/System/Library/Frameworks/Foundation.framework/Foundation", 1);

    private static IntPtr al = Dlfcn.dlopen("/System/Library/Frameworks/AppKit.framework/AppKit", 1);

    private static IntPtr ab = Dlfcn.dlopen("/System/Library/Frameworks/AddressBook.framework/AddressBook", 1);

    private static IntPtr ct = Dlfcn.dlopen("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText", 1);

    private static IntPtr wl = Dlfcn.dlopen("/System/Library/Frameworks/WebKit.framework/WebKit", 1);

    private static IntPtr zl = Dlfcn.dlopen("/System/Library/Frameworks/QuartzCore.framework/QuartzCore", 1);

    private static IntPtr ql = Dlfcn.dlopen("/System/Library/Frameworks/QTKit.framework/QTKit", 1);

    private static IntPtr cl = Dlfcn.dlopen("/System/Library/Frameworks/CoreLocation.framework/CoreLocation", 1);

    private static IntPtr ll = Dlfcn.dlopen("/System/Library/Frameworks/Security.framework/Security", 1);

    private static IntPtr zc = Dlfcn.dlopen("/System/Library/Frameworks/Quartz.framework/Frameworks/QuartzComposer.framework/QuartzComposer", 1);

    private static IntPtr cw = Dlfcn.dlopen("/System/Library/Frameworks/CoreWLAN.framework/CoreWLAN", 1);

    private static IntPtr pk = Dlfcn.dlopen("/System/Library/Frameworks/Quartz.framework/Frameworks/PDFKit.framework/PDFKit", 1);

    private static IntPtr ik = Dlfcn.dlopen("/System/Library/Frameworks/Quartz.framework/Frameworks/ImageKit.framework/ImageKit", 1);

    private static IntPtr sb = Dlfcn.dlopen("/System/Library/Frameworks/ScriptingBridge.framework/ScriptingBridge", 1);

    private static IntPtr av = Dlfcn.dlopen("/System/Library/Frameworks/AVFoundation.framework/AVFoundation", 1);

    public unsafe IntPtr SuperHandle
    {
        get
        {
            if (super == IntPtr.Zero)
            {
                super = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(objc_super)));
                objc_super* ptr = (objc_super*)(void*)super;
                ptr->receiver = handle;
                ptr->super = ClassHandle;
            }
            return super;
        }
    }

    public IntPtr Handle
    {
        get
        {
            return handle;
        }
        set
        {
            if (!(handle == value))
            {
                if (handle != IntPtr.Zero)
                {
                    Runtime.UnregisterNSObject(handle);
                }
                handle = value;
                if (handle != IntPtr.Zero)
                {
                    Runtime.RegisterNSObject(this, handle);
                }
            }
        }
    }

    [Export("retainCount")]
    public virtual int RetainCount
    {
        get
        {
            if (IsDirectBinding)
            {
                return Messaging.int_objc_msgSend(Handle, Selector.RetainCount);
            }
            return Messaging.int_objc_msgSendSuper(SuperHandle, Selector.RetainCount);
        }
    }

    public virtual IntPtr ClassHandle => class_ptr;

    public virtual string Description
    {
        [Export("description")]
        get
        {
            if (IsDirectBinding)
            {
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(Handle, selDescriptionHandle));
            }
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selDescriptionHandle));
        }
    }

    public virtual string DebugDescription
    {
        [Export("debugDescription")]
        get
        {
            if (IsDirectBinding)
            {
                return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(Handle, selDebugDescriptionHandle));
            }
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selDebugDescriptionHandle));
        }
    }

    [Field("NSKeyValueChangeKindKey", "Foundation")]
    public static NSString ChangeKindKey
    {
        get
        {
            if (_ChangeKindKey == null)
            {
                _ChangeKindKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSKeyValueChangeKindKey");
            }
            return _ChangeKindKey;
        }
    }

    [Field("NSKeyValueChangeNewKey", "Foundation")]
    public static NSString ChangeNewKey
    {
        get
        {
            if (_ChangeNewKey == null)
            {
                _ChangeNewKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSKeyValueChangeNewKey");
            }
            return _ChangeNewKey;
        }
    }

    [Field("NSKeyValueChangeOldKey", "Foundation")]
    public static NSString ChangeOldKey
    {
        get
        {
            if (_ChangeOldKey == null)
            {
                _ChangeOldKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSKeyValueChangeOldKey");
            }
            return _ChangeOldKey;
        }
    }

    [Field("NSKeyValueChangeIndexesKey", "Foundation")]
    public static NSString ChangeIndexesKey
    {
        get
        {
            if (_ChangeIndexesKey == null)
            {
                _ChangeIndexesKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSKeyValueChangeIndexesKey");
            }
            return _ChangeIndexesKey;
        }
    }

    [Field("NSKeyValueChangeNotificationIsPriorKey", "Foundation")]
    public static NSString ChangeNotificationIsPriorKey
    {
        get
        {
            if (_ChangeNotificationIsPriorKey == null)
            {
                _ChangeNotificationIsPriorKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSKeyValueChangeNotificationIsPriorKey");
            }
            return _ChangeNotificationIsPriorKey;
        }
    }

    [Export("init")]
    public NSObject()
    {
        bool alloced = AllocIfNeeded();
        InitializeObject(alloced);
    }

    public NSObject(NSObjectFlag x)
    {
        bool alloced = AllocIfNeeded();
        InitializeObject(alloced);
    }

    public NSObject(IntPtr handle)
        : this(handle, alloced: false)
    {
    }

    public NSObject(IntPtr handle, bool alloced)
    {
        this.handle = handle;
        InitializeObject(alloced);
    }

    ~NSObject()
    {
        Dispose(disposing: false);
    }

    protected void InitializeHandle(IntPtr selector)
    {
        if (IsDirectBinding)
            Handle = Messaging.IntPtr_objc_msgSend(Handle, selector);
        else
            Handle = Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selector);
    }

    protected void InitializeHandle(IntPtr selector, NSCoder coder)
    {
        if (IsDirectBinding)
            Handle = Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selector, coder.Handle);
        else
            Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selector, coder.Handle);
    }

    protected void InitializeWithHandle(IntPtr handle)
    {
        Handle = handle;
    }

    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    [Export("encodeWithCoder:")]
    public virtual void EncodeTo(NSCoder coder)
    {
        if (coder == null)
        {
            throw new ArgumentNullException("coder");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_intptr(Handle, selEncodeWithCoderHandle, coder.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_intptr(SuperHandle, selEncodeWithCoderHandle, coder.Handle);
        }
    }

    [Export("conformsToProtocol:")]
    [Preserve]
    public virtual bool ConformsToProtocol(IntPtr protocol)
    {
        if ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_intptr(SuperHandle, selConformsToProtocolHandle, protocol) : Messaging.bool_objc_msgSend_intptr(Handle, selConformsToProtocolHandle, protocol))
        {
            return true;
        }
        object[] customAttributes = GetType().GetCustomAttributes(typeof(AdoptsAttribute), inherit: true);
        for (int i = 0; i < customAttributes.Length; i++)
        {
            if (((AdoptsAttribute)customAttributes[i]).ProtocolHandle == protocol)
            {
                return true;
            }
        }
        return false;
    }

    [Export("respondsToSelector:")]
    public virtual bool RespondsToSelector(Selector sel)
    {
        if (IsDirectBinding)
        {
            return Messaging.bool_objc_msgSend_intptr(Handle, selRespondsToSelectorHandle, sel.Handle);
        }
        return Messaging.bool_objc_msgSendSuper_intptr(SuperHandle, selRespondsToSelectorHandle, sel.Handle);
    }

    [Export("doesNotRecognizeSelector:")]
    public virtual void DoesNotRecognizeSelector(Selector sel)
    {
        Messaging.void_objc_msgSendSuper_intptr(SuperHandle, Selector.DoesNotRecognizeSelectorHandle, sel.Handle);
    }

    public void Release()
    {
        Messaging.void_objc_msgSend(handle, Selector.ReleaseHandle);
    }

    public NSObject Retain()
    {
        Messaging.void_objc_msgSend(handle, Selector.RetainHandle);
        return this;
    }

    public NSObject Autorelease()
    {
        Messaging.void_objc_msgSend(handle, Selector.AutoreleaseHandle);
        return this;
    }

    private bool AllocIfNeeded()
    {
        if (handle == IntPtr.Zero)
        {
            handle = Messaging.intptr_objc_msgSend(Class.GetHandle(GetType()), Selector.AllocHandle);
            return true;
        }
        return false;
    }

    private IntPtr GetObjCIvar(string name)
    {
        object_getInstanceVariable(handle, name, out var val);
        return val;
    }

    public NSObject GetNativeField(string name)
    {
        IntPtr objCIvar = GetObjCIvar(name);
        if (objCIvar == IntPtr.Zero)
        {
            return null;
        }
        return Runtime.GetNSObject(objCIvar);
    }

    private void SetObjCIvar(string name, IntPtr value)
    {
        object_setInstanceVariable(handle, name, value);
    }

    public void SetNativeField(string name, NSObject value)
    {
        if (value == null)
        {
            SetObjCIvar(name, IntPtr.Zero);
        }
        else
        {
            SetObjCIvar(name, value.Handle);
        }
    }

    [DllImport("/usr/lib/libobjc.dylib")]
    private static extern void object_getInstanceVariable(IntPtr obj, string name, out IntPtr val);

    [DllImport("/usr/lib/libobjc.dylib")]
    private static extern void object_setInstanceVariable(IntPtr obj, string name, IntPtr val);

    [Export("performSelector:withObject:afterDelay:")]
    public virtual void PerformSelector(Selector sel, NSObject obj, double delay)
    {
        if (sel == null)
        {
            throw new ArgumentNullException("sel");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_intptr_intptr_double(Handle, Selector.PerformSelectorWithObjectAfterDelayHandle, sel.Handle, obj?.Handle ?? IntPtr.Zero, delay);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_intptr_intptr_double(SuperHandle, Selector.PerformSelectorWithObjectAfterDelayHandle, sel.Handle, obj?.Handle ?? IntPtr.Zero, delay);
        }
    }

    [Export("awakeFromNib")]
    public virtual void AwakeFromNib()
    {
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend(Handle, selAwakeFromNibHandle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper(SuperHandle, selAwakeFromNibHandle);
        }
    }

    private void InvokeOnMainThread(Selector sel, NSObject obj, bool wait)
    {
        Messaging.void_objc_msgSend_intptr_intptr_bool(Handle, Selector.PerformSelectorOnMainThreadWithObjectWaitUntilDoneHandle, sel.Handle, obj?.Handle ?? IntPtr.Zero, wait);
    }

    public void BeginInvokeOnMainThread(Selector sel, NSObject obj)
    {
        InvokeOnMainThread(sel, obj, wait: false);
    }

    public void InvokeOnMainThread(Selector sel, NSObject obj)
    {
        InvokeOnMainThread(sel, obj, wait: true);
    }

    public void BeginInvokeOnMainThread(NSAction action)
    {
        NSAsyncActionDispatcher nSAsyncActionDispatcher = new NSAsyncActionDispatcher(action);
        Messaging.void_objc_msgSend_intptr_intptr_bool(nSAsyncActionDispatcher.Handle, Selector.PerformSelectorOnMainThreadWithObjectWaitUntilDoneHandle, NSActionDispatcher.Selector.Handle, nSAsyncActionDispatcher.Handle, arg3: false);
    }

    public void InvokeOnMainThread(NSAction action)
    {
        using NSActionDispatcher nSActionDispatcher = new NSActionDispatcher(action);
        Messaging.void_objc_msgSend_intptr_intptr_bool(nSActionDispatcher.Handle, Selector.PerformSelectorOnMainThreadWithObjectWaitUntilDoneHandle, NSActionDispatcher.Selector.Handle, nSActionDispatcher.Handle, arg3: true);
    }

    public static NSObject FromObject(object obj)
    {
        if (obj == null)
        {
            return NSNull.Null;
        }
        Type type = obj.GetType();
        if (type == typeof(NSObject) || type.IsSubclassOf(typeof(NSObject)))
        {
            return (NSObject)obj;
        }
        switch (Type.GetTypeCode(type))
        {
            case TypeCode.Boolean:
                return new NSNumber((bool)obj);
            case TypeCode.Char:
                return new NSNumber((char)obj);
            case TypeCode.SByte:
                return new NSNumber((sbyte)obj);
            case TypeCode.Byte:
                return new NSNumber((byte)obj);
            case TypeCode.Int16:
                return new NSNumber((short)obj);
            case TypeCode.UInt16:
                return new NSNumber((ushort)obj);
            case TypeCode.Int32:
                return new NSNumber((int)obj);
            case TypeCode.UInt32:
                return new NSNumber((uint)obj);
            case TypeCode.Int64:
                return new NSNumber((long)obj);
            case TypeCode.UInt64:
                return new NSNumber((ulong)obj);
            case TypeCode.Single:
                return new NSNumber((float)obj);
            case TypeCode.Double:
                return new NSNumber((double)obj);
            case TypeCode.String:
                return new NSString((string)obj);
            default:
                if (type == typeof(IntPtr))
                {
                    return NSValue.ValueFromPointer((IntPtr)obj);
                }
                if (type == typeof(CGSize))
                {
                    return NSValue.FromSize((CGSize)obj);
                }
                if (type == typeof(CGRect))
                {
                    return NSValue.FromRectangle((CGRect)obj);
                }
                if (type == typeof(CGPoint))
                {
                    return NSValue.FromPoint((CGPoint)obj);
                }
                if (obj is INativeObject nativeObject)
                {
                    return Runtime.GetNSObject(nativeObject.Handle);
                }
                return null;
        }
    }

    public void SetValueForKeyPath(IntPtr handle, NSString keyPath)
    {
        if (keyPath == null)
        {
            throw new ArgumentNullException("keyPath");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selSetValueForKeyPath_Handle, handle, keyPath.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selSetValueForKeyPath_Handle, handle, keyPath.Handle);
        }
    }

    public override string ToString()
    {
        return Description ?? base.ToString();
    }

    public virtual void Invoke(NSAction action, double delay)
    {
        NSAsyncActionDispatcher obj = new NSAsyncActionDispatcher(action);
        PerformSelector(NSActionDispatcher.Selector, obj, delay);
    }

    public virtual void Invoke(NSAction action, TimeSpan delay)
    {
        NSAsyncActionDispatcher obj = new NSAsyncActionDispatcher(action);
        PerformSelector(NSActionDispatcher.Selector, obj, delay.TotalSeconds);
    }

    internal void ClearHandle()
    {
        handle = IntPtr.Zero;
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposed)
        {
            return;
        }
        disposed = true;
        if (handle != IntPtr.Zero)
        {
            if (disposing)
            {
                ReleaseManagedRef();
            }
            else
            {
                NSObject_Disposer.Add(this);
            }
        }
        if (super != IntPtr.Zero)
        {
            Marshal.FreeHGlobal(super);
            super = IntPtr.Zero;
        }
    }

    private void InitializeObject(bool alloced)
    {
        if (alloced && handle == IntPtr.Zero && Class.ThrowOnInitFailure)
        {
            if (ClassHandle == IntPtr.Zero)
            {
                throw new Exception($"Could not create an native instance of the type '{GetType().FullName}': the native class hasn't been loaded.\nIt is possible to ignore this condition by setting ObjCRuntime.Class.ThrowOnInitFailure to false.");
            }
            throw new Exception($"Failed to create a instance of the native type '{new Class(ClassHandle).Name}'.\nIt is possible to ignore this condition by setting ObjCRuntime.Class.ThrowOnInitFailure to false.");
        }
        IsDirectBinding = GetType().Assembly == MonoMacAssembly;
        Runtime.RegisterNSObject(this, handle);
        CreateManagedRef(!alloced);
    }

    private static int GetRetainCount(IntPtr @this)
    {
        return Messaging.int_objc_msgSend(@this, Selector.RetainCount);
    }

    private void UnregisterObject()
    {
        Runtime.NativeObjectHasDied(handle);
    }

    private void FreeGCHandle()
    {
        if (gchandle != IntPtr.Zero)
        {
            GCHandle.FromIntPtr(gchandle).Free();
            gchandle = IntPtr.Zero;
        }
    }

    private void SwitchGCHandle(bool to_weak)
    {
        if (gchandle != IntPtr.Zero)
        {
            GCHandle.FromIntPtr(gchandle).Free();
        }
        if (to_weak)
        {
            gchandle = GCHandle.ToIntPtr(GCHandle.Alloc(this, GCHandleType.WeakTrackResurrection));
        }
        else
        {
            gchandle = GCHandle.ToIntPtr(GCHandle.Alloc(this, GCHandleType.Normal));
        }
    }

    internal static void OverrideRetainAndRelease(IntPtr @class)
    {
        lock (lock_obj)
        {
            if (ReleaseTrampolineFunctionPointer == IntPtr.Zero)
            {
                retainTrampoline = RetainTrampoline;
                releaseTrampoline = ReleaseTrampoline;
                RetainTrampolineFunctionPointer = Marshal.GetFunctionPointerForDelegate(retainTrampoline);
                ReleaseTrampolineFunctionPointer = Marshal.GetFunctionPointerForDelegate(releaseTrampoline);
            }
        }
        Class.class_addMethod(@class, Selector.RetainHandle, RetainTrampolineFunctionPointer, "@@:");
        Class.class_addMethod(@class, Selector.ReleaseHandle, ReleaseTrampolineFunctionPointer, "v@:");
    }

    private static bool IsUserType(IntPtr @this)
    {
        IntPtr intPtr = object_getClass(@this);
        if (Class.class_getMethodImplementation(intPtr, Selector.RetainHandle) == RetainTrampolineFunctionPointer)
        {
            return true;
        }
        Type type = Class.Lookup(intPtr, throw_on_error: false);
        if (type != null)
        {
            return Class.IsCustomType(type);
        }
        return false;
    }

    private void CreateGCHandle(bool force_weak)
    {
        bool num = force_weak || GetRetainCount(handle) == 1;
        has_managed_ref = true;
        if (num)
        {
            gchandle = GCHandle.ToIntPtr(GCHandle.Alloc(this, GCHandleType.WeakTrackResurrection));
        }
        else
        {
            gchandle = GCHandle.ToIntPtr(GCHandle.Alloc(this, GCHandleType.Normal));
        }
    }

    private void CreateManagedRef(bool retain)
    {
        if (IsUserType(handle) && gchandle == IntPtr.Zero)
        {
            CreateGCHandle(!retain);
        }
        if (retain)
        {
            Messaging.void_objc_msgSend(handle, Selector.RetainHandle);
        }
    }

    private void ReleaseManagedRef()
    {
        IntPtr intPtr = handle;
        if (IsUserType(intPtr))
        {
            has_managed_ref = false;
        }
        else
        {
            UnregisterObject();
        }
        Messaging.void_objc_msgSend(intPtr, Selector.ReleaseHandle);
    }

    [DllImport("/usr/lib/libobjc.dylib")]
    private static extern IntPtr object_getClass(IntPtr @this);

    [DllImport("/usr/lib/libobjc.dylib")]
    private static extern IntPtr objc_msgSendSuper(ref objc_super super, IntPtr selector);

    private static IntPtr InvokeObjCMethodImplementation(IntPtr @this, IntPtr sel)
    {
        IntPtr cls = object_getClass(@this);
        IntPtr cls2 = Class.class_getSuperclass(cls);
        IntPtr intPtr = Class.class_getMethodImplementation(cls, sel);
        IntPtr intPtr2 = Class.class_getMethodImplementation(cls2, sel);
        while (intPtr == intPtr2)
        {
            cls2 = Class.class_getSuperclass(cls2);
            intPtr2 = Class.class_getMethodImplementation(cls2, sel);
        }
        objc_super objc_super = default(objc_super);
        objc_super.receiver = @this;
        objc_super.super = cls2;
        return objc_msgSendSuper(ref objc_super, sel);
    }

    private static void ReleaseTrampoline(IntPtr @this, IntPtr sel)
    {
        int num = Messaging.int_objc_msgSend(@this, Selector.RetainCount);
        NSObject nSObject = null;
        if (num == 1)
        {
            nSObject = Runtime.TryGetNSObject(@this);
            if (nSObject != null)
            {
                nSObject.UnregisterObject();
                nSObject.FreeGCHandle();
            }
        }
        if (num == 2)
        {
            nSObject = Runtime.TryGetNSObject(@this);
            if (nSObject != null && nSObject.has_managed_ref)
            {
                nSObject.SwitchGCHandle(to_weak: true);
            }
        }
        InvokeObjCMethodImplementation(@this, sel);
    }

    private static IntPtr RetainTrampoline(IntPtr @this, IntPtr sel)
    {
        int num = Messaging.int_objc_msgSend(@this, Selector.RetainCount);
        NSObject nSObject = null;
        if (num == 1)
        {
            nSObject = Runtime.TryGetNSObject(@this);
            if (nSObject != null && nSObject.has_managed_ref)
            {
                nSObject.SwitchGCHandle(to_weak: false);
            }
        }
        @this = InvokeObjCMethodImplementation(@this, sel);
        return @this;
    }

    internal void SetAsProxy()
    {
        IsDirectBinding = true;
    }

    [Export("observeValueForKeyPath:ofObject:change:context:")]
    public virtual void ObserveValue(NSString keyPath, NSObject ofObject, NSDictionary change, IntPtr context)
    {
        if (keyPath == null)
        {
            throw new ArgumentNullException("keyPath");
        }
        if (ofObject == null)
        {
            throw new ArgumentNullException("ofObject");
        }
        if (change == null)
        {
            throw new ArgumentNullException("change");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(Handle, selObserveValueForKeyPathOfObjectChangeContext_Handle, keyPath.Handle, ofObject.Handle, change.Handle, context);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(SuperHandle, selObserveValueForKeyPathOfObjectChangeContext_Handle, keyPath.Handle, ofObject.Handle, change.Handle, context);
        }
    }

    [Export("addObserver:forKeyPath:options:context:")]
    public virtual void AddObserver(NSObject observer, NSString keyPath, NSKeyValueObservingOptions options, IntPtr context)
    {
        if (observer == null)
        {
            throw new ArgumentNullException("observer");
        }
        if (keyPath == null)
        {
            throw new ArgumentNullException("keyPath");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr(Handle, selAddObserverForKeyPathOptionsContext_Handle, observer.Handle, keyPath.Handle, (ulong)options, context);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr(SuperHandle, selAddObserverForKeyPathOptionsContext_Handle, observer.Handle, keyPath.Handle, (ulong)options, context);
        }
    }

    [Export("removeObserver:forKeyPath:")]
    public virtual void RemoveObserver(NSObject observer, NSString keyPath)
    {
        if (observer == null)
        {
            throw new ArgumentNullException("observer");
        }
        if (keyPath == null)
        {
            throw new ArgumentNullException("keyPath");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selRemoveObserverForKeyPath_Handle, observer.Handle, keyPath.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selRemoveObserverForKeyPath_Handle, observer.Handle, keyPath.Handle);
        }
    }

    [Export("willChangeValueForKey:")]
    public virtual void WillChangeValue(string forKey)
    {
        if (forKey == null)
        {
            throw new ArgumentNullException("forKey");
        }
        IntPtr arg = NSString.CreateNative(forKey);
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selWillChangeValueForKey_Handle, arg);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selWillChangeValueForKey_Handle, arg);
        }
        NSString.ReleaseNative(arg);
    }

    [Export("didChangeValueForKey:")]
    public virtual void DidChangeValue(string forKey)
    {
        if (forKey == null)
        {
            throw new ArgumentNullException("forKey");
        }
        IntPtr arg = NSString.CreateNative(forKey);
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selDidChangeValueForKey_Handle, arg);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selDidChangeValueForKey_Handle, arg);
        }
        NSString.ReleaseNative(arg);
    }

    [Export("willChange:valuesAtIndexes:forKey:")]
    public virtual void WillChange(NSKeyValueChange changeKind, NSIndexSet indexes, NSString forKey)
    {
        if (indexes == null)
        {
            throw new ArgumentNullException("indexes");
        }
        if (forKey == null)
        {
            throw new ArgumentNullException("forKey");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_UInt64_IntPtr_IntPtr(Handle, selWillChangeValuesAtIndexesForKey_Handle, (ulong)changeKind, indexes.Handle, forKey.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_UInt64_IntPtr_IntPtr(SuperHandle, selWillChangeValuesAtIndexesForKey_Handle, (ulong)changeKind, indexes.Handle, forKey.Handle);
        }
    }

    [Export("didChange:valuesAtIndexes:forKey:")]
    public virtual void DidChange(NSKeyValueChange changeKind, NSIndexSet indexes, NSString forKey)
    {
        if (indexes == null)
        {
            throw new ArgumentNullException("indexes");
        }
        if (forKey == null)
        {
            throw new ArgumentNullException("forKey");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_UInt64_IntPtr_IntPtr(Handle, selDidChangeValuesAtIndexesForKey_Handle, (ulong)changeKind, indexes.Handle, forKey.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_UInt64_IntPtr_IntPtr(SuperHandle, selDidChangeValuesAtIndexesForKey_Handle, (ulong)changeKind, indexes.Handle, forKey.Handle);
        }
    }

    [Export("willChangeValueForKey:withSetMutation:usingObjects:")]
    public virtual void WillChange(NSString forKey, NSKeyValueSetMutationKind mutationKind, NSSet objects)
    {
        if (forKey == null)
        {
            throw new ArgumentNullException("forKey");
        }
        if (objects == null)
        {
            throw new ArgumentNullException("objects");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr(Handle, selWillChangeValueForKeyWithSetMutationUsingObjects_Handle, forKey.Handle, (ulong)mutationKind, objects.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_UInt64_IntPtr(SuperHandle, selWillChangeValueForKeyWithSetMutationUsingObjects_Handle, forKey.Handle, (ulong)mutationKind, objects.Handle);
        }
    }

    [Export("didChangeValueForKey:withSetMutation:usingObjects:")]
    public virtual void DidChange(NSString forKey, NSKeyValueSetMutationKind mutationKind, NSSet objects)
    {
        if (forKey == null)
        {
            throw new ArgumentNullException("forKey");
        }
        if (objects == null)
        {
            throw new ArgumentNullException("objects");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr(Handle, selDidChangeValueForKeyWithSetMutationUsingObjects_Handle, forKey.Handle, (ulong)mutationKind, objects.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_UInt64_IntPtr(SuperHandle, selDidChangeValueForKeyWithSetMutationUsingObjects_Handle, forKey.Handle, (ulong)mutationKind, objects.Handle);
        }
    }

    [Export("keyPathsForValuesAffectingValueForKey:")]
    public static NSSet GetKeyPathsForValuesAffecting(NSString key)
    {
        if (key == null)
        {
            throw new ArgumentNullException("key");
        }
        return (NSSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selKeyPathsForValuesAffectingValueForKey_Handle, key.Handle));
    }

    [Export("automaticallyNotifiesObserversForKey:")]
    public static bool AutomaticallyNotifiesObserversForKey(string key)
    {
        if (key == null)
        {
            throw new ArgumentNullException("key");
        }
        IntPtr arg = NSString.CreateNative(key);
        bool result = Messaging.bool_objc_msgSend_IntPtr(class_ptr, selAutomaticallyNotifiesObserversForKey_Handle, arg);
        NSString.ReleaseNative(arg);
        return result;
    }

    [Export("valueForKey:")]
    public virtual NSObject ValueForKey(NSString key)
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
    public virtual void SetValueForKey(NSObject value, NSString key)
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

    [Export("valueForKeyPath:")]
    public virtual NSObject ValueForKeyPath(NSString keyPath)
    {
        if (keyPath == null)
        {
            throw new ArgumentNullException("keyPath");
        }
        if (IsDirectBinding)
        {
            return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selValueForKeyPath_Handle, keyPath.Handle));
        }
        return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selValueForKeyPath_Handle, keyPath.Handle));
    }

    [Export("setValue:forKeyPath:")]
    public virtual void SetValueForKeyPath(NSObject value, NSString keyPath)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value");
        }
        if (keyPath == null)
        {
            throw new ArgumentNullException("keyPath");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selSetValueForKeyPath_Handle, value.Handle, keyPath.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selSetValueForKeyPath_Handle, value.Handle, keyPath.Handle);
        }
    }

    [Export("valueForUndefinedKey:")]
    public virtual NSObject ValueForUndefinedKey(NSString key)
    {
        if (key == null)
        {
            throw new ArgumentNullException("key");
        }
        if (IsDirectBinding)
        {
            return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selValueForUndefinedKey_Handle, key.Handle));
        }
        return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selValueForUndefinedKey_Handle, key.Handle));
    }

    [Export("setValue:forUndefinedKey:")]
    public virtual void SetValueForUndefinedKey(NSObject value, NSString undefinedKey)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value");
        }
        if (undefinedKey == null)
        {
            throw new ArgumentNullException("undefinedKey");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selSetValueForUndefinedKey_Handle, value.Handle, undefinedKey.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selSetValueForUndefinedKey_Handle, value.Handle, undefinedKey.Handle);
        }
    }

    [Export("setNilValueForKey:")]
    public virtual void SetNilValueForKey(NSString key)
    {
        if (key == null)
        {
            throw new ArgumentNullException("key");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selSetNilValueForKey_Handle, key.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetNilValueForKey_Handle, key.Handle);
        }
    }

    [Export("dictionaryWithValuesForKeys:")]
    public virtual NSDictionary GetDictionaryOfValuesFromKeys(NSString[] keys)
    {
        if (keys == null)
        {
            throw new ArgumentNullException("keys");
        }
        NSArray nSArray = NSArray.FromNSObjects(keys);
        NSDictionary result = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selDictionaryWithValuesForKeys_Handle, nSArray.Handle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selDictionaryWithValuesForKeys_Handle, nSArray.Handle))));
        nSArray.Dispose();
        return result;
    }

    [Export("setValuesForKeysWithDictionary:")]
    public virtual void SetValuesForKeysWithDictionary(NSDictionary keyedValues)
    {
        if (keyedValues == null)
        {
            throw new ArgumentNullException("keyedValues");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selSetValuesForKeysWithDictionary_Handle, keyedValues.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selSetValuesForKeysWithDictionary_Handle, keyedValues.Handle);
        }
    }

    [Export("exposedBindings")]
    public virtual NSString[] ExposedBindings()
    {
        if (IsDirectBinding)
        {
            return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(Handle, selExposedBindingsHandle));
        }
        return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selExposedBindingsHandle));
    }

    [Export("valueClassForBinding:")]
    public virtual Class BindingValueClass(string binding)
    {
        if (binding == null)
        {
            throw new ArgumentNullException("binding");
        }
        IntPtr arg = NSString.CreateNative(binding);
        Class result = ((!IsDirectBinding) ? new Class(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selValueClassForBinding_Handle, arg)) : new Class(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selValueClassForBinding_Handle, arg)));
        NSString.ReleaseNative(arg);
        return result;
    }

    [Export("bind:toObject:withKeyPath:options:")]
    public virtual void Bind(string binding, NSObject observable, string keyPath, NSDictionary options)
    {
        if (binding == null)
        {
            throw new ArgumentNullException("binding");
        }
        if (observable == null)
        {
            throw new ArgumentNullException("observable");
        }
        if (keyPath == null)
        {
            throw new ArgumentNullException("keyPath");
        }
        IntPtr arg = NSString.CreateNative(binding);
        IntPtr arg2 = NSString.CreateNative(keyPath);
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(Handle, selBindToObjectWithKeyPathOptions_Handle, arg, observable.Handle, arg2, options?.Handle ?? IntPtr.Zero);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(SuperHandle, selBindToObjectWithKeyPathOptions_Handle, arg, observable.Handle, arg2, options?.Handle ?? IntPtr.Zero);
        }
        NSString.ReleaseNative(arg);
        NSString.ReleaseNative(arg2);
    }

    [Export("unbind:")]
    public virtual void Unbind(string binding)
    {
        if (binding == null)
        {
            throw new ArgumentNullException("binding");
        }
        IntPtr arg = NSString.CreateNative(binding);
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selUnbind_Handle, arg);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selUnbind_Handle, arg);
        }
        NSString.ReleaseNative(arg);
    }

    [Export("infoForBinding:")]
    public virtual NSDictionary BindingInfo(string binding)
    {
        if (binding == null)
        {
            throw new ArgumentNullException("binding");
        }
        IntPtr arg = NSString.CreateNative(binding);
        NSDictionary result = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selInfoForBinding_Handle, arg))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selInfoForBinding_Handle, arg))));
        NSString.ReleaseNative(arg);
        return result;
    }

    [Export("optionDescriptionsForBinding:")]
    public virtual NSObject[] BindingOptionDescriptions(string aBinding)
    {
        if (aBinding == null)
        {
            throw new ArgumentNullException("aBinding");
        }
        IntPtr arg = NSString.CreateNative(aBinding);
        NSObject[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(SuperHandle, selOptionDescriptionsForBinding_Handle, arg)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr(Handle, selOptionDescriptionsForBinding_Handle, arg)));
        NSString.ReleaseNative(arg);
        return result;
    }

    [Export("defaultPlaceholderForMarker:withBinding:")]
    public static NSObject GetDefaultPlaceholder(NSObject marker, string binding)
    {
        if (marker == null)
        {
            throw new ArgumentNullException("marker");
        }
        if (binding == null)
        {
            throw new ArgumentNullException("binding");
        }
        IntPtr arg = NSString.CreateNative(binding);
        NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selDefaultPlaceholderForMarkerWithBinding_Handle, marker.Handle, arg));
        NSString.ReleaseNative(arg);
        return nSObject;
    }

    [Export("setDefaultPlaceholder:forMarker:withBinding:")]
    public static void SetDefaultPlaceholder(NSObject placeholder, NSObject marker, string binding)
    {
        if (placeholder == null)
        {
            throw new ArgumentNullException("placeholder");
        }
        if (marker == null)
        {
            throw new ArgumentNullException("marker");
        }
        if (binding == null)
        {
            throw new ArgumentNullException("binding");
        }
        IntPtr arg = NSString.CreateNative(binding);
        Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selSetDefaultPlaceholderForMarkerWithBinding_Handle, placeholder.Handle, marker.Handle, arg);
        NSString.ReleaseNative(arg);
    }

    [Export("objectDidEndEditing:")]
    public virtual void ObjectDidEndEditing(NSObject editor)
    {
        if (editor == null)
        {
            throw new ArgumentNullException("editor");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selObjectDidEndEditing_Handle, editor.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selObjectDidEndEditing_Handle, editor.Handle);
        }
    }

    [Export("commitEditing")]
    public virtual bool CommitEditing()
    {
        if (IsDirectBinding)
        {
            return Messaging.bool_objc_msgSend(Handle, selCommitEditingHandle);
        }
        return Messaging.bool_objc_msgSendSuper(SuperHandle, selCommitEditingHandle);
    }

    [Export("commitEditingWithDelegate:didCommitSelector:contextInfo:")]
    public virtual void CommitEditing(NSObject objDelegate, Selector didCommitSelector, IntPtr contextInfo)
    {
        if (objDelegate == null)
        {
            throw new ArgumentNullException("objDelegate");
        }
        if (didCommitSelector == null)
        {
            throw new ArgumentNullException("didCommitSelector");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(Handle, selCommitEditingWithDelegateDidCommitSelectorContextInfo_Handle, objDelegate.Handle, didCommitSelector.Handle, contextInfo);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(SuperHandle, selCommitEditingWithDelegateDidCommitSelectorContextInfo_Handle, objDelegate.Handle, didCommitSelector.Handle, contextInfo);
        }
    }

    [Export("copy")]
    public virtual NSObject Copy()
    {
        if (IsDirectBinding)
        {
            return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selCopyHandle));
        }
        return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selCopyHandle));
    }

    [Export("mutableCopy")]
    public virtual NSObject MutableCopy()
    {
        if (IsDirectBinding)
        {
            return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(Handle, selMutableCopyHandle));
        }
        return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selMutableCopyHandle));
    }

    [Export("performSelector:withObject:afterDelay:inModes:")]
    public virtual void PerformSelector(Selector selector, NSObject withObject, double afterDelay, NSString[] nsRunLoopModes)
    {
        if (selector == null)
        {
            throw new ArgumentNullException("selector");
        }
        if (withObject == null)
        {
            throw new ArgumentNullException("withObject");
        }
        if (nsRunLoopModes == null)
        {
            throw new ArgumentNullException("nsRunLoopModes");
        }
        NSArray nSArray = NSArray.FromNSObjects(nsRunLoopModes);
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_IntPtr_Double_IntPtr(Handle, selPerformSelectorWithObjectAfterDelayInModes_Handle, selector.Handle, withObject.Handle, afterDelay, nSArray.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_Double_IntPtr(SuperHandle, selPerformSelectorWithObjectAfterDelayInModes_Handle, selector.Handle, withObject.Handle, afterDelay, nSArray.Handle);
        }
        nSArray.Dispose();
    }

    [Export("performSelector:onThread:withObject:waitUntilDone:")]
    public virtual void PerformSelector(Selector selector, NSThread onThread, NSObject withObject, bool waitUntilDone)
    {
        if (selector == null)
        {
            throw new ArgumentNullException("selector");
        }
        if (onThread == null)
        {
            throw new ArgumentNullException("onThread");
        }
        if (withObject == null)
        {
            throw new ArgumentNullException("withObject");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool(Handle, selPerformSelectorOnThreadWithObjectWaitUntilDone_Handle, selector.Handle, onThread.Handle, withObject.Handle, waitUntilDone);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool(SuperHandle, selPerformSelectorOnThreadWithObjectWaitUntilDone_Handle, selector.Handle, onThread.Handle, withObject.Handle, waitUntilDone);
        }
    }

    [Export("performSelector:onThread:withObject:waitUntilDone:modes:")]
    public virtual void PerformSelector(Selector selector, NSThread onThread, NSObject withObject, bool waitUntilDone, NSString[] nsRunLoopModes)
    {
        if (selector == null)
        {
            throw new ArgumentNullException("selector");
        }
        if (onThread == null)
        {
            throw new ArgumentNullException("onThread");
        }
        if (withObject == null)
        {
            throw new ArgumentNullException("withObject");
        }
        if (nsRunLoopModes == null)
        {
            throw new ArgumentNullException("nsRunLoopModes");
        }
        NSArray nSArray = NSArray.FromNSObjects(nsRunLoopModes);
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool_IntPtr(Handle, selPerformSelectorOnThreadWithObjectWaitUntilDoneModes_Handle, selector.Handle, onThread.Handle, withObject.Handle, waitUntilDone, nSArray.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool_IntPtr(SuperHandle, selPerformSelectorOnThreadWithObjectWaitUntilDoneModes_Handle, selector.Handle, onThread.Handle, withObject.Handle, waitUntilDone, nSArray.Handle);
        }
        nSArray.Dispose();
    }

    [Export("cancelPreviousPerformRequestsWithTarget:")]
    public static void CancelPreviousPerformRequest(NSObject aTarget)
    {
        if (aTarget == null)
        {
            throw new ArgumentNullException("aTarget");
        }
        Messaging.void_objc_msgSend_IntPtr(class_ptr, selCancelPreviousPerformRequestsWithTarget_Handle, aTarget.Handle);
    }

    [Export("cancelPreviousPerformRequestsWithTarget:selector:object:")]
    public static void CancelPreviousPerformRequest(NSObject aTarget, Selector selector, NSObject argument)
    {
        if (aTarget == null)
        {
            throw new ArgumentNullException("aTarget");
        }
        if (selector == null)
        {
            throw new ArgumentNullException("selector");
        }
        Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selCancelPreviousPerformRequestsWithTargetSelectorObject_Handle, aTarget.Handle, selector.Handle, argument?.Handle ?? IntPtr.Zero);
    }
}

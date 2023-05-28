using AppKit;
using Foundation;
using Registrar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;

namespace ObjCRuntime;

public static class Runtime
{
    internal delegate void register_nsobject_delegate(IntPtr managed_obj, IntPtr native_obj, out int exception_gchandle);

    internal delegate void register_assembly_delegate(IntPtr assembly, out int exception_gchandle);

    internal delegate void throw_ns_exception_delegate(IntPtr exc);

    internal delegate void rethrow_managed_exception_delegate(uint original_exception_gchandle, out int exception_gchandle);

    internal delegate int create_ns_exception_delegate(IntPtr exc, out int exception_gchandle);

    internal delegate IntPtr unwrap_ns_exception_delegate(uint exc_handle, out int exception_gchandle);

    internal delegate IntPtr get_block_wrapper_creator_delegate(IntPtr method, int parameter, out int exception_gchandle);

    internal delegate IntPtr create_block_proxy_delegate(IntPtr method, IntPtr block, out int exception_gchandle);

    internal delegate IntPtr create_delegate_proxy_delegate(IntPtr method, IntPtr block, IntPtr signature, uint token_ref, out int exception_gchandle);

    internal delegate void register_entry_assembly_delegate(IntPtr assembly, out int exception_gchandle);

    internal delegate IntPtr get_class_delegate(IntPtr ptr, out int exception_gchandle);

    internal delegate IntPtr get_selector_delegate(IntPtr ptr, out int exception_gchandle);

    internal delegate void get_method_for_selector_delegate(IntPtr cls, IntPtr sel, bool is_static, IntPtr desc, out int exception_gchandle);

    internal delegate IntPtr get_nsobject_delegate(IntPtr obj, out int exception_gchandle);

    internal delegate bool has_nsobject_delegate(IntPtr obj, out int exception_gchandle);

    internal delegate IntPtr get_handle_for_inativeobject_delegate(IntPtr obj, out int exception_gchandle);

    internal delegate void unregister_nsobject_delegate(IntPtr native_obj, IntPtr managed_obj, out int exception_gchandle);

    internal delegate IntPtr try_get_or_construct_nsobject_delegate(IntPtr obj, out int exception_gchandle);

    internal delegate IntPtr get_inative_object_dynamic_delegate(IntPtr obj, bool owns, IntPtr type, out int exception_gchandle);

    internal delegate IntPtr get_method_from_token_delegate(uint token_ref, out int exception_gchandle);

    internal delegate IntPtr get_generic_method_from_token_delegate(IntPtr obj, uint token_ref, out int exception_gchandle);

    internal delegate IntPtr get_inative_object_static_delegate(IntPtr obj, bool owns, uint iface_token_ref, uint implementation_token_ref, out int exception_gchandle);

    internal delegate IntPtr get_nsobject_with_type_delegate(IntPtr obj, IntPtr type, out bool created, out int exception_gchandle);

    internal delegate void dispose_delegate(IntPtr mobj, out int exception_gchandle);

    internal delegate bool is_parameter_transient_delegate(IntPtr method, int parameter, out int exception_gchandle);

    internal delegate bool is_parameter_out_delegate(IntPtr method, int parameter, out int exception_gchandle);

    internal delegate void get_method_and_object_for_selector_delegate(IntPtr cls, IntPtr sel, bool is_static, IntPtr obj, ref IntPtr mthis, IntPtr desc, out int exception_gchandle);

    internal delegate int create_product_exception_for_error_delegate(int code, uint inner_exception_gchandle, string message, out int exception_gchandle);

    internal delegate IntPtr reflection_type_get_full_name_delegate(IntPtr type, out int exception_gchandle);

    internal delegate IntPtr lookup_managed_type_name_delegate(IntPtr klass, out int exception_gchandle);

    internal delegate MarshalManagedExceptionMode on_marshal_managed_exception_delegate(int exception, out int exception_gchandle);

    internal delegate MarshalObjectiveCExceptionMode on_marshal_objectivec_exception_delegate(IntPtr exception, bool throwManagedAsDefault, out int exception_gchandle);

    internal delegate IntPtr convert_smart_enum_to_nsstring_delegate(IntPtr value, out int exception_gchandle);

    internal delegate IntPtr convert_nsstring_to_smart_enum_delegate(IntPtr value, IntPtr type, out int exception_gchandle);

    internal delegate int create_runtime_exception_delegate(int code, IntPtr message, out int exception_gchandle);

    internal struct Delegates
    {
        public IntPtr register_nsobject;

        public IntPtr register_assembly;

        public IntPtr throw_ns_exception;

        public IntPtr rethrow_managed_exception;

        public IntPtr create_ns_exception;

        public IntPtr unwrap_ns_exception;

        public IntPtr get_block_wrapper_creator;

        public IntPtr create_block_proxy;

        public IntPtr create_delegate_proxy;

        public IntPtr register_entry_assembly;

        public IntPtr get_class;

        public IntPtr get_selector;

        public IntPtr get_method_for_selector;

        public IntPtr get_nsobject;

        public IntPtr has_nsobject;

        public IntPtr get_handle_for_inativeobject;

        public IntPtr unregister_nsobject;

        public IntPtr try_get_or_construct_nsobject;

        public IntPtr get_inative_object_dynamic;

        public IntPtr get_method_from_token;

        public IntPtr get_generic_method_from_token;

        public IntPtr get_inative_object_static;

        public IntPtr get_nsobject_with_type;

        public IntPtr dispose;

        public IntPtr is_parameter_transient;

        public IntPtr is_parameter_out;

        public IntPtr get_method_and_object_for_selector;

        public IntPtr create_product_exception_for_error;

        public IntPtr reflection_type_get_full_name;

        public IntPtr lookup_managed_type_name;

        public IntPtr on_marshal_managed_exception;

        public IntPtr on_marshal_objectivec_exception;

        public IntPtr convert_smart_enum_to_nsstring;

        public IntPtr convert_nsstring_to_smart_enum;

        public IntPtr create_runtime_exception;
    }

    internal struct MTRegistrationMap
    {
        public IntPtr assembly;

        public unsafe MTClassMap* map;

        public IntPtr full_token_references;

        public unsafe MTManagedClassMap* skipped_map;

        public unsafe MTProtocolWrapperMap* protocol_wrapper_map;

        public MTProtocolMap protocol_map;

        public int assembly_count;

        public int map_count;

        public int full_token_reference_count;

        public int skipped_map_count;

        public int protocol_wrapper_count;

        public int protocol_count;
    }

    [Flags]
    internal enum MTTypeFlags : uint
    {
        None = 0u,
        CustomType = 1u,
        UserType = 2u
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct MTClassMap
    {
        public IntPtr handle;

        public uint type_reference;

        public MTTypeFlags flags;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct MTManagedClassMap
    {
        public uint skipped_reference;

        public uint actual_reference;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct MTProtocolWrapperMap
    {
        public uint protocol_token;

        public uint wrapper_token;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct MTProtocolMap
    {
        public unsafe uint* protocol_tokens;

        public unsafe IntPtr* protocols;
    }

    internal struct Trampolines
    {
        public IntPtr tramp;

        public IntPtr stret_tramp;

        public IntPtr fpret_single_tramp;

        public IntPtr fpret_double_tramp;

        public IntPtr release_tramp;

        public IntPtr retain_tramp;

        public IntPtr static_tramp;

        public IntPtr ctor_tramp;

        public IntPtr x86_double_abi_stret_tramp;

        public IntPtr static_fpret_single_tramp;

        public IntPtr static_fpret_double_tramp;

        public IntPtr static_stret_tramp;

        public IntPtr x86_double_abi_static_stret_tramp;

        public IntPtr long_tramp;

        public IntPtr static_long_tramp;

        public IntPtr copy_with_zone_1;

        public IntPtr copy_with_zone_2;

        public IntPtr get_gchandle_tramp;

        public IntPtr set_gchandle_tramp;
    }

    [Flags]
    internal enum InitializationFlags
    {
        IsPartialStaticRegistrar = 1,
        DynamicRegistrar = 4,
        IsSimulator = 0x10
    }

    internal enum LaunchMode
    {
        App,
        Extension,
        Embedded
    }

    internal struct InitializationOptions
    {
        public int Size;

        public InitializationFlags Flags;

        public unsafe Delegates* Delegates;

        public unsafe Trampolines* Trampolines;

        public unsafe MTRegistrationMap* RegistrationMap;

        public MarshalObjectiveCExceptionMode MarshalObjectiveCExceptionMode;

        public MarshalManagedExceptionMode MarshalManagedExceptionMode;

        public LaunchMode LaunchMode;

        public IntPtr EntryAssemblyPath;

        private IntPtr AssemblyLocations;

        public bool IsSimulator => (Flags & InitializationFlags.IsSimulator) == InitializationFlags.IsSimulator;
    }

    internal enum MissingCtorResolution
    {
        ThrowConstructor1NotFound,
        ThrowConstructor2NotFound,
        Ignore
    }

    private delegate void intptr_func(IntPtr block);

    private enum NXByteOrder
    {
        Unknown,
        LittleEndian,
        BigEndian
    }

    private struct NXArchInfo
    {
        private IntPtr name;

        public int CpuType;

        public int CpuSubType;

        public NXByteOrder ByteOrder;

        private IntPtr description;

        public string Name => MarshalHelper.PtrToStringUTF8(name);

        public string Description => MarshalHelper.PtrToStringUTF8(description);
    }

    private delegate void initialize_func();

    private unsafe delegate sbyte* get_sbyteptr_func();

    private static Dictionary<IntPtrTypeValueTuple, Delegate> block_to_delegate_cache;

    private static Dictionary<Type, ConstructorInfo> intptr_ctor_cache;

    private static Dictionary<Type, ConstructorInfo> intptr_bool_ctor_cache;

    private static List<object> delegates;

    private static List<Assembly> assemblies;

    private static Dictionary<IntPtr, WeakReference> object_map;

    private static object lock_obj;

    private static IntPtr NSObjectClass;

    private static bool initialized;

    internal static IntPtrEqualityComparer IntPtrEqualityComparer;

    internal static TypeEqualityComparer TypeEqualityComparer;

    internal static DynamicRegistrar Registrar;

    internal const uint INVALID_TOKEN_REF = uint.MaxValue;

    internal unsafe static InitializationOptions* options;

    private static MarshalObjectiveCExceptionMode objc_exception_mode;

    private static MarshalManagedExceptionMode managed_exception_mode;

    private static int MajorVersion = -1;

    private static int MinorVersion = -1;

    private static int BuildVersion = -1;

    private static intptr_func release_block_on_main_thread;

    public static bool IsARM64CallingConvention;

    internal const string ProductName = "Xamarin.Mac";

    internal const string AssemblyName = "Xamarin.Mac.dll";

    private static volatile bool originalWorkingDirectoryIsSet;

    private static string originalWorkingDirectory;

    private static IntPtr runtime_library;

    [BindingImpl(BindingImplOptions.Optimizable)]
    public static bool DynamicRegistrationSupported => true;

    internal static bool Initialized => initialized;

    public static string FrameworksPath { get; set; }

    public static string ResourcesPath { get; set; }

    public unsafe static string OriginalWorkingDirectory
    {
        get
        {
            if (originalWorkingDirectoryIsSet)
            {
                return originalWorkingDirectory;
            }
            originalWorkingDirectoryIsSet = true;
            sbyte* ptr = LookupInternalFunction<get_sbyteptr_func>("xamarin_get_original_working_directory_path")();
            if (ptr == null || *ptr == 0)
            {
                return null;
            }
            return originalWorkingDirectory = new string(ptr);
        }
    }

    public static event AssemblyRegistrationHandler AssemblyRegistration;

    public static event MarshalObjectiveCExceptionHandler MarshalObjectiveCException;

    public static event MarshalManagedExceptionHandler MarshalManagedException;

    [MonoPInvokeCallback(typeof(register_nsobject_delegate))]
    private static void register_nsobject(IntPtr managed_obj, IntPtr native_obj, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            RegisterNSObject(managed_obj, native_obj);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
        }
    }

    [MonoPInvokeCallback(typeof(register_assembly_delegate))]
    private static void register_assembly(IntPtr assembly, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            RegisterAssembly(assembly);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
        }
    }

    [MonoPInvokeCallback(typeof(throw_ns_exception_delegate))]
    private static void throw_ns_exception(IntPtr exc)
    {
        ThrowNSException(exc);
    }

    [MonoPInvokeCallback(typeof(rethrow_managed_exception_delegate))]
    private static void rethrow_managed_exception(uint original_exception_gchandle, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            RethrowManagedException(original_exception_gchandle);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
        }
    }

    [MonoPInvokeCallback(typeof(create_ns_exception_delegate))]
    private static int create_ns_exception(IntPtr exc, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return CreateNSException(exc);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
            return 0;
        }
    }

    [MonoPInvokeCallback(typeof(unwrap_ns_exception_delegate))]
    private static IntPtr unwrap_ns_exception(uint exc_handle, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return UnwrapNSException(exc_handle);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
            return (IntPtr)0;
        }
    }

    [MonoPInvokeCallback(typeof(get_block_wrapper_creator_delegate))]
    private static IntPtr get_block_wrapper_creator(IntPtr method, int parameter, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return GetBlockWrapperCreator(method, parameter);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
            return (IntPtr)0;
        }
    }

    [MonoPInvokeCallback(typeof(create_block_proxy_delegate))]
    private static IntPtr create_block_proxy(IntPtr method, IntPtr block, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return CreateBlockProxy(method, block);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
            return (IntPtr)0;
        }
    }

    [MonoPInvokeCallback(typeof(create_delegate_proxy_delegate))]
    private static IntPtr create_delegate_proxy(IntPtr method, IntPtr block, IntPtr signature, uint token_ref, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return CreateDelegateProxy(method, block, signature, token_ref);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
            return (IntPtr)0;
        }
    }

    [MonoPInvokeCallback(typeof(register_entry_assembly_delegate))]
    private static void register_entry_assembly(IntPtr assembly, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            RegisterEntryAssembly(assembly);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
        }
    }

    [MonoPInvokeCallback(typeof(get_class_delegate))]
    private static IntPtr get_class(IntPtr ptr, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return GetClass(ptr);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
            return (IntPtr)0;
        }
    }

    [MonoPInvokeCallback(typeof(get_selector_delegate))]
    private static IntPtr get_selector(IntPtr ptr, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return GetSelector(ptr);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
            return (IntPtr)0;
        }
    }

    [MonoPInvokeCallback(typeof(get_method_for_selector_delegate))]
    private static void get_method_for_selector(IntPtr cls, IntPtr sel, bool is_static, IntPtr desc, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            GetMethodForSelector(cls, sel, is_static, desc);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
        }
    }

    [MonoPInvokeCallback(typeof(get_nsobject_delegate))]
    private static IntPtr get_nsobject(IntPtr obj, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return GetNSObjectWrapped(obj);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
            return (IntPtr)0;
        }
    }

    [MonoPInvokeCallback(typeof(has_nsobject_delegate))]
    private static bool has_nsobject(IntPtr obj, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return HasNSObject(obj);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
            return false;
        }
    }

    [MonoPInvokeCallback(typeof(get_handle_for_inativeobject_delegate))]
    private static IntPtr get_handle_for_inativeobject(IntPtr obj, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return GetHandleForINativeObject(obj);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
            return (IntPtr)0;
        }
    }

    [MonoPInvokeCallback(typeof(unregister_nsobject_delegate))]
    private static void unregister_nsobject(IntPtr native_obj, IntPtr managed_obj, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            UnregisterNSObject(native_obj, managed_obj);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
        }
    }

    [MonoPInvokeCallback(typeof(try_get_or_construct_nsobject_delegate))]
    private static IntPtr try_get_or_construct_nsobject(IntPtr obj, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return TryGetOrConstructNSObjectWrapped(obj);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
            return (IntPtr)0;
        }
    }

    [MonoPInvokeCallback(typeof(get_inative_object_dynamic_delegate))]
    private static IntPtr get_inative_object_dynamic(IntPtr obj, bool owns, IntPtr type, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return GetINativeObject_Dynamic(obj, owns, type);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
            return (IntPtr)0;
        }
    }

    [MonoPInvokeCallback(typeof(get_method_from_token_delegate))]
    private static IntPtr get_method_from_token(uint token_ref, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return GetMethodFromToken(token_ref);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
            return (IntPtr)0;
        }
    }

    [MonoPInvokeCallback(typeof(get_generic_method_from_token_delegate))]
    private static IntPtr get_generic_method_from_token(IntPtr obj, uint token_ref, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return GetGenericMethodFromToken(obj, token_ref);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
            return (IntPtr)0;
        }
    }

    [MonoPInvokeCallback(typeof(get_inative_object_static_delegate))]
    private static IntPtr get_inative_object_static(IntPtr obj, bool owns, uint iface_token_ref, uint implementation_token_ref, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return GetINativeObject_Static(obj, owns, iface_token_ref, implementation_token_ref);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
            return (IntPtr)0;
        }
    }

    [MonoPInvokeCallback(typeof(get_nsobject_with_type_delegate))]
    private static IntPtr get_nsobject_with_type(IntPtr obj, IntPtr type, out bool created, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return GetNSObjectWithType(obj, type, out created);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
            created = false;
            return (IntPtr)0;
        }
    }

    [MonoPInvokeCallback(typeof(dispose_delegate))]
    private static void dispose(IntPtr mobj, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            Dispose(mobj);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
        }
    }

    [MonoPInvokeCallback(typeof(is_parameter_transient_delegate))]
    private static bool is_parameter_transient(IntPtr method, int parameter, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return IsParameterTransient(method, parameter);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
            return false;
        }
    }

    [MonoPInvokeCallback(typeof(is_parameter_out_delegate))]
    private static bool is_parameter_out(IntPtr method, int parameter, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return IsParameterOut(method, parameter);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
            return false;
        }
    }

    [MonoPInvokeCallback(typeof(get_method_and_object_for_selector_delegate))]
    private static void get_method_and_object_for_selector(IntPtr cls, IntPtr sel, bool is_static, IntPtr obj, ref IntPtr mthis, IntPtr desc, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            GetMethodAndObjectForSelector(cls, sel, is_static, obj, ref mthis, desc);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
        }
    }

    [MonoPInvokeCallback(typeof(create_product_exception_for_error_delegate))]
    private static int create_product_exception_for_error(int code, uint inner_exception_gchandle, string message, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return CreateProductException(code, inner_exception_gchandle, message);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
            return 0;
        }
    }

    [MonoPInvokeCallback(typeof(reflection_type_get_full_name_delegate))]
    private static IntPtr reflection_type_get_full_name(IntPtr type, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return TypeGetFullName(type);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
            return (IntPtr)0;
        }
    }

    [MonoPInvokeCallback(typeof(lookup_managed_type_name_delegate))]
    private static IntPtr lookup_managed_type_name(IntPtr klass, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return LookupManagedTypeName(klass);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
            return (IntPtr)0;
        }
    }

    [MonoPInvokeCallback(typeof(on_marshal_managed_exception_delegate))]
    private static MarshalManagedExceptionMode on_marshal_managed_exception(int exception, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return OnMarshalManagedException(exception);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
            return MarshalManagedExceptionMode.Default;
        }
    }

    [MonoPInvokeCallback(typeof(on_marshal_objectivec_exception_delegate))]
    private static MarshalObjectiveCExceptionMode on_marshal_objectivec_exception(IntPtr exception, bool throwManagedAsDefault, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return OnMarshalObjectiveCException(exception, throwManagedAsDefault);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
            return MarshalObjectiveCExceptionMode.Default;
        }
    }

    [MonoPInvokeCallback(typeof(convert_smart_enum_to_nsstring_delegate))]
    private static IntPtr convert_smart_enum_to_nsstring(IntPtr value, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return ConvertSmartEnumToNSString(value);
        }
        catch (Exception value2)
        {
            GCHandle value3 = GCHandle.Alloc(value2, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value3).ToInt32();
            return (IntPtr)0;
        }
    }

    [MonoPInvokeCallback(typeof(convert_nsstring_to_smart_enum_delegate))]
    private static IntPtr convert_nsstring_to_smart_enum(IntPtr value, IntPtr type, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return ConvertNSStringToSmartEnum(value, type);
        }
        catch (Exception value2)
        {
            GCHandle value3 = GCHandle.Alloc(value2, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value3).ToInt32();
            return (IntPtr)0;
        }
    }

    [MonoPInvokeCallback(typeof(create_runtime_exception_delegate))]
    private static int create_runtime_exception(int code, IntPtr message, out int exception_gchandle)
    {
        exception_gchandle = 0;
        try
        {
            return CreateRuntimeException(code, message);
        }
        catch (Exception value)
        {
            GCHandle value2 = GCHandle.Alloc(value, GCHandleType.Normal);
            exception_gchandle = GCHandle.ToIntPtr(value2).ToInt32();
            return 0;
        }
    }

    [BindingImpl(BindingImplOptions.Optimizable)]
    private unsafe static void RegisterDelegates(InitializationOptions* options)
    {
        options->Delegates->throw_ns_exception = GetFunctionPointer(new throw_ns_exception_delegate(throw_ns_exception));
        options->Delegates->rethrow_managed_exception = GetFunctionPointer(new rethrow_managed_exception_delegate(rethrow_managed_exception));
        options->Delegates->create_ns_exception = GetFunctionPointer(new create_ns_exception_delegate(create_ns_exception));
        options->Delegates->unwrap_ns_exception = GetFunctionPointer(new unwrap_ns_exception_delegate(unwrap_ns_exception));
        options->Delegates->create_block_proxy = GetFunctionPointer(new create_block_proxy_delegate(create_block_proxy));
        options->Delegates->create_delegate_proxy = GetFunctionPointer(new create_delegate_proxy_delegate(create_delegate_proxy));
        options->Delegates->get_class = GetFunctionPointer(new get_class_delegate(get_class));
        options->Delegates->get_selector = GetFunctionPointer(new get_selector_delegate(get_selector));
        options->Delegates->has_nsobject = GetFunctionPointer(new has_nsobject_delegate(has_nsobject));
        options->Delegates->get_handle_for_inativeobject = GetFunctionPointer(new get_handle_for_inativeobject_delegate(get_handle_for_inativeobject));
        options->Delegates->unregister_nsobject = GetFunctionPointer(new unregister_nsobject_delegate(unregister_nsobject));
        options->Delegates->try_get_or_construct_nsobject = GetFunctionPointer(new try_get_or_construct_nsobject_delegate(try_get_or_construct_nsobject));
        options->Delegates->get_inative_object_dynamic = GetFunctionPointer(new get_inative_object_dynamic_delegate(get_inative_object_dynamic));
        options->Delegates->get_method_from_token = GetFunctionPointer(new get_method_from_token_delegate(get_method_from_token));
        options->Delegates->get_generic_method_from_token = GetFunctionPointer(new get_generic_method_from_token_delegate(get_generic_method_from_token));
        options->Delegates->get_inative_object_static = GetFunctionPointer(new get_inative_object_static_delegate(get_inative_object_static));
        options->Delegates->get_nsobject_with_type = GetFunctionPointer(new get_nsobject_with_type_delegate(get_nsobject_with_type));
        options->Delegates->dispose = GetFunctionPointer(new dispose_delegate(dispose));
        options->Delegates->create_product_exception_for_error = GetFunctionPointer(new create_product_exception_for_error_delegate(create_product_exception_for_error));
        options->Delegates->reflection_type_get_full_name = GetFunctionPointer(new reflection_type_get_full_name_delegate(reflection_type_get_full_name));
        options->Delegates->lookup_managed_type_name = GetFunctionPointer(new lookup_managed_type_name_delegate(lookup_managed_type_name));
        options->Delegates->on_marshal_managed_exception = GetFunctionPointer(new on_marshal_managed_exception_delegate(on_marshal_managed_exception));
        options->Delegates->on_marshal_objectivec_exception = GetFunctionPointer(new on_marshal_objectivec_exception_delegate(on_marshal_objectivec_exception));
        options->Delegates->create_runtime_exception = GetFunctionPointer(new create_runtime_exception_delegate(create_runtime_exception));
        if (DynamicRegistrationSupported)
        {
            RegisterDelegatesDynamic(options);
        }
    }

    private unsafe static void RegisterDelegatesDynamic(InitializationOptions* options)
    {
        options->Delegates->register_nsobject = GetFunctionPointer(new register_nsobject_delegate(register_nsobject));
        options->Delegates->register_assembly = GetFunctionPointer(new register_assembly_delegate(register_assembly));
        options->Delegates->get_block_wrapper_creator = GetFunctionPointer(new get_block_wrapper_creator_delegate(get_block_wrapper_creator));
        options->Delegates->register_entry_assembly = GetFunctionPointer(new register_entry_assembly_delegate(register_entry_assembly));
        options->Delegates->get_method_for_selector = GetFunctionPointer(new get_method_for_selector_delegate(get_method_for_selector));
        options->Delegates->get_nsobject = GetFunctionPointer(new get_nsobject_delegate(get_nsobject));
        options->Delegates->is_parameter_transient = GetFunctionPointer(new is_parameter_transient_delegate(is_parameter_transient));
        options->Delegates->is_parameter_out = GetFunctionPointer(new is_parameter_out_delegate(is_parameter_out));
        options->Delegates->get_method_and_object_for_selector = GetFunctionPointer(new get_method_and_object_for_selector_delegate(get_method_and_object_for_selector));
        options->Delegates->convert_smart_enum_to_nsstring = GetFunctionPointer(new convert_smart_enum_to_nsstring_delegate(convert_smart_enum_to_nsstring));
        options->Delegates->convert_nsstring_to_smart_enum = GetFunctionPointer(new convert_nsstring_to_smart_enum_delegate(convert_nsstring_to_smart_enum));
    }

    [DllImport("/usr/lib/libc.dylib")]
    private static extern int _NSGetExecutablePath(byte[] buf, ref int bufsize);

    [Preserve]
    [BindingImpl(BindingImplOptions.Optimizable)]
    private unsafe static void Initialize(InitializationOptions* options)
    {
        if (options->Size != Marshal.SizeOf(typeof(InitializationOptions)))
        {
            string text = "Version mismatch between the native Xamarin.Mac runtime and Xamarin.Mac.dll. Please reinstall Xamarin.Mac.";
            Console.Error.WriteLine(text);
            try
            {
                Console.Error.WriteLine("Xamarin.Mac.dll was loaded from {0}", typeof(nint).Assembly.Location);
                IntPtr addr = Dlfcn.dlsym(Dlfcn.RTLD.Default, "xamarin_initialize");
                if (Dlfcn.dladdr(addr, out var info) == 0)
                {
                    Console.Error.WriteLine("The native runtime was loaded from {0}", Marshal.PtrToStringAuto(info.dli_fname));
                }
                else if (Dlfcn.dlsym(Dlfcn.RTLD.MainOnly, "xamarin_initialize") != IntPtr.Zero)
                {
                    byte[] array = new byte[128];
                    int bufsize = array.Length;
                    if (_NSGetExecutablePath(array, ref bufsize) == -1)
                    {
                        Array.Resize(ref array, bufsize);
                        bufsize = array.Length;
                        if (_NSGetExecutablePath(array, ref bufsize) != 0)
                        {
                            Console.Error.WriteLine("Could not find out where the native runtime was loaded from.");
                            array = null;
                        }
                    }
                    if (array != null)
                    {
                        int num = 0;
                        for (int i = 0; i < array.Length && array[i] != 0; i++)
                        {
                            num++;
                        }
                        Console.Error.WriteLine("The native runtime was loaded from {0}", Encoding.UTF8.GetString(array, 0, num));
                    }
                }
                else
                {
                    Console.Error.WriteLine("Could not find out where the native runtime was loaded from.");
                }
            }
            catch
            {
            }
            throw ErrorHelper.CreateError(8001, text);
        }
        if (IntPtr.Size != sizeof(nint))
        {
            string text2 = string.Format("Native type size mismatch between Xamarin.Mac.dll and the executing architecture. Xamarin.Mac.dll was built for {0}-bit, while the current process is {1}-bit.", (IntPtr.Size == 4) ? "64" : "32", (IntPtr.Size == 4) ? "32" : "64");
            Console.Error.WriteLine(text2);
            throw ErrorHelper.CreateError(8010, text2);
        }
        IntPtrEqualityComparer = new IntPtrEqualityComparer();
        TypeEqualityComparer = new TypeEqualityComparer();
        Runtime.options = options;
        delegates = new List<object>();
        object_map = new Dictionary<IntPtr, WeakReference>(IntPtrEqualityComparer);
        intptr_ctor_cache = new Dictionary<Type, ConstructorInfo>(TypeEqualityComparer);
        intptr_bool_ctor_cache = new Dictionary<Type, ConstructorInfo>(TypeEqualityComparer);
        lock_obj = new object();
        NSObjectClass = NSObject.Initialize();
        if (DynamicRegistrationSupported)
        {
            Registrar = new DynamicRegistrar();
        }
        RegisterDelegates(options);
        Class.Initialize(options);
        //SystemDependencyProvider.Initialize();
        InitializePlatform(options);
        IsARM64CallingConvention = GetIsARM64CallingConvention();
        objc_exception_mode = options->MarshalObjectiveCExceptionMode;
        managed_exception_mode = options->MarshalManagedExceptionMode;
        initialized = true;
    }

    private static bool OnAssemblyRegistration(AssemblyName assembly_name)
    {
        if (Runtime.AssemblyRegistration != null)
        {
            AssemblyRegistrationEventArgs assemblyRegistrationEventArgs = new AssemblyRegistrationEventArgs
            {
                Register = true,
                AssemblyName = assembly_name
            };
            Runtime.AssemblyRegistration(null, assemblyRegistrationEventArgs);
            return assemblyRegistrationEventArgs.Register;
        }
        return true;
    }

    private static MarshalObjectiveCExceptionMode OnMarshalObjectiveCException(IntPtr exception_handle, bool throwManagedAsDefault)
    {
        if (throwManagedAsDefault && Runtime.MarshalObjectiveCException == null)
        {
            return MarshalObjectiveCExceptionMode.ThrowManagedException;
        }
        if (Runtime.MarshalObjectiveCException != null)
        {
            NSException nSObject = GetNSObject<NSException>(exception_handle);
            MarshalObjectiveCExceptionEventArgs marshalObjectiveCExceptionEventArgs = new MarshalObjectiveCExceptionEventArgs
            {
                Exception = nSObject,
                ExceptionMode = (throwManagedAsDefault ? MarshalObjectiveCExceptionMode.ThrowManagedException : objc_exception_mode)
            };
            Runtime.MarshalObjectiveCException(null, marshalObjectiveCExceptionEventArgs);
            return marshalObjectiveCExceptionEventArgs.ExceptionMode;
        }
        return objc_exception_mode;
    }

    private static MarshalManagedExceptionMode OnMarshalManagedException(int exception_handle)
    {
        if (Runtime.MarshalManagedException != null)
        {
            Exception exception = GCHandle.FromIntPtr(new IntPtr(exception_handle)).Target as Exception;
            MarshalManagedExceptionEventArgs marshalManagedExceptionEventArgs = new MarshalManagedExceptionEventArgs
            {
                Exception = exception,
                ExceptionMode = managed_exception_mode
            };
            Runtime.MarshalManagedException(null, marshalManagedExceptionEventArgs);
            return marshalManagedExceptionEventArgs.ExceptionMode;
        }
        return managed_exception_mode;
    }

    private static IntPtr GetFunctionPointer(Delegate d)
    {
        delegates.Add(d);
        return Marshal.GetFunctionPointerForDelegate(d);
    }

    private static IntPtr ConvertSmartEnumToNSString(IntPtr value_handle)
    {
        object target = GCHandle.FromIntPtr(value_handle).Target;
        Type type = target.GetType();
        if (!Registrar.IsSmartEnum(type, out var getConstantMethod, out var _))
        {
            throw ErrorHelper.CreateError(8024, "Could not find a valid extension type for the smart enum '" + type.FullName + "'. Please file a bug at https://github.com/xamarin/xamarin-macios/issues/new.");
        }
        NSString nSString = (NSString)((MethodInfo)getConstantMethod).Invoke(null, new object[1] { target });
        if (nSString == null)
        {
            return IntPtr.Zero;
        }
        nSString.DangerousRetain().DangerousAutorelease();
        return nSString.Handle;
    }

    private static IntPtr ConvertNSStringToSmartEnum(IntPtr value, IntPtr type)
    {
        Type type2 = (Type)ObjectWrapper.Convert(type);
        NSString nSObject = GetNSObject<NSString>(value);
        if (!Registrar.IsSmartEnum(type2, out var _, out var getValueMethod))
        {
            throw ErrorHelper.CreateError(8024, "Could not find a valid extension type for the smart enum '" + type2.FullName + "'. Please file a bug at https://github.com/xamarin/xamarin-macios/issues/new.");
        }
        object value2 = ((MethodInfo)getValueMethod).Invoke(null, new object[1] { nSObject });
        return GCHandle.ToIntPtr(GCHandle.Alloc(value2));
    }

    private static void RegisterNSObject(IntPtr managed_obj, IntPtr native_obj)
    {
        RegisterNSObject((NSObject)ObjectWrapper.Convert(managed_obj), native_obj);
    }

    private static void RegisterAssembly(IntPtr a)
    {
        RegisterAssembly((Assembly)ObjectWrapper.Convert(a));
    }

    private static void RegisterEntryAssembly(IntPtr a)
    {
        RegisterEntryAssembly((Assembly)ObjectWrapper.Convert(a));
    }

    private static void ThrowNSException(IntPtr ns_exception)
    {
        throw new ObjCException(new NSException(ns_exception));
    }

    private static void RethrowManagedException(uint exception_gchandle)
    {
        Exception source = (Exception)GCHandle.FromIntPtr((IntPtr)exception_gchandle).Target;
        ExceptionDispatchInfo.Capture(source).Throw();
    }

    private static int CreateNSException(IntPtr ns_exception)
    {
        Exception value = new ObjCException(GetNSObject<NSException>(ns_exception));
        return GCHandle.ToIntPtr(GCHandle.Alloc(value)).ToInt32();
    }

    private static int CreateRuntimeException(int code, IntPtr message)
    {
        RuntimeException value = ErrorHelper.CreateError(code, Marshal.PtrToStringAuto(message));
        return GCHandle.ToIntPtr(GCHandle.Alloc(value)).ToInt32();
    }

    private static IntPtr UnwrapNSException(uint exc_handle)
    {
        object target = GCHandle.FromIntPtr(new IntPtr(exc_handle)).Target;
        if (target is ObjCException ex)
        {
            return ex.NSException.DangerousRetain().DangerousAutorelease().Handle;
        }
        return IntPtr.Zero;
    }

    private static IntPtr GetBlockWrapperCreator(IntPtr method, int parameter)
    {
        return ObjectWrapper.Convert(GetBlockWrapperCreator((MethodInfo)ObjectWrapper.Convert(method), parameter));
    }

    private static IntPtr CreateBlockProxy(IntPtr method, IntPtr block)
    {
        return ObjectWrapper.Convert(CreateBlockProxy((MethodInfo)ObjectWrapper.Convert(method), block));
    }

    private static IntPtr CreateDelegateProxy(IntPtr method, IntPtr @delegate, IntPtr signature, uint token_ref)
    {
        return BlockLiteral.GetBlockForDelegate((MethodInfo)ObjectWrapper.Convert(method), ObjectWrapper.Convert(@delegate), token_ref, Marshal.PtrToStringAuto(signature));
    }

    private unsafe static Assembly GetEntryAssembly()
    {
        Assembly assembly = Assembly.GetEntryAssembly();
        if (assembly == null)
        {
            assembly = Assembly.LoadFile(Marshal.PtrToStringAuto(options->EntryAssemblyPath));
        }
        return assembly;
    }

    internal static void RegisterAssemblies()
    {
        RegisterEntryAssembly(GetEntryAssembly());
    }

    internal static void RegisterEntryAssembly(Assembly entry_assembly)
    {
        List<Assembly> list = new List<Assembly>();
        list.Add(NSObject.PlatformAssembly);
        if (entry_assembly != null)
        {
            bool flag = true;
            if (OnAssemblyRegistration(entry_assembly.GetName()))
            {
                CollectReferencedAssemblies(list, entry_assembly);
            }
        }
        else
        {
            Console.WriteLine("Could not find the entry assembly.");
        }
        Assembly[] array = AppDomain.CurrentDomain.GetAssemblies();
        foreach (Assembly assembly in array)
        {
            if (OnAssemblyRegistration(assembly.GetName()) && !list.Contains(assembly))
            {
                list.Add(assembly);
            }
        }
        foreach (Assembly item in list)
        {
            RegisterAssembly(item);
        }
    }

    private static void CollectReferencedAssemblies(List<Assembly> assemblies, Assembly assembly)
    {
        assemblies.Add(assembly);
        AssemblyName[] referencedAssemblies = assembly.GetReferencedAssemblies();
        foreach (AssemblyName assemblyName in referencedAssemblies)
        {
            if (!OnAssemblyRegistration(assemblyName))
            {
                continue;
            }
            try
            {
                Assembly assembly2 = Assembly.Load(assemblyName);
                if (!assemblies.Contains(assembly2))
                {
                    CollectReferencedAssemblies(assemblies, assembly2);
                }
            }
            catch (FileNotFoundException ex)
            {
                NSLog("Could not find `{0}` referenced by assembly `{1}`.", ex.FileName, assembly.FullName);
                if (!NSApplication.IgnoreMissingAssembliesDuringRegistration)
                {
                    throw;
                }
            }
        }
    }

    internal static IEnumerable<Assembly> GetAssemblies()
    {
        return Registrar.GetAssemblies();
    }

    internal static string ComputeSignature(MethodInfo method, bool isBlockSignature)
    {
        return Registrar.ComputeSignature(method, isBlockSignature);
    }

    [BindingImpl(BindingImplOptions.Optimizable)]
    public static void RegisterAssembly(Assembly a)
    {
        if (a == null)
        {
            throw new ArgumentNullException("a");
        }
        if (!DynamicRegistrationSupported)
        {
            throw ErrorHelper.CreateError(8026, "Runtime.RegisterAssembly is not supported when the dynamic registrar has been linked away.");
        }
        object[] customAttributes = a.GetCustomAttributes(typeof(RequiredFrameworkAttribute), inherit: false);
        object[] array = customAttributes;
        foreach (object obj in array)
        {
            RequiredFrameworkAttribute requiredFrameworkAttribute = (RequiredFrameworkAttribute)obj;
            string text = requiredFrameworkAttribute.Name;
            string path;
            if (text.Contains(".dylib"))
            {
                path = ResourcesPath;
            }
            else
            {
                path = FrameworksPath;
                path = Path.Combine(path, text);
                text = text.Replace(".frameworks", "");
            }
            path = Path.Combine(path, text);
            if (Dlfcn.dlopen(path, 0) == IntPtr.Zero)
            {
                throw new Exception($"Unable to load required framework: '{requiredFrameworkAttribute.Name}'", new Exception(Dlfcn.dlerror()));
            }
        }
        customAttributes = a.GetCustomAttributes(typeof(DelayedRegistrationAttribute), inherit: false);
        object[] array2 = customAttributes;
        foreach (object obj2 in array2)
        {
            DelayedRegistrationAttribute delayedRegistrationAttribute = (DelayedRegistrationAttribute)obj2;
            if (delayedRegistrationAttribute.Delay)
            {
                return;
            }
        }
        if (assemblies == null)
        {
            assemblies = new List<Assembly>();
            Class.Register(typeof(NSObject));
        }
        if (!assemblies.Contains(a))
        {
            assemblies.Add(a);
            Registrar.RegisterAssembly(a);
        }
    }

    private static IntPtr GetClass(IntPtr klass)
    {
        return ObjectWrapper.Convert(new Class(klass));
    }

    private static IntPtr GetSelector(IntPtr sel)
    {
        return ObjectWrapper.Convert(new Selector(sel));
    }

    private static void GetMethodForSelector(IntPtr cls, IntPtr sel, bool is_static, IntPtr desc)
    {
        Registrar.GetMethodDescription(Class.Lookup(cls), sel, is_static, desc);
    }

    private static IntPtr GetNSObjectWrapped(IntPtr ptr)
    {
        return ObjectWrapper.Convert(TryGetNSObject(ptr, evenInFinalizerQueue: true));
    }

    private static bool HasNSObject(IntPtr ptr)
    {
        return TryGetNSObject(ptr) != null;
    }

    private static IntPtr GetHandleForINativeObject(IntPtr ptr)
    {
        return ((INativeObject)ObjectWrapper.Convert(ptr)).Handle;
    }

    private static void UnregisterNSObject(IntPtr native_obj, IntPtr managed_obj)
    {
        NativeObjectHasDied(native_obj, ObjectWrapper.Convert(managed_obj) as NSObject);
    }

    private static IntPtr GetMethodFromToken(uint token_ref)
    {
        MethodBase methodBase = Class.ResolveMethodTokenReference(token_ref);
        if (methodBase != null)
        {
            return ObjectWrapper.Convert(methodBase);
        }
        return IntPtr.Zero;
    }

    private static IntPtr GetGenericMethodFromToken(IntPtr obj, uint token_ref)
    {
        MethodBase methodBase = Class.ResolveMethodTokenReference(token_ref);
        if (methodBase == null)
        {
            return IntPtr.Zero;
        }
        if (!(ObjectWrapper.Convert(obj) is NSObject nSObject))
        {
            throw ErrorHelper.CreateError(8023, $"An instance object is required to construct a closed generic method for the open generic method: {methodBase.DeclaringType.FullName}.{methodBase.Name} (token reference: 0x{token_ref:X}). Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new.");
        }
        return ObjectWrapper.Convert(FindClosedMethod(nSObject.GetType(), methodBase));
    }

    private static IntPtr TryGetOrConstructNSObjectWrapped(IntPtr ptr)
    {
        return ObjectWrapper.Convert(GetNSObject(ptr, MissingCtorResolution.Ignore, evenInFinalizerQueue: true));
    }

    private static IntPtr GetINativeObject_Dynamic(IntPtr ptr, bool owns, IntPtr type_ptr)
    {
        Type target_type = (Type)ObjectWrapper.Convert(type_ptr);
        return ObjectWrapper.Convert(GetINativeObject(ptr, owns, target_type));
    }

    private static IntPtr GetINativeObject_Static(IntPtr ptr, bool owns, uint iface_token, uint implementation_token)
    {
        Type target_type = Class.ResolveTypeTokenReference(iface_token);
        Type implementation = Class.ResolveTypeTokenReference(implementation_token);
        return ObjectWrapper.Convert(GetINativeObject(ptr, owns, target_type, implementation));
    }

    private static IntPtr GetNSObjectWithType(IntPtr ptr, IntPtr type_ptr, out bool created)
    {
        Type target_type = (Type)ObjectWrapper.Convert(type_ptr);
        return ObjectWrapper.Convert(GetNSObject(ptr, target_type, MissingCtorResolution.ThrowConstructor1NotFound, evenInFinalizerQueue: true, out created));
    }

    private static void Dispose(IntPtr mobj)
    {
        ((IDisposable)ObjectWrapper.Convert(mobj)).Dispose();
    }

    private static bool IsParameterTransient(IntPtr info, int parameter)
    {
        MethodInfo methodInfo = ObjectWrapper.Convert(info) as MethodInfo;
        if (methodInfo == null)
        {
            return false;
        }
        methodInfo = methodInfo.GetBaseDefinition();
        ParameterInfo[] parameters = methodInfo.GetParameters();
        if (parameters.Length <= parameter)
        {
            return false;
        }
        return parameters[parameter].IsDefined(typeof(TransientAttribute), inherit: false);
    }

    private static bool IsParameterOut(IntPtr info, int parameter)
    {
        MethodInfo methodInfo = ObjectWrapper.Convert(info) as MethodInfo;
        if (methodInfo == null)
        {
            return false;
        }
        methodInfo = methodInfo.GetBaseDefinition();
        ParameterInfo[] parameters = methodInfo.GetParameters();
        if (parameters.Length <= parameter)
        {
            return false;
        }
        return parameters[parameter].IsOut;
    }

    private static void GetMethodAndObjectForSelector(IntPtr klass, IntPtr sel, bool is_static, IntPtr obj, ref IntPtr mthis, IntPtr desc)
    {
        Registrar.GetMethodDescriptionAndObject(Class.Lookup(klass), sel, is_static, obj, ref mthis, desc);
    }

    private static int CreateProductException(int code, uint inner_exception_gchandle, string msg)
    {
        Exception ex = null;
        if (inner_exception_gchandle != 0)
        {
            GCHandle gCHandle = GCHandle.FromIntPtr(new IntPtr(inner_exception_gchandle));
            ex = (Exception)gCHandle.Target;
            gCHandle.Free();
        }
        Exception value = ((ex == null) ? ErrorHelper.CreateError(code, msg) : ErrorHelper.CreateError(code, ex, msg));
        return GCHandle.ToIntPtr(GCHandle.Alloc(value, GCHandleType.Normal)).ToInt32();
    }

    private static IntPtr TypeGetFullName(IntPtr type)
    {
        return Marshal.StringToHGlobalAuto(((Type)ObjectWrapper.Convert(type)).FullName);
    }

    private static IntPtr LookupManagedTypeName(IntPtr klass)
    {
        return Marshal.StringToHGlobalAuto(Class.LookupFullName(klass));
    }

    private static MethodInfo GetBlockProxyAttributeMethod(MethodInfo method, int parameter)
    {
        object[] customAttributes = method.GetParameters()[parameter].GetCustomAttributes(typeof(BlockProxyAttribute), inherit: true);
        if (customAttributes.Length == 1)
        {
            try
            {
                BlockProxyAttribute blockProxyAttribute = customAttributes[0] as BlockProxyAttribute;
                return blockProxyAttribute.Type.GetMethod("Create");
            }
            catch
            {
                return null;
            }
        }
        return null;
    }

    internal static ProtocolMemberAttribute GetProtocolMemberAttribute(Type type, string selector, MethodInfo method)
    {
        IEnumerable<ProtocolMemberAttribute> customAttributes = type.GetCustomAttributes<ProtocolMemberAttribute>();
        if (customAttributes == null)
        {
            return null;
        }
        foreach (ProtocolMemberAttribute item in customAttributes)
        {
            if (item.IsStatic != method.IsStatic || item.Selector != selector)
            {
                continue;
            }
            if (!item.IsProperty)
            {
                ParameterInfo[] parameters = method.GetParameters();
                Type[]? parameterType = item.ParameterType;
                if (((parameterType != null) ? parameterType.Length : 0) != parameters.Length)
                {
                    continue;
                }
                bool flag = false;
                for (int i = 0; i < parameters.Length; i++)
                {
                    Type type2 = parameters[i].ParameterType;
                    bool isByRef = type2.IsByRef;
                    if (isByRef)
                    {
                        type2 = type2.GetElementType();
                    }
                    if (isByRef != item.ParameterByRef[i])
                    {
                        flag = true;
                        break;
                    }
                    if (type2 != item.ParameterType[i])
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    continue;
                }
            }
            return item;
        }
        return null;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    private static MethodInfo GetBlockWrapperCreator(MethodInfo method, int parameter)
    {
        MethodInfo methodInfo = method;
        MethodInfo methodInfo2 = null;
        Type[] array = null;
        while (method != methodInfo2)
        {
            methodInfo2 = method;
            MethodInfo blockProxyAttributeMethod = GetBlockProxyAttributeMethod(method, parameter);
            if (blockProxyAttributeMethod != null)
            {
                return blockProxyAttributeMethod;
            }
            method = method.GetBaseDefinition();
        }
        string text = null;
        Type[] interfaces = method.DeclaringType.GetInterfaces();
        foreach (Type type in interfaces)
        {
            if (!type.IsDefined(typeof(ProtocolAttribute), inherit: false))
            {
                continue;
            }
            InterfaceMapping interfaceMap = method.DeclaringType.GetInterfaceMap(type);
            for (int j = 0; j < interfaceMap.TargetMethods.Length; j++)
            {
                if (interfaceMap.TargetMethods[j] == methodInfo)
                {
                    MethodInfo blockProxyAttributeMethod2 = GetBlockProxyAttributeMethod(interfaceMap.InterfaceMethods[j], parameter);
                    if (blockProxyAttributeMethod2 != null)
                    {
                        return blockProxyAttributeMethod2;
                    }
                }
            }
            if (text == null)
            {
                text = GetExportAttribute(method)?.Selector ?? string.Empty;
            }
            if (!string.IsNullOrEmpty(text))
            {
                ProtocolMemberAttribute protocolMemberAttribute = GetProtocolMemberAttribute(type, text, method);
                if (protocolMemberAttribute != null && protocolMemberAttribute.ParameterBlockProxy.Length > parameter && protocolMemberAttribute.ParameterBlockProxy[parameter] != null)
                {
                    return protocolMemberAttribute.ParameterBlockProxy[parameter].GetMethod("Create");
                }
            }
            string text2 = string.Empty;
            if (!string.IsNullOrEmpty(type.Namespace))
            {
                text2 = type.Namespace + ".";
            }
            text2 = text2 + type.Name.Substring(1) + "_Extensions";
            Type type2 = type.Assembly.GetType(text2, throwOnError: false);
            if (!(type2 != null))
            {
                continue;
            }
            if (array == null)
            {
                ParameterInfo[] parameters = method.GetParameters();
                array = new Type[parameters.Length + 1];
                for (int k = 0; k < parameters.Length; k++)
                {
                    array[k + 1] = parameters[k].ParameterType;
                }
            }
            array[0] = type;
            MethodInfo method2 = type2.GetMethod(method.Name, BindingFlags.Static | BindingFlags.Public, null, array, null);
            if (method2 != null)
            {
                MethodInfo blockProxyAttributeMethod3 = GetBlockProxyAttributeMethod(method2, parameter + 1);
                if (blockProxyAttributeMethod3 != null)
                {
                    return blockProxyAttributeMethod3;
                }
            }
        }
        throw new RuntimeException(8009, true, "Unable to locate the block to delegate conversion method for the method {0}.{1}'s parameter #{2}. Please file a bug at https://github.com/xamarin/xamarin-macios/issues/new.", method.DeclaringType.FullName, method.Name, parameter + 1);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    private static Delegate CreateBlockProxy(MethodInfo method, IntPtr block)
    {
        return (Delegate)method.Invoke(null, new object[1] { block });
    }

    internal static Delegate GetDelegateForBlock(IntPtr methodPtr, Type type)
    {
        if (block_to_delegate_cache == null)
        {
            block_to_delegate_cache = new Dictionary<IntPtrTypeValueTuple, Delegate>();
        }
        IntPtrTypeValueTuple key = new IntPtrTypeValueTuple(methodPtr, type);
        Delegate value;
        lock (block_to_delegate_cache)
        {
            if (block_to_delegate_cache.TryGetValue(key, out value))
            {
                return value;
            }
        }
        value = Marshal.GetDelegateForFunctionPointer(methodPtr, type);
        lock (block_to_delegate_cache)
        {
            block_to_delegate_cache[key] = value;
        }
        return value;
    }

    private unsafe static MethodBase FindMethod(IntPtr typeptr, IntPtr methodptr, int paramCount, IntPtr* paramptr)
    {
        Type type = Type.GetType(Marshal.PtrToStringAuto(typeptr));
        string text = Marshal.PtrToStringAuto(methodptr);
        string[] array = new string[paramCount];
        for (int i = 0; i < paramCount; i++)
        {
            array[i] = Marshal.PtrToStringAuto(paramptr[i]);
        }
        MethodBase[] array2;
        if (text == ".ctor")
        {
            MethodBase[] constructors = type.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            array2 = constructors;
        }
        else
        {
            MethodBase[] constructors = type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            array2 = constructors;
        }
        MethodBase[] array3 = array2;
        foreach (MethodBase methodBase in array3)
        {
            if (methodBase.Name != text)
            {
                continue;
            }
            ParameterInfo[] parameters = methodBase.GetParameters();
            if (parameters.Length != paramCount)
            {
                continue;
            }
            bool flag = true;
            for (int k = 0; k < paramCount; k++)
            {
                Type parameterType = parameters[k].ParameterType;
                string text2 = parameterType.AssemblyQualifiedName;
                if (parameterType.IsGenericType)
                {
                    int num = 0;
                    while ((num = text2.IndexOf(", Version=", num, StringComparison.OrdinalIgnoreCase)) != -1)
                    {
                        int num2 = text2.IndexOf(']', num);
                        text2 = ((num2 == -1) ? text2.Substring(0, num) : text2.Remove(num, num2 - num));
                    }
                }
                if (parameterType.Name != array[k] && !text2.StartsWith(array[k], StringComparison.Ordinal))
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                return methodBase;
            }
        }
        throw ErrorHelper.CreateError(8002, "Could not find the method '{0}' in the type '{1}'.", text, type.FullName);
    }

    internal static void UnregisterNSObject(IntPtr ptr)
    {
        lock (lock_obj)
        {
            object_map.Remove(ptr);
        }
    }

    private static void NativeObjectHasDied(IntPtr ptr, NSObject managed_obj)
    {
        lock (lock_obj)
        {
            if (object_map.TryGetValue(ptr, out var value) && (managed_obj == null || value.Target == managed_obj))
            {
                object_map.Remove(ptr);
            }
            managed_obj?.ClearHandle();
        }
    }

    internal static void RegisterNSObject(NSObject obj, IntPtr ptr)
    {
        lock (lock_obj)
        {
            object_map[ptr] = new WeakReference(obj, trackResurrection: true);
            obj.Handle = ptr;
        }
    }

    internal static PropertyInfo FindPropertyInfo(MethodInfo accessor)
    {
        if (!accessor.IsSpecialName)
        {
            return null;
        }
        PropertyInfo[] properties = accessor.DeclaringType.GetProperties();
        foreach (PropertyInfo propertyInfo in properties)
        {
            if (propertyInfo.GetGetMethod() == accessor)
            {
                return propertyInfo;
            }
            if (propertyInfo.GetSetMethod() == accessor)
            {
                return propertyInfo;
            }
        }
        return null;
    }

    internal static ExportAttribute GetExportAttribute(MethodInfo method)
    {
        ExportAttribute customAttribute = method.GetCustomAttribute<ExportAttribute>();
        if (customAttribute == null)
        {
            PropertyInfo propertyInfo = FindPropertyInfo(method);
            if (propertyInfo != null)
            {
                customAttribute = propertyInfo.GetCustomAttribute<ExportAttribute>();
            }
        }
        return customAttribute;
    }

    private static NSObject IgnoreConstructionError(IntPtr ptr, IntPtr klass, Type type)
    {
        return null;
    }

    private static void MissingCtor(IntPtr ptr, IntPtr klass, Type type, MissingCtorResolution resolution)
    {
        if (klass == IntPtr.Zero)
        {
            klass = Class.GetClassForObject(ptr);
        }
        string format;
        switch (resolution)
        {
            default:
                return;
            case MissingCtorResolution.ThrowConstructor1NotFound:
                format = "Failed to marshal the Objective-C object 0x{0} (type: {1}). Could not find an existing managed instance for this object, nor was it possible to create a new managed instance (because the type '{2}' does not have a constructor that takes one IntPtr argument).";
                break;
            case MissingCtorResolution.ThrowConstructor2NotFound:
                format = "Failed to marshal the Objective-C object 0x{0} (type: {1}). Could not find an existing managed instance for this object, nor was it possible to create a new managed instance (because the type '{2}' does not have a constructor that takes two (IntPtr, bool) arguments).";
                break;
            case MissingCtorResolution.Ignore:
                return;
        }
        throw ErrorHelper.CreateError(8027, string.Format(format, ptr.ToString("x"), new Class(klass).Name, type.FullName));
    }

    private static NSObject ConstructNSObject(IntPtr ptr, IntPtr klass, MissingCtorResolution missingCtorResolution)
    {
        Type type = Class.Lookup(klass);
        if (type != null)
        {
            return ConstructNSObject<NSObject>(ptr, type, missingCtorResolution);
        }
        return new NSObject(ptr);
    }

    internal static T ConstructNSObject<T>(IntPtr ptr) where T : NSObject
    {
        return ConstructNSObject<T>(ptr, typeof(T), MissingCtorResolution.ThrowConstructor1NotFound);
    }

    private static T ConstructNSObject<T>(IntPtr ptr, Type type, MissingCtorResolution missingCtorResolution) where T : class, INativeObject
    {
        if (type == null)
        {
            throw new ArgumentNullException("type");
        }
        ConstructorInfo intPtrConstructor = GetIntPtrConstructor(type);
        if (intPtrConstructor == null)
        {
            MissingCtor(ptr, IntPtr.Zero, type, missingCtorResolution);
            return null;
        }
        return (T)intPtrConstructor.Invoke(new object[1] { ptr });
    }

    private static T ConstructINativeObject<T>(IntPtr ptr, bool owns, Type type, MissingCtorResolution missingCtorResolution) where T : class, INativeObject
    {
        if (type == null)
        {
            throw new ArgumentNullException("type");
        }
        if (type.IsByRef)
        {
            type = type.GetElementType();
        }
        ConstructorInfo intPtr_BoolConstructor = GetIntPtr_BoolConstructor(type);
        if (intPtr_BoolConstructor == null)
        {
            MissingCtor(ptr, IntPtr.Zero, type, missingCtorResolution);
        }
        return (T)intPtr_BoolConstructor.Invoke(new object[2] { ptr, owns });
    }

    private static ConstructorInfo GetIntPtrConstructor(Type type)
    {
        lock (intptr_ctor_cache)
        {
            if (intptr_ctor_cache.TryGetValue(type, out var value))
            {
                return value;
            }
        }
        ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        for (int i = 0; i < constructors.Length; i++)
        {
            ParameterInfo[] parameters = constructors[i].GetParameters();
            if (parameters.Length == 1 && parameters[0].ParameterType == typeof(IntPtr))
            {
                lock (intptr_ctor_cache)
                {
                    intptr_ctor_cache[type] = constructors[i];
                }
                return constructors[i];
            }
        }
        return null;
    }

    private static ConstructorInfo GetIntPtr_BoolConstructor(Type type)
    {
        lock (intptr_bool_ctor_cache)
        {
            if (intptr_bool_ctor_cache.TryGetValue(type, out var value))
            {
                return value;
            }
        }
        ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        for (int i = 0; i < constructors.Length; i++)
        {
            ParameterInfo[] parameters = constructors[i].GetParameters();
            if (parameters.Length == 2 && parameters[0].ParameterType == typeof(IntPtr) && parameters[1].ParameterType == typeof(bool))
            {
                lock (intptr_bool_ctor_cache)
                {
                    intptr_bool_ctor_cache[type] = constructors[i];
                }
                return constructors[i];
            }
        }
        return null;
    }

    public static NSObject TryGetNSObject(IntPtr ptr)
    {
        return TryGetNSObject(ptr, evenInFinalizerQueue: false);
    }

    internal static NSObject TryGetNSObject(IntPtr ptr, bool evenInFinalizerQueue = false)
    {
        lock (lock_obj)
        {
            if (object_map.TryGetValue(ptr, out var value))
            {
                NSObject nSObject = (NSObject)value.Target;
                if (nSObject == null)
                {
                    return null;
                }
                if (nSObject.InFinalizerQueue)
                {
                    if (!evenInFinalizerQueue)
                    {
                        return null;
                    }
                    if (nSObject.IsDirectBinding && !nSObject.IsRegisteredToggleRef)
                    {
                        return null;
                    }
                }
                return nSObject;
            }
        }
        return null;
    }

    public static NSObject GetNSObject(IntPtr ptr)
    {
        return GetNSObject(ptr, MissingCtorResolution.ThrowConstructor1NotFound);
    }

    internal static NSObject GetNSObject(IntPtr ptr, MissingCtorResolution missingCtorResolution, bool evenInFinalizerQueue = false)
    {
        if (ptr == IntPtr.Zero)
        {
            return null;
        }
        NSObject nSObject = TryGetNSObject(ptr, evenInFinalizerQueue);
        if (nSObject != null)
        {
            return nSObject;
        }
        return ConstructNSObject(ptr, Class.GetClassForObject(ptr), missingCtorResolution);
    }

    public static T GetNSObject<T>(IntPtr ptr) where T : NSObject
    {
        if (ptr == IntPtr.Zero)
        {
            return null;
        }
        object obj = TryGetNSObject(ptr);
        T val;
        if (obj == null)
        {
            IntPtr classForObject = Class.GetClassForObject(ptr);
            Type type;
            if (classForObject != NSObjectClass)
            {
                type = Class.Lookup(classForObject);
                if (type == typeof(NSObject))
                {
                    type = typeof(T);
                }
                else if (typeof(T).IsGenericType)
                {
                    type = typeof(T);
                }
                else if (!type.IsSubclassOf(typeof(T)) && Messaging.bool_objc_msgSend_IntPtr(ptr, Selector.GetHandle("isKindOfClass:"), Class.GetHandle(typeof(T))))
                {
                    type = typeof(T);
                }
            }
            else
            {
                type = typeof(NSObject);
            }
            val = ConstructNSObject<T>(ptr, type, MissingCtorResolution.ThrowConstructor1NotFound);
        }
        else
        {
            val = obj as T;
            if (val == null)
            {
                throw new InvalidCastException($"Unable to cast object of type '{obj.GetType().FullName}' to type '{typeof(T).FullName}'");
            }
        }
        return val;
    }

    public static T GetNSObject<T>(IntPtr ptr, bool owns) where T : NSObject
    {
        T nSObject = GetNSObject<T>(ptr);
        if (owns)
        {
            nSObject?.DangerousRelease();
        }
        return nSObject;
    }

    private static NSObject GetNSObject(IntPtr ptr, Type target_type, MissingCtorResolution missingCtorResolution, bool evenInFinalizerQueue, out bool created)
    {
        created = false;
        if (ptr == IntPtr.Zero)
        {
            return null;
        }
        NSObject nSObject = TryGetNSObject(ptr, evenInFinalizerQueue);
        if (nSObject != null)
        {
            return nSObject;
        }
        IntPtr classForObject = Class.GetClassForObject(ptr);
        if (classForObject != NSObjectClass)
        {
            Type type = Class.Lookup(classForObject);
            if (!(type == typeof(NSObject)))
            {
                if (type.IsSubclassOf(target_type))
                {
                    target_type = type;
                }
                else if (!Messaging.bool_objc_msgSend_IntPtr(ptr, Selector.GetHandle("isKindOfClass:"), Class.GetHandle(target_type)))
                {
                    target_type = type;
                }
            }
        }
        else
        {
            target_type = typeof(NSObject);
        }
        created = true;
        return ConstructNSObject<NSObject>(ptr, target_type, MissingCtorResolution.ThrowConstructor1NotFound);
    }

    private static Type LookupINativeObjectImplementation(IntPtr ptr, Type target_type, Type implementation = null)
    {
        if (!typeof(NSObject).IsAssignableFrom(target_type))
        {
            implementation = target_type;
        }
        else
        {
            IntPtr classForObject = Class.GetClassForObject(ptr);
            if (classForObject == NSObjectClass)
            {
                if (implementation == null)
                {
                    implementation = target_type;
                }
            }
            else
            {
                Type type = Class.Lookup(classForObject);
                if (target_type.IsAssignableFrom(type))
                {
                    implementation = type;
                }
                else if (implementation == null)
                {
                    implementation = target_type;
                }
            }
        }
        if (implementation.IsInterface)
        {
            implementation = FindProtocolWrapperType(implementation);
        }
        return implementation;
    }

    public static INativeObject GetINativeObject(IntPtr ptr, bool owns, Type target_type)
    {
        return GetINativeObject(ptr, owns, target_type, null);
    }

    private static INativeObject GetINativeObject(IntPtr ptr, bool owns, Type target_type, Type implementation)
    {
        if (ptr == IntPtr.Zero)
        {
            return null;
        }
        NSObject nSObject = TryGetNSObject(ptr);
        if (nSObject != null && target_type.IsAssignableFrom(nSObject.GetType()))
        {
            return nSObject;
        }
        if (nSObject != null && !target_type.IsInterface)
        {
            throw new InvalidCastException($"Unable to cast object of type '{nSObject.GetType().FullName}' to type '{target_type.FullName}'.");
        }
        implementation = LookupINativeObjectImplementation(ptr, target_type, implementation);
        if (implementation.IsSubclassOf(typeof(NSObject)))
        {
            if (nSObject != null)
            {
                throw ErrorHelper.CreateError(8004, "Cannot create an instance of {0} for the native object 0x{1} (of type '{2}'), because another instance already exists for this native object (of type {3}).", implementation.FullName, ptr.ToString("x"), Class.class_getName(Class.GetClassForObject(ptr)), nSObject.GetType().FullName);
            }
            return ConstructNSObject<INativeObject>(ptr, implementation, MissingCtorResolution.ThrowConstructor1NotFound);
        }
        return ConstructINativeObject<INativeObject>(ptr, owns, implementation, MissingCtorResolution.ThrowConstructor2NotFound);
    }

    public static T GetINativeObject<T>(IntPtr ptr, bool owns) where T : class, INativeObject
    {
        return GetINativeObject<T>(ptr, forced_type: false, owns);
    }

    public static T GetINativeObject<T>(IntPtr ptr, bool forced_type, bool owns) where T : class, INativeObject
    {
        if (ptr == IntPtr.Zero)
        {
            return null;
        }
        NSObject nSObject = TryGetNSObject(ptr);
        if (nSObject is T result)
        {
            return result;
        }
        if (nSObject != null && !forced_type && !typeof(T).IsInterface && typeof(NSObject).IsAssignableFrom(typeof(T)))
        {
            throw new InvalidCastException($"Unable to cast object of type '{nSObject.GetType().FullName}' to type '{typeof(T).FullName}'.");
        }
        Type type = LookupINativeObjectImplementation(ptr, typeof(T));
        if (type.IsSubclassOf(typeof(NSObject)))
        {
            if (nSObject != null && !forced_type)
            {
                throw ErrorHelper.CreateError(8004, "Cannot create an instance of {0} for the native object 0x{1} (of type '{2}'), because another instance already exists for this native object (of type {3}).", type.FullName, ptr.ToString("x"), Class.class_getName(Class.GetClassForObject(ptr)), nSObject.GetType().FullName);
            }
            return ConstructNSObject<T>(ptr, type, MissingCtorResolution.ThrowConstructor1NotFound);
        }
        return ConstructINativeObject<T>(ptr, owns, type, MissingCtorResolution.ThrowConstructor2NotFound);
    }

    private unsafe static Type FindProtocolWrapperType(Type type)
    {
        if (type == null || !type.IsInterface)
        {
            return null;
        }
        MTRegistrationMap* registrationMap = options->RegistrationMap;
        if (registrationMap != null)
        {
            uint tokenReference = Class.GetTokenReference(type, throw_exception: false);
            if (tokenReference != uint.MaxValue)
            {
                uint num = xamarin_find_protocol_wrapper_type(tokenReference);
                if (num != uint.MaxValue)
                {
                    return Class.ResolveTypeTokenReference(num);
                }
            }
        }
        object[] customAttributes = type.GetCustomAttributes(typeof(ProtocolAttribute), inherit: false);
        ProtocolAttribute protocolAttribute = (ProtocolAttribute)((customAttributes.Length != 0) ? customAttributes[0] : null);
        if (protocolAttribute == null || protocolAttribute.WrapperType == null)
        {
            throw ErrorHelper.CreateError(4125, "The registrar found an invalid interface '{0}': The interface must have a Protocol attribute specifying its wrapper type.", type.FullName);
        }
        return protocolAttribute.WrapperType;
    }

    [DllImport("__Internal")]
    private static extern uint xamarin_find_protocol_wrapper_type(uint token_ref);

    public static IntPtr GetProtocol(string protocol)
    {
        return Protocol.objc_getProtocol(protocol);
    }

    internal unsafe static IntPtr GetProtocolForType(Type type)
    {
        MTRegistrationMap* registrationMap = options->RegistrationMap;
        if (registrationMap != null && registrationMap->protocol_count > 0)
        {
            uint tokenReference = Class.GetTokenReference(type);
            uint* protocol_tokens = registrationMap->protocol_map.protocol_tokens;
            for (int i = 0; i < registrationMap->protocol_count; i++)
            {
                if (protocol_tokens[i] == tokenReference)
                {
                    return registrationMap->protocol_map.protocols[i];
                }
            }
        }
        if (type.IsInterface)
        {
            ProtocolAttribute customAttribute = type.GetCustomAttribute<ProtocolAttribute>(inherit: false);
            if (customAttribute != null)
            {
                IntPtr intPtr = Protocol.objc_getProtocol(customAttribute.Name);
                if (intPtr != IntPtr.Zero)
                {
                    return intPtr;
                }
            }
        }
        throw new ArgumentException($"'{type.FullName}' is an unknown protocol");
    }

    public static void ConnectMethod(Type type, MethodInfo method, Selector selector)
    {
        if (selector == null)
        {
            throw new ArgumentNullException("selector");
        }
        ConnectMethod(type, method, new ExportAttribute(selector.Name));
    }

    [BindingImpl(BindingImplOptions.Optimizable)]
    public static void ConnectMethod(Type type, MethodInfo method, ExportAttribute export)
    {
        if (type == null)
        {
            throw new ArgumentNullException("type");
        }
        if (method == null)
        {
            throw new ArgumentNullException("method");
        }
        if (export == null)
        {
            throw new ArgumentNullException("export");
        }
        if (!DynamicRegistrationSupported)
        {
            throw ErrorHelper.CreateError(8026, "Runtime.ConnectMethod is not supported when the dynamic registrar has been linked away.");
        }
        Registrar.RegisterMethod(type, method, export);
    }

    public static void ConnectMethod(MethodInfo method, Selector selector)
    {
        if (method == null)
        {
            throw new ArgumentNullException("method");
        }
        ConnectMethod(method.DeclaringType, method, selector);
    }

    [DllImport("/System/Library/Frameworks/Foundation.framework/Foundation", EntryPoint = "NSLog")]
    private static extern void NSLog_impl(IntPtr format, [MarshalAs(UnmanagedType.LPStr)] string s);

    private static void NSLog(IntPtr format, string s)
    {
        if (PlatformHelper.CheckSystemVersion(10, 12))
        {
            Console.WriteLine(s);
        }
        else
        {
            NSLog_impl(format, s);
        }
    }

    [BindingImpl(BindingImplOptions.Optimizable)]
    internal static void NSLog(string format, params object[] args)
    {
        IntPtr intPtr = NSString.CreateNative("%s");
        string s = ((args == null || args.Length == 0) ? format : string.Format(format, args));
        NSLog(intPtr, s);
        NSString.ReleaseNative(intPtr);
    }

    internal static bool CheckSystemVersion(int major, int minor, string systemVersion)
    {
        return CheckSystemVersion(major, minor, 0, systemVersion);
    }

    internal static bool CheckSystemVersion(int major, int minor, int build, string systemVersion)
    {
        if (MajorVersion == -1)
        {
            string[] array = systemVersion.Split('.');
            if (array.Length < 1 || !int.TryParse(array[0], NumberStyles.Integer, CultureInfo.InvariantCulture, out MajorVersion))
            {
                MajorVersion = 2;
            }
            if (array.Length < 2 || !int.TryParse(array[1], NumberStyles.Integer, CultureInfo.InvariantCulture, out MinorVersion))
            {
                MinorVersion = 0;
            }
            if (array.Length < 3 || !int.TryParse(array[2], NumberStyles.Integer, CultureInfo.InvariantCulture, out BuildVersion))
            {
                BuildVersion = 0;
            }
        }
        if (MajorVersion > major)
        {
            return true;
        }
        if (MajorVersion < major)
        {
            return false;
        }
        if (MinorVersion > minor)
        {
            return true;
        }
        if (MinorVersion < minor)
        {
            return false;
        }
        if (BuildVersion < build)
        {
            return false;
        }
        return true;
    }

    internal static IntPtr CloneMemory(IntPtr source, nint length)
    {
        IntPtr intPtr = Marshal.AllocHGlobal(new IntPtr(length));
        memcpy(intPtr, source, length);
        return intPtr;
    }

    [DllImport("/usr/lib/libSystem.dylib")]
    internal static extern void memcpy(IntPtr target, IntPtr source, nint n);

    [DllImport("/usr/lib/libSystem.dylib")]
    internal unsafe static extern void memcpy(byte* target, byte* source, nint n);

    internal unsafe static bool StringEquals(IntPtr utf8, string str)
    {
        byte* ptr = (byte*)(void*)utf8;
        for (int i = 0; i < str.Length; i++)
        {
            byte b = ptr[i];
            if (b > 127)
            {
                return string.Equals(MarshalHelper.PtrToStringUTF8(utf8), str);
            }
            if (b != (short)str[i])
            {
                return false;
            }
        }
        return ptr[str.Length] == 0;
    }

    internal static MethodInfo FindClosedMethod(Type closed_type, MethodBase open_method)
    {
        if (!open_method.ContainsGenericParameters)
        {
            return (MethodInfo)open_method;
        }
        Type type = closed_type;
        do
        {
            if (type.IsGenericType && type.GetGenericTypeDefinition() == open_method.DeclaringType)
            {
                closed_type = type;
                break;
            }
            type = type.BaseType;
        }
        while (type != null);
        MethodInfo[] methods = closed_type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
        foreach (MethodInfo methodInfo in methods)
        {
            if (methodInfo.MetadataToken == open_method.MetadataToken)
            {
                return methodInfo;
            }
        }
        throw ErrorHelper.CreateError(8003, "Failed to find the closed generic method '{0}' on the type '{1}'.", open_method.Name, closed_type.FullName);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public static void ReleaseBlockOnMainThread(IntPtr block)
    {
        if (release_block_on_main_thread == null)
        {
            release_block_on_main_thread = LookupInternalFunction<intptr_func>("xamarin_release_block_on_main_thread");
        }
        release_block_on_main_thread(block);
    }

    internal static T ThrowOnNull<T>(T obj, string name, string message = null) where T : class
    {
        return obj ?? throw new ArgumentNullException(name, message);
    }

    [DllImport("/usr/lib/libSystem.dylib")]
    private unsafe static extern NXArchInfo* NXGetLocalArchInfo();

    [BindingImpl(BindingImplOptions.Optimizable)]
    private static bool GetIsARM64CallingConvention()
    {
        return false;
    }

    public static void ChangeToOriginalWorkingDirectory()
    {
        Directory.SetCurrentDirectory(OriginalWorkingDirectory);
    }

    internal static T LookupInternalFunction<T>(string name) where T : class
    {
        IntPtr intPtr;
        if (runtime_library == IntPtr.Zero)
        {
            runtime_library = new IntPtr(-2);
            intPtr = Dlfcn.dlsym(runtime_library, name);
            if (intPtr == IntPtr.Zero)
            {
                runtime_library = Dlfcn.dlopen("libxammac.dylib", 0);
                if (runtime_library == IntPtr.Zero)
                {
                    runtime_library = Dlfcn.dlopen(Path.Combine(Path.GetDirectoryName(typeof(NSApplication).Assembly.Location), "libxammac.dylib"), 0);
                }
                if (runtime_library == IntPtr.Zero)
                {
                    throw new DllNotFoundException("Could not find the runtime library libxammac.dylib");
                }
                intPtr = Dlfcn.dlsym(runtime_library, name);
            }
        }
        else
        {
            intPtr = Dlfcn.dlsym(runtime_library, name);
        }
        if (intPtr == IntPtr.Zero)
        {
            throw new EntryPointNotFoundException($"Could not find the runtime method '{name}'");
        }
        return (T)(object)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(T));
    }

    internal static void EnsureInitialized()
    {
        if (!initialized)
        {
            if (GC.MaxGeneration <= 0)
            {
                throw ErrorHelper.CreateError(8017, "The Boehm garbage collector is not supported. Please use SGen instead.");
            }
            VerifyMonoVersion();
            LookupInternalFunction<initialize_func>("xamarin_initialize")();
        }
    }

    private static void VerifyMonoVersion()
    {
        Type type = Type.GetType("Mono.Runtime");
        if (type == null)
        {
            return;
        }
        MethodInfo method = type.GetMethod("GetDisplayName", BindingFlags.Static | BindingFlags.NonPublic);
        if (method == null)
        {
            return;
        }
        string text = method.Invoke(null, null) as string;
        if (!string.IsNullOrEmpty(text))
        {
            int num = text.IndexOf(' ');
            if (num > 0)
            {
                text = text.Substring(0, num);
            }
            if (Version.TryParse(text, out var result) && Version.TryParse("6.4.0.94", out var result2) && !(result2 <= result))
            {
                throw new NotSupportedException($"This version of Xamarin.Mac requires Mono {result2}, but found Mono {result}.");
            }
        }
    }

    private unsafe static void InitializePlatform(InitializationOptions* options)
    {
        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        if (!string.IsNullOrEmpty(baseDirectory))
        {
            baseDirectory = Path.Combine(baseDirectory, "..");
        }
        else
        {
            baseDirectory = Assembly.GetExecutingAssembly().Location;
            baseDirectory = (string.IsNullOrEmpty(baseDirectory) ? Path.Combine(Environment.CurrentDirectory, "..") : Path.Combine(Path.GetDirectoryName(baseDirectory), ".."));
        }
        ResourcesPath = Path.Combine(baseDirectory, "Resources");
        FrameworksPath = Path.Combine(baseDirectory, "Frameworks");
    }

    [Preserve]
    private static IntPtr GetNullableType(IntPtr type)
    {
        return ObjectWrapper.Convert(Registrar.GetNullableType((Type)ObjectWrapper.Convert(type)));
    }
}

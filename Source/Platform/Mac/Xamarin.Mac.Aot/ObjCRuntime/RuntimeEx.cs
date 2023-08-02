using Foundation;
using Registrar;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Xamarin.Utiles;

namespace ObjCRuntime;
public static class RuntimeEx
{
    internal enum MissingCtorResolution
    {
        ThrowConstructor1NotFound,
        ThrowConstructor2NotFound,
        Ignore
    }


    static RuntimeEx()
    {
        var architecture = RuntimeInformation.ProcessArchitecture;
        if (architecture == Architecture.Arm64)
            IsARM64CallingConvention = true;

        IntPtrEqualityComparer = new();
        TypeEqualityComparer = new();
        object_map = new();
        Registrar = new();
        lock_obj = new();
    }

    public static bool IsARM64CallingConvention = false;
    internal static IntPtrEqualityComparer IntPtrEqualityComparer;
    internal static TypeEqualityComparer TypeEqualityComparer;
    private static Dictionary<IntPtr, GCHandle> object_map;
    private static object lock_obj;
    public static bool DynamicRegistrationSupported => true;

    static DynamicRegistrar Registrar;

    internal static IntPtr AllocGCHandle(object? value, GCHandleType type = GCHandleType.Normal)
    {
        return GCHandle.ToIntPtr(GCHandle.Alloc(value, type));
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
        while ((object)type != null);
        MethodInfo[] methods = closed_type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
        foreach (MethodInfo methodInfo in methods)
        {
            if (methodInfo.MetadataToken == open_method.MetadataToken)
            {
                return methodInfo;
            }
        }
        throw ErrorHelper.CreateError(8003, $"Failed to find the closed generic method '{open_method.Name}' on the type '{closed_type.FullName}'.");
    }

    public static void RegisterEntryAssembly(Assembly assembly)
    {
        AssemblyName name = assembly.GetName();
        Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
        foreach (Assembly assembly2 in assemblies)
        {
            AssemblyName[] referencedAssemblies = assembly2.GetReferencedAssemblies();
            for (int j = 0; j < referencedAssemblies.Length; j++)
            {
                if (AssemblyName.ReferenceMatchesDefinition(referencedAssemblies[j], name))
                {
                    RegisterAssembly(assembly2);
                    break;
                }
            }
        }
    }

    public static void RegisterAssembly(Assembly assembly) => Registrar.RegisterAssembly(assembly);


    internal static ExportAttribute? GetExportAttribute(MethodInfo method)
    {
        ExportAttribute customAttribute = method.GetCustomAttribute<ExportAttribute>();
        if (customAttribute == null)
        {
            PropertyInfo propertyInfo = FindPropertyInfo(method);
            if ((object)propertyInfo != null)
            {
                customAttribute = propertyInfo.GetCustomAttribute<ExportAttribute>();
            }
        }
        return customAttribute;
    }

    internal static PropertyInfo? FindPropertyInfo(MethodInfo accessor)
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


    internal static ProtocolMemberAttribute? GetProtocolMemberAttribute(Type type, string selector, MethodInfo method)
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

    internal static void MissingCtor(IntPtr ptr, IntPtr klass, Type type, MissingCtorResolution resolution)
    {
        if (resolution == MissingCtorResolution.Ignore)
            return;

        if (klass == IntPtr.Zero)
            klass = Class.GetClassForObject(ptr);

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("Failed to marshal the Objective-C object 0x");
        stringBuilder.Append(ptr.ToString("x"));
        stringBuilder.Append(" (type: ");
        stringBuilder.Append(new Class(klass).Name);
        stringBuilder.Append("). Could not find an existing managed instance for this object, nor was it possible to create a new managed instance (because the type '");
        stringBuilder.Append(type.FullName);
        stringBuilder.Append("' does not have a constructor that takes ");
        switch (resolution)
        {
            case MissingCtorResolution.ThrowConstructor1NotFound:
                stringBuilder.Append("one NativeHandle argument");
                break;
            case MissingCtorResolution.ThrowConstructor2NotFound:
                stringBuilder.Append("two (NativeHandle, bool) arguments");
                break;
        }
        stringBuilder.Append(").");
        throw ErrorHelper.CreateError(8027, stringBuilder.ToString());
    }


    //public static NSObject? GetNSObject(IntPtr ptr)
    //{
    //    return GetNSObject(ptr, MissingCtorResolution.ThrowConstructor1NotFound);
    //}

    //internal static NSObject? GetNSObject(IntPtr ptr, MissingCtorResolution missingCtorResolution, bool evenInFinalizerQueue = false)
    //{
    //    if (ptr == IntPtr.Zero)
    //    {
    //        return null;
    //    }
    //    NSObject nSObject = TryGetNSObject(ptr, evenInFinalizerQueue);
    //    if (nSObject != null)
    //    {
    //        return nSObject;
    //    }
    //    return ConstructNSObject(ptr, Class.GetClassForObject(ptr), missingCtorResolution);
    //}

    //internal static NSObject? TryGetNSObject(IntPtr ptr, bool evenInFinalizerQueue)
    //{
    //    lock (lock_obj)
    //    {
    //        if (object_map.TryGetValue(ptr, out var value))
    //        {
    //            NSObject nSObject = (NSObject)value.Target;
    //            if (nSObject == null)
    //            {
    //                return null;
    //            }
    //            if (nSObject.InFinalizerQueue)
    //            {
    //                if (!evenInFinalizerQueue)
    //                {
    //                    return null;
    //                }
    //                if (nSObject.IsDirectBinding && !nSObject.IsRegisteredToggleRef)
    //                {
    //                    return null;
    //                }
    //            }
    //            return nSObject;
    //        }
    //    }
    //    return null;
    //}

}

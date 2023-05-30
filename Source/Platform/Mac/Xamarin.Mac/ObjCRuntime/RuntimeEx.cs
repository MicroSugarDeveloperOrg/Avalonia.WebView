using Foundation;
using System.Reflection;
using System.Runtime.InteropServices;
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


    public static bool Initialize()
    {
        var architecture = RuntimeInformation.ProcessArchitecture;
        if (architecture == Architecture.Arm64)
            IsARM64CallingConvention = true;

        IntPtrEqualityComparer = new();
        TypeEqualityComparer = new();

        return true;
    }

    internal static IntPtrEqualityComparer IntPtrEqualityComparer;

    internal static TypeEqualityComparer TypeEqualityComparer;


    private static Dictionary<IntPtr, GCHandle> object_map;

    private static object lock_obj;

    public static bool IsARM64CallingConvention = false;

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

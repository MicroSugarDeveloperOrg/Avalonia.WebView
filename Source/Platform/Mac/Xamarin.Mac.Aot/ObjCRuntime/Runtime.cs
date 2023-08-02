using Foundation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Xamarin.Utiles;
using static ObjCRuntime.RuntimeEx;

namespace ObjCRuntime;

public static class Runtime
{
    static Runtime()
    {
        object_map = new Dictionary<IntPtr, WeakReference>();
        intptr_ctor_cache = new();
        lock_obj = new object();
        selClass = Selector.GetHandle("class");
        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        if (!string.IsNullOrEmpty(baseDirectory))
            baseDirectory = Path.Combine(baseDirectory, "..");
        else
        {
            baseDirectory = Assembly.GetExecutingAssembly().Location;
            if (string.IsNullOrEmpty(baseDirectory))
                throw new InvalidOperationException("Cannot get base path of current app domain");

            baseDirectory = Path.Combine(Path.GetDirectoryName(baseDirectory), "..");
        }
        ResourcesPath = Path.Combine(baseDirectory, "Resources");
        FrameworksPath = Path.Combine(baseDirectory, "Frameworks");
    }

    private static List<Assembly> assemblies;

    private static Dictionary<IntPtr, WeakReference> object_map;

    private static Dictionary<Type, ConstructorInfo> intptr_ctor_cache;

    private static object lock_obj;

    private static IntPtr selClass;

    public static string FrameworksPath { get; set; }

    public static string ResourcesPath { get; set; }

    public static void RegisterEntryAssembly(Assembly entryAssembly)
    {
        RegisterAssembly(entryAssembly);
        AssemblyName name = entryAssembly.GetName();
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

    public static void RegisterAssembly(Assembly a)
    {
        object[] customAttributes = a.GetCustomAttributes(typeof(RequiredFrameworkAttribute), inherit: false);
        for (int i = 0; i < customAttributes.Length; i++)
        {
            RequiredFrameworkAttribute requiredFrameworkAttribute = (RequiredFrameworkAttribute)customAttributes[i];
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
                throw new Exception($"Unable to load required framework: '{requiredFrameworkAttribute.Name}'", new Exception(Dlfcn.dlerror()));
        }
        if (assemblies == null)
        {
            assemblies = new List<Assembly>();
            Class.Register(typeof(NSObject));
        }

        assemblies.Add(a);

        Type[] types = a.GetTypes();
        foreach (Type type in types)
        {
            if (type.IsSubclassOf(typeof(NSObject)) && !Attribute.IsDefined(type, typeof(ModelAttribute), inherit: false))
                Class.Register(type);
        }
    }

    internal static List<Assembly> GetAssemblies()
    {
        if (assemblies == null)
        {
            AssemblyName name = typeof(Runtime).Assembly.GetName();
            assemblies = new List<Assembly>();
            Assembly[] array = AppDomain.CurrentDomain.GetAssemblies();
            foreach (Assembly assembly in array)
            {
                if (assembly.GetName() != name)
                {
                    assemblies.Add(assembly);
                }
            }
        }
        return assemblies;
    }

    internal static void UnregisterNSObject(IntPtr ptr)
    {
        lock (lock_obj)
        {
            object_map.Remove(ptr);
        }
    }

    internal static void RegisterNSObject(NSObject obj, IntPtr ptr)
    {
        lock (lock_obj)
        {
            object_map[ptr] = new WeakReference(obj);
            obj.Handle = ptr;
        }
    }

    internal static void NativeObjectHasDied(IntPtr ptr)
    {
        lock (lock_obj)
        {
            if (object_map.TryGetValue(ptr, out var value))
            {
                object_map.Remove(ptr);
                ((NSObject)value.Target)?.ClearHandle();
            }
        }
    }

    public static NSObject TryGetNSObject(IntPtr ptr)
    {
        lock (lock_obj)
        {
            if (object_map.TryGetValue(ptr, out var value))
            {
                return (NSObject)value.Target;
            }
        }
        return null;
    }

    public static NSObject GetNSObject(IntPtr ptr)
    {
        if (ptr == IntPtr.Zero)
        {
            return null;
        }
        lock (lock_obj)
        {
            if (object_map.TryGetValue(ptr, out var value))
            {
                NSObject nSObject = (NSObject)value.Target;
                if (nSObject != null)
                    return nSObject;
            }
        }
        Type type = Class.Lookup(Messaging.intptr_objc_msgSend(ptr, selClass));
        if (type != null)
        {

            var intPtrConstructor = GetIntPtrConstructor(type);
            if (intPtrConstructor is null)
            {
                MissingCtor(ptr, IntPtr.Zero, type, MissingCtorResolution.ThrowConstructor1NotFound);
                return null;
            }

            object[] array = new object[1];
            if (intPtrConstructor.GetParameters()[0].ParameterType == typeof(IntPtr))
                array[0] = ptr;
            else
                array[0] = new NativeHandle(ptr);

            return (NSObject)intPtrConstructor.Invoke(array);
        }
        return new NSObject(ptr);
    }

    public static void ConnectMethod(MethodInfo method, Selector selector)
    {
        if (method == null)
            throw new ArgumentNullException("method");

        if (selector == null)
            throw new ArgumentNullException("selector");

        Type declaringType = method.DeclaringType;
        if (!Class.IsCustomType(declaringType))
            throw new ArgumentException("Cannot late bind methods on core types");

        ExportAttribute ea = new ExportAttribute(selector.Name);
        Class @class = new Class(declaringType);
        Class.RegisterMethod(method, ea, declaringType, @class.Handle);
    }

    #region

    internal static MethodInfo FindClosedMethod(Type closed_type, MethodBase open_method)
    {
        if (!open_method.ContainsGenericParameters)
            return (MethodInfo)open_method;
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
                return methodInfo;
        }
        throw ErrorHelper.CreateError(8003, "Failed to find the closed generic method '{0}' on the type '{1}'.", open_method.Name, closed_type.FullName);
    }

    public static T TryGetNSObjectTx<T>(IntPtr ptr) where T : NSObject
    {
        lock (lock_obj)
        {
            if (object_map.TryGetValue(ptr, out var value))
            {
                return value.Target as T;
            }
        }
        return null;
    }

    public static T? GetNSObjectTx<T>(IntPtr ptr) where T : NSObject
    {
        if (ptr == IntPtr.Zero)
            return null;

        lock (lock_obj)
        {
            if (object_map.TryGetValue(ptr, out var value))
            {
                NSObject nSObject = (NSObject)value.Target;
                if (nSObject != null)
                    return nSObject as T;
            }
        }
        Type type = Class.Lookup(Messaging.intptr_objc_msgSend(ptr, selClass));
        if (type != null)
        {
            var intPtrConstructor = GetIntPtrConstructor(type);
            if (intPtrConstructor is null)
            {
                MissingCtor(ptr, IntPtr.Zero, type, MissingCtorResolution.ThrowConstructor1NotFound);
                return null;
            }

            object[] array = new object[1];
            if (intPtrConstructor.GetParameters()[0].ParameterType == typeof(IntPtr))
            {
                array[0] = ptr;
            }
            else
            {
                array[0] = new NativeHandle(ptr);
            }
            return (T)intPtrConstructor.Invoke(array);
        }
        return new NSObject(ptr) as T;
    }

    public static T GetNativeObject<T>(IntPtr ptr) where T : class, INativeObject
    {
        if (ptr == IntPtr.Zero)
            return default;

        lock (lock_obj)
        {
            if (object_map.TryGetValue(ptr, out var value))
            {
                var nSObject = value.Target;
                if (nSObject != null)
                    return nSObject as T;
            }
        }

        Type type = Class.Lookup(Messaging.intptr_objc_msgSend(ptr, selClass));
        if (type != null)
        {
            var intPtrConstructor = GetIntPtrConstructor(type);
            if (intPtrConstructor is null)
            {
                MissingCtor(ptr, IntPtr.Zero, type, MissingCtorResolution.ThrowConstructor1NotFound);
                return null;
            }

            object[] array = new object[1];
            if (intPtrConstructor.GetParameters()[0].ParameterType == typeof(IntPtr))
            {
                array[0] = ptr;
            }
            else
            {
                array[0] = new NativeHandle(ptr);
            }
            return (T)intPtrConstructor.Invoke(array);
        }

        return new NSObject(ptr) as T;
    }

    private static ConstructorInfo? GetIntPtrConstructor(Type type)
    {
        lock (intptr_ctor_cache)
        {
            if (intptr_ctor_cache.TryGetValue(type, out ConstructorInfo value))
                return value;
        }

        ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        ConstructorInfo constructorInfo = null;
        for (int i = 0; i < constructors.Length; i++)
        {
            ParameterInfo[] parameters = constructors[i].GetParameters();
            if (parameters.Length != 1)
                continue;
            if (parameters[0].ParameterType == typeof(IntPtr))
                constructorInfo = constructors[i];
            else if (!(parameters[0].ParameterType != typeof(NativeHandle)))
            {
                lock (intptr_ctor_cache)
                    intptr_ctor_cache[type] = constructors[i];

                return constructors[i];
            }
        }
        if (constructorInfo != null)
        {
            string fullName = typeof(IntPtr).FullName;
            string fullName2 = typeof(NativeHandle).FullName;
            LogHelper.NSLog($"The type {type.FullName} does not have a constructor that takes {"an ObjCRuntime.NativeHandle parameter"} but a constructor that takes {"an System.IntPtr parameter"} was found (and will be used instead). It's highly recommended to change the signature of the {fullName} constructor to be {fullName2}.");
            lock (intptr_ctor_cache)
            {
                intptr_ctor_cache[type] = constructorInfo;
                return constructorInfo;
            }
        }
        return null;
    }


    #endregion
}

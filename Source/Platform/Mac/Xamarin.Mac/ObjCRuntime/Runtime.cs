using Foundation;
using System.Reflection;
using System.Runtime.InteropServices;
using Xamarin.Utiles;

namespace ObjCRuntime;

public static class Runtime
{
    private static List<Assembly> assemblies;

    private static Dictionary<IntPtr, WeakReference> object_map;

    private static object lock_obj;

    private static IntPtr selClass;

    public static string FrameworksPath { get; set; }

    public static string ResourcesPath { get; set; }

    static Runtime()
    {
        object_map = new Dictionary<IntPtr, WeakReference>();
        lock_obj = new object();
        selClass = Selector.GetHandle("class");
        string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        if (!string.IsNullOrEmpty(baseDirectory))
        {
            baseDirectory = Path.Combine(baseDirectory, "..");
        }
        else
        {
            baseDirectory = Assembly.GetExecutingAssembly().Location;
            if (string.IsNullOrEmpty(baseDirectory))
            {
                throw new InvalidOperationException("Cannot get base path of current app domain");
            }
            baseDirectory = Path.Combine(Path.GetDirectoryName(baseDirectory), "..");
        }
        ResourcesPath = Path.Combine(baseDirectory, "Resources");
        FrameworksPath = Path.Combine(baseDirectory, "Frameworks");
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
            {
                throw new Exception($"Unable to load required framework: '{requiredFrameworkAttribute.Name}'", new Exception(Dlfcn.dlerror()));
            }
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
            {
                Class.Register(type);
            }
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
                {
                    return nSObject;
                }
            }
        }
        Type type = Class.Lookup(Messaging.intptr_objc_msgSend(ptr, selClass));
        if (type != null)
        {
            return (NSObject)Activator.CreateInstance(type, ptr);
        }
        return new NSObject(ptr);
    }

    public static void ConnectMethod(MethodInfo method, Selector selector)
    {
        if (method == null)
        {
            throw new ArgumentNullException("method");
        }
        if (selector == null)
        {
            throw new ArgumentNullException("selector");
        }
        Type declaringType = method.DeclaringType;
        if (!Class.IsCustomType(declaringType))
        {
            throw new ArgumentException("Cannot late bind methods on core types");
        }
        ExportAttribute ea = new ExportAttribute(selector.Name);
        Class @class = new Class(declaringType);
        Class.RegisterMethod(method, ea, declaringType, @class.Handle);
    }

    #region

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

    public static T GetNSObjectTx<T>(IntPtr ptr) where T : NSObject
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
            return Activator.CreateInstance(type, ptr) as T;
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
            return Activator.CreateInstance(type, ptr) as T;

        return new NSObject(ptr) as T;
    }

    internal static IntPtr AllocGCHandle(object? value, GCHandleType type = GCHandleType.Normal)
    {
        return GCHandle.ToIntPtr(GCHandle.Alloc(value, type));
    }

    #endregion
}

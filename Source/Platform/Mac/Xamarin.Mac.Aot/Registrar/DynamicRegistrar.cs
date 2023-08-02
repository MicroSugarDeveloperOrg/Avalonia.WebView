using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using Xamarin.Utiles;

namespace Registrar;

internal class DynamicRegistrar : Registrar
{
    private Dictionary<IntPtr, ObjCType> type_map;

    private Dictionary<string, object> registered_assemblies;

    private Dictionary<Type, object> custom_type_map;

    protected object lock_obj = new object();

    protected override bool IsSimulatorOrDesktop => true;

    protected override bool Is64Bits => IntPtr.Size == 8;

    protected override bool IsARM64 => RuntimeEx.IsARM64CallingConvention;

    protected override string PlatformName => "Mac"; 

    public DynamicRegistrar()
    {
        type_map = new Dictionary<IntPtr, ObjCType>(RuntimeEx.IntPtrEqualityComparer);
        custom_type_map = new Dictionary<Type, object>(RuntimeEx.TypeEqualityComparer);
    }

    protected override bool SkipRegisterAssembly(Assembly assembly)
    {
        if (registered_assemblies != null)
        {
            return registered_assemblies.ContainsKey(GetAssemblyName(assembly));
        }
        return false;
    }

    public void SetAssemblyRegistered(string assembly)
    {
        if (registered_assemblies == null)
        {
            registered_assemblies = new Dictionary<string, object>();
        }
        registered_assemblies.Add(assembly, null);
    }

    protected override bool ContainsPlatformReference(Assembly assembly)
    {
        if (assembly.GetName().Name == AssemblyName)
        {
            return true;
        }
        AssemblyName[] referencedAssemblies = assembly.GetReferencedAssemblies();
        for (int i = 0; i < referencedAssemblies.Length; i++)
        {
            if (referencedAssemblies[i].Name == AssemblyName)
            {
                return true;
            }
        }
        return false;
    }

    public bool IsCustomType(Type type)
    {
        lock (custom_type_map)
        {
            return custom_type_map.ContainsKey(type);
        }
    }

    public void RegisterMethod(Type type, MethodInfo minfo, ExportAttribute ea)
    {
        if (!IsNSObject(type))
        {
            throw new ArgumentException($"Cannot register methods on '{type.FullName}'; it does not inherit from NSObject.");
        }
        if (!minfo.IsStatic && type != minfo.DeclaringType)
        {
            throw new ArgumentException(string.Format("Cannot register the instance method '{0}' on the type '{1}'. The type to connect to ('{2}') must match the method's type ('{1}').", minfo.Name, type.FullName, minfo.DeclaringType.FullName));
        }
        List<Exception> exceptions = null;
        ObjCType objCType = RegisterType(type, ref exceptions);
        ObjCMethod objCMethod = new ObjCMethod(this, objCType, minfo);
        if (objCMethod.SetExportAttribute(ea, ref exceptions) && exceptions == null)
        {
            objCType.Add(objCMethod, ref exceptions);
            if (exceptions == null)
            {
                RegisterMethod(objCMethod);
            }
        }
        if (exceptions != null)
        {
            throw (exceptions.Count == 1) ? exceptions[0] : new AggregateException(exceptions);
        }
    }

    protected override IEnumerable<MethodBase> FindMethods(Type type, string name)
    {
        MethodInfo[] methods = type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
        foreach (MethodInfo methodInfo in methods)
        {
            if (methodInfo.Name == name)
            {
                yield return methodInfo;
            }
        }
    }

    protected override PropertyInfo FindProperty(Type type, string name)
    {
        return type.GetProperty(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
    }

    public override Type FindType(Type relative, string @namespace, string name)
    {
        Type[] array = relative.Assembly.GetTypes();
        foreach (Type type in array)
        {
            if (type.Namespace == @namespace && type.Name == name)
            {
                return type;
            }
        }
        return null;
    }

    protected override int GetValueTypeSize(Type type)
    {
        return Marshal.SizeOf(type);
    }

    protected override IEnumerable<MethodBase> CollectConstructors(Type type)
    {
        return type.GetConstructors(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
    }

    protected override IEnumerable<MethodBase> CollectMethods(Type type)
    {
        return type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
    }

    protected override IEnumerable<PropertyInfo> CollectProperties(Type type)
    {
        return type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
    }

    protected override IEnumerable<Type> CollectTypes(Assembly assembly)
    {
        return assembly.GetTypes();
    }

    protected override BindAsAttribute GetBindAsAttribute(PropertyInfo property)
    {
        return property?.GetCustomAttribute<BindAsAttribute>(inherit: false);
    }

    protected override BindAsAttribute GetBindAsAttribute(MethodBase method, int parameter_index)
    {
        if (method == null)
        {
            return null;
        }
        MethodInfo methodInfo = method as MethodInfo;
        ICustomAttributeProvider provider;
        if (methodInfo != null)
        {
            methodInfo = methodInfo.GetBaseDefinition();
            provider = ((parameter_index != -1) ? methodInfo.GetParameters()[parameter_index] : methodInfo.ReturnTypeCustomAttributes);
        }
        else
        {
            ConstructorInfo constructorInfo = method as ConstructorInfo;
            if (parameter_index == -1)
            {
                throw ErrorHelper.CreateError(99, "Internal error: can't get the BindAs attribute for the return value of a constructor (" + GetDescriptiveMethodName(method) + "). Please file a bug report with a test case (https://github.com/xamarin/xamarin-macios/issues/new).");
            }
            provider = constructorInfo.GetParameters()[parameter_index];
        }
        return SharedDynamic.GetOneAttribute<BindAsAttribute>(provider);
    }

    public override Type GetNullableType(Type type)
    {
        if (!type.IsGenericType)
        {
            return null;
        }
        if (type.GetGenericTypeDefinition() != typeof(Nullable<>))
        {
            return null;
        }
        return type.GetGenericArguments()[0];
    }

    protected override ConnectAttribute GetConnectAttribute(PropertyInfo property)
    {
        return SharedDynamic.GetOneAttribute<ConnectAttribute>(property);
    }

    protected override ExportAttribute GetExportAttribute(MethodBase method)
    {
        MethodInfo methodInfo = method as MethodInfo;
        if (methodInfo != null)
        {
            return SharedDynamic.GetOneAttribute<ExportAttribute>(methodInfo.GetBaseDefinition());
        }
        ConstructorInfo constructorInfo = method as ConstructorInfo;
        if (constructorInfo != null)
        {
            return SharedDynamic.GetOneAttribute<ExportAttribute>(constructorInfo);
        }
        return null;
    }

    protected override Dictionary<MethodBase, List<MethodBase>> PrepareMethodMapping(Type type)
    {
        return SharedDynamic.PrepareInterfaceMethodMapping(type);
    }

    protected override ExportAttribute GetExportAttribute(PropertyInfo property)
    {
        return SharedDynamic.GetOneAttribute<ExportAttribute>(GetBasePropertyInTypeHierarchy(property) ?? property);
    }

    public override RegisterAttribute GetRegisterAttribute(Type type)
    {
        return SharedDynamic.GetOneAttribute<RegisterAttribute>(type);
    }

    public override ProtocolAttribute GetProtocolAttribute(Type type)
    {
        return SharedDynamic.GetOneAttribute<ProtocolAttribute>(type);
    }

    protected override IEnumerable<ProtocolMemberAttribute> GetProtocolMemberAttributes(Type type)
    {
        object[] customAttributes = type.GetCustomAttributes(inherit: false);
        for (int i = 0; i < customAttributes.Length; i++)
        {
            if (customAttributes[i] is ProtocolMemberAttribute protocolMemberAttribute)
            {
                yield return protocolMemberAttribute;
            }
        }
    }

    protected override Version GetSDKVersion()
    {
        throw new NotImplementedException();
    }

    protected override Type GetSystemVoidType()
    {
        return typeof(void);
    }

    protected override Type MakeByRef(Type type)
    {
        return type.MakeByRefType();
    }

    protected override CategoryAttribute GetCategoryAttribute(Type type)
    {
        return SharedDynamic.GetOneAttribute<CategoryAttribute>(type);
    }

    protected override Type GetProtocolAttributeWrapperType(Type type)
    {
        return SharedDynamic.GetOneAttribute<ProtocolAttribute>(type)?.WrapperType;
    }

    protected override IList<AdoptsAttribute> GetAdoptsAttributes(Type type)
    {
        return (AdoptsAttribute[])type.GetCustomAttributes(typeof(AdoptsAttribute), inherit: false);
    }

    protected override string GetAssemblyName(Assembly assembly)
    {
        return assembly.GetName().Name;
    }

    protected override Type GetBaseType(Type type)
    {
        return type.BaseType;
    }

    protected override MethodBase GetBaseMethod(MethodBase method)
    {
        return ((MethodInfo)method).GetBaseDefinition();
    }

    protected override Type GetElementType(Type type)
    {
        return type.GetElementType();
    }

    protected override Type GetEnumUnderlyingType(Type type)
    {
        return Enum.GetUnderlyingType(type);
    }

    protected override string GetFieldName(FieldInfo field)
    {
        return field.Name;
    }

    protected override IEnumerable<FieldInfo> GetFields(Type type)
    {
        return type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
    }

    protected override Type GetFieldType(FieldInfo field)
    {
        return field.FieldType;
    }

    protected override MethodBase GetGetMethod(PropertyInfo property)
    {
        return property.GetGetMethod(nonPublic: true);
    }

    protected override MethodBase GetSetMethod(PropertyInfo property)
    {
        return property.GetSetMethod(nonPublic: true);
    }

    protected override string GetMethodName(MethodBase method)
    {
        return method.Name;
    }

    protected override void GetNamespaceAndName(Type type, out string @namespace, out string name)
    {
        @namespace = type.Namespace;
        name = type.Name;
    }

    protected override Type[] GetParameters(MethodBase method)
    {
        ParameterInfo[] parameters = method.GetParameters();
        Type[] array = new Type[parameters.Length];
        for (int i = 0; i < parameters.Length; i++)
        {
            array[i] = parameters[i].ParameterType;
        }
        return array;
    }

    protected override string GetParameterName(MethodBase method, int parameter_index)
    {
        return method.GetParameters()[parameter_index].Name;
    }

    protected override string GetPropertyName(PropertyInfo property)
    {
        return property.Name;
    }

    protected override Type GetPropertyType(PropertyInfo property)
    {
        return property.PropertyType;
    }

    protected override Type GetReturnType(MethodBase method)
    {
        MethodInfo methodInfo = method as MethodInfo;
        if (methodInfo != null)
        {
            return methodInfo.ReturnType;
        }
        throw ErrorHelper.CreateError(0, "Cannot get the return type of a {0}", method.GetType().Name);
    }

    protected override string GetTypeFullName(Type type)
    {
        return type.FullName;
    }

    protected override bool VerifyIsConstrainedToNSObject(Type type, out Type constrained_type)
    {
        constrained_type = null;
        if (!type.IsGenericType && (!type.IsGenericType || type.ContainsGenericParameters) && !type.IsGenericParameter && !type.IsGenericTypeDefinition)
        {
            return true;
        }
        if (type.IsGenericParameter)
        {
            if (typeof(NSObject).IsAssignableFrom(type))
            {
                Type[] genericParameterConstraints = type.GetGenericParameterConstraints();
                foreach (Type type2 in genericParameterConstraints)
                {
                    if (type2.IsSubclassOf(typeof(NSObject)))
                    {
                        constrained_type = type2;
                        return true;
                    }
                }
                constrained_type = typeof(NSObject);
                return true;
            }
            return false;
        }
        if (type.IsGenericTypeDefinition)
        {
            bool flag = true;
            Type[] genericArguments = type.GetGenericArguments();
            Type[] array = new Type[genericArguments.Length];
            for (int j = 0; j < genericArguments.Length; j++)
            {
                flag &= VerifyIsConstrainedToNSObject(genericArguments[j], out var constrained_type2);
                array[j] = constrained_type2;
            }
            constrained_type = type.MakeGenericType(array);
            return flag;
        }
        return true;
    }

    protected override Exception CreateExceptionImpl(int code, bool error, Exception innerException, MethodBase method, string message, params object[] args)
    {
        if (error)
        {
            return ErrorHelper.CreateError(code, innerException, message, args);
        }
        return ErrorHelper.CreateWarning(code, innerException, message, args);
    }

    protected override Exception CreateExceptionImpl(int code, bool error, Exception innerException, Type type, string message, params object[] args)
    {
        if (error)
        {
            return ErrorHelper.CreateError(code, innerException, message, args);
        }
        return ErrorHelper.CreateWarning(code, innerException, message, args);
    }

    protected override string GetAssemblyQualifiedName(Type type)
    {
        return type.AssemblyQualifiedName;
    }

    protected override bool HasReleaseAttribute(MethodBase method)
    {
        MethodInfo methodInfo = method as MethodInfo;
        if (methodInfo == null)
        {
            return false;
        }
        return methodInfo.ReturnTypeCustomAttributes.IsDefined(typeof(ReleaseAttribute), inherit: false);
    }

    public static bool HasThisAttributeImpl(MethodBase method)
    {
        MethodInfo methodInfo = method as MethodInfo;
        if (methodInfo == null)
        {
            return false;
        }
        return methodInfo.IsDefined(typeof(ExtensionAttribute), inherit: false);
    }

    protected override bool HasThisAttribute(MethodBase method)
    {
        return HasThisAttributeImpl(method);
    }

    protected override string GetTypeName(Type type)
    {
        return type.Name;
    }

    protected override bool HasModelAttribute(Type type)
    {
        return type.IsDefined(typeof(ModelAttribute), inherit: false);
    }

    protected override bool IsArray(Type type, out int rank)
    {
        if (!type.IsArray)
        {
            rank = 0;
            return false;
        }
        rank = type.GetArrayRank();
        return true;
    }

    protected override bool IsByRef(Type type)
    {
        return type.IsByRef;
    }

    protected override bool IsConstructor(MethodBase method)
    {
        return method is ConstructorInfo;
    }

    protected override bool IsGenericType(Type type)
    {
        if (!type.IsGenericType && !type.IsGenericTypeDefinition)
        {
            return type.IsGenericParameter;
        }
        return true;
    }

    protected override bool IsGenericMethod(MethodBase method)
    {
        if (!method.IsGenericMethod)
        {
            return method.IsGenericMethodDefinition;
        }
        return true;
    }

    protected override Type GetGenericTypeDefinition(Type type)
    {
        return type.GetGenericTypeDefinition();
    }

    protected override bool IsDelegate(Type type)
    {
        return type.IsSubclassOf(typeof(Delegate));
    }

    protected override bool IsNullable(Type type)
    {
        if (!type.IsGenericType)
        {
            return false;
        }
        return type.GetGenericTypeDefinition() == typeof(Nullable<>);
    }

    protected override bool IsEnum(Type type, out bool isNativeEnum)
    {
        isNativeEnum = false;
        if (type.IsEnum)
        {
            isNativeEnum = type.IsDefined(typeof(NativeAttribute), inherit: false);
        }
        return type.IsEnum;
    }

    protected override bool IsInterface(Type type)
    {
        return type.IsInterface;
    }

    protected override bool IsAbstract(Type type)
    {
        return type.IsAbstract;
    }

    protected override bool IsINativeObject(Type type)
    {
        return typeof(INativeObject).IsAssignableFrom(type);
    }

    protected override bool IsNSObject(Type type)
    {
        if (!(type == typeof(NSObject)))
        {
            return type.IsSubclassOf(typeof(NSObject));
        }
        return true;
    }

    protected override bool IsStatic(FieldInfo field)
    {
        return field.IsStatic;
    }

    protected override bool IsStatic(MethodBase method)
    {
        return method.IsStatic;
    }

    protected override bool IsStatic(PropertyInfo property)
    {
        return IsStaticProperty(property);
    }

    protected override bool IsValueType(Type type)
    {
        return type.IsValueType;
    }

    protected override bool IsVirtual(MethodBase method)
    {
        return method.IsVirtual;
    }

    protected override Type[] GetInterfaces(Type type)
    {
        return type.GetInterfaces();
    }

    protected override bool TryGetAttribute(Type type, string attributeNamespace, string attributeType, out object attribute)
    {
        object[] customAttributes = type.GetCustomAttributes(inherit: false);
        attribute = null;
        if (customAttributes.Length == 0)
        {
            return false;
        }
        object[] array = customAttributes;
        foreach (object obj in array)
        {
            Type type2 = obj.GetType();
            if (type2.Namespace == attributeNamespace && type2.Name == attributeType)
            {
                if (attribute != null)
                {
                    throw new AmbiguousMatchException($"The type '{type.FullName}' contains more than one '{attributeNamespace}.{attributeType}'");
                }
                attribute = obj;
            }
        }
        return attribute != null;
    }

    protected override void ReportError(int code, string message, params object[] args)
    {
        LogHelper.NSLog(string.Format(message, args));
    }

    private Class.objc_attribute_prop[] GetPropertyAttributes(ObjCProperty property, out int count, bool isProtocol)
    {
        Class.objc_attribute_prop[] array = new Class.objc_attribute_prop[5];
        count = 0;
        array[count++] = new Class.objc_attribute_prop
        {
            name = "T",
            value = ToSignature(property.PropertyType, property, forProperty: true)
        };
        switch (property.ArgumentSemantic)
        {
            case ArgumentSemantic.Copy:
                array[count++] = new Class.objc_attribute_prop
                {
                    name = "C",
                    value = ""
                };
                break;
            case ArgumentSemantic.Retain:
                array[count++] = new Class.objc_attribute_prop
                {
                    name = "&",
                    value = ""
                };
                break;
        }
        if (!isProtocol)
        {
            array[count++] = new Class.objc_attribute_prop
            {
                name = "V",
                value = property.Selector
            };
        }
        if (property.IsReadOnly)
        {
            array[count++] = new Class.objc_attribute_prop
            {
                name = "R",
                value = string.Empty
            };
        }
        array[count++] = new Class.objc_attribute_prop
        {
            name = "N",
            value = string.Empty
        };
        return array;
    }

    protected override void OnRegisterProtocol(ObjCType type)
    {
        IntPtr intPtr = Protocol.objc_getProtocol(type.ProtocolName);
        if (intPtr != IntPtr.Zero)
        {
            type.Handle = intPtr;
            if (!type_map.ContainsKey(intPtr))
            {
                type_map[intPtr] = type;
            }
            return;
        }
        intPtr = Protocol.objc_allocateProtocol(type.ProtocolName);
        if (type.Protocols != null)
        {
            ObjCType[] protocols = type.Protocols;
            foreach (ObjCType objCType in protocols)
            {
                if (objCType.ProtocolName == "JSExport")
                {
                    ErrorHelper.Show(ErrorHelper.CreateWarning(4147, "Detected a protocol ({0}) inheriting from the JSExport protocol while using the dynamic registrar. It is not possible to export protocols to JavaScriptCore dynamically; the static registrar must be used (add '--registrar:static' to the additional mtouch arguments in the project's iOS Build options to select the static registrar).", GetTypeFullName(type.Type)));
                }
                Protocol.protocol_addProtocol(intPtr, objCType.Handle);
            }
        }
        if (type.Properties != null)
        {
            foreach (ObjCProperty property in type.Properties)
            {
                int count;
                Class.objc_attribute_prop[] propertyAttributes = GetPropertyAttributes(property, out count, isProtocol: true);
                Protocol.protocol_addProperty(intPtr, property.Selector, propertyAttributes, count, !property.IsOptional, !property.IsStatic);
                string text = ToSignature(property.PropertyType, property);
                Protocol.protocol_addMethodDescription(intPtr, Selector.GetHandle(property.GetterSelector), text + "@:", !property.IsOptional, !property.IsStatic);
                if (!property.IsReadOnly)
                {
                    Protocol.protocol_addMethodDescription(intPtr, Selector.GetHandle(property.SetterSelector), "v@:" + text, !property.IsOptional, !property.IsStatic);
                }
            }
        }
        if (type.Methods != null)
        {
            foreach (ObjCMethod method in type.Methods)
            {
                Protocol.protocol_addMethodDescription(intPtr, Selector.GetHandle(method.Selector), method.Signature, !method.IsOptional, !method.IsStatic);
            }
        }
        Protocol.objc_registerProtocol(intPtr);
        type_map[intPtr] = type;
    }

    protected override void OnRegisterCategory(ObjCType type, ref List<Exception> exceptions)
    {
        if (type.Methods == null)
        {
            return;
        }
        foreach (ObjCMethod method in type.Methods)
        {
            if (!RegisterMethod(method))
            {
                Registrar.AddException(ref exceptions, ErrorHelper.CreateError(4155, "Cannot register the method '{0}.{1}' with the selector '{2}' as a category method on '{3}' because Objective-C already has an implementation for this selector.", GetTypeFullName(type.Type), method.MethodName, method.Selector, type.ExportedName));
            }
        }
    }

    protected override void OnReloadType(ObjCType type)
    {
        if (type.Handle == IntPtr.Zero)
        {
            type.Handle = Class.GetHandle(type.ExportedName);
        }
    }

    protected override void OnRegisterType(ObjCType type)
    {
        type.Handle = Class.GetHandle(type.ExportedName);
        if (type.Handle != IntPtr.Zero)
        {
            if (!type_map.ContainsKey(type.Handle))
            {
                type_map[type.Handle] = type;
            }
        }
        else
        {
            if ((type.IsWrapper && !type.IsModel) || type.IsFakeProtocol)
            {
                return;
            }
            ObjCType superType = type.SuperType;
            type.Handle = Class.objc_allocateClassPair(superType.Handle, type.ExportedName, IntPtr.Zero);
            if (type.Properties != null)
            {
                foreach (ObjCProperty property in type.Properties)
                {
                    int count;
                    Class.objc_attribute_prop[] propertyAttributes = GetPropertyAttributes(property, out count, isProtocol: false);
                    Class.class_addProperty(type.Handle, property.Selector, propertyAttributes, count);
                }
            }
            if (type.Fields != null)
            {
                foreach (ObjCField value in type.Fields.Values)
                {
                    Class.class_addIvar(type.Handle, value.Name, new IntPtr(value.Size), value.Alignment, value.FieldType);
                }
            }
            if (type.Methods != null)
            {
                foreach (ObjCMethod method in type.Methods)
                {
                    RegisterMethod(method);
                }
            }
            if (type.Protocols != null)
            {
                ObjCType[] protocols = type.Protocols;
                foreach (ObjCType objCType in protocols)
                {
                    Class.class_addProtocol(type.Handle, objCType.Handle);
                }
            }
            Class.objc_registerClassPair(type.Handle);
            type_map[type.Handle] = type;
            AddCustomType(type.Type);
        }
    }

    public void AddCustomType(Type type)
    {
        lock (custom_type_map)
        {
            custom_type_map[type] = null;
        }
    }

    public void GetMethodDescriptionAndObject(Type type, IntPtr selector, bool is_static, IntPtr obj, ref IntPtr mthis, IntPtr desc)
    {
        string name = Selector.GetName(selector);
        ObjCMethod methodNoThrow = GetMethodNoThrow(type, type, name, is_static);
        if (methodNoThrow == null)
        {
            throw ErrorHelper.CreateError(8006, "Failed to find the selector '{0}' on the type '{1}'", name, type.FullName);
        }
        if (methodNoThrow.IsInstanceCategory)
        {
            mthis = IntPtr.Zero;
        }
        else
        {
            try
            {
                NSObject nSObject = Runtime.GetNSObject(obj);
                //NSObject nSObject = Runtime.GetNSObject(obj, RuntimeEx.MissingCtorResolution.ThrowConstructor1NotFound, evenInFinalizerQueue: true);
                mthis = RuntimeEx.AllocGCHandle(nSObject);
                if (methodNoThrow.Method.ContainsGenericParameters)
                {
                    methodNoThrow.WriteUnmanagedDescription(desc, Runtime.FindClosedMethod(nSObject.GetType(), methodNoThrow.Method));
                    return;
                }
            }
            catch (Exception innerException)
            {
                throw ErrorHelper.CreateError(8035, innerException, "Failed to get the 'this' instance in a method call to " + methodNoThrow.DescriptiveMethodName + ".");
            }
        }
        methodNoThrow.WriteUnmanagedDescription(desc);
    }

    public void GetMethodDescription(Type type, IntPtr selector, bool is_static, IntPtr desc)
    {
        string name = Selector.GetName(selector);
        ObjCMethod methodNoThrow = GetMethodNoThrow(type, type, name, is_static);
        if (methodNoThrow == null)
        {
            throw ErrorHelper.CreateError(8006, "Failed to find the selector '{0}' on the type '{1}'", name, type.FullName);
        }
        if (type.IsGenericType && methodNoThrow.Method is ConstructorInfo)
        {
            throw ErrorHelper.CreateError(4133, "Cannot construct an instance of the type '{0}' from Objective-C because the type is generic.", type.FullName);
        }
        methodNoThrow.WriteUnmanagedDescription(desc);
    }

    private ObjCMethod GetMethodNoThrow(Type original_type, Type type, string selector, bool is_static)
    {
        ObjCType objCType = RegisterType(type);
        if (objCType == null)
        {
            throw ErrorHelper.CreateError(4142, "Failed to register the type '{0}'", type.FullName);
        }
        ObjCMember member = null;
        if (type.BaseType != typeof(object) && !objCType.TryGetMember(selector, is_static, out member))
        {
            return GetMethodNoThrow(original_type, type.BaseType, selector, is_static);
        }
        if (!(member is ObjCMethod result))
        {
            throw ErrorHelper.CreateError(8007, "Cannot get the method descriptor for the selector '{0}' on the type '{1}', because the selector does not correspond to a method", selector, original_type.FullName);
        }
        return result;
    }

    public Type Lookup(IntPtr @class, bool throw_on_error)
    {
        IntPtr cls = @class;
        bool lockTaken = false;
        try
        {
            LockRegistrar(ref lockTaken);
            do
            {
                if (type_map.TryGetValue(@class, out var value))
                {
                    return value.Type;
                }
                bool is_custom_type;
                Type type = Class.FindType(@class, out is_custom_type);
                if (type != null)
                {
                    value = RegisterType(type);
                    if (is_custom_type)
                    {
                        AddCustomType(type);
                    }
                    return type;
                }
                @class = Class.class_getSuperclass(@class);
            }
            while (@class != IntPtr.Zero);
        }
        finally
        {
            if (lockTaken)
            {
                UnlockRegistrar();
            }
        }
        if (throw_on_error)
        {
            throw ErrorHelper.CreateError(4143, "The ObjectiveC class '{0}' could not be registered, it does not seem to derive from any known ObjectiveC class (including NSObject).", Marshal.PtrToStringAuto(Class.class_getName(cls)));
        }
        return null;
    }

    private bool RegisterMethod(ObjCMethod method)
    {
        IntPtr cls = ((method.IsStatic && !method.IsCategoryInstance) ? Class.object_getClass(method.DeclaringType.Handle) : method.DeclaringType.Handle);
        return Class.class_addMethod(imp: method.Trampoline switch
        {
            Trampoline.Constructor => () => { },
            //Trampoline.Constructor => Method.ConstructorTrampoline,
            //Trampoline.Double => Method.DoubleTrampoline,
            //Trampoline.Long => Method.LongTrampoline,
            //Trampoline.Normal => Method.Trampoline,
            //Trampoline.Release => Method.ReleaseTrampoline,
            //Trampoline.Retain => Method.RetainTrampoline,
            //Trampoline.Single => Method.SingleTrampoline,
            //Trampoline.Static => Method.StaticTrampoline,
            //Trampoline.StaticDouble => Method.StaticDoubleTrampoline,
            //Trampoline.StaticLong => Method.StaticLongTrampoline,
            //Trampoline.StaticSingle => Method.StaticSingleTrampoline,
            //Trampoline.StaticStret => Method.StaticStretTrampoline,
            //Trampoline.Stret => Method.StretTrampoline,
            //Trampoline.X86_DoubleABI_StaticStretTrampoline => Method.X86_DoubleABI_StaticStretTrampoline,
            //Trampoline.X86_DoubleABI_StretTrampoline => Method.X86_DoubleABI_StretTrampoline,
            //Trampoline.GetGCHandle => Method.GetGCHandleTrampoline,
            //Trampoline.SetGCHandle => Method.SetGCHandleTrampoline,
            //Trampoline.GetFlags => Method.GetFlagsTrampoline,
            //Trampoline.SetFlags => Method.SetFlagsTrampoline,
            _ => throw ErrorHelper.CreateError(4144, "Cannot register the method '{0}.{1}' since it does not have an associated trampoline. Please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new", method.DeclaringType.Type.FullName, method.Name),
        }, cls: cls, name: Selector.GetHandle(method.Selector), types: method.Signature);;
    }

    private static MethodInfo GetPropertyMethod(PropertyInfo property)
    {
        if (property.CanRead)
        {
            return property.GetGetMethod(nonPublic: true);
        }
        return property.GetSetMethod(nonPublic: true);
    }

    private static bool IsStaticProperty(PropertyInfo property)
    {
        return GetPropertyMethod(property).IsStatic;
    }

    private static bool IsVirtualProperty(PropertyInfo property)
    {
        return GetPropertyMethod(property).IsVirtual;
    }

    private static PropertyInfo GetBasePropertyInTypeHierarchy(PropertyInfo property)
    {
        if (IsStaticProperty(property) || !IsVirtualProperty(property))
        {
            return property;
        }
        Type baseType = property.DeclaringType.BaseType;
        while (baseType != null)
        {
            PropertyInfo propertyInfo = TryMatchProperty(baseType, property);
            if (propertyInfo != null)
            {
                return GetBasePropertyInTypeHierarchy(propertyInfo) ?? propertyInfo;
            }
            baseType = baseType.BaseType;
        }
        return null;
    }

    private static PropertyInfo TryMatchProperty(Type type, PropertyInfo property)
    {
        PropertyInfo[] properties = type.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        foreach (PropertyInfo propertyInfo in properties)
        {
            if (PropertyMatch(propertyInfo, property))
            {
                return propertyInfo;
            }
        }
        return null;
    }

    private static bool PropertyMatch(PropertyInfo candidate, PropertyInfo property)
    {
        if (candidate.Name != property.Name)
        {
            return false;
        }
        if (candidate.CanRead)
        {
            if (!property.CanRead)
            {
                return false;
            }
            if (!MethodMatch(candidate.GetGetMethod(nonPublic: true), property.GetGetMethod(nonPublic: true)))
            {
                return false;
            }
        }
        else if (property.CanRead)
        {
            return false;
        }
        if (candidate.CanWrite)
        {
            if (!property.CanWrite)
            {
                return false;
            }
            if (!MethodMatch(candidate.GetSetMethod(nonPublic: true), property.GetSetMethod(nonPublic: true)))
            {
                return false;
            }
        }
        else if (property.CanWrite)
        {
            return false;
        }
        return true;
    }

    private static bool MethodMatch(MethodInfo candidate, MethodInfo method)
    {
        if (!candidate.IsVirtual)
        {
            return false;
        }
        if (candidate.Name != method.Name)
        {
            return false;
        }
        if (!TypeMatch(candidate.ReturnType, method.ReturnType))
        {
            return false;
        }
        ParameterInfo[] parameters = candidate.GetParameters();
        ParameterInfo[] parameters2 = method.GetParameters();
        if (parameters.Length != parameters2.Length)
        {
            return false;
        }
        for (int i = 0; i < parameters.Length; i++)
        {
            if (!TypeMatch(parameters[i].ParameterType, parameters2[i].ParameterType))
            {
                return false;
            }
        }
        return true;
    }

    private static bool TypeMatch(Type a, Type b)
    {
        return a == b;
    }

    public IntPtr Register(Type type)
    {
        List<Exception> exceptions = null;
        ObjCType objCType = RegisterType(type, ref exceptions);
        if (exceptions != null && exceptions.Count > 0)
        {
            throw new AggregateException(exceptions);
        }
        return objCType?.Handle ?? IntPtr.Zero;
    }

    public void Register(Type type, ref List<Exception> exceptions)
    {
        RegisterType(type, ref exceptions);
    }

    public string ComputeSignature(MethodInfo method, bool isBlockSignature)
    {
        return ComputeSignature(method.DeclaringType, method, null, isCategoryInstance: false, isBlockSignature);
    }
}

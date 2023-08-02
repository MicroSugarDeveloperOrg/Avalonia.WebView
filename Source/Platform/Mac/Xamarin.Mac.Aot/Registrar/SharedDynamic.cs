using Foundation;
using System.Reflection;
using Xamarin.Utiles;

namespace Registrar;

internal static class SharedDynamic
{
    public static Dictionary<MethodBase, List<MethodBase>> PrepareInterfaceMethodMapping(Type type)
    {
        Dictionary<MethodBase, List<MethodBase>> dictionary = null;
        Type[] array = type.FindInterfaces(delegate (Type v, object o)
        {
            object[] customAttributes = v.GetCustomAttributes(typeof(ProtocolAttribute), inherit: true);
            return customAttributes != null && customAttributes.Length != 0;
        }, null);
        Type[] array2 = array;
        foreach (Type interfaceType in array2)
        {
            InterfaceMapping interfaceMap = type.GetInterfaceMap(interfaceType);
            for (int j = 0; j < interfaceMap.InterfaceMethods.Length; j++)
            {
                MethodInfo methodInfo = interfaceMap.InterfaceMethods[j];
                MethodInfo key = interfaceMap.TargetMethods[j];
                if (GetOneAttribute<ExportAttribute>(methodInfo) != null)
                {
                    List<MethodBase> value;
                    if (dictionary == null)
                    {
                        dictionary = new Dictionary<MethodBase, List<MethodBase>>();
                        value = (dictionary[key] = new List<MethodBase>());
                    }
                    else if (!dictionary.TryGetValue(key, out value))
                    {
                        value = (dictionary[key] = new List<MethodBase>());
                    }
                    value.Add(methodInfo);
                }
            }
        }
        return dictionary;
    }

    public static T GetOneAttribute<T>(ICustomAttributeProvider provider) where T : Attribute
    {
        object[] customAttributes = provider.GetCustomAttributes(typeof(T), inherit: false);
        if (customAttributes.Length == 0)
        {
            return null;
        }
        if (customAttributes.Length == 1)
        {
            return (T)customAttributes[0];
        }
        MemberInfo memberInfo = provider as MemberInfo;
        if (memberInfo != null)
        {
            throw new AmbiguousMatchException($"The member '{memberInfo.Name}' contains more than one '{typeof(T).FullName}'");
        }
        if (provider is ParameterInfo parameterInfo)
        {
            throw new AmbiguousMatchException($"The parameter '{parameterInfo.Name}' contains more than one '{typeof(T).FullName}'");
        }
        throw new AmbiguousMatchException($"The member '{provider}' contains more than one '{typeof(T).FullName}'");
    }
}

using System.Reflection;
using Xamarin.Utiles;

namespace Registrar;

internal static class Shared
{
    public static List<RuntimeException> GetMT4127(MethodBase impl, List<MethodBase> ifaceMethods)
    {
        List<RuntimeException> list = new List<RuntimeException>();
        list.Add(ErrorHelper.CreateError(4127, "Cannot register more than one interface method for the method '{0}.{1}'.", impl.DeclaringType.FullName, impl.Name));
        for (int i = 0; i < ifaceMethods.Count; i++)
        {
            MethodBase methodBase = ifaceMethods[i];
            list.Add(ErrorHelper.CreateError(4137, "The method '{0}.{1}' is implementing '{2}.{3}'.", impl.DeclaringType.FullName, impl.Name, methodBase.DeclaringType.FullName, methodBase.Name));
        }
        return list;
    }
}

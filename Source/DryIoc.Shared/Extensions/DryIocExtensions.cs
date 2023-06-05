namespace DryIoc.Shared.Extensions;

public static class DryIocExtensions
{
    public static void RegisterSingleton(this IRegistrator regitser, Type type) => regitser.Register(type, type, Reuse.Singleton);
    public static void RegisterSingleton(this IRegistrator regitser, Type from, Type to) => regitser.Register(from, to, Reuse.Singleton);
    public static void RegisterSingleton(this IRegistrator regitser, Type type, string name) => regitser.Register(type, type, Reuse.Singleton, ifAlreadyRegistered: IfAlreadyRegistered.Replace, serviceKey: name);
    public static void RegisterSingleton(this IRegistrator regitser, Type from, Type to, string name) => regitser.Register(from, to, Reuse.Singleton, ifAlreadyRegistered: IfAlreadyRegistered.Replace, serviceKey: name);
    public static void RegisterSingleton(this IRegistrator regitser, Type type, Func<object> factoryMethod) => regitser.RegisterDelegate(type, r => factoryMethod(), Reuse.Singleton);
    public static void RegisterSingleton(this IRegistrator regitser, Type type, Func<IResolver, object> factoryMethod) => regitser.RegisterDelegate(type, factoryMethod, Reuse.Singleton);
    public static void RegisterManySingleton(this IRegistrator regitser, Type type, params Type[] serviceTypes)
    {
        if (serviceTypes.Length == 0)
            serviceTypes = type.GetInterfaces();

        regitser.RegisterMany(serviceTypes, type, Reuse.Singleton);
    }

    public static void RegisterScoped(this IRegistrator regitser, Type type) => regitser.Register(type, type, Reuse.ScopedOrSingleton);
    public static void RegisterScoped(this IRegistrator regitser, Type from, Type to) => regitser.Register(from, to, Reuse.ScopedOrSingleton);
    public static void RegisterScoped(this IRegistrator regitser, Type type, string name) => regitser.Register(type, type, Reuse.ScopedOrSingleton, ifAlreadyRegistered: IfAlreadyRegistered.Replace, serviceKey: name);
    public static void RegisterScoped(this IRegistrator regitser, Type from, Type to, string name) => regitser.Register(from, to, Reuse.ScopedOrSingleton, ifAlreadyRegistered: IfAlreadyRegistered.Replace, serviceKey: name);
    public static void RegisterScoped(this IRegistrator regitser, Type type, Func<object> factoryMethod) => regitser.RegisterDelegate(type, r => factoryMethod(), Reuse.ScopedOrSingleton);
    public static void RegisterScoped(this IRegistrator regitser, Type type, Func<IResolver, object> factoryMethod) => regitser.RegisterDelegate(type, factoryMethod, Reuse.ScopedOrSingleton);
    public static void RegisterManyScoped(this IRegistrator regitser, Type type, params Type[] serviceTypes)
    {
        if (serviceTypes.Length == 0)
            serviceTypes = type.GetInterfaces();

        regitser.RegisterMany(serviceTypes, type, Reuse.ScopedOrSingleton);
    }

    public static void RegisterTransient(this IRegistrator regitser, Type type) => regitser.Register(type, type, Reuse.Transient);
    public static void RegisterTransient(this IRegistrator regitser, Type from, Type to) => regitser.Register(from, to, Reuse.Transient);
    public static void RegisterTransient(this IRegistrator regitser, Type type, string name) => regitser.Register(type, type, Reuse.Transient, ifAlreadyRegistered: IfAlreadyRegistered.Replace, serviceKey: name);
    public static void RegisterTransient(this IRegistrator regitser, Type from, Type to, string name) => regitser.Register(from, to, Reuse.Transient, ifAlreadyRegistered: IfAlreadyRegistered.Replace, serviceKey: name);
    public static void RegisterTransient(this IRegistrator regitser, Type type, Func<object> factoryMethod) => regitser.RegisterDelegate(type, r => factoryMethod(), Reuse.Transient);
    public static void RegisterTransient(this IRegistrator regitser, Type type, Func<IResolver, object> factoryMethod) => regitser.RegisterDelegate(type, factoryMethod, Reuse.Transient);
    public static void RegisterManyTransient(this IRegistrator regitser, Type type, params Type[] serviceTypes)
    {
        if (serviceTypes.Length == 0)
            serviceTypes = type.GetInterfaces();

        regitser.RegisterMany(serviceTypes, type, Reuse.Transient);
    }


}

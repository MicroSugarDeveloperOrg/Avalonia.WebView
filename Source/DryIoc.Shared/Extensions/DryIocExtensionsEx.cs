namespace DryIoc.Shared.Extensions;

public static class DryIocExtensionsEx
{
    public static void RegisterSingleton<T>(this IRegistrator regitser) => regitser.RegisterSingleton(typeof(T));
    public static void RegisterSingleton<TFrom, TTo>(this IRegistrator regitser) => regitser.RegisterSingleton(typeof(TFrom), typeof(TTo));
    public static void RegisterSingleton<T>(this IRegistrator regitser, string name) => regitser.RegisterSingleton(typeof(T), name);
    public static void RegisterSingleton<TFrom, TTo>(this IRegistrator regitser, string name) => regitser.RegisterSingleton(typeof(TFrom), typeof(TTo), name);
    public static void RegisterSingleton<T>(this IRegistrator regitser, Func<T> factoryMethod) => regitser.RegisterDelegate<T>(factoryMethod, Reuse.Singleton);
    public static void RegisterSingleton<T>(this IRegistrator regitser, Func<IResolver, T> factoryMethod) => regitser.RegisterDelegate<T>(factoryMethod, Reuse.Singleton);
    public static void RegisterManySingleton<T>(this IRegistrator regitser, params Type[] serviceTypes) => regitser.RegisterManySingleton(typeof(T), serviceTypes);

    public static void RegisterScoped<T>(this IRegistrator regitser) => regitser.RegisterScoped(typeof(T));
    public static void RegisterScoped<TFrom, TTo>(this IRegistrator regitser) => regitser.RegisterScoped(typeof(TFrom), typeof(TTo));
    public static void RegisterScoped<T>(this IRegistrator regitser, string name) => regitser.RegisterScoped(typeof(T), name);
    public static void RegisterScoped<TFrom, TTo>(this IRegistrator regitser, string name) => regitser.RegisterScoped(typeof(TFrom), typeof(TTo), name);
    public static void RegisterScoped<T>(this IRegistrator regitser, Func<T> factoryMethod) => regitser.RegisterDelegate<T>(factoryMethod, Reuse.ScopedOrSingleton);
    public static void RegisterScoped<T>(this IRegistrator regitser, Func<IResolver, T> factoryMethod) => regitser.RegisterDelegate<T>(factoryMethod, Reuse.ScopedOrSingleton);
    public static void RegisterManyScoped<T>(this IRegistrator regitser, params Type[] serviceTypes) => regitser.RegisterManyScoped(typeof(T), serviceTypes);

    public static void RegisterTransient<T>(this IRegistrator regitser) => regitser.RegisterTransient(typeof(T));
    public static void RegisterTransient<TFrom, TTo>(this IRegistrator regitser) => regitser.RegisterTransient(typeof(TFrom), typeof(TTo));
    public static void RegisterTransient<T>(this IRegistrator regitser, string name) => regitser.RegisterTransient(typeof(T), name);
    public static void RegisterTransient<TFrom, TTo>(this IRegistrator regitser, string name) => regitser.RegisterTransient(typeof(TFrom), typeof(TTo), name);
    public static void RegisterTransient<T>(this IRegistrator regitser, Func<T> factoryMethod) => regitser.RegisterDelegate<T>(factoryMethod, Reuse.Transient);
    public static void RegisterTransient<T>(this IRegistrator regitser, Func<IResolver, T> factoryMethod) => regitser.RegisterDelegate<T>(factoryMethod, Reuse.Transient);
    public static void RegisterManyTransient<T>(this IRegistrator regitser, params Type[] serviceTypes) => regitser.RegisterManyTransient(typeof(T), serviceTypes);

}

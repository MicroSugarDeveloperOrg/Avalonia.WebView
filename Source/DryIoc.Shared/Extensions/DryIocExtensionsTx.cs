namespace DryIoc.Shared.Extensions;
public static class DryIocExtensionsTx
{
    public static void RegisterViewAndViewModel<TView, TViewModel>(this IRegistrator registrator)
    {
        registrator.RegisterSingleton<TView>();
        registrator.RegisterSingleton<TViewModel>();
    }

    public static T? GetService<T>(this IResolverContext resolverContext)
    {
        var value = resolverContext.GetService(typeof(T));
        if (value is T tValue)
            return tValue;

        return default;
    }

    public static T GetRequiredService<T>(this IResolverContext resolverContext)
    {
        var value = resolverContext.GetService<T>();
        if (value is null)
            throw new ArgumentOutOfRangeException(nameof(value));

        return value;
    }

}

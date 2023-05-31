namespace Xamarin.Utiles;

[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
public sealed class BlockProxyAttribute : Attribute
{
    public Type Type { get; set; }

    public BlockProxyAttribute(Type t)
    {
        Type = t;
    }
}
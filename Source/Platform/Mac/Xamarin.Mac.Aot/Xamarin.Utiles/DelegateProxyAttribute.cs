namespace Xamarin.Utiles;

[AttributeUsage(AttributeTargets.ReturnValue, AllowMultiple = false)]
public sealed class DelegateProxyAttribute : Attribute
{
    public Type DelegateType { get; set; }

    public DelegateProxyAttribute(Type delegateType)
    {
        DelegateType = delegateType;
    }
}

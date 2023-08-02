namespace Xamarin.Utiles;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = false)]
public class BindAsAttribute : Attribute
{
    public Type Type;

    public Type OriginalType;

    public BindAsAttribute(Type type)
    {
        Type = type;
    }
}
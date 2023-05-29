namespace Xamarin.Utiles;

[AttributeUsage(AttributeTargets.Enum)]
public sealed class NativeAttribute : Attribute
{
    public string NativeName { get; set; }

    public NativeAttribute()
    {
    }

    public NativeAttribute(string name)
    {
        NativeName = name;
    }
}
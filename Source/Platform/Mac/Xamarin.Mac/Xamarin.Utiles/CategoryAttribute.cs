namespace Xamarin.Utiles;

[AttributeUsage(AttributeTargets.Class)]
public class CategoryAttribute : Attribute
{
    public Type Type { get; set; }

    public string Name { get; set; }

    public CategoryAttribute(Type type)
    {
        Type = type;
    }
}

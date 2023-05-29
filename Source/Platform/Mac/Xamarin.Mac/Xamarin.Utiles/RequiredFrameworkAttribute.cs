namespace Xamarin.Utiles;

[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public class RequiredFrameworkAttribute : Attribute
{
    public string Name { get; private set; }

    public RequiredFrameworkAttribute(string name)
    {
        Name = name;
    }
}
namespace Xamarin.Utiles;

internal class TypeEqualityComparer : IEqualityComparer<Type>
{
    public bool Equals(Type x, Type y)
    {
        return x == y;
    }

    public int GetHashCode(Type obj)
    {
        if (obj == null)
        {
            return 0;
        }
        return obj.GetHashCode();
    }
}

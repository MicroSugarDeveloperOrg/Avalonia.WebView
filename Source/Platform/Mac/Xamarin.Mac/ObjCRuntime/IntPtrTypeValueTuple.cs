namespace ObjCRuntime;

internal struct IntPtrTypeValueTuple : IEquatable<IntPtrTypeValueTuple>
{
    private static readonly IEqualityComparer<IntPtr> item1Comparer = Runtime.IntPtrEqualityComparer;

    private static readonly IEqualityComparer<Type> item2Comparer = Runtime.TypeEqualityComparer;

    public readonly IntPtr Item1;

    public readonly Type Item2;

    public IntPtrTypeValueTuple(IntPtr item1, Type item2)
    {
        Item1 = item1;
        Item2 = item2;
    }

    public bool Equals(IntPtrTypeValueTuple other)
    {
        return item1Comparer.Equals(Item1, other.Item1) && item2Comparer.Equals(Item2, other.Item2);
    }

    public override bool Equals(object obj)
    {
        if (obj is IntPtrTypeValueTuple)
        {
            return Equals((IntPtrTypeValueTuple)obj);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return item1Comparer.GetHashCode(Item1) ^ item2Comparer.GetHashCode(Item2);
    }

    public static bool operator ==(IntPtrTypeValueTuple left, IntPtrTypeValueTuple right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(IntPtrTypeValueTuple left, IntPtrTypeValueTuple right)
    {
        return !left.Equals(right);
    }
}
namespace WebKit;

public interface IIndexedContainer<T>
{
	int Count { get; }

	T this[int index] { get; }
}

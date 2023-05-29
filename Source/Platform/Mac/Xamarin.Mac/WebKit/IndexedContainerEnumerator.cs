using System;
using System.Collections;
using System.Collections.Generic;

namespace WebKit;

internal class IndexedContainerEnumerator<T> : IEnumerator<T>, IEnumerator, IDisposable
{
	private IIndexedContainer<T> _container;

	private int _index;

	public T Current => _container[_index];

	object IEnumerator.Current => ((IEnumerator<T>)this).Current;

	public IndexedContainerEnumerator(IIndexedContainer<T> container)
	{
		_container = container;
		Reset();
	}

	public void Dispose()
	{
		_container = null;
	}

	public bool MoveNext()
	{
		return ++_index < _container.Count;
	}

	public void Reset()
	{
		_index = -1;
	}
}

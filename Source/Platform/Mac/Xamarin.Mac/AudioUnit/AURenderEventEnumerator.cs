using System.Collections;
using System.Collections.Generic;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AudioUnit;

public class AURenderEventEnumerator : IEnumerator<AURenderEvent>, IDisposable, IEnumerator, INativeObject
{
	private unsafe AURenderEvent* current;

	public IntPtr Handle { get; private set; }

	public bool IsEmpty => Handle == IntPtr.Zero;

	public unsafe bool IsAtEnd => current == null;

	public unsafe AURenderEvent* UnsafeFirst => (AURenderEvent*)(void*)Handle;

	public unsafe AURenderEvent First
	{
		get
		{
			if (IsEmpty)
			{
				throw new InvalidOperationException("Can not get First on AURenderEventEnumerator when empty");
			}
			return *(AURenderEvent*)(void*)Handle;
		}
	}

	public unsafe AURenderEvent Current
	{
		get
		{
			if (IsAtEnd)
			{
				throw new InvalidOperationException("Can not get Current on AURenderEventEnumerator when at end");
			}
			return *current;
		}
	}

	object IEnumerator.Current => Current;

	public unsafe AURenderEventEnumerator(IntPtr ptr)
	{
		Handle = ptr;
		current = (AURenderEvent*)(void*)ptr;
	}

	public unsafe void Dispose()
	{
		Handle = IntPtr.Zero;
		current = null;
	}

	private unsafe bool IsAt(nint now)
	{
		return current != null && current->Head.EventSampleTime == (long)now;
	}

	public IEnumerable<AURenderEvent> EnumeratorCurrentEvents(nint now)
	{
		if (IsAtEnd)
		{
			throw new InvalidOperationException("Can not enumerate events on AURenderEventEnumerator when at end");
		}
		do
		{
			yield return Current;
			MoveNext();
		}
		while (IsAt(now));
	}

	public unsafe bool MoveNext()
	{
		if (current != null)
		{
			current = current->Head.UnsafeNext;
		}
		return current != null;
	}

	public unsafe void Reset()
	{
		current = (AURenderEvent*)(void*)Handle;
	}
}

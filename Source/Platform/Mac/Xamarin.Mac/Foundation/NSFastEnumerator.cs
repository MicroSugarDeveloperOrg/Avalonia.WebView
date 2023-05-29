using ObjCRuntime;
using System.Collections;
using System.Runtime.InteropServices;

namespace Foundation;
internal class NSFastEnumerator
{
    [DllImport("/usr/lib/libobjc.dylib")]
    public static extern nuint objc_msgSend(IntPtr receiver, IntPtr selector, ref NSFastEnumerationState arg1, IntPtr[] arg2, nuint arg3);
}

internal class NSFastEnumerator<T> : IEnumerator<T>, IDisposable, IEnumerator where T : class, INativeObject
{
    private NSFastEnumerationState state;

    private NSObject collection;

    private IntPtr[] array;

    private nuint count;

    private IntPtr mutationValue;

    private nuint current;

    private bool started;

    object IEnumerator.Current
    {
        get
        {
            VerifyNonMutated();
            return Current;
        }
    }

    public T Current => Runtime.GetNativeObject<T>(Marshal.ReadIntPtr(state.itemsPtr, IntPtr.Size * (int)current));

    public NSFastEnumerator(NSObject collection)
    {
        this.collection = collection;
    }

    private void Fetch()
    {
        if (array == null)
        {
            array = new IntPtr[16];
        }
        count = NSFastEnumerator.objc_msgSend(collection.Handle, Selector.GetHandle("countByEnumeratingWithState:objects:count:"), ref state, array, (nuint)array.Length);
        if (!started)
        {
            started = true;
            mutationValue = Marshal.ReadIntPtr(state.mutationsPtr);
        }
        current = 0;
    }

    private void VerifyNonMutated()
    {
        if (mutationValue != Marshal.ReadIntPtr(state.mutationsPtr))
            throw new InvalidOperationException("Collection was modified");
    }

    bool IEnumerator.MoveNext()
    {
        if (array == null || current == count - 1)
        {
            Fetch();
            if (count == 0)
                return false;
        }
        else
            ++current;

        VerifyNonMutated();
        return true;
    }

    void IEnumerator.Reset()
    {
        state = default;
        started = false;
    }

    void IDisposable.Dispose()
    {
    }
}
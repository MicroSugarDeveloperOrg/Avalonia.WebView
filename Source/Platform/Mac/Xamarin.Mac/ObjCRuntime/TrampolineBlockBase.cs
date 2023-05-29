using System.ComponentModel;
using System.Runtime.InteropServices;

namespace ObjCRuntime;

[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class TrampolineBlockBase
{
    private readonly IntPtr blockPtr;

    protected IntPtr BlockPointer => blockPtr;

    [DllImport("/usr/lib/libobjc.dylib")]
    private static extern IntPtr _Block_copy(IntPtr ptr);

    protected unsafe TrampolineBlockBase(BlockLiteral* block)
    {
        blockPtr = _Block_copy((IntPtr)block);
    }

    ~TrampolineBlockBase()
    {
        //Runtime.ReleaseBlockOnMainThread(blockPtr);
    }

    protected unsafe static object GetExistingManagedDelegate(IntPtr block)
    {
        return null;
    }
}

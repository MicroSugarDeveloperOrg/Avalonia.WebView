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

    [DllImport("/usr/lib/libobjc.dylib")]
    internal static extern void _Block_release(IntPtr block);

    protected unsafe TrampolineBlockBase(BlockLiteral* block)
    {
        blockPtr = _Block_copy((IntPtr)block);
    }

    ~TrampolineBlockBase()
    {
        _Block_release(blockPtr);
    }

    protected unsafe static object GetExistingManagedDelegate(IntPtr block)
    {
        if (!BlockLiteral.IsManagedBlock(block))
            return null;

        return ((BlockLiteral*)(void*)block)->Target;
    }
}

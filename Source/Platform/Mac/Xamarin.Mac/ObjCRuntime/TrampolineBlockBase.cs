using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;

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
        Runtime.ReleaseBlockOnMainThread(blockPtr);
    }

    protected unsafe static object GetExistingManagedDelegate(IntPtr block)
    {
        if (!BlockLiteral.IsManagedBlock(block))
        {
            return null;
        }
        return ((BlockLiteral*)(void*)block)->Target;
    }
}
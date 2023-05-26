using System.Runtime.InteropServices;

namespace Foundation;
internal abstract class NSAsyncDispatcher : NSDispatcher
{
    private readonly GCHandle gch;

    protected NSAsyncDispatcher()
    {
        gch = GCHandle.Alloc(this);
    }

    public override void Apply()
    {
        gch.Free();
    }
}

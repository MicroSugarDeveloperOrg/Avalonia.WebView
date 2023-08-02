using Foundation;
using ObjCRuntime;

namespace JavaScriptCore;

internal sealed class JSExportWrapper : BaseWrapper, IJSExport
{
    [Preserve(Conditional = true)]
    public JSExportWrapper(IntPtr handle)
        : base(handle, false)
    {
    }

    [Preserve(Conditional = true)]
    public JSExportWrapper(IntPtr handle, bool owns)
    : base(handle, owns)
    {
    }
}

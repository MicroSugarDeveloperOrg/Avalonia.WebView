using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace JavaScriptCore;

[Protocol]
[Register("Xamarin_Mac__JavaScriptCore_JSExport", false)]
[Model]
public class JSExport : NSObject, IJSExport, INativeObject, IDisposable
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public JSExport()
        : base(NSObjectFlag.Empty)
    {
        IsDirectBinding = false;
        InitializeHandle(Selector.Init);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected JSExport(NSObjectFlag t)
        : base(t)
    {
        IsDirectBinding = false;
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal JSExport(IntPtr handle)
        : base(handle)
    {
        IsDirectBinding = false;
    }
}

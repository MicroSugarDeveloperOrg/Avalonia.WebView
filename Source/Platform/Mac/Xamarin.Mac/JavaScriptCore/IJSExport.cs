using Foundation;
using ObjCRuntime;

namespace JavaScriptCore;

[Protocol(Name = "JSExport", WrapperType = typeof(JSExportWrapper))]
public interface IJSExport : INativeObject, IDisposable
{
}

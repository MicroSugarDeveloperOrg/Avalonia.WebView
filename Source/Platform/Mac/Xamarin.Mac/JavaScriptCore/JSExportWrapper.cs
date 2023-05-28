using System;
using Foundation;
using ObjCRuntime;

namespace JavaScriptCore;

internal sealed class JSExportWrapper : BaseWrapper, IJSExport, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public JSExportWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

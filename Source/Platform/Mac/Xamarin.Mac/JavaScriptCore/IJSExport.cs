using System;
using Foundation;
using ObjCRuntime;

namespace JavaScriptCore;

[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "JSExport", WrapperType = typeof(JSExportWrapper))]
public interface IJSExport : INativeObject, IDisposable
{
}

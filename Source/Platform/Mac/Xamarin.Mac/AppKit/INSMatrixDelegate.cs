using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSMatrixDelegate", WrapperType = typeof(NSMatrixDelegateWrapper))]
public interface INSMatrixDelegate : INativeObject, IDisposable, INSControlTextEditingDelegate
{
}

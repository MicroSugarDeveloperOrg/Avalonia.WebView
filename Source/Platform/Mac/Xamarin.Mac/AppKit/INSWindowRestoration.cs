using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSWindowRestoration", WrapperType = typeof(NSWindowRestorationWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = true, Name = "RestoreWindow", Selector = "restoreWindowWithIdentifier:state:completionHandler:", ParameterType = new Type[]
{
	typeof(string),
	typeof(NSCoder),
	typeof(NSWindowCompletionHandler)
}, ParameterByRef = new bool[] { false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	typeof(Trampolines.NIDNSWindowCompletionHandler)
})]
public interface INSWindowRestoration : INativeObject, IDisposable
{
}

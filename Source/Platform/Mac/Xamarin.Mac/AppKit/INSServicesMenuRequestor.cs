using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSServicesMenuRequestor", WrapperType = typeof(NSServicesMenuRequestorWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WriteSelectionToPasteboard", Selector = "writeSelectionToPasteboard:types:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSPasteboard),
	typeof(string[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReadSelectionFromPasteboard", Selector = "readSelectionFromPasteboard:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSPasteboard) }, ParameterByRef = new bool[] { false })]
public interface INSServicesMenuRequestor : INativeObject, IDisposable
{
}

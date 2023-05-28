using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSTouchBarDelegate", WrapperType = typeof(NSTouchBarDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MakeItem", Selector = "touchBar:makeItemForIdentifier:", ReturnType = typeof(NSTouchBarItem), ParameterType = new Type[]
{
	typeof(NSTouchBar),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
public interface INSTouchBarDelegate : INativeObject, IDisposable
{
}

using System;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
[Protocol(Name = "WebOpenPanelResultListener", WrapperType = typeof(WebOpenPanelResultListenerWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ChooseFilename", Selector = "chooseFilename:", ParameterType = new Type[] { typeof(string) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ChooseFilenames", Selector = "chooseFilenames:", ParameterType = new Type[] { typeof(string[]) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Cancel", Selector = "cancel")]
public interface IWebOpenPanelResultListener : INativeObject, IDisposable
{
}

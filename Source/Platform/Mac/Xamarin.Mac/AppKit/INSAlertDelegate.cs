using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSAlertDelegate", WrapperType = typeof(NSAlertDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShowHelp", Selector = "alertShowHelp:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSAlert) }, ParameterByRef = new bool[] { false })]
public interface INSAlertDelegate : INativeObject, IDisposable
{
}

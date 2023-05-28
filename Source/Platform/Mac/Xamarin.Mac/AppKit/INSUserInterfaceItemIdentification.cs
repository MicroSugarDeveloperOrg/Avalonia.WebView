using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSUserInterfaceItemIdentification", WrapperType = typeof(NSUserInterfaceItemIdentificationWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Identifier", Selector = "identifier", PropertyType = typeof(string), GetterSelector = "identifier", SetterSelector = "setIdentifier:", ArgumentSemantic = ArgumentSemantic.Copy)]
public interface INSUserInterfaceItemIdentification : INativeObject, IDisposable
{
}

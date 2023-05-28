using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Protocol(Name = "NSEditorRegistration", WrapperType = typeof(NSEditorRegistrationWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ObjectDidBeginEditing", Selector = "objectDidBeginEditing:", ParameterType = new Type[] { typeof(INSEditor) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ObjectDidEndEditing", Selector = "objectDidEndEditing:", ParameterType = new Type[] { typeof(INSEditor) }, ParameterByRef = new bool[] { false })]
public interface INSEditorRegistration : INativeObject, IDisposable
{
}

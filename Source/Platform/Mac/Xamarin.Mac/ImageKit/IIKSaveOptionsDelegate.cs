using System;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Protocol(Name = "IKSaveOptionsDelegate", WrapperType = typeof(IKSaveOptionsDelegateWrapper), IsInformal = true)]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowType", Selector = "saveOptions:shouldShowUTType:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(IKSaveOptions),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
public interface IIKSaveOptionsDelegate : INativeObject, IDisposable
{
}

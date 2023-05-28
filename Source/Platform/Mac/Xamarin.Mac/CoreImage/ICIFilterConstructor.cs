using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "CIFilterConstructor", WrapperType = typeof(CIFilterConstructorWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "FilterWithName", Selector = "filterWithName:", ReturnType = typeof(CIFilter), ParameterType = new Type[] { typeof(string) }, ParameterByRef = new bool[] { false })]
public interface ICIFilterConstructor : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("filterWithName:")]
	[Preserve(Conditional = true)]
	CIFilter? FilterWithName(string name);
}

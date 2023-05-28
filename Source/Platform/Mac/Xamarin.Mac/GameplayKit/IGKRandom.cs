using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace GameplayKit;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "GKRandom", WrapperType = typeof(GKRandomWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetNextInt", Selector = "nextInt", ReturnType = typeof(nint))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetNextInt", Selector = "nextIntWithUpperBound:", ReturnType = typeof(nuint), ParameterType = new Type[] { typeof(nuint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetNextUniform", Selector = "nextUniform", ReturnType = typeof(float))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetNextBool", Selector = "nextBool", ReturnType = typeof(bool))]
public interface IGKRandom : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("nextInt")]
	[Preserve(Conditional = true)]
	nint GetNextInt();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("nextIntWithUpperBound:")]
	[Preserve(Conditional = true)]
	nuint GetNextInt(nuint upperBound);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("nextUniform")]
	[Preserve(Conditional = true)]
	float GetNextUniform();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("nextBool")]
	[Preserve(Conditional = true)]
	bool GetNextBool();
}

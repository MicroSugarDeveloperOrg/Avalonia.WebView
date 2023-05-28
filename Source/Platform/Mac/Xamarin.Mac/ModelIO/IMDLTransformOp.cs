using System;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace ModelIO;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "MDLTransformOp", WrapperType = typeof(MDLTransformOpWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetNMatrix4", Selector = "float4x4AtTime:", ReturnType = typeof(NMatrix4), ParameterType = new Type[] { typeof(double) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetNMatrix4d", Selector = "double4x4AtTime:", ReturnType = typeof(NMatrix4d), ParameterType = new Type[] { typeof(double) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Name", Selector = "name", PropertyType = typeof(string), GetterSelector = "name", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "IsInverseOp", Selector = "IsInverseOp", PropertyType = typeof(bool), GetterSelector = "IsInverseOp", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMDLTransformOp : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	string Name
	{
		[Export("name")]
		get;
	}

	[Preserve(Conditional = true)]
	bool IsInverseOp
	{
		[Export("IsInverseOp")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("float4x4AtTime:")]
	[Preserve(Conditional = true)]
	NMatrix4 GetNMatrix4(double atTime);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("double4x4AtTime:")]
	[Preserve(Conditional = true)]
	NMatrix4d GetNMatrix4d(double atTime);
}

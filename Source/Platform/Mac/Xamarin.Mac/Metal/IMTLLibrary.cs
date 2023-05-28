using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLLibrary", WrapperType = typeof(MTLLibraryWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateFunction", Selector = "newFunctionWithName:", ReturnType = typeof(IMTLFunction), ParameterType = new Type[] { typeof(string) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateFunction", Selector = "newFunctionWithName:constantValues:error:", ReturnType = typeof(IMTLFunction), ParameterType = new Type[]
{
	typeof(string),
	typeof(MTLFunctionConstantValues),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, true })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateFunction", Selector = "newFunctionWithName:constantValues:completionHandler:", ParameterType = new Type[]
{
	typeof(string),
	typeof(MTLFunctionConstantValues),
	typeof(Action<IMTLFunction, NSError>)
}, ParameterByRef = new bool[] { false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	typeof(Trampolines.NIDActionArity2V70)
})]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof(string), GetterSelector = "label", SetterSelector = "setLabel:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof(IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "FunctionNames", Selector = "functionNames", PropertyType = typeof(string[]), GetterSelector = "functionNames", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMTLLibrary : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	string Label
	{
		[Export("label")]
		get;
		[Export("setLabel:")]
		set;
	}

	[Preserve(Conditional = true)]
	IMTLDevice Device
	{
		[Export("device")]
		get;
	}

	[Preserve(Conditional = true)]
	string[] FunctionNames
	{
		[Export("functionNames")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newFunctionWithName:")]
	[Preserve(Conditional = true)]
	[return: Release]
	IMTLFunction CreateFunction(string functionName);
}

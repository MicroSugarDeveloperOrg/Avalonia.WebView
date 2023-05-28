using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLFunction", WrapperType = typeof(MTLFunctionWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateArgumentEncoder", Selector = "newArgumentEncoderWithBufferIndex:", ReturnType = typeof(IMTLArgumentEncoder), ParameterType = new Type[] { typeof(nuint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateArgumentEncoder", Selector = "newArgumentEncoderWithBufferIndex:reflection:", ReturnType = typeof(IMTLArgumentEncoder), ParameterType = new Type[]
{
	typeof(nuint),
	typeof(MTLArgument)
}, ParameterByRef = new bool[] { false, true })]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof(string), GetterSelector = "label", SetterSelector = "setLabel:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof(IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "FunctionType", Selector = "functionType", PropertyType = typeof(MTLFunctionType), GetterSelector = "functionType", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "VertexAttributes", Selector = "vertexAttributes", PropertyType = typeof(MTLVertexAttribute[]), GetterSelector = "vertexAttributes", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Name", Selector = "name", PropertyType = typeof(string), GetterSelector = "name", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "PatchType", Selector = "patchType", PropertyType = typeof(MTLPatchType), GetterSelector = "patchType", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "PatchControlPointCount", Selector = "patchControlPointCount", PropertyType = typeof(nint), GetterSelector = "patchControlPointCount", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "StageInputAttributes", Selector = "stageInputAttributes", PropertyType = typeof(MTLAttribute[]), GetterSelector = "stageInputAttributes", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "FunctionConstants", Selector = "functionConstantsDictionary", PropertyType = typeof(NSDictionary<NSString, MTLFunctionConstant>), GetterSelector = "functionConstantsDictionary", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMTLFunction : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	IMTLDevice Device
	{
		[Export("device")]
		get;
	}

	[Preserve(Conditional = true)]
	MTLFunctionType FunctionType
	{
		[Export("functionType")]
		get;
	}

	[Preserve(Conditional = true)]
	MTLVertexAttribute[] VertexAttributes
	{
		[Export("vertexAttributes")]
		get;
	}

	[Preserve(Conditional = true)]
	string Name
	{
		[Export("name")]
		get;
	}
}

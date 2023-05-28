using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLCommandEncoder", WrapperType = typeof(MTLCommandEncoderWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "EndEncoding", Selector = "endEncoding")]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "InsertDebugSignpost", Selector = "insertDebugSignpost:", ParameterType = new Type[] { typeof(string) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "PushDebugGroup", Selector = "pushDebugGroup:", ParameterType = new Type[] { typeof(string) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "PopDebugGroup", Selector = "popDebugGroup")]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof(IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof(string), GetterSelector = "label", SetterSelector = "setLabel:", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMTLCommandEncoder : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	IMTLDevice Device
	{
		[Export("device")]
		get;
	}

	[Preserve(Conditional = true)]
	string Label
	{
		[Export("label")]
		get;
		[Export("setLabel:")]
		set;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("endEncoding")]
	[Preserve(Conditional = true)]
	void EndEncoding();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("insertDebugSignpost:")]
	[Preserve(Conditional = true)]
	void InsertDebugSignpost(string signpost);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("pushDebugGroup:")]
	[Preserve(Conditional = true)]
	void PushDebugGroup(string debugGroup);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("popDebugGroup")]
	[Preserve(Conditional = true)]
	void PopDebugGroup();
}

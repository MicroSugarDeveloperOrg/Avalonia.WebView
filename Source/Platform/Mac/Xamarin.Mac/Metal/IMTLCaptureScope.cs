using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLCaptureScope", WrapperType = typeof(MTLCaptureScopeWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "BeginScope", Selector = "beginScope")]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "EndScope", Selector = "endScope")]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof(string), GetterSelector = "label", SetterSelector = "setLabel:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof(IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "CommandQueue", Selector = "commandQueue", PropertyType = typeof(IMTLCommandQueue), GetterSelector = "commandQueue", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMTLCaptureScope : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	string? Label
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
	IMTLCommandQueue? CommandQueue
	{
		[Export("commandQueue")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("beginScope")]
	[Preserve(Conditional = true)]
	void BeginScope();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("endScope")]
	[Preserve(Conditional = true)]
	void EndScope();
}

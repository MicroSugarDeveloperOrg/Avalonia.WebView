using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Protocol(Name = "NSUserInterfaceCompression", WrapperType = typeof(NSUserInterfaceCompressionWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Compress", Selector = "compressWithPrioritizedCompressionOptions:", ParameterType = new Type[] { typeof(NSUserInterfaceCompressionOptions[]) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetMinimumSize", Selector = "minimumSizeWithPrioritizedCompressionOptions:", ReturnType = typeof(CGSize), ParameterType = new Type[] { typeof(NSUserInterfaceCompressionOptions[]) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ActiveCompressionOptions", Selector = "activeCompressionOptions", PropertyType = typeof(NSUserInterfaceCompressionOptions), GetterSelector = "activeCompressionOptions", ArgumentSemantic = ArgumentSemantic.Copy)]
public interface INSUserInterfaceCompression : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	NSUserInterfaceCompressionOptions ActiveCompressionOptions
	{
		[Export("activeCompressionOptions", ArgumentSemantic.Copy)]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("compressWithPrioritizedCompressionOptions:")]
	[Preserve(Conditional = true)]
	void Compress(NSUserInterfaceCompressionOptions[] prioritizedOptions);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("minimumSizeWithPrioritizedCompressionOptions:")]
	[Preserve(Conditional = true)]
	CGSize GetMinimumSize(NSUserInterfaceCompressionOptions[] prioritizedOptions);
}

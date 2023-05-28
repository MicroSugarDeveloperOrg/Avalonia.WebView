using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "NSSpringLoadingDestination", WrapperType = typeof(NSSpringLoadingDestinationWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Activated", Selector = "springLoadingActivated:draggingInfo:", ParameterType = new Type[]
{
	typeof(bool),
	typeof(NSDraggingInfo)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "HighlightChanged", Selector = "springLoadingHighlightChanged:", ParameterType = new Type[] { typeof(NSDraggingInfo) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Entered", Selector = "springLoadingEntered:", ReturnType = typeof(NSSpringLoadingOptions), ParameterType = new Type[] { typeof(NSDraggingInfo) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Updated", Selector = "springLoadingUpdated:", ReturnType = typeof(NSSpringLoadingOptions), ParameterType = new Type[] { typeof(NSDraggingInfo) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Exited", Selector = "springLoadingExited:", ParameterType = new Type[] { typeof(NSDraggingInfo) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DraggingEnded", Selector = "draggingEnded:", ParameterType = new Type[] { typeof(NSDraggingInfo) }, ParameterByRef = new bool[] { false })]
public interface INSSpringLoadingDestination : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("springLoadingActivated:draggingInfo:")]
	[Preserve(Conditional = true)]
	void Activated(bool activated, NSDraggingInfo draggingInfo);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("springLoadingHighlightChanged:")]
	[Preserve(Conditional = true)]
	void HighlightChanged(NSDraggingInfo draggingInfo);
}

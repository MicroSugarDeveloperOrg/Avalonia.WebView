using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.MacCatalyst, 13, 4, PlatformArchitecture.None, null)]
[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLRasterizationRateMap", WrapperType = typeof(MTLRasterizationRateMapWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CopyParameterData", Selector = "copyParameterDataToBuffer:offset:", ParameterType = new Type[]
{
	typeof(IMTLBuffer),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPhysicalSize", Selector = "physicalSizeForLayer:", ReturnType = typeof(MTLSize), ParameterType = new Type[] { typeof(nuint) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "MapScreenToPhysicalCoordinates", Selector = "mapScreenToPhysicalCoordinates:forLayer:", ReturnType = typeof(MTLCoordinate2D), ParameterType = new Type[]
{
	typeof(MTLCoordinate2D),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "MapPhysicalToScreenCoordinates", Selector = "mapPhysicalToScreenCoordinates:forLayer:", ReturnType = typeof(MTLCoordinate2D), ParameterType = new Type[]
{
	typeof(MTLCoordinate2D),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof(IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof(string), GetterSelector = "label", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ScreenSize", Selector = "screenSize", PropertyType = typeof(MTLSize), GetterSelector = "screenSize", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "PhysicalGranularity", Selector = "physicalGranularity", PropertyType = typeof(MTLSize), GetterSelector = "physicalGranularity", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "LayerCount", Selector = "layerCount", PropertyType = typeof(nuint), GetterSelector = "layerCount", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ParameterBufferSizeAndAlign", Selector = "parameterBufferSizeAndAlign", PropertyType = typeof(MTLSizeAndAlign), GetterSelector = "parameterBufferSizeAndAlign", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMTLRasterizationRateMap : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	IMTLDevice Device
	{
		[Export("device")]
		get;
	}

	[Preserve(Conditional = true)]
	string? Label
	{
		[Export("label")]
		get;
	}

	[Preserve(Conditional = true)]
	MTLSize ScreenSize
	{
		[Export("screenSize")]
		get;
	}

	[Preserve(Conditional = true)]
	MTLSize PhysicalGranularity
	{
		[Export("physicalGranularity")]
		get;
	}

	[Preserve(Conditional = true)]
	nuint LayerCount
	{
		[Export("layerCount")]
		get;
	}

	[Preserve(Conditional = true)]
	MTLSizeAndAlign ParameterBufferSizeAndAlign
	{
		[Export("parameterBufferSizeAndAlign")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("copyParameterDataToBuffer:offset:")]
	[Preserve(Conditional = true)]
	void CopyParameterData(IMTLBuffer buffer, nuint offset);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("physicalSizeForLayer:")]
	[Preserve(Conditional = true)]
	MTLSize GetPhysicalSize(nuint layerIndex);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("mapScreenToPhysicalCoordinates:forLayer:")]
	[Preserve(Conditional = true)]
	MTLCoordinate2D MapScreenToPhysicalCoordinates(MTLCoordinate2D screenCoordinates, nuint layerIndex);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("mapPhysicalToScreenCoordinates:forLayer:")]
	[Preserve(Conditional = true)]
	MTLCoordinate2D MapPhysicalToScreenCoordinates(MTLCoordinate2D physicalCoordinates, nuint layerIndex);
}

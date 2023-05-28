using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Metal;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLBuffer", WrapperType = typeof(MTLBufferWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidModify", Selector = "didModifyRange:", ParameterType = new Type[] { typeof(NSRange) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateTexture", Selector = "newTextureWithDescriptor:offset:bytesPerRow:", ReturnType = typeof(IMTLTexture), ParameterType = new Type[]
{
	typeof(MTLTextureDescriptor),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddDebugMarker", Selector = "addDebugMarker:range:", ParameterType = new Type[]
{
	typeof(string),
	typeof(NSRange)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoveAllDebugMarkers", Selector = "removeAllDebugMarkers")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateRemoteBuffer", Selector = "newRemoteBufferViewForDevice:", ReturnType = typeof(IMTLBuffer), ParameterType = new Type[] { typeof(IMTLDevice) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Length", Selector = "length", PropertyType = typeof(nuint), GetterSelector = "length", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Contents", Selector = "contents", PropertyType = typeof(IntPtr), GetterSelector = "contents", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "RemoteStorageBuffer", Selector = "remoteStorageBuffer", PropertyType = typeof(IMTLBuffer), GetterSelector = "remoteStorageBuffer", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMTLBuffer : INativeObject, IDisposable, IMTLResource
{
	[Preserve(Conditional = true)]
	nuint Length
	{
		[Export("length")]
		get;
	}

	[Preserve(Conditional = true)]
	IntPtr Contents
	{
		[Export("contents")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("didModifyRange:")]
	[Preserve(Conditional = true)]
	void DidModify(NSRange range);
}

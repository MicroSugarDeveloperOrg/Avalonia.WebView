using System;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

[Protocol(Name = "ICCameraDeviceDelegate", WrapperType = typeof(ICCameraDeviceDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidAddItem", Selector = "cameraDevice:didAddItem:", ParameterType = new Type[]
{
	typeof(ICCameraDevice),
	typeof(ICCameraItem)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidRemoveItem", Selector = "cameraDevice:didRemoveItem:", ParameterType = new Type[]
{
	typeof(ICCameraDevice),
	typeof(ICCameraItem)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidRenameItems", Selector = "cameraDevice:didRenameItems:", ParameterType = new Type[]
{
	typeof(ICCameraDevice),
	typeof(ICCameraItem[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidCompleteDeleteFiles", Selector = "cameraDevice:didCompleteDeleteFilesWithError:", ParameterType = new Type[]
{
	typeof(ICCameraDevice),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidChangeCapability", Selector = "cameraDeviceDidChangeCapability:", ParameterType = new Type[] { typeof(ICCameraDevice) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveThumbnail", Selector = "cameraDevice:didReceiveThumbnailForItem:", ParameterType = new Type[]
{
	typeof(ICCameraDevice),
	typeof(ICCameraItem)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveMetadata", Selector = "cameraDevice:didReceiveMetadataForItem:", ParameterType = new Type[]
{
	typeof(ICCameraDevice),
	typeof(ICCameraItem)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceivePtpEvent", Selector = "cameraDevice:didReceivePTPEvent:", ParameterType = new Type[]
{
	typeof(ICCameraDevice),
	typeof(NSData)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidBecomeReadyWithCompleteContentCatalog", Selector = "deviceDidBecomeReadyWithCompleteContentCatalog:", ParameterType = new Type[] { typeof(ICDevice) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAddItems", Selector = "cameraDevice:didAddItems:", ParameterType = new Type[]
{
	typeof(ICCameraDevice),
	typeof(ICCameraItem[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemoveItems", Selector = "cameraDevice:didRemoveItems:", ParameterType = new Type[]
{
	typeof(ICCameraDevice),
	typeof(ICCameraItem[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldGetThumbnail", Selector = "cameraDevice:shouldGetThumbnailOfItem:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(ICCameraDevice),
	typeof(ICCameraItem)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldGetMetadata", Selector = "cameraDevice:shouldGetMetadataOfItem:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(ICCameraDevice),
	typeof(ICCameraItem)
}, ParameterByRef = new bool[] { false, false })]
public interface IICCameraDeviceDelegate : INativeObject, IDisposable, IICDeviceDelegate
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("cameraDevice:didAddItem:")]
	[Preserve(Conditional = true)]
	void DidAddItem(ICCameraDevice camera, ICCameraItem item);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("cameraDevice:didRemoveItem:")]
	[Preserve(Conditional = true)]
	void DidRemoveItem(ICCameraDevice camera, ICCameraItem item);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("cameraDevice:didRenameItems:")]
	[Preserve(Conditional = true)]
	void DidRenameItems(ICCameraDevice camera, ICCameraItem[] items);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("cameraDevice:didCompleteDeleteFilesWithError:")]
	[Preserve(Conditional = true)]
	void DidCompleteDeleteFiles(ICCameraDevice scanner, NSError? error);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("cameraDeviceDidChangeCapability:")]
	[Preserve(Conditional = true)]
	void DidChangeCapability(ICCameraDevice camera);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("cameraDevice:didReceiveThumbnailForItem:")]
	[Preserve(Conditional = true)]
	void DidReceiveThumbnail(ICCameraDevice camera, ICCameraItem forItem);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("cameraDevice:didReceiveMetadataForItem:")]
	[Preserve(Conditional = true)]
	void DidReceiveMetadata(ICCameraDevice camera, ICCameraItem forItem);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("cameraDevice:didReceivePTPEvent:")]
	[Preserve(Conditional = true)]
	void DidReceivePtpEvent(ICCameraDevice camera, NSData eventData);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("deviceDidBecomeReadyWithCompleteContentCatalog:")]
	[Preserve(Conditional = true)]
	void DidBecomeReadyWithCompleteContentCatalog(ICDevice device);
}

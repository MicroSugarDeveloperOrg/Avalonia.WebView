using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSRNNMatrixTrainingState", true)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class MPSRnnMatrixTrainingState : MPSState
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_BufferSize_ = "initWithDevice:bufferSize:";

	private static readonly IntPtr selInitWithDevice_BufferSize_Handle = Selector.GetHandle("initWithDevice:bufferSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ResourceList_ = "initWithDevice:resourceList:";

	private static readonly IntPtr selInitWithDevice_ResourceList_Handle = Selector.GetHandle("initWithDevice:resourceList:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_TextureDescriptor_ = "initWithDevice:textureDescriptor:";

	private static readonly IntPtr selInitWithDevice_TextureDescriptor_Handle = Selector.GetHandle("initWithDevice:textureDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithResource_ = "initWithResource:";

	private static readonly IntPtr selInitWithResource_Handle = Selector.GetHandle("initWithResource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithResources_ = "initWithResources:";

	private static readonly IntPtr selInitWithResources_Handle = Selector.GetHandle("initWithResources:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryStateWithCommandBuffer_ = "temporaryStateWithCommandBuffer:";

	private static readonly IntPtr selTemporaryStateWithCommandBuffer_Handle = Selector.GetHandle("temporaryStateWithCommandBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryStateWithCommandBuffer_BufferSize_ = "temporaryStateWithCommandBuffer:bufferSize:";

	private static readonly IntPtr selTemporaryStateWithCommandBuffer_BufferSize_Handle = Selector.GetHandle("temporaryStateWithCommandBuffer:bufferSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryStateWithCommandBuffer_ResourceList_ = "temporaryStateWithCommandBuffer:resourceList:";

	private static readonly IntPtr selTemporaryStateWithCommandBuffer_ResourceList_Handle = Selector.GetHandle("temporaryStateWithCommandBuffer:resourceList:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTemporaryStateWithCommandBuffer_TextureDescriptor_ = "temporaryStateWithCommandBuffer:textureDescriptor:";

	private static readonly IntPtr selTemporaryStateWithCommandBuffer_TextureDescriptor_Handle = Selector.GetHandle("temporaryStateWithCommandBuffer:textureDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSRNNMatrixTrainingState");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSRnnMatrixTrainingState(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSRnnMatrixTrainingState(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:bufferSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSRnnMatrixTrainingState(IMTLDevice device, nuint bufferSize)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(base.Handle, selInitWithDevice_BufferSize_Handle, device.Handle, bufferSize), "initWithDevice:bufferSize:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selInitWithDevice_BufferSize_Handle, device.Handle, bufferSize), "initWithDevice:bufferSize:");
		}
	}

	[Export("initWithDevice:textureDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSRnnMatrixTrainingState(IMTLDevice device, MTLTextureDescriptor descriptor)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDevice_TextureDescriptor_Handle, device.Handle, descriptor.Handle), "initWithDevice:textureDescriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDevice_TextureDescriptor_Handle, device.Handle, descriptor.Handle), "initWithDevice:textureDescriptor:");
		}
	}

	[Export("initWithResource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSRnnMatrixTrainingState(IMTLResource? resource)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithResource_Handle, resource?.Handle ?? IntPtr.Zero), "initWithResource:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithResource_Handle, resource?.Handle ?? IntPtr.Zero), "initWithResource:");
		}
	}

	[Export("initWithDevice:resourceList:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSRnnMatrixTrainingState(IMTLDevice device, MPSStateResourceList resourceList)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (resourceList == null)
		{
			throw new ArgumentNullException("resourceList");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDevice_ResourceList_Handle, device.Handle, resourceList.Handle), "initWithDevice:resourceList:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDevice_ResourceList_Handle, device.Handle, resourceList.Handle), "initWithDevice:resourceList:");
		}
	}

	[Export("initWithResources:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSRnnMatrixTrainingState(IMTLResource[]? resources)
		: base(NSObjectFlag.Empty)
	{
		NSArray nSArray = ((resources == null) ? null : NSArray.FromNSObjects(resources));
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithResources_Handle, nSArray?.Handle ?? IntPtr.Zero), "initWithResources:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithResources_Handle, nSArray?.Handle ?? IntPtr.Zero), "initWithResources:");
		}
		nSArray?.Dispose();
	}

	[Export("temporaryStateWithCommandBuffer:bufferSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static MPSRnnMatrixTrainingState CreateTemporaryState(IMTLCommandBuffer commandBuffer, nuint bufferSize)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		return Runtime.GetNSObject<MPSRnnMatrixTrainingState>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(class_ptr, selTemporaryStateWithCommandBuffer_BufferSize_Handle, commandBuffer.Handle, bufferSize));
	}

	[Export("temporaryStateWithCommandBuffer:textureDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static MPSRnnMatrixTrainingState CreateTemporaryState(IMTLCommandBuffer commandBuffer, MTLTextureDescriptor descriptor)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		return Runtime.GetNSObject<MPSRnnMatrixTrainingState>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selTemporaryStateWithCommandBuffer_TextureDescriptor_Handle, commandBuffer.Handle, descriptor.Handle));
	}

	[Export("temporaryStateWithCommandBuffer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static MPSRnnMatrixTrainingState CreateTemporaryState(IMTLCommandBuffer commandBuffer)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		return Runtime.GetNSObject<MPSRnnMatrixTrainingState>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTemporaryStateWithCommandBuffer_Handle, commandBuffer.Handle));
	}

	[Export("temporaryStateWithCommandBuffer:resourceList:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static MPSRnnMatrixTrainingState CreateTemporaryState(IMTLCommandBuffer commandBuffer, MPSStateResourceList resourceList)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (resourceList == null)
		{
			throw new ArgumentNullException("resourceList");
		}
		return Runtime.GetNSObject<MPSRnnMatrixTrainingState>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selTemporaryStateWithCommandBuffer_ResourceList_Handle, commandBuffer.Handle, resourceList.Handle));
	}
}

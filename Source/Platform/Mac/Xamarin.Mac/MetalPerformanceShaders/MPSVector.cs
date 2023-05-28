using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSVector", true)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSVector : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selData = "data";

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataType = "dataType";

	private static readonly IntPtr selDataTypeHandle = Selector.GetHandle("dataType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDevice = "device";

	private static readonly IntPtr selDeviceHandle = Selector.GetHandle("device");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithBuffer_Descriptor_ = "initWithBuffer:descriptor:";

	private static readonly IntPtr selInitWithBuffer_Descriptor_Handle = Selector.GetHandle("initWithBuffer:descriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithBuffer_Offset_Descriptor_ = "initWithBuffer:offset:descriptor:";

	private static readonly IntPtr selInitWithBuffer_Offset_Descriptor_Handle = Selector.GetHandle("initWithBuffer:offset:descriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_Descriptor_ = "initWithDevice:descriptor:";

	private static readonly IntPtr selInitWithDevice_Descriptor_Handle = Selector.GetHandle("initWithDevice:descriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLength = "length";

	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOffset = "offset";

	private static readonly IntPtr selOffsetHandle = Selector.GetHandle("offset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResourceSize = "resourceSize";

	private static readonly IntPtr selResourceSizeHandle = Selector.GetHandle("resourceSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSynchronizeOnCommandBuffer_ = "synchronizeOnCommandBuffer:";

	private static readonly IntPtr selSynchronizeOnCommandBuffer_Handle = Selector.GetHandle("synchronizeOnCommandBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVectorBytes = "vectorBytes";

	private static readonly IntPtr selVectorBytesHandle = Selector.GetHandle("vectorBytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVectors = "vectors";

	private static readonly IntPtr selVectorsHandle = Selector.GetHandle("vectors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSVector");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLBuffer Data
	{
		[Export("data")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSDataType DataType
	{
		[Export("dataType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSDataType)Messaging.UInt32_objc_msgSend(base.Handle, selDataTypeHandle);
			}
			return (MPSDataType)Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selDataTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLDevice Device
	{
		[Export("device", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, selDeviceHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeviceHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Length
	{
		[Export("length")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selLengthHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selLengthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 1, PlatformArchitecture.All, null)]
	public virtual nuint Offset
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 1, PlatformArchitecture.All, null)]
		[Export("offset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selOffsetHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selOffsetHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	public virtual nuint ResourceSize
	{
		[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
		[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
		[Export("resourceSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selResourceSizeHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selResourceSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint VectorBytes
	{
		[Export("vectorBytes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selVectorBytesHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selVectorBytesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Vectors
	{
		[Export("vectors")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selVectorsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selVectorsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSVector(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSVector(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithBuffer:descriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSVector(IMTLBuffer buffer, MPSVectorDescriptor descriptor)
		: base(NSObjectFlag.Empty)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithBuffer_Descriptor_Handle, buffer.Handle, descriptor.Handle), "initWithBuffer:descriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithBuffer_Descriptor_Handle, buffer.Handle, descriptor.Handle), "initWithBuffer:descriptor:");
		}
	}

	[Export("initWithBuffer:offset:descriptor:")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSVector(IMTLBuffer buffer, nuint offset, MPSVectorDescriptor descriptor)
		: base(NSObjectFlag.Empty)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_IntPtr(base.Handle, selInitWithBuffer_Offset_Descriptor_Handle, buffer.Handle, offset, descriptor.Handle), "initWithBuffer:offset:descriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_IntPtr(base.SuperHandle, selInitWithBuffer_Offset_Descriptor_Handle, buffer.Handle, offset, descriptor.Handle), "initWithBuffer:offset:descriptor:");
		}
	}

	[Export("initWithDevice:descriptor:")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSVector(IMTLDevice device, MPSVectorDescriptor descriptor)
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
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDevice_Descriptor_Handle, device.Handle, descriptor.Handle), "initWithDevice:descriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDevice_Descriptor_Handle, device.Handle, descriptor.Handle), "initWithDevice:descriptor:");
		}
	}

	[Export("synchronizeOnCommandBuffer:")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Synchronize(IMTLCommandBuffer commandBuffer)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSynchronizeOnCommandBuffer_Handle, commandBuffer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSynchronizeOnCommandBuffer_Handle, commandBuffer.Handle);
		}
	}
}

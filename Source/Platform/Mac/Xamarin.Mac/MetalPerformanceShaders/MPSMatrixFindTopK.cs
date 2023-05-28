using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSMatrixFindTopK", true)]
[Introduced(PlatformName.TvOS, 11, 3, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
public class MPSMatrixFindTopK : MPSMatrixUnaryKernel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_Device_ = "copyWithZone:device:";

	private static readonly IntPtr selCopyWithZone_Device_Handle = Selector.GetHandle("copyWithZone:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeToCommandBuffer_InputMatrix_ResultIndexMatrix_ResultValueMatrix_ = "encodeToCommandBuffer:inputMatrix:resultIndexMatrix:resultValueMatrix:";

	private static readonly IntPtr selEncodeToCommandBuffer_InputMatrix_ResultIndexMatrix_ResultValueMatrix_Handle = Selector.GetHandle("encodeToCommandBuffer:inputMatrix:resultIndexMatrix:resultValueMatrix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOffset = "indexOffset";

	private static readonly IntPtr selIndexOffsetHandle = Selector.GetHandle("indexOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_Device_ = "initWithCoder:device:";

	private static readonly IntPtr selInitWithCoder_Device_Handle = Selector.GetHandle("initWithCoder:device:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_NumberOfTopKValues_ = "initWithDevice:numberOfTopKValues:";

	private static readonly IntPtr selInitWithDevice_NumberOfTopKValues_Handle = Selector.GetHandle("initWithDevice:numberOfTopKValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfTopKValues = "numberOfTopKValues";

	private static readonly IntPtr selNumberOfTopKValuesHandle = Selector.GetHandle("numberOfTopKValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIndexOffset_ = "setIndexOffset:";

	private static readonly IntPtr selSetIndexOffset_Handle = Selector.GetHandle("setIndexOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNumberOfTopKValues_ = "setNumberOfTopKValues:";

	private static readonly IntPtr selSetNumberOfTopKValues_Handle = Selector.GetHandle("setNumberOfTopKValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSourceColumns_ = "setSourceColumns:";

	private static readonly IntPtr selSetSourceColumns_Handle = Selector.GetHandle("setSourceColumns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSourceRows_ = "setSourceRows:";

	private static readonly IntPtr selSetSourceRows_Handle = Selector.GetHandle("setSourceRows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceColumns = "sourceColumns";

	private static readonly IntPtr selSourceColumnsHandle = Selector.GetHandle("sourceColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceRows = "sourceRows";

	private static readonly IntPtr selSourceRowsHandle = Selector.GetHandle("sourceRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSMatrixFindTopK");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint IndexOffset
	{
		[Export("indexOffset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selIndexOffsetHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selIndexOffsetHandle);
		}
		[Export("setIndexOffset:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetIndexOffset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetIndexOffset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint NumberOfTopKValues
	{
		[Export("numberOfTopKValues")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNumberOfTopKValuesHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNumberOfTopKValuesHandle);
		}
		[Export("setNumberOfTopKValues:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetNumberOfTopKValues_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetNumberOfTopKValues_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint SourceColumns
	{
		[Export("sourceColumns")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSourceColumnsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSourceColumnsHandle);
		}
		[Export("setSourceColumns:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSourceColumns_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSourceColumns_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint SourceRows
	{
		[Export("sourceRows")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSourceRowsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSourceRowsHandle);
		}
		[Export("setSourceRows:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSourceRows_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSourceRows_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public MPSMatrixFindTopK(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSMatrixFindTopK(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSMatrixFindTopK(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:numberOfTopKValues:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSMatrixFindTopK(IMTLDevice device, nuint numberOfTopKValues)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(base.Handle, selInitWithDevice_NumberOfTopKValues_Handle, device.Handle, numberOfTopKValues), "initWithDevice:numberOfTopKValues:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selInitWithDevice_NumberOfTopKValues_Handle, device.Handle, numberOfTopKValues), "initWithDevice:numberOfTopKValues:");
		}
	}

	[Export("initWithCoder:device:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPSMatrixFindTopK(NSCoder aDecoder, IMTLDevice device)
		: base(NSObjectFlag.Empty)
	{
		if (aDecoder == null)
		{
			throw new ArgumentNullException("aDecoder");
		}
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithCoder_Device_Handle, aDecoder.Handle, device.Handle), "initWithCoder:device:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithCoder_Device_Handle, aDecoder.Handle, device.Handle), "initWithCoder:device:");
		}
	}

	[Export("copyWithZone:device:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual MPSMatrixFindTopK Copy(NSZone? zone, IMTLDevice? device)
	{
		MPSMatrixFindTopK mPSMatrixFindTopK = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MPSMatrixFindTopK>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCopyWithZone_Device_Handle, zone?.Handle ?? IntPtr.Zero, device?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<MPSMatrixFindTopK>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCopyWithZone_Device_Handle, zone?.Handle ?? IntPtr.Zero, device?.Handle ?? IntPtr.Zero)));
		if (mPSMatrixFindTopK != null)
		{
			Messaging.void_objc_msgSend(mPSMatrixFindTopK.Handle, Selector.GetHandle("release"));
		}
		return mPSMatrixFindTopK;
	}

	[Export("encodeToCommandBuffer:inputMatrix:resultIndexMatrix:resultValueMatrix:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeToCommandBuffer(IMTLCommandBuffer commandBuffer, MPSMatrix inputMatrix, MPSMatrix resultIndexMatrix, MPSMatrix resultValueMatrix)
	{
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		if (inputMatrix == null)
		{
			throw new ArgumentNullException("inputMatrix");
		}
		if (resultIndexMatrix == null)
		{
			throw new ArgumentNullException("resultIndexMatrix");
		}
		if (resultValueMatrix == null)
		{
			throw new ArgumentNullException("resultValueMatrix");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEncodeToCommandBuffer_InputMatrix_ResultIndexMatrix_ResultValueMatrix_Handle, commandBuffer.Handle, inputMatrix.Handle, resultIndexMatrix.Handle, resultValueMatrix.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEncodeToCommandBuffer_InputMatrix_ResultIndexMatrix_ResultValueMatrix_Handle, commandBuffer.Handle, inputMatrix.Handle, resultIndexMatrix.Handle, resultValueMatrix.Handle);
		}
	}
}

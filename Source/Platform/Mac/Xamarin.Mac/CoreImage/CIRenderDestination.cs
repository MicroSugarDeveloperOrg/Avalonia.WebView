using System;
using System.ComponentModel;
using CoreGraphics;
using CoreVideo;
using Foundation;
using IOSurface;
using Metal;
using ObjCRuntime;

namespace CoreImage;

[Register("CIRenderDestination", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class CIRenderDestination : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlphaMode = "alphaMode";

	private static readonly IntPtr selAlphaModeHandle = Selector.GetHandle("alphaMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBlendKernel = "blendKernel";

	private static readonly IntPtr selBlendKernelHandle = Selector.GetHandle("blendKernel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBlendsInDestinationColorSpace = "blendsInDestinationColorSpace";

	private static readonly IntPtr selBlendsInDestinationColorSpaceHandle = Selector.GetHandle("blendsInDestinationColorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorSpace = "colorSpace";

	private static readonly IntPtr selColorSpaceHandle = Selector.GetHandle("colorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeight = "height";

	private static readonly IntPtr selHeightHandle = Selector.GetHandle("height");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithBitmapData_Width_Height_BytesPerRow_Format_ = "initWithBitmapData:width:height:bytesPerRow:format:";

	private static readonly IntPtr selInitWithBitmapData_Width_Height_BytesPerRow_Format_Handle = Selector.GetHandle("initWithBitmapData:width:height:bytesPerRow:format:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithGLTexture_Target_Width_Height_ = "initWithGLTexture:target:width:height:";

	private static readonly IntPtr selInitWithGLTexture_Target_Width_Height_Handle = Selector.GetHandle("initWithGLTexture:target:width:height:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIOSurface_ = "initWithIOSurface:";

	private static readonly IntPtr selInitWithIOSurface_Handle = Selector.GetHandle("initWithIOSurface:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMTLTexture_CommandBuffer_ = "initWithMTLTexture:commandBuffer:";

	private static readonly IntPtr selInitWithMTLTexture_CommandBuffer_Handle = Selector.GetHandle("initWithMTLTexture:commandBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPixelBuffer_ = "initWithPixelBuffer:";

	private static readonly IntPtr selInitWithPixelBuffer_Handle = Selector.GetHandle("initWithPixelBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithWidth_Height_PixelFormat_CommandBuffer_MtlTextureProvider_ = "initWithWidth:height:pixelFormat:commandBuffer:mtlTextureProvider:";

	private static readonly IntPtr selInitWithWidth_Height_PixelFormat_CommandBuffer_MtlTextureProvider_Handle = Selector.GetHandle("initWithWidth:height:pixelFormat:commandBuffer:mtlTextureProvider:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsClamped = "isClamped";

	private static readonly IntPtr selIsClampedHandle = Selector.GetHandle("isClamped");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDithered = "isDithered";

	private static readonly IntPtr selIsDitheredHandle = Selector.GetHandle("isDithered");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFlipped = "isFlipped";

	private static readonly IntPtr selIsFlippedHandle = Selector.GetHandle("isFlipped");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlphaMode_ = "setAlphaMode:";

	private static readonly IntPtr selSetAlphaMode_Handle = Selector.GetHandle("setAlphaMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBlendKernel_ = "setBlendKernel:";

	private static readonly IntPtr selSetBlendKernel_Handle = Selector.GetHandle("setBlendKernel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBlendsInDestinationColorSpace_ = "setBlendsInDestinationColorSpace:";

	private static readonly IntPtr selSetBlendsInDestinationColorSpace_Handle = Selector.GetHandle("setBlendsInDestinationColorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClamped_ = "setClamped:";

	private static readonly IntPtr selSetClamped_Handle = Selector.GetHandle("setClamped:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColorSpace_ = "setColorSpace:";

	private static readonly IntPtr selSetColorSpace_Handle = Selector.GetHandle("setColorSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDithered_ = "setDithered:";

	private static readonly IntPtr selSetDithered_Handle = Selector.GetHandle("setDithered:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFlipped_ = "setFlipped:";

	private static readonly IntPtr selSetFlipped_Handle = Selector.GetHandle("setFlipped:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWidth = "width";

	private static readonly IntPtr selWidthHandle = Selector.GetHandle("width");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CIRenderDestination");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIRenderDestinationAlphaMode AlphaMode
	{
		[Export("alphaMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CIRenderDestinationAlphaMode)Messaging.UInt64_objc_msgSend(base.Handle, selAlphaModeHandle);
			}
			return (CIRenderDestinationAlphaMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAlphaModeHandle);
		}
		[Export("setAlphaMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetAlphaMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetAlphaMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIBlendKernel? BlendKernel
	{
		[Export("blendKernel", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSend(base.Handle, selBlendKernelHandle));
			}
			return Runtime.GetNSObject<CIBlendKernel>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBlendKernelHandle));
		}
		[Export("setBlendKernel:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBlendKernel_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBlendKernel_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool BlendsInDestinationColorSpace
	{
		[Export("blendsInDestinationColorSpace")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selBlendsInDestinationColorSpaceHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selBlendsInDestinationColorSpaceHandle);
		}
		[Export("setBlendsInDestinationColorSpace:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetBlendsInDestinationColorSpace_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBlendsInDestinationColorSpace_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Clamped
	{
		[Export("isClamped")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsClampedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsClampedHandle);
		}
		[Export("setClamped:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetClamped_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetClamped_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGColorSpace? ColorSpace
	{
		[Export("colorSpace", ArgumentSemantic.Assign)]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorSpaceHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selColorSpaceHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGColorSpace(intPtr);
		}
		[Export("setColorSpace:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColorSpace_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColorSpace_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Dithered
	{
		[Export("isDithered")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDitheredHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDitheredHandle);
		}
		[Export("setDithered:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDithered_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDithered_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Flipped
	{
		[Export("isFlipped")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFlippedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFlippedHandle);
		}
		[Export("setFlipped:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFlipped_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFlipped_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Height
	{
		[Export("height")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selHeightHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selHeightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Width
	{
		[Export("width")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selWidthHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selWidthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIRenderDestination(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CIRenderDestination(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPixelBuffer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIRenderDestination(CVPixelBuffer pixelBuffer)
		: base(NSObjectFlag.Empty)
	{
		if (pixelBuffer == null)
		{
			throw new ArgumentNullException("pixelBuffer");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPixelBuffer_Handle, pixelBuffer.Handle), "initWithPixelBuffer:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPixelBuffer_Handle, pixelBuffer.Handle), "initWithPixelBuffer:");
		}
	}

	[Export("initWithIOSurface:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIRenderDestination(global::IOSurface.IOSurface surface)
		: base(NSObjectFlag.Empty)
	{
		if (surface == null)
		{
			throw new ArgumentNullException("surface");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithIOSurface_Handle, surface.Handle), "initWithIOSurface:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithIOSurface_Handle, surface.Handle), "initWithIOSurface:");
		}
	}

	[Export("initWithMTLTexture:commandBuffer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIRenderDestination(IMTLTexture texture, IMTLCommandBuffer? commandBuffer)
		: base(NSObjectFlag.Empty)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithMTLTexture_CommandBuffer_Handle, texture.Handle, commandBuffer?.Handle ?? IntPtr.Zero), "initWithMTLTexture:commandBuffer:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithMTLTexture_CommandBuffer_Handle, texture.Handle, commandBuffer?.Handle ?? IntPtr.Zero), "initWithMTLTexture:commandBuffer:");
		}
	}

	[Export("initWithWidth:height:pixelFormat:commandBuffer:mtlTextureProvider:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe CIRenderDestination(nuint width, nuint height, MTLPixelFormat pixelFormat, IMTLCommandBuffer? commandBuffer, [BlockProxy(typeof(Trampolines.NIDFuncArity1V1))] Func<IMTLTexture> block)
		: base(NSObjectFlag.Empty)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDFuncArity1V1.Handler, block);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nuint_nuint_UInt64_IntPtr_IntPtr(base.Handle, selInitWithWidth_Height_PixelFormat_CommandBuffer_MtlTextureProvider_Handle, width, height, (ulong)pixelFormat, commandBuffer?.Handle ?? IntPtr.Zero, (IntPtr)ptr), "initWithWidth:height:pixelFormat:commandBuffer:mtlTextureProvider:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nuint_nuint_UInt64_IntPtr_IntPtr(base.SuperHandle, selInitWithWidth_Height_PixelFormat_CommandBuffer_MtlTextureProvider_Handle, width, height, (ulong)pixelFormat, commandBuffer?.Handle ?? IntPtr.Zero, (IntPtr)ptr), "initWithWidth:height:pixelFormat:commandBuffer:mtlTextureProvider:");
		}
		ptr->CleanupBlock();
	}

	[Export("initWithGLTexture:target:width:height:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIRenderDestination(uint texture, uint target, nuint width, nuint height)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt32_UInt32_nuint_nuint(base.Handle, selInitWithGLTexture_Target_Width_Height_Handle, texture, target, width, height), "initWithGLTexture:target:width:height:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt32_UInt32_nuint_nuint(base.SuperHandle, selInitWithGLTexture_Target_Width_Height_Handle, texture, target, width, height), "initWithGLTexture:target:width:height:");
		}
	}

	[Export("initWithBitmapData:width:height:bytesPerRow:format:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIRenderDestination(IntPtr data, nuint width, nuint height, nuint bytesPerRow, CIFormat format)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint_nuint_int(base.Handle, selInitWithBitmapData_Width_Height_BytesPerRow_Format_Handle, data, width, height, bytesPerRow, (int)format), "initWithBitmapData:width:height:bytesPerRow:format:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint_nuint_int(base.SuperHandle, selInitWithBitmapData_Width_Height_BytesPerRow_Format_Handle, data, width, height, bytesPerRow, (int)format), "initWithBitmapData:width:height:bytesPerRow:format:");
		}
	}
}

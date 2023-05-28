using System;
using System.ComponentModel;
using System.Threading.Tasks;
using AppKit;
using CoreGraphics;
using CoreImage;
using Foundation;
using GameplayKit;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKTexture", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class SKTexture : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCGImage = "CGImage";

	private static readonly IntPtr selCGImageHandle = Selector.GetHandle("CGImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilteringMode = "filteringMode";

	private static readonly IntPtr selFilteringModeHandle = Selector.GetHandle("filteringMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreloadTextures_WithCompletionHandler_ = "preloadTextures:withCompletionHandler:";

	private static readonly IntPtr selPreloadTextures_WithCompletionHandler_Handle = Selector.GetHandle("preloadTextures:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreloadWithCompletionHandler_ = "preloadWithCompletionHandler:";

	private static readonly IntPtr selPreloadWithCompletionHandler_Handle = Selector.GetHandle("preloadWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFilteringMode_ = "setFilteringMode:";

	private static readonly IntPtr selSetFilteringMode_Handle = Selector.GetHandle("setFilteringMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesMipmaps_ = "setUsesMipmaps:";

	private static readonly IntPtr selSetUsesMipmaps_Handle = Selector.GetHandle("setUsesMipmaps:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSize = "size";

	private static readonly IntPtr selSizeHandle = Selector.GetHandle("size");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureByApplyingCIFilter_ = "textureByApplyingCIFilter:";

	private static readonly IntPtr selTextureByApplyingCIFilter_Handle = Selector.GetHandle("textureByApplyingCIFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureByGeneratingNormalMap = "textureByGeneratingNormalMap";

	private static readonly IntPtr selTextureByGeneratingNormalMapHandle = Selector.GetHandle("textureByGeneratingNormalMap");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureByGeneratingNormalMapWithSmoothness_Contrast_ = "textureByGeneratingNormalMapWithSmoothness:contrast:";

	private static readonly IntPtr selTextureByGeneratingNormalMapWithSmoothness_Contrast_Handle = Selector.GetHandle("textureByGeneratingNormalMapWithSmoothness:contrast:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureNoiseWithSmoothness_Size_Grayscale_ = "textureNoiseWithSmoothness:size:grayscale:";

	private static readonly IntPtr selTextureNoiseWithSmoothness_Size_Grayscale_Handle = Selector.GetHandle("textureNoiseWithSmoothness:size:grayscale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureRect = "textureRect";

	private static readonly IntPtr selTextureRectHandle = Selector.GetHandle("textureRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureVectorNoiseWithSmoothness_Size_ = "textureVectorNoiseWithSmoothness:size:";

	private static readonly IntPtr selTextureVectorNoiseWithSmoothness_Size_Handle = Selector.GetHandle("textureVectorNoiseWithSmoothness:size:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureWithCGImage_ = "textureWithCGImage:";

	private static readonly IntPtr selTextureWithCGImage_Handle = Selector.GetHandle("textureWithCGImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureWithData_Size_ = "textureWithData:size:";

	private static readonly IntPtr selTextureWithData_Size_Handle = Selector.GetHandle("textureWithData:size:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureWithData_Size_Flipped_ = "textureWithData:size:flipped:";

	private static readonly IntPtr selTextureWithData_Size_Flipped_Handle = Selector.GetHandle("textureWithData:size:flipped:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureWithData_Size_RowLength_Alignment_ = "textureWithData:size:rowLength:alignment:";

	private static readonly IntPtr selTextureWithData_Size_RowLength_Alignment_Handle = Selector.GetHandle("textureWithData:size:rowLength:alignment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureWithImage_ = "textureWithImage:";

	private static readonly IntPtr selTextureWithImage_Handle = Selector.GetHandle("textureWithImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureWithImageNamed_ = "textureWithImageNamed:";

	private static readonly IntPtr selTextureWithImageNamed_Handle = Selector.GetHandle("textureWithImageNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureWithNoiseMap_ = "textureWithNoiseMap:";

	private static readonly IntPtr selTextureWithNoiseMap_Handle = Selector.GetHandle("textureWithNoiseMap:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureWithRect_InTexture_ = "textureWithRect:inTexture:";

	private static readonly IntPtr selTextureWithRect_InTexture_Handle = Selector.GetHandle("textureWithRect:inTexture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesMipmaps = "usesMipmaps";

	private static readonly IntPtr selUsesMipmapsHandle = Selector.GetHandle("usesMipmaps");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKTexture");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual CGImage CGImage
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("CGImage")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCGImageHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selCGImageHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGImage(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKTextureFilteringMode FilteringMode
	{
		[Export("filteringMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SKTextureFilteringMode)Messaging.Int64_objc_msgSend(base.Handle, selFilteringModeHandle);
			}
			return (SKTextureFilteringMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFilteringModeHandle);
		}
		[Export("setFilteringMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetFilteringMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetFilteringMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize Size
	{
		[Export("size")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect TextureRect
	{
		[Export("textureRect")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selTextureRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selTextureRectHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UsesMipmaps
	{
		[Export("usesMipmaps")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesMipmapsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesMipmapsHandle);
		}
		[Export("setUsesMipmaps:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesMipmaps_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesMipmaps_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SKTexture(NSCoder coder)
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
	protected SKTexture(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKTexture(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("textureByGeneratingNormalMap")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKTexture CreateTextureByGeneratingNormalMap()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextureByGeneratingNormalMapHandle));
		}
		return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextureByGeneratingNormalMapHandle));
	}

	[Export("textureByGeneratingNormalMapWithSmoothness:contrast:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKTexture CreateTextureByGeneratingNormalMap(nfloat smoothness, nfloat contrast)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat(base.Handle, selTextureByGeneratingNormalMapWithSmoothness_Contrast_Handle, smoothness, contrast));
		}
		return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSendSuper_nfloat_nfloat(base.SuperHandle, selTextureByGeneratingNormalMapWithSmoothness_Contrast_Handle, smoothness, contrast));
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("textureWithData:size:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTexture FromData(NSData pixelData, CGSize size)
	{
		if (pixelData == null)
		{
			throw new ArgumentNullException("pixelData");
		}
		return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSend_IntPtr_CGSize(class_ptr, selTextureWithData_Size_Handle, pixelData.Handle, size));
	}

	[Export("textureWithData:size:rowLength:alignment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTexture FromData(NSData pixelData, CGSize size, uint rowLength, uint alignment)
	{
		if (pixelData == null)
		{
			throw new ArgumentNullException("pixelData");
		}
		return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSend_IntPtr_CGSize_UInt32_UInt32(class_ptr, selTextureWithData_Size_RowLength_Alignment_Handle, pixelData.Handle, size, rowLength, alignment));
	}

	[Export("textureWithData:size:flipped:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTexture FromData(NSData pixelData, CGSize size, bool flipped)
	{
		if (pixelData == null)
		{
			throw new ArgumentNullException("pixelData");
		}
		return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSend_IntPtr_CGSize_bool(class_ptr, selTextureWithData_Size_Flipped_Handle, pixelData.Handle, size, flipped));
	}

	[Export("textureWithCGImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTexture FromImage(CGImage image)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTextureWithCGImage_Handle, image.Handle));
	}

	[Export("textureWithImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTexture FromImage(NSImage image)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTextureWithImage_Handle, image.Handle));
	}

	[Export("textureWithImageNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTexture FromImageNamed(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		SKTexture nSObject = Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTextureWithImageNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("textureWithNoiseMap:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTexture FromNoiseMap(GKNoiseMap noiseMap)
	{
		if (noiseMap == null)
		{
			throw new ArgumentNullException("noiseMap");
		}
		return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTextureWithNoiseMap_Handle, noiseMap.Handle));
	}

	[Export("textureWithRect:inTexture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTexture FromRectangle(CGRect rect, SKTexture texture)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSend_CGRect_IntPtr(class_ptr, selTextureWithRect_InTexture_Handle, rect, texture.Handle));
	}

	[Export("textureNoiseWithSmoothness:size:grayscale:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTexture FromTextureNoise(nfloat smoothness, CGSize size, bool grayscale)
	{
		return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSend_nfloat_CGSize_bool(class_ptr, selTextureNoiseWithSmoothness_Size_Grayscale_Handle, smoothness, size, grayscale));
	}

	[Export("textureVectorNoiseWithSmoothness:size:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTexture FromTextureVectorNoise(nfloat smoothness, CGSize size)
	{
		return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSend_nfloat_CGSize(class_ptr, selTextureVectorNoiseWithSmoothness_Size_Handle, smoothness, size));
	}

	[Export("preloadWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Preload([BlockProxy(typeof(Trampolines.NIDAction))] Action completion)
	{
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completion);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPreloadWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPreloadWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task PreloadAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Preload(delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Export("preloadTextures:withCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void PreloadTextures(SKTexture[] textures, [BlockProxy(typeof(Trampolines.NIDAction))] Action completion)
	{
		if (textures == null)
		{
			throw new ArgumentNullException("textures");
		}
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		NSArray nSArray = NSArray.FromNSObjects(textures);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selPreloadTextures_WithCompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		nSArray.Dispose();
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task PreloadTexturesAsync(SKTexture[] textures)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		PreloadTextures(textures, delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Export("textureByApplyingCIFilter:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKTexture TextureByApplyingCIFilter(CIFilter filter)
	{
		if (filter == null)
		{
			throw new ArgumentNullException("filter");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selTextureByApplyingCIFilter_Handle, filter.Handle));
		}
		return Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextureByApplyingCIFilter_Handle, filter.Handle));
	}
}

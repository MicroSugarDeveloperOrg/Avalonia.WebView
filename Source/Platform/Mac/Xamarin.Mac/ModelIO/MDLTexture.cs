using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace ModelIO;

[Register("MDLTexture", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLTexture : NSObject, IMDLNamed, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChannelCount = "channelCount";

	private static readonly IntPtr selChannelCountHandle = Selector.GetHandle("channelCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChannelEncoding = "channelEncoding";

	private static readonly IntPtr selChannelEncodingHandle = Selector.GetHandle("channelEncoding");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDimensions = "dimensions";

	private static readonly IntPtr selDimensionsHandle = Selector.GetHandle("dimensions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasAlphaValues = "hasAlphaValues";

	private static readonly IntPtr selHasAlphaValuesHandle = Selector.GetHandle("hasAlphaValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageFromTexture = "imageFromTexture";

	private static readonly IntPtr selImageFromTextureHandle = Selector.GetHandle("imageFromTexture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageFromTextureAtLevel_ = "imageFromTextureAtLevel:";

	private static readonly IntPtr selImageFromTextureAtLevel_Handle = Selector.GetHandle("imageFromTextureAtLevel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_ = "initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:";

	private static readonly IntPtr selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_Handle = Selector.GetHandle("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIrradianceTextureCubeWithTexture_Name_Dimensions_ = "irradianceTextureCubeWithTexture:name:dimensions:";

	private static readonly IntPtr selIrradianceTextureCubeWithTexture_Name_Dimensions_Handle = Selector.GetHandle("irradianceTextureCubeWithTexture:name:dimensions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIrradianceTextureCubeWithTexture_Name_Dimensions_Roughness_ = "irradianceTextureCubeWithTexture:name:dimensions:roughness:";

	private static readonly IntPtr selIrradianceTextureCubeWithTexture_Name_Dimensions_Roughness_Handle = Selector.GetHandle("irradianceTextureCubeWithTexture:name:dimensions:roughness:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCube = "isCube";

	private static readonly IntPtr selIsCubeHandle = Selector.GetHandle("isCube");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMipLevelCount = "mipLevelCount";

	private static readonly IntPtr selMipLevelCountHandle = Selector.GetHandle("mipLevelCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowStride = "rowStride";

	private static readonly IntPtr selRowStrideHandle = Selector.GetHandle("rowStride");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHasAlphaValues_ = "setHasAlphaValues:";

	private static readonly IntPtr selSetHasAlphaValues_Handle = Selector.GetHandle("setHasAlphaValues:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIsCube_ = "setIsCube:";

	private static readonly IntPtr selSetIsCube_Handle = Selector.GetHandle("setIsCube:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTexelDataWithBottomLeftOrigin = "texelDataWithBottomLeftOrigin";

	private static readonly IntPtr selTexelDataWithBottomLeftOriginHandle = Selector.GetHandle("texelDataWithBottomLeftOrigin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTexelDataWithBottomLeftOriginAtMipLevel_Create_ = "texelDataWithBottomLeftOriginAtMipLevel:create:";

	private static readonly IntPtr selTexelDataWithBottomLeftOriginAtMipLevel_Create_Handle = Selector.GetHandle("texelDataWithBottomLeftOriginAtMipLevel:create:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTexelDataWithTopLeftOrigin = "texelDataWithTopLeftOrigin";

	private static readonly IntPtr selTexelDataWithTopLeftOriginHandle = Selector.GetHandle("texelDataWithTopLeftOrigin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTexelDataWithTopLeftOriginAtMipLevel_Create_ = "texelDataWithTopLeftOriginAtMipLevel:create:";

	private static readonly IntPtr selTexelDataWithTopLeftOriginAtMipLevel_Create_Handle = Selector.GetHandle("texelDataWithTopLeftOriginAtMipLevel:create:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureCubeWithImagesNamed_ = "textureCubeWithImagesNamed:";

	private static readonly IntPtr selTextureCubeWithImagesNamed_Handle = Selector.GetHandle("textureCubeWithImagesNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureCubeWithImagesNamed_Bundle_ = "textureCubeWithImagesNamed:bundle:";

	private static readonly IntPtr selTextureCubeWithImagesNamed_Bundle_Handle = Selector.GetHandle("textureCubeWithImagesNamed:bundle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureNamed_ = "textureNamed:";

	private static readonly IntPtr selTextureNamed_Handle = Selector.GetHandle("textureNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureNamed_AssetResolver_ = "textureNamed:assetResolver:";

	private static readonly IntPtr selTextureNamed_AssetResolver_Handle = Selector.GetHandle("textureNamed:assetResolver:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureNamed_Bundle_ = "textureNamed:bundle:";

	private static readonly IntPtr selTextureNamed_Bundle_Handle = Selector.GetHandle("textureNamed:bundle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToURL_ = "writeToURL:";

	private static readonly IntPtr selWriteToURL_Handle = Selector.GetHandle("writeToURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToURL_Level_ = "writeToURL:level:";

	private static readonly IntPtr selWriteToURL_Level_Handle = Selector.GetHandle("writeToURL:level:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToURL_Type_ = "writeToURL:type:";

	private static readonly IntPtr selWriteToURL_Type_Handle = Selector.GetHandle("writeToURL:type:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToURL_Type_Level_ = "writeToURL:type:level:";

	private static readonly IntPtr selWriteToURL_Type_Level_Handle = Selector.GetHandle("writeToURL:type:level:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLTexture");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ChannelCount
	{
		[Export("channelCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selChannelCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selChannelCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLTextureChannelEncoding ChannelEncoding
	{
		[Export("channelEncoding")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MDLTextureChannelEncoding)Messaging.Int64_objc_msgSend(base.Handle, selChannelEncodingHandle);
			}
			return (MDLTextureChannelEncoding)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selChannelEncodingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector2i Dimensions
	{
		[Export("dimensions")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector2i_objc_msgSend(base.Handle, selDimensionsHandle);
			}
			return Messaging.xamarin_simd__Vector2i_objc_msgSendSuper(base.SuperHandle, selDimensionsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual bool HasAlphaValues
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("hasAlphaValues")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasAlphaValuesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasAlphaValuesHandle);
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("setHasAlphaValues:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasAlphaValues_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasAlphaValues_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsCube
	{
		[Export("isCube")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCubeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCubeHandle);
		}
		[Export("setIsCube:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIsCube_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIsCube_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint MipLevelCount
	{
		[Export("mipLevelCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMipLevelCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMipLevelCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
		[Export("setName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint RowStride
	{
		[Export("rowStride")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selRowStrideHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selRowStrideHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MDLTexture(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLTexture(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLTexture()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInitHandle), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitHandle), "init");
		}
	}

	[Export("initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLTexture(NSData? pixelData, bool topLeftOrigin, string? name, Vector2i dimensions, nint rowStride, nuint channelCount, MDLTextureChannelEncoding channelEncoding, bool isCube)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_bool_IntPtr_Vector2i_nint_nuint_Int64_bool(base.Handle, selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_Handle, pixelData?.Handle ?? IntPtr.Zero, topLeftOrigin, arg, dimensions, rowStride, channelCount, (long)channelEncoding, isCube), "initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_bool_IntPtr_Vector2i_nint_nuint_Int64_bool(base.SuperHandle, selInitWithData_TopLeftOrigin_Name_Dimensions_RowStride_ChannelCount_ChannelEncoding_IsCube_Handle, pixelData?.Handle ?? IntPtr.Zero, topLeftOrigin, arg, dimensions, rowStride, channelCount, (long)channelEncoding, isCube), "initWithData:topLeftOrigin:name:dimensions:rowStride:channelCount:channelEncoding:isCube:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("irradianceTextureCubeWithTexture:name:dimensions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLTexture CreateIrradianceTextureCube(MDLTexture texture, string? name, Vector2i dimensions)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		IntPtr arg = NSString.CreateNative(name);
		MDLTexture nSObject = Runtime.GetNSObject<MDLTexture>(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_IntPtr_Vector2i(class_ptr, selIrradianceTextureCubeWithTexture_Name_Dimensions_Handle, texture.Handle, arg, dimensions));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("irradianceTextureCubeWithTexture:name:dimensions:roughness:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLTexture CreateIrradianceTextureCube(MDLTexture reflectiveTexture, string? name, Vector2i dimensions, float roughness)
	{
		if (reflectiveTexture == null)
		{
			throw new ArgumentNullException("reflectiveTexture");
		}
		IntPtr arg = NSString.CreateNative(name);
		MDLTexture nSObject = Runtime.GetNSObject<MDLTexture>(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_IntPtr_Vector2i_float(class_ptr, selIrradianceTextureCubeWithTexture_Name_Dimensions_Roughness_Handle, reflectiveTexture.Handle, arg, dimensions, roughness));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("textureNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLTexture CreateTexture(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		MDLTexture nSObject = Runtime.GetNSObject<MDLTexture>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTextureNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("textureNamed:bundle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLTexture CreateTexture(string name, NSBundle? bundleOrNil)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		MDLTexture nSObject = Runtime.GetNSObject<MDLTexture>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selTextureNamed_Bundle_Handle, arg, bundleOrNil?.Handle ?? IntPtr.Zero));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("textureNamed:assetResolver:")]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLTexture? CreateTexture(string name, IMDLAssetResolver resolver)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (resolver == null)
		{
			throw new ArgumentNullException("resolver");
		}
		IntPtr arg = NSString.CreateNative(name);
		MDLTexture nSObject = Runtime.GetNSObject<MDLTexture>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selTextureNamed_AssetResolver_Handle, arg, resolver.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("textureCubeWithImagesNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLTexture CreateTextureCube(string[] imageNames)
	{
		if (imageNames == null)
		{
			throw new ArgumentNullException("imageNames");
		}
		NSArray nSArray = NSArray.FromStrings(imageNames);
		MDLTexture nSObject = Runtime.GetNSObject<MDLTexture>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTextureCubeWithImagesNamed_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("textureCubeWithImagesNamed:bundle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLTexture CreateTextureCube(string[] imageNames, NSBundle? bundleOrNil)
	{
		if (imageNames == null)
		{
			throw new ArgumentNullException("imageNames");
		}
		NSArray nSArray = NSArray.FromStrings(imageNames);
		MDLTexture nSObject = Runtime.GetNSObject<MDLTexture>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selTextureCubeWithImagesNamed_Bundle_Handle, nSArray.Handle, bundleOrNil?.Handle ?? IntPtr.Zero));
		nSArray.Dispose();
		return nSObject;
	}

	[Obsolete("Use 'CreateTexture' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLTexture FromBundle(string name)
	{
		return CreateTexture(name);
	}

	[Obsolete("Use 'CreateTexture' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLTexture FromBundle(string name, NSBundle? bundleOrNil)
	{
		return CreateTexture(name, bundleOrNil);
	}

	[Export("imageFromTexture")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGImage? GetImageFromTexture()
	{
		IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageFromTextureHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selImageFromTextureHandle));
		return (intPtr == IntPtr.Zero) ? null : new CGImage(intPtr);
	}

	[Export("imageFromTextureAtLevel:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGImage? GetImageFromTexture(nuint level)
	{
		IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selImageFromTextureAtLevel_Handle, level) : Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selImageFromTextureAtLevel_Handle, level));
		return (intPtr == IntPtr.Zero) ? null : new CGImage(intPtr);
	}

	[Export("texelDataWithBottomLeftOrigin")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? GetTexelDataWithBottomLeftOrigin()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selTexelDataWithBottomLeftOriginHandle));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTexelDataWithBottomLeftOriginHandle));
	}

	[Export("texelDataWithBottomLeftOriginAtMipLevel:create:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? GetTexelDataWithBottomLeftOrigin(nint mipLevel, bool create)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_nint_bool(base.Handle, selTexelDataWithBottomLeftOriginAtMipLevel_Create_Handle, mipLevel, create));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_nint_bool(base.SuperHandle, selTexelDataWithBottomLeftOriginAtMipLevel_Create_Handle, mipLevel, create));
	}

	[Export("texelDataWithTopLeftOrigin")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? GetTexelDataWithTopLeftOrigin()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selTexelDataWithTopLeftOriginHandle));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTexelDataWithTopLeftOriginHandle));
	}

	[Export("texelDataWithTopLeftOriginAtMipLevel:create:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? GetTexelDataWithTopLeftOrigin(nint mipLevel, bool create)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_nint_bool(base.Handle, selTexelDataWithTopLeftOriginAtMipLevel_Create_Handle, mipLevel, create));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_nint_bool(base.SuperHandle, selTexelDataWithTopLeftOriginAtMipLevel_Create_Handle, mipLevel, create));
	}

	[Export("writeToURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WriteToUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selWriteToURL_Handle, url.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selWriteToURL_Handle, url.Handle);
	}

	[Export("writeToURL:level:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WriteToUrl(NSUrl url, nuint level)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_nuint(base.Handle, selWriteToURL_Level_Handle, url.Handle, level);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selWriteToURL_Level_Handle, url.Handle, level);
	}

	[Export("writeToURL:type:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WriteToUrl(NSUrl url, string type)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWriteToURL_Type_Handle, url.Handle, arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selWriteToURL_Type_Handle, url.Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("writeToURL:type:level:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WriteToUrl(NSUrl nsurl, string type, nuint level)
	{
		if (nsurl == null)
		{
			throw new ArgumentNullException("nsurl");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_nuint(base.SuperHandle, selWriteToURL_Type_Level_Handle, nsurl.Handle, arg, level) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_nuint(base.Handle, selWriteToURL_Type_Level_Handle, nsurl.Handle, arg, level));
		NSString.ReleaseNative(arg);
		return result;
	}
}

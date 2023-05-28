using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace SpriteKit;

[Register("SKTileDefinition", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
public class SKTileDefinition : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlipHorizontally = "flipHorizontally";

	private static readonly IntPtr selFlipHorizontallyHandle = Selector.GetHandle("flipHorizontally");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlipVertically = "flipVertically";

	private static readonly IntPtr selFlipVerticallyHandle = Selector.GetHandle("flipVertically");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTexture_ = "initWithTexture:";

	private static readonly IntPtr selInitWithTexture_Handle = Selector.GetHandle("initWithTexture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTexture_NormalTexture_Size_ = "initWithTexture:normalTexture:size:";

	private static readonly IntPtr selInitWithTexture_NormalTexture_Size_Handle = Selector.GetHandle("initWithTexture:normalTexture:size:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTexture_Size_ = "initWithTexture:size:";

	private static readonly IntPtr selInitWithTexture_Size_Handle = Selector.GetHandle("initWithTexture:size:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTextures_NormalTextures_Size_TimePerFrame_ = "initWithTextures:normalTextures:size:timePerFrame:";

	private static readonly IntPtr selInitWithTextures_NormalTextures_Size_TimePerFrame_Handle = Selector.GetHandle("initWithTextures:normalTextures:size:timePerFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTextures_Size_TimePerFrame_ = "initWithTextures:size:timePerFrame:";

	private static readonly IntPtr selInitWithTextures_Size_TimePerFrame_Handle = Selector.GetHandle("initWithTextures:size:timePerFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNormalTextures = "normalTextures";

	private static readonly IntPtr selNormalTexturesHandle = Selector.GetHandle("normalTextures");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlacementWeight = "placementWeight";

	private static readonly IntPtr selPlacementWeightHandle = Selector.GetHandle("placementWeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotation = "rotation";

	private static readonly IntPtr selRotationHandle = Selector.GetHandle("rotation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFlipHorizontally_ = "setFlipHorizontally:";

	private static readonly IntPtr selSetFlipHorizontally_Handle = Selector.GetHandle("setFlipHorizontally:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFlipVertically_ = "setFlipVertically:";

	private static readonly IntPtr selSetFlipVertically_Handle = Selector.GetHandle("setFlipVertically:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNormalTextures_ = "setNormalTextures:";

	private static readonly IntPtr selSetNormalTextures_Handle = Selector.GetHandle("setNormalTextures:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPlacementWeight_ = "setPlacementWeight:";

	private static readonly IntPtr selSetPlacementWeight_Handle = Selector.GetHandle("setPlacementWeight:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRotation_ = "setRotation:";

	private static readonly IntPtr selSetRotation_Handle = Selector.GetHandle("setRotation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSize_ = "setSize:";

	private static readonly IntPtr selSetSize_Handle = Selector.GetHandle("setSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextures_ = "setTextures:";

	private static readonly IntPtr selSetTextures_Handle = Selector.GetHandle("setTextures:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimePerFrame_ = "setTimePerFrame:";

	private static readonly IntPtr selSetTimePerFrame_Handle = Selector.GetHandle("setTimePerFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserData_ = "setUserData:";

	private static readonly IntPtr selSetUserData_Handle = Selector.GetHandle("setUserData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSize = "size";

	private static readonly IntPtr selSizeHandle = Selector.GetHandle("size");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextures = "textures";

	private static readonly IntPtr selTexturesHandle = Selector.GetHandle("textures");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTileDefinitionWithTexture_ = "tileDefinitionWithTexture:";

	private static readonly IntPtr selTileDefinitionWithTexture_Handle = Selector.GetHandle("tileDefinitionWithTexture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTileDefinitionWithTexture_NormalTexture_Size_ = "tileDefinitionWithTexture:normalTexture:size:";

	private static readonly IntPtr selTileDefinitionWithTexture_NormalTexture_Size_Handle = Selector.GetHandle("tileDefinitionWithTexture:normalTexture:size:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTileDefinitionWithTexture_Size_ = "tileDefinitionWithTexture:size:";

	private static readonly IntPtr selTileDefinitionWithTexture_Size_Handle = Selector.GetHandle("tileDefinitionWithTexture:size:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTileDefinitionWithTextures_NormalTextures_Size_TimePerFrame_ = "tileDefinitionWithTextures:normalTextures:size:timePerFrame:";

	private static readonly IntPtr selTileDefinitionWithTextures_NormalTextures_Size_TimePerFrame_Handle = Selector.GetHandle("tileDefinitionWithTextures:normalTextures:size:timePerFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTileDefinitionWithTextures_Size_TimePerFrame_ = "tileDefinitionWithTextures:size:timePerFrame:";

	private static readonly IntPtr selTileDefinitionWithTextures_Size_TimePerFrame_Handle = Selector.GetHandle("tileDefinitionWithTextures:size:timePerFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimePerFrame = "timePerFrame";

	private static readonly IntPtr selTimePerFrameHandle = Selector.GetHandle("timePerFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserData = "userData";

	private static readonly IntPtr selUserDataHandle = Selector.GetHandle("userData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKTileDefinition");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool FlipHorizontally
	{
		[Export("flipHorizontally")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selFlipHorizontallyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selFlipHorizontallyHandle);
		}
		[Export("setFlipHorizontally:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFlipHorizontally_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFlipHorizontally_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool FlipVertically
	{
		[Export("flipVertically")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selFlipVerticallyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selFlipVerticallyHandle);
		}
		[Export("setFlipVertically:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFlipVertically_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFlipVertically_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Name
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
	public virtual SKTexture[] NormalTextures
	{
		[Export("normalTextures", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SKTexture>(Messaging.IntPtr_objc_msgSend(base.Handle, selNormalTexturesHandle));
			}
			return NSArray.ArrayFromHandle<SKTexture>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNormalTexturesHandle));
		}
		[Export("setNormalTextures:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNormalTextures_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNormalTextures_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint PlacementWeight
	{
		[Export("placementWeight")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selPlacementWeightHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selPlacementWeightHandle);
		}
		[Export("setPlacementWeight:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetPlacementWeight_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetPlacementWeight_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKTileDefinitionRotation Rotation
	{
		[Export("rotation", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SKTileDefinitionRotation)Messaging.UInt64_objc_msgSend(base.Handle, selRotationHandle);
			}
			return (SKTileDefinitionRotation)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selRotationHandle);
		}
		[Export("setRotation:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetRotation_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetRotation_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize Size
	{
		[Export("size", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selSizeHandle);
		}
		[Export("setSize:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKTexture[] Textures
	{
		[Export("textures", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SKTexture>(Messaging.IntPtr_objc_msgSend(base.Handle, selTexturesHandle));
			}
			return NSArray.ArrayFromHandle<SKTexture>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTexturesHandle));
		}
		[Export("setTextures:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextures_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextures_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat TimePerFrame
	{
		[Export("timePerFrame")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selTimePerFrameHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selTimePerFrameHandle);
		}
		[Export("setTimePerFrame:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetTimePerFrame_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetTimePerFrame_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMutableDictionary? UserData
	{
		[Export("userData", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMutableDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selUserDataHandle));
			}
			return Runtime.GetNSObject<NSMutableDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserDataHandle));
		}
		[Export("setUserData:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUserData_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUserData_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SKTileDefinition(NSCoder coder)
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
	protected SKTileDefinition(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKTileDefinition(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTexture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKTileDefinition(SKTexture texture)
		: base(NSObjectFlag.Empty)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithTexture_Handle, texture.Handle), "initWithTexture:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithTexture_Handle, texture.Handle), "initWithTexture:");
		}
	}

	[Export("initWithTexture:size:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKTileDefinition(SKTexture texture, CGSize size)
		: base(NSObjectFlag.Empty)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_CGSize(base.Handle, selInitWithTexture_Size_Handle, texture.Handle, size), "initWithTexture:size:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_CGSize(base.SuperHandle, selInitWithTexture_Size_Handle, texture.Handle, size), "initWithTexture:size:");
		}
	}

	[Export("initWithTexture:normalTexture:size:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKTileDefinition(SKTexture texture, SKTexture normalTexture, CGSize size)
		: base(NSObjectFlag.Empty)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		if (normalTexture == null)
		{
			throw new ArgumentNullException("normalTexture");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_CGSize(base.Handle, selInitWithTexture_NormalTexture_Size_Handle, texture.Handle, normalTexture.Handle, size), "initWithTexture:normalTexture:size:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_CGSize(base.SuperHandle, selInitWithTexture_NormalTexture_Size_Handle, texture.Handle, normalTexture.Handle, size), "initWithTexture:normalTexture:size:");
		}
	}

	[Export("initWithTextures:size:timePerFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKTileDefinition(SKTexture[] textures, CGSize size, nfloat timePerFrame)
		: base(NSObjectFlag.Empty)
	{
		if (textures == null)
		{
			throw new ArgumentNullException("textures");
		}
		NSArray nSArray = NSArray.FromNSObjects(textures);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_CGSize_nfloat(base.Handle, selInitWithTextures_Size_TimePerFrame_Handle, nSArray.Handle, size, timePerFrame), "initWithTextures:size:timePerFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_CGSize_nfloat(base.SuperHandle, selInitWithTextures_Size_TimePerFrame_Handle, nSArray.Handle, size, timePerFrame), "initWithTextures:size:timePerFrame:");
		}
		nSArray.Dispose();
	}

	[Export("initWithTextures:normalTextures:size:timePerFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKTileDefinition(SKTexture[] textures, SKTexture[] normalTextures, CGSize size, nfloat timePerFrame)
		: base(NSObjectFlag.Empty)
	{
		if (textures == null)
		{
			throw new ArgumentNullException("textures");
		}
		if (normalTextures == null)
		{
			throw new ArgumentNullException("normalTextures");
		}
		NSArray nSArray = NSArray.FromNSObjects(textures);
		NSArray nSArray2 = NSArray.FromNSObjects(normalTextures);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_CGSize_nfloat(base.Handle, selInitWithTextures_NormalTextures_Size_TimePerFrame_Handle, nSArray.Handle, nSArray2.Handle, size, timePerFrame), "initWithTextures:normalTextures:size:timePerFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_CGSize_nfloat(base.SuperHandle, selInitWithTextures_NormalTextures_Size_TimePerFrame_Handle, nSArray.Handle, nSArray2.Handle, size, timePerFrame), "initWithTextures:normalTextures:size:timePerFrame:");
		}
		nSArray.Dispose();
		nSArray2.Dispose();
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

	[Export("tileDefinitionWithTexture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTileDefinition Create(SKTexture texture)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		return Runtime.GetNSObject<SKTileDefinition>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTileDefinitionWithTexture_Handle, texture.Handle));
	}

	[Export("tileDefinitionWithTexture:size:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTileDefinition Create(SKTexture texture, CGSize size)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		return Runtime.GetNSObject<SKTileDefinition>(Messaging.IntPtr_objc_msgSend_IntPtr_CGSize(class_ptr, selTileDefinitionWithTexture_Size_Handle, texture.Handle, size));
	}

	[Export("tileDefinitionWithTexture:normalTexture:size:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTileDefinition Create(SKTexture texture, SKTexture normalTexture, CGSize size)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		if (normalTexture == null)
		{
			throw new ArgumentNullException("normalTexture");
		}
		return Runtime.GetNSObject<SKTileDefinition>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_CGSize(class_ptr, selTileDefinitionWithTexture_NormalTexture_Size_Handle, texture.Handle, normalTexture.Handle, size));
	}

	[Export("tileDefinitionWithTextures:size:timePerFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTileDefinition Create(SKTexture[] textures, CGSize size, nfloat timePerFrame)
	{
		if (textures == null)
		{
			throw new ArgumentNullException("textures");
		}
		NSArray nSArray = NSArray.FromNSObjects(textures);
		SKTileDefinition nSObject = Runtime.GetNSObject<SKTileDefinition>(Messaging.IntPtr_objc_msgSend_IntPtr_CGSize_nfloat(class_ptr, selTileDefinitionWithTextures_Size_TimePerFrame_Handle, nSArray.Handle, size, timePerFrame));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("tileDefinitionWithTextures:normalTextures:size:timePerFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTileDefinition Create(SKTexture[] textures, SKTexture[] normalTextures, CGSize size, nfloat timePerFrame)
	{
		if (textures == null)
		{
			throw new ArgumentNullException("textures");
		}
		if (normalTextures == null)
		{
			throw new ArgumentNullException("normalTextures");
		}
		NSArray nSArray = NSArray.FromNSObjects(textures);
		NSArray nSArray2 = NSArray.FromNSObjects(normalTextures);
		SKTileDefinition nSObject = Runtime.GetNSObject<SKTileDefinition>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_CGSize_nfloat(class_ptr, selTileDefinitionWithTextures_NormalTextures_Size_TimePerFrame_Handle, nSArray.Handle, nSArray2.Handle, size, timePerFrame));
		nSArray.Dispose();
		nSArray2.Dispose();
		return nSObject;
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
}

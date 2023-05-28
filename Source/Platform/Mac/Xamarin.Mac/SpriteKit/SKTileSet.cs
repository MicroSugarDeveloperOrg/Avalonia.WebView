using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKTileSet", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
public class SKTileSet : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultTileGroup = "defaultTileGroup";

	private static readonly IntPtr selDefaultTileGroupHandle = Selector.GetHandle("defaultTileGroup");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultTileSize = "defaultTileSize";

	private static readonly IntPtr selDefaultTileSizeHandle = Selector.GetHandle("defaultTileSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTileGroups_ = "initWithTileGroups:";

	private static readonly IntPtr selInitWithTileGroups_Handle = Selector.GetHandle("initWithTileGroups:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTileGroups_TileSetType_ = "initWithTileGroups:tileSetType:";

	private static readonly IntPtr selInitWithTileGroups_TileSetType_Handle = Selector.GetHandle("initWithTileGroups:tileSetType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultTileGroup_ = "setDefaultTileGroup:";

	private static readonly IntPtr selSetDefaultTileGroup_Handle = Selector.GetHandle("setDefaultTileGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultTileSize_ = "setDefaultTileSize:";

	private static readonly IntPtr selSetDefaultTileSize_Handle = Selector.GetHandle("setDefaultTileSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTileGroups_ = "setTileGroups:";

	private static readonly IntPtr selSetTileGroups_Handle = Selector.GetHandle("setTileGroups:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetType_ = "setType:";

	private static readonly IntPtr selSetType_Handle = Selector.GetHandle("setType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTileGroups = "tileGroups";

	private static readonly IntPtr selTileGroupsHandle = Selector.GetHandle("tileGroups");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTileSetFromURL_ = "tileSetFromURL:";

	private static readonly IntPtr selTileSetFromURL_Handle = Selector.GetHandle("tileSetFromURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTileSetNamed_ = "tileSetNamed:";

	private static readonly IntPtr selTileSetNamed_Handle = Selector.GetHandle("tileSetNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTileSetWithTileGroups_ = "tileSetWithTileGroups:";

	private static readonly IntPtr selTileSetWithTileGroups_Handle = Selector.GetHandle("tileSetWithTileGroups:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTileSetWithTileGroups_TileSetType_ = "tileSetWithTileGroups:tileSetType:";

	private static readonly IntPtr selTileSetWithTileGroups_TileSetType_Handle = Selector.GetHandle("tileSetWithTileGroups:tileSetType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKTileSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_DefaultTileGroup_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKTileGroup? DefaultTileGroup
	{
		[Export("defaultTileGroup", ArgumentSemantic.Assign)]
		get
		{
			SKTileGroup sKTileGroup = ((!base.IsDirectBinding) ? Runtime.GetNSObject<SKTileGroup>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultTileGroupHandle)) : Runtime.GetNSObject<SKTileGroup>(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultTileGroupHandle)));
			MarkDirty();
			__mt_DefaultTileGroup_var = sKTileGroup;
			return sKTileGroup;
		}
		[Export("setDefaultTileGroup:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDefaultTileGroup_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDefaultTileGroup_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_DefaultTileGroup_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize DefaultTileSize
	{
		[Export("defaultTileSize", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selDefaultTileSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selDefaultTileSizeHandle);
		}
		[Export("setDefaultTileSize:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetDefaultTileSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetDefaultTileSize_Handle, value);
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
	public virtual SKTileGroup[] TileGroups
	{
		[Export("tileGroups", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SKTileGroup>(Messaging.IntPtr_objc_msgSend(base.Handle, selTileGroupsHandle));
			}
			return NSArray.ArrayFromHandle<SKTileGroup>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTileGroupsHandle));
		}
		[Export("setTileGroups:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTileGroups_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTileGroups_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKTileSetType Type
	{
		[Export("type", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SKTileSetType)Messaging.UInt64_objc_msgSend(base.Handle, selTypeHandle);
			}
			return (SKTileSetType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTypeHandle);
		}
		[Export("setType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKTileSet()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SKTileSet(NSCoder coder)
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
	protected SKTileSet(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKTileSet(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTileGroups:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKTileSet(SKTileGroup[] tileGroups)
		: base(NSObjectFlag.Empty)
	{
		if (tileGroups == null)
		{
			throw new ArgumentNullException("tileGroups");
		}
		NSArray nSArray = NSArray.FromNSObjects(tileGroups);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithTileGroups_Handle, nSArray.Handle), "initWithTileGroups:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithTileGroups_Handle, nSArray.Handle), "initWithTileGroups:");
		}
		nSArray.Dispose();
	}

	[Export("initWithTileGroups:tileSetType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKTileSet(SKTileGroup[] tileGroups, SKTileSetType tileSetType)
		: base(NSObjectFlag.Empty)
	{
		if (tileGroups == null)
		{
			throw new ArgumentNullException("tileGroups");
		}
		NSArray nSArray = NSArray.FromNSObjects(tileGroups);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selInitWithTileGroups_TileSetType_Handle, nSArray.Handle, (ulong)tileSetType), "initWithTileGroups:tileSetType:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selInitWithTileGroups_TileSetType_Handle, nSArray.Handle, (ulong)tileSetType), "initWithTileGroups:tileSetType:");
		}
		nSArray.Dispose();
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

	[Export("tileSetWithTileGroups:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTileSet Create(SKTileGroup[] tileGroups)
	{
		if (tileGroups == null)
		{
			throw new ArgumentNullException("tileGroups");
		}
		NSArray nSArray = NSArray.FromNSObjects(tileGroups);
		SKTileSet nSObject = Runtime.GetNSObject<SKTileSet>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTileSetWithTileGroups_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("tileSetWithTileGroups:tileSetType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTileSet Create(SKTileGroup[] tileGroups, SKTileSetType tileSetType)
	{
		if (tileGroups == null)
		{
			throw new ArgumentNullException("tileGroups");
		}
		NSArray nSArray = NSArray.FromNSObjects(tileGroups);
		SKTileSet nSObject = Runtime.GetNSObject<SKTileSet>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(class_ptr, selTileSetWithTileGroups_TileSetType_Handle, nSArray.Handle, (ulong)tileSetType));
		nSArray.Dispose();
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

	[Export("tileSetNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTileSet? FromName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		SKTileSet nSObject = Runtime.GetNSObject<SKTileSet>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTileSetNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("tileSetFromURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTileSet? FromUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Runtime.GetNSObject<SKTileSet>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTileSetFromURL_Handle, url.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_DefaultTileGroup_var = null;
		}
	}
}

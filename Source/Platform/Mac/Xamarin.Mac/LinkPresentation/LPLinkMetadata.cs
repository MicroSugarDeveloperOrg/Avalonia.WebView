using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace LinkPresentation;

[Register("LPLinkMetadata", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class LPLinkMetadata : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURL = "URL";

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIconProvider = "iconProvider";

	private static readonly IntPtr selIconProviderHandle = Selector.GetHandle("iconProvider");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageProvider = "imageProvider";

	private static readonly IntPtr selImageProviderHandle = Selector.GetHandle("imageProvider");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOriginalURL = "originalURL";

	private static readonly IntPtr selOriginalURLHandle = Selector.GetHandle("originalURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoteVideoURL = "remoteVideoURL";

	private static readonly IntPtr selRemoteVideoURLHandle = Selector.GetHandle("remoteVideoURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIconProvider_ = "setIconProvider:";

	private static readonly IntPtr selSetIconProvider_Handle = Selector.GetHandle("setIconProvider:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetImageProvider_ = "setImageProvider:";

	private static readonly IntPtr selSetImageProvider_Handle = Selector.GetHandle("setImageProvider:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOriginalURL_ = "setOriginalURL:";

	private static readonly IntPtr selSetOriginalURL_Handle = Selector.GetHandle("setOriginalURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRemoteVideoURL_ = "setRemoteVideoURL:";

	private static readonly IntPtr selSetRemoteVideoURL_Handle = Selector.GetHandle("setRemoteVideoURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitle_ = "setTitle:";

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetURL_ = "setURL:";

	private static readonly IntPtr selSetURL_Handle = Selector.GetHandle("setURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVideoProvider_ = "setVideoProvider:";

	private static readonly IntPtr selSetVideoProvider_Handle = Selector.GetHandle("setVideoProvider:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitle = "title";

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoProvider = "videoProvider";

	private static readonly IntPtr selVideoProviderHandle = Selector.GetHandle("videoProvider");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("LPLinkMetadata");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSItemProvider? IconProvider
	{
		[Export("iconProvider", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSItemProvider>(Messaging.IntPtr_objc_msgSend(base.Handle, selIconProviderHandle));
			}
			return Runtime.GetNSObject<NSItemProvider>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIconProviderHandle));
		}
		[Export("setIconProvider:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetIconProvider_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetIconProvider_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSItemProvider? ImageProvider
	{
		[Export("imageProvider", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSItemProvider>(Messaging.IntPtr_objc_msgSend(base.Handle, selImageProviderHandle));
			}
			return Runtime.GetNSObject<NSItemProvider>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImageProviderHandle));
		}
		[Export("setImageProvider:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetImageProvider_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetImageProvider_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? OriginalUrl
	{
		[Export("originalURL", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selOriginalURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOriginalURLHandle));
		}
		[Export("setOriginalURL:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOriginalURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOriginalURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? RemoteVideoUrl
	{
		[Export("remoteVideoURL", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selRemoteVideoURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRemoteVideoURLHandle));
		}
		[Export("setRemoteVideoURL:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRemoteVideoURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRemoteVideoURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Title
	{
		[Export("title", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
		[Export("setTitle:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? Url
	{
		[Export("URL", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle));
		}
		[Export("setURL:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSItemProvider? VideoProvider
	{
		[Export("videoProvider", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSItemProvider>(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoProviderHandle));
			}
			return Runtime.GetNSObject<NSItemProvider>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoProviderHandle));
		}
		[Export("setVideoProvider:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVideoProvider_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVideoProvider_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public LPLinkMetadata()
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
	public LPLinkMetadata(NSCoder coder)
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
	protected LPLinkMetadata(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal LPLinkMetadata(IntPtr handle)
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

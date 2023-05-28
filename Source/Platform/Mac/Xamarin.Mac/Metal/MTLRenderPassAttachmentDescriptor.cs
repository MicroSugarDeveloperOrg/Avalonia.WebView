using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Register("MTLRenderPassAttachmentDescriptor", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MTLRenderPassAttachmentDescriptor : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepthPlane = "depthPlane";

	private static readonly IntPtr selDepthPlaneHandle = Selector.GetHandle("depthPlane");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLevel = "level";

	private static readonly IntPtr selLevelHandle = Selector.GetHandle("level");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadAction = "loadAction";

	private static readonly IntPtr selLoadActionHandle = Selector.GetHandle("loadAction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResolveDepthPlane = "resolveDepthPlane";

	private static readonly IntPtr selResolveDepthPlaneHandle = Selector.GetHandle("resolveDepthPlane");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResolveLevel = "resolveLevel";

	private static readonly IntPtr selResolveLevelHandle = Selector.GetHandle("resolveLevel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResolveSlice = "resolveSlice";

	private static readonly IntPtr selResolveSliceHandle = Selector.GetHandle("resolveSlice");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResolveTexture = "resolveTexture";

	private static readonly IntPtr selResolveTextureHandle = Selector.GetHandle("resolveTexture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDepthPlane_ = "setDepthPlane:";

	private static readonly IntPtr selSetDepthPlane_Handle = Selector.GetHandle("setDepthPlane:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLevel_ = "setLevel:";

	private static readonly IntPtr selSetLevel_Handle = Selector.GetHandle("setLevel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLoadAction_ = "setLoadAction:";

	private static readonly IntPtr selSetLoadAction_Handle = Selector.GetHandle("setLoadAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResolveDepthPlane_ = "setResolveDepthPlane:";

	private static readonly IntPtr selSetResolveDepthPlane_Handle = Selector.GetHandle("setResolveDepthPlane:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResolveLevel_ = "setResolveLevel:";

	private static readonly IntPtr selSetResolveLevel_Handle = Selector.GetHandle("setResolveLevel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResolveSlice_ = "setResolveSlice:";

	private static readonly IntPtr selSetResolveSlice_Handle = Selector.GetHandle("setResolveSlice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResolveTexture_ = "setResolveTexture:";

	private static readonly IntPtr selSetResolveTexture_Handle = Selector.GetHandle("setResolveTexture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSlice_ = "setSlice:";

	private static readonly IntPtr selSetSlice_Handle = Selector.GetHandle("setSlice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStoreAction_ = "setStoreAction:";

	private static readonly IntPtr selSetStoreAction_Handle = Selector.GetHandle("setStoreAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStoreActionOptions_ = "setStoreActionOptions:";

	private static readonly IntPtr selSetStoreActionOptions_Handle = Selector.GetHandle("setStoreActionOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTexture_ = "setTexture:";

	private static readonly IntPtr selSetTexture_Handle = Selector.GetHandle("setTexture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSlice = "slice";

	private static readonly IntPtr selSliceHandle = Selector.GetHandle("slice");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStoreAction = "storeAction";

	private static readonly IntPtr selStoreActionHandle = Selector.GetHandle("storeAction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStoreActionOptions = "storeActionOptions";

	private static readonly IntPtr selStoreActionOptionsHandle = Selector.GetHandle("storeActionOptions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTexture = "texture";

	private static readonly IntPtr selTextureHandle = Selector.GetHandle("texture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTLRenderPassAttachmentDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint DepthPlane
	{
		[Export("depthPlane")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selDepthPlaneHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selDepthPlaneHandle);
		}
		[Export("setDepthPlane:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetDepthPlane_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetDepthPlane_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Level
	{
		[Export("level")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selLevelHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selLevelHandle);
		}
		[Export("setLevel:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetLevel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetLevel_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLLoadAction LoadAction
	{
		[Export("loadAction")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLLoadAction)Messaging.UInt64_objc_msgSend(base.Handle, selLoadActionHandle);
			}
			return (MTLLoadAction)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLoadActionHandle);
		}
		[Export("setLoadAction:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetLoadAction_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetLoadAction_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ResolveDepthPlane
	{
		[Export("resolveDepthPlane")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selResolveDepthPlaneHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selResolveDepthPlaneHandle);
		}
		[Export("setResolveDepthPlane:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetResolveDepthPlane_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetResolveDepthPlane_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ResolveLevel
	{
		[Export("resolveLevel")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selResolveLevelHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selResolveLevelHandle);
		}
		[Export("setResolveLevel:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetResolveLevel_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetResolveLevel_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ResolveSlice
	{
		[Export("resolveSlice")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selResolveSliceHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selResolveSliceHandle);
		}
		[Export("setResolveSlice:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetResolveSlice_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetResolveSlice_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLTexture? ResolveTexture
	{
		[Export("resolveTexture", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend(base.Handle, selResolveTextureHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResolveTextureHandle), owns: false);
		}
		[Export("setResolveTexture:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetResolveTexture_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetResolveTexture_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Slice
	{
		[Export("slice")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selSliceHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selSliceHandle);
		}
		[Export("setSlice:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetSlice_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetSlice_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLStoreAction StoreAction
	{
		[Export("storeAction")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLStoreAction)Messaging.UInt64_objc_msgSend(base.Handle, selStoreActionHandle);
			}
			return (MTLStoreAction)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selStoreActionHandle);
		}
		[Export("setStoreAction:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetStoreAction_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetStoreAction_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual MTLStoreActionOptions StoreActionOptions
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("storeActionOptions", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLStoreActionOptions)Messaging.UInt64_objc_msgSend(base.Handle, selStoreActionOptionsHandle);
			}
			return (MTLStoreActionOptions)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selStoreActionOptionsHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("setStoreActionOptions:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetStoreActionOptions_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetStoreActionOptions_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLTexture? Texture
	{
		[Export("texture", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextureHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextureHandle), owns: false);
		}
		[Export("setTexture:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTexture_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTexture_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MTLRenderPassAttachmentDescriptor()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MTLRenderPassAttachmentDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTLRenderPassAttachmentDescriptor(IntPtr handle)
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
}

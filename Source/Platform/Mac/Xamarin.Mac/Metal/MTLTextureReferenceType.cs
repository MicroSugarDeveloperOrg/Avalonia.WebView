using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Register("MTLTextureReferenceType", true)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class MTLTextureReferenceType : MTLType
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccess = "access";

	private static readonly IntPtr selAccessHandle = Selector.GetHandle("access");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDepthTexture = "isDepthTexture";

	private static readonly IntPtr selIsDepthTextureHandle = Selector.GetHandle("isDepthTexture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureDataType = "textureDataType";

	private static readonly IntPtr selTextureDataTypeHandle = Selector.GetHandle("textureDataType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureType = "textureType";

	private static readonly IntPtr selTextureTypeHandle = Selector.GetHandle("textureType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTLTextureReferenceType");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLArgumentAccess Access
	{
		[Export("access")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLArgumentAccess)Messaging.UInt64_objc_msgSend(base.Handle, selAccessHandle);
			}
			return (MTLArgumentAccess)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAccessHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsDepthTexture
	{
		[Export("isDepthTexture")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDepthTextureHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDepthTextureHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLDataType TextureDataType
	{
		[Export("textureDataType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLDataType)Messaging.UInt64_objc_msgSend(base.Handle, selTextureDataTypeHandle);
			}
			return (MTLDataType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTextureDataTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLTextureType TextureType
	{
		[Export("textureType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLTextureType)Messaging.UInt64_objc_msgSend(base.Handle, selTextureTypeHandle);
			}
			return (MTLTextureType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTextureTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MTLTextureReferenceType()
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
	protected MTLTextureReferenceType(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTLTextureReferenceType(IntPtr handle)
		: base(handle)
	{
	}
}

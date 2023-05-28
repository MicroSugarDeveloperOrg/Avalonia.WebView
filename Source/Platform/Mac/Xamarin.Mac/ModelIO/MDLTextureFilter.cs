using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

[Register("MDLTextureFilter", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLTextureFilter : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMagFilter = "magFilter";

	private static readonly IntPtr selMagFilterHandle = Selector.GetHandle("magFilter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinFilter = "minFilter";

	private static readonly IntPtr selMinFilterHandle = Selector.GetHandle("minFilter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMipFilter = "mipFilter";

	private static readonly IntPtr selMipFilterHandle = Selector.GetHandle("mipFilter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRWrapMode = "rWrapMode";

	private static readonly IntPtr selRWrapModeHandle = Selector.GetHandle("rWrapMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSWrapMode = "sWrapMode";

	private static readonly IntPtr selSWrapModeHandle = Selector.GetHandle("sWrapMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMagFilter_ = "setMagFilter:";

	private static readonly IntPtr selSetMagFilter_Handle = Selector.GetHandle("setMagFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinFilter_ = "setMinFilter:";

	private static readonly IntPtr selSetMinFilter_Handle = Selector.GetHandle("setMinFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMipFilter_ = "setMipFilter:";

	private static readonly IntPtr selSetMipFilter_Handle = Selector.GetHandle("setMipFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRWrapMode_ = "setRWrapMode:";

	private static readonly IntPtr selSetRWrapMode_Handle = Selector.GetHandle("setRWrapMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSWrapMode_ = "setSWrapMode:";

	private static readonly IntPtr selSetSWrapMode_Handle = Selector.GetHandle("setSWrapMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTWrapMode_ = "setTWrapMode:";

	private static readonly IntPtr selSetTWrapMode_Handle = Selector.GetHandle("setTWrapMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTWrapMode = "tWrapMode";

	private static readonly IntPtr selTWrapModeHandle = Selector.GetHandle("tWrapMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLTextureFilter");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialTextureFilterMode MagFilter
	{
		[Export("magFilter", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MDLMaterialTextureFilterMode)Messaging.UInt64_objc_msgSend(base.Handle, selMagFilterHandle);
			}
			return (MDLMaterialTextureFilterMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMagFilterHandle);
		}
		[Export("setMagFilter:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetMagFilter_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetMagFilter_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialTextureFilterMode MinFilter
	{
		[Export("minFilter", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MDLMaterialTextureFilterMode)Messaging.UInt64_objc_msgSend(base.Handle, selMinFilterHandle);
			}
			return (MDLMaterialTextureFilterMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMinFilterHandle);
		}
		[Export("setMinFilter:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetMinFilter_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetMinFilter_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialMipMapFilterMode MipFilter
	{
		[Export("mipFilter", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MDLMaterialMipMapFilterMode)Messaging.UInt64_objc_msgSend(base.Handle, selMipFilterHandle);
			}
			return (MDLMaterialMipMapFilterMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMipFilterHandle);
		}
		[Export("setMipFilter:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetMipFilter_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetMipFilter_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialTextureWrapMode RWrapMode
	{
		[Export("rWrapMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MDLMaterialTextureWrapMode)Messaging.UInt64_objc_msgSend(base.Handle, selRWrapModeHandle);
			}
			return (MDLMaterialTextureWrapMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selRWrapModeHandle);
		}
		[Export("setRWrapMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetRWrapMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetRWrapMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialTextureWrapMode SWrapMode
	{
		[Export("sWrapMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MDLMaterialTextureWrapMode)Messaging.UInt64_objc_msgSend(base.Handle, selSWrapModeHandle);
			}
			return (MDLMaterialTextureWrapMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSWrapModeHandle);
		}
		[Export("setSWrapMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetSWrapMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetSWrapMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMaterialTextureWrapMode TWrapMode
	{
		[Export("tWrapMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MDLMaterialTextureWrapMode)Messaging.UInt64_objc_msgSend(base.Handle, selTWrapModeHandle);
			}
			return (MDLMaterialTextureWrapMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTWrapModeHandle);
		}
		[Export("setTWrapMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTWrapMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTWrapMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLTextureFilter()
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
	protected MDLTextureFilter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLTextureFilter(IntPtr handle)
		: base(handle)
	{
	}
}

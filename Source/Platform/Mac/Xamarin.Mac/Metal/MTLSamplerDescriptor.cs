using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Register("MTLSamplerDescriptor", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MTLSamplerDescriptor : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBorderColor = "borderColor";

	private static readonly IntPtr selBorderColorHandle = Selector.GetHandle("borderColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompareFunction = "compareFunction";

	private static readonly IntPtr selCompareFunctionHandle = Selector.GetHandle("compareFunction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabel = "label";

	private static readonly IntPtr selLabelHandle = Selector.GetHandle("label");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLodMaxClamp = "lodMaxClamp";

	private static readonly IntPtr selLodMaxClampHandle = Selector.GetHandle("lodMaxClamp");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLodMinClamp = "lodMinClamp";

	private static readonly IntPtr selLodMinClampHandle = Selector.GetHandle("lodMinClamp");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMagFilter = "magFilter";

	private static readonly IntPtr selMagFilterHandle = Selector.GetHandle("magFilter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxAnisotropy = "maxAnisotropy";

	private static readonly IntPtr selMaxAnisotropyHandle = Selector.GetHandle("maxAnisotropy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinFilter = "minFilter";

	private static readonly IntPtr selMinFilterHandle = Selector.GetHandle("minFilter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMipFilter = "mipFilter";

	private static readonly IntPtr selMipFilterHandle = Selector.GetHandle("mipFilter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNormalizedCoordinates = "normalizedCoordinates";

	private static readonly IntPtr selNormalizedCoordinatesHandle = Selector.GetHandle("normalizedCoordinates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRAddressMode = "rAddressMode";

	private static readonly IntPtr selRAddressModeHandle = Selector.GetHandle("rAddressMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSAddressMode = "sAddressMode";

	private static readonly IntPtr selSAddressModeHandle = Selector.GetHandle("sAddressMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBorderColor_ = "setBorderColor:";

	private static readonly IntPtr selSetBorderColor_Handle = Selector.GetHandle("setBorderColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCompareFunction_ = "setCompareFunction:";

	private static readonly IntPtr selSetCompareFunction_Handle = Selector.GetHandle("setCompareFunction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLabel_ = "setLabel:";

	private static readonly IntPtr selSetLabel_Handle = Selector.GetHandle("setLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLodMaxClamp_ = "setLodMaxClamp:";

	private static readonly IntPtr selSetLodMaxClamp_Handle = Selector.GetHandle("setLodMaxClamp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLodMinClamp_ = "setLodMinClamp:";

	private static readonly IntPtr selSetLodMinClamp_Handle = Selector.GetHandle("setLodMinClamp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMagFilter_ = "setMagFilter:";

	private static readonly IntPtr selSetMagFilter_Handle = Selector.GetHandle("setMagFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxAnisotropy_ = "setMaxAnisotropy:";

	private static readonly IntPtr selSetMaxAnisotropy_Handle = Selector.GetHandle("setMaxAnisotropy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinFilter_ = "setMinFilter:";

	private static readonly IntPtr selSetMinFilter_Handle = Selector.GetHandle("setMinFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMipFilter_ = "setMipFilter:";

	private static readonly IntPtr selSetMipFilter_Handle = Selector.GetHandle("setMipFilter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNormalizedCoordinates_ = "setNormalizedCoordinates:";

	private static readonly IntPtr selSetNormalizedCoordinates_Handle = Selector.GetHandle("setNormalizedCoordinates:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRAddressMode_ = "setRAddressMode:";

	private static readonly IntPtr selSetRAddressMode_Handle = Selector.GetHandle("setRAddressMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSAddressMode_ = "setSAddressMode:";

	private static readonly IntPtr selSetSAddressMode_Handle = Selector.GetHandle("setSAddressMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSupportArgumentBuffers_ = "setSupportArgumentBuffers:";

	private static readonly IntPtr selSetSupportArgumentBuffers_Handle = Selector.GetHandle("setSupportArgumentBuffers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTAddressMode_ = "setTAddressMode:";

	private static readonly IntPtr selSetTAddressMode_Handle = Selector.GetHandle("setTAddressMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportArgumentBuffers = "supportArgumentBuffers";

	private static readonly IntPtr selSupportArgumentBuffersHandle = Selector.GetHandle("supportArgumentBuffers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTAddressMode = "tAddressMode";

	private static readonly IntPtr selTAddressModeHandle = Selector.GetHandle("tAddressMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTLSamplerDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual MTLSamplerBorderColor BorderColor
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("borderColor", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLSamplerBorderColor)Messaging.UInt64_objc_msgSend(base.Handle, selBorderColorHandle);
			}
			return (MTLSamplerBorderColor)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selBorderColorHandle);
		}
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setBorderColor:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetBorderColor_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetBorderColor_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public virtual MTLCompareFunction CompareFunction
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("compareFunction")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLCompareFunction)Messaging.UInt64_objc_msgSend(base.Handle, selCompareFunctionHandle);
			}
			return (MTLCompareFunction)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCompareFunctionHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("setCompareFunction:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetCompareFunction_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetCompareFunction_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Label
	{
		[Export("label")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLabelHandle));
		}
		[Export("setLabel:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLabel_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float LodMaxClamp
	{
		[Export("lodMaxClamp")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selLodMaxClampHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selLodMaxClampHandle);
		}
		[Export("setLodMaxClamp:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetLodMaxClamp_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetLodMaxClamp_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float LodMinClamp
	{
		[Export("lodMinClamp")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selLodMinClampHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selLodMinClampHandle);
		}
		[Export("setLodMinClamp:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetLodMinClamp_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetLodMinClamp_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLSamplerMinMagFilter MagFilter
	{
		[Export("magFilter", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLSamplerMinMagFilter)Messaging.UInt64_objc_msgSend(base.Handle, selMagFilterHandle);
			}
			return (MTLSamplerMinMagFilter)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMagFilterHandle);
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
	public virtual nuint MaxAnisotropy
	{
		[Export("maxAnisotropy")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMaxAnisotropyHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMaxAnisotropyHandle);
		}
		[Export("setMaxAnisotropy:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetMaxAnisotropy_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetMaxAnisotropy_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLSamplerMinMagFilter MinFilter
	{
		[Export("minFilter", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLSamplerMinMagFilter)Messaging.UInt64_objc_msgSend(base.Handle, selMinFilterHandle);
			}
			return (MTLSamplerMinMagFilter)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMinFilterHandle);
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
	public virtual MTLSamplerMipFilter MipFilter
	{
		[Export("mipFilter", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLSamplerMipFilter)Messaging.UInt64_objc_msgSend(base.Handle, selMipFilterHandle);
			}
			return (MTLSamplerMipFilter)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selMipFilterHandle);
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
	public virtual bool NormalizedCoordinates
	{
		[Export("normalizedCoordinates")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selNormalizedCoordinatesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selNormalizedCoordinatesHandle);
		}
		[Export("setNormalizedCoordinates:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetNormalizedCoordinates_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetNormalizedCoordinates_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLSamplerAddressMode RAddressMode
	{
		[Export("rAddressMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLSamplerAddressMode)Messaging.UInt64_objc_msgSend(base.Handle, selRAddressModeHandle);
			}
			return (MTLSamplerAddressMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selRAddressModeHandle);
		}
		[Export("setRAddressMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetRAddressMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetRAddressMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLSamplerAddressMode SAddressMode
	{
		[Export("sAddressMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLSamplerAddressMode)Messaging.UInt64_objc_msgSend(base.Handle, selSAddressModeHandle);
			}
			return (MTLSamplerAddressMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSAddressModeHandle);
		}
		[Export("setSAddressMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetSAddressMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetSAddressMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual bool SupportArgumentBuffers
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("supportArgumentBuffers")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportArgumentBuffersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportArgumentBuffersHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("setSupportArgumentBuffers:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSupportArgumentBuffers_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSupportArgumentBuffers_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLSamplerAddressMode TAddressMode
	{
		[Export("tAddressMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLSamplerAddressMode)Messaging.UInt64_objc_msgSend(base.Handle, selTAddressModeHandle);
			}
			return (MTLSamplerAddressMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTAddressModeHandle);
		}
		[Export("setTAddressMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTAddressMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTAddressMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MTLSamplerDescriptor()
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
	protected MTLSamplerDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTLSamplerDescriptor(IntPtr handle)
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

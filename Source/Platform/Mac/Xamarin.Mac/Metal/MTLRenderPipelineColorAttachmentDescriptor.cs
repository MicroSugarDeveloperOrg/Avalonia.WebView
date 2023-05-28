using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Register("MTLRenderPipelineColorAttachmentDescriptor", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MTLRenderPipelineColorAttachmentDescriptor : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlphaBlendOperation = "alphaBlendOperation";

	private static readonly IntPtr selAlphaBlendOperationHandle = Selector.GetHandle("alphaBlendOperation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationAlphaBlendFactor = "destinationAlphaBlendFactor";

	private static readonly IntPtr selDestinationAlphaBlendFactorHandle = Selector.GetHandle("destinationAlphaBlendFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestinationRGBBlendFactor = "destinationRGBBlendFactor";

	private static readonly IntPtr selDestinationRGBBlendFactorHandle = Selector.GetHandle("destinationRGBBlendFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsBlendingEnabled = "isBlendingEnabled";

	private static readonly IntPtr selIsBlendingEnabledHandle = Selector.GetHandle("isBlendingEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelFormat = "pixelFormat";

	private static readonly IntPtr selPixelFormatHandle = Selector.GetHandle("pixelFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRgbBlendOperation = "rgbBlendOperation";

	private static readonly IntPtr selRgbBlendOperationHandle = Selector.GetHandle("rgbBlendOperation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlphaBlendOperation_ = "setAlphaBlendOperation:";

	private static readonly IntPtr selSetAlphaBlendOperation_Handle = Selector.GetHandle("setAlphaBlendOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBlendingEnabled_ = "setBlendingEnabled:";

	private static readonly IntPtr selSetBlendingEnabled_Handle = Selector.GetHandle("setBlendingEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDestinationAlphaBlendFactor_ = "setDestinationAlphaBlendFactor:";

	private static readonly IntPtr selSetDestinationAlphaBlendFactor_Handle = Selector.GetHandle("setDestinationAlphaBlendFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDestinationRGBBlendFactor_ = "setDestinationRGBBlendFactor:";

	private static readonly IntPtr selSetDestinationRGBBlendFactor_Handle = Selector.GetHandle("setDestinationRGBBlendFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPixelFormat_ = "setPixelFormat:";

	private static readonly IntPtr selSetPixelFormat_Handle = Selector.GetHandle("setPixelFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRgbBlendOperation_ = "setRgbBlendOperation:";

	private static readonly IntPtr selSetRgbBlendOperation_Handle = Selector.GetHandle("setRgbBlendOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSourceAlphaBlendFactor_ = "setSourceAlphaBlendFactor:";

	private static readonly IntPtr selSetSourceAlphaBlendFactor_Handle = Selector.GetHandle("setSourceAlphaBlendFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSourceRGBBlendFactor_ = "setSourceRGBBlendFactor:";

	private static readonly IntPtr selSetSourceRGBBlendFactor_Handle = Selector.GetHandle("setSourceRGBBlendFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWriteMask_ = "setWriteMask:";

	private static readonly IntPtr selSetWriteMask_Handle = Selector.GetHandle("setWriteMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceAlphaBlendFactor = "sourceAlphaBlendFactor";

	private static readonly IntPtr selSourceAlphaBlendFactorHandle = Selector.GetHandle("sourceAlphaBlendFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceRGBBlendFactor = "sourceRGBBlendFactor";

	private static readonly IntPtr selSourceRGBBlendFactorHandle = Selector.GetHandle("sourceRGBBlendFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteMask = "writeMask";

	private static readonly IntPtr selWriteMaskHandle = Selector.GetHandle("writeMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTLRenderPipelineColorAttachmentDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLBlendOperation AlphaBlendOperation
	{
		[Export("alphaBlendOperation", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLBlendOperation)Messaging.UInt64_objc_msgSend(base.Handle, selAlphaBlendOperationHandle);
			}
			return (MTLBlendOperation)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAlphaBlendOperationHandle);
		}
		[Export("setAlphaBlendOperation:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetAlphaBlendOperation_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetAlphaBlendOperation_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool BlendingEnabled
	{
		[Export("isBlendingEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsBlendingEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsBlendingEnabledHandle);
		}
		[Export("setBlendingEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetBlendingEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBlendingEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLBlendFactor DestinationAlphaBlendFactor
	{
		[Export("destinationAlphaBlendFactor", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLBlendFactor)Messaging.UInt64_objc_msgSend(base.Handle, selDestinationAlphaBlendFactorHandle);
			}
			return (MTLBlendFactor)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDestinationAlphaBlendFactorHandle);
		}
		[Export("setDestinationAlphaBlendFactor:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDestinationAlphaBlendFactor_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDestinationAlphaBlendFactor_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLBlendFactor DestinationRgbBlendFactor
	{
		[Export("destinationRGBBlendFactor", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLBlendFactor)Messaging.UInt64_objc_msgSend(base.Handle, selDestinationRGBBlendFactorHandle);
			}
			return (MTLBlendFactor)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDestinationRGBBlendFactorHandle);
		}
		[Export("setDestinationRGBBlendFactor:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDestinationRGBBlendFactor_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDestinationRGBBlendFactor_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLPixelFormat PixelFormat
	{
		[Export("pixelFormat", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLPixelFormat)Messaging.UInt64_objc_msgSend(base.Handle, selPixelFormatHandle);
			}
			return (MTLPixelFormat)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPixelFormatHandle);
		}
		[Export("setPixelFormat:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetPixelFormat_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetPixelFormat_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLBlendOperation RgbBlendOperation
	{
		[Export("rgbBlendOperation", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLBlendOperation)Messaging.UInt64_objc_msgSend(base.Handle, selRgbBlendOperationHandle);
			}
			return (MTLBlendOperation)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selRgbBlendOperationHandle);
		}
		[Export("setRgbBlendOperation:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetRgbBlendOperation_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetRgbBlendOperation_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLBlendFactor SourceAlphaBlendFactor
	{
		[Export("sourceAlphaBlendFactor", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLBlendFactor)Messaging.UInt64_objc_msgSend(base.Handle, selSourceAlphaBlendFactorHandle);
			}
			return (MTLBlendFactor)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSourceAlphaBlendFactorHandle);
		}
		[Export("setSourceAlphaBlendFactor:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetSourceAlphaBlendFactor_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetSourceAlphaBlendFactor_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLBlendFactor SourceRgbBlendFactor
	{
		[Export("sourceRGBBlendFactor", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLBlendFactor)Messaging.UInt64_objc_msgSend(base.Handle, selSourceRGBBlendFactorHandle);
			}
			return (MTLBlendFactor)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSourceRGBBlendFactorHandle);
		}
		[Export("setSourceRGBBlendFactor:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetSourceRGBBlendFactor_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetSourceRGBBlendFactor_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLColorWriteMask WriteMask
	{
		[Export("writeMask", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLColorWriteMask)Messaging.UInt64_objc_msgSend(base.Handle, selWriteMaskHandle);
			}
			return (MTLColorWriteMask)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selWriteMaskHandle);
		}
		[Export("setWriteMask:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetWriteMask_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetWriteMask_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MTLRenderPipelineColorAttachmentDescriptor()
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
	protected MTLRenderPipelineColorAttachmentDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTLRenderPipelineColorAttachmentDescriptor(IntPtr handle)
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

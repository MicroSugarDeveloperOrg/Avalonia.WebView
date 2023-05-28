using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Register("MTLStencilDescriptor", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MTLStencilDescriptor : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepthFailureOperation = "depthFailureOperation";

	private static readonly IntPtr selDepthFailureOperationHandle = Selector.GetHandle("depthFailureOperation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepthStencilPassOperation = "depthStencilPassOperation";

	private static readonly IntPtr selDepthStencilPassOperationHandle = Selector.GetHandle("depthStencilPassOperation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadMask = "readMask";

	private static readonly IntPtr selReadMaskHandle = Selector.GetHandle("readMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDepthFailureOperation_ = "setDepthFailureOperation:";

	private static readonly IntPtr selSetDepthFailureOperation_Handle = Selector.GetHandle("setDepthFailureOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDepthStencilPassOperation_ = "setDepthStencilPassOperation:";

	private static readonly IntPtr selSetDepthStencilPassOperation_Handle = Selector.GetHandle("setDepthStencilPassOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReadMask_ = "setReadMask:";

	private static readonly IntPtr selSetReadMask_Handle = Selector.GetHandle("setReadMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStencilCompareFunction_ = "setStencilCompareFunction:";

	private static readonly IntPtr selSetStencilCompareFunction_Handle = Selector.GetHandle("setStencilCompareFunction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStencilFailureOperation_ = "setStencilFailureOperation:";

	private static readonly IntPtr selSetStencilFailureOperation_Handle = Selector.GetHandle("setStencilFailureOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWriteMask_ = "setWriteMask:";

	private static readonly IntPtr selSetWriteMask_Handle = Selector.GetHandle("setWriteMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStencilCompareFunction = "stencilCompareFunction";

	private static readonly IntPtr selStencilCompareFunctionHandle = Selector.GetHandle("stencilCompareFunction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStencilFailureOperation = "stencilFailureOperation";

	private static readonly IntPtr selStencilFailureOperationHandle = Selector.GetHandle("stencilFailureOperation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteMask = "writeMask";

	private static readonly IntPtr selWriteMaskHandle = Selector.GetHandle("writeMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTLStencilDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLStencilOperation DepthFailureOperation
	{
		[Export("depthFailureOperation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLStencilOperation)Messaging.UInt64_objc_msgSend(base.Handle, selDepthFailureOperationHandle);
			}
			return (MTLStencilOperation)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDepthFailureOperationHandle);
		}
		[Export("setDepthFailureOperation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDepthFailureOperation_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDepthFailureOperation_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLStencilOperation DepthStencilPassOperation
	{
		[Export("depthStencilPassOperation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLStencilOperation)Messaging.UInt64_objc_msgSend(base.Handle, selDepthStencilPassOperationHandle);
			}
			return (MTLStencilOperation)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDepthStencilPassOperationHandle);
		}
		[Export("setDepthStencilPassOperation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDepthStencilPassOperation_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDepthStencilPassOperation_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint ReadMask
	{
		[Export("readMask")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selReadMaskHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selReadMaskHandle);
		}
		[Export("setReadMask:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetReadMask_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetReadMask_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLCompareFunction StencilCompareFunction
	{
		[Export("stencilCompareFunction")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLCompareFunction)Messaging.UInt64_objc_msgSend(base.Handle, selStencilCompareFunctionHandle);
			}
			return (MTLCompareFunction)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selStencilCompareFunctionHandle);
		}
		[Export("setStencilCompareFunction:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetStencilCompareFunction_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetStencilCompareFunction_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLStencilOperation StencilFailureOperation
	{
		[Export("stencilFailureOperation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLStencilOperation)Messaging.UInt64_objc_msgSend(base.Handle, selStencilFailureOperationHandle);
			}
			return (MTLStencilOperation)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selStencilFailureOperationHandle);
		}
		[Export("setStencilFailureOperation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetStencilFailureOperation_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetStencilFailureOperation_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint WriteMask
	{
		[Export("writeMask")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selWriteMaskHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selWriteMaskHandle);
		}
		[Export("setWriteMask:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetWriteMask_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetWriteMask_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MTLStencilDescriptor()
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
	protected MTLStencilDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTLStencilDescriptor(IntPtr handle)
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

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Register("MTLStageInputOutputDescriptor", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class MTLStageInputOutputDescriptor : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributes = "attributes";

	private static readonly IntPtr selAttributesHandle = Selector.GetHandle("attributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexBufferIndex = "indexBufferIndex";

	private static readonly IntPtr selIndexBufferIndexHandle = Selector.GetHandle("indexBufferIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexType = "indexType";

	private static readonly IntPtr selIndexTypeHandle = Selector.GetHandle("indexType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayouts = "layouts";

	private static readonly IntPtr selLayoutsHandle = Selector.GetHandle("layouts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReset = "reset";

	private static readonly IntPtr selResetHandle = Selector.GetHandle("reset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIndexBufferIndex_ = "setIndexBufferIndex:";

	private static readonly IntPtr selSetIndexBufferIndex_Handle = Selector.GetHandle("setIndexBufferIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIndexType_ = "setIndexType:";

	private static readonly IntPtr selSetIndexType_Handle = Selector.GetHandle("setIndexType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStageInputOutputDescriptor = "stageInputOutputDescriptor";

	private static readonly IntPtr selStageInputOutputDescriptorHandle = Selector.GetHandle("stageInputOutputDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTLStageInputOutputDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLAttributeDescriptorArray Attributes
	{
		[Export("attributes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MTLAttributeDescriptorArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributesHandle));
			}
			return Runtime.GetNSObject<MTLAttributeDescriptorArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint IndexBufferIndex
	{
		[Export("indexBufferIndex")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selIndexBufferIndexHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selIndexBufferIndexHandle);
		}
		[Export("setIndexBufferIndex:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetIndexBufferIndex_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetIndexBufferIndex_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLIndexType IndexType
	{
		[Export("indexType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLIndexType)Messaging.UInt64_objc_msgSend(base.Handle, selIndexTypeHandle);
			}
			return (MTLIndexType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selIndexTypeHandle);
		}
		[Export("setIndexType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetIndexType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetIndexType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLBufferLayoutDescriptorArray Layouts
	{
		[Export("layouts")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MTLBufferLayoutDescriptorArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selLayoutsHandle));
			}
			return Runtime.GetNSObject<MTLBufferLayoutDescriptorArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLayoutsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MTLStageInputOutputDescriptor()
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
	protected MTLStageInputOutputDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTLStageInputOutputDescriptor(IntPtr handle)
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

	[Export("stageInputOutputDescriptor")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLStageInputOutputDescriptor Create()
	{
		return Runtime.GetNSObject<MTLStageInputOutputDescriptor>(Messaging.IntPtr_objc_msgSend(class_ptr, selStageInputOutputDescriptorHandle));
	}

	[Export("reset")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Reset()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetHandle);
		}
	}
}

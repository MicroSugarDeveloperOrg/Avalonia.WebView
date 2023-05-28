using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Register("MTLPointerType", true)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class MTLPointerType : MTLType
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccess = "access";

	private static readonly IntPtr selAccessHandle = Selector.GetHandle("access");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignment = "alignment";

	private static readonly IntPtr selAlignmentHandle = Selector.GetHandle("alignment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataSize = "dataSize";

	private static readonly IntPtr selDataSizeHandle = Selector.GetHandle("dataSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementArrayType = "elementArrayType";

	private static readonly IntPtr selElementArrayTypeHandle = Selector.GetHandle("elementArrayType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementIsArgumentBuffer = "elementIsArgumentBuffer";

	private static readonly IntPtr selElementIsArgumentBufferHandle = Selector.GetHandle("elementIsArgumentBuffer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementStructType = "elementStructType";

	private static readonly IntPtr selElementStructTypeHandle = Selector.GetHandle("elementStructType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementType = "elementType";

	private static readonly IntPtr selElementTypeHandle = Selector.GetHandle("elementType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTLPointerType");

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
	public virtual nuint Alignment
	{
		[Export("alignment")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selAlignmentHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selAlignmentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint DataSize
	{
		[Export("dataSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selDataSizeHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selDataSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLArrayType? ElementArrayType
	{
		[Export("elementArrayType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MTLArrayType>(Messaging.IntPtr_objc_msgSend(base.Handle, selElementArrayTypeHandle));
			}
			return Runtime.GetNSObject<MTLArrayType>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selElementArrayTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ElementIsArgumentBuffer
	{
		[Export("elementIsArgumentBuffer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selElementIsArgumentBufferHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selElementIsArgumentBufferHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLStructType? ElementStructType
	{
		[Export("elementStructType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MTLStructType>(Messaging.IntPtr_objc_msgSend(base.Handle, selElementStructTypeHandle));
			}
			return Runtime.GetNSObject<MTLStructType>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selElementStructTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLDataType ElementType
	{
		[Export("elementType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLDataType)Messaging.UInt64_objc_msgSend(base.Handle, selElementTypeHandle);
			}
			return (MTLDataType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selElementTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MTLPointerType()
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
	protected MTLPointerType(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTLPointerType(IntPtr handle)
		: base(handle)
	{
	}
}

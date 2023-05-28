using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Register("MTLStructMember", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MTLStructMember : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArgumentIndex = "argumentIndex";

	private static readonly IntPtr selArgumentIndexHandle = Selector.GetHandle("argumentIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArrayType = "arrayType";

	private static readonly IntPtr selArrayTypeHandle = Selector.GetHandle("arrayType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataType = "dataType";

	private static readonly IntPtr selDataTypeHandle = Selector.GetHandle("dataType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOffset = "offset";

	private static readonly IntPtr selOffsetHandle = Selector.GetHandle("offset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPointerType = "pointerType";

	private static readonly IntPtr selPointerTypeHandle = Selector.GetHandle("pointerType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStructType = "structType";

	private static readonly IntPtr selStructTypeHandle = Selector.GetHandle("structType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureReferenceType = "textureReferenceType";

	private static readonly IntPtr selTextureReferenceTypeHandle = Selector.GetHandle("textureReferenceType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTLStructMember");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual nuint ArgumentIndex
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("argumentIndex")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selArgumentIndexHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selArgumentIndexHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLDataType DataType
	{
		[Export("dataType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLDataType)Messaging.UInt64_objc_msgSend(base.Handle, selDataTypeHandle);
			}
			return (MTLDataType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDataTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Name
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Offset
	{
		[Export("offset")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selOffsetHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selOffsetHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual MTLPointerType? PointerType
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("pointerType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MTLPointerType>(Messaging.IntPtr_objc_msgSend(base.Handle, selPointerTypeHandle));
			}
			return Runtime.GetNSObject<MTLPointerType>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPointerTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual MTLTextureReferenceType? TextureReferenceType
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("textureReferenceType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MTLTextureReferenceType>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextureReferenceTypeHandle));
			}
			return Runtime.GetNSObject<MTLTextureReferenceType>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextureReferenceTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MTLStructMember()
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
	protected MTLStructMember(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTLStructMember(IntPtr handle)
		: base(handle)
	{
	}

	[Export("arrayType")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLArrayType ArrayType()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MTLArrayType>(Messaging.IntPtr_objc_msgSend(base.Handle, selArrayTypeHandle));
		}
		return Runtime.GetNSObject<MTLArrayType>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selArrayTypeHandle));
	}

	[Export("structType")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLStructType StructType()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MTLStructType>(Messaging.IntPtr_objc_msgSend(base.Handle, selStructTypeHandle));
		}
		return Runtime.GetNSObject<MTLStructType>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStructTypeHandle));
	}
}

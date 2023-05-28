using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Metal;

[Register("MTLArrayType", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MTLArrayType : MTLType
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArgumentIndexStride = "argumentIndexStride";

	private static readonly IntPtr selArgumentIndexStrideHandle = Selector.GetHandle("argumentIndexStride");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArrayLength = "arrayLength";

	private static readonly IntPtr selArrayLengthHandle = Selector.GetHandle("arrayLength");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementArrayType = "elementArrayType";

	private static readonly IntPtr selElementArrayTypeHandle = Selector.GetHandle("elementArrayType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementPointerType = "elementPointerType";

	private static readonly IntPtr selElementPointerTypeHandle = Selector.GetHandle("elementPointerType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementStructType = "elementStructType";

	private static readonly IntPtr selElementStructTypeHandle = Selector.GetHandle("elementStructType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementTextureReferenceType = "elementTextureReferenceType";

	private static readonly IntPtr selElementTextureReferenceTypeHandle = Selector.GetHandle("elementTextureReferenceType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementType = "elementType";

	private static readonly IntPtr selElementTypeHandle = Selector.GetHandle("elementType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStride = "stride";

	private static readonly IntPtr selStrideHandle = Selector.GetHandle("stride");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTLArrayType");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual nuint ArgumentIndexStride
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("argumentIndexStride")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selArgumentIndexStrideHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selArgumentIndexStrideHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual MTLPointerType? ElementPointerType
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("elementPointerType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MTLPointerType>(Messaging.IntPtr_objc_msgSend(base.Handle, selElementPointerTypeHandle));
			}
			return Runtime.GetNSObject<MTLPointerType>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selElementPointerTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual MTLTextureReferenceType? ElementTextureReferenceType
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("elementTextureReferenceType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MTLTextureReferenceType>(Messaging.IntPtr_objc_msgSend(base.Handle, selElementTextureReferenceTypeHandle));
			}
			return Runtime.GetNSObject<MTLTextureReferenceType>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selElementTextureReferenceTypeHandle));
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
	public virtual nuint Length
	{
		[Export("arrayLength")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selArrayLengthHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selArrayLengthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Stride
	{
		[Export("stride")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selStrideHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selStrideHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MTLArrayType()
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
	protected MTLArrayType(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTLArrayType(IntPtr handle)
		: base(handle)
	{
	}

	[Export("elementArrayType")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLArrayType ElementArrayType()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MTLArrayType>(Messaging.IntPtr_objc_msgSend(base.Handle, selElementArrayTypeHandle));
		}
		return Runtime.GetNSObject<MTLArrayType>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selElementArrayTypeHandle));
	}

	[Export("elementStructType")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLStructType ElementStructType()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MTLStructType>(Messaging.IntPtr_objc_msgSend(base.Handle, selElementStructTypeHandle));
		}
		return Runtime.GetNSObject<MTLStructType>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selElementStructTypeHandle));
	}
}

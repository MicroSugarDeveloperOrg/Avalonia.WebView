using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Metal;

[Register("MTLArgument", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MTLArgument : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccess = "access";

	private static readonly IntPtr selAccessHandle = Selector.GetHandle("access");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArrayLength = "arrayLength";

	private static readonly IntPtr selArrayLengthHandle = Selector.GetHandle("arrayLength");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBufferAlignment = "bufferAlignment";

	private static readonly IntPtr selBufferAlignmentHandle = Selector.GetHandle("bufferAlignment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBufferDataSize = "bufferDataSize";

	private static readonly IntPtr selBufferDataSizeHandle = Selector.GetHandle("bufferDataSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBufferDataType = "bufferDataType";

	private static readonly IntPtr selBufferDataTypeHandle = Selector.GetHandle("bufferDataType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBufferPointerType = "bufferPointerType";

	private static readonly IntPtr selBufferPointerTypeHandle = Selector.GetHandle("bufferPointerType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBufferStructType = "bufferStructType";

	private static readonly IntPtr selBufferStructTypeHandle = Selector.GetHandle("bufferStructType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndex = "index";

	private static readonly IntPtr selIndexHandle = Selector.GetHandle("index");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsActive = "isActive";

	private static readonly IntPtr selIsActiveHandle = Selector.GetHandle("isActive");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDepthTexture = "isDepthTexture";

	private static readonly IntPtr selIsDepthTextureHandle = Selector.GetHandle("isDepthTexture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureDataType = "textureDataType";

	private static readonly IntPtr selTextureDataTypeHandle = Selector.GetHandle("textureDataType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureType = "textureType";

	private static readonly IntPtr selTextureTypeHandle = Selector.GetHandle("textureType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selThreadgroupMemoryAlignment = "threadgroupMemoryAlignment";

	private static readonly IntPtr selThreadgroupMemoryAlignmentHandle = Selector.GetHandle("threadgroupMemoryAlignment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selThreadgroupMemoryDataSize = "threadgroupMemoryDataSize";

	private static readonly IntPtr selThreadgroupMemoryDataSizeHandle = Selector.GetHandle("threadgroupMemoryDataSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTLArgument");

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
	public virtual bool Active
	{
		[Export("isActive")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsActiveHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsActiveHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual nuint ArrayLength
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
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
	public virtual nuint BufferAlignment
	{
		[Export("bufferAlignment")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selBufferAlignmentHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selBufferAlignmentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint BufferDataSize
	{
		[Export("bufferDataSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selBufferDataSizeHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selBufferDataSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLDataType BufferDataType
	{
		[Export("bufferDataType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLDataType)Messaging.UInt64_objc_msgSend(base.Handle, selBufferDataTypeHandle);
			}
			return (MTLDataType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selBufferDataTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual MTLPointerType? BufferPointerType
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("bufferPointerType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MTLPointerType>(Messaging.IntPtr_objc_msgSend(base.Handle, selBufferPointerTypeHandle));
			}
			return Runtime.GetNSObject<MTLPointerType>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBufferPointerTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLStructType? BufferStructType
	{
		[Export("bufferStructType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MTLStructType>(Messaging.IntPtr_objc_msgSend(base.Handle, selBufferStructTypeHandle));
			}
			return Runtime.GetNSObject<MTLStructType>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBufferStructTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Index
	{
		[Export("index")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selIndexHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selIndexHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual bool IsDepthTexture
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
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
	public virtual nuint ThreadgroupMemoryAlignment
	{
		[Export("threadgroupMemoryAlignment")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selThreadgroupMemoryAlignmentHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selThreadgroupMemoryAlignmentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ThreadgroupMemoryDataSize
	{
		[Export("threadgroupMemoryDataSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selThreadgroupMemoryDataSizeHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selThreadgroupMemoryDataSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MTLArgumentType Type
	{
		[Export("type")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MTLArgumentType)Messaging.UInt64_objc_msgSend(base.Handle, selTypeHandle);
			}
			return (MTLArgumentType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MTLArgument()
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
	protected MTLArgument(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTLArgument(IntPtr handle)
		: base(handle)
	{
	}
}

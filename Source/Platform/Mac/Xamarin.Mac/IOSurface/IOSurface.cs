using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace IOSurface;

[Register("IOSurface", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class IOSurface : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllAttachments = "allAttachments";

	private static readonly IntPtr selAllAttachmentsHandle = Selector.GetHandle("allAttachments");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllocationSize = "allocationSize";

	private static readonly IntPtr selAllocationSizeHandle = Selector.GetHandle("allocationSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsPixelSizeCasting = "allowsPixelSizeCasting";

	private static readonly IntPtr selAllowsPixelSizeCastingHandle = Selector.GetHandle("allowsPixelSizeCasting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttachmentForKey_ = "attachmentForKey:";

	private static readonly IntPtr selAttachmentForKey_Handle = Selector.GetHandle("attachmentForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaseAddress = "baseAddress";

	private static readonly IntPtr selBaseAddressHandle = Selector.GetHandle("baseAddress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaseAddressOfPlaneAtIndex_ = "baseAddressOfPlaneAtIndex:";

	private static readonly IntPtr selBaseAddressOfPlaneAtIndex_Handle = Selector.GetHandle("baseAddressOfPlaneAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBytesPerElement = "bytesPerElement";

	private static readonly IntPtr selBytesPerElementHandle = Selector.GetHandle("bytesPerElement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBytesPerElementOfPlaneAtIndex_ = "bytesPerElementOfPlaneAtIndex:";

	private static readonly IntPtr selBytesPerElementOfPlaneAtIndex_Handle = Selector.GetHandle("bytesPerElementOfPlaneAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBytesPerRow = "bytesPerRow";

	private static readonly IntPtr selBytesPerRowHandle = Selector.GetHandle("bytesPerRow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBytesPerRowOfPlaneAtIndex_ = "bytesPerRowOfPlaneAtIndex:";

	private static readonly IntPtr selBytesPerRowOfPlaneAtIndex_Handle = Selector.GetHandle("bytesPerRowOfPlaneAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecrementUseCount = "decrementUseCount";

	private static readonly IntPtr selDecrementUseCountHandle = Selector.GetHandle("decrementUseCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementHeight = "elementHeight";

	private static readonly IntPtr selElementHeightHandle = Selector.GetHandle("elementHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementHeightOfPlaneAtIndex_ = "elementHeightOfPlaneAtIndex:";

	private static readonly IntPtr selElementHeightOfPlaneAtIndex_Handle = Selector.GetHandle("elementHeightOfPlaneAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementWidth = "elementWidth";

	private static readonly IntPtr selElementWidthHandle = Selector.GetHandle("elementWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementWidthOfPlaneAtIndex_ = "elementWidthOfPlaneAtIndex:";

	private static readonly IntPtr selElementWidthOfPlaneAtIndex_Handle = Selector.GetHandle("elementWidthOfPlaneAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeight = "height";

	private static readonly IntPtr selHeightHandle = Selector.GetHandle("height");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeightOfPlaneAtIndex_ = "heightOfPlaneAtIndex:";

	private static readonly IntPtr selHeightOfPlaneAtIndex_Handle = Selector.GetHandle("heightOfPlaneAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncrementUseCount = "incrementUseCount";

	private static readonly IntPtr selIncrementUseCountHandle = Selector.GetHandle("incrementUseCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithProperties_ = "initWithProperties:";

	private static readonly IntPtr selInitWithProperties_Handle = Selector.GetHandle("initWithProperties:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsInUse = "isInUse";

	private static readonly IntPtr selIsInUseHandle = Selector.GetHandle("isInUse");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalUseCount = "localUseCount";

	private static readonly IntPtr selLocalUseCountHandle = Selector.GetHandle("localUseCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLockWithOptions_Seed_ = "lockWithOptions:seed:";

	private static readonly IntPtr selLockWithOptions_Seed_Handle = Selector.GetHandle("lockWithOptions:seed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelFormat = "pixelFormat";

	private static readonly IntPtr selPixelFormatHandle = Selector.GetHandle("pixelFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlaneCount = "planeCount";

	private static readonly IntPtr selPlaneCountHandle = Selector.GetHandle("planeCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllAttachments = "removeAllAttachments";

	private static readonly IntPtr selRemoveAllAttachmentsHandle = Selector.GetHandle("removeAllAttachments");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAttachmentForKey_ = "removeAttachmentForKey:";

	private static readonly IntPtr selRemoveAttachmentForKey_Handle = Selector.GetHandle("removeAttachmentForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSeed = "seed";

	private static readonly IntPtr selSeedHandle = Selector.GetHandle("seed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllAttachments_ = "setAllAttachments:";

	private static readonly IntPtr selSetAllAttachments_Handle = Selector.GetHandle("setAllAttachments:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttachment_ForKey_ = "setAttachment:forKey:";

	private static readonly IntPtr selSetAttachment_ForKey_Handle = Selector.GetHandle("setAttachment:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPurgeable_OldState_ = "setPurgeable:oldState:";

	private static readonly IntPtr selSetPurgeable_OldState_Handle = Selector.GetHandle("setPurgeable:oldState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnlockWithOptions_Seed_ = "unlockWithOptions:seed:";

	private static readonly IntPtr selUnlockWithOptions_Seed_Handle = Selector.GetHandle("unlockWithOptions:seed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWidth = "width";

	private static readonly IntPtr selWidthHandle = Selector.GetHandle("width");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWidthOfPlaneAtIndex_ = "widthOfPlaneAtIndex:";

	private static readonly IntPtr selWidthOfPlaneAtIndex_Handle = Selector.GetHandle("widthOfPlaneAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("IOSurface");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<NSString, NSObject> AllAttachments
	{
		[Export("allAttachments")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSend(base.Handle, selAllAttachmentsHandle));
			}
			return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllAttachmentsHandle));
		}
		[Export("setAllAttachments:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAllAttachments_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAllAttachments_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint AllocationSize
	{
		[Export("allocationSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selAllocationSizeHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selAllocationSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsPixelSizeCasting
	{
		[Export("allowsPixelSizeCasting")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsPixelSizeCastingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsPixelSizeCastingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr BaseAddress
	{
		[Export("baseAddress")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selBaseAddressHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBaseAddressHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint BytesPerElement
	{
		[Export("bytesPerElement")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selBytesPerElementHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selBytesPerElementHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint BytesPerRow
	{
		[Export("bytesPerRow")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selBytesPerRowHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selBytesPerRowHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ElementHeight
	{
		[Export("elementHeight")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selElementHeightHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selElementHeightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ElementWidth
	{
		[Export("elementWidth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selElementWidthHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selElementWidthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Height
	{
		[Export("height")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selHeightHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selHeightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool InUse
	{
		[Export("isInUse")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsInUseHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsInUseHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int LocalUseCount
	{
		[Export("localUseCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selLocalUseCountHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selLocalUseCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint PixelFormat
	{
		[Export("pixelFormat")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selPixelFormatHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selPixelFormatHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint PlaneCount
	{
		[Export("planeCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selPlaneCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selPlaneCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint Seed
	{
		[Export("seed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selSeedHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selSeedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Width
	{
		[Export("width")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selWidthHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selWidthHandle);
		}
	}

	[iOS(11, 0)]
	[Mac(10, 12)]
	[TV(11, 0)]
	public unsafe int Lock(IOSurfaceLockOptions options, ref int seed)
	{
		fixed (int* ptr = &seed)
		{
			return _Lock(options, (IntPtr)ptr);
		}
	}

	[iOS(11, 0)]
	[Mac(10, 12)]
	[TV(11, 0)]
	public int Lock(IOSurfaceLockOptions options)
	{
		return _Lock(options, IntPtr.Zero);
	}

	[iOS(11, 0)]
	[Mac(10, 12)]
	[TV(11, 0)]
	public unsafe int Unlock(IOSurfaceLockOptions options, ref int seed)
	{
		fixed (int* ptr = &seed)
		{
			return _Unlock(options, (IntPtr)ptr);
		}
	}

	[iOS(11, 0)]
	[Mac(10, 12)]
	[TV(11, 0)]
	public int Unlock(IOSurfaceLockOptions options)
	{
		return _Unlock(options, IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IOSurface()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public IOSurface(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected IOSurface(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal IOSurface(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithProperties:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal IOSurface(NSDictionary properties)
		: base(NSObjectFlag.Empty)
	{
		if (properties == null)
		{
			throw new ArgumentNullException("properties");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithProperties_Handle, properties.Handle), "initWithProperties:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithProperties_Handle, properties.Handle), "initWithProperties:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IOSurface(IOSurfaceOptions properties)
		: this(properties.GetDictionary())
	{
	}

	[Export("decrementUseCount")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DecrementUseCount()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDecrementUseCountHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDecrementUseCountHandle);
		}
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("attachmentForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? GetAttachment(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAttachmentForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAttachmentForKey_Handle, key.Handle));
	}

	[Export("baseAddressOfPlaneAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr GetBaseAddress(nuint planeIndex)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selBaseAddressOfPlaneAtIndex_Handle, planeIndex);
		}
		return Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selBaseAddressOfPlaneAtIndex_Handle, planeIndex);
	}

	[Export("bytesPerElementOfPlaneAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetBytesPerElement(nuint planeIndex)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_nuint(base.Handle, selBytesPerElementOfPlaneAtIndex_Handle, planeIndex);
		}
		return Messaging.nint_objc_msgSendSuper_nuint(base.SuperHandle, selBytesPerElementOfPlaneAtIndex_Handle, planeIndex);
	}

	[Export("bytesPerRowOfPlaneAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetBytesPerRow(nuint planeIndex)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_nuint(base.Handle, selBytesPerRowOfPlaneAtIndex_Handle, planeIndex);
		}
		return Messaging.nint_objc_msgSendSuper_nuint(base.SuperHandle, selBytesPerRowOfPlaneAtIndex_Handle, planeIndex);
	}

	[Export("elementHeightOfPlaneAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetElementHeight(nuint planeIndex)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_nuint(base.Handle, selElementHeightOfPlaneAtIndex_Handle, planeIndex);
		}
		return Messaging.nint_objc_msgSendSuper_nuint(base.SuperHandle, selElementHeightOfPlaneAtIndex_Handle, planeIndex);
	}

	[Export("elementWidthOfPlaneAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetElementWidth(nuint planeIndex)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_nuint(base.Handle, selElementWidthOfPlaneAtIndex_Handle, planeIndex);
		}
		return Messaging.nint_objc_msgSendSuper_nuint(base.SuperHandle, selElementWidthOfPlaneAtIndex_Handle, planeIndex);
	}

	[Export("heightOfPlaneAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetHeight(nuint planeIndex)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_nuint(base.Handle, selHeightOfPlaneAtIndex_Handle, planeIndex);
		}
		return Messaging.nint_objc_msgSendSuper_nuint(base.SuperHandle, selHeightOfPlaneAtIndex_Handle, planeIndex);
	}

	[Export("widthOfPlaneAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetWidth(nuint planeIndex)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_nuint(base.Handle, selWidthOfPlaneAtIndex_Handle, planeIndex);
		}
		return Messaging.nint_objc_msgSendSuper_nuint(base.SuperHandle, selWidthOfPlaneAtIndex_Handle, planeIndex);
	}

	[Export("incrementUseCount")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void IncrementUseCount()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selIncrementUseCountHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selIncrementUseCountHandle);
		}
	}

	[Export("removeAllAttachments")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllAttachments()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllAttachmentsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllAttachmentsHandle);
		}
	}

	[Export("removeAttachmentForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAttachment(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveAttachmentForKey_Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveAttachmentForKey_Handle, key.Handle);
		}
	}

	[Export("setAttachment:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetAttachment(NSObject anObject, NSString key)
	{
		if (anObject == null)
		{
			throw new ArgumentNullException("anObject");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetAttachment_ForKey_Handle, anObject.Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetAttachment_ForKey_Handle, anObject.Handle, key.Handle);
		}
	}

	[Export("lockWithOptions:seed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual int _Lock(IOSurfaceLockOptions options, IntPtr seedPtr)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.int_objc_msgSend_UInt32_IntPtr(base.Handle, selLockWithOptions_Seed_Handle, (uint)options, seedPtr);
		}
		return Messaging.int_objc_msgSendSuper_UInt32_IntPtr(base.SuperHandle, selLockWithOptions_Seed_Handle, (uint)options, seedPtr);
	}

	[Export("setPurgeable:oldState:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual int _SetPurgeable(IOSurfacePurgeabilityState newState, IntPtr oldStatePtr)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.int_objc_msgSend_UInt32_IntPtr(base.Handle, selSetPurgeable_OldState_Handle, (uint)newState, oldStatePtr);
		}
		return Messaging.int_objc_msgSendSuper_UInt32_IntPtr(base.SuperHandle, selSetPurgeable_OldState_Handle, (uint)newState, oldStatePtr);
	}

	[Export("unlockWithOptions:seed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual int _Unlock(IOSurfaceLockOptions options, IntPtr seed)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.int_objc_msgSend_UInt32_IntPtr(base.Handle, selUnlockWithOptions_Seed_Handle, (uint)options, seed);
		}
		return Messaging.int_objc_msgSendSuper_UInt32_IntPtr(base.SuperHandle, selUnlockWithOptions_Seed_Handle, (uint)options, seed);
	}
}

using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreImage;

[Register("CIDataMatrixCodeDescriptor", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class CIDataMatrixCodeDescriptor : CIBarcodeDescriptor
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColumnCount = "columnCount";

	private static readonly IntPtr selColumnCountHandle = Selector.GetHandle("columnCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptorWithPayload_RowCount_ColumnCount_EccVersion_ = "descriptorWithPayload:rowCount:columnCount:eccVersion:";

	private static readonly IntPtr selDescriptorWithPayload_RowCount_ColumnCount_EccVersion_Handle = Selector.GetHandle("descriptorWithPayload:rowCount:columnCount:eccVersion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEccVersion = "eccVersion";

	private static readonly IntPtr selEccVersionHandle = Selector.GetHandle("eccVersion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selErrorCorrectedPayload = "errorCorrectedPayload";

	private static readonly IntPtr selErrorCorrectedPayloadHandle = Selector.GetHandle("errorCorrectedPayload");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPayload_RowCount_ColumnCount_EccVersion_ = "initWithPayload:rowCount:columnCount:eccVersion:";

	private static readonly IntPtr selInitWithPayload_RowCount_ColumnCount_EccVersion_Handle = Selector.GetHandle("initWithPayload:rowCount:columnCount:eccVersion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowCount = "rowCount";

	private static readonly IntPtr selRowCountHandle = Selector.GetHandle("rowCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CIDataMatrixCodeDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ColumnCount
	{
		[Export("columnCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selColumnCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selColumnCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIDataMatrixCodeEccVersion EccVersion
	{
		[Export("eccVersion")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CIDataMatrixCodeEccVersion)Messaging.Int64_objc_msgSend(base.Handle, selEccVersionHandle);
			}
			return (CIDataMatrixCodeEccVersion)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selEccVersionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData ErrorCorrectedPayload
	{
		[Export("errorCorrectedPayload")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selErrorCorrectedPayloadHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selErrorCorrectedPayloadHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint RowCount
	{
		[Export("rowCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selRowCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selRowCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CIDataMatrixCodeDescriptor()
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
	public CIDataMatrixCodeDescriptor(NSCoder coder)
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
	protected CIDataMatrixCodeDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CIDataMatrixCodeDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPayload:rowCount:columnCount:eccVersion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIDataMatrixCodeDescriptor(NSData errorCorrectedPayload, nint rowCount, nint columnCount, CIDataMatrixCodeEccVersion eccVersion)
		: base(NSObjectFlag.Empty)
	{
		if (errorCorrectedPayload == null)
		{
			throw new ArgumentNullException("errorCorrectedPayload");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nint_nint_Int64(base.Handle, selInitWithPayload_RowCount_ColumnCount_EccVersion_Handle, errorCorrectedPayload.Handle, rowCount, columnCount, (long)eccVersion), "initWithPayload:rowCount:columnCount:eccVersion:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nint_nint_Int64(base.SuperHandle, selInitWithPayload_RowCount_ColumnCount_EccVersion_Handle, errorCorrectedPayload.Handle, rowCount, columnCount, (long)eccVersion), "initWithPayload:rowCount:columnCount:eccVersion:");
		}
	}

	[Export("descriptorWithPayload:rowCount:columnCount:eccVersion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIDataMatrixCodeDescriptor? CreateDescriptor(NSData errorCorrectedPayload, nint rowCount, nint columnCount, CIDataMatrixCodeEccVersion eccVersion)
	{
		if (errorCorrectedPayload == null)
		{
			throw new ArgumentNullException("errorCorrectedPayload");
		}
		return Runtime.GetNSObject<CIDataMatrixCodeDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr_nint_nint_Int64(class_ptr, selDescriptorWithPayload_RowCount_ColumnCount_EccVersion_Handle, errorCorrectedPayload.Handle, rowCount, columnCount, (long)eccVersion));
	}
}

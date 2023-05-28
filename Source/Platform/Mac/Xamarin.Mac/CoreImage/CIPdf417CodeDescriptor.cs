using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreImage;

[Register("CIPDF417CodeDescriptor", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class CIPdf417CodeDescriptor : CIBarcodeDescriptor
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColumnCount = "columnCount";

	private static readonly IntPtr selColumnCountHandle = Selector.GetHandle("columnCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptorWithPayload_IsCompact_RowCount_ColumnCount_ = "descriptorWithPayload:isCompact:rowCount:columnCount:";

	private static readonly IntPtr selDescriptorWithPayload_IsCompact_RowCount_ColumnCount_Handle = Selector.GetHandle("descriptorWithPayload:isCompact:rowCount:columnCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selErrorCorrectedPayload = "errorCorrectedPayload";

	private static readonly IntPtr selErrorCorrectedPayloadHandle = Selector.GetHandle("errorCorrectedPayload");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPayload_IsCompact_RowCount_ColumnCount_ = "initWithPayload:isCompact:rowCount:columnCount:";

	private static readonly IntPtr selInitWithPayload_IsCompact_RowCount_ColumnCount_Handle = Selector.GetHandle("initWithPayload:isCompact:rowCount:columnCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCompact = "isCompact";

	private static readonly IntPtr selIsCompactHandle = Selector.GetHandle("isCompact");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowCount = "rowCount";

	private static readonly IntPtr selRowCountHandle = Selector.GetHandle("rowCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CIPDF417CodeDescriptor");

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
	public virtual bool IsCompact
	{
		[Export("isCompact")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCompactHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCompactHandle);
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
	public CIPdf417CodeDescriptor()
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
	public CIPdf417CodeDescriptor(NSCoder coder)
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
	protected CIPdf417CodeDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CIPdf417CodeDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPayload:isCompact:rowCount:columnCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIPdf417CodeDescriptor(NSData errorCorrectedPayload, bool isCompact, nint rowCount, nint columnCount)
		: base(NSObjectFlag.Empty)
	{
		if (errorCorrectedPayload == null)
		{
			throw new ArgumentNullException("errorCorrectedPayload");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_bool_nint_nint(base.Handle, selInitWithPayload_IsCompact_RowCount_ColumnCount_Handle, errorCorrectedPayload.Handle, isCompact, rowCount, columnCount), "initWithPayload:isCompact:rowCount:columnCount:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_nint_nint(base.SuperHandle, selInitWithPayload_IsCompact_RowCount_ColumnCount_Handle, errorCorrectedPayload.Handle, isCompact, rowCount, columnCount), "initWithPayload:isCompact:rowCount:columnCount:");
		}
	}

	[Export("descriptorWithPayload:isCompact:rowCount:columnCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIPdf417CodeDescriptor? CreateDescriptor(NSData errorCorrectedPayload, bool isCompact, nint rowCount, nint columnCount)
	{
		if (errorCorrectedPayload == null)
		{
			throw new ArgumentNullException("errorCorrectedPayload");
		}
		return Runtime.GetNSObject<CIPdf417CodeDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr_bool_nint_nint(class_ptr, selDescriptorWithPayload_IsCompact_RowCount_ColumnCount_Handle, errorCorrectedPayload.Handle, isCompact, rowCount, columnCount));
	}
}

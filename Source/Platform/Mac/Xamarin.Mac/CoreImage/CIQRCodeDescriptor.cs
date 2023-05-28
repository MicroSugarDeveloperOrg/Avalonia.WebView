using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Register("CIQRCodeDescriptor", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class CIQRCodeDescriptor : CIBarcodeDescriptor
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptorWithPayload_SymbolVersion_MaskPattern_ErrorCorrectionLevel_ = "descriptorWithPayload:symbolVersion:maskPattern:errorCorrectionLevel:";

	private static readonly IntPtr selDescriptorWithPayload_SymbolVersion_MaskPattern_ErrorCorrectionLevel_Handle = Selector.GetHandle("descriptorWithPayload:symbolVersion:maskPattern:errorCorrectionLevel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selErrorCorrectedPayload = "errorCorrectedPayload";

	private static readonly IntPtr selErrorCorrectedPayloadHandle = Selector.GetHandle("errorCorrectedPayload");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selErrorCorrectionLevel = "errorCorrectionLevel";

	private static readonly IntPtr selErrorCorrectionLevelHandle = Selector.GetHandle("errorCorrectionLevel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPayload_SymbolVersion_MaskPattern_ErrorCorrectionLevel_ = "initWithPayload:symbolVersion:maskPattern:errorCorrectionLevel:";

	private static readonly IntPtr selInitWithPayload_SymbolVersion_MaskPattern_ErrorCorrectionLevel_Handle = Selector.GetHandle("initWithPayload:symbolVersion:maskPattern:errorCorrectionLevel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaskPattern = "maskPattern";

	private static readonly IntPtr selMaskPatternHandle = Selector.GetHandle("maskPattern");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSymbolVersion = "symbolVersion";

	private static readonly IntPtr selSymbolVersionHandle = Selector.GetHandle("symbolVersion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CIQRCodeDescriptor");

	public override IntPtr ClassHandle => class_ptr;

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
	public virtual CIQRCodeErrorCorrectionLevel ErrorCorrectionLevel
	{
		[Export("errorCorrectionLevel")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CIQRCodeErrorCorrectionLevel)Messaging.Int64_objc_msgSend(base.Handle, selErrorCorrectionLevelHandle);
			}
			return (CIQRCodeErrorCorrectionLevel)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selErrorCorrectionLevelHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual byte MaskPattern
	{
		[Export("maskPattern")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.byte_objc_msgSend(base.Handle, selMaskPatternHandle);
			}
			return Messaging.byte_objc_msgSendSuper(base.SuperHandle, selMaskPatternHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint SymbolVersion
	{
		[Export("symbolVersion")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selSymbolVersionHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSymbolVersionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CIQRCodeDescriptor()
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
	public CIQRCodeDescriptor(NSCoder coder)
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
	protected CIQRCodeDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CIQRCodeDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPayload:symbolVersion:maskPattern:errorCorrectionLevel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIQRCodeDescriptor(NSData errorCorrectedPayload, nint symbolVersion, byte maskPattern, CIQRCodeErrorCorrectionLevel errorCorrectionLevel)
		: base(NSObjectFlag.Empty)
	{
		if (errorCorrectedPayload == null)
		{
			throw new ArgumentNullException("errorCorrectedPayload");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nint_byte_Int64(base.Handle, selInitWithPayload_SymbolVersion_MaskPattern_ErrorCorrectionLevel_Handle, errorCorrectedPayload.Handle, symbolVersion, maskPattern, (long)errorCorrectionLevel), "initWithPayload:symbolVersion:maskPattern:errorCorrectionLevel:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nint_byte_Int64(base.SuperHandle, selInitWithPayload_SymbolVersion_MaskPattern_ErrorCorrectionLevel_Handle, errorCorrectedPayload.Handle, symbolVersion, maskPattern, (long)errorCorrectionLevel), "initWithPayload:symbolVersion:maskPattern:errorCorrectionLevel:");
		}
	}

	[Export("descriptorWithPayload:symbolVersion:maskPattern:errorCorrectionLevel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIQRCodeDescriptor? CreateDescriptor(NSData errorCorrectedPayload, nint symbolVersion, byte maskPattern, CIQRCodeErrorCorrectionLevel errorCorrectionLevel)
	{
		if (errorCorrectedPayload == null)
		{
			throw new ArgumentNullException("errorCorrectedPayload");
		}
		return Runtime.GetNSObject<CIQRCodeDescriptor>(Messaging.IntPtr_objc_msgSend_IntPtr_nint_byte_Int64(class_ptr, selDescriptorWithPayload_SymbolVersion_MaskPattern_ErrorCorrectionLevel_Handle, errorCorrectedPayload.Handle, symbolVersion, maskPattern, (long)errorCorrectionLevel));
	}
}

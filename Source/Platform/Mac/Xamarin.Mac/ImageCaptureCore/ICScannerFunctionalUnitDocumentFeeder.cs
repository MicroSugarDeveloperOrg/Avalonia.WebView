using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

[Register("ICScannerFunctionalUnitDocumentFeeder", true)]
public class ICScannerFunctionalUnitDocumentFeeder : ICScannerFunctionalUnit
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocumentLoaded = "documentLoaded";

	private static readonly IntPtr selDocumentLoadedHandle = Selector.GetHandle("documentLoaded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocumentSize = "documentSize";

	private static readonly IntPtr selDocumentSizeHandle = Selector.GetHandle("documentSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocumentType = "documentType";

	private static readonly IntPtr selDocumentTypeHandle = Selector.GetHandle("documentType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuplexScanningEnabled = "duplexScanningEnabled";

	private static readonly IntPtr selDuplexScanningEnabledHandle = Selector.GetHandle("duplexScanningEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEvenPageOrientation = "evenPageOrientation";

	private static readonly IntPtr selEvenPageOrientationHandle = Selector.GetHandle("evenPageOrientation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOddPageOrientation = "oddPageOrientation";

	private static readonly IntPtr selOddPageOrientationHandle = Selector.GetHandle("oddPageOrientation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReverseFeederPageOrder = "reverseFeederPageOrder";

	private static readonly IntPtr selReverseFeederPageOrderHandle = Selector.GetHandle("reverseFeederPageOrder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDocumentType_ = "setDocumentType:";

	private static readonly IntPtr selSetDocumentType_Handle = Selector.GetHandle("setDocumentType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDuplexScanningEnabled_ = "setDuplexScanningEnabled:";

	private static readonly IntPtr selSetDuplexScanningEnabled_Handle = Selector.GetHandle("setDuplexScanningEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEvenPageOrientation_ = "setEvenPageOrientation:";

	private static readonly IntPtr selSetEvenPageOrientation_Handle = Selector.GetHandle("setEvenPageOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOddPageOrientation_ = "setOddPageOrientation:";

	private static readonly IntPtr selSetOddPageOrientation_Handle = Selector.GetHandle("setOddPageOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedDocumentTypes = "supportedDocumentTypes";

	private static readonly IntPtr selSupportedDocumentTypesHandle = Selector.GetHandle("supportedDocumentTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsDuplexScanning = "supportsDuplexScanning";

	private static readonly IntPtr selSupportsDuplexScanningHandle = Selector.GetHandle("supportsDuplexScanning");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ICScannerFunctionalUnitDocumentFeeder");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DocumentLoaded
	{
		[Export("documentLoaded")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDocumentLoadedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDocumentLoadedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize DocumentSize
	{
		[Export("documentSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selDocumentSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selDocumentSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICScannerDocumentType DocumentType
	{
		[Export("documentType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (ICScannerDocumentType)Messaging.UInt64_objc_msgSend(base.Handle, selDocumentTypeHandle);
			}
			return (ICScannerDocumentType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDocumentTypeHandle);
		}
		[Export("setDocumentType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDocumentType_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDocumentType_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DuplexScanningEnabled
	{
		[Export("duplexScanningEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDuplexScanningEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDuplexScanningEnabledHandle);
		}
		[Export("setDuplexScanningEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDuplexScanningEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDuplexScanningEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICExifOrientationType EvenPageOrientation
	{
		[Export("evenPageOrientation", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (ICExifOrientationType)Messaging.UInt64_objc_msgSend(base.Handle, selEvenPageOrientationHandle);
			}
			return (ICExifOrientationType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selEvenPageOrientationHandle);
		}
		[Export("setEvenPageOrientation:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetEvenPageOrientation_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetEvenPageOrientation_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICExifOrientationType OddPageOrientation
	{
		[Export("oddPageOrientation", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (ICExifOrientationType)Messaging.UInt64_objc_msgSend(base.Handle, selOddPageOrientationHandle);
			}
			return (ICExifOrientationType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selOddPageOrientationHandle);
		}
		[Export("setOddPageOrientation:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetOddPageOrientation_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetOddPageOrientation_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ReverseFeederPageOrder
	{
		[Export("reverseFeederPageOrder")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selReverseFeederPageOrderHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selReverseFeederPageOrderHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexSet SupportedDocumentTypes
	{
		[Export("supportedDocumentTypes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selSupportedDocumentTypesHandle));
			}
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSupportedDocumentTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SupportsDuplexScanning
	{
		[Export("supportsDuplexScanning")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupportsDuplexScanningHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupportsDuplexScanningHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected ICScannerFunctionalUnitDocumentFeeder(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ICScannerFunctionalUnitDocumentFeeder(IntPtr handle)
		: base(handle)
	{
	}
}

using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

[Register("ICScannerFunctionalUnitPositiveTransparency", true)]
public class ICScannerFunctionalUnitPositiveTransparency : ICScannerFunctionalUnit
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocumentSize = "documentSize";

	private static readonly IntPtr selDocumentSizeHandle = Selector.GetHandle("documentSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocumentType = "documentType";

	private static readonly IntPtr selDocumentTypeHandle = Selector.GetHandle("documentType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDocumentType_ = "setDocumentType:";

	private static readonly IntPtr selSetDocumentType_Handle = Selector.GetHandle("setDocumentType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedDocumentTypes = "supportedDocumentTypes";

	private static readonly IntPtr selSupportedDocumentTypesHandle = Selector.GetHandle("supportedDocumentTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ICScannerFunctionalUnitPositiveTransparency");

	public override IntPtr ClassHandle => class_ptr;

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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected ICScannerFunctionalUnitPositiveTransparency(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ICScannerFunctionalUnitPositiveTransparency(IntPtr handle)
		: base(handle)
	{
	}
}

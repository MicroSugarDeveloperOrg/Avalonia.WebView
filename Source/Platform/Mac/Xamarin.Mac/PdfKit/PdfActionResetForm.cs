using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFActionResetForm", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class PdfActionResetForm : PdfAction
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFields = "fields";

	private static readonly IntPtr selFieldsHandle = Selector.GetHandle("fields");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFieldsIncludedAreCleared = "fieldsIncludedAreCleared";

	private static readonly IntPtr selFieldsIncludedAreClearedHandle = Selector.GetHandle("fieldsIncludedAreCleared");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFields_ = "setFields:";

	private static readonly IntPtr selSetFields_Handle = Selector.GetHandle("setFields:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFieldsIncludedAreCleared_ = "setFieldsIncludedAreCleared:";

	private static readonly IntPtr selSetFieldsIncludedAreCleared_Handle = Selector.GetHandle("setFieldsIncludedAreCleared:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PDFActionResetForm");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[]? Fields
	{
		[Export("fields")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFieldsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFieldsHandle));
		}
		[Export("setFields:")]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromStrings(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFields_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFields_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool FieldsIncludedAreCleared
	{
		[Export("fieldsIncludedAreCleared")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selFieldsIncludedAreClearedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selFieldsIncludedAreClearedHandle);
		}
		[Export("setFieldsIncludedAreCleared:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFieldsIncludedAreCleared_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFieldsIncludedAreCleared_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected PdfActionResetForm(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PdfActionResetForm(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public PdfActionResetForm()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInitHandle), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitHandle), "init");
		}
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFActionResetForm", true)]
public class PdfActionResetForm : PdfAction
{
	private static readonly IntPtr selFieldsHandle = Selector.GetHandle("fields");

	private static readonly IntPtr selSetFields_Handle = Selector.GetHandle("setFields:");

	private static readonly IntPtr selFieldsIncludedAreClearedHandle = Selector.GetHandle("fieldsIncludedAreCleared");

	private static readonly IntPtr selSetFieldsIncludedAreCleared_Handle = Selector.GetHandle("setFieldsIncludedAreCleared:");

	private static readonly IntPtr class_ptr = Class.GetHandle("PDFActionResetForm");

	public override IntPtr ClassHandle => class_ptr;

	public virtual string[] Fields
	{
		[Export("fields")]
		get
		{
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFieldsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFieldsHandle));
		}
		[Export("setFields:")]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromStrings(value));
			if (IsDirectBinding)
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

	public virtual bool FieldsIncludedAreCleared
	{
		[Export("fieldsIncludedAreCleared")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selFieldsIncludedAreClearedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selFieldsIncludedAreClearedHandle);
		}
		[Export("setFieldsIncludedAreCleared:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFieldsIncludedAreCleared_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFieldsIncludedAreCleared_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfActionResetForm()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public PdfActionResetForm(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public PdfActionResetForm(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public PdfActionResetForm(IntPtr handle)
		: base(handle)
	{
	}
}

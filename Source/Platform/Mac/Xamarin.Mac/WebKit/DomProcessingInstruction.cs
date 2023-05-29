using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMProcessingInstruction", true)]
public class DomProcessingInstruction : DomNode
{
	private static readonly IntPtr selTargetHandle = Selector.GetHandle("target");

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	private static readonly IntPtr selSetData_Handle = Selector.GetHandle("setData:");

	private static readonly IntPtr selSheetHandle = Selector.GetHandle("sheet");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMProcessingInstruction");

	private object __mt_Sheet_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string Target
	{
		[Export("target")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTargetHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTargetHandle));
		}
	}

	public virtual string Data
	{
		[Export("data")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle));
		}
		[Export("setData:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetData_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetData_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual DomStyleSheet Sheet
	{
		[Export("sheet")]
		get
		{
			return (DomStyleSheet)(__mt_Sheet_var = ((!IsDirectBinding) ? ((DomStyleSheet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSheetHandle))) : ((DomStyleSheet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSheetHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomProcessingInstruction(NSCoder coder)
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
	public DomProcessingInstruction(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomProcessingInstruction(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Sheet_var = null;
		}
	}
}

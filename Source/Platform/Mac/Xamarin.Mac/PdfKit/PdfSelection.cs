using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFSelection", true)]
public class PdfSelection : NSObject
{
	private static readonly IntPtr selPagesHandle = Selector.GetHandle("pages");

	private static readonly IntPtr selColorHandle = Selector.GetHandle("color");

	private static readonly IntPtr selSetColor_Handle = Selector.GetHandle("setColor:");

	private static readonly IntPtr selStringHandle = Selector.GetHandle("string");

	private static readonly IntPtr selAttributedStringHandle = Selector.GetHandle("attributedString");

	private static readonly IntPtr selInitWithDocument_Handle = Selector.GetHandle("initWithDocument:");

	private static readonly IntPtr selBoundsForPage_Handle = Selector.GetHandle("boundsForPage:");

	private static readonly IntPtr selSelectionsByLineHandle = Selector.GetHandle("selectionsByLine");

	private static readonly IntPtr selAddSelection_Handle = Selector.GetHandle("addSelection:");

	private static readonly IntPtr selAddSelections_Handle = Selector.GetHandle("addSelections:");

	private static readonly IntPtr selExtendSelectionAtEnd_Handle = Selector.GetHandle("extendSelectionAtEnd:");

	private static readonly IntPtr selExtendSelectionAtStart_Handle = Selector.GetHandle("extendSelectionAtStart:");

	private static readonly IntPtr selDrawForPageActive_Handle = Selector.GetHandle("drawForPage:active:");

	private static readonly IntPtr selDrawForPageWithBoxActive_Handle = Selector.GetHandle("drawForPage:withBox:active:");

	private static readonly IntPtr class_ptr = Class.GetHandle("PDFSelection");

	private object __mt_Pages_var;

	private object __mt_Color_var;

	private object __mt_AttributedString_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual PdfPage[] Pages
	{
		[Export("pages")]
		get
		{
			return (PdfPage[])(__mt_Pages_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<PdfPage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPagesHandle)) : NSArray.ArrayFromHandle<PdfPage>(Messaging.IntPtr_objc_msgSend(base.Handle, selPagesHandle))));
		}
	}

	public virtual NSColor Color
	{
		[Export("color")]
		get
		{
			return (NSColor)(__mt_Color_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selColorHandle)))));
		}
		[Export("setColor:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColor_Handle, value.Handle);
			}
			__mt_Color_var = value;
		}
	}

	public virtual string Text
	{
		[Export("string")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringHandle));
		}
	}

	public virtual NSAttributedString AttributedString
	{
		[Export("attributedString")]
		get
		{
			return (NSAttributedString)(__mt_AttributedString_var = ((!IsDirectBinding) ? ((NSAttributedString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributedStringHandle))) : ((NSAttributedString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributedStringHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public PdfSelection(NSCoder coder)
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
	public PdfSelection(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public PdfSelection(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDocument:")]
	public PdfSelection(PdfDocument document)
		: base(NSObjectFlag.Empty)
	{
		if (document == null)
		{
			throw new ArgumentNullException("document");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithDocument_Handle, document.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithDocument_Handle, document.Handle);
		}
	}

	[Export("boundsForPage:")]
	public virtual CGRect GetBoundsForPage(PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr(out retval, base.Handle, selBoundsForPage_Handle, page.Handle);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr(out retval, base.SuperHandle, selBoundsForPage_Handle, page.Handle);
		}
		return retval;
	}

	[Export("selectionsByLine")]
	public virtual PdfSelection[] SelectionsByLine()
	{
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<PdfSelection>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectionsByLineHandle));
		}
		return NSArray.ArrayFromHandle<PdfSelection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectionsByLineHandle));
	}

	[Export("addSelection:")]
	public virtual void AddSelection(PdfSelection selection)
	{
		if (selection == null)
		{
			throw new ArgumentNullException("selection");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddSelection_Handle, selection.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSelection_Handle, selection.Handle);
		}
	}

	[Export("addSelections:")]
	public virtual void AddSelections(PdfSelection[] selections)
	{
		if (selections == null)
		{
			throw new ArgumentNullException("selections");
		}
		NSArray nSArray = NSArray.FromNSObjects(selections);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddSelections_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSelections_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("extendSelectionAtEnd:")]
	public virtual void ExtendSelectionAtEnd(int succeed)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int(base.Handle, selExtendSelectionAtEnd_Handle, succeed);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selExtendSelectionAtEnd_Handle, succeed);
		}
	}

	[Export("extendSelectionAtStart:")]
	public virtual void ExtendSelectionAtStart(int precede)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int(base.Handle, selExtendSelectionAtStart_Handle, precede);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selExtendSelectionAtStart_Handle, precede);
		}
	}

	[Export("drawForPage:active:")]
	public virtual void Draw(PdfPage page, bool active)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selDrawForPageActive_Handle, page.Handle, active);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selDrawForPageActive_Handle, page.Handle, active);
		}
	}

	[Export("drawForPage:withBox:active:")]
	public virtual void Draw(PdfPage page, PdfDisplayBox box, bool active)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int_bool(base.Handle, selDrawForPageWithBoxActive_Handle, page.Handle, (int)box, active);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int_bool(base.SuperHandle, selDrawForPageWithBoxActive_Handle, page.Handle, (int)box, active);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Pages_var = null;
			__mt_Color_var = null;
			__mt_AttributedString_var = null;
		}
	}
}

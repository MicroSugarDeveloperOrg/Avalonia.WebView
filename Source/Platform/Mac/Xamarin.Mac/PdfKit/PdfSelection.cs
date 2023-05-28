using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFSelection", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class PdfSelection : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddSelection_ = "addSelection:";

	private static readonly IntPtr selAddSelection_Handle = Selector.GetHandle("addSelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddSelections_ = "addSelections:";

	private static readonly IntPtr selAddSelections_Handle = Selector.GetHandle("addSelections:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributedString = "attributedString";

	private static readonly IntPtr selAttributedStringHandle = Selector.GetHandle("attributedString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundsForPage_ = "boundsForPage:";

	private static readonly IntPtr selBoundsForPage_Handle = Selector.GetHandle("boundsForPage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColor = "color";

	private static readonly IntPtr selColorHandle = Selector.GetHandle("color");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawForPage_Active_ = "drawForPage:active:";

	private static readonly IntPtr selDrawForPage_Active_Handle = Selector.GetHandle("drawForPage:active:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawForPage_WithBox_Active_ = "drawForPage:withBox:active:";

	private static readonly IntPtr selDrawForPage_WithBox_Active_Handle = Selector.GetHandle("drawForPage:withBox:active:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtendSelectionAtEnd_ = "extendSelectionAtEnd:";

	private static readonly IntPtr selExtendSelectionAtEnd_Handle = Selector.GetHandle("extendSelectionAtEnd:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtendSelectionAtStart_ = "extendSelectionAtStart:";

	private static readonly IntPtr selExtendSelectionAtStart_Handle = Selector.GetHandle("extendSelectionAtStart:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtendSelectionForLineBoundaries = "extendSelectionForLineBoundaries";

	private static readonly IntPtr selExtendSelectionForLineBoundariesHandle = Selector.GetHandle("extendSelectionForLineBoundaries");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDocument_ = "initWithDocument:";

	private static readonly IntPtr selInitWithDocument_Handle = Selector.GetHandle("initWithDocument:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfTextRangesOnPage_ = "numberOfTextRangesOnPage:";

	private static readonly IntPtr selNumberOfTextRangesOnPage_Handle = Selector.GetHandle("numberOfTextRangesOnPage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPages = "pages";

	private static readonly IntPtr selPagesHandle = Selector.GetHandle("pages");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangeAtIndex_OnPage_ = "rangeAtIndex:onPage:";

	private static readonly IntPtr selRangeAtIndex_OnPage_Handle = Selector.GetHandle("rangeAtIndex:onPage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionsByLine = "selectionsByLine";

	private static readonly IntPtr selSelectionsByLineHandle = Selector.GetHandle("selectionsByLine");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColor_ = "setColor:";

	private static readonly IntPtr selSetColor_Handle = Selector.GetHandle("setColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selString = "string";

	private static readonly IntPtr selStringHandle = Selector.GetHandle("string");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PDFSelection");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString? AttributedString
	{
		[Export("attributedString")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributedStringHandle));
			}
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributedStringHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor? Color
	{
		[Export("color", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorHandle));
		}
		[Export("setColor:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColor_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColor_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfPage[] Pages
	{
		[Export("pages")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<PdfPage>(Messaging.IntPtr_objc_msgSend(base.Handle, selPagesHandle));
			}
			return NSArray.ArrayFromHandle<PdfPage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPagesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Text
	{
		[Export("string")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected PdfSelection(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PdfSelection(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDocument:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public PdfSelection(PdfDocument document)
		: base(NSObjectFlag.Empty)
	{
		if (document == null)
		{
			throw new ArgumentNullException("document");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithDocument_Handle, document.Handle), "initWithDocument:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithDocument_Handle, document.Handle), "initWithDocument:");
		}
	}

	[Export("addSelection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddSelection(PdfSelection selection)
	{
		if (selection == null)
		{
			throw new ArgumentNullException("selection");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddSelection_Handle, selection.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSelection_Handle, selection.Handle);
		}
	}

	[Export("addSelections:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddSelections(PdfSelection[] selections)
	{
		if (selections == null)
		{
			throw new ArgumentNullException("selections");
		}
		NSArray nSArray = NSArray.FromNSObjects(selections);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddSelections_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSelections_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("drawForPage:active:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Draw(PdfPage page, bool active)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selDrawForPage_Active_Handle, page.Handle, active);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selDrawForPage_Active_Handle, page.Handle, active);
		}
	}

	[Export("drawForPage:withBox:active:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Draw(PdfPage page, PdfDisplayBox box, bool active)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64_bool(base.Handle, selDrawForPage_WithBox_Active_Handle, page.Handle, (long)box, active);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64_bool(base.SuperHandle, selDrawForPage_WithBox_Active_Handle, page.Handle, (long)box, active);
		}
	}

	[Export("extendSelectionAtEnd:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ExtendSelectionAtEnd(nint succeed)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selExtendSelectionAtEnd_Handle, succeed);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selExtendSelectionAtEnd_Handle, succeed);
		}
	}

	[Export("extendSelectionAtStart:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ExtendSelectionAtStart(nint precede)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selExtendSelectionAtStart_Handle, precede);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selExtendSelectionAtStart_Handle, precede);
		}
	}

	[Export("extendSelectionForLineBoundaries")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ExtendSelectionForLineBoundaries()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selExtendSelectionForLineBoundariesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selExtendSelectionForLineBoundariesHandle);
		}
	}

	[Export("boundsForPage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetBoundsForPage(PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr(out retval, base.Handle, selBoundsForPage_Handle, page.Handle);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr(out retval, base.SuperHandle, selBoundsForPage_Handle, page.Handle);
		}
		return retval;
	}

	[Export("numberOfTextRangesOnPage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetNumberOfTextRanges(PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr(base.Handle, selNumberOfTextRangesOnPage_Handle, page.Handle);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr(base.SuperHandle, selNumberOfTextRangesOnPage_Handle, page.Handle);
	}

	[Export("rangeAtIndex:onPage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange GetRange(nuint index, PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_nuint_IntPtr(base.Handle, selRangeAtIndex_OnPage_Handle, index, page.Handle);
		}
		return Messaging.NSRange_objc_msgSendSuper_nuint_IntPtr(base.SuperHandle, selRangeAtIndex_OnPage_Handle, index, page.Handle);
	}

	[Export("selectionsByLine")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfSelection[] SelectionsByLine()
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<PdfSelection>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectionsByLineHandle));
		}
		return NSArray.ArrayFromHandle<PdfSelection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectionsByLineHandle));
	}
}

using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFPage", true)]
public class PdfPage : NSObject
{
	private static readonly IntPtr selDocumentHandle = Selector.GetHandle("document");

	private static readonly IntPtr selLabelHandle = Selector.GetHandle("label");

	private static readonly IntPtr selRotationHandle = Selector.GetHandle("rotation");

	private static readonly IntPtr selSetRotation_Handle = Selector.GetHandle("setRotation:");

	private static readonly IntPtr selAnnotationsHandle = Selector.GetHandle("annotations");

	private static readonly IntPtr selDisplaysAnnotationsHandle = Selector.GetHandle("displaysAnnotations");

	private static readonly IntPtr selSetDisplaysAnnotations_Handle = Selector.GetHandle("setDisplaysAnnotations:");

	private static readonly IntPtr selNumberOfCharactersHandle = Selector.GetHandle("numberOfCharacters");

	private static readonly IntPtr selStringHandle = Selector.GetHandle("string");

	private static readonly IntPtr selAttributedStringHandle = Selector.GetHandle("attributedString");

	private static readonly IntPtr selDataRepresentationHandle = Selector.GetHandle("dataRepresentation");

	private static readonly IntPtr selInitWithImage_Handle = Selector.GetHandle("initWithImage:");

	private static readonly IntPtr selBoundsForBox_Handle = Selector.GetHandle("boundsForBox:");

	private static readonly IntPtr selSetBoundsForBox_Handle = Selector.GetHandle("setBounds:forBox:");

	private static readonly IntPtr selAddAnnotation_Handle = Selector.GetHandle("addAnnotation:");

	private static readonly IntPtr selRemoveAnnotation_Handle = Selector.GetHandle("removeAnnotation:");

	private static readonly IntPtr selAnnotationAtPoint_Handle = Selector.GetHandle("annotationAtPoint:");

	private static readonly IntPtr selDrawWithBox_Handle = Selector.GetHandle("drawWithBox:");

	private static readonly IntPtr selTransformContextForBox_Handle = Selector.GetHandle("transformContextForBox:");

	private static readonly IntPtr selCharacterBoundsAtIndex_Handle = Selector.GetHandle("characterBoundsAtIndex:");

	private static readonly IntPtr selCharacterIndexAtPoint_Handle = Selector.GetHandle("characterIndexAtPoint:");

	private static readonly IntPtr selSelectionForRect_Handle = Selector.GetHandle("selectionForRect:");

	private static readonly IntPtr selSelectionForWordAtPoint_Handle = Selector.GetHandle("selectionForWordAtPoint:");

	private static readonly IntPtr selSelectionForLineAtPoint_Handle = Selector.GetHandle("selectionForLineAtPoint:");

	private static readonly IntPtr selSelectionFromPointToPoint_Handle = Selector.GetHandle("selectionFromPoint:toPoint:");

	private static readonly IntPtr selSelectionForRange_Handle = Selector.GetHandle("selectionForRange:");

	private static readonly IntPtr class_ptr = Class.GetHandle("PDFPage");

	private object __mt_Document_var;

	private object __mt_Annotations_var;

	private object __mt_AttributedString_var;

	private object __mt_DataRepresentation_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual PdfDocument Document
	{
		[Export("document")]
		get
		{
			return (PdfDocument)(__mt_Document_var = ((!IsDirectBinding) ? ((PdfDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentHandle))) : ((PdfDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentHandle)))));
		}
	}

	public virtual string Label
	{
		[Export("label")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLabelHandle));
		}
	}

	public virtual long Rotation
	{
		[Export("rotation")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selRotationHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selRotationHandle);
		}
		[Export("setRotation:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetRotation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetRotation_Handle, value);
			}
		}
	}

	public virtual PdfAnnotation[] Annotations
	{
		[Export("annotations")]
		get
		{
			return (PdfAnnotation[])(__mt_Annotations_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<PdfAnnotation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnnotationsHandle)) : NSArray.ArrayFromHandle<PdfAnnotation>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnnotationsHandle))));
		}
	}

	public virtual bool DisplaysAnnotations
	{
		[Export("displaysAnnotations")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisplaysAnnotationsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisplaysAnnotationsHandle);
		}
		[Export("setDisplaysAnnotations:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplaysAnnotations_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplaysAnnotations_Handle, value);
			}
		}
	}

	public virtual ulong CharacterCount
	{
		[Export("numberOfCharacters")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selNumberOfCharactersHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selNumberOfCharactersHandle);
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

	public virtual NSData DataRepresentation
	{
		[Export("dataRepresentation")]
		get
		{
			return (NSData)(__mt_DataRepresentation_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataRepresentationHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDataRepresentationHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfPage()
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
	public PdfPage(NSCoder coder)
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
	public PdfPage(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public PdfPage(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithImage:")]
	public PdfPage(NSImage image)
		: base(NSObjectFlag.Empty)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithImage_Handle, image.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithImage_Handle, image.Handle);
		}
	}

	[Export("boundsForBox:")]
	public virtual CGRect GetBoundsForBox(PdfDisplayBox box)
	{
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_int(out retval, base.Handle, selBoundsForBox_Handle, (int)box);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_int(out retval, base.SuperHandle, selBoundsForBox_Handle, (int)box);
		}
		return retval;
	}

	[Export("setBounds:forBox:")]
	public virtual void SetBoundsForBox(CGRect bounds, PdfDisplayBox box)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_int(base.Handle, selSetBoundsForBox_Handle, bounds, (int)box);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_int(base.SuperHandle, selSetBoundsForBox_Handle, bounds, (int)box);
		}
	}

	[Export("addAnnotation:")]
	public virtual void AddAnnotation(PdfAnnotation annotation)
	{
		if (annotation == null)
		{
			throw new ArgumentNullException("annotation");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddAnnotation_Handle, annotation.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddAnnotation_Handle, annotation.Handle);
		}
	}

	[Export("removeAnnotation:")]
	public virtual void RemoveAnnotation(PdfAnnotation annotation)
	{
		if (annotation == null)
		{
			throw new ArgumentNullException("annotation");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveAnnotation_Handle, annotation.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveAnnotation_Handle, annotation.Handle);
		}
	}

	[Export("annotationAtPoint:")]
	public virtual PdfAnnotation GetAnnotation(CGPoint point)
	{
		if (IsDirectBinding)
		{
			return (PdfAnnotation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGPoint(base.Handle, selAnnotationAtPoint_Handle, point));
		}
		return (PdfAnnotation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGPoint(base.SuperHandle, selAnnotationAtPoint_Handle, point));
	}

	[Export("drawWithBox:")]
	public virtual void Draw(PdfDisplayBox box)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int(base.Handle, selDrawWithBox_Handle, (int)box);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selDrawWithBox_Handle, (int)box);
		}
	}

	[Export("transformContextForBox:")]
	public virtual void TransformContext(PdfDisplayBox box)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int(base.Handle, selTransformContextForBox_Handle, (int)box);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selTransformContextForBox_Handle, (int)box);
		}
	}

	[Export("characterBoundsAtIndex:")]
	public virtual CGRect GetCharacterBounds(long index)
	{
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_Int64(out retval, base.Handle, selCharacterBoundsAtIndex_Handle, index);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_Int64(out retval, base.SuperHandle, selCharacterBoundsAtIndex_Handle, index);
		}
		return retval;
	}

	[Export("characterIndexAtPoint:")]
	public virtual long GetCharacterIndex(CGPoint point)
	{
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_CGPoint(base.Handle, selCharacterIndexAtPoint_Handle, point);
		}
		return Messaging.Int64_objc_msgSendSuper_CGPoint(base.SuperHandle, selCharacterIndexAtPoint_Handle, point);
	}

	[Export("selectionForRect:")]
	public virtual PdfSelection GetSelection(CGRect rect)
	{
		if (IsDirectBinding)
		{
			return (PdfSelection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selSelectionForRect_Handle, rect));
		}
		return (PdfSelection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selSelectionForRect_Handle, rect));
	}

	[Export("selectionForWordAtPoint:")]
	public virtual PdfSelection SelectWord(CGPoint point)
	{
		if (IsDirectBinding)
		{
			return (PdfSelection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGPoint(base.Handle, selSelectionForWordAtPoint_Handle, point));
		}
		return (PdfSelection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGPoint(base.SuperHandle, selSelectionForWordAtPoint_Handle, point));
	}

	[Export("selectionForLineAtPoint:")]
	public virtual PdfSelection SelectLine(CGPoint point)
	{
		if (IsDirectBinding)
		{
			return (PdfSelection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGPoint(base.Handle, selSelectionForLineAtPoint_Handle, point));
		}
		return (PdfSelection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGPoint(base.SuperHandle, selSelectionForLineAtPoint_Handle, point));
	}

	[Export("selectionFromPoint:toPoint:")]
	public virtual PdfSelection GetSelection(CGPoint startPoint, CGPoint endPoint)
	{
		if (IsDirectBinding)
		{
			return (PdfSelection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGPoint_CGPoint(base.Handle, selSelectionFromPointToPoint_Handle, startPoint, endPoint));
		}
		return (PdfSelection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGPoint_CGPoint(base.SuperHandle, selSelectionFromPointToPoint_Handle, startPoint, endPoint));
	}

	[Export("selectionForRange:")]
	public virtual PdfSelection GetSelection(NSRange range)
	{
		if (IsDirectBinding)
		{
			return (PdfSelection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selSelectionForRange_Handle, range));
		}
		return (PdfSelection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selSelectionForRange_Handle, range));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Document_var = null;
			__mt_Annotations_var = null;
			__mt_AttributedString_var = null;
			__mt_DataRepresentation_var = null;
		}
	}
}

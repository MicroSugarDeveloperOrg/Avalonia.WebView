using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFPage", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class PdfPage : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddAnnotation_ = "addAnnotation:";

	private static readonly IntPtr selAddAnnotation_Handle = Selector.GetHandle("addAnnotation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnnotationAtPoint_ = "annotationAtPoint:";

	private static readonly IntPtr selAnnotationAtPoint_Handle = Selector.GetHandle("annotationAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnnotations = "annotations";

	private static readonly IntPtr selAnnotationsHandle = Selector.GetHandle("annotations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributedString = "attributedString";

	private static readonly IntPtr selAttributedStringHandle = Selector.GetHandle("attributedString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundsForBox_ = "boundsForBox:";

	private static readonly IntPtr selBoundsForBox_Handle = Selector.GetHandle("boundsForBox:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharacterBoundsAtIndex_ = "characterBoundsAtIndex:";

	private static readonly IntPtr selCharacterBoundsAtIndex_Handle = Selector.GetHandle("characterBoundsAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharacterIndexAtPoint_ = "characterIndexAtPoint:";

	private static readonly IntPtr selCharacterIndexAtPoint_Handle = Selector.GetHandle("characterIndexAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataRepresentation = "dataRepresentation";

	private static readonly IntPtr selDataRepresentationHandle = Selector.GetHandle("dataRepresentation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplaysAnnotations = "displaysAnnotations";

	private static readonly IntPtr selDisplaysAnnotationsHandle = Selector.GetHandle("displaysAnnotations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocument = "document";

	private static readonly IntPtr selDocumentHandle = Selector.GetHandle("document");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawWithBox_ = "drawWithBox:";

	private static readonly IntPtr selDrawWithBox_Handle = Selector.GetHandle("drawWithBox:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawWithBox_ToContext_ = "drawWithBox:toContext:";

	private static readonly IntPtr selDrawWithBox_ToContext_Handle = Selector.GetHandle("drawWithBox:toContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithImage_ = "initWithImage:";

	private static readonly IntPtr selInitWithImage_Handle = Selector.GetHandle("initWithImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabel = "label";

	private static readonly IntPtr selLabelHandle = Selector.GetHandle("label");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfCharacters = "numberOfCharacters";

	private static readonly IntPtr selNumberOfCharactersHandle = Selector.GetHandle("numberOfCharacters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPageRef = "pageRef";

	private static readonly IntPtr selPageRefHandle = Selector.GetHandle("pageRef");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAnnotation_ = "removeAnnotation:";

	private static readonly IntPtr selRemoveAnnotation_Handle = Selector.GetHandle("removeAnnotation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRotation = "rotation";

	private static readonly IntPtr selRotationHandle = Selector.GetHandle("rotation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionForLineAtPoint_ = "selectionForLineAtPoint:";

	private static readonly IntPtr selSelectionForLineAtPoint_Handle = Selector.GetHandle("selectionForLineAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionForRange_ = "selectionForRange:";

	private static readonly IntPtr selSelectionForRange_Handle = Selector.GetHandle("selectionForRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionForRect_ = "selectionForRect:";

	private static readonly IntPtr selSelectionForRect_Handle = Selector.GetHandle("selectionForRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionForWordAtPoint_ = "selectionForWordAtPoint:";

	private static readonly IntPtr selSelectionForWordAtPoint_Handle = Selector.GetHandle("selectionForWordAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionFromPoint_ToPoint_ = "selectionFromPoint:toPoint:";

	private static readonly IntPtr selSelectionFromPoint_ToPoint_Handle = Selector.GetHandle("selectionFromPoint:toPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBounds_ForBox_ = "setBounds:forBox:";

	private static readonly IntPtr selSetBounds_ForBox_Handle = Selector.GetHandle("setBounds:forBox:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisplaysAnnotations_ = "setDisplaysAnnotations:";

	private static readonly IntPtr selSetDisplaysAnnotations_Handle = Selector.GetHandle("setDisplaysAnnotations:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRotation_ = "setRotation:";

	private static readonly IntPtr selSetRotation_Handle = Selector.GetHandle("setRotation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selString = "string";

	private static readonly IntPtr selStringHandle = Selector.GetHandle("string");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selThumbnailOfSize_ForBox_ = "thumbnailOfSize:forBox:";

	private static readonly IntPtr selThumbnailOfSize_ForBox_Handle = Selector.GetHandle("thumbnailOfSize:forBox:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransformContext_ForBox_ = "transformContext:forBox:";

	private static readonly IntPtr selTransformContext_ForBox_Handle = Selector.GetHandle("transformContext:forBox:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransformContextForBox_ = "transformContextForBox:";

	private static readonly IntPtr selTransformContextForBox_Handle = Selector.GetHandle("transformContextForBox:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransformForBox_ = "transformForBox:";

	private static readonly IntPtr selTransformForBox_Handle = Selector.GetHandle("transformForBox:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PDFPage");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfAnnotation[] Annotations
	{
		[Export("annotations")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<PdfAnnotation>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnnotationsHandle));
			}
			return NSArray.ArrayFromHandle<PdfAnnotation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnnotationsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString AttributedString
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
	public virtual nint CharacterCount
	{
		[Export("numberOfCharacters")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfCharactersHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfCharactersHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? DataRepresentation
	{
		[Export("dataRepresentation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataRepresentationHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataRepresentationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DisplaysAnnotations
	{
		[Export("displaysAnnotations")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDisplaysAnnotationsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDisplaysAnnotationsHandle);
		}
		[Export("setDisplaysAnnotations:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDisplaysAnnotations_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDisplaysAnnotations_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfDocument? Document
	{
		[Export("document")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<PdfDocument>(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentHandle));
			}
			return Runtime.GetNSObject<PdfDocument>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Label
	{
		[Export("label")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLabelHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPDFPage? Page
	{
		[Export("pageRef")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPageRefHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selPageRefHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGPDFPage(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Rotation
	{
		[Export("rotation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selRotationHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selRotationHandle);
		}
		[Export("setRotation:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetRotation_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetRotation_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Text
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
	protected PdfPage(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PdfPage(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public PdfPage()
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

	[Export("initWithImage:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public PdfPage(NSImage image)
		: base(NSObjectFlag.Empty)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithImage_Handle, image.Handle), "initWithImage:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithImage_Handle, image.Handle), "initWithImage:");
		}
	}

	[Export("addAnnotation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddAnnotation(PdfAnnotation annotation)
	{
		if (annotation == null)
		{
			throw new ArgumentNullException("annotation");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddAnnotation_Handle, annotation.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddAnnotation_Handle, annotation.Handle);
		}
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

	[Export("drawWithBox:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Draw(PdfDisplayBox box)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selDrawWithBox_Handle, (long)box);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selDrawWithBox_Handle, (long)box);
		}
	}

	[Export("drawWithBox:toContext:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Draw(PdfDisplayBox box, CGContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_IntPtr(base.Handle, selDrawWithBox_ToContext_Handle, (long)box, context.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr(base.SuperHandle, selDrawWithBox_ToContext_Handle, (long)box, context.Handle);
		}
	}

	[Export("annotationAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfAnnotation? GetAnnotation(CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<PdfAnnotation>(Messaging.IntPtr_objc_msgSend_CGPoint(base.Handle, selAnnotationAtPoint_Handle, point));
		}
		return Runtime.GetNSObject<PdfAnnotation>(Messaging.IntPtr_objc_msgSendSuper_CGPoint(base.SuperHandle, selAnnotationAtPoint_Handle, point));
	}

	[Export("boundsForBox:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetBoundsForBox(PdfDisplayBox box)
	{
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_Int64(out retval, base.Handle, selBoundsForBox_Handle, (long)box);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_Int64(out retval, base.SuperHandle, selBoundsForBox_Handle, (long)box);
		}
		return retval;
	}

	[Export("characterBoundsAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetCharacterBounds(nint index)
	{
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_nint(out retval, base.Handle, selCharacterBoundsAtIndex_Handle, index);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_nint(out retval, base.SuperHandle, selCharacterBoundsAtIndex_Handle, index);
		}
		return retval;
	}

	[Export("characterIndexAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetCharacterIndex(CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_CGPoint(base.Handle, selCharacterIndexAtPoint_Handle, point);
		}
		return Messaging.nint_objc_msgSendSuper_CGPoint(base.SuperHandle, selCharacterIndexAtPoint_Handle, point);
	}

	[Export("selectionForRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfSelection? GetSelection(CGRect rect)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<PdfSelection>(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selSelectionForRect_Handle, rect));
		}
		return Runtime.GetNSObject<PdfSelection>(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selSelectionForRect_Handle, rect));
	}

	[Export("selectionFromPoint:toPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfSelection? GetSelection(CGPoint startPoint, CGPoint endPoint)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<PdfSelection>(Messaging.IntPtr_objc_msgSend_CGPoint_CGPoint(base.Handle, selSelectionFromPoint_ToPoint_Handle, startPoint, endPoint));
		}
		return Runtime.GetNSObject<PdfSelection>(Messaging.IntPtr_objc_msgSendSuper_CGPoint_CGPoint(base.SuperHandle, selSelectionFromPoint_ToPoint_Handle, startPoint, endPoint));
	}

	[Export("selectionForRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfSelection? GetSelection(NSRange range)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<PdfSelection>(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selSelectionForRange_Handle, range));
		}
		return Runtime.GetNSObject<PdfSelection>(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selSelectionForRange_Handle, range));
	}

	[Export("thumbnailOfSize:forBox:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage GetThumbnail(CGSize size, PdfDisplayBox box)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend_CGSize_Int64(base.Handle, selThumbnailOfSize_ForBox_Handle, size, (long)box));
		}
		return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper_CGSize_Int64(base.SuperHandle, selThumbnailOfSize_ForBox_Handle, size, (long)box));
	}

	[Export("transformForBox:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGAffineTransform GetTransform(PdfDisplayBox box)
	{
		CGAffineTransform retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGAffineTransform_objc_msgSend_stret_Int64(out retval, base.Handle, selTransformForBox_Handle, (long)box);
		}
		else
		{
			Messaging.CGAffineTransform_objc_msgSendSuper_stret_Int64(out retval, base.SuperHandle, selTransformForBox_Handle, (long)box);
		}
		return retval;
	}

	[Export("removeAnnotation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAnnotation(PdfAnnotation annotation)
	{
		if (annotation == null)
		{
			throw new ArgumentNullException("annotation");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveAnnotation_Handle, annotation.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveAnnotation_Handle, annotation.Handle);
		}
	}

	[Export("selectionForLineAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfSelection? SelectLine(CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<PdfSelection>(Messaging.IntPtr_objc_msgSend_CGPoint(base.Handle, selSelectionForLineAtPoint_Handle, point));
		}
		return Runtime.GetNSObject<PdfSelection>(Messaging.IntPtr_objc_msgSendSuper_CGPoint(base.SuperHandle, selSelectionForLineAtPoint_Handle, point));
	}

	[Export("selectionForWordAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfSelection? SelectWord(CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<PdfSelection>(Messaging.IntPtr_objc_msgSend_CGPoint(base.Handle, selSelectionForWordAtPoint_Handle, point));
		}
		return Runtime.GetNSObject<PdfSelection>(Messaging.IntPtr_objc_msgSendSuper_CGPoint(base.SuperHandle, selSelectionForWordAtPoint_Handle, point));
	}

	[Export("setBounds:forBox:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetBoundsForBox(CGRect bounds, PdfDisplayBox box)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_Int64(base.Handle, selSetBounds_ForBox_Handle, bounds, (long)box);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_Int64(base.SuperHandle, selSetBounds_ForBox_Handle, bounds, (long)box);
		}
	}

	[Export("transformContext:forBox:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TransformContext(CGContext context, PdfDisplayBox box)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selTransformContext_ForBox_Handle, context.Handle, (long)box);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selTransformContext_ForBox_Handle, context.Handle, (long)box);
		}
	}

	[Export("transformContextForBox:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TransformContext(PdfDisplayBox box)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selTransformContextForBox_Handle, (long)box);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selTransformContextForBox_Handle, (long)box);
		}
	}
}

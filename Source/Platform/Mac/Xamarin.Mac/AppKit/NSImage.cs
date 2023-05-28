using System;
using System.ComponentModel;
using System.IO;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSImage", true)]
public class NSImage : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSPasteboardReading, INSPasteboardWriting, INSSecureCoding
{
	[Register]
	internal class _NSImageDelegate : NSObject, INSImageDelegate, INativeObject, IDisposable
	{
		internal EventHandler<NSImagePartialEventArgs>? didLoadPartOfRepresentation;

		internal EventHandler<NSImageLoadRepresentationEventArgs>? didLoadRepresentation;

		internal EventHandler<NSImageLoadEventArgs>? didLoadRepresentationHeader;

		internal NSImageRect? imageDidNotDraw;

		internal EventHandler<NSImageLoadEventArgs>? willLoadRepresentation;

		public _NSImageDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("image:didLoadPartOfRepresentation:withValidRows:")]
		public void DidLoadPartOfRepresentation(NSImage image, NSImageRep rep, nint rows)
		{
			EventHandler<NSImagePartialEventArgs> eventHandler = didLoadPartOfRepresentation;
			if (eventHandler != null)
			{
				NSImagePartialEventArgs e = new NSImagePartialEventArgs(rep, rows);
				eventHandler(image, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("image:didLoadRepresentation:withStatus:")]
		public void DidLoadRepresentation(NSImage image, NSImageRep rep, NSImageLoadStatus status)
		{
			EventHandler<NSImageLoadRepresentationEventArgs> eventHandler = didLoadRepresentation;
			if (eventHandler != null)
			{
				NSImageLoadRepresentationEventArgs e = new NSImageLoadRepresentationEventArgs(rep, status);
				eventHandler(image, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("image:didLoadRepresentationHeader:")]
		public void DidLoadRepresentationHeader(NSImage image, NSImageRep rep)
		{
			EventHandler<NSImageLoadEventArgs> eventHandler = didLoadRepresentationHeader;
			if (eventHandler != null)
			{
				NSImageLoadEventArgs e = new NSImageLoadEventArgs(rep);
				eventHandler(image, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("imageDidNotDraw:inRect:")]
		public NSImage ImageDidNotDraw(NSObject sender, CGRect aRect)
		{
			return imageDidNotDraw?.Invoke(sender, aRect);
		}

		[Preserve(Conditional = true)]
		[Export("image:willLoadRepresentation:")]
		public void WillLoadRepresentation(NSImage image, NSImageRep rep)
		{
			EventHandler<NSImageLoadEventArgs> eventHandler = willLoadRepresentation;
			if (eventHandler != null)
			{
				NSImageLoadEventArgs e = new NSImageLoadEventArgs(rep);
				eventHandler(image, e);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCGImageForProposedRect_Context_Hints_ = "CGImageForProposedRect:context:hints:";

	private static readonly IntPtr selCGImageForProposedRect_Context_Hints_Handle = Selector.GetHandle("CGImageForProposedRect:context:hints:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTIFFRepresentation = "TIFFRepresentation";

	private static readonly IntPtr selTIFFRepresentationHandle = Selector.GetHandle("TIFFRepresentation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTIFFRepresentationUsingCompression_Factor_ = "TIFFRepresentationUsingCompression:factor:";

	private static readonly IntPtr selTIFFRepresentationUsingCompression_Factor_Handle = Selector.GetHandle("TIFFRepresentationUsingCompression:factor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessibilityDescription = "accessibilityDescription";

	private static readonly IntPtr selAccessibilityDescriptionHandle = Selector.GetHandle("accessibilityDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddRepresentation_ = "addRepresentation:";

	private static readonly IntPtr selAddRepresentation_Handle = Selector.GetHandle("addRepresentation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddRepresentations_ = "addRepresentations:";

	private static readonly IntPtr selAddRepresentations_Handle = Selector.GetHandle("addRepresentations:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignmentRect = "alignmentRect";

	private static readonly IntPtr selAlignmentRectHandle = Selector.GetHandle("alignmentRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundColor = "backgroundColor";

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBestRepresentationForDevice_ = "bestRepresentationForDevice:";

	private static readonly IntPtr selBestRepresentationForDevice_Handle = Selector.GetHandle("bestRepresentationForDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBestRepresentationForRect_Context_Hints_ = "bestRepresentationForRect:context:hints:";

	private static readonly IntPtr selBestRepresentationForRect_Context_Hints_Handle = Selector.GetHandle("bestRepresentationForRect:context:hints:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCacheMode = "cacheMode";

	private static readonly IntPtr selCacheModeHandle = Selector.GetHandle("cacheMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanInitWithPasteboard_ = "canInitWithPasteboard:";

	private static readonly IntPtr selCanInitWithPasteboard_Handle = Selector.GetHandle("canInitWithPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelIncrementalLoad = "cancelIncrementalLoad";

	private static readonly IntPtr selCancelIncrementalLoadHandle = Selector.GetHandle("cancelIncrementalLoad");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCapInsets = "capInsets";

	private static readonly IntPtr selCapInsetsHandle = Selector.GetHandle("capInsets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawAtPoint_FromRect_Operation_Fraction_ = "drawAtPoint:fromRect:operation:fraction:";

	private static readonly IntPtr selDrawAtPoint_FromRect_Operation_Fraction_Handle = Selector.GetHandle("drawAtPoint:fromRect:operation:fraction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawInRect_ = "drawInRect:";

	private static readonly IntPtr selDrawInRect_Handle = Selector.GetHandle("drawInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawInRect_FromRect_Operation_Fraction_ = "drawInRect:fromRect:operation:fraction:";

	private static readonly IntPtr selDrawInRect_FromRect_Operation_Fraction_Handle = Selector.GetHandle("drawInRect:fromRect:operation:fraction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawInRect_FromRect_Operation_Fraction_RespectFlipped_Hints_ = "drawInRect:fromRect:operation:fraction:respectFlipped:hints:";

	private static readonly IntPtr selDrawInRect_FromRect_Operation_Fraction_RespectFlipped_Hints_Handle = Selector.GetHandle("drawInRect:fromRect:operation:fraction:respectFlipped:hints:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawRepresentation_InRect_ = "drawRepresentation:inRect:";

	private static readonly IntPtr selDrawRepresentation_InRect_Handle = Selector.GetHandle("drawRepresentation:inRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHitTestRect_WithImageDestinationRect_Context_Hints_Flipped_ = "hitTestRect:withImageDestinationRect:context:hints:flipped:";

	private static readonly IntPtr selHitTestRect_WithImageDestinationRect_Context_Hints_Flipped_Handle = Selector.GetHandle("hitTestRect:withImageDestinationRect:context:hints:flipped:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageFileTypes = "imageFileTypes";

	private static readonly IntPtr selImageFileTypesHandle = Selector.GetHandle("imageFileTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageNamed_ = "imageNamed:";

	private static readonly IntPtr selImageNamed_Handle = Selector.GetHandle("imageNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImagePasteboardTypes = "imagePasteboardTypes";

	private static readonly IntPtr selImagePasteboardTypesHandle = Selector.GetHandle("imagePasteboardTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageTypes = "imageTypes";

	private static readonly IntPtr selImageTypesHandle = Selector.GetHandle("imageTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageUnfilteredFileTypes = "imageUnfilteredFileTypes";

	private static readonly IntPtr selImageUnfilteredFileTypesHandle = Selector.GetHandle("imageUnfilteredFileTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageUnfilteredPasteboardTypes = "imageUnfilteredPasteboardTypes";

	private static readonly IntPtr selImageUnfilteredPasteboardTypesHandle = Selector.GetHandle("imageUnfilteredPasteboardTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageUnfilteredTypes = "imageUnfilteredTypes";

	private static readonly IntPtr selImageUnfilteredTypesHandle = Selector.GetHandle("imageUnfilteredTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImageWithSize_Flipped_DrawingHandler_ = "imageWithSize:flipped:drawingHandler:";

	private static readonly IntPtr selImageWithSize_Flipped_DrawingHandler_Handle = Selector.GetHandle("imageWithSize:flipped:drawingHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitByReferencingFile_ = "initByReferencingFile:";

	private static readonly IntPtr selInitByReferencingFile_Handle = Selector.GetHandle("initByReferencingFile:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCGImage_Size_ = "initWithCGImage:size:";

	private static readonly IntPtr selInitWithCGImage_Size_Handle = Selector.GetHandle("initWithCGImage:size:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContentsOfFile_ = "initWithContentsOfFile:";

	private static readonly IntPtr selInitWithContentsOfFile_Handle = Selector.GetHandle("initWithContentsOfFile:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContentsOfURL_ = "initWithContentsOfURL:";

	private static readonly IntPtr selInitWithContentsOfURL_Handle = Selector.GetHandle("initWithContentsOfURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_ = "initWithData:";

	private static readonly IntPtr selInitWithData_Handle = Selector.GetHandle("initWithData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDataIgnoringOrientation_ = "initWithDataIgnoringOrientation:";

	private static readonly IntPtr selInitWithDataIgnoringOrientation_Handle = Selector.GetHandle("initWithDataIgnoringOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPasteboard_ = "initWithPasteboard:";

	private static readonly IntPtr selInitWithPasteboard_Handle = Selector.GetHandle("initWithPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSize_ = "initWithSize:";

	private static readonly IntPtr selInitWithSize_Handle = Selector.GetHandle("initWithSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFlipped = "isFlipped";

	private static readonly IntPtr selIsFlippedHandle = Selector.GetHandle("isFlipped");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsTemplate = "isTemplate";

	private static readonly IntPtr selIsTemplateHandle = Selector.GetHandle("isTemplate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsValid = "isValid";

	private static readonly IntPtr selIsValidHandle = Selector.GetHandle("isValid");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayerContentsForContentsScale_ = "layerContentsForContentsScale:";

	private static readonly IntPtr selLayerContentsForContentsScale_Handle = Selector.GetHandle("layerContentsForContentsScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLockFocus = "lockFocus";

	private static readonly IntPtr selLockFocusHandle = Selector.GetHandle("lockFocus");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLockFocusFlipped_ = "lockFocusFlipped:";

	private static readonly IntPtr selLockFocusFlipped_Handle = Selector.GetHandle("lockFocusFlipped:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchesOnMultipleResolution = "matchesOnMultipleResolution";

	private static readonly IntPtr selMatchesOnMultipleResolutionHandle = Selector.GetHandle("matchesOnMultipleResolution");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchesOnlyOnBestFittingAxis = "matchesOnlyOnBestFittingAxis";

	private static readonly IntPtr selMatchesOnlyOnBestFittingAxisHandle = Selector.GetHandle("matchesOnlyOnBestFittingAxis");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPasteboardPropertyListForType_ = "pasteboardPropertyListForType:";

	private static readonly IntPtr selPasteboardPropertyListForType_Handle = Selector.GetHandle("pasteboardPropertyListForType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrefersColorMatch = "prefersColorMatch";

	private static readonly IntPtr selPrefersColorMatchHandle = Selector.GetHandle("prefersColorMatch");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadableTypesForPasteboard_ = "readableTypesForPasteboard:";

	private static readonly IntPtr selReadableTypesForPasteboard_Handle = Selector.GetHandle("readableTypesForPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadingOptionsForType_Pasteboard_ = "readingOptionsForType:pasteboard:";

	private static readonly IntPtr selReadingOptionsForType_Pasteboard_Handle = Selector.GetHandle("readingOptionsForType:pasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecache = "recache";

	private static readonly IntPtr selRecacheHandle = Selector.GetHandle("recache");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecommendedLayerContentsScale_ = "recommendedLayerContentsScale:";

	private static readonly IntPtr selRecommendedLayerContentsScale_Handle = Selector.GetHandle("recommendedLayerContentsScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveRepresentation_ = "removeRepresentation:";

	private static readonly IntPtr selRemoveRepresentation_Handle = Selector.GetHandle("removeRepresentation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRepresentations = "representations";

	private static readonly IntPtr selRepresentationsHandle = Selector.GetHandle("representations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResizingMode = "resizingMode";

	private static readonly IntPtr selResizingModeHandle = Selector.GetHandle("resizingMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessibilityDescription_ = "setAccessibilityDescription:";

	private static readonly IntPtr selSetAccessibilityDescription_Handle = Selector.GetHandle("setAccessibilityDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlignmentRect_ = "setAlignmentRect:";

	private static readonly IntPtr selSetAlignmentRect_Handle = Selector.GetHandle("setAlignmentRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundColor_ = "setBackgroundColor:";

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCacheMode_ = "setCacheMode:";

	private static readonly IntPtr selSetCacheMode_Handle = Selector.GetHandle("setCacheMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCapInsets_ = "setCapInsets:";

	private static readonly IntPtr selSetCapInsets_Handle = Selector.GetHandle("setCapInsets:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFlipped_ = "setFlipped:";

	private static readonly IntPtr selSetFlipped_Handle = Selector.GetHandle("setFlipped:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMatchesOnMultipleResolution_ = "setMatchesOnMultipleResolution:";

	private static readonly IntPtr selSetMatchesOnMultipleResolution_Handle = Selector.GetHandle("setMatchesOnMultipleResolution:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMatchesOnlyOnBestFittingAxis_ = "setMatchesOnlyOnBestFittingAxis:";

	private static readonly IntPtr selSetMatchesOnlyOnBestFittingAxis_Handle = Selector.GetHandle("setMatchesOnlyOnBestFittingAxis:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrefersColorMatch_ = "setPrefersColorMatch:";

	private static readonly IntPtr selSetPrefersColorMatch_Handle = Selector.GetHandle("setPrefersColorMatch:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResizingMode_ = "setResizingMode:";

	private static readonly IntPtr selSetResizingMode_Handle = Selector.GetHandle("setResizingMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSize_ = "setSize:";

	private static readonly IntPtr selSetSize_Handle = Selector.GetHandle("setSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTemplate_ = "setTemplate:";

	private static readonly IntPtr selSetTemplate_Handle = Selector.GetHandle("setTemplate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUsesEPSOnResolutionMismatch_ = "setUsesEPSOnResolutionMismatch:";

	private static readonly IntPtr selSetUsesEPSOnResolutionMismatch_Handle = Selector.GetHandle("setUsesEPSOnResolutionMismatch:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSize = "size";

	private static readonly IntPtr selSizeHandle = Selector.GetHandle("size");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnlockFocus = "unlockFocus";

	private static readonly IntPtr selUnlockFocusHandle = Selector.GetHandle("unlockFocus");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesEPSOnResolutionMismatch = "usesEPSOnResolutionMismatch";

	private static readonly IntPtr selUsesEPSOnResolutionMismatchHandle = Selector.GetHandle("usesEPSOnResolutionMismatch");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWritableTypesForPasteboard_ = "writableTypesForPasteboard:";

	private static readonly IntPtr selWritableTypesForPasteboard_Handle = Selector.GetHandle("writableTypesForPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWritingOptionsForType_Pasteboard_ = "writingOptionsForType:pasteboard:";

	private static readonly IntPtr selWritingOptionsForType_Pasteboard_Handle = Selector.GetHandle("writingOptionsForType:pasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selXamarinselector_Removed_ = "xamarinselector:removed:";

	private static readonly IntPtr selXamarinselector_Removed_Handle = Selector.GetHandle("xamarinselector:removed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public CGImage CGImage
	{
		get
		{
			CGRect proposedDestRect = CGRect.Empty;
			return AsCGImage(ref proposedDestRect, null, null);
		}
	}

	public string Name
	{
		get
		{
			return GetName();
		}
		set
		{
			SetName(value);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string AccessibilityDescription
	{
		[Export("accessibilityDescription")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityDescriptionHandle));
		}
		[Export("setAccessibilityDescription:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessibilityDescription_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessibilityDescription_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect AlignmentRect
	{
		[Export("alignmentRect")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selAlignmentRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selAlignmentRectHandle);
			}
			return retval;
		}
		[Export("setAlignmentRect:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetAlignmentRect_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetAlignmentRect_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle));
		}
		[Export("setBackgroundColor:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImageCacheMode CacheMode
	{
		[Export("cacheMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSImageCacheMode)Messaging.UInt64_objc_msgSend(base.Handle, selCacheModeHandle);
			}
			return (NSImageCacheMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCacheModeHandle);
		}
		[Export("setCacheMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetCacheMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetCacheMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSEdgeInsets CapInsets
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("capInsets")]
		get
		{
			NSEdgeInsets retval;
			if (base.IsDirectBinding)
			{
				Messaging.NSEdgeInsets_objc_msgSend_stret(out retval, base.Handle, selCapInsetsHandle);
			}
			else
			{
				Messaging.NSEdgeInsets_objc_msgSendSuper_stret(out retval, base.SuperHandle, selCapInsetsHandle);
			}
			return retval;
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setCapInsets:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_NSEdgeInsets(base.Handle, selSetCapInsets_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_NSEdgeInsets(base.SuperHandle, selSetCapInsets_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSImageDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSImageDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "Use DrawInRect with respectContextIsFlipped instead.")]
	public virtual bool Flipped
	{
		[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "Use DrawInRect with respectContextIsFlipped instead.")]
		[Export("isFlipped")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFlippedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFlippedHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "Use DrawInRect with respectContextIsFlipped instead.")]
		[Export("setFlipped:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFlipped_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFlipped_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static string[] ImageFileTypes
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("imageFileTypes")]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selImageFileTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static string[] ImagePasteboardTypes
	{
		[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("imagePasteboardTypes")]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selImagePasteboardTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] ImageTypes
	{
		[Export("imageTypes", ArgumentSemantic.Copy)]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selImageTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] ImageUnfilteredTypes
	{
		[Export("imageUnfilteredTypes", ArgumentSemantic.Copy)]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selImageUnfilteredTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsValid
	{
		[Export("isValid")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsValidHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsValidHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool MatchesOnMultipleResolution
	{
		[Export("matchesOnMultipleResolution")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selMatchesOnMultipleResolutionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selMatchesOnMultipleResolutionHandle);
		}
		[Export("setMatchesOnMultipleResolution:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMatchesOnMultipleResolution_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMatchesOnMultipleResolution_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool MatchesOnlyOnBestFittingAxis
	{
		[Export("matchesOnlyOnBestFittingAxis")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selMatchesOnlyOnBestFittingAxisHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selMatchesOnlyOnBestFittingAxisHandle);
		}
		[Export("setMatchesOnlyOnBestFittingAxis:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMatchesOnlyOnBestFittingAxis_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMatchesOnlyOnBestFittingAxis_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PrefersColorMatch
	{
		[Export("prefersColorMatch")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPrefersColorMatchHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPrefersColorMatchHandle);
		}
		[Export("setPrefersColorMatch:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPrefersColorMatch_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPrefersColorMatch_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSImageResizingMode ResizingMode
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("resizingMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSImageResizingMode)Messaging.Int64_objc_msgSend(base.Handle, selResizingModeHandle);
			}
			return (NSImageResizingMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selResizingModeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setResizingMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetResizingMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetResizingMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize Size
	{
		[Export("size")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selSizeHandle);
		}
		[Export("setSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Template
	{
		[Export("isTemplate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTemplateHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTemplateHandle);
		}
		[Export("setTemplate:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTemplate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTemplate_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UsesEpsOnResolutionMismatch
	{
		[Export("usesEPSOnResolutionMismatch")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesEPSOnResolutionMismatchHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesEPSOnResolutionMismatchHandle);
		}
		[Export("setUsesEPSOnResolutionMismatch:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesEPSOnResolutionMismatch_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesEPSOnResolutionMismatch_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_NSImageDelegate);

	public NSImageRect? ImageDidNotDraw
	{
		get
		{
			return EnsureNSImageDelegate().imageDidNotDraw;
		}
		set
		{
			EnsureNSImageDelegate().imageDidNotDraw = value;
		}
	}

	public event EventHandler<NSImagePartialEventArgs> DidLoadPartOfRepresentation
	{
		add
		{
			_NSImageDelegate nSImageDelegate = EnsureNSImageDelegate();
			nSImageDelegate.didLoadPartOfRepresentation = (EventHandler<NSImagePartialEventArgs>)System.Delegate.Combine(nSImageDelegate.didLoadPartOfRepresentation, value);
		}
		remove
		{
			_NSImageDelegate nSImageDelegate = EnsureNSImageDelegate();
			nSImageDelegate.didLoadPartOfRepresentation = (EventHandler<NSImagePartialEventArgs>)System.Delegate.Remove(nSImageDelegate.didLoadPartOfRepresentation, value);
		}
	}

	public event EventHandler<NSImageLoadRepresentationEventArgs> DidLoadRepresentation
	{
		add
		{
			_NSImageDelegate nSImageDelegate = EnsureNSImageDelegate();
			nSImageDelegate.didLoadRepresentation = (EventHandler<NSImageLoadRepresentationEventArgs>)System.Delegate.Combine(nSImageDelegate.didLoadRepresentation, value);
		}
		remove
		{
			_NSImageDelegate nSImageDelegate = EnsureNSImageDelegate();
			nSImageDelegate.didLoadRepresentation = (EventHandler<NSImageLoadRepresentationEventArgs>)System.Delegate.Remove(nSImageDelegate.didLoadRepresentation, value);
		}
	}

	public event EventHandler<NSImageLoadEventArgs> DidLoadRepresentationHeader
	{
		add
		{
			_NSImageDelegate nSImageDelegate = EnsureNSImageDelegate();
			nSImageDelegate.didLoadRepresentationHeader = (EventHandler<NSImageLoadEventArgs>)System.Delegate.Combine(nSImageDelegate.didLoadRepresentationHeader, value);
		}
		remove
		{
			_NSImageDelegate nSImageDelegate = EnsureNSImageDelegate();
			nSImageDelegate.didLoadRepresentationHeader = (EventHandler<NSImageLoadEventArgs>)System.Delegate.Remove(nSImageDelegate.didLoadRepresentationHeader, value);
		}
	}

	public event EventHandler<NSImageLoadEventArgs> WillLoadRepresentation
	{
		add
		{
			_NSImageDelegate nSImageDelegate = EnsureNSImageDelegate();
			nSImageDelegate.willLoadRepresentation = (EventHandler<NSImageLoadEventArgs>)System.Delegate.Combine(nSImageDelegate.willLoadRepresentation, value);
		}
		remove
		{
			_NSImageDelegate nSImageDelegate = EnsureNSImageDelegate();
			nSImageDelegate.willLoadRepresentation = (EventHandler<NSImageLoadEventArgs>)System.Delegate.Remove(nSImageDelegate.willLoadRepresentation, value);
		}
	}

	public static NSImage FromStream(Stream stream)
	{
		using NSData data = NSData.FromStream(stream);
		return new NSImage(data);
	}

	public NSImage(string fileName, bool lazy)
	{
		if (lazy)
		{
			base.Handle = InitByReferencingFile(fileName);
		}
		else
		{
			base.Handle = InitWithContentsOfFile(fileName);
		}
	}

	public NSImage(NSData data, bool ignoresOrientation)
	{
		if (ignoresOrientation)
		{
			base.Handle = InitWithDataIgnoringOrientation(data);
		}
		else
		{
			base.Handle = InitWithData(data);
		}
	}

	public static NSImage ImageNamed(NSImageName name)
	{
		return ImageNamed(name.GetConstant());
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSImage()
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
	public NSImage(NSCoder coder)
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
	protected NSImage(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSImage(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSize:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSImage(CGSize aSize)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGSize(base.Handle, selInitWithSize_Handle, aSize), "initWithSize:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGSize(base.SuperHandle, selInitWithSize_Handle, aSize), "initWithSize:");
		}
	}

	[Export("initWithData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSImage(NSData data)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithData_Handle, data.Handle), "initWithData:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithData_Handle, data.Handle), "initWithData:");
		}
	}

	[Export("initWithContentsOfFile:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSImage(string fileName)
		: base(NSObjectFlag.Empty)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		IntPtr arg = NSString.CreateNative(fileName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithContentsOfFile_Handle, arg), "initWithContentsOfFile:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithContentsOfFile_Handle, arg), "initWithContentsOfFile:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithContentsOfURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSImage(NSUrl url)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithContentsOfURL_Handle, url.Handle), "initWithContentsOfURL:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithContentsOfURL_Handle, url.Handle), "initWithContentsOfURL:");
		}
	}

	[Export("initWithPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSImage(NSPasteboard pasteboard)
		: base(NSObjectFlag.Empty)
	{
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPasteboard_Handle, pasteboard.Handle), "initWithPasteboard:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPasteboard_Handle, pasteboard.Handle), "initWithPasteboard:");
		}
	}

	[Export("initWithCGImage:size:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSImage(CGImage cgImage, CGSize size)
		: base(NSObjectFlag.Empty)
	{
		if (cgImage == null)
		{
			throw new ArgumentNullException("cgImage");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_CGSize(base.Handle, selInitWithCGImage_Size_Handle, cgImage.Handle, size), "initWithCGImage:size:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_CGSize(base.SuperHandle, selInitWithCGImage_Size_Handle, cgImage.Handle, size), "initWithCGImage:size:");
		}
	}

	[Export("addRepresentation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddRepresentation(NSImageRep imageRep)
	{
		if (imageRep == null)
		{
			throw new ArgumentNullException("imageRep");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddRepresentation_Handle, imageRep.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddRepresentation_Handle, imageRep.Handle);
		}
	}

	[Export("addRepresentations:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddRepresentations(NSImageRep[] imageReps)
	{
		if (imageReps == null)
		{
			throw new ArgumentNullException("imageReps");
		}
		NSArray nSArray = NSArray.FromNSObjects(imageReps);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddRepresentations_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddRepresentations_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("CGImageForProposedRect:context:hints:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGImage AsCGImage(ref CGRect proposedDestRect, NSGraphicsContext? referenceContext, NSDictionary? hints)
	{
		IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_ref_CGRect_IntPtr_IntPtr(base.SuperHandle, selCGImageForProposedRect_Context_Hints_Handle, ref proposedDestRect, referenceContext?.Handle ?? IntPtr.Zero, hints?.Handle ?? IntPtr.Zero) : Messaging.IntPtr_objc_msgSend_ref_CGRect_IntPtr_IntPtr(base.Handle, selCGImageForProposedRect_Context_Hints_Handle, ref proposedDestRect, referenceContext?.Handle ?? IntPtr.Zero, hints?.Handle ?? IntPtr.Zero));
		return (intPtr == IntPtr.Zero) ? null : new CGImage(intPtr);
	}

	[Export("TIFFRepresentation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData AsTiff()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selTIFFRepresentationHandle));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTIFFRepresentationHandle));
	}

	[Export("TIFFRepresentationUsingCompression:factor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData AsTiff(NSTiffCompression comp, float aFloat)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_UInt64_float(base.Handle, selTIFFRepresentationUsingCompression_Factor_Handle, (ulong)comp, aFloat));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_UInt64_float(base.SuperHandle, selTIFFRepresentationUsingCompression_Factor_Handle, (ulong)comp, aFloat));
	}

	[Export("bestRepresentationForRect:context:hints:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImageRep BestRepresentation(CGRect rect, NSGraphicsContext? referenceContext, NSDictionary? hints)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSImageRep>(Messaging.IntPtr_objc_msgSend_CGRect_IntPtr_IntPtr(base.Handle, selBestRepresentationForRect_Context_Hints_Handle, rect, referenceContext?.Handle ?? IntPtr.Zero, hints?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject<NSImageRep>(Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr_IntPtr(base.SuperHandle, selBestRepresentationForRect_Context_Hints_Handle, rect, referenceContext?.Handle ?? IntPtr.Zero, hints?.Handle ?? IntPtr.Zero));
	}

	[Export("bestRepresentationForDevice:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImageRep BestRepresentationForDevice(NSDictionary? deviceDescription)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSImageRep>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selBestRepresentationForDevice_Handle, deviceDescription?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject<NSImageRep>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selBestRepresentationForDevice_Handle, deviceDescription?.Handle ?? IntPtr.Zero));
	}

	[Export("canInitWithPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool CanInitWithPasteboard(NSPasteboard pasteboard)
	{
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return Messaging.bool_objc_msgSend_IntPtr(class_ptr, selCanInitWithPasteboard_Handle, pasteboard.Handle);
	}

	[Export("cancelIncrementalLoad")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelIncrementalLoad()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelIncrementalLoadHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelIncrementalLoadHandle);
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

	[Export("drawAtPoint:fromRect:operation:fraction:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Draw(CGPoint point, CGRect fromRect, NSCompositingOperation op, nfloat delta)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_CGRect_UInt64_nfloat(base.Handle, selDrawAtPoint_FromRect_Operation_Fraction_Handle, point, fromRect, (ulong)op, delta);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_CGRect_UInt64_nfloat(base.SuperHandle, selDrawAtPoint_FromRect_Operation_Fraction_Handle, point, fromRect, (ulong)op, delta);
		}
	}

	[Export("drawInRect:fromRect:operation:fraction:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Draw(CGRect rect, CGRect fromRect, NSCompositingOperation op, nfloat delta)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_CGRect_UInt64_nfloat(base.Handle, selDrawInRect_FromRect_Operation_Fraction_Handle, rect, fromRect, (ulong)op, delta);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_CGRect_UInt64_nfloat(base.SuperHandle, selDrawInRect_FromRect_Operation_Fraction_Handle, rect, fromRect, (ulong)op, delta);
		}
	}

	[Export("drawInRect:fromRect:operation:fraction:respectFlipped:hints:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Draw(CGRect dstSpacePortionRect, CGRect srcSpacePortionRect, NSCompositingOperation op, nfloat requestedAlpha, bool respectContextIsFlipped, NSDictionary? hints)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_CGRect_UInt64_nfloat_bool_IntPtr(base.Handle, selDrawInRect_FromRect_Operation_Fraction_RespectFlipped_Hints_Handle, dstSpacePortionRect, srcSpacePortionRect, (ulong)op, requestedAlpha, respectContextIsFlipped, hints?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_CGRect_UInt64_nfloat_bool_IntPtr(base.SuperHandle, selDrawInRect_FromRect_Operation_Fraction_RespectFlipped_Hints_Handle, dstSpacePortionRect, srcSpacePortionRect, (ulong)op, requestedAlpha, respectContextIsFlipped, hints?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("drawInRect:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Draw(CGRect rect)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawInRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawInRect_Handle, rect);
		}
	}

	[Export("drawRepresentation:inRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Draw(NSImageRep imageRep, CGRect rect)
	{
		if (imageRep == null)
		{
			throw new ArgumentNullException("imageRep");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_CGRect(base.Handle, selDrawRepresentation_InRect_Handle, imageRep.Handle, rect);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_CGRect(base.SuperHandle, selDrawRepresentation_InRect_Handle, imageRep.Handle, rect);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DrawInRect(CGRect dstRect, CGRect srcRect, NSCompositingOperation operation, nfloat delta)
	{
		Messaging.void_objc_msgSend_CGRect_CGRect_UInt64_nfloat(base.Handle, selDrawInRect_FromRect_Operation_Fraction_Handle, dstRect, srcRect, (ulong)operation, delta);
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("layerContentsForContentsScale:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetLayerContentsForContentsScale(nfloat layerContentsScale)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_nfloat(base.Handle, selLayerContentsForContentsScale_Handle, layerContentsScale));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_nfloat(base.SuperHandle, selLayerContentsForContentsScale_Handle, layerContentsScale));
	}

	[Export("name")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual string GetName()
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
	}

	[Export("pasteboardPropertyListForType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetPasteboardPropertyListForType(string type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPasteboardPropertyListForType_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPasteboardPropertyListForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("readableTypesForPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] GetReadableTypesForPasteboard(NSPasteboard pasteboard)
	{
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selReadableTypesForPasteboard_Handle, pasteboard.Handle));
	}

	[Export("readingOptionsForType:pasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPasteboardReadingOptions GetReadingOptionsForType(string type, NSPasteboard pasteboard)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSPasteboardReadingOptions result = (NSPasteboardReadingOptions)Messaging.UInt64_objc_msgSend_IntPtr_IntPtr(class_ptr, selReadingOptionsForType_Pasteboard_Handle, arg, pasteboard.Handle);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("recommendedLayerContentsScale:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetRecommendedLayerContentsScale(nfloat preferredContentsScale)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_nfloat(base.Handle, selRecommendedLayerContentsScale_Handle, preferredContentsScale);
		}
		return Messaging.nfloat_objc_msgSendSuper_nfloat(base.SuperHandle, selRecommendedLayerContentsScale_Handle, preferredContentsScale);
	}

	[Export("writableTypesForPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GetWritableTypesForPasteboard(NSPasteboard pasteboard)
	{
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selWritableTypesForPasteboard_Handle, pasteboard.Handle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selWritableTypesForPasteboard_Handle, pasteboard.Handle));
	}

	[Export("writingOptionsForType:pasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPasteboardWritingOptions GetWritingOptionsForType(string type, NSPasteboard pasteboard)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSPasteboardWritingOptions result = (NSPasteboardWritingOptions)((!base.IsDirectBinding) ? Messaging.UInt64_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWritingOptionsForType_Pasteboard_Handle, arg, pasteboard.Handle) : Messaging.UInt64_objc_msgSend_IntPtr_IntPtr(base.Handle, selWritingOptionsForType_Pasteboard_Handle, arg, pasteboard.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("hitTestRect:withImageDestinationRect:context:hints:flipped:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HitTestRect(CGRect testRectDestSpace, CGRect imageRectDestSpace, NSGraphicsContext context, NSDictionary hints, bool flipped)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (hints == null)
		{
			throw new ArgumentNullException("hints");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGRect_CGRect_IntPtr_IntPtr_bool(base.Handle, selHitTestRect_WithImageDestinationRect_Context_Hints_Flipped_Handle, testRectDestSpace, imageRectDestSpace, context.Handle, hints.Handle, flipped);
		}
		return Messaging.bool_objc_msgSendSuper_CGRect_CGRect_IntPtr_IntPtr_bool(base.SuperHandle, selHitTestRect_WithImageDestinationRect_Context_Hints_Flipped_Handle, testRectDestSpace, imageRectDestSpace, context.Handle, hints.Handle, flipped);
	}

	[Export("imageNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSImage ImageNamed(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSImage nSObject = Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("imageUnfilteredFileTypes")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject[] ImageUnfilteredFileTypes()
	{
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(class_ptr, selImageUnfilteredFileTypesHandle));
	}

	[Export("imageUnfilteredPasteboardTypes")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] ImageUnfilteredPasteboardTypes()
	{
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selImageUnfilteredPasteboardTypesHandle));
	}

	[Export("imageWithSize:flipped:drawingHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static NSImage ImageWithSize(CGSize size, bool flipped, [BlockProxy(typeof(Trampolines.NIDNSCustomImageRepDrawingHandler))] NSCustomImageRepDrawingHandler drawingHandler)
	{
		if (drawingHandler == null)
		{
			throw new ArgumentNullException("drawingHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSCustomImageRepDrawingHandler.Handler, drawingHandler);
		NSImage nSObject = Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend_CGSize_bool_IntPtr(class_ptr, selImageWithSize_Flipped_DrawingHandler_Handle, size, flipped, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
	}

	[Export("initByReferencingFile:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitByReferencingFile(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitByReferencingFile_Handle, arg) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitByReferencingFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal IntPtr InitWithContentsOfFile(string fileName)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		IntPtr arg = NSString.CreateNative(fileName);
		IntPtr result = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithContentsOfFile_Handle, arg);
		NSString.ReleaseNative(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal IntPtr InitWithData(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithData_Handle, data.Handle);
	}

	[Export("initWithDataIgnoringOrientation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithDataIgnoringOrientation(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithDataIgnoringOrientation_Handle, data.Handle);
		}
		return Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithDataIgnoringOrientation_Handle, data.Handle);
	}

	[Export("xamarinselector:removed:")]
	[Obsolete("It will never be called.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject InitWithPasteboardPropertyList(NSObject propertyList, string type)
	{
		if (propertyList == null)
		{
			throw new ArgumentNullException("propertyList");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selXamarinselector_Removed_Handle, propertyList.Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selXamarinselector_Removed_Handle, propertyList.Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("lockFocus")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LockFocus()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLockFocusHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLockFocusHandle);
		}
	}

	[Export("lockFocusFlipped:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LockFocusFlipped(bool flipped)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selLockFocusFlipped_Handle, flipped);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selLockFocusFlipped_Handle, flipped);
		}
	}

	[Export("recache")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Recache()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRecacheHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRecacheHandle);
		}
	}

	[Export("removeRepresentation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveRepresentation(NSImageRep imageRep)
	{
		if (imageRep == null)
		{
			throw new ArgumentNullException("imageRep");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveRepresentation_Handle, imageRep.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveRepresentation_Handle, imageRep.Handle);
		}
	}

	[Export("representations")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImageRep[] Representations()
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSImageRep>(Messaging.IntPtr_objc_msgSend(base.Handle, selRepresentationsHandle));
		}
		return NSArray.ArrayFromHandle<NSImageRep>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRepresentationsHandle));
	}

	[Export("setName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual bool SetName(string aString)
	{
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("unlockFocus")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UnlockFocus()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUnlockFocusHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUnlockFocusHandle);
		}
	}

	internal virtual _NSImageDelegate CreateInternalEventDelegateType()
	{
		return new _NSImageDelegate();
	}

	internal _NSImageDelegate EnsureNSImageDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSImageDelegate nSImageDelegate = Delegate as _NSImageDelegate;
		if (nSImageDelegate == null)
		{
			nSImageDelegate = (_NSImageDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSImageDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}

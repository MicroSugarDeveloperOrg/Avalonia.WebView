using System;
using System.ComponentModel;
using System.IO;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSImage", true)]
public class NSImage : NSObject
{
	[Register]
	private sealed class _NSImageDelegate : NSImageDelegate
	{
		internal NSImageRect imageDidNotDraw;

		internal EventHandler<NSImageLoadEventArgs> willLoadRepresentation;

		internal EventHandler<NSImageLoadEventArgs> didLoadRepresentationHeader;

		internal EventHandler<NSImagePartialEventArgs> didLoadPartOfRepresentation;

		internal EventHandler<NSImageLoadRepresentationEventArgs> didLoadRepresentation;

		[Preserve(Conditional = true)]
		public override NSImage ImageDidNotDraw(NSObject sender, CGRect aRect)
		{
			return imageDidNotDraw?.Invoke(sender, aRect);
		}

		[Preserve(Conditional = true)]
		public override void WillLoadRepresentation(NSImage image, NSImageRep rep)
		{
			EventHandler<NSImageLoadEventArgs> eventHandler = willLoadRepresentation;
			if (eventHandler != null)
			{
				NSImageLoadEventArgs e = new NSImageLoadEventArgs(rep);
				eventHandler(image, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void DidLoadRepresentationHeader(NSImage image, NSImageRep rep)
		{
			EventHandler<NSImageLoadEventArgs> eventHandler = didLoadRepresentationHeader;
			if (eventHandler != null)
			{
				NSImageLoadEventArgs e = new NSImageLoadEventArgs(rep);
				eventHandler(image, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void DidLoadPartOfRepresentation(NSImage image, NSImageRep rep, long rows)
		{
			EventHandler<NSImagePartialEventArgs> eventHandler = didLoadPartOfRepresentation;
			if (eventHandler != null)
			{
				NSImagePartialEventArgs e = new NSImagePartialEventArgs(rep, rows);
				eventHandler(image, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void DidLoadRepresentation(NSImage image, NSImageRep rep, NSImageLoadStatus status)
		{
			EventHandler<NSImageLoadRepresentationEventArgs> eventHandler = didLoadRepresentation;
			if (eventHandler != null)
			{
				NSImageLoadRepresentationEventArgs e = new NSImageLoadRepresentationEventArgs(rep, status);
				eventHandler(image, e);
			}
		}
	}

	private object __mt_reps_var;

	private static readonly IntPtr selIsValidHandle = Selector.GetHandle("isValid");

	private static readonly IntPtr selImageFileTypesHandle = Selector.GetHandle("imageFileTypes");

	private static readonly IntPtr selImagePasteboardTypesHandle = Selector.GetHandle("imagePasteboardTypes");

	private static readonly IntPtr selImageTypesHandle = Selector.GetHandle("imageTypes");

	private static readonly IntPtr selImageUnfilteredTypesHandle = Selector.GetHandle("imageUnfilteredTypes");

	private static readonly IntPtr selAccessibilityDescriptionHandle = Selector.GetHandle("accessibilityDescription");

	private static readonly IntPtr selSetAccessibilityDescription_Handle = Selector.GetHandle("setAccessibilityDescription:");

	private static readonly IntPtr selSizeHandle = Selector.GetHandle("size");

	private static readonly IntPtr selSetSize_Handle = Selector.GetHandle("setSize:");

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	private static readonly IntPtr selUsesEPSOnResolutionMismatchHandle = Selector.GetHandle("usesEPSOnResolutionMismatch");

	private static readonly IntPtr selSetUsesEPSOnResolutionMismatch_Handle = Selector.GetHandle("setUsesEPSOnResolutionMismatch:");

	private static readonly IntPtr selPrefersColorMatchHandle = Selector.GetHandle("prefersColorMatch");

	private static readonly IntPtr selSetPrefersColorMatch_Handle = Selector.GetHandle("setPrefersColorMatch:");

	private static readonly IntPtr selMatchesOnMultipleResolutionHandle = Selector.GetHandle("matchesOnMultipleResolution");

	private static readonly IntPtr selSetMatchesOnMultipleResolution_Handle = Selector.GetHandle("setMatchesOnMultipleResolution:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selCacheModeHandle = Selector.GetHandle("cacheMode");

	private static readonly IntPtr selSetCacheMode_Handle = Selector.GetHandle("setCacheMode:");

	private static readonly IntPtr selAlignmentRectHandle = Selector.GetHandle("alignmentRect");

	private static readonly IntPtr selSetAlignmentRect_Handle = Selector.GetHandle("setAlignmentRect:");

	private static readonly IntPtr selIsTemplateHandle = Selector.GetHandle("isTemplate");

	private static readonly IntPtr selSetTemplate_Handle = Selector.GetHandle("setTemplate:");

	private static readonly IntPtr selIsFlippedHandle = Selector.GetHandle("isFlipped");

	private static readonly IntPtr selSetFlipped_Handle = Selector.GetHandle("setFlipped:");

	private static readonly IntPtr selImageNamed_Handle = Selector.GetHandle("imageNamed:");

	private static readonly IntPtr selInitWithSize_Handle = Selector.GetHandle("initWithSize:");

	private static readonly IntPtr selInitWithData_Handle = Selector.GetHandle("initWithData:");

	private static readonly IntPtr selInitWithContentsOfFile_Handle = Selector.GetHandle("initWithContentsOfFile:");

	private static readonly IntPtr selInitWithContentsOfURL_Handle = Selector.GetHandle("initWithContentsOfURL:");

	private static readonly IntPtr selInitWithPasteboard_Handle = Selector.GetHandle("initWithPasteboard:");

	private static readonly IntPtr selDrawAtPointFromRectOperationFraction_Handle = Selector.GetHandle("drawAtPoint:fromRect:operation:fraction:");

	private static readonly IntPtr selDrawInRectFromRectOperationFraction_Handle = Selector.GetHandle("drawInRect:fromRect:operation:fraction:");

	private static readonly IntPtr selDrawInRectFromRectOperationFractionRespectFlippedHints_Handle = Selector.GetHandle("drawInRect:fromRect:operation:fraction:respectFlipped:hints:");

	private static readonly IntPtr selDrawRepresentationInRect_Handle = Selector.GetHandle("drawRepresentation:inRect:");

	private static readonly IntPtr selRecacheHandle = Selector.GetHandle("recache");

	private static readonly IntPtr selTIFFRepresentationHandle = Selector.GetHandle("TIFFRepresentation");

	private static readonly IntPtr selTIFFRepresentationUsingCompressionFactor_Handle = Selector.GetHandle("TIFFRepresentationUsingCompression:factor:");

	private static readonly IntPtr selRepresentationsHandle = Selector.GetHandle("representations");

	private static readonly IntPtr selAddRepresentations_Handle = Selector.GetHandle("addRepresentations:");

	private static readonly IntPtr selAddRepresentation_Handle = Selector.GetHandle("addRepresentation:");

	private static readonly IntPtr selRemoveRepresentation_Handle = Selector.GetHandle("removeRepresentation:");

	private static readonly IntPtr selLockFocusHandle = Selector.GetHandle("lockFocus");

	private static readonly IntPtr selLockFocusFlipped_Handle = Selector.GetHandle("lockFocusFlipped:");

	private static readonly IntPtr selUnlockFocusHandle = Selector.GetHandle("unlockFocus");

	private static readonly IntPtr selBestRepresentationForDevice_Handle = Selector.GetHandle("bestRepresentationForDevice:");

	private static readonly IntPtr selImageUnfilteredFileTypesHandle = Selector.GetHandle("imageUnfilteredFileTypes");

	private static readonly IntPtr selImageUnfilteredPasteboardTypesHandle = Selector.GetHandle("imageUnfilteredPasteboardTypes");

	private static readonly IntPtr selCanInitWithPasteboard_Handle = Selector.GetHandle("canInitWithPasteboard:");

	private static readonly IntPtr selCancelIncrementalLoadHandle = Selector.GetHandle("cancelIncrementalLoad");

	private static readonly IntPtr selInitWithCGImageSize_Handle = Selector.GetHandle("initWithCGImage:size:");

	private static readonly IntPtr selCGImageForProposedRectContextHints_Handle = Selector.GetHandle("CGImageForProposedRect:context:hints:");

	private static readonly IntPtr selBestRepresentationForRectContextHints_Handle = Selector.GetHandle("bestRepresentationForRect:context:hints:");

	private static readonly IntPtr selHitTestRectWithImageDestinationRectContextHintsFlipped_Handle = Selector.GetHandle("hitTestRect:withImageDestinationRect:context:hints:flipped:");

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	private static readonly IntPtr selSizeWithAttributes_Handle = Selector.GetHandle("sizeWithAttributes:");

	private static readonly IntPtr selDrawInRectWithAttributes_Handle = Selector.GetHandle("drawInRect:withAttributes:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSImage");

	private object __mt_BackgroundColor_var;

	private object __mt_WeakDelegate_var;

	private static NSString _NSImageNameQuickLookTemplate;

	private static NSString _NSImageNameBluetoothTemplate;

	private static NSString _NSImageNameIChatTheaterTemplate;

	private static NSString _NSImageNameSlideshowTemplate;

	private static NSString _NSImageNameActionTemplate;

	private static NSString _NSImageNameSmartBadgeTemplate;

	private static NSString _NSImageNamePathTemplate;

	private static NSString _NSImageNameInvalidDataFreestandingTemplate;

	private static NSString _NSImageNameLockLockedTemplate;

	private static NSString _NSImageNameLockUnlockedTemplate;

	private static NSString _NSImageNameGoRightTemplate;

	private static NSString _NSImageNameGoLeftTemplate;

	private static NSString _NSImageNameRightFacingTriangleTemplate;

	private static NSString _NSImageNameLeftFacingTriangleTemplate;

	private static NSString _NSImageNameAddTemplate;

	private static NSString _NSImageNameRemoveTemplate;

	private static NSString _NSImageNameRevealFreestandingTemplate;

	private static NSString _NSImageNameFollowLinkFreestandingTemplate;

	private static NSString _NSImageNameEnterFullScreenTemplate;

	private static NSString _NSImageNameExitFullScreenTemplate;

	private static NSString _NSImageNameStopProgressTemplate;

	private static NSString _NSImageNameStopProgressFreestandingTemplate;

	private static NSString _NSImageNameRefreshTemplate;

	private static NSString _NSImageNameRefreshFreestandingTemplate;

	private static NSString _NSImageNameFolder;

	private static NSString _NSImageNameTrashEmpty;

	private static NSString _NSImageNameTrashFull;

	private static NSString _NSImageNameHomeTemplate;

	private static NSString _NSImageNameBookmarksTemplate;

	private static NSString _NSImageNameCaution;

	private static NSString _NSImageNameStatusAvailable;

	private static NSString _NSImageNameStatusPartiallyAvailable;

	private static NSString _NSImageNameStatusUnavailable;

	private static NSString _NSImageNameStatusNone;

	private static NSString _NSImageNameApplicationIcon;

	private static NSString _NSImageNameMenuOnStateTemplate;

	private static NSString _NSImageNameMenuMixedStateTemplate;

	private static NSString _NSImageNameUserGuest;

	private static NSString _NSImageNameMobileMe;

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

	public virtual bool IsValid
	{
		[Export("isValid")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsValidHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsValidHandle);
		}
	}

	public static string[] ImageFileTypes
	{
		[Export("imageFileTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selImageFileTypesHandle));
		}
	}

	public static string[] ImagePasteboardTypes
	{
		[Export("imagePasteboardTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selImagePasteboardTypesHandle));
		}
	}

	public static string[] ImageTypes
	{
		[Export("imageTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selImageTypesHandle));
		}
	}

	public static string[] ImageUnfilteredTypes
	{
		[Export("imageUnfilteredTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selImageUnfilteredTypesHandle));
		}
	}

	public virtual string AccessibilityDescription
	{
		[Export("accessibilityDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessibilityDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessibilityDescriptionHandle));
		}
		[Export("setAccessibilityDescription:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
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

	public virtual CGSize Size
	{
		[Export("size")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selSizeHandle);
		}
		[Export("setSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetSize_Handle, value);
			}
		}
	}

	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_BackgroundColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle)))));
		}
		[Export("setBackgroundColor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
			}
			__mt_BackgroundColor_var = value;
		}
	}

	public virtual bool UsesEpsOnResolutionMismatch
	{
		[Export("usesEPSOnResolutionMismatch")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesEPSOnResolutionMismatchHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesEPSOnResolutionMismatchHandle);
		}
		[Export("setUsesEPSOnResolutionMismatch:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesEPSOnResolutionMismatch_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesEPSOnResolutionMismatch_Handle, value);
			}
		}
	}

	public virtual bool PrefersColorMatch
	{
		[Export("prefersColorMatch")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPrefersColorMatchHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPrefersColorMatchHandle);
		}
		[Export("setPrefersColorMatch:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPrefersColorMatch_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPrefersColorMatch_Handle, value);
			}
		}
	}

	public virtual bool MatchesOnMultipleResolution
	{
		[Export("matchesOnMultipleResolution")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selMatchesOnMultipleResolutionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selMatchesOnMultipleResolutionHandle);
		}
		[Export("setMatchesOnMultipleResolution:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMatchesOnMultipleResolution_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMatchesOnMultipleResolution_Handle, value);
			}
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public NSImageDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSImageDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual NSImageCacheMode CacheMode
	{
		[Export("cacheMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSImageCacheMode)Messaging.UInt64_objc_msgSend(base.Handle, selCacheModeHandle);
			}
			return (NSImageCacheMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCacheModeHandle);
		}
		[Export("setCacheMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetCacheMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetCacheMode_Handle, (ulong)value);
			}
		}
	}

	public virtual CGRect AlignmentRect
	{
		[Export("alignmentRect")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
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
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetAlignmentRect_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetAlignmentRect_Handle, value);
			}
		}
	}

	public virtual bool Template
	{
		[Export("isTemplate")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsTemplateHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsTemplateHandle);
		}
		[Export("setTemplate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTemplate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTemplate_Handle, value);
			}
		}
	}

	[Obsolete("On 10.6 and newer use DrawInRect with respectContextIsFlipped instead", false)]
	public virtual bool Flipped
	{
		[Export("isFlipped")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFlippedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFlippedHandle);
		}
		[Export("setFlipped:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFlipped_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFlipped_Handle, value);
			}
		}
	}

	[Field("NSImageNameQuickLookTemplate", "AppKit")]
	internal static NSString NSImageNameQuickLookTemplate
	{
		get
		{
			if (_NSImageNameQuickLookTemplate == null)
			{
				_NSImageNameQuickLookTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameQuickLookTemplate");
			}
			return _NSImageNameQuickLookTemplate;
		}
	}

	[Field("NSImageNameBluetoothTemplate", "AppKit")]
	internal static NSString NSImageNameBluetoothTemplate
	{
		get
		{
			if (_NSImageNameBluetoothTemplate == null)
			{
				_NSImageNameBluetoothTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameBluetoothTemplate");
			}
			return _NSImageNameBluetoothTemplate;
		}
	}

	[Field("NSImageNameIChatTheaterTemplate", "AppKit")]
	internal static NSString NSImageNameIChatTheaterTemplate
	{
		get
		{
			if (_NSImageNameIChatTheaterTemplate == null)
			{
				_NSImageNameIChatTheaterTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameIChatTheaterTemplate");
			}
			return _NSImageNameIChatTheaterTemplate;
		}
	}

	[Field("NSImageNameSlideshowTemplate", "AppKit")]
	internal static NSString NSImageNameSlideshowTemplate
	{
		get
		{
			if (_NSImageNameSlideshowTemplate == null)
			{
				_NSImageNameSlideshowTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameSlideshowTemplate");
			}
			return _NSImageNameSlideshowTemplate;
		}
	}

	[Field("NSImageNameActionTemplate", "AppKit")]
	internal static NSString NSImageNameActionTemplate
	{
		get
		{
			if (_NSImageNameActionTemplate == null)
			{
				_NSImageNameActionTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameActionTemplate");
			}
			return _NSImageNameActionTemplate;
		}
	}

	[Field("NSImageNameSmartBadgeTemplate", "AppKit")]
	internal static NSString NSImageNameSmartBadgeTemplate
	{
		get
		{
			if (_NSImageNameSmartBadgeTemplate == null)
			{
				_NSImageNameSmartBadgeTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameSmartBadgeTemplate");
			}
			return _NSImageNameSmartBadgeTemplate;
		}
	}

	[Field("NSImageNamePathTemplate", "AppKit")]
	internal static NSString NSImageNamePathTemplate
	{
		get
		{
			if (_NSImageNamePathTemplate == null)
			{
				_NSImageNamePathTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNamePathTemplate");
			}
			return _NSImageNamePathTemplate;
		}
	}

	[Field("NSImageNameInvalidDataFreestandingTemplate", "AppKit")]
	internal static NSString NSImageNameInvalidDataFreestandingTemplate
	{
		get
		{
			if (_NSImageNameInvalidDataFreestandingTemplate == null)
			{
				_NSImageNameInvalidDataFreestandingTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameInvalidDataFreestandingTemplate");
			}
			return _NSImageNameInvalidDataFreestandingTemplate;
		}
	}

	[Field("NSImageNameLockLockedTemplate", "AppKit")]
	internal static NSString NSImageNameLockLockedTemplate
	{
		get
		{
			if (_NSImageNameLockLockedTemplate == null)
			{
				_NSImageNameLockLockedTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameLockLockedTemplate");
			}
			return _NSImageNameLockLockedTemplate;
		}
	}

	[Field("NSImageNameLockUnlockedTemplate", "AppKit")]
	internal static NSString NSImageNameLockUnlockedTemplate
	{
		get
		{
			if (_NSImageNameLockUnlockedTemplate == null)
			{
				_NSImageNameLockUnlockedTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameLockUnlockedTemplate");
			}
			return _NSImageNameLockUnlockedTemplate;
		}
	}

	[Field("NSImageNameGoRightTemplate", "AppKit")]
	internal static NSString NSImageNameGoRightTemplate
	{
		get
		{
			if (_NSImageNameGoRightTemplate == null)
			{
				_NSImageNameGoRightTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameGoRightTemplate");
			}
			return _NSImageNameGoRightTemplate;
		}
	}

	[Field("NSImageNameGoLeftTemplate", "AppKit")]
	internal static NSString NSImageNameGoLeftTemplate
	{
		get
		{
			if (_NSImageNameGoLeftTemplate == null)
			{
				_NSImageNameGoLeftTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameGoLeftTemplate");
			}
			return _NSImageNameGoLeftTemplate;
		}
	}

	[Field("NSImageNameRightFacingTriangleTemplate", "AppKit")]
	internal static NSString NSImageNameRightFacingTriangleTemplate
	{
		get
		{
			if (_NSImageNameRightFacingTriangleTemplate == null)
			{
				_NSImageNameRightFacingTriangleTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameRightFacingTriangleTemplate");
			}
			return _NSImageNameRightFacingTriangleTemplate;
		}
	}

	[Field("NSImageNameLeftFacingTriangleTemplate", "AppKit")]
	internal static NSString NSImageNameLeftFacingTriangleTemplate
	{
		get
		{
			if (_NSImageNameLeftFacingTriangleTemplate == null)
			{
				_NSImageNameLeftFacingTriangleTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameLeftFacingTriangleTemplate");
			}
			return _NSImageNameLeftFacingTriangleTemplate;
		}
	}

	[Field("NSImageNameAddTemplate", "AppKit")]
	internal static NSString NSImageNameAddTemplate
	{
		get
		{
			if (_NSImageNameAddTemplate == null)
			{
				_NSImageNameAddTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameAddTemplate");
			}
			return _NSImageNameAddTemplate;
		}
	}

	[Field("NSImageNameRemoveTemplate", "AppKit")]
	internal static NSString NSImageNameRemoveTemplate
	{
		get
		{
			if (_NSImageNameRemoveTemplate == null)
			{
				_NSImageNameRemoveTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameRemoveTemplate");
			}
			return _NSImageNameRemoveTemplate;
		}
	}

	[Field("NSImageNameRevealFreestandingTemplate", "AppKit")]
	internal static NSString NSImageNameRevealFreestandingTemplate
	{
		get
		{
			if (_NSImageNameRevealFreestandingTemplate == null)
			{
				_NSImageNameRevealFreestandingTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameRevealFreestandingTemplate");
			}
			return _NSImageNameRevealFreestandingTemplate;
		}
	}

	[Field("NSImageNameFollowLinkFreestandingTemplate", "AppKit")]
	internal static NSString NSImageNameFollowLinkFreestandingTemplate
	{
		get
		{
			if (_NSImageNameFollowLinkFreestandingTemplate == null)
			{
				_NSImageNameFollowLinkFreestandingTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameFollowLinkFreestandingTemplate");
			}
			return _NSImageNameFollowLinkFreestandingTemplate;
		}
	}

	[Field("NSImageNameEnterFullScreenTemplate", "AppKit")]
	internal static NSString NSImageNameEnterFullScreenTemplate
	{
		get
		{
			if (_NSImageNameEnterFullScreenTemplate == null)
			{
				_NSImageNameEnterFullScreenTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameEnterFullScreenTemplate");
			}
			return _NSImageNameEnterFullScreenTemplate;
		}
	}

	[Field("NSImageNameExitFullScreenTemplate", "AppKit")]
	internal static NSString NSImageNameExitFullScreenTemplate
	{
		get
		{
			if (_NSImageNameExitFullScreenTemplate == null)
			{
				_NSImageNameExitFullScreenTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameExitFullScreenTemplate");
			}
			return _NSImageNameExitFullScreenTemplate;
		}
	}

	[Field("NSImageNameStopProgressTemplate", "AppKit")]
	internal static NSString NSImageNameStopProgressTemplate
	{
		get
		{
			if (_NSImageNameStopProgressTemplate == null)
			{
				_NSImageNameStopProgressTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameStopProgressTemplate");
			}
			return _NSImageNameStopProgressTemplate;
		}
	}

	[Field("NSImageNameStopProgressFreestandingTemplate", "AppKit")]
	internal static NSString NSImageNameStopProgressFreestandingTemplate
	{
		get
		{
			if (_NSImageNameStopProgressFreestandingTemplate == null)
			{
				_NSImageNameStopProgressFreestandingTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameStopProgressFreestandingTemplate");
			}
			return _NSImageNameStopProgressFreestandingTemplate;
		}
	}

	[Field("NSImageNameRefreshTemplate", "AppKit")]
	internal static NSString NSImageNameRefreshTemplate
	{
		get
		{
			if (_NSImageNameRefreshTemplate == null)
			{
				_NSImageNameRefreshTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameRefreshTemplate");
			}
			return _NSImageNameRefreshTemplate;
		}
	}

	[Field("NSImageNameRefreshFreestandingTemplate", "AppKit")]
	internal static NSString NSImageNameRefreshFreestandingTemplate
	{
		get
		{
			if (_NSImageNameRefreshFreestandingTemplate == null)
			{
				_NSImageNameRefreshFreestandingTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameRefreshFreestandingTemplate");
			}
			return _NSImageNameRefreshFreestandingTemplate;
		}
	}

	[Field("NSImageNameFolder", "AppKit")]
	internal static NSString NSImageNameFolder
	{
		get
		{
			if (_NSImageNameFolder == null)
			{
				_NSImageNameFolder = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameFolder");
			}
			return _NSImageNameFolder;
		}
	}

	[Field("NSImageNameTrashEmpty", "AppKit")]
	internal static NSString NSImageNameTrashEmpty
	{
		get
		{
			if (_NSImageNameTrashEmpty == null)
			{
				_NSImageNameTrashEmpty = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameTrashEmpty");
			}
			return _NSImageNameTrashEmpty;
		}
	}

	[Field("NSImageNameTrashFull", "AppKit")]
	internal static NSString NSImageNameTrashFull
	{
		get
		{
			if (_NSImageNameTrashFull == null)
			{
				_NSImageNameTrashFull = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameTrashFull");
			}
			return _NSImageNameTrashFull;
		}
	}

	[Field("NSImageNameHomeTemplate", "AppKit")]
	internal static NSString NSImageNameHomeTemplate
	{
		get
		{
			if (_NSImageNameHomeTemplate == null)
			{
				_NSImageNameHomeTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameHomeTemplate");
			}
			return _NSImageNameHomeTemplate;
		}
	}

	[Field("NSImageNameBookmarksTemplate", "AppKit")]
	internal static NSString NSImageNameBookmarksTemplate
	{
		get
		{
			if (_NSImageNameBookmarksTemplate == null)
			{
				_NSImageNameBookmarksTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameBookmarksTemplate");
			}
			return _NSImageNameBookmarksTemplate;
		}
	}

	[Field("NSImageNameCaution", "AppKit")]
	internal static NSString NSImageNameCaution
	{
		get
		{
			if (_NSImageNameCaution == null)
			{
				_NSImageNameCaution = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameCaution");
			}
			return _NSImageNameCaution;
		}
	}

	[Field("NSImageNameStatusAvailable", "AppKit")]
	internal static NSString NSImageNameStatusAvailable
	{
		get
		{
			if (_NSImageNameStatusAvailable == null)
			{
				_NSImageNameStatusAvailable = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameStatusAvailable");
			}
			return _NSImageNameStatusAvailable;
		}
	}

	[Field("NSImageNameStatusPartiallyAvailable", "AppKit")]
	internal static NSString NSImageNameStatusPartiallyAvailable
	{
		get
		{
			if (_NSImageNameStatusPartiallyAvailable == null)
			{
				_NSImageNameStatusPartiallyAvailable = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameStatusPartiallyAvailable");
			}
			return _NSImageNameStatusPartiallyAvailable;
		}
	}

	[Field("NSImageNameStatusUnavailable", "AppKit")]
	internal static NSString NSImageNameStatusUnavailable
	{
		get
		{
			if (_NSImageNameStatusUnavailable == null)
			{
				_NSImageNameStatusUnavailable = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameStatusUnavailable");
			}
			return _NSImageNameStatusUnavailable;
		}
	}

	[Field("NSImageNameStatusNone", "AppKit")]
	internal static NSString NSImageNameStatusNone
	{
		get
		{
			if (_NSImageNameStatusNone == null)
			{
				_NSImageNameStatusNone = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameStatusNone");
			}
			return _NSImageNameStatusNone;
		}
	}

	[Field("NSImageNameApplicationIcon", "AppKit")]
	internal static NSString NSImageNameApplicationIcon
	{
		get
		{
			if (_NSImageNameApplicationIcon == null)
			{
				_NSImageNameApplicationIcon = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameApplicationIcon");
			}
			return _NSImageNameApplicationIcon;
		}
	}

	[Field("NSImageNameMenuOnStateTemplate", "AppKit")]
	internal static NSString NSImageNameMenuOnStateTemplate
	{
		get
		{
			if (_NSImageNameMenuOnStateTemplate == null)
			{
				_NSImageNameMenuOnStateTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameMenuOnStateTemplate");
			}
			return _NSImageNameMenuOnStateTemplate;
		}
	}

	[Field("NSImageNameMenuMixedStateTemplate", "AppKit")]
	internal static NSString NSImageNameMenuMixedStateTemplate
	{
		get
		{
			if (_NSImageNameMenuMixedStateTemplate == null)
			{
				_NSImageNameMenuMixedStateTemplate = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameMenuMixedStateTemplate");
			}
			return _NSImageNameMenuMixedStateTemplate;
		}
	}

	[Field("NSImageNameUserGuest", "AppKit")]
	internal static NSString NSImageNameUserGuest
	{
		get
		{
			if (_NSImageNameUserGuest == null)
			{
				_NSImageNameUserGuest = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameUserGuest");
			}
			return _NSImageNameUserGuest;
		}
	}

	[Field("NSImageNameMobileMe", "AppKit")]
	internal static NSString NSImageNameMobileMe
	{
		get
		{
			if (_NSImageNameMobileMe == null)
			{
				_NSImageNameMobileMe = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSImageNameMobileMe");
			}
			return _NSImageNameMobileMe;
		}
	}

	public NSImageRect ImageDidNotDraw
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

	public static NSImage FromStream(Stream stream)
	{
		using NSData data = NSData.FromStream(stream);
		return new NSImage(data);
	}

	public static NSImage ImageNamed(NSImageName name)
	{
		return name switch
		{
			NSImageName.QuickLookTemplate => ImageNamed(NSImageNameQuickLookTemplate), 
			NSImageName.BluetoothTemplate => ImageNamed(NSImageNameBluetoothTemplate), 
			NSImageName.IChatTheaterTemplate => ImageNamed(NSImageNameIChatTheaterTemplate), 
			NSImageName.SlideshowTemplate => ImageNamed(NSImageNameSlideshowTemplate), 
			NSImageName.ActionTemplate => ImageNamed(NSImageNameActionTemplate), 
			NSImageName.SmartBadgeTemplate => ImageNamed(NSImageNameSmartBadgeTemplate), 
			NSImageName.PathTemplate => ImageNamed(NSImageNamePathTemplate), 
			NSImageName.InvalidDataFreestandingTemplate => ImageNamed(NSImageNameInvalidDataFreestandingTemplate), 
			NSImageName.LockLockedTemplate => ImageNamed(NSImageNameLockLockedTemplate), 
			NSImageName.LockUnlockedTemplate => ImageNamed(NSImageNameLockUnlockedTemplate), 
			NSImageName.GoRightTemplate => ImageNamed(NSImageNameGoRightTemplate), 
			NSImageName.GoLeftTemplate => ImageNamed(NSImageNameGoLeftTemplate), 
			NSImageName.RightFacingTriangleTemplate => ImageNamed(NSImageNameRightFacingTriangleTemplate), 
			NSImageName.LeftFacingTriangleTemplate => ImageNamed(NSImageNameLeftFacingTriangleTemplate), 
			NSImageName.AddTemplate => ImageNamed(NSImageNameAddTemplate), 
			NSImageName.RemoveTemplate => ImageNamed(NSImageNameRemoveTemplate), 
			NSImageName.RevealFreestandingTemplate => ImageNamed(NSImageNameRevealFreestandingTemplate), 
			NSImageName.FollowLinkFreestandingTemplate => ImageNamed(NSImageNameFollowLinkFreestandingTemplate), 
			NSImageName.EnterFullScreenTemplate => ImageNamed(NSImageNameEnterFullScreenTemplate), 
			NSImageName.ExitFullScreenTemplate => ImageNamed(NSImageNameExitFullScreenTemplate), 
			NSImageName.StopProgressTemplate => ImageNamed(NSImageNameStopProgressTemplate), 
			NSImageName.StopProgressFreestandingTemplate => ImageNamed(NSImageNameStopProgressFreestandingTemplate), 
			NSImageName.RefreshTemplate => ImageNamed(NSImageNameRefreshTemplate), 
			NSImageName.RefreshFreestandingTemplate => ImageNamed(NSImageNameRefreshFreestandingTemplate), 
			NSImageName.Folder => ImageNamed(NSImageNameFolder), 
			NSImageName.TrashEmpty => ImageNamed(NSImageNameTrashEmpty), 
			NSImageName.TrashFull => ImageNamed(NSImageNameTrashFull), 
			NSImageName.HomeTemplate => ImageNamed(NSImageNameHomeTemplate), 
			NSImageName.BookmarksTemplate => ImageNamed(NSImageNameBookmarksTemplate), 
			NSImageName.Caution => ImageNamed(NSImageNameCaution), 
			NSImageName.StatusAvailable => ImageNamed(NSImageNameStatusAvailable), 
			NSImageName.StatusPartiallyAvailable => ImageNamed(NSImageNameStatusPartiallyAvailable), 
			NSImageName.StatusUnavailable => ImageNamed(NSImageNameStatusUnavailable), 
			NSImageName.StatusNone => ImageNamed(NSImageNameStatusNone), 
			NSImageName.ApplicationIcon => ImageNamed(NSImageNameApplicationIcon), 
			NSImageName.MenuOnStateTemplate => ImageNamed(NSImageNameMenuOnStateTemplate), 
			NSImageName.MenuMixedStateTemplate => ImageNamed(NSImageNameMenuMixedStateTemplate), 
			NSImageName.UserGuest => ImageNamed(NSImageNameUserGuest), 
			NSImageName.MobileMe => ImageNamed(NSImageNameMobileMe), 
			_ => throw new ArgumentException("Invalid enum value", "name"), 
		};
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSImage()
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
	public NSImage(NSCoder coder)
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
	public NSImage(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSImage(IntPtr handle)
		: base(handle)
	{
	}

	[Export("imageNamed:")]
	public static NSImage ImageNamed(string name)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSImage result = (NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selImageNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithSize:")]
	public NSImage(CGSize aSize)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGSize(base.Handle, selInitWithSize_Handle, aSize);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGSize(base.SuperHandle, selInitWithSize_Handle, aSize);
		}
	}

	[Export("initWithData:")]
	public NSImage(NSData data)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithData_Handle, data.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithData_Handle, data.Handle);
		}
	}

	[Export("initWithContentsOfFile:")]
	public NSImage(string fileName)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		IntPtr arg = NSString.CreateNative(fileName);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithContentsOfFile_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithContentsOfFile_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithContentsOfURL:")]
	public NSImage(NSUrl url)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithContentsOfURL_Handle, url.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithContentsOfURL_Handle, url.Handle);
		}
	}

	[Export("initWithPasteboard:")]
	public NSImage(NSPasteboard pasteboard)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPasteboard_Handle, pasteboard.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPasteboard_Handle, pasteboard.Handle);
		}
	}

	[Export("drawAtPoint:fromRect:operation:fraction:")]
	public virtual void Draw(CGPoint point, CGRect fromRect, NSCompositingOperation op, double delta)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_CGRect_UInt64_Double(base.Handle, selDrawAtPointFromRectOperationFraction_Handle, point, fromRect, (ulong)op, delta);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_CGRect_UInt64_Double(base.SuperHandle, selDrawAtPointFromRectOperationFraction_Handle, point, fromRect, (ulong)op, delta);
		}
	}

	[Export("drawInRect:fromRect:operation:fraction:")]
	public virtual void Draw(CGRect rect, CGRect fromRect, NSCompositingOperation op, double delta)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_CGRect_UInt64_Double(base.Handle, selDrawInRectFromRectOperationFraction_Handle, rect, fromRect, (ulong)op, delta);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_CGRect_UInt64_Double(base.SuperHandle, selDrawInRectFromRectOperationFraction_Handle, rect, fromRect, (ulong)op, delta);
		}
	}

	[Export("drawInRect:fromRect:operation:fraction:respectFlipped:hints:")]
	public virtual void Draw(CGRect dstSpacePortionRect, CGRect srcSpacePortionRect, NSCompositingOperation op, double requestedAlpha, bool respectContextIsFlipped, NSDictionary hints)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_CGRect_UInt64_Double_bool_IntPtr(base.Handle, selDrawInRectFromRectOperationFractionRespectFlippedHints_Handle, dstSpacePortionRect, srcSpacePortionRect, (ulong)op, requestedAlpha, respectContextIsFlipped, hints?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_CGRect_UInt64_Double_bool_IntPtr(base.SuperHandle, selDrawInRectFromRectOperationFractionRespectFlippedHints_Handle, dstSpacePortionRect, srcSpacePortionRect, (ulong)op, requestedAlpha, respectContextIsFlipped, hints?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("drawRepresentation:inRect:")]
	public virtual bool Draw(NSImageRep imageRep, CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (imageRep == null)
		{
			throw new ArgumentNullException("imageRep");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_CGRect(base.Handle, selDrawRepresentationInRect_Handle, imageRep.Handle, rect);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_CGRect(base.SuperHandle, selDrawRepresentationInRect_Handle, imageRep.Handle, rect);
	}

	[Export("recache")]
	public virtual void Recache()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRecacheHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRecacheHandle);
		}
	}

	[Export("TIFFRepresentation")]
	public virtual NSData AsTiff()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTIFFRepresentationHandle));
		}
		return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTIFFRepresentationHandle));
	}

	[Export("TIFFRepresentationUsingCompression:factor:")]
	public virtual NSData AsTiff(NSTiffCompression comp, double aFloat)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_Double(base.Handle, selTIFFRepresentationUsingCompressionFactor_Handle, (ulong)comp, aFloat));
		}
		return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64_Double(base.SuperHandle, selTIFFRepresentationUsingCompressionFactor_Handle, (ulong)comp, aFloat));
	}

	[Export("representations")]
	public virtual NSImageRep[] Representations()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSImageRep>(Messaging.IntPtr_objc_msgSend(base.Handle, selRepresentationsHandle));
		}
		return NSArray.ArrayFromHandle<NSImageRep>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRepresentationsHandle));
	}

	[Export("addRepresentations:")]
	public virtual void AddRepresentations(NSImageRep[] imageReps)
	{
		NSApplication.EnsureUIThread();
		if (imageReps == null)
		{
			throw new ArgumentNullException("imageReps");
		}
		NSArray nSArray = NSArray.FromNSObjects(imageReps);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddRepresentations_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddRepresentations_Handle, nSArray.Handle);
		}
		__mt_reps_var = Representations();
		nSArray.Dispose();
	}

	[Export("addRepresentation:")]
	public virtual void AddRepresentation(NSImageRep imageRep)
	{
		NSApplication.EnsureUIThread();
		if (imageRep == null)
		{
			throw new ArgumentNullException("imageRep");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddRepresentation_Handle, imageRep.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddRepresentation_Handle, imageRep.Handle);
		}
		__mt_reps_var = Representations();
	}

	[Export("removeRepresentation:")]
	public virtual void RemoveRepresentation(NSImageRep imageRep)
	{
		NSApplication.EnsureUIThread();
		if (imageRep == null)
		{
			throw new ArgumentNullException("imageRep");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveRepresentation_Handle, imageRep.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveRepresentation_Handle, imageRep.Handle);
		}
		__mt_reps_var = Representations();
	}

	[Export("lockFocus")]
	public virtual void LockFocus()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLockFocusHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLockFocusHandle);
		}
	}

	[Export("lockFocusFlipped:")]
	public virtual void LockFocusFlipped(bool flipped)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selLockFocusFlipped_Handle, flipped);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selLockFocusFlipped_Handle, flipped);
		}
	}

	[Export("unlockFocus")]
	public virtual void UnlockFocus()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUnlockFocusHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUnlockFocusHandle);
		}
	}

	[Export("bestRepresentationForDevice:")]
	public virtual NSImageRep BestRepresentationForDevice(NSDictionary deviceDescription)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSImageRep)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selBestRepresentationForDevice_Handle, deviceDescription?.Handle ?? IntPtr.Zero));
		}
		return (NSImageRep)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selBestRepresentationForDevice_Handle, deviceDescription?.Handle ?? IntPtr.Zero));
	}

	[Export("imageUnfilteredFileTypes")]
	public static NSObject[] ImageUnfilteredFileTypes()
	{
		NSApplication.EnsureUIThread();
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(class_ptr, selImageUnfilteredFileTypesHandle));
	}

	[Export("imageUnfilteredPasteboardTypes")]
	public static string[] ImageUnfilteredPasteboardTypes()
	{
		NSApplication.EnsureUIThread();
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selImageUnfilteredPasteboardTypesHandle));
	}

	[Export("canInitWithPasteboard:")]
	public static bool CanInitWithPasteboard(NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return Messaging.bool_objc_msgSend_IntPtr(class_ptr, selCanInitWithPasteboard_Handle, pasteboard.Handle);
	}

	[Export("cancelIncrementalLoad")]
	public virtual void CancelIncrementalLoad()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelIncrementalLoadHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelIncrementalLoadHandle);
		}
	}

	[Export("initWithCGImage:size:")]
	public NSImage(CGImage cgImage, CGSize size)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_CGSize(base.Handle, selInitWithCGImageSize_Handle, cgImage.Handle, size);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_CGSize(base.SuperHandle, selInitWithCGImageSize_Handle, cgImage.Handle, size);
		}
	}

	[Export("CGImageForProposedRect:context:hints:")]
	public virtual CGImage AsCGImage(ref CGRect proposedDestRect, NSGraphicsContext referenceContext, NSDictionary hints)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return new CGImage(Messaging.IntPtr_objc_msgSend_out_CGRect_IntPtr_IntPtr(base.Handle, selCGImageForProposedRectContextHints_Handle, out proposedDestRect, referenceContext?.Handle ?? IntPtr.Zero, hints?.Handle ?? IntPtr.Zero));
		}
		return new CGImage(Messaging.IntPtr_objc_msgSendSuper_out_CGRect_IntPtr_IntPtr(base.SuperHandle, selCGImageForProposedRectContextHints_Handle, out proposedDestRect, referenceContext?.Handle ?? IntPtr.Zero, hints?.Handle ?? IntPtr.Zero));
	}

	[Export("bestRepresentationForRect:context:hints:")]
	public virtual NSImageRep BestRepresentation(CGRect rect, NSGraphicsContext referenceContext, NSDictionary hints)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSImageRep)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CGRect_IntPtr_IntPtr(base.Handle, selBestRepresentationForRectContextHints_Handle, rect, referenceContext?.Handle ?? IntPtr.Zero, hints?.Handle ?? IntPtr.Zero));
		}
		return (NSImageRep)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr_IntPtr(base.SuperHandle, selBestRepresentationForRectContextHints_Handle, rect, referenceContext?.Handle ?? IntPtr.Zero, hints?.Handle ?? IntPtr.Zero));
	}

	[Export("hitTestRect:withImageDestinationRect:context:hints:flipped:")]
	public virtual bool HitTestRect(CGRect testRectDestSpace, CGRect imageRectDestSpace, NSGraphicsContext context, NSDictionary hints, bool flipped)
	{
		NSApplication.EnsureUIThread();
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (hints == null)
		{
			throw new ArgumentNullException("hints");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGRect_CGRect_IntPtr_IntPtr_bool(base.Handle, selHitTestRectWithImageDestinationRectContextHintsFlipped_Handle, testRectDestSpace, imageRectDestSpace, context.Handle, hints.Handle, flipped);
		}
		return Messaging.bool_objc_msgSendSuper_CGRect_CGRect_IntPtr_IntPtr_bool(base.SuperHandle, selHitTestRectWithImageDestinationRectContextHintsFlipped_Handle, testRectDestSpace, imageRectDestSpace, context.Handle, hints.Handle, flipped);
	}

	[Export("name")]
	internal virtual string GetName()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
	}

	[Export("setName:")]
	internal virtual bool SetName(string aString)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	public CGSize StringSize(string str, NSDictionary attributes)
	{
		NSApplication.EnsureUIThread();
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		IntPtr receiver = NSString.CreateNative(str);
		CGSize result = Messaging.CGSize_objc_msgSend_IntPtr(receiver, selSizeWithAttributes_Handle, attributes.Handle);
		NSString.ReleaseNative(receiver);
		return result;
	}

	public void DrawInRect(string str, CGRect rect, NSDictionary attributes)
	{
		NSApplication.EnsureUIThread();
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		IntPtr receiver = NSString.CreateNative(str);
		Messaging.void_objc_msgSend_CGRect_IntPtr(receiver, selDrawInRectWithAttributes_Handle, rect, attributes.Handle);
		NSString.ReleaseNative(receiver);
	}

	[Export("drawInRect:fromRect:operation:fraction:")]
	public virtual void DrawInRect(CGRect dstRect, CGRect srcRect, NSCompositingOperation operation, double delta)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_CGRect_UInt64_Double(base.Handle, selDrawInRectFromRectOperationFraction_Handle, dstRect, srcRect, (ulong)operation, delta);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_CGRect_UInt64_Double(base.SuperHandle, selDrawInRectFromRectOperationFraction_Handle, dstRect, srcRect, (ulong)operation, delta);
		}
	}

	private _NSImageDelegate EnsureNSImageDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _NSImageDelegate))
		{
			nSObject = (WeakDelegate = new _NSImageDelegate());
		}
		return (_NSImageDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		__mt_reps_var = null;
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_BackgroundColor_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}

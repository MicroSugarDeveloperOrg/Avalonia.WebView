using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace PdfKit;

[Register("PDFDocument", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class PdfDocument : NSObject, INSCopying, INativeObject, IDisposable
{
	[Register]
	internal class _PdfDocumentDelegate : NSObject, IPdfDocumentDelegate, INativeObject, IDisposable
	{
		internal ClassForAnnotationClassDelegate? classForAnnotationClass;

		internal EventHandler? didBeginDocumentFind;

		internal EventHandler? didMatchString;

		internal EventHandler? didUnlock;

		internal EventHandler? findFinished;

		internal ClassForAnnotationTypeDelegate? getClassForAnnotationType;

		internal EventHandler? matchFound;

		internal EventHandler? pageFindFinished;

		internal EventHandler? pageFindStarted;

		public _PdfDocumentDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("classForAnnotationClass:")]
		public Class ClassForAnnotationClass(Class sender)
		{
			return classForAnnotationClass?.Invoke(sender);
		}

		[Preserve(Conditional = true)]
		[Export("documentDidBeginDocumentFind:")]
		public void DidBeginDocumentFind(NSNotification notification)
		{
			didBeginDocumentFind?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("didMatchString:")]
		public void DidMatchString(PdfSelection sender)
		{
			didMatchString?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("documentDidUnlock:")]
		public void DidUnlock(NSNotification notification)
		{
			didUnlock?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("documentDidEndDocumentFind:")]
		public void FindFinished(NSNotification notification)
		{
			findFinished?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("classForAnnotationType:")]
		public Class GetClassForAnnotationType(string annotationType)
		{
			return getClassForAnnotationType?.Invoke(annotationType);
		}

		[Preserve(Conditional = true)]
		[Export("documentDidFindMatch:")]
		public void MatchFound(NSNotification notification)
		{
			matchFound?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("documentDidEndPageFind:")]
		public void PageFindFinished(NSNotification notification)
		{
			pageFindFinished?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("documentDidBeginPageFind:")]
		public void PageFindStarted(NSNotification notification)
		{
			pageFindStarted?.Invoke(notification, EventArgs.Empty);
		}
	}

	public static class Notifications
	{
		public static NSObject ObserveDidBeginFind(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidBeginFindNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidBeginFind(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidBeginFindNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidBeginPageFind(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidBeginPageFindNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidBeginPageFind(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidBeginPageFindNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidBeginPageWrite(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidBeginPageWriteNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidBeginPageWrite(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidBeginPageWriteNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidBeginWrite(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidBeginWriteNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidBeginWrite(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidBeginWriteNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidEndFind(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEndFindNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidEndFind(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEndFindNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidEndPageFind(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEndPageFindNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidEndPageFind(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEndPageFindNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidEndPageWrite(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEndPageWriteNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidEndPageWrite(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEndPageWriteNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidEndWrite(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEndWriteNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidEndWrite(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidEndWriteNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidFindMatch(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidFindMatchNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidFindMatch(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidFindMatchNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidUnlock(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidUnlockNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidUnlock(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidUnlockNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsCommenting = "allowsCommenting";

	private static readonly IntPtr selAllowsCommentingHandle = Selector.GetHandle("allowsCommenting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsContentAccessibility = "allowsContentAccessibility";

	private static readonly IntPtr selAllowsContentAccessibilityHandle = Selector.GetHandle("allowsContentAccessibility");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsCopying = "allowsCopying";

	private static readonly IntPtr selAllowsCopyingHandle = Selector.GetHandle("allowsCopying");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsDocumentAssembly = "allowsDocumentAssembly";

	private static readonly IntPtr selAllowsDocumentAssemblyHandle = Selector.GetHandle("allowsDocumentAssembly");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsDocumentChanges = "allowsDocumentChanges";

	private static readonly IntPtr selAllowsDocumentChangesHandle = Selector.GetHandle("allowsDocumentChanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsFormFieldEntry = "allowsFormFieldEntry";

	private static readonly IntPtr selAllowsFormFieldEntryHandle = Selector.GetHandle("allowsFormFieldEntry");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsPrinting = "allowsPrinting";

	private static readonly IntPtr selAllowsPrintingHandle = Selector.GetHandle("allowsPrinting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginFindString_WithOptions_ = "beginFindString:withOptions:";

	private static readonly IntPtr selBeginFindString_WithOptions_Handle = Selector.GetHandle("beginFindString:withOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginFindStrings_WithOptions_ = "beginFindStrings:withOptions:";

	private static readonly IntPtr selBeginFindStrings_WithOptions_Handle = Selector.GetHandle("beginFindStrings:withOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelFindString = "cancelFindString";

	private static readonly IntPtr selCancelFindStringHandle = Selector.GetHandle("cancelFindString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataRepresentation = "dataRepresentation";

	private static readonly IntPtr selDataRepresentationHandle = Selector.GetHandle("dataRepresentation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataRepresentationWithOptions_ = "dataRepresentationWithOptions:";

	private static readonly IntPtr selDataRepresentationWithOptions_Handle = Selector.GetHandle("dataRepresentationWithOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocumentAttributes = "documentAttributes";

	private static readonly IntPtr selDocumentAttributesHandle = Selector.GetHandle("documentAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocumentRef = "documentRef";

	private static readonly IntPtr selDocumentRefHandle = Selector.GetHandle("documentRef");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocumentURL = "documentURL";

	private static readonly IntPtr selDocumentURLHandle = Selector.GetHandle("documentURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExchangePageAtIndex_WithPageAtIndex_ = "exchangePageAtIndex:withPageAtIndex:";

	private static readonly IntPtr selExchangePageAtIndex_WithPageAtIndex_Handle = Selector.GetHandle("exchangePageAtIndex:withPageAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFindString_FromSelection_WithOptions_ = "findString:fromSelection:withOptions:";

	private static readonly IntPtr selFindString_FromSelection_WithOptions_Handle = Selector.GetHandle("findString:fromSelection:withOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFindString_WithOptions_ = "findString:withOptions:";

	private static readonly IntPtr selFindString_WithOptions_Handle = Selector.GetHandle("findString:withOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexForPage_ = "indexForPage:";

	private static readonly IntPtr selIndexForPage_Handle = Selector.GetHandle("indexForPage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_ = "initWithData:";

	private static readonly IntPtr selInitWithData_Handle = Selector.GetHandle("initWithData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_ = "initWithURL:";

	private static readonly IntPtr selInitWithURL_Handle = Selector.GetHandle("initWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertPage_AtIndex_ = "insertPage:atIndex:";

	private static readonly IntPtr selInsertPage_AtIndex_Handle = Selector.GetHandle("insertPage:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEncrypted = "isEncrypted";

	private static readonly IntPtr selIsEncryptedHandle = Selector.GetHandle("isEncrypted");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFinding = "isFinding";

	private static readonly IntPtr selIsFindingHandle = Selector.GetHandle("isFinding");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsLocked = "isLocked";

	private static readonly IntPtr selIsLockedHandle = Selector.GetHandle("isLocked");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMajorVersion = "majorVersion";

	private static readonly IntPtr selMajorVersionHandle = Selector.GetHandle("majorVersion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinorVersion = "minorVersion";

	private static readonly IntPtr selMinorVersionHandle = Selector.GetHandle("minorVersion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutlineItemForSelection_ = "outlineItemForSelection:";

	private static readonly IntPtr selOutlineItemForSelection_Handle = Selector.GetHandle("outlineItemForSelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutlineRoot = "outlineRoot";

	private static readonly IntPtr selOutlineRootHandle = Selector.GetHandle("outlineRoot");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPageAtIndex_ = "pageAtIndex:";

	private static readonly IntPtr selPageAtIndex_Handle = Selector.GetHandle("pageAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPageClass = "pageClass";

	private static readonly IntPtr selPageClassHandle = Selector.GetHandle("pageClass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPageCount = "pageCount";

	private static readonly IntPtr selPageCountHandle = Selector.GetHandle("pageCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPermissionsStatus = "permissionsStatus";

	private static readonly IntPtr selPermissionsStatusHandle = Selector.GetHandle("permissionsStatus");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrintOperationForPrintInfo_ScalingMode_AutoRotate_ = "printOperationForPrintInfo:scalingMode:autoRotate:";

	private static readonly IntPtr selPrintOperationForPrintInfo_ScalingMode_AutoRotate_Handle = Selector.GetHandle("printOperationForPrintInfo:scalingMode:autoRotate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemovePageAtIndex_ = "removePageAtIndex:";

	private static readonly IntPtr selRemovePageAtIndex_Handle = Selector.GetHandle("removePageAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionForEntireDocument = "selectionForEntireDocument";

	private static readonly IntPtr selSelectionForEntireDocumentHandle = Selector.GetHandle("selectionForEntireDocument");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionFromPage_AtCharacterIndex_ToPage_AtCharacterIndex_ = "selectionFromPage:atCharacterIndex:toPage:atCharacterIndex:";

	private static readonly IntPtr selSelectionFromPage_AtCharacterIndex_ToPage_AtCharacterIndex_Handle = Selector.GetHandle("selectionFromPage:atCharacterIndex:toPage:atCharacterIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionFromPage_AtPoint_ToPage_AtPoint_ = "selectionFromPage:atPoint:toPage:atPoint:";

	private static readonly IntPtr selSelectionFromPage_AtPoint_ToPage_AtPoint_Handle = Selector.GetHandle("selectionFromPage:atPoint:toPage:atPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDocumentAttributes_ = "setDocumentAttributes:";

	private static readonly IntPtr selSetDocumentAttributes_Handle = Selector.GetHandle("setDocumentAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOutlineRoot_ = "setOutlineRoot:";

	private static readonly IntPtr selSetOutlineRoot_Handle = Selector.GetHandle("setOutlineRoot:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selString = "string";

	private static readonly IntPtr selStringHandle = Selector.GetHandle("string");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnlockWithPassword_ = "unlockWithPassword:";

	private static readonly IntPtr selUnlockWithPassword_Handle = Selector.GetHandle("unlockWithPassword:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToFile_ = "writeToFile:";

	private static readonly IntPtr selWriteToFile_Handle = Selector.GetHandle("writeToFile:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToFile_WithOptions_ = "writeToFile:withOptions:";

	private static readonly IntPtr selWriteToFile_WithOptions_Handle = Selector.GetHandle("writeToFile:withOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToURL_ = "writeToURL:";

	private static readonly IntPtr selWriteToURL_Handle = Selector.GetHandle("writeToURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToURL_WithOptions_ = "writeToURL:withOptions:";

	private static readonly IntPtr selWriteToURL_WithOptions_Handle = Selector.GetHandle("writeToURL:withOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PDFDocument");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidBeginFindNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidBeginPageFindNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidBeginPageWriteNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidBeginWriteNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidEndFindNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidEndPageFindNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidEndPageWriteNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidEndWriteNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidFindMatchNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidUnlockNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual bool AllowsCommenting
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("allowsCommenting")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsCommentingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsCommentingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual bool AllowsContentAccessibility
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("allowsContentAccessibility")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsContentAccessibilityHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsContentAccessibilityHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsCopying
	{
		[Export("allowsCopying")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsCopyingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsCopyingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual bool AllowsDocumentAssembly
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("allowsDocumentAssembly")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsDocumentAssemblyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsDocumentAssemblyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual bool AllowsDocumentChanges
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("allowsDocumentChanges")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsDocumentChangesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsDocumentChangesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual bool AllowsFormFieldEntry
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("allowsFormFieldEntry")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsFormFieldEntryHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsFormFieldEntryHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsPrinting
	{
		[Export("allowsPrinting")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsPrintingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsPrintingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IPdfDocumentDelegate Delegate
	{
		get
		{
			return WeakDelegate as IPdfDocumentDelegate;
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
	public virtual CGPDFDocument Document
	{
		[Export("documentRef")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentRefHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentRefHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGPDFDocument(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Use the strongly typed '[Get|Set]DocumentAttributes' instead.")]
	public virtual NSDictionary DocumentAttributes
	{
		[Export("documentAttributes", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentAttributesHandle));
		}
		[Export("setDocumentAttributes:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDocumentAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDocumentAttributes_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl DocumentUrl
	{
		[Export("documentURL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEncrypted
	{
		[Export("isEncrypted")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEncryptedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEncryptedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsFinding
	{
		[Export("isFinding")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFindingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFindingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsLocked
	{
		[Export("isLocked")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLockedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLockedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int MajorVersion
	{
		[Export("majorVersion")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selMajorVersionHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selMajorVersionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int MinorVersion
	{
		[Export("minorVersion")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selMinorVersionHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selMinorVersionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfOutline? OutlineRoot
	{
		[Export("outlineRoot")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<PdfOutline>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutlineRootHandle));
			}
			return Runtime.GetNSObject<PdfOutline>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutlineRootHandle));
		}
		[Export("setOutlineRoot:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOutlineRoot_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOutlineRoot_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Class PageClass
	{
		[Export("pageClass")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPageClassHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selPageClassHandle));
			return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint PageCount
	{
		[Export("pageCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selPageCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selPageCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Type PageType => ObjCRuntime.Class.Lookup(PageClass);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfDocumentPermissions PermissionsStatus
	{
		[Export("permissionsStatus")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PdfDocumentPermissions)Messaging.Int64_objc_msgSend(base.Handle, selPermissionsStatusHandle);
			}
			return (PdfDocumentPermissions)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selPermissionsStatusHandle);
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

	[Field("PDFDocumentDidBeginFindNotification", "Quartz")]
	[Advice("Use PdfDocument.Notifications.ObserveDidBeginFind helper method instead.")]
	public static NSString DidBeginFindNotification
	{
		get
		{
			if (_DidBeginFindNotification == null)
			{
				_DidBeginFindNotification = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFDocumentDidBeginFindNotification");
			}
			return _DidBeginFindNotification;
		}
	}

	[Field("PDFDocumentDidBeginPageFindNotification", "Quartz")]
	[Advice("Use PdfDocument.Notifications.ObserveDidBeginPageFind helper method instead.")]
	public static NSString DidBeginPageFindNotification
	{
		get
		{
			if (_DidBeginPageFindNotification == null)
			{
				_DidBeginPageFindNotification = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFDocumentDidBeginPageFindNotification");
			}
			return _DidBeginPageFindNotification;
		}
	}

	[Field("PDFDocumentDidBeginPageWriteNotification", "Quartz")]
	[Advice("Use PdfDocument.Notifications.ObserveDidBeginPageWrite helper method instead.")]
	public static NSString DidBeginPageWriteNotification
	{
		get
		{
			if (_DidBeginPageWriteNotification == null)
			{
				_DidBeginPageWriteNotification = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFDocumentDidBeginPageWriteNotification");
			}
			return _DidBeginPageWriteNotification;
		}
	}

	[Field("PDFDocumentDidBeginWriteNotification", "Quartz")]
	[Advice("Use PdfDocument.Notifications.ObserveDidBeginWrite helper method instead.")]
	public static NSString DidBeginWriteNotification
	{
		get
		{
			if (_DidBeginWriteNotification == null)
			{
				_DidBeginWriteNotification = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFDocumentDidBeginWriteNotification");
			}
			return _DidBeginWriteNotification;
		}
	}

	[Field("PDFDocumentDidEndFindNotification", "Quartz")]
	[Advice("Use PdfDocument.Notifications.ObserveDidEndFind helper method instead.")]
	public static NSString DidEndFindNotification
	{
		get
		{
			if (_DidEndFindNotification == null)
			{
				_DidEndFindNotification = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFDocumentDidEndFindNotification");
			}
			return _DidEndFindNotification;
		}
	}

	[Field("PDFDocumentDidEndPageFindNotification", "Quartz")]
	[Advice("Use PdfDocument.Notifications.ObserveDidEndPageFind helper method instead.")]
	public static NSString DidEndPageFindNotification
	{
		get
		{
			if (_DidEndPageFindNotification == null)
			{
				_DidEndPageFindNotification = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFDocumentDidEndPageFindNotification");
			}
			return _DidEndPageFindNotification;
		}
	}

	[Field("PDFDocumentDidEndPageWriteNotification", "Quartz")]
	[Advice("Use PdfDocument.Notifications.ObserveDidEndPageWrite helper method instead.")]
	public static NSString DidEndPageWriteNotification
	{
		get
		{
			if (_DidEndPageWriteNotification == null)
			{
				_DidEndPageWriteNotification = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFDocumentDidEndPageWriteNotification");
			}
			return _DidEndPageWriteNotification;
		}
	}

	[Field("PDFDocumentDidEndWriteNotification", "Quartz")]
	[Advice("Use PdfDocument.Notifications.ObserveDidEndWrite helper method instead.")]
	public static NSString DidEndWriteNotification
	{
		get
		{
			if (_DidEndWriteNotification == null)
			{
				_DidEndWriteNotification = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFDocumentDidEndWriteNotification");
			}
			return _DidEndWriteNotification;
		}
	}

	[Field("PDFDocumentDidFindMatchNotification", "Quartz")]
	[Advice("Use PdfDocument.Notifications.ObserveDidFindMatch helper method instead.")]
	public static NSString DidFindMatchNotification
	{
		get
		{
			if (_DidFindMatchNotification == null)
			{
				_DidFindMatchNotification = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFDocumentDidFindMatchNotification");
			}
			return _DidFindMatchNotification;
		}
	}

	[Field("PDFDocumentDidUnlockNotification", "Quartz")]
	[Advice("Use PdfDocument.Notifications.ObserveDidUnlock helper method instead.")]
	public static NSString DidUnlockNotification
	{
		get
		{
			if (_DidUnlockNotification == null)
			{
				_DidUnlockNotification = Dlfcn.GetStringConstant(Libraries.PdfKit.Handle, "PDFDocumentDidUnlockNotification");
			}
			return _DidUnlockNotification;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_PdfDocumentDelegate);

	public ClassForAnnotationClassDelegate? ClassForAnnotationClass
	{
		get
		{
			return EnsurePdfDocumentDelegate().classForAnnotationClass;
		}
		set
		{
			EnsurePdfDocumentDelegate().classForAnnotationClass = value;
		}
	}

	public ClassForAnnotationTypeDelegate? GetClassForAnnotationType
	{
		get
		{
			return EnsurePdfDocumentDelegate().getClassForAnnotationType;
		}
		set
		{
			EnsurePdfDocumentDelegate().getClassForAnnotationType = value;
		}
	}

	public event EventHandler DidBeginDocumentFind
	{
		add
		{
			_PdfDocumentDelegate pdfDocumentDelegate = EnsurePdfDocumentDelegate();
			pdfDocumentDelegate.didBeginDocumentFind = (EventHandler)System.Delegate.Combine(pdfDocumentDelegate.didBeginDocumentFind, value);
		}
		remove
		{
			_PdfDocumentDelegate pdfDocumentDelegate = EnsurePdfDocumentDelegate();
			pdfDocumentDelegate.didBeginDocumentFind = (EventHandler)System.Delegate.Remove(pdfDocumentDelegate.didBeginDocumentFind, value);
		}
	}

	public event EventHandler DidMatchString
	{
		add
		{
			_PdfDocumentDelegate pdfDocumentDelegate = EnsurePdfDocumentDelegate();
			pdfDocumentDelegate.didMatchString = (EventHandler)System.Delegate.Combine(pdfDocumentDelegate.didMatchString, value);
		}
		remove
		{
			_PdfDocumentDelegate pdfDocumentDelegate = EnsurePdfDocumentDelegate();
			pdfDocumentDelegate.didMatchString = (EventHandler)System.Delegate.Remove(pdfDocumentDelegate.didMatchString, value);
		}
	}

	public event EventHandler DidUnlock
	{
		add
		{
			_PdfDocumentDelegate pdfDocumentDelegate = EnsurePdfDocumentDelegate();
			pdfDocumentDelegate.didUnlock = (EventHandler)System.Delegate.Combine(pdfDocumentDelegate.didUnlock, value);
		}
		remove
		{
			_PdfDocumentDelegate pdfDocumentDelegate = EnsurePdfDocumentDelegate();
			pdfDocumentDelegate.didUnlock = (EventHandler)System.Delegate.Remove(pdfDocumentDelegate.didUnlock, value);
		}
	}

	public event EventHandler FindFinished
	{
		add
		{
			_PdfDocumentDelegate pdfDocumentDelegate = EnsurePdfDocumentDelegate();
			pdfDocumentDelegate.findFinished = (EventHandler)System.Delegate.Combine(pdfDocumentDelegate.findFinished, value);
		}
		remove
		{
			_PdfDocumentDelegate pdfDocumentDelegate = EnsurePdfDocumentDelegate();
			pdfDocumentDelegate.findFinished = (EventHandler)System.Delegate.Remove(pdfDocumentDelegate.findFinished, value);
		}
	}

	public event EventHandler MatchFound
	{
		add
		{
			_PdfDocumentDelegate pdfDocumentDelegate = EnsurePdfDocumentDelegate();
			pdfDocumentDelegate.matchFound = (EventHandler)System.Delegate.Combine(pdfDocumentDelegate.matchFound, value);
		}
		remove
		{
			_PdfDocumentDelegate pdfDocumentDelegate = EnsurePdfDocumentDelegate();
			pdfDocumentDelegate.matchFound = (EventHandler)System.Delegate.Remove(pdfDocumentDelegate.matchFound, value);
		}
	}

	public event EventHandler PageFindFinished
	{
		add
		{
			_PdfDocumentDelegate pdfDocumentDelegate = EnsurePdfDocumentDelegate();
			pdfDocumentDelegate.pageFindFinished = (EventHandler)System.Delegate.Combine(pdfDocumentDelegate.pageFindFinished, value);
		}
		remove
		{
			_PdfDocumentDelegate pdfDocumentDelegate = EnsurePdfDocumentDelegate();
			pdfDocumentDelegate.pageFindFinished = (EventHandler)System.Delegate.Remove(pdfDocumentDelegate.pageFindFinished, value);
		}
	}

	public event EventHandler PageFindStarted
	{
		add
		{
			_PdfDocumentDelegate pdfDocumentDelegate = EnsurePdfDocumentDelegate();
			pdfDocumentDelegate.pageFindStarted = (EventHandler)System.Delegate.Combine(pdfDocumentDelegate.pageFindStarted, value);
		}
		remove
		{
			_PdfDocumentDelegate pdfDocumentDelegate = EnsurePdfDocumentDelegate();
			pdfDocumentDelegate.pageFindStarted = (EventHandler)System.Delegate.Remove(pdfDocumentDelegate.pageFindStarted, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected PdfDocument(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PdfDocument(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public PdfDocument()
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

	[Export("initWithURL:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public PdfDocument(NSUrl url)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithURL_Handle, url.Handle), "initWithURL:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithURL_Handle, url.Handle), "initWithURL:");
		}
	}

	[Export("initWithData:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public PdfDocument(NSData data)
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

	[Export("cancelFindString")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelFind()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelFindStringHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelFindStringHandle);
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

	[Export("exchangePageAtIndex:withPageAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ExchangePages(nint indexA, nint indexB)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_nint(base.Handle, selExchangePageAtIndex_WithPageAtIndex_Handle, indexA, indexB);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_nint(base.SuperHandle, selExchangePageAtIndex_WithPageAtIndex_Handle, indexA, indexB);
		}
	}

	[Export("findString:withOptions:")]
	[Obsolete("Use 'Find (string, NSStringCompareOptions)' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfSelection[] Find(string text, nint options)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		IntPtr arg = NSString.CreateNative(text);
		PdfSelection[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<PdfSelection>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selFindString_WithOptions_Handle, arg, options)) : NSArray.ArrayFromHandle<PdfSelection>(Messaging.IntPtr_objc_msgSend_IntPtr_nint(base.Handle, selFindString_WithOptions_Handle, arg, options)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfSelection[] Find(string text, NSStringCompareOptions compareOptions)
	{
		return Find(text, (int)compareOptions);
	}

	[Export("findString:fromSelection:withOptions:")]
	[Obsolete("Use 'Find (string, PdfSelection, NSStringCompareOptions)' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfSelection Find(string text, PdfSelection selection, nint options)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		if (selection == null)
		{
			throw new ArgumentNullException("selection");
		}
		IntPtr arg = NSString.CreateNative(text);
		PdfSelection result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<PdfSelection>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_nint(base.SuperHandle, selFindString_FromSelection_WithOptions_Handle, arg, selection.Handle, options)) : Runtime.GetNSObject<PdfSelection>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nint(base.Handle, selFindString_FromSelection_WithOptions_Handle, arg, selection.Handle, options)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfSelection Find(string text, PdfSelection selection, NSStringCompareOptions compareOptions)
	{
		return Find(text, selection, (int)compareOptions);
	}

	[Export("beginFindString:withOptions:")]
	[Obsolete("Use 'FindAsync (string, NSStringCompareOptions)' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FindAsync(string text, nint options)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		IntPtr arg = NSString.CreateNative(text);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selBeginFindString_WithOptions_Handle, arg, options);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selBeginFindString_WithOptions_Handle, arg, options);
		}
		NSString.ReleaseNative(arg);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FindAsync(string text, NSStringCompareOptions compareOptions)
	{
		FindAsync(text, (int)compareOptions);
	}

	[Export("beginFindStrings:withOptions:")]
	[Obsolete("Use 'FindAsync (string [], NSStringCompareOptions)' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FindAsync(string[] text, nint options)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		NSArray nSArray = NSArray.FromStrings(text);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selBeginFindStrings_WithOptions_Handle, nSArray.Handle, options);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selBeginFindStrings_WithOptions_Handle, nSArray.Handle, options);
		}
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FindAsync(string[] text, NSStringCompareOptions compareOptions)
	{
		FindAsync(text, (int)compareOptions);
	}

	[Export("dataRepresentation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData GetDataRepresentation()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataRepresentationHandle));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataRepresentationHandle));
	}

	[Export("dataRepresentationWithOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData GetDataRepresentation(NSDictionary options)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDataRepresentationWithOptions_Handle, options.Handle));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDataRepresentationWithOptions_Handle, options.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public PdfDocumentAttributes GetDocumentAttributes()
	{
		return new PdfDocumentAttributes(DocumentAttributes);
	}

	[Export("pageAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfPage GetPage(nint index)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<PdfPage>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selPageAtIndex_Handle, index));
		}
		return Runtime.GetNSObject<PdfPage>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selPageAtIndex_Handle, index));
	}

	[Export("indexForPage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetPageIndex(PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selIndexForPage_Handle, page.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexForPage_Handle, page.Handle);
	}

	[Export("printOperationForPrintInfo:scalingMode:autoRotate:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPrintOperation? GetPrintOperation(NSPrintInfo? printInfo, PdfPrintScalingMode scaleMode, bool doRotate)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSPrintOperation>(Messaging.IntPtr_objc_msgSend_IntPtr_Int64_bool(base.Handle, selPrintOperationForPrintInfo_ScalingMode_AutoRotate_Handle, printInfo?.Handle ?? IntPtr.Zero, (long)scaleMode, doRotate));
		}
		return Runtime.GetNSObject<NSPrintOperation>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_Int64_bool(base.SuperHandle, selPrintOperationForPrintInfo_ScalingMode_AutoRotate_Handle, printInfo?.Handle ?? IntPtr.Zero, (long)scaleMode, doRotate));
	}

	[Export("selectionFromPage:atPoint:toPage:atPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfSelection GetSelection(PdfPage startPage, CGPoint startPoint, PdfPage endPage, CGPoint endPoint)
	{
		if (startPage == null)
		{
			throw new ArgumentNullException("startPage");
		}
		if (endPage == null)
		{
			throw new ArgumentNullException("endPage");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<PdfSelection>(Messaging.IntPtr_objc_msgSend_IntPtr_CGPoint_IntPtr_CGPoint(base.Handle, selSelectionFromPage_AtPoint_ToPage_AtPoint_Handle, startPage.Handle, startPoint, endPage.Handle, endPoint));
		}
		return Runtime.GetNSObject<PdfSelection>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_CGPoint_IntPtr_CGPoint(base.SuperHandle, selSelectionFromPage_AtPoint_ToPage_AtPoint_Handle, startPage.Handle, startPoint, endPage.Handle, endPoint));
	}

	[Export("selectionFromPage:atCharacterIndex:toPage:atCharacterIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfSelection GetSelection(PdfPage startPage, nint startCharIndex, PdfPage endPage, nint endCharIndex)
	{
		if (startPage == null)
		{
			throw new ArgumentNullException("startPage");
		}
		if (endPage == null)
		{
			throw new ArgumentNullException("endPage");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<PdfSelection>(Messaging.IntPtr_objc_msgSend_IntPtr_nint_IntPtr_nint(base.Handle, selSelectionFromPage_AtCharacterIndex_ToPage_AtCharacterIndex_Handle, startPage.Handle, startCharIndex, endPage.Handle, endCharIndex));
		}
		return Runtime.GetNSObject<PdfSelection>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nint_IntPtr_nint(base.SuperHandle, selSelectionFromPage_AtCharacterIndex_ToPage_AtCharacterIndex_Handle, startPage.Handle, startCharIndex, endPage.Handle, endCharIndex));
	}

	[Export("insertPage:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertPage(PdfPage page, nint index)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selInsertPage_AtIndex_Handle, page.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selInsertPage_AtIndex_Handle, page.Handle, index);
		}
	}

	[Export("outlineItemForSelection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfOutline OutlineItem(PdfSelection selection)
	{
		if (selection == null)
		{
			throw new ArgumentNullException("selection");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<PdfOutline>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selOutlineItemForSelection_Handle, selection.Handle));
		}
		return Runtime.GetNSObject<PdfOutline>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selOutlineItemForSelection_Handle, selection.Handle));
	}

	[Export("removePageAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemovePage(nint index)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selRemovePageAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selRemovePageAtIndex_Handle, index);
		}
	}

	[Export("selectionForEntireDocument")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PdfSelection SelectEntireDocument()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<PdfSelection>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectionForEntireDocumentHandle));
		}
		return Runtime.GetNSObject<PdfSelection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectionForEntireDocumentHandle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetDocumentAttributes(PdfDocumentAttributes attributes)
	{
		DocumentAttributes = attributes.GetDictionary();
	}

	[Export("unlockWithPassword:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Unlock(string password)
	{
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		IntPtr arg = NSString.CreateNative(password);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selUnlockWithPassword_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selUnlockWithPassword_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("writeToFile:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Write(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selWriteToFile_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selWriteToFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("writeToFile:withOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Write(string path, NSDictionary options)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWriteToFile_WithOptions_Handle, arg, options.Handle) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selWriteToFile_WithOptions_Handle, arg, options.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool Write(string path, PdfDocumentWriteOptions options)
	{
		return Write(path, options.GetDictionary());
	}

	[Export("writeToURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Write(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selWriteToURL_Handle, url.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selWriteToURL_Handle, url.Handle);
	}

	[Export("writeToURL:withOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Write(NSUrl url, NSDictionary options)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selWriteToURL_WithOptions_Handle, url.Handle, options.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWriteToURL_WithOptions_Handle, url.Handle, options.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool Write(NSUrl url, PdfDocumentWriteOptions options)
	{
		return Write(url, options.GetDictionary());
	}

	internal virtual _PdfDocumentDelegate CreateInternalEventDelegateType()
	{
		return new _PdfDocumentDelegate();
	}

	internal _PdfDocumentDelegate EnsurePdfDocumentDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_PdfDocumentDelegate pdfDocumentDelegate = Delegate as _PdfDocumentDelegate;
		if (pdfDocumentDelegate == null)
		{
			pdfDocumentDelegate = (_PdfDocumentDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return pdfDocumentDelegate;
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

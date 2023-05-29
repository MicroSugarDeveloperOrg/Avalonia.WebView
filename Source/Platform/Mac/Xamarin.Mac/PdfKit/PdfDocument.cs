using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFDocument", true)]
public class PdfDocument : NSObject
{
	[Register]
	private sealed class _PdfDocumentDelegate : PdfDocumentDelegate
	{
		internal EventHandler didMatchString;

		internal ClassForAnnotationClassDelegate classForAnnotationClass;

		internal EventHandler findFinished;

		internal EventHandler pageFindStarted;

		internal EventHandler pageFindFinished;

		internal EventHandler matchFound;

		[Preserve(Conditional = true)]
		public override void DidMatchString(PdfSelection sender)
		{
			didMatchString?.Invoke(sender, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override Class ClassForAnnotationClass(Class sender)
		{
			return classForAnnotationClass?.Invoke(sender);
		}

		[Preserve(Conditional = true)]
		public override void FindFinished(NSNotification notification)
		{
			findFinished?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void PageFindStarted(NSNotification notification)
		{
			pageFindStarted?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void PageFindFinished(NSNotification notification)
		{
			pageFindFinished?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void MatchFound(NSNotification notification)
		{
			matchFound?.Invoke(notification, EventArgs.Empty);
		}
	}

	private static readonly IntPtr selDocumentURLHandle = Selector.GetHandle("documentURL");

	private static readonly IntPtr selDocumentAttributesHandle = Selector.GetHandle("documentAttributes");

	private static readonly IntPtr selSetDocumentAttributes_Handle = Selector.GetHandle("setDocumentAttributes:");

	private static readonly IntPtr selMajorVersionHandle = Selector.GetHandle("majorVersion");

	private static readonly IntPtr selMinorVersionHandle = Selector.GetHandle("minorVersion");

	private static readonly IntPtr selIsEncryptedHandle = Selector.GetHandle("isEncrypted");

	private static readonly IntPtr selIsLockedHandle = Selector.GetHandle("isLocked");

	private static readonly IntPtr selAllowsPrintingHandle = Selector.GetHandle("allowsPrinting");

	private static readonly IntPtr selAllowsCopyingHandle = Selector.GetHandle("allowsCopying");

	private static readonly IntPtr selPermissionsStatusHandle = Selector.GetHandle("permissionsStatus");

	private static readonly IntPtr selStringHandle = Selector.GetHandle("string");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selOutlineRootHandle = Selector.GetHandle("outlineRoot");

	private static readonly IntPtr selSetOutlineRoot_Handle = Selector.GetHandle("setOutlineRoot:");

	private static readonly IntPtr selPageCountHandle = Selector.GetHandle("pageCount");

	private static readonly IntPtr selPageClassHandle = Selector.GetHandle("pageClass");

	private static readonly IntPtr selIsFindingHandle = Selector.GetHandle("isFinding");

	private static readonly IntPtr selInitWithURL_Handle = Selector.GetHandle("initWithURL:");

	private static readonly IntPtr selInitWithData_Handle = Selector.GetHandle("initWithData:");

	private static readonly IntPtr selUnlockWithPassword_Handle = Selector.GetHandle("unlockWithPassword:");

	private static readonly IntPtr selDataRepresentationHandle = Selector.GetHandle("dataRepresentation");

	private static readonly IntPtr selDataRepresentationWithOptions_Handle = Selector.GetHandle("dataRepresentationWithOptions:");

	private static readonly IntPtr selWriteToFile_Handle = Selector.GetHandle("writeToFile:");

	private static readonly IntPtr selWriteToFileWithOptions_Handle = Selector.GetHandle("writeToFile:withOptions:");

	private static readonly IntPtr selWriteToURL_Handle = Selector.GetHandle("writeToURL:");

	private static readonly IntPtr selWriteToURLWithOptions_Handle = Selector.GetHandle("writeToURL:withOptions:");

	private static readonly IntPtr selOutlineItemForSelection_Handle = Selector.GetHandle("outlineItemForSelection:");

	private static readonly IntPtr selPageAtIndex_Handle = Selector.GetHandle("pageAtIndex:");

	private static readonly IntPtr selIndexForPage_Handle = Selector.GetHandle("indexForPage:");

	private static readonly IntPtr selInsertPageAtIndex_Handle = Selector.GetHandle("insertPage:atIndex:");

	private static readonly IntPtr selRemovePageAtIndex_Handle = Selector.GetHandle("removePageAtIndex:");

	private static readonly IntPtr selExchangePageAtIndexWithPageAtIndex_Handle = Selector.GetHandle("exchangePageAtIndex:withPageAtIndex:");

	private static readonly IntPtr selFindStringWithOptions_Handle = Selector.GetHandle("findString:withOptions:");

	private static readonly IntPtr selBeginFindStringWithOptions_Handle = Selector.GetHandle("beginFindString:withOptions:");

	private static readonly IntPtr selBeginFindStringsWithOptions_Handle = Selector.GetHandle("beginFindStrings:withOptions:");

	private static readonly IntPtr selFindStringFromSelectionWithOptions_Handle = Selector.GetHandle("findString:fromSelection:withOptions:");

	private static readonly IntPtr selCancelFindStringHandle = Selector.GetHandle("cancelFindString");

	private static readonly IntPtr selSelectionForEntireDocumentHandle = Selector.GetHandle("selectionForEntireDocument");

	private static readonly IntPtr selSelectionFromPageAtPointToPageAtPoint_Handle = Selector.GetHandle("selectionFromPage:atPoint:toPage:atPoint:");

	private static readonly IntPtr selSelectionFromPageAtCharacterIndexToPageAtCharacterIndex_Handle = Selector.GetHandle("selectionFromPage:atCharacterIndex:toPage:atCharacterIndex:");

	private static readonly IntPtr class_ptr = Class.GetHandle("PDFDocument");

	private object __mt_DocumentUrl_var;

	private object __mt_DocumentAttributes_var;

	private object __mt_WeakDelegate_var;

	private object __mt_OutlineRoot_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSUrl DocumentUrl
	{
		[Export("documentURL")]
		get
		{
			return (NSUrl)(__mt_DocumentUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentURLHandle)))));
		}
	}

	public virtual NSDictionary DocumentAttributes
	{
		[Export("documentAttributes")]
		get
		{
			return (NSDictionary)(__mt_DocumentAttributes_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentAttributesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentAttributesHandle)))));
		}
		[Export("setDocumentAttributes:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDocumentAttributes_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDocumentAttributes_Handle, value.Handle);
			}
			__mt_DocumentAttributes_var = value;
		}
	}

	public virtual int MajorVersion
	{
		[Export("majorVersion")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selMajorVersionHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selMajorVersionHandle);
		}
	}

	public virtual int MinorVersion
	{
		[Export("minorVersion")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selMinorVersionHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selMinorVersionHandle);
		}
	}

	public virtual bool IsEncrypted
	{
		[Export("isEncrypted")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEncryptedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEncryptedHandle);
		}
	}

	public virtual bool IsLocked
	{
		[Export("isLocked")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLockedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLockedHandle);
		}
	}

	public virtual bool AllowsPrinting
	{
		[Export("allowsPrinting")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsPrintingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsPrintingHandle);
		}
	}

	public virtual bool AllowsCopying
	{
		[Export("allowsCopying")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsCopyingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsCopyingHandle);
		}
	}

	public virtual PdfDocumentPermissions PermissionsStatus
	{
		[Export("permissionsStatus")]
		get
		{
			if (IsDirectBinding)
			{
				return (PdfDocumentPermissions)Messaging.int_objc_msgSend(base.Handle, selPermissionsStatusHandle);
			}
			return (PdfDocumentPermissions)Messaging.int_objc_msgSendSuper(base.SuperHandle, selPermissionsStatusHandle);
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

	public virtual NSObject WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
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

	public PdfDocumentDelegate Delegate
	{
		get
		{
			return WeakDelegate as PdfDocumentDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual PdfOutline OutlineRoot
	{
		[Export("outlineRoot")]
		get
		{
			return (PdfOutline)(__mt_OutlineRoot_var = ((!IsDirectBinding) ? ((PdfOutline)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutlineRootHandle))) : ((PdfOutline)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOutlineRootHandle)))));
		}
		[Export("setOutlineRoot:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOutlineRoot_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOutlineRoot_Handle, value.Handle);
			}
			__mt_OutlineRoot_var = value;
		}
	}

	public virtual int PageCount
	{
		[Export("pageCount")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selPageCountHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selPageCountHandle);
		}
	}

	public virtual Class PageClass
	{
		[Export("pageClass")]
		get
		{
			if (IsDirectBinding)
			{
				return new Class(Messaging.IntPtr_objc_msgSend(base.Handle, selPageClassHandle));
			}
			return new Class(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPageClassHandle));
		}
	}

	public virtual bool IsFinding
	{
		[Export("isFinding")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFindingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFindingHandle);
		}
	}

	public ClassForAnnotationClassDelegate ClassForAnnotationClass
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfDocument()
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
	public PdfDocument(NSCoder coder)
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
	public PdfDocument(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public PdfDocument(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:")]
	public PdfDocument(NSUrl url)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithURL_Handle, url.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithURL_Handle, url.Handle);
		}
	}

	[Export("initWithData:")]
	public PdfDocument(NSData data)
		: base(NSObjectFlag.Empty)
	{
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

	[Export("unlockWithPassword:")]
	public virtual bool Unlock(string password)
	{
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		IntPtr arg = NSString.CreateNative(password);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selUnlockWithPassword_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selUnlockWithPassword_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("dataRepresentation")]
	public virtual NSData GetDataRepresentation()
	{
		if (IsDirectBinding)
		{
			return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDataRepresentationHandle));
		}
		return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataRepresentationHandle));
	}

	[Export("dataRepresentationWithOptions:")]
	public virtual NSData GetDataRepresentation(NSDictionary options)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (IsDirectBinding)
		{
			return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDataRepresentationWithOptions_Handle, options.Handle));
		}
		return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDataRepresentationWithOptions_Handle, options.Handle));
	}

	[Export("writeToFile:")]
	public virtual bool Write(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selWriteToFile_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selWriteToFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("writeToFile:withOptions:")]
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWriteToFileWithOptions_Handle, arg, options.Handle) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selWriteToFileWithOptions_Handle, arg, options.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("writeToURL:")]
	public virtual bool Write(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selWriteToURL_Handle, url.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selWriteToURL_Handle, url.Handle);
	}

	[Export("writeToURL:withOptions:")]
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
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selWriteToURLWithOptions_Handle, url.Handle, options.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWriteToURLWithOptions_Handle, url.Handle, options.Handle);
	}

	[Export("outlineItemForSelection:")]
	public virtual PdfOutline OutlineItem(PdfSelection selection)
	{
		if (selection == null)
		{
			throw new ArgumentNullException("selection");
		}
		if (IsDirectBinding)
		{
			return (PdfOutline)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selOutlineItemForSelection_Handle, selection.Handle));
		}
		return (PdfOutline)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selOutlineItemForSelection_Handle, selection.Handle));
	}

	[Export("pageAtIndex:")]
	public virtual PdfPage GetPage(int index)
	{
		if (IsDirectBinding)
		{
			return (PdfPage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_int(base.Handle, selPageAtIndex_Handle, index));
		}
		return (PdfPage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selPageAtIndex_Handle, index));
	}

	[Export("indexForPage:")]
	public virtual int GetPageIndex(PdfPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (IsDirectBinding)
		{
			return Messaging.int_objc_msgSend_IntPtr(base.Handle, selIndexForPage_Handle, page.Handle);
		}
		return Messaging.int_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexForPage_Handle, page.Handle);
	}

	[Export("insertPage:atIndex:")]
	public virtual void InsertPage(PdfPage page, int index)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int(base.Handle, selInsertPageAtIndex_Handle, page.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selInsertPageAtIndex_Handle, page.Handle, index);
		}
	}

	[Export("removePageAtIndex:")]
	public virtual void RemovePage(int index)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int(base.Handle, selRemovePageAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selRemovePageAtIndex_Handle, index);
		}
	}

	[Export("exchangePageAtIndex:withPageAtIndex:")]
	public virtual void ExchangePages(int indexA, int indexB)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int_int(base.Handle, selExchangePageAtIndexWithPageAtIndex_Handle, indexA, indexB);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int_int(base.SuperHandle, selExchangePageAtIndexWithPageAtIndex_Handle, indexA, indexB);
		}
	}

	[Export("findString:withOptions:")]
	public virtual PdfSelection[] Find(string text, int options)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		IntPtr arg = NSString.CreateNative(text);
		PdfSelection[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<PdfSelection>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selFindStringWithOptions_Handle, arg, options)) : NSArray.ArrayFromHandle<PdfSelection>(Messaging.IntPtr_objc_msgSend_IntPtr_int(base.Handle, selFindStringWithOptions_Handle, arg, options)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("beginFindString:withOptions:")]
	public virtual void FindAsync(string text, int options)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		IntPtr arg = NSString.CreateNative(text);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int(base.Handle, selBeginFindStringWithOptions_Handle, arg, options);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selBeginFindStringWithOptions_Handle, arg, options);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("beginFindStrings:withOptions:")]
	public virtual void FindAsync(string[] text, int options)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		NSArray nSArray = NSArray.FromStrings(text);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int(base.Handle, selBeginFindStringsWithOptions_Handle, nSArray.Handle, options);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selBeginFindStringsWithOptions_Handle, nSArray.Handle, options);
		}
		nSArray.Dispose();
	}

	[Export("findString:fromSelection:withOptions:")]
	public virtual PdfSelection Find(string text, PdfSelection selection, int options)
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
		PdfSelection result = ((!IsDirectBinding) ? ((PdfSelection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int(base.SuperHandle, selFindStringFromSelectionWithOptions_Handle, arg, selection.Handle, options))) : ((PdfSelection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_int(base.Handle, selFindStringFromSelectionWithOptions_Handle, arg, selection.Handle, options))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("cancelFindString")]
	public virtual void CancelFind()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelFindStringHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelFindStringHandle);
		}
	}

	[Export("selectionForEntireDocument")]
	public virtual PdfSelection SelectEntireDocument()
	{
		if (IsDirectBinding)
		{
			return (PdfSelection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectionForEntireDocumentHandle));
		}
		return (PdfSelection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectionForEntireDocumentHandle));
	}

	[Export("selectionFromPage:atPoint:toPage:atPoint:")]
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
		if (IsDirectBinding)
		{
			return (PdfSelection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_CGPoint_IntPtr_CGPoint(base.Handle, selSelectionFromPageAtPointToPageAtPoint_Handle, startPage.Handle, startPoint, endPage.Handle, endPoint));
		}
		return (PdfSelection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_CGPoint_IntPtr_CGPoint(base.SuperHandle, selSelectionFromPageAtPointToPageAtPoint_Handle, startPage.Handle, startPoint, endPage.Handle, endPoint));
	}

	[Export("selectionFromPage:atCharacterIndex:toPage:atCharacterIndex:")]
	public virtual PdfSelection GetSelection(PdfPage startPage, int startCharIndex, PdfPage endPage, int endCharIndex)
	{
		if (startPage == null)
		{
			throw new ArgumentNullException("startPage");
		}
		if (endPage == null)
		{
			throw new ArgumentNullException("endPage");
		}
		if (IsDirectBinding)
		{
			return (PdfSelection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr_int(base.Handle, selSelectionFromPageAtCharacterIndexToPageAtCharacterIndex_Handle, startPage.Handle, startCharIndex, endPage.Handle, endCharIndex));
		}
		return (PdfSelection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr_int(base.SuperHandle, selSelectionFromPageAtCharacterIndexToPageAtCharacterIndex_Handle, startPage.Handle, startCharIndex, endPage.Handle, endCharIndex));
	}

	private _PdfDocumentDelegate EnsurePdfDocumentDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _PdfDocumentDelegate))
		{
			nSObject = (WeakDelegate = new _PdfDocumentDelegate());
		}
		return (_PdfDocumentDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_DocumentUrl_var = null;
			__mt_DocumentAttributes_var = null;
			__mt_WeakDelegate_var = null;
			__mt_OutlineRoot_var = null;
		}
	}
}

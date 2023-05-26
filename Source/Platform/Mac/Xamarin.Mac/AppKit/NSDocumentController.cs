using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSDocumentController", true)]
public class NSDocumentController : NSObject
{
	private static readonly IntPtr selSharedDocumentControllerHandle = Selector.GetHandle("sharedDocumentController");

	private static readonly IntPtr selDocumentsHandle = Selector.GetHandle("documents");

	private static readonly IntPtr selCurrentDocumentHandle = Selector.GetHandle("currentDocument");

	private static readonly IntPtr selCurrentDirectoryHandle = Selector.GetHandle("currentDirectory");

	private static readonly IntPtr selHasEditedDocumentsHandle = Selector.GetHandle("hasEditedDocuments");

	private static readonly IntPtr selMaximumRecentDocumentCountHandle = Selector.GetHandle("maximumRecentDocumentCount");

	private static readonly IntPtr selRecentDocumentURLsHandle = Selector.GetHandle("recentDocumentURLs");

	private static readonly IntPtr selDefaultTypeHandle = Selector.GetHandle("defaultType");

	private static readonly IntPtr selDocumentClassNamesHandle = Selector.GetHandle("documentClassNames");

	private static readonly IntPtr selAutosavingDelayHandle = Selector.GetHandle("autosavingDelay");

	private static readonly IntPtr selSetAutosavingDelay_Handle = Selector.GetHandle("setAutosavingDelay:");

	private static readonly IntPtr selDocumentForURL_Handle = Selector.GetHandle("documentForURL:");

	private static readonly IntPtr selDocumentForWindow_Handle = Selector.GetHandle("documentForWindow:");

	private static readonly IntPtr selAddDocument_Handle = Selector.GetHandle("addDocument:");

	private static readonly IntPtr selRemoveDocument_Handle = Selector.GetHandle("removeDocument:");

	private static readonly IntPtr selNewDocument_Handle = Selector.GetHandle("newDocument:");

	private static readonly IntPtr selOpenUntitledDocumentAndDisplayError_Handle = Selector.GetHandle("openUntitledDocumentAndDisplay:error:");

	private static readonly IntPtr selMakeUntitledDocumentOfTypeError_Handle = Selector.GetHandle("makeUntitledDocumentOfType:error:");

	private static readonly IntPtr selOpenDocument_Handle = Selector.GetHandle("openDocument:");

	private static readonly IntPtr selURLsFromRunningOpenPanelHandle = Selector.GetHandle("URLsFromRunningOpenPanel");

	private static readonly IntPtr selRunModalOpenPanelForTypes_Handle = Selector.GetHandle("runModalOpenPanel:forTypes:");

	private static readonly IntPtr selOpenDocumentWithContentsOfURLDisplayError_Handle = Selector.GetHandle("openDocumentWithContentsOfURL:display:error:");

	private static readonly IntPtr selOpenDocumentWithContentsOfURLDisplayCompletionHandler_Handle = Selector.GetHandle("openDocumentWithContentsOfURL:display:completionHandler:");

	private static readonly IntPtr selMakeDocumentWithContentsOfURLOfTypeError_Handle = Selector.GetHandle("makeDocumentWithContentsOfURL:ofType:error:");

	private static readonly IntPtr selReopenDocumentForURLWithContentsOfURLError_Handle = Selector.GetHandle("reopenDocumentForURL:withContentsOfURL:error:");

	private static readonly IntPtr selMakeDocumentForURLWithContentsOfURLOfTypeError_Handle = Selector.GetHandle("makeDocumentForURL:withContentsOfURL:ofType:error:");

	private static readonly IntPtr selSaveAllDocuments_Handle = Selector.GetHandle("saveAllDocuments:");

	private static readonly IntPtr selReviewUnsavedDocumentsWithAlertTitleCancellableDelegateDidReviewAllSelectorContextInfo_Handle = Selector.GetHandle("reviewUnsavedDocumentsWithAlertTitle:cancellable:delegate:didReviewAllSelector:contextInfo:");

	private static readonly IntPtr selCloseAllDocumentsWithDelegateDidCloseAllSelectorContextInfo_Handle = Selector.GetHandle("closeAllDocumentsWithDelegate:didCloseAllSelector:contextInfo:");

	private static readonly IntPtr selPresentErrorModalForWindowDelegateDidPresentSelectorContextInfo_Handle = Selector.GetHandle("presentError:modalForWindow:delegate:didPresentSelector:contextInfo:");

	private static readonly IntPtr selPresentError_Handle = Selector.GetHandle("presentError:");

	private static readonly IntPtr selWillPresentError_Handle = Selector.GetHandle("willPresentError:");

	private static readonly IntPtr selClearRecentDocuments_Handle = Selector.GetHandle("clearRecentDocuments:");

	private static readonly IntPtr selNoteNewRecentDocument_Handle = Selector.GetHandle("noteNewRecentDocument:");

	private static readonly IntPtr selNoteNewRecentDocumentURL_Handle = Selector.GetHandle("noteNewRecentDocumentURL:");

	private static readonly IntPtr selTypeForContentsOfURLError_Handle = Selector.GetHandle("typeForContentsOfURL:error:");

	private static readonly IntPtr selDocumentClassForType_Handle = Selector.GetHandle("documentClassForType:");

	private static readonly IntPtr selDisplayNameForType_Handle = Selector.GetHandle("displayNameForType:");

	private static readonly IntPtr selValidateUserInterfaceItem_Handle = Selector.GetHandle("validateUserInterfaceItem:");

	private static readonly IntPtr selRestoreWindowWithIdentifierStateCompletionHandler_Handle = Selector.GetHandle("restoreWindowWithIdentifier:state:completionHandler:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSDocumentController");

	private static object __mt_SharedDocumentController_var_static;

	private object __mt_Documents_var;

	private object __mt_CurrentDocument_var;

	private object __mt_RecentDocumentUrls_var;

	public override IntPtr ClassHandle => class_ptr;

	public static NSObject SharedDocumentController
	{
		[Export("sharedDocumentController")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_SharedDocumentController_var_static = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedDocumentControllerHandle)));
		}
	}

	public virtual NSDocument[] Documents
	{
		[Export("documents")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDocument[])(__mt_Documents_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSDocument>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentsHandle)) : NSArray.ArrayFromHandle<NSDocument>(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentsHandle))));
		}
	}

	public virtual NSDocument CurrentDocument
	{
		[Export("currentDocument")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDocument)(__mt_CurrentDocument_var = ((!IsDirectBinding) ? ((NSDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentDocumentHandle))) : ((NSDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentDocumentHandle)))));
		}
	}

	public virtual string CurrentDirectory
	{
		[Export("currentDirectory")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentDirectoryHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentDirectoryHandle));
		}
	}

	public virtual bool HasEditedDocuments
	{
		[Export("hasEditedDocuments")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasEditedDocumentsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasEditedDocumentsHandle);
		}
	}

	public virtual long MaximumRecentDocumentCount
	{
		[Export("maximumRecentDocumentCount")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selMaximumRecentDocumentCountHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMaximumRecentDocumentCountHandle);
		}
	}

	public virtual NSUrl[] RecentDocumentUrls
	{
		[Export("recentDocumentURLs")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSUrl[])(__mt_RecentDocumentUrls_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecentDocumentURLsHandle)) : NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selRecentDocumentURLsHandle))));
		}
	}

	public virtual string DefaultType
	{
		[Export("defaultType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultTypeHandle));
		}
	}

	public virtual string[] DocumentClassNames
	{
		[Export("documentClassNames")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentClassNamesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentClassNamesHandle));
		}
	}

	public virtual double AutosavingDelay
	{
		[Export("autosavingDelay")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selAutosavingDelayHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selAutosavingDelayHandle);
		}
		[Export("setAutosavingDelay:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetAutosavingDelay_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetAutosavingDelay_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDocumentController()
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
	public NSDocumentController(NSCoder coder)
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
	public NSDocumentController(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSDocumentController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("documentForURL:")]
	public virtual NSDocument DocumentForUrl(NSUrl url)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			return (NSDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDocumentForURL_Handle, url.Handle));
		}
		return (NSDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDocumentForURL_Handle, url.Handle));
	}

	[Export("documentForWindow:")]
	public virtual NSDocument DocumentForWindow(NSWindow window)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		if (IsDirectBinding)
		{
			return (NSDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDocumentForWindow_Handle, window.Handle));
		}
		return (NSDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDocumentForWindow_Handle, window.Handle));
	}

	[Export("addDocument:")]
	public virtual void AddDocument(NSDocument document)
	{
		NSApplication.EnsureUIThread();
		if (document == null)
		{
			throw new ArgumentNullException("document");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddDocument_Handle, document.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddDocument_Handle, document.Handle);
		}
		_ = Documents;
	}

	[Export("removeDocument:")]
	public virtual void RemoveDocument(NSDocument document)
	{
		NSApplication.EnsureUIThread();
		if (document == null)
		{
			throw new ArgumentNullException("document");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveDocument_Handle, document.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveDocument_Handle, document.Handle);
		}
		_ = Documents;
	}

	[Export("newDocument:")]
	public virtual void NewDocument(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selNewDocument_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selNewDocument_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("openUntitledDocumentAndDisplay:error:")]
	public virtual NSObject OpenUntitledDocument(bool displayDocument, out NSError outError)
	{
		NSApplication.EnsureUIThread();
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_bool_IntPtr(base.SuperHandle, selOpenUntitledDocumentAndDisplayError_Handle, displayDocument, intPtr)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_bool_IntPtr(base.Handle, selOpenUntitledDocumentAndDisplayError_Handle, displayDocument, intPtr)));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("makeUntitledDocumentOfType:error:")]
	public virtual NSObject MakeUntitledDocument(string typeName, out NSError error)
	{
		NSApplication.EnsureUIThread();
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(typeName);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selMakeUntitledDocumentOfTypeError_Handle, arg, intPtr)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selMakeUntitledDocumentOfTypeError_Handle, arg, intPtr)));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("openDocument:")]
	public virtual void OpenDocument(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOpenDocument_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOpenDocument_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("URLsFromRunningOpenPanel")]
	public virtual NSUrl[] UrlsFromRunningOpenPanel()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLsFromRunningOpenPanelHandle));
		}
		return NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLsFromRunningOpenPanelHandle));
	}

	[Export("runModalOpenPanel:forTypes:")]
	public virtual long RunModalOpenPanel(NSOpenPanel openPanel, string[] types)
	{
		NSApplication.EnsureUIThread();
		if (openPanel == null)
		{
			throw new ArgumentNullException("openPanel");
		}
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		NSArray nSArray = NSArray.FromStrings(types);
		long result = ((!IsDirectBinding) ? Messaging.Int64_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRunModalOpenPanelForTypes_Handle, openPanel.Handle, nSArray.Handle) : Messaging.Int64_objc_msgSend_IntPtr_IntPtr(base.Handle, selRunModalOpenPanelForTypes_Handle, openPanel.Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("openDocumentWithContentsOfURL:display:error:")]
	public virtual NSObject OpenDocument(NSUrl url, bool displayDocument, out NSError outError)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_IntPtr(base.SuperHandle, selOpenDocumentWithContentsOfURLDisplayError_Handle, url.Handle, displayDocument, intPtr)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_bool_IntPtr(base.Handle, selOpenDocumentWithContentsOfURLDisplayError_Handle, url.Handle, displayDocument, intPtr)));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("openDocumentWithContentsOfURL:display:completionHandler:")]
	public unsafe virtual void OpenDocument(NSUrl url, bool display, OpenDocumentCompletionHandler completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDOpenDocumentCompletionHandler.Handler, completionHandler);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool_IntPtr(base.Handle, selOpenDocumentWithContentsOfURLDisplayCompletionHandler_Handle, url.Handle, display, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool_IntPtr(base.SuperHandle, selOpenDocumentWithContentsOfURLDisplayCompletionHandler_Handle, url.Handle, display, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("makeDocumentWithContentsOfURL:ofType:error:")]
	public virtual NSObject MakeDocument(NSUrl url, string typeName, out NSError outError)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(typeName);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selMakeDocumentWithContentsOfURLOfTypeError_Handle, url.Handle, arg, intPtr)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selMakeDocumentWithContentsOfURLOfTypeError_Handle, url.Handle, arg, intPtr)));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("reopenDocumentForURL:withContentsOfURL:error:")]
	public virtual bool ReopenDocument(NSUrl url, NSUrl contentsUrl, out NSError outError)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (contentsUrl == null)
		{
			throw new ArgumentNullException("contentsUrl");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selReopenDocumentForURLWithContentsOfURLError_Handle, url.Handle, contentsUrl.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selReopenDocumentForURLWithContentsOfURLError_Handle, url.Handle, contentsUrl.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("makeDocumentForURL:withContentsOfURL:ofType:error:")]
	public virtual NSObject MakeDocument(NSUrl urlOrNil, NSUrl contentsUrl, string typeName, out NSError outError)
	{
		NSApplication.EnsureUIThread();
		if (contentsUrl == null)
		{
			throw new ArgumentNullException("contentsUrl");
		}
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(typeName);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selMakeDocumentForURLWithContentsOfURLOfTypeError_Handle, urlOrNil?.Handle ?? IntPtr.Zero, contentsUrl.Handle, arg, intPtr)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selMakeDocumentForURLWithContentsOfURLOfTypeError_Handle, urlOrNil?.Handle ?? IntPtr.Zero, contentsUrl.Handle, arg, intPtr)));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("saveAllDocuments:")]
	public virtual void SaveAllDocuments(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSaveAllDocuments_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSaveAllDocuments_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("reviewUnsavedDocumentsWithAlertTitle:cancellable:delegate:didReviewAllSelector:contextInfo:")]
	public virtual void ReviewUnsavedDocuments(string title, bool cancellable, NSObject delegateObject, Selector didReviewAllSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		if (delegateObject == null)
		{
			throw new ArgumentNullException("delegateObject");
		}
		if (didReviewAllSelector == null)
		{
			throw new ArgumentNullException("didReviewAllSelector");
		}
		IntPtr arg = NSString.CreateNative(title);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool_IntPtr_IntPtr_IntPtr(base.Handle, selReviewUnsavedDocumentsWithAlertTitleCancellableDelegateDidReviewAllSelectorContextInfo_Handle, arg, cancellable, delegateObject.Handle, didReviewAllSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool_IntPtr_IntPtr_IntPtr(base.SuperHandle, selReviewUnsavedDocumentsWithAlertTitleCancellableDelegateDidReviewAllSelectorContextInfo_Handle, arg, cancellable, delegateObject.Handle, didReviewAllSelector.Handle, contextInfo);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("closeAllDocumentsWithDelegate:didCloseAllSelector:contextInfo:")]
	public virtual void CloseAllDocuments(NSObject delegateObject, Selector didCloseAllSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (delegateObject == null)
		{
			throw new ArgumentNullException("delegateObject");
		}
		if (didCloseAllSelector == null)
		{
			throw new ArgumentNullException("didCloseAllSelector");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selCloseAllDocumentsWithDelegateDidCloseAllSelectorContextInfo_Handle, delegateObject.Handle, didCloseAllSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCloseAllDocumentsWithDelegateDidCloseAllSelectorContextInfo_Handle, delegateObject.Handle, didCloseAllSelector.Handle, contextInfo);
		}
	}

	[Export("presentError:modalForWindow:delegate:didPresentSelector:contextInfo:")]
	public virtual void PresentError(NSError error, NSWindow window, NSObject delegateObject, Selector didPresentSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		if (delegateObject == null)
		{
			throw new ArgumentNullException("delegateObject");
		}
		if (didPresentSelector == null)
		{
			throw new ArgumentNullException("didPresentSelector");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selPresentErrorModalForWindowDelegateDidPresentSelectorContextInfo_Handle, error.Handle, window.Handle, delegateObject.Handle, didPresentSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selPresentErrorModalForWindowDelegateDidPresentSelectorContextInfo_Handle, error.Handle, window.Handle, delegateObject.Handle, didPresentSelector.Handle, contextInfo);
		}
	}

	[Export("presentError:")]
	public virtual bool PresentError(NSError error)
	{
		NSApplication.EnsureUIThread();
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPresentError_Handle, error.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPresentError_Handle, error.Handle);
	}

	[Export("willPresentError:")]
	public virtual NSError WillPresentError(NSError error)
	{
		NSApplication.EnsureUIThread();
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (IsDirectBinding)
		{
			return (NSError)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selWillPresentError_Handle, error.Handle));
		}
		return (NSError)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selWillPresentError_Handle, error.Handle));
	}

	[Export("clearRecentDocuments:")]
	public virtual void ClearRecentDocuments(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selClearRecentDocuments_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selClearRecentDocuments_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("noteNewRecentDocument:")]
	public virtual void NoteNewRecentDocument(NSDocument document)
	{
		NSApplication.EnsureUIThread();
		if (document == null)
		{
			throw new ArgumentNullException("document");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selNoteNewRecentDocument_Handle, document.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selNoteNewRecentDocument_Handle, document.Handle);
		}
	}

	[Export("noteNewRecentDocumentURL:")]
	public virtual void NoteNewRecentDocumentURL(NSUrl url)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selNoteNewRecentDocumentURL_Handle, url.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selNoteNewRecentDocumentURL_Handle, url.Handle);
		}
	}

	[Export("typeForContentsOfURL:error:")]
	public virtual string TypeForUrl(NSUrl url, out NSError outError)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selTypeForContentsOfURLError_Handle, url.Handle, intPtr)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selTypeForContentsOfURLError_Handle, url.Handle, intPtr)));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("documentClassForType:")]
	public virtual Class DocumentClassForType(string typeName)
	{
		NSApplication.EnsureUIThread();
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr arg = NSString.CreateNative(typeName);
		Class result = ((!IsDirectBinding) ? new Class(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDocumentClassForType_Handle, arg)) : new Class(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDocumentClassForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("displayNameForType:")]
	public virtual string DisplayNameForType(string typeName)
	{
		NSApplication.EnsureUIThread();
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr arg = NSString.CreateNative(typeName);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDisplayNameForType_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDisplayNameForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("validateUserInterfaceItem:")]
	public virtual bool ValidateUserInterfaceItem(NSObject anItem)
	{
		NSApplication.EnsureUIThread();
		if (anItem == null)
		{
			throw new ArgumentNullException("anItem");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selValidateUserInterfaceItem_Handle, anItem.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selValidateUserInterfaceItem_Handle, anItem.Handle);
	}

	[Export("restoreWindowWithIdentifier:state:completionHandler:")]
	public unsafe static void RestoreWindow(string identifier, NSCoder state, NSWindowCompletionHandler onCompletion)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (state == null)
		{
			throw new ArgumentNullException("state");
		}
		if (onCompletion == null)
		{
			throw new ArgumentNullException("onCompletion");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSWindowCompletionHandler.Handler, onCompletion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selRestoreWindowWithIdentifierStateCompletionHandler_Handle, arg, state.Handle, (IntPtr)ptr);
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Documents_var = null;
			__mt_CurrentDocument_var = null;
			__mt_RecentDocumentUrls_var = null;
		}
	}
}

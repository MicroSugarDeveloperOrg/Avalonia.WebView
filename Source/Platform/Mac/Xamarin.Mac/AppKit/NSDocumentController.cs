using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSDocumentController", true)]
public class NSDocumentController : NSObject, INSCoding, INativeObject, IDisposable, INSMenuItemValidation, INSWindowRestoration
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLsFromRunningOpenPanel = "URLsFromRunningOpenPanel";

	private static readonly IntPtr selURLsFromRunningOpenPanelHandle = Selector.GetHandle("URLsFromRunningOpenPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddDocument_ = "addDocument:";

	private static readonly IntPtr selAddDocument_Handle = Selector.GetHandle("addDocument:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsAutomaticShareMenu = "allowsAutomaticShareMenu";

	private static readonly IntPtr selAllowsAutomaticShareMenuHandle = Selector.GetHandle("allowsAutomaticShareMenu");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutosavingDelay = "autosavingDelay";

	private static readonly IntPtr selAutosavingDelayHandle = Selector.GetHandle("autosavingDelay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginOpenPanel_ForTypes_CompletionHandler_ = "beginOpenPanel:forTypes:completionHandler:";

	private static readonly IntPtr selBeginOpenPanel_ForTypes_CompletionHandler_Handle = Selector.GetHandle("beginOpenPanel:forTypes:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginOpenPanelWithCompletionHandler_ = "beginOpenPanelWithCompletionHandler:";

	private static readonly IntPtr selBeginOpenPanelWithCompletionHandler_Handle = Selector.GetHandle("beginOpenPanelWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClearRecentDocuments_ = "clearRecentDocuments:";

	private static readonly IntPtr selClearRecentDocuments_Handle = Selector.GetHandle("clearRecentDocuments:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCloseAllDocumentsWithDelegate_DidCloseAllSelector_ContextInfo_ = "closeAllDocumentsWithDelegate:didCloseAllSelector:contextInfo:";

	private static readonly IntPtr selCloseAllDocumentsWithDelegate_DidCloseAllSelector_ContextInfo_Handle = Selector.GetHandle("closeAllDocumentsWithDelegate:didCloseAllSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentDirectory = "currentDirectory";

	private static readonly IntPtr selCurrentDirectoryHandle = Selector.GetHandle("currentDirectory");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentDocument = "currentDocument";

	private static readonly IntPtr selCurrentDocumentHandle = Selector.GetHandle("currentDocument");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultType = "defaultType";

	private static readonly IntPtr selDefaultTypeHandle = Selector.GetHandle("defaultType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayNameForType_ = "displayNameForType:";

	private static readonly IntPtr selDisplayNameForType_Handle = Selector.GetHandle("displayNameForType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocumentClassForType_ = "documentClassForType:";

	private static readonly IntPtr selDocumentClassForType_Handle = Selector.GetHandle("documentClassForType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocumentClassNames = "documentClassNames";

	private static readonly IntPtr selDocumentClassNamesHandle = Selector.GetHandle("documentClassNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocumentForURL_ = "documentForURL:";

	private static readonly IntPtr selDocumentForURL_Handle = Selector.GetHandle("documentForURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocumentForWindow_ = "documentForWindow:";

	private static readonly IntPtr selDocumentForWindow_Handle = Selector.GetHandle("documentForWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocuments = "documents";

	private static readonly IntPtr selDocumentsHandle = Selector.GetHandle("documents");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuplicateDocumentWithContentsOfURL_Copying_DisplayName_Error_ = "duplicateDocumentWithContentsOfURL:copying:displayName:error:";

	private static readonly IntPtr selDuplicateDocumentWithContentsOfURL_Copying_DisplayName_Error_Handle = Selector.GetHandle("duplicateDocumentWithContentsOfURL:copying:displayName:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasEditedDocuments = "hasEditedDocuments";

	private static readonly IntPtr selHasEditedDocumentsHandle = Selector.GetHandle("hasEditedDocuments");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeDocumentForURL_WithContentsOfURL_OfType_Error_ = "makeDocumentForURL:withContentsOfURL:ofType:error:";

	private static readonly IntPtr selMakeDocumentForURL_WithContentsOfURL_OfType_Error_Handle = Selector.GetHandle("makeDocumentForURL:withContentsOfURL:ofType:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeDocumentWithContentsOfURL_OfType_Error_ = "makeDocumentWithContentsOfURL:ofType:error:";

	private static readonly IntPtr selMakeDocumentWithContentsOfURL_OfType_Error_Handle = Selector.GetHandle("makeDocumentWithContentsOfURL:ofType:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeUntitledDocumentOfType_Error_ = "makeUntitledDocumentOfType:error:";

	private static readonly IntPtr selMakeUntitledDocumentOfType_Error_Handle = Selector.GetHandle("makeUntitledDocumentOfType:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumRecentDocumentCount = "maximumRecentDocumentCount";

	private static readonly IntPtr selMaximumRecentDocumentCountHandle = Selector.GetHandle("maximumRecentDocumentCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewDocument_ = "newDocument:";

	private static readonly IntPtr selNewDocument_Handle = Selector.GetHandle("newDocument:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoteNewRecentDocument_ = "noteNewRecentDocument:";

	private static readonly IntPtr selNoteNewRecentDocument_Handle = Selector.GetHandle("noteNewRecentDocument:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoteNewRecentDocumentURL_ = "noteNewRecentDocumentURL:";

	private static readonly IntPtr selNoteNewRecentDocumentURL_Handle = Selector.GetHandle("noteNewRecentDocumentURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenDocument_ = "openDocument:";

	private static readonly IntPtr selOpenDocument_Handle = Selector.GetHandle("openDocument:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenDocumentWithContentsOfURL_Display_CompletionHandler_ = "openDocumentWithContentsOfURL:display:completionHandler:";

	private static readonly IntPtr selOpenDocumentWithContentsOfURL_Display_CompletionHandler_Handle = Selector.GetHandle("openDocumentWithContentsOfURL:display:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenDocumentWithContentsOfURL_Display_Error_ = "openDocumentWithContentsOfURL:display:error:";

	private static readonly IntPtr selOpenDocumentWithContentsOfURL_Display_Error_Handle = Selector.GetHandle("openDocumentWithContentsOfURL:display:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenUntitledDocumentAndDisplay_Error_ = "openUntitledDocumentAndDisplay:error:";

	private static readonly IntPtr selOpenUntitledDocumentAndDisplay_Error_Handle = Selector.GetHandle("openUntitledDocumentAndDisplay:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentError_ = "presentError:";

	private static readonly IntPtr selPresentError_Handle = Selector.GetHandle("presentError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentError_ModalForWindow_Delegate_DidPresentSelector_ContextInfo_ = "presentError:modalForWindow:delegate:didPresentSelector:contextInfo:";

	private static readonly IntPtr selPresentError_ModalForWindow_Delegate_DidPresentSelector_ContextInfo_Handle = Selector.GetHandle("presentError:modalForWindow:delegate:didPresentSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecentDocumentURLs = "recentDocumentURLs";

	private static readonly IntPtr selRecentDocumentURLsHandle = Selector.GetHandle("recentDocumentURLs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveDocument_ = "removeDocument:";

	private static readonly IntPtr selRemoveDocument_Handle = Selector.GetHandle("removeDocument:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReopenDocumentForURL_WithContentsOfURL_Display_CompletionHandler_ = "reopenDocumentForURL:withContentsOfURL:display:completionHandler:";

	private static readonly IntPtr selReopenDocumentForURL_WithContentsOfURL_Display_CompletionHandler_Handle = Selector.GetHandle("reopenDocumentForURL:withContentsOfURL:display:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReopenDocumentForURL_WithContentsOfURL_Error_ = "reopenDocumentForURL:withContentsOfURL:error:";

	private static readonly IntPtr selReopenDocumentForURL_WithContentsOfURL_Error_Handle = Selector.GetHandle("reopenDocumentForURL:withContentsOfURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRestoreWindowWithIdentifier_State_CompletionHandler_ = "restoreWindowWithIdentifier:state:completionHandler:";

	private static readonly IntPtr selRestoreWindowWithIdentifier_State_CompletionHandler_Handle = Selector.GetHandle("restoreWindowWithIdentifier:state:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReviewUnsavedDocumentsWithAlertTitle_Cancellable_Delegate_DidReviewAllSelector_ContextInfo_ = "reviewUnsavedDocumentsWithAlertTitle:cancellable:delegate:didReviewAllSelector:contextInfo:";

	private static readonly IntPtr selReviewUnsavedDocumentsWithAlertTitle_Cancellable_Delegate_DidReviewAllSelector_ContextInfo_Handle = Selector.GetHandle("reviewUnsavedDocumentsWithAlertTitle:cancellable:delegate:didReviewAllSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunModalOpenPanel_ForTypes_ = "runModalOpenPanel:forTypes:";

	private static readonly IntPtr selRunModalOpenPanel_ForTypes_Handle = Selector.GetHandle("runModalOpenPanel:forTypes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveAllDocuments_ = "saveAllDocuments:";

	private static readonly IntPtr selSaveAllDocuments_Handle = Selector.GetHandle("saveAllDocuments:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutosavingDelay_ = "setAutosavingDelay:";

	private static readonly IntPtr selSetAutosavingDelay_Handle = Selector.GetHandle("setAutosavingDelay:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedDocumentController = "sharedDocumentController";

	private static readonly IntPtr selSharedDocumentControllerHandle = Selector.GetHandle("sharedDocumentController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStandardShareMenuItem = "standardShareMenuItem";

	private static readonly IntPtr selStandardShareMenuItemHandle = Selector.GetHandle("standardShareMenuItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTypeForContentsOfURL_Error_ = "typeForContentsOfURL:error:";

	private static readonly IntPtr selTypeForContentsOfURL_Error_Handle = Selector.GetHandle("typeForContentsOfURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateMenuItem_ = "validateMenuItem:";

	private static readonly IntPtr selValidateMenuItem_Handle = Selector.GetHandle("validateMenuItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateUserInterfaceItem_ = "validateUserInterfaceItem:";

	private static readonly IntPtr selValidateUserInterfaceItem_Handle = Selector.GetHandle("validateUserInterfaceItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWillPresentError_ = "willPresentError:";

	private static readonly IntPtr selWillPresentError_Handle = Selector.GetHandle("willPresentError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSDocumentController");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual bool AllowsAutomaticShareMenu
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("allowsAutomaticShareMenu")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsAutomaticShareMenuHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsAutomaticShareMenuHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double AutosavingDelay
	{
		[Export("autosavingDelay")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selAutosavingDelayHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selAutosavingDelayHandle);
		}
		[Export("setAutosavingDelay:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetAutosavingDelay_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetAutosavingDelay_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CurrentDirectory
	{
		[Export("currentDirectory")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentDirectoryHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentDirectoryHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDocument CurrentDocument
	{
		[Export("currentDocument")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDocument>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentDocumentHandle));
			}
			return Runtime.GetNSObject<NSDocument>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentDocumentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DefaultType
	{
		[Export("defaultType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] DocumentClassNames
	{
		[Export("documentClassNames")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentClassNamesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentClassNamesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDocument[] Documents
	{
		[Export("documents")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSDocument>(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentsHandle));
			}
			return NSArray.ArrayFromHandle<NSDocument>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasEditedDocuments
	{
		[Export("hasEditedDocuments")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasEditedDocumentsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasEditedDocumentsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[ThreadSafe]
	public virtual nint MaximumRecentDocumentCount
	{
		[Export("maximumRecentDocumentCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMaximumRecentDocumentCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMaximumRecentDocumentCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl[] RecentDocumentUrls
	{
		[Export("recentDocumentURLs")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selRecentDocumentURLsHandle));
			}
			return NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecentDocumentURLsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSDocumentController SharedDocumentController
	{
		[Export("sharedDocumentController")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSDocumentController>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedDocumentControllerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual NSMenuItem StandardShareMenuItem
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("standardShareMenuItem")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMenuItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selStandardShareMenuItemHandle));
			}
			return Runtime.GetNSObject<NSMenuItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStandardShareMenuItemHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDocumentController()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	public NSDocumentController(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected NSDocumentController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSDocumentController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addDocument:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddDocument(NSDocument document)
	{
		NSApplication.EnsureUIThread();
		if (document == null)
		{
			throw new ArgumentNullException("document");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddDocument_Handle, document.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddDocument_Handle, document.Handle);
		}
	}

	[Export("beginOpenPanel:forTypes:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void BeginOpenPanel(NSOpenPanel openPanel, NSArray inTypes, [BlockProxy(typeof(Trampolines.NIDNSDocumentControllerOpenPanelResultHandler))] NSDocumentControllerOpenPanelResultHandler completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (openPanel == null)
		{
			throw new ArgumentNullException("openPanel");
		}
		if (inTypes == null)
		{
			throw new ArgumentNullException("inTypes");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSDocumentControllerOpenPanelResultHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selBeginOpenPanel_ForTypes_CompletionHandler_Handle, openPanel.Handle, inTypes.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selBeginOpenPanel_ForTypes_CompletionHandler_Handle, openPanel.Handle, inTypes.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("beginOpenPanelWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void BeginOpenPanelWithCompletionHandler([BlockProxy(typeof(Trampolines.NIDNSDocumentControllerOpenPanelWithCompletionHandler))] NSDocumentControllerOpenPanelWithCompletionHandler completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSDocumentControllerOpenPanelWithCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selBeginOpenPanelWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selBeginOpenPanelWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("clearRecentDocuments:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ClearRecentDocuments(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selClearRecentDocuments_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selClearRecentDocuments_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("closeAllDocumentsWithDelegate:didCloseAllSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selCloseAllDocumentsWithDelegate_DidCloseAllSelector_ContextInfo_Handle, delegateObject.Handle, didCloseAllSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCloseAllDocumentsWithDelegate_DidCloseAllSelector_ContextInfo_Handle, delegateObject.Handle, didCloseAllSelector.Handle, contextInfo);
		}
	}

	[Export("displayNameForType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DisplayNameForType(string typeName)
	{
		NSApplication.EnsureUIThread();
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr arg = NSString.CreateNative(typeName);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDisplayNameForType_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDisplayNameForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("documentClassForType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Class DocumentClassForType(string typeName)
	{
		NSApplication.EnsureUIThread();
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr arg = NSString.CreateNative(typeName);
		IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDocumentClassForType_Handle, arg) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDocumentClassForType_Handle, arg));
		NSString.ReleaseNative(arg);
		return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
	}

	[Export("documentForURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDocument DocumentForUrl(NSUrl url)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDocument>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDocumentForURL_Handle, url.Handle));
		}
		return Runtime.GetNSObject<NSDocument>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDocumentForURL_Handle, url.Handle));
	}

	[Export("documentForWindow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDocument DocumentForWindow(NSWindow window)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDocument>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDocumentForWindow_Handle, window.Handle));
		}
		return Runtime.GetNSObject<NSDocument>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDocumentForWindow_Handle, window.Handle));
	}

	[Export("duplicateDocumentWithContentsOfURL:copying:displayName:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDocument DuplicateDocumentWithContentsOfUrl(NSUrl url, bool duplicateByCopying, string? displayName, out NSError error)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(displayName);
		NSDocument result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDocument>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_IntPtr_ref_IntPtr(base.SuperHandle, selDuplicateDocumentWithContentsOfURL_Copying_DisplayName_Error_Handle, url.Handle, duplicateByCopying, arg2, ref arg)) : Runtime.GetNSObject<NSDocument>(Messaging.IntPtr_objc_msgSend_IntPtr_bool_IntPtr_ref_IntPtr(base.Handle, selDuplicateDocumentWithContentsOfURL_Copying_DisplayName_Error_Handle, url.Handle, duplicateByCopying, arg2, ref arg)));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
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

	[Export("makeDocumentWithContentsOfURL:ofType:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(typeName);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selMakeDocumentWithContentsOfURL_OfType_Error_Handle, url.Handle, arg2, ref arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selMakeDocumentWithContentsOfURL_OfType_Error_Handle, url.Handle, arg2, ref arg)));
		NSString.ReleaseNative(arg2);
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("makeDocumentForURL:withContentsOfURL:ofType:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject MakeDocument(NSUrl? urlOrNil, NSUrl contentsUrl, string typeName, out NSError outError)
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
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(typeName);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selMakeDocumentForURL_WithContentsOfURL_OfType_Error_Handle, (urlOrNil == null) ? IntPtr.Zero : urlOrNil.Handle, contentsUrl.Handle, arg2, ref arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.Handle, selMakeDocumentForURL_WithContentsOfURL_OfType_Error_Handle, (urlOrNil == null) ? IntPtr.Zero : urlOrNil.Handle, contentsUrl.Handle, arg2, ref arg)));
		NSString.ReleaseNative(arg2);
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("makeUntitledDocumentOfType:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject MakeUntitledDocument(string typeName, out NSError error)
	{
		NSApplication.EnsureUIThread();
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(typeName);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selMakeUntitledDocumentOfType_Error_Handle, arg2, ref arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selMakeUntitledDocumentOfType_Error_Handle, arg2, ref arg)));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("newDocument:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void NewDocument(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selNewDocument_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selNewDocument_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("noteNewRecentDocument:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void NoteNewRecentDocument(NSDocument document)
	{
		NSApplication.EnsureUIThread();
		if (document == null)
		{
			throw new ArgumentNullException("document");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selNoteNewRecentDocument_Handle, document.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selNoteNewRecentDocument_Handle, document.Handle);
		}
	}

	[Export("noteNewRecentDocumentURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void NoteNewRecentDocumentURL(NSUrl url)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selNoteNewRecentDocumentURL_Handle, url.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selNoteNewRecentDocumentURL_Handle, url.Handle);
		}
	}

	[Export("openDocument:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void OpenDocument(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOpenDocument_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOpenDocument_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("openDocumentWithContentsOfURL:display:error:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.None, "Use 'OpenDocument (NSUrl, bool, OpenDocumentCompletionHandler)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject OpenDocument(NSUrl url, bool displayDocument, out NSError outError)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_ref_IntPtr(base.SuperHandle, selOpenDocumentWithContentsOfURL_Display_Error_Handle, url.Handle, displayDocument, ref arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_bool_ref_IntPtr(base.Handle, selOpenDocumentWithContentsOfURL_Display_Error_Handle, url.Handle, displayDocument, ref arg)));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("openDocumentWithContentsOfURL:display:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void OpenDocument(NSUrl url, bool display, [BlockProxy(typeof(Trampolines.NIDOpenDocumentCompletionHandler))] OpenDocumentCompletionHandler completionHandler)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDOpenDocumentCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool_IntPtr(base.Handle, selOpenDocumentWithContentsOfURL_Display_CompletionHandler_Handle, url.Handle, display, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool_IntPtr(base.SuperHandle, selOpenDocumentWithContentsOfURL_Display_CompletionHandler_Handle, url.Handle, display, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("openUntitledDocumentAndDisplay:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject OpenUntitledDocument(bool displayDocument, out NSError outError)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = IntPtr.Zero;
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_bool_ref_IntPtr(base.SuperHandle, selOpenUntitledDocumentAndDisplay_Error_Handle, displayDocument, ref arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_bool_ref_IntPtr(base.Handle, selOpenUntitledDocumentAndDisplay_Error_Handle, displayDocument, ref arg)));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("presentError:modalForWindow:delegate:didPresentSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentError(NSError error, NSWindow window, NSObject? delegateObject, Selector? didPresentSelector, IntPtr contextInfo)
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selPresentError_ModalForWindow_Delegate_DidPresentSelector_ContextInfo_Handle, error.Handle, window.Handle, delegateObject?.Handle ?? IntPtr.Zero, (didPresentSelector == null) ? IntPtr.Zero : didPresentSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selPresentError_ModalForWindow_Delegate_DidPresentSelector_ContextInfo_Handle, error.Handle, window.Handle, delegateObject?.Handle ?? IntPtr.Zero, (didPresentSelector == null) ? IntPtr.Zero : didPresentSelector.Handle, contextInfo);
		}
	}

	[Export("presentError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PresentError(NSError error)
	{
		NSApplication.EnsureUIThread();
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPresentError_Handle, error.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPresentError_Handle, error.Handle);
	}

	[Export("removeDocument:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveDocument(NSDocument document)
	{
		NSApplication.EnsureUIThread();
		if (document == null)
		{
			throw new ArgumentNullException("document");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveDocument_Handle, document.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveDocument_Handle, document.Handle);
		}
	}

	[Export("reopenDocumentForURL:withContentsOfURL:error:")]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.None, "Use 'NSDocumentController.ReopenDocumentForUrl (NSUrl, NSUrl, bool, OpenDocumentCompletionHandler)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selReopenDocumentForURL_WithContentsOfURL_Error_Handle, url.Handle, contentsUrl.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selReopenDocumentForURL_WithContentsOfURL_Error_Handle, url.Handle, contentsUrl.Handle, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("reopenDocumentForURL:withContentsOfURL:display:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ReopenDocumentForUrl(NSUrl? url, NSUrl contentsUrl, bool displayDocument, [BlockProxy(typeof(Trampolines.NIDOpenDocumentCompletionHandler))] OpenDocumentCompletionHandler completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (contentsUrl == null)
		{
			throw new ArgumentNullException("contentsUrl");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDOpenDocumentCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_bool_IntPtr(base.Handle, selReopenDocumentForURL_WithContentsOfURL_Display_CompletionHandler_Handle, (url == null) ? IntPtr.Zero : url.Handle, contentsUrl.Handle, displayDocument, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool_IntPtr(base.SuperHandle, selReopenDocumentForURL_WithContentsOfURL_Display_CompletionHandler_Handle, (url == null) ? IntPtr.Zero : url.Handle, contentsUrl.Handle, displayDocument, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("restoreWindowWithIdentifier:state:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void RestoreWindow(string identifier, NSCoder state, [BlockProxy(typeof(Trampolines.NIDNSWindowCompletionHandler))] NSWindowCompletionHandler onCompletion)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSWindowCompletionHandler.Handler, onCompletion);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selRestoreWindowWithIdentifier_State_CompletionHandler_Handle, arg, state.Handle, (IntPtr)ptr);
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Export("reviewUnsavedDocumentsWithAlertTitle:cancellable:delegate:didReviewAllSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool_IntPtr_IntPtr_IntPtr(base.Handle, selReviewUnsavedDocumentsWithAlertTitle_Cancellable_Delegate_DidReviewAllSelector_ContextInfo_Handle, arg, cancellable, delegateObject.Handle, didReviewAllSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool_IntPtr_IntPtr_IntPtr(base.SuperHandle, selReviewUnsavedDocumentsWithAlertTitle_Cancellable_Delegate_DidReviewAllSelector_ContextInfo_Handle, arg, cancellable, delegateObject.Handle, didReviewAllSelector.Handle, contextInfo);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("runModalOpenPanel:forTypes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint RunModalOpenPanel(NSOpenPanel openPanel, string[] types)
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
		nint result = ((!base.IsDirectBinding) ? Messaging.nint_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRunModalOpenPanel_ForTypes_Handle, openPanel.Handle, nSArray.Handle) : Messaging.nint_objc_msgSend_IntPtr_IntPtr(base.Handle, selRunModalOpenPanel_ForTypes_Handle, openPanel.Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("saveAllDocuments:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SaveAllDocuments(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSaveAllDocuments_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSaveAllDocuments_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("typeForContentsOfURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string TypeForUrl(NSUrl url, out NSError outError)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selTypeForContentsOfURL_Error_Handle, url.Handle, ref arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selTypeForContentsOfURL_Error_Handle, url.Handle, ref arg)));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("URLsFromRunningOpenPanel")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl[] UrlsFromRunningOpenPanel()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLsFromRunningOpenPanelHandle));
		}
		return NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLsFromRunningOpenPanelHandle));
	}

	[Export("validateMenuItem:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ValidateMenuItem(NSMenuItem menuItem)
	{
		NSApplication.EnsureUIThread();
		if (menuItem == null)
		{
			throw new ArgumentNullException("menuItem");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selValidateMenuItem_Handle, menuItem.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selValidateMenuItem_Handle, menuItem.Handle);
	}

	[Export("validateUserInterfaceItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ValidateUserInterfaceItem(NSObject anItem)
	{
		NSApplication.EnsureUIThread();
		if (anItem == null)
		{
			throw new ArgumentNullException("anItem");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selValidateUserInterfaceItem_Handle, anItem.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selValidateUserInterfaceItem_Handle, anItem.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool ValidateUserInterfaceItem(INSValidatedUserInterfaceItem anItem)
	{
		return ValidateUserInterfaceItem((NSObject)anItem);
	}

	[Export("willPresentError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSError WillPresentError(NSError error)
	{
		NSApplication.EnsureUIThread();
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selWillPresentError_Handle, error.Handle));
		}
		return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selWillPresentError_Handle, error.Handle));
	}
}

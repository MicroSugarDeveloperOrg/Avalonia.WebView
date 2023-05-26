using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSDocument", true)]
public class NSDocument : NSObject
{
	public delegate void DuplicateCallback(NSDocument document, bool didDuplicate);

	[Register("__NSDocumentDuplicateCallback")]
	internal class Callback : NSObject
	{
		private DuplicateCallback callback;

		public Callback(DuplicateCallback callback)
		{
			this.callback = callback;
		}

		[Export("document:didDuplicate:contextInfo:")]
		private void SelectorCallback(NSDocument source, bool didDuplicate, IntPtr contextInfo)
		{
			callback(source, didDuplicate);
			if (proxies != null)
			{
				proxies.Remove(this);
				if (proxies.Count == 0)
				{
					proxies = null;
				}
			}
		}
	}

	private static List<Callback> proxies;

	private static readonly IntPtr selShouldRunSavePanelWithAccessoryViewHandle = Selector.GetHandle("shouldRunSavePanelWithAccessoryView");

	private static readonly IntPtr selFileNameExtensionWasHiddenInLastRunSavePanelHandle = Selector.GetHandle("fileNameExtensionWasHiddenInLastRunSavePanel");

	private static readonly IntPtr selFileTypeFromLastRunSavePanelHandle = Selector.GetHandle("fileTypeFromLastRunSavePanel");

	private static readonly IntPtr selHasUnautosavedChangesHandle = Selector.GetHandle("hasUnautosavedChanges");

	private static readonly IntPtr selAutosavingFileTypeHandle = Selector.GetHandle("autosavingFileType");

	private static readonly IntPtr selIsDocumentEditedHandle = Selector.GetHandle("isDocumentEdited");

	private static readonly IntPtr selWindowNibNameHandle = Selector.GetHandle("windowNibName");

	private static readonly IntPtr selWindowControllersHandle = Selector.GetHandle("windowControllers");

	private static readonly IntPtr selDisplayNameHandle = Selector.GetHandle("displayName");

	private static readonly IntPtr selSetDisplayName_Handle = Selector.GetHandle("setDisplayName:");

	private static readonly IntPtr selWindowForSheetHandle = Selector.GetHandle("windowForSheet");

	private static readonly IntPtr selReadableTypesHandle = Selector.GetHandle("readableTypes");

	private static readonly IntPtr selFileTypeHandle = Selector.GetHandle("fileType");

	private static readonly IntPtr selSetFileType_Handle = Selector.GetHandle("setFileType:");

	private static readonly IntPtr selFileURLHandle = Selector.GetHandle("fileURL");

	private static readonly IntPtr selSetFileURL_Handle = Selector.GetHandle("setFileURL:");

	private static readonly IntPtr selFileModificationDateHandle = Selector.GetHandle("fileModificationDate");

	private static readonly IntPtr selSetFileModificationDate_Handle = Selector.GetHandle("setFileModificationDate:");

	private static readonly IntPtr selAutosavedContentsFileURLHandle = Selector.GetHandle("autosavedContentsFileURL");

	private static readonly IntPtr selSetAutosavedContentsFileURL_Handle = Selector.GetHandle("setAutosavedContentsFileURL:");

	private static readonly IntPtr selPrintInfoHandle = Selector.GetHandle("printInfo");

	private static readonly IntPtr selSetPrintInfo_Handle = Selector.GetHandle("setPrintInfo:");

	private static readonly IntPtr selUndoManagerHandle = Selector.GetHandle("undoManager");

	private static readonly IntPtr selSetUndoManager_Handle = Selector.GetHandle("setUndoManager:");

	private static readonly IntPtr selHasUndoManagerHandle = Selector.GetHandle("hasUndoManager");

	private static readonly IntPtr selSetHasUndoManager_Handle = Selector.GetHandle("setHasUndoManager:");

	private static readonly IntPtr selIsEntireFileLoadedHandle = Selector.GetHandle("isEntireFileLoaded");

	private static readonly IntPtr selAutosavingIsImplicitlyCancellableHandle = Selector.GetHandle("autosavingIsImplicitlyCancellable");

	private static readonly IntPtr selIsInViewingModeHandle = Selector.GetHandle("isInViewingMode");

	private static readonly IntPtr selInitWithTypeError_Handle = Selector.GetHandle("initWithType:error:");

	private static readonly IntPtr selCanConcurrentlyReadDocumentsOfType_Handle = Selector.GetHandle("canConcurrentlyReadDocumentsOfType:");

	private static readonly IntPtr selInitWithContentsOfURLOfTypeError_Handle = Selector.GetHandle("initWithContentsOfURL:ofType:error:");

	private static readonly IntPtr selInitForURLWithContentsOfURLOfTypeError_Handle = Selector.GetHandle("initForURL:withContentsOfURL:ofType:error:");

	private static readonly IntPtr selRevertDocumentToSaved_Handle = Selector.GetHandle("revertDocumentToSaved:");

	private static readonly IntPtr selRevertToContentsOfURLOfTypeError_Handle = Selector.GetHandle("revertToContentsOfURL:ofType:error:");

	private static readonly IntPtr selReadFromURLOfTypeError_Handle = Selector.GetHandle("readFromURL:ofType:error:");

	private static readonly IntPtr selReadFromFileWrapperOfTypeError_Handle = Selector.GetHandle("readFromFileWrapper:ofType:error:");

	private static readonly IntPtr selReadFromDataOfTypeError_Handle = Selector.GetHandle("readFromData:ofType:error:");

	private static readonly IntPtr selWriteToURLOfTypeError_Handle = Selector.GetHandle("writeToURL:ofType:error:");

	private static readonly IntPtr selFileWrapperOfTypeError_Handle = Selector.GetHandle("fileWrapperOfType:error:");

	private static readonly IntPtr selDataOfTypeError_Handle = Selector.GetHandle("dataOfType:error:");

	private static readonly IntPtr selWriteSafelyToURLOfTypeForSaveOperationError_Handle = Selector.GetHandle("writeSafelyToURL:ofType:forSaveOperation:error:");

	private static readonly IntPtr selWriteToURLOfTypeForSaveOperationOriginalContentsURLError_Handle = Selector.GetHandle("writeToURL:ofType:forSaveOperation:originalContentsURL:error:");

	private static readonly IntPtr selFileAttributesToWriteToURLOfTypeForSaveOperationOriginalContentsURLError_Handle = Selector.GetHandle("fileAttributesToWriteToURL:ofType:forSaveOperation:originalContentsURL:error:");

	private static readonly IntPtr selKeepBackupFileHandle = Selector.GetHandle("keepBackupFile");

	private static readonly IntPtr selSaveDocument_Handle = Selector.GetHandle("saveDocument:");

	private static readonly IntPtr selSaveDocumentAs_Handle = Selector.GetHandle("saveDocumentAs:");

	private static readonly IntPtr selSaveDocumentTo_Handle = Selector.GetHandle("saveDocumentTo:");

	private static readonly IntPtr selSaveDocumentWithDelegateDidSaveSelectorContextInfo_Handle = Selector.GetHandle("saveDocumentWithDelegate:didSaveSelector:contextInfo:");

	private static readonly IntPtr selRunModalSavePanelForSaveOperationDelegateDidSaveSelectorContextInfo_Handle = Selector.GetHandle("runModalSavePanelForSaveOperation:delegate:didSaveSelector:contextInfo:");

	private static readonly IntPtr selPrepareSavePanel_Handle = Selector.GetHandle("prepareSavePanel:");

	private static readonly IntPtr selSaveToURLOfTypeForSaveOperationDelegateDidSaveSelectorContextInfo_Handle = Selector.GetHandle("saveToURL:ofType:forSaveOperation:delegate:didSaveSelector:contextInfo:");

	private static readonly IntPtr selSaveToURLOfTypeForSaveOperationError_Handle = Selector.GetHandle("saveToURL:ofType:forSaveOperation:error:");

	private static readonly IntPtr selAutosaveDocumentWithDelegateDidAutosaveSelectorContextInfo_Handle = Selector.GetHandle("autosaveDocumentWithDelegate:didAutosaveSelector:contextInfo:");

	private static readonly IntPtr selCanCloseDocumentWithDelegateShouldCloseSelectorContextInfo_Handle = Selector.GetHandle("canCloseDocumentWithDelegate:shouldCloseSelector:contextInfo:");

	private static readonly IntPtr selCloseHandle = Selector.GetHandle("close");

	private static readonly IntPtr selRunPageLayout_Handle = Selector.GetHandle("runPageLayout:");

	private static readonly IntPtr selRunModalPageLayoutWithPrintInfoDelegateDidRunSelectorContextInfo_Handle = Selector.GetHandle("runModalPageLayoutWithPrintInfo:delegate:didRunSelector:contextInfo:");

	private static readonly IntPtr selPreparePageLayout_Handle = Selector.GetHandle("preparePageLayout:");

	private static readonly IntPtr selShouldChangePrintInfo_Handle = Selector.GetHandle("shouldChangePrintInfo:");

	private static readonly IntPtr selPrintDocument_Handle = Selector.GetHandle("printDocument:");

	private static readonly IntPtr selPrintDocumentWithSettingsShowPrintPanelDelegateDidPrintSelectorContextInfo_Handle = Selector.GetHandle("printDocumentWithSettings:showPrintPanel:delegate:didPrintSelector:contextInfo:");

	private static readonly IntPtr selPrintOperationWithSettingsError_Handle = Selector.GetHandle("printOperationWithSettings:error:");

	private static readonly IntPtr selRunModalPrintOperationDelegateDidRunSelectorContextInfo_Handle = Selector.GetHandle("runModalPrintOperation:delegate:didRunSelector:contextInfo:");

	private static readonly IntPtr selUpdateChangeCount_Handle = Selector.GetHandle("updateChangeCount:");

	private static readonly IntPtr selPresentErrorModalForWindowDelegateDidPresentSelectorContextInfo_Handle = Selector.GetHandle("presentError:modalForWindow:delegate:didPresentSelector:contextInfo:");

	private static readonly IntPtr selPresentError_Handle = Selector.GetHandle("presentError:");

	private static readonly IntPtr selWillPresentError_Handle = Selector.GetHandle("willPresentError:");

	private static readonly IntPtr selMakeWindowControllersHandle = Selector.GetHandle("makeWindowControllers");

	private static readonly IntPtr selWindowControllerWillLoadNib_Handle = Selector.GetHandle("windowControllerWillLoadNib:");

	private static readonly IntPtr selWindowControllerDidLoadNib_Handle = Selector.GetHandle("windowControllerDidLoadNib:");

	private static readonly IntPtr selSetWindow_Handle = Selector.GetHandle("setWindow:");

	private static readonly IntPtr selAddWindowController_Handle = Selector.GetHandle("addWindowController:");

	private static readonly IntPtr selRemoveWindowController_Handle = Selector.GetHandle("removeWindowController:");

	private static readonly IntPtr selShowWindowsHandle = Selector.GetHandle("showWindows");

	private static readonly IntPtr selShouldCloseWindowControllerDelegateShouldCloseSelectorContextInfo_Handle = Selector.GetHandle("shouldCloseWindowController:delegate:shouldCloseSelector:contextInfo:");

	private static readonly IntPtr selWritableTypesHandle = Selector.GetHandle("writableTypes");

	private static readonly IntPtr selIsNativeType_Handle = Selector.GetHandle("isNativeType:");

	private static readonly IntPtr selWritableTypesForSaveOperation_Handle = Selector.GetHandle("writableTypesForSaveOperation:");

	private static readonly IntPtr selFileNameExtensionForTypeSaveOperation_Handle = Selector.GetHandle("fileNameExtensionForType:saveOperation:");

	private static readonly IntPtr selValidateUserInterfaceItem_Handle = Selector.GetHandle("validateUserInterfaceItem:");

	private static readonly IntPtr selPerformActivityWithSynchronousWaitingUsingBlock_Handle = Selector.GetHandle("performActivityWithSynchronousWaiting:usingBlock:");

	private static readonly IntPtr selContinueActivityUsingBlock_Handle = Selector.GetHandle("continueActivityUsingBlock:");

	private static readonly IntPtr selContinueAsynchronousWorkOnMainThreadUsingBlock_Handle = Selector.GetHandle("continueAsynchronousWorkOnMainThreadUsingBlock:");

	private static readonly IntPtr selPerformSynchronousFileAccessUsingBlock_Handle = Selector.GetHandle("performSynchronousFileAccessUsingBlock:");

	private static readonly IntPtr selPerformAsynchronousFileAccessUsingBlock_Handle = Selector.GetHandle("performAsynchronousFileAccessUsingBlock:");

	private static readonly IntPtr selUnblockUserInteractionHandle = Selector.GetHandle("unblockUserInteraction");

	private static readonly IntPtr selSaveToURLOfTypeForSaveOperationCompletionHandler_Handle = Selector.GetHandle("saveToURL:ofType:forSaveOperation:completionHandler:");

	private static readonly IntPtr selCanAsynchronouslyWriteToURLOfTypeForSaveOperation_Handle = Selector.GetHandle("canAsynchronouslyWriteToURL:ofType:forSaveOperation:");

	private static readonly IntPtr selCheckAutosavingSafetyAndReturnError_Handle = Selector.GetHandle("checkAutosavingSafetyAndReturnError:");

	private static readonly IntPtr selScheduleAutosavingHandle = Selector.GetHandle("scheduleAutosaving");

	private static readonly IntPtr selAutosaveWithImplicitCancellabilityCompletionHandler_Handle = Selector.GetHandle("autosaveWithImplicitCancellability:completionHandler:");

	private static readonly IntPtr selAutosavesInPlaceHandle = Selector.GetHandle("autosavesInPlace");

	private static readonly IntPtr selPreservesVersionsHandle = Selector.GetHandle("preservesVersions");

	private static readonly IntPtr selDuplicateDocument_Handle = Selector.GetHandle("duplicateDocument:");

	private static readonly IntPtr selDuplicateDocumentWithDelegateDidDuplicateSelectorContextInfo_Handle = Selector.GetHandle("duplicateDocumentWithDelegate:didDuplicateSelector:contextInfo:");

	private static readonly IntPtr selDuplicateAndReturnError_Handle = Selector.GetHandle("duplicateAndReturnError:");

	private static readonly IntPtr selChangeCountTokenForSaveOperation_Handle = Selector.GetHandle("changeCountTokenForSaveOperation:");

	private static readonly IntPtr selUpdateChangeCountWithTokenForSaveOperation_Handle = Selector.GetHandle("updateChangeCountWithToken:forSaveOperation:");

	private static readonly IntPtr selWillNotPresentError_Handle = Selector.GetHandle("willNotPresentError:");

	private static readonly IntPtr selRestoreDocumentWindowWithIdentifierStateCompletionHandler_Handle = Selector.GetHandle("restoreDocumentWindowWithIdentifier:state:completionHandler:");

	private static readonly IntPtr selEncodeRestorableStateWithCoder_Handle = Selector.GetHandle("encodeRestorableStateWithCoder:");

	private static readonly IntPtr selRestoreStateWithCoder_Handle = Selector.GetHandle("restoreStateWithCoder:");

	private static readonly IntPtr selInvalidateRestorableStateHandle = Selector.GetHandle("invalidateRestorableState");

	private static readonly IntPtr selRestorableStateKeyPathsHandle = Selector.GetHandle("restorableStateKeyPaths");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSDocument");

	private object __mt_WindowControllers_var;

	private object __mt_WindowForSheet_var;

	private object __mt_FileUrl_var;

	private object __mt_FileModificationDate_var;

	private object __mt_AutosavedContentsFileUrl_var;

	private object __mt_PrintInfo_var;

	private object __mt_UndoManager_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual bool ShouldRunSavePanelWithAccessoryView
	{
		[Export("shouldRunSavePanelWithAccessoryView")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldRunSavePanelWithAccessoryViewHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldRunSavePanelWithAccessoryViewHandle);
		}
	}

	public virtual bool FileNameExtensionWasHiddenInLastRunSavePanel
	{
		[Export("fileNameExtensionWasHiddenInLastRunSavePanel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selFileNameExtensionWasHiddenInLastRunSavePanelHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selFileNameExtensionWasHiddenInLastRunSavePanelHandle);
		}
	}

	public virtual string FileTypeFromLastRunSavePanel
	{
		[Export("fileTypeFromLastRunSavePanel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFileTypeFromLastRunSavePanelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileTypeFromLastRunSavePanelHandle));
		}
	}

	public virtual bool HasUnautosavedChanges
	{
		[Export("hasUnautosavedChanges")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasUnautosavedChangesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasUnautosavedChangesHandle);
		}
	}

	public virtual string AutosavingFileType
	{
		[Export("autosavingFileType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAutosavingFileTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAutosavingFileTypeHandle));
		}
	}

	public virtual bool IsDocumentEdited
	{
		[Export("isDocumentEdited")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDocumentEditedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDocumentEditedHandle);
		}
	}

	public virtual string WindowNibName
	{
		[Export("windowNibName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowNibNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowNibNameHandle));
		}
	}

	public virtual NSWindowController[] WindowControllers
	{
		[Export("windowControllers")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSWindowController[])(__mt_WindowControllers_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSWindowController>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowControllersHandle)) : NSArray.ArrayFromHandle<NSWindowController>(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowControllersHandle))));
		}
	}

	public virtual string DisplayName
	{
		[Export("displayName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDisplayNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDisplayNameHandle));
		}
		[Export("setDisplayName:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDisplayName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDisplayName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSWindow WindowForSheet
	{
		[Export("windowForSheet")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSWindow)(__mt_WindowForSheet_var = ((!IsDirectBinding) ? ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowForSheetHandle))) : ((NSWindow)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowForSheetHandle)))));
		}
	}

	public static string[] ReadableTypes
	{
		[Export("readableTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selReadableTypesHandle));
		}
	}

	public virtual string FileType
	{
		[Export("fileType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFileTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileTypeHandle));
		}
		[Export("setFileType:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFileType_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFileType_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSUrl FileUrl
	{
		[Export("fileURL")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSUrl)(__mt_FileUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFileURLHandle)))));
		}
		[Export("setFileURL:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFileURL_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFileURL_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_FileUrl_var = value;
		}
	}

	public virtual NSDate FileModificationDate
	{
		[Export("fileModificationDate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDate)(__mt_FileModificationDate_var = ((!IsDirectBinding) ? ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileModificationDateHandle))) : ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFileModificationDateHandle)))));
		}
		[Export("setFileModificationDate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFileModificationDate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFileModificationDate_Handle, value.Handle);
			}
			__mt_FileModificationDate_var = value;
		}
	}

	public virtual NSUrl AutosavedContentsFileUrl
	{
		[Export("autosavedContentsFileURL")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSUrl)(__mt_AutosavedContentsFileUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAutosavedContentsFileURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAutosavedContentsFileURLHandle)))));
		}
		[Export("setAutosavedContentsFileURL:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAutosavedContentsFileURL_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAutosavedContentsFileURL_Handle, value.Handle);
			}
			__mt_AutosavedContentsFileUrl_var = value;
		}
	}

	public virtual NSPrintInfo PrintInfo
	{
		[Export("printInfo")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSPrintInfo)(__mt_PrintInfo_var = ((!IsDirectBinding) ? ((NSPrintInfo)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrintInfoHandle))) : ((NSPrintInfo)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPrintInfoHandle)))));
		}
		[Export("setPrintInfo:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPrintInfo_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPrintInfo_Handle, value.Handle);
			}
			__mt_PrintInfo_var = value;
		}
	}

	public virtual NSUndoManager UndoManager
	{
		[Export("undoManager")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSUndoManager)(__mt_UndoManager_var = ((!IsDirectBinding) ? ((NSUndoManager)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUndoManagerHandle))) : ((NSUndoManager)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUndoManagerHandle)))));
		}
		[Export("setUndoManager:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUndoManager_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUndoManager_Handle, value.Handle);
			}
			__mt_UndoManager_var = value;
		}
	}

	public virtual bool HasUndoManager
	{
		[Export("hasUndoManager")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasUndoManagerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasUndoManagerHandle);
		}
		[Export("setHasUndoManager:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasUndoManager_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasUndoManager_Handle, value);
			}
		}
	}

	public virtual bool IsEntireFileLoaded
	{
		[Export("isEntireFileLoaded")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEntireFileLoadedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEntireFileLoadedHandle);
		}
	}

	public virtual bool AutosavingIsImplicitlyCancellable
	{
		[Export("autosavingIsImplicitlyCancellable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutosavingIsImplicitlyCancellableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutosavingIsImplicitlyCancellableHandle);
		}
	}

	public virtual bool IsInViewingMode
	{
		[Export("isInViewingMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsInViewingModeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsInViewingModeHandle);
		}
	}

	public void DuplicateDocument(DuplicateCallback callback)
	{
		if (callback == null)
		{
			_DuplicateDocument(null, null, IntPtr.Zero);
		}
		Callback callback2 = new Callback(callback);
		if (proxies == null)
		{
			proxies = new List<Callback>();
		}
		proxies.Add(callback2);
		_DuplicateDocument(callback2, new Selector("document:didDuplicate:contextInfo:"), IntPtr.Zero);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDocument()
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
	public NSDocument(NSCoder coder)
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
	public NSDocument(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSDocument(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithType:error:")]
	public NSDocument(string typeName, out NSError outError)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(typeName);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithTypeError_Handle, arg, intPtr);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithTypeError_Handle, arg, intPtr);
		}
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	[Export("canConcurrentlyReadDocumentsOfType:")]
	public static bool CanConcurrentlyReadDocumentsOfType(string typeName)
	{
		NSApplication.EnsureUIThread();
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr arg = NSString.CreateNative(typeName);
		bool result = Messaging.bool_objc_msgSend_IntPtr(class_ptr, selCanConcurrentlyReadDocumentsOfType_Handle, arg);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithContentsOfURL:ofType:error:")]
	public NSDocument(NSUrl url, string typeName, out NSError outError)
		: base(NSObjectFlag.Empty)
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
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithContentsOfURLOfTypeError_Handle, url.Handle, arg, intPtr);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithContentsOfURLOfTypeError_Handle, url.Handle, arg, intPtr);
		}
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	[Export("initForURL:withContentsOfURL:ofType:error:")]
	public NSDocument(NSUrl documentUrl, NSUrl documentContentsUrl, string typeName, out NSError outError)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (documentContentsUrl == null)
		{
			throw new ArgumentNullException("documentContentsUrl");
		}
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(typeName);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitForURLWithContentsOfURLOfTypeError_Handle, documentUrl?.Handle ?? IntPtr.Zero, documentContentsUrl.Handle, arg, intPtr);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitForURLWithContentsOfURLOfTypeError_Handle, documentUrl?.Handle ?? IntPtr.Zero, documentContentsUrl.Handle, arg, intPtr);
		}
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	[Export("revertDocumentToSaved:")]
	public virtual void RevertDocumentToSaved(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRevertDocumentToSaved_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRevertDocumentToSaved_Handle, sender.Handle);
		}
	}

	[Export("revertToContentsOfURL:ofType:error:")]
	public virtual bool RevertToContentsOfUrl(NSUrl url, string typeName, out NSError outError)
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRevertToContentsOfURLOfTypeError_Handle, url.Handle, arg, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRevertToContentsOfURLOfTypeError_Handle, url.Handle, arg, intPtr));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("readFromURL:ofType:error:")]
	public virtual bool ReadFromUrl(NSUrl url, string typeName, out NSError outError)
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selReadFromURLOfTypeError_Handle, url.Handle, arg, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selReadFromURLOfTypeError_Handle, url.Handle, arg, intPtr));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("readFromFileWrapper:ofType:error:")]
	public virtual bool ReadFromFileWrapper(NSFileWrapper fileWrapper, string typeName, out NSError outError)
	{
		NSApplication.EnsureUIThread();
		if (fileWrapper == null)
		{
			throw new ArgumentNullException("fileWrapper");
		}
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(typeName);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selReadFromFileWrapperOfTypeError_Handle, fileWrapper.Handle, arg, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selReadFromFileWrapperOfTypeError_Handle, fileWrapper.Handle, arg, intPtr));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("readFromData:ofType:error:")]
	public virtual bool ReadFromData(NSData data, string typeName, out NSError outError)
	{
		NSApplication.EnsureUIThread();
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(typeName);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selReadFromDataOfTypeError_Handle, data.Handle, arg, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selReadFromDataOfTypeError_Handle, data.Handle, arg, intPtr));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("writeToURL:ofType:error:")]
	public virtual bool WriteToUrl(NSUrl url, string typeName, out NSError outError)
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selWriteToURLOfTypeError_Handle, url.Handle, arg, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selWriteToURLOfTypeError_Handle, url.Handle, arg, intPtr));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("fileWrapperOfType:error:")]
	public virtual NSFileWrapper GetAsFileWrapper(string typeName, out NSError outError)
	{
		NSApplication.EnsureUIThread();
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(typeName);
		NSFileWrapper result = ((!IsDirectBinding) ? ((NSFileWrapper)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFileWrapperOfTypeError_Handle, arg, intPtr))) : ((NSFileWrapper)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selFileWrapperOfTypeError_Handle, arg, intPtr))));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("dataOfType:error:")]
	public virtual NSData GetAsData(string typeName, out NSError outError)
	{
		NSApplication.EnsureUIThread();
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(typeName);
		NSData result = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selDataOfTypeError_Handle, arg, intPtr))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selDataOfTypeError_Handle, arg, intPtr))));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("writeSafelyToURL:ofType:forSaveOperation:error:")]
	public virtual bool WriteSafelyToUrl(NSUrl url, string typeName, NSSaveOperationType saveOperation, out NSError outError)
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr(base.SuperHandle, selWriteSafelyToURLOfTypeForSaveOperationError_Handle, url.Handle, arg, (ulong)saveOperation, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr(base.Handle, selWriteSafelyToURLOfTypeForSaveOperationError_Handle, url.Handle, arg, (ulong)saveOperation, intPtr));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("writeToURL:ofType:forSaveOperation:originalContentsURL:error:")]
	public virtual bool WriteToUrl(NSUrl url, string typeName, NSSaveOperationType saveOperation, NSUrl absoluteOriginalContentsUrl, out NSError outError)
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
		if (absoluteOriginalContentsUrl == null)
		{
			throw new ArgumentNullException("absoluteOriginalContentsUrl");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(typeName);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr_IntPtr(base.SuperHandle, selWriteToURLOfTypeForSaveOperationOriginalContentsURLError_Handle, url.Handle, arg, (ulong)saveOperation, absoluteOriginalContentsUrl.Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr_IntPtr(base.Handle, selWriteToURLOfTypeForSaveOperationOriginalContentsURLError_Handle, url.Handle, arg, (ulong)saveOperation, absoluteOriginalContentsUrl.Handle, intPtr));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("fileAttributesToWriteToURL:ofType:forSaveOperation:originalContentsURL:error:")]
	public virtual NSDictionary FileAttributesToWrite(NSUrl toUrl, string typeName, NSSaveOperationType saveOperation, NSUrl absoluteOriginalContentsUrl, out NSError outError)
	{
		NSApplication.EnsureUIThread();
		if (toUrl == null)
		{
			throw new ArgumentNullException("toUrl");
		}
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		if (absoluteOriginalContentsUrl == null)
		{
			throw new ArgumentNullException("absoluteOriginalContentsUrl");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(typeName);
		NSDictionary result = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr_IntPtr(base.SuperHandle, selFileAttributesToWriteToURLOfTypeForSaveOperationOriginalContentsURLError_Handle, toUrl.Handle, arg, (ulong)saveOperation, absoluteOriginalContentsUrl.Handle, intPtr))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr_IntPtr(base.Handle, selFileAttributesToWriteToURLOfTypeForSaveOperationOriginalContentsURLError_Handle, toUrl.Handle, arg, (ulong)saveOperation, absoluteOriginalContentsUrl.Handle, intPtr))));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("keepBackupFile")]
	public virtual bool KeepBackupFile()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selKeepBackupFileHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selKeepBackupFileHandle);
	}

	[Export("saveDocument:")]
	public virtual void SaveDocument(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSaveDocument_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSaveDocument_Handle, sender.Handle);
		}
	}

	[Export("saveDocumentAs:")]
	public virtual void SaveDocumentAs(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSaveDocumentAs_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSaveDocumentAs_Handle, sender.Handle);
		}
	}

	[Export("saveDocumentTo:")]
	public virtual void SaveDocumentTo(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSaveDocumentTo_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSaveDocumentTo_Handle, sender.Handle);
		}
	}

	[Export("saveDocumentWithDelegate:didSaveSelector:contextInfo:")]
	public virtual void SaveDocument(NSObject delegateObject, Selector didSaveSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (delegateObject == null)
		{
			throw new ArgumentNullException("delegateObject");
		}
		if (didSaveSelector == null)
		{
			throw new ArgumentNullException("didSaveSelector");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selSaveDocumentWithDelegateDidSaveSelectorContextInfo_Handle, delegateObject.Handle, didSaveSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSaveDocumentWithDelegateDidSaveSelectorContextInfo_Handle, delegateObject.Handle, didSaveSelector.Handle, contextInfo);
		}
	}

	[Export("runModalSavePanelForSaveOperation:delegate:didSaveSelector:contextInfo:")]
	public virtual void RunModalSavePanelForSaveOperation(NSSaveOperationType saveOperation, NSObject delegateObject, Selector didSaveSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (delegateObject == null)
		{
			throw new ArgumentNullException("delegateObject");
		}
		if (didSaveSelector == null)
		{
			throw new ArgumentNullException("didSaveSelector");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_IntPtr_IntPtr_IntPtr(base.Handle, selRunModalSavePanelForSaveOperationDelegateDidSaveSelectorContextInfo_Handle, (ulong)saveOperation, delegateObject.Handle, didSaveSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRunModalSavePanelForSaveOperationDelegateDidSaveSelectorContextInfo_Handle, (ulong)saveOperation, delegateObject.Handle, didSaveSelector.Handle, contextInfo);
		}
	}

	[Export("prepareSavePanel:")]
	public virtual bool PrepareSavePanel(NSSavePanel savePanel)
	{
		NSApplication.EnsureUIThread();
		if (savePanel == null)
		{
			throw new ArgumentNullException("savePanel");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPrepareSavePanel_Handle, savePanel.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPrepareSavePanel_Handle, savePanel.Handle);
	}

	[Export("saveToURL:ofType:forSaveOperation:delegate:didSaveSelector:contextInfo:")]
	public virtual void SaveToUrl(NSUrl url, string typeName, NSSaveOperationType saveOperation, NSObject delegateObject, Selector didSaveSelector, IntPtr contextInfo)
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
		if (delegateObject == null)
		{
			throw new ArgumentNullException("delegateObject");
		}
		if (didSaveSelector == null)
		{
			throw new ArgumentNullException("didSaveSelector");
		}
		IntPtr arg = NSString.CreateNative(typeName);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr_IntPtr_IntPtr(base.Handle, selSaveToURLOfTypeForSaveOperationDelegateDidSaveSelectorContextInfo_Handle, url.Handle, arg, (ulong)saveOperation, delegateObject.Handle, didSaveSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSaveToURLOfTypeForSaveOperationDelegateDidSaveSelectorContextInfo_Handle, url.Handle, arg, (ulong)saveOperation, delegateObject.Handle, didSaveSelector.Handle, contextInfo);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("saveToURL:ofType:forSaveOperation:error:")]
	public virtual bool SaveToUrl(NSUrl url, string typeName, NSSaveOperationType saveOperation, out NSError outError)
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr(base.SuperHandle, selSaveToURLOfTypeForSaveOperationError_Handle, url.Handle, arg, (ulong)saveOperation, intPtr) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr(base.Handle, selSaveToURLOfTypeForSaveOperationError_Handle, url.Handle, arg, (ulong)saveOperation, intPtr));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("autosaveDocumentWithDelegate:didAutosaveSelector:contextInfo:")]
	public virtual void AutosaveDocument(NSObject delegateObject, Selector didAutosaveSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (delegateObject == null)
		{
			throw new ArgumentNullException("delegateObject");
		}
		if (didAutosaveSelector == null)
		{
			throw new ArgumentNullException("didAutosaveSelector");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selAutosaveDocumentWithDelegateDidAutosaveSelectorContextInfo_Handle, delegateObject.Handle, didAutosaveSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selAutosaveDocumentWithDelegateDidAutosaveSelectorContextInfo_Handle, delegateObject.Handle, didAutosaveSelector.Handle, contextInfo);
		}
	}

	[Export("canCloseDocumentWithDelegate:shouldCloseSelector:contextInfo:")]
	public virtual void CanCloseDocument(NSObject delegateObject, Selector shouldCloseSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (delegateObject == null)
		{
			throw new ArgumentNullException("delegateObject");
		}
		if (shouldCloseSelector == null)
		{
			throw new ArgumentNullException("shouldCloseSelector");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selCanCloseDocumentWithDelegateShouldCloseSelectorContextInfo_Handle, delegateObject.Handle, shouldCloseSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCanCloseDocumentWithDelegateShouldCloseSelectorContextInfo_Handle, delegateObject.Handle, shouldCloseSelector.Handle, contextInfo);
		}
	}

	[Export("close")]
	public virtual void Close()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCloseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCloseHandle);
		}
	}

	[Export("runPageLayout:")]
	public virtual void RunPageLayout(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRunPageLayout_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRunPageLayout_Handle, sender.Handle);
		}
	}

	[Export("runModalPageLayoutWithPrintInfo:delegate:didRunSelector:contextInfo:")]
	public virtual void RunModalPageLayout(NSPrintInfo printInfo, NSObject delegateObject, Selector didRunSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (printInfo == null)
		{
			throw new ArgumentNullException("printInfo");
		}
		if (delegateObject == null)
		{
			throw new ArgumentNullException("delegateObject");
		}
		if (didRunSelector == null)
		{
			throw new ArgumentNullException("didRunSelector");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selRunModalPageLayoutWithPrintInfoDelegateDidRunSelectorContextInfo_Handle, printInfo.Handle, delegateObject.Handle, didRunSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRunModalPageLayoutWithPrintInfoDelegateDidRunSelectorContextInfo_Handle, printInfo.Handle, delegateObject.Handle, didRunSelector.Handle, contextInfo);
		}
	}

	[Export("preparePageLayout:")]
	public virtual bool PreparePageLayout(NSPageLayout pageLayout)
	{
		NSApplication.EnsureUIThread();
		if (pageLayout == null)
		{
			throw new ArgumentNullException("pageLayout");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPreparePageLayout_Handle, pageLayout.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPreparePageLayout_Handle, pageLayout.Handle);
	}

	[Export("shouldChangePrintInfo:")]
	public virtual bool ShouldChangePrintInfo(NSPrintInfo newPrintInfo)
	{
		NSApplication.EnsureUIThread();
		if (newPrintInfo == null)
		{
			throw new ArgumentNullException("newPrintInfo");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selShouldChangePrintInfo_Handle, newPrintInfo.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selShouldChangePrintInfo_Handle, newPrintInfo.Handle);
	}

	[Export("printDocument:")]
	public virtual void PrintDocument(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPrintDocument_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPrintDocument_Handle, sender.Handle);
		}
	}

	[Export("printDocumentWithSettings:showPrintPanel:delegate:didPrintSelector:contextInfo:")]
	public virtual void PrintDocument(NSDictionary printSettings, bool showPrintPanel, NSObject delegateObject, Selector didPrintSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (printSettings == null)
		{
			throw new ArgumentNullException("printSettings");
		}
		if (delegateObject == null)
		{
			throw new ArgumentNullException("delegateObject");
		}
		if (didPrintSelector == null)
		{
			throw new ArgumentNullException("didPrintSelector");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool_IntPtr_IntPtr_IntPtr(base.Handle, selPrintDocumentWithSettingsShowPrintPanelDelegateDidPrintSelectorContextInfo_Handle, printSettings.Handle, showPrintPanel, delegateObject.Handle, didPrintSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool_IntPtr_IntPtr_IntPtr(base.SuperHandle, selPrintDocumentWithSettingsShowPrintPanelDelegateDidPrintSelectorContextInfo_Handle, printSettings.Handle, showPrintPanel, delegateObject.Handle, didPrintSelector.Handle, contextInfo);
		}
	}

	[Export("printOperationWithSettings:error:")]
	public virtual NSPrintOperation PrintOperation(NSDictionary printSettings, out NSError outError)
	{
		NSApplication.EnsureUIThread();
		if (printSettings == null)
		{
			throw new ArgumentNullException("printSettings");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSPrintOperation result = ((!IsDirectBinding) ? ((NSPrintOperation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPrintOperationWithSettingsError_Handle, printSettings.Handle, intPtr))) : ((NSPrintOperation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selPrintOperationWithSettingsError_Handle, printSettings.Handle, intPtr))));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("runModalPrintOperation:delegate:didRunSelector:contextInfo:")]
	public virtual void RunModalPrintOperation(NSPrintOperation printOperation, NSObject delegateObject, Selector didRunSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (printOperation == null)
		{
			throw new ArgumentNullException("printOperation");
		}
		if (delegateObject == null)
		{
			throw new ArgumentNullException("delegateObject");
		}
		if (didRunSelector == null)
		{
			throw new ArgumentNullException("didRunSelector");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selRunModalPrintOperationDelegateDidRunSelectorContextInfo_Handle, printOperation.Handle, delegateObject.Handle, didRunSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRunModalPrintOperationDelegateDidRunSelectorContextInfo_Handle, printOperation.Handle, delegateObject.Handle, didRunSelector.Handle, contextInfo);
		}
	}

	[Export("updateChangeCount:")]
	public virtual void UpdateChangeCount(NSDocumentChangeType change)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selUpdateChangeCount_Handle, (ulong)change);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selUpdateChangeCount_Handle, (ulong)change);
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

	[Export("makeWindowControllers")]
	public virtual void MakeWindowControllers()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selMakeWindowControllersHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selMakeWindowControllersHandle);
		}
	}

	[Export("windowControllerWillLoadNib:")]
	public virtual void WindowControllerWillLoadNib(NSWindowController windowController)
	{
		NSApplication.EnsureUIThread();
		if (windowController == null)
		{
			throw new ArgumentNullException("windowController");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWindowControllerWillLoadNib_Handle, windowController.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWindowControllerWillLoadNib_Handle, windowController.Handle);
		}
	}

	[Export("windowControllerDidLoadNib:")]
	public virtual void WindowControllerDidLoadNib(NSWindowController windowController)
	{
		NSApplication.EnsureUIThread();
		if (windowController == null)
		{
			throw new ArgumentNullException("windowController");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWindowControllerDidLoadNib_Handle, windowController.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWindowControllerDidLoadNib_Handle, windowController.Handle);
		}
	}

	[Export("setWindow:")]
	public virtual void SetWindow(NSWindow window)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetWindow_Handle, window.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetWindow_Handle, window.Handle);
		}
	}

	[Export("addWindowController:")]
	public virtual void AddWindowController(NSWindowController windowController)
	{
		NSApplication.EnsureUIThread();
		if (windowController == null)
		{
			throw new ArgumentNullException("windowController");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddWindowController_Handle, windowController.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddWindowController_Handle, windowController.Handle);
		}
		_ = WindowControllers;
	}

	[Export("removeWindowController:")]
	public virtual void RemoveWindowController(NSWindowController windowController)
	{
		NSApplication.EnsureUIThread();
		if (windowController == null)
		{
			throw new ArgumentNullException("windowController");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveWindowController_Handle, windowController.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveWindowController_Handle, windowController.Handle);
		}
		_ = WindowControllers;
	}

	[Export("showWindows")]
	public virtual void ShowWindows()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selShowWindowsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selShowWindowsHandle);
		}
	}

	[Export("shouldCloseWindowController:delegate:shouldCloseSelector:contextInfo:")]
	public virtual void ShouldCloseWindowController(NSWindowController windowController, NSObject delegateObject, Selector shouldCloseSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (windowController == null)
		{
			throw new ArgumentNullException("windowController");
		}
		if (delegateObject == null)
		{
			throw new ArgumentNullException("delegateObject");
		}
		if (shouldCloseSelector == null)
		{
			throw new ArgumentNullException("shouldCloseSelector");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selShouldCloseWindowControllerDelegateShouldCloseSelectorContextInfo_Handle, windowController.Handle, delegateObject.Handle, shouldCloseSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selShouldCloseWindowControllerDelegateShouldCloseSelectorContextInfo_Handle, windowController.Handle, delegateObject.Handle, shouldCloseSelector.Handle, contextInfo);
		}
	}

	[Export("writableTypes")]
	public static string[] WritableTypes()
	{
		NSApplication.EnsureUIThread();
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selWritableTypesHandle));
	}

	[Export("isNativeType:")]
	public static bool IsNativeType(string type)
	{
		NSApplication.EnsureUIThread();
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		bool result = Messaging.bool_objc_msgSend_IntPtr(class_ptr, selIsNativeType_Handle, arg);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("writableTypesForSaveOperation:")]
	public virtual string[] WritableTypesForSaveOperation(NSSaveOperationType saveOperation)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selWritableTypesForSaveOperation_Handle, (ulong)saveOperation));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selWritableTypesForSaveOperation_Handle, (ulong)saveOperation));
	}

	[Export("fileNameExtensionForType:saveOperation:")]
	public virtual string FileNameExtensionForSaveOperation(string typeName, NSSaveOperationType saveOperation)
	{
		NSApplication.EnsureUIThread();
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr arg = NSString.CreateNative(typeName);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selFileNameExtensionForTypeSaveOperation_Handle, arg, (ulong)saveOperation)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selFileNameExtensionForTypeSaveOperation_Handle, arg, (ulong)saveOperation)));
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

	[Export("performActivityWithSynchronousWaiting:usingBlock:")]
	public unsafe virtual void PerformActivity(bool waitSynchronously, NSAction activityCompletionHandler)
	{
		NSApplication.EnsureUIThread();
		if (activityCompletionHandler == null)
		{
			throw new ArgumentNullException("activityCompletionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSAction.Handler, activityCompletionHandler);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_IntPtr(base.Handle, selPerformActivityWithSynchronousWaitingUsingBlock_Handle, waitSynchronously, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_IntPtr(base.SuperHandle, selPerformActivityWithSynchronousWaitingUsingBlock_Handle, waitSynchronously, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("continueActivityUsingBlock:")]
	public unsafe virtual void ContinueActivity(NSAction resume)
	{
		NSApplication.EnsureUIThread();
		if (resume == null)
		{
			throw new ArgumentNullException("resume");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSAction.Handler, resume);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selContinueActivityUsingBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selContinueActivityUsingBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("continueAsynchronousWorkOnMainThreadUsingBlock:")]
	public unsafe virtual void ContinueAsynchronousWorkOnMainThread(NSAction work)
	{
		NSApplication.EnsureUIThread();
		if (work == null)
		{
			throw new ArgumentNullException("work");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSAction.Handler, work);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selContinueAsynchronousWorkOnMainThreadUsingBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selContinueAsynchronousWorkOnMainThreadUsingBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("performSynchronousFileAccessUsingBlock:")]
	public unsafe virtual void PerformSynchronousFileAccess(NSAction fileAccessCallback)
	{
		NSApplication.EnsureUIThread();
		if (fileAccessCallback == null)
		{
			throw new ArgumentNullException("fileAccessCallback");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSAction.Handler, fileAccessCallback);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformSynchronousFileAccessUsingBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformSynchronousFileAccessUsingBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("performAsynchronousFileAccessUsingBlock:")]
	public unsafe virtual void PerformAsynchronousFileAccess(NSAction ioCode)
	{
		NSApplication.EnsureUIThread();
		if (ioCode == null)
		{
			throw new ArgumentNullException("ioCode");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSAction.Handler, ioCode);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformAsynchronousFileAccessUsingBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformAsynchronousFileAccessUsingBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("unblockUserInteraction")]
	public virtual void UnblockUserInteraction()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUnblockUserInteractionHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUnblockUserInteractionHandle);
		}
	}

	[Export("saveToURL:ofType:forSaveOperation:completionHandler:")]
	public unsafe virtual void SaveTo(NSUrl url, string typeName, NSSaveOperationType saveOperation, NSDocumentCompletionHandler completionHandler)
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
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(typeName);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSDocumentCompletionHandler.Handler, completionHandler);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr(base.Handle, selSaveToURLOfTypeForSaveOperationCompletionHandler_Handle, url.Handle, arg, (ulong)saveOperation, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr(base.SuperHandle, selSaveToURLOfTypeForSaveOperationCompletionHandler_Handle, url.Handle, arg, (ulong)saveOperation, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Export("canAsynchronouslyWriteToURL:ofType:forSaveOperation:")]
	public virtual bool CanWriteAsynchronously(NSUrl toUrl, string typeName, NSSaveOperationType saveOperation)
	{
		NSApplication.EnsureUIThread();
		if (toUrl == null)
		{
			throw new ArgumentNullException("toUrl");
		}
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr arg = NSString.CreateNative(typeName);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_UInt64(base.SuperHandle, selCanAsynchronouslyWriteToURLOfTypeForSaveOperation_Handle, toUrl.Handle, arg, (ulong)saveOperation) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, selCanAsynchronouslyWriteToURLOfTypeForSaveOperation_Handle, toUrl.Handle, arg, (ulong)saveOperation));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("checkAutosavingSafetyAndReturnError:")]
	public virtual bool CheckAutosavingSafety(out NSError outError)
	{
		NSApplication.EnsureUIThread();
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selCheckAutosavingSafetyAndReturnError_Handle, intPtr) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selCheckAutosavingSafetyAndReturnError_Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("scheduleAutosaving")]
	public virtual void ScheduleAutosaving()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selScheduleAutosavingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selScheduleAutosavingHandle);
		}
	}

	[Export("autosaveWithImplicitCancellability:completionHandler:")]
	public unsafe virtual void Autosave(bool autosavingIsImplicitlyCancellable, NSDocumentCompletionHandler completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSDocumentCompletionHandler.Handler, completionHandler);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_IntPtr(base.Handle, selAutosaveWithImplicitCancellabilityCompletionHandler_Handle, autosavingIsImplicitlyCancellable, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_IntPtr(base.SuperHandle, selAutosaveWithImplicitCancellabilityCompletionHandler_Handle, autosavingIsImplicitlyCancellable, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("autosavesInPlace")]
	public static bool AutosavesInPlace()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(class_ptr, selAutosavesInPlaceHandle);
	}

	[Export("preservesVersions")]
	public static bool PreservesVersions()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(class_ptr, selPreservesVersionsHandle);
	}

	[Export("duplicateDocument:")]
	public virtual void DuplicateDocument(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDuplicateDocument_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDuplicateDocument_Handle, sender.Handle);
		}
	}

	[Export("duplicateDocumentWithDelegate:didDuplicateSelector:contextInfo:")]
	internal virtual void _DuplicateDocument(NSObject cbackobject, Selector didDuplicateSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selDuplicateDocumentWithDelegateDidDuplicateSelectorContextInfo_Handle, cbackobject?.Handle ?? IntPtr.Zero, (didDuplicateSelector == null) ? IntPtr.Zero : didDuplicateSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selDuplicateDocumentWithDelegateDidDuplicateSelectorContextInfo_Handle, cbackobject?.Handle ?? IntPtr.Zero, (didDuplicateSelector == null) ? IntPtr.Zero : didDuplicateSelector.Handle, contextInfo);
		}
	}

	[Export("duplicateAndReturnError:")]
	public virtual NSDocument Duplicate(out NSError outError)
	{
		NSApplication.EnsureUIThread();
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSDocument result = ((!IsDirectBinding) ? ((NSDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDuplicateAndReturnError_Handle, intPtr))) : ((NSDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDuplicateAndReturnError_Handle, intPtr))));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		outError = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("changeCountTokenForSaveOperation:")]
	public virtual NSObject ChangeCountToken(NSSaveOperationType saveOperation)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selChangeCountTokenForSaveOperation_Handle, (ulong)saveOperation));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selChangeCountTokenForSaveOperation_Handle, (ulong)saveOperation));
	}

	[Export("updateChangeCountWithToken:forSaveOperation:")]
	public virtual void UpdateChangeCount(NSObject changeCountToken, NSSaveOperationType saveOperation)
	{
		NSApplication.EnsureUIThread();
		if (changeCountToken == null)
		{
			throw new ArgumentNullException("changeCountToken");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selUpdateChangeCountWithTokenForSaveOperation_Handle, changeCountToken.Handle, (ulong)saveOperation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selUpdateChangeCountWithTokenForSaveOperation_Handle, changeCountToken.Handle, (ulong)saveOperation);
		}
	}

	[Export("willNotPresentError:")]
	public virtual void WillNotPresentError(NSError error)
	{
		NSApplication.EnsureUIThread();
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWillNotPresentError_Handle, error.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWillNotPresentError_Handle, error.Handle);
		}
	}

	[Export("setDisplayName:")]
	public virtual void SetDisplayName(string displayNameOrNull)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(displayNameOrNull);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDisplayName_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDisplayName_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("restoreDocumentWindowWithIdentifier:state:completionHandler:")]
	public unsafe virtual void RestoreDocumentWindow(string identifier, NSCoder state, NSWindowCompletionHandler completionHandler)
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
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSWindowCompletionHandler.Handler, completionHandler);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRestoreDocumentWindowWithIdentifierStateCompletionHandler_Handle, arg, state.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRestoreDocumentWindowWithIdentifierStateCompletionHandler_Handle, arg, state.Handle, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Export("encodeRestorableStateWithCoder:")]
	public virtual void EncodeRestorableState(NSCoder coder)
	{
		NSApplication.EnsureUIThread();
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeRestorableStateWithCoder_Handle, coder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeRestorableStateWithCoder_Handle, coder.Handle);
		}
	}

	[Export("restoreStateWithCoder:")]
	public virtual void RestoreState(NSCoder coder)
	{
		NSApplication.EnsureUIThread();
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRestoreStateWithCoder_Handle, coder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRestoreStateWithCoder_Handle, coder.Handle);
		}
	}

	[Export("invalidateRestorableState")]
	public virtual void InvalidateRestorableState()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateRestorableStateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateRestorableStateHandle);
		}
	}

	[Export("restorableStateKeyPaths")]
	public static string[] RestorableStateKeyPaths()
	{
		NSApplication.EnsureUIThread();
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selRestorableStateKeyPathsHandle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WindowControllers_var = null;
			__mt_WindowForSheet_var = null;
			__mt_FileUrl_var = null;
			__mt_FileModificationDate_var = null;
			__mt_AutosavedContentsFileUrl_var = null;
			__mt_PrintInfo_var = null;
			__mt_UndoManager_var = null;
		}
	}
}

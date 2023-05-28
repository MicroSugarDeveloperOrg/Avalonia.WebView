using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSDocument", true)]
public class NSDocument : NSObject, INSEditorRegistration, INativeObject, IDisposable, INSFilePresenter, INSMenuItemValidation
{
	public delegate void DuplicateCallback(NSDocument document, bool didDuplicate);

	[Register("__NSDocumentDuplicateCallback")]
	internal class Callback : NSObject
	{
		private DuplicateCallback callback;

		public Callback(DuplicateCallback callback)
		{
			this.callback = callback;
			base.IsDirectBinding = false;
			DangerousRetain();
		}

		[Export("document:didDuplicate:contextInfo:")]
		private void SelectorCallback(NSDocument source, bool didDuplicate, IntPtr contextInfo)
		{
			try
			{
				callback(source, didDuplicate);
			}
			finally
			{
				DangerousRelease();
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPDFPrintOperation = "PDFPrintOperation";

	private static readonly IntPtr selPDFPrintOperationHandle = Selector.GetHandle("PDFPrintOperation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccommodatePresentedItemDeletionWithCompletionHandler_ = "accommodatePresentedItemDeletionWithCompletionHandler:";

	private static readonly IntPtr selAccommodatePresentedItemDeletionWithCompletionHandler_Handle = Selector.GetHandle("accommodatePresentedItemDeletionWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccommodatePresentedSubitemDeletionAtURL_CompletionHandler_ = "accommodatePresentedSubitemDeletionAtURL:completionHandler:";

	private static readonly IntPtr selAccommodatePresentedSubitemDeletionAtURL_CompletionHandler_Handle = Selector.GetHandle("accommodatePresentedSubitemDeletionAtURL:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddWindowController_ = "addWindowController:";

	private static readonly IntPtr selAddWindowController_Handle = Selector.GetHandle("addWindowController:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsDocumentSharing = "allowsDocumentSharing";

	private static readonly IntPtr selAllowsDocumentSharingHandle = Selector.GetHandle("allowsDocumentSharing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutosaveDocumentWithDelegate_DidAutosaveSelector_ContextInfo_ = "autosaveDocumentWithDelegate:didAutosaveSelector:contextInfo:";

	private static readonly IntPtr selAutosaveDocumentWithDelegate_DidAutosaveSelector_ContextInfo_Handle = Selector.GetHandle("autosaveDocumentWithDelegate:didAutosaveSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutosaveWithImplicitCancellability_CompletionHandler_ = "autosaveWithImplicitCancellability:completionHandler:";

	private static readonly IntPtr selAutosaveWithImplicitCancellability_CompletionHandler_Handle = Selector.GetHandle("autosaveWithImplicitCancellability:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutosavedContentsFileURL = "autosavedContentsFileURL";

	private static readonly IntPtr selAutosavedContentsFileURLHandle = Selector.GetHandle("autosavedContentsFileURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutosavesDrafts = "autosavesDrafts";

	private static readonly IntPtr selAutosavesDraftsHandle = Selector.GetHandle("autosavesDrafts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutosavesInPlace = "autosavesInPlace";

	private static readonly IntPtr selAutosavesInPlaceHandle = Selector.GetHandle("autosavesInPlace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutosavingFileType = "autosavingFileType";

	private static readonly IntPtr selAutosavingFileTypeHandle = Selector.GetHandle("autosavingFileType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutosavingIsImplicitlyCancellable = "autosavingIsImplicitlyCancellable";

	private static readonly IntPtr selAutosavingIsImplicitlyCancellableHandle = Selector.GetHandle("autosavingIsImplicitlyCancellable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackupFileURL = "backupFileURL";

	private static readonly IntPtr selBackupFileURLHandle = Selector.GetHandle("backupFileURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBrowseDocumentVersions_ = "browseDocumentVersions:";

	private static readonly IntPtr selBrowseDocumentVersions_Handle = Selector.GetHandle("browseDocumentVersions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanAsynchronouslyWriteToURL_OfType_ForSaveOperation_ = "canAsynchronouslyWriteToURL:ofType:forSaveOperation:";

	private static readonly IntPtr selCanAsynchronouslyWriteToURL_OfType_ForSaveOperation_Handle = Selector.GetHandle("canAsynchronouslyWriteToURL:ofType:forSaveOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanCloseDocumentWithDelegate_ShouldCloseSelector_ContextInfo_ = "canCloseDocumentWithDelegate:shouldCloseSelector:contextInfo:";

	private static readonly IntPtr selCanCloseDocumentWithDelegate_ShouldCloseSelector_ContextInfo_Handle = Selector.GetHandle("canCloseDocumentWithDelegate:shouldCloseSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanConcurrentlyReadDocumentsOfType_ = "canConcurrentlyReadDocumentsOfType:";

	private static readonly IntPtr selCanConcurrentlyReadDocumentsOfType_Handle = Selector.GetHandle("canConcurrentlyReadDocumentsOfType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeCountTokenForSaveOperation_ = "changeCountTokenForSaveOperation:";

	private static readonly IntPtr selChangeCountTokenForSaveOperation_Handle = Selector.GetHandle("changeCountTokenForSaveOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCheckAutosavingSafetyAndReturnError_ = "checkAutosavingSafetyAndReturnError:";

	private static readonly IntPtr selCheckAutosavingSafetyAndReturnError_Handle = Selector.GetHandle("checkAutosavingSafetyAndReturnError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClose = "close";

	private static readonly IntPtr selCloseHandle = Selector.GetHandle("close");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContinueActivityUsingBlock_ = "continueActivityUsingBlock:";

	private static readonly IntPtr selContinueActivityUsingBlock_Handle = Selector.GetHandle("continueActivityUsingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContinueAsynchronousWorkOnMainThreadUsingBlock_ = "continueAsynchronousWorkOnMainThreadUsingBlock:";

	private static readonly IntPtr selContinueAsynchronousWorkOnMainThreadUsingBlock_Handle = Selector.GetHandle("continueAsynchronousWorkOnMainThreadUsingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataOfType_Error_ = "dataOfType:error:";

	private static readonly IntPtr selDataOfType_Error_Handle = Selector.GetHandle("dataOfType:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultDraftName = "defaultDraftName";

	private static readonly IntPtr selDefaultDraftNameHandle = Selector.GetHandle("defaultDraftName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayName = "displayName";

	private static readonly IntPtr selDisplayNameHandle = Selector.GetHandle("displayName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuplicateAndReturnError_ = "duplicateAndReturnError:";

	private static readonly IntPtr selDuplicateAndReturnError_Handle = Selector.GetHandle("duplicateAndReturnError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuplicateDocument_ = "duplicateDocument:";

	private static readonly IntPtr selDuplicateDocument_Handle = Selector.GetHandle("duplicateDocument:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuplicateDocumentWithDelegate_DidDuplicateSelector_ContextInfo_ = "duplicateDocumentWithDelegate:didDuplicateSelector:contextInfo:";

	private static readonly IntPtr selDuplicateDocumentWithDelegate_DidDuplicateSelector_ContextInfo_Handle = Selector.GetHandle("duplicateDocumentWithDelegate:didDuplicateSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeRestorableStateWithCoder_ = "encodeRestorableStateWithCoder:";

	private static readonly IntPtr selEncodeRestorableStateWithCoder_Handle = Selector.GetHandle("encodeRestorableStateWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeRestorableStateWithCoder_BackgroundQueue_ = "encodeRestorableStateWithCoder:backgroundQueue:";

	private static readonly IntPtr selEncodeRestorableStateWithCoder_BackgroundQueue_Handle = Selector.GetHandle("encodeRestorableStateWithCoder:backgroundQueue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileAttributesToWriteToURL_OfType_ForSaveOperation_OriginalContentsURL_Error_ = "fileAttributesToWriteToURL:ofType:forSaveOperation:originalContentsURL:error:";

	private static readonly IntPtr selFileAttributesToWriteToURL_OfType_ForSaveOperation_OriginalContentsURL_Error_Handle = Selector.GetHandle("fileAttributesToWriteToURL:ofType:forSaveOperation:originalContentsURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileModificationDate = "fileModificationDate";

	private static readonly IntPtr selFileModificationDateHandle = Selector.GetHandle("fileModificationDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileNameExtensionForType_SaveOperation_ = "fileNameExtensionForType:saveOperation:";

	private static readonly IntPtr selFileNameExtensionForType_SaveOperation_Handle = Selector.GetHandle("fileNameExtensionForType:saveOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileNameExtensionWasHiddenInLastRunSavePanel = "fileNameExtensionWasHiddenInLastRunSavePanel";

	private static readonly IntPtr selFileNameExtensionWasHiddenInLastRunSavePanelHandle = Selector.GetHandle("fileNameExtensionWasHiddenInLastRunSavePanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileType = "fileType";

	private static readonly IntPtr selFileTypeHandle = Selector.GetHandle("fileType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileTypeFromLastRunSavePanel = "fileTypeFromLastRunSavePanel";

	private static readonly IntPtr selFileTypeFromLastRunSavePanelHandle = Selector.GetHandle("fileTypeFromLastRunSavePanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileURL = "fileURL";

	private static readonly IntPtr selFileURLHandle = Selector.GetHandle("fileURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileWrapperOfType_Error_ = "fileWrapperOfType:error:";

	private static readonly IntPtr selFileWrapperOfType_Error_Handle = Selector.GetHandle("fileWrapperOfType:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasUnautosavedChanges = "hasUnautosavedChanges";

	private static readonly IntPtr selHasUnautosavedChangesHandle = Selector.GetHandle("hasUnautosavedChanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasUndoManager = "hasUndoManager";

	private static readonly IntPtr selHasUndoManagerHandle = Selector.GetHandle("hasUndoManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitForURL_WithContentsOfURL_OfType_Error_ = "initForURL:withContentsOfURL:ofType:error:";

	private static readonly IntPtr selInitForURL_WithContentsOfURL_OfType_Error_Handle = Selector.GetHandle("initForURL:withContentsOfURL:ofType:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContentsOfURL_OfType_Error_ = "initWithContentsOfURL:ofType:error:";

	private static readonly IntPtr selInitWithContentsOfURL_OfType_Error_Handle = Selector.GetHandle("initWithContentsOfURL:ofType:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithType_Error_ = "initWithType:error:";

	private static readonly IntPtr selInitWithType_Error_Handle = Selector.GetHandle("initWithType:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateRestorableState = "invalidateRestorableState";

	private static readonly IntPtr selInvalidateRestorableStateHandle = Selector.GetHandle("invalidateRestorableState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsBrowsingVersions = "isBrowsingVersions";

	private static readonly IntPtr selIsBrowsingVersionsHandle = Selector.GetHandle("isBrowsingVersions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDocumentEdited = "isDocumentEdited";

	private static readonly IntPtr selIsDocumentEditedHandle = Selector.GetHandle("isDocumentEdited");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDraft = "isDraft";

	private static readonly IntPtr selIsDraftHandle = Selector.GetHandle("isDraft");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEntireFileLoaded = "isEntireFileLoaded";

	private static readonly IntPtr selIsEntireFileLoadedHandle = Selector.GetHandle("isEntireFileLoaded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsInViewingMode = "isInViewingMode";

	private static readonly IntPtr selIsInViewingModeHandle = Selector.GetHandle("isInViewingMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsLocked = "isLocked";

	private static readonly IntPtr selIsLockedHandle = Selector.GetHandle("isLocked");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsNativeType_ = "isNativeType:";

	private static readonly IntPtr selIsNativeType_Handle = Selector.GetHandle("isNativeType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeepBackupFile = "keepBackupFile";

	private static readonly IntPtr selKeepBackupFileHandle = Selector.GetHandle("keepBackupFile");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLockDocument_ = "lockDocument:";

	private static readonly IntPtr selLockDocument_Handle = Selector.GetHandle("lockDocument:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLockDocumentWithCompletionHandler_ = "lockDocumentWithCompletionHandler:";

	private static readonly IntPtr selLockDocumentWithCompletionHandler_Handle = Selector.GetHandle("lockDocumentWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLockWithCompletionHandler_ = "lockWithCompletionHandler:";

	private static readonly IntPtr selLockWithCompletionHandler_Handle = Selector.GetHandle("lockWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeWindowControllers = "makeWindowControllers";

	private static readonly IntPtr selMakeWindowControllersHandle = Selector.GetHandle("makeWindowControllers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveDocument_ = "moveDocument:";

	private static readonly IntPtr selMoveDocument_Handle = Selector.GetHandle("moveDocument:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveDocumentToUbiquityContainer_ = "moveDocumentToUbiquityContainer:";

	private static readonly IntPtr selMoveDocumentToUbiquityContainer_Handle = Selector.GetHandle("moveDocumentToUbiquityContainer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveDocumentWithCompletionHandler_ = "moveDocumentWithCompletionHandler:";

	private static readonly IntPtr selMoveDocumentWithCompletionHandler_Handle = Selector.GetHandle("moveDocumentWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveToURL_CompletionHandler_ = "moveToURL:completionHandler:";

	private static readonly IntPtr selMoveToURL_CompletionHandler_Handle = Selector.GetHandle("moveToURL:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectDidBeginEditing_ = "objectDidBeginEditing:";

	private static readonly IntPtr selObjectDidBeginEditing_Handle = Selector.GetHandle("objectDidBeginEditing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectDidEndEditing_ = "objectDidEndEditing:";

	private static readonly IntPtr selObjectDidEndEditing_Handle = Selector.GetHandle("objectDidEndEditing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObservedPresentedItemUbiquityAttributes = "observedPresentedItemUbiquityAttributes";

	private static readonly IntPtr selObservedPresentedItemUbiquityAttributesHandle = Selector.GetHandle("observedPresentedItemUbiquityAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformActivityWithSynchronousWaiting_UsingBlock_ = "performActivityWithSynchronousWaiting:usingBlock:";

	private static readonly IntPtr selPerformActivityWithSynchronousWaiting_UsingBlock_Handle = Selector.GetHandle("performActivityWithSynchronousWaiting:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformAsynchronousFileAccessUsingBlock_ = "performAsynchronousFileAccessUsingBlock:";

	private static readonly IntPtr selPerformAsynchronousFileAccessUsingBlock_Handle = Selector.GetHandle("performAsynchronousFileAccessUsingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformSynchronousFileAccessUsingBlock_ = "performSynchronousFileAccessUsingBlock:";

	private static readonly IntPtr selPerformSynchronousFileAccessUsingBlock_Handle = Selector.GetHandle("performSynchronousFileAccessUsingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreparePageLayout_ = "preparePageLayout:";

	private static readonly IntPtr selPreparePageLayout_Handle = Selector.GetHandle("preparePageLayout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareSavePanel_ = "prepareSavePanel:";

	private static readonly IntPtr selPrepareSavePanel_Handle = Selector.GetHandle("prepareSavePanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareSharingServicePicker_ = "prepareSharingServicePicker:";

	private static readonly IntPtr selPrepareSharingServicePicker_Handle = Selector.GetHandle("prepareSharingServicePicker:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentError_ = "presentError:";

	private static readonly IntPtr selPresentError_Handle = Selector.GetHandle("presentError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentError_ModalForWindow_Delegate_DidPresentSelector_ContextInfo_ = "presentError:modalForWindow:delegate:didPresentSelector:contextInfo:";

	private static readonly IntPtr selPresentError_ModalForWindow_Delegate_DidPresentSelector_ContextInfo_Handle = Selector.GetHandle("presentError:modalForWindow:delegate:didPresentSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentedItemDidChange = "presentedItemDidChange";

	private static readonly IntPtr selPresentedItemDidChangeHandle = Selector.GetHandle("presentedItemDidChange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentedItemDidChangeUbiquityAttributes_ = "presentedItemDidChangeUbiquityAttributes:";

	private static readonly IntPtr selPresentedItemDidChangeUbiquityAttributes_Handle = Selector.GetHandle("presentedItemDidChangeUbiquityAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentedItemDidGainVersion_ = "presentedItemDidGainVersion:";

	private static readonly IntPtr selPresentedItemDidGainVersion_Handle = Selector.GetHandle("presentedItemDidGainVersion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentedItemDidLoseVersion_ = "presentedItemDidLoseVersion:";

	private static readonly IntPtr selPresentedItemDidLoseVersion_Handle = Selector.GetHandle("presentedItemDidLoseVersion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentedItemDidMoveToURL_ = "presentedItemDidMoveToURL:";

	private static readonly IntPtr selPresentedItemDidMoveToURL_Handle = Selector.GetHandle("presentedItemDidMoveToURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentedItemDidResolveConflictVersion_ = "presentedItemDidResolveConflictVersion:";

	private static readonly IntPtr selPresentedItemDidResolveConflictVersion_Handle = Selector.GetHandle("presentedItemDidResolveConflictVersion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentedItemOperationQueue = "presentedItemOperationQueue";

	private static readonly IntPtr selPresentedItemOperationQueueHandle = Selector.GetHandle("presentedItemOperationQueue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentedItemURL = "presentedItemURL";

	private static readonly IntPtr selPresentedItemURLHandle = Selector.GetHandle("presentedItemURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentedSubitemAtURL_DidGainVersion_ = "presentedSubitemAtURL:didGainVersion:";

	private static readonly IntPtr selPresentedSubitemAtURL_DidGainVersion_Handle = Selector.GetHandle("presentedSubitemAtURL:didGainVersion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentedSubitemAtURL_DidLoseVersion_ = "presentedSubitemAtURL:didLoseVersion:";

	private static readonly IntPtr selPresentedSubitemAtURL_DidLoseVersion_Handle = Selector.GetHandle("presentedSubitemAtURL:didLoseVersion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentedSubitemAtURL_DidMoveToURL_ = "presentedSubitemAtURL:didMoveToURL:";

	private static readonly IntPtr selPresentedSubitemAtURL_DidMoveToURL_Handle = Selector.GetHandle("presentedSubitemAtURL:didMoveToURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentedSubitemAtURL_DidResolveConflictVersion_ = "presentedSubitemAtURL:didResolveConflictVersion:";

	private static readonly IntPtr selPresentedSubitemAtURL_DidResolveConflictVersion_Handle = Selector.GetHandle("presentedSubitemAtURL:didResolveConflictVersion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentedSubitemDidAppearAtURL_ = "presentedSubitemDidAppearAtURL:";

	private static readonly IntPtr selPresentedSubitemDidAppearAtURL_Handle = Selector.GetHandle("presentedSubitemDidAppearAtURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentedSubitemDidChangeAtURL_ = "presentedSubitemDidChangeAtURL:";

	private static readonly IntPtr selPresentedSubitemDidChangeAtURL_Handle = Selector.GetHandle("presentedSubitemDidChangeAtURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreservesVersions = "preservesVersions";

	private static readonly IntPtr selPreservesVersionsHandle = Selector.GetHandle("preservesVersions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimaryPresentedItemURL = "primaryPresentedItemURL";

	private static readonly IntPtr selPrimaryPresentedItemURLHandle = Selector.GetHandle("primaryPresentedItemURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrintDocument_ = "printDocument:";

	private static readonly IntPtr selPrintDocument_Handle = Selector.GetHandle("printDocument:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrintDocumentWithSettings_ShowPrintPanel_Delegate_DidPrintSelector_ContextInfo_ = "printDocumentWithSettings:showPrintPanel:delegate:didPrintSelector:contextInfo:";

	private static readonly IntPtr selPrintDocumentWithSettings_ShowPrintPanel_Delegate_DidPrintSelector_ContextInfo_Handle = Selector.GetHandle("printDocumentWithSettings:showPrintPanel:delegate:didPrintSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrintInfo = "printInfo";

	private static readonly IntPtr selPrintInfoHandle = Selector.GetHandle("printInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrintOperationWithSettings_Error_ = "printOperationWithSettings:error:";

	private static readonly IntPtr selPrintOperationWithSettings_Error_Handle = Selector.GetHandle("printOperationWithSettings:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadFromData_OfType_Error_ = "readFromData:ofType:error:";

	private static readonly IntPtr selReadFromData_OfType_Error_Handle = Selector.GetHandle("readFromData:ofType:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadFromFileWrapper_OfType_Error_ = "readFromFileWrapper:ofType:error:";

	private static readonly IntPtr selReadFromFileWrapper_OfType_Error_Handle = Selector.GetHandle("readFromFileWrapper:ofType:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadFromURL_OfType_Error_ = "readFromURL:ofType:error:";

	private static readonly IntPtr selReadFromURL_OfType_Error_Handle = Selector.GetHandle("readFromURL:ofType:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadableTypes = "readableTypes";

	private static readonly IntPtr selReadableTypesHandle = Selector.GetHandle("readableTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRelinquishPresentedItemToReader_ = "relinquishPresentedItemToReader:";

	private static readonly IntPtr selRelinquishPresentedItemToReader_Handle = Selector.GetHandle("relinquishPresentedItemToReader:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRelinquishPresentedItemToWriter_ = "relinquishPresentedItemToWriter:";

	private static readonly IntPtr selRelinquishPresentedItemToWriter_Handle = Selector.GetHandle("relinquishPresentedItemToWriter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveWindowController_ = "removeWindowController:";

	private static readonly IntPtr selRemoveWindowController_Handle = Selector.GetHandle("removeWindowController:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenameDocument_ = "renameDocument:";

	private static readonly IntPtr selRenameDocument_Handle = Selector.GetHandle("renameDocument:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRestorableStateKeyPaths = "restorableStateKeyPaths";

	private static readonly IntPtr selRestorableStateKeyPathsHandle = Selector.GetHandle("restorableStateKeyPaths");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRestoreDocumentWindowWithIdentifier_State_CompletionHandler_ = "restoreDocumentWindowWithIdentifier:state:completionHandler:";

	private static readonly IntPtr selRestoreDocumentWindowWithIdentifier_State_CompletionHandler_Handle = Selector.GetHandle("restoreDocumentWindowWithIdentifier:state:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRestoreStateWithCoder_ = "restoreStateWithCoder:";

	private static readonly IntPtr selRestoreStateWithCoder_Handle = Selector.GetHandle("restoreStateWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRestoreUserActivityState_ = "restoreUserActivityState:";

	private static readonly IntPtr selRestoreUserActivityState_Handle = Selector.GetHandle("restoreUserActivityState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRevertDocumentToSaved_ = "revertDocumentToSaved:";

	private static readonly IntPtr selRevertDocumentToSaved_Handle = Selector.GetHandle("revertDocumentToSaved:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRevertToContentsOfURL_OfType_Error_ = "revertToContentsOfURL:ofType:error:";

	private static readonly IntPtr selRevertToContentsOfURL_OfType_Error_Handle = Selector.GetHandle("revertToContentsOfURL:ofType:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunModalPageLayoutWithPrintInfo_Delegate_DidRunSelector_ContextInfo_ = "runModalPageLayoutWithPrintInfo:delegate:didRunSelector:contextInfo:";

	private static readonly IntPtr selRunModalPageLayoutWithPrintInfo_Delegate_DidRunSelector_ContextInfo_Handle = Selector.GetHandle("runModalPageLayoutWithPrintInfo:delegate:didRunSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunModalPrintOperation_Delegate_DidRunSelector_ContextInfo_ = "runModalPrintOperation:delegate:didRunSelector:contextInfo:";

	private static readonly IntPtr selRunModalPrintOperation_Delegate_DidRunSelector_ContextInfo_Handle = Selector.GetHandle("runModalPrintOperation:delegate:didRunSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunModalSavePanelForSaveOperation_Delegate_DidSaveSelector_ContextInfo_ = "runModalSavePanelForSaveOperation:delegate:didSaveSelector:contextInfo:";

	private static readonly IntPtr selRunModalSavePanelForSaveOperation_Delegate_DidSaveSelector_ContextInfo_Handle = Selector.GetHandle("runModalSavePanelForSaveOperation:delegate:didSaveSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunPageLayout_ = "runPageLayout:";

	private static readonly IntPtr selRunPageLayout_Handle = Selector.GetHandle("runPageLayout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveDocument_ = "saveDocument:";

	private static readonly IntPtr selSaveDocument_Handle = Selector.GetHandle("saveDocument:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveDocumentAs_ = "saveDocumentAs:";

	private static readonly IntPtr selSaveDocumentAs_Handle = Selector.GetHandle("saveDocumentAs:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveDocumentTo_ = "saveDocumentTo:";

	private static readonly IntPtr selSaveDocumentTo_Handle = Selector.GetHandle("saveDocumentTo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveDocumentToPDF_ = "saveDocumentToPDF:";

	private static readonly IntPtr selSaveDocumentToPDF_Handle = Selector.GetHandle("saveDocumentToPDF:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveDocumentWithDelegate_DidSaveSelector_ContextInfo_ = "saveDocumentWithDelegate:didSaveSelector:contextInfo:";

	private static readonly IntPtr selSaveDocumentWithDelegate_DidSaveSelector_ContextInfo_Handle = Selector.GetHandle("saveDocumentWithDelegate:didSaveSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSavePresentedItemChangesWithCompletionHandler_ = "savePresentedItemChangesWithCompletionHandler:";

	private static readonly IntPtr selSavePresentedItemChangesWithCompletionHandler_Handle = Selector.GetHandle("savePresentedItemChangesWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveToURL_OfType_ForSaveOperation_CompletionHandler_ = "saveToURL:ofType:forSaveOperation:completionHandler:";

	private static readonly IntPtr selSaveToURL_OfType_ForSaveOperation_CompletionHandler_Handle = Selector.GetHandle("saveToURL:ofType:forSaveOperation:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveToURL_OfType_ForSaveOperation_Delegate_DidSaveSelector_ContextInfo_ = "saveToURL:ofType:forSaveOperation:delegate:didSaveSelector:contextInfo:";

	private static readonly IntPtr selSaveToURL_OfType_ForSaveOperation_Delegate_DidSaveSelector_ContextInfo_Handle = Selector.GetHandle("saveToURL:ofType:forSaveOperation:delegate:didSaveSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveToURL_OfType_ForSaveOperation_Error_ = "saveToURL:ofType:forSaveOperation:error:";

	private static readonly IntPtr selSaveToURL_OfType_ForSaveOperation_Error_Handle = Selector.GetHandle("saveToURL:ofType:forSaveOperation:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScheduleAutosaving = "scheduleAutosaving";

	private static readonly IntPtr selScheduleAutosavingHandle = Selector.GetHandle("scheduleAutosaving");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutosavedContentsFileURL_ = "setAutosavedContentsFileURL:";

	private static readonly IntPtr selSetAutosavedContentsFileURL_Handle = Selector.GetHandle("setAutosavedContentsFileURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisplayName_ = "setDisplayName:";

	private static readonly IntPtr selSetDisplayName_Handle = Selector.GetHandle("setDisplayName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDraft_ = "setDraft:";

	private static readonly IntPtr selSetDraft_Handle = Selector.GetHandle("setDraft:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFileModificationDate_ = "setFileModificationDate:";

	private static readonly IntPtr selSetFileModificationDate_Handle = Selector.GetHandle("setFileModificationDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFileType_ = "setFileType:";

	private static readonly IntPtr selSetFileType_Handle = Selector.GetHandle("setFileType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFileURL_ = "setFileURL:";

	private static readonly IntPtr selSetFileURL_Handle = Selector.GetHandle("setFileURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHasUndoManager_ = "setHasUndoManager:";

	private static readonly IntPtr selSetHasUndoManager_Handle = Selector.GetHandle("setHasUndoManager:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrintInfo_ = "setPrintInfo:";

	private static readonly IntPtr selSetPrintInfo_Handle = Selector.GetHandle("setPrintInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUndoManager_ = "setUndoManager:";

	private static readonly IntPtr selSetUndoManager_Handle = Selector.GetHandle("setUndoManager:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserActivity_ = "setUserActivity:";

	private static readonly IntPtr selSetUserActivity_Handle = Selector.GetHandle("setUserActivity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWindow_ = "setWindow:";

	private static readonly IntPtr selSetWindow_Handle = Selector.GetHandle("setWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShareDocumentWithSharingService_CompletionHandler_ = "shareDocumentWithSharingService:completionHandler:";

	private static readonly IntPtr selShareDocumentWithSharingService_CompletionHandler_Handle = Selector.GetHandle("shareDocumentWithSharingService:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldChangePrintInfo_ = "shouldChangePrintInfo:";

	private static readonly IntPtr selShouldChangePrintInfo_Handle = Selector.GetHandle("shouldChangePrintInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldCloseWindowController_Delegate_ShouldCloseSelector_ContextInfo_ = "shouldCloseWindowController:delegate:shouldCloseSelector:contextInfo:";

	private static readonly IntPtr selShouldCloseWindowController_Delegate_ShouldCloseSelector_ContextInfo_Handle = Selector.GetHandle("shouldCloseWindowController:delegate:shouldCloseSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldRunSavePanelWithAccessoryView = "shouldRunSavePanelWithAccessoryView";

	private static readonly IntPtr selShouldRunSavePanelWithAccessoryViewHandle = Selector.GetHandle("shouldRunSavePanelWithAccessoryView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowWindows = "showWindows";

	private static readonly IntPtr selShowWindowsHandle = Selector.GetHandle("showWindows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopBrowsingVersionsWithCompletionHandler_ = "stopBrowsingVersionsWithCompletionHandler:";

	private static readonly IntPtr selStopBrowsingVersionsWithCompletionHandler_Handle = Selector.GetHandle("stopBrowsingVersionsWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnblockUserInteraction = "unblockUserInteraction";

	private static readonly IntPtr selUnblockUserInteractionHandle = Selector.GetHandle("unblockUserInteraction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUndoManager = "undoManager";

	private static readonly IntPtr selUndoManagerHandle = Selector.GetHandle("undoManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnlockDocument_ = "unlockDocument:";

	private static readonly IntPtr selUnlockDocument_Handle = Selector.GetHandle("unlockDocument:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnlockDocumentWithCompletionHandler_ = "unlockDocumentWithCompletionHandler:";

	private static readonly IntPtr selUnlockDocumentWithCompletionHandler_Handle = Selector.GetHandle("unlockDocumentWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnlockWithCompletionHandler_ = "unlockWithCompletionHandler:";

	private static readonly IntPtr selUnlockWithCompletionHandler_Handle = Selector.GetHandle("unlockWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateChangeCount_ = "updateChangeCount:";

	private static readonly IntPtr selUpdateChangeCount_Handle = Selector.GetHandle("updateChangeCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateChangeCountWithToken_ForSaveOperation_ = "updateChangeCountWithToken:forSaveOperation:";

	private static readonly IntPtr selUpdateChangeCountWithToken_ForSaveOperation_Handle = Selector.GetHandle("updateChangeCountWithToken:forSaveOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateUserActivityState_ = "updateUserActivityState:";

	private static readonly IntPtr selUpdateUserActivityState_Handle = Selector.GetHandle("updateUserActivityState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserActivity = "userActivity";

	private static readonly IntPtr selUserActivityHandle = Selector.GetHandle("userActivity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUsesUbiquitousStorage = "usesUbiquitousStorage";

	private static readonly IntPtr selUsesUbiquitousStorageHandle = Selector.GetHandle("usesUbiquitousStorage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateMenuItem_ = "validateMenuItem:";

	private static readonly IntPtr selValidateMenuItem_Handle = Selector.GetHandle("validateMenuItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateUserInterfaceItem_ = "validateUserInterfaceItem:";

	private static readonly IntPtr selValidateUserInterfaceItem_Handle = Selector.GetHandle("validateUserInterfaceItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWillNotPresentError_ = "willNotPresentError:";

	private static readonly IntPtr selWillNotPresentError_Handle = Selector.GetHandle("willNotPresentError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWillPresentError_ = "willPresentError:";

	private static readonly IntPtr selWillPresentError_Handle = Selector.GetHandle("willPresentError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindowControllerDidLoadNib_ = "windowControllerDidLoadNib:";

	private static readonly IntPtr selWindowControllerDidLoadNib_Handle = Selector.GetHandle("windowControllerDidLoadNib:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindowControllerWillLoadNib_ = "windowControllerWillLoadNib:";

	private static readonly IntPtr selWindowControllerWillLoadNib_Handle = Selector.GetHandle("windowControllerWillLoadNib:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindowControllers = "windowControllers";

	private static readonly IntPtr selWindowControllersHandle = Selector.GetHandle("windowControllers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindowForSheet = "windowForSheet";

	private static readonly IntPtr selWindowForSheetHandle = Selector.GetHandle("windowForSheet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindowNibName = "windowNibName";

	private static readonly IntPtr selWindowNibNameHandle = Selector.GetHandle("windowNibName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWritableTypes = "writableTypes";

	private static readonly IntPtr selWritableTypesHandle = Selector.GetHandle("writableTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWritableTypesForSaveOperation_ = "writableTypesForSaveOperation:";

	private static readonly IntPtr selWritableTypesForSaveOperation_Handle = Selector.GetHandle("writableTypesForSaveOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteSafelyToURL_OfType_ForSaveOperation_Error_ = "writeSafelyToURL:ofType:forSaveOperation:error:";

	private static readonly IntPtr selWriteSafelyToURL_OfType_ForSaveOperation_Error_Handle = Selector.GetHandle("writeSafelyToURL:ofType:forSaveOperation:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToURL_OfType_Error_ = "writeToURL:ofType:error:";

	private static readonly IntPtr selWriteToURL_OfType_Error_Handle = Selector.GetHandle("writeToURL:ofType:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToURL_OfType_ForSaveOperation_OriginalContentsURL_Error_ = "writeToURL:ofType:forSaveOperation:originalContentsURL:error:";

	private static readonly IntPtr selWriteToURL_OfType_ForSaveOperation_OriginalContentsURL_Error_Handle = Selector.GetHandle("writeToURL:ofType:forSaveOperation:originalContentsURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSDocument");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public virtual bool AllowsDocumentSharing
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Export("allowsDocumentSharing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsDocumentSharingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsDocumentSharingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool AutoSavesDrafts
	{
		[Export("autosavesDrafts")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selAutosavesDraftsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl AutosavedContentsFileUrl
	{
		[Export("autosavedContentsFileURL", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selAutosavedContentsFileURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAutosavedContentsFileURLHandle));
		}
		[Export("setAutosavedContentsFileURL:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAutosavedContentsFileURL_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAutosavedContentsFileURL_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string AutosavingFileType
	{
		[Export("autosavingFileType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAutosavingFileTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAutosavingFileTypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutosavingIsImplicitlyCancellable
	{
		[Export("autosavingIsImplicitlyCancellable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutosavingIsImplicitlyCancellableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutosavingIsImplicitlyCancellableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl BackupFileUrl
	{
		[Export("backupFileURL")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackupFileURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackupFileURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DefaultDraftName
	{
		[Export("defaultDraftName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultDraftNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultDraftNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? DisplayName
	{
		[Export("displayName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate FileModificationDate
	{
		[Export("fileModificationDate", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selFileModificationDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileModificationDateHandle));
		}
		[Export("setFileModificationDate:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFileModificationDate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFileModificationDate_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool FileNameExtensionWasHiddenInLastRunSavePanel
	{
		[Export("fileNameExtensionWasHiddenInLastRunSavePanel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selFileNameExtensionWasHiddenInLastRunSavePanelHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selFileNameExtensionWasHiddenInLastRunSavePanelHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string FileType
	{
		[Export("fileType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string FileTypeFromLastRunSavePanel
	{
		[Export("fileTypeFromLastRunSavePanel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFileTypeFromLastRunSavePanelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileTypeFromLastRunSavePanelHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? FileUrl
	{
		[Export("fileURL", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selFileURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileURLHandle));
		}
		[Export("setFileURL:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFileURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFileURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasUnautosavedChanges
	{
		[Export("hasUnautosavedChanges")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasUnautosavedChangesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasUnautosavedChangesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasUndoManager
	{
		[Export("hasUndoManager")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasUndoManagerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasUndoManagerHandle);
		}
		[Export("setHasUndoManager:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHasUndoManager_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHasUndoManager_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual bool IsBrowsingVersions
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("isBrowsingVersions")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsBrowsingVersionsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsBrowsingVersionsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsDocumentEdited
	{
		[Export("isDocumentEdited")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDocumentEditedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDocumentEditedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsDraft
	{
		[Export("isDraft")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDraftHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDraftHandle);
		}
		[Export("setDraft:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDraft_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDraft_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEntireFileLoaded
	{
		[Export("isEntireFileLoaded")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEntireFileLoadedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEntireFileLoadedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsInViewingMode
	{
		[Export("isInViewingMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsInViewingModeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsInViewingModeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsLocked
	{
		[Export("isLocked")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLockedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLockedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual NSPrintOperation PDFPrintOperation
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("PDFPrintOperation", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPrintOperation>(Messaging.IntPtr_objc_msgSend(base.Handle, selPDFPrintOperationHandle));
			}
			return Runtime.GetNSObject<NSPrintOperation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPDFPrintOperationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSOperationQueue PesentedItemOperationQueue
	{
		[Export("presentedItemOperationQueue", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSOperationQueue>(Messaging.IntPtr_objc_msgSend(base.Handle, selPresentedItemOperationQueueHandle));
			}
			return Runtime.GetNSObject<NSOperationQueue>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPresentedItemOperationQueueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual NSSet<NSString> PresentedItemObservedUbiquityAttributes
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("observedPresentedItemUbiquityAttributes", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet<NSString>>(Messaging.IntPtr_objc_msgSend(base.Handle, selObservedPresentedItemUbiquityAttributesHandle));
			}
			return Runtime.GetNSObject<NSSet<NSString>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObservedPresentedItemUbiquityAttributesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl PresentedItemURL
	{
		[Export("presentedItemURL", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selPresentedItemURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPresentedItemURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl PrimaryPresentedItemUrl
	{
		[Export("primaryPresentedItemURL")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selPrimaryPresentedItemURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrimaryPresentedItemURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPrintInfo PrintInfo
	{
		[Export("printInfo", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPrintInfo>(Messaging.IntPtr_objc_msgSend(base.Handle, selPrintInfoHandle));
			}
			return Runtime.GetNSObject<NSPrintInfo>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrintInfoHandle));
		}
		[Export("setPrintInfo:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPrintInfo_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPrintInfo_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] ReadableTypes
	{
		[Export("readableTypes", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selReadableTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldRunSavePanelWithAccessoryView
	{
		[Export("shouldRunSavePanelWithAccessoryView")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldRunSavePanelWithAccessoryViewHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldRunSavePanelWithAccessoryViewHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUndoManager UndoManager
	{
		[Export("undoManager", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUndoManager>(Messaging.IntPtr_objc_msgSend(base.Handle, selUndoManagerHandle));
			}
			return Runtime.GetNSObject<NSUndoManager>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUndoManagerHandle));
		}
		[Export("setUndoManager:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUndoManager_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUndoManager_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSUserActivity UserActivity
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("userActivity", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUserActivity>(Messaging.IntPtr_objc_msgSend(base.Handle, selUserActivityHandle));
			}
			return Runtime.GetNSObject<NSUserActivity>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserActivityHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setUserActivity:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUserActivity_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUserActivity_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool UsesUbiquitousStorage
	{
		[Export("usesUbiquitousStorage")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selUsesUbiquitousStorageHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindowController[] WindowControllers
	{
		[Export("windowControllers")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSWindowController>(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowControllersHandle));
			}
			return NSArray.ArrayFromHandle<NSWindowController>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowControllersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindow WindowForSheet
	{
		[Export("windowForSheet")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowForSheetHandle));
			}
			return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowForSheetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string WindowNibName
	{
		[Export("windowNibName")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowNibNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowNibNameHandle));
		}
	}

	public void DuplicateDocument(DuplicateCallback callback)
	{
		if (callback == null)
		{
			_DuplicateDocument(null, null, IntPtr.Zero);
		}
		else
		{
			_DuplicateDocument(new Callback(callback), new Selector("document:didDuplicate:contextInfo:"), IntPtr.Zero);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSDocument()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSDocument(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSDocument(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithType:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDocument(string typeName, out NSError? outError)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(typeName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithType_Error_Handle, arg2, ref arg), "initWithType:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithType_Error_Handle, arg2, ref arg), "initWithType:error:");
		}
		NSString.ReleaseNative(arg2);
		outError = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("initWithContentsOfURL:ofType:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDocument(NSUrl url, string typeName, out NSError? outError)
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
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(typeName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selInitWithContentsOfURL_OfType_Error_Handle, url.Handle, arg2, ref arg), "initWithContentsOfURL:ofType:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithContentsOfURL_OfType_Error_Handle, url.Handle, arg2, ref arg), "initWithContentsOfURL:ofType:error:");
		}
		NSString.ReleaseNative(arg2);
		outError = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("initForURL:withContentsOfURL:ofType:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDocument(NSUrl? documentUrl, NSUrl documentContentsUrl, string typeName, out NSError? outError)
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
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(typeName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.Handle, selInitForURL_WithContentsOfURL_OfType_Error_Handle, (documentUrl == null) ? IntPtr.Zero : documentUrl.Handle, documentContentsUrl.Handle, arg2, ref arg), "initForURL:withContentsOfURL:ofType:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selInitForURL_WithContentsOfURL_OfType_Error_Handle, (documentUrl == null) ? IntPtr.Zero : documentUrl.Handle, documentContentsUrl.Handle, arg2, ref arg), "initForURL:withContentsOfURL:ofType:error:");
		}
		NSString.ReleaseNative(arg2);
		outError = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("accommodatePresentedItemDeletionWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void AccommodatePresentedItemDeletion([BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAccommodatePresentedItemDeletionWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAccommodatePresentedItemDeletionWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("accommodatePresentedSubitemDeletionAtURL:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void AccommodatePresentedSubitemDeletion(NSUrl url, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAccommodatePresentedSubitemDeletionAtURL_CompletionHandler_Handle, url.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAccommodatePresentedSubitemDeletionAtURL_CompletionHandler_Handle, url.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("addWindowController:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddWindowController(NSWindowController windowController)
	{
		NSApplication.EnsureUIThread();
		if (windowController == null)
		{
			throw new ArgumentNullException("windowController");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddWindowController_Handle, windowController.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddWindowController_Handle, windowController.Handle);
		}
	}

	[Export("autosaveWithImplicitCancellability:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Autosave(bool autosavingIsImplicitlyCancellable, [BlockProxy(typeof(Trampolines.NIDNSDocumentCompletionHandler))] NSDocumentCompletionHandler completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSDocumentCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_IntPtr(base.Handle, selAutosaveWithImplicitCancellability_CompletionHandler_Handle, autosavingIsImplicitlyCancellable, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_IntPtr(base.SuperHandle, selAutosaveWithImplicitCancellability_CompletionHandler_Handle, autosavingIsImplicitlyCancellable, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("autosaveDocumentWithDelegate:didAutosaveSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AutosaveDocument(NSObject? delegateObject, Selector? didAutosaveSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selAutosaveDocumentWithDelegate_DidAutosaveSelector_ContextInfo_Handle, delegateObject?.Handle ?? IntPtr.Zero, (didAutosaveSelector == null) ? IntPtr.Zero : didAutosaveSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selAutosaveDocumentWithDelegate_DidAutosaveSelector_ContextInfo_Handle, delegateObject?.Handle ?? IntPtr.Zero, (didAutosaveSelector == null) ? IntPtr.Zero : didAutosaveSelector.Handle, contextInfo);
		}
	}

	[Export("autosavesInPlace")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool AutosavesInPlace()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(class_ptr, selAutosavesInPlaceHandle);
	}

	[Export("browseDocumentVersions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BrowseDocumentVersions(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selBrowseDocumentVersions_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selBrowseDocumentVersions_Handle, sender.Handle);
		}
	}

	[Export("canCloseDocumentWithDelegate:shouldCloseSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CanCloseDocument(NSObject delegateObject, Selector? shouldCloseSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (delegateObject == null)
		{
			throw new ArgumentNullException("delegateObject");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selCanCloseDocumentWithDelegate_ShouldCloseSelector_ContextInfo_Handle, delegateObject.Handle, (shouldCloseSelector == null) ? IntPtr.Zero : shouldCloseSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCanCloseDocumentWithDelegate_ShouldCloseSelector_ContextInfo_Handle, delegateObject.Handle, (shouldCloseSelector == null) ? IntPtr.Zero : shouldCloseSelector.Handle, contextInfo);
		}
	}

	[Export("canConcurrentlyReadDocumentsOfType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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

	[Export("canAsynchronouslyWriteToURL:ofType:forSaveOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_UInt64(base.SuperHandle, selCanAsynchronouslyWriteToURL_OfType_ForSaveOperation_Handle, toUrl.Handle, arg, (ulong)saveOperation) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, selCanAsynchronouslyWriteToURL_OfType_ForSaveOperation_Handle, toUrl.Handle, arg, (ulong)saveOperation));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("changeCountTokenForSaveOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ChangeCountToken(NSSaveOperationType saveOperation)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selChangeCountTokenForSaveOperation_Handle, (ulong)saveOperation));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selChangeCountTokenForSaveOperation_Handle, (ulong)saveOperation));
	}

	[Export("checkAutosavingSafetyAndReturnError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CheckAutosavingSafety(out NSError? outError)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selCheckAutosavingSafetyAndReturnError_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selCheckAutosavingSafetyAndReturnError_Handle, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("close")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Close()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCloseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCloseHandle);
		}
	}

	[Export("continueActivityUsingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ContinueActivity([BlockProxy(typeof(Trampolines.NIDAction))] Action resume)
	{
		NSApplication.EnsureUIThread();
		if (resume == null)
		{
			throw new ArgumentNullException("resume");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, resume);
		if (base.IsDirectBinding)
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
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ContinueAsynchronousWorkOnMainThread([BlockProxy(typeof(Trampolines.NIDAction))] Action work)
	{
		NSApplication.EnsureUIThread();
		if (work == null)
		{
			throw new ArgumentNullException("work");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, work);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selContinueAsynchronousWorkOnMainThreadUsingBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selContinueAsynchronousWorkOnMainThreadUsingBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("duplicateAndReturnError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDocument Duplicate(out NSError? outError)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = IntPtr.Zero;
		NSDocument result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDocument>(Messaging.IntPtr_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selDuplicateAndReturnError_Handle, ref arg)) : Runtime.GetNSObject<NSDocument>(Messaging.IntPtr_objc_msgSend_ref_IntPtr(base.Handle, selDuplicateAndReturnError_Handle, ref arg)));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("duplicateDocument:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DuplicateDocument(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDuplicateDocument_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDuplicateDocument_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("encodeRestorableStateWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeRestorableState(NSCoder coder)
	{
		NSApplication.EnsureUIThread();
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeRestorableStateWithCoder_Handle, coder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeRestorableStateWithCoder_Handle, coder.Handle);
		}
	}

	[Export("encodeRestorableStateWithCoder:backgroundQueue:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeRestorableState(NSCoder coder, NSOperationQueue queue)
	{
		NSApplication.EnsureUIThread();
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selEncodeRestorableStateWithCoder_BackgroundQueue_Handle, coder.Handle, queue.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEncodeRestorableStateWithCoder_BackgroundQueue_Handle, coder.Handle, queue.Handle);
		}
	}

	[Export("fileAttributesToWriteToURL:ofType:forSaveOperation:originalContentsURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary FileAttributesToWrite(NSUrl toUrl, string typeName, NSSaveOperationType saveOperation, NSUrl? absoluteOriginalContentsUrl, out NSError? outError)
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
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(typeName);
		NSDictionary result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr_ref_IntPtr(base.SuperHandle, selFileAttributesToWriteToURL_OfType_ForSaveOperation_OriginalContentsURL_Error_Handle, toUrl.Handle, arg2, (ulong)saveOperation, (absoluteOriginalContentsUrl == null) ? IntPtr.Zero : absoluteOriginalContentsUrl.Handle, ref arg)) : Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr_ref_IntPtr(base.Handle, selFileAttributesToWriteToURL_OfType_ForSaveOperation_OriginalContentsURL_Error_Handle, toUrl.Handle, arg2, (ulong)saveOperation, (absoluteOriginalContentsUrl == null) ? IntPtr.Zero : absoluteOriginalContentsUrl.Handle, ref arg)));
		NSString.ReleaseNative(arg2);
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("fileNameExtensionForType:saveOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string FileNameExtensionForSaveOperation(string typeName, NSSaveOperationType saveOperation)
	{
		NSApplication.EnsureUIThread();
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr arg = NSString.CreateNative(typeName);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selFileNameExtensionForType_SaveOperation_Handle, arg, (ulong)saveOperation)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selFileNameExtensionForType_SaveOperation_Handle, arg, (ulong)saveOperation)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("dataOfType:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData GetAsData(string typeName, out NSError? outError)
	{
		NSApplication.EnsureUIThread();
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(typeName);
		NSData result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selDataOfType_Error_Handle, arg2, ref arg)) : Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selDataOfType_Error_Handle, arg2, ref arg)));
		NSString.ReleaseNative(arg2);
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("fileWrapperOfType:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFileWrapper GetAsFileWrapper(string typeName, out NSError? outError)
	{
		NSApplication.EnsureUIThread();
		if (typeName == null)
		{
			throw new ArgumentNullException("typeName");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(typeName);
		NSFileWrapper result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSFileWrapper>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selFileWrapperOfType_Error_Handle, arg2, ref arg)) : Runtime.GetNSObject<NSFileWrapper>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selFileWrapperOfType_Error_Handle, arg2, ref arg)));
		NSString.ReleaseNative(arg2);
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("invalidateRestorableState")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InvalidateRestorableState()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateRestorableStateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateRestorableStateHandle);
		}
	}

	[Export("isNativeType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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

	[Export("keepBackupFile")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool KeepBackupFile()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selKeepBackupFileHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selKeepBackupFileHandle);
	}

	[Export("lockDocument:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LockDocument(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLockDocument_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLockDocument_Handle, sender.Handle);
		}
	}

	[Export("lockDocumentWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void LockDocumentWithCompletionHandler([BlockProxy(typeof(Trampolines.NIDNSDocumentLockDocumentCompletionHandler))] NSDocumentLockDocumentCompletionHandler completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSDocumentLockDocumentCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLockDocumentWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLockDocumentWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("lockWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void LockWithCompletionHandler([BlockProxy(typeof(Trampolines.NIDNSDocumentLockCompletionHandler))] NSDocumentLockCompletionHandler completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSDocumentLockCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLockWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLockWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("makeWindowControllers")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MakeWindowControllers()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selMakeWindowControllersHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selMakeWindowControllersHandle);
		}
	}

	[Export("moveDocument:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveDocument(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMoveDocument_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMoveDocument_Handle, sender.Handle);
		}
	}

	[Export("moveDocumentToUbiquityContainer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveDocumentToUbiquityContainer(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMoveDocumentToUbiquityContainer_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMoveDocumentToUbiquityContainer_Handle, sender.Handle);
		}
	}

	[Export("moveDocumentWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void MoveDocumentWithCompletionHandler([BlockProxy(typeof(Trampolines.NIDNSDocumentMoveCompletionHandler))] NSDocumentMoveCompletionHandler completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSDocumentMoveCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selMoveDocumentWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selMoveDocumentWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("moveToURL:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void MoveToUrl(NSUrl url, [BlockProxy(typeof(Trampolines.NIDNSDocumentMoveToUrlCompletionHandler))] NSDocumentMoveToUrlCompletionHandler completionHandler)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSDocumentMoveToUrlCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selMoveToURL_CompletionHandler_Handle, url.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selMoveToURL_CompletionHandler_Handle, url.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("objectDidBeginEditing:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ObjectDidBeginEditing(INSEditor editor)
	{
		NSApplication.EnsureUIThread();
		if (editor == null)
		{
			throw new ArgumentNullException("editor");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selObjectDidBeginEditing_Handle, editor.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectDidBeginEditing_Handle, editor.Handle);
		}
	}

	[Export("objectDidEndEditing:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ObjectDidEndEditing(INSEditor editor)
	{
		NSApplication.EnsureUIThread();
		if (editor == null)
		{
			throw new ArgumentNullException("editor");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selObjectDidEndEditing_Handle, editor.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectDidEndEditing_Handle, editor.Handle);
		}
	}

	[Export("performActivityWithSynchronousWaiting:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void PerformActivity(bool waitSynchronously, [BlockProxy(typeof(Trampolines.NIDAction))] Action activityCompletionHandler)
	{
		NSApplication.EnsureUIThread();
		if (activityCompletionHandler == null)
		{
			throw new ArgumentNullException("activityCompletionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, activityCompletionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_IntPtr(base.Handle, selPerformActivityWithSynchronousWaiting_UsingBlock_Handle, waitSynchronously, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_IntPtr(base.SuperHandle, selPerformActivityWithSynchronousWaiting_UsingBlock_Handle, waitSynchronously, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("performAsynchronousFileAccessUsingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void PerformAsynchronousFileAccess([BlockProxy(typeof(Trampolines.NIDAction))] Action ioCode)
	{
		NSApplication.EnsureUIThread();
		if (ioCode == null)
		{
			throw new ArgumentNullException("ioCode");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, ioCode);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformAsynchronousFileAccessUsingBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformAsynchronousFileAccessUsingBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("performSynchronousFileAccessUsingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void PerformSynchronousFileAccess([BlockProxy(typeof(Trampolines.NIDAction))] Action fileAccessCallback)
	{
		NSApplication.EnsureUIThread();
		if (fileAccessCallback == null)
		{
			throw new ArgumentNullException("fileAccessCallback");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, fileAccessCallback);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformSynchronousFileAccessUsingBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformSynchronousFileAccessUsingBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("prepareSharingServicePicker:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Prepare(NSSharingServicePicker sharingServicePicker)
	{
		NSApplication.EnsureUIThread();
		if (sharingServicePicker == null)
		{
			throw new ArgumentNullException("sharingServicePicker");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPrepareSharingServicePicker_Handle, sharingServicePicker.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPrepareSharingServicePicker_Handle, sharingServicePicker.Handle);
		}
	}

	[Export("preparePageLayout:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PreparePageLayout(NSPageLayout pageLayout)
	{
		NSApplication.EnsureUIThread();
		if (pageLayout == null)
		{
			throw new ArgumentNullException("pageLayout");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPreparePageLayout_Handle, pageLayout.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPreparePageLayout_Handle, pageLayout.Handle);
	}

	[Export("prepareSavePanel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PrepareSavePanel(NSSavePanel savePanel)
	{
		NSApplication.EnsureUIThread();
		if (savePanel == null)
		{
			throw new ArgumentNullException("savePanel");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selPrepareSavePanel_Handle, savePanel.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selPrepareSavePanel_Handle, savePanel.Handle);
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

	[Export("presentedItemDidChange")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentedItemChanged()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPresentedItemDidChangeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPresentedItemDidChangeHandle);
		}
	}

	[Export("presentedItemDidChangeUbiquityAttributes:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentedItemChangedUbiquityAttributes(NSSet<NSString> attributes)
	{
		NSApplication.EnsureUIThread();
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPresentedItemDidChangeUbiquityAttributes_Handle, attributes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPresentedItemDidChangeUbiquityAttributes_Handle, attributes.Handle);
		}
	}

	[Export("presentedItemDidGainVersion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentedItemGainedVersion(NSFileVersion version)
	{
		NSApplication.EnsureUIThread();
		if (version == null)
		{
			throw new ArgumentNullException("version");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPresentedItemDidGainVersion_Handle, version.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPresentedItemDidGainVersion_Handle, version.Handle);
		}
	}

	[Export("presentedItemDidLoseVersion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentedItemLostVersion(NSFileVersion version)
	{
		NSApplication.EnsureUIThread();
		if (version == null)
		{
			throw new ArgumentNullException("version");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPresentedItemDidLoseVersion_Handle, version.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPresentedItemDidLoseVersion_Handle, version.Handle);
		}
	}

	[Export("presentedItemDidMoveToURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentedItemMoved(NSUrl newURL)
	{
		NSApplication.EnsureUIThread();
		if (newURL == null)
		{
			throw new ArgumentNullException("newURL");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPresentedItemDidMoveToURL_Handle, newURL.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPresentedItemDidMoveToURL_Handle, newURL.Handle);
		}
	}

	[Export("presentedItemDidResolveConflictVersion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentedItemResolveConflictVersion(NSFileVersion version)
	{
		NSApplication.EnsureUIThread();
		if (version == null)
		{
			throw new ArgumentNullException("version");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPresentedItemDidResolveConflictVersion_Handle, version.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPresentedItemDidResolveConflictVersion_Handle, version.Handle);
		}
	}

	[Export("presentedSubitemDidAppearAtURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentedSubitemAppeared(NSUrl atUrl)
	{
		NSApplication.EnsureUIThread();
		if (atUrl == null)
		{
			throw new ArgumentNullException("atUrl");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPresentedSubitemDidAppearAtURL_Handle, atUrl.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPresentedSubitemDidAppearAtURL_Handle, atUrl.Handle);
		}
	}

	[Export("presentedSubitemDidChangeAtURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentedSubitemChanged(NSUrl url)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPresentedSubitemDidChangeAtURL_Handle, url.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPresentedSubitemDidChangeAtURL_Handle, url.Handle);
		}
	}

	[Export("presentedSubitemAtURL:didGainVersion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentedSubitemGainedVersion(NSUrl url, NSFileVersion version)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (version == null)
		{
			throw new ArgumentNullException("version");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selPresentedSubitemAtURL_DidGainVersion_Handle, url.Handle, version.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPresentedSubitemAtURL_DidGainVersion_Handle, url.Handle, version.Handle);
		}
	}

	[Export("presentedSubitemAtURL:didLoseVersion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentedSubitemLostVersion(NSUrl url, NSFileVersion version)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (version == null)
		{
			throw new ArgumentNullException("version");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selPresentedSubitemAtURL_DidLoseVersion_Handle, url.Handle, version.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPresentedSubitemAtURL_DidLoseVersion_Handle, url.Handle, version.Handle);
		}
	}

	[Export("presentedSubitemAtURL:didMoveToURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentedSubitemMoved(NSUrl oldURL, NSUrl newURL)
	{
		NSApplication.EnsureUIThread();
		if (oldURL == null)
		{
			throw new ArgumentNullException("oldURL");
		}
		if (newURL == null)
		{
			throw new ArgumentNullException("newURL");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selPresentedSubitemAtURL_DidMoveToURL_Handle, oldURL.Handle, newURL.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPresentedSubitemAtURL_DidMoveToURL_Handle, oldURL.Handle, newURL.Handle);
		}
	}

	[Export("presentedSubitemAtURL:didResolveConflictVersion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PresentedSubitemResolvedConflictVersion(NSUrl url, NSFileVersion version)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (version == null)
		{
			throw new ArgumentNullException("version");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selPresentedSubitemAtURL_DidResolveConflictVersion_Handle, url.Handle, version.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPresentedSubitemAtURL_DidResolveConflictVersion_Handle, url.Handle, version.Handle);
		}
	}

	[Export("preservesVersions")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool PreservesVersions()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(class_ptr, selPreservesVersionsHandle);
	}

	[Export("printDocument:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PrintDocument(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPrintDocument_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPrintDocument_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("printDocumentWithSettings:showPrintPanel:delegate:didPrintSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PrintDocument(NSDictionary printSettings, bool showPrintPanel, NSObject? delegateObject, Selector? didPrintSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (printSettings == null)
		{
			throw new ArgumentNullException("printSettings");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool_IntPtr_IntPtr_IntPtr(base.Handle, selPrintDocumentWithSettings_ShowPrintPanel_Delegate_DidPrintSelector_ContextInfo_Handle, printSettings.Handle, showPrintPanel, delegateObject?.Handle ?? IntPtr.Zero, (didPrintSelector == null) ? IntPtr.Zero : didPrintSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool_IntPtr_IntPtr_IntPtr(base.SuperHandle, selPrintDocumentWithSettings_ShowPrintPanel_Delegate_DidPrintSelector_ContextInfo_Handle, printSettings.Handle, showPrintPanel, delegateObject?.Handle ?? IntPtr.Zero, (didPrintSelector == null) ? IntPtr.Zero : didPrintSelector.Handle, contextInfo);
		}
	}

	[Export("printOperationWithSettings:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPrintOperation PrintOperation(NSDictionary printSettings, out NSError? outError)
	{
		NSApplication.EnsureUIThread();
		if (printSettings == null)
		{
			throw new ArgumentNullException("printSettings");
		}
		IntPtr arg = IntPtr.Zero;
		NSPrintOperation result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSPrintOperation>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selPrintOperationWithSettings_Error_Handle, printSettings.Handle, ref arg)) : Runtime.GetNSObject<NSPrintOperation>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selPrintOperationWithSettings_Error_Handle, printSettings.Handle, ref arg)));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("readFromData:ofType:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ReadFromData(NSData data, string typeName, out NSError? outError)
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
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(typeName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selReadFromData_OfType_Error_Handle, data.Handle, arg2, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selReadFromData_OfType_Error_Handle, data.Handle, arg2, ref arg));
		NSString.ReleaseNative(arg2);
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("readFromFileWrapper:ofType:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(typeName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selReadFromFileWrapper_OfType_Error_Handle, fileWrapper.Handle, arg2, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selReadFromFileWrapper_OfType_Error_Handle, fileWrapper.Handle, arg2, ref arg));
		NSString.ReleaseNative(arg2);
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("readFromURL:ofType:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ReadFromUrl(NSUrl url, string typeName, out NSError? outError)
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
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selReadFromURL_OfType_Error_Handle, url.Handle, arg2, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selReadFromURL_OfType_Error_Handle, url.Handle, arg2, ref arg));
		NSString.ReleaseNative(arg2);
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("relinquishPresentedItemToReader:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RelinquishPresentedItemToReader([BlockProxy(typeof(Trampolines.NIDNSFilePresenterReacquirer))] NSFilePresenterReacquirer readerAction)
	{
		NSApplication.EnsureUIThread();
		if (readerAction == null)
		{
			throw new ArgumentNullException("readerAction");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSFilePresenterReacquirer.Handler, readerAction);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRelinquishPresentedItemToReader_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRelinquishPresentedItemToReader_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("relinquishPresentedItemToWriter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RelinquishPresentedItemToWriter([BlockProxy(typeof(Trampolines.NIDNSFilePresenterReacquirer))] NSFilePresenterReacquirer writerAction)
	{
		NSApplication.EnsureUIThread();
		if (writerAction == null)
		{
			throw new ArgumentNullException("writerAction");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSFilePresenterReacquirer.Handler, writerAction);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRelinquishPresentedItemToWriter_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRelinquishPresentedItemToWriter_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("removeWindowController:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveWindowController(NSWindowController windowController)
	{
		NSApplication.EnsureUIThread();
		if (windowController == null)
		{
			throw new ArgumentNullException("windowController");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveWindowController_Handle, windowController.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveWindowController_Handle, windowController.Handle);
		}
	}

	[Export("renameDocument:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RenameDocument(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRenameDocument_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRenameDocument_Handle, sender.Handle);
		}
	}

	[Export("restorableStateKeyPaths")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] RestorableStateKeyPaths()
	{
		NSApplication.EnsureUIThread();
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selRestorableStateKeyPathsHandle));
	}

	[Export("restoreDocumentWindowWithIdentifier:state:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RestoreDocumentWindow(string identifier, NSCoder state, [BlockProxy(typeof(Trampolines.NIDNSWindowCompletionHandler))] NSWindowCompletionHandler completionHandler)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSWindowCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRestoreDocumentWindowWithIdentifier_State_CompletionHandler_Handle, arg, state.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRestoreDocumentWindowWithIdentifier_State_CompletionHandler_Handle, arg, state.Handle, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Export("restoreStateWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RestoreState(NSCoder coder)
	{
		NSApplication.EnsureUIThread();
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRestoreStateWithCoder_Handle, coder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRestoreStateWithCoder_Handle, coder.Handle);
		}
	}

	[Export("restoreUserActivityState:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RestoreUserActivityState(NSUserActivity userActivity)
	{
		NSApplication.EnsureUIThread();
		if (userActivity == null)
		{
			throw new ArgumentNullException("userActivity");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRestoreUserActivityState_Handle, userActivity.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRestoreUserActivityState_Handle, userActivity.Handle);
		}
	}

	[Export("revertDocumentToSaved:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RevertDocumentToSaved(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRevertDocumentToSaved_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRevertDocumentToSaved_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("revertToContentsOfURL:ofType:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RevertToContentsOfUrl(NSUrl url, string typeName, out NSError? outError)
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
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selRevertToContentsOfURL_OfType_Error_Handle, url.Handle, arg2, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selRevertToContentsOfURL_OfType_Error_Handle, url.Handle, arg2, ref arg));
		NSString.ReleaseNative(arg2);
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("runModalPageLayoutWithPrintInfo:delegate:didRunSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RunModalPageLayout(NSPrintInfo printInfo, NSObject? delegateObject, Selector? didRunSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (printInfo == null)
		{
			throw new ArgumentNullException("printInfo");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selRunModalPageLayoutWithPrintInfo_Delegate_DidRunSelector_ContextInfo_Handle, printInfo.Handle, delegateObject?.Handle ?? IntPtr.Zero, (didRunSelector == null) ? IntPtr.Zero : didRunSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRunModalPageLayoutWithPrintInfo_Delegate_DidRunSelector_ContextInfo_Handle, printInfo.Handle, delegateObject?.Handle ?? IntPtr.Zero, (didRunSelector == null) ? IntPtr.Zero : didRunSelector.Handle, contextInfo);
		}
	}

	[Export("runModalPrintOperation:delegate:didRunSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RunModalPrintOperation(NSPrintOperation printOperation, NSObject? delegateObject, Selector? didRunSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (printOperation == null)
		{
			throw new ArgumentNullException("printOperation");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selRunModalPrintOperation_Delegate_DidRunSelector_ContextInfo_Handle, printOperation.Handle, delegateObject?.Handle ?? IntPtr.Zero, (didRunSelector == null) ? IntPtr.Zero : didRunSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRunModalPrintOperation_Delegate_DidRunSelector_ContextInfo_Handle, printOperation.Handle, delegateObject?.Handle ?? IntPtr.Zero, (didRunSelector == null) ? IntPtr.Zero : didRunSelector.Handle, contextInfo);
		}
	}

	[Export("runModalSavePanelForSaveOperation:delegate:didSaveSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RunModalSavePanelForSaveOperation(NSSaveOperationType saveOperation, NSObject? delegateObject, Selector? didSaveSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_IntPtr_IntPtr_IntPtr(base.Handle, selRunModalSavePanelForSaveOperation_Delegate_DidSaveSelector_ContextInfo_Handle, (ulong)saveOperation, delegateObject?.Handle ?? IntPtr.Zero, (didSaveSelector == null) ? IntPtr.Zero : didSaveSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRunModalSavePanelForSaveOperation_Delegate_DidSaveSelector_ContextInfo_Handle, (ulong)saveOperation, delegateObject?.Handle ?? IntPtr.Zero, (didSaveSelector == null) ? IntPtr.Zero : didSaveSelector.Handle, contextInfo);
		}
	}

	[Export("runPageLayout:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RunPageLayout(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRunPageLayout_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRunPageLayout_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("saveDocument:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SaveDocument(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSaveDocument_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSaveDocument_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("saveDocumentWithDelegate:didSaveSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SaveDocument(NSObject? delegateObject, Selector? didSaveSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selSaveDocumentWithDelegate_DidSaveSelector_ContextInfo_Handle, delegateObject?.Handle ?? IntPtr.Zero, (didSaveSelector == null) ? IntPtr.Zero : didSaveSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSaveDocumentWithDelegate_DidSaveSelector_ContextInfo_Handle, delegateObject?.Handle ?? IntPtr.Zero, (didSaveSelector == null) ? IntPtr.Zero : didSaveSelector.Handle, contextInfo);
		}
	}

	[Export("saveDocumentAs:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SaveDocumentAs(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSaveDocumentAs_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSaveDocumentAs_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("saveDocumentToPDF:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SaveDocumentAsPdf(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSaveDocumentToPDF_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSaveDocumentToPDF_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("saveDocumentTo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SaveDocumentTo(NSObject? sender)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSaveDocumentTo_Handle, sender?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSaveDocumentTo_Handle, sender?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("savePresentedItemChangesWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SavePresentedItemChanges([BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSavePresentedItemChangesWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSavePresentedItemChangesWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("saveToURL:ofType:forSaveOperation:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SaveTo(NSUrl url, string typeName, NSSaveOperationType saveOperation, [BlockProxy(typeof(Trampolines.NIDNSDocumentCompletionHandler))] NSDocumentCompletionHandler completionHandler)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSDocumentCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr(base.Handle, selSaveToURL_OfType_ForSaveOperation_CompletionHandler_Handle, url.Handle, arg, (ulong)saveOperation, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr(base.SuperHandle, selSaveToURL_OfType_ForSaveOperation_CompletionHandler_Handle, url.Handle, arg, (ulong)saveOperation, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Export("saveToURL:ofType:forSaveOperation:delegate:didSaveSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SaveToUrl(NSUrl url, string typeName, NSSaveOperationType saveOperation, NSObject? delegateObject, Selector? didSaveSelector, IntPtr contextInfo)
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
		IntPtr arg = NSString.CreateNative(typeName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr_IntPtr_IntPtr(base.Handle, selSaveToURL_OfType_ForSaveOperation_Delegate_DidSaveSelector_ContextInfo_Handle, url.Handle, arg, (ulong)saveOperation, delegateObject?.Handle ?? IntPtr.Zero, (didSaveSelector == null) ? IntPtr.Zero : didSaveSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSaveToURL_OfType_ForSaveOperation_Delegate_DidSaveSelector_ContextInfo_Handle, url.Handle, arg, (ulong)saveOperation, delegateObject?.Handle ?? IntPtr.Zero, (didSaveSelector == null) ? IntPtr.Zero : didSaveSelector.Handle, contextInfo);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("saveToURL:ofType:forSaveOperation:error:")]
	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.None, "Use a 'SaveToUrl' overload accepting a completion handler instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SaveToUrl(NSUrl url, string typeName, NSSaveOperationType saveOperation, out NSError? outError)
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
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_UInt64_ref_IntPtr(base.SuperHandle, selSaveToURL_OfType_ForSaveOperation_Error_Handle, url.Handle, arg2, (ulong)saveOperation, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt64_ref_IntPtr(base.Handle, selSaveToURL_OfType_ForSaveOperation_Error_Handle, url.Handle, arg2, (ulong)saveOperation, ref arg));
		NSString.ReleaseNative(arg2);
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("scheduleAutosaving")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScheduleAutosaving()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selScheduleAutosavingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selScheduleAutosavingHandle);
		}
	}

	[Export("setWindow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetWindow(NSWindow? window)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetWindow_Handle, window?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetWindow_Handle, window?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("shareDocumentWithSharingService:completionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ShareDocument(NSSharingService sharingService, [BlockProxy(typeof(Trampolines.NIDActionArity1V0))] Action<bool>? completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (sharingService == null)
		{
			throw new ArgumentNullException("sharingService");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V0.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selShareDocumentWithSharingService_CompletionHandler_Handle, sharingService.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selShareDocumentWithSharingService_CompletionHandler_Handle, sharingService.Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<bool> ShareDocumentAsync(NSSharingService sharingService)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		ShareDocument(sharingService, delegate(bool obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("shouldChangePrintInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldChangePrintInfo(NSPrintInfo newPrintInfo)
	{
		NSApplication.EnsureUIThread();
		if (newPrintInfo == null)
		{
			throw new ArgumentNullException("newPrintInfo");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selShouldChangePrintInfo_Handle, newPrintInfo.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selShouldChangePrintInfo_Handle, newPrintInfo.Handle);
	}

	[Export("shouldCloseWindowController:delegate:shouldCloseSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ShouldCloseWindowController(NSWindowController windowController, NSObject? delegateObject, Selector? shouldCloseSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (windowController == null)
		{
			throw new ArgumentNullException("windowController");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selShouldCloseWindowController_Delegate_ShouldCloseSelector_ContextInfo_Handle, windowController.Handle, delegateObject?.Handle ?? IntPtr.Zero, (shouldCloseSelector == null) ? IntPtr.Zero : shouldCloseSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selShouldCloseWindowController_Delegate_ShouldCloseSelector_ContextInfo_Handle, windowController.Handle, delegateObject?.Handle ?? IntPtr.Zero, (shouldCloseSelector == null) ? IntPtr.Zero : shouldCloseSelector.Handle, contextInfo);
		}
	}

	[Export("showWindows")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ShowWindows()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selShowWindowsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selShowWindowsHandle);
		}
	}

	[Export("stopBrowsingVersionsWithCompletionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void StopBrowsingVersions([BlockProxy(typeof(Trampolines.NIDAction))] Action? completionHandler)
	{
		NSApplication.EnsureUIThread();
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStopBrowsingVersionsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStopBrowsingVersionsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task StopBrowsingVersionsAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		StopBrowsingVersions(delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Export("unblockUserInteraction")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UnblockUserInteraction()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUnblockUserInteractionHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUnblockUserInteractionHandle);
		}
	}

	[Export("unlockDocument:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UnlockDocument(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUnlockDocument_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUnlockDocument_Handle, sender.Handle);
		}
	}

	[Export("unlockDocumentWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void UnlockDocumentWithCompletionHandler([BlockProxy(typeof(Trampolines.NIDNSDocumentUnlockDocumentCompletionHandler))] NSDocumentUnlockDocumentCompletionHandler completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSDocumentUnlockDocumentCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUnlockDocumentWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUnlockDocumentWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("unlockWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void UnlockWithCompletionHandler([BlockProxy(typeof(Trampolines.NIDNSDocumentUnlockCompletionHandler))] NSDocumentUnlockCompletionHandler completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSDocumentUnlockCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUnlockWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUnlockWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("updateChangeCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateChangeCount(NSDocumentChangeType change)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selUpdateChangeCount_Handle, (ulong)change);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selUpdateChangeCount_Handle, (ulong)change);
		}
	}

	[Export("updateChangeCountWithToken:forSaveOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateChangeCount(NSObject changeCountToken, NSSaveOperationType saveOperation)
	{
		NSApplication.EnsureUIThread();
		if (changeCountToken == null)
		{
			throw new ArgumentNullException("changeCountToken");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selUpdateChangeCountWithToken_ForSaveOperation_Handle, changeCountToken.Handle, (ulong)saveOperation);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selUpdateChangeCountWithToken_ForSaveOperation_Handle, changeCountToken.Handle, (ulong)saveOperation);
		}
	}

	[Export("updateUserActivityState:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateUserActivityState(NSUserActivity userActivity)
	{
		NSApplication.EnsureUIThread();
		if (userActivity == null)
		{
			throw new ArgumentNullException("userActivity");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUpdateUserActivityState_Handle, userActivity.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUpdateUserActivityState_Handle, userActivity.Handle);
		}
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

	[Export("willNotPresentError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillNotPresentError(NSError error)
	{
		NSApplication.EnsureUIThread();
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWillNotPresentError_Handle, error.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWillNotPresentError_Handle, error.Handle);
		}
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

	[Export("windowControllerDidLoadNib:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WindowControllerDidLoadNib(NSWindowController windowController)
	{
		NSApplication.EnsureUIThread();
		if (windowController == null)
		{
			throw new ArgumentNullException("windowController");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWindowControllerDidLoadNib_Handle, windowController.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWindowControllerDidLoadNib_Handle, windowController.Handle);
		}
	}

	[Export("windowControllerWillLoadNib:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WindowControllerWillLoadNib(NSWindowController windowController)
	{
		NSApplication.EnsureUIThread();
		if (windowController == null)
		{
			throw new ArgumentNullException("windowController");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWindowControllerWillLoadNib_Handle, windowController.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWindowControllerWillLoadNib_Handle, windowController.Handle);
		}
	}

	[Export("writableTypes")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] WritableTypes()
	{
		NSApplication.EnsureUIThread();
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selWritableTypesHandle));
	}

	[Export("writableTypesForSaveOperation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] WritableTypesForSaveOperation(NSSaveOperationType saveOperation)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selWritableTypesForSaveOperation_Handle, (ulong)saveOperation));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selWritableTypesForSaveOperation_Handle, (ulong)saveOperation));
	}

	[Export("writeSafelyToURL:ofType:forSaveOperation:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WriteSafelyToUrl(NSUrl url, string typeName, NSSaveOperationType saveOperation, out NSError? outError)
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
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_UInt64_ref_IntPtr(base.SuperHandle, selWriteSafelyToURL_OfType_ForSaveOperation_Error_Handle, url.Handle, arg2, (ulong)saveOperation, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt64_ref_IntPtr(base.Handle, selWriteSafelyToURL_OfType_ForSaveOperation_Error_Handle, url.Handle, arg2, (ulong)saveOperation, ref arg));
		NSString.ReleaseNative(arg2);
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("writeToURL:ofType:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WriteToUrl(NSUrl url, string typeName, out NSError? outError)
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
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selWriteToURL_OfType_Error_Handle, url.Handle, arg2, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selWriteToURL_OfType_Error_Handle, url.Handle, arg2, ref arg));
		NSString.ReleaseNative(arg2);
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("writeToURL:ofType:forSaveOperation:originalContentsURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WriteToUrl(NSUrl url, string typeName, NSSaveOperationType saveOperation, NSUrl? absoluteOriginalContentsUrl, out NSError? outError)
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
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr_ref_IntPtr(base.SuperHandle, selWriteToURL_OfType_ForSaveOperation_OriginalContentsURL_Error_Handle, url.Handle, arg2, (ulong)saveOperation, (absoluteOriginalContentsUrl == null) ? IntPtr.Zero : absoluteOriginalContentsUrl.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr_ref_IntPtr(base.Handle, selWriteToURL_OfType_ForSaveOperation_OriginalContentsURL_Error_Handle, url.Handle, arg2, (ulong)saveOperation, (absoluteOriginalContentsUrl == null) ? IntPtr.Zero : absoluteOriginalContentsUrl.Handle, ref arg));
		NSString.ReleaseNative(arg2);
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("duplicateDocumentWithDelegate:didDuplicateSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _DuplicateDocument(NSObject? cbackobject, Selector? didDuplicateSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selDuplicateDocumentWithDelegate_DidDuplicateSelector_ContextInfo_Handle, cbackobject?.Handle ?? IntPtr.Zero, (didDuplicateSelector == null) ? IntPtr.Zero : didDuplicateSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selDuplicateDocumentWithDelegate_DidDuplicateSelector_ContextInfo_Handle, cbackobject?.Handle ?? IntPtr.Zero, (didDuplicateSelector == null) ? IntPtr.Zero : didDuplicateSelector.Handle, contextInfo);
		}
	}
}

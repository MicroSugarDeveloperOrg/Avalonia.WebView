using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSavePanel", true)]
public class NSSavePanel : NSPanel
{
	[Register]
	internal class _NSOpenSavePanelDelegate : NSObject, INSOpenSavePanelDelegate, INativeObject, IDisposable
	{
		internal NSOpenSaveCompare? compareFilenames;

		internal EventHandler<NSOpenSavePanelUrlEventArgs>? didChangeToDirectory;

		internal EventHandler<NSOpenSaveFilenameEventArgs>? directoryDidChange;

		internal NSOpenSaveFilename? isValidFilename;

		internal EventHandler? selectionDidChange;

		internal NSOpenSavePanelUrl? shouldEnableUrl;

		internal NSOpenSaveFilename? shouldShowFilename;

		internal NSOpenSaveFilenameConfirmation? userEnteredFilename;

		internal NSOpenSavePanelValidate? validateUrl;

		internal EventHandler<NSOpenSaveExpandingEventArgs>? willExpand;

		public _NSOpenSavePanelDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("panel:compareFilename:with:caseSensitive:")]
		public NSComparisonResult CompareFilenames(NSSavePanel panel, string name1, string name2, bool caseSensitive)
		{
			return compareFilenames?.Invoke(panel, name1, name2, caseSensitive) ?? NSComparisonResult.Same;
		}

		[Preserve(Conditional = true)]
		[Export("panel:didChangeToDirectoryURL:")]
		public void DidChangeToDirectory(NSSavePanel panel, NSUrl newDirectoryUrl)
		{
			EventHandler<NSOpenSavePanelUrlEventArgs> eventHandler = didChangeToDirectory;
			if (eventHandler != null)
			{
				NSOpenSavePanelUrlEventArgs e = new NSOpenSavePanelUrlEventArgs(newDirectoryUrl);
				eventHandler(panel, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("panel:directoryDidChange:")]
		public void DirectoryDidChange(NSSavePanel panel, string path)
		{
			EventHandler<NSOpenSaveFilenameEventArgs> eventHandler = directoryDidChange;
			if (eventHandler != null)
			{
				NSOpenSaveFilenameEventArgs e = new NSOpenSaveFilenameEventArgs(path);
				eventHandler(panel, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("panel:isValidFilename:")]
		public bool IsValidFilename(NSSavePanel panel, string fileName)
		{
			return isValidFilename?.Invoke(panel, fileName) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("panelSelectionDidChange:")]
		public void SelectionDidChange(NSSavePanel panel)
		{
			selectionDidChange?.Invoke(panel, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("panel:shouldEnableURL:")]
		public bool ShouldEnableUrl(NSSavePanel panel, NSUrl url)
		{
			return shouldEnableUrl?.Invoke(panel, url) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("panel:shouldShowFilename:")]
		public bool ShouldShowFilename(NSSavePanel panel, string filename)
		{
			return shouldShowFilename?.Invoke(panel, filename) ?? true;
		}

		[Preserve(Conditional = true)]
		[Export("panel:userEnteredFilename:confirmed:")]
		public string UserEnteredFilename(NSSavePanel panel, string filename, bool confirmed)
		{
			NSOpenSaveFilenameConfirmation nSOpenSaveFilenameConfirmation = userEnteredFilename;
			if (nSOpenSaveFilenameConfirmation != null)
			{
				return nSOpenSaveFilenameConfirmation(panel, filename, confirmed);
			}
			return filename;
		}

		[Preserve(Conditional = true)]
		[Export("panel:validateURL:error:")]
		public bool ValidateUrl(NSSavePanel panel, NSUrl url, out NSError? outError)
		{
			NSOpenSavePanelValidate nSOpenSavePanelValidate = validateUrl;
			if (nSOpenSavePanelValidate != null)
			{
				return nSOpenSavePanelValidate(panel, url, out outError);
			}
			outError = null;
			return true;
		}

		[Preserve(Conditional = true)]
		[Export("panel:willExpand:")]
		public void WillExpand(NSSavePanel panel, bool expanding)
		{
			EventHandler<NSOpenSaveExpandingEventArgs> eventHandler = willExpand;
			if (eventHandler != null)
			{
				NSOpenSaveExpandingEventArgs e = new NSOpenSaveExpandingEventArgs(expanding);
				eventHandler(panel, e);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURL = "URL";

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessoryView = "accessoryView";

	private static readonly IntPtr selAccessoryViewHandle = Selector.GetHandle("accessoryView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowedFileTypes = "allowedFileTypes";

	private static readonly IntPtr selAllowedFileTypesHandle = Selector.GetHandle("allowedFileTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsOtherFileTypes = "allowsOtherFileTypes";

	private static readonly IntPtr selAllowsOtherFileTypesHandle = Selector.GetHandle("allowsOtherFileTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginSheetForDirectory_File_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo_ = "beginSheetForDirectory:file:modalForWindow:modalDelegate:didEndSelector:contextInfo:";

	private static readonly IntPtr selBeginSheetForDirectory_File_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo_Handle = Selector.GetHandle("beginSheetForDirectory:file:modalForWindow:modalDelegate:didEndSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginSheetModalForWindow_CompletionHandler_ = "beginSheetModalForWindow:completionHandler:";

	private static readonly IntPtr selBeginSheetModalForWindow_CompletionHandler_Handle = Selector.GetHandle("beginSheetModalForWindow:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginWithCompletionHandler_ = "beginWithCompletionHandler:";

	private static readonly IntPtr selBeginWithCompletionHandler_Handle = Selector.GetHandle("beginWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanCreateDirectories = "canCreateDirectories";

	private static readonly IntPtr selCanCreateDirectoriesHandle = Selector.GetHandle("canCreateDirectories");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanSelectHiddenExtension = "canSelectHiddenExtension";

	private static readonly IntPtr selCanSelectHiddenExtensionHandle = Selector.GetHandle("canSelectHiddenExtension");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancel_ = "cancel:";

	private static readonly IntPtr selCancel_Handle = Selector.GetHandle("cancel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDirectory = "directory";

	private static readonly IntPtr selDirectoryHandle = Selector.GetHandle("directory");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDirectoryURL = "directoryURL";

	private static readonly IntPtr selDirectoryURLHandle = Selector.GetHandle("directoryURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilename = "filename";

	private static readonly IntPtr selFilenameHandle = Selector.GetHandle("filename");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsExpanded = "isExpanded";

	private static readonly IntPtr selIsExpandedHandle = Selector.GetHandle("isExpanded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsExtensionHidden = "isExtensionHidden";

	private static readonly IntPtr selIsExtensionHiddenHandle = Selector.GetHandle("isExtensionHidden");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMessage = "message";

	private static readonly IntPtr selMessageHandle = Selector.GetHandle("message");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNameFieldLabel = "nameFieldLabel";

	private static readonly IntPtr selNameFieldLabelHandle = Selector.GetHandle("nameFieldLabel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNameFieldStringValue = "nameFieldStringValue";

	private static readonly IntPtr selNameFieldStringValueHandle = Selector.GetHandle("nameFieldStringValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOk_ = "ok:";

	private static readonly IntPtr selOk_Handle = Selector.GetHandle("ok:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrompt = "prompt";

	private static readonly IntPtr selPromptHandle = Selector.GetHandle("prompt");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequiredFileType = "requiredFileType";

	private static readonly IntPtr selRequiredFileTypeHandle = Selector.GetHandle("requiredFileType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunModal = "runModal";

	private static readonly IntPtr selRunModalHandle = Selector.GetHandle("runModal");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunModalForDirectory_File_ = "runModalForDirectory:file:";

	private static readonly IntPtr selRunModalForDirectory_File_Handle = Selector.GetHandle("runModalForDirectory:file:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSavePanel = "savePanel";

	private static readonly IntPtr selSavePanelHandle = Selector.GetHandle("savePanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessoryView_ = "setAccessoryView:";

	private static readonly IntPtr selSetAccessoryView_Handle = Selector.GetHandle("setAccessoryView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowedFileTypes_ = "setAllowedFileTypes:";

	private static readonly IntPtr selSetAllowedFileTypes_Handle = Selector.GetHandle("setAllowedFileTypes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsOtherFileTypes_ = "setAllowsOtherFileTypes:";

	private static readonly IntPtr selSetAllowsOtherFileTypes_Handle = Selector.GetHandle("setAllowsOtherFileTypes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCanCreateDirectories_ = "setCanCreateDirectories:";

	private static readonly IntPtr selSetCanCreateDirectories_Handle = Selector.GetHandle("setCanCreateDirectories:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCanSelectHiddenExtension_ = "setCanSelectHiddenExtension:";

	private static readonly IntPtr selSetCanSelectHiddenExtension_Handle = Selector.GetHandle("setCanSelectHiddenExtension:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDirectory_ = "setDirectory:";

	private static readonly IntPtr selSetDirectory_Handle = Selector.GetHandle("setDirectory:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDirectoryURL_ = "setDirectoryURL:";

	private static readonly IntPtr selSetDirectoryURL_Handle = Selector.GetHandle("setDirectoryURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExtensionHidden_ = "setExtensionHidden:";

	private static readonly IntPtr selSetExtensionHidden_Handle = Selector.GetHandle("setExtensionHidden:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMessage_ = "setMessage:";

	private static readonly IntPtr selSetMessage_Handle = Selector.GetHandle("setMessage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNameFieldLabel_ = "setNameFieldLabel:";

	private static readonly IntPtr selSetNameFieldLabel_Handle = Selector.GetHandle("setNameFieldLabel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNameFieldStringValue_ = "setNameFieldStringValue:";

	private static readonly IntPtr selSetNameFieldStringValue_Handle = Selector.GetHandle("setNameFieldStringValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrompt_ = "setPrompt:";

	private static readonly IntPtr selSetPrompt_Handle = Selector.GetHandle("setPrompt:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRequiredFileType_ = "setRequiredFileType:";

	private static readonly IntPtr selSetRequiredFileType_Handle = Selector.GetHandle("setRequiredFileType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsHiddenFiles_ = "setShowsHiddenFiles:";

	private static readonly IntPtr selSetShowsHiddenFiles_Handle = Selector.GetHandle("setShowsHiddenFiles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsTagField_ = "setShowsTagField:";

	private static readonly IntPtr selSetShowsTagField_Handle = Selector.GetHandle("setShowsTagField:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTagNames_ = "setTagNames:";

	private static readonly IntPtr selSetTagNames_Handle = Selector.GetHandle("setTagNames:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitle_ = "setTitle:";

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTreatsFilePackagesAsDirectories_ = "setTreatsFilePackagesAsDirectories:";

	private static readonly IntPtr selSetTreatsFilePackagesAsDirectories_Handle = Selector.GetHandle("setTreatsFilePackagesAsDirectories:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsHiddenFiles = "showsHiddenFiles";

	private static readonly IntPtr selShowsHiddenFilesHandle = Selector.GetHandle("showsHiddenFiles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsTagField = "showsTagField";

	private static readonly IntPtr selShowsTagFieldHandle = Selector.GetHandle("showsTagField");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTagNames = "tagNames";

	private static readonly IntPtr selTagNamesHandle = Selector.GetHandle("tagNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitle = "title";

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTreatsFilePackagesAsDirectories = "treatsFilePackagesAsDirectories";

	private static readonly IntPtr selTreatsFilePackagesAsDirectoriesHandle = Selector.GetHandle("treatsFilePackagesAsDirectories");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateVisibleColumns = "validateVisibleColumns";

	private static readonly IntPtr selValidateVisibleColumnsHandle = Selector.GetHandle("validateVisibleColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSSavePanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView? AccessoryView
	{
		[Export("accessoryView", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessoryViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessoryViewHandle));
		}
		[Export("setAccessoryView:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessoryView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessoryView_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] AllowedFileTypes
	{
		[Export("allowedFileTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAllowedFileTypesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllowedFileTypesHandle));
		}
		[Export("setAllowedFileTypes:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAllowedFileTypes_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAllowedFileTypes_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsOtherFileTypes
	{
		[Export("allowsOtherFileTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsOtherFileTypesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsOtherFileTypesHandle);
		}
		[Export("setAllowsOtherFileTypes:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsOtherFileTypes_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsOtherFileTypes_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanCreateDirectories
	{
		[Export("canCreateDirectories")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanCreateDirectoriesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanCreateDirectoriesHandle);
		}
		[Export("setCanCreateDirectories:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanCreateDirectories_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanCreateDirectories_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanSelectHiddenExtension
	{
		[Export("canSelectHiddenExtension")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanSelectHiddenExtensionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanSelectHiddenExtensionHandle);
		}
		[Export("setCanSelectHiddenExtension:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanSelectHiddenExtension_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanSelectHiddenExtension_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new INSOpenSavePanelDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSOpenSavePanelDelegate;
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
	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "Use DirectoryUrl instead.")]
	public virtual string Directory
	{
		[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "Use DirectoryUrl instead.")]
		[Export("directory")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDirectoryHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDirectoryHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "Use DirectoryUrl instead.")]
		[Export("setDirectory:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDirectory_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDirectory_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl DirectoryUrl
	{
		[Export("directoryURL", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selDirectoryURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDirectoryURLHandle));
		}
		[Export("setDirectoryURL:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDirectoryURL_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDirectoryURL_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ExtensionHidden
	{
		[Export("isExtensionHidden")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsExtensionHiddenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsExtensionHiddenHandle);
		}
		[Export("setExtensionHidden:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetExtensionHidden_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetExtensionHidden_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "Use Url instead.")]
	public virtual string Filename
	{
		[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "Use Url instead.")]
		[Export("filename")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFilenameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFilenameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsExpanded
	{
		[Export("isExpanded")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsExpandedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsExpandedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Message
	{
		[Export("message")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMessageHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMessageHandle));
		}
		[Export("setMessage:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMessage_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMessage_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string NameFieldLabel
	{
		[Export("nameFieldLabel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameFieldLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameFieldLabelHandle));
		}
		[Export("setNameFieldLabel:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNameFieldLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNameFieldLabel_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string NameFieldStringValue
	{
		[Export("nameFieldStringValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameFieldStringValueHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameFieldStringValueHandle));
		}
		[Export("setNameFieldStringValue:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNameFieldStringValue_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNameFieldStringValue_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Prompt
	{
		[Export("prompt")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPromptHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPromptHandle));
		}
		[Export("setPrompt:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPrompt_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPrompt_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "Use AllowedFileTypes instead.")]
	public virtual string RequiredFileType
	{
		[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "Use AllowedFileTypes instead.")]
		[Export("requiredFileType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRequiredFileTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRequiredFileTypeHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "Use AllowedFileTypes instead.")]
		[Export("setRequiredFileType:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRequiredFileType_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRequiredFileType_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSSavePanel SavePanel
	{
		[Export("savePanel")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetINativeObject<NSSavePanel>(Messaging.IntPtr_objc_msgSend(class_ptr, selSavePanelHandle), forced_type: true, owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsHiddenFiles
	{
		[Export("showsHiddenFiles")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsHiddenFilesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsHiddenFilesHandle);
		}
		[Export("setShowsHiddenFiles:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsHiddenFiles_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsHiddenFiles_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual bool ShowsTagField
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("showsTagField")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsTagFieldHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsTagFieldHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setShowsTagField:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsTagField_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsTagField_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual string[] TagNames
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("tagNames", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTagNamesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTagNamesHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setTagNames:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTagNames_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTagNames_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string Title
	{
		[Export("title")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
		[Export("setTitle:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool TreatsFilePackagesAsDirectories
	{
		[Export("treatsFilePackagesAsDirectories")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selTreatsFilePackagesAsDirectoriesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selTreatsFilePackagesAsDirectoriesHandle);
		}
		[Export("setTreatsFilePackagesAsDirectories:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTreatsFilePackagesAsDirectories_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTreatsFilePackagesAsDirectories_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl Url
	{
		[Export("URL")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			NSApplication.EnsureUIThread();
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

	internal new virtual Type GetInternalEventDelegateType => typeof(_NSOpenSavePanelDelegate);

	public NSOpenSaveCompare? CompareFilenames
	{
		get
		{
			return EnsureNSOpenSavePanelDelegate().compareFilenames;
		}
		set
		{
			EnsureNSOpenSavePanelDelegate().compareFilenames = value;
		}
	}

	public NSOpenSaveFilename? IsValidFilename
	{
		get
		{
			return EnsureNSOpenSavePanelDelegate().isValidFilename;
		}
		set
		{
			EnsureNSOpenSavePanelDelegate().isValidFilename = value;
		}
	}

	public NSOpenSavePanelUrl? ShouldEnableUrl
	{
		get
		{
			return EnsureNSOpenSavePanelDelegate().shouldEnableUrl;
		}
		set
		{
			EnsureNSOpenSavePanelDelegate().shouldEnableUrl = value;
		}
	}

	public NSOpenSaveFilename? ShouldShowFilename
	{
		get
		{
			return EnsureNSOpenSavePanelDelegate().shouldShowFilename;
		}
		set
		{
			EnsureNSOpenSavePanelDelegate().shouldShowFilename = value;
		}
	}

	public NSOpenSaveFilenameConfirmation? UserEnteredFilename
	{
		get
		{
			return EnsureNSOpenSavePanelDelegate().userEnteredFilename;
		}
		set
		{
			EnsureNSOpenSavePanelDelegate().userEnteredFilename = value;
		}
	}

	public NSOpenSavePanelValidate? ValidateUrl
	{
		get
		{
			return EnsureNSOpenSavePanelDelegate().validateUrl;
		}
		set
		{
			EnsureNSOpenSavePanelDelegate().validateUrl = value;
		}
	}

	public event EventHandler<NSOpenSavePanelUrlEventArgs> DidChangeToDirectory
	{
		add
		{
			_NSOpenSavePanelDelegate nSOpenSavePanelDelegate = EnsureNSOpenSavePanelDelegate();
			nSOpenSavePanelDelegate.didChangeToDirectory = (EventHandler<NSOpenSavePanelUrlEventArgs>)System.Delegate.Combine(nSOpenSavePanelDelegate.didChangeToDirectory, value);
		}
		remove
		{
			_NSOpenSavePanelDelegate nSOpenSavePanelDelegate = EnsureNSOpenSavePanelDelegate();
			nSOpenSavePanelDelegate.didChangeToDirectory = (EventHandler<NSOpenSavePanelUrlEventArgs>)System.Delegate.Remove(nSOpenSavePanelDelegate.didChangeToDirectory, value);
		}
	}

	public event EventHandler<NSOpenSaveFilenameEventArgs> DirectoryDidChange
	{
		add
		{
			_NSOpenSavePanelDelegate nSOpenSavePanelDelegate = EnsureNSOpenSavePanelDelegate();
			nSOpenSavePanelDelegate.directoryDidChange = (EventHandler<NSOpenSaveFilenameEventArgs>)System.Delegate.Combine(nSOpenSavePanelDelegate.directoryDidChange, value);
		}
		remove
		{
			_NSOpenSavePanelDelegate nSOpenSavePanelDelegate = EnsureNSOpenSavePanelDelegate();
			nSOpenSavePanelDelegate.directoryDidChange = (EventHandler<NSOpenSaveFilenameEventArgs>)System.Delegate.Remove(nSOpenSavePanelDelegate.directoryDidChange, value);
		}
	}

	public event EventHandler SelectionDidChange
	{
		add
		{
			_NSOpenSavePanelDelegate nSOpenSavePanelDelegate = EnsureNSOpenSavePanelDelegate();
			nSOpenSavePanelDelegate.selectionDidChange = (EventHandler)System.Delegate.Combine(nSOpenSavePanelDelegate.selectionDidChange, value);
		}
		remove
		{
			_NSOpenSavePanelDelegate nSOpenSavePanelDelegate = EnsureNSOpenSavePanelDelegate();
			nSOpenSavePanelDelegate.selectionDidChange = (EventHandler)System.Delegate.Remove(nSOpenSavePanelDelegate.selectionDidChange, value);
		}
	}

	public event EventHandler<NSOpenSaveExpandingEventArgs> WillExpand
	{
		add
		{
			_NSOpenSavePanelDelegate nSOpenSavePanelDelegate = EnsureNSOpenSavePanelDelegate();
			nSOpenSavePanelDelegate.willExpand = (EventHandler<NSOpenSaveExpandingEventArgs>)System.Delegate.Combine(nSOpenSavePanelDelegate.willExpand, value);
		}
		remove
		{
			_NSOpenSavePanelDelegate nSOpenSavePanelDelegate = EnsureNSOpenSavePanelDelegate();
			nSOpenSavePanelDelegate.willExpand = (EventHandler<NSOpenSaveExpandingEventArgs>)System.Delegate.Remove(nSOpenSavePanelDelegate.willExpand, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSSavePanel(NSCoder coder)
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
	protected NSSavePanel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSavePanel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "All save panels now run out-of-process, use 'SavePanel' method instead")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("You must use 'SavePanel' method if the application is sandboxed.")]
	public NSSavePanel()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInitHandle), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitHandle), "init");
		}
	}

	[Export("beginWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Begin([BlockProxy(typeof(Trampolines.NIDNSSavePanelComplete))] NSSavePanelComplete onComplete)
	{
		NSApplication.EnsureUIThread();
		if (onComplete == null)
		{
			throw new ArgumentNullException("onComplete");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSSavePanelComplete.Handler, onComplete);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selBeginWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selBeginWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("beginSheetForDirectory:file:modalForWindow:modalDelegate:didEndSelector:contextInfo:")]
	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "Use Begin with the callback instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Begin(string directory, string filename, NSWindow docWindow, NSObject modalDelegate, Selector selector, IntPtr context)
	{
		NSApplication.EnsureUIThread();
		if (directory == null)
		{
			throw new ArgumentNullException("directory");
		}
		if (filename == null)
		{
			throw new ArgumentNullException("filename");
		}
		if (docWindow == null)
		{
			throw new ArgumentNullException("docWindow");
		}
		if (modalDelegate == null)
		{
			throw new ArgumentNullException("modalDelegate");
		}
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		IntPtr arg = NSString.CreateNative(directory);
		IntPtr arg2 = NSString.CreateNative(filename);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selBeginSheetForDirectory_File_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo_Handle, arg, arg2, docWindow.Handle, modalDelegate.Handle, selector.Handle, context);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selBeginSheetForDirectory_File_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo_Handle, arg, arg2, docWindow.Handle, modalDelegate.Handle, selector.Handle, context);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("beginSheetModalForWindow:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void BeginSheet(NSWindow window, [BlockProxy(typeof(Trampolines.NIDNSSavePanelComplete))] NSSavePanelComplete onComplete)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		if (onComplete == null)
		{
			throw new ArgumentNullException("onComplete");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSSavePanelComplete.Handler, onComplete);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selBeginSheetModalForWindow_CompletionHandler_Handle, window.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selBeginSheetModalForWindow_CompletionHandler_Handle, window.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("cancel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Cancel(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCancel_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCancel_Handle, sender.Handle);
		}
	}

	[Export("ok:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Ok(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOk_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOk_Handle, sender.Handle);
		}
	}

	[Export("runModal")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint RunModal()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend(base.Handle, selRunModalHandle);
		}
		return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selRunModalHandle);
	}

	[Export("runModalForDirectory:file:")]
	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "Use RunModal without parameters instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint RunModal(string? directory, string? filename)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(directory);
		IntPtr arg2 = NSString.CreateNative(filename);
		nint result = ((!base.IsDirectBinding) ? Messaging.nint_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRunModalForDirectory_File_Handle, arg, arg2) : Messaging.nint_objc_msgSend_IntPtr_IntPtr(base.Handle, selRunModalForDirectory_File_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("validateVisibleColumns")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ValidateVisibleColumns()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selValidateVisibleColumnsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selValidateVisibleColumnsHandle);
		}
	}

	internal new virtual _NSOpenSavePanelDelegate CreateInternalEventDelegateType()
	{
		return new _NSOpenSavePanelDelegate();
	}

	internal _NSOpenSavePanelDelegate EnsureNSOpenSavePanelDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSOpenSavePanelDelegate nSOpenSavePanelDelegate = Delegate as _NSOpenSavePanelDelegate;
		if (nSOpenSavePanelDelegate == null)
		{
			nSOpenSavePanelDelegate = (_NSOpenSavePanelDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSOpenSavePanelDelegate;
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

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSavePanel", true)]
public class NSSavePanel : NSPanel
{
	[Register]
	private sealed class _NSOpenSavePanelDelegate : NSOpenSavePanelDelegate
	{
		internal NSOpenSavePanelUrl shouldEnableUrl;

		internal NSOpenSavePanelValidate validateUrl;

		internal EventHandler<NSOpenSavePanelUrlEventArgs> didChangeToDirectory;

		internal NSOpenSaveFilenameConfirmation userEnteredFilename;

		internal EventHandler<NSOpenSaveExpandingEventArgs> willExpand;

		internal EventHandler selectionDidChange;

		internal NSOpenSaveFilename isValidFilename;

		internal EventHandler<NSOpenSaveFilenameEventArgs> directoryDidChange;

		internal NSOpenSaveCompare compareFilenames;

		internal NSOpenSaveFilename shouldShowFilename;

		[Preserve(Conditional = true)]
		public override bool ShouldEnableUrl(NSSavePanel panel, NSUrl url)
		{
			return shouldEnableUrl?.Invoke(panel, url) ?? true;
		}

		[Preserve(Conditional = true)]
		public override bool ValidateUrl(NSSavePanel panel, NSUrl url, out NSError outError)
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
		public override void DidChangeToDirectory(NSSavePanel panel, NSUrl newDirectoryUrl)
		{
			EventHandler<NSOpenSavePanelUrlEventArgs> eventHandler = didChangeToDirectory;
			if (eventHandler != null)
			{
				NSOpenSavePanelUrlEventArgs e = new NSOpenSavePanelUrlEventArgs(newDirectoryUrl);
				eventHandler(panel, e);
			}
		}

		[Preserve(Conditional = true)]
		public override string UserEnteredFilename(NSSavePanel panel, string filename, bool confirmed)
		{
			NSOpenSaveFilenameConfirmation nSOpenSaveFilenameConfirmation = userEnteredFilename;
			if (nSOpenSaveFilenameConfirmation != null)
			{
				return nSOpenSaveFilenameConfirmation(panel, filename, confirmed);
			}
			return filename;
		}

		[Preserve(Conditional = true)]
		public override void WillExpand(NSSavePanel panel, bool expanding)
		{
			EventHandler<NSOpenSaveExpandingEventArgs> eventHandler = willExpand;
			if (eventHandler != null)
			{
				NSOpenSaveExpandingEventArgs e = new NSOpenSaveExpandingEventArgs(expanding);
				eventHandler(panel, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void SelectionDidChange(NSSavePanel panel)
		{
			selectionDidChange?.Invoke(panel, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override bool IsValidFilename(NSSavePanel panel, string fileName)
		{
			return isValidFilename?.Invoke(panel, fileName) ?? true;
		}

		[Preserve(Conditional = true)]
		public override void DirectoryDidChange(NSSavePanel panel, string path)
		{
			EventHandler<NSOpenSaveFilenameEventArgs> eventHandler = directoryDidChange;
			if (eventHandler != null)
			{
				NSOpenSaveFilenameEventArgs e = new NSOpenSaveFilenameEventArgs(path);
				eventHandler(panel, e);
			}
		}

		[Preserve(Conditional = true)]
		public override NSComparisonResult CompareFilenames(NSSavePanel panel, string name1, string name2, bool caseSensitive)
		{
			return compareFilenames?.Invoke(panel, name1, name2, caseSensitive) ?? NSComparisonResult.Same;
		}

		[Preserve(Conditional = true)]
		public override bool ShouldShowFilename(NSSavePanel panel, string filename)
		{
			return shouldShowFilename?.Invoke(panel, filename) ?? true;
		}
	}

	private static readonly IntPtr selSavePanelHandle = Selector.GetHandle("savePanel");

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	private static readonly IntPtr selIsExpandedHandle = Selector.GetHandle("isExpanded");

	private static readonly IntPtr selDirectoryURLHandle = Selector.GetHandle("directoryURL");

	private static readonly IntPtr selSetDirectoryURL_Handle = Selector.GetHandle("setDirectoryURL:");

	private static readonly IntPtr selAllowedFileTypesHandle = Selector.GetHandle("allowedFileTypes");

	private static readonly IntPtr selSetAllowedFileTypes_Handle = Selector.GetHandle("setAllowedFileTypes:");

	private static readonly IntPtr selAllowsOtherFileTypesHandle = Selector.GetHandle("allowsOtherFileTypes");

	private static readonly IntPtr selSetAllowsOtherFileTypes_Handle = Selector.GetHandle("setAllowsOtherFileTypes:");

	private static readonly IntPtr selAccessoryViewHandle = Selector.GetHandle("accessoryView");

	private static readonly IntPtr selSetAccessoryView_Handle = Selector.GetHandle("setAccessoryView:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selCanCreateDirectoriesHandle = Selector.GetHandle("canCreateDirectories");

	private static readonly IntPtr selSetCanCreateDirectories_Handle = Selector.GetHandle("setCanCreateDirectories:");

	private static readonly IntPtr selCanSelectHiddenExtensionHandle = Selector.GetHandle("canSelectHiddenExtension");

	private static readonly IntPtr selSetCanSelectHiddenExtension_Handle = Selector.GetHandle("setCanSelectHiddenExtension:");

	private static readonly IntPtr selIsExtensionHiddenHandle = Selector.GetHandle("isExtensionHidden");

	private static readonly IntPtr selSetExtensionHidden_Handle = Selector.GetHandle("setExtensionHidden:");

	private static readonly IntPtr selTreatsFilePackagesAsDirectoriesHandle = Selector.GetHandle("treatsFilePackagesAsDirectories");

	private static readonly IntPtr selSetTreatsFilePackagesAsDirectories_Handle = Selector.GetHandle("setTreatsFilePackagesAsDirectories:");

	private static readonly IntPtr selPromptHandle = Selector.GetHandle("prompt");

	private static readonly IntPtr selSetPrompt_Handle = Selector.GetHandle("setPrompt:");

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	private static readonly IntPtr selNameFieldLabelHandle = Selector.GetHandle("nameFieldLabel");

	private static readonly IntPtr selSetNameFieldLabel_Handle = Selector.GetHandle("setNameFieldLabel:");

	private static readonly IntPtr selNameFieldStringValueHandle = Selector.GetHandle("nameFieldStringValue");

	private static readonly IntPtr selSetNameFieldStringValue_Handle = Selector.GetHandle("setNameFieldStringValue:");

	private static readonly IntPtr selMessageHandle = Selector.GetHandle("message");

	private static readonly IntPtr selSetMessage_Handle = Selector.GetHandle("setMessage:");

	private static readonly IntPtr selShowsHiddenFilesHandle = Selector.GetHandle("showsHiddenFiles");

	private static readonly IntPtr selSetShowsHiddenFiles_Handle = Selector.GetHandle("setShowsHiddenFiles:");

	private static readonly IntPtr selFilenameHandle = Selector.GetHandle("filename");

	private static readonly IntPtr selDirectoryHandle = Selector.GetHandle("directory");

	private static readonly IntPtr selSetDirectory_Handle = Selector.GetHandle("setDirectory:");

	private static readonly IntPtr selRequiredFileTypeHandle = Selector.GetHandle("requiredFileType");

	private static readonly IntPtr selSetRequiredFileType_Handle = Selector.GetHandle("setRequiredFileType:");

	private static readonly IntPtr selValidateVisibleColumnsHandle = Selector.GetHandle("validateVisibleColumns");

	private static readonly IntPtr selOk_Handle = Selector.GetHandle("ok:");

	private static readonly IntPtr selCancel_Handle = Selector.GetHandle("cancel:");

	private static readonly IntPtr selBeginSheetModalForWindowCompletionHandler_Handle = Selector.GetHandle("beginSheetModalForWindow:completionHandler:");

	private static readonly IntPtr selBeginWithCompletionHandler_Handle = Selector.GetHandle("beginWithCompletionHandler:");

	private static readonly IntPtr selRunModalHandle = Selector.GetHandle("runModal");

	private static readonly IntPtr selBeginSheetForDirectoryFileModalForWindowModalDelegateDidEndSelectorContextInfo_Handle = Selector.GetHandle("beginSheetForDirectory:file:modalForWindow:modalDelegate:didEndSelector:contextInfo:");

	private static readonly IntPtr selRunModalForDirectoryFile_Handle = Selector.GetHandle("runModalForDirectory:file:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSSavePanel");

	private static object __mt_SavePanel_var_static;

	private object __mt_Url_var;

	private object __mt_DirectoryUrl_var;

	private object __mt_AccessoryView_var;

	private object __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public static NSSavePanel SavePanel
	{
		[Export("savePanel")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSSavePanel)(__mt_SavePanel_var_static = (NSSavePanel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSavePanelHandle)));
		}
	}

	public virtual NSUrl Url
	{
		[Export("URL")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSUrl)(__mt_Url_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle)))));
		}
	}

	public virtual bool IsExpanded
	{
		[Export("isExpanded")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsExpandedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsExpandedHandle);
		}
	}

	public virtual NSUrl DirectoryUrl
	{
		[Export("directoryURL")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSUrl)(__mt_DirectoryUrl_var = ((!IsDirectBinding) ? ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDirectoryURLHandle))) : ((NSUrl)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDirectoryURLHandle)))));
		}
		[Export("setDirectoryURL:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDirectoryURL_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDirectoryURL_Handle, value.Handle);
			}
			__mt_DirectoryUrl_var = value;
		}
	}

	public virtual string[] AllowedFileTypes
	{
		[Export("allowedFileTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAllowedFileTypesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllowedFileTypesHandle));
		}
		[Export("setAllowedFileTypes:")]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromStrings(value));
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAllowedFileTypes_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAllowedFileTypes_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	public virtual bool AllowsOtherFileTypes
	{
		[Export("allowsOtherFileTypes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsOtherFileTypesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsOtherFileTypesHandle);
		}
		[Export("setAllowsOtherFileTypes:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsOtherFileTypes_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsOtherFileTypes_Handle, value);
			}
		}
	}

	public virtual NSView AccessoryView
	{
		[Export("accessoryView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSView)(__mt_AccessoryView_var = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessoryViewHandle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessoryViewHandle)))));
		}
		[Export("setAccessoryView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessoryView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessoryView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_AccessoryView_var = value;
		}
	}

	public new virtual NSObject WeakDelegate
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

	public new NSOpenSavePanelDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSOpenSavePanelDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual bool CanCreateDirectories
	{
		[Export("canCreateDirectories")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanCreateDirectoriesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanCreateDirectoriesHandle);
		}
		[Export("setCanCreateDirectories:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanCreateDirectories_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanCreateDirectories_Handle, value);
			}
		}
	}

	public virtual bool CanSelectHiddenExtension
	{
		[Export("canSelectHiddenExtension")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanSelectHiddenExtensionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanSelectHiddenExtensionHandle);
		}
		[Export("setCanSelectHiddenExtension:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanSelectHiddenExtension_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanSelectHiddenExtension_Handle, value);
			}
		}
	}

	public virtual bool ExtensionHidden
	{
		[Export("isExtensionHidden")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsExtensionHiddenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsExtensionHiddenHandle);
		}
		[Export("setExtensionHidden:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetExtensionHidden_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetExtensionHidden_Handle, value);
			}
		}
	}

	public virtual bool TreatsFilePackagesAsDirectories
	{
		[Export("treatsFilePackagesAsDirectories")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selTreatsFilePackagesAsDirectoriesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selTreatsFilePackagesAsDirectoriesHandle);
		}
		[Export("setTreatsFilePackagesAsDirectories:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetTreatsFilePackagesAsDirectories_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetTreatsFilePackagesAsDirectories_Handle, value);
			}
		}
	}

	public virtual string Prompt
	{
		[Export("prompt")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public new virtual string Title
	{
		[Export("title")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string NameFieldLabel
	{
		[Export("nameFieldLabel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string NameFieldStringValue
	{
		[Export("nameFieldStringValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string Message
	{
		[Export("message")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual bool ShowsHiddenFiles
	{
		[Export("showsHiddenFiles")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsHiddenFilesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsHiddenFilesHandle);
		}
		[Export("setShowsHiddenFiles:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsHiddenFiles_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsHiddenFiles_Handle, value);
			}
		}
	}

	[Obsolete("On 10.6 and newer use Url instead", false)]
	public virtual string Filename
	{
		[Export("filename")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFilenameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFilenameHandle));
		}
	}

	[Obsolete("On 10.6 and newer use DirectoryUrl instead", false)]
	public virtual string Directory
	{
		[Export("directory")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDirectoryHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDirectoryHandle));
		}
		[Export("setDirectory:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDirectory_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDirectory_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[Obsolete("On 10.6 and newer use AllowedFileTypes instead", false)]
	public virtual string RequiredFileType
	{
		[Export("requiredFileType")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRequiredFileTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRequiredFileTypeHandle));
		}
		[Export("setRequiredFileType:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRequiredFileType_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRequiredFileType_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public NSOpenSavePanelUrl ShouldEnableUrl
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

	public NSOpenSavePanelValidate ValidateUrl
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

	public NSOpenSaveFilenameConfirmation UserEnteredFilename
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

	public NSOpenSaveFilename IsValidFilename
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

	public NSOpenSaveCompare CompareFilenames
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

	public NSOpenSaveFilename ShouldShowFilename
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

	[Obsolete("On 10.6 and newer Use DidChangeToDirectoryUrl instead", false)]
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSavePanel()
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
	public NSSavePanel(NSCoder coder)
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
	public NSSavePanel(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSSavePanel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("validateVisibleColumns")]
	public virtual void ValidateVisibleColumns()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selValidateVisibleColumnsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selValidateVisibleColumnsHandle);
		}
	}

	[Export("ok:")]
	public virtual void Ok(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selOk_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selOk_Handle, sender.Handle);
		}
	}

	[Export("cancel:")]
	public virtual void Cancel(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCancel_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCancel_Handle, sender.Handle);
		}
	}

	[Export("beginSheetModalForWindow:completionHandler:")]
	public unsafe virtual void BeginSheet(NSWindow window, NSSavePanelComplete onComplete)
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
		blockLiteral.SetupBlock(Trampolines.SDNSSavePanelComplete.Handler, onComplete);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selBeginSheetModalForWindowCompletionHandler_Handle, window.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selBeginSheetModalForWindowCompletionHandler_Handle, window.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("beginWithCompletionHandler:")]
	public unsafe virtual void Begin(NSSavePanelComplete onComplete)
	{
		NSApplication.EnsureUIThread();
		if (onComplete == null)
		{
			throw new ArgumentNullException("onComplete");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSSavePanelComplete.Handler, onComplete);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selBeginWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selBeginWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("runModal")]
	public virtual long RunModal()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend(base.Handle, selRunModalHandle);
		}
		return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selRunModalHandle);
	}

	[Export("beginSheetForDirectory:file:modalForWindow:modalDelegate:didEndSelector:contextInfo:")]
	[Obsolete("On 10.6 and newer use Begin with the callback", false)]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selBeginSheetForDirectoryFileModalForWindowModalDelegateDidEndSelectorContextInfo_Handle, arg, arg2, docWindow.Handle, modalDelegate.Handle, selector.Handle, context);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selBeginSheetForDirectoryFileModalForWindowModalDelegateDidEndSelectorContextInfo_Handle, arg, arg2, docWindow.Handle, modalDelegate.Handle, selector.Handle, context);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("runModalForDirectory:file:")]
	[Obsolete("On 10.6 and newer use RunModal without parameters instead", false)]
	public virtual long RunModal(string directory, string filename)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(directory);
		IntPtr arg2 = NSString.CreateNative(filename);
		long result = ((!IsDirectBinding) ? Messaging.Int64_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRunModalForDirectoryFile_Handle, arg, arg2) : Messaging.Int64_objc_msgSend_IntPtr_IntPtr(base.Handle, selRunModalForDirectoryFile_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	private _NSOpenSavePanelDelegate EnsureNSOpenSavePanelDelegate()
	{
		NSOpenSavePanelDelegate nSOpenSavePanelDelegate = Delegate;
		if (nSOpenSavePanelDelegate == null || !(nSOpenSavePanelDelegate is _NSOpenSavePanelDelegate))
		{
			nSOpenSavePanelDelegate = (Delegate = new _NSOpenSavePanelDelegate());
		}
		return (_NSOpenSavePanelDelegate)nSOpenSavePanelDelegate;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Url_var = null;
			__mt_DirectoryUrl_var = null;
			__mt_AccessoryView_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}

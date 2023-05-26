using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSOpenPanel", true)]
public class NSOpenPanel : NSSavePanel
{
	private static readonly IntPtr selOpenPanelHandle = Selector.GetHandle("openPanel");

	private static readonly IntPtr selURLsHandle = Selector.GetHandle("URLs");

	private static readonly IntPtr selResolvesAliasesHandle = Selector.GetHandle("resolvesAliases");

	private static readonly IntPtr selSetResolvesAliases_Handle = Selector.GetHandle("setResolvesAliases:");

	private static readonly IntPtr selCanChooseDirectoriesHandle = Selector.GetHandle("canChooseDirectories");

	private static readonly IntPtr selSetCanChooseDirectories_Handle = Selector.GetHandle("setCanChooseDirectories:");

	private static readonly IntPtr selAllowsMultipleSelectionHandle = Selector.GetHandle("allowsMultipleSelection");

	private static readonly IntPtr selSetAllowsMultipleSelection_Handle = Selector.GetHandle("setAllowsMultipleSelection:");

	private static readonly IntPtr selCanChooseFilesHandle = Selector.GetHandle("canChooseFiles");

	private static readonly IntPtr selSetCanChooseFiles_Handle = Selector.GetHandle("setCanChooseFiles:");

	private static readonly IntPtr selFilenamesHandle = Selector.GetHandle("filenames");

	private static readonly IntPtr selBeginSheetForDirectoryFileTypesModalForWindowModalDelegateDidEndSelectorContextInfo_Handle = Selector.GetHandle("beginSheetForDirectory:file:types:modalForWindow:modalDelegate:didEndSelector:contextInfo:");

	private static readonly IntPtr selBeginForDirectoryFileTypesModelessDelegateDidEndSelectorContextInfo_Handle = Selector.GetHandle("beginForDirectory:file:types:modelessDelegate:didEndSelector:contextInfo:");

	private static readonly IntPtr selRunModalForDirectoryFileTypes_Handle = Selector.GetHandle("runModalForDirectory:file:types:");

	private static readonly IntPtr selRunModalForTypes_Handle = Selector.GetHandle("runModalForTypes:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSOpenPanel");

	private static object __mt_OpenPanel_var_static;

	private object __mt_Urls_var;

	public override IntPtr ClassHandle => class_ptr;

	public static NSOpenPanel OpenPanel
	{
		[Export("openPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSOpenPanel)(__mt_OpenPanel_var_static = (NSOpenPanel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selOpenPanelHandle)));
		}
	}

	public virtual NSUrl[] Urls
	{
		[Export("URLs")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSUrl[])(__mt_Urls_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLsHandle)) : NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLsHandle))));
		}
	}

	public virtual bool ResolvesAliases
	{
		[Export("resolvesAliases")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selResolvesAliasesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selResolvesAliasesHandle);
		}
		[Export("setResolvesAliases:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetResolvesAliases_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetResolvesAliases_Handle, value);
			}
		}
	}

	public virtual bool CanChooseDirectories
	{
		[Export("canChooseDirectories")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanChooseDirectoriesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanChooseDirectoriesHandle);
		}
		[Export("setCanChooseDirectories:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanChooseDirectories_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanChooseDirectories_Handle, value);
			}
		}
	}

	public virtual bool AllowsMultipleSelection
	{
		[Export("allowsMultipleSelection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsMultipleSelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsMultipleSelectionHandle);
		}
		[Export("setAllowsMultipleSelection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsMultipleSelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsMultipleSelection_Handle, value);
			}
		}
	}

	public virtual bool CanChooseFiles
	{
		[Export("canChooseFiles")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanChooseFilesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanChooseFilesHandle);
		}
		[Export("setCanChooseFiles:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanChooseFiles_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanChooseFiles_Handle, value);
			}
		}
	}

	[Obsolete("On 10.6 and newer, use Uris", false)]
	public virtual string[] Filenames
	{
		[Export("filenames")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFilenamesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFilenamesHandle));
		}
	}

	public void BeginSheet(string directory, string fileName, string[] fileTypes, NSWindow modalForWindow)
	{
		BeginSheet(directory, fileName, fileTypes, modalForWindow, null, null, IntPtr.Zero);
	}

	public void BeginSheet(string directory, string fileName, string[] fileTypes, NSWindow modalForWindow, NSAction onEnded)
	{
		NSObject modalDelegate = OneShotTracker.Create(onEnded);
		BeginSheet(directory, fileName, fileTypes, modalForWindow, modalDelegate, NSActionDispatcher.Selector, IntPtr.Zero);
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSOpenPanel()
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
	public NSOpenPanel(NSCoder coder)
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
	public NSOpenPanel(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSOpenPanel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("beginSheetForDirectory:file:types:modalForWindow:modalDelegate:didEndSelector:contextInfo:")]
	[Obsolete("On 10.6 and newer use runModalForWindow:", false)]
	public virtual void BeginSheet(string directory, string fileName, string[] fileTypes, NSWindow modalForWindow, NSObject modalDelegate, Selector didEndSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(directory);
		IntPtr arg2 = NSString.CreateNative(fileName);
		NSArray nSArray = ((fileTypes == null) ? null : NSArray.FromStrings(fileTypes));
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selBeginSheetForDirectoryFileTypesModalForWindowModalDelegateDidEndSelectorContextInfo_Handle, arg, arg2, nSArray?.Handle ?? IntPtr.Zero, modalForWindow?.Handle ?? IntPtr.Zero, modalDelegate?.Handle ?? IntPtr.Zero, (didEndSelector == null) ? IntPtr.Zero : didEndSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selBeginSheetForDirectoryFileTypesModalForWindowModalDelegateDidEndSelectorContextInfo_Handle, arg, arg2, nSArray?.Handle ?? IntPtr.Zero, modalForWindow?.Handle ?? IntPtr.Zero, modalDelegate?.Handle ?? IntPtr.Zero, (didEndSelector == null) ? IntPtr.Zero : didEndSelector.Handle, contextInfo);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		nSArray?.Dispose();
	}

	[Export("beginForDirectory:file:types:modelessDelegate:didEndSelector:contextInfo:")]
	[Obsolete("On 10.6 and newer use runWithCompletionHandler:", false)]
	public virtual void Begin(string directory, string fileName, string[] fileTypes, NSObject modelessDelegate, Selector didEndSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(directory);
		IntPtr arg2 = NSString.CreateNative(fileName);
		NSArray nSArray = ((fileTypes == null) ? null : NSArray.FromStrings(fileTypes));
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selBeginForDirectoryFileTypesModelessDelegateDidEndSelectorContextInfo_Handle, arg, arg2, nSArray?.Handle ?? IntPtr.Zero, modelessDelegate?.Handle ?? IntPtr.Zero, (didEndSelector == null) ? IntPtr.Zero : didEndSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selBeginForDirectoryFileTypesModelessDelegateDidEndSelectorContextInfo_Handle, arg, arg2, nSArray?.Handle ?? IntPtr.Zero, modelessDelegate?.Handle ?? IntPtr.Zero, (didEndSelector == null) ? IntPtr.Zero : didEndSelector.Handle, contextInfo);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		nSArray?.Dispose();
	}

	[Export("runModalForDirectory:file:types:")]
	[Obsolete("On 10.6 and newer use runModal:", false)]
	public virtual long RunModal(string directory, string fileName, string[] types)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(directory);
		IntPtr arg2 = NSString.CreateNative(fileName);
		NSArray nSArray = ((types == null) ? null : NSArray.FromStrings(types));
		long result = ((!IsDirectBinding) ? Messaging.Int64_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRunModalForDirectoryFileTypes_Handle, arg, arg2, nSArray?.Handle ?? IntPtr.Zero) : Messaging.Int64_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRunModalForDirectoryFileTypes_Handle, arg, arg2, nSArray?.Handle ?? IntPtr.Zero));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		nSArray?.Dispose();
		return result;
	}

	[Export("runModalForTypes:")]
	[Obsolete("On 10.6 and newer use runModal:", false)]
	public virtual long RunModal(string[] types)
	{
		NSApplication.EnsureUIThread();
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		NSArray nSArray = NSArray.FromStrings(types);
		long result = ((!IsDirectBinding) ? Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selRunModalForTypes_Handle, nSArray.Handle) : Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selRunModalForTypes_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Urls_var = null;
		}
	}
}

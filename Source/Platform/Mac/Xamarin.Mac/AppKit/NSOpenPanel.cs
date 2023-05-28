using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSOpenPanel", true)]
public class NSOpenPanel : NSSavePanel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLs = "URLs";

	private static readonly IntPtr selURLsHandle = Selector.GetHandle("URLs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsMultipleSelection = "allowsMultipleSelection";

	private static readonly IntPtr selAllowsMultipleSelectionHandle = Selector.GetHandle("allowsMultipleSelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginForDirectory_File_Types_ModelessDelegate_DidEndSelector_ContextInfo_ = "beginForDirectory:file:types:modelessDelegate:didEndSelector:contextInfo:";

	private static readonly IntPtr selBeginForDirectory_File_Types_ModelessDelegate_DidEndSelector_ContextInfo_Handle = Selector.GetHandle("beginForDirectory:file:types:modelessDelegate:didEndSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginSheetForDirectory_File_Types_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo_ = "beginSheetForDirectory:file:types:modalForWindow:modalDelegate:didEndSelector:contextInfo:";

	private static readonly IntPtr selBeginSheetForDirectory_File_Types_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo_Handle = Selector.GetHandle("beginSheetForDirectory:file:types:modalForWindow:modalDelegate:didEndSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanChooseDirectories = "canChooseDirectories";

	private static readonly IntPtr selCanChooseDirectoriesHandle = Selector.GetHandle("canChooseDirectories");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanChooseFiles = "canChooseFiles";

	private static readonly IntPtr selCanChooseFilesHandle = Selector.GetHandle("canChooseFiles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilenames = "filenames";

	private static readonly IntPtr selFilenamesHandle = Selector.GetHandle("filenames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenPanel = "openPanel";

	private static readonly IntPtr selOpenPanelHandle = Selector.GetHandle("openPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResolvesAliases = "resolvesAliases";

	private static readonly IntPtr selResolvesAliasesHandle = Selector.GetHandle("resolvesAliases");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunModalForDirectory_File_Types_ = "runModalForDirectory:file:types:";

	private static readonly IntPtr selRunModalForDirectory_File_Types_Handle = Selector.GetHandle("runModalForDirectory:file:types:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunModalForTypes_ = "runModalForTypes:";

	private static readonly IntPtr selRunModalForTypes_Handle = Selector.GetHandle("runModalForTypes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsMultipleSelection_ = "setAllowsMultipleSelection:";

	private static readonly IntPtr selSetAllowsMultipleSelection_Handle = Selector.GetHandle("setAllowsMultipleSelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCanChooseDirectories_ = "setCanChooseDirectories:";

	private static readonly IntPtr selSetCanChooseDirectories_Handle = Selector.GetHandle("setCanChooseDirectories:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCanChooseFiles_ = "setCanChooseFiles:";

	private static readonly IntPtr selSetCanChooseFiles_Handle = Selector.GetHandle("setCanChooseFiles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResolvesAliases_ = "setResolvesAliases:";

	private static readonly IntPtr selSetResolvesAliases_Handle = Selector.GetHandle("setResolvesAliases:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSOpenPanel");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsMultipleSelection
	{
		[Export("allowsMultipleSelection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsMultipleSelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsMultipleSelectionHandle);
		}
		[Export("setAllowsMultipleSelection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsMultipleSelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsMultipleSelection_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanChooseDirectories
	{
		[Export("canChooseDirectories")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanChooseDirectoriesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanChooseDirectoriesHandle);
		}
		[Export("setCanChooseDirectories:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanChooseDirectories_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanChooseDirectories_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanChooseFiles
	{
		[Export("canChooseFiles")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanChooseFilesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanChooseFilesHandle);
		}
		[Export("setCanChooseFiles:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCanChooseFiles_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCanChooseFiles_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "Use Urls instead.")]
	public virtual string[] Filenames
	{
		[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "Use Urls instead.")]
		[Export("filenames")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFilenamesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFilenamesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSOpenPanel OpenPanel
	{
		[Export("openPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetINativeObject<NSOpenPanel>(Messaging.IntPtr_objc_msgSend(class_ptr, selOpenPanelHandle), forced_type: true, owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ResolvesAliases
	{
		[Export("resolvesAliases")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selResolvesAliasesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selResolvesAliasesHandle);
		}
		[Export("setResolvesAliases:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetResolvesAliases_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetResolvesAliases_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl[] Urls
	{
		[Export("URLs")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLsHandle));
			}
			return NSArray.ArrayFromHandle<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLsHandle));
		}
	}

	public void BeginSheet(string directory, string fileName, string[] fileTypes, NSWindow modalForWindow)
	{
		BeginSheet(directory, fileName, fileTypes, modalForWindow, null, null, IntPtr.Zero);
	}

	public void BeginSheet(string directory, string fileName, string[] fileTypes, NSWindow modalForWindow, Action onEnded)
	{
		NSAsyncActionDispatcher modalDelegate = new NSAsyncActionDispatcher(onEnded);
		BeginSheet(directory, fileName, fileTypes, modalForWindow, modalDelegate, NSDispatcher.Selector, IntPtr.Zero);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSOpenPanel(NSCoder coder)
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
	protected NSOpenPanel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSOpenPanel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "All open panels now run out-of-process, use 'OpenPanel' method instead")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("You must use 'OpenPanel' method if the application is sandboxed.")]
	public NSOpenPanel()
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

	[Export("beginForDirectory:file:types:modelessDelegate:didEndSelector:contextInfo:")]
	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Begin(string? directory, string? fileName, string[]? fileTypes, NSObject? modelessDelegate, Selector? didEndSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(directory);
		IntPtr arg2 = NSString.CreateNative(fileName);
		NSArray nSArray = ((fileTypes == null) ? null : NSArray.FromStrings(fileTypes));
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selBeginForDirectory_File_Types_ModelessDelegate_DidEndSelector_ContextInfo_Handle, arg, arg2, nSArray?.Handle ?? IntPtr.Zero, modelessDelegate?.Handle ?? IntPtr.Zero, (didEndSelector == null) ? IntPtr.Zero : didEndSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selBeginForDirectory_File_Types_ModelessDelegate_DidEndSelector_ContextInfo_Handle, arg, arg2, nSArray?.Handle ?? IntPtr.Zero, modelessDelegate?.Handle ?? IntPtr.Zero, (didEndSelector == null) ? IntPtr.Zero : didEndSelector.Handle, contextInfo);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		nSArray?.Dispose();
	}

	[Export("beginSheetForDirectory:file:types:modalForWindow:modalDelegate:didEndSelector:contextInfo:")]
	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "Use NSApplication.RunModal instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BeginSheet(string? directory, string? fileName, string[]? fileTypes, NSWindow? modalForWindow, NSObject? modalDelegate, Selector? didEndSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(directory);
		IntPtr arg2 = NSString.CreateNative(fileName);
		NSArray nSArray = ((fileTypes == null) ? null : NSArray.FromStrings(fileTypes));
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selBeginSheetForDirectory_File_Types_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo_Handle, arg, arg2, nSArray?.Handle ?? IntPtr.Zero, modalForWindow?.Handle ?? IntPtr.Zero, modalDelegate?.Handle ?? IntPtr.Zero, (didEndSelector == null) ? IntPtr.Zero : didEndSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selBeginSheetForDirectory_File_Types_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo_Handle, arg, arg2, nSArray?.Handle ?? IntPtr.Zero, modalForWindow?.Handle ?? IntPtr.Zero, modalDelegate?.Handle ?? IntPtr.Zero, (didEndSelector == null) ? IntPtr.Zero : didEndSelector.Handle, contextInfo);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		nSArray?.Dispose();
	}

	[Export("runModalForDirectory:file:types:")]
	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "Use NSApplication.RunModal instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint RunModal(string? directory, string? fileName, string[]? types)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(directory);
		IntPtr arg2 = NSString.CreateNative(fileName);
		NSArray nSArray = ((types == null) ? null : NSArray.FromStrings(types));
		nint result = ((!base.IsDirectBinding) ? Messaging.nint_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRunModalForDirectory_File_Types_Handle, arg, arg2, nSArray?.Handle ?? IntPtr.Zero) : Messaging.nint_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRunModalForDirectory_File_Types_Handle, arg, arg2, nSArray?.Handle ?? IntPtr.Zero));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		nSArray?.Dispose();
		return result;
	}

	[Export("runModalForTypes:")]
	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "Use NSApplication.RunModal instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint RunModal(string[] types)
	{
		NSApplication.EnsureUIThread();
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		NSArray nSArray = NSArray.FromStrings(types);
		nint result = ((!base.IsDirectBinding) ? Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selRunModalForTypes_Handle, nSArray.Handle) : Messaging.nint_objc_msgSend_IntPtr(base.Handle, selRunModalForTypes_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}
}

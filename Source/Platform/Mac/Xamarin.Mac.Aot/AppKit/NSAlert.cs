using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSAlert", true)]
public class NSAlert : NSObject
{
	[Register]
	private sealed class _NSAlertDelegate : NSAlertDelegate
	{
		internal NSAlertPredicate showHelp;

		[Preserve(Conditional = true)]
		public override bool ShowHelp(NSAlert alert)
		{
			return showHelp?.Invoke(alert) ?? false;
		}
	}

	private static readonly IntPtr selMessageTextHandle = Selector.GetHandle("messageText");

	private static readonly IntPtr selSetMessageText_Handle = Selector.GetHandle("setMessageText:");

	private static readonly IntPtr selInformativeTextHandle = Selector.GetHandle("informativeText");

	private static readonly IntPtr selSetInformativeText_Handle = Selector.GetHandle("setInformativeText:");

	private static readonly IntPtr selIconHandle = Selector.GetHandle("icon");

	private static readonly IntPtr selSetIcon_Handle = Selector.GetHandle("setIcon:");

	private static readonly IntPtr selButtonsHandle = Selector.GetHandle("buttons");

	private static readonly IntPtr selShowsHelpHandle = Selector.GetHandle("showsHelp");

	private static readonly IntPtr selSetShowsHelp_Handle = Selector.GetHandle("setShowsHelp:");

	private static readonly IntPtr selHelpAnchorHandle = Selector.GetHandle("helpAnchor");

	private static readonly IntPtr selSetHelpAnchor_Handle = Selector.GetHandle("setHelpAnchor:");

	private static readonly IntPtr selAlertStyleHandle = Selector.GetHandle("alertStyle");

	private static readonly IntPtr selSetAlertStyle_Handle = Selector.GetHandle("setAlertStyle:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selShowsSuppressionButtonHandle = Selector.GetHandle("showsSuppressionButton");

	private static readonly IntPtr selSetShowsSuppressionButton_Handle = Selector.GetHandle("setShowsSuppressionButton:");

	private static readonly IntPtr selSuppressionButtonHandle = Selector.GetHandle("suppressionButton");

	private static readonly IntPtr selAccessoryViewHandle = Selector.GetHandle("accessoryView");

	private static readonly IntPtr selSetAccessoryView_Handle = Selector.GetHandle("setAccessoryView:");

	private static readonly IntPtr selWindowHandle = Selector.GetHandle("window");

	private static readonly IntPtr selAlertWithError_Handle = Selector.GetHandle("alertWithError:");

	private static readonly IntPtr selAlertWithMessageTextDefaultButtonAlternateButtonOtherButtonInformativeTextWithFormat_Handle = Selector.GetHandle("alertWithMessageText:defaultButton:alternateButton:otherButton:informativeTextWithFormat:");

	private static readonly IntPtr selAddButtonWithTitle_Handle = Selector.GetHandle("addButtonWithTitle:");

	private static readonly IntPtr selLayoutHandle = Selector.GetHandle("layout");

	private static readonly IntPtr selRunModalHandle = Selector.GetHandle("runModal");

	private static readonly IntPtr selBeginSheetModalForWindowModalDelegateDidEndSelectorContextInfo_Handle = Selector.GetHandle("beginSheetModalForWindow:modalDelegate:didEndSelector:contextInfo:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSAlert");

	private object __mt_Icon_var;

	private object __mt_Buttons_var;

	private object __mt_Delegate_var;

	private object __mt_SuppressionButton_var;

	private object __mt_AccessoryView_var;

	private object __mt_Window_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string MessageText
	{
		[Export("messageText")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMessageTextHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMessageTextHandle));
		}
		[Export("setMessageText:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMessageText_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMessageText_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string InformativeText
	{
		[Export("informativeText")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInformativeTextHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInformativeTextHandle));
		}
		[Export("setInformativeText:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInformativeText_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInformativeText_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSImage Icon
	{
		[Export("icon")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSImage)(__mt_Icon_var = ((!IsDirectBinding) ? ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIconHandle))) : ((NSImage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selIconHandle)))));
		}
		[Export("setIcon:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetIcon_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetIcon_Handle, value.Handle);
			}
			__mt_Icon_var = value;
		}
	}

	public virtual NSButton[] Buttons
	{
		[Export("buttons")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSButton[])(__mt_Buttons_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSButton>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selButtonsHandle)) : NSArray.ArrayFromHandle<NSButton>(Messaging.IntPtr_objc_msgSend(base.Handle, selButtonsHandle))));
		}
	}

	public virtual bool ShowsHelp
	{
		[Export("showsHelp")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsHelpHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsHelpHandle);
		}
		[Export("setShowsHelp:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsHelp_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsHelp_Handle, value);
			}
		}
	}

	public virtual string HelpAnchor
	{
		[Export("helpAnchor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selHelpAnchorHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHelpAnchorHandle));
		}
		[Export("setHelpAnchor:")]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHelpAnchor_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHelpAnchor_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSAlertStyle AlertStyle
	{
		[Export("alertStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSAlertStyle)Messaging.UInt64_objc_msgSend(base.Handle, selAlertStyleHandle);
			}
			return (NSAlertStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAlertStyleHandle);
		}
		[Export("setAlertStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetAlertStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetAlertStyle_Handle, (ulong)value);
			}
		}
	}

	public virtual NSAlertDelegate Delegate
	{
		[Export("delegate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSAlertDelegate)(__mt_Delegate_var = ((!IsDirectBinding) ? ((NSAlertDelegate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle))) : ((NSAlertDelegate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)))));
		}
		[Export("setDelegate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value.Handle);
			}
			__mt_Delegate_var = value;
		}
	}

	public virtual bool ShowsSuppressionButton
	{
		[Export("showsSuppressionButton")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsSuppressionButtonHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsSuppressionButtonHandle);
		}
		[Export("setShowsSuppressionButton:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsSuppressionButton_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsSuppressionButton_Handle, value);
			}
		}
	}

	public virtual NSButton SuppressionButton
	{
		[Export("suppressionButton")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSButton)(__mt_SuppressionButton_var = ((!IsDirectBinding) ? ((NSButton)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSuppressionButtonHandle))) : ((NSButton)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSuppressionButtonHandle)))));
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

	public virtual NSPanel Window
	{
		[Export("window")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSPanel)(__mt_Window_var = ((!IsDirectBinding) ? ((NSPanel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowHandle))) : ((NSPanel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowHandle)))));
		}
	}

	public NSAlertPredicate ShowHelp
	{
		get
		{
			return EnsureNSAlertDelegate().showHelp;
		}
		set
		{
			EnsureNSAlertDelegate().showHelp = value;
		}
	}

	public void BeginSheet(NSWindow window)
	{
		BeginSheet(window, null, null, IntPtr.Zero);
	}

	public void BeginSheet(NSWindow window, NSAction onEnded)
	{
		BeginSheetForResponse(window, delegate
		{
			if (onEnded != null)
			{
				onEnded();
			}
		});
	}

	public void BeginSheetForResponse(NSWindow window, Action<int> onEnded)
	{
		BeginSheet(window, new NSAlertDidEndDispatcher(onEnded), NSAlertDidEndDispatcher.Selector, IntPtr.Zero);
	}

	public long RunSheetModal(NSWindow window)
	{
		return RunSheetModal(window, NSApplication.SharedApplication);
	}

	public long RunSheetModal(NSWindow window, NSApplication application)
	{
		if (application == null)
		{
			throw new ArgumentNullException("application");
		}
		if (window == null)
		{
			return RunModal();
		}
		long returnCode = -1000L;
		BeginSheetForResponse(window, delegate(int r)
		{
			returnCode = r;
			application.StopModal();
		});
		application.RunModalForWindow(Window);
		return returnCode;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSAlert()
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
	public NSAlert(NSCoder coder)
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
	public NSAlert(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSAlert(IntPtr handle)
		: base(handle)
	{
	}

	[Export("alertWithError:")]
	public static NSAlert WithError(NSError error)
	{
		NSApplication.EnsureUIThread();
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		return (NSAlert)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAlertWithError_Handle, error.Handle));
	}

	[Export("alertWithMessageText:defaultButton:alternateButton:otherButton:informativeTextWithFormat:")]
	public static NSAlert WithMessage(string message, string defaultButton, string alternateButton, string otherButton, string full)
	{
		NSApplication.EnsureUIThread();
		if (full == null)
		{
			throw new ArgumentNullException("full");
		}
		IntPtr arg = NSString.CreateNative(message);
		IntPtr arg2 = NSString.CreateNative(defaultButton);
		IntPtr arg3 = NSString.CreateNative(alternateButton);
		IntPtr arg4 = NSString.CreateNative(otherButton);
		IntPtr arg5 = NSString.CreateNative(full);
		NSAlert result = (NSAlert)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(class_ptr, selAlertWithMessageTextDefaultButtonAlternateButtonOtherButtonInformativeTextWithFormat_Handle, arg, arg2, arg3, arg4, arg5));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		NSString.ReleaseNative(arg4);
		NSString.ReleaseNative(arg5);
		return result;
	}

	[Export("addButtonWithTitle:")]
	public virtual NSButton AddButton(string title)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		NSButton result = ((!IsDirectBinding) ? ((NSButton)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddButtonWithTitle_Handle, arg))) : ((NSButton)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAddButtonWithTitle_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("layout")]
	public virtual void Layout()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLayoutHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLayoutHandle);
		}
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

	[Export("beginSheetModalForWindow:modalDelegate:didEndSelector:contextInfo:")]
	public virtual void BeginSheet(NSWindow window, NSObject modalDelegate, Selector didEndSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selBeginSheetModalForWindowModalDelegateDidEndSelectorContextInfo_Handle, window?.Handle ?? IntPtr.Zero, modalDelegate?.Handle ?? IntPtr.Zero, (didEndSelector == null) ? IntPtr.Zero : didEndSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selBeginSheetModalForWindowModalDelegateDidEndSelectorContextInfo_Handle, window?.Handle ?? IntPtr.Zero, modalDelegate?.Handle ?? IntPtr.Zero, (didEndSelector == null) ? IntPtr.Zero : didEndSelector.Handle, contextInfo);
		}
	}

	private _NSAlertDelegate EnsureNSAlertDelegate()
	{
		NSAlertDelegate nSAlertDelegate = Delegate;
		if (nSAlertDelegate == null || !(nSAlertDelegate is _NSAlertDelegate))
		{
			nSAlertDelegate = (Delegate = new _NSAlertDelegate());
		}
		return (_NSAlertDelegate)nSAlertDelegate;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Icon_var = null;
			__mt_Buttons_var = null;
			__mt_Delegate_var = null;
			__mt_SuppressionButton_var = null;
			__mt_AccessoryView_var = null;
			__mt_Window_var = null;
		}
	}
}

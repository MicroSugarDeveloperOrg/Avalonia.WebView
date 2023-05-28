using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSAlert", true)]
public class NSAlert : NSObject
{
	[Register]
	internal class _NSAlertDelegate : NSObject, INSAlertDelegate, INativeObject, IDisposable
	{
		internal NSAlertPredicate? showHelp;

		public _NSAlertDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("alertShowHelp:")]
		public bool ShowHelp(NSAlert alert)
		{
			return showHelp?.Invoke(alert) ?? false;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessoryView = "accessoryView";

	private static readonly IntPtr selAccessoryViewHandle = Selector.GetHandle("accessoryView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddButtonWithTitle_ = "addButtonWithTitle:";

	private static readonly IntPtr selAddButtonWithTitle_Handle = Selector.GetHandle("addButtonWithTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlertStyle = "alertStyle";

	private static readonly IntPtr selAlertStyleHandle = Selector.GetHandle("alertStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlertWithError_ = "alertWithError:";

	private static readonly IntPtr selAlertWithError_Handle = Selector.GetHandle("alertWithError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlertWithMessageText_DefaultButton_AlternateButton_OtherButton_InformativeTextWithFormat_ = "alertWithMessageText:defaultButton:alternateButton:otherButton:informativeTextWithFormat:";

	private static readonly IntPtr selAlertWithMessageText_DefaultButton_AlternateButton_OtherButton_InformativeTextWithFormat_Handle = Selector.GetHandle("alertWithMessageText:defaultButton:alternateButton:otherButton:informativeTextWithFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginSheetModalForWindow_CompletionHandler_ = "beginSheetModalForWindow:completionHandler:";

	private static readonly IntPtr selBeginSheetModalForWindow_CompletionHandler_Handle = Selector.GetHandle("beginSheetModalForWindow:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginSheetModalForWindow_ModalDelegate_DidEndSelector_ContextInfo_ = "beginSheetModalForWindow:modalDelegate:didEndSelector:contextInfo:";

	private static readonly IntPtr selBeginSheetModalForWindow_ModalDelegate_DidEndSelector_ContextInfo_Handle = Selector.GetHandle("beginSheetModalForWindow:modalDelegate:didEndSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selButtons = "buttons";

	private static readonly IntPtr selButtonsHandle = Selector.GetHandle("buttons");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHelpAnchor = "helpAnchor";

	private static readonly IntPtr selHelpAnchorHandle = Selector.GetHandle("helpAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIcon = "icon";

	private static readonly IntPtr selIconHandle = Selector.GetHandle("icon");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInformativeText = "informativeText";

	private static readonly IntPtr selInformativeTextHandle = Selector.GetHandle("informativeText");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayout = "layout";

	private static readonly IntPtr selLayoutHandle = Selector.GetHandle("layout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMessageText = "messageText";

	private static readonly IntPtr selMessageTextHandle = Selector.GetHandle("messageText");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunModal = "runModal";

	private static readonly IntPtr selRunModalHandle = Selector.GetHandle("runModal");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessoryView_ = "setAccessoryView:";

	private static readonly IntPtr selSetAccessoryView_Handle = Selector.GetHandle("setAccessoryView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlertStyle_ = "setAlertStyle:";

	private static readonly IntPtr selSetAlertStyle_Handle = Selector.GetHandle("setAlertStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHelpAnchor_ = "setHelpAnchor:";

	private static readonly IntPtr selSetHelpAnchor_Handle = Selector.GetHandle("setHelpAnchor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIcon_ = "setIcon:";

	private static readonly IntPtr selSetIcon_Handle = Selector.GetHandle("setIcon:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInformativeText_ = "setInformativeText:";

	private static readonly IntPtr selSetInformativeText_Handle = Selector.GetHandle("setInformativeText:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMessageText_ = "setMessageText:";

	private static readonly IntPtr selSetMessageText_Handle = Selector.GetHandle("setMessageText:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsHelp_ = "setShowsHelp:";

	private static readonly IntPtr selSetShowsHelp_Handle = Selector.GetHandle("setShowsHelp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsSuppressionButton_ = "setShowsSuppressionButton:";

	private static readonly IntPtr selSetShowsSuppressionButton_Handle = Selector.GetHandle("setShowsSuppressionButton:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsHelp = "showsHelp";

	private static readonly IntPtr selShowsHelpHandle = Selector.GetHandle("showsHelp");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsSuppressionButton = "showsSuppressionButton";

	private static readonly IntPtr selShowsSuppressionButtonHandle = Selector.GetHandle("showsSuppressionButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuppressionButton = "suppressionButton";

	private static readonly IntPtr selSuppressionButtonHandle = Selector.GetHandle("suppressionButton");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindow = "window";

	private static readonly IntPtr selWindowHandle = Selector.GetHandle("window");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSAlert");

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
	public virtual NSAlertStyle AlertStyle
	{
		[Export("alertStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSAlertStyle)Messaging.UInt64_objc_msgSend(base.Handle, selAlertStyleHandle);
			}
			return (NSAlertStyle)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAlertStyleHandle);
		}
		[Export("setAlertStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetAlertStyle_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetAlertStyle_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSButton[] Buttons
	{
		[Export("buttons")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSButton>(Messaging.IntPtr_objc_msgSend(base.Handle, selButtonsHandle));
			}
			return NSArray.ArrayFromHandle<NSButton>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selButtonsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSAlertDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSAlertDelegate;
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
	public virtual string HelpAnchor
	{
		[Export("helpAnchor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage Icon
	{
		[Export("icon", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selIconHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIconHandle));
		}
		[Export("setIcon:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetIcon_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetIcon_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string InformativeText
	{
		[Export("informativeText")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string MessageText
	{
		[Export("messageText")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsHelp
	{
		[Export("showsHelp")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsHelpHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsHelpHandle);
		}
		[Export("setShowsHelp:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsHelp_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsHelp_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsSuppressionButton
	{
		[Export("showsSuppressionButton")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsSuppressionButtonHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsSuppressionButtonHandle);
		}
		[Export("setShowsSuppressionButton:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsSuppressionButton_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsSuppressionButton_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSButton SuppressionButton
	{
		[Export("suppressionButton")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSButton>(Messaging.IntPtr_objc_msgSend(base.Handle, selSuppressionButtonHandle));
			}
			return Runtime.GetNSObject<NSButton>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSuppressionButtonHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Weak)]
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPanel Window
	{
		[Export("window")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPanel>(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowHandle));
			}
			return Runtime.GetNSObject<NSPanel>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowHandle));
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_NSAlertDelegate);

	public NSAlertPredicate? ShowHelp
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

	public void BeginSheet(NSWindow window, Action onEnded)
	{
		BeginSheetForResponse(window, delegate
		{
			if (onEnded != null)
			{
				onEnded();
			}
		});
	}

	public void BeginSheetForResponse(NSWindow window, Action<nint> onEnded)
	{
		BeginSheet(window, new NSAlertDidEndDispatcher(onEnded), NSAlertDidEndDispatcher.Selector, IntPtr.Zero);
	}

	public nint RunSheetModal(NSWindow window)
	{
		return RunSheetModal(window, NSApplication.SharedApplication);
	}

	public nint RunSheetModal(NSWindow window, NSApplication application)
	{
		if (application == null)
		{
			throw new ArgumentNullException("application");
		}
		if (window == null)
		{
			return RunModal();
		}
		nint returnCode = -1000;
		BeginSheetForResponse(window, delegate(nint r)
		{
			returnCode = r;
			application.StopModal();
		});
		application.RunModalForWindow(Window);
		return returnCode;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSAlert()
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
	protected NSAlert(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSAlert(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addButtonWithTitle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSButton AddButton(string title)
	{
		NSApplication.EnsureUIThread();
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		IntPtr arg = NSString.CreateNative(title);
		NSButton result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSButton>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddButtonWithTitle_Handle, arg)) : Runtime.GetNSObject<NSButton>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAddButtonWithTitle_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("beginSheetModalForWindow:modalDelegate:didEndSelector:contextInfo:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use BeginSheetModalForWindow (NSWindow sheetWindow, Action<nint> handler) instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BeginSheet(NSWindow? window, NSObject? modalDelegate, Selector? didEndSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selBeginSheetModalForWindow_ModalDelegate_DidEndSelector_ContextInfo_Handle, window?.Handle ?? IntPtr.Zero, modalDelegate?.Handle ?? IntPtr.Zero, (didEndSelector == null) ? IntPtr.Zero : didEndSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selBeginSheetModalForWindow_ModalDelegate_DidEndSelector_ContextInfo_Handle, window?.Handle ?? IntPtr.Zero, modalDelegate?.Handle ?? IntPtr.Zero, (didEndSelector == null) ? IntPtr.Zero : didEndSelector.Handle, contextInfo);
		}
	}

	[Export("beginSheetModalForWindow:completionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void BeginSheet(NSWindow? Window, [BlockProxy(typeof(Trampolines.NIDActionArity1V8))] Action<NSModalResponse>? handler)
	{
		NSApplication.EnsureUIThread();
		BlockLiteral* ptr;
		if (handler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V8.Handler, handler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selBeginSheetModalForWindow_CompletionHandler_Handle, Window?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selBeginSheetModalForWindow_CompletionHandler_Handle, Window?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSModalResponse> BeginSheetAsync(NSWindow? Window)
	{
		TaskCompletionSource<NSModalResponse> tcs = new TaskCompletionSource<NSModalResponse>();
		BeginSheet(Window, delegate(NSModalResponse obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("layout")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Layout()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLayoutHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLayoutHandle);
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

	[Export("alertWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAlert WithError(NSError error)
	{
		NSApplication.EnsureUIThread();
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		return Runtime.GetNSObject<NSAlert>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAlertWithError_Handle, error.Handle));
	}

	[Export("alertWithMessageText:defaultButton:alternateButton:otherButton:informativeTextWithFormat:")]
	[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, "Use constructor instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAlert WithMessage(string? message, string? defaultButton, string? alternateButton, string? otherButton, string full)
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
		NSAlert nSObject = Runtime.GetNSObject<NSAlert>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(class_ptr, selAlertWithMessageText_DefaultButton_AlternateButton_OtherButton_InformativeTextWithFormat_Handle, arg, arg2, arg3, arg4, arg5));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		NSString.ReleaseNative(arg4);
		NSString.ReleaseNative(arg5);
		return nSObject;
	}

	internal virtual _NSAlertDelegate CreateInternalEventDelegateType()
	{
		return new _NSAlertDelegate();
	}

	internal _NSAlertDelegate EnsureNSAlertDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSAlertDelegate nSAlertDelegate = Delegate as _NSAlertDelegate;
		if (nSAlertDelegate == null)
		{
			nSAlertDelegate = (_NSAlertDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSAlertDelegate;
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

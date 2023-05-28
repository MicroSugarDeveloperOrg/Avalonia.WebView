using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTextInputContext", true)]
public class NSTextInputContext : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveKeyboardSelectionDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(KeyboardSelectionDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveKeyboardSelectionDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(KeyboardSelectionDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcceptsGlyphInfo = "acceptsGlyphInfo";

	private static readonly IntPtr selAcceptsGlyphInfoHandle = Selector.GetHandle("acceptsGlyphInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActivate = "activate";

	private static readonly IntPtr selActivateHandle = Selector.GetHandle("activate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowedInputSourceLocales = "allowedInputSourceLocales";

	private static readonly IntPtr selAllowedInputSourceLocalesHandle = Selector.GetHandle("allowedInputSourceLocales");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClient = "client";

	private static readonly IntPtr selClientHandle = Selector.GetHandle("client");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentInputContext = "currentInputContext";

	private static readonly IntPtr selCurrentInputContextHandle = Selector.GetHandle("currentInputContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeactivate = "deactivate";

	private static readonly IntPtr selDeactivateHandle = Selector.GetHandle("deactivate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscardMarkedText = "discardMarkedText";

	private static readonly IntPtr selDiscardMarkedTextHandle = Selector.GetHandle("discardMarkedText");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHandleEvent_ = "handleEvent:";

	private static readonly IntPtr selHandleEvent_Handle = Selector.GetHandle("handleEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithClient_ = "initWithClient:";

	private static readonly IntPtr selInitWithClient_Handle = Selector.GetHandle("initWithClient:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateCharacterCoordinates = "invalidateCharacterCoordinates";

	private static readonly IntPtr selInvalidateCharacterCoordinatesHandle = Selector.GetHandle("invalidateCharacterCoordinates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyboardInputSources = "keyboardInputSources";

	private static readonly IntPtr selKeyboardInputSourcesHandle = Selector.GetHandle("keyboardInputSources");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedNameForInputSource_ = "localizedNameForInputSource:";

	private static readonly IntPtr selLocalizedNameForInputSource_Handle = Selector.GetHandle("localizedNameForInputSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedKeyboardInputSource = "selectedKeyboardInputSource";

	private static readonly IntPtr selSelectedKeyboardInputSourceHandle = Selector.GetHandle("selectedKeyboardInputSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAcceptsGlyphInfo_ = "setAcceptsGlyphInfo:";

	private static readonly IntPtr selSetAcceptsGlyphInfo_Handle = Selector.GetHandle("setAcceptsGlyphInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowedInputSourceLocales_ = "setAllowedInputSourceLocales:";

	private static readonly IntPtr selSetAllowedInputSourceLocales_Handle = Selector.GetHandle("setAllowedInputSourceLocales:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedKeyboardInputSource_ = "setSelectedKeyboardInputSource:";

	private static readonly IntPtr selSetSelectedKeyboardInputSource_Handle = Selector.GetHandle("setSelectedKeyboardInputSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTextInputContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeyboardSelectionDidChangeNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AcceptsGlyphInfo
	{
		[Export("acceptsGlyphInfo")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAcceptsGlyphInfoHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAcceptsGlyphInfoHandle);
		}
		[Export("setAcceptsGlyphInfo:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAcceptsGlyphInfo_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAcceptsGlyphInfo_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[]? AllowedInputSourceLocales
	{
		[Export("allowedInputSourceLocales", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAllowedInputSourceLocalesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllowedInputSourceLocalesHandle));
		}
		[Export("setAllowedInputSourceLocales:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			NSArray nSArray = ((value == null) ? null : NSArray.FromStrings(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAllowedInputSourceLocales_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAllowedInputSourceLocales_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSTextInputClient Client
	{
		[Export("client")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<INSTextInputClient>(Messaging.IntPtr_objc_msgSend(base.Handle, selClientHandle), owns: false);
			}
			return Runtime.GetINativeObject<INSTextInputClient>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selClientHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextInputContext CurrentInputContext
	{
		[Export("currentInputContext")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSTextInputContext>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentInputContextHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[]? KeyboardInputSources
	{
		[Export("keyboardInputSources")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyboardInputSourcesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyboardInputSourcesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? SelectedKeyboardInputSource
	{
		[Export("selectedKeyboardInputSource")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedKeyboardInputSourceHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedKeyboardInputSourceHandle));
		}
		[Export("setSelectedKeyboardInputSource:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSelectedKeyboardInputSource_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectedKeyboardInputSource_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[Field("NSTextInputContextKeyboardSelectionDidChangeNotification", "AppKit")]
	[Advice("Use NSTextInputContext.Notifications.ObserveKeyboardSelectionDidChange helper method instead.")]
	public static NSString KeyboardSelectionDidChangeNotification
	{
		get
		{
			if (_KeyboardSelectionDidChangeNotification == null)
			{
				_KeyboardSelectionDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextInputContextKeyboardSelectionDidChangeNotification");
			}
			return _KeyboardSelectionDidChangeNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextInputContext()
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
	protected NSTextInputContext(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTextInputContext(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithClient:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTextInputContext(INSTextInputClient client)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (client != null)
		{
			if (!(client is NSObject))
			{
				throw new ArgumentException("The object passed of type " + client.GetType()?.ToString() + " does not derive from NSObject");
			}
			if (base.IsDirectBinding)
			{
				InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithClient_Handle, client.Handle), "initWithClient:");
			}
			else
			{
				InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithClient_Handle, client.Handle), "initWithClient:");
			}
			return;
		}
		throw new ArgumentNullException("client");
	}

	[Export("activate")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Activate()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selActivateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selActivateHandle);
		}
	}

	[Export("deactivate")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Deactivate()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDeactivateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDeactivateHandle);
		}
	}

	[Export("discardMarkedText")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DiscardMarkedText()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDiscardMarkedTextHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDiscardMarkedTextHandle);
		}
	}

	[Export("handleEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HandleEvent(NSEvent theEvent)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selHandleEvent_Handle, theEvent.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selHandleEvent_Handle, theEvent.Handle);
	}

	[Export("invalidateCharacterCoordinates")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InvalidateCharacterCoordinates()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateCharacterCoordinatesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateCharacterCoordinatesHandle);
		}
	}

	[Export("localizedNameForInputSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string LocalizedNameForInputSource(string inputSourceIdentifier)
	{
		NSApplication.EnsureUIThread();
		if (inputSourceIdentifier == null)
		{
			throw new ArgumentNullException("inputSourceIdentifier");
		}
		IntPtr arg = NSString.CreateNative(inputSourceIdentifier);
		string result = NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLocalizedNameForInputSource_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}
}

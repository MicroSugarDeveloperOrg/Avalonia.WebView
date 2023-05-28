using System;
using System.ComponentModel;
using CoreText;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTextStorage", true)]
public class NSTextStorage : NSMutableAttributedString
{
	[Register]
	internal class _NSTextStorageDelegate : NSObject, INSTextStorageDelegate, INativeObject, IDisposable
	{
		internal EventHandler<NSTextStorageEventArgs>? didProcessEditing;

		internal EventHandler? textStorageDidProcessEditing;

		internal EventHandler? textStorageWillProcessEditing;

		internal EventHandler<NSTextStorageEventArgs>? willProcessEditing;

		public _NSTextStorageDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("textStorage:didProcessEditing:range:changeInLength:")]
		public void DidProcessEditing(NSTextStorage textStorage, NSTextStorageEditActions editedMask, NSRange editedRange, nint delta)
		{
			EventHandler<NSTextStorageEventArgs> eventHandler = didProcessEditing;
			if (eventHandler != null)
			{
				NSTextStorageEventArgs e = new NSTextStorageEventArgs(editedMask, editedRange, delta);
				eventHandler(textStorage, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("textStorageDidProcessEditing:")]
		public void TextStorageDidProcessEditing(NSNotification notification)
		{
			textStorageDidProcessEditing?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("textStorageWillProcessEditing:")]
		public void TextStorageWillProcessEditing(NSNotification notification)
		{
			textStorageWillProcessEditing?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("textStorage:willProcessEditing:range:changeInLength:")]
		public void WillProcessEditing(NSTextStorage textStorage, NSTextStorageEditActions editedMask, NSRange editedRange, nint delta)
		{
			EventHandler<NSTextStorageEventArgs> eventHandler = willProcessEditing;
			if (eventHandler != null)
			{
				NSTextStorageEventArgs e = new NSTextStorageEventArgs(editedMask, editedRange, delta);
				eventHandler(textStorage, e);
			}
		}
	}

	public static class Notifications
	{
		public static NSObject ObserveDidProcessEditing(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidProcessEditingNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidProcessEditing(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidProcessEditingNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillProcessEditing(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillProcessEditingNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillProcessEditing(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillProcessEditingNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddLayoutManager_ = "addLayoutManager:";

	private static readonly IntPtr selAddLayoutManager_Handle = Selector.GetHandle("addLayoutManager:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeInLength = "changeInLength";

	private static readonly IntPtr selChangeInLengthHandle = Selector.GetHandle("changeInLength");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEdited_Range_ChangeInLength_ = "edited:range:changeInLength:";

	private static readonly IntPtr selEdited_Range_ChangeInLength_Handle = Selector.GetHandle("edited:range:changeInLength:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEditedMask = "editedMask";

	private static readonly IntPtr selEditedMaskHandle = Selector.GetHandle("editedMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEditedRange = "editedRange";

	private static readonly IntPtr selEditedRangeHandle = Selector.GetHandle("editedRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnsureAttributesAreFixedInRange_ = "ensureAttributesAreFixedInRange:";

	private static readonly IntPtr selEnsureAttributesAreFixedInRange_Handle = Selector.GetHandle("ensureAttributesAreFixedInRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFixesAttributesLazily = "fixesAttributesLazily";

	private static readonly IntPtr selFixesAttributesLazilyHandle = Selector.GetHandle("fixesAttributesLazily");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithString_ = "initWithString:";

	private static readonly IntPtr selInitWithString_Handle = Selector.GetHandle("initWithString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateAttributesInRange_ = "invalidateAttributesInRange:";

	private static readonly IntPtr selInvalidateAttributesInRange_Handle = Selector.GetHandle("invalidateAttributesInRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutManagers = "layoutManagers";

	private static readonly IntPtr selLayoutManagersHandle = Selector.GetHandle("layoutManagers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProcessEditing = "processEditing";

	private static readonly IntPtr selProcessEditingHandle = Selector.GetHandle("processEditing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveLayoutManager_ = "removeLayoutManager:";

	private static readonly IntPtr selRemoveLayoutManager_Handle = Selector.GetHandle("removeLayoutManager:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTextStorage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidProcessEditingNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillProcessEditingNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ChangeInLength
	{
		[Export("changeInLength")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selChangeInLengthHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selChangeInLengthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSTextStorageDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSTextStorageDelegate;
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
	public virtual NSTextStorageEditedFlags EditedMask
	{
		[Export("editedMask")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSTextStorageEditedFlags)Messaging.UInt64_objc_msgSend(base.Handle, selEditedMaskHandle);
			}
			return (NSTextStorageEditedFlags)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selEditedMaskHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange EditedRange
	{
		[Export("editedRange")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selEditedRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selEditedRangeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool FixesAttributesLazily
	{
		[Export("fixesAttributesLazily")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selFixesAttributesLazilyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selFixesAttributesLazilyHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutManager[] LayoutManagers
	{
		[Export("layoutManagers")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSLayoutManager>(Messaging.IntPtr_objc_msgSend(base.Handle, selLayoutManagersHandle));
			}
			return NSArray.ArrayFromHandle<NSLayoutManager>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLayoutManagersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
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

	[Field("NSTextStorageDidProcessEditingNotification", "AppKit")]
	[Advice("Use NSTextStorage.Notifications.ObserveDidProcessEditing helper method instead.")]
	public static NSString DidProcessEditingNotification
	{
		get
		{
			if (_DidProcessEditingNotification == null)
			{
				_DidProcessEditingNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextStorageDidProcessEditingNotification");
			}
			return _DidProcessEditingNotification;
		}
	}

	[Field("NSTextStorageWillProcessEditingNotification", "AppKit")]
	[Advice("Use NSTextStorage.Notifications.ObserveWillProcessEditing helper method instead.")]
	public static NSString WillProcessEditingNotification
	{
		get
		{
			if (_WillProcessEditingNotification == null)
			{
				_WillProcessEditingNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextStorageWillProcessEditingNotification");
			}
			return _WillProcessEditingNotification;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_NSTextStorageDelegate);

	public event EventHandler<NSTextStorageEventArgs> DidProcessEditing
	{
		add
		{
			_NSTextStorageDelegate nSTextStorageDelegate = EnsureNSTextStorageDelegate();
			nSTextStorageDelegate.didProcessEditing = (EventHandler<NSTextStorageEventArgs>)System.Delegate.Combine(nSTextStorageDelegate.didProcessEditing, value);
		}
		remove
		{
			_NSTextStorageDelegate nSTextStorageDelegate = EnsureNSTextStorageDelegate();
			nSTextStorageDelegate.didProcessEditing = (EventHandler<NSTextStorageEventArgs>)System.Delegate.Remove(nSTextStorageDelegate.didProcessEditing, value);
		}
	}

	public event EventHandler TextStorageDidProcessEditing
	{
		add
		{
			_NSTextStorageDelegate nSTextStorageDelegate = EnsureNSTextStorageDelegate();
			nSTextStorageDelegate.textStorageDidProcessEditing = (EventHandler)System.Delegate.Combine(nSTextStorageDelegate.textStorageDidProcessEditing, value);
		}
		remove
		{
			_NSTextStorageDelegate nSTextStorageDelegate = EnsureNSTextStorageDelegate();
			nSTextStorageDelegate.textStorageDidProcessEditing = (EventHandler)System.Delegate.Remove(nSTextStorageDelegate.textStorageDidProcessEditing, value);
		}
	}

	public event EventHandler TextStorageWillProcessEditing
	{
		add
		{
			_NSTextStorageDelegate nSTextStorageDelegate = EnsureNSTextStorageDelegate();
			nSTextStorageDelegate.textStorageWillProcessEditing = (EventHandler)System.Delegate.Combine(nSTextStorageDelegate.textStorageWillProcessEditing, value);
		}
		remove
		{
			_NSTextStorageDelegate nSTextStorageDelegate = EnsureNSTextStorageDelegate();
			nSTextStorageDelegate.textStorageWillProcessEditing = (EventHandler)System.Delegate.Remove(nSTextStorageDelegate.textStorageWillProcessEditing, value);
		}
	}

	public event EventHandler<NSTextStorageEventArgs> WillProcessEditing
	{
		add
		{
			_NSTextStorageDelegate nSTextStorageDelegate = EnsureNSTextStorageDelegate();
			nSTextStorageDelegate.willProcessEditing = (EventHandler<NSTextStorageEventArgs>)System.Delegate.Combine(nSTextStorageDelegate.willProcessEditing, value);
		}
		remove
		{
			_NSTextStorageDelegate nSTextStorageDelegate = EnsureNSTextStorageDelegate();
			nSTextStorageDelegate.willProcessEditing = (EventHandler<NSTextStorageEventArgs>)System.Delegate.Remove(nSTextStorageDelegate.willProcessEditing, value);
		}
	}

	public NSTextStorage(string str, NSDictionary attributes)
		: base(str, attributes)
	{
	}

	public NSTextStorage(NSAttributedString other)
		: base(other)
	{
	}

	public NSTextStorage(string str, CTStringAttributes attributes)
		: base(str, attributes)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextStorage()
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
	public NSTextStorage(NSCoder coder)
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
	protected NSTextStorage(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTextStorage(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTextStorage(string str)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = NSString.CreateNative(str);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithString_Handle, arg), "initWithString:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithString_Handle, arg), "initWithString:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("addLayoutManager:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddLayoutManager(NSLayoutManager obj)
	{
		NSApplication.EnsureUIThread();
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddLayoutManager_Handle, obj.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddLayoutManager_Handle, obj.Handle);
		}
	}

	[Export("edited:range:changeInLength:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Edited(nuint editedMask, NSRange range, nint delta)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nuint_NSRange_nint(base.Handle, selEdited_Range_ChangeInLength_Handle, editedMask, range, delta);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nuint_NSRange_nint(base.SuperHandle, selEdited_Range_ChangeInLength_Handle, editedMask, range, delta);
		}
	}

	[Export("ensureAttributesAreFixedInRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EnsureAttributesAreFixed(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selEnsureAttributesAreFixedInRange_Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selEnsureAttributesAreFixedInRange_Handle, range);
		}
	}

	[Export("invalidateAttributesInRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InvalidateAttributes(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selInvalidateAttributesInRange_Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selInvalidateAttributesInRange_Handle, range);
		}
	}

	[Export("processEditing")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ProcessEditing()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selProcessEditingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selProcessEditingHandle);
		}
	}

	[Export("removeLayoutManager:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveLayoutManager(NSLayoutManager obj)
	{
		NSApplication.EnsureUIThread();
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveLayoutManager_Handle, obj.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveLayoutManager_Handle, obj.Handle);
		}
	}

	internal virtual _NSTextStorageDelegate CreateInternalEventDelegateType()
	{
		return new _NSTextStorageDelegate();
	}

	internal _NSTextStorageDelegate EnsureNSTextStorageDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSTextStorageDelegate nSTextStorageDelegate = Delegate as _NSTextStorageDelegate;
		if (nSTextStorageDelegate == null)
		{
			nSTextStorageDelegate = (_NSTextStorageDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSTextStorageDelegate;
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

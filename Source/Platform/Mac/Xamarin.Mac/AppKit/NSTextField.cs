using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTextField", true)]
public class NSTextField : NSControl
{
	[Register]
	private sealed class _NSTextFieldDelegate : NSTextFieldDelegate
	{
		internal NSControlText textShouldBeginEditing;

		internal NSControlText textShouldEndEditing;

		internal NSControlTextError didFailToFormatString;

		internal EventHandler<NSControlTextErrorEventArgs> didFailToValidatePartialString;

		internal NSControlTextValidation isValidObject;

		internal NSControlCommand doCommandBySelector;

		internal NSControlTextFilter getCompletions;

		internal EventHandler editingEnded;

		internal EventHandler changed;

		internal EventHandler editingBegan;

		[Preserve(Conditional = true)]
		public override bool TextShouldBeginEditing(NSControl control, NSText fieldEditor)
		{
			return textShouldBeginEditing?.Invoke(control, fieldEditor) ?? true;
		}

		[Preserve(Conditional = true)]
		public override bool TextShouldEndEditing(NSControl control, NSText fieldEditor)
		{
			return textShouldEndEditing?.Invoke(control, fieldEditor) ?? true;
		}

		[Preserve(Conditional = true)]
		public override bool DidFailToFormatString(NSControl control, string str, string error)
		{
			return didFailToFormatString?.Invoke(control, str, error) ?? true;
		}

		[Preserve(Conditional = true)]
		public override void DidFailToValidatePartialString(NSControl control, string str, string error)
		{
			EventHandler<NSControlTextErrorEventArgs> eventHandler = didFailToValidatePartialString;
			if (eventHandler != null)
			{
				NSControlTextErrorEventArgs e = new NSControlTextErrorEventArgs(str, error);
				eventHandler(control, e);
			}
		}

		[Preserve(Conditional = true)]
		public override bool IsValidObject(NSControl control, NSObject objectToValidate)
		{
			return isValidObject?.Invoke(control, objectToValidate) ?? true;
		}

		[Preserve(Conditional = true)]
		public override bool DoCommandBySelector(NSControl control, NSTextView textView, Selector commandSelector)
		{
			return doCommandBySelector?.Invoke(control, textView, commandSelector) ?? false;
		}

		[Preserve(Conditional = true)]
		public override string[] GetCompletions(NSControl control, NSTextView textView, string[] words, NSRange charRange, long index)
		{
			NSControlTextFilter nSControlTextFilter = getCompletions;
			if (nSControlTextFilter != null)
			{
				return nSControlTextFilter(control, textView, words, charRange, index);
			}
			return new string[0];
		}

		[Preserve(Conditional = true)]
		public override void EditingEnded(NSNotification notification)
		{
			editingEnded?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void Changed(NSNotification notification)
		{
			changed?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void EditingBegan(NSNotification notification)
		{
			editingBegan?.Invoke(notification, EventArgs.Empty);
		}
	}

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	private static readonly IntPtr selDrawsBackgroundHandle = Selector.GetHandle("drawsBackground");

	private static readonly IntPtr selSetDrawsBackground_Handle = Selector.GetHandle("setDrawsBackground:");

	private static readonly IntPtr selTextColorHandle = Selector.GetHandle("textColor");

	private static readonly IntPtr selSetTextColor_Handle = Selector.GetHandle("setTextColor:");

	private static readonly IntPtr selIsBorderedHandle = Selector.GetHandle("isBordered");

	private static readonly IntPtr selSetBordered_Handle = Selector.GetHandle("setBordered:");

	private static readonly IntPtr selIsBezeledHandle = Selector.GetHandle("isBezeled");

	private static readonly IntPtr selSetBezeled_Handle = Selector.GetHandle("setBezeled:");

	private static readonly IntPtr selIsEditableHandle = Selector.GetHandle("isEditable");

	private static readonly IntPtr selSetEditable_Handle = Selector.GetHandle("setEditable:");

	private static readonly IntPtr selIsSelectableHandle = Selector.GetHandle("isSelectable");

	private static readonly IntPtr selSetSelectable_Handle = Selector.GetHandle("setSelectable:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selBezelStyleHandle = Selector.GetHandle("bezelStyle");

	private static readonly IntPtr selSetBezelStyle_Handle = Selector.GetHandle("setBezelStyle:");

	private static readonly IntPtr selAllowsEditingTextAttributesHandle = Selector.GetHandle("allowsEditingTextAttributes");

	private static readonly IntPtr selSetAllowsEditingTextAttributes_Handle = Selector.GetHandle("setAllowsEditingTextAttributes:");

	private static readonly IntPtr selImportsGraphicsHandle = Selector.GetHandle("importsGraphics");

	private static readonly IntPtr selSetImportsGraphics_Handle = Selector.GetHandle("setImportsGraphics:");

	private static readonly IntPtr selPreferredMaxLayoutWidthHandle = Selector.GetHandle("preferredMaxLayoutWidth");

	private static readonly IntPtr selSetPreferredMaxLayoutWidth_Handle = Selector.GetHandle("setPreferredMaxLayoutWidth:");

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	private static readonly IntPtr selSelectText_Handle = Selector.GetHandle("selectText:");

	private static readonly IntPtr selTextShouldBeginEditing_Handle = Selector.GetHandle("textShouldBeginEditing:");

	private static readonly IntPtr selTextShouldEndEditing_Handle = Selector.GetHandle("textShouldEndEditing:");

	private static readonly IntPtr selTextDidBeginEditing_Handle = Selector.GetHandle("textDidBeginEditing:");

	private static readonly IntPtr selTextDidEndEditing_Handle = Selector.GetHandle("textDidEndEditing:");

	private static readonly IntPtr selTextDidChange_Handle = Selector.GetHandle("textDidChange:");

	private static readonly IntPtr selAcceptsFirstResponderHandle = Selector.GetHandle("acceptsFirstResponder");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTextField");

	private object __mt_BackgroundColor_var;

	private object __mt_TextColor_var;

	private object __mt_WeakDelegate_var;

	public new NSTextFieldCell Cell
	{
		get
		{
			return (NSTextFieldCell)base.Cell;
		}
		set
		{
			base.Cell = value;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSColor BackgroundColor
	{
		[Export("backgroundColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_BackgroundColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle)))));
		}
		[Export("setBackgroundColor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
			}
			__mt_BackgroundColor_var = value;
		}
	}

	public virtual bool DrawsBackground
	{
		[Export("drawsBackground")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDrawsBackgroundHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDrawsBackgroundHandle);
		}
		[Export("setDrawsBackground:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDrawsBackground_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDrawsBackground_Handle, value);
			}
		}
	}

	public virtual NSColor TextColor
	{
		[Export("textColor")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColor)(__mt_TextColor_var = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextColorHandle))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTextColorHandle)))));
		}
		[Export("setTextColor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextColor_Handle, value.Handle);
			}
			__mt_TextColor_var = value;
		}
	}

	public virtual bool Bordered
	{
		[Export("isBordered")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsBorderedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsBorderedHandle);
		}
		[Export("setBordered:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetBordered_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBordered_Handle, value);
			}
		}
	}

	public virtual bool Bezeled
	{
		[Export("isBezeled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsBezeledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsBezeledHandle);
		}
		[Export("setBezeled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetBezeled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBezeled_Handle, value);
			}
		}
	}

	public virtual bool Editable
	{
		[Export("isEditable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEditableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEditableHandle);
		}
		[Export("setEditable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEditable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEditable_Handle, value);
			}
		}
	}

	public virtual bool Selectable
	{
		[Export("isSelectable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSelectableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSelectableHandle);
		}
		[Export("setSelectable:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSelectable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSelectable_Handle, value);
			}
		}
	}

	public virtual NSObject WeakDelegate
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

	public NSTextFieldDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSTextFieldDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual NSTextFieldBezelStyle BezelStyle
	{
		[Export("bezelStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTextFieldBezelStyle)Messaging.int_objc_msgSend(base.Handle, selBezelStyleHandle);
			}
			return (NSTextFieldBezelStyle)Messaging.int_objc_msgSendSuper(base.SuperHandle, selBezelStyleHandle);
		}
		[Export("setBezelStyle:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetBezelStyle_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetBezelStyle_Handle, (int)value);
			}
		}
	}

	public virtual bool AllowsEditingTextAttributes
	{
		[Export("allowsEditingTextAttributes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsEditingTextAttributesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsEditingTextAttributesHandle);
		}
		[Export("setAllowsEditingTextAttributes:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsEditingTextAttributes_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsEditingTextAttributes_Handle, value);
			}
		}
	}

	public virtual bool ImportsGraphics
	{
		[Export("importsGraphics")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selImportsGraphicsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selImportsGraphicsHandle);
		}
		[Export("setImportsGraphics:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetImportsGraphics_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetImportsGraphics_Handle, value);
			}
		}
	}

	[MountainLion]
	public virtual double PreferredMaxLayoutWidth
	{
		[MountainLion]
		[Export("preferredMaxLayoutWidth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selPreferredMaxLayoutWidthHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selPreferredMaxLayoutWidthHandle);
		}
		[MountainLion]
		[Export("setPreferredMaxLayoutWidth:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetPreferredMaxLayoutWidth_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetPreferredMaxLayoutWidth_Handle, value);
			}
		}
	}

	public NSControlText TextShouldBeginEditing
	{
		get
		{
			return EnsureNSTextFieldDelegate().textShouldBeginEditing;
		}
		set
		{
			EnsureNSTextFieldDelegate().textShouldBeginEditing = value;
		}
	}

	public NSControlText TextShouldEndEditing
	{
		get
		{
			return EnsureNSTextFieldDelegate().textShouldEndEditing;
		}
		set
		{
			EnsureNSTextFieldDelegate().textShouldEndEditing = value;
		}
	}

	public NSControlTextError DidFailToFormatString
	{
		get
		{
			return EnsureNSTextFieldDelegate().didFailToFormatString;
		}
		set
		{
			EnsureNSTextFieldDelegate().didFailToFormatString = value;
		}
	}

	public NSControlTextValidation IsValidObject
	{
		get
		{
			return EnsureNSTextFieldDelegate().isValidObject;
		}
		set
		{
			EnsureNSTextFieldDelegate().isValidObject = value;
		}
	}

	public NSControlCommand DoCommandBySelector
	{
		get
		{
			return EnsureNSTextFieldDelegate().doCommandBySelector;
		}
		set
		{
			EnsureNSTextFieldDelegate().doCommandBySelector = value;
		}
	}

	public NSControlTextFilter GetCompletions
	{
		get
		{
			return EnsureNSTextFieldDelegate().getCompletions;
		}
		set
		{
			EnsureNSTextFieldDelegate().getCompletions = value;
		}
	}

	public event EventHandler<NSControlTextErrorEventArgs> DidFailToValidatePartialString
	{
		add
		{
			_NSTextFieldDelegate nSTextFieldDelegate = EnsureNSTextFieldDelegate();
			nSTextFieldDelegate.didFailToValidatePartialString = (EventHandler<NSControlTextErrorEventArgs>)System.Delegate.Combine(nSTextFieldDelegate.didFailToValidatePartialString, value);
		}
		remove
		{
			_NSTextFieldDelegate nSTextFieldDelegate = EnsureNSTextFieldDelegate();
			nSTextFieldDelegate.didFailToValidatePartialString = (EventHandler<NSControlTextErrorEventArgs>)System.Delegate.Remove(nSTextFieldDelegate.didFailToValidatePartialString, value);
		}
	}

	public event EventHandler EditingEnded
	{
		add
		{
			_NSTextFieldDelegate nSTextFieldDelegate = EnsureNSTextFieldDelegate();
			nSTextFieldDelegate.editingEnded = (EventHandler)System.Delegate.Combine(nSTextFieldDelegate.editingEnded, value);
		}
		remove
		{
			_NSTextFieldDelegate nSTextFieldDelegate = EnsureNSTextFieldDelegate();
			nSTextFieldDelegate.editingEnded = (EventHandler)System.Delegate.Remove(nSTextFieldDelegate.editingEnded, value);
		}
	}

	public event EventHandler Changed
	{
		add
		{
			_NSTextFieldDelegate nSTextFieldDelegate = EnsureNSTextFieldDelegate();
			nSTextFieldDelegate.changed = (EventHandler)System.Delegate.Combine(nSTextFieldDelegate.changed, value);
		}
		remove
		{
			_NSTextFieldDelegate nSTextFieldDelegate = EnsureNSTextFieldDelegate();
			nSTextFieldDelegate.changed = (EventHandler)System.Delegate.Remove(nSTextFieldDelegate.changed, value);
		}
	}

	public event EventHandler EditingBegan
	{
		add
		{
			_NSTextFieldDelegate nSTextFieldDelegate = EnsureNSTextFieldDelegate();
			nSTextFieldDelegate.editingBegan = (EventHandler)System.Delegate.Combine(nSTextFieldDelegate.editingBegan, value);
		}
		remove
		{
			_NSTextFieldDelegate nSTextFieldDelegate = EnsureNSTextFieldDelegate();
			nSTextFieldDelegate.editingBegan = (EventHandler)System.Delegate.Remove(nSTextFieldDelegate.editingBegan, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextField()
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
	public NSTextField(NSCoder coder)
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
	public NSTextField(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTextField(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	public NSTextField(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect);
		}
	}

	[Export("selectText:")]
	public virtual void SelectText(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSelectText_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSelectText_Handle, sender.Handle);
		}
	}

	[Export("textShouldBeginEditing:")]
	public virtual bool ShouldBeginEditing(NSText textObject)
	{
		NSApplication.EnsureUIThread();
		if (textObject == null)
		{
			throw new ArgumentNullException("textObject");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selTextShouldBeginEditing_Handle, textObject.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextShouldBeginEditing_Handle, textObject.Handle);
	}

	[Export("textShouldEndEditing:")]
	public virtual bool ShouldEndEditing(NSText textObject)
	{
		NSApplication.EnsureUIThread();
		if (textObject == null)
		{
			throw new ArgumentNullException("textObject");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selTextShouldEndEditing_Handle, textObject.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextShouldEndEditing_Handle, textObject.Handle);
	}

	[Export("textDidBeginEditing:")]
	public virtual void DidBeginEditing(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTextDidBeginEditing_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextDidBeginEditing_Handle, notification.Handle);
		}
	}

	[Export("textDidEndEditing:")]
	public virtual void DidEndEditing(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTextDidEndEditing_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextDidEndEditing_Handle, notification.Handle);
		}
	}

	[Export("textDidChange:")]
	public virtual void DidChange(NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTextDidChange_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextDidChange_Handle, notification.Handle);
		}
	}

	[Export("acceptsFirstResponder")]
	public new virtual bool AcceptsFirstResponder()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selAcceptsFirstResponderHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAcceptsFirstResponderHandle);
	}

	private _NSTextFieldDelegate EnsureNSTextFieldDelegate()
	{
		NSTextFieldDelegate nSTextFieldDelegate = Delegate;
		if (nSTextFieldDelegate == null || !(nSTextFieldDelegate is _NSTextFieldDelegate))
		{
			nSTextFieldDelegate = (Delegate = new _NSTextFieldDelegate());
		}
		return (_NSTextFieldDelegate)nSTextFieldDelegate;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_BackgroundColor_var = null;
			__mt_TextColor_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}

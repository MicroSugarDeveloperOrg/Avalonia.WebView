using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTextStorage", true)]
public class NSTextStorage : NSMutableAttributedString
{
	[Register]
	private sealed class _NSTextStorageDelegate : NSTextStorageDelegate
	{
		internal EventHandler textStorageWillProcessEditing;

		internal EventHandler textStorageDidProcessEditing;

		[Preserve(Conditional = true)]
		public override void TextStorageWillProcessEditing(NSNotification notification)
		{
			textStorageWillProcessEditing?.Invoke(notification, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void TextStorageDidProcessEditing(NSNotification notification)
		{
			textStorageDidProcessEditing?.Invoke(notification, EventArgs.Empty);
		}
	}

	private static readonly IntPtr selLayoutManagersHandle = Selector.GetHandle("layoutManagers");

	private static readonly IntPtr selFixesAttributesLazilyHandle = Selector.GetHandle("fixesAttributesLazily");

	private static readonly IntPtr selEditedMaskHandle = Selector.GetHandle("editedMask");

	private static readonly IntPtr selEditedRangeHandle = Selector.GetHandle("editedRange");

	private static readonly IntPtr selChangeInLengthHandle = Selector.GetHandle("changeInLength");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selAddLayoutManager_Handle = Selector.GetHandle("addLayoutManager:");

	private static readonly IntPtr selRemoveLayoutManager_Handle = Selector.GetHandle("removeLayoutManager:");

	private static readonly IntPtr selEditedRangeChangeInLength_Handle = Selector.GetHandle("edited:range:changeInLength:");

	private static readonly IntPtr selProcessEditingHandle = Selector.GetHandle("processEditing");

	private static readonly IntPtr selInvalidateAttributesInRange_Handle = Selector.GetHandle("invalidateAttributesInRange:");

	private static readonly IntPtr selEnsureAttributesAreFixedInRange_Handle = Selector.GetHandle("ensureAttributesAreFixedInRange:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTextStorage");

	private object __mt_LayoutManagers_var;

	private object __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSLayoutManager[] LayoutManagers
	{
		[Export("layoutManagers")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSLayoutManager[])(__mt_LayoutManagers_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSLayoutManager>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLayoutManagersHandle)) : NSArray.ArrayFromHandle<NSLayoutManager>(Messaging.IntPtr_objc_msgSend(base.Handle, selLayoutManagersHandle))));
		}
	}

	public virtual bool FixesAttributesLazily
	{
		[Export("fixesAttributesLazily")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selFixesAttributesLazilyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selFixesAttributesLazilyHandle);
		}
	}

	public virtual NSTextStorageEditedFlags EditedMask
	{
		[Export("editedMask")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTextStorageEditedFlags)Messaging.UInt64_objc_msgSend(base.Handle, selEditedMaskHandle);
			}
			return (NSTextStorageEditedFlags)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selEditedMaskHandle);
		}
	}

	public virtual NSRange EditedRange
	{
		[Export("editedRange")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.NSRange_objc_msgSend(base.Handle, selEditedRangeHandle);
			}
			return Messaging.NSRange_objc_msgSendSuper(base.SuperHandle, selEditedRangeHandle);
		}
	}

	public virtual long ChangeInLength
	{
		[Export("changeInLength")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selChangeInLengthHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selChangeInLengthHandle);
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
			__mt_WeakDelegate_var = value;
		}
	}

	public NSTextStorageDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSTextStorageDelegate;
		}
		set
		{
			WeakDelegate = value;
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextStorage()
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
	public NSTextStorage(NSCoder coder)
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
	public NSTextStorage(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTextStorage(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addLayoutManager:")]
	public virtual void AddLayoutManager(NSLayoutManager obj)
	{
		NSApplication.EnsureUIThread();
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddLayoutManager_Handle, obj.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddLayoutManager_Handle, obj.Handle);
		}
		_ = LayoutManagers;
	}

	[Export("removeLayoutManager:")]
	public virtual void RemoveLayoutManager(NSLayoutManager obj)
	{
		NSApplication.EnsureUIThread();
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveLayoutManager_Handle, obj.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveLayoutManager_Handle, obj.Handle);
		}
		_ = LayoutManagers;
	}

	[Export("edited:range:changeInLength:")]
	public virtual void Edited(ulong editedMask, NSRange range, long delta)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_NSRange_Int64(base.Handle, selEditedRangeChangeInLength_Handle, editedMask, range, delta);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_NSRange_Int64(base.SuperHandle, selEditedRangeChangeInLength_Handle, editedMask, range, delta);
		}
	}

	[Export("processEditing")]
	public virtual void ProcessEditing()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selProcessEditingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selProcessEditingHandle);
		}
	}

	[Export("invalidateAttributesInRange:")]
	public virtual void InvalidateAttributes(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selInvalidateAttributesInRange_Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selInvalidateAttributesInRange_Handle, range);
		}
	}

	[Export("ensureAttributesAreFixedInRange:")]
	public virtual void EnsureAttributesAreFixed(NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selEnsureAttributesAreFixedInRange_Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selEnsureAttributesAreFixedInRange_Handle, range);
		}
	}

	private _NSTextStorageDelegate EnsureNSTextStorageDelegate()
	{
		NSTextStorageDelegate nSTextStorageDelegate = Delegate;
		if (nSTextStorageDelegate == null || !(nSTextStorageDelegate is _NSTextStorageDelegate))
		{
			nSTextStorageDelegate = (Delegate = new _NSTextStorageDelegate());
		}
		return (_NSTextStorageDelegate)nSTextStorageDelegate;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_LayoutManagers_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}

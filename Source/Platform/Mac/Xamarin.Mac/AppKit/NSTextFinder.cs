using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTextFinder", true)]
public class NSTextFinder : NSObject, INSCoding, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelFindIndicator = "cancelFindIndicator";

	private static readonly IntPtr selCancelFindIndicatorHandle = Selector.GetHandle("cancelFindIndicator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawIncrementalMatchHighlightInRect_ = "drawIncrementalMatchHighlightInRect:";

	private static readonly IntPtr selDrawIncrementalMatchHighlightInRect_Handle = Selector.GetHandle("drawIncrementalMatchHighlightInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFindIndicatorNeedsUpdate = "findIndicatorNeedsUpdate";

	private static readonly IntPtr selFindIndicatorNeedsUpdateHandle = Selector.GetHandle("findIndicatorNeedsUpdate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncrementalMatchRanges = "incrementalMatchRanges";

	private static readonly IntPtr selIncrementalMatchRangesHandle = Selector.GetHandle("incrementalMatchRanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsIncrementalSearchingEnabled = "isIncrementalSearchingEnabled";

	private static readonly IntPtr selIsIncrementalSearchingEnabledHandle = Selector.GetHandle("isIncrementalSearchingEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNoteClientStringWillChange = "noteClientStringWillChange";

	private static readonly IntPtr selNoteClientStringWillChangeHandle = Selector.GetHandle("noteClientStringWillChange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformAction_ = "performAction:";

	private static readonly IntPtr selPerformAction_Handle = Selector.GetHandle("performAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClient_ = "setClient:";

	private static readonly IntPtr selSetClient_Handle = Selector.GetHandle("setClient:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFindBarContainer_ = "setFindBarContainer:";

	private static readonly IntPtr selSetFindBarContainer_Handle = Selector.GetHandle("setFindBarContainer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFindIndicatorNeedsUpdate_ = "setFindIndicatorNeedsUpdate:";

	private static readonly IntPtr selSetFindIndicatorNeedsUpdate_Handle = Selector.GetHandle("setFindIndicatorNeedsUpdate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIncrementalSearchingEnabled_ = "setIncrementalSearchingEnabled:";

	private static readonly IntPtr selSetIncrementalSearchingEnabled_Handle = Selector.GetHandle("setIncrementalSearchingEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidateAction_ = "validateAction:";

	private static readonly IntPtr selValidateAction_Handle = Selector.GetHandle("validateAction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTextFinder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Client_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_FindBarContainer_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSTextFinderClient Client
	{
		[Export("setClient:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetClient_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetClient_Handle, value.Handle);
			}
			MarkDirty();
			__mt_Client_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSTextFinderBarContainer FindBarContainer
	{
		[Export("setFindBarContainer:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFindBarContainer_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFindBarContainer_Handle, value.Handle);
			}
			MarkDirty();
			__mt_FindBarContainer_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool FindIndicatorNeedsUpdate
	{
		[Export("findIndicatorNeedsUpdate")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selFindIndicatorNeedsUpdateHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selFindIndicatorNeedsUpdateHandle);
		}
		[Export("setFindIndicatorNeedsUpdate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFindIndicatorNeedsUpdate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFindIndicatorNeedsUpdate_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray IncrementalMatchRanges
	{
		[Export("incrementalMatchRanges", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selIncrementalMatchRangesHandle));
			}
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIncrementalMatchRangesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IncrementalSearchingEnabled
	{
		[Export("isIncrementalSearchingEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsIncrementalSearchingEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsIncrementalSearchingEnabledHandle);
		}
		[Export("setIncrementalSearchingEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIncrementalSearchingEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIncrementalSearchingEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextFinder()
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
	public NSTextFinder(NSCoder coder)
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
	protected NSTextFinder(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTextFinder(IntPtr handle)
		: base(handle)
	{
	}

	[Export("cancelFindIndicator")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelFindIndicator()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelFindIndicatorHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelFindIndicatorHandle);
		}
	}

	[Export("drawIncrementalMatchHighlightInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DrawIncrementalMatchHighlightInRect(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_CGRect(class_ptr, selDrawIncrementalMatchHighlightInRect_Handle, rect);
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("noteClientStringWillChange")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void NoteClientStringWillChange()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selNoteClientStringWillChangeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selNoteClientStringWillChangeHandle);
		}
	}

	[Export("performAction:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PerformAction(NSTextFinderAction op)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selPerformAction_Handle, (long)op);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selPerformAction_Handle, (long)op);
		}
	}

	[Export("validateAction:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ValidateAction(NSTextFinderAction op)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selValidateAction_Handle, (long)op);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selValidateAction_Handle, (long)op);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Client_var = null;
			__mt_FindBarContainer_var = null;
		}
	}
}

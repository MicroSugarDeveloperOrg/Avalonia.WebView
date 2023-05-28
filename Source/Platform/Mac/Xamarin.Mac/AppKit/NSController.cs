using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSController", true)]
public class NSController : NSObject, INSCoding, INativeObject, IDisposable, INSEditorRegistration
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommitEditing = "commitEditing";

	private static readonly IntPtr selCommitEditingHandle = Selector.GetHandle("commitEditing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCommitEditingWithDelegate_DidCommitSelector_ContextInfo_ = "commitEditingWithDelegate:didCommitSelector:contextInfo:";

	private static readonly IntPtr selCommitEditingWithDelegate_DidCommitSelector_ContextInfo_Handle = Selector.GetHandle("commitEditingWithDelegate:didCommitSelector:contextInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscardEditing = "discardEditing";

	private static readonly IntPtr selDiscardEditingHandle = Selector.GetHandle("discardEditing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEditing = "isEditing";

	private static readonly IntPtr selIsEditingHandle = Selector.GetHandle("isEditing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectDidBeginEditing_ = "objectDidBeginEditing:";

	private static readonly IntPtr selObjectDidBeginEditing_Handle = Selector.GetHandle("objectDidBeginEditing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectDidEndEditing_ = "objectDidEndEditing:";

	private static readonly IntPtr selObjectDidEndEditing_Handle = Selector.GetHandle("objectDidEndEditing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSController");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool CommitEditing
	{
		[Export("commitEditing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCommitEditingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCommitEditingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEditing
	{
		[Export("isEditing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEditingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEditingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSController()
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
	public NSController(NSCoder coder)
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
	protected NSController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("commitEditingWithDelegate:didCommitSelector:contextInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CommitEditingWithDelegate(NSObject? delegate1, Selector? didCommitSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selCommitEditingWithDelegate_DidCommitSelector_ContextInfo_Handle, delegate1?.Handle ?? IntPtr.Zero, (didCommitSelector == null) ? IntPtr.Zero : didCommitSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCommitEditingWithDelegate_DidCommitSelector_ContextInfo_Handle, delegate1?.Handle ?? IntPtr.Zero, (didCommitSelector == null) ? IntPtr.Zero : didCommitSelector.Handle, contextInfo);
		}
	}

	[Export("discardEditing")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DiscardEditing()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDiscardEditingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDiscardEditingHandle);
		}
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

	[Export("objectDidBeginEditing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ObjectDidBeginEditing(NSObject editor)
	{
		NSApplication.EnsureUIThread();
		if (editor == null)
		{
			throw new ArgumentNullException("editor");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selObjectDidBeginEditing_Handle, editor.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectDidBeginEditing_Handle, editor.Handle);
		}
	}

	[Export("objectDidEndEditing:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void ObjectDidEndEditing(NSObject editor)
	{
		NSApplication.EnsureUIThread();
		if (editor == null)
		{
			throw new ArgumentNullException("editor");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selObjectDidEndEditing_Handle, editor.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectDidEndEditing_Handle, editor.Handle);
		}
	}
}

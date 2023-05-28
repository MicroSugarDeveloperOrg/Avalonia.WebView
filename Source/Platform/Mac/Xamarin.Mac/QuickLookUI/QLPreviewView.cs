using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace QuickLookUI;

[Register("QLPreviewView", true)]
public class QLPreviewView : NSView
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutostarts = "autostarts";

	private static readonly IntPtr selAutostartsHandle = Selector.GetHandle("autostarts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClose = "close";

	private static readonly IntPtr selCloseHandle = Selector.GetHandle("close");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayState = "displayState";

	private static readonly IntPtr selDisplayStateHandle = Selector.GetHandle("displayState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_Style_ = "initWithFrame:style:";

	private static readonly IntPtr selInitWithFrame_Style_Handle = Selector.GetHandle("initWithFrame:style:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreviewItem = "previewItem";

	private static readonly IntPtr selPreviewItemHandle = Selector.GetHandle("previewItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRefreshPreviewItem = "refreshPreviewItem";

	private static readonly IntPtr selRefreshPreviewItemHandle = Selector.GetHandle("refreshPreviewItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutostarts_ = "setAutostarts:";

	private static readonly IntPtr selSetAutostarts_Handle = Selector.GetHandle("setAutostarts:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisplayState_ = "setDisplayState:";

	private static readonly IntPtr selSetDisplayState_Handle = Selector.GetHandle("setDisplayState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreviewItem_ = "setPreviewItem:";

	private static readonly IntPtr selSetPreviewItem_Handle = Selector.GetHandle("setPreviewItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldCloseWithWindow_ = "setShouldCloseWithWindow:";

	private static readonly IntPtr selSetShouldCloseWithWindow_Handle = Selector.GetHandle("setShouldCloseWithWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldCloseWithWindow = "shouldCloseWithWindow";

	private static readonly IntPtr selShouldCloseWithWindowHandle = Selector.GetHandle("shouldCloseWithWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QLPreviewView");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Autostarts
	{
		[Export("autostarts")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutostartsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutostartsHandle);
		}
		[Export("setAutostarts:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutostarts_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutostarts_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject DisplayState
	{
		[Export("displayState", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDisplayStateHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDisplayStateHandle));
		}
		[Export("setDisplayState:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDisplayState_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDisplayState_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IQLPreviewItem PreviewItem
	{
		[Export("previewItem", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IQLPreviewItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selPreviewItemHandle), owns: false);
			}
			return Runtime.GetINativeObject<IQLPreviewItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreviewItemHandle), owns: false);
		}
		[Export("setPreviewItem:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPreviewItem_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPreviewItem_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldCloseWithWindow
	{
		[Export("shouldCloseWithWindow")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldCloseWithWindowHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldCloseWithWindowHandle);
		}
		[Export("setShouldCloseWithWindow:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldCloseWithWindow_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldCloseWithWindow_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QLPreviewView()
		: base(NSObjectFlag.Empty)
	{
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
	public QLPreviewView(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
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
	protected QLPreviewView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QLPreviewView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:style:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public QLPreviewView(CGRect frame, QLPreviewViewStyle style)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect_UInt64(base.Handle, selInitWithFrame_Style_Handle, frame, (ulong)style), "initWithFrame:style:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect_UInt64(base.SuperHandle, selInitWithFrame_Style_Handle, frame, (ulong)style), "initWithFrame:style:");
		}
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public QLPreviewView(CGRect frame)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frame), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frame), "initWithFrame:");
		}
	}

	[Export("close")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Close()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCloseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCloseHandle);
		}
	}

	[Export("refreshPreviewItem")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RefreshPreviewItem()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRefreshPreviewItemHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRefreshPreviewItemHandle);
		}
	}
}

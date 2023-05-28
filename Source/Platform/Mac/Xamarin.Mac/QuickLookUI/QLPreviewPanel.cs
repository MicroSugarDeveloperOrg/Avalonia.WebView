using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace QuickLookUI;

[Register("QLPreviewPanel", true)]
public class QLPreviewPanel : NSPanel
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentController = "currentController";

	private static readonly IntPtr selCurrentControllerHandle = Selector.GetHandle("currentController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentPreviewItem = "currentPreviewItem";

	private static readonly IntPtr selCurrentPreviewItemHandle = Selector.GetHandle("currentPreviewItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentPreviewItemIndex = "currentPreviewItemIndex";

	private static readonly IntPtr selCurrentPreviewItemIndexHandle = Selector.GetHandle("currentPreviewItemIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataSource = "dataSource";

	private static readonly IntPtr selDataSourceHandle = Selector.GetHandle("dataSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisplayState = "displayState";

	private static readonly IntPtr selDisplayStateHandle = Selector.GetHandle("displayState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnterFullScreenMode_WithOptions_ = "enterFullScreenMode:withOptions:";

	private static readonly IntPtr selEnterFullScreenMode_WithOptions_Handle = Selector.GetHandle("enterFullScreenMode:withOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExitFullScreenModeWithOptions_ = "exitFullScreenModeWithOptions:";

	private static readonly IntPtr selExitFullScreenModeWithOptions_Handle = Selector.GetHandle("exitFullScreenModeWithOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsInFullScreenMode = "isInFullScreenMode";

	private static readonly IntPtr selIsInFullScreenModeHandle = Selector.GetHandle("isInFullScreenMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRefreshCurrentPreviewItem = "refreshCurrentPreviewItem";

	private static readonly IntPtr selRefreshCurrentPreviewItemHandle = Selector.GetHandle("refreshCurrentPreviewItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadData = "reloadData";

	private static readonly IntPtr selReloadDataHandle = Selector.GetHandle("reloadData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentPreviewItemIndex_ = "setCurrentPreviewItemIndex:";

	private static readonly IntPtr selSetCurrentPreviewItemIndex_Handle = Selector.GetHandle("setCurrentPreviewItemIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDataSource_ = "setDataSource:";

	private static readonly IntPtr selSetDataSource_Handle = Selector.GetHandle("setDataSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDisplayState_ = "setDisplayState:";

	private static readonly IntPtr selSetDisplayState_Handle = Selector.GetHandle("setDisplayState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedPreviewPanel = "sharedPreviewPanel";

	private static readonly IntPtr selSharedPreviewPanelHandle = Selector.GetHandle("sharedPreviewPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedPreviewPanelExists = "sharedPreviewPanelExists";

	private static readonly IntPtr selSharedPreviewPanelExistsHandle = Selector.GetHandle("sharedPreviewPanelExists");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateController = "updateController";

	private static readonly IntPtr selUpdateControllerHandle = Selector.GetHandle("updateController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QLPreviewPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDataSource_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject CurrentController
	{
		[Export("currentController")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentControllerHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentControllerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IQLPreviewItem CurrentPreviewItem
	{
		[Export("currentPreviewItem")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IQLPreviewItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentPreviewItemHandle), owns: false);
			}
			return Runtime.GetINativeObject<IQLPreviewItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentPreviewItemHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint CurrentPreviewItemIndex
	{
		[Export("currentPreviewItemIndex")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selCurrentPreviewItemIndexHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selCurrentPreviewItemIndexHandle);
		}
		[Export("setCurrentPreviewItemIndex:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetCurrentPreviewItemIndex_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetCurrentPreviewItemIndex_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IQLPreviewPanelDataSource? DataSource
	{
		get
		{
			return WeakDataSource as IQLPreviewPanelDataSource;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDataSource = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new IQLPreviewPanelDelegate? Delegate
	{
		get
		{
			return WeakDelegate as IQLPreviewPanelDelegate;
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
	public virtual bool InFullScreenMode
	{
		[Export("isInFullScreenMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsInFullScreenModeHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsInFullScreenModeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDataSource
	{
		[Export("dataSource", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataSourceHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDataSourceHandle)));
			MarkDirty();
			__mt_WeakDataSource_var = nSObject;
			return nSObject;
		}
		[Export("setDataSource:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDataSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDataSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDataSource_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
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

	public bool EnterFullScreenMode()
	{
		return EnterFullScreenMode(null, null);
	}

	public void ExitFullScreenModeWithOptions()
	{
		ExitFullScreenModeWithOptions(null);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QLPreviewPanel()
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
	public QLPreviewPanel(NSCoder coder)
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
	protected QLPreviewPanel(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QLPreviewPanel(IntPtr handle)
		: base(handle)
	{
	}

	[Export("enterFullScreenMode:withOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool EnterFullScreenMode(NSScreen? screen, NSDictionary? options)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selEnterFullScreenMode_WithOptions_Handle, screen?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEnterFullScreenMode_WithOptions_Handle, screen?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero);
	}

	[Export("exitFullScreenModeWithOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ExitFullScreenModeWithOptions(NSDictionary? options)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selExitFullScreenModeWithOptions_Handle, options?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selExitFullScreenModeWithOptions_Handle, options?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("refreshCurrentPreviewItem")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RefreshCurrentPreviewItem()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRefreshCurrentPreviewItemHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRefreshCurrentPreviewItemHandle);
		}
	}

	[Export("reloadData")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadData()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadDataHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadDataHandle);
		}
	}

	[Export("sharedPreviewPanel")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static QLPreviewPanel SharedPreviewPanel()
	{
		return Runtime.GetNSObject<QLPreviewPanel>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedPreviewPanelHandle));
	}

	[Export("sharedPreviewPanelExists")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool SharedPreviewPanelExists()
	{
		return Messaging.bool_objc_msgSend(class_ptr, selSharedPreviewPanelExistsHandle);
	}

	[Export("updateController")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateController()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateControllerHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateControllerHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDataSource_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}

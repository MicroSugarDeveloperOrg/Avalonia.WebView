using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSUndoManager", true)]
public class NSUndoManager : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveCheckpoint(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(CheckpointNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveCheckpoint(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(CheckpointNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidCloseUndoGroup(EventHandler<NSUndoManagerCloseUndoGroupEventArgs> handler)
		{
			EventHandler<NSUndoManagerCloseUndoGroupEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidCloseUndoGroupNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSUndoManagerCloseUndoGroupEventArgs(notification));
			});
		}

		public static NSObject ObserveDidCloseUndoGroup(NSObject objectToObserve, EventHandler<NSUndoManagerCloseUndoGroupEventArgs> handler)
		{
			EventHandler<NSUndoManagerCloseUndoGroupEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidCloseUndoGroupNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSUndoManagerCloseUndoGroupEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidOpenUndoGroup(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidOpenUndoGroupNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidOpenUndoGroup(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidOpenUndoGroupNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidRedoChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidRedoChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidRedoChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidRedoChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidUndoChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidUndoChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidUndoChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidUndoChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillCloseUndoGroup(EventHandler<NSUndoManagerCloseUndoGroupEventArgs> handler)
		{
			EventHandler<NSUndoManagerCloseUndoGroupEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillCloseUndoGroupNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSUndoManagerCloseUndoGroupEventArgs(notification));
			});
		}

		public static NSObject ObserveWillCloseUndoGroup(NSObject objectToObserve, EventHandler<NSUndoManagerCloseUndoGroupEventArgs> handler)
		{
			EventHandler<NSUndoManagerCloseUndoGroupEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillCloseUndoGroupNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSUndoManagerCloseUndoGroupEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillRedoChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillRedoChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillRedoChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillRedoChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWillUndoChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillUndoChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillUndoChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WillUndoChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginUndoGrouping = "beginUndoGrouping";

	private static readonly IntPtr selBeginUndoGroupingHandle = Selector.GetHandle("beginUndoGrouping");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanRedo = "canRedo";

	private static readonly IntPtr selCanRedoHandle = Selector.GetHandle("canRedo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanUndo = "canUndo";

	private static readonly IntPtr selCanUndoHandle = Selector.GetHandle("canUndo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisableUndoRegistration = "disableUndoRegistration";

	private static readonly IntPtr selDisableUndoRegistrationHandle = Selector.GetHandle("disableUndoRegistration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnableUndoRegistration = "enableUndoRegistration";

	private static readonly IntPtr selEnableUndoRegistrationHandle = Selector.GetHandle("enableUndoRegistration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndUndoGrouping = "endUndoGrouping";

	private static readonly IntPtr selEndUndoGroupingHandle = Selector.GetHandle("endUndoGrouping");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroupingLevel = "groupingLevel";

	private static readonly IntPtr selGroupingLevelHandle = Selector.GetHandle("groupingLevel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroupsByEvent = "groupsByEvent";

	private static readonly IntPtr selGroupsByEventHandle = Selector.GetHandle("groupsByEvent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsRedoing = "isRedoing";

	private static readonly IntPtr selIsRedoingHandle = Selector.GetHandle("isRedoing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsUndoRegistrationEnabled = "isUndoRegistrationEnabled";

	private static readonly IntPtr selIsUndoRegistrationEnabledHandle = Selector.GetHandle("isUndoRegistrationEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsUndoing = "isUndoing";

	private static readonly IntPtr selIsUndoingHandle = Selector.GetHandle("isUndoing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLevelsOfUndo = "levelsOfUndo";

	private static readonly IntPtr selLevelsOfUndoHandle = Selector.GetHandle("levelsOfUndo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareWithInvocationTarget_ = "prepareWithInvocationTarget:";

	private static readonly IntPtr selPrepareWithInvocationTarget_Handle = Selector.GetHandle("prepareWithInvocationTarget:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRedo = "redo";

	private static readonly IntPtr selRedoHandle = Selector.GetHandle("redo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRedoActionIsDiscardable = "redoActionIsDiscardable";

	private static readonly IntPtr selRedoActionIsDiscardableHandle = Selector.GetHandle("redoActionIsDiscardable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRedoActionName = "redoActionName";

	private static readonly IntPtr selRedoActionNameHandle = Selector.GetHandle("redoActionName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRedoMenuItemTitle = "redoMenuItemTitle";

	private static readonly IntPtr selRedoMenuItemTitleHandle = Selector.GetHandle("redoMenuItemTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRedoMenuTitleForUndoActionName_ = "redoMenuTitleForUndoActionName:";

	private static readonly IntPtr selRedoMenuTitleForUndoActionName_Handle = Selector.GetHandle("redoMenuTitleForUndoActionName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterUndoWithTarget_Handler_ = "registerUndoWithTarget:handler:";

	private static readonly IntPtr selRegisterUndoWithTarget_Handler_Handle = Selector.GetHandle("registerUndoWithTarget:handler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterUndoWithTarget_Selector_Object_ = "registerUndoWithTarget:selector:object:";

	private static readonly IntPtr selRegisterUndoWithTarget_Selector_Object_Handle = Selector.GetHandle("registerUndoWithTarget:selector:object:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllActions = "removeAllActions";

	private static readonly IntPtr selRemoveAllActionsHandle = Selector.GetHandle("removeAllActions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllActionsWithTarget_ = "removeAllActionsWithTarget:";

	private static readonly IntPtr selRemoveAllActionsWithTarget_Handle = Selector.GetHandle("removeAllActionsWithTarget:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRunLoopModes = "runLoopModes";

	private static readonly IntPtr selRunLoopModesHandle = Selector.GetHandle("runLoopModes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetActionIsDiscardable_ = "setActionIsDiscardable:";

	private static readonly IntPtr selSetActionIsDiscardable_Handle = Selector.GetHandle("setActionIsDiscardable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetActionName_ = "setActionName:";

	private static readonly IntPtr selSetActionName_Handle = Selector.GetHandle("setActionName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGroupsByEvent_ = "setGroupsByEvent:";

	private static readonly IntPtr selSetGroupsByEvent_Handle = Selector.GetHandle("setGroupsByEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLevelsOfUndo_ = "setLevelsOfUndo:";

	private static readonly IntPtr selSetLevelsOfUndo_Handle = Selector.GetHandle("setLevelsOfUndo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRunLoopModes_ = "setRunLoopModes:";

	private static readonly IntPtr selSetRunLoopModes_Handle = Selector.GetHandle("setRunLoopModes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUndo = "undo";

	private static readonly IntPtr selUndoHandle = Selector.GetHandle("undo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUndoActionIsDiscardable = "undoActionIsDiscardable";

	private static readonly IntPtr selUndoActionIsDiscardableHandle = Selector.GetHandle("undoActionIsDiscardable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUndoActionName = "undoActionName";

	private static readonly IntPtr selUndoActionNameHandle = Selector.GetHandle("undoActionName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUndoMenuItemTitle = "undoMenuItemTitle";

	private static readonly IntPtr selUndoMenuItemTitleHandle = Selector.GetHandle("undoMenuItemTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUndoMenuTitleForUndoActionName_ = "undoMenuTitleForUndoActionName:";

	private static readonly IntPtr selUndoMenuTitleForUndoActionName_Handle = Selector.GetHandle("undoMenuTitleForUndoActionName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUndoNestedGroup = "undoNestedGroup";

	private static readonly IntPtr selUndoNestedGroupHandle = Selector.GetHandle("undoNestedGroup");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSUndoManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CheckpointNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidCloseUndoGroupNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidOpenUndoGroupNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidRedoChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidUndoChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GroupIsDiscardableKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillCloseUndoGroupNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillRedoChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WillUndoChangeNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanRedo
	{
		[Export("canRedo")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanRedoHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanRedoHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanUndo
	{
		[Export("canUndo")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanUndoHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanUndoHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GroupingLevel
	{
		[Export("groupingLevel")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selGroupingLevelHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selGroupingLevelHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GroupsByEvent
	{
		[Export("groupsByEvent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selGroupsByEventHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selGroupsByEventHandle);
		}
		[Export("setGroupsByEvent:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetGroupsByEvent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetGroupsByEvent_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsRedoing
	{
		[Export("isRedoing")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRedoingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRedoingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsUndoRegistrationEnabled
	{
		[Export("isUndoRegistrationEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsUndoRegistrationEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsUndoRegistrationEnabledHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsUndoing
	{
		[Export("isUndoing")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsUndoingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsUndoingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint LevelsOfUndo
	{
		[Export("levelsOfUndo")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selLevelsOfUndoHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selLevelsOfUndoHandle);
		}
		[Export("setLevelsOfUndo:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetLevelsOfUndo_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetLevelsOfUndo_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RedoActionIsDiscardable
	{
		[Export("redoActionIsDiscardable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRedoActionIsDiscardableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRedoActionIsDiscardableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string RedoActionName
	{
		[Export("redoActionName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRedoActionNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRedoActionNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string RedoMenuItemTitle
	{
		[Export("redoMenuItemTitle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRedoMenuItemTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRedoMenuItemTitleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] RunLoopModes
	{
		[Export("runLoopModes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRunLoopModesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRunLoopModesHandle));
		}
		[Export("setRunLoopModes:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRunLoopModes_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRunLoopModes_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UndoActionIsDiscardable
	{
		[Export("undoActionIsDiscardable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUndoActionIsDiscardableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUndoActionIsDiscardableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string UndoActionName
	{
		[Export("undoActionName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUndoActionNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUndoActionNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string UndoMenuItemTitle
	{
		[Export("undoMenuItemTitle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUndoMenuItemTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUndoMenuItemTitleHandle));
		}
	}

	[Field("NSUndoManagerCheckpointNotification", "Foundation")]
	[Advice("Use NSUndoManager.Notifications.ObserveCheckpoint helper method instead.")]
	public static NSString CheckpointNotification
	{
		get
		{
			if (_CheckpointNotification == null)
			{
				_CheckpointNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSUndoManagerCheckpointNotification");
			}
			return _CheckpointNotification;
		}
	}

	[Field("NSUndoManagerDidCloseUndoGroupNotification", "Foundation")]
	[Advice("Use NSUndoManager.Notifications.ObserveDidCloseUndoGroup helper method instead.")]
	public static NSString DidCloseUndoGroupNotification
	{
		get
		{
			if (_DidCloseUndoGroupNotification == null)
			{
				_DidCloseUndoGroupNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSUndoManagerDidCloseUndoGroupNotification");
			}
			return _DidCloseUndoGroupNotification;
		}
	}

	[Field("NSUndoManagerDidOpenUndoGroupNotification", "Foundation")]
	[Advice("Use NSUndoManager.Notifications.ObserveDidOpenUndoGroup helper method instead.")]
	public static NSString DidOpenUndoGroupNotification
	{
		get
		{
			if (_DidOpenUndoGroupNotification == null)
			{
				_DidOpenUndoGroupNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSUndoManagerDidOpenUndoGroupNotification");
			}
			return _DidOpenUndoGroupNotification;
		}
	}

	[Field("NSUndoManagerDidRedoChangeNotification", "Foundation")]
	[Advice("Use NSUndoManager.Notifications.ObserveDidRedoChange helper method instead.")]
	public static NSString DidRedoChangeNotification
	{
		get
		{
			if (_DidRedoChangeNotification == null)
			{
				_DidRedoChangeNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSUndoManagerDidRedoChangeNotification");
			}
			return _DidRedoChangeNotification;
		}
	}

	[Field("NSUndoManagerDidUndoChangeNotification", "Foundation")]
	[Advice("Use NSUndoManager.Notifications.ObserveDidUndoChange helper method instead.")]
	public static NSString DidUndoChangeNotification
	{
		get
		{
			if (_DidUndoChangeNotification == null)
			{
				_DidUndoChangeNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSUndoManagerDidUndoChangeNotification");
			}
			return _DidUndoChangeNotification;
		}
	}

	[Field("NSUndoManagerGroupIsDiscardableKey", "Foundation")]
	public static NSString GroupIsDiscardableKey
	{
		get
		{
			if (_GroupIsDiscardableKey == null)
			{
				_GroupIsDiscardableKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSUndoManagerGroupIsDiscardableKey");
			}
			return _GroupIsDiscardableKey;
		}
	}

	[Field("NSUndoManagerWillCloseUndoGroupNotification", "Foundation")]
	[Advice("Use NSUndoManager.Notifications.ObserveWillCloseUndoGroup helper method instead.")]
	public static NSString WillCloseUndoGroupNotification
	{
		get
		{
			if (_WillCloseUndoGroupNotification == null)
			{
				_WillCloseUndoGroupNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSUndoManagerWillCloseUndoGroupNotification");
			}
			return _WillCloseUndoGroupNotification;
		}
	}

	[Field("NSUndoManagerWillRedoChangeNotification", "Foundation")]
	[Advice("Use NSUndoManager.Notifications.ObserveWillRedoChange helper method instead.")]
	public static NSString WillRedoChangeNotification
	{
		get
		{
			if (_WillRedoChangeNotification == null)
			{
				_WillRedoChangeNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSUndoManagerWillRedoChangeNotification");
			}
			return _WillRedoChangeNotification;
		}
	}

	[Field("NSUndoManagerWillUndoChangeNotification", "Foundation")]
	[Advice("Use NSUndoManager.Notifications.ObserveWillUndoChange helper method instead.")]
	public static NSString WillUndoChangeNotification
	{
		get
		{
			if (_WillUndoChangeNotification == null)
			{
				_WillUndoChangeNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSUndoManagerWillUndoChangeNotification");
			}
			return _WillUndoChangeNotification;
		}
	}

	public virtual void SetActionName(string actionName)
	{
		SetActionname(actionName);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUndoManager()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSUndoManager(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUndoManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("beginUndoGrouping")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BeginUndoGrouping()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selBeginUndoGroupingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selBeginUndoGroupingHandle);
		}
	}

	[Export("disableUndoRegistration")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisableUndoRegistration()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisableUndoRegistrationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisableUndoRegistrationHandle);
		}
	}

	[Export("enableUndoRegistration")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EnableUndoRegistration()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEnableUndoRegistrationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEnableUndoRegistrationHandle);
		}
	}

	[Export("endUndoGrouping")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EndUndoGrouping()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEndUndoGroupingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEndUndoGroupingHandle);
		}
	}

	[Export("prepareWithInvocationTarget:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject PrepareWithInvocationTarget(NSObject target)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPrepareWithInvocationTarget_Handle, target.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPrepareWithInvocationTarget_Handle, target.Handle));
	}

	[Export("redo")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Redo()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRedoHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRedoHandle);
		}
	}

	[Export("redoMenuTitleForUndoActionName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string RedoMenuTitleForUndoActionName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRedoMenuTitleForUndoActionName_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRedoMenuTitleForUndoActionName_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("registerUndoWithTarget:handler:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RegisterUndo(NSObject target, [BlockProxy(typeof(Trampolines.NIDActionArity1V35))] Action<NSObject> undoHandler)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (undoHandler == null)
		{
			throw new ArgumentNullException("undoHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V35.Handler, undoHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRegisterUndoWithTarget_Handler_Handle, target.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRegisterUndoWithTarget_Handler_Handle, target.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("registerUndoWithTarget:selector:object:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RegisterUndoWithTarget(NSObject target, Selector selector, NSObject? anObject)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRegisterUndoWithTarget_Selector_Object_Handle, target.Handle, selector.Handle, anObject?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRegisterUndoWithTarget_Selector_Object_Handle, target.Handle, selector.Handle, anObject?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("removeAllActions")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllActions()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllActionsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllActionsHandle);
		}
	}

	[Export("removeAllActionsWithTarget:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllActions(NSObject target)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveAllActionsWithTarget_Handle, target.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveAllActionsWithTarget_Handle, target.Handle);
		}
	}

	[Export("setActionIsDiscardable:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetActionIsDiscardable(bool discardable)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetActionIsDiscardable_Handle, discardable);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetActionIsDiscardable_Handle, discardable);
		}
	}

	[Export("setActionName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Use the correctly named method: 'SetActionName'.")]
	public virtual void SetActionname(string actionName)
	{
		if (actionName == null)
		{
			throw new ArgumentNullException("actionName");
		}
		IntPtr arg = NSString.CreateNative(actionName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetActionName_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetActionName_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("undo")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Undo()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUndoHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUndoHandle);
		}
	}

	[Export("undoMenuTitleForUndoActionName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string UndoMenuTitleForUndoActionName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selUndoMenuTitleForUndoActionName_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selUndoMenuTitleForUndoActionName_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("undoNestedGroup")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UndoNestedGroup()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUndoNestedGroupHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUndoNestedGroupHandle);
		}
	}
}

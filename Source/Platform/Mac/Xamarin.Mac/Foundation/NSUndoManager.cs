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
			return NSNotificationCenter.DefaultCenter.AddObserver(CheckpointNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidOpenUndoGroup(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(DidOpenUndoGroupNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidRedoChange(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(DidRedoChangeNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidUndoChange(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(DidUndoChangeNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillCloseUndoGroup(EventHandler<NSUndoManagerCloseUndoGroupEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(WillCloseUndoGroupNotification, delegate(NSNotification notification)
			{
				handler(null, new NSUndoManagerCloseUndoGroupEventArgs(notification));
			});
		}

		public static NSObject ObserveWillRedoChange(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(WillRedoChangeNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWillUndoChange(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(WillUndoChangeNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidCloseUndoGroup(EventHandler<NSUndoManagerCloseUndoGroupEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(DidCloseUndoGroupNotification, delegate(NSNotification notification)
			{
				handler(null, new NSUndoManagerCloseUndoGroupEventArgs(notification));
			});
		}
	}

	private static readonly IntPtr selGroupingLevelHandle = Selector.GetHandle("groupingLevel");

	private static readonly IntPtr selIsUndoRegistrationEnabledHandle = Selector.GetHandle("isUndoRegistrationEnabled");

	private static readonly IntPtr selGroupsByEventHandle = Selector.GetHandle("groupsByEvent");

	private static readonly IntPtr selSetGroupsByEvent_Handle = Selector.GetHandle("setGroupsByEvent:");

	private static readonly IntPtr selLevelsOfUndoHandle = Selector.GetHandle("levelsOfUndo");

	private static readonly IntPtr selSetLevelsOfUndo_Handle = Selector.GetHandle("setLevelsOfUndo:");

	private static readonly IntPtr selRunLoopModesHandle = Selector.GetHandle("runLoopModes");

	private static readonly IntPtr selSetRunLoopModes_Handle = Selector.GetHandle("setRunLoopModes:");

	private static readonly IntPtr selCanUndoHandle = Selector.GetHandle("canUndo");

	private static readonly IntPtr selCanRedoHandle = Selector.GetHandle("canRedo");

	private static readonly IntPtr selIsUndoingHandle = Selector.GetHandle("isUndoing");

	private static readonly IntPtr selIsRedoingHandle = Selector.GetHandle("isRedoing");

	private static readonly IntPtr selUndoActionNameHandle = Selector.GetHandle("undoActionName");

	private static readonly IntPtr selRedoActionNameHandle = Selector.GetHandle("redoActionName");

	private static readonly IntPtr selUndoMenuItemTitleHandle = Selector.GetHandle("undoMenuItemTitle");

	private static readonly IntPtr selRedoMenuItemTitleHandle = Selector.GetHandle("redoMenuItemTitle");

	private static readonly IntPtr selUndoActionIsDiscardableHandle = Selector.GetHandle("undoActionIsDiscardable");

	private static readonly IntPtr selRedoActionIsDiscardableHandle = Selector.GetHandle("redoActionIsDiscardable");

	private static readonly IntPtr selBeginUndoGroupingHandle = Selector.GetHandle("beginUndoGrouping");

	private static readonly IntPtr selEndUndoGroupingHandle = Selector.GetHandle("endUndoGrouping");

	private static readonly IntPtr selDisableUndoRegistrationHandle = Selector.GetHandle("disableUndoRegistration");

	private static readonly IntPtr selEnableUndoRegistrationHandle = Selector.GetHandle("enableUndoRegistration");

	private static readonly IntPtr selUndoHandle = Selector.GetHandle("undo");

	private static readonly IntPtr selRedoHandle = Selector.GetHandle("redo");

	private static readonly IntPtr selUndoNestedGroupHandle = Selector.GetHandle("undoNestedGroup");

	private static readonly IntPtr selRemoveAllActionsHandle = Selector.GetHandle("removeAllActions");

	private static readonly IntPtr selRemoveAllActionsWithTarget_Handle = Selector.GetHandle("removeAllActionsWithTarget:");

	private static readonly IntPtr selRegisterUndoWithTargetSelectorObject_Handle = Selector.GetHandle("registerUndoWithTarget:selector:object:");

	private static readonly IntPtr selPrepareWithInvocationTarget_Handle = Selector.GetHandle("prepareWithInvocationTarget:");

	private static readonly IntPtr selSetActionName_Handle = Selector.GetHandle("setActionName:");

	private static readonly IntPtr selUndoMenuTitleForUndoActionName_Handle = Selector.GetHandle("undoMenuTitleForUndoActionName:");

	private static readonly IntPtr selRedoMenuTitleForUndoActionName_Handle = Selector.GetHandle("redoMenuTitleForUndoActionName:");

	private static readonly IntPtr selSetActionIsDiscardable_Handle = Selector.GetHandle("setActionIsDiscardable:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSUndoManager");

	private static NSString _CheckpointNotification;

	private static NSString _DidOpenUndoGroupNotification;

	private static NSString _DidRedoChangeNotification;

	private static NSString _DidUndoChangeNotification;

	private static NSString _WillCloseUndoGroupNotification;

	private static NSString _WillRedoChangeNotification;

	private static NSString _WillUndoChangeNotification;

	private static NSString _GroupIsDiscardableKey;

	private static NSString _DidCloseUndoGroupNotification;

	public override IntPtr ClassHandle => class_ptr;

	public virtual long GroupingLevel
	{
		[Export("groupingLevel")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selGroupingLevelHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selGroupingLevelHandle);
		}
	}

	public virtual bool IsUndoRegistrationEnabled
	{
		[Export("isUndoRegistrationEnabled")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsUndoRegistrationEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsUndoRegistrationEnabledHandle);
		}
	}

	public virtual bool GroupsByEvent
	{
		[Export("groupsByEvent")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selGroupsByEventHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selGroupsByEventHandle);
		}
		[Export("setGroupsByEvent:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetGroupsByEvent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetGroupsByEvent_Handle, value);
			}
		}
	}

	public virtual long LevelsOfUndo
	{
		[Export("levelsOfUndo")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selLevelsOfUndoHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selLevelsOfUndoHandle);
		}
		[Export("setLevelsOfUndo:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetLevelsOfUndo_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetLevelsOfUndo_Handle, value);
			}
		}
	}

	public virtual string[] RunLoopModes
	{
		[Export("runLoopModes")]
		get
		{
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual bool CanUndo
	{
		[Export("canUndo")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanUndoHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanUndoHandle);
		}
	}

	public virtual bool CanRedo
	{
		[Export("canRedo")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanRedoHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanRedoHandle);
		}
	}

	public virtual bool IsUndoing
	{
		[Export("isUndoing")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsUndoingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsUndoingHandle);
		}
	}

	public virtual bool IsRedoing
	{
		[Export("isRedoing")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsRedoingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsRedoingHandle);
		}
	}

	public virtual string UndoActionName
	{
		[Export("undoActionName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUndoActionNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUndoActionNameHandle));
		}
	}

	public virtual string RedoActionName
	{
		[Export("redoActionName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRedoActionNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRedoActionNameHandle));
		}
	}

	public virtual string UndoMenuItemTitle
	{
		[Export("undoMenuItemTitle")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUndoMenuItemTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUndoMenuItemTitleHandle));
		}
	}

	public virtual string RedoMenuItemTitle
	{
		[Export("redoMenuItemTitle")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRedoMenuItemTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRedoMenuItemTitleHandle));
		}
	}

	[Since(5, 0)]
	public virtual bool UndoActionIsDiscardable
	{
		[Export("undoActionIsDiscardable")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUndoActionIsDiscardableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUndoActionIsDiscardableHandle);
		}
	}

	[Since(5, 0)]
	public virtual bool RedoActionIsDiscardable
	{
		[Export("redoActionIsDiscardable")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRedoActionIsDiscardableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRedoActionIsDiscardableHandle);
		}
	}

	[Field("NSUndoManagerCheckpointNotification", "Foundation")]
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

	[Field("NSUndoManagerDidOpenUndoGroupNotification", "Foundation")]
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

	[Field("NSUndoManagerWillCloseUndoGroupNotification", "Foundation")]
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

	[Field("NSUndoManagerDidCloseUndoGroupNotification", "Foundation")]
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSUndoManager()
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
	public NSUndoManager(NSCoder coder)
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
	public NSUndoManager(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUndoManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("beginUndoGrouping")]
	public virtual void BeginUndoGrouping()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selBeginUndoGroupingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selBeginUndoGroupingHandle);
		}
	}

	[Export("endUndoGrouping")]
	public virtual void EndUndoGrouping()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEndUndoGroupingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEndUndoGroupingHandle);
		}
	}

	[Export("disableUndoRegistration")]
	public virtual void DisableUndoRegistration()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisableUndoRegistrationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisableUndoRegistrationHandle);
		}
	}

	[Export("enableUndoRegistration")]
	public virtual void EnableUndoRegistration()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEnableUndoRegistrationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEnableUndoRegistrationHandle);
		}
	}

	[Export("undo")]
	public virtual void Undo()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUndoHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUndoHandle);
		}
	}

	[Export("redo")]
	public virtual void Redo()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRedoHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRedoHandle);
		}
	}

	[Export("undoNestedGroup")]
	public virtual void UndoNestedGroup()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUndoNestedGroupHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUndoNestedGroupHandle);
		}
	}

	[Export("removeAllActions")]
	public virtual void RemoveAllActions()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllActionsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllActionsHandle);
		}
	}

	[Export("removeAllActionsWithTarget:")]
	public virtual void RemoveAllActions(NSObject target)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveAllActionsWithTarget_Handle, target.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveAllActionsWithTarget_Handle, target.Handle);
		}
	}

	[Export("registerUndoWithTarget:selector:object:")]
	public virtual void RegisterUndoWithTarget(NSObject target, Selector selector, NSObject anObject)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		if (anObject == null)
		{
			throw new ArgumentNullException("anObject");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRegisterUndoWithTargetSelectorObject_Handle, target.Handle, selector.Handle, anObject.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRegisterUndoWithTargetSelectorObject_Handle, target.Handle, selector.Handle, anObject.Handle);
		}
	}

	[Export("prepareWithInvocationTarget:")]
	public virtual NSObject PrepareWithInvocationTarget(NSObject target)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPrepareWithInvocationTarget_Handle, target.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPrepareWithInvocationTarget_Handle, target.Handle));
	}

	[Export("setActionName:")]
	public virtual void SetActionname(string actionName)
	{
		if (actionName == null)
		{
			throw new ArgumentNullException("actionName");
		}
		IntPtr arg = NSString.CreateNative(actionName);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetActionName_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetActionName_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("undoMenuTitleForUndoActionName:")]
	public virtual string UndoMenuTitleForUndoActionName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selUndoMenuTitleForUndoActionName_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selUndoMenuTitleForUndoActionName_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("redoMenuTitleForUndoActionName:")]
	public virtual string RedoMenuTitleForUndoActionName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRedoMenuTitleForUndoActionName_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRedoMenuTitleForUndoActionName_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setActionIsDiscardable:")]
	public virtual void SetActionIsDiscardable(bool discardable)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetActionIsDiscardable_Handle, discardable);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetActionIsDiscardable_Handle, discardable);
		}
	}
}

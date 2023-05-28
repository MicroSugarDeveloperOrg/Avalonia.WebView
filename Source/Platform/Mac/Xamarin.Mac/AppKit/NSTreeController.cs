using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTreeController", true)]
public class NSTreeController : NSObjectController
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAdd_ = "add:";

	private static readonly IntPtr selAdd_Handle = Selector.GetHandle("add:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddChild_ = "addChild:";

	private static readonly IntPtr selAddChild_Handle = Selector.GetHandle("addChild:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddSelectionIndexPaths_ = "addSelectionIndexPaths:";

	private static readonly IntPtr selAddSelectionIndexPaths_Handle = Selector.GetHandle("addSelectionIndexPaths:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlwaysUsesMultipleValuesMarker = "alwaysUsesMultipleValuesMarker";

	private static readonly IntPtr selAlwaysUsesMultipleValuesMarkerHandle = Selector.GetHandle("alwaysUsesMultipleValuesMarker");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArrangedObjects = "arrangedObjects";

	private static readonly IntPtr selArrangedObjectsHandle = Selector.GetHandle("arrangedObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvoidsEmptySelection = "avoidsEmptySelection";

	private static readonly IntPtr selAvoidsEmptySelectionHandle = Selector.GetHandle("avoidsEmptySelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanAddChild = "canAddChild";

	private static readonly IntPtr selCanAddChildHandle = Selector.GetHandle("canAddChild");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanInsert = "canInsert";

	private static readonly IntPtr selCanInsertHandle = Selector.GetHandle("canInsert");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanInsertChild = "canInsertChild";

	private static readonly IntPtr selCanInsertChildHandle = Selector.GetHandle("canInsertChild");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChildrenKeyPath = "childrenKeyPath";

	private static readonly IntPtr selChildrenKeyPathHandle = Selector.GetHandle("childrenKeyPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChildrenKeyPathForNode_ = "childrenKeyPathForNode:";

	private static readonly IntPtr selChildrenKeyPathForNode_Handle = Selector.GetHandle("childrenKeyPathForNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContent = "content";

	private static readonly IntPtr selContentHandle = Selector.GetHandle("content");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCountKeyPath = "countKeyPath";

	private static readonly IntPtr selCountKeyPathHandle = Selector.GetHandle("countKeyPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCountKeyPathForNode_ = "countKeyPathForNode:";

	private static readonly IntPtr selCountKeyPathForNode_Handle = Selector.GetHandle("countKeyPathForNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsert_ = "insert:";

	private static readonly IntPtr selInsert_Handle = Selector.GetHandle("insert:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertChild_ = "insertChild:";

	private static readonly IntPtr selInsertChild_Handle = Selector.GetHandle("insertChild:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertObject_AtArrangedObjectIndexPath_ = "insertObject:atArrangedObjectIndexPath:";

	private static readonly IntPtr selInsertObject_AtArrangedObjectIndexPath_Handle = Selector.GetHandle("insertObject:atArrangedObjectIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertObjects_AtArrangedObjectIndexPaths_ = "insertObjects:atArrangedObjectIndexPaths:";

	private static readonly IntPtr selInsertObjects_AtArrangedObjectIndexPaths_Handle = Selector.GetHandle("insertObjects:atArrangedObjectIndexPaths:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeafKeyPath = "leafKeyPath";

	private static readonly IntPtr selLeafKeyPathHandle = Selector.GetHandle("leafKeyPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeafKeyPathForNode_ = "leafKeyPathForNode:";

	private static readonly IntPtr selLeafKeyPathForNode_Handle = Selector.GetHandle("leafKeyPathForNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveNode_ToIndexPath_ = "moveNode:toIndexPath:";

	private static readonly IntPtr selMoveNode_ToIndexPath_Handle = Selector.GetHandle("moveNode:toIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveNodes_ToIndexPath_ = "moveNodes:toIndexPath:";

	private static readonly IntPtr selMoveNodes_ToIndexPath_Handle = Selector.GetHandle("moveNodes:toIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreservesSelection = "preservesSelection";

	private static readonly IntPtr selPreservesSelectionHandle = Selector.GetHandle("preservesSelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRearrangeObjects = "rearrangeObjects";

	private static readonly IntPtr selRearrangeObjectsHandle = Selector.GetHandle("rearrangeObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemove_ = "remove:";

	private static readonly IntPtr selRemove_Handle = Selector.GetHandle("remove:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObjectAtArrangedObjectIndexPath_ = "removeObjectAtArrangedObjectIndexPath:";

	private static readonly IntPtr selRemoveObjectAtArrangedObjectIndexPath_Handle = Selector.GetHandle("removeObjectAtArrangedObjectIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObjectsAtArrangedObjectIndexPaths_ = "removeObjectsAtArrangedObjectIndexPaths:";

	private static readonly IntPtr selRemoveObjectsAtArrangedObjectIndexPaths_Handle = Selector.GetHandle("removeObjectsAtArrangedObjectIndexPaths:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveSelectionIndexPaths_ = "removeSelectionIndexPaths:";

	private static readonly IntPtr selRemoveSelectionIndexPaths_Handle = Selector.GetHandle("removeSelectionIndexPaths:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedNodes = "selectedNodes";

	private static readonly IntPtr selSelectedNodesHandle = Selector.GetHandle("selectedNodes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedObjects = "selectedObjects";

	private static readonly IntPtr selSelectedObjectsHandle = Selector.GetHandle("selectedObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionIndexPath = "selectionIndexPath";

	private static readonly IntPtr selSelectionIndexPathHandle = Selector.GetHandle("selectionIndexPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionIndexPaths = "selectionIndexPaths";

	private static readonly IntPtr selSelectionIndexPathsHandle = Selector.GetHandle("selectionIndexPaths");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectsInsertedObjects = "selectsInsertedObjects";

	private static readonly IntPtr selSelectsInsertedObjectsHandle = Selector.GetHandle("selectsInsertedObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlwaysUsesMultipleValuesMarker_ = "setAlwaysUsesMultipleValuesMarker:";

	private static readonly IntPtr selSetAlwaysUsesMultipleValuesMarker_Handle = Selector.GetHandle("setAlwaysUsesMultipleValuesMarker:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAvoidsEmptySelection_ = "setAvoidsEmptySelection:";

	private static readonly IntPtr selSetAvoidsEmptySelection_Handle = Selector.GetHandle("setAvoidsEmptySelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetChildrenKeyPath_ = "setChildrenKeyPath:";

	private static readonly IntPtr selSetChildrenKeyPath_Handle = Selector.GetHandle("setChildrenKeyPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContent_ = "setContent:";

	private static readonly IntPtr selSetContent_Handle = Selector.GetHandle("setContent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCountKeyPath_ = "setCountKeyPath:";

	private static readonly IntPtr selSetCountKeyPath_Handle = Selector.GetHandle("setCountKeyPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLeafKeyPath_ = "setLeafKeyPath:";

	private static readonly IntPtr selSetLeafKeyPath_Handle = Selector.GetHandle("setLeafKeyPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreservesSelection_ = "setPreservesSelection:";

	private static readonly IntPtr selSetPreservesSelection_Handle = Selector.GetHandle("setPreservesSelection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectionIndexPath_ = "setSelectionIndexPath:";

	private static readonly IntPtr selSetSelectionIndexPath_Handle = Selector.GetHandle("setSelectionIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectionIndexPaths_ = "setSelectionIndexPaths:";

	private static readonly IntPtr selSetSelectionIndexPaths_Handle = Selector.GetHandle("setSelectionIndexPaths:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectsInsertedObjects_ = "setSelectsInsertedObjects:";

	private static readonly IntPtr selSetSelectsInsertedObjects_Handle = Selector.GetHandle("setSelectsInsertedObjects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSortDescriptors_ = "setSortDescriptors:";

	private static readonly IntPtr selSetSortDescriptors_Handle = Selector.GetHandle("setSortDescriptors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSortDescriptors = "sortDescriptors";

	private static readonly IntPtr selSortDescriptorsHandle = Selector.GetHandle("sortDescriptors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTreeController");

	public NSIndexPath SelectionIndexPath
	{
		get
		{
			return GetSelectionIndexPath();
		}
		set
		{
			SetSelectionIndexPath(value);
		}
	}

	public NSIndexPath[] SelectionIndexPaths
	{
		get
		{
			return GetSelectionIndexPaths();
		}
		set
		{
			SetSelectionIndexPaths(value);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AlwaysUsesMultipleValuesMarker
	{
		[Export("alwaysUsesMultipleValuesMarker")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAlwaysUsesMultipleValuesMarkerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAlwaysUsesMultipleValuesMarkerHandle);
		}
		[Export("setAlwaysUsesMultipleValuesMarker:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAlwaysUsesMultipleValuesMarker_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAlwaysUsesMultipleValuesMarker_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ArrangedObjects
	{
		[Export("arrangedObjects")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selArrangedObjectsHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selArrangedObjectsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AvoidsEmptySelection
	{
		[Export("avoidsEmptySelection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAvoidsEmptySelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAvoidsEmptySelectionHandle);
		}
		[Export("setAvoidsEmptySelection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAvoidsEmptySelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAvoidsEmptySelection_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanAddChild
	{
		[Export("canAddChild")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanAddChildHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanAddChildHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanInsert
	{
		[Export("canInsert")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanInsertHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanInsertHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanInsertChild
	{
		[Export("canInsertChild")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanInsertChildHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanInsertChildHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ChildrenKeyPath
	{
		[Export("childrenKeyPath")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selChildrenKeyPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChildrenKeyPathHandle));
		}
		[Export("setChildrenKeyPath:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetChildrenKeyPath_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetChildrenKeyPath_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSObject Content
	{
		[Export("content", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selContentHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentHandle));
		}
		[Export("setContent:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContent_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContent_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CountKeyPath
	{
		[Export("countKeyPath")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCountKeyPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCountKeyPathHandle));
		}
		[Export("setCountKeyPath:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCountKeyPath_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCountKeyPath_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string LeafKeyPath
	{
		[Export("leafKeyPath")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLeafKeyPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLeafKeyPathHandle));
		}
		[Export("setLeafKeyPath:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLeafKeyPath_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLeafKeyPath_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PreservesSelection
	{
		[Export("preservesSelection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPreservesSelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPreservesSelectionHandle);
		}
		[Export("setPreservesSelection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPreservesSelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPreservesSelection_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTreeNode[] SelectedNodes
	{
		[Export("selectedNodes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSTreeNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedNodesHandle));
			}
			return NSArray.ArrayFromHandle<NSTreeNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedNodesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SelectsInsertedObjects
	{
		[Export("selectsInsertedObjects")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSelectsInsertedObjectsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSelectsInsertedObjectsHandle);
		}
		[Export("setSelectsInsertedObjects:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSelectsInsertedObjects_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSelectsInsertedObjects_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSortDescriptor[] SortDescriptors
	{
		[Export("sortDescriptors", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSSortDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selSortDescriptorsHandle));
			}
			return NSArray.ArrayFromHandle<NSSortDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSortDescriptorsHandle));
		}
		[Export("setSortDescriptors:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSortDescriptors_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSortDescriptors_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTreeController()
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
	public NSTreeController(NSCoder coder)
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
	protected NSTreeController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTreeController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("add:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void Add(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAdd_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAdd_Handle, sender.Handle);
		}
	}

	[Export("addChild:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddChild(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddChild_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddChild_Handle, sender.Handle);
		}
	}

	[Export("addSelectionIndexPaths:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AddSelectionIndexPaths(NSIndexPath[] indexPaths)
	{
		NSApplication.EnsureUIThread();
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		NSArray nSArray = NSArray.FromNSObjects(indexPaths);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSelectionIndexPaths_Handle, nSArray.Handle) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selAddSelectionIndexPaths_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("childrenKeyPathForNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ChildrenKeyPathForNode(NSTreeNode node)
	{
		NSApplication.EnsureUIThread();
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selChildrenKeyPathForNode_Handle, node.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selChildrenKeyPathForNode_Handle, node.Handle));
	}

	[Export("countKeyPathForNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CountKeyPathForNode(NSTreeNode node)
	{
		NSApplication.EnsureUIThread();
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCountKeyPathForNode_Handle, node.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCountKeyPathForNode_Handle, node.Handle));
	}

	[Export("selectionIndexPath")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSIndexPath GetSelectionIndexPath()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectionIndexPathHandle));
		}
		return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectionIndexPathHandle));
	}

	[Export("selectionIndexPaths")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSIndexPath[] GetSelectionIndexPaths()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSIndexPath>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectionIndexPathsHandle));
		}
		return NSArray.ArrayFromHandle<NSIndexPath>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectionIndexPathsHandle));
	}

	[Export("insert:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Insert(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInsert_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInsert_Handle, sender.Handle);
		}
	}

	[Export("insertChild:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertChild(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInsertChild_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInsertChild_Handle, sender.Handle);
		}
	}

	[Export("insertObject:atArrangedObjectIndexPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertObject(NSObject object1, NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (object1 == null)
		{
			throw new ArgumentNullException("object1");
		}
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertObject_AtArrangedObjectIndexPath_Handle, object1.Handle, indexPath.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertObject_AtArrangedObjectIndexPath_Handle, object1.Handle, indexPath.Handle);
		}
	}

	[Export("insertObjects:atArrangedObjectIndexPaths:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertObjects(NSObject[] objects, NSArray indexPaths)
	{
		NSApplication.EnsureUIThread();
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertObjects_AtArrangedObjectIndexPaths_Handle, nSArray.Handle, indexPaths.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertObjects_AtArrangedObjectIndexPaths_Handle, nSArray.Handle, indexPaths.Handle);
		}
		nSArray.Dispose();
	}

	[Export("leafKeyPathForNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string LeafKeyPathForNode(NSTreeNode node)
	{
		NSApplication.EnsureUIThread();
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLeafKeyPathForNode_Handle, node.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLeafKeyPathForNode_Handle, node.Handle));
	}

	[Export("moveNode:toIndexPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveNode(NSTreeNode node, NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selMoveNode_ToIndexPath_Handle, node.Handle, indexPath.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selMoveNode_ToIndexPath_Handle, node.Handle, indexPath.Handle);
		}
	}

	[Export("moveNodes:toIndexPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveNodes(NSTreeNode[] nodes, NSIndexPath startingIndexPath)
	{
		NSApplication.EnsureUIThread();
		if (nodes == null)
		{
			throw new ArgumentNullException("nodes");
		}
		if (startingIndexPath == null)
		{
			throw new ArgumentNullException("startingIndexPath");
		}
		NSArray nSArray = NSArray.FromNSObjects(nodes);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selMoveNodes_ToIndexPath_Handle, nSArray.Handle, startingIndexPath.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selMoveNodes_ToIndexPath_Handle, nSArray.Handle, startingIndexPath.Handle);
		}
		nSArray.Dispose();
	}

	[Export("rearrangeObjects")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RearrangeObjects()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRearrangeObjectsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRearrangeObjectsHandle);
		}
	}

	[Export("remove:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void Remove(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemove_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemove_Handle, sender.Handle);
		}
	}

	[Export("removeObjectAtArrangedObjectIndexPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveObjectAtArrangedObjectIndexPath(NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObjectAtArrangedObjectIndexPath_Handle, indexPath.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObjectAtArrangedObjectIndexPath_Handle, indexPath.Handle);
		}
	}

	[Export("removeObjectsAtArrangedObjectIndexPaths:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveObjectsAtArrangedObjectIndexPaths(NSIndexPath[] indexPaths)
	{
		NSApplication.EnsureUIThread();
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		NSArray nSArray = NSArray.FromNSObjects(indexPaths);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObjectsAtArrangedObjectIndexPaths_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObjectsAtArrangedObjectIndexPaths_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("removeSelectionIndexPaths:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RemoveSelectionIndexPaths(NSIndexPath[] indexPaths)
	{
		NSApplication.EnsureUIThread();
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		NSArray nSArray = NSArray.FromNSObjects(indexPaths);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveSelectionIndexPaths_Handle, nSArray.Handle) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selRemoveSelectionIndexPaths_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("setSelectionIndexPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual bool SetSelectionIndexPath(NSIndexPath index)
	{
		NSApplication.EnsureUIThread();
		if (index == null)
		{
			throw new ArgumentNullException("index");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSetSelectionIndexPath_Handle, index.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectionIndexPath_Handle, index.Handle);
	}

	[Export("setSelectionIndexPaths:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual bool SetSelectionIndexPaths(NSIndexPath[] indexPaths)
	{
		NSApplication.EnsureUIThread();
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		NSArray nSArray = NSArray.FromNSObjects(indexPaths);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectionIndexPaths_Handle, nSArray.Handle) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSetSelectionIndexPaths_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}
}

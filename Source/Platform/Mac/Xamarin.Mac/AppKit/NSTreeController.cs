using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTreeController", true)]
public class NSTreeController : NSObjectController
{
	private static readonly IntPtr selArrangedObjectsHandle = Selector.GetHandle("arrangedObjects");

	private static readonly IntPtr selChildrenKeyPathHandle = Selector.GetHandle("childrenKeyPath");

	private static readonly IntPtr selSetChildrenKeyPath_Handle = Selector.GetHandle("setChildrenKeyPath:");

	private static readonly IntPtr selCountKeyPathHandle = Selector.GetHandle("countKeyPath");

	private static readonly IntPtr selSetCountKeyPath_Handle = Selector.GetHandle("setCountKeyPath:");

	private static readonly IntPtr selLeafKeyPathHandle = Selector.GetHandle("leafKeyPath");

	private static readonly IntPtr selSetLeafKeyPath_Handle = Selector.GetHandle("setLeafKeyPath:");

	private static readonly IntPtr selSortDescriptorsHandle = Selector.GetHandle("sortDescriptors");

	private static readonly IntPtr selSetSortDescriptors_Handle = Selector.GetHandle("setSortDescriptors:");

	private static readonly IntPtr selContentHandle = Selector.GetHandle("content");

	private static readonly IntPtr selSetContent_Handle = Selector.GetHandle("setContent:");

	private static readonly IntPtr selCanInsertHandle = Selector.GetHandle("canInsert");

	private static readonly IntPtr selCanInsertChildHandle = Selector.GetHandle("canInsertChild");

	private static readonly IntPtr selCanAddChildHandle = Selector.GetHandle("canAddChild");

	private static readonly IntPtr selAvoidsEmptySelectionHandle = Selector.GetHandle("avoidsEmptySelection");

	private static readonly IntPtr selSetAvoidsEmptySelection_Handle = Selector.GetHandle("setAvoidsEmptySelection:");

	private static readonly IntPtr selPreservesSelectionHandle = Selector.GetHandle("preservesSelection");

	private static readonly IntPtr selSetPreservesSelection_Handle = Selector.GetHandle("setPreservesSelection:");

	private static readonly IntPtr selSelectsInsertedObjectsHandle = Selector.GetHandle("selectsInsertedObjects");

	private static readonly IntPtr selSetSelectsInsertedObjects_Handle = Selector.GetHandle("setSelectsInsertedObjects:");

	private static readonly IntPtr selAlwaysUsesMultipleValuesMarkerHandle = Selector.GetHandle("alwaysUsesMultipleValuesMarker");

	private static readonly IntPtr selSetAlwaysUsesMultipleValuesMarker_Handle = Selector.GetHandle("setAlwaysUsesMultipleValuesMarker:");

	private static readonly IntPtr selSelectedObjectsHandle = Selector.GetHandle("selectedObjects");

	private static readonly IntPtr selSelectedNodesHandle = Selector.GetHandle("selectedNodes");

	private static readonly IntPtr selRearrangeObjectsHandle = Selector.GetHandle("rearrangeObjects");

	private static readonly IntPtr selAdd_Handle = Selector.GetHandle("add:");

	private static readonly IntPtr selRemove_Handle = Selector.GetHandle("remove:");

	private static readonly IntPtr selAddChild_Handle = Selector.GetHandle("addChild:");

	private static readonly IntPtr selInsert_Handle = Selector.GetHandle("insert:");

	private static readonly IntPtr selInsertChild_Handle = Selector.GetHandle("insertChild:");

	private static readonly IntPtr selInsertObjectAtArrangedObjectIndexPath_Handle = Selector.GetHandle("insertObject:atArrangedObjectIndexPath:");

	private static readonly IntPtr selInsertObjectsAtArrangedObjectIndexPaths_Handle = Selector.GetHandle("insertObjects:atArrangedObjectIndexPaths:");

	private static readonly IntPtr selRemoveObjectAtArrangedObjectIndexPath_Handle = Selector.GetHandle("removeObjectAtArrangedObjectIndexPath:");

	private static readonly IntPtr selRemoveObjectsAtArrangedObjectIndexPaths_Handle = Selector.GetHandle("removeObjectsAtArrangedObjectIndexPaths:");

	private static readonly IntPtr selSelectionIndexPathsHandle = Selector.GetHandle("selectionIndexPaths");

	private static readonly IntPtr selSetSelectionIndexPaths_Handle = Selector.GetHandle("setSelectionIndexPaths:");

	private static readonly IntPtr selSelectionIndexPathHandle = Selector.GetHandle("selectionIndexPath");

	private static readonly IntPtr selSetSelectionIndexPath_Handle = Selector.GetHandle("setSelectionIndexPath:");

	private static readonly IntPtr selAddSelectionIndexPaths_Handle = Selector.GetHandle("addSelectionIndexPaths:");

	private static readonly IntPtr selRemoveSelectionIndexPaths_Handle = Selector.GetHandle("removeSelectionIndexPaths:");

	private static readonly IntPtr selMoveNodeToIndexPath_Handle = Selector.GetHandle("moveNode:toIndexPath:");

	private static readonly IntPtr selMoveNodesToIndexPath_Handle = Selector.GetHandle("moveNodes:toIndexPath:");

	private static readonly IntPtr selChildrenKeyPathForNode_Handle = Selector.GetHandle("childrenKeyPathForNode:");

	private static readonly IntPtr selCountKeyPathForNode_Handle = Selector.GetHandle("countKeyPathForNode:");

	private static readonly IntPtr selLeafKeyPathForNode_Handle = Selector.GetHandle("leafKeyPathForNode:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTreeController");

	private object __mt_ArrangedObjects_var;

	private object __mt_SortDescriptors_var;

	private object __mt_Content_var;

	private object __mt_SelectedObjects_var;

	private object __mt_SelectedNodes_var;

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

	public virtual NSObject ArrangedObjects
	{
		[Export("arrangedObjects")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_ArrangedObjects_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selArrangedObjectsHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selArrangedObjectsHandle))));
		}
	}

	public virtual string ChildrenKeyPath
	{
		[Export("childrenKeyPath")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string CountKeyPath
	{
		[Export("countKeyPath")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual string LeafKeyPath
	{
		[Export("leafKeyPath")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
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
			if (IsDirectBinding)
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

	public virtual NSSortDescriptor[] SortDescriptors
	{
		[Export("sortDescriptors")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSSortDescriptor[])(__mt_SortDescriptors_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSSortDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSortDescriptorsHandle)) : NSArray.ArrayFromHandle<NSSortDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selSortDescriptorsHandle))));
		}
		[Export("setSortDescriptors:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSortDescriptors_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSortDescriptors_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_SortDescriptors_var = value;
		}
	}

	public new virtual NSObject Content
	{
		[Export("content")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_Content_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selContentHandle))));
		}
		[Export("setContent:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContent_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContent_Handle, value.Handle);
			}
			__mt_Content_var = value;
		}
	}

	public virtual bool CanInsert
	{
		[Export("canInsert")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanInsertHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanInsertHandle);
		}
	}

	public virtual bool CanInsertChild
	{
		[Export("canInsertChild")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanInsertChildHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanInsertChildHandle);
		}
	}

	public virtual bool CanAddChild
	{
		[Export("canAddChild")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCanAddChildHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCanAddChildHandle);
		}
	}

	public virtual bool AvoidsEmptySelection
	{
		[Export("avoidsEmptySelection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAvoidsEmptySelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAvoidsEmptySelectionHandle);
		}
		[Export("setAvoidsEmptySelection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAvoidsEmptySelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAvoidsEmptySelection_Handle, value);
			}
		}
	}

	public virtual bool PreservesSelection
	{
		[Export("preservesSelection")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPreservesSelectionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPreservesSelectionHandle);
		}
		[Export("setPreservesSelection:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPreservesSelection_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPreservesSelection_Handle, value);
			}
		}
	}

	public virtual bool SelectsInsertedObjects
	{
		[Export("selectsInsertedObjects")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSelectsInsertedObjectsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSelectsInsertedObjectsHandle);
		}
		[Export("setSelectsInsertedObjects:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSelectsInsertedObjects_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSelectsInsertedObjects_Handle, value);
			}
		}
	}

	public virtual bool AlwaysUsesMultipleValuesMarker
	{
		[Export("alwaysUsesMultipleValuesMarker")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAlwaysUsesMultipleValuesMarkerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAlwaysUsesMultipleValuesMarkerHandle);
		}
		[Export("setAlwaysUsesMultipleValuesMarker:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAlwaysUsesMultipleValuesMarker_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAlwaysUsesMultipleValuesMarker_Handle, value);
			}
		}
	}

	public new virtual NSObject[] SelectedObjects
	{
		[Export("selectedObjects")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject[])(__mt_SelectedObjects_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedObjectsHandle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedObjectsHandle))));
		}
	}

	public virtual NSTreeNode[] SelectedNodes
	{
		[Export("selectedNodes")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTreeNode[])(__mt_SelectedNodes_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSTreeNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedNodesHandle)) : NSArray.ArrayFromHandle<NSTreeNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedNodesHandle))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTreeController()
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
	public NSTreeController(NSCoder coder)
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
	public NSTreeController(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTreeController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("rearrangeObjects")]
	public virtual void RearrangeObjects()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRearrangeObjectsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRearrangeObjectsHandle);
		}
	}

	[Export("add:")]
	public new virtual void Add(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAdd_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAdd_Handle, sender.Handle);
		}
	}

	[Export("remove:")]
	public new virtual void Remove(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemove_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemove_Handle, sender.Handle);
		}
	}

	[Export("addChild:")]
	public virtual void AddChild(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddChild_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddChild_Handle, sender.Handle);
		}
	}

	[Export("insert:")]
	public virtual void Insert(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInsert_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInsert_Handle, sender.Handle);
		}
	}

	[Export("insertChild:")]
	public virtual void InsertChild(NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInsertChild_Handle, sender.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInsertChild_Handle, sender.Handle);
		}
	}

	[Export("insertObject:atArrangedObjectIndexPath:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertObjectAtArrangedObjectIndexPath_Handle, object1.Handle, indexPath.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertObjectAtArrangedObjectIndexPath_Handle, object1.Handle, indexPath.Handle);
		}
	}

	[Export("insertObjects:atArrangedObjectIndexPaths:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertObjectsAtArrangedObjectIndexPaths_Handle, nSArray.Handle, indexPaths.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertObjectsAtArrangedObjectIndexPaths_Handle, nSArray.Handle, indexPaths.Handle);
		}
		nSArray.Dispose();
	}

	[Export("removeObjectAtArrangedObjectIndexPath:")]
	public virtual void RemoveObjectAtArrangedObjectIndexPath(NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObjectAtArrangedObjectIndexPath_Handle, indexPath.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObjectAtArrangedObjectIndexPath_Handle, indexPath.Handle);
		}
	}

	[Export("removeObjectsAtArrangedObjectIndexPaths:")]
	public virtual void RemoveObjectsAtArrangedObjectIndexPaths(NSIndexPath[] indexPaths)
	{
		NSApplication.EnsureUIThread();
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		NSArray nSArray = NSArray.FromNSObjects(indexPaths);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObjectsAtArrangedObjectIndexPaths_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObjectsAtArrangedObjectIndexPaths_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("selectionIndexPaths")]
	protected virtual NSIndexPath[] GetSelectionIndexPaths()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSIndexPath>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectionIndexPathsHandle));
		}
		return NSArray.ArrayFromHandle<NSIndexPath>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectionIndexPathsHandle));
	}

	[Export("setSelectionIndexPaths:")]
	protected virtual bool SetSelectionIndexPaths(NSIndexPath[] indexPaths)
	{
		NSApplication.EnsureUIThread();
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		NSArray nSArray = NSArray.FromNSObjects(indexPaths);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectionIndexPaths_Handle, nSArray.Handle) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSetSelectionIndexPaths_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("selectionIndexPath")]
	protected virtual NSIndexPath GetSelectionIndexPath()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return (NSIndexPath)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectionIndexPathHandle));
		}
		return (NSIndexPath)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectionIndexPathHandle));
	}

	[Export("setSelectionIndexPath:")]
	protected virtual bool SetSelectionIndexPath(NSIndexPath index)
	{
		NSApplication.EnsureUIThread();
		if (index == null)
		{
			throw new ArgumentNullException("index");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSetSelectionIndexPath_Handle, index.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectionIndexPath_Handle, index.Handle);
	}

	[Export("addSelectionIndexPaths:")]
	public virtual bool AddSelectionIndexPaths(NSIndexPath[] indexPaths)
	{
		NSApplication.EnsureUIThread();
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		NSArray nSArray = NSArray.FromNSObjects(indexPaths);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddSelectionIndexPaths_Handle, nSArray.Handle) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selAddSelectionIndexPaths_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("removeSelectionIndexPaths:")]
	public virtual bool RemoveSelectionIndexPaths(NSIndexPath[] indexPaths)
	{
		NSApplication.EnsureUIThread();
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		NSArray nSArray = NSArray.FromNSObjects(indexPaths);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveSelectionIndexPaths_Handle, nSArray.Handle) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selRemoveSelectionIndexPaths_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("moveNode:toIndexPath:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selMoveNodeToIndexPath_Handle, node.Handle, indexPath.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selMoveNodeToIndexPath_Handle, node.Handle, indexPath.Handle);
		}
	}

	[Export("moveNodes:toIndexPath:")]
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selMoveNodesToIndexPath_Handle, nSArray.Handle, startingIndexPath.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selMoveNodesToIndexPath_Handle, nSArray.Handle, startingIndexPath.Handle);
		}
		nSArray.Dispose();
	}

	[Export("childrenKeyPathForNode:")]
	public virtual string ChildrenKeyPathForNode(NSTreeNode node)
	{
		NSApplication.EnsureUIThread();
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selChildrenKeyPathForNode_Handle, node.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selChildrenKeyPathForNode_Handle, node.Handle));
	}

	[Export("countKeyPathForNode:")]
	public virtual string CountKeyPathForNode(NSTreeNode node)
	{
		NSApplication.EnsureUIThread();
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCountKeyPathForNode_Handle, node.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCountKeyPathForNode_Handle, node.Handle));
	}

	[Export("leafKeyPathForNode:")]
	public virtual string LeafKeyPathForNode(NSTreeNode node)
	{
		NSApplication.EnsureUIThread();
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLeafKeyPathForNode_Handle, node.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLeafKeyPathForNode_Handle, node.Handle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ArrangedObjects_var = null;
			__mt_SortDescriptors_var = null;
			__mt_Content_var = null;
			__mt_SelectedObjects_var = null;
			__mt_SelectedNodes_var = null;
		}
	}
}

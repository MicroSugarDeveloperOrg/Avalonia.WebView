using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTreeNode", true)]
public class NSTreeNode : NSObject
{
	private static readonly IntPtr selRepresentedObjectHandle = Selector.GetHandle("representedObject");

	private static readonly IntPtr selIndexPathHandle = Selector.GetHandle("indexPath");

	private static readonly IntPtr selIsLeafHandle = Selector.GetHandle("isLeaf");

	private static readonly IntPtr selChildNodesHandle = Selector.GetHandle("childNodes");

	private static readonly IntPtr selParentNodeHandle = Selector.GetHandle("parentNode");

	private static readonly IntPtr selTreeNodeWithRepresentedObject_Handle = Selector.GetHandle("treeNodeWithRepresentedObject:");

	private static readonly IntPtr selInitWithRepresentedObject_Handle = Selector.GetHandle("initWithRepresentedObject:");

	private static readonly IntPtr selDescendantNodeAtIndexPath_Handle = Selector.GetHandle("descendantNodeAtIndexPath:");

	private static readonly IntPtr selSortWithSortDescriptorsRecursively_Handle = Selector.GetHandle("sortWithSortDescriptors:recursively:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSTreeNode");

	private object __mt_RepresentedObject_var;

	private object __mt_IndexPath_var;

	private object __mt_Children_var;

	private object __mt_ParentNode_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSObject RepresentedObject
	{
		[Export("representedObject")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_RepresentedObject_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRepresentedObjectHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRepresentedObjectHandle))));
		}
	}

	public virtual NSIndexPath IndexPath
	{
		[Export("indexPath")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSIndexPath)(__mt_IndexPath_var = ((!IsDirectBinding) ? ((NSIndexPath)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIndexPathHandle))) : ((NSIndexPath)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selIndexPathHandle)))));
		}
	}

	public virtual bool IsLeaf
	{
		[Export("isLeaf")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLeafHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLeafHandle);
		}
	}

	public virtual NSTreeNode[] Children
	{
		[Export("childNodes")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTreeNode[])(__mt_Children_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSTreeNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChildNodesHandle)) : NSArray.ArrayFromHandle<NSTreeNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selChildNodesHandle))));
		}
	}

	public virtual NSTreeNode ParentNode
	{
		[Export("parentNode")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTreeNode)(__mt_ParentNode_var = ((!IsDirectBinding) ? ((NSTreeNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentNodeHandle))) : ((NSTreeNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selParentNodeHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTreeNode()
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
	public NSTreeNode(NSCoder coder)
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
	public NSTreeNode(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSTreeNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("treeNodeWithRepresentedObject:")]
	public static NSTreeNode FromRepresentedObject(NSObject modelObject)
	{
		NSApplication.EnsureUIThread();
		if (modelObject == null)
		{
			throw new ArgumentNullException("modelObject");
		}
		return (NSTreeNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTreeNodeWithRepresentedObject_Handle, modelObject.Handle));
	}

	[Export("initWithRepresentedObject:")]
	public NSTreeNode(NSObject modelObject)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (modelObject == null)
		{
			throw new ArgumentNullException("modelObject");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithRepresentedObject_Handle, modelObject.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithRepresentedObject_Handle, modelObject.Handle);
		}
	}

	[Export("descendantNodeAtIndexPath:")]
	public virtual NSTreeNode DescendantNode(NSIndexPath atIndexPath)
	{
		NSApplication.EnsureUIThread();
		if (atIndexPath == null)
		{
			throw new ArgumentNullException("atIndexPath");
		}
		if (IsDirectBinding)
		{
			return (NSTreeNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDescendantNodeAtIndexPath_Handle, atIndexPath.Handle));
		}
		return (NSTreeNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDescendantNodeAtIndexPath_Handle, atIndexPath.Handle));
	}

	[Export("sortWithSortDescriptors:recursively:")]
	public virtual void SortWithSortDescriptors(NSSortDescriptor[] sortDescriptors, bool recursively)
	{
		NSApplication.EnsureUIThread();
		if (sortDescriptors == null)
		{
			throw new ArgumentNullException("sortDescriptors");
		}
		NSArray nSArray = NSArray.FromNSObjects(sortDescriptors);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSortWithSortDescriptorsRecursively_Handle, nSArray.Handle, recursively);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSortWithSortDescriptorsRecursively_Handle, nSArray.Handle, recursively);
		}
		nSArray.Dispose();
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_RepresentedObject_var = null;
			__mt_IndexPath_var = null;
			__mt_Children_var = null;
			__mt_ParentNode_var = null;
		}
	}
}

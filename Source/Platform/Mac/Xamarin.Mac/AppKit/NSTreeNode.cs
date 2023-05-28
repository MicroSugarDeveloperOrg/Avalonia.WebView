using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSTreeNode", true)]
public class NSTreeNode : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChildNodes = "childNodes";

	private static readonly IntPtr selChildNodesHandle = Selector.GetHandle("childNodes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescendantNodeAtIndexPath_ = "descendantNodeAtIndexPath:";

	private static readonly IntPtr selDescendantNodeAtIndexPath_Handle = Selector.GetHandle("descendantNodeAtIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexPath = "indexPath";

	private static readonly IntPtr selIndexPathHandle = Selector.GetHandle("indexPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRepresentedObject_ = "initWithRepresentedObject:";

	private static readonly IntPtr selInitWithRepresentedObject_Handle = Selector.GetHandle("initWithRepresentedObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsLeaf = "isLeaf";

	private static readonly IntPtr selIsLeafHandle = Selector.GetHandle("isLeaf");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParentNode = "parentNode";

	private static readonly IntPtr selParentNodeHandle = Selector.GetHandle("parentNode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRepresentedObject = "representedObject";

	private static readonly IntPtr selRepresentedObjectHandle = Selector.GetHandle("representedObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSortWithSortDescriptors_Recursively_ = "sortWithSortDescriptors:recursively:";

	private static readonly IntPtr selSortWithSortDescriptors_Recursively_Handle = Selector.GetHandle("sortWithSortDescriptors:recursively:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTreeNodeWithRepresentedObject_ = "treeNodeWithRepresentedObject:";

	private static readonly IntPtr selTreeNodeWithRepresentedObject_Handle = Selector.GetHandle("treeNodeWithRepresentedObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTreeNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTreeNode[] Children
	{
		[Export("childNodes")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSTreeNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selChildNodesHandle));
			}
			return NSArray.ArrayFromHandle<NSTreeNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChildNodesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexPath IndexPath
	{
		[Export("indexPath")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSend(base.Handle, selIndexPathHandle));
			}
			return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIndexPathHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsLeaf
	{
		[Export("isLeaf")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLeafHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLeafHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTreeNode ParentNode
	{
		[Export("parentNode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTreeNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selParentNodeHandle));
			}
			return Runtime.GetNSObject<NSTreeNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentNodeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject RepresentedObject
	{
		[Export("representedObject")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selRepresentedObjectHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRepresentedObjectHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTreeNode()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSTreeNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTreeNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRepresentedObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTreeNode(NSObject modelObject)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (modelObject == null)
		{
			throw new ArgumentNullException("modelObject");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithRepresentedObject_Handle, modelObject.Handle), "initWithRepresentedObject:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithRepresentedObject_Handle, modelObject.Handle), "initWithRepresentedObject:");
		}
	}

	[Export("descendantNodeAtIndexPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTreeNode DescendantNode(NSIndexPath atIndexPath)
	{
		NSApplication.EnsureUIThread();
		if (atIndexPath == null)
		{
			throw new ArgumentNullException("atIndexPath");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSTreeNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDescendantNodeAtIndexPath_Handle, atIndexPath.Handle));
		}
		return Runtime.GetNSObject<NSTreeNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDescendantNodeAtIndexPath_Handle, atIndexPath.Handle));
	}

	[Export("treeNodeWithRepresentedObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTreeNode FromRepresentedObject(NSObject modelObject)
	{
		NSApplication.EnsureUIThread();
		if (modelObject == null)
		{
			throw new ArgumentNullException("modelObject");
		}
		return Runtime.GetNSObject<NSTreeNode>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selTreeNodeWithRepresentedObject_Handle, modelObject.Handle));
	}

	[Export("sortWithSortDescriptors:recursively:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SortWithSortDescriptors(NSSortDescriptor[] sortDescriptors, bool recursively)
	{
		NSApplication.EnsureUIThread();
		if (sortDescriptors == null)
		{
			throw new ArgumentNullException("sortDescriptors");
		}
		NSArray nSArray = NSArray.FromNSObjects(sortDescriptors);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool(base.Handle, selSortWithSortDescriptors_Recursively_Handle, nSArray.Handle, recursively);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selSortWithSortDescriptors_Recursively_Handle, nSArray.Handle, recursively);
		}
		nSArray.Dispose();
	}
}

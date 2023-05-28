using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace GameplayKit;

[Register("GKQuadtree", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class GKQuadTree : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddElement_WithPoint_ = "addElement:withPoint:";

	private static readonly IntPtr selAddElement_WithPoint_Handle = Selector.GetHandle("addElement:withPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddElement_WithQuad_ = "addElement:withQuad:";

	private static readonly IntPtr selAddElement_WithQuad_Handle = Selector.GetHandle("addElement:withQuad:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementsAtPoint_ = "elementsAtPoint:";

	private static readonly IntPtr selElementsAtPoint_Handle = Selector.GetHandle("elementsAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementsInQuad_ = "elementsInQuad:";

	private static readonly IntPtr selElementsInQuad_Handle = Selector.GetHandle("elementsInQuad:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithBoundingQuad_MinimumCellSize_ = "initWithBoundingQuad:minimumCellSize:";

	private static readonly IntPtr selInitWithBoundingQuad_MinimumCellSize_Handle = Selector.GetHandle("initWithBoundingQuad:minimumCellSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuadtreeWithBoundingQuad_MinimumCellSize_ = "quadtreeWithBoundingQuad:minimumCellSize:";

	private static readonly IntPtr selQuadtreeWithBoundingQuad_MinimumCellSize_Handle = Selector.GetHandle("quadtreeWithBoundingQuad:minimumCellSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveElement_ = "removeElement:";

	private static readonly IntPtr selRemoveElement_Handle = Selector.GetHandle("removeElement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveElement_WithNode_ = "removeElement:withNode:";

	private static readonly IntPtr selRemoveElement_WithNode_Handle = Selector.GetHandle("removeElement:withNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKQuadtree");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKQuadTree(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKQuadTree(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithBoundingQuad:minimumCellSize:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKQuadTree(GKQuad quad, float minCellSize)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_GKQuad_float(base.Handle, selInitWithBoundingQuad_MinimumCellSize_Handle, quad, minCellSize), "initWithBoundingQuad:minimumCellSize:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_GKQuad_float(base.SuperHandle, selInitWithBoundingQuad_MinimumCellSize_Handle, quad, minCellSize), "initWithBoundingQuad:minimumCellSize:");
		}
	}

	[Export("addElement:withPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKQuadTreeNode AddElement(NSObject element, Vector2 point)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<GKQuadTreeNode>(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_Vector2(base.Handle, selAddElement_WithPoint_Handle, element.Handle, point));
		}
		return Runtime.GetNSObject<GKQuadTreeNode>(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_Vector2(base.SuperHandle, selAddElement_WithPoint_Handle, element.Handle, point));
	}

	[Export("addElement:withQuad:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKQuadTreeNode AddElement(NSObject element, GKQuad quad)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<GKQuadTreeNode>(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_GKQuad(base.Handle, selAddElement_WithQuad_Handle, element.Handle, quad));
		}
		return Runtime.GetNSObject<GKQuadTreeNode>(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_GKQuad(base.SuperHandle, selAddElement_WithQuad_Handle, element.Handle, quad));
	}

	[Export("quadtreeWithBoundingQuad:minimumCellSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKQuadTree FromBoundingQuad(GKQuad quad, float minCellSize)
	{
		return Runtime.GetNSObject<GKQuadTree>(Messaging.xamarin_simd__IntPtr_objc_msgSend_GKQuad_float(class_ptr, selQuadtreeWithBoundingQuad_MinimumCellSize_Handle, quad, minCellSize));
	}

	[Export("elementsAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] GetElements(Vector2 point)
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSObject>(Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector2(base.Handle, selElementsAtPoint_Handle, point));
		}
		return NSArray.ArrayFromHandle<NSObject>(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector2(base.SuperHandle, selElementsAtPoint_Handle, point));
	}

	[Export("elementsInQuad:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] GetElements(GKQuad quad)
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSObject>(Messaging.xamarin_simd__IntPtr_objc_msgSend_GKQuad(base.Handle, selElementsInQuad_Handle, quad));
		}
		return NSArray.ArrayFromHandle<NSObject>(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_GKQuad(base.SuperHandle, selElementsInQuad_Handle, quad));
	}

	[Export("removeElement:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RemoveElement(NSObject element)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selRemoveElement_Handle, element.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveElement_Handle, element.Handle);
	}

	[Export("removeElement:withNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RemoveElement(NSObject data, GKQuadTreeNode node)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selRemoveElement_WithNode_Handle, data.Handle, node.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRemoveElement_WithNode_Handle, data.Handle, node.Handle);
	}
}

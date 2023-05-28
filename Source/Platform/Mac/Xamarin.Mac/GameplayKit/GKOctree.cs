using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace GameplayKit;

[Register("GKOctree", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class GKOctree<ElementType> : NSObject where ElementType : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddElement_WithBox_ = "addElement:withBox:";

	private static readonly IntPtr selAddElement_WithBox_Handle = Selector.GetHandle("addElement:withBox:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddElement_WithPoint_ = "addElement:withPoint:";

	private static readonly IntPtr selAddElement_WithPoint_Handle = Selector.GetHandle("addElement:withPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementsAtPoint_ = "elementsAtPoint:";

	private static readonly IntPtr selElementsAtPoint_Handle = Selector.GetHandle("elementsAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementsInBox_ = "elementsInBox:";

	private static readonly IntPtr selElementsInBox_Handle = Selector.GetHandle("elementsInBox:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithBoundingBox_MinimumCellSize_ = "initWithBoundingBox:minimumCellSize:";

	private static readonly IntPtr selInitWithBoundingBox_MinimumCellSize_Handle = Selector.GetHandle("initWithBoundingBox:minimumCellSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOctreeWithBoundingBox_MinimumCellSize_ = "octreeWithBoundingBox:minimumCellSize:";

	private static readonly IntPtr selOctreeWithBoundingBox_MinimumCellSize_Handle = Selector.GetHandle("octreeWithBoundingBox:minimumCellSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveElement_ = "removeElement:";

	private static readonly IntPtr selRemoveElement_Handle = Selector.GetHandle("removeElement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveElement_WithNode_ = "removeElement:withNode:";

	private static readonly IntPtr selRemoveElement_WithNode_Handle = Selector.GetHandle("removeElement:withNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKOctree");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKOctree()
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
	protected GKOctree(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKOctree(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithBoundingBox:minimumCellSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKOctree(GKBox box, float minCellSize)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_GKBox_float(base.Handle, selInitWithBoundingBox_MinimumCellSize_Handle, box, minCellSize), "initWithBoundingBox:minimumCellSize:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_GKBox_float(base.SuperHandle, selInitWithBoundingBox_MinimumCellSize_Handle, box, minCellSize), "initWithBoundingBox:minimumCellSize:");
		}
	}

	[Export("addElement:withPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKOctreeNode AddElement(ElementType element, Vector3 point)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<GKOctreeNode>(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_Vector3(base.Handle, selAddElement_WithPoint_Handle, element.Handle, point));
		}
		return Runtime.GetNSObject<GKOctreeNode>(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_Vector3(base.SuperHandle, selAddElement_WithPoint_Handle, element.Handle, point));
	}

	[Export("addElement:withBox:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKOctreeNode AddElement(ElementType element, GKBox box)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<GKOctreeNode>(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_GKBox(base.Handle, selAddElement_WithBox_Handle, element.Handle, box));
		}
		return Runtime.GetNSObject<GKOctreeNode>(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_GKBox(base.SuperHandle, selAddElement_WithBox_Handle, element.Handle, box));
	}

	[Export("octreeWithBoundingBox:minimumCellSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKOctree<ElementType> FromBoundingBox(GKBox box, float minCellSize)
	{
		return Runtime.GetNSObject<GKOctree<ElementType>>(Messaging.xamarin_simd__IntPtr_objc_msgSend_GKBox_float(class_ptr, selOctreeWithBoundingBox_MinimumCellSize_Handle, box, minCellSize));
	}

	[Export("elementsAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ElementType[] GetElements(Vector3 point)
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<ElementType>(Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector3(base.Handle, selElementsAtPoint_Handle, point));
		}
		return NSArray.ArrayFromHandle<ElementType>(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector3(base.SuperHandle, selElementsAtPoint_Handle, point));
	}

	[Export("elementsInBox:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ElementType[] GetElements(GKBox box)
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<ElementType>(Messaging.xamarin_simd__IntPtr_objc_msgSend_GKBox(base.Handle, selElementsInBox_Handle, box));
		}
		return NSArray.ArrayFromHandle<ElementType>(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_GKBox(base.SuperHandle, selElementsInBox_Handle, box));
	}

	[Export("removeElement:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RemoveElement(ElementType element)
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
	public virtual bool RemoveElement(ElementType element, GKOctreeNode node)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selRemoveElement_WithNode_Handle, element.Handle, node.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRemoveElement_WithNode_Handle, element.Handle, node.Handle);
	}
}

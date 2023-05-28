using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;
using Xamarin.Mac.System.Mac;

namespace GameplayKit;

[Register("GKRTree", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class GKRTree<ElementType> : NSObject where ElementType : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddElement_BoundingRectMin_BoundingRectMax_SplitStrategy_ = "addElement:boundingRectMin:boundingRectMax:splitStrategy:";

	private static readonly IntPtr selAddElement_BoundingRectMin_BoundingRectMax_SplitStrategy_Handle = Selector.GetHandle("addElement:boundingRectMin:boundingRectMax:splitStrategy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementsInBoundingRectMin_RectMax_ = "elementsInBoundingRectMin:rectMax:";

	private static readonly IntPtr selElementsInBoundingRectMin_RectMax_Handle = Selector.GetHandle("elementsInBoundingRectMin:rectMax:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMaxNumberOfChildren_ = "initWithMaxNumberOfChildren:";

	private static readonly IntPtr selInitWithMaxNumberOfChildren_Handle = Selector.GetHandle("initWithMaxNumberOfChildren:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQueryReserve = "queryReserve";

	private static readonly IntPtr selQueryReserveHandle = Selector.GetHandle("queryReserve");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveElement_BoundingRectMin_BoundingRectMax_ = "removeElement:boundingRectMin:boundingRectMax:";

	private static readonly IntPtr selRemoveElement_BoundingRectMin_BoundingRectMax_Handle = Selector.GetHandle("removeElement:boundingRectMin:boundingRectMax:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetQueryReserve_ = "setQueryReserve:";

	private static readonly IntPtr selSetQueryReserve_Handle = Selector.GetHandle("setQueryReserve:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTreeWithMaxNumberOfChildren_ = "treeWithMaxNumberOfChildren:";

	private static readonly IntPtr selTreeWithMaxNumberOfChildren_Handle = Selector.GetHandle("treeWithMaxNumberOfChildren:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKRTree");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint QueryReserve
	{
		[Export("queryReserve")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selQueryReserveHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selQueryReserveHandle);
		}
		[Export("setQueryReserve:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetQueryReserve_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetQueryReserve_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKRTree(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKRTree(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithMaxNumberOfChildren:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKRTree(nuint maxNumberOfChildren)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selInitWithMaxNumberOfChildren_Handle, maxNumberOfChildren), "initWithMaxNumberOfChildren:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selInitWithMaxNumberOfChildren_Handle, maxNumberOfChildren), "initWithMaxNumberOfChildren:");
		}
	}

	[Export("addElement:boundingRectMin:boundingRectMax:splitStrategy:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddElement(ElementType element, Vector2 boundingRectMin, Vector2 boundingRectMax, GKRTreeSplitStrategy splitStrategy)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_IntPtr_Vector2_Vector2_Int64(base.Handle, selAddElement_BoundingRectMin_BoundingRectMax_SplitStrategy_Handle, element.Handle, boundingRectMin, boundingRectMax, (long)splitStrategy);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_IntPtr_Vector2_Vector2_Int64(base.SuperHandle, selAddElement_BoundingRectMin_BoundingRectMax_SplitStrategy_Handle, element.Handle, boundingRectMin, boundingRectMax, (long)splitStrategy);
		}
	}

	[Export("treeWithMaxNumberOfChildren:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKRTree<ElementType> FromMaxNumberOfChildren(nuint maxNumberOfChildren)
	{
		return Runtime.GetNSObject<GKRTree<ElementType>>(Messaging.IntPtr_objc_msgSend_nuint(class_ptr, selTreeWithMaxNumberOfChildren_Handle, maxNumberOfChildren));
	}

	[Export("elementsInBoundingRectMin:rectMax:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ElementType[] GetElements(Vector2 rectMin, Vector2 rectMax)
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<ElementType>(Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector2_Vector2(base.Handle, selElementsInBoundingRectMin_RectMax_Handle, rectMin, rectMax));
		}
		return NSArray.ArrayFromHandle<ElementType>(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector2_Vector2(base.SuperHandle, selElementsInBoundingRectMin_RectMax_Handle, rectMin, rectMax));
	}

	[Export("removeElement:boundingRectMin:boundingRectMax:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveElement(ElementType element, Vector2 boundingRectMin, Vector2 boundingRectMax)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_IntPtr_Vector2_Vector2(base.Handle, selRemoveElement_BoundingRectMin_BoundingRectMax_Handle, element.Handle, boundingRectMin, boundingRectMax);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_IntPtr_Vector2_Vector2(base.SuperHandle, selRemoveElement_BoundingRectMin_BoundingRectMax_Handle, element.Handle, boundingRectMin, boundingRectMax);
		}
	}
}

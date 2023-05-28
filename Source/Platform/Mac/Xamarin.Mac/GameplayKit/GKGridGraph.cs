using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;
using Xamarin.Mac.System.Mac;

namespace GameplayKit;

[Register("GKGridGraph", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class GKGridGraph : GKGraph
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClassForGenericArgumentAtIndex_ = "classForGenericArgumentAtIndex:";

	private static readonly IntPtr selClassForGenericArgumentAtIndex_Handle = Selector.GetHandle("classForGenericArgumentAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectNodeToAdjacentNodes_ = "connectNodeToAdjacentNodes:";

	private static readonly IntPtr selConnectNodeToAdjacentNodes_Handle = Selector.GetHandle("connectNodeToAdjacentNodes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiagonalsAllowed = "diagonalsAllowed";

	private static readonly IntPtr selDiagonalsAllowedHandle = Selector.GetHandle("diagonalsAllowed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGraphFromGridStartingAt_Width_Height_DiagonalsAllowed_ = "graphFromGridStartingAt:width:height:diagonalsAllowed:";

	private static readonly IntPtr selGraphFromGridStartingAt_Width_Height_DiagonalsAllowed_Handle = Selector.GetHandle("graphFromGridStartingAt:width:height:diagonalsAllowed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGraphFromGridStartingAt_Width_Height_DiagonalsAllowed_NodeClass_ = "graphFromGridStartingAt:width:height:diagonalsAllowed:nodeClass:";

	private static readonly IntPtr selGraphFromGridStartingAt_Width_Height_DiagonalsAllowed_NodeClass_Handle = Selector.GetHandle("graphFromGridStartingAt:width:height:diagonalsAllowed:nodeClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGridHeight = "gridHeight";

	private static readonly IntPtr selGridHeightHandle = Selector.GetHandle("gridHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGridOrigin = "gridOrigin";

	private static readonly IntPtr selGridOriginHandle = Selector.GetHandle("gridOrigin");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGridWidth = "gridWidth";

	private static readonly IntPtr selGridWidthHandle = Selector.GetHandle("gridWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitFromGridStartingAt_Width_Height_DiagonalsAllowed_ = "initFromGridStartingAt:width:height:diagonalsAllowed:";

	private static readonly IntPtr selInitFromGridStartingAt_Width_Height_DiagonalsAllowed_Handle = Selector.GetHandle("initFromGridStartingAt:width:height:diagonalsAllowed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitFromGridStartingAt_Width_Height_DiagonalsAllowed_NodeClass_ = "initFromGridStartingAt:width:height:diagonalsAllowed:nodeClass:";

	private static readonly IntPtr selInitFromGridStartingAt_Width_Height_DiagonalsAllowed_NodeClass_Handle = Selector.GetHandle("initFromGridStartingAt:width:height:diagonalsAllowed:nodeClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeAtGridPosition_ = "nodeAtGridPosition:";

	private static readonly IntPtr selNodeAtGridPosition_Handle = Selector.GetHandle("nodeAtGridPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKGridGraph");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DiagonalsAllowed
	{
		[Export("diagonalsAllowed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDiagonalsAllowedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDiagonalsAllowedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GridHeight
	{
		[Export("gridHeight")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selGridHeightHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selGridHeightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector2i GridOrigin
	{
		[Export("gridOrigin")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__Vector2i_objc_msgSend(base.Handle, selGridOriginHandle);
			}
			return Messaging.xamarin_simd__Vector2i_objc_msgSendSuper(base.SuperHandle, selGridOriginHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GridWidth
	{
		[Export("gridWidth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selGridWidthHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selGridWidthHandle);
		}
	}

	public virtual GKGridGraphNode GetNodeAt(Vector2i position)
	{
		return GetNodeAt<GKGridGraphNode>(position);
	}

	public NodeType GetNodeAt<NodeType>(Vector2i position) where NodeType : GKGridGraphNode
	{
		return Runtime.GetNSObject<NodeType>(_GetNodeAt(position));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKGridGraph()
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
	public GKGridGraph(NSCoder coder)
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
	protected GKGridGraph(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKGridGraph(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initFromGridStartingAt:width:height:diagonalsAllowed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKGridGraph(Vector2i position, int width, int height, bool diagonalsAllowed)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector2i_int_int_bool(base.Handle, selInitFromGridStartingAt_Width_Height_DiagonalsAllowed_Handle, position, width, height, diagonalsAllowed), "initFromGridStartingAt:width:height:diagonalsAllowed:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector2i_int_int_bool(base.SuperHandle, selInitFromGridStartingAt_Width_Height_DiagonalsAllowed_Handle, position, width, height, diagonalsAllowed), "initFromGridStartingAt:width:height:diagonalsAllowed:");
		}
	}

	[Export("initFromGridStartingAt:width:height:diagonalsAllowed:nodeClass:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKGridGraph(Vector2i position, int width, int height, bool diagonalsAllowed, Class aClass)
		: base(NSObjectFlag.Empty)
	{
		if (aClass == null)
		{
			throw new ArgumentNullException("aClass");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector2i_int_int_bool_IntPtr(base.Handle, selInitFromGridStartingAt_Width_Height_DiagonalsAllowed_NodeClass_Handle, position, width, height, diagonalsAllowed, aClass.Handle), "initFromGridStartingAt:width:height:diagonalsAllowed:nodeClass:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector2i_int_int_bool_IntPtr(base.SuperHandle, selInitFromGridStartingAt_Width_Height_DiagonalsAllowed_NodeClass_Handle, position, width, height, diagonalsAllowed, aClass.Handle), "initFromGridStartingAt:width:height:diagonalsAllowed:nodeClass:");
		}
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKGridGraph(Vector2i position, int width, int height, bool diagonalsAllowed, Type nodeType)
		: this(position, width, height, diagonalsAllowed, new Class(nodeType))
	{
	}

	[Export("connectNodeToAdjacentNodes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ConnectNodeToAdjacentNodes(GKGridGraphNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selConnectNodeToAdjacentNodes_Handle, node.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selConnectNodeToAdjacentNodes_Handle, node.Handle);
		}
	}

	[Export("graphFromGridStartingAt:width:height:diagonalsAllowed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKGridGraph FromGridStartingAt(Vector2i position, int width, int height, bool diagonalsAllowed)
	{
		return Runtime.GetNSObject<GKGridGraph>(Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector2i_int_int_bool(class_ptr, selGraphFromGridStartingAt_Width_Height_DiagonalsAllowed_Handle, position, width, height, diagonalsAllowed));
	}

	[Export("graphFromGridStartingAt:width:height:diagonalsAllowed:nodeClass:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKGridGraph FromGridStartingAt(Vector2i position, int width, int height, bool diagonalsAllowed, Class aClass)
	{
		if (aClass == null)
		{
			throw new ArgumentNullException("aClass");
		}
		return Runtime.GetNSObject<GKGridGraph>(Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector2i_int_int_bool_IntPtr(class_ptr, selGraphFromGridStartingAt_Width_Height_DiagonalsAllowed_NodeClass_Handle, position, width, height, diagonalsAllowed, aClass.Handle));
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKGridGraph FromGridStartingAt(Vector2i position, int width, int height, bool diagonalsAllowed, Type type)
	{
		return FromGridStartingAt(position, width, height, diagonalsAllowed, new Class(type));
	}

	[Export("classForGenericArgumentAtIndex:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Class GetClassForGenericArgument(nuint index)
	{
		IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selClassForGenericArgumentAtIndex_Handle, index) : Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selClassForGenericArgumentAtIndex_Handle, index));
		return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Type GetTypeForGenericArgument(nuint index)
	{
		return ObjCRuntime.Class.Lookup(GetClassForGenericArgument(index));
	}

	[Export("nodeAtGridPosition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr _GetNodeAt(Vector2i position)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector2i(base.Handle, selNodeAtGridPosition_Handle, position);
		}
		return Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector2i(base.SuperHandle, selNodeAtGridPosition_Handle, position);
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace GameplayKit;

[Register("GKMeshGraph", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class GKMeshGraph<NodeType> : GKGraph where NodeType : GKGraphNode2D
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddObstacles_ = "addObstacles:";

	private static readonly IntPtr selAddObstacles_Handle = Selector.GetHandle("addObstacles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBufferRadius = "bufferRadius";

	private static readonly IntPtr selBufferRadiusHandle = Selector.GetHandle("bufferRadius");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClassForGenericArgumentAtIndex_ = "classForGenericArgumentAtIndex:";

	private static readonly IntPtr selClassForGenericArgumentAtIndex_Handle = Selector.GetHandle("classForGenericArgumentAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectNodeUsingObstacles_ = "connectNodeUsingObstacles:";

	private static readonly IntPtr selConnectNodeUsingObstacles_Handle = Selector.GetHandle("connectNodeUsingObstacles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGraphWithBufferRadius_MinCoordinate_MaxCoordinate_ = "graphWithBufferRadius:minCoordinate:maxCoordinate:";

	private static readonly IntPtr selGraphWithBufferRadius_MinCoordinate_MaxCoordinate_Handle = Selector.GetHandle("graphWithBufferRadius:minCoordinate:maxCoordinate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGraphWithBufferRadius_MinCoordinate_MaxCoordinate_NodeClass_ = "graphWithBufferRadius:minCoordinate:maxCoordinate:nodeClass:";

	private static readonly IntPtr selGraphWithBufferRadius_MinCoordinate_MaxCoordinate_NodeClass_Handle = Selector.GetHandle("graphWithBufferRadius:minCoordinate:maxCoordinate:nodeClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithBufferRadius_MinCoordinate_MaxCoordinate_ = "initWithBufferRadius:minCoordinate:maxCoordinate:";

	private static readonly IntPtr selInitWithBufferRadius_MinCoordinate_MaxCoordinate_Handle = Selector.GetHandle("initWithBufferRadius:minCoordinate:maxCoordinate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithBufferRadius_MinCoordinate_MaxCoordinate_NodeClass_ = "initWithBufferRadius:minCoordinate:maxCoordinate:nodeClass:";

	private static readonly IntPtr selInitWithBufferRadius_MinCoordinate_MaxCoordinate_NodeClass_Handle = Selector.GetHandle("initWithBufferRadius:minCoordinate:maxCoordinate:nodeClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObstacles = "obstacles";

	private static readonly IntPtr selObstaclesHandle = Selector.GetHandle("obstacles");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObstacles_ = "removeObstacles:";

	private static readonly IntPtr selRemoveObstacles_Handle = Selector.GetHandle("removeObstacles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTriangulationMode_ = "setTriangulationMode:";

	private static readonly IntPtr selSetTriangulationMode_Handle = Selector.GetHandle("setTriangulationMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTriangleAtIndex_ = "triangleAtIndex:";

	private static readonly IntPtr selTriangleAtIndex_Handle = Selector.GetHandle("triangleAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTriangleCount = "triangleCount";

	private static readonly IntPtr selTriangleCountHandle = Selector.GetHandle("triangleCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTriangulate = "triangulate";

	private static readonly IntPtr selTriangulateHandle = Selector.GetHandle("triangulate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTriangulationMode = "triangulationMode";

	private static readonly IntPtr selTriangulationModeHandle = Selector.GetHandle("triangulationMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKMeshGraph");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float BufferRadius
	{
		[Export("bufferRadius")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selBufferRadiusHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selBufferRadiusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKPolygonObstacle[] Obstacles
	{
		[Export("obstacles")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<GKPolygonObstacle>(Messaging.IntPtr_objc_msgSend(base.Handle, selObstaclesHandle));
			}
			return NSArray.ArrayFromHandle<GKPolygonObstacle>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObstaclesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint TriangleCount
	{
		[Export("triangleCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selTriangleCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selTriangleCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKMeshGraphTriangulationMode TriangulationMode
	{
		[Export("triangulationMode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (GKMeshGraphTriangulationMode)Messaging.UInt64_objc_msgSend(base.Handle, selTriangulationModeHandle);
			}
			return (GKMeshGraphTriangulationMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selTriangulationModeHandle);
		}
		[Export("setTriangulationMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetTriangulationMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetTriangulationMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKMeshGraph()
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
	public GKMeshGraph(NSCoder coder)
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
	protected GKMeshGraph(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKMeshGraph(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithBufferRadius:minCoordinate:maxCoordinate:nodeClass:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKMeshGraph(float bufferRadius, Vector2 min, Vector2 max, Class nodeClass)
		: base(NSObjectFlag.Empty)
	{
		if (nodeClass == null)
		{
			throw new ArgumentNullException("nodeClass");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_float_Vector2_Vector2_IntPtr(base.Handle, selInitWithBufferRadius_MinCoordinate_MaxCoordinate_NodeClass_Handle, bufferRadius, min, max, nodeClass.Handle), "initWithBufferRadius:minCoordinate:maxCoordinate:nodeClass:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_float_Vector2_Vector2_IntPtr(base.SuperHandle, selInitWithBufferRadius_MinCoordinate_MaxCoordinate_NodeClass_Handle, bufferRadius, min, max, nodeClass.Handle), "initWithBufferRadius:minCoordinate:maxCoordinate:nodeClass:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKMeshGraph(float bufferRadius, Vector2 min, Vector2 max, Type nodeType)
		: this(bufferRadius, min, max, new Class(nodeType))
	{
	}

	[Export("initWithBufferRadius:minCoordinate:maxCoordinate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKMeshGraph(float bufferRadius, Vector2 min, Vector2 max)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_float_Vector2_Vector2(base.Handle, selInitWithBufferRadius_MinCoordinate_MaxCoordinate_Handle, bufferRadius, min, max), "initWithBufferRadius:minCoordinate:maxCoordinate:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_float_Vector2_Vector2(base.SuperHandle, selInitWithBufferRadius_MinCoordinate_MaxCoordinate_Handle, bufferRadius, min, max), "initWithBufferRadius:minCoordinate:maxCoordinate:");
		}
	}

	[Export("addObstacles:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddObstacles(GKPolygonObstacle[] obstacles)
	{
		if (obstacles == null)
		{
			throw new ArgumentNullException("obstacles");
		}
		NSArray nSArray = NSArray.FromNSObjects(obstacles);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddObstacles_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddObstacles_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("connectNodeUsingObstacles:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ConnectNodeUsingObstacles(NodeType node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selConnectNodeUsingObstacles_Handle, node.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selConnectNodeUsingObstacles_Handle, node.Handle);
		}
	}

	[Export("graphWithBufferRadius:minCoordinate:maxCoordinate:nodeClass:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKMeshGraph<NodeType> FromBufferRadius(float bufferRadius, Vector2 min, Vector2 max, Class nodeClass)
	{
		if (nodeClass == null)
		{
			throw new ArgumentNullException("nodeClass");
		}
		return Runtime.GetNSObject<GKMeshGraph<NodeType>>(Messaging.xamarin_simd__IntPtr_objc_msgSend_float_Vector2_Vector2_IntPtr(class_ptr, selGraphWithBufferRadius_MinCoordinate_MaxCoordinate_NodeClass_Handle, bufferRadius, min, max, nodeClass.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKMeshGraph<NodeType> FromBufferRadius(float bufferRadius, Vector2 min, Vector2 max, Type nodeType)
	{
		return FromBufferRadius(bufferRadius, min, max, new Class(nodeType));
	}

	[Export("graphWithBufferRadius:minCoordinate:maxCoordinate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKMeshGraph<NodeType> FromBufferRadius(float bufferRadius, Vector2 min, Vector2 max)
	{
		return Runtime.GetNSObject<GKMeshGraph<NodeType>>(Messaging.xamarin_simd__IntPtr_objc_msgSend_float_Vector2_Vector2(class_ptr, selGraphWithBufferRadius_MinCoordinate_MaxCoordinate_Handle, bufferRadius, min, max));
	}

	[Export("classForGenericArgumentAtIndex:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Class GetClassForGenericArgument(nuint index)
	{
		IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selClassForGenericArgumentAtIndex_Handle, index) : Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selClassForGenericArgumentAtIndex_Handle, index));
		return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
	}

	[Export("triangleAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKTriangle GetTriangle(nuint index)
	{
		GKTriangle retval;
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__GKTriangle_objc_msgSend_stret_nuint(out retval, base.Handle, selTriangleAtIndex_Handle, index);
		}
		else
		{
			Messaging.xamarin_simd__GKTriangle_objc_msgSendSuper_stret_nuint(out retval, base.SuperHandle, selTriangleAtIndex_Handle, index);
		}
		return retval;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Type GetTypeForGenericArgument(nuint index)
	{
		return ObjCRuntime.Class.Lookup(GetClassForGenericArgument(index));
	}

	[Export("removeObstacles:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveObstacles(GKPolygonObstacle[] obstacles)
	{
		if (obstacles == null)
		{
			throw new ArgumentNullException("obstacles");
		}
		NSArray nSArray = NSArray.FromNSObjects(obstacles);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObstacles_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObstacles_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("triangulate")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Triangulate()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selTriangulateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selTriangulateHandle);
		}
	}
}

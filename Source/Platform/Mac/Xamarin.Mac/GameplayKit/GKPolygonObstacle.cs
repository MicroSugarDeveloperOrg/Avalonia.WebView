using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace GameplayKit;

[Register("GKPolygonObstacle", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class GKPolygonObstacle : GKObstacle, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[ThreadStatic]
	private static IntPtr ctor_pointer;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPoints_Count_ = "initWithPoints:count:";

	private static readonly IntPtr selInitWithPoints_Count_Handle = Selector.GetHandle("initWithPoints:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObstacleWithPoints_Count_ = "obstacleWithPoints:count:";

	private static readonly IntPtr selObstacleWithPoints_Count_Handle = Selector.GetHandle("obstacleWithPoints:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVertexAtIndex_ = "vertexAtIndex:";

	private static readonly IntPtr selVertexAtIndex_Handle = Selector.GetHandle("vertexAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVertexCount = "vertexCount";

	private static readonly IntPtr selVertexCountHandle = Selector.GetHandle("vertexCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKPolygonObstacle");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint VertexCount
	{
		[Export("vertexCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selVertexCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selVertexCountHandle);
		}
	}

	public static GKPolygonObstacle FromPoints(Vector2[] points)
	{
		if (points == null)
		{
			throw new ArgumentNullException("points");
		}
		int num = Marshal.SizeOf(typeof(Vector2));
		int cb = points.Length * num;
		IntPtr intPtr = Marshal.AllocHGlobal(cb);
		try
		{
			for (int i = 0; i < points.Length; i++)
			{
				Marshal.StructureToPtr(points[i], IntPtr.Add(intPtr, i * num), fDeleteOld: false);
			}
			return FromPoints(intPtr, (nuint)points.Length);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	private static IntPtr GetPointer(Vector2[] points)
	{
		if (points == null)
		{
			throw new ArgumentNullException("points");
		}
		if (ctor_pointer != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(ctor_pointer);
			ctor_pointer = IntPtr.Zero;
		}
		int num = Marshal.SizeOf(typeof(Vector2));
		int cb = points.Length * num;
		IntPtr pointer = Marshal.AllocHGlobal(cb);
		for (int i = 0; i < points.Length; i++)
		{
			Marshal.StructureToPtr(points[i], IntPtr.Add(pointer, i * num), fDeleteOld: false);
		}
		ctor_pointer = pointer;
		return ctor_pointer = pointer;
	}

	public GKPolygonObstacle(Vector2[] points)
		: this(GetPointer(points), (nuint)points.Length)
	{
		if (ctor_pointer != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(ctor_pointer);
			ctor_pointer = IntPtr.Zero;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public GKPolygonObstacle(NSCoder coder)
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
	protected GKPolygonObstacle(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKPolygonObstacle(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPoints:count:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal GKPolygonObstacle(IntPtr points, nuint numPoints)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(base.Handle, selInitWithPoints_Count_Handle, points, numPoints), "initWithPoints:count:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selInitWithPoints_Count_Handle, points, numPoints), "initWithPoints:count:");
		}
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("obstacleWithPoints:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static GKPolygonObstacle FromPoints(IntPtr points, nuint numPoints)
	{
		return Runtime.GetNSObject<GKPolygonObstacle>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint(class_ptr, selObstacleWithPoints_Count_Handle, points, numPoints));
	}

	[Export("vertexAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector2 GetVertex(nuint index)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__Vector2_objc_msgSend_nuint(base.Handle, selVertexAtIndex_Handle, index);
		}
		return Messaging.xamarin_simd__Vector2_objc_msgSendSuper_nuint(base.SuperHandle, selVertexAtIndex_Handle, index);
	}
}

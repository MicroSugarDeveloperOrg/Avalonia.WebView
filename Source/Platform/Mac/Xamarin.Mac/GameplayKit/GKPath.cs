using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace GameplayKit;

[Register("GKPath", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class GKPath : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloat2AtIndex_ = "float2AtIndex:";

	private static readonly IntPtr selFloat2AtIndex_Handle = Selector.GetHandle("float2AtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloat3AtIndex_ = "float3AtIndex:";

	private static readonly IntPtr selFloat3AtIndex_Handle = Selector.GetHandle("float3AtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFloat3Points_Count_Radius_Cyclical_ = "initWithFloat3Points:count:radius:cyclical:";

	private static readonly IntPtr selInitWithFloat3Points_Count_Radius_Cyclical_Handle = Selector.GetHandle("initWithFloat3Points:count:radius:cyclical:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithGraphNodes_Radius_ = "initWithGraphNodes:radius:";

	private static readonly IntPtr selInitWithGraphNodes_Radius_Handle = Selector.GetHandle("initWithGraphNodes:radius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPoints_Count_Radius_Cyclical_ = "initWithPoints:count:radius:cyclical:";

	private static readonly IntPtr selInitWithPoints_Count_Radius_Cyclical_Handle = Selector.GetHandle("initWithPoints:count:radius:cyclical:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCyclical = "isCyclical";

	private static readonly IntPtr selIsCyclicalHandle = Selector.GetHandle("isCyclical");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumPoints = "numPoints";

	private static readonly IntPtr selNumPointsHandle = Selector.GetHandle("numPoints");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPathWithFloat3Points_Count_Radius_Cyclical_ = "pathWithFloat3Points:count:radius:cyclical:";

	private static readonly IntPtr selPathWithFloat3Points_Count_Radius_Cyclical_Handle = Selector.GetHandle("pathWithFloat3Points:count:radius:cyclical:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPathWithGraphNodes_Radius_ = "pathWithGraphNodes:radius:";

	private static readonly IntPtr selPathWithGraphNodes_Radius_Handle = Selector.GetHandle("pathWithGraphNodes:radius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPathWithPoints_Count_Radius_Cyclical_ = "pathWithPoints:count:radius:cyclical:";

	private static readonly IntPtr selPathWithPoints_Count_Radius_Cyclical_Handle = Selector.GetHandle("pathWithPoints:count:radius:cyclical:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPointAtIndex_ = "pointAtIndex:";

	private static readonly IntPtr selPointAtIndex_Handle = Selector.GetHandle("pointAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRadius = "radius";

	private static readonly IntPtr selRadiusHandle = Selector.GetHandle("radius");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCyclical_ = "setCyclical:";

	private static readonly IntPtr selSetCyclical_Handle = Selector.GetHandle("setCyclical:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRadius_ = "setRadius:";

	private static readonly IntPtr selSetRadius_Handle = Selector.GetHandle("setRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKPath");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Cyclical
	{
		[Export("isCyclical")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCyclicalHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCyclicalHandle);
		}
		[Export("setCyclical:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCyclical_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCyclical_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint NumPoints
	{
		[Export("numPoints")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNumPointsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNumPointsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Radius
	{
		[Export("radius")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selRadiusHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selRadiusHandle);
		}
		[Export("setRadius:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetRadius_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetRadius_Handle, value);
			}
		}
	}

	public static GKPath FromPoints(Vector2[] points, float radius, bool cyclical)
	{
		if (points == null)
		{
			throw new ArgumentNullException("points");
		}
		IntPtr buffer = IntPtr.Zero;
		try
		{
			PrepareBuffer(out buffer, ref points);
			return FromPoints(buffer, (nuint)points.Length, radius, cyclical);
		}
		finally
		{
			if (buffer != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(buffer);
			}
		}
	}

	[DesignatedInitializer]
	public GKPath(Vector2[] points, float radius, bool cyclical)
	{
		if (points == null)
		{
			throw new ArgumentNullException("points");
		}
		IntPtr buffer = IntPtr.Zero;
		try
		{
			PrepareBuffer(out buffer, ref points);
			base.Handle = InitWithPoints(buffer, (nuint)points.Length, radius, cyclical);
		}
		finally
		{
			if (buffer != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(buffer);
			}
		}
	}

	[iOS(10, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	public static GKPath FromPoints(Vector3[] points, float radius, bool cyclical)
	{
		if (points == null)
		{
			throw new ArgumentNullException("points");
		}
		IntPtr buffer = IntPtr.Zero;
		try
		{
			PrepareBuffer(out buffer, ref points);
			return FromFloat3Points(buffer, (nuint)points.Length, radius, cyclical);
		}
		finally
		{
			if (buffer != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(buffer);
			}
		}
	}

	[iOS(10, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	public GKPath(Vector3[] points, float radius, bool cyclical)
	{
		if (points == null)
		{
			throw new ArgumentNullException("points");
		}
		IntPtr buffer = IntPtr.Zero;
		try
		{
			PrepareBuffer(out buffer, ref points);
			base.Handle = InitWithFloat3Points(buffer, (nuint)points.Length, radius, cyclical);
		}
		finally
		{
			if (buffer != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(buffer);
			}
		}
	}

	private static void PrepareBuffer<T>(out IntPtr buffer, ref T[] points) where T : struct
	{
		Type typeFromHandle = typeof(T);
		int num = ((typeFromHandle == typeof(Vector3)) ? 16 : Marshal.SizeOf(typeFromHandle));
		int cb = points.Length * num;
		buffer = Marshal.AllocHGlobal(cb);
		for (int i = 0; i < points.Length; i++)
		{
			Marshal.StructureToPtr(points[i], IntPtr.Add(buffer, i * num), fDeleteOld: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKPath(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKPath(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithGraphNodes:radius:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKPath(GKGraphNode[] nodes, float radius)
		: base(NSObjectFlag.Empty)
	{
		if (nodes == null)
		{
			throw new ArgumentNullException("nodes");
		}
		NSArray nSArray = NSArray.FromNSObjects(nodes);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_float(base.Handle, selInitWithGraphNodes_Radius_Handle, nSArray.Handle, radius), "initWithGraphNodes:radius:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_float(base.SuperHandle, selInitWithGraphNodes_Radius_Handle, nSArray.Handle, radius), "initWithGraphNodes:radius:");
		}
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKPath(GKGraphNode2D[] graphNodes, float radius)
		: this((GKGraphNode[])graphNodes, radius)
	{
	}

	[Export("pathWithFloat3Points:count:radius:cyclical:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static GKPath FromFloat3Points(IntPtr points, nuint count, float radius, bool cyclical)
	{
		return Runtime.GetNSObject<GKPath>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_float_bool(class_ptr, selPathWithFloat3Points_Count_Radius_Cyclical_Handle, points, count, radius, cyclical));
	}

	[Export("pathWithGraphNodes:radius:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKPath FromGraphNodes(GKGraphNode[] nodes, float radius)
	{
		if (nodes == null)
		{
			throw new ArgumentNullException("nodes");
		}
		NSArray nSArray = NSArray.FromNSObjects(nodes);
		GKPath nSObject = Runtime.GetNSObject<GKPath>(Messaging.IntPtr_objc_msgSend_IntPtr_float(class_ptr, selPathWithGraphNodes_Radius_Handle, nSArray.Handle, radius));
		nSArray.Dispose();
		return nSObject;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKPath FromGraphNodes(GKGraphNode2D[] graphNodes, float radius)
	{
		return FromGraphNodes((GKGraphNode[])graphNodes, radius);
	}

	[Export("pathWithPoints:count:radius:cyclical:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static GKPath FromPoints(IntPtr points, nuint count, float radius, bool cyclical)
	{
		return Runtime.GetNSObject<GKPath>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_float_bool(class_ptr, selPathWithPoints_Count_Radius_Cyclical_Handle, points, count, radius, cyclical));
	}

	[Export("pointAtIndex:")]
	[Deprecated(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'GetVector2Point' instead.")]
	[Deprecated(PlatformName.TvOS, 10, 0, PlatformArchitecture.None, "Use 'GetVector2Point' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'GetVector2Point' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector2 GetPoint(nuint index)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__Vector2_objc_msgSend_nuint(base.Handle, selPointAtIndex_Handle, index);
		}
		return Messaging.xamarin_simd__Vector2_objc_msgSendSuper_nuint(base.SuperHandle, selPointAtIndex_Handle, index);
	}

	[Export("float2AtIndex:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector2 GetVector2Point(nuint index)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__Vector2_objc_msgSend_nuint(base.Handle, selFloat2AtIndex_Handle, index);
		}
		return Messaging.xamarin_simd__Vector2_objc_msgSendSuper_nuint(base.SuperHandle, selFloat2AtIndex_Handle, index);
	}

	[Export("float3AtIndex:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector3 GetVector3Point(nuint index)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__Vector3_objc_msgSend_nuint(base.Handle, selFloat3AtIndex_Handle, index);
		}
		return Messaging.xamarin_simd__Vector3_objc_msgSendSuper_nuint(base.SuperHandle, selFloat3AtIndex_Handle, index);
	}

	[Export("initWithFloat3Points:count:radius:cyclical:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithFloat3Points(IntPtr points, nuint count, float radius, bool cyclical)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_IntPtr_nuint_float_bool(base.Handle, selInitWithFloat3Points_Count_Radius_Cyclical_Handle, points, count, radius, cyclical);
		}
		return Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_float_bool(base.SuperHandle, selInitWithFloat3Points_Count_Radius_Cyclical_Handle, points, count, radius, cyclical);
	}

	[Export("initWithPoints:count:radius:cyclical:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithPoints(IntPtr points, nuint count, float radius, bool cyclical)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_IntPtr_nuint_float_bool(base.Handle, selInitWithPoints_Count_Radius_Cyclical_Handle, points, count, radius, cyclical);
		}
		return Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_float_bool(base.SuperHandle, selInitWithPoints_Count_Radius_Cyclical_Handle, points, count, radius, cyclical);
	}
}

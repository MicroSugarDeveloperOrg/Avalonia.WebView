using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;
using Xamarin.Mac.System.Mac;

namespace SpriteKit;

[Register("SKWarpGeometryGrid", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
public class SKWarpGeometryGrid : SKWarpGeometry, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDestPositionAtIndex_ = "destPositionAtIndex:";

	private static readonly IntPtr selDestPositionAtIndex_Handle = Selector.GetHandle("destPositionAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGrid = "grid";

	private static readonly IntPtr selGridHandle = Selector.GetHandle("grid");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGridByReplacingDestPositions_ = "gridByReplacingDestPositions:";

	private static readonly IntPtr selGridByReplacingDestPositions_Handle = Selector.GetHandle("gridByReplacingDestPositions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGridByReplacingSourcePositions_ = "gridByReplacingSourcePositions:";

	private static readonly IntPtr selGridByReplacingSourcePositions_Handle = Selector.GetHandle("gridByReplacingSourcePositions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGridWithColumns_Rows_ = "gridWithColumns:rows:";

	private static readonly IntPtr selGridWithColumns_Rows_Handle = Selector.GetHandle("gridWithColumns:rows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGridWithColumns_Rows_SourcePositions_DestPositions_ = "gridWithColumns:rows:sourcePositions:destPositions:";

	private static readonly IntPtr selGridWithColumns_Rows_SourcePositions_DestPositions_Handle = Selector.GetHandle("gridWithColumns:rows:sourcePositions:destPositions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithColumns_Rows_SourcePositions_DestPositions_ = "initWithColumns:rows:sourcePositions:destPositions:";

	private static readonly IntPtr selInitWithColumns_Rows_SourcePositions_DestPositions_Handle = Selector.GetHandle("initWithColumns:rows:sourcePositions:destPositions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfColumns = "numberOfColumns";

	private static readonly IntPtr selNumberOfColumnsHandle = Selector.GetHandle("numberOfColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfRows = "numberOfRows";

	private static readonly IntPtr selNumberOfRowsHandle = Selector.GetHandle("numberOfRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourcePositionAtIndex_ = "sourcePositionAtIndex:";

	private static readonly IntPtr selSourcePositionAtIndex_Handle = Selector.GetHandle("sourcePositionAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVertexCount = "vertexCount";

	private static readonly IntPtr selVertexCountHandle = Selector.GetHandle("vertexCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKWarpGeometryGrid");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint NumberOfColumns
	{
		[Export("numberOfColumns")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfColumnsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfColumnsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint NumberOfRows
	{
		[Export("numberOfRows")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfRowsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfRowsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint VertexCount
	{
		[Export("vertexCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selVertexCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selVertexCountHandle);
		}
	}

	public unsafe static SKWarpGeometryGrid Create(nint cols, nint rows, Vector2[] sourcePositions, Vector2[] destPositions)
	{
		if (cols < 1 || rows < 1)
		{
			throw new InvalidOperationException("cols and rows should be >= 1");
		}
		if (sourcePositions.Length < (cols + 1) * (rows + 1))
		{
			throw new InvalidOperationException("sourcePositions should have a minimum lenght of (cols + 1) * (rows + 1)");
		}
		if (destPositions.Length < (cols + 1) * (rows + 1))
		{
			throw new InvalidOperationException("destPositions should have a minimum lenght of (cols + 1) * (rows + 1)");
		}
		fixed (Vector2* ptr = sourcePositions)
		{
			fixed (Vector2* ptr2 = destPositions)
			{
				return GridWithColumns(cols, rows, (IntPtr)ptr, (IntPtr)ptr2);
			}
		}
	}

	[DesignatedInitializer]
	public unsafe SKWarpGeometryGrid(nint cols, nint rows, Vector2[] sourcePositions, Vector2[] destPositions)
	{
		if (cols < 1 || rows < 1)
		{
			throw new InvalidOperationException("cols and rows should be >= 1");
		}
		if (sourcePositions.Length < (cols + 1) * (rows + 1))
		{
			throw new InvalidOperationException("sourcePositions should have a minimum lenght of (cols + 1) * (rows + 1)");
		}
		if (destPositions.Length < (cols + 1) * (rows + 1))
		{
			throw new InvalidOperationException("destPositions should have a minimum lenght of (cols + 1) * (rows + 1)");
		}
		fixed (Vector2* ptr = sourcePositions)
		{
			fixed (Vector2* ptr2 = destPositions)
			{
				InitializeHandle(InitWithColumns(cols, rows, (IntPtr)ptr, (IntPtr)ptr2), "initWithColumns:rows:sourcePositions:destPositions:");
			}
		}
	}

	public unsafe SKWarpGeometryGrid GetGridByReplacingSourcePositions(Vector2[] sourcePositions)
	{
		if (sourcePositions == null)
		{
			throw new ArgumentNullException("sourcePositions");
		}
		if (sourcePositions.Length < (NumberOfColumns + 1) * (NumberOfRows + 1))
		{
			throw new InvalidOperationException("sourcePositions should have a minimum lenght of (NumberOfColumns + 1) * (NumberOfRows + 1)");
		}
		fixed (Vector2* ptr = sourcePositions)
		{
			return _GridByReplacingSourcePositions((IntPtr)ptr);
		}
	}

	public unsafe SKWarpGeometryGrid GetGridByReplacingDestPositions(Vector2[] destPositions)
	{
		if (destPositions == null)
		{
			throw new ArgumentNullException("destPositions");
		}
		if (destPositions.Length < (NumberOfColumns + 1) * (NumberOfRows + 1))
		{
			throw new InvalidOperationException("destPositions should have a minimum lenght of (NumberOfColumns + 1) * (NumberOfRows + 1)");
		}
		fixed (Vector2* ptr = destPositions)
		{
			return _GridByReplacingDestPositions((IntPtr)ptr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SKWarpGeometryGrid(NSCoder coder)
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
	protected SKWarpGeometryGrid(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKWarpGeometryGrid(IntPtr handle)
		: base(handle)
	{
	}

	[Export("gridWithColumns:rows:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKWarpGeometryGrid Create(nint cols, nint rows)
	{
		return Runtime.GetNSObject<SKWarpGeometryGrid>(Messaging.IntPtr_objc_msgSend_nint_nint(class_ptr, selGridWithColumns_Rows_Handle, cols, rows));
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void EncodeTo(NSCoder encoder)
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

	[Export("destPositionAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector2 GetDestPosition(nint index)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__Vector2_objc_msgSend_nint(base.Handle, selDestPositionAtIndex_Handle, index);
		}
		return Messaging.xamarin_simd__Vector2_objc_msgSendSuper_nint(base.SuperHandle, selDestPositionAtIndex_Handle, index);
	}

	[Export("grid")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKWarpGeometryGrid GetGrid()
	{
		return Runtime.GetNSObject<SKWarpGeometryGrid>(Messaging.IntPtr_objc_msgSend(class_ptr, selGridHandle));
	}

	[Export("sourcePositionAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector2 GetSourcePosition(nint index)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__Vector2_objc_msgSend_nint(base.Handle, selSourcePositionAtIndex_Handle, index);
		}
		return Messaging.xamarin_simd__Vector2_objc_msgSendSuper_nint(base.SuperHandle, selSourcePositionAtIndex_Handle, index);
	}

	[Export("gridWithColumns:rows:sourcePositions:destPositions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static SKWarpGeometryGrid GridWithColumns(nint cols, nint rows, IntPtr sourcePositions, IntPtr destPositions)
	{
		return Runtime.GetNSObject<SKWarpGeometryGrid>(Messaging.IntPtr_objc_msgSend_nint_nint_IntPtr_IntPtr(class_ptr, selGridWithColumns_Rows_SourcePositions_DestPositions_Handle, cols, rows, sourcePositions, destPositions));
	}

	[Export("initWithColumns:rows:sourcePositions:destPositions:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithColumns(nint cols, nint rows, IntPtr sourcePositions, IntPtr destPositions)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_nint_nint_IntPtr_IntPtr(base.Handle, selInitWithColumns_Rows_SourcePositions_DestPositions_Handle, cols, rows, sourcePositions, destPositions);
		}
		return Messaging.IntPtr_objc_msgSendSuper_nint_nint_IntPtr_IntPtr(base.SuperHandle, selInitWithColumns_Rows_SourcePositions_DestPositions_Handle, cols, rows, sourcePositions, destPositions);
	}

	[Export("gridByReplacingDestPositions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual SKWarpGeometryGrid _GridByReplacingDestPositions(IntPtr destPositions)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<SKWarpGeometryGrid>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGridByReplacingDestPositions_Handle, destPositions));
		}
		return Runtime.GetNSObject<SKWarpGeometryGrid>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGridByReplacingDestPositions_Handle, destPositions));
	}

	[Export("gridByReplacingSourcePositions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual SKWarpGeometryGrid _GridByReplacingSourcePositions(IntPtr sourcePositions)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<SKWarpGeometryGrid>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGridByReplacingSourcePositions_Handle, sourcePositions));
		}
		return Runtime.GetNSObject<SKWarpGeometryGrid>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGridByReplacingSourcePositions_Handle, sourcePositions));
	}
}

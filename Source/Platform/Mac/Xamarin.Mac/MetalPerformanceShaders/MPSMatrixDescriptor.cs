using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MetalPerformanceShaders;

[Register("MPSMatrixDescriptor", true)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class MPSMatrixDescriptor : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColumns = "columns";

	private static readonly IntPtr selColumnsHandle = Selector.GetHandle("columns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataType = "dataType";

	private static readonly IntPtr selDataTypeHandle = Selector.GetHandle("dataType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatrices = "matrices";

	private static readonly IntPtr selMatricesHandle = Selector.GetHandle("matrices");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatrixBytes = "matrixBytes";

	private static readonly IntPtr selMatrixBytesHandle = Selector.GetHandle("matrixBytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatrixDescriptorWithDimensions_Columns_RowBytes_DataType_ = "matrixDescriptorWithDimensions:columns:rowBytes:dataType:";

	private static readonly IntPtr selMatrixDescriptorWithDimensions_Columns_RowBytes_DataType_Handle = Selector.GetHandle("matrixDescriptorWithDimensions:columns:rowBytes:dataType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatrixDescriptorWithRows_Columns_Matrices_RowBytes_MatrixBytes_DataType_ = "matrixDescriptorWithRows:columns:matrices:rowBytes:matrixBytes:dataType:";

	private static readonly IntPtr selMatrixDescriptorWithRows_Columns_Matrices_RowBytes_MatrixBytes_DataType_Handle = Selector.GetHandle("matrixDescriptorWithRows:columns:matrices:rowBytes:matrixBytes:dataType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatrixDescriptorWithRows_Columns_RowBytes_DataType_ = "matrixDescriptorWithRows:columns:rowBytes:dataType:";

	private static readonly IntPtr selMatrixDescriptorWithRows_Columns_RowBytes_DataType_Handle = Selector.GetHandle("matrixDescriptorWithRows:columns:rowBytes:dataType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowBytes = "rowBytes";

	private static readonly IntPtr selRowBytesHandle = Selector.GetHandle("rowBytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowBytesForColumns_DataType_ = "rowBytesForColumns:dataType:";

	private static readonly IntPtr selRowBytesForColumns_DataType_Handle = Selector.GetHandle("rowBytesForColumns:dataType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRowBytesFromColumns_DataType_ = "rowBytesFromColumns:dataType:";

	private static readonly IntPtr selRowBytesFromColumns_DataType_Handle = Selector.GetHandle("rowBytesFromColumns:dataType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRows = "rows";

	private static readonly IntPtr selRowsHandle = Selector.GetHandle("rows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColumns_ = "setColumns:";

	private static readonly IntPtr selSetColumns_Handle = Selector.GetHandle("setColumns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDataType_ = "setDataType:";

	private static readonly IntPtr selSetDataType_Handle = Selector.GetHandle("setDataType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRowBytes_ = "setRowBytes:";

	private static readonly IntPtr selSetRowBytes_Handle = Selector.GetHandle("setRowBytes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRows_ = "setRows:";

	private static readonly IntPtr selSetRows_Handle = Selector.GetHandle("setRows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSMatrixDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Columns
	{
		[Export("columns")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selColumnsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selColumnsHandle);
		}
		[Export("setColumns:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetColumns_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetColumns_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPSDataType DataType
	{
		[Export("dataType", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MPSDataType)Messaging.UInt32_objc_msgSend(base.Handle, selDataTypeHandle);
			}
			return (MPSDataType)Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selDataTypeHandle);
		}
		[Export("setDataType:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt32(base.Handle, selSetDataType_Handle, (uint)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt32(base.SuperHandle, selSetDataType_Handle, (uint)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual nuint Matrices
	{
		[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("matrices")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMatricesHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMatricesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual nuint MatrixBytes
	{
		[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("matrixBytes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMatrixBytesHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMatrixBytesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint RowBytes
	{
		[Export("rowBytes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selRowBytesHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selRowBytesHandle);
		}
		[Export("setRowBytes:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetRowBytes_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetRowBytes_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Rows
	{
		[Export("rows")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selRowsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selRowsHandle);
		}
		[Export("setRows:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetRows_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetRows_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSMatrixDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSMatrixDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("matrixDescriptorWithDimensions:columns:rowBytes:dataType:")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
	[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSMatrixDescriptor Create(nuint rows, nuint columns, nuint rowBytes, MPSDataType dataType)
	{
		return Runtime.GetNSObject<MPSMatrixDescriptor>(Messaging.IntPtr_objc_msgSend_nuint_nuint_nuint_UInt32(class_ptr, selMatrixDescriptorWithDimensions_Columns_RowBytes_DataType_Handle, rows, columns, rowBytes, (uint)dataType));
	}

	[Export("matrixDescriptorWithRows:columns:rowBytes:dataType:")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSMatrixDescriptor GetMatrixDescriptor(nuint rows, nuint columns, nuint rowBytes, MPSDataType dataType)
	{
		return Runtime.GetNSObject<MPSMatrixDescriptor>(Messaging.IntPtr_objc_msgSend_nuint_nuint_nuint_UInt32(class_ptr, selMatrixDescriptorWithRows_Columns_RowBytes_DataType_Handle, rows, columns, rowBytes, (uint)dataType));
	}

	[Export("matrixDescriptorWithRows:columns:matrices:rowBytes:matrixBytes:dataType:")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSMatrixDescriptor GetMatrixDescriptor(nuint rows, nuint columns, nuint matrices, nuint rowBytes, nuint matrixBytes, MPSDataType dataType)
	{
		return Runtime.GetNSObject<MPSMatrixDescriptor>(Messaging.IntPtr_objc_msgSend_nuint_nuint_nuint_nuint_nuint_UInt32(class_ptr, selMatrixDescriptorWithRows_Columns_Matrices_RowBytes_MatrixBytes_DataType_Handle, rows, columns, matrices, rowBytes, matrixBytes, (uint)dataType));
	}

	[Export("rowBytesForColumns:dataType:")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetRowBytesForColumns(nuint columns, MPSDataType dataType)
	{
		return Messaging.nuint_objc_msgSend_nuint_UInt32(class_ptr, selRowBytesForColumns_DataType_Handle, columns, (uint)dataType);
	}

	[Export("rowBytesFromColumns:dataType:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, null)]
	[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetRowBytesFromColumns(nuint columns, MPSDataType dataType)
	{
		return Messaging.nuint_objc_msgSend_nuint_UInt32(class_ptr, selRowBytesFromColumns_DataType_Handle, columns, (uint)dataType);
	}
}

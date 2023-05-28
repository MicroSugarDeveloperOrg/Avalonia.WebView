using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Register("MPSVectorDescriptor", true)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MPSVectorDescriptor : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataType = "dataType";

	private static readonly IntPtr selDataTypeHandle = Selector.GetHandle("dataType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLength = "length";

	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDataType_ = "setDataType:";

	private static readonly IntPtr selSetDataType_Handle = Selector.GetHandle("setDataType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLength_ = "setLength:";

	private static readonly IntPtr selSetLength_Handle = Selector.GetHandle("setLength:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVectorBytes = "vectorBytes";

	private static readonly IntPtr selVectorBytesHandle = Selector.GetHandle("vectorBytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVectorBytesForLength_DataType_ = "vectorBytesForLength:dataType:";

	private static readonly IntPtr selVectorBytesForLength_DataType_Handle = Selector.GetHandle("vectorBytesForLength:dataType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVectorDescriptorWithLength_DataType_ = "vectorDescriptorWithLength:dataType:";

	private static readonly IntPtr selVectorDescriptorWithLength_DataType_Handle = Selector.GetHandle("vectorDescriptorWithLength:dataType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVectorDescriptorWithLength_Vectors_VectorBytes_DataType_ = "vectorDescriptorWithLength:vectors:vectorBytes:dataType:";

	private static readonly IntPtr selVectorDescriptorWithLength_Vectors_VectorBytes_DataType_Handle = Selector.GetHandle("vectorDescriptorWithLength:vectors:vectorBytes:dataType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVectors = "vectors";

	private static readonly IntPtr selVectorsHandle = Selector.GetHandle("vectors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPSVectorDescriptor");

	public override IntPtr ClassHandle => class_ptr;

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
	public virtual nuint Length
	{
		[Export("length")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selLengthHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selLengthHandle);
		}
		[Export("setLength:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetLength_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetLength_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint VectorBytes
	{
		[Export("vectorBytes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selVectorBytesHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selVectorBytesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Vectors
	{
		[Export("vectors")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selVectorsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selVectorsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPSVectorDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPSVectorDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("vectorDescriptorWithLength:dataType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSVectorDescriptor Create(nuint length, MPSDataType dataType)
	{
		return Runtime.GetNSObject<MPSVectorDescriptor>(Messaging.IntPtr_objc_msgSend_nuint_UInt32(class_ptr, selVectorDescriptorWithLength_DataType_Handle, length, (uint)dataType));
	}

	[Export("vectorDescriptorWithLength:vectors:vectorBytes:dataType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MPSVectorDescriptor Create(nuint length, nuint vectors, nuint vectorBytes, MPSDataType dataType)
	{
		return Runtime.GetNSObject<MPSVectorDescriptor>(Messaging.IntPtr_objc_msgSend_nuint_nuint_nuint_UInt32(class_ptr, selVectorDescriptorWithLength_Vectors_VectorBytes_DataType_Handle, length, vectors, vectorBytes, (uint)dataType));
	}

	[Export("vectorBytesForLength:dataType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetVectorBytes(nuint length, MPSDataType dataType)
	{
		return Messaging.nuint_objc_msgSend_nuint_UInt32(class_ptr, selVectorBytesForLength_DataType_Handle, length, (uint)dataType);
	}
}

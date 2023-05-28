using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreML;

[Register("MLMultiArray", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class MLMultiArray : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCount = "count";

	private static readonly IntPtr selCountHandle = Selector.GetHandle("count");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataPointer = "dataPointer";

	private static readonly IntPtr selDataPointerHandle = Selector.GetHandle("dataPointer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataType = "dataType";

	private static readonly IntPtr selDataTypeHandle = Selector.GetHandle("dataType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDataPointer_Shape_DataType_Strides_Deallocator_Error_ = "initWithDataPointer:shape:dataType:strides:deallocator:error:";

	private static readonly IntPtr selInitWithDataPointer_Shape_DataType_Strides_Deallocator_Error_Handle = Selector.GetHandle("initWithDataPointer:shape:dataType:strides:deallocator:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithShape_DataType_Error_ = "initWithShape:dataType:error:";

	private static readonly IntPtr selInitWithShape_DataType_Error_Handle = Selector.GetHandle("initWithShape:dataType:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectAtIndexedSubscript_ = "objectAtIndexedSubscript:";

	private static readonly IntPtr selObjectAtIndexedSubscript_Handle = Selector.GetHandle("objectAtIndexedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectForKeyedSubscript_ = "objectForKeyedSubscript:";

	private static readonly IntPtr selObjectForKeyedSubscript_Handle = Selector.GetHandle("objectForKeyedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetObject_AtIndexedSubscript_ = "setObject:atIndexedSubscript:";

	private static readonly IntPtr selSetObject_AtIndexedSubscript_Handle = Selector.GetHandle("setObject:atIndexedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetObject_ForKeyedSubscript_ = "setObject:forKeyedSubscript:";

	private static readonly IntPtr selSetObject_ForKeyedSubscript_Handle = Selector.GetHandle("setObject:forKeyedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShape = "shape";

	private static readonly IntPtr selShapeHandle = Selector.GetHandle("shape");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStrides = "strides";

	private static readonly IntPtr selStridesHandle = Selector.GetHandle("strides");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MLMultiArray");

	[Watch(4, 0)]
	[TV(11, 0)]
	[Mac(10, 13)]
	[iOS(11, 0)]
	public NSNumber this[nint idx]
	{
		get
		{
			return GetObject(idx);
		}
		set
		{
			SetObject(value, idx);
		}
	}

	[Watch(4, 0)]
	[TV(11, 0)]
	[Mac(10, 13)]
	[iOS(11, 0)]
	public NSNumber this[params nint[] indices]
	{
		get
		{
			return GetObject(indices);
		}
		set
		{
			SetObject(value, indices);
		}
	}

	[Watch(4, 0)]
	[TV(11, 0)]
	[Mac(10, 13)]
	[iOS(11, 0)]
	public NSNumber this[NSNumber[] key]
	{
		get
		{
			return GetObject(key);
		}
		set
		{
			SetObject(value, key);
		}
	}

	[Watch(4, 0)]
	[TV(11, 0)]
	[Mac(10, 13)]
	[iOS(11, 0)]
	public nint[] Shape => ConvertArray(_Shape);

	[Watch(4, 0)]
	[TV(11, 0)]
	[Mac(10, 13)]
	[iOS(11, 0)]
	public nint[] Strides => ConvertArray(_Strides);

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Count
	{
		[Export("count")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr DataPointer
	{
		[Export("dataPointer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selDataPointerHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataPointerHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MLMultiArrayDataType DataType
	{
		[Export("dataType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MLMultiArrayDataType)Messaging.Int64_objc_msgSend(base.Handle, selDataTypeHandle);
			}
			return (MLMultiArrayDataType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDataTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr _Shape
	{
		[Export("shape")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selShapeHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selShapeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr _Strides
	{
		[Export("strides")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selStridesHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStridesHandle);
		}
	}

	private static NSNumber[] ConvertArray(nint[] value)
	{
		if (value == null)
		{
			return null;
		}
		return Array.ConvertAll(value, NSNumber.FromNInt);
	}

	internal static nint[] ConvertArray(IntPtr handle)
	{
		return NSArray.ArrayFromHandle(handle, (IntPtr v) => Messaging.nint_objc_msgSend(v, Selector.GetHandle("integerValue")));
	}

	[Watch(4, 0)]
	[TV(11, 0)]
	[Mac(10, 13)]
	[iOS(11, 0)]
	public MLMultiArray(nint[] shape, MLMultiArrayDataType dataType, out NSError error)
		: this(ConvertArray(shape), dataType, out error)
	{
	}

	[Watch(4, 0)]
	[TV(11, 0)]
	[Mac(10, 13)]
	[iOS(11, 0)]
	public MLMultiArray(IntPtr dataPointer, nint[] shape, MLMultiArrayDataType dataType, nint[] strides, Action<IntPtr> deallocator, out NSError error)
		: this(dataPointer, ConvertArray(shape), dataType, ConvertArray(strides), deallocator, out error)
	{
	}

	[Watch(4, 0)]
	[TV(11, 0)]
	[Mac(10, 13)]
	[iOS(11, 0)]
	public NSNumber GetObject(params nint[] indices)
	{
		using NSArray self = NSArray.FromNSObjects(NSNumber.FromNInt, indices);
		return GetObject(self.GetHandle());
	}

	[Watch(4, 0)]
	[TV(11, 0)]
	[Mac(10, 13)]
	[iOS(11, 0)]
	public void SetObject(NSNumber obj, params nint[] indices)
	{
		using NSArray self = NSArray.FromNSObjects(NSNumber.FromNInt, indices);
		SetObject(obj, self.GetHandle());
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MLMultiArray(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MLMultiArray(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithShape:dataType:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MLMultiArray(NSNumber[] shape, MLMultiArrayDataType dataType, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (shape == null)
		{
			throw new ArgumentNullException("shape");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(shape);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_Int64_ref_IntPtr(base.Handle, selInitWithShape_DataType_Error_Handle, nSArray.Handle, (long)dataType, ref arg), "initWithShape:dataType:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_Int64_ref_IntPtr(base.SuperHandle, selInitWithShape_DataType_Error_Handle, nSArray.Handle, (long)dataType, ref arg), "initWithShape:dataType:error:");
		}
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("initWithDataPointer:shape:dataType:strides:deallocator:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe MLMultiArray(IntPtr dataPointer, NSNumber[] shape, MLMultiArrayDataType dataType, NSNumber[] strides, [BlockProxy(typeof(Trampolines.NIDActionArity1V24))] Action<IntPtr> deallocator, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (shape == null)
		{
			throw new ArgumentNullException("shape");
		}
		if (strides == null)
		{
			throw new ArgumentNullException("strides");
		}
		if (deallocator == null)
		{
			throw new ArgumentNullException("deallocator");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(shape);
		NSArray nSArray2 = NSArray.FromNSObjects(strides);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V24.Handler, deallocator);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_Int64_IntPtr_IntPtr_ref_IntPtr(base.Handle, selInitWithDataPointer_Shape_DataType_Strides_Deallocator_Error_Handle, dataPointer, nSArray.Handle, (long)dataType, nSArray2.Handle, (IntPtr)ptr, ref arg), "initWithDataPointer:shape:dataType:strides:deallocator:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_Int64_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithDataPointer_Shape_DataType_Strides_Deallocator_Error_Handle, dataPointer, nSArray.Handle, (long)dataType, nSArray2.Handle, (IntPtr)ptr, ref arg), "initWithDataPointer:shape:dataType:strides:deallocator:error:");
		}
		nSArray.Dispose();
		nSArray2.Dispose();
		ptr->CleanupBlock();
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("objectAtIndexedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber GetObject(nint idx)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selObjectAtIndexedSubscript_Handle, idx));
		}
		return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selObjectAtIndexedSubscript_Handle, idx));
	}

	[Export("objectForKeyedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber GetObject(NSNumber[] key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		NSArray nSArray = NSArray.FromNSObjects(key);
		NSNumber result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectForKeyedSubscript_Handle, nSArray.Handle)) : Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectForKeyedSubscript_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal NSNumber GetObject(IntPtr key)
	{
		return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectForKeyedSubscript_Handle, key));
	}

	[Export("setObject:atIndexedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetObject(NSNumber obj, nint idx)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selSetObject_AtIndexedSubscript_Handle, obj.Handle, idx);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selSetObject_AtIndexedSubscript_Handle, obj.Handle, idx);
		}
	}

	[Export("setObject:forKeyedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetObject(NSNumber obj, NSNumber[] key)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		NSArray nSArray = NSArray.FromNSObjects(key);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetObject_ForKeyedSubscript_Handle, obj.Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetObject_ForKeyedSubscript_Handle, obj.Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal void SetObject(NSNumber obj, IntPtr key)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetObject_ForKeyedSubscript_Handle, obj.Handle, key);
	}
}

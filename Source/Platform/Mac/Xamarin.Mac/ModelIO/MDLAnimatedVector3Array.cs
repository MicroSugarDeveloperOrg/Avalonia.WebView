using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using OpenTK;
using Xamarin.Mac.System.Mac;

namespace ModelIO;

[Register("MDLAnimatedVector3Array", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class MDLAnimatedVector3Array : MDLAnimatedValue
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementCount = "elementCount";

	private static readonly IntPtr selElementCountHandle = Selector.GetHandle("elementCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetDouble3Array_MaxCount_ = "getDouble3Array:maxCount:";

	private static readonly IntPtr selGetDouble3Array_MaxCount_Handle = Selector.GetHandle("getDouble3Array:maxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetDouble3Array_MaxCount_AtTime_ = "getDouble3Array:maxCount:atTime:";

	private static readonly IntPtr selGetDouble3Array_MaxCount_AtTime_Handle = Selector.GetHandle("getDouble3Array:maxCount:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetFloat3Array_MaxCount_ = "getFloat3Array:maxCount:";

	private static readonly IntPtr selGetFloat3Array_MaxCount_Handle = Selector.GetHandle("getFloat3Array:maxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetFloat3Array_MaxCount_AtTime_ = "getFloat3Array:maxCount:atTime:";

	private static readonly IntPtr selGetFloat3Array_MaxCount_AtTime_Handle = Selector.GetHandle("getFloat3Array:maxCount:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithElementCount_ = "initWithElementCount:";

	private static readonly IntPtr selInitWithElementCount_Handle = Selector.GetHandle("initWithElementCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetWithDouble3Array_Count_AtTimes_Count_ = "resetWithDouble3Array:count:atTimes:count:";

	private static readonly IntPtr selResetWithDouble3Array_Count_AtTimes_Count_Handle = Selector.GetHandle("resetWithDouble3Array:count:atTimes:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetWithFloat3Array_Count_AtTimes_Count_ = "resetWithFloat3Array:count:atTimes:count:";

	private static readonly IntPtr selResetWithFloat3Array_Count_AtTimes_Count_Handle = Selector.GetHandle("resetWithFloat3Array:count:atTimes:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDouble3Array_Count_AtTime_ = "setDouble3Array:count:atTime:";

	private static readonly IntPtr selSetDouble3Array_Count_AtTime_Handle = Selector.GetHandle("setDouble3Array:count:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloat3Array_Count_AtTime_ = "setFloat3Array:count:atTime:";

	private static readonly IntPtr selSetFloat3Array_Count_AtTime_Handle = Selector.GetHandle("setFloat3Array:count:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLAnimatedVector3Array");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ElementCount
	{
		[Export("elementCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selElementCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selElementCountHandle);
		}
	}

	public unsafe virtual void SetValues(NVector3[] array, double time)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		int typeSize = Marshal.SizeOf(typeof(NVector3));
		fixed (NVector3* ptr = array)
		{
			MDLMemoryHelper.SetValues(typeSize, (IntPtr)ptr, array.Length, time, _SetFloat3Array);
		}
	}

	public unsafe virtual void SetValues(NVector3d[] array, double time)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		int typeSize = Marshal.SizeOf(typeof(NVector3d));
		fixed (NVector3d* ptr = array)
		{
			MDLMemoryHelper.SetValues(typeSize, (IntPtr)ptr, array.Length, time, _SetDouble3Array);
		}
	}

	public unsafe virtual NVector3[] GetNVector3Values(double time)
	{
		nuint elementCount = ElementCount;
		NVector3[] array = new NVector3[(int)elementCount];
		int typeSize = sizeof(NVector3);
		fixed (NVector3* ptr = array)
		{
			MDLMemoryHelper.FetchValues(typeSize, (IntPtr)ptr, elementCount, time, _GetFloat3Array);
		}
		return array;
	}

	public unsafe virtual NVector3d[] GetNVector3dValues(double time)
	{
		nuint elementCount = ElementCount;
		NVector3d[] array = new NVector3d[(int)elementCount];
		int typeSize = sizeof(NVector3d);
		fixed (NVector3d* ptr = array)
		{
			MDLMemoryHelper.FetchValues(typeSize, (IntPtr)ptr, elementCount, time, _GetDouble3Array);
		}
		return array;
	}

	public unsafe virtual void Reset(NVector3[] values, double[] times)
	{
		if (values == null)
		{
			throw new ArgumentNullException("values");
		}
		if (times == null)
		{
			throw new ArgumentNullException("times");
		}
		int typeSize = Marshal.SizeOf(typeof(NVector3));
		fixed (NVector3* ptr = values)
		{
			MDLMemoryHelper.Reset(typeSize, (IntPtr)ptr, values.Length, times, _ResetWithFloat3Array);
		}
	}

	public unsafe virtual void Reset(NVector3d[] values, double[] times)
	{
		if (values == null)
		{
			throw new ArgumentNullException("values");
		}
		if (times == null)
		{
			throw new ArgumentNullException("times");
		}
		int typeSize = Marshal.SizeOf(typeof(NVector3d));
		fixed (NVector3d* ptr = values)
		{
			MDLMemoryHelper.Reset(typeSize, (IntPtr)ptr, values.Length, times, _ResetWithDouble3Array);
		}
	}

	public unsafe virtual NVector3[] GetNVector3Values()
	{
		nuint nuint = ElementCount * TimeSampleCount;
		NVector3[] array = new NVector3[(int)nuint];
		int typeSize = sizeof(NVector3);
		fixed (NVector3* ptr = array)
		{
			MDLMemoryHelper.FetchValues(typeSize, (IntPtr)ptr, nuint, _GetFloat3Array);
		}
		return array;
	}

	public unsafe virtual NVector3d[] GetNVector3dValues()
	{
		nuint nuint = ElementCount * TimeSampleCount;
		NVector3d[] array = new NVector3d[(int)nuint];
		int typeSize = sizeof(NVector3d);
		fixed (NVector3d* ptr = array)
		{
			MDLMemoryHelper.FetchValues(typeSize, (IntPtr)ptr, nuint, _GetDouble3Array);
		}
		return array;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLAnimatedVector3Array()
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
	protected MDLAnimatedVector3Array(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLAnimatedVector3Array(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithElementCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLAnimatedVector3Array(nuint arrayElementCount)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selInitWithElementCount_Handle, arrayElementCount), "initWithElementCount:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selInitWithElementCount_Handle, arrayElementCount), "initWithElementCount:");
		}
	}

	[Export("getDouble3Array:maxCount:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual nuint _GetDouble3Array(IntPtr array, nuint maxCount, double time)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_nuint_Double(base.Handle, selGetDouble3Array_MaxCount_AtTime_Handle, array, maxCount, time);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_nuint_Double(base.SuperHandle, selGetDouble3Array_MaxCount_AtTime_Handle, array, maxCount, time);
	}

	[Export("getDouble3Array:maxCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual nuint _GetDouble3Array(IntPtr valuesArray, nuint maxCount)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_nuint(base.Handle, selGetDouble3Array_MaxCount_Handle, valuesArray, maxCount);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selGetDouble3Array_MaxCount_Handle, valuesArray, maxCount);
	}

	[Export("getFloat3Array:maxCount:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual nuint _GetFloat3Array(IntPtr array, nuint maxCount, double time)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_nuint_Double(base.Handle, selGetFloat3Array_MaxCount_AtTime_Handle, array, maxCount, time);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_nuint_Double(base.SuperHandle, selGetFloat3Array_MaxCount_AtTime_Handle, array, maxCount, time);
	}

	[Export("getFloat3Array:maxCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual nuint _GetFloat3Array(IntPtr valuesArray, nuint maxCount)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_nuint(base.Handle, selGetFloat3Array_MaxCount_Handle, valuesArray, maxCount);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selGetFloat3Array_MaxCount_Handle, valuesArray, maxCount);
	}

	[Export("resetWithDouble3Array:count:atTimes:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _ResetWithDouble3Array(IntPtr valuesArray, nuint valuesCount, IntPtr timesArray, nuint timesCount)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint_IntPtr_nuint(base.Handle, selResetWithDouble3Array_Count_AtTimes_Count_Handle, valuesArray, valuesCount, timesArray, timesCount);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint_IntPtr_nuint(base.SuperHandle, selResetWithDouble3Array_Count_AtTimes_Count_Handle, valuesArray, valuesCount, timesArray, timesCount);
		}
	}

	[Export("resetWithFloat3Array:count:atTimes:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _ResetWithFloat3Array(IntPtr valuesArray, nuint valuesCount, IntPtr timesArray, nuint timesCount)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint_IntPtr_nuint(base.Handle, selResetWithFloat3Array_Count_AtTimes_Count_Handle, valuesArray, valuesCount, timesArray, timesCount);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint_IntPtr_nuint(base.SuperHandle, selResetWithFloat3Array_Count_AtTimes_Count_Handle, valuesArray, valuesCount, timesArray, timesCount);
		}
	}

	[Export("setDouble3Array:count:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _SetDouble3Array(IntPtr array, nuint count, double time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint_Double(base.Handle, selSetDouble3Array_Count_AtTime_Handle, array, count, time);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint_Double(base.SuperHandle, selSetDouble3Array_Count_AtTime_Handle, array, count, time);
		}
	}

	[Export("setFloat3Array:count:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _SetFloat3Array(IntPtr array, nuint count, double time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint_Double(base.Handle, selSetFloat3Array_Count_AtTime_Handle, array, count, time);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint_Double(base.SuperHandle, selSetFloat3Array_Count_AtTime_Handle, array, count, time);
		}
	}
}

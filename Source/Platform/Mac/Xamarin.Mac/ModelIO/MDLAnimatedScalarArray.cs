using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

[Register("MDLAnimatedScalarArray", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class MDLAnimatedScalarArray : MDLAnimatedValue
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementCount = "elementCount";

	private static readonly IntPtr selElementCountHandle = Selector.GetHandle("elementCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetDoubleArray_MaxCount_ = "getDoubleArray:maxCount:";

	private static readonly IntPtr selGetDoubleArray_MaxCount_Handle = Selector.GetHandle("getDoubleArray:maxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetDoubleArray_MaxCount_AtTime_ = "getDoubleArray:maxCount:atTime:";

	private static readonly IntPtr selGetDoubleArray_MaxCount_AtTime_Handle = Selector.GetHandle("getDoubleArray:maxCount:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetFloatArray_MaxCount_ = "getFloatArray:maxCount:";

	private static readonly IntPtr selGetFloatArray_MaxCount_Handle = Selector.GetHandle("getFloatArray:maxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetFloatArray_MaxCount_AtTime_ = "getFloatArray:maxCount:atTime:";

	private static readonly IntPtr selGetFloatArray_MaxCount_AtTime_Handle = Selector.GetHandle("getFloatArray:maxCount:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithElementCount_ = "initWithElementCount:";

	private static readonly IntPtr selInitWithElementCount_Handle = Selector.GetHandle("initWithElementCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetWithDoubleArray_Count_AtTimes_Count_ = "resetWithDoubleArray:count:atTimes:count:";

	private static readonly IntPtr selResetWithDoubleArray_Count_AtTimes_Count_Handle = Selector.GetHandle("resetWithDoubleArray:count:atTimes:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetWithFloatArray_Count_AtTimes_Count_ = "resetWithFloatArray:count:atTimes:count:";

	private static readonly IntPtr selResetWithFloatArray_Count_AtTimes_Count_Handle = Selector.GetHandle("resetWithFloatArray:count:atTimes:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDoubleArray_Count_AtTime_ = "setDoubleArray:count:atTime:";

	private static readonly IntPtr selSetDoubleArray_Count_AtTime_Handle = Selector.GetHandle("setDoubleArray:count:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloatArray_Count_AtTime_ = "setFloatArray:count:atTime:";

	private static readonly IntPtr selSetFloatArray_Count_AtTime_Handle = Selector.GetHandle("setFloatArray:count:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLAnimatedScalarArray");

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

	public unsafe virtual void SetValues(float[] array, double time)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		fixed (float* ptr = array)
		{
			_SetFloatArray((IntPtr)ptr, (nuint)array.Length, time);
		}
	}

	public unsafe virtual void SetValues(double[] array, double time)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		fixed (double* ptr = array)
		{
			_SetDoubleArray((IntPtr)ptr, (nuint)array.Length, time);
		}
	}

	public unsafe virtual float[] GetFloatValues(double time)
	{
		nuint elementCount = ElementCount;
		float[] array = new float[(int)elementCount];
		fixed (float* ptr = array)
		{
			_GetFloatArray((IntPtr)ptr, elementCount);
		}
		return array;
	}

	public unsafe virtual double[] GetDoubleValues(double time)
	{
		nuint elementCount = ElementCount;
		double[] array = new double[(int)elementCount];
		fixed (double* ptr = array)
		{
			_GetDoubleArray((IntPtr)ptr, elementCount);
		}
		return array;
	}

	public unsafe virtual void Reset(float[] values, double[] times)
	{
		if (values == null)
		{
			throw new ArgumentNullException("values");
		}
		if (times == null)
		{
			throw new ArgumentNullException("times");
		}
		fixed (float* ptr = values)
		{
			fixed (double* ptr2 = times)
			{
				_ResetWithFloatArray((IntPtr)ptr, (nuint)values.Length, (IntPtr)ptr2, (nuint)times.Length);
			}
		}
	}

	public unsafe virtual void Reset(double[] values, double[] times)
	{
		if (values == null)
		{
			throw new ArgumentNullException("values");
		}
		if (times == null)
		{
			throw new ArgumentNullException("times");
		}
		fixed (double* ptr = values)
		{
			fixed (double* ptr2 = times)
			{
				_ResetWithDoubleArray((IntPtr)ptr, (nuint)values.Length, (IntPtr)ptr2, (nuint)times.Length);
			}
		}
	}

	public unsafe virtual float[] GetFloatValues()
	{
		nuint nuint = ElementCount * TimeSampleCount;
		float[] array = new float[(int)nuint];
		fixed (float* ptr = array)
		{
			_GetFloatArray((IntPtr)ptr, nuint);
		}
		return array;
	}

	public unsafe virtual double[] GetDoubleValues()
	{
		nuint nuint = ElementCount * TimeSampleCount;
		double[] array = new double[(int)nuint];
		fixed (double* ptr = array)
		{
			_GetDoubleArray((IntPtr)ptr, nuint);
		}
		return array;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLAnimatedScalarArray()
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
	protected MDLAnimatedScalarArray(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLAnimatedScalarArray(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithElementCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLAnimatedScalarArray(nuint arrayElementCount)
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

	[Export("getDoubleArray:maxCount:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual nuint _GetDoubleArray(IntPtr array, nuint maxCount, double time)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_nuint_Double(base.Handle, selGetDoubleArray_MaxCount_AtTime_Handle, array, maxCount, time);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_nuint_Double(base.SuperHandle, selGetDoubleArray_MaxCount_AtTime_Handle, array, maxCount, time);
	}

	[Export("getDoubleArray:maxCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual nuint _GetDoubleArray(IntPtr valuesArray, nuint maxCount)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_nuint(base.Handle, selGetDoubleArray_MaxCount_Handle, valuesArray, maxCount);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selGetDoubleArray_MaxCount_Handle, valuesArray, maxCount);
	}

	[Export("getFloatArray:maxCount:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual nuint _GetFloatArray(IntPtr array, nuint maxCount, double time)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_nuint_Double(base.Handle, selGetFloatArray_MaxCount_AtTime_Handle, array, maxCount, time);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_nuint_Double(base.SuperHandle, selGetFloatArray_MaxCount_AtTime_Handle, array, maxCount, time);
	}

	[Export("getFloatArray:maxCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual nuint _GetFloatArray(IntPtr valuesArray, nuint maxCount)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_nuint(base.Handle, selGetFloatArray_MaxCount_Handle, valuesArray, maxCount);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selGetFloatArray_MaxCount_Handle, valuesArray, maxCount);
	}

	[Export("resetWithDoubleArray:count:atTimes:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _ResetWithDoubleArray(IntPtr valuesArray, nuint valuesCount, IntPtr timesArray, nuint timesCount)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint_IntPtr_nuint(base.Handle, selResetWithDoubleArray_Count_AtTimes_Count_Handle, valuesArray, valuesCount, timesArray, timesCount);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint_IntPtr_nuint(base.SuperHandle, selResetWithDoubleArray_Count_AtTimes_Count_Handle, valuesArray, valuesCount, timesArray, timesCount);
		}
	}

	[Export("resetWithFloatArray:count:atTimes:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _ResetWithFloatArray(IntPtr valuesArray, nuint valuesCount, IntPtr timesArray, nuint timesCount)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint_IntPtr_nuint(base.Handle, selResetWithFloatArray_Count_AtTimes_Count_Handle, valuesArray, valuesCount, timesArray, timesCount);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint_IntPtr_nuint(base.SuperHandle, selResetWithFloatArray_Count_AtTimes_Count_Handle, valuesArray, valuesCount, timesArray, timesCount);
		}
	}

	[Export("setDoubleArray:count:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _SetDoubleArray(IntPtr array, nuint count, double time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint_Double(base.Handle, selSetDoubleArray_Count_AtTime_Handle, array, count, time);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint_Double(base.SuperHandle, selSetDoubleArray_Count_AtTime_Handle, array, count, time);
		}
	}

	[Export("setFloatArray:count:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _SetFloatArray(IntPtr array, nuint count, double time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint_Double(base.Handle, selSetFloatArray_Count_AtTime_Handle, array, count, time);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint_Double(base.SuperHandle, selSetFloatArray_Count_AtTime_Handle, array, count, time);
		}
	}
}

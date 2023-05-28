using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace ModelIO;

[Register("MDLAnimatedScalar", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class MDLAnimatedScalar : MDLAnimatedValue
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoubleAtTime_ = "doubleAtTime:";

	private static readonly IntPtr selDoubleAtTime_Handle = Selector.GetHandle("doubleAtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloatAtTime_ = "floatAtTime:";

	private static readonly IntPtr selFloatAtTime_Handle = Selector.GetHandle("floatAtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetDoubleArray_MaxCount_ = "getDoubleArray:maxCount:";

	private static readonly IntPtr selGetDoubleArray_MaxCount_Handle = Selector.GetHandle("getDoubleArray:maxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetFloatArray_MaxCount_ = "getFloatArray:maxCount:";

	private static readonly IntPtr selGetFloatArray_MaxCount_Handle = Selector.GetHandle("getFloatArray:maxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetWithDoubleArray_AtTimes_Count_ = "resetWithDoubleArray:atTimes:count:";

	private static readonly IntPtr selResetWithDoubleArray_AtTimes_Count_Handle = Selector.GetHandle("resetWithDoubleArray:atTimes:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetWithFloatArray_AtTimes_Count_ = "resetWithFloatArray:atTimes:count:";

	private static readonly IntPtr selResetWithFloatArray_AtTimes_Count_Handle = Selector.GetHandle("resetWithFloatArray:atTimes:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDouble_AtTime_ = "setDouble:atTime:";

	private static readonly IntPtr selSetDouble_AtTime_Handle = Selector.GetHandle("setDouble:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloat_AtTime_ = "setFloat:atTime:";

	private static readonly IntPtr selSetFloat_AtTime_Handle = Selector.GetHandle("setFloat:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLAnimatedScalar");

	public override IntPtr ClassHandle => class_ptr;

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
				_ResetWithFloatArray((IntPtr)ptr, (IntPtr)ptr2, (nuint)times.Length);
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
				_ResetWithDoubleArray((IntPtr)ptr, (IntPtr)ptr2, (nuint)times.Length);
			}
		}
	}

	public unsafe virtual float[] GetFloatValues()
	{
		nuint timeSampleCount = TimeSampleCount;
		float[] array = new float[(int)timeSampleCount];
		fixed (float* ptr = array)
		{
			_GetFloatArray((IntPtr)ptr, timeSampleCount);
		}
		return array;
	}

	public unsafe virtual double[] GetDoubleValues()
	{
		nuint timeSampleCount = TimeSampleCount;
		double[] array = new double[(int)timeSampleCount];
		fixed (double* ptr = array)
		{
			_GetDoubleArray((IntPtr)ptr, timeSampleCount);
		}
		return array;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLAnimatedScalar()
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
	protected MDLAnimatedScalar(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLAnimatedScalar(IntPtr handle)
		: base(handle)
	{
	}

	[Export("doubleAtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double GetDouble(double time)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_Double(base.Handle, selDoubleAtTime_Handle, time);
		}
		return Messaging.Double_objc_msgSendSuper_Double(base.SuperHandle, selDoubleAtTime_Handle, time);
	}

	[Export("floatAtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float GetFloat(double time)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.float_objc_msgSend_Double(base.Handle, selFloatAtTime_Handle, time);
		}
		return Messaging.float_objc_msgSendSuper_Double(base.SuperHandle, selFloatAtTime_Handle, time);
	}

	[Export("setFloat:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValue(float value, double time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_Double(base.Handle, selSetFloat_AtTime_Handle, value, time);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_Double(base.SuperHandle, selSetFloat_AtTime_Handle, value, time);
		}
	}

	[Export("setDouble:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValue(double value, double time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double_Double(base.Handle, selSetDouble_AtTime_Handle, value, time);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double_Double(base.SuperHandle, selSetDouble_AtTime_Handle, value, time);
		}
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

	[Export("resetWithDoubleArray:atTimes:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _ResetWithDoubleArray(IntPtr valuesArray, IntPtr timesArray, nuint count)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint(base.Handle, selResetWithDoubleArray_AtTimes_Count_Handle, valuesArray, timesArray, count);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint(base.SuperHandle, selResetWithDoubleArray_AtTimes_Count_Handle, valuesArray, timesArray, count);
		}
	}

	[Export("resetWithFloatArray:atTimes:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _ResetWithFloatArray(IntPtr valuesArray, IntPtr timesArray, nuint count)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint(base.Handle, selResetWithFloatArray_AtTimes_Count_Handle, valuesArray, timesArray, count);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint(base.SuperHandle, selResetWithFloatArray_AtTimes_Count_Handle, valuesArray, timesArray, count);
		}
	}
}

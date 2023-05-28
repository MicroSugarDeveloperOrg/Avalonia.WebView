using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using OpenTK;
using Xamarin.Mac.System.Mac;

namespace ModelIO;

[Register("MDLAnimatedVector3", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class MDLAnimatedVector3 : MDLAnimatedValue
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDouble3AtTime_ = "double3AtTime:";

	private static readonly IntPtr selDouble3AtTime_Handle = Selector.GetHandle("double3AtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloat3AtTime_ = "float3AtTime:";

	private static readonly IntPtr selFloat3AtTime_Handle = Selector.GetHandle("float3AtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetDouble3Array_MaxCount_ = "getDouble3Array:maxCount:";

	private static readonly IntPtr selGetDouble3Array_MaxCount_Handle = Selector.GetHandle("getDouble3Array:maxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetFloat3Array_MaxCount_ = "getFloat3Array:maxCount:";

	private static readonly IntPtr selGetFloat3Array_MaxCount_Handle = Selector.GetHandle("getFloat3Array:maxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetWithDouble3Array_AtTimes_Count_ = "resetWithDouble3Array:atTimes:count:";

	private static readonly IntPtr selResetWithDouble3Array_AtTimes_Count_Handle = Selector.GetHandle("resetWithDouble3Array:atTimes:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetWithFloat3Array_AtTimes_Count_ = "resetWithFloat3Array:atTimes:count:";

	private static readonly IntPtr selResetWithFloat3Array_AtTimes_Count_Handle = Selector.GetHandle("resetWithFloat3Array:atTimes:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDouble3_AtTime_ = "setDouble3:atTime:";

	private static readonly IntPtr selSetDouble3_AtTime_Handle = Selector.GetHandle("setDouble3:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloat3_AtTime_ = "setFloat3:atTime:";

	private static readonly IntPtr selSetFloat3_AtTime_Handle = Selector.GetHandle("setFloat3:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLAnimatedVector3");

	public override IntPtr ClassHandle => class_ptr;

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
		if (values.Length != times.Length)
		{
			throw new InvalidOperationException("The length of the 'values' array and the 'times' array must match.");
		}
		int typeSize = Marshal.SizeOf(typeof(NVector3));
		fixed (NVector3* ptr = values)
		{
			MDLMemoryHelper.Reset(typeSize, (IntPtr)ptr, times, _ResetWithFloat3Array);
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
		if (values.Length != times.Length)
		{
			throw new InvalidOperationException("The length of the 'values' array and the 'times' array must match.");
		}
		int typeSize = Marshal.SizeOf(typeof(NVector3d));
		fixed (NVector3d* ptr = values)
		{
			MDLMemoryHelper.Reset(typeSize, (IntPtr)ptr, times, _ResetWithDouble3Array);
		}
	}

	public unsafe virtual NVector3[] GetNVector3Values()
	{
		nuint timeSampleCount = TimeSampleCount;
		NVector3[] array = new NVector3[(int)timeSampleCount];
		int typeSize = sizeof(NVector3);
		fixed (NVector3* ptr = array)
		{
			MDLMemoryHelper.FetchValues(typeSize, (IntPtr)ptr, timeSampleCount, _GetFloat3Array);
		}
		return array;
	}

	public unsafe virtual NVector3d[] GetNVector3dValues()
	{
		nuint timeSampleCount = TimeSampleCount;
		NVector3d[] array = new NVector3d[(int)timeSampleCount];
		int typeSize = sizeof(NVector3d);
		fixed (NVector3d* ptr = array)
		{
			MDLMemoryHelper.FetchValues(typeSize, (IntPtr)ptr, timeSampleCount, _GetDouble3Array);
		}
		return array;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLAnimatedVector3()
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
	protected MDLAnimatedVector3(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLAnimatedVector3(IntPtr handle)
		: base(handle)
	{
	}

	[Export("float3AtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NVector3 GetNVector3Value(double time)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__NVector3_objc_msgSend_Double(base.Handle, selFloat3AtTime_Handle, time);
		}
		return Messaging.xamarin_simd__NVector3_objc_msgSendSuper_Double(base.SuperHandle, selFloat3AtTime_Handle, time);
	}

	[Export("double3AtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NVector3d GetNVector3dValue(double time)
	{
		NVector3d retval;
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__NVector3d_objc_msgSend_stret_Double(out retval, base.Handle, selDouble3AtTime_Handle, time);
		}
		else
		{
			Messaging.xamarin_simd__NVector3d_objc_msgSendSuper_stret_Double(out retval, base.SuperHandle, selDouble3AtTime_Handle, time);
		}
		return retval;
	}

	[Export("setFloat3:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValue(NVector3 value, double time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_NVector3_Double(base.Handle, selSetFloat3_AtTime_Handle, value, time);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_NVector3_Double(base.SuperHandle, selSetFloat3_AtTime_Handle, value, time);
		}
	}

	[Export("setDouble3:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValue(NVector3d value, double time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_NVector3d_Double(base.Handle, selSetDouble3_AtTime_Handle, value, time);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_NVector3d_Double(base.SuperHandle, selSetDouble3_AtTime_Handle, value, time);
		}
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

	[Export("resetWithDouble3Array:atTimes:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _ResetWithDouble3Array(IntPtr valuesArray, IntPtr timesArray, nuint count)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint(base.Handle, selResetWithDouble3Array_AtTimes_Count_Handle, valuesArray, timesArray, count);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint(base.SuperHandle, selResetWithDouble3Array_AtTimes_Count_Handle, valuesArray, timesArray, count);
		}
	}

	[Export("resetWithFloat3Array:atTimes:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _ResetWithFloat3Array(IntPtr valuesArray, IntPtr timesArray, nuint count)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint(base.Handle, selResetWithFloat3Array_AtTimes_Count_Handle, valuesArray, timesArray, count);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint(base.SuperHandle, selResetWithFloat3Array_AtTimes_Count_Handle, valuesArray, timesArray, count);
		}
	}
}

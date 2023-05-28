using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using OpenTK;
using Xamarin.Mac.System.Mac;

namespace ModelIO;

[Register("MDLAnimatedMatrix4x4", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class MDLAnimatedMatrix4x4 : MDLAnimatedValue
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDouble4x4AtTime_ = "double4x4AtTime:";

	private static readonly IntPtr selDouble4x4AtTime_Handle = Selector.GetHandle("double4x4AtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloat4x4AtTime_ = "float4x4AtTime:";

	private static readonly IntPtr selFloat4x4AtTime_Handle = Selector.GetHandle("float4x4AtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetDouble4x4Array_MaxCount_ = "getDouble4x4Array:maxCount:";

	private static readonly IntPtr selGetDouble4x4Array_MaxCount_Handle = Selector.GetHandle("getDouble4x4Array:maxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetFloat4x4Array_MaxCount_ = "getFloat4x4Array:maxCount:";

	private static readonly IntPtr selGetFloat4x4Array_MaxCount_Handle = Selector.GetHandle("getFloat4x4Array:maxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetWithDouble4x4Array_AtTimes_Count_ = "resetWithDouble4x4Array:atTimes:count:";

	private static readonly IntPtr selResetWithDouble4x4Array_AtTimes_Count_Handle = Selector.GetHandle("resetWithDouble4x4Array:atTimes:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetWithFloat4x4Array_AtTimes_Count_ = "resetWithFloat4x4Array:atTimes:count:";

	private static readonly IntPtr selResetWithFloat4x4Array_AtTimes_Count_Handle = Selector.GetHandle("resetWithFloat4x4Array:atTimes:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDouble4x4_AtTime_ = "setDouble4x4:atTime:";

	private static readonly IntPtr selSetDouble4x4_AtTime_Handle = Selector.GetHandle("setDouble4x4:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloat4x4_AtTime_ = "setFloat4x4:atTime:";

	private static readonly IntPtr selSetFloat4x4_AtTime_Handle = Selector.GetHandle("setFloat4x4:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLAnimatedMatrix4x4");

	public override IntPtr ClassHandle => class_ptr;

	public unsafe virtual void Reset(NMatrix4[] values, double[] times)
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
		int typeSize = Marshal.SizeOf(typeof(NMatrix4));
		fixed (NMatrix4* ptr = values)
		{
			MDLMemoryHelper.Reset(typeSize, (IntPtr)ptr, times, _ResetWithFloat4x4Array);
		}
	}

	public unsafe virtual void Reset(NMatrix4d[] values, double[] times)
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
		int typeSize = Marshal.SizeOf(typeof(NMatrix4d));
		fixed (NMatrix4d* ptr = values)
		{
			MDLMemoryHelper.Reset(typeSize, (IntPtr)ptr, times, _ResetWithDouble4x4Array);
		}
	}

	public unsafe virtual NMatrix4[] GetNMatrix4Values()
	{
		nuint timeSampleCount = TimeSampleCount;
		NMatrix4[] array = new NMatrix4[(int)timeSampleCount];
		int typeSize = sizeof(NMatrix4);
		fixed (NMatrix4* ptr = array)
		{
			MDLMemoryHelper.FetchValues(typeSize, (IntPtr)ptr, timeSampleCount, _GetFloat4x4Array);
		}
		return array;
	}

	public unsafe virtual NMatrix4d[] GetNMatrix4dValues()
	{
		nuint timeSampleCount = TimeSampleCount;
		NMatrix4d[] array = new NMatrix4d[(int)timeSampleCount];
		int typeSize = sizeof(NMatrix4d);
		fixed (NMatrix4d* ptr = array)
		{
			MDLMemoryHelper.FetchValues(typeSize, (IntPtr)ptr, timeSampleCount, _GetDouble4x4Array);
		}
		return array;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLAnimatedMatrix4x4()
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
	protected MDLAnimatedMatrix4x4(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLAnimatedMatrix4x4(IntPtr handle)
		: base(handle)
	{
	}

	[Export("float4x4AtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NMatrix4 GetNMatrix4Value(double time)
	{
		NMatrix4 retval;
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret_Double(out retval, base.Handle, selFloat4x4AtTime_Handle, time);
		}
		else
		{
			Messaging.xamarin_simd__NMatrix4_objc_msgSendSuper_stret_Double(out retval, base.SuperHandle, selFloat4x4AtTime_Handle, time);
		}
		return retval;
	}

	[Export("double4x4AtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NMatrix4d GetNMatrix4dValue(double time)
	{
		NMatrix4d retval;
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__NMatrix4d_objc_msgSend_stret_Double(out retval, base.Handle, selDouble4x4AtTime_Handle, time);
		}
		else
		{
			Messaging.xamarin_simd__NMatrix4d_objc_msgSendSuper_stret_Double(out retval, base.SuperHandle, selDouble4x4AtTime_Handle, time);
		}
		return retval;
	}

	[Export("setFloat4x4:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValue(NMatrix4 value, double time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_NMatrix4_Double(base.Handle, selSetFloat4x4_AtTime_Handle, value, time);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_NMatrix4_Double(base.SuperHandle, selSetFloat4x4_AtTime_Handle, value, time);
		}
	}

	[Export("setDouble4x4:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValue(NMatrix4d value, double time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_NMatrix4d_Double(base.Handle, selSetDouble4x4_AtTime_Handle, value, time);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_NMatrix4d_Double(base.SuperHandle, selSetDouble4x4_AtTime_Handle, value, time);
		}
	}

	[Export("getDouble4x4Array:maxCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual nuint _GetDouble4x4Array(IntPtr valuesArray, nuint maxCount)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_nuint(base.Handle, selGetDouble4x4Array_MaxCount_Handle, valuesArray, maxCount);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selGetDouble4x4Array_MaxCount_Handle, valuesArray, maxCount);
	}

	[Export("getFloat4x4Array:maxCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual nuint _GetFloat4x4Array(IntPtr valuesArray, nuint maxCount)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_nuint(base.Handle, selGetFloat4x4Array_MaxCount_Handle, valuesArray, maxCount);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selGetFloat4x4Array_MaxCount_Handle, valuesArray, maxCount);
	}

	[Export("resetWithDouble4x4Array:atTimes:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _ResetWithDouble4x4Array(IntPtr valuesArray, IntPtr timesArray, nuint count)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint(base.Handle, selResetWithDouble4x4Array_AtTimes_Count_Handle, valuesArray, timesArray, count);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint(base.SuperHandle, selResetWithDouble4x4Array_AtTimes_Count_Handle, valuesArray, timesArray, count);
		}
	}

	[Export("resetWithFloat4x4Array:atTimes:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _ResetWithFloat4x4Array(IntPtr valuesArray, IntPtr timesArray, nuint count)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint(base.Handle, selResetWithFloat4x4Array_AtTimes_Count_Handle, valuesArray, timesArray, count);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint(base.SuperHandle, selResetWithFloat4x4Array_AtTimes_Count_Handle, valuesArray, timesArray, count);
		}
	}
}

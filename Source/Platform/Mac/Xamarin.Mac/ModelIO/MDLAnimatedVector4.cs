using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace ModelIO;

[Register("MDLAnimatedVector4", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class MDLAnimatedVector4 : MDLAnimatedValue
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDouble4AtTime_ = "double4AtTime:";

	private static readonly IntPtr selDouble4AtTime_Handle = Selector.GetHandle("double4AtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloat4AtTime_ = "float4AtTime:";

	private static readonly IntPtr selFloat4AtTime_Handle = Selector.GetHandle("float4AtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetDouble4Array_MaxCount_ = "getDouble4Array:maxCount:";

	private static readonly IntPtr selGetDouble4Array_MaxCount_Handle = Selector.GetHandle("getDouble4Array:maxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetFloat4Array_MaxCount_ = "getFloat4Array:maxCount:";

	private static readonly IntPtr selGetFloat4Array_MaxCount_Handle = Selector.GetHandle("getFloat4Array:maxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetWithDouble4Array_AtTimes_Count_ = "resetWithDouble4Array:atTimes:count:";

	private static readonly IntPtr selResetWithDouble4Array_AtTimes_Count_Handle = Selector.GetHandle("resetWithDouble4Array:atTimes:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetWithFloat4Array_AtTimes_Count_ = "resetWithFloat4Array:atTimes:count:";

	private static readonly IntPtr selResetWithFloat4Array_AtTimes_Count_Handle = Selector.GetHandle("resetWithFloat4Array:atTimes:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDouble4_AtTime_ = "setDouble4:atTime:";

	private static readonly IntPtr selSetDouble4_AtTime_Handle = Selector.GetHandle("setDouble4:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloat4_AtTime_ = "setFloat4:atTime:";

	private static readonly IntPtr selSetFloat4_AtTime_Handle = Selector.GetHandle("setFloat4:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLAnimatedVector4");

	public override IntPtr ClassHandle => class_ptr;

	public unsafe virtual void Reset(Vector4[] values, double[] times)
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
		int typeSize = Marshal.SizeOf(typeof(Vector4));
		fixed (Vector4* ptr = values)
		{
			MDLMemoryHelper.Reset(typeSize, (IntPtr)ptr, times, _ResetWithFloat4Array);
		}
	}

	public unsafe virtual void Reset(Vector4d[] values, double[] times)
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
		int typeSize = Marshal.SizeOf(typeof(Vector4d));
		fixed (Vector4d* ptr = values)
		{
			MDLMemoryHelper.Reset(typeSize, (IntPtr)ptr, times, _ResetWithDouble4Array);
		}
	}

	public unsafe virtual Vector4[] GetVector4Values()
	{
		nuint timeSampleCount = TimeSampleCount;
		Vector4[] array = new Vector4[(int)timeSampleCount];
		int typeSize = sizeof(Vector4);
		fixed (Vector4* ptr = array)
		{
			MDLMemoryHelper.FetchValues(typeSize, (IntPtr)ptr, timeSampleCount, _GetFloat4Array);
		}
		return array;
	}

	public unsafe virtual Vector4d[] GetVector4dValues()
	{
		nuint timeSampleCount = TimeSampleCount;
		Vector4d[] array = new Vector4d[(int)timeSampleCount];
		int typeSize = sizeof(Vector4d);
		fixed (Vector4d* ptr = array)
		{
			MDLMemoryHelper.FetchValues(typeSize, (IntPtr)ptr, timeSampleCount, _GetDouble4Array);
		}
		return array;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLAnimatedVector4()
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
	protected MDLAnimatedVector4(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLAnimatedVector4(IntPtr handle)
		: base(handle)
	{
	}

	[Export("float4AtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector4 GetVector4Value(double time)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__Vector4_objc_msgSend_Double(base.Handle, selFloat4AtTime_Handle, time);
		}
		return Messaging.xamarin_simd__Vector4_objc_msgSendSuper_Double(base.SuperHandle, selFloat4AtTime_Handle, time);
	}

	[Export("double4AtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector4d GetVector4dValue(double time)
	{
		Vector4d retval;
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__Vector4d_objc_msgSend_stret_Double(out retval, base.Handle, selDouble4AtTime_Handle, time);
		}
		else
		{
			Messaging.xamarin_simd__Vector4d_objc_msgSendSuper_stret_Double(out retval, base.SuperHandle, selDouble4AtTime_Handle, time);
		}
		return retval;
	}

	[Export("setFloat4:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValue(Vector4 value, double time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_Vector4_Double(base.Handle, selSetFloat4_AtTime_Handle, value, time);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_Vector4_Double(base.SuperHandle, selSetFloat4_AtTime_Handle, value, time);
		}
	}

	[Export("setDouble4:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValue(Vector4d value, double time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_Vector4d_Double(base.Handle, selSetDouble4_AtTime_Handle, value, time);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_Vector4d_Double(base.SuperHandle, selSetDouble4_AtTime_Handle, value, time);
		}
	}

	[Export("getDouble4Array:maxCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual nuint _GetDouble4Array(IntPtr valuesArray, nuint maxCount)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_nuint(base.Handle, selGetDouble4Array_MaxCount_Handle, valuesArray, maxCount);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selGetDouble4Array_MaxCount_Handle, valuesArray, maxCount);
	}

	[Export("getFloat4Array:maxCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual nuint _GetFloat4Array(IntPtr valuesArray, nuint maxCount)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_nuint(base.Handle, selGetFloat4Array_MaxCount_Handle, valuesArray, maxCount);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selGetFloat4Array_MaxCount_Handle, valuesArray, maxCount);
	}

	[Export("resetWithDouble4Array:atTimes:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _ResetWithDouble4Array(IntPtr valuesArray, IntPtr timesArray, nuint count)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint(base.Handle, selResetWithDouble4Array_AtTimes_Count_Handle, valuesArray, timesArray, count);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint(base.SuperHandle, selResetWithDouble4Array_AtTimes_Count_Handle, valuesArray, timesArray, count);
		}
	}

	[Export("resetWithFloat4Array:atTimes:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _ResetWithFloat4Array(IntPtr valuesArray, IntPtr timesArray, nuint count)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint(base.Handle, selResetWithFloat4Array_AtTimes_Count_Handle, valuesArray, timesArray, count);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint(base.SuperHandle, selResetWithFloat4Array_AtTimes_Count_Handle, valuesArray, timesArray, count);
		}
	}
}

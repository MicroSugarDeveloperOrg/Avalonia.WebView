using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace ModelIO;

[Register("MDLAnimatedVector2", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class MDLAnimatedVector2 : MDLAnimatedValue
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDouble2AtTime_ = "double2AtTime:";

	private static readonly IntPtr selDouble2AtTime_Handle = Selector.GetHandle("double2AtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloat2AtTime_ = "float2AtTime:";

	private static readonly IntPtr selFloat2AtTime_Handle = Selector.GetHandle("float2AtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetDouble2Array_MaxCount_ = "getDouble2Array:maxCount:";

	private static readonly IntPtr selGetDouble2Array_MaxCount_Handle = Selector.GetHandle("getDouble2Array:maxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetFloat2Array_MaxCount_ = "getFloat2Array:maxCount:";

	private static readonly IntPtr selGetFloat2Array_MaxCount_Handle = Selector.GetHandle("getFloat2Array:maxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetWithDouble2Array_AtTimes_Count_ = "resetWithDouble2Array:atTimes:count:";

	private static readonly IntPtr selResetWithDouble2Array_AtTimes_Count_Handle = Selector.GetHandle("resetWithDouble2Array:atTimes:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetWithFloat2Array_AtTimes_Count_ = "resetWithFloat2Array:atTimes:count:";

	private static readonly IntPtr selResetWithFloat2Array_AtTimes_Count_Handle = Selector.GetHandle("resetWithFloat2Array:atTimes:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDouble2_AtTime_ = "setDouble2:atTime:";

	private static readonly IntPtr selSetDouble2_AtTime_Handle = Selector.GetHandle("setDouble2:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloat2_AtTime_ = "setFloat2:atTime:";

	private static readonly IntPtr selSetFloat2_AtTime_Handle = Selector.GetHandle("setFloat2:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLAnimatedVector2");

	public override IntPtr ClassHandle => class_ptr;

	public unsafe virtual void Reset(Vector2[] values, double[] times)
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
		int typeSize = Marshal.SizeOf(typeof(Vector2));
		fixed (Vector2* ptr = values)
		{
			MDLMemoryHelper.Reset(typeSize, (IntPtr)ptr, times, _ResetWithFloat2Array);
		}
	}

	public unsafe virtual void Reset(Vector2d[] values, double[] times)
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
		int typeSize = Marshal.SizeOf(typeof(Vector2d));
		fixed (Vector2d* ptr = values)
		{
			MDLMemoryHelper.Reset(typeSize, (IntPtr)ptr, times, _ResetWithDouble2Array);
		}
	}

	public unsafe virtual Vector2[] GetVector2Values()
	{
		nuint timeSampleCount = TimeSampleCount;
		Vector2[] array = new Vector2[(int)timeSampleCount];
		int typeSize = sizeof(Vector2);
		fixed (Vector2* ptr = array)
		{
			MDLMemoryHelper.FetchValues(typeSize, (IntPtr)ptr, timeSampleCount, _GetFloat2Array);
		}
		return array;
	}

	public unsafe virtual Vector2d[] GetVector2dValues()
	{
		nuint timeSampleCount = TimeSampleCount;
		Vector2d[] array = new Vector2d[(int)timeSampleCount];
		int typeSize = sizeof(Vector2d);
		fixed (Vector2d* ptr = array)
		{
			MDLMemoryHelper.FetchValues(typeSize, (IntPtr)ptr, timeSampleCount, _GetDouble2Array);
		}
		return array;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLAnimatedVector2()
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
	protected MDLAnimatedVector2(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLAnimatedVector2(IntPtr handle)
		: base(handle)
	{
	}

	[Export("float2AtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector2 GetVector2Value(double time)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__Vector2_objc_msgSend_Double(base.Handle, selFloat2AtTime_Handle, time);
		}
		return Messaging.xamarin_simd__Vector2_objc_msgSendSuper_Double(base.SuperHandle, selFloat2AtTime_Handle, time);
	}

	[Export("double2AtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector2d GetVector2dValue(double time)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__Vector2d_objc_msgSend_Double(base.Handle, selDouble2AtTime_Handle, time);
		}
		return Messaging.xamarin_simd__Vector2d_objc_msgSendSuper_Double(base.SuperHandle, selDouble2AtTime_Handle, time);
	}

	[Export("setFloat2:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValue(Vector2 value, double time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_Vector2_Double(base.Handle, selSetFloat2_AtTime_Handle, value, time);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_Vector2_Double(base.SuperHandle, selSetFloat2_AtTime_Handle, value, time);
		}
	}

	[Export("setDouble2:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetValue(Vector2d value, double time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_Vector2d_Double(base.Handle, selSetDouble2_AtTime_Handle, value, time);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_Vector2d_Double(base.SuperHandle, selSetDouble2_AtTime_Handle, value, time);
		}
	}

	[Export("getDouble2Array:maxCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual nuint _GetDouble2Array(IntPtr valuesArray, nuint maxCount)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_nuint(base.Handle, selGetDouble2Array_MaxCount_Handle, valuesArray, maxCount);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selGetDouble2Array_MaxCount_Handle, valuesArray, maxCount);
	}

	[Export("getFloat2Array:maxCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual nuint _GetFloat2Array(IntPtr valuesArray, nuint maxCount)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_nuint(base.Handle, selGetFloat2Array_MaxCount_Handle, valuesArray, maxCount);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selGetFloat2Array_MaxCount_Handle, valuesArray, maxCount);
	}

	[Export("resetWithDouble2Array:atTimes:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _ResetWithDouble2Array(IntPtr valuesArray, IntPtr timesArray, nuint count)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint(base.Handle, selResetWithDouble2Array_AtTimes_Count_Handle, valuesArray, timesArray, count);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint(base.SuperHandle, selResetWithDouble2Array_AtTimes_Count_Handle, valuesArray, timesArray, count);
		}
	}

	[Export("resetWithFloat2Array:atTimes:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _ResetWithFloat2Array(IntPtr valuesArray, IntPtr timesArray, nuint count)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint(base.Handle, selResetWithFloat2Array_AtTimes_Count_Handle, valuesArray, timesArray, count);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint(base.SuperHandle, selResetWithFloat2Array_AtTimes_Count_Handle, valuesArray, timesArray, count);
		}
	}
}

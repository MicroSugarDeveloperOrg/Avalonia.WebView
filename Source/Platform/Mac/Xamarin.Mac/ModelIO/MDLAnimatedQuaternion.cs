using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace ModelIO;

[Register("MDLAnimatedQuaternion", true)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
public class MDLAnimatedQuaternion : MDLAnimatedValue
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoubleQuaternionAtTime_ = "doubleQuaternionAtTime:";

	private static readonly IntPtr selDoubleQuaternionAtTime_Handle = Selector.GetHandle("doubleQuaternionAtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloatQuaternionAtTime_ = "floatQuaternionAtTime:";

	private static readonly IntPtr selFloatQuaternionAtTime_Handle = Selector.GetHandle("floatQuaternionAtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetDoubleQuaternionArray_MaxCount_ = "getDoubleQuaternionArray:maxCount:";

	private static readonly IntPtr selGetDoubleQuaternionArray_MaxCount_Handle = Selector.GetHandle("getDoubleQuaternionArray:maxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetFloatQuaternionArray_MaxCount_ = "getFloatQuaternionArray:maxCount:";

	private static readonly IntPtr selGetFloatQuaternionArray_MaxCount_Handle = Selector.GetHandle("getFloatQuaternionArray:maxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetWithDoubleQuaternionArray_AtTimes_Count_ = "resetWithDoubleQuaternionArray:atTimes:count:";

	private static readonly IntPtr selResetWithDoubleQuaternionArray_AtTimes_Count_Handle = Selector.GetHandle("resetWithDoubleQuaternionArray:atTimes:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetWithFloatQuaternionArray_AtTimes_Count_ = "resetWithFloatQuaternionArray:atTimes:count:";

	private static readonly IntPtr selResetWithFloatQuaternionArray_AtTimes_Count_Handle = Selector.GetHandle("resetWithFloatQuaternionArray:atTimes:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDoubleQuaternion_AtTime_ = "setDoubleQuaternion:atTime:";

	private static readonly IntPtr selSetDoubleQuaternion_AtTime_Handle = Selector.GetHandle("setDoubleQuaternion:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloatQuaternion_AtTime_ = "setFloatQuaternion:atTime:";

	private static readonly IntPtr selSetFloatQuaternion_AtTime_Handle = Selector.GetHandle("setFloatQuaternion:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLAnimatedQuaternion");

	public override IntPtr ClassHandle => class_ptr;

	public unsafe virtual void Reset(Quaternion[] values, double[] times)
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
			throw new ArgumentOutOfRangeException("The 'values' and 'times' arrays must have the same length");
		}
		int typeSize = Marshal.SizeOf(typeof(Quaternion));
		fixed (Quaternion* ptr = values)
		{
			MDLMemoryHelper.Reset(typeSize, (IntPtr)ptr, times, _ResetWithFloatQuaternionArray);
		}
	}

	public unsafe virtual void Reset(Quaterniond[] values, double[] times)
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
			throw new ArgumentOutOfRangeException("The 'values' and 'times' arrays must have the same length");
		}
		int typeSize = Marshal.SizeOf(typeof(Quaterniond));
		fixed (Quaterniond* ptr = values)
		{
			MDLMemoryHelper.Reset(typeSize, (IntPtr)ptr, times, _ResetWithDoubleQuaternionArray);
		}
	}

	public unsafe virtual Quaternion[] GetQuaternionValues(nuint maxCount)
	{
		Quaternion[] array = new Quaternion[(int)maxCount];
		int typeSize = sizeof(Quaternion);
		fixed (Quaternion* ptr = array)
		{
			nuint nuint = MDLMemoryHelper.FetchValues(typeSize, (IntPtr)ptr, maxCount, _GetFloatQuaternionArray);
			Array.Resize(ref array, (int)nuint);
		}
		return array;
	}

	public unsafe virtual Quaterniond[] GetQuaterniondValues(nuint maxCount)
	{
		Quaterniond[] array = new Quaterniond[(int)maxCount];
		int typeSize = sizeof(Quaterniond);
		fixed (Quaterniond* ptr = array)
		{
			nuint nuint = MDLMemoryHelper.FetchValues(typeSize, (IntPtr)ptr, maxCount, _GetDoubleQuaternionArray);
			Array.Resize(ref array, (int)nuint);
		}
		return array;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLAnimatedQuaternion()
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
	protected MDLAnimatedQuaternion(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLAnimatedQuaternion(IntPtr handle)
		: base(handle)
	{
	}

	[Export("doubleQuaternionAtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Quaterniond GetDoubleQuaternion(double atTime)
	{
		Quaterniond retval;
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__Quaterniond_objc_msgSend_stret_Double(out retval, base.Handle, selDoubleQuaternionAtTime_Handle, atTime);
		}
		else
		{
			Messaging.xamarin_simd__Quaterniond_objc_msgSendSuper_stret_Double(out retval, base.SuperHandle, selDoubleQuaternionAtTime_Handle, atTime);
		}
		return retval;
	}

	[Export("floatQuaternionAtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Quaternion GetFloatQuaternion(double atTime)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__Quaternion_objc_msgSend_Double(base.Handle, selFloatQuaternionAtTime_Handle, atTime);
		}
		return Messaging.xamarin_simd__Quaternion_objc_msgSendSuper_Double(base.SuperHandle, selFloatQuaternionAtTime_Handle, atTime);
	}

	[Export("setFloatQuaternion:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetQuaternion(Quaternion value, double atTime)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_Quaternion_Double(base.Handle, selSetFloatQuaternion_AtTime_Handle, value, atTime);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_Quaternion_Double(base.SuperHandle, selSetFloatQuaternion_AtTime_Handle, value, atTime);
		}
	}

	[Export("setDoubleQuaternion:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetQuaternion(Quaterniond value, double atTime)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_Quaterniond_Double(base.Handle, selSetDoubleQuaternion_AtTime_Handle, value, atTime);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_Quaterniond_Double(base.SuperHandle, selSetDoubleQuaternion_AtTime_Handle, value, atTime);
		}
	}

	[Export("getDoubleQuaternionArray:maxCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual nuint _GetDoubleQuaternionArray(IntPtr valuesArray, nuint maxCount)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_nuint(base.Handle, selGetDoubleQuaternionArray_MaxCount_Handle, valuesArray, maxCount);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selGetDoubleQuaternionArray_MaxCount_Handle, valuesArray, maxCount);
	}

	[Export("getFloatQuaternionArray:maxCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual nuint _GetFloatQuaternionArray(IntPtr valuesArray, nuint maxCount)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_nuint(base.Handle, selGetFloatQuaternionArray_MaxCount_Handle, valuesArray, maxCount);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selGetFloatQuaternionArray_MaxCount_Handle, valuesArray, maxCount);
	}

	[Export("resetWithDoubleQuaternionArray:atTimes:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _ResetWithDoubleQuaternionArray(IntPtr valuesArray, IntPtr timesArray, nuint times)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint(base.Handle, selResetWithDoubleQuaternionArray_AtTimes_Count_Handle, valuesArray, timesArray, times);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint(base.SuperHandle, selResetWithDoubleQuaternionArray_AtTimes_Count_Handle, valuesArray, timesArray, times);
		}
	}

	[Export("resetWithFloatQuaternionArray:atTimes:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _ResetWithFloatQuaternionArray(IntPtr valuesArray, IntPtr timesArray, nuint times)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint(base.Handle, selResetWithFloatQuaternionArray_AtTimes_Count_Handle, valuesArray, timesArray, times);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint(base.SuperHandle, selResetWithFloatQuaternionArray_AtTimes_Count_Handle, valuesArray, timesArray, times);
		}
	}
}

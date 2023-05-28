using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using OpenTK;
using Xamarin.Mac.System.Mac;

namespace ModelIO;

[Register("MDLAnimatedQuaternionArray", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class MDLAnimatedQuaternionArray : MDLAnimatedValue
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementCount = "elementCount";

	private static readonly IntPtr selElementCountHandle = Selector.GetHandle("elementCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetDoubleQuaternionArray_MaxCount_ = "getDoubleQuaternionArray:maxCount:";

	private static readonly IntPtr selGetDoubleQuaternionArray_MaxCount_Handle = Selector.GetHandle("getDoubleQuaternionArray:maxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetDoubleQuaternionArray_MaxCount_AtTime_ = "getDoubleQuaternionArray:maxCount:atTime:";

	private static readonly IntPtr selGetDoubleQuaternionArray_MaxCount_AtTime_Handle = Selector.GetHandle("getDoubleQuaternionArray:maxCount:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetFloatQuaternionArray_MaxCount_ = "getFloatQuaternionArray:maxCount:";

	private static readonly IntPtr selGetFloatQuaternionArray_MaxCount_Handle = Selector.GetHandle("getFloatQuaternionArray:maxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetFloatQuaternionArray_MaxCount_AtTime_ = "getFloatQuaternionArray:maxCount:atTime:";

	private static readonly IntPtr selGetFloatQuaternionArray_MaxCount_AtTime_Handle = Selector.GetHandle("getFloatQuaternionArray:maxCount:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithElementCount_ = "initWithElementCount:";

	private static readonly IntPtr selInitWithElementCount_Handle = Selector.GetHandle("initWithElementCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetWithDoubleQuaternionArray_Count_AtTimes_Count_ = "resetWithDoubleQuaternionArray:count:atTimes:count:";

	private static readonly IntPtr selResetWithDoubleQuaternionArray_Count_AtTimes_Count_Handle = Selector.GetHandle("resetWithDoubleQuaternionArray:count:atTimes:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResetWithFloatQuaternionArray_Count_AtTimes_Count_ = "resetWithFloatQuaternionArray:count:atTimes:count:";

	private static readonly IntPtr selResetWithFloatQuaternionArray_Count_AtTimes_Count_Handle = Selector.GetHandle("resetWithFloatQuaternionArray:count:atTimes:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDoubleQuaternionArray_Count_AtTime_ = "setDoubleQuaternionArray:count:atTime:";

	private static readonly IntPtr selSetDoubleQuaternionArray_Count_AtTime_Handle = Selector.GetHandle("setDoubleQuaternionArray:count:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloatQuaternionArray_Count_AtTime_ = "setFloatQuaternionArray:count:atTime:";

	private static readonly IntPtr selSetFloatQuaternionArray_Count_AtTime_Handle = Selector.GetHandle("setFloatQuaternionArray:count:atTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLAnimatedQuaternionArray");

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

	public unsafe virtual void SetValues(Quaternion[] array, double time)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		int typeSize = Marshal.SizeOf(typeof(Quaternion));
		fixed (Quaternion* ptr = array)
		{
			MDLMemoryHelper.SetValues(typeSize, (IntPtr)ptr, array.Length, time, _SetFloatQuaternionArray);
		}
	}

	public unsafe virtual void SetValues(Quaterniond[] array, double time)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		int typeSize = Marshal.SizeOf(typeof(Quaterniond));
		fixed (Quaterniond* ptr = array)
		{
			MDLMemoryHelper.SetValues(typeSize, (IntPtr)ptr, array.Length, time, _SetDoubleQuaternionArray);
		}
	}

	public unsafe virtual Quaternion[] GetQuaternionValues(double time)
	{
		nuint elementCount = ElementCount;
		Quaternion[] array = new Quaternion[(int)elementCount];
		int typeSize = sizeof(Quaternion);
		fixed (Quaternion* ptr = array)
		{
			MDLMemoryHelper.FetchValues(typeSize, (IntPtr)ptr, elementCount, time, _GetFloatQuaternionArray);
		}
		return array;
	}

	public unsafe virtual Quaterniond[] GetQuaterniondValues(double time)
	{
		nuint elementCount = ElementCount;
		Quaterniond[] array = new Quaterniond[(int)elementCount];
		int typeSize = sizeof(Quaterniond);
		fixed (Quaterniond* ptr = array)
		{
			MDLMemoryHelper.FetchValues(typeSize, (IntPtr)ptr, elementCount, time, _GetDoubleQuaternionArray);
		}
		return array;
	}

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
		int typeSize = Marshal.SizeOf(typeof(Quaternion));
		fixed (Quaternion* ptr = values)
		{
			MDLMemoryHelper.Reset(typeSize, (IntPtr)ptr, values.Length, times, _ResetWithFloatQuaternionArray);
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
		int typeSize = Marshal.SizeOf(typeof(Quaterniond));
		fixed (Quaterniond* ptr = values)
		{
			MDLMemoryHelper.Reset(typeSize, (IntPtr)ptr, values.Length, times, _ResetWithDoubleQuaternionArray);
		}
	}

	public unsafe virtual Quaternion[] GetQuaternionValues()
	{
		nuint nuint = ElementCount * TimeSampleCount;
		Quaternion[] array = new Quaternion[(int)nuint];
		int typeSize = sizeof(Quaternion);
		fixed (Quaternion* ptr = array)
		{
			MDLMemoryHelper.FetchValues(typeSize, (IntPtr)ptr, nuint, _GetFloatQuaternionArray);
		}
		return array;
	}

	public unsafe virtual Quaterniond[] GetQuaterniondValues()
	{
		nuint nuint = ElementCount * TimeSampleCount;
		Quaterniond[] array = new Quaterniond[(int)nuint];
		int typeSize = sizeof(Quaterniond);
		fixed (Quaterniond* ptr = array)
		{
			MDLMemoryHelper.FetchValues(typeSize, (IntPtr)ptr, nuint, _GetDoubleQuaternionArray);
		}
		return array;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLAnimatedQuaternionArray()
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
	protected MDLAnimatedQuaternionArray(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLAnimatedQuaternionArray(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithElementCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLAnimatedQuaternionArray(nuint arrayElementCount)
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

	[Export("getDoubleQuaternionArray:maxCount:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual nuint _GetDoubleQuaternionArray(IntPtr array, nuint maxCount, double time)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_nuint_Double(base.Handle, selGetDoubleQuaternionArray_MaxCount_AtTime_Handle, array, maxCount, time);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_nuint_Double(base.SuperHandle, selGetDoubleQuaternionArray_MaxCount_AtTime_Handle, array, maxCount, time);
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

	[Export("getFloatQuaternionArray:maxCount:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual nuint _GetFloatQuaternionArray(IntPtr array, nuint maxCount, double time)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_nuint_Double(base.Handle, selGetFloatQuaternionArray_MaxCount_AtTime_Handle, array, maxCount, time);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_nuint_Double(base.SuperHandle, selGetFloatQuaternionArray_MaxCount_AtTime_Handle, array, maxCount, time);
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

	[Export("resetWithDoubleQuaternionArray:count:atTimes:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _ResetWithDoubleQuaternionArray(IntPtr valuesArray, nuint valuesCount, IntPtr timesArray, nuint timesCount)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint_IntPtr_nuint(base.Handle, selResetWithDoubleQuaternionArray_Count_AtTimes_Count_Handle, valuesArray, valuesCount, timesArray, timesCount);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint_IntPtr_nuint(base.SuperHandle, selResetWithDoubleQuaternionArray_Count_AtTimes_Count_Handle, valuesArray, valuesCount, timesArray, timesCount);
		}
	}

	[Export("resetWithFloatQuaternionArray:count:atTimes:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _ResetWithFloatQuaternionArray(IntPtr valuesArray, nuint valuesCount, IntPtr timesArray, nuint timesCount)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint_IntPtr_nuint(base.Handle, selResetWithFloatQuaternionArray_Count_AtTimes_Count_Handle, valuesArray, valuesCount, timesArray, timesCount);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint_IntPtr_nuint(base.SuperHandle, selResetWithFloatQuaternionArray_Count_AtTimes_Count_Handle, valuesArray, valuesCount, timesArray, timesCount);
		}
	}

	[Export("setDoubleQuaternionArray:count:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _SetDoubleQuaternionArray(IntPtr array, nuint count, double time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint_Double(base.Handle, selSetDoubleQuaternionArray_Count_AtTime_Handle, array, count, time);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint_Double(base.SuperHandle, selSetDoubleQuaternionArray_Count_AtTime_Handle, array, count, time);
		}
	}

	[Export("setFloatQuaternionArray:count:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _SetFloatQuaternionArray(IntPtr array, nuint count, double time)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint_Double(base.Handle, selSetFloatQuaternionArray_Count_AtTime_Handle, array, count, time);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint_Double(base.SuperHandle, selSetFloatQuaternionArray_Count_AtTime_Handle, array, count, time);
		}
	}
}

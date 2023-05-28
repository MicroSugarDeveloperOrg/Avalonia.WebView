using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

[Register("MDLAnimatedValue", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class MDLAnimatedValue : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClear = "clear";

	private static readonly IntPtr selClearHandle = Selector.GetHandle("clear");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetTimes_MaxCount_ = "getTimes:maxCount:";

	private static readonly IntPtr selGetTimes_MaxCount_Handle = Selector.GetHandle("getTimes:maxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterpolation = "interpolation";

	private static readonly IntPtr selInterpolationHandle = Selector.GetHandle("interpolation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAnimated = "isAnimated";

	private static readonly IntPtr selIsAnimatedHandle = Selector.GetHandle("isAnimated");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeyTimes = "keyTimes";

	private static readonly IntPtr selKeyTimesHandle = Selector.GetHandle("keyTimes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumTime = "maximumTime";

	private static readonly IntPtr selMaximumTimeHandle = Selector.GetHandle("maximumTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumTime = "minimumTime";

	private static readonly IntPtr selMinimumTimeHandle = Selector.GetHandle("minimumTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrecision = "precision";

	private static readonly IntPtr selPrecisionHandle = Selector.GetHandle("precision");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInterpolation_ = "setInterpolation:";

	private static readonly IntPtr selSetInterpolation_Handle = Selector.GetHandle("setInterpolation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeSampleCount = "timeSampleCount";

	private static readonly IntPtr selTimeSampleCountHandle = Selector.GetHandle("timeSampleCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLAnimatedValue");

	public double[] KeyTimes
	{
		get
		{
			NSNumber[] weakKeyTimes = WeakKeyTimes;
			if (weakKeyTimes == null)
			{
				return null;
			}
			int num = weakKeyTimes.Length;
			double[] array = new double[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = weakKeyTimes[i].DoubleValue;
			}
			return array;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLAnimatedValueInterpolation Interpolation
	{
		[Export("interpolation", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MDLAnimatedValueInterpolation)Messaging.UInt64_objc_msgSend(base.Handle, selInterpolationHandle);
			}
			return (MDLAnimatedValueInterpolation)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selInterpolationHandle);
		}
		[Export("setInterpolation:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetInterpolation_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetInterpolation_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsAnimated
	{
		[Export("isAnimated")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAnimatedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAnimatedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double MaximumTime
	{
		[Export("maximumTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMaximumTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMaximumTimeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double MinimumTime
	{
		[Export("minimumTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMinimumTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMinimumTimeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLDataPrecision Precision
	{
		[Export("precision")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MDLDataPrecision)Messaging.UInt64_objc_msgSend(base.Handle, selPrecisionHandle);
			}
			return (MDLDataPrecision)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPrecisionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint TimeSampleCount
	{
		[Export("timeSampleCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selTimeSampleCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selTimeSampleCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSNumber[] WeakKeyTimes
	{
		[Export("keyTimes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyTimesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyTimesHandle));
		}
	}

	public unsafe virtual double[] GetTimes()
	{
		nuint timeSampleCount = TimeSampleCount;
		double[] array = new double[(int)timeSampleCount];
		fixed (double* ptr = array)
		{
			_GetTimes((IntPtr)ptr, timeSampleCount);
		}
		return array;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLAnimatedValue()
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
	protected MDLAnimatedValue(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLAnimatedValue(IntPtr handle)
		: base(handle)
	{
	}

	[Export("clear")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Clear()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selClearHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selClearHandle);
		}
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("getTimes:maxCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual nuint _GetTimes(IntPtr timesArray, nuint maxCount)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_nuint(base.Handle, selGetTimes_MaxCount_Handle, timesArray, maxCount);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selGetTimes_MaxCount_Handle, timesArray, maxCount);
	}
}

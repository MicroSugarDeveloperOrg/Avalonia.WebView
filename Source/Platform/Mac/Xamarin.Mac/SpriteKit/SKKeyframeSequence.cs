using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKKeyframeSequence", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class SKKeyframeSequence : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddKeyframeValue_Time_ = "addKeyframeValue:time:";

	private static readonly IntPtr selAddKeyframeValue_Time_Handle = Selector.GetHandle("addKeyframeValue:time:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCount = "count";

	private static readonly IntPtr selCountHandle = Selector.GetHandle("count");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetKeyframeTimeForIndex_ = "getKeyframeTimeForIndex:";

	private static readonly IntPtr selGetKeyframeTimeForIndex_Handle = Selector.GetHandle("getKeyframeTimeForIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetKeyframeValueForIndex_ = "getKeyframeValueForIndex:";

	private static readonly IntPtr selGetKeyframeValueForIndex_Handle = Selector.GetHandle("getKeyframeValueForIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCapacity_ = "initWithCapacity:";

	private static readonly IntPtr selInitWithCapacity_Handle = Selector.GetHandle("initWithCapacity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithKeyframeValues_Times_ = "initWithKeyframeValues:times:";

	private static readonly IntPtr selInitWithKeyframeValues_Times_Handle = Selector.GetHandle("initWithKeyframeValues:times:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterpolationMode = "interpolationMode";

	private static readonly IntPtr selInterpolationModeHandle = Selector.GetHandle("interpolationMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveKeyframeAtIndex_ = "removeKeyframeAtIndex:";

	private static readonly IntPtr selRemoveKeyframeAtIndex_Handle = Selector.GetHandle("removeKeyframeAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveLastKeyframe = "removeLastKeyframe";

	private static readonly IntPtr selRemoveLastKeyframeHandle = Selector.GetHandle("removeLastKeyframe");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRepeatMode = "repeatMode";

	private static readonly IntPtr selRepeatModeHandle = Selector.GetHandle("repeatMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSampleAtTime_ = "sampleAtTime:";

	private static readonly IntPtr selSampleAtTime_Handle = Selector.GetHandle("sampleAtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInterpolationMode_ = "setInterpolationMode:";

	private static readonly IntPtr selSetInterpolationMode_Handle = Selector.GetHandle("setInterpolationMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKeyframeTime_ForIndex_ = "setKeyframeTime:forIndex:";

	private static readonly IntPtr selSetKeyframeTime_ForIndex_Handle = Selector.GetHandle("setKeyframeTime:forIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKeyframeValue_ForIndex_ = "setKeyframeValue:forIndex:";

	private static readonly IntPtr selSetKeyframeValue_ForIndex_Handle = Selector.GetHandle("setKeyframeValue:forIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKeyframeValue_Time_ForIndex_ = "setKeyframeValue:time:forIndex:";

	private static readonly IntPtr selSetKeyframeValue_Time_ForIndex_Handle = Selector.GetHandle("setKeyframeValue:time:forIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRepeatMode_ = "setRepeatMode:";

	private static readonly IntPtr selSetRepeatMode_Handle = Selector.GetHandle("setRepeatMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKKeyframeSequence");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint Count
	{
		[Export("count")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKInterpolationMode InterpolationMode
	{
		[Export("interpolationMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SKInterpolationMode)Messaging.Int64_objc_msgSend(base.Handle, selInterpolationModeHandle);
			}
			return (SKInterpolationMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selInterpolationModeHandle);
		}
		[Export("setInterpolationMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetInterpolationMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetInterpolationMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKRepeatMode RepeatMode
	{
		[Export("repeatMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SKRepeatMode)Messaging.Int64_objc_msgSend(base.Handle, selRepeatModeHandle);
			}
			return (SKRepeatMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selRepeatModeHandle);
		}
		[Export("setRepeatMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetRepeatMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetRepeatMode_Handle, (long)value);
			}
		}
	}

	[DesignatedInitializer]
	public SKKeyframeSequence(NSObject[] values, NSNumber[] times)
		: this(values, NSArray.FromNSObjects(times))
	{
	}

	[DesignatedInitializer]
	public SKKeyframeSequence(NSObject[] values, float[] times)
		: this(values, Convert(times))
	{
	}

	[DesignatedInitializer]
	public SKKeyframeSequence(NSObject[] values, double[] times)
		: this(values, Convert(times))
	{
	}

	private static NSNumber[] Convert(float[] values)
	{
		if (values == null)
		{
			return null;
		}
		NSNumber[] array = new NSNumber[values.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = NSNumber.FromFloat(values[i]);
		}
		return array;
	}

	private static NSNumber[] Convert(double[] values)
	{
		if (values == null)
		{
			return null;
		}
		NSNumber[] array = new NSNumber[values.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = NSNumber.FromDouble(values[i]);
		}
		return array;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKKeyframeSequence()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SKKeyframeSequence(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SKKeyframeSequence(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKKeyframeSequence(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithKeyframeValues:times:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal SKKeyframeSequence(NSObject[]? values, NSArray? times)
		: base(NSObjectFlag.Empty)
	{
		NSArray nSArray = ((values == null) ? null : NSArray.FromNSObjects(values));
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithKeyframeValues_Times_Handle, nSArray?.Handle ?? IntPtr.Zero, times?.Handle ?? IntPtr.Zero), "initWithKeyframeValues:times:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithKeyframeValues_Times_Handle, nSArray?.Handle ?? IntPtr.Zero, times?.Handle ?? IntPtr.Zero), "initWithKeyframeValues:times:");
		}
		nSArray?.Dispose();
	}

	[Export("initWithCapacity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKKeyframeSequence(nuint numItems)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selInitWithCapacity_Handle, numItems), "initWithCapacity:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selInitWithCapacity_Handle, numItems), "initWithCapacity:");
		}
	}

	[Export("addKeyframeValue:time:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddKeyframeValue(NSObject value, nfloat time)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nfloat(base.Handle, selAddKeyframeValue_Time_Handle, value.Handle, time);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nfloat(base.SuperHandle, selAddKeyframeValue_Time_Handle, value.Handle, time);
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

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("getKeyframeTimeForIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetKeyframeTime(nuint index)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_nuint(base.Handle, selGetKeyframeTimeForIndex_Handle, index);
		}
		return Messaging.nfloat_objc_msgSendSuper_nuint(base.SuperHandle, selGetKeyframeTimeForIndex_Handle, index);
	}

	[Export("getKeyframeValueForIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetKeyframeValue(nuint index)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selGetKeyframeValueForIndex_Handle, index));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selGetKeyframeValueForIndex_Handle, index));
	}

	[Export("removeKeyframeAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveKeyframe(nuint index)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nuint(base.Handle, selRemoveKeyframeAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selRemoveKeyframeAtIndex_Handle, index);
		}
	}

	[Export("removeLastKeyframe")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveLastKeyframe()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveLastKeyframeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveLastKeyframeHandle);
		}
	}

	[Export("sampleAtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject SampleAtTime(nfloat time)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_nfloat(base.Handle, selSampleAtTime_Handle, time));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_nfloat(base.SuperHandle, selSampleAtTime_Handle, time));
	}

	[Export("setKeyframeTime:forIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetKeyframeTime(nfloat time, nuint index)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_nuint(base.Handle, selSetKeyframeTime_ForIndex_Handle, time, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_nuint(base.SuperHandle, selSetKeyframeTime_ForIndex_Handle, time, index);
		}
	}

	[Export("setKeyframeValue:forIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetKeyframeValue(NSObject value, nuint index)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, selSetKeyframeValue_ForIndex_Handle, value.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selSetKeyframeValue_ForIndex_Handle, value.Handle, index);
		}
	}

	[Export("setKeyframeValue:time:forIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetKeyframeValue(NSObject value, nfloat time, nuint index)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nfloat_nuint(base.Handle, selSetKeyframeValue_Time_ForIndex_Handle, value.Handle, time, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nfloat_nuint(base.SuperHandle, selSetKeyframeValue_Time_ForIndex_Handle, value.Handle, time, index);
		}
	}
}

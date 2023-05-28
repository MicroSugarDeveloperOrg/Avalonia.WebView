using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKRange", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SKRange : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithLowerLimit_UpperLimit_ = "initWithLowerLimit:upperLimit:";

	private static readonly IntPtr selInitWithLowerLimit_UpperLimit_Handle = Selector.GetHandle("initWithLowerLimit:upperLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLowerLimit = "lowerLimit";

	private static readonly IntPtr selLowerLimitHandle = Selector.GetHandle("lowerLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangeWithConstantValue_ = "rangeWithConstantValue:";

	private static readonly IntPtr selRangeWithConstantValue_Handle = Selector.GetHandle("rangeWithConstantValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangeWithLowerLimit_ = "rangeWithLowerLimit:";

	private static readonly IntPtr selRangeWithLowerLimit_Handle = Selector.GetHandle("rangeWithLowerLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangeWithLowerLimit_UpperLimit_ = "rangeWithLowerLimit:upperLimit:";

	private static readonly IntPtr selRangeWithLowerLimit_UpperLimit_Handle = Selector.GetHandle("rangeWithLowerLimit:upperLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangeWithNoLimits = "rangeWithNoLimits";

	private static readonly IntPtr selRangeWithNoLimitsHandle = Selector.GetHandle("rangeWithNoLimits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangeWithUpperLimit_ = "rangeWithUpperLimit:";

	private static readonly IntPtr selRangeWithUpperLimit_Handle = Selector.GetHandle("rangeWithUpperLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangeWithValue_Variance_ = "rangeWithValue:variance:";

	private static readonly IntPtr selRangeWithValue_Variance_Handle = Selector.GetHandle("rangeWithValue:variance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLowerLimit_ = "setLowerLimit:";

	private static readonly IntPtr selSetLowerLimit_Handle = Selector.GetHandle("setLowerLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUpperLimit_ = "setUpperLimit:";

	private static readonly IntPtr selSetUpperLimit_Handle = Selector.GetHandle("setUpperLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpperLimit = "upperLimit";

	private static readonly IntPtr selUpperLimitHandle = Selector.GetHandle("upperLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKRange");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat LowerLimit
	{
		[Export("lowerLimit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selLowerLimitHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selLowerLimitHandle);
		}
		[Export("setLowerLimit:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetLowerLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetLowerLimit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat UpperLimit
	{
		[Export("upperLimit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selUpperLimitHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selUpperLimitHandle);
		}
		[Export("setUpperLimit:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetUpperLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetUpperLimit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKRange()
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
	public SKRange(NSCoder coder)
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
	protected SKRange(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKRange(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithLowerLimit:upperLimit:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKRange(nfloat lowerLimit, nfloat upperLimier)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nfloat_nfloat(base.Handle, selInitWithLowerLimit_UpperLimit_Handle, lowerLimit, upperLimier), "initWithLowerLimit:upperLimit:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nfloat_nfloat(base.SuperHandle, selInitWithLowerLimit_UpperLimit_Handle, lowerLimit, upperLimier), "initWithLowerLimit:upperLimit:");
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

	[Export("rangeWithLowerLimit:upperLimit:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKRange Create(nfloat lower, nfloat upper)
	{
		return Runtime.GetNSObject<SKRange>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat(class_ptr, selRangeWithLowerLimit_UpperLimit_Handle, lower, upper));
	}

	[Export("rangeWithConstantValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKRange CreateConstant(nfloat value)
	{
		return Runtime.GetNSObject<SKRange>(Messaging.IntPtr_objc_msgSend_nfloat(class_ptr, selRangeWithConstantValue_Handle, value));
	}

	[Export("rangeWithNoLimits")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKRange CreateUnlimited()
	{
		return Runtime.GetNSObject<SKRange>(Messaging.IntPtr_objc_msgSend(class_ptr, selRangeWithNoLimitsHandle));
	}

	[Export("rangeWithLowerLimit:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKRange CreateWithLowerLimit(nfloat lower)
	{
		return Runtime.GetNSObject<SKRange>(Messaging.IntPtr_objc_msgSend_nfloat(class_ptr, selRangeWithLowerLimit_Handle, lower));
	}

	[Export("rangeWithUpperLimit:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKRange CreateWithUpperLimit(nfloat upper)
	{
		return Runtime.GetNSObject<SKRange>(Messaging.IntPtr_objc_msgSend_nfloat(class_ptr, selRangeWithUpperLimit_Handle, upper));
	}

	[Export("rangeWithValue:variance:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKRange CreateWithVariance(nfloat value, nfloat variance)
	{
		return Runtime.GetNSObject<SKRange>(Messaging.IntPtr_objc_msgSend_nfloat_nfloat(class_ptr, selRangeWithValue_Variance_Handle, value, variance));
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
}

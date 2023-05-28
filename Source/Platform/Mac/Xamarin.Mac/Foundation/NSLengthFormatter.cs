using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSLengthFormatter", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NSLengthFormatter : NSFormatter
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetObjectValue_ForString_ErrorDescription_ = "getObjectValue:forString:errorDescription:";

	private static readonly IntPtr selGetObjectValue_ForString_ErrorDescription_Handle = Selector.GetHandle("getObjectValue:forString:errorDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsForPersonHeightUse = "isForPersonHeightUse";

	private static readonly IntPtr selIsForPersonHeightUseHandle = Selector.GetHandle("isForPersonHeightUse");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberFormatter = "numberFormatter";

	private static readonly IntPtr selNumberFormatterHandle = Selector.GetHandle("numberFormatter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetForPersonHeightUse_ = "setForPersonHeightUse:";

	private static readonly IntPtr selSetForPersonHeightUse_Handle = Selector.GetHandle("setForPersonHeightUse:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNumberFormatter_ = "setNumberFormatter:";

	private static readonly IntPtr selSetNumberFormatter_Handle = Selector.GetHandle("setNumberFormatter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUnitStyle_ = "setUnitStyle:";

	private static readonly IntPtr selSetUnitStyle_Handle = Selector.GetHandle("setUnitStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringFromMeters_ = "stringFromMeters:";

	private static readonly IntPtr selStringFromMeters_Handle = Selector.GetHandle("stringFromMeters:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringFromValue_Unit_ = "stringFromValue:unit:";

	private static readonly IntPtr selStringFromValue_Unit_Handle = Selector.GetHandle("stringFromValue:unit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnitStringFromMeters_UsedUnit_ = "unitStringFromMeters:usedUnit:";

	private static readonly IntPtr selUnitStringFromMeters_UsedUnit_Handle = Selector.GetHandle("unitStringFromMeters:usedUnit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnitStringFromValue_Unit_ = "unitStringFromValue:unit:";

	private static readonly IntPtr selUnitStringFromValue_Unit_Handle = Selector.GetHandle("unitStringFromValue:unit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnitStyle = "unitStyle";

	private static readonly IntPtr selUnitStyleHandle = Selector.GetHandle("unitStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSLengthFormatter");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ForPersonHeightUse
	{
		[Export("isForPersonHeightUse")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsForPersonHeightUseHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsForPersonHeightUseHandle);
		}
		[Export("setForPersonHeightUse:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetForPersonHeightUse_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetForPersonHeightUse_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumberFormatter NumberFormatter
	{
		[Export("numberFormatter", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumberFormatter>(Messaging.IntPtr_objc_msgSend(base.Handle, selNumberFormatterHandle));
			}
			return Runtime.GetNSObject<NSNumberFormatter>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNumberFormatterHandle));
		}
		[Export("setNumberFormatter:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNumberFormatter_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNumberFormatter_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFormattingUnitStyle UnitStyle
	{
		[Export("unitStyle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSFormattingUnitStyle)Messaging.Int64_objc_msgSend(base.Handle, selUnitStyleHandle);
			}
			return (NSFormattingUnitStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selUnitStyleHandle);
		}
		[Export("setUnitStyle:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetUnitStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetUnitStyle_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSLengthFormatter()
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
	public NSLengthFormatter(NSCoder coder)
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
	protected NSLengthFormatter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSLengthFormatter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("getObjectValue:forString:errorDescription:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GetObjectValue(out NSObject obj, string str, out string error)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = IntPtr.Zero;
		IntPtr arg3 = NSString.CreateNative(str);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selGetObjectValue_ForString_ErrorDescription_Handle, ref arg, arg3, ref arg2) : Messaging.bool_objc_msgSend_ref_IntPtr_IntPtr_ref_IntPtr(base.Handle, selGetObjectValue_ForString_ErrorDescription_Handle, ref arg, arg3, ref arg2));
		NSString.ReleaseNative(arg3);
		obj = Runtime.GetNSObject<NSObject>(arg);
		error = NSString.FromHandle(arg2);
		return result;
	}

	[Export("stringFromMeters:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string StringFromMeters(double numberInMeters)
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_Double(base.Handle, selStringFromMeters_Handle, numberInMeters));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_Double(base.SuperHandle, selStringFromMeters_Handle, numberInMeters));
	}

	[Export("stringFromValue:unit:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string StringFromValue(double value, NSLengthFormatterUnit unit)
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_Double_Int64(base.Handle, selStringFromValue_Unit_Handle, value, (long)unit));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_Double_Int64(base.SuperHandle, selStringFromValue_Unit_Handle, value, (long)unit));
	}

	[Export("unitStringFromMeters:usedUnit:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string UnitStringFromMeters(double numberInMeters, ref NSLengthFormatterUnit unitp)
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_Double_ref_NSLengthFormatterUnit(base.Handle, selUnitStringFromMeters_UsedUnit_Handle, numberInMeters, ref unitp));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_Double_ref_NSLengthFormatterUnit(base.SuperHandle, selUnitStringFromMeters_UsedUnit_Handle, numberInMeters, ref unitp));
	}

	[Export("unitStringFromValue:unit:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string UnitStringFromValue(double value, NSLengthFormatterUnit unit)
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_Double_Int64(base.Handle, selUnitStringFromValue_Unit_Handle, value, (long)unit));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_Double_Int64(base.SuperHandle, selUnitStringFromValue_Unit_Handle, value, (long)unit));
	}
}

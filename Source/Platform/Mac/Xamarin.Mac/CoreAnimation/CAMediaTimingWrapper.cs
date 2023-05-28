using System;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

internal sealed class CAMediaTimingWrapper : BaseWrapper, ICAMediaTiming, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public double BeginTime
	{
		[Export("beginTime")]
		get
		{
			return Messaging.Double_objc_msgSend(base.Handle, Selector.GetHandle("beginTime"));
		}
		[Export("setBeginTime:")]
		set
		{
			Messaging.void_objc_msgSend_Double(base.Handle, Selector.GetHandle("setBeginTime:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public double Duration
	{
		[Export("duration")]
		get
		{
			return Messaging.Double_objc_msgSend(base.Handle, Selector.GetHandle("duration"));
		}
		[Export("setDuration:")]
		set
		{
			Messaging.void_objc_msgSend_Double(base.Handle, Selector.GetHandle("setDuration:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float Speed
	{
		[Export("speed")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("speed"));
		}
		[Export("setSpeed:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setSpeed:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public double TimeOffset
	{
		[Export("timeOffset")]
		get
		{
			return Messaging.Double_objc_msgSend(base.Handle, Selector.GetHandle("timeOffset"));
		}
		[Export("setTimeOffset:")]
		set
		{
			Messaging.void_objc_msgSend_Double(base.Handle, Selector.GetHandle("setTimeOffset:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public float RepeatCount
	{
		[Export("repeatCount")]
		get
		{
			return Messaging.float_objc_msgSend(base.Handle, Selector.GetHandle("repeatCount"));
		}
		[Export("setRepeatCount:")]
		set
		{
			Messaging.void_objc_msgSend_float(base.Handle, Selector.GetHandle("setRepeatCount:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public double RepeatDuration
	{
		[Export("repeatDuration")]
		get
		{
			return Messaging.Double_objc_msgSend(base.Handle, Selector.GetHandle("repeatDuration"));
		}
		[Export("setRepeatDuration:")]
		set
		{
			Messaging.void_objc_msgSend_Double(base.Handle, Selector.GetHandle("setRepeatDuration:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool AutoReverses
	{
		[Export("autoreverses")]
		get
		{
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("autoreverses"));
		}
		[Export("setAutoreverses:")]
		set
		{
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setAutoreverses:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string FillMode
	{
		[Export("fillMode", ArgumentSemantic.Copy)]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("fillMode")));
		}
		[Export("setFillMode:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setFillMode:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[Preserve(Conditional = true)]
	public CAMediaTimingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Protocol]
[Register("CAMediaTiming", false)]
[Model]
public abstract class CAMediaTiming : NSObject, ICAMediaTiming, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract bool AutoReverses
	{
		[Export("autoreverses")]
		get;
		[Export("setAutoreverses:")]
		set;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract double BeginTime
	{
		[Export("beginTime")]
		get;
		[Export("setBeginTime:")]
		set;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract double Duration
	{
		[Export("duration")]
		get;
		[Export("setDuration:")]
		set;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract string FillMode
	{
		[Export("fillMode", ArgumentSemantic.Copy)]
		get;
		[Export("setFillMode:", ArgumentSemantic.Copy)]
		set;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract float RepeatCount
	{
		[Export("repeatCount")]
		get;
		[Export("setRepeatCount:")]
		set;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract double RepeatDuration
	{
		[Export("repeatDuration")]
		get;
		[Export("setRepeatDuration:")]
		set;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract float Speed
	{
		[Export("speed")]
		get;
		[Export("setSpeed:")]
		set;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract double TimeOffset
	{
		[Export("timeOffset")]
		get;
		[Export("setTimeOffset:")]
		set;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected CAMediaTiming()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CAMediaTiming(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CAMediaTiming(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}
}

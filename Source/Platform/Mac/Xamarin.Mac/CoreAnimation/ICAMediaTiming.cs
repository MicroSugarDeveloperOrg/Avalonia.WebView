using System;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Protocol(Name = "CAMediaTiming", WrapperType = typeof(CAMediaTimingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "BeginTime", Selector = "beginTime", PropertyType = typeof(double), GetterSelector = "beginTime", SetterSelector = "setBeginTime:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Duration", Selector = "duration", PropertyType = typeof(double), GetterSelector = "duration", SetterSelector = "setDuration:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Speed", Selector = "speed", PropertyType = typeof(float), GetterSelector = "speed", SetterSelector = "setSpeed:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "TimeOffset", Selector = "timeOffset", PropertyType = typeof(double), GetterSelector = "timeOffset", SetterSelector = "setTimeOffset:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "RepeatCount", Selector = "repeatCount", PropertyType = typeof(float), GetterSelector = "repeatCount", SetterSelector = "setRepeatCount:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "RepeatDuration", Selector = "repeatDuration", PropertyType = typeof(double), GetterSelector = "repeatDuration", SetterSelector = "setRepeatDuration:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "AutoReverses", Selector = "autoreverses", PropertyType = typeof(bool), GetterSelector = "autoreverses", SetterSelector = "setAutoreverses:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "FillMode", Selector = "fillMode", PropertyType = typeof(string), GetterSelector = "fillMode", SetterSelector = "setFillMode:", ArgumentSemantic = ArgumentSemantic.Copy)]
public interface ICAMediaTiming : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	double BeginTime
	{
		[Export("beginTime")]
		get;
		[Export("setBeginTime:")]
		set;
	}

	[Preserve(Conditional = true)]
	double Duration
	{
		[Export("duration")]
		get;
		[Export("setDuration:")]
		set;
	}

	[Preserve(Conditional = true)]
	float Speed
	{
		[Export("speed")]
		get;
		[Export("setSpeed:")]
		set;
	}

	[Preserve(Conditional = true)]
	double TimeOffset
	{
		[Export("timeOffset")]
		get;
		[Export("setTimeOffset:")]
		set;
	}

	[Preserve(Conditional = true)]
	float RepeatCount
	{
		[Export("repeatCount")]
		get;
		[Export("setRepeatCount:")]
		set;
	}

	[Preserve(Conditional = true)]
	double RepeatDuration
	{
		[Export("repeatDuration")]
		get;
		[Export("setRepeatDuration:")]
		set;
	}

	[Preserve(Conditional = true)]
	bool AutoReverses
	{
		[Export("autoreverses")]
		get;
		[Export("setAutoreverses:")]
		set;
	}

	[Preserve(Conditional = true)]
	string FillMode
	{
		[Export("fillMode", ArgumentSemantic.Copy)]
		get;
		[Export("setFillMode:", ArgumentSemantic.Copy)]
		set;
	}
}

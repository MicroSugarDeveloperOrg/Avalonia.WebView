using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreML;

[Register("MLUpdateContext", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MLUpdateContext : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEvent = "event";

	private static readonly IntPtr selEventHandle = Selector.GetHandle("event");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetrics = "metrics";

	private static readonly IntPtr selMetricsHandle = Selector.GetHandle("metrics");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModel = "model";

	private static readonly IntPtr selModelHandle = Selector.GetHandle("model");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParameters = "parameters";

	private static readonly IntPtr selParametersHandle = Selector.GetHandle("parameters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTask = "task";

	private static readonly IntPtr selTaskHandle = Selector.GetHandle("task");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MLUpdateContext");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MLUpdateProgressEvent Event
	{
		[Export("event")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MLUpdateProgressEvent)Messaging.UInt64_objc_msgSend(base.Handle, selEventHandle);
			}
			return (MLUpdateProgressEvent)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selEventHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<MLMetricKey, NSObject> Metrics
	{
		[Export("metrics")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<MLMetricKey, NSObject>>(Messaging.IntPtr_objc_msgSend(base.Handle, selMetricsHandle));
			}
			return Runtime.GetNSObject<NSDictionary<MLMetricKey, NSObject>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMetricsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMLWritable Model
	{
		[Export("model")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMLWritable>(Messaging.IntPtr_objc_msgSend(base.Handle, selModelHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMLWritable>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selModelHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<MLParameterKey, NSObject> Parameters
	{
		[Export("parameters")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<MLParameterKey, NSObject>>(Messaging.IntPtr_objc_msgSend(base.Handle, selParametersHandle));
			}
			return Runtime.GetNSObject<NSDictionary<MLParameterKey, NSObject>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParametersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MLUpdateTask Task
	{
		[Export("task")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MLUpdateTask>(Messaging.IntPtr_objc_msgSend(base.Handle, selTaskHandle));
			}
			return Runtime.GetNSObject<MLUpdateTask>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTaskHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MLUpdateContext(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MLUpdateContext(IntPtr handle)
		: base(handle)
	{
	}
}

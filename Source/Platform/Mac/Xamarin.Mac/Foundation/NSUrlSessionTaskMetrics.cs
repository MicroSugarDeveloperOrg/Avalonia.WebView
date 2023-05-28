using System.ComponentModel;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSURLSessionTaskMetrics", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class NSUrlSessionTaskMetrics : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRedirectCount = "redirectCount";

	private static readonly IntPtr selRedirectCountHandle = Selector.GetHandle("redirectCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTaskInterval = "taskInterval";

	private static readonly IntPtr selTaskIntervalHandle = Selector.GetHandle("taskInterval");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransactionMetrics = "transactionMetrics";

	private static readonly IntPtr selTransactionMetricsHandle = Selector.GetHandle("transactionMetrics");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSURLSessionTaskMetrics");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint RedirectCount
	{
		[Export("redirectCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selRedirectCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selRedirectCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDateInterval TaskInterval
	{
		[Export("taskInterval", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDateInterval>(Messaging.IntPtr_objc_msgSend(base.Handle, selTaskIntervalHandle));
			}
			return Runtime.GetNSObject<NSDateInterval>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTaskIntervalHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlSessionTaskTransactionMetrics[] TransactionMetrics
	{
		[Export("transactionMetrics", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSUrlSessionTaskTransactionMetrics>(Messaging.IntPtr_objc_msgSend(base.Handle, selTransactionMetricsHandle));
			}
			return NSArray.ArrayFromHandle<NSUrlSessionTaskTransactionMetrics>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTransactionMetricsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSUrlSessionTaskMetrics(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUrlSessionTaskMetrics(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "This type is not meant to be user created.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "This type is not meant to be user created.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "This type is not meant to be user created.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "This type is not meant to be user created.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUrlSessionTaskMetrics()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInitHandle), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitHandle), "init");
		}
	}
}

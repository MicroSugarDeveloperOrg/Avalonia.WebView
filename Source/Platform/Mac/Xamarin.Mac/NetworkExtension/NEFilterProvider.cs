using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NEFilterProvider", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
public abstract class NEFilterProvider : NEProvider
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilterConfiguration = "filterConfiguration";

	private static readonly IntPtr selFilterConfigurationHandle = Selector.GetHandle("filterConfiguration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHandleReport_ = "handleReport:";

	private static readonly IntPtr selHandleReport_Handle = Selector.GetHandle("handleReport:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartFilterWithCompletionHandler_ = "startFilterWithCompletionHandler:";

	private static readonly IntPtr selStartFilterWithCompletionHandler_Handle = Selector.GetHandle("startFilterWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopFilterWithReason_CompletionHandler_ = "stopFilterWithReason:completionHandler:";

	private static readonly IntPtr selStopFilterWithReason_CompletionHandler_Handle = Selector.GetHandle("stopFilterWithReason:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NEFilterProvider");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RemediationMapRemediationButtonTexts;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RemediationMapRemediationUrls;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEFilterProviderConfiguration FilterConfiguration
	{
		[Export("filterConfiguration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NEFilterProviderConfiguration>(Messaging.IntPtr_objc_msgSend(base.Handle, selFilterConfigurationHandle));
			}
			return Runtime.GetNSObject<NEFilterProviderConfiguration>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFilterConfigurationHandle));
		}
	}

	[Field("NEFilterProviderRemediationMapRemediationButtonTexts", "NetworkExtension")]
	public static NSString RemediationMapRemediationButtonTexts
	{
		get
		{
			if (_RemediationMapRemediationButtonTexts == null)
			{
				_RemediationMapRemediationButtonTexts = Dlfcn.GetStringConstant(Libraries.NetworkExtension.Handle, "NEFilterProviderRemediationMapRemediationButtonTexts");
			}
			return _RemediationMapRemediationButtonTexts;
		}
	}

	[Field("NEFilterProviderRemediationMapRemediationURLs", "NetworkExtension")]
	public static NSString RemediationMapRemediationUrls
	{
		get
		{
			if (_RemediationMapRemediationUrls == null)
			{
				_RemediationMapRemediationUrls = Dlfcn.GetStringConstant(Libraries.NetworkExtension.Handle, "NEFilterProviderRemediationMapRemediationURLs");
			}
			return _RemediationMapRemediationUrls;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected NEFilterProvider()
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
	protected NEFilterProvider(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NEFilterProvider(IntPtr handle)
		: base(handle)
	{
	}

	[Export("handleReport:")]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void HandleReport(NEFilterReport report)
	{
		if (report == null)
		{
			throw new ArgumentNullException("report");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selHandleReport_Handle, report.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selHandleReport_Handle, report.Handle);
		}
	}

	[Export("startFilterWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void StartFilter([BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selStartFilterWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selStartFilterWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task StartFilterAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		StartFilter(delegate(NSError obj_)
		{
			if (obj_ != null)
			{
				tcs.SetException(new NSErrorException(obj_));
			}
			else
			{
				tcs.SetResult(result: true);
			}
		});
		return tcs.Task;
	}

	[Export("stopFilterWithReason:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void StopFilter(NEProviderStopReason reason, [BlockProxy(typeof(Trampolines.NIDAction))] Action completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_IntPtr(base.Handle, selStopFilterWithReason_CompletionHandler_Handle, (long)reason, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr(base.SuperHandle, selStopFilterWithReason_CompletionHandler_Handle, (long)reason, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task StopFilterAsync(NEProviderStopReason reason)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		StopFilter(reason, delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}
}

using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace LinkPresentation;

[Register("LPMetadataProvider", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class LPMetadataProvider : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancel = "cancel";

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShouldFetchSubresources_ = "setShouldFetchSubresources:";

	private static readonly IntPtr selSetShouldFetchSubresources_Handle = Selector.GetHandle("setShouldFetchSubresources:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeout_ = "setTimeout:";

	private static readonly IntPtr selSetTimeout_Handle = Selector.GetHandle("setTimeout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldFetchSubresources = "shouldFetchSubresources";

	private static readonly IntPtr selShouldFetchSubresourcesHandle = Selector.GetHandle("shouldFetchSubresources");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartFetchingMetadataForURL_CompletionHandler_ = "startFetchingMetadataForURL:completionHandler:";

	private static readonly IntPtr selStartFetchingMetadataForURL_CompletionHandler_Handle = Selector.GetHandle("startFetchingMetadataForURL:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeout = "timeout";

	private static readonly IntPtr selTimeoutHandle = Selector.GetHandle("timeout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("LPMetadataProvider");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldFetchSubresources
	{
		[Export("shouldFetchSubresources")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShouldFetchSubresourcesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldFetchSubresourcesHandle);
		}
		[Export("setShouldFetchSubresources:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShouldFetchSubresources_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShouldFetchSubresources_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Timeout
	{
		[Export("timeout")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTimeoutHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimeoutHandle);
		}
		[Export("setTimeout:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetTimeout_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetTimeout_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public LPMetadataProvider()
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
	protected LPMetadataProvider(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal LPMetadataProvider(IntPtr handle)
		: base(handle)
	{
	}

	[Export("cancel")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Cancel()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelHandle);
		}
	}

	[Export("startFetchingMetadataForURL:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void StartFetchingMetadata(NSUrl url, [BlockProxy(typeof(Trampolines.NIDActionArity2V66))] Action<LPLinkMetadata, NSError> completionHandler)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V66.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selStartFetchingMetadataForURL_CompletionHandler_Handle, url.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selStartFetchingMetadataForURL_CompletionHandler_Handle, url.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<LPLinkMetadata> StartFetchingMetadataAsync(NSUrl url)
	{
		TaskCompletionSource<LPLinkMetadata> tcs = new TaskCompletionSource<LPLinkMetadata>();
		StartFetchingMetadata(url, delegate(LPLinkMetadata arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}
}

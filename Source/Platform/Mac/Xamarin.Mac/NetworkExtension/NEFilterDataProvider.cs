using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace NetworkExtension;

[Register("NEFilterDataProvider", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NEFilterDataProvider : NEFilterProvider
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplySettings_CompletionHandler_ = "applySettings:completionHandler:";

	private static readonly IntPtr selApplySettings_CompletionHandler_Handle = Selector.GetHandle("applySettings:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHandleInboundDataCompleteForFlow_ = "handleInboundDataCompleteForFlow:";

	private static readonly IntPtr selHandleInboundDataCompleteForFlow_Handle = Selector.GetHandle("handleInboundDataCompleteForFlow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHandleInboundDataFromFlow_ReadBytesStartOffset_ReadBytes_ = "handleInboundDataFromFlow:readBytesStartOffset:readBytes:";

	private static readonly IntPtr selHandleInboundDataFromFlow_ReadBytesStartOffset_ReadBytes_Handle = Selector.GetHandle("handleInboundDataFromFlow:readBytesStartOffset:readBytes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHandleNewFlow_ = "handleNewFlow:";

	private static readonly IntPtr selHandleNewFlow_Handle = Selector.GetHandle("handleNewFlow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHandleOutboundDataCompleteForFlow_ = "handleOutboundDataCompleteForFlow:";

	private static readonly IntPtr selHandleOutboundDataCompleteForFlow_Handle = Selector.GetHandle("handleOutboundDataCompleteForFlow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHandleOutboundDataFromFlow_ReadBytesStartOffset_ReadBytes_ = "handleOutboundDataFromFlow:readBytesStartOffset:readBytes:";

	private static readonly IntPtr selHandleOutboundDataFromFlow_ReadBytesStartOffset_ReadBytes_Handle = Selector.GetHandle("handleOutboundDataFromFlow:readBytesStartOffset:readBytes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResumeFlow_WithVerdict_ = "resumeFlow:withVerdict:";

	private static readonly IntPtr selResumeFlow_WithVerdict_Handle = Selector.GetHandle("resumeFlow:withVerdict:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateFlow_UsingVerdict_ForDirection_ = "updateFlow:usingVerdict:forDirection:";

	private static readonly IntPtr selUpdateFlow_UsingVerdict_ForDirection_Handle = Selector.GetHandle("updateFlow:usingVerdict:forDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NEFilterDataProvider");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NEFilterDataProvider(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NEFilterDataProvider(IntPtr handle)
		: base(handle)
	{
	}

	[Export("applySettings:completionHandler:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ApplySettings(NEFilterSettings? settings, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
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
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selApplySettings_CompletionHandler_Handle, settings?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selApplySettings_CompletionHandler_Handle, settings?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task ApplySettingsAsync(NEFilterSettings? settings)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		ApplySettings(settings, delegate(NSError obj_)
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

	[Export("handleInboundDataCompleteForFlow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEFilterDataVerdict HandleInboundDataCompleteForFlow(NEFilterFlow flow)
	{
		if (flow == null)
		{
			throw new ArgumentNullException("flow");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NEFilterDataVerdict>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selHandleInboundDataCompleteForFlow_Handle, flow.Handle));
		}
		return Runtime.GetNSObject<NEFilterDataVerdict>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selHandleInboundDataCompleteForFlow_Handle, flow.Handle));
	}

	[Export("handleInboundDataFromFlow:readBytesStartOffset:readBytes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEFilterDataVerdict HandleInboundDataFromFlow(NEFilterFlow flow, nuint offset, NSData readBytes)
	{
		if (flow == null)
		{
			throw new ArgumentNullException("flow");
		}
		if (readBytes == null)
		{
			throw new ArgumentNullException("readBytes");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NEFilterDataVerdict>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_IntPtr(base.Handle, selHandleInboundDataFromFlow_ReadBytesStartOffset_ReadBytes_Handle, flow.Handle, offset, readBytes.Handle));
		}
		return Runtime.GetNSObject<NEFilterDataVerdict>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_IntPtr(base.SuperHandle, selHandleInboundDataFromFlow_ReadBytesStartOffset_ReadBytes_Handle, flow.Handle, offset, readBytes.Handle));
	}

	[Export("handleNewFlow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEFilterNewFlowVerdict HandleNewFlow(NEFilterFlow flow)
	{
		if (flow == null)
		{
			throw new ArgumentNullException("flow");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NEFilterNewFlowVerdict>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selHandleNewFlow_Handle, flow.Handle));
		}
		return Runtime.GetNSObject<NEFilterNewFlowVerdict>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selHandleNewFlow_Handle, flow.Handle));
	}

	[Export("handleOutboundDataCompleteForFlow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEFilterDataVerdict HandleOutboundDataCompleteForFlow(NEFilterFlow flow)
	{
		if (flow == null)
		{
			throw new ArgumentNullException("flow");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NEFilterDataVerdict>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selHandleOutboundDataCompleteForFlow_Handle, flow.Handle));
		}
		return Runtime.GetNSObject<NEFilterDataVerdict>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selHandleOutboundDataCompleteForFlow_Handle, flow.Handle));
	}

	[Export("handleOutboundDataFromFlow:readBytesStartOffset:readBytes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEFilterDataVerdict HandleOutboundDataFromFlow(NEFilterFlow flow, nuint offset, NSData readBytes)
	{
		if (flow == null)
		{
			throw new ArgumentNullException("flow");
		}
		if (readBytes == null)
		{
			throw new ArgumentNullException("readBytes");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NEFilterDataVerdict>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_IntPtr(base.Handle, selHandleOutboundDataFromFlow_ReadBytesStartOffset_ReadBytes_Handle, flow.Handle, offset, readBytes.Handle));
		}
		return Runtime.GetNSObject<NEFilterDataVerdict>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_IntPtr(base.SuperHandle, selHandleOutboundDataFromFlow_ReadBytesStartOffset_ReadBytes_Handle, flow.Handle, offset, readBytes.Handle));
	}

	[Export("resumeFlow:withVerdict:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResumeFlow(NEFilterFlow flow, NEFilterVerdict verdict)
	{
		if (flow == null)
		{
			throw new ArgumentNullException("flow");
		}
		if (verdict == null)
		{
			throw new ArgumentNullException("verdict");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selResumeFlow_WithVerdict_Handle, flow.Handle, verdict.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selResumeFlow_WithVerdict_Handle, flow.Handle, verdict.Handle);
		}
	}

	[Export("updateFlow:usingVerdict:forDirection:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateFlow(NEFilterSocketFlow flow, NEFilterDataVerdict verdict, NETrafficDirection direction)
	{
		if (flow == null)
		{
			throw new ArgumentNullException("flow");
		}
		if (verdict == null)
		{
			throw new ArgumentNullException("verdict");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_Int64(base.Handle, selUpdateFlow_UsingVerdict_ForDirection_Handle, flow.Handle, verdict.Handle, (long)direction);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_Int64(base.SuperHandle, selUpdateFlow_UsingVerdict_ForDirection_Handle, flow.Handle, verdict.Handle, (long)direction);
		}
	}
}

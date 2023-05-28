using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAudioSinkNode", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class AVAudioSinkNode : AVAudioNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithReceiverBlock_ = "initWithReceiverBlock:";

	private static readonly IntPtr selInitWithReceiverBlock_Handle = Selector.GetHandle("initWithReceiverBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioSinkNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAudioSinkNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioSinkNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithReceiverBlock:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe AVAudioSinkNode([BlockProxy(typeof(Trampolines.NIDAVAudioSinkNodeReceiverHandler))] AVAudioSinkNodeReceiverHandler receiverHandler)
		: base(NSObjectFlag.Empty)
	{
		if (receiverHandler == null)
		{
			throw new ArgumentNullException("receiverHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAVAudioSinkNodeReceiverHandler.Handler, receiverHandler);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithReceiverBlock_Handle, (IntPtr)ptr), "initWithReceiverBlock:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithReceiverBlock_Handle, (IntPtr)ptr), "initWithReceiverBlock:");
		}
		ptr->CleanupBlock();
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NEFilterPacketProvider", true)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NEFilterPacketProvider : NEFilterProvider
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowPacket_ = "allowPacket:";

	private static readonly IntPtr selAllowPacket_Handle = Selector.GetHandle("allowPacket:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelayCurrentPacket_ = "delayCurrentPacket:";

	private static readonly IntPtr selDelayCurrentPacket_Handle = Selector.GetHandle("delayCurrentPacket:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPacketHandler = "packetHandler";

	private static readonly IntPtr selPacketHandlerHandle = Selector.GetHandle("packetHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPacketHandler_ = "setPacketHandler:";

	private static readonly IntPtr selSetPacketHandler_Handle = Selector.GetHandle("setPacketHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NEFilterPacketProvider");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NEFilterPacketHandler? PacketHandler
	{
		[Export("packetHandler", ArgumentSemantic.Retain)]
		[return: DelegateProxy(typeof(Trampolines.SDNEFilterPacketHandler))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPacketHandlerHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selPacketHandlerHandle));
			return Trampolines.NIDNEFilterPacketHandler.Create(block);
		}
		[Export("setPacketHandler:", ArgumentSemantic.Retain)]
		[param: BlockProxy(typeof(Trampolines.NIDNEFilterPacketHandler))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDNEFilterPacketHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPacketHandler_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPacketHandler_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NEFilterPacketProvider(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NEFilterPacketProvider(IntPtr handle)
		: base(handle)
	{
	}

	[Export("allowPacket:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AllowPacket(NEPacket packet)
	{
		if (packet == null)
		{
			throw new ArgumentNullException("packet");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAllowPacket_Handle, packet.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAllowPacket_Handle, packet.Handle);
		}
	}

	[Export("delayCurrentPacket:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEPacket DelayCurrentPacket(NEFilterPacketContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NEPacket>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDelayCurrentPacket_Handle, context.Handle));
		}
		return Runtime.GetNSObject<NEPacket>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDelayCurrentPacket_Handle, context.Handle));
	}
}

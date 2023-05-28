using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

internal sealed class MTLSharedEventWrapper : BaseWrapper, IMTLSharedEvent, INativeObject, IDisposable, IMTLEvent
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public ulong SignaledValue
	{
		[Export("signaledValue")]
		get
		{
			return Messaging.UInt64_objc_msgSend(base.Handle, Selector.GetHandle("signaledValue"));
		}
		[Export("setSignaledValue:")]
		set
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, Selector.GetHandle("setSignaledValue:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	public IMTLDevice? Device
	{
		[Export("device")]
		get
		{
			return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("device")), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	public string? Label
	{
		[Export("label")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("label")));
		}
		[Export("setLabel:")]
		set
		{
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setLabel:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[Preserve(Conditional = true)]
	public MTLSharedEventWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("notifyListener:atValue:block:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void NotifyListener(MTLSharedEventListener listener, ulong atValue, [BlockProxy(typeof(Trampolines.NIDMTLSharedEventNotificationBlock))] MTLSharedEventNotificationBlock block)
	{
		if (listener == null)
		{
			throw new ArgumentNullException("listener");
		}
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMTLSharedEventNotificationBlock.Handler, block);
		Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr(base.Handle, Selector.GetHandle("notifyListener:atValue:block:"), listener.Handle, atValue, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Export("newSharedEventHandle")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public MTLSharedEventHandle CreateSharedEventHandle()
	{
		MTLSharedEventHandle nSObject = Runtime.GetNSObject<MTLSharedEventHandle>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("newSharedEventHandle")));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}
}

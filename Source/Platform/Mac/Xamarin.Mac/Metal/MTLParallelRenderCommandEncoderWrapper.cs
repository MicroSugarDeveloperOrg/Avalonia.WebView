using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

internal sealed class MTLParallelRenderCommandEncoderWrapper : BaseWrapper, IMTLParallelRenderCommandEncoder, INativeObject, IDisposable, IMTLCommandEncoder
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public IMTLDevice Device
	{
		[Export("device")]
		get
		{
			return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("device")), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public string Label
	{
		[Export("label")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("label")));
		}
		[Export("setLabel:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setLabel:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[Preserve(Conditional = true)]
	public MTLParallelRenderCommandEncoderWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("renderCommandEncoder")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMTLRenderCommandEncoder? CreateRenderCommandEncoder()
	{
		using (new NSAutoreleasePool())
		{
			return Runtime.GetINativeObject<IMTLRenderCommandEncoder>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("renderCommandEncoder")), owns: false);
		}
	}

	[Export("endEncoding")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void EndEncoding()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("endEncoding"));
	}

	[Export("insertDebugSignpost:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void InsertDebugSignpost(string signpost)
	{
		if (signpost == null)
		{
			throw new ArgumentNullException("signpost");
		}
		IntPtr intPtr = NSString.CreateNative(signpost);
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("insertDebugSignpost:"), intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[Export("pushDebugGroup:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void PushDebugGroup(string debugGroup)
	{
		if (debugGroup == null)
		{
			throw new ArgumentNullException("debugGroup");
		}
		IntPtr intPtr = NSString.CreateNative(debugGroup);
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("pushDebugGroup:"), intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[Export("popDebugGroup")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void PopDebugGroup()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("popDebugGroup"));
	}
}

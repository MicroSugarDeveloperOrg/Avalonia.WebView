using System;
using Foundation;
using ObjCRuntime;

namespace PushKit;

internal sealed class PKPushRegistryDelegateWrapper : BaseWrapper, IPKPushRegistryDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public PKPushRegistryDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("pushRegistry:didUpdatePushCredentials:forType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidUpdatePushCredentials(PKPushRegistry registry, PKPushCredentials credentials, string type)
	{
		if (registry == null)
		{
			throw new ArgumentNullException("registry");
		}
		if (credentials == null)
		{
			throw new ArgumentNullException("credentials");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr intPtr = NSString.CreateNative(type);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("pushRegistry:didUpdatePushCredentials:forType:"), registry.Handle, credentials.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
	}
}

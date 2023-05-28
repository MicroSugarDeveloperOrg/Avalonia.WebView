using System;
using Foundation;
using ObjCRuntime;

namespace ScriptingBridge;

internal sealed class SBApplicationDelegateWrapper : BaseWrapper, ISBApplicationDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SBApplicationDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("eventDidFail:withError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSObject EventDidFailwithError(IntPtr appleEvent, NSError error)
	{
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("eventDidFail:withError:"), appleEvent, error.Handle));
	}
}

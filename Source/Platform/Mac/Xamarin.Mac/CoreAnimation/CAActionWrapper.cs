using System;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

internal sealed class CAActionWrapper : BaseWrapper, ICAAction, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public CAActionWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("runActionForKey:object:arguments:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void RunAction(string eventKey, NSObject obj, NSDictionary? arguments)
	{
		if (eventKey == null)
		{
			throw new ArgumentNullException("eventKey");
		}
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		IntPtr intPtr = NSString.CreateNative(eventKey);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("runActionForKey:object:arguments:"), intPtr, obj.Handle, arguments?.Handle ?? IntPtr.Zero);
		NSString.ReleaseNative(intPtr);
	}
}

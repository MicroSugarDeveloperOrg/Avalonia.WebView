using System;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

internal sealed class MDLNamedWrapper : BaseWrapper, IMDLNamed, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string Name
	{
		[Export("name")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("name")));
		}
		[Export("setName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setName:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[Preserve(Conditional = true)]
	public MDLNamedWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

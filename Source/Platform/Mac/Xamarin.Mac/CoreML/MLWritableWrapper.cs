using System;
using Foundation;
using ObjCRuntime;

namespace CoreML;

internal sealed class MLWritableWrapper : BaseWrapper, IMLWritable, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public MLWritableWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("writeToURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool Write(NSUrl url, out NSError? error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, Selector.GetHandle("writeToURL:error:"), url.Handle, ref arg);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}
}

using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace SceneKit;

internal sealed class SCNBufferStreamWrapper : BaseWrapper, ISCNBufferStream, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SCNBufferStreamWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("writeBytes:length:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Length(IntPtr bytes, nuint length)
	{
		Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, Selector.GetHandle("writeBytes:length:"), bytes, length);
	}
}

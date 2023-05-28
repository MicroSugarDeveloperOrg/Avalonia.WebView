using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

internal sealed class CIFilterConstructorWrapper : BaseWrapper, ICIFilterConstructor, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public CIFilterConstructorWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("filterWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIFilter? FilterWithName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr intPtr = NSString.CreateNative(name);
		CIFilter nSObject = Runtime.GetNSObject<CIFilter>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("filterWithName:"), intPtr));
		NSString.ReleaseNative(intPtr);
		return nSObject;
	}
}

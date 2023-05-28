using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSPasteboardReadingWrapper : BaseWrapper, INSPasteboardReading, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSPasteboardReadingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("xamarinselector:removed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSObject InitWithPasteboardPropertyList(NSObject propertyList, string type)
	{
		NSApplication.EnsureUIThread();
		if (propertyList == null)
		{
			throw new ArgumentNullException("propertyList");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr intPtr = NSString.CreateNative(type);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("xamarinselector:removed:"), propertyList.Handle, intPtr));
		NSString.ReleaseNative(intPtr);
		return nSObject;
	}
}

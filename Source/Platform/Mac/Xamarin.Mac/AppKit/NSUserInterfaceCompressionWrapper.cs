using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSUserInterfaceCompressionWrapper : BaseWrapper, INSUserInterfaceCompression, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUserInterfaceCompressionOptions ActiveCompressionOptions
	{
		[Export("activeCompressionOptions", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSUserInterfaceCompressionOptions>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("activeCompressionOptions")));
		}
	}

	[Preserve(Conditional = true)]
	public NSUserInterfaceCompressionWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("compressWithPrioritizedCompressionOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Compress(NSUserInterfaceCompressionOptions[] prioritizedOptions)
	{
		NSApplication.EnsureUIThread();
		if (prioritizedOptions == null)
		{
			throw new ArgumentNullException("prioritizedOptions");
		}
		NSArray nSArray = NSArray.FromNSObjects(prioritizedOptions);
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("compressWithPrioritizedCompressionOptions:"), nSArray.Handle);
		nSArray.Dispose();
	}

	[Export("minimumSizeWithPrioritizedCompressionOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGSize GetMinimumSize(NSUserInterfaceCompressionOptions[] prioritizedOptions)
	{
		NSApplication.EnsureUIThread();
		if (prioritizedOptions == null)
		{
			throw new ArgumentNullException("prioritizedOptions");
		}
		NSArray nSArray = NSArray.FromNSObjects(prioritizedOptions);
		CGSize result = Messaging.CGSize_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("minimumSizeWithPrioritizedCompressionOptions:"), nSArray.Handle);
		nSArray.Dispose();
		return result;
	}
}

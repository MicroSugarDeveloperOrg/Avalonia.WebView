using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

internal sealed class NSTextAttachmentContainerWrapper : BaseWrapper, INSTextAttachmentContainer, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSTextAttachmentContainerWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("imageForBounds:textContainer:characterIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSImage? GetImage(CGRect imageBounds, NSTextContainer? textContainer, nuint charIndex)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend_CGRect_IntPtr_nuint(base.Handle, Selector.GetHandle("imageForBounds:textContainer:characterIndex:"), imageBounds, textContainer?.Handle ?? IntPtr.Zero, charIndex));
	}

	[Export("attachmentBoundsForTextContainer:proposedLineFragment:glyphPosition:characterIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect GetAttachmentBounds(NSTextContainer? textContainer, CGRect lineFrag, CGPoint position, nuint charIndex)
	{
		NSApplication.EnsureUIThread();
		Messaging.CGRect_objc_msgSend_stret_IntPtr_CGRect_CGPoint_nuint(out var retval, base.Handle, Selector.GetHandle("attachmentBoundsForTextContainer:proposedLineFragment:glyphPosition:characterIndex:"), textContainer?.Handle ?? IntPtr.Zero, lineFrag, position, charIndex);
		return retval;
	}
}

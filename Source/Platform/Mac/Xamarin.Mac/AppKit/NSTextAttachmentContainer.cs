using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSTextAttachmentContainer", false)]
[Model]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public abstract class NSTextAttachmentContainer : NSObject, INSTextAttachmentContainer, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected NSTextAttachmentContainer()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSTextAttachmentContainer(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTextAttachmentContainer(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("attachmentBoundsForTextContainer:proposedLineFragment:glyphPosition:characterIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract CGRect GetAttachmentBounds(NSTextContainer? textContainer, CGRect lineFrag, CGPoint position, nuint charIndex);

	[Export("imageForBounds:textContainer:characterIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract NSImage? GetImage(CGRect imageBounds, NSTextContainer? textContainer, nuint charIndex);
}

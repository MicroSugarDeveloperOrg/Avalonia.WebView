using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol]
[Register("NSTextStorageDelegate", false)]
[Model]
public class NSTextStorageDelegate : NSObject, INSTextStorageDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextStorageDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSTextStorageDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTextStorageDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("textStorage:didProcessEditing:range:changeInLength:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidProcessEditing(NSTextStorage textStorage, NSTextStorageEditActions editedMask, NSRange editedRange, nint delta)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textStorageDidProcessEditing:")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "Use DidProcessEditing instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TextStorageDidProcessEditing(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textStorageWillProcessEditing:")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "Use WillProcessEditing instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TextStorageWillProcessEditing(NSNotification notification)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("textStorage:willProcessEditing:range:changeInLength:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillProcessEditing(NSTextStorage textStorage, NSTextStorageEditActions editedMask, NSRange editedRange, nint delta)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

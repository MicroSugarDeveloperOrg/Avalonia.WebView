using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QuickLookUI;

[Protocol]
[Register("QLPreviewItem", false)]
[Model]
public class QLPreviewItem : NSObject, IQLPreviewItem, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject PreviewItemDisplayState
	{
		[Export("previewItemDisplayState")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PreviewItemTitle
	{
		[Export("previewItemTitle")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl PreviewItemURL
	{
		[Export("previewItemURL")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QLPreviewItem()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected QLPreviewItem(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QLPreviewItem(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}
}

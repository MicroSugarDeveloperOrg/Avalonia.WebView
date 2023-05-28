using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Protocol]
[Register("IKSlideshowDataSource", false)]
[Model]
public abstract class IKSlideshowDataSource : NSObject, IIKSlideshowDataSource, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract nint ItemCount
	{
		[Export("numberOfSlideshowItems")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected IKSlideshowDataSource()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected IKSlideshowDataSource(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal IKSlideshowDataSource(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("canExportSlideshowItemAtIndex:toApplication:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanExportItemToApplication(nint index, string applicationBundleIdentifier)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("slideshowDidChangeCurrentIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChange(nint newIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("slideshowDidStop")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidStop()
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("slideshowItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract NSObject GetItemAt(nint index);

	[Export("nameOfSlideshowItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetNameOfItemAt(nint index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("slideshowWillStart")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillStart()
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

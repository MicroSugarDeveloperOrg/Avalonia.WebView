using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Protocol]
[Register("IKImageEditPanelDataSource", false)]
[Model]
public abstract class IKImageEditPanelDataSource : NSObject, IIKImageEditPanelDataSource, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasAdjustMode
	{
		[Export("hasAdjustMode")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasDetailsMode
	{
		[Export("hasDetailsMode")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasEffectsMode
	{
		[Export("hasEffectsMode")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract CGImage Image
	{
		[Export("image")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary ImageProperties
	{
		[Export("imageProperties")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected IKImageEditPanelDataSource()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected IKImageEditPanelDataSource(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal IKImageEditPanelDataSource(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("thumbnailWithMaximumSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGImage GetThumbnail(CGSize maximumSize)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("setImage:imageProperties:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void SetImageAndProperties(CGImage image, NSDictionary metaData);
}

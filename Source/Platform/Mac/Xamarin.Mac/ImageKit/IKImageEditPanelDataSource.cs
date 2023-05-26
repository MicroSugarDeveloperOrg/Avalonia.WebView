using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Register("IKImageEditPanelDataSource", true)]
[Model]
public abstract class IKImageEditPanelDataSource : NSObject
{
	public abstract CGImage Image
	{
		[Export("image")]
		get;
	}

	public virtual NSDictionary ImageProperties
	{
		[Export("imageProperties")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	public virtual bool HasAdjustMode
	{
		[Export("hasAdjustMode")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	public virtual bool HasEffectsMode
	{
		[Export("hasEffectsMode")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	public virtual bool HasDetailsMode
	{
		[Export("hasDetailsMode")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKImageEditPanelDataSource()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public IKImageEditPanelDataSource(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKImageEditPanelDataSource(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKImageEditPanelDataSource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setImage:imageProperties:")]
	public abstract void SetImageAndProperties(CGImage image, NSDictionary metaData);

	[Export("thumbnailWithMaximumSize:")]
	public virtual CGImage GetThumbnail(CGSize maximumSize)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

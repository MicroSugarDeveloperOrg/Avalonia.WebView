using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Register("IKSlideshowDataSource", true)]
[Model]
public abstract class IKSlideshowDataSource : NSObject
{
	public abstract int ItemCount
	{
		[Export("numberOfSlideshowItems")]
		get;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKSlideshowDataSource()
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
	public IKSlideshowDataSource(NSCoder coder)
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
	public IKSlideshowDataSource(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKSlideshowDataSource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("slideshowItemAtIndex:")]
	public abstract NSObject GetItemAt(int index);

	[Export("nameOfSlideshowItemAtIndex:")]
	public virtual string GetNameOfItemAt(int index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("canExportSlideshowItemAtIndex:toApplication:")]
	public virtual bool CanExportItemToApplication(int index, string applicationBundleIdentifier)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("slideshowWillStart")]
	public virtual void WillStart()
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("slideshowDidStop")]
	public virtual void DidStop()
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("slideshowDidChangeCurrentIndex:")]
	public virtual void DidChange(int newIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Register("IKImageBrowserDataSource", true)]
[Model]
public abstract class IKImageBrowserDataSource : NSObject
{
	private static NSString _GroupRangeKey;

	private static NSString _GroupBackgroundColorKey;

	private static NSString _GroupTitleKey;

	private static NSString _GroupStyleKey;

	private static NSString _GroupHeaderLayer;

	private static NSString _GroupFooterLayer;

	[Field("IKImageBrowserGroupRangeKey", "ImageKit")]
	public static NSString GroupRangeKey
	{
		get
		{
			if (_GroupRangeKey == null)
			{
				_GroupRangeKey = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserGroupRangeKey");
			}
			return _GroupRangeKey;
		}
	}

	[Field("IKImageBrowserGroupBackgroundColorKey", "ImageKit")]
	public static NSString GroupBackgroundColorKey
	{
		get
		{
			if (_GroupBackgroundColorKey == null)
			{
				_GroupBackgroundColorKey = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserGroupBackgroundColorKey");
			}
			return _GroupBackgroundColorKey;
		}
	}

	[Field("IKImageBrowserGroupTitleKey", "ImageKit")]
	public static NSString GroupTitleKey
	{
		get
		{
			if (_GroupTitleKey == null)
			{
				_GroupTitleKey = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserGroupTitleKey");
			}
			return _GroupTitleKey;
		}
	}

	[Field("IKImageBrowserGroupStyleKey", "ImageKit")]
	public static NSString GroupStyleKey
	{
		get
		{
			if (_GroupStyleKey == null)
			{
				_GroupStyleKey = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserGroupStyleKey");
			}
			return _GroupStyleKey;
		}
	}

	[Field("IKImageBrowserGroupHeaderLayer", "ImageKit")]
	public static NSString GroupHeaderLayer
	{
		get
		{
			if (_GroupHeaderLayer == null)
			{
				_GroupHeaderLayer = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserGroupHeaderLayer");
			}
			return _GroupHeaderLayer;
		}
	}

	[Field("IKImageBrowserGroupFooterLayer", "ImageKit")]
	public static NSString GroupFooterLayer
	{
		get
		{
			if (_GroupFooterLayer == null)
			{
				_GroupFooterLayer = Dlfcn.GetStringConstant(Libraries.ImageKit.Handle, "IKImageBrowserGroupFooterLayer");
			}
			return _GroupFooterLayer;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKImageBrowserDataSource()
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
	public IKImageBrowserDataSource(NSCoder coder)
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
	public IKImageBrowserDataSource(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKImageBrowserDataSource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("numberOfItemsInImageBrowser:")]
	public abstract int ItemCount(IKImageBrowserView aBrowser);

	[Export("imageBrowser:itemAtIndex:")]
	public abstract IKImageBrowserItem GetItem(IKImageBrowserView aBrowser, int index);

	[Export("imageBrowser:removeItemsAtIndexes:")]
	public virtual void RemoveItems(IKImageBrowserView aBrowser, NSIndexSet indexes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("imageBrowser:moveItemsAtIndexes:toIndex:")]
	public virtual bool MoveItems(IKImageBrowserView aBrowser, NSIndexSet indexes, int destinationIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("imageBrowser:writeItemsAtIndexes:toPasteboard:")]
	public virtual int WriteItemsToPasteboard(IKImageBrowserView aBrowser, NSIndexSet itemIndexes, NSPasteboard pasteboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("numberOfGroupsInImageBrowser:")]
	public virtual int GroupCount(IKImageBrowserView aBrowser)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("imageBrowser:groupAtIndex:")]
	public virtual NSDictionary GetGroup(IKImageBrowserView aBrowser, int index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

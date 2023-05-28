using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace ImageKit;

[Protocol(IsInformal = true)]
[Register("IKImageBrowserDataSource", false)]
[Model]
public abstract class IKImageBrowserDataSource : NSObject, IIKImageBrowserDataSource, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GroupBackgroundColorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GroupFooterLayer;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GroupHeaderLayer;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GroupRangeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GroupStyleKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GroupTitleKey;

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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected IKImageBrowserDataSource()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected IKImageBrowserDataSource(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal IKImageBrowserDataSource(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("imageBrowser:groupAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary GetGroup(IKImageBrowserView aBrowser, nint index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("imageBrowser:itemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract IIKImageBrowserItem GetItem(IKImageBrowserView aBrowser, nint index);

	[Export("numberOfGroupsInImageBrowser:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GroupCount(IKImageBrowserView aBrowser)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("numberOfItemsInImageBrowser:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract nint ItemCount(IKImageBrowserView aBrowser);

	[Export("imageBrowser:moveItemsAtIndexes:toIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool MoveItems(IKImageBrowserView aBrowser, NSIndexSet indexes, nint destinationIndex)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("imageBrowser:removeItemsAtIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveItems(IKImageBrowserView aBrowser, NSIndexSet indexes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("imageBrowser:writeItemsAtIndexes:toPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint WriteItemsToPasteboard(IKImageBrowserView aBrowser, NSIndexSet itemIndexes, NSPasteboard pasteboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

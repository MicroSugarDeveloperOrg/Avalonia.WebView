using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WKBackForwardList", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class WKBackForwardList : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackItem = "backItem";

	private static readonly IntPtr selBackItemHandle = Selector.GetHandle("backItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackList = "backList";

	private static readonly IntPtr selBackListHandle = Selector.GetHandle("backList");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentItem = "currentItem";

	private static readonly IntPtr selCurrentItemHandle = Selector.GetHandle("currentItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selForwardItem = "forwardItem";

	private static readonly IntPtr selForwardItemHandle = Selector.GetHandle("forwardItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selForwardList = "forwardList";

	private static readonly IntPtr selForwardListHandle = Selector.GetHandle("forwardList");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemAtIndex_ = "itemAtIndex:";

	private static readonly IntPtr selItemAtIndex_Handle = Selector.GetHandle("itemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WKBackForwardList");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKBackForwardListItem BackItem
	{
		[Export("backItem", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WKBackForwardListItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackItemHandle));
			}
			return Runtime.GetNSObject<WKBackForwardListItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackItemHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKBackForwardListItem[] BackList
	{
		[Export("backList")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<WKBackForwardListItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackListHandle));
			}
			return NSArray.ArrayFromHandle<WKBackForwardListItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackListHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKBackForwardListItem CurrentItem
	{
		[Export("currentItem", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WKBackForwardListItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentItemHandle));
			}
			return Runtime.GetNSObject<WKBackForwardListItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentItemHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKBackForwardListItem ForwardItem
	{
		[Export("forwardItem", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WKBackForwardListItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selForwardItemHandle));
			}
			return Runtime.GetNSObject<WKBackForwardListItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selForwardItemHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKBackForwardListItem[] ForwardList
	{
		[Export("forwardList")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<WKBackForwardListItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selForwardListHandle));
			}
			return NSArray.ArrayFromHandle<WKBackForwardListItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selForwardListHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected WKBackForwardList(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal WKBackForwardList(IntPtr handle)
		: base(handle)
	{
	}

	[Export("itemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKBackForwardListItem ItemAtIndex(nint index)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<WKBackForwardListItem>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selItemAtIndex_Handle, index));
		}
		return Runtime.GetNSObject<WKBackForwardListItem>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selItemAtIndex_Handle, index));
	}
}

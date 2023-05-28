using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMutableDateRangeMetadataGroup", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVMutableDateRangeMetadataGroup : AVDateRangeMetadataGroup
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndDate = "endDate";

	private static readonly IntPtr selEndDateHandle = Selector.GetHandle("endDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItems = "items";

	private static readonly IntPtr selItemsHandle = Selector.GetHandle("items");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEndDate_ = "setEndDate:";

	private static readonly IntPtr selSetEndDate_Handle = Selector.GetHandle("setEndDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetItems_ = "setItems:";

	private static readonly IntPtr selSetItems_Handle = Selector.GetHandle("setItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStartDate_ = "setStartDate:";

	private static readonly IntPtr selSetStartDate_Handle = Selector.GetHandle("setStartDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartDate = "startDate";

	private static readonly IntPtr selStartDateHandle = Selector.GetHandle("startDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVMutableDateRangeMetadataGroup");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override NSDate? EndDate
	{
		[Export("endDate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selEndDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEndDateHandle));
		}
		[Export("setEndDate:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEndDate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEndDate_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override AVMetadataItem[] Items
	{
		[Export("items", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selItemsHandle));
			}
			return NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemsHandle));
		}
		[Export("setItems:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetItems_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetItems_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override NSDate StartDate
	{
		[Export("startDate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selStartDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStartDateHandle));
		}
		[Export("setStartDate:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetStartDate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetStartDate_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVMutableDateRangeMetadataGroup()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVMutableDateRangeMetadataGroup(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVMutableDateRangeMetadataGroup(IntPtr handle)
		: base(handle)
	{
	}
}

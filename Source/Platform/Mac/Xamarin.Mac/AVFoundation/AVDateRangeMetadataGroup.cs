using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVDateRangeMetadataGroup", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class AVDateRangeMetadataGroup : AVMetadataGroup, INSCopying, INativeObject, IDisposable, INSMutableCopying
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndDate = "endDate";

	private static readonly IntPtr selEndDateHandle = Selector.GetHandle("endDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithItems_StartDate_EndDate_ = "initWithItems:startDate:endDate:";

	private static readonly IntPtr selInitWithItems_StartDate_EndDate_Handle = Selector.GetHandle("initWithItems:startDate:endDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItems = "items";

	private static readonly IntPtr selItemsHandle = Selector.GetHandle("items");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMutableCopyWithZone_ = "mutableCopyWithZone:";

	private static readonly IntPtr selMutableCopyWithZone_Handle = Selector.GetHandle("mutableCopyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartDate = "startDate";

	private static readonly IntPtr selStartDateHandle = Selector.GetHandle("startDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVDateRangeMetadataGroup");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate? EndDate
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
		[NotImplemented]
		set
		{
			throw new NotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual AVMetadataItem[] Items
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
		[NotImplemented]
		set
		{
			throw new NotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate StartDate
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
		[NotImplemented]
		set
		{
			throw new NotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVDateRangeMetadataGroup()
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
	protected AVDateRangeMetadataGroup(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVDateRangeMetadataGroup(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithItems:startDate:endDate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVDateRangeMetadataGroup(AVMetadataItem[] items, NSDate startDate, NSDate? endDate)
		: base(NSObjectFlag.Empty)
	{
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		if (startDate == null)
		{
			throw new ArgumentNullException("startDate");
		}
		NSArray nSArray = NSArray.FromNSObjects(items);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithItems_StartDate_EndDate_Handle, nSArray.Handle, startDate.Handle, endDate?.Handle ?? IntPtr.Zero), "initWithItems:startDate:endDate:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithItems_StartDate_EndDate_Handle, nSArray.Handle, startDate.Handle, endDate?.Handle ?? IntPtr.Zero), "initWithItems:startDate:endDate:");
		}
		nSArray.Dispose();
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("mutableCopyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject MutableCopy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}
}

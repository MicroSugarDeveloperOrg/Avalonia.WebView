using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSMetadataQueryResultGroup", true)]
public class NSMetadataQueryResultGroup : NSObject
{
	private static readonly IntPtr selAttributeHandle = Selector.GetHandle("attribute");

	private static readonly IntPtr selValueHandle = Selector.GetHandle("value");

	private static readonly IntPtr selSubgroupsHandle = Selector.GetHandle("subgroups");

	private static readonly IntPtr selResultCountHandle = Selector.GetHandle("resultCount");

	private static readonly IntPtr selResultsHandle = Selector.GetHandle("results");

	private static readonly IntPtr selResultAtIndex_Handle = Selector.GetHandle("resultAtIndex:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMetadataQueryResultGroup");

	private object __mt_Value_var;

	private object __mt_Subgroups_var;

	private object __mt_Results_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string Attribute
	{
		[Export("attribute")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributeHandle));
		}
	}

	public virtual NSObject Value
	{
		[Export("value")]
		get
		{
			return (NSObject)(__mt_Value_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selValueHandle))));
		}
	}

	public virtual NSObject[] Subgroups
	{
		[Export("subgroups")]
		get
		{
			return (NSObject[])(__mt_Subgroups_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubgroupsHandle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubgroupsHandle))));
		}
	}

	public virtual ulong ResultCount
	{
		[Export("resultCount")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selResultCountHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selResultCountHandle);
		}
	}

	public virtual NSObject[] Results
	{
		[Export("results")]
		get
		{
			return (NSObject[])(__mt_Results_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResultsHandle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selResultsHandle))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMetadataQueryResultGroup()
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
	public NSMetadataQueryResultGroup(NSCoder coder)
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
	public NSMetadataQueryResultGroup(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMetadataQueryResultGroup(IntPtr handle)
		: base(handle)
	{
	}

	[Export("resultAtIndex:")]
	public virtual NSObject ResultAtIndex(ulong idx)
	{
		if (IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selResultAtIndex_Handle, idx));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selResultAtIndex_Handle, idx));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Value_var = null;
			__mt_Subgroups_var = null;
			__mt_Results_var = null;
		}
	}
}

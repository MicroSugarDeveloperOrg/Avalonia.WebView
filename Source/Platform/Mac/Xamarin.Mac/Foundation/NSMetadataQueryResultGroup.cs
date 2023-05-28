using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSMetadataQueryResultGroup", true)]
public class NSMetadataQueryResultGroup : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttribute = "attribute";

	private static readonly IntPtr selAttributeHandle = Selector.GetHandle("attribute");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultAtIndex_ = "resultAtIndex:";

	private static readonly IntPtr selResultAtIndex_Handle = Selector.GetHandle("resultAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultCount = "resultCount";

	private static readonly IntPtr selResultCountHandle = Selector.GetHandle("resultCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResults = "results";

	private static readonly IntPtr selResultsHandle = Selector.GetHandle("results");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubgroups = "subgroups";

	private static readonly IntPtr selSubgroupsHandle = Selector.GetHandle("subgroups");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValue = "value";

	private static readonly IntPtr selValueHandle = Selector.GetHandle("value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMetadataQueryResultGroup");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Attribute
	{
		[Export("attribute")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ResultCount
	{
		[Export("resultCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selResultCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selResultCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] Results
	{
		[Export("results")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selResultsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResultsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] Subgroups
	{
		[Export("subgroups")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubgroupsHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubgroupsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject Value
	{
		[Export("value")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selValueHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMetadataQueryResultGroup()
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
	protected NSMetadataQueryResultGroup(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMetadataQueryResultGroup(IntPtr handle)
		: base(handle)
	{
	}

	[Export("resultAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ResultAtIndex(nuint idx)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selResultAtIndex_Handle, idx));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selResultAtIndex_Handle, idx));
	}
}

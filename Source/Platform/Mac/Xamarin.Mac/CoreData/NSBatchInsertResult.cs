using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSBatchInsertResult", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class NSBatchInsertResult : NSPersistentStoreResult
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResult = "result";

	private static readonly IntPtr selResultHandle = Selector.GetHandle("result");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResultType = "resultType";

	private static readonly IntPtr selResultTypeHandle = Selector.GetHandle("resultType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSBatchInsertResult");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? Result
	{
		[Export("result", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selResultHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResultHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSBatchInsertRequestResultType ResultType
	{
		[Export("resultType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSBatchInsertRequestResultType)Messaging.UInt64_objc_msgSend(base.Handle, selResultTypeHandle);
			}
			return (NSBatchInsertRequestResultType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selResultTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSBatchInsertResult()
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
	protected NSBatchInsertResult(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSBatchInsertResult(IntPtr handle)
		: base(handle)
	{
	}
}

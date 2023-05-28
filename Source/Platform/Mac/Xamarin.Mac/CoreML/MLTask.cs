using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreML;

[Register("MLTask", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MLTask : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancel = "cancel";

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selError = "error";

	private static readonly IntPtr selErrorHandle = Selector.GetHandle("error");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResume = "resume";

	private static readonly IntPtr selResumeHandle = Selector.GetHandle("resume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selState = "state";

	private static readonly IntPtr selStateHandle = Selector.GetHandle("state");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTaskIdentifier = "taskIdentifier";

	private static readonly IntPtr selTaskIdentifierHandle = Selector.GetHandle("taskIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MLTask");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSError? Error
	{
		[Export("error", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend(base.Handle, selErrorHandle));
			}
			return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selErrorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MLTaskState State
	{
		[Export("state", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MLTaskState)Messaging.Int64_objc_msgSend(base.Handle, selStateHandle);
			}
			return (MLTaskState)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string TaskIdentifier
	{
		[Export("taskIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTaskIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTaskIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MLTask(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MLTask(IntPtr handle)
		: base(handle)
	{
	}

	[Export("cancel")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Cancel()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelHandle);
		}
	}

	[Export("resume")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Resume()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResumeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResumeHandle);
		}
	}
}

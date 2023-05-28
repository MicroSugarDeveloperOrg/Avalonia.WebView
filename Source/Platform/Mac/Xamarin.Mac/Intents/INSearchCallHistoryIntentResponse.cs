using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INSearchCallHistoryIntentResponse", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
public class INSearchCallHistoryIntentResponse : INIntentResponse
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCallRecords = "callRecords";

	private static readonly IntPtr selCallRecordsHandle = Selector.GetHandle("callRecords");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCode = "code";

	private static readonly IntPtr selCodeHandle = Selector.GetHandle("code");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCode_UserActivity_ = "initWithCode:userActivity:";

	private static readonly IntPtr selInitWithCode_UserActivity_Handle = Selector.GetHandle("initWithCode:userActivity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCallRecords_ = "setCallRecords:";

	private static readonly IntPtr selSetCallRecords_Handle = Selector.GetHandle("setCallRecords:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INSearchCallHistoryIntentResponse");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	public virtual INCallRecord[]? CallRecords
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Export("callRecords", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<INCallRecord>(Messaging.IntPtr_objc_msgSend(base.Handle, selCallRecordsHandle));
			}
			return NSArray.ArrayFromHandle<INCallRecord>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCallRecordsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Export("setCallRecords:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCallRecords_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCallRecords_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSearchCallHistoryIntentResponseCode Code
	{
		[Export("code")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (INSearchCallHistoryIntentResponseCode)Messaging.Int64_objc_msgSend(base.Handle, selCodeHandle);
			}
			return (INSearchCallHistoryIntentResponseCode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selCodeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public INSearchCallHistoryIntentResponse(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected INSearchCallHistoryIntentResponse(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INSearchCallHistoryIntentResponse(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCode:userActivity:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSearchCallHistoryIntentResponse(INSearchCallHistoryIntentResponseCode code, NSUserActivity? userActivity)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_Int64_IntPtr(base.Handle, selInitWithCode_UserActivity_Handle, (long)code, userActivity?.Handle ?? IntPtr.Zero), "initWithCode:userActivity:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Int64_IntPtr(base.SuperHandle, selInitWithCode_UserActivity_Handle, (long)code, userActivity?.Handle ?? IntPtr.Zero), "initWithCode:userActivity:");
		}
	}
}

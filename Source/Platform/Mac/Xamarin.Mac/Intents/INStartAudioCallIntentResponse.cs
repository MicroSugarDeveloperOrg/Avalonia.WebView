using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INStartAudioCallIntentResponse", true)]
[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'INStartCallIntentResponse' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'INStartCallIntentResponse' instead.")]
[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'INStartCallIntentResponse' instead.")]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
public class INStartAudioCallIntentResponse : INIntentResponse
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCode = "code";

	private static readonly IntPtr selCodeHandle = Selector.GetHandle("code");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCode_UserActivity_ = "initWithCode:userActivity:";

	private static readonly IntPtr selInitWithCode_UserActivity_Handle = Selector.GetHandle("initWithCode:userActivity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INStartAudioCallIntentResponse");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INStartAudioCallIntentResponseCode Code
	{
		[Export("code")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (INStartAudioCallIntentResponseCode)Messaging.Int64_objc_msgSend(base.Handle, selCodeHandle);
			}
			return (INStartAudioCallIntentResponseCode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selCodeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public INStartAudioCallIntentResponse(NSCoder coder)
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
	protected INStartAudioCallIntentResponse(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INStartAudioCallIntentResponse(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCode:userActivity:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INStartAudioCallIntentResponse(INStartAudioCallIntentResponseCode code, NSUserActivity? userActivity)
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

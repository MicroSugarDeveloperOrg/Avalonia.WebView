using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVSampleBufferRequest", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class AVSampleBufferRequest : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDirection = "direction";

	private static readonly IntPtr selDirectionHandle = Selector.GetHandle("direction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithStartCursor_ = "initWithStartCursor:";

	private static readonly IntPtr selInitWithStartCursor_Handle = Selector.GetHandle("initWithStartCursor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLimitCursor = "limitCursor";

	private static readonly IntPtr selLimitCursorHandle = Selector.GetHandle("limitCursor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaxSampleCount = "maxSampleCount";

	private static readonly IntPtr selMaxSampleCountHandle = Selector.GetHandle("maxSampleCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMode = "mode";

	private static readonly IntPtr selModeHandle = Selector.GetHandle("mode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOverrideTime = "overrideTime";

	private static readonly IntPtr selOverrideTimeHandle = Selector.GetHandle("overrideTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredMinSampleCount = "preferredMinSampleCount";

	private static readonly IntPtr selPreferredMinSampleCountHandle = Selector.GetHandle("preferredMinSampleCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDirection_ = "setDirection:";

	private static readonly IntPtr selSetDirection_Handle = Selector.GetHandle("setDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLimitCursor_ = "setLimitCursor:";

	private static readonly IntPtr selSetLimitCursor_Handle = Selector.GetHandle("setLimitCursor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaxSampleCount_ = "setMaxSampleCount:";

	private static readonly IntPtr selSetMaxSampleCount_Handle = Selector.GetHandle("setMaxSampleCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMode_ = "setMode:";

	private static readonly IntPtr selSetMode_Handle = Selector.GetHandle("setMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOverrideTime_ = "setOverrideTime:";

	private static readonly IntPtr selSetOverrideTime_Handle = Selector.GetHandle("setOverrideTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPreferredMinSampleCount_ = "setPreferredMinSampleCount:";

	private static readonly IntPtr selSetPreferredMinSampleCount_Handle = Selector.GetHandle("setPreferredMinSampleCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartCursor = "startCursor";

	private static readonly IntPtr selStartCursorHandle = Selector.GetHandle("startCursor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVSampleBufferRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVSampleBufferRequestDirection Direction
	{
		[Export("direction", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVSampleBufferRequestDirection)Messaging.Int64_objc_msgSend(base.Handle, selDirectionHandle);
			}
			return (AVSampleBufferRequestDirection)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDirectionHandle);
		}
		[Export("setDirection:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDirection_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDirection_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVSampleCursor? LimitCursor
	{
		[Export("limitCursor", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVSampleCursor>(Messaging.IntPtr_objc_msgSend(base.Handle, selLimitCursorHandle));
			}
			return Runtime.GetNSObject<AVSampleCursor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLimitCursorHandle));
		}
		[Export("setLimitCursor:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLimitCursor_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLimitCursor_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint MaxSampleCount
	{
		[Export("maxSampleCount", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMaxSampleCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMaxSampleCountHandle);
		}
		[Export("setMaxSampleCount:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetMaxSampleCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetMaxSampleCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVSampleBufferRequestMode Mode
	{
		[Export("mode", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVSampleBufferRequestMode)Messaging.Int64_objc_msgSend(base.Handle, selModeHandle);
			}
			return (AVSampleBufferRequestMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selModeHandle);
		}
		[Export("setMode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime OverrideTime
	{
		[Export("overrideTime", ArgumentSemantic.Assign)]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selOverrideTimeHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selOverrideTimeHandle);
			}
			return retval;
		}
		[Export("setOverrideTime:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetOverrideTime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetOverrideTime_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint PreferredMinSampleCount
	{
		[Export("preferredMinSampleCount", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selPreferredMinSampleCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selPreferredMinSampleCountHandle);
		}
		[Export("setPreferredMinSampleCount:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetPreferredMinSampleCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetPreferredMinSampleCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVSampleCursor StartCursor
	{
		[Export("startCursor", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVSampleCursor>(Messaging.IntPtr_objc_msgSend(base.Handle, selStartCursorHandle));
			}
			return Runtime.GetNSObject<AVSampleCursor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStartCursorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVSampleBufferRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVSampleBufferRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithStartCursor:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVSampleBufferRequest(AVSampleCursor startCursor)
		: base(NSObjectFlag.Empty)
	{
		if (startCursor == null)
		{
			throw new ArgumentNullException("startCursor");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithStartCursor_Handle, startCursor.Handle), "initWithStartCursor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithStartCursor_Handle, startCursor.Handle), "initWithStartCursor:");
		}
	}
}

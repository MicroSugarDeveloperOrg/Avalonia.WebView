using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAudioEnvironmentDistanceAttenuationParameters", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class AVAudioEnvironmentDistanceAttenuationParameters : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDistanceAttenuationModel = "distanceAttenuationModel";

	private static readonly IntPtr selDistanceAttenuationModelHandle = Selector.GetHandle("distanceAttenuationModel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumDistance = "maximumDistance";

	private static readonly IntPtr selMaximumDistanceHandle = Selector.GetHandle("maximumDistance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReferenceDistance = "referenceDistance";

	private static readonly IntPtr selReferenceDistanceHandle = Selector.GetHandle("referenceDistance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRolloffFactor = "rolloffFactor";

	private static readonly IntPtr selRolloffFactorHandle = Selector.GetHandle("rolloffFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDistanceAttenuationModel_ = "setDistanceAttenuationModel:";

	private static readonly IntPtr selSetDistanceAttenuationModel_Handle = Selector.GetHandle("setDistanceAttenuationModel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumDistance_ = "setMaximumDistance:";

	private static readonly IntPtr selSetMaximumDistance_Handle = Selector.GetHandle("setMaximumDistance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReferenceDistance_ = "setReferenceDistance:";

	private static readonly IntPtr selSetReferenceDistance_Handle = Selector.GetHandle("setReferenceDistance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRolloffFactor_ = "setRolloffFactor:";

	private static readonly IntPtr selSetRolloffFactor_Handle = Selector.GetHandle("setRolloffFactor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioEnvironmentDistanceAttenuationParameters");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioEnvironmentDistanceAttenuationModel DistanceAttenuationModel
	{
		[Export("distanceAttenuationModel", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVAudioEnvironmentDistanceAttenuationModel)Messaging.Int64_objc_msgSend(base.Handle, selDistanceAttenuationModelHandle);
			}
			return (AVAudioEnvironmentDistanceAttenuationModel)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDistanceAttenuationModelHandle);
		}
		[Export("setDistanceAttenuationModel:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDistanceAttenuationModel_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDistanceAttenuationModel_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float MaximumDistance
	{
		[Export("maximumDistance")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selMaximumDistanceHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selMaximumDistanceHandle);
		}
		[Export("setMaximumDistance:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetMaximumDistance_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetMaximumDistance_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float ReferenceDistance
	{
		[Export("referenceDistance")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selReferenceDistanceHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selReferenceDistanceHandle);
		}
		[Export("setReferenceDistance:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetReferenceDistance_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetReferenceDistance_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float RolloffFactor
	{
		[Export("rolloffFactor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selRolloffFactorHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selRolloffFactorHandle);
		}
		[Export("setRolloffFactor:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetRolloffFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetRolloffFactor_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAudioEnvironmentDistanceAttenuationParameters(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioEnvironmentDistanceAttenuationParameters(IntPtr handle)
		: base(handle)
	{
	}
}

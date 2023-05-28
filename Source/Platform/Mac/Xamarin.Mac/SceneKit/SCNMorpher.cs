using System;
using System.ComponentModel;
using CoreAnimation;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNMorpher", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNMorpher : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding, ISCNAnimatable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddAnimation_ForKey_ = "addAnimation:forKey:";

	private static readonly IntPtr selAddAnimation_ForKey_Handle = Selector.GetHandle("addAnimation:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddAnimationPlayer_ForKey_ = "addAnimationPlayer:forKey:";

	private static readonly IntPtr selAddAnimationPlayer_ForKey_Handle = Selector.GetHandle("addAnimationPlayer:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationForKey_ = "animationForKey:";

	private static readonly IntPtr selAnimationForKey_Handle = Selector.GetHandle("animationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationKeys = "animationKeys";

	private static readonly IntPtr selAnimationKeysHandle = Selector.GetHandle("animationKeys");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationPlayerForKey_ = "animationPlayerForKey:";

	private static readonly IntPtr selAnimationPlayerForKey_Handle = Selector.GetHandle("animationPlayerForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalculationMode = "calculationMode";

	private static readonly IntPtr selCalculationModeHandle = Selector.GetHandle("calculationMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAnimationForKeyPaused_ = "isAnimationForKeyPaused:";

	private static readonly IntPtr selIsAnimationForKeyPaused_Handle = Selector.GetHandle("isAnimationForKeyPaused:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPauseAnimationForKey_ = "pauseAnimationForKey:";

	private static readonly IntPtr selPauseAnimationForKey_Handle = Selector.GetHandle("pauseAnimationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllAnimations = "removeAllAnimations";

	private static readonly IntPtr selRemoveAllAnimationsHandle = Selector.GetHandle("removeAllAnimations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAnimationForKey_ = "removeAnimationForKey:";

	private static readonly IntPtr selRemoveAnimationForKey_Handle = Selector.GetHandle("removeAnimationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAnimationForKey_BlendOutDuration_ = "removeAnimationForKey:blendOutDuration:";

	private static readonly IntPtr selRemoveAnimationForKey_BlendOutDuration_Handle = Selector.GetHandle("removeAnimationForKey:blendOutDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAnimationForKey_FadeOutDuration_ = "removeAnimationForKey:fadeOutDuration:";

	private static readonly IntPtr selRemoveAnimationForKey_FadeOutDuration_Handle = Selector.GetHandle("removeAnimationForKey:fadeOutDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResumeAnimationForKey_ = "resumeAnimationForKey:";

	private static readonly IntPtr selResumeAnimationForKey_Handle = Selector.GetHandle("resumeAnimationForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCalculationMode_ = "setCalculationMode:";

	private static readonly IntPtr selSetCalculationMode_Handle = Selector.GetHandle("setCalculationMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSpeed_ForAnimationKey_ = "setSpeed:forAnimationKey:";

	private static readonly IntPtr selSetSpeed_ForAnimationKey_Handle = Selector.GetHandle("setSpeed:forAnimationKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTargets_ = "setTargets:";

	private static readonly IntPtr selSetTargets_Handle = Selector.GetHandle("setTargets:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUnifiesNormals_ = "setUnifiesNormals:";

	private static readonly IntPtr selSetUnifiesNormals_Handle = Selector.GetHandle("setUnifiesNormals:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWeight_ForTargetAtIndex_ = "setWeight:forTargetAtIndex:";

	private static readonly IntPtr selSetWeight_ForTargetAtIndex_Handle = Selector.GetHandle("setWeight:forTargetAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWeight_ForTargetNamed_ = "setWeight:forTargetNamed:";

	private static readonly IntPtr selSetWeight_ForTargetNamed_Handle = Selector.GetHandle("setWeight:forTargetNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWeights_ = "setWeights:";

	private static readonly IntPtr selSetWeights_Handle = Selector.GetHandle("setWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTargets = "targets";

	private static readonly IntPtr selTargetsHandle = Selector.GetHandle("targets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnifiesNormals = "unifiesNormals";

	private static readonly IntPtr selUnifiesNormalsHandle = Selector.GetHandle("unifiesNormals");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWeightForTargetAtIndex_ = "weightForTargetAtIndex:";

	private static readonly IntPtr selWeightForTargetAtIndex_Handle = Selector.GetHandle("weightForTargetAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWeightForTargetNamed_ = "weightForTargetNamed:";

	private static readonly IntPtr selWeightForTargetNamed_Handle = Selector.GetHandle("weightForTargetNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWeights = "weights";

	private static readonly IntPtr selWeightsHandle = Selector.GetHandle("weights");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNMorpher");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNMorpherCalculationMode CalculationMode
	{
		[Export("calculationMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SCNMorpherCalculationMode)Messaging.Int64_objc_msgSend(base.Handle, selCalculationModeHandle);
			}
			return (SCNMorpherCalculationMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selCalculationModeHandle);
		}
		[Export("setCalculationMode:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetCalculationMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetCalculationMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNGeometry[]? Targets
	{
		[Export("targets", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SCNGeometry>(Messaging.IntPtr_objc_msgSend(base.Handle, selTargetsHandle));
			}
			return NSArray.ArrayFromHandle<SCNGeometry>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTargetsHandle));
		}
		[Export("setTargets:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTargets_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTargets_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual bool UnifiesNormals
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("unifiesNormals")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUnifiesNormalsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUnifiesNormalsHandle);
		}
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setUnifiesNormals:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUnifiesNormals_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUnifiesNormals_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual NSNumber[] Weights
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("weights", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selWeightsHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWeightsHandle));
		}
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setWeights:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetWeights_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetWeights_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SCNMorpher()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SCNMorpher(NSCoder coder)
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
	protected SCNMorpher(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNMorpher(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addAnimation:forKey:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddAnimation(CAAnimation animation, NSString? key)
	{
		if (animation == null)
		{
			throw new ArgumentNullException("animation");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddAnimation_ForKey_Handle, animation.Handle, (key == null) ? IntPtr.Zero : key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddAnimation_ForKey_Handle, animation.Handle, (key == null) ? IntPtr.Zero : key.Handle);
		}
	}

	[Export("addAnimationPlayer:forKey:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddAnimation(SCNAnimationPlayer player, NSString? key)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddAnimationPlayer_ForKey_Handle, player.Handle, (key == null) ? IntPtr.Zero : key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddAnimationPlayer_ForKey_Handle, player.Handle, (key == null) ? IntPtr.Zero : key.Handle);
		}
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("animationForKey:")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'GetAnimationPlayer' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'GetAnimationPlayer' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'GetAnimationPlayer' instead.")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CAAnimation GetAnimation(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<CAAnimation>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAnimationForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject<CAAnimation>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnimationForKey_Handle, key.Handle));
	}

	[Export("animationKeys")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString[] GetAnimationKeys()
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationKeysHandle));
		}
		return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationKeysHandle));
	}

	[Export("animationPlayerForKey:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNAnimationPlayer? GetAnimationPlayer(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<SCNAnimationPlayer>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAnimationPlayerForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject<SCNAnimationPlayer>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnimationPlayerForKey_Handle, key.Handle));
	}

	[Export("weightForTargetAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetWeight(nuint targetIndex)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nfloat_objc_msgSend_nuint(base.Handle, selWeightForTargetAtIndex_Handle, targetIndex);
		}
		return Messaging.nfloat_objc_msgSendSuper_nuint(base.SuperHandle, selWeightForTargetAtIndex_Handle, targetIndex);
	}

	[Export("weightForTargetNamed:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat GetWeight(string targetName)
	{
		if (targetName == null)
		{
			throw new ArgumentNullException("targetName");
		}
		IntPtr arg = NSString.CreateNative(targetName);
		nfloat result = ((!base.IsDirectBinding) ? Messaging.nfloat_objc_msgSendSuper_IntPtr(base.SuperHandle, selWeightForTargetNamed_Handle, arg) : Messaging.nfloat_objc_msgSend_IntPtr(base.Handle, selWeightForTargetNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("isAnimationForKeyPaused:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsAnimationPaused(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsAnimationForKeyPaused_Handle, key.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsAnimationForKeyPaused_Handle, key.Handle);
	}

	[Export("pauseAnimationForKey:")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PauseAnimation(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPauseAnimationForKey_Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPauseAnimationForKey_Handle, key.Handle);
		}
	}

	[Export("removeAllAnimations")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllAnimations()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllAnimationsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllAnimationsHandle);
		}
	}

	[Export("removeAnimationForKey:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAnimation(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveAnimationForKey_Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveAnimationForKey_Handle, key.Handle);
		}
	}

	[Export("removeAnimationForKey:fadeOutDuration:")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'RemoveAnimationUsingBlendOutDuration' instead.")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAnimation(NSString key, nfloat duration)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nfloat(base.Handle, selRemoveAnimationForKey_FadeOutDuration_Handle, key.Handle, duration);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nfloat(base.SuperHandle, selRemoveAnimationForKey_FadeOutDuration_Handle, key.Handle, duration);
		}
	}

	[Export("removeAnimationForKey:blendOutDuration:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAnimationUsingBlendOutDuration(NSString key, nfloat blendOutDuration)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nfloat(base.Handle, selRemoveAnimationForKey_BlendOutDuration_Handle, key.Handle, blendOutDuration);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nfloat(base.SuperHandle, selRemoveAnimationForKey_BlendOutDuration_Handle, key.Handle, blendOutDuration);
		}
	}

	[Export("resumeAnimationForKey:")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Paused' instead.")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResumeAnimation(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selResumeAnimationForKey_Handle, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selResumeAnimationForKey_Handle, key.Handle);
		}
	}

	[Export("setSpeed:forAnimationKey:")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Speed' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Speed' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Speed' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SCNAnimationPlayer.Speed' instead.")]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetSpeed(nfloat speed, NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_IntPtr(base.Handle, selSetSpeed_ForAnimationKey_Handle, speed, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_IntPtr(base.SuperHandle, selSetSpeed_ForAnimationKey_Handle, speed, key.Handle);
		}
	}

	[Export("setWeight:forTargetAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetWeight(nfloat weight, nuint targetIndex)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_nuint(base.Handle, selSetWeight_ForTargetAtIndex_Handle, weight, targetIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_nuint(base.SuperHandle, selSetWeight_ForTargetAtIndex_Handle, weight, targetIndex);
		}
	}

	[Export("setWeight:forTargetNamed:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetWeight(nfloat weight, string targetName)
	{
		if (targetName == null)
		{
			throw new ArgumentNullException("targetName");
		}
		IntPtr arg = NSString.CreateNative(targetName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nfloat_IntPtr(base.Handle, selSetWeight_ForTargetNamed_Handle, weight, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nfloat_IntPtr(base.SuperHandle, selSetWeight_ForTargetNamed_Handle, weight, arg);
		}
		NSString.ReleaseNative(arg);
	}
}

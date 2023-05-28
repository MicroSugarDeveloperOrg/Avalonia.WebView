using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
public class SCNSceneLoadingOptions : DictionaryContainer
{
	public SCNAnimationImportPolicy AnimationImportPolicy
	{
		get
		{
			NSString animationImportPolicyKey = _AnimationImportPolicyKey;
			if (animationImportPolicyKey == SCNSceneSourceLoading.AnimationImportPolicyPlay)
			{
				return SCNAnimationImportPolicy.Play;
			}
			if (animationImportPolicyKey == SCNSceneSourceLoading.AnimationImportPolicyPlayRepeatedly)
			{
				return SCNAnimationImportPolicy.PlayRepeatedly;
			}
			if (animationImportPolicyKey == SCNSceneSourceLoading.AnimationImportPolicyDoNotPlay)
			{
				return SCNAnimationImportPolicy.DoNotPlay;
			}
			if (animationImportPolicyKey == SCNSceneSourceLoading.AnimationImportPolicyPlayUsingSceneTimeBase)
			{
				return SCNAnimationImportPolicy.PlayUsingSceneTimeBase;
			}
			return SCNAnimationImportPolicy.Unknown;
		}
		set
		{
			switch (value)
			{
			case SCNAnimationImportPolicy.Play:
				_AnimationImportPolicyKey = SCNSceneSourceLoading.AnimationImportPolicyPlay;
				break;
			case SCNAnimationImportPolicy.PlayRepeatedly:
				_AnimationImportPolicyKey = SCNSceneSourceLoading.AnimationImportPolicyPlayRepeatedly;
				break;
			case SCNAnimationImportPolicy.DoNotPlay:
				_AnimationImportPolicyKey = SCNSceneSourceLoading.AnimationImportPolicyDoNotPlay;
				break;
			case SCNAnimationImportPolicy.PlayUsingSceneTimeBase:
				_AnimationImportPolicyKey = SCNSceneSourceLoading.AnimationImportPolicyPlayUsingSceneTimeBase;
				break;
			default:
				throw new ArgumentException("Invalid value passed to AnimationImportPolicy property");
			}
		}
	}

	public NSUrl[]? AssetDirectoryUrls
	{
		get
		{
			return GetArray<NSUrl>(SCNSceneSourceLoading.AssetDirectoryUrlsKey);
		}
		set
		{
			SetArrayValue(SCNSceneSourceLoading.AssetDirectoryUrlsKey, value);
		}
	}

	public bool? CreateNormalsIfAbsent
	{
		get
		{
			return GetBoolValue(SCNSceneSourceLoading.CreateNormalsIfAbsentKey);
		}
		set
		{
			SetBooleanValue(SCNSceneSourceLoading.CreateNormalsIfAbsentKey, value);
		}
	}

	public bool? FlattenScene
	{
		get
		{
			return GetBoolValue(SCNSceneSourceLoading.FlattenSceneKey);
		}
		set
		{
			SetBooleanValue(SCNSceneSourceLoading.FlattenSceneKey, value);
		}
	}

	public bool? CheckConsistency
	{
		get
		{
			return GetBoolValue(SCNSceneSourceLoading.CheckConsistencyKey);
		}
		set
		{
			SetBooleanValue(SCNSceneSourceLoading.CheckConsistencyKey, value);
		}
	}

	public bool? OverrideAssetUrls
	{
		get
		{
			return GetBoolValue(SCNSceneSourceLoading.OverrideAssetUrlsKey);
		}
		set
		{
			SetBooleanValue(SCNSceneSourceLoading.OverrideAssetUrlsKey, value);
		}
	}

	public bool? StrictConformance
	{
		get
		{
			return GetBoolValue(SCNSceneSourceLoading.StrictConformanceKey);
		}
		set
		{
			SetBooleanValue(SCNSceneSourceLoading.StrictConformanceKey, value);
		}
	}

	public bool? UseSafeMode
	{
		get
		{
			return GetBoolValue(SCNSceneSourceLoading.UseSafeModeKey);
		}
		set
		{
			SetBooleanValue(SCNSceneSourceLoading.UseSafeModeKey, value);
		}
	}

	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public bool? PreserveOriginalTopology
	{
		get
		{
			return GetBoolValue(SCNSceneSourceLoading.OptionPreserveOriginalTopology);
		}
		set
		{
			SetBooleanValue(SCNSceneSourceLoading.OptionPreserveOriginalTopology, value);
		}
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public float? ConvertUnitsToMeters
	{
		get
		{
			return GetFloatValue(SCNSceneSourceLoading.ConvertUnitsToMetersKey);
		}
		set
		{
			SetNumberValue(SCNSceneSourceLoading.ConvertUnitsToMetersKey, value);
		}
	}

	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public bool? ConvertToYUp
	{
		get
		{
			return GetBoolValue(SCNSceneSourceLoading.ConvertToYUpKey);
		}
		set
		{
			SetBooleanValue(SCNSceneSourceLoading.ConvertToYUpKey, value);
		}
	}

	internal NSString? _AnimationImportPolicyKey
	{
		get
		{
			return GetNSStringValue(SCNSceneSourceLoading.AnimationImportPolicyKey);
		}
		set
		{
			SetStringValue(SCNSceneSourceLoading.AnimationImportPolicyKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public SCNSceneLoadingOptions()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public SCNSceneLoadingOptions(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}

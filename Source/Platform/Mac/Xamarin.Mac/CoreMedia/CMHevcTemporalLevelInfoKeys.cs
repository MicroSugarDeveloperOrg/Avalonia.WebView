using Foundation;
using ObjCRuntime;

namespace CoreMedia;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
internal static class CMHevcTemporalLevelInfoKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ConstraintIndicatorFlagsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LevelIndexKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProfileCompatibilityFlagsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProfileIndexKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProfileSpaceKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TemporalLevelKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TierFlagKey;

	[Field("kCMHEVCTemporalLevelInfoKey_ConstraintIndicatorFlags", "CoreMedia")]
	public static NSString ConstraintIndicatorFlagsKey
	{
		get
		{
			if (_ConstraintIndicatorFlagsKey == null)
			{
				_ConstraintIndicatorFlagsKey = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMHEVCTemporalLevelInfoKey_ConstraintIndicatorFlags");
			}
			return _ConstraintIndicatorFlagsKey;
		}
	}

	[Field("kCMHEVCTemporalLevelInfoKey_LevelIndex", "CoreMedia")]
	public static NSString LevelIndexKey
	{
		get
		{
			if (_LevelIndexKey == null)
			{
				_LevelIndexKey = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMHEVCTemporalLevelInfoKey_LevelIndex");
			}
			return _LevelIndexKey;
		}
	}

	[Field("kCMHEVCTemporalLevelInfoKey_ProfileCompatibilityFlags", "CoreMedia")]
	public static NSString ProfileCompatibilityFlagsKey
	{
		get
		{
			if (_ProfileCompatibilityFlagsKey == null)
			{
				_ProfileCompatibilityFlagsKey = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMHEVCTemporalLevelInfoKey_ProfileCompatibilityFlags");
			}
			return _ProfileCompatibilityFlagsKey;
		}
	}

	[Field("kCMHEVCTemporalLevelInfoKey_ProfileIndex", "CoreMedia")]
	public static NSString ProfileIndexKey
	{
		get
		{
			if (_ProfileIndexKey == null)
			{
				_ProfileIndexKey = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMHEVCTemporalLevelInfoKey_ProfileIndex");
			}
			return _ProfileIndexKey;
		}
	}

	[Field("kCMHEVCTemporalLevelInfoKey_ProfileSpace", "CoreMedia")]
	public static NSString ProfileSpaceKey
	{
		get
		{
			if (_ProfileSpaceKey == null)
			{
				_ProfileSpaceKey = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMHEVCTemporalLevelInfoKey_ProfileSpace");
			}
			return _ProfileSpaceKey;
		}
	}

	[Field("kCMHEVCTemporalLevelInfoKey_TemporalLevel", "CoreMedia")]
	public static NSString TemporalLevelKey
	{
		get
		{
			if (_TemporalLevelKey == null)
			{
				_TemporalLevelKey = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMHEVCTemporalLevelInfoKey_TemporalLevel");
			}
			return _TemporalLevelKey;
		}
	}

	[Field("kCMHEVCTemporalLevelInfoKey_TierFlag", "CoreMedia")]
	public static NSString TierFlagKey
	{
		get
		{
			if (_TierFlagKey == null)
			{
				_TierFlagKey = Dlfcn.GetStringConstant(Libraries.CoreMedia.Handle, "kCMHEVCTemporalLevelInfoKey_TierFlag");
			}
			return _TierFlagKey;
		}
	}
}

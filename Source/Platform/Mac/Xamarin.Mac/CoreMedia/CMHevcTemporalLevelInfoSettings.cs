using Foundation;
using ObjCRuntime;

namespace CoreMedia;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class CMHevcTemporalLevelInfoSettings : DictionaryContainer
{
	public int? TemporalLevel
	{
		get
		{
			return GetInt32Value(CMHevcTemporalLevelInfoKeys.TemporalLevelKey);
		}
		set
		{
			SetNumberValue(CMHevcTemporalLevelInfoKeys.TemporalLevelKey, value);
		}
	}

	public int? ProfileSpace
	{
		get
		{
			return GetInt32Value(CMHevcTemporalLevelInfoKeys.ProfileSpaceKey);
		}
		set
		{
			SetNumberValue(CMHevcTemporalLevelInfoKeys.ProfileSpaceKey, value);
		}
	}

	public int? TierFlag
	{
		get
		{
			return GetInt32Value(CMHevcTemporalLevelInfoKeys.TierFlagKey);
		}
		set
		{
			SetNumberValue(CMHevcTemporalLevelInfoKeys.TierFlagKey, value);
		}
	}

	public int? ProfileIndex
	{
		get
		{
			return GetInt32Value(CMHevcTemporalLevelInfoKeys.ProfileIndexKey);
		}
		set
		{
			SetNumberValue(CMHevcTemporalLevelInfoKeys.ProfileIndexKey, value);
		}
	}

	public NSData? ProfileCompatibilityFlags
	{
		get
		{
			return base.Dictionary[CMHevcTemporalLevelInfoKeys.ProfileCompatibilityFlagsKey] as NSData;
		}
		set
		{
			SetNativeValue(CMHevcTemporalLevelInfoKeys.ProfileCompatibilityFlagsKey, value);
		}
	}

	public NSData? ConstraintIndicatorFlags
	{
		get
		{
			return base.Dictionary[CMHevcTemporalLevelInfoKeys.ConstraintIndicatorFlagsKey] as NSData;
		}
		set
		{
			SetNativeValue(CMHevcTemporalLevelInfoKeys.ConstraintIndicatorFlagsKey, value);
		}
	}

	public int? LevelIndex
	{
		get
		{
			return GetInt32Value(CMHevcTemporalLevelInfoKeys.LevelIndexKey);
		}
		set
		{
			SetNumberValue(CMHevcTemporalLevelInfoKeys.LevelIndexKey, value);
		}
	}

	[Preserve(Conditional = true)]
	public CMHevcTemporalLevelInfoSettings()
		: base(new NSMutableDictionary())
	{
	}

	[Preserve(Conditional = true)]
	public CMHevcTemporalLevelInfoSettings(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}

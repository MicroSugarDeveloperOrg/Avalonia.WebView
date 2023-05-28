using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
internal static class AVContentKeySessionServerPlaybackContextOptionKeys
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProtocolVersionsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ServerChallengeKey;

	[Field("AVContentKeySessionServerPlaybackContextOptionProtocolVersions", "AVFoundation")]
	public static NSString ProtocolVersionsKey
	{
		get
		{
			if (_ProtocolVersionsKey == null)
			{
				_ProtocolVersionsKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVContentKeySessionServerPlaybackContextOptionProtocolVersions");
			}
			return _ProtocolVersionsKey;
		}
	}

	[Field("AVContentKeySessionServerPlaybackContextOptionServerChallenge", "AVFoundation")]
	public static NSString ServerChallengeKey
	{
		get
		{
			if (_ServerChallengeKey == null)
			{
				_ServerChallengeKey = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVContentKeySessionServerPlaybackContextOptionServerChallenge");
			}
			return _ServerChallengeKey;
		}
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.iOS, 7, 0, PlatformArchitecture.None, "Implement the 'IGKChallengeListener' interface and register a listener with 'GKLocalPlayer'.")]
[Deprecated(PlatformName.MacOSX, 10, 10, PlatformArchitecture.None, "Implement the 'IGKChallengeListener' interface and register a listener with 'GKLocalPlayer'.")]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Protocol(Name = "GKChallengeEventHandlerDelegate", WrapperType = typeof(GKChallengeEventHandlerDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "LocalPlayerSelectedChallenge", Selector = "localPlayerDidSelectChallenge:", ParameterType = new Type[] { typeof(GKChallenge) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowBannerForLocallyReceivedChallenge", Selector = "shouldShowBannerForLocallyReceivedChallenge:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(GKChallenge) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "LocalPlayerReceivedChallenge", Selector = "localPlayerDidReceiveChallenge:", ParameterType = new Type[] { typeof(GKChallenge) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowBannerForLocallyCompletedChallenge", Selector = "shouldShowBannerForLocallyCompletedChallenge:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(GKChallenge) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "LocalPlayerCompletedChallenge", Selector = "localPlayerDidCompleteChallenge:", ParameterType = new Type[] { typeof(GKChallenge) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowBannerForRemotelyCompletedChallenge", Selector = "shouldShowBannerForRemotelyCompletedChallenge:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(GKChallenge) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemotePlayerCompletedChallenge", Selector = "remotePlayerDidCompleteChallenge:", ParameterType = new Type[] { typeof(GKChallenge) }, ParameterByRef = new bool[] { false })]
public interface IGKChallengeEventHandlerDelegate : INativeObject, IDisposable
{
}

using System;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "MDLJointAnimation", WrapperType = typeof(MDLJointAnimationWrapper))]
public interface IMDLJointAnimation : INativeObject, IDisposable
{
}

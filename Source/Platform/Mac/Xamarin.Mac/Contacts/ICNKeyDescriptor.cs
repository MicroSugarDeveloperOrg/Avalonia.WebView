using System;
using Foundation;
using ObjCRuntime;

namespace Contacts;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "CNKeyDescriptor", WrapperType = typeof(CNKeyDescriptorWrapper))]
public interface ICNKeyDescriptor : INativeObject, IDisposable, INSCoding, INSCopying, INSObjectProtocol, INSSecureCoding
{
}

using System;
using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "CKRecordValue", WrapperType = typeof(CKRecordValueWrapper))]
public interface ICKRecordValue : INativeObject, IDisposable
{
}

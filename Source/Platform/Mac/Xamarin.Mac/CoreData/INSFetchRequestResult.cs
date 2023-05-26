using Foundation;
using ObjCRuntime;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace CoreData;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Protocol(Name = "NSFetchRequestResult", WrapperType = typeof(NSFetchRequestResultWrapper))]
public interface INSFetchRequestResult : INativeObject, IDisposable
{
}

using System;
using ObjCRuntime;

namespace Foundation;

[Protocol(Name = "NSCacheDelegate", WrapperType = typeof(NSCacheDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillEvictObject", Selector = "cache:willEvictObject:", ParameterType = new Type[]
{
	typeof(NSCache),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
public interface INSCacheDelegate : INativeObject, IDisposable
{
}

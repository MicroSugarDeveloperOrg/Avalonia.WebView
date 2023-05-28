using System;
using ObjCRuntime;

namespace Foundation;

[Protocol(Name = "NSSecureCoding", WrapperType = typeof(NSSecureCodingWrapper))]
public interface INSSecureCoding : INativeObject, IDisposable, INSCoding
{
}

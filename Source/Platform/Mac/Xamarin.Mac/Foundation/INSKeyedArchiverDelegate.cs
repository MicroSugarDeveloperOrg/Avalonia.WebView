using System;
using ObjCRuntime;

namespace Foundation;

[Protocol(Name = "NSKeyedArchiverDelegate", WrapperType = typeof(NSKeyedArchiverDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "EncodedObject", Selector = "archiver:didEncodeObject:", ParameterType = new Type[]
{
	typeof(NSKeyedArchiver),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Finished", Selector = "archiverDidFinish:", ParameterType = new Type[] { typeof(NSKeyedArchiver) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillEncode", Selector = "archiver:willEncodeObject:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(NSKeyedArchiver),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Finishing", Selector = "archiverWillFinish:", ParameterType = new Type[] { typeof(NSKeyedArchiver) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReplacingObject", Selector = "archiver:willReplaceObject:withObject:", ParameterType = new Type[]
{
	typeof(NSKeyedArchiver),
	typeof(NSObject),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false, false })]
public interface INSKeyedArchiverDelegate : INativeObject, IDisposable
{
}

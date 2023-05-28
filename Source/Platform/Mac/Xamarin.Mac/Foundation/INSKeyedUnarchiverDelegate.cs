using System;
using ObjCRuntime;

namespace Foundation;

[Protocol(Name = "NSKeyedUnarchiverDelegate", WrapperType = typeof(NSKeyedUnarchiverDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecodedObject", Selector = "unarchiver:didDecodeObject:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(NSKeyedUnarchiver),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Finished", Selector = "unarchiverDidFinish:", ParameterType = new Type[] { typeof(NSKeyedUnarchiver) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CannotDecodeClass", Selector = "unarchiver:cannotDecodeObjectOfClassName:originalClasses:", ReturnType = typeof(Class), ParameterType = new Type[]
{
	typeof(NSKeyedUnarchiver),
	typeof(string),
	typeof(string[])
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Finishing", Selector = "unarchiverWillFinish:", ParameterType = new Type[] { typeof(NSKeyedUnarchiver) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReplacingObject", Selector = "unarchiver:willReplaceObject:withObject:", ParameterType = new Type[]
{
	typeof(NSKeyedUnarchiver),
	typeof(NSObject),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false, false })]
public interface INSKeyedUnarchiverDelegate : INativeObject, IDisposable
{
}

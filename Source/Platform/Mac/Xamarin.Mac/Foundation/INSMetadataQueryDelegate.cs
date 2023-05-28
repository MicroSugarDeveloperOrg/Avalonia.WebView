using System;
using ObjCRuntime;

namespace Foundation;

[Protocol(Name = "NSMetadataQueryDelegate", WrapperType = typeof(NSMetadataQueryDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReplacementObjectForResultObject", Selector = "metadataQuery:replacementObjectForResultObject:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(NSMetadataQuery),
	typeof(NSMetadataItem)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReplacementValueForAttributevalue", Selector = "metadataQuery:replacementValueForAttribute:value:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(NSMetadataQuery),
	typeof(string),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false, false })]
public interface INSMetadataQueryDelegate : INativeObject, IDisposable
{
}

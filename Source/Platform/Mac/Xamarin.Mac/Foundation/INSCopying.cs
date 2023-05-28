using System;
using ObjCRuntime;

namespace Foundation;

[Protocol(Name = "NSCopying", WrapperType = typeof(NSCopyingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "Copy", Selector = "copyWithZone:", ReturnType = typeof(NSObject), ParameterType = new Type[] { typeof(NSZone) }, ParameterByRef = new bool[] { false })]
public interface INSCopying : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("copyWithZone:")]
	[Preserve(Conditional = true)]
	[return: Release]
	NSObject Copy(NSZone? zone);
}

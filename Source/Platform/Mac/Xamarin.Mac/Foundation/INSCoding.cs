using System;
using ObjCRuntime;

namespace Foundation;

[Protocol(Name = "NSCoding", WrapperType = typeof(NSCodingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "EncodeTo", Selector = "encodeWithCoder:", ParameterType = new Type[] { typeof(NSCoder) }, ParameterByRef = new bool[] { false })]
public interface INSCoding : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("encodeWithCoder:")]
	[Preserve(Conditional = true)]
	void EncodeTo(NSCoder encoder);
}

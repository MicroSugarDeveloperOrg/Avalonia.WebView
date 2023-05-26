using ObjCRuntime;

namespace Foundation;

[Protocol(Name = "NSMutableCopying", WrapperType = typeof(NSMutableCopyingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "MutableCopy", Selector = "mutableCopyWithZone:", ReturnType = typeof(NSObject), ParameterType = new Type[] { typeof(NSZone) }, ParameterByRef = new bool[] { false })]
public interface INSMutableCopying : INativeObject, IDisposable, INSCopying
{
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [Export("mutableCopyWithZone:")]
    [Preserve(Conditional = true)]
    [return: Release]
    NSObject MutableCopy(NSZone? zone);
}

using Foundation;
using ObjCRuntime;

namespace WebKit;


[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "WKURLSchemeTask", WrapperType = typeof(WKUrlSchemeTaskWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveResponse", Selector = "didReceiveResponse:", ParameterType = new Type[] { typeof(NSUrlResponse) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidReceiveData", Selector = "didReceiveData:", ParameterType = new Type[] { typeof(NSData) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFinish", Selector = "didFinish")]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidFailWithError", Selector = "didFailWithError:", ParameterType = new Type[] { typeof(NSError) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Request", Selector = "request", PropertyType = typeof(NSUrlRequest), GetterSelector = "request", ArgumentSemantic = ArgumentSemantic.Copy)]
public interface IWKUrlSchemeTask : INativeObject, IDisposable
{
    [Preserve(Conditional = true)]
    NSUrlRequest Request
    {
        [Export("request", ArgumentSemantic.Copy)]
        get;
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [Export("didReceiveResponse:")]
    [Preserve(Conditional = true)]
    void DidReceiveResponse(NSUrlResponse response);

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [Export("didReceiveData:")]
    [Preserve(Conditional = true)]
    void DidReceiveData(NSData data);

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [Export("didFinish")]
    [Preserve(Conditional = true)]
    void DidFinish();

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [Export("didFailWithError:")]
    [Preserve(Conditional = true)]
    void DidFailWithError(NSError error);
}
using Foundation;
using ObjCRuntime;
using Xamarin.Utiles;

namespace WebKit;

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

    [Export("didReceiveResponse:")]
    [Preserve(Conditional = true)]
    void DidReceiveResponse(NSUrlResponse response);

    [Export("didReceiveData:")]
    [Preserve(Conditional = true)]
    void DidReceiveData(NSData data);

    [Export("didFinish")]
    [Preserve(Conditional = true)]
    void DidFinish();

    [Export("didFailWithError:")]
    [Preserve(Conditional = true)]
    void DidFailWithError(NSError error);
}
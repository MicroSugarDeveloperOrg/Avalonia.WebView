using Foundation;
using ObjCRuntime;

namespace WebKit;

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
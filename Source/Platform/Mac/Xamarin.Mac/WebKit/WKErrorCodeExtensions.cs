using Foundation;
using ObjCRuntime;

namespace WebKit;
public static class WKErrorCodeExtensions
{
    [Field("WKErrorDomain", "WebKit")]
    private static NSString? _domain;

    public static NSString? GetDomain(this WKErrorCode self)
    {
        if (_domain == null)
        {
            _domain = Dlfcn.GetStringConstant(Libraries.WebKit.Handle, "WKErrorDomain");
        }
        return _domain;
    }
}

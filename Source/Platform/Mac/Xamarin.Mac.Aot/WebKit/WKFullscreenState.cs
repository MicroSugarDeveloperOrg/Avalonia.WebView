using Xamarin.Utiles;

namespace WebKit;
[Native]
public enum WKFullscreenState : long
{
    NotInFullscreen,
    EnteringFullscreen,
    InFullscreen,
    ExitingFullscreen
}

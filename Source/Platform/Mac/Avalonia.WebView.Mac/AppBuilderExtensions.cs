namespace Avalonia.WebView.Mac;

public static class AppBuilderExtensions
{
    public static AppBuilder UseOSXWebView(this AppBuilder builder)
    {
        return builder.AfterPlatformServicesSetup(app =>
        {
            AvaloniaLocator.CurrentMutable.BindToSelf<IViewHandlerProvider>(new ViewHandlerProvider());
            AvaloniaLocator.CurrentMutable.BindToSelf<IPlatformBlazorWebViewProvider>(new BlaozeWebViewHandlerProvider());
        });
    }
}


//新版本的macOS及iOS都强制必须使用https网页访问，如果需要支持老的http网页，还需要在Info.plist中增加一行：App Transport Security Settings，类型为字典项，其中增加一项：Allow Arbitrary Loads，值为YES。
//完成以上4项，网页已经可以访问了。
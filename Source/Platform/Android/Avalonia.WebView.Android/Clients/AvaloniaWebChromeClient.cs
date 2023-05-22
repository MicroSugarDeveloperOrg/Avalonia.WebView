namespace Avalonia.WebView.Android.Clients;

internal class AvaloniaWebChromeClient : WebChromeClient
{
    public AvaloniaWebChromeClient(AndroidWebViewCore androidWebViewCore)
    {
        _androidWebViewCore = androidWebViewCore;
        var topLevel = androidWebViewCore.GetTopLevel();
        if (topLevel is null)
            throw new ArgumentNullException(nameof(topLevel));

        _topLevel = topLevel;
    }

    readonly AndroidWebViewCore _androidWebViewCore;
    readonly TopLevel _topLevel;

    public override bool OnCreateWindow(AndroidWebView? view, bool isDialog, bool isUserGesture, Message? resultMsg)
    {
        if (view?.Context is not null)
        {
            var requestUrl = view.GetHitTestResult().Extra;
            var intent = new Intent(Intent.ActionView, AndroidUri.Parse(requestUrl));
            intent.SetFlags(ActivityFlags.NewTask);
            view.Context.StartActivity(intent);
        }

        return false;
    }

    public override bool OnShowFileChooser(AndroidWebView? webView, IValueCallback? filePathCallback, FileChooserParams? fileChooserParams)
    {
        if (filePathCallback is null)
            return base.OnShowFileChooser(webView, filePathCallback, fileChooserParams);

        CallFilePickerAsync(filePathCallback, fileChooserParams).FireAndForget();
        return true;
    }

    private async Task CallFilePickerAsync(IValueCallback filePathCallback, FileChooserParams? fileChooserParams)
    {
        var pickOptions = GetPickOptions(fileChooserParams);
        if (pickOptions is null)
        {
            filePathCallback.OnReceiveValue(default);
            return;
        }

        var fileResults = await _topLevel.StorageProvider.OpenFilePickerAsync(pickOptions);
        if (fileResults?.All(f => f is null) ?? true)
        {
            filePathCallback.OnReceiveValue(default);
            return;
        }

        var fileUris = new List<AndroidUri>(fileResults.Count());
        foreach (var fileResult in fileResults)
        {
            if (fileResult is null)
                continue;

            var javaFile = new JavaFile(fileResult.Path.AbsoluteUri);
            var androidUri = AndroidUri.FromFile(javaFile);

            if (androidUri is not null)
                fileUris.Add(androidUri);
        }

        filePathCallback.OnReceiveValue(fileUris.ToArray());
        return;
    }

    private static FilePickerOpenOptions? GetPickOptions(FileChooserParams? fileChooserParams)
    {
        if (fileChooserParams is null)
            return default;

        var acceptedFileTypes = fileChooserParams.GetAcceptTypes();
        if (acceptedFileTypes is null || (acceptedFileTypes.Length == 1 && string.IsNullOrEmpty(acceptedFileTypes[0])))
            return null;

        bool allowMultiple = fileChooserParams.Mode == ChromeFileChooserMode.OpenMultiple;

        var pickOptions = new FilePickerOpenOptions()
        {
            AllowMultiple = allowMultiple,
            FileTypeFilter = new List<FilePickerFileType>()
            {
                 new FilePickerFileType("Accepted File")
                 {
                     Patterns = acceptedFileTypes,
                     AppleUniformTypeIdentifiers = new string[1] { "public.accepted"},
                     MimeTypes = new string[1] { "accepted/*" }
                 }
            }
        };
        return pickOptions;
    }
}


using Microsoft.Web.WebView2.Core;

namespace Microsoft.Web.WebView2.WinForms;


public class CoreWebView2CreationProperties
{
    private string _browserExecutableFolder;

    private string _userDataFolder;

    private string _language;

    private string _additionalBrowserArguments;

    private Task<CoreWebView2Environment> _task;

    public string BrowserExecutableFolder
    {
        get
        {
            return _browserExecutableFolder;
        }
        set
        {
            _browserExecutableFolder = value;
            _task = null;
        }
    }

    public string UserDataFolder
    {
        get
        {
            return _userDataFolder;
        }
        set
        {
            _userDataFolder = value;
            _task = null;
        }
    }

    public string Language
    {
        get
        {
            return _language;
        }
        set
        {
            _language = value;
            _task = null;
        }
    }

    public string ProfileName { get; set; }

    public string AdditionalBrowserArguments
    {
        get
        {
            return _additionalBrowserArguments;
        }
        set
        {
            _additionalBrowserArguments = value;
            _task = null;
        }
    }

    public bool? IsInPrivateModeEnabled { get; set; }

    internal Task<CoreWebView2Environment> CreateEnvironmentAsync()
    {
        if (_task == null && (BrowserExecutableFolder != null || UserDataFolder != null || Language != null || AdditionalBrowserArguments != null))
        {
            _task = CoreWebView2Environment.CreateAsync(BrowserExecutableFolder, UserDataFolder, new CoreWebView2EnvironmentOptions(AdditionalBrowserArguments, Language));
        }
        return _task ?? Task.FromResult<CoreWebView2Environment>(null);
    }

    internal CoreWebView2ControllerOptions CreateCoreWebView2ControllerOptions(CoreWebView2Environment environment)
    {
        CoreWebView2ControllerOptions coreWebView2ControllerOptions = null;
        if (ProfileName != null || IsInPrivateModeEnabled.HasValue)
        {
            coreWebView2ControllerOptions = environment.CreateCoreWebView2ControllerOptions();
            coreWebView2ControllerOptions.ProfileName = ProfileName;
            coreWebView2ControllerOptions.IsInPrivateModeEnabled = IsInPrivateModeEnabled.GetValueOrDefault();
        }
        return coreWebView2ControllerOptions;
    }
}

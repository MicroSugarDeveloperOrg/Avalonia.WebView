namespace SampleBlazorWebViewShared.Global.Config;

public class GlobalConfig
{
    private readonly CookieStorage? _cookieStorage;

    private string? _pageMode;
    private bool _expandOnHover;
    private string? _favorite;
    private string? _navigationStyle;

    public GlobalConfig(CookieStorage cookieStorage, IHttpContextAccessor httpContextAccessor)
    {
        _cookieStorage = cookieStorage;
        if (httpContextAccessor.HttpContext is not null) Initialization(httpContextAccessor.HttpContext.Request.Cookies);
    }

    public static string PageModeKey { get; set; } = "GlobalConfig_PageMode";

    public static string NavigationStyleKey { get; set; } = "GlobalConfig_NavigationStyle";

    public static string ExpandOnHoverCookieKey { get; set; } = "GlobalConfig_ExpandOnHover";

    public static string FavoriteCookieKey { get; set; } = "GlobalConfig_Favorite";

    public EventHandler? NavigationStyleChanged { get; set; }

    public string PageMode
    {
        get => _pageMode ?? PageModes.PageTab;
        set
        {
            _pageMode = value;
            _cookieStorage?.SetItemAsync(PageModeKey, value);
        }
    }

    public string NavigationStyle
    {
        get => _navigationStyle ?? NavigationStyles.Flat;
        set
        {
            _navigationStyle = value;
            NavigationStyleChanged?.Invoke(this, EventArgs.Empty);
            _cookieStorage?.SetItemAsync(NavigationStyleKey, value);
        }
    }

    public bool ExpandOnHover
    {
        get => _expandOnHover;
        set
        {
            _expandOnHover = value;
            _cookieStorage?.SetItemAsync(ExpandOnHoverCookieKey, value);
        }
    }

    public string? Favorite
    {
        get => _favorite;
        set
        {
            _favorite = value;
            _cookieStorage?.SetItemAsync(FavoriteCookieKey, value);
        }
    }

    public void Initialization(IRequestCookieCollection cookies)
    {
        _pageMode = cookies[PageModeKey];
        _navigationStyle = cookies[NavigationStyleKey];
        _expandOnHover = Convert.ToBoolean(cookies[ExpandOnHoverCookieKey]);
        _favorite = cookies[FavoriteCookieKey];
    }
}

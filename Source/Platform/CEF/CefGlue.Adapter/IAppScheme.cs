namespace CefGlue.Adapter;
public interface IAppScheme
{
    void OnRegisterCustomSchemes(CefSchemeRegistrar registrar);
}

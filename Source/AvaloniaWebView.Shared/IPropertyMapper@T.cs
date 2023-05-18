using System.ComponentModel;

namespace AvaloniaWebView.Shared;
public interface IPropertyMapper<TVirtualView, TViewHandler> : IPropertyMapper where TVirtualView : INotifyPropertyChanged
{
    void Add(string key, Action<TViewHandler, TVirtualView> action);
    Action<TViewHandler, TVirtualView>? GetProperty(string key);
    void UpdateProperties(TViewHandler elementHandler, TVirtualView virtualView);
    void UpdateProperty(TViewHandler elementHandler, TVirtualView virtualView, string key);
}

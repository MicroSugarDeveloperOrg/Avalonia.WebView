using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AvaloniaWebView.Shared.Core;
public abstract class PropertyMapper<TVirtualView, TViewHandler> : IPropertyMapper<TVirtualView, TViewHandler> where TVirtualView : INotifyPropertyChanged
{
    void IPropertyMapper<TVirtualView, TViewHandler>.Add(string key, Action<TViewHandler, TVirtualView> action)
    {
        throw new NotImplementedException();
    }

    IEnumerable<string> IPropertyMapper.GetKeys()
    {
        throw new NotImplementedException();
    }

    Action<TViewHandler, TVirtualView>? IPropertyMapper<TVirtualView, TViewHandler>.GetProperty(string key)
    {
        throw new NotImplementedException();
    }

    void IPropertyMapper<TVirtualView, TViewHandler>.UpdateProperties(TViewHandler elementHandler, TVirtualView virtualView)
    {
        throw new NotImplementedException();
    }

    void IPropertyMapper<TVirtualView, TViewHandler>.UpdateProperty(TViewHandler elementHandler, TVirtualView virtualView, string key)
    {
        throw new NotImplementedException();
    }
}

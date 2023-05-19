using Microsoft.AspNetCore.Components.Web;
using System.Collections.ObjectModel;

namespace Microsoft.AspNetCore.Components.WebView.Wpf;
public class RootComponentsCollection : ObservableCollection<RootComponent>, IJSComponentConfiguration
{
    /// <inheritdoc />
    public JSComponentConfigurationStore JSComponents { get; } = new();
}
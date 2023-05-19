namespace AvaloniaBlazorWebView.Components;

public class BlazorRootComponentsCollection : ObservableCollection<BlazorRootComponent>
{
    public BlazorRootComponentsCollection()
    {

    }

    public void Add<TComponent>(string selector) where TComponent : IComponent
    {
        BlazorRootComponent component = new()
        {
            ComponentType = typeof(TComponent),
            Selector = selector
        };

        Add(component);
    }

}
using DryIoc;
using DryIoc.Shared.Extensions;

namespace WebViewCore.Ioc;
public class WebViewLocator
{
    static WebViewLocator()
    {
        __dryIocContainer = new Lazy<Container>(() => new Container(RulesExtensions.DefaultRules));
    }

    readonly static Lazy<Container> __dryIocContainer;

    public static IRegistrator s_Registrator => __dryIocContainer.Value;
    public static IResolverContext s_ResolverContext => __dryIocContainer.Value;
}

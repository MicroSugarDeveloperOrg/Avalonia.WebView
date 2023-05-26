using ObjCRuntime;

namespace Foundation;

internal abstract class NSDispatcher : NSObject
{
    public const string SelectorName = "xamarinApplySelector";

    public static readonly Selector Selector = new Selector("xamarinApplySelector");

    protected NSDispatcher()
    {
        base.IsDirectBinding = false;
    }

    [Export("xamarinApplySelector")]
    [Preserve(Conditional = true)]
    public abstract void Apply();
}

namespace Foundation;


[Register("__MonoMac_NSAsyncSynchronizationContextDispatcher")]
internal sealed class NSAsyncSynchronizationContextDispatcher : NSAsyncDispatcher
{
    private SendOrPostCallback d;

    private object state;

    public NSAsyncSynchronizationContextDispatcher(SendOrPostCallback d, object state)
    {
        if (d == null)
        {
            throw new ArgumentNullException("d");
        }
        this.d = d;
        this.state = state;
    }

    public override void Apply()
    {
        try
        {
            d(state);
        }
        finally
        {
            d = null;
            state = null;
            base.Apply();
        }
    }
}

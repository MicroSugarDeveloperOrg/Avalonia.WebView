using ObjCRuntime;

namespace Foundation;
internal sealed class NSCodingWrapper : BaseWrapper, INSCoding, INativeObject, IDisposable
{
    [Preserve(Conditional = true)]
    public NSCodingWrapper(IntPtr handle, bool owns)
        : base(handle, owns)
    {
    }

    [Export("encodeWithCoder:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public void EncodeTo(NSCoder encoder)
    {
        if (encoder == null)
        {
            throw new ArgumentNullException("encoder");
        }
        Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("encodeWithCoder:"), encoder.Handle);
    }
}
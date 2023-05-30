using Foundation;
using ObjCRuntime;

namespace WebKit;

internal sealed class WebDocumentRepresentationWrapper : BaseWrapper, IWebDocumentRepresentation 
{
    public bool CanProvideDocumentSource
    {
        [Export("canProvideDocumentSource")]
        get
        {
            return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("canProvideDocumentSource"));
        }
    }

    public string DocumentSource
    {
        [Export("documentSource")]
        get
        {
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("documentSource")));
        }
    }

    public string Title
    {
        [Export("title")]
        get
        {
            return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("title")));
        }
    }

    [Preserve(Conditional = false)]
    public WebDocumentRepresentationWrapper(IntPtr handle)
        : base(handle, false)
    {
    }

    [Preserve(Conditional = true)]
    public WebDocumentRepresentationWrapper(IntPtr handle, bool owns)
    : base(handle, owns)
    {
    }

    [Export("setDataSource:")]
    public void SetDataSource(WebDataSource dataSource)
    {
        if (dataSource == null)
        {
            throw new ArgumentNullException("dataSource");
        }
        Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setDataSource:"), dataSource.Handle);
    }

    [Export("receivedData:withDataSource:")]
    public void ReceivedData(NSData data, WebDataSource dataSource)
    {
        if (data == null)
        {
            throw new ArgumentNullException("data");
        }
        if (dataSource == null)
        {
            throw new ArgumentNullException("dataSource");
        }
        Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("receivedData:withDataSource:"), data.Handle, dataSource.Handle);
    }

    [Export("receivedError:withDataSource:")]
    public void ReceivedError(NSError error, WebDataSource dataSource)
    {
        if (error == null)
        {
            throw new ArgumentNullException("error");
        }
        if (dataSource == null)
        {
            throw new ArgumentNullException("dataSource");
        }
        Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("receivedError:withDataSource:"), error.Handle, dataSource.Handle);
    }

    [Export("finishedLoadingWithDataSource:")]
    public void FinishedLoading(WebDataSource dataSource)
    {
        if (dataSource == null)
        {
            throw new ArgumentNullException("dataSource");
        }
        Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("finishedLoadingWithDataSource:"), dataSource.Handle);
    }
}

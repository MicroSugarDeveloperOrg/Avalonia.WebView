using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WebDocumentRepresentation", true)]
[Model]
public abstract class WebDocumentRepresentation : NSObject
{
	public abstract bool CanProvideDocumentSource
	{
		[Export("canProvideDocumentSource")]
		get;
	}

	public abstract string DocumentSource
	{
		[Export("documentSource")]
		get;
	}

	public abstract string Title
	{
		[Export("title")]
		get;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WebDocumentRepresentation()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public WebDocumentRepresentation(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public WebDocumentRepresentation(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public WebDocumentRepresentation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("setDataSource:")]
	public abstract void SetDataSource(WebDataSource dataSource);

	[Export("receivedData:withDataSource:")]
	public abstract void ReceivedData(NSData data, WebDataSource dataSource);

	[Export("receivedError:withDataSource:")]
	public abstract void ReceivedError(NSError error, WebDataSource dataSource);

	[Export("finishedLoadingWithDataSource:")]
	public abstract void FinishedLoading(WebDataSource dataSource);
}

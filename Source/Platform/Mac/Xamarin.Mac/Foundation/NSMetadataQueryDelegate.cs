using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSMetadataQueryDelegate", true)]
[Model]
public class NSMetadataQueryDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMetadataQueryDelegate()
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
	public NSMetadataQueryDelegate(NSCoder coder)
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
	public NSMetadataQueryDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMetadataQueryDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("metadataQuery:replacementObjectForResultObject:")]
	public virtual NSObject ReplacementObjectForResultObject(NSMetadataQuery query, NSMetadataItem result)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("metadataQuery:replacementValueForAttribute:value:")]
	public virtual NSObject ReplacementValueForAttributevalue(NSMetadataQuery query, string attributeName, NSObject value)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

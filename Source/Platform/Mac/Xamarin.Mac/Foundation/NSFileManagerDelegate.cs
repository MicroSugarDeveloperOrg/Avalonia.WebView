using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSFileManagerDelegate", true)]
[Model]
public class NSFileManagerDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSFileManagerDelegate()
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
	public NSFileManagerDelegate(NSCoder coder)
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
	public NSFileManagerDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSFileManagerDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("fileManager:shouldCopyItemAtPath:toPath:")]
	public virtual bool ShouldCopyItemAtPath(NSFileManager fm, NSString srcPath, NSString dstPath)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("fileManager:shouldProceedAfterError:")]
	public virtual bool ShouldProceedAfterError(NSFileManager fm, NSDictionary errorInfo)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("fileManager:shouldCopyItemAtPath:toPath:")]
	public virtual bool ShouldCopyItemAtPath(NSFileManager fileManager, string srcPath, string dstPath)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("fileManager:shouldProceedAfterError:copyingItemAtPath:toPath:")]
	public virtual bool ShouldProceedAfterErrorCopyingItem(NSFileManager fileManager, NSError error, string srcPath, string dstPath)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("fileManager:shouldMoveItemAtPath:toPath:")]
	public virtual bool ShouldMoveItemAtPath(NSFileManager fileManager, string srcPath, string dstPath)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("fileManager:shouldProceedAfterError:movingItemAtPath:toPath:")]
	public virtual bool ShouldProceedAfterErrorMovingItem(NSFileManager fileManager, NSError error, string srcPath, string dstPath)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("fileManager:shouldLinkItemAtPath:toPath:")]
	public virtual bool ShouldLinkItemAtPath(NSFileManager fileManager, string srcPath, string dstPath)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("fileManager:shouldProceedAfterError:linkingItemAtPath:toPath:")]
	public virtual bool ShouldProceedAfterErrorLinkingItem(NSFileManager fileManager, NSError error, string srcPath, string dstPath)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("fileManager:shouldRemoveItemAtPath:")]
	public virtual bool ShouldRemoveItemAtPath(NSFileManager fileManager, string path)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("fileManager:shouldProceedAfterError:removingItemAtPath:")]
	public virtual bool ShouldProceedAfterErrorRemovingItem(NSFileManager fileManager, NSError error, string path)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

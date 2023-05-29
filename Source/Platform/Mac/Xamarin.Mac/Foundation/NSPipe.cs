using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSPipe", true)]
public class NSPipe : NSObject
{
	private static readonly IntPtr selFileHandleForReadingHandle = Selector.GetHandle("fileHandleForReading");

	private static readonly IntPtr selFileHandleForWritingHandle = Selector.GetHandle("fileHandleForWriting");

	private static readonly IntPtr selPipeHandle = Selector.GetHandle("pipe");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSPipe");

	private object __mt_ReadHandle_var;

	private object __mt_WriteHandle_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSFileHandle ReadHandle
	{
		[Export("fileHandleForReading")]
		get
		{
			return (NSFileHandle)(__mt_ReadHandle_var = ((!IsDirectBinding) ? ((NSFileHandle)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileHandleForReadingHandle))) : ((NSFileHandle)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFileHandleForReadingHandle)))));
		}
	}

	public virtual NSFileHandle WriteHandle
	{
		[Export("fileHandleForWriting")]
		get
		{
			return (NSFileHandle)(__mt_WriteHandle_var = ((!IsDirectBinding) ? ((NSFileHandle)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileHandleForWritingHandle))) : ((NSFileHandle)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFileHandleForWritingHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPipe()
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
	public NSPipe(NSCoder coder)
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
	public NSPipe(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPipe(IntPtr handle)
		: base(handle)
	{
	}

	[Export("pipe")]
	public static NSPipe Create()
	{
		return (NSPipe)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selPipeHandle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ReadHandle_var = null;
			__mt_WriteHandle_var = null;
		}
	}
}

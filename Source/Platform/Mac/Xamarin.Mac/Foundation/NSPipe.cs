using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSPipe", true)]
public class NSPipe : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileHandleForReading = "fileHandleForReading";

	private static readonly IntPtr selFileHandleForReadingHandle = Selector.GetHandle("fileHandleForReading");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileHandleForWriting = "fileHandleForWriting";

	private static readonly IntPtr selFileHandleForWritingHandle = Selector.GetHandle("fileHandleForWriting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPipe = "pipe";

	private static readonly IntPtr selPipeHandle = Selector.GetHandle("pipe");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPipe");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFileHandle ReadHandle
	{
		[Export("fileHandleForReading")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSFileHandle>(Messaging.IntPtr_objc_msgSend(base.Handle, selFileHandleForReadingHandle));
			}
			return Runtime.GetNSObject<NSFileHandle>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileHandleForReadingHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFileHandle WriteHandle
	{
		[Export("fileHandleForWriting")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSFileHandle>(Messaging.IntPtr_objc_msgSend(base.Handle, selFileHandleForWritingHandle));
			}
			return Runtime.GetNSObject<NSFileHandle>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileHandleForWritingHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPipe()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSPipe(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPipe(IntPtr handle)
		: base(handle)
	{
	}

	[Export("pipe")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPipe Create()
	{
		return Runtime.GetNSObject<NSPipe>(Messaging.IntPtr_objc_msgSend(class_ptr, selPipeHandle));
	}
}

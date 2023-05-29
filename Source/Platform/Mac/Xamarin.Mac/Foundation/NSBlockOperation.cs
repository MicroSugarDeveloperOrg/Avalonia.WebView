using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSBlockOperation", true)]
public class NSBlockOperation : NSOperation
{
	private static readonly IntPtr selExecutionBlocksHandle = Selector.GetHandle("executionBlocks");

	private static readonly IntPtr selBlockOperationWithBlock_Handle = Selector.GetHandle("blockOperationWithBlock:");

	private static readonly IntPtr selAddExecutionBlock_Handle = Selector.GetHandle("addExecutionBlock:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSBlockOperation");

	private object __mt_ExecutionBlocks_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSObject[] ExecutionBlocks
	{
		[Export("executionBlocks")]
		get
		{
			return (NSObject[])(__mt_ExecutionBlocks_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExecutionBlocksHandle)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selExecutionBlocksHandle))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSBlockOperation()
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
	public NSBlockOperation(NSCoder coder)
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
	public NSBlockOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSBlockOperation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("blockOperationWithBlock:")]
	public unsafe static NSBlockOperation Create(NSAction method)
	{
		if (method == null)
		{
			throw new ArgumentNullException("method");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSAction.Handler, method);
		NSBlockOperation result = (NSBlockOperation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selBlockOperationWithBlock_Handle, (IntPtr)ptr));
		ptr->CleanupBlock();
		return result;
	}

	[Export("addExecutionBlock:")]
	public unsafe virtual void AddExecutionBlock(NSAction method)
	{
		if (method == null)
		{
			throw new ArgumentNullException("method");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSAction.Handler, method);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddExecutionBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddExecutionBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ExecutionBlocks_var = null;
		}
	}
}

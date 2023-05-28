using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSBlockOperation", true)]
public class NSBlockOperation : NSOperation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddExecutionBlock_ = "addExecutionBlock:";

	private static readonly IntPtr selAddExecutionBlock_Handle = Selector.GetHandle("addExecutionBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBlockOperationWithBlock_ = "blockOperationWithBlock:";

	private static readonly IntPtr selBlockOperationWithBlock_Handle = Selector.GetHandle("blockOperationWithBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExecutionBlocks = "executionBlocks";

	private static readonly IntPtr selExecutionBlocksHandle = Selector.GetHandle("executionBlocks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSBlockOperation");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] ExecutionBlocks
	{
		[Export("executionBlocks")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selExecutionBlocksHandle));
			}
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExecutionBlocksHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSBlockOperation()
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
	protected NSBlockOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSBlockOperation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addExecutionBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void AddExecutionBlock([BlockProxy(typeof(Trampolines.NIDAction))] Action method)
	{
		if (method == null)
		{
			throw new ArgumentNullException("method");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, method);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddExecutionBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddExecutionBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("blockOperationWithBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static NSBlockOperation Create([BlockProxy(typeof(Trampolines.NIDAction))] Action method)
	{
		if (method == null)
		{
			throw new ArgumentNullException("method");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, method);
		NSBlockOperation nSObject = Runtime.GetNSObject<NSBlockOperation>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selBlockOperationWithBlock_Handle, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
	}
}

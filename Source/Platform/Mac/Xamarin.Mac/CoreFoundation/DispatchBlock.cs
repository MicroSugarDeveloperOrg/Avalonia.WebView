using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CoreFoundation;

[iOS(8, 0)]
[Mac(10, 10)]
public sealed class DispatchBlock : NativeObject
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void DispatchBlockCallback(IntPtr block);

	public bool Cancelled => TestCancel() != 0;

	internal DispatchBlock(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	public DispatchBlock(Action action, DispatchBlockFlags flags = DispatchBlockFlags.None)
		: base(create(action, flags), owns: true)
	{
	}

	public DispatchBlock(Action action, DispatchBlockFlags flags, DispatchQualityOfService qosClass, int relative_priority)
		: base(create(flags, qosClass, relative_priority, action), owns: true)
	{
	}

	public DispatchBlock(DispatchBlock dispatchBlock, DispatchBlockFlags flags, DispatchQualityOfService qosClass, int relative_priority)
		: base(dispatch_block_create_with_qos_class((nuint)(ulong)flags, qosClass, relative_priority, Runtime.ThrowOnNull(dispatchBlock, "dispatchBlock").GetCheckedHandle()), owns: true)
	{
	}

	public static DispatchBlock Create(Action action, DispatchBlockFlags flags = DispatchBlockFlags.None)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		return new DispatchBlock(action, flags);
	}

	public static DispatchBlock Create(Action action, DispatchBlockFlags flags, DispatchQualityOfService qosClass, int relative_priority)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		return new DispatchBlock(action, flags, qosClass, relative_priority);
	}

	public static DispatchBlock Create(DispatchBlock block, DispatchBlockFlags flags, DispatchQualityOfService qosClass, int relative_priority)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		return block.Create(flags, qosClass, relative_priority);
	}

	public DispatchBlock Create(DispatchBlockFlags flags, DispatchQualityOfService qosClass, int relative_priority)
	{
		return new DispatchBlock(dispatch_block_create_with_qos_class((nuint)(ulong)flags, qosClass, relative_priority, GetCheckedHandle()), owns: true);
	}

	protected override void Retain()
	{
		base.Handle = BlockLiteral._Block_copy(GetCheckedHandle());
	}

	protected override void Release()
	{
		BlockLiteral._Block_release(GetCheckedHandle());
	}

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_block_create(nuint flags, ref BlockLiteral block);

	[BindingImpl(BindingImplOptions.Optimizable)]
	private static IntPtr create(Action action, DispatchBlockFlags flags)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		BlockLiteral block = default(BlockLiteral);
		try
		{
			block.SetupBlockUnsafe(BlockStaticDispatchClass.static_dispatch_block, action);
			return dispatch_block_create((nuint)(ulong)flags, ref block);
		}
		finally
		{
			block.CleanupBlock();
		}
	}

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_block_create_with_qos_class(nuint flags, DispatchQualityOfService qosClass, int relative_priority, ref BlockLiteral dispatchBlock);

	[DllImport("/usr/lib/libc.dylib")]
	private static extern IntPtr dispatch_block_create_with_qos_class(nuint flags, DispatchQualityOfService qosClass, int relative_priority, IntPtr dispatchBlock);

	[BindingImpl(BindingImplOptions.Optimizable)]
	private static IntPtr create(DispatchBlockFlags flags, DispatchQualityOfService qosClass, int relative_priority, Action action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		BlockLiteral dispatchBlock = default(BlockLiteral);
		try
		{
			dispatchBlock.SetupBlockUnsafe(BlockStaticDispatchClass.static_dispatch_block, action);
			return dispatch_block_create_with_qos_class((nuint)(ulong)flags, qosClass, relative_priority, ref dispatchBlock);
		}
		finally
		{
			dispatchBlock.CleanupBlock();
		}
	}

	[DllImport("/usr/lib/libc.dylib")]
	private static extern void dispatch_block_cancel(IntPtr block);

	public void Cancel()
	{
		dispatch_block_cancel(GetCheckedHandle());
	}

	[DllImport("/usr/lib/libc.dylib")]
	private static extern void dispatch_block_notify(IntPtr block, IntPtr queue, IntPtr notification);

	public void Notify(DispatchQueue queue, Action notification)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		using DispatchBlock notification2 = new DispatchBlock(notification, DispatchBlockFlags.None);
		Notify(queue, notification2);
	}

	public void Notify(DispatchQueue queue, DispatchBlock notification)
	{
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		dispatch_block_notify(GetCheckedHandle(), queue.GetCheckedHandle(), notification.GetCheckedHandle());
	}

	[DllImport("/usr/lib/libc.dylib")]
	private static extern nint dispatch_block_testcancel(IntPtr block);

	public nint TestCancel()
	{
		return dispatch_block_testcancel(GetCheckedHandle());
	}

	[DllImport("/usr/lib/libc.dylib")]
	private static extern nint dispatch_block_wait(IntPtr block, DispatchTime time);

	public nint Wait(DispatchTime time)
	{
		return dispatch_block_wait(GetCheckedHandle(), time);
	}

	public nint Wait(TimeSpan timeout)
	{
		return Wait(new DispatchTime(DispatchTime.Now, timeout));
	}

	public unsafe static explicit operator Action(DispatchBlock block)
	{
		if (block == null)
		{
			return null;
		}
		BlockLiteral* ptr = (BlockLiteral*)(void*)block.GetCheckedHandle();
		DispatchBlockCallback del = ptr->GetDelegateForBlock<DispatchBlockCallback>();
		return delegate
		{
			del(block.GetCheckedHandle());
		};
	}

	public void Invoke()
	{
		((Action)this)();
	}

	[BindingImpl(BindingImplOptions.Optimizable)]
	internal unsafe static void Invoke(Action codeToRun, Action<IntPtr> invoker)
	{
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, codeToRun);
		invoker((IntPtr)ptr);
		ptr->CleanupBlock();
	}
}

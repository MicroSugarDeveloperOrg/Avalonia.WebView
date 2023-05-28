using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

public class DispatchIO : DispatchObject
{
	private delegate void DispatchReadWrite(IntPtr block, IntPtr dispatchData, int error);

	private static DispatchReadWrite static_DispatchReadWriteHandler = Trampoline_DispatchReadWriteHandler;

	[Preserve(Conditional = true)]
	internal DispatchIO(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Preserve(Conditional = true)]
	internal DispatchIO(IntPtr handle)
		: this(handle, owns: false)
	{
	}

	[MonoPInvokeCallback(typeof(DispatchReadWrite))]
	private static void Trampoline_DispatchReadWriteHandler(IntPtr block, IntPtr dispatchData, int error)
	{
		DispatchIOHandler target = BlockLiteral.GetTarget<DispatchIOHandler>(block);
		if (target != null)
		{
			DispatchData data = ((dispatchData == IntPtr.Zero) ? null : new DispatchData(dispatchData, owns: false));
			target(data, error);
		}
	}

	[DllImport("/usr/lib/libc.dylib")]
	private static extern void dispatch_read(int fd, nuint length, IntPtr dispatchQueue, ref BlockLiteral block);

	[BindingImpl(BindingImplOptions.Optimizable)]
	public static void Read(int fd, nuint size, DispatchQueue dispatchQueue, DispatchIOHandler handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		if (dispatchQueue == null)
		{
			throw new ArgumentNullException("dispatchQueue");
		}
		BlockLiteral block = default(BlockLiteral);
		block.SetupBlockUnsafe(static_DispatchReadWriteHandler, handler);
		dispatch_read(fd, size, dispatchQueue.Handle, ref block);
		block.CleanupBlock();
	}

	[DllImport("/usr/lib/libc.dylib")]
	private static extern void dispatch_write(int fd, IntPtr dispatchData, IntPtr dispatchQueue, ref BlockLiteral handler);

	[BindingImpl(BindingImplOptions.Optimizable)]
	public static void Write(int fd, DispatchData dispatchData, DispatchQueue dispatchQueue, DispatchIOHandler handler)
	{
		if (dispatchData == null)
		{
			throw new ArgumentNullException("dispatchData");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		if (dispatchQueue == null)
		{
			throw new ArgumentNullException("dispatchQueue");
		}
		BlockLiteral handler2 = default(BlockLiteral);
		handler2.SetupBlockUnsafe(static_DispatchReadWriteHandler, handler);
		dispatch_write(fd, dispatchData.Handle, dispatchQueue.Handle, ref handler2);
		handler2.CleanupBlock();
	}
}

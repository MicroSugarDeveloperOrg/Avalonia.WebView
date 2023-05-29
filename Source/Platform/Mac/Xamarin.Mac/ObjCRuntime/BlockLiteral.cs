using System;
using System.Runtime.InteropServices;

namespace ObjCRuntime;

public struct BlockLiteral
{
	public IntPtr isa;

	public BlockFlags flags;

	public int reserved;

	public IntPtr invoke;

	public IntPtr block_descriptor;

	public IntPtr local_handle;

	public IntPtr global_handle;

	internal static IntPtr block_class;

	internal static BlockDescriptor global_descriptor;

	internal static IntPtr global_descriptor_ptr;

	static BlockLiteral()
	{
		block_class = Class.GetHandle("__NSStackBlock");
		global_descriptor = BlockDescriptor.CreateDescriptor();
		global_descriptor_ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(IntPtr)) * 2 + Marshal.SizeOf(typeof(IntPtr)) * 2);
		Marshal.StructureToPtr(global_descriptor, global_descriptor_ptr, fDeleteOld: false);
	}

	public void SetupBlock(Delegate trampoline, Delegate userDelegate)
	{
		isa = block_class;
		invoke = Marshal.GetFunctionPointerForDelegate(trampoline);
		local_handle = (IntPtr)GCHandle.Alloc(userDelegate);
		global_handle = IntPtr.Zero;
		flags = BlockFlags.BLOCK_HAS_COPY_DISPOSE | BlockFlags.BLOCK_HAS_DESCRIPTOR;
		block_descriptor = global_descriptor_ptr;
	}

	public void CleanupBlock()
	{
		GCHandle.FromIntPtr(local_handle).Free();
	}
}

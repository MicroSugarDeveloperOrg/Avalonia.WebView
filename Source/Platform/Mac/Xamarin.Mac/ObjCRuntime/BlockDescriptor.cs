using System;
using System.Runtime.InteropServices;

namespace ObjCRuntime;

public struct BlockDescriptor
{
	private unsafe delegate void CopyHelperDelegate(BlockLiteral* dest, BlockLiteral* src);

	private unsafe delegate void DisposeHelperDelegate(BlockLiteral* block);

	public IntPtr reserved;

	public IntPtr size;

	public IntPtr copy_helper;

	public IntPtr dispose;

    public IntPtr signature;

    private unsafe static CopyHelperDelegate copy_helper_delegate = CopyHelper;

	private unsafe static DisposeHelperDelegate dispose_helper_delegate = DisposeHelper;

	private static IntPtr copy_helper_ptr = Marshal.GetFunctionPointerForDelegate(copy_helper_delegate);

	private static IntPtr dispose_helper_ptr = Marshal.GetFunctionPointerForDelegate(dispose_helper_delegate);

	[MonoPInvokeCallback(typeof(CopyHelperDelegate))]
	private unsafe static void CopyHelper(BlockLiteral* dest, BlockLiteral* source)
	{
		dest->global_handle = (IntPtr)GCHandle.Alloc(GCHandle.FromIntPtr(dest->local_handle).Target);
	}

	[MonoPInvokeCallback(typeof(DisposeHelperDelegate))]
	private unsafe static void DisposeHelper(BlockLiteral* block)
	{
		GCHandle.FromIntPtr(block->global_handle).Free();
	}

	internal static BlockDescriptor CreateDescriptor()
	{
		BlockDescriptor result = default(BlockDescriptor);
		result.copy_helper = copy_helper_ptr;
		result.dispose = dispose_helper_ptr;
		result.size = (IntPtr)(Marshal.SizeOf(typeof(IntPtr)) * 5 + Marshal.SizeOf(typeof(int)) * 2);
		return result;
	}
}

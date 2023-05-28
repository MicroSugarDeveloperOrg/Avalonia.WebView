using System.Runtime.InteropServices;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[iOS(11, 3)]
[TV(11, 3)]
[Mac(10, 13, 4)]
public static class MPSStateBatch
{
	[DllImport("/System/Library/Frameworks/MetalPerformanceShaders.framework/MetalPerformanceShaders")]
	private static extern nuint MPSStateBatchIncrementReadCount(IntPtr batch, nint amount);

	public static nuint IncrementReadCount(NSArray<MPSState> stateBatch, nint amount)
	{
		if (stateBatch == null)
		{
			throw new ArgumentNullException("stateBatch");
		}
		return MPSStateBatchIncrementReadCount(stateBatch.Handle, amount);
	}

	[DllImport("/System/Library/Frameworks/MetalPerformanceShaders.framework/MetalPerformanceShaders")]
	private static extern void MPSStateBatchSynchronize(IntPtr batch, IntPtr cmdBuf);

	public static void Synchronize(NSArray<MPSState> stateBatch, IMTLCommandBuffer commandBuffer)
	{
		if (stateBatch == null)
		{
			throw new ArgumentNullException("stateBatch");
		}
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		MPSStateBatchSynchronize(stateBatch.Handle, commandBuffer.Handle);
	}

	[DllImport("/System/Library/Frameworks/MetalPerformanceShaders.framework/MetalPerformanceShaders")]
	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[iOS(12, 0)]
	[TV(12, 0)]
	[Mac(10, 14)]
	private static extern nuint MPSStateBatchResourceSize(IntPtr batch);

	[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
	[iOS(12, 0)]
	[TV(12, 0)]
	[Mac(10, 14)]
	public static nuint GetResourceSize(NSArray<MPSState> stateBatch)
	{
		if (stateBatch == null)
		{
			throw new ArgumentNullException("stateBatch");
		}
		return MPSStateBatchResourceSize(stateBatch.Handle);
	}
}

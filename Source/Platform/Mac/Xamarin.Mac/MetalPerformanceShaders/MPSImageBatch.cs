using System.Runtime.InteropServices;
using Foundation;
using Metal;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

[iOS(11, 3)]
[TV(11, 3)]
[Mac(10, 13, 4)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
public static class MPSImageBatch
{
	[DllImport("/System/Library/Frameworks/MetalPerformanceShaders.framework/MetalPerformanceShaders")]
	private static extern nuint MPSImageBatchIncrementReadCount(IntPtr batch, nint amount);

	public static nuint IncrementReadCount(NSArray<MPSImage> imageBatch, nint amount)
	{
		if (imageBatch == null)
		{
			throw new ArgumentNullException("imageBatch");
		}
		return MPSImageBatchIncrementReadCount(imageBatch.Handle, amount);
	}

	[DllImport("/System/Library/Frameworks/MetalPerformanceShaders.framework/MetalPerformanceShaders")]
	private static extern void MPSImageBatchSynchronize(IntPtr batch, IntPtr cmdBuf);

	public static void Synchronize(NSArray<MPSImage> imageBatch, IMTLCommandBuffer commandBuffer)
	{
		if (imageBatch == null)
		{
			throw new ArgumentNullException("imageBatch");
		}
		if (commandBuffer == null)
		{
			throw new ArgumentNullException("commandBuffer");
		}
		MPSImageBatchSynchronize(imageBatch.Handle, commandBuffer.Handle);
	}

	[DllImport("/System/Library/Frameworks/MetalPerformanceShaders.framework/MetalPerformanceShaders")]
	[iOS(12, 0)]
	[TV(12, 0)]
	[Mac(10, 14)]
	private static extern nuint MPSImageBatchResourceSize(IntPtr batch);

	[iOS(12, 0)]
	[TV(12, 0)]
	[Mac(10, 14)]
	public static nuint GetResourceSize(NSArray<MPSImage> imageBatch)
	{
		if (imageBatch == null)
		{
			throw new ArgumentNullException("imageBatch");
		}
		return MPSImageBatchResourceSize(imageBatch.Handle);
	}
}

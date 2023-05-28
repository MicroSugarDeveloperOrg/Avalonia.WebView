using Foundation;

namespace MetalPerformanceShaders;

public delegate NSObject MPSCopyAllocator(MPSKernel filter, NSObject commandBuffer, NSObject sourceTexture);

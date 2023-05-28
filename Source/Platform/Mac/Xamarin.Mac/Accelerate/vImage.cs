using System.Runtime.InteropServices;
using Xamarin.Mac.System.Mac;

namespace Accelerate;

public static class vImage
{
	[DllImport("/System/Library/Frameworks/Accelerate.framework/Frameworks/vImage.framework/vImage")]
	private unsafe static extern nint vImageConvolve_Planar8(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, short* kernel, uint kernel_height, uint kernel_width, int divisor, byte backgroundColor, vImageFlags flags);

	public unsafe static vImageError ConvolvePlanar8(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, short* kernel, uint kernel_height, uint kernel_width, int divisor, byte backgroundColor, vImageFlags flags)
	{
		return (vImageError)(long)vImageConvolve_Planar8(ref src, ref dest, tempBuffer, srcOffsetToROI_X, srcOffsetToROI_Y, kernel, kernel_height, kernel_width, divisor, backgroundColor, flags);
	}

	[DllImport("/System/Library/Frameworks/Accelerate.framework/Frameworks/vImage.framework/vImage")]
	private unsafe static extern nint vImageConvolve_PlanarF(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, float* kernel, uint kernel_height, uint kernel_width, float backgroundColor, vImageFlags flags);

	public unsafe static vImageError ConvolvePlanarF(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, float* kernel, uint kernel_height, uint kernel_width, float backgroundColor, vImageFlags flags)
	{
		return (vImageError)(long)vImageConvolve_PlanarF(ref src, ref dest, tempBuffer, srcOffsetToROI_X, srcOffsetToROI_Y, kernel, kernel_height, kernel_width, backgroundColor, flags);
	}

	[DllImport("/System/Library/Frameworks/Accelerate.framework/Frameworks/vImage.framework/vImage")]
	private unsafe static extern nint vImageConvolve_ARGB8888(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, short* kernel, uint kernel_height, uint kernel_width, int divisor, Pixel8888* backgroundColor, vImageFlags flags);

	public unsafe static vImageError ConvolveARGB8888(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, short* kernel, uint kernel_height, uint kernel_width, int divisor, Pixel8888* backgroundColor, vImageFlags flags)
	{
		return (vImageError)(long)vImageConvolve_ARGB8888(ref src, ref dest, tempBuffer, srcOffsetToROI_X, srcOffsetToROI_Y, kernel, kernel_height, kernel_width, divisor, backgroundColor, flags);
	}

	[DllImport("/System/Library/Frameworks/Accelerate.framework/Frameworks/vImage.framework/vImage")]
	private unsafe static extern nint vImageConvolve_ARGBFFFF(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, float* kernel, uint kernel_height, uint kernel_width, PixelFFFF backgroundColor, vImageFlags flags);

	public unsafe static vImageError ConvolveARGBFFFF(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, float* kernel, uint kernel_height, uint kernel_width, PixelFFFF backgroundColor, vImageFlags flags)
	{
		return (vImageError)(long)vImageConvolve_ARGBFFFF(ref src, ref dest, tempBuffer, srcOffsetToROI_X, srcOffsetToROI_Y, kernel, kernel_height, kernel_width, backgroundColor, flags);
	}

	[DllImport("/System/Library/Frameworks/Accelerate.framework/Frameworks/vImage.framework/vImage")]
	private unsafe static extern nint vImageConvolveWithBias_Planar8(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, short* kernel, uint kernel_height, uint kernel_width, int divisor, int bias, byte backgroundColor, vImageFlags flags);

	public unsafe static vImageError ConvolveWithBiasPlanar8(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, short* kernel, uint kernel_height, uint kernel_width, int divisor, int bias, byte backgroundColor, vImageFlags flags)
	{
		return (vImageError)(long)vImageConvolveWithBias_Planar8(ref src, ref dest, tempBuffer, srcOffsetToROI_X, srcOffsetToROI_Y, kernel, kernel_width, kernel_height, divisor, bias, backgroundColor, flags);
	}

	[DllImport("/System/Library/Frameworks/Accelerate.framework/Frameworks/vImage.framework/vImage")]
	private unsafe static extern nint vImageConvolveWithBias_PlanarF(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, float* kernel, uint kernel_height, uint kernel_width, float bias, float backgroundColor, vImageFlags flags);

	public unsafe static vImageError ConvolveWithBiasPlanarF(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, float* kernel, uint kernel_height, uint kernel_width, float bias, float backgroundColor, vImageFlags flags)
	{
		return (vImageError)(long)vImageConvolveWithBias_PlanarF(ref src, ref dest, tempBuffer, srcOffsetToROI_X, srcOffsetToROI_Y, kernel, kernel_height, kernel_width, bias, backgroundColor, flags);
	}

	[DllImport("/System/Library/Frameworks/Accelerate.framework/Frameworks/vImage.framework/vImage")]
	private unsafe static extern nint vImageConvolveWithBias_ARGB8888(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, short* kernel, uint kernel_height, uint kernel_width, int divisor, int bias, Pixel8888 backgroundColor, vImageFlags flags);

	public unsafe static vImageError ConvolveWithBiasARGB8888(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, short* kernel, uint kernel_height, uint kernel_width, int divisor, int bias, Pixel8888 backgroundColor, vImageFlags flags)
	{
		return (vImageError)(long)vImageConvolveWithBias_ARGB8888(ref src, ref dest, tempBuffer, srcOffsetToROI_X, srcOffsetToROI_Y, kernel, kernel_height, kernel_width, divisor, bias, backgroundColor, flags);
	}

	[DllImport("/System/Library/Frameworks/Accelerate.framework/Frameworks/vImage.framework/vImage")]
	private unsafe static extern nint vImageConvolveWithBias_ARGBFFFF(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, float* kernel, uint kernel_height, uint kernel_width, float bias, PixelFFFF backgroundColor, vImageFlags flags);

	public unsafe static vImageError ConvolveWithBiasARGBFFFF(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, float* kernel, uint kernel_height, uint kernel_width, float bias, PixelFFFF backgroundColor, vImageFlags flags)
	{
		return (vImageError)(long)vImageConvolveWithBias_ARGBFFFF(ref src, ref dest, tempBuffer, srcOffsetToROI_X, srcOffsetToROI_Y, kernel, kernel_height, kernel_width, bias, backgroundColor, flags);
	}

	[DllImport("/System/Library/Frameworks/Accelerate.framework/Frameworks/vImage.framework/vImage")]
	private unsafe static extern nint vImageConvolveMultiKernel_ARGB8888(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, short*[] kernels, uint kernel_height, uint kernel_width, int[] divisors, int[] biases, Pixel8888 backgroundColor, vImageFlags flags);

	public unsafe static vImageError ConvolveMultiKernelARGB8888(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, short[][] kernels, uint kernel_height, uint kernel_width, int[] divisors, int[] biases, Pixel8888 backgroundColor, vImageFlags flags)
	{
		if (kernels == null)
		{
			throw new ArgumentNullException("kernels");
		}
		if (divisors == null)
		{
			throw new ArgumentNullException("divisors");
		}
		if (biases == null)
		{
			throw new ArgumentNullException("biases");
		}
		if (kernels.Length < 4)
		{
			throw new ArgumentException("Must contain at least four elements", "kernels");
		}
		if (divisors.Length < 4)
		{
			throw new ArgumentException("Must contain at least four elements", "divisors");
		}
		if (biases.Length < 4)
		{
			throw new ArgumentException("Must contain at least four elements", "biases");
		}
		fixed (short* ptr = kernels[0])
		{
			fixed (short* ptr2 = kernels[1])
			{
				fixed (short* ptr3 = kernels[2])
				{
					fixed (short* ptr4 = kernels[3])
					{
						return (vImageError)(long)vImageConvolveMultiKernel_ARGB8888(ref src, ref dest, tempBuffer, srcOffsetToROI_X, srcOffsetToROI_Y, new short*[4] { ptr, ptr2, ptr3, ptr4 }, kernel_height, kernel_width, divisors, biases, backgroundColor, flags);
					}
				}
			}
		}
	}

	[DllImport("/System/Library/Frameworks/Accelerate.framework/Frameworks/vImage.framework/vImage")]
	private unsafe static extern nint vImageConvolveMultiKernel_ARGBFFFF(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, float*[] kernels, uint kernel_height, uint kernel_width, float[] biases, PixelFFFF backgroundColor, vImageFlags flags);

	public unsafe static vImageError ConvolveMultiKernelARGBFFFF(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, float[][] kernels, uint kernel_height, uint kernel_width, float[] biases, PixelFFFF backgroundColor, vImageFlags flags)
	{
		if (kernels == null)
		{
			throw new ArgumentNullException("kernels");
		}
		if (biases == null)
		{
			throw new ArgumentNullException("biases");
		}
		if (kernels.Length < 4)
		{
			throw new ArgumentException("Must contain at least four elements", "kernels");
		}
		if (biases.Length < 4)
		{
			throw new ArgumentException("Must contain at least four elements", "biases");
		}
		fixed (float* ptr = kernels[0])
		{
			fixed (float* ptr2 = kernels[1])
			{
				fixed (float* ptr3 = kernels[2])
				{
					fixed (float* ptr4 = kernels[3])
					{
						return (vImageError)(long)vImageConvolveMultiKernel_ARGBFFFF(ref src, ref dest, tempBuffer, srcOffsetToROI_X, srcOffsetToROI_Y, new float*[4] { ptr, ptr2, ptr3, ptr4 }, kernel_height, kernel_width, biases, backgroundColor, flags);
					}
				}
			}
		}
	}

	[DllImport("/System/Library/Frameworks/Accelerate.framework/Frameworks/vImage.framework/vImage")]
	private unsafe static extern nint vImageRichardsonLucyDeConvolve_Planar8(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, short* kernel, short* kernel2, uint kernel_height, uint kernel_width, uint kernel_height2, uint kernel_width2, int divisor, int divisor2, byte backgroundColor, uint iterationCount, vImageFlags flags);

	public unsafe static vImageError RichardsonLucyDeConvolvePlanar8(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, short* kernel, short* kernel2, uint kernel_height, uint kernel_width, uint kernel_height2, uint kernel_width2, int divisor, int divisor2, byte backgroundColor, uint iterationCount, vImageFlags flags)
	{
		return (vImageError)(long)vImageRichardsonLucyDeConvolve_Planar8(ref src, ref dest, tempBuffer, srcOffsetToROI_X, srcOffsetToROI_Y, kernel, kernel2, kernel_height, kernel_width, kernel_height2, kernel_width2, divisor, divisor2, backgroundColor, iterationCount, flags);
	}

	[DllImport("/System/Library/Frameworks/Accelerate.framework/Frameworks/vImage.framework/vImage")]
	private unsafe static extern nint vImageRichardsonLucyDeConvolve_PlanarF(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, float* kernel, float* kernel2, uint kernel_height, uint kernel_width, uint kernel_height2, uint kernel_width2, float backgroundColor, uint iterationCount, vImageFlags flags);

	public unsafe static vImageError RichardsonLucyDeConvolvePlanarF(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, float* kernel, float* kernel2, uint kernel_height, uint kernel_width, uint kernel_height2, uint kernel_width2, float backgroundColor, uint iterationCount, vImageFlags flags)
	{
		return (vImageError)(long)vImageRichardsonLucyDeConvolve_PlanarF(ref src, ref dest, tempBuffer, srcOffsetToROI_X, srcOffsetToROI_Y, kernel, kernel2, kernel_height, kernel_width, kernel_height2, kernel_width2, backgroundColor, iterationCount, flags);
	}

	[DllImport("/System/Library/Frameworks/Accelerate.framework/Frameworks/vImage.framework/vImage")]
	private unsafe static extern nint vImageRichardsonLucyDeConvolve_ARGB8888(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, short* kernel, short* kernel2, uint kernel_height, uint kernel_width, uint kernel_height2, uint kernel_width2, int divisor, int divisor2, Pixel8888 backgroundColor, uint iterationCount, vImageFlags flags);

	public unsafe static vImageError RichardsonLucyDeConvolveARGB8888(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, short* kernel, short* kernel2, uint kernel_height, uint kernel_width, uint kernel_height2, uint kernel_width2, int divisor, int divisor2, Pixel8888 backgroundColor, uint iterationCount, vImageFlags flags)
	{
		return (vImageError)(long)vImageRichardsonLucyDeConvolve_ARGB8888(ref src, ref dest, tempBuffer, srcOffsetToROI_X, srcOffsetToROI_Y, kernel, kernel2, kernel_height, kernel_width, kernel_height2, kernel_width2, divisor, divisor2, backgroundColor, iterationCount, flags);
	}

	[DllImport("/System/Library/Frameworks/Accelerate.framework/Frameworks/vImage.framework/vImage")]
	private unsafe static extern nint vImageRichardsonLucyDeConvolve_ARGBFFFF(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, float* kernel, float* kernel2, uint kernel_height, uint kernel_width, uint kernel_height2, uint kernel_width2, PixelFFFF backgroundColor, uint iterationCount, vImageFlags flags);

	public unsafe static vImageError RichardsonLucyDeConvolveARGBFFFF(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, float* kernel, float* kernel2, uint kernel_height, uint kernel_width, uint kernel_height2, uint kernel_width2, PixelFFFF backgroundColor, uint iterationCount, vImageFlags flags)
	{
		return (vImageError)(long)vImageRichardsonLucyDeConvolve_ARGBFFFF(ref src, ref dest, tempBuffer, srcOffsetToROI_X, srcOffsetToROI_Y, kernel, kernel2, kernel_height, kernel_width, kernel_height2, kernel_width2, backgroundColor, iterationCount, flags);
	}

	[DllImport("/System/Library/Frameworks/Accelerate.framework/Frameworks/vImage.framework/vImage")]
	private static extern nint vImageBoxConvolve_Planar8(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, uint kernel_height, uint kernel_width, byte backgroundColor, vImageFlags flags);

	public static vImageError BoxConvolvePlanar8(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, uint kernel_height, uint kernel_width, byte backgroundColor, vImageFlags flags)
	{
		return (vImageError)(long)vImageBoxConvolve_Planar8(ref src, ref dest, tempBuffer, srcOffsetToROI_X, srcOffsetToROI_Y, kernel_height, kernel_width, backgroundColor, flags);
	}

	[DllImport("/System/Library/Frameworks/Accelerate.framework/Frameworks/vImage.framework/vImage")]
	private static extern nint vImageBoxConvolve_ARGB8888(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, uint kernel_height, uint kernel_width, Pixel8888 backgroundColor, vImageFlags flags);

	public static vImageError BoxConvolveARGB8888(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, uint kernel_height, uint kernel_width, Pixel8888 backgroundColor, vImageFlags flags)
	{
		return (vImageError)(long)vImageBoxConvolve_ARGB8888(ref src, ref dest, tempBuffer, srcOffsetToROI_X, srcOffsetToROI_Y, kernel_height, kernel_width, backgroundColor, flags);
	}

	[DllImport("/System/Library/Frameworks/Accelerate.framework/Frameworks/vImage.framework/vImage")]
	private unsafe static extern nint vImageBoxConvolve_ARGB8888(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, uint kernel_height, uint kernel_width, Pixel8888* backgroundColor, vImageFlags flags);

	public unsafe static vImageError BoxConvolveARGB8888(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, uint kernel_height, uint kernel_width, Pixel8888* backgroundColor, vImageFlags flags)
	{
		return (vImageError)(long)vImageBoxConvolve_ARGB8888(ref src, ref dest, tempBuffer, srcOffsetToROI_X, srcOffsetToROI_Y, kernel_height, kernel_width, backgroundColor, flags);
	}

	[DllImport("/System/Library/Frameworks/Accelerate.framework/Frameworks/vImage.framework/vImage")]
	private static extern nint vImageTentConvolve_Planar8(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, uint kernel_height, uint kernel_width, byte backgroundColor, vImageFlags flags);

	public static vImageError TentConvolvePlanar8(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, uint kernel_height, uint kernel_width, byte backgroundColor, vImageFlags flags)
	{
		return (vImageError)(long)vImageTentConvolve_Planar8(ref src, ref dest, tempBuffer, srcOffsetToROI_X, srcOffsetToROI_Y, kernel_height, kernel_width, backgroundColor, flags);
	}

	[DllImport("/System/Library/Frameworks/Accelerate.framework/Frameworks/vImage.framework/vImage")]
	private static extern nint vImageTentConvolve_ARGB8888(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, uint kernel_height, uint kernel_width, Pixel8888 backgroundColor, vImageFlags flags);

	public static vImageError TentConvolveARGB8888(ref vImageBuffer src, ref vImageBuffer dest, IntPtr tempBuffer, nint srcOffsetToROI_X, nint srcOffsetToROI_Y, uint kernel_height, uint kernel_width, Pixel8888 backgroundColor, vImageFlags flags)
	{
		return (vImageError)(long)vImageTentConvolve_ARGB8888(ref src, ref dest, tempBuffer, srcOffsetToROI_X, srcOffsetToROI_Y, kernel_height, kernel_width, backgroundColor, flags);
	}

	[DllImport("/System/Library/Frameworks/Accelerate.framework/Frameworks/vImage.framework/vImage")]
	private static extern nint vImageMatrixMultiply_ARGB8888(ref vImageBuffer src, ref vImageBuffer dest, short[] matrix, int divisor, short[] pre_bias, int[] post_bias, vImageFlags flags);

	public static vImageError MatrixMultiplyARGB8888(ref vImageBuffer src, ref vImageBuffer dest, short[] matrix, int divisor, short[] pre_bias, int[] post_bias, vImageFlags flags)
	{
		if (matrix == null)
		{
			throw new ArgumentNullException("matrix");
		}
		if (pre_bias != null && pre_bias.Length != 4)
		{
			throw new ArgumentException("Must have four elements", "pre_bias");
		}
		if (post_bias != null && post_bias.Length != 4)
		{
			throw new ArgumentException("Must have four elements", "post_bias");
		}
		return (vImageError)(long)vImageMatrixMultiply_ARGB8888(ref src, ref dest, matrix, divisor, pre_bias, post_bias, flags);
	}
}

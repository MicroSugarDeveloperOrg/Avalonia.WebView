using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class MTLCommonCounterExtensions
{
	private static IntPtr[] values = new IntPtr[18];

	[Field("MTLCommonCounterTimestamp", "Metal")]
	internal unsafe static IntPtr MTLCommonCounterTimestamp
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.Metal.Handle, "MTLCommonCounterTimestamp", storage);
			}
		}
	}

	[Field("MTLCommonCounterTessellationInputPatches", "Metal")]
	internal unsafe static IntPtr MTLCommonCounterTessellationInputPatches
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.Metal.Handle, "MTLCommonCounterTessellationInputPatches", storage);
			}
		}
	}

	[Field("MTLCommonCounterVertexInvocations", "Metal")]
	internal unsafe static IntPtr MTLCommonCounterVertexInvocations
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.Metal.Handle, "MTLCommonCounterVertexInvocations", storage);
			}
		}
	}

	[Field("MTLCommonCounterPostTessellationVertexInvocations", "Metal")]
	internal unsafe static IntPtr MTLCommonCounterPostTessellationVertexInvocations
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.Metal.Handle, "MTLCommonCounterPostTessellationVertexInvocations", storage);
			}
		}
	}

	[Field("MTLCommonCounterClipperInvocations", "Metal")]
	internal unsafe static IntPtr MTLCommonCounterClipperInvocations
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.Metal.Handle, "MTLCommonCounterClipperInvocations", storage);
			}
		}
	}

	[Field("MTLCommonCounterClipperPrimitivesOut", "Metal")]
	internal unsafe static IntPtr MTLCommonCounterClipperPrimitivesOut
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.Metal.Handle, "MTLCommonCounterClipperPrimitivesOut", storage);
			}
		}
	}

	[Field("MTLCommonCounterFragmentInvocations", "Metal")]
	internal unsafe static IntPtr MTLCommonCounterFragmentInvocations
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.Metal.Handle, "MTLCommonCounterFragmentInvocations", storage);
			}
		}
	}

	[Field("MTLCommonCounterFragmentsPassed", "Metal")]
	internal unsafe static IntPtr MTLCommonCounterFragmentsPassed
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.Metal.Handle, "MTLCommonCounterFragmentsPassed", storage);
			}
		}
	}

	[Field("MTLCommonCounterComputeKernelInvocations", "Metal")]
	internal unsafe static IntPtr MTLCommonCounterComputeKernelInvocations
	{
		get
		{
			fixed (IntPtr* storage = &values[8])
			{
				return Dlfcn.CachePointer(Libraries.Metal.Handle, "MTLCommonCounterComputeKernelInvocations", storage);
			}
		}
	}

	[Field("MTLCommonCounterTotalCycles", "Metal")]
	internal unsafe static IntPtr MTLCommonCounterTotalCycles
	{
		get
		{
			fixed (IntPtr* storage = &values[9])
			{
				return Dlfcn.CachePointer(Libraries.Metal.Handle, "MTLCommonCounterTotalCycles", storage);
			}
		}
	}

	[Field("MTLCommonCounterVertexCycles", "Metal")]
	internal unsafe static IntPtr MTLCommonCounterVertexCycles
	{
		get
		{
			fixed (IntPtr* storage = &values[10])
			{
				return Dlfcn.CachePointer(Libraries.Metal.Handle, "MTLCommonCounterVertexCycles", storage);
			}
		}
	}

	[Field("MTLCommonCounterTessellationCycles", "Metal")]
	internal unsafe static IntPtr MTLCommonCounterTessellationCycles
	{
		get
		{
			fixed (IntPtr* storage = &values[11])
			{
				return Dlfcn.CachePointer(Libraries.Metal.Handle, "MTLCommonCounterTessellationCycles", storage);
			}
		}
	}

	[Field("MTLCommonCounterPostTessellationVertexCycles", "Metal")]
	internal unsafe static IntPtr MTLCommonCounterPostTessellationVertexCycles
	{
		get
		{
			fixed (IntPtr* storage = &values[12])
			{
				return Dlfcn.CachePointer(Libraries.Metal.Handle, "MTLCommonCounterPostTessellationVertexCycles", storage);
			}
		}
	}

	[Field("MTLCommonCounterFragmentCycles", "Metal")]
	internal unsafe static IntPtr MTLCommonCounterFragmentCycles
	{
		get
		{
			fixed (IntPtr* storage = &values[13])
			{
				return Dlfcn.CachePointer(Libraries.Metal.Handle, "MTLCommonCounterFragmentCycles", storage);
			}
		}
	}

	[Field("MTLCommonCounterRenderTargetWriteCycles", "Metal")]
	internal unsafe static IntPtr MTLCommonCounterRenderTargetWriteCycles
	{
		get
		{
			fixed (IntPtr* storage = &values[14])
			{
				return Dlfcn.CachePointer(Libraries.Metal.Handle, "MTLCommonCounterRenderTargetWriteCycles", storage);
			}
		}
	}

	[Field("MTLCommonCounterSetTimestamp", "Metal")]
	internal unsafe static IntPtr MTLCommonCounterSetTimestamp
	{
		get
		{
			fixed (IntPtr* storage = &values[15])
			{
				return Dlfcn.CachePointer(Libraries.Metal.Handle, "MTLCommonCounterSetTimestamp", storage);
			}
		}
	}

	[Field("MTLCommonCounterSetStageUtilization", "Metal")]
	internal unsafe static IntPtr MTLCommonCounterSetStageUtilization
	{
		get
		{
			fixed (IntPtr* storage = &values[16])
			{
				return Dlfcn.CachePointer(Libraries.Metal.Handle, "MTLCommonCounterSetStageUtilization", storage);
			}
		}
	}

	[Field("MTLCommonCounterSetStatistic", "Metal")]
	internal unsafe static IntPtr MTLCommonCounterSetStatistic
	{
		get
		{
			fixed (IntPtr* storage = &values[17])
			{
				return Dlfcn.CachePointer(Libraries.Metal.Handle, "MTLCommonCounterSetStatistic", storage);
			}
		}
	}

	public static NSString? GetConstant(this MTLCommonCounter self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = MTLCommonCounterTimestamp;
			break;
		case 1:
			ptr = MTLCommonCounterTessellationInputPatches;
			break;
		case 2:
			ptr = MTLCommonCounterVertexInvocations;
			break;
		case 3:
			ptr = MTLCommonCounterPostTessellationVertexInvocations;
			break;
		case 4:
			ptr = MTLCommonCounterClipperInvocations;
			break;
		case 5:
			ptr = MTLCommonCounterClipperPrimitivesOut;
			break;
		case 6:
			ptr = MTLCommonCounterFragmentInvocations;
			break;
		case 7:
			ptr = MTLCommonCounterFragmentsPassed;
			break;
		case 8:
			ptr = MTLCommonCounterComputeKernelInvocations;
			break;
		case 9:
			ptr = MTLCommonCounterTotalCycles;
			break;
		case 10:
			ptr = MTLCommonCounterVertexCycles;
			break;
		case 11:
			ptr = MTLCommonCounterTessellationCycles;
			break;
		case 12:
			ptr = MTLCommonCounterPostTessellationVertexCycles;
			break;
		case 13:
			ptr = MTLCommonCounterFragmentCycles;
			break;
		case 14:
			ptr = MTLCommonCounterRenderTargetWriteCycles;
			break;
		case 15:
			ptr = MTLCommonCounterSetTimestamp;
			break;
		case 16:
			ptr = MTLCommonCounterSetStageUtilization;
			break;
		case 17:
			ptr = MTLCommonCounterSetStatistic;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static MTLCommonCounter GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(MTLCommonCounterTimestamp))
		{
			return MTLCommonCounter.Timestamp;
		}
		if (constant.IsEqualTo(MTLCommonCounterTessellationInputPatches))
		{
			return MTLCommonCounter.TessellationInputPatches;
		}
		if (constant.IsEqualTo(MTLCommonCounterVertexInvocations))
		{
			return MTLCommonCounter.VertexInvocations;
		}
		if (constant.IsEqualTo(MTLCommonCounterPostTessellationVertexInvocations))
		{
			return MTLCommonCounter.PostTessellationVertexInvocations;
		}
		if (constant.IsEqualTo(MTLCommonCounterClipperInvocations))
		{
			return MTLCommonCounter.ClipperInvocations;
		}
		if (constant.IsEqualTo(MTLCommonCounterClipperPrimitivesOut))
		{
			return MTLCommonCounter.ClipperPrimitivesOut;
		}
		if (constant.IsEqualTo(MTLCommonCounterFragmentInvocations))
		{
			return MTLCommonCounter.FragmentInvocations;
		}
		if (constant.IsEqualTo(MTLCommonCounterFragmentsPassed))
		{
			return MTLCommonCounter.FragmentsPassed;
		}
		if (constant.IsEqualTo(MTLCommonCounterComputeKernelInvocations))
		{
			return MTLCommonCounter.ComputeKernelInvocations;
		}
		if (constant.IsEqualTo(MTLCommonCounterTotalCycles))
		{
			return MTLCommonCounter.TotalCycles;
		}
		if (constant.IsEqualTo(MTLCommonCounterVertexCycles))
		{
			return MTLCommonCounter.VertexCycles;
		}
		if (constant.IsEqualTo(MTLCommonCounterTessellationCycles))
		{
			return MTLCommonCounter.TessellationCycles;
		}
		if (constant.IsEqualTo(MTLCommonCounterPostTessellationVertexCycles))
		{
			return MTLCommonCounter.PostTessellationVertexCycles;
		}
		if (constant.IsEqualTo(MTLCommonCounterFragmentCycles))
		{
			return MTLCommonCounter.FragmentCycles;
		}
		if (constant.IsEqualTo(MTLCommonCounterRenderTargetWriteCycles))
		{
			return MTLCommonCounter.RenderTargetWriteCycles;
		}
		if (constant.IsEqualTo(MTLCommonCounterSetTimestamp))
		{
			return MTLCommonCounter.SetTimestamp;
		}
		if (constant.IsEqualTo(MTLCommonCounterSetStageUtilization))
		{
			return MTLCommonCounter.SetStageUtilization;
		}
		if (constant.IsEqualTo(MTLCommonCounterSetStatistic))
		{
			return MTLCommonCounter.SetStatistic;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}

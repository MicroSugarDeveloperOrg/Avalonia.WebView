using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CoreGraphics;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace CoreMedia;

[Watch(6, 0)]
public class CMVideoFormatDescription : CMFormatDescription
{
	public CMVideoDimensions Dimensions => CMFormatDescription.CMVideoFormatDescriptionGetDimensions(handle);

	internal CMVideoFormatDescription(IntPtr handle)
		: base(handle)
	{
	}

	internal CMVideoFormatDescription(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMFormatDescriptionError CMVideoFormatDescriptionCreate(IntPtr allocator, CMVideoCodecType codecType, int width, int height, IntPtr extensions, out IntPtr outDesc);

	private static IntPtr CreateCMVideoFormatDescription(CMVideoCodecType codecType, CMVideoDimensions size)
	{
		IntPtr outDesc;
		CMFormatDescriptionError cMFormatDescriptionError = CMVideoFormatDescriptionCreate(IntPtr.Zero, codecType, size.Width, size.Height, IntPtr.Zero, out outDesc);
		if (cMFormatDescriptionError != 0)
		{
			throw new ArgumentException(cMFormatDescriptionError.ToString());
		}
		return outDesc;
	}

	public CMVideoFormatDescription(CMVideoCodecType codecType, CMVideoDimensions size)
		: base(CreateCMVideoFormatDescription(codecType, size), owns: true)
	{
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMFormatDescriptionError CMVideoFormatDescriptionCreateForImageBuffer(IntPtr allocator, IntPtr imageBuffer, out IntPtr outDesc);

	public static CMVideoFormatDescription CreateForImageBuffer(CVImageBuffer imageBuffer, out CMFormatDescriptionError error)
	{
		if (imageBuffer == null)
		{
			throw new ArgumentNullException("imageBuffer");
		}
		error = CMVideoFormatDescriptionCreateForImageBuffer(IntPtr.Zero, imageBuffer.handle, out var outDesc);
		if (error != 0)
		{
			return null;
		}
		return new CMVideoFormatDescription(outDesc, owns: true);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	[iOS(7, 0)]
	[Mac(10, 9)]
	private static extern CMFormatDescriptionError CMVideoFormatDescriptionCreateFromH264ParameterSets(IntPtr allocator, nuint parameterSetCount, IntPtr[] parameterSetPointers, nuint[] parameterSetSizes, int NALUnitHeaderLength, out IntPtr formatDescriptionOut);

	[iOS(7, 0)]
	[Mac(10, 9)]
	public static CMVideoFormatDescription FromH264ParameterSets(List<byte[]> parameterSets, int nalUnitHeaderLength, out CMFormatDescriptionError error)
	{
		if (parameterSets == null)
		{
			throw new ArgumentNullException("parameterSets");
		}
		if (parameterSets.Count < 2)
		{
			throw new ArgumentException("parameterSets must contain at least two elements");
		}
		if (nalUnitHeaderLength != 1 && nalUnitHeaderLength != 2 && nalUnitHeaderLength != 4)
		{
			throw new ArgumentOutOfRangeException("nalUnitHeaderLength", "must be 1, 2 or 4");
		}
		GCHandle[] array = new GCHandle[parameterSets.Count];
		try
		{
			nuint[] array2 = new nuint[parameterSets.Count];
			IntPtr[] array3 = new IntPtr[parameterSets.Count];
			for (int i = 0; i < parameterSets.Count; i++)
			{
				array[i] = GCHandle.Alloc(parameterSets[i], GCHandleType.Pinned);
				array3[i] = array[i].AddrOfPinnedObject();
				array2[i] = (nuint)parameterSets[i].Length;
			}
			error = CMVideoFormatDescriptionCreateFromH264ParameterSets(IntPtr.Zero, (nuint)parameterSets.Count, array3, array2, nalUnitHeaderLength, out var formatDescriptionOut);
			if (error != 0)
			{
				return null;
			}
			return new CMVideoFormatDescription(formatDescriptionOut, owns: true);
		}
		finally
		{
			for (int j = 0; j < parameterSets.Count; j++)
			{
				if (array[j].IsAllocated)
				{
					array[j].Free();
				}
			}
		}
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	[iOS(7, 0)]
	[Mac(10, 9)]
	private static extern CMFormatDescriptionError CMVideoFormatDescriptionGetH264ParameterSetAtIndex(IntPtr videoDesc, nuint parameterSetIndex, out IntPtr parameterSetPointerOut, out nuint parameterSetSizeOut, out nuint parameterSetCountOut, out int nalUnitHeaderLengthOut);

	[iOS(7, 0)]
	[Mac(10, 9)]
	public byte[] GetH264ParameterSet(nuint index, out nuint parameterSetCount, out int nalUnitHeaderLength, out CMFormatDescriptionError error)
	{
		if (base.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("VideoFormatDescription");
		}
		error = CMVideoFormatDescriptionGetH264ParameterSetAtIndex(base.Handle, index, out var parameterSetPointerOut, out var parameterSetSizeOut, out parameterSetCount, out nalUnitHeaderLength);
		if (error != 0)
		{
			return null;
		}
		byte[] array = new byte[(int)parameterSetSizeOut];
		Marshal.Copy(parameterSetPointerOut, array, 0, (int)parameterSetSizeOut);
		return array;
	}

	public CGRect GetCleanAperture(bool originIsAtTopLeft)
	{
		return CMFormatDescription.CMVideoFormatDescriptionGetCleanAperture(handle, originIsAtTopLeft);
	}

	public CGSize GetPresentationDimensions(bool usePixelAspectRatio, bool useCleanAperture)
	{
		return CMFormatDescription.CMVideoFormatDescriptionGetPresentationDimensions(handle, usePixelAspectRatio, useCleanAperture);
	}

	public static NSObject[] GetExtensionKeysCommonWithImageBuffers()
	{
		IntPtr intPtr = CMFormatDescription.CMVideoFormatDescriptionGetExtensionKeysCommonWithImageBuffers();
		return NSArray.ArrayFromHandle<NSString>(intPtr);
	}

	public bool VideoMatchesImageBuffer(CVImageBuffer imageBuffer)
	{
		if (imageBuffer == null)
		{
			throw new ArgumentNullException("imageBuffer");
		}
		return CMFormatDescription.CMVideoFormatDescriptionMatchesImageBuffer(handle, imageBuffer.Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	[iOS(11, 0)]
	[Mac(10, 13)]
	[TV(11, 0)]
	private static extern CMFormatDescriptionError CMVideoFormatDescriptionCreateFromHEVCParameterSets(IntPtr allocator, nuint parameterSetCount, IntPtr[] parameterSetPointers, nuint[] parameterSetSizes, int NALUnitHeaderLength, IntPtr extensions, out IntPtr formatDescriptionOut);

	[iOS(11, 0)]
	[Mac(10, 13)]
	[TV(11, 0)]
	public static CMVideoFormatDescription FromHevcParameterSets(List<byte[]> parameterSets, int nalUnitHeaderLength, NSDictionary extensions, out CMFormatDescriptionError error)
	{
		if (parameterSets == null)
		{
			throw new ArgumentNullException("parameterSets");
		}
		if (parameterSets.Count < 3)
		{
			throw new ArgumentException("parameterSets must contain at least three elements");
		}
		if (nalUnitHeaderLength != 1 && nalUnitHeaderLength != 2 && nalUnitHeaderLength != 4)
		{
			throw new ArgumentOutOfRangeException("nalUnitHeaderLength", "must be 1, 2 or 4");
		}
		GCHandle[] array = new GCHandle[parameterSets.Count];
		try
		{
			nuint[] array2 = new nuint[parameterSets.Count];
			IntPtr[] array3 = new IntPtr[parameterSets.Count];
			for (int i = 0; i < parameterSets.Count; i++)
			{
				array[i] = GCHandle.Alloc(parameterSets[i], GCHandleType.Pinned);
				array3[i] = array[i].AddrOfPinnedObject();
				array2[i] = (nuint)parameterSets[i].Length;
			}
			error = CMVideoFormatDescriptionCreateFromHEVCParameterSets(IntPtr.Zero, (nuint)parameterSets.Count, array3, array2, nalUnitHeaderLength, extensions.GetHandle(), out var formatDescriptionOut);
			if (error != 0 || formatDescriptionOut == IntPtr.Zero)
			{
				return null;
			}
			return new CMVideoFormatDescription(formatDescriptionOut, owns: true);
		}
		finally
		{
			for (int j = 0; j < array.Length; j++)
			{
				if (array[j].IsAllocated)
				{
					array[j].Free();
				}
			}
		}
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	[iOS(11, 0)]
	[Mac(10, 13)]
	[TV(11, 0)]
	private static extern CMFormatDescriptionError CMVideoFormatDescriptionGetHEVCParameterSetAtIndex(IntPtr videoDesc, nuint parameterSetIndex, out IntPtr parameterSetPointerOut, out nuint parameterSetSizeOut, out nuint parameterSetCountOut, out int nalUnitHeaderLengthOut);

	[iOS(11, 0)]
	[Mac(10, 13)]
	[TV(11, 0)]
	public byte[] GetHevcParameterSet(nuint index, out nuint parameterSetCount, out int nalUnitHeaderLength, out CMFormatDescriptionError error)
	{
		if (base.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("VideoFormatDescription");
		}
		error = CMVideoFormatDescriptionGetHEVCParameterSetAtIndex(base.Handle, index, out var parameterSetPointerOut, out var parameterSetSizeOut, out parameterSetCount, out nalUnitHeaderLength);
		if (error != 0)
		{
			return null;
		}
		byte[] array = new byte[(int)parameterSetSizeOut];
		Marshal.Copy(parameterSetPointerOut, array, 0, (int)parameterSetSizeOut);
		return array;
	}
}

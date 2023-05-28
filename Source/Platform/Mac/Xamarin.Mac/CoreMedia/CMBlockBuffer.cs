using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreMedia;

[Watch(6, 0)]
public class CMBlockBuffer : ICMAttachmentBearer, INativeObject, IDisposable
{
	internal IntPtr handle;

	internal CMCustomBlockAllocator customAllocator;

	public IntPtr Handle => handle;

	public nuint DataLength => CMBlockBufferGetDataLength(handle);

	public bool IsEmpty
	{
		get
		{
			if (Handle == IntPtr.Zero)
			{
				throw new ObjectDisposedException("BlockBuffer");
			}
			return CMBlockBufferIsEmpty(handle);
		}
	}

	internal CMBlockBuffer(IntPtr handle)
	{
		this.handle = handle;
	}

	[Preserve(Conditional = true)]
	internal CMBlockBuffer(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
		this.handle = handle;
	}

	~CMBlockBuffer()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMBlockBufferError CMBlockBufferCreateEmpty(IntPtr allocator, uint subBlockCapacity, CMBlockBufferFlags flags, out IntPtr output);

	public static CMBlockBuffer CreateEmpty(uint subBlockCapacity, CMBlockBufferFlags flags, out CMBlockBufferError error)
	{
		error = CMBlockBufferCreateEmpty(IntPtr.Zero, subBlockCapacity, flags, out var output);
		if (error != 0)
		{
			return null;
		}
		return new CMBlockBuffer(output, owns: true);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMBlockBufferError CMBlockBufferCreateWithBufferReference(IntPtr structureAllocator, IntPtr targetBuffer, nuint offsetToData, nuint dataLength, CMBlockBufferFlags flags, out IntPtr newBlockBuffer);

	public static CMBlockBuffer FromBuffer(CMBlockBuffer targetBuffer, nuint offsetToData, nuint dataLength, CMBlockBufferFlags flags, out CMBlockBufferError error)
	{
		if (!flags.HasFlag(CMBlockBufferFlags.PermitEmptyReference) && targetBuffer == null)
		{
			throw new ArgumentNullException("targetBuffer");
		}
		error = CMBlockBufferCreateWithBufferReference(IntPtr.Zero, targetBuffer?.handle ?? IntPtr.Zero, offsetToData, dataLength, flags, out var newBlockBuffer);
		if (error != 0)
		{
			return null;
		}
		return new CMBlockBuffer(newBlockBuffer, owns: true);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMBlockBufferError CMBlockBufferAppendBufferReference(IntPtr buffer, IntPtr targetBBuf, nuint offsetToData, nuint dataLength, CMBlockBufferFlags flags);

	public CMBlockBufferError AppendBuffer(CMBlockBuffer targetBuffer, nuint offsetToData, nuint dataLength, CMBlockBufferFlags flags)
	{
		if (Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("BlockBuffer");
		}
		if (!flags.HasFlag(CMBlockBufferFlags.PermitEmptyReference) && targetBuffer == null)
		{
			throw new ArgumentNullException("targetBuffer");
		}
		return CMBlockBufferAppendBufferReference(Handle, targetBuffer?.handle ?? IntPtr.Zero, offsetToData, dataLength, flags);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMBlockBufferError CMBlockBufferAssureBlockMemory(IntPtr buffer);

	public CMBlockBufferError AssureBlockMemory()
	{
		if (Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("BlockBuffer");
		}
		return CMBlockBufferAssureBlockMemory(Handle);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMBlockBufferError CMBlockBufferAccessDataBytes(IntPtr buffer, nuint offset, nuint length, IntPtr temporaryBlock, ref IntPtr returnedPointer);

	public CMBlockBufferError AccessDataBytes(nuint offset, nuint length, IntPtr temporaryBlock, ref IntPtr returnedPointer)
	{
		if (Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("BlockBuffer");
		}
		return CMBlockBufferAccessDataBytes(Handle, offset, length, temporaryBlock, ref returnedPointer);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMBlockBufferError CMBlockBufferCopyDataBytes(IntPtr theSourceBuffer, nuint offsetToData, nuint dataLength, IntPtr destination);

	public CMBlockBufferError CopyDataBytes(nuint offsetToData, nuint dataLength, IntPtr destination)
	{
		if (Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("BlockBuffer");
		}
		return CMBlockBufferCopyDataBytes(handle, offsetToData, dataLength, destination);
	}

	public unsafe CMBlockBufferError CopyDataBytes(nuint offsetToData, nuint dataLength, out byte[] destination)
	{
		if (Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("BlockBuffer");
		}
		destination = new byte[(ulong)dataLength];
		CMBlockBufferError cMBlockBufferError;
		fixed (byte* ptr = destination)
		{
			cMBlockBufferError = CMBlockBufferCopyDataBytes(handle, offsetToData, dataLength, (IntPtr)ptr);
		}
		if (cMBlockBufferError != 0)
		{
			destination = null;
		}
		return cMBlockBufferError;
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMBlockBufferError CMBlockBufferReplaceDataBytes(IntPtr sourceBytes, IntPtr destinationBuffer, nuint offsetIntoDestination, nuint dataLength);

	public CMBlockBufferError ReplaceDataBytes(IntPtr sourceBytes, nuint offsetIntoDestination, nuint dataLength)
	{
		if (Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("BlockBuffer");
		}
		return CMBlockBufferReplaceDataBytes(sourceBytes, handle, offsetIntoDestination, dataLength);
	}

	public unsafe CMBlockBufferError ReplaceDataBytes(byte[] sourceBytes, nuint offsetIntoDestination)
	{
		if (Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("BlockBuffer");
		}
		if (sourceBytes == null)
		{
			throw new ArgumentNullException("sourceBytes");
		}
		fixed (byte* ptr = sourceBytes)
		{
			return ReplaceDataBytes((IntPtr)ptr, offsetIntoDestination, (nuint)sourceBytes.Length);
		}
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMBlockBufferError CMBlockBufferFillDataBytes(byte fillByte, IntPtr destinationBuffer, nuint offsetIntoDestination, nuint dataLength);

	public CMBlockBufferError FillDataBytes(byte fillByte, nuint offsetIntoDestination, nuint dataLength)
	{
		if (Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("BlockBuffer");
		}
		return CMBlockBufferFillDataBytes(fillByte, handle, offsetIntoDestination, dataLength);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMBlockBufferError CMBlockBufferGetDataPointer(IntPtr buffer, nuint offset, out nuint lengthAtOffset, out nuint totalLength, ref IntPtr dataPointer);

	public CMBlockBufferError GetDataPointer(nuint offset, out nuint lengthAtOffset, out nuint totalLength, ref IntPtr dataPointer)
	{
		if (Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("BlockBuffer");
		}
		return CMBlockBufferGetDataPointer(Handle, offset, out lengthAtOffset, out totalLength, ref dataPointer);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern nuint CMBlockBufferGetDataLength(IntPtr theBuffer);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool CMBlockBufferIsRangeContiguous(IntPtr buffer, nuint offset, nuint length);

	public bool IsRangeContiguous(nuint offset, nuint length)
	{
		if (Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("BlockBuffer");
		}
		return CMBlockBufferIsRangeContiguous(Handle, offset, length);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	[return: MarshalAs(UnmanagedType.U1)]
	private static extern bool CMBlockBufferIsEmpty(IntPtr theBuffer);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMBlockBufferError CMBlockBufferCreateWithMemoryBlock(IntPtr structureAllocator, IntPtr memoryBlock, nuint blockLength, IntPtr blockAllocator, ref CMCustomBlockAllocator.CMBlockBufferCustomBlockSource customBlockSource, nuint offsetToData, nuint dataLength, CMBlockBufferFlags flags, out IntPtr newBlockBuffer);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMBlockBufferError CMBlockBufferCreateWithMemoryBlock(IntPtr structureAllocator, IntPtr memoryBlock, nuint blockLength, IntPtr blockAllocator, IntPtr customBlockSource, nuint offsetToData, nuint dataLength, CMBlockBufferFlags flags, out IntPtr newBlockBuffer);

	public static CMBlockBuffer FromMemoryBlock(IntPtr memoryBlock, nuint blockLength, CMCustomBlockAllocator customBlockSource, nuint offsetToData, nuint dataLength, CMBlockBufferFlags flags, out CMBlockBufferError error)
	{
		IntPtr blockAllocator = ((memoryBlock == IntPtr.Zero) ? IntPtr.Zero : CFAllocator.Null.Handle);
		IntPtr newBlockBuffer;
		if (customBlockSource == null)
		{
			error = CMBlockBufferCreateWithMemoryBlock(IntPtr.Zero, memoryBlock, blockLength, blockAllocator, IntPtr.Zero, offsetToData, dataLength, flags, out newBlockBuffer);
		}
		else
		{
			error = CMBlockBufferCreateWithMemoryBlock(IntPtr.Zero, memoryBlock, blockLength, blockAllocator, ref customBlockSource.Cblock, offsetToData, dataLength, flags, out newBlockBuffer);
		}
		if (error != 0)
		{
			return null;
		}
		CMBlockBuffer cMBlockBuffer = new CMBlockBuffer(newBlockBuffer, owns: true);
		cMBlockBuffer.customAllocator = customBlockSource;
		return cMBlockBuffer;
	}

	public static CMBlockBuffer FromMemoryBlock(byte[] data, nuint offsetToData, CMBlockBufferFlags flags, out CMBlockBufferError error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		CMManagedArrayBlockAllocator customBlockSource = new CMManagedArrayBlockAllocator(data);
		return FromMemoryBlock(IntPtr.Zero, (uint)data.Length, customBlockSource, offsetToData, (uint)data.Length, flags, out error);
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMBlockBufferError CMBlockBufferCreateContiguous(IntPtr structureAllocator, IntPtr sourceBuffer, IntPtr blockAllocator, ref CMCustomBlockAllocator.CMBlockBufferCustomBlockSource customBlockSource, nuint offsetToData, nuint dataLength, CMBlockBufferFlags flags, out IntPtr newBlockBuffer);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMBlockBufferError CMBlockBufferCreateContiguous(IntPtr structureAllocator, IntPtr sourceBuffer, IntPtr blockAllocator, IntPtr customBlockSource, nuint offsetToData, nuint dataLength, CMBlockBufferFlags flags, out IntPtr newBlockBuffer);

	public static CMBlockBuffer CreateContiguous(CMBlockBuffer sourceBuffer, CMCustomBlockAllocator customBlockSource, nuint offsetToData, nuint dataLength, CMBlockBufferFlags flags, out CMBlockBufferError error)
	{
		if (sourceBuffer == null)
		{
			throw new ArgumentNullException("sourceBuffer");
		}
		IntPtr newBlockBuffer;
		if (customBlockSource == null)
		{
			error = CMBlockBufferCreateContiguous(IntPtr.Zero, sourceBuffer.handle, IntPtr.Zero, IntPtr.Zero, offsetToData, dataLength, flags, out newBlockBuffer);
		}
		else
		{
			error = CMBlockBufferCreateContiguous(IntPtr.Zero, sourceBuffer.handle, IntPtr.Zero, ref customBlockSource.Cblock, offsetToData, dataLength, flags, out newBlockBuffer);
		}
		if (error != 0)
		{
			return null;
		}
		CMBlockBuffer cMBlockBuffer = new CMBlockBuffer(newBlockBuffer, owns: true);
		cMBlockBuffer.customAllocator = customBlockSource;
		return cMBlockBuffer;
	}

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMBlockBufferError CMBlockBufferAppendMemoryBlock(IntPtr buffer, IntPtr memoryBlock, nuint blockLength, IntPtr blockAllocator, ref CMCustomBlockAllocator.CMBlockBufferCustomBlockSource customBlockSource, nuint offsetToData, nuint dataLength, CMBlockBufferFlags flags);

	[DllImport("/System/Library/Frameworks/CoreMedia.framework/CoreMedia")]
	private static extern CMBlockBufferError CMBlockBufferAppendMemoryBlock(IntPtr buffer, IntPtr memoryBlock, nuint blockLength, IntPtr blockAllocator, IntPtr customBlockSource, nuint offsetToData, nuint dataLength, CMBlockBufferFlags flags);

	public CMBlockBufferError AppendMemoryBlock(IntPtr memoryBlock, nuint blockLength, CMCustomBlockAllocator customBlockSource, nuint offsetToData, nuint dataLength, CMBlockBufferFlags flags)
	{
		if (Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("BlockBuffer");
		}
		IntPtr blockAllocator = ((memoryBlock == IntPtr.Zero) ? IntPtr.Zero : CFAllocator.Null.Handle);
		if (customBlockSource == null)
		{
			return CMBlockBufferAppendMemoryBlock(Handle, memoryBlock, blockLength, blockAllocator, IntPtr.Zero, offsetToData, dataLength, flags);
		}
		return CMBlockBufferAppendMemoryBlock(Handle, memoryBlock, blockLength, blockAllocator, ref customBlockSource.Cblock, offsetToData, dataLength, flags);
	}

	public CMBlockBufferError AppendMemoryBlock(byte[] data, nuint offsetToData, CMBlockBufferFlags flags)
	{
		if (Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("BlockBuffer");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		CMManagedArrayBlockAllocator customBlockSource = new CMManagedArrayBlockAllocator(data);
		return AppendMemoryBlock(IntPtr.Zero, (uint)data.Length, customBlockSource, offsetToData, (uint)data.Length, flags);
	}
}

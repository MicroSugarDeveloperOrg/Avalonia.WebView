using System.Runtime.InteropServices;
using Foundation;
using IOSurface;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreVideo;

[Watch(4, 0)]
public class CVPixelBuffer : CVImageBuffer
{
	private delegate void CVPixelBufferReleaseBytesCallback(IntPtr releaseRefCon, IntPtr baseAddress);

	private class PlaneData
	{
		public GCHandle[] dataHandles;
	}

	private delegate void CVPixelBufferReleasePlanarBytesCallback(IntPtr releaseRefCon, IntPtr dataPtr, nint dataSize, nint numberOfPlanes, IntPtr planeAddresses);

	private static CVPixelBufferReleaseBytesCallback releaseBytesCallback = ReleaseBytesCallback;

	private static CVPixelBufferReleasePlanarBytesCallback releasePlanarBytesCallback = ReleasePlanarBytesCallback;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BytesPerRowAlignmentKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CGBitmapContextCompatibilityKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CGImageCompatibilityKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExtendedPixelsBottomKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExtendedPixelsLeftKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExtendedPixelsRightKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ExtendedPixelsTopKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _HeightKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IOSurfacePropertiesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MemoryAllocatorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MetalCompatibilityKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OpenGLCompatibilityKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OpenGLTextureCacheCompatibilityKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PixelFormatTypeKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PlaneAlignmentKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WidthKey;

	public IntPtr BaseAddress => CVPixelBufferGetBaseAddress(handle);

	public nint BytesPerRow => CVPixelBufferGetBytesPerRow(handle);

	public nint DataSize => CVPixelBufferGetDataSize(handle);

	public nint Height => CVPixelBufferGetHeight(handle);

	public nint Width => CVPixelBufferGetWidth(handle);

	public nint PlaneCount => CVPixelBufferGetPlaneCount(handle);

	public bool IsPlanar => CVPixelBufferIsPlanar(handle);

	public CVPixelFormatType PixelFormatType => CVPixelBufferGetPixelFormatType(handle);

	[Field("kCVPixelBufferBytesPerRowAlignmentKey", "CoreVideo")]
	public static NSString BytesPerRowAlignmentKey
	{
		get
		{
			if (_BytesPerRowAlignmentKey == null)
			{
				_BytesPerRowAlignmentKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVPixelBufferBytesPerRowAlignmentKey");
			}
			return _BytesPerRowAlignmentKey;
		}
	}

	[Field("kCVPixelBufferCGBitmapContextCompatibilityKey", "CoreVideo")]
	public static NSString CGBitmapContextCompatibilityKey
	{
		get
		{
			if (_CGBitmapContextCompatibilityKey == null)
			{
				_CGBitmapContextCompatibilityKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVPixelBufferCGBitmapContextCompatibilityKey");
			}
			return _CGBitmapContextCompatibilityKey;
		}
	}

	[Field("kCVPixelBufferCGImageCompatibilityKey", "CoreVideo")]
	public static NSString CGImageCompatibilityKey
	{
		get
		{
			if (_CGImageCompatibilityKey == null)
			{
				_CGImageCompatibilityKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVPixelBufferCGImageCompatibilityKey");
			}
			return _CGImageCompatibilityKey;
		}
	}

	[Field("kCVPixelBufferExtendedPixelsBottomKey", "CoreVideo")]
	public static NSString ExtendedPixelsBottomKey
	{
		get
		{
			if (_ExtendedPixelsBottomKey == null)
			{
				_ExtendedPixelsBottomKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVPixelBufferExtendedPixelsBottomKey");
			}
			return _ExtendedPixelsBottomKey;
		}
	}

	[Field("kCVPixelBufferExtendedPixelsLeftKey", "CoreVideo")]
	public static NSString ExtendedPixelsLeftKey
	{
		get
		{
			if (_ExtendedPixelsLeftKey == null)
			{
				_ExtendedPixelsLeftKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVPixelBufferExtendedPixelsLeftKey");
			}
			return _ExtendedPixelsLeftKey;
		}
	}

	[Field("kCVPixelBufferExtendedPixelsRightKey", "CoreVideo")]
	public static NSString ExtendedPixelsRightKey
	{
		get
		{
			if (_ExtendedPixelsRightKey == null)
			{
				_ExtendedPixelsRightKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVPixelBufferExtendedPixelsRightKey");
			}
			return _ExtendedPixelsRightKey;
		}
	}

	[Field("kCVPixelBufferExtendedPixelsTopKey", "CoreVideo")]
	public static NSString ExtendedPixelsTopKey
	{
		get
		{
			if (_ExtendedPixelsTopKey == null)
			{
				_ExtendedPixelsTopKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVPixelBufferExtendedPixelsTopKey");
			}
			return _ExtendedPixelsTopKey;
		}
	}

	[Field("kCVPixelBufferHeightKey", "CoreVideo")]
	public static NSString HeightKey
	{
		get
		{
			if (_HeightKey == null)
			{
				_HeightKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVPixelBufferHeightKey");
			}
			return _HeightKey;
		}
	}

	[Field("kCVPixelBufferIOSurfacePropertiesKey", "CoreVideo")]
	public static NSString IOSurfacePropertiesKey
	{
		get
		{
			if (_IOSurfacePropertiesKey == null)
			{
				_IOSurfacePropertiesKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVPixelBufferIOSurfacePropertiesKey");
			}
			return _IOSurfacePropertiesKey;
		}
	}

	[Field("kCVPixelBufferMemoryAllocatorKey", "CoreVideo")]
	public static NSString MemoryAllocatorKey
	{
		get
		{
			if (_MemoryAllocatorKey == null)
			{
				_MemoryAllocatorKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVPixelBufferMemoryAllocatorKey");
			}
			return _MemoryAllocatorKey;
		}
	}

	[Field("kCVPixelBufferMetalCompatibilityKey", "CoreVideo")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString MetalCompatibilityKey
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_MetalCompatibilityKey == null)
			{
				_MetalCompatibilityKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVPixelBufferMetalCompatibilityKey");
			}
			return _MetalCompatibilityKey;
		}
	}

	[Field("kCVPixelBufferOpenGLCompatibilityKey", "CoreVideo")]
	public static NSString OpenGLCompatibilityKey
	{
		get
		{
			if (_OpenGLCompatibilityKey == null)
			{
				_OpenGLCompatibilityKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVPixelBufferOpenGLCompatibilityKey");
			}
			return _OpenGLCompatibilityKey;
		}
	}

	[Field("kCVPixelBufferOpenGLTextureCacheCompatibilityKey", "CoreVideo")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static NSString OpenGLTextureCacheCompatibilityKey
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			if (_OpenGLTextureCacheCompatibilityKey == null)
			{
				_OpenGLTextureCacheCompatibilityKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVPixelBufferOpenGLTextureCacheCompatibilityKey");
			}
			return _OpenGLTextureCacheCompatibilityKey;
		}
	}

	[Field("kCVPixelBufferPixelFormatTypeKey", "CoreVideo")]
	public static NSString PixelFormatTypeKey
	{
		get
		{
			if (_PixelFormatTypeKey == null)
			{
				_PixelFormatTypeKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVPixelBufferPixelFormatTypeKey");
			}
			return _PixelFormatTypeKey;
		}
	}

	[Field("kCVPixelBufferPlaneAlignmentKey", "CoreVideo")]
	public static NSString PlaneAlignmentKey
	{
		get
		{
			if (_PlaneAlignmentKey == null)
			{
				_PlaneAlignmentKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVPixelBufferPlaneAlignmentKey");
			}
			return _PlaneAlignmentKey;
		}
	}

	[Field("kCVPixelBufferWidthKey", "CoreVideo")]
	public static NSString WidthKey
	{
		get
		{
			if (_WidthKey == null)
			{
				_WidthKey = Dlfcn.GetStringConstant(Libraries.CoreVideo.Handle, "kCVPixelBufferWidthKey");
			}
			return _WidthKey;
		}
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	[iOS(11, 0)]
	[Mac(10, 13)]
	[TV(11, 0)]
	[NoWatch]
	private static extern IntPtr CVPixelBufferGetIOSurface(IntPtr pixelBuffer);

	[iOS(11, 0)]
	[Mac(10, 13)]
	[TV(11, 0)]
	[NoWatch]
	public global::IOSurface.IOSurface GetIOSurface()
	{
		if (base.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("CVPixelBuffer");
		}
		IntPtr intPtr = CVPixelBufferGetIOSurface(base.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return Runtime.GetINativeObject<global::IOSurface.IOSurface>(intPtr, owns: false);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	[iOS(11, 0)]
	[Mac(10, 13)]
	[TV(11, 0)]
	[NoWatch]
	private static extern CVReturn CVPixelBufferCreateWithIOSurface(IntPtr allocator, IntPtr surface, IntPtr pixelBufferAttributes, out IntPtr pixelBufferOut);

	[iOS(11, 0)]
	[Mac(10, 13)]
	[TV(11, 0)]
	[NoWatch]
	public static CVPixelBuffer Create(global::IOSurface.IOSurface surface, out CVReturn result, CVPixelBufferAttributes pixelBufferAttributes = null)
	{
		if (surface == null)
		{
			throw new ArgumentNullException("surface");
		}
		result = CVPixelBufferCreateWithIOSurface(IntPtr.Zero, surface.Handle, pixelBufferAttributes?.Dictionary.Handle ?? IntPtr.Zero, out var pixelBufferOut);
		if (result != 0)
		{
			return null;
		}
		return new CVPixelBuffer(pixelBufferOut, owns: true);
	}

	[iOS(11, 0)]
	[Mac(10, 13)]
	[TV(11, 0)]
	[NoWatch]
	public static CVPixelBuffer Create(global::IOSurface.IOSurface surface, CVPixelBufferAttributes pixelBufferAttributes = null)
	{
		CVReturn result;
		return Create(surface, out result, pixelBufferAttributes);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo", EntryPoint = "CVPixelBufferGetTypeID")]
	public static extern nint GetTypeID();

	internal CVPixelBuffer(IntPtr handle)
		: base(handle)
	{
	}

	[Preserve(Conditional = true)]
	internal CVPixelBuffer(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVPixelBufferCreate(IntPtr allocator, nint width, nint height, CVPixelFormatType pixelFormatType, IntPtr pixelBufferAttributes, out IntPtr pixelBufferOut);

	public CVPixelBuffer(nint width, nint height, CVPixelFormatType pixelFormat)
		: this(width, height, pixelFormat, (NSDictionary)null)
	{
	}

	public CVPixelBuffer(nint width, nint height, CVPixelFormatType pixelFormatType, CVPixelBufferAttributes attributes)
		: this(width, height, pixelFormatType, attributes?.Dictionary)
	{
	}

	[Advice("Use constructor with CVPixelBufferAttributes")]
	private CVPixelBuffer(nint width, nint height, CVPixelFormatType pixelFormatType, NSDictionary pixelBufferAttributes)
	{
		if (width <= 0)
		{
			throw new ArgumentOutOfRangeException("width");
		}
		if (height <= 0)
		{
			throw new ArgumentOutOfRangeException("height");
		}
		CVReturn cVReturn = CVPixelBufferCreate(IntPtr.Zero, width, height, pixelFormatType, pixelBufferAttributes?.Handle ?? IntPtr.Zero, out handle);
		if (cVReturn != 0)
		{
			throw new ArgumentException(cVReturn.ToString());
		}
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVPixelBufferCreateResolvedAttributesDictionary(IntPtr allocator, IntPtr attributes, out IntPtr resolvedDictionaryOut);

	public NSDictionary GetAttributes(NSDictionary[] attributes)
	{
		CVReturn cVReturn;
		IntPtr resolvedDictionaryOut;
		if (attributes == null)
		{
			cVReturn = CVPixelBufferCreateResolvedAttributesDictionary(IntPtr.Zero, IntPtr.Zero, out resolvedDictionaryOut);
		}
		else
		{
			using NSArray nSArray = NSArray.FromNSObjects(attributes);
			cVReturn = CVPixelBufferCreateResolvedAttributesDictionary(IntPtr.Zero, nSArray.Handle, out resolvedDictionaryOut);
		}
		if (cVReturn != 0)
		{
			throw new ArgumentException(cVReturn.ToString());
		}
		return Runtime.GetNSObject<NSDictionary>(resolvedDictionaryOut);
	}

	[MonoPInvokeCallback(typeof(CVPixelBufferReleaseBytesCallback))]
	private static void ReleaseBytesCallback(IntPtr releaseRefCon, IntPtr baseAddress)
	{
		GCHandle.FromIntPtr(releaseRefCon).Free();
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVPixelBufferCreateWithBytes(IntPtr allocator, nint width, nint height, CVPixelFormatType pixelFormatType, IntPtr baseAddress, nint bytesPerRow, CVPixelBufferReleaseBytesCallback releaseCallback, IntPtr releaseRefCon, IntPtr pixelBufferAttributes, out IntPtr pixelBufferOut);

	public static CVPixelBuffer Create(nint width, nint height, CVPixelFormatType pixelFormatType, byte[] data, nint bytesPerRow, CVPixelBufferAttributes pixelBufferAttributes)
	{
		CVReturn status;
		return Create(width, height, pixelFormatType, data, bytesPerRow, pixelBufferAttributes, out status);
	}

	public static CVPixelBuffer Create(nint width, nint height, CVPixelFormatType pixelFormatType, byte[] data, nint bytesPerRow, CVPixelBufferAttributes pixelBufferAttributes, out CVReturn status)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (data.Length < height * bytesPerRow)
		{
			throw new ArgumentOutOfRangeException("data", "The length of data is smaller than height * bytesPerRow");
		}
		GCHandle value = GCHandle.Alloc(data, GCHandleType.Pinned);
		status = CVPixelBufferCreateWithBytes(IntPtr.Zero, width, height, pixelFormatType, value.AddrOfPinnedObject(), bytesPerRow, releaseBytesCallback, GCHandle.ToIntPtr(value), pixelBufferAttributes.GetHandle(), out var pixelBufferOut);
		if (status != 0)
		{
			value.Free();
			return null;
		}
		return new CVPixelBuffer(pixelBufferOut, owns: true);
	}

	[MonoPInvokeCallback(typeof(CVPixelBufferReleasePlanarBytesCallback))]
	private static void ReleasePlanarBytesCallback(IntPtr releaseRefCon, IntPtr dataPtr, nint dataSize, nint numberOfPlanes, IntPtr planeAddresses)
	{
		GCHandle gCHandle = GCHandle.FromIntPtr(releaseRefCon);
		PlaneData planeData = (PlaneData)gCHandle.Target;
		for (int i = 0; i < planeData.dataHandles.Length; i++)
		{
			planeData.dataHandles[i].Free();
		}
		gCHandle.Free();
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVPixelBufferCreateWithPlanarBytes(IntPtr allocator, nint width, nint height, CVPixelFormatType pixelFormatType, IntPtr dataPtr, nint dataSize, nint numberOfPlanes, IntPtr[] planeBaseAddress, nint[] planeWidth, nint[] planeHeight, nint[] planeBytesPerRow, CVPixelBufferReleasePlanarBytesCallback releaseCallback, IntPtr releaseRefCon, IntPtr pixelBufferAttributes, out IntPtr pixelBufferOut);

	public static CVPixelBuffer Create(nint width, nint height, CVPixelFormatType pixelFormatType, byte[][] planes, nint[] planeWidths, nint[] planeHeights, nint[] planeBytesPerRow, CVPixelBufferAttributes pixelBufferAttributes)
	{
		CVReturn status;
		return Create(width, height, pixelFormatType, planes, planeWidths, planeHeights, planeBytesPerRow, pixelBufferAttributes, out status);
	}

	public static CVPixelBuffer Create(nint width, nint height, CVPixelFormatType pixelFormatType, byte[][] planes, nint[] planeWidths, nint[] planeHeights, nint[] planeBytesPerRow, CVPixelBufferAttributes pixelBufferAttributes, out CVReturn status)
	{
		if (planes == null)
		{
			throw new ArgumentNullException("planes");
		}
		if (planeWidths == null)
		{
			throw new ArgumentNullException("planeWidths");
		}
		if (planeHeights == null)
		{
			throw new ArgumentNullException("planeHeights");
		}
		if (planeBytesPerRow == null)
		{
			throw new ArgumentNullException("planeBytesPerRow");
		}
		int num = planes.Length;
		if (planeWidths.Length != num)
		{
			throw new ArgumentOutOfRangeException("planeWidths", "The length of planeWidths does not match the number of planes");
		}
		if (planeHeights.Length != num)
		{
			throw new ArgumentOutOfRangeException("planeWidths", "The length of planeHeights does not match the number of planes");
		}
		if (planeBytesPerRow.Length != num)
		{
			throw new ArgumentOutOfRangeException("planeWidths", "The length of planeBytesPerRow does not match the number of planes");
		}
		IntPtr[] array = new IntPtr[num];
		PlaneData planeData = new PlaneData();
		planeData.dataHandles = new GCHandle[num];
		for (int i = 0; i < num; i++)
		{
			planeData.dataHandles[i] = GCHandle.Alloc(planes[i], GCHandleType.Pinned);
			array[i] = planeData.dataHandles[i].AddrOfPinnedObject();
		}
		GCHandle value = GCHandle.Alloc(planeData);
		IntPtr releaseRefCon = GCHandle.ToIntPtr(value);
		status = CVPixelBufferCreateWithPlanarBytes(IntPtr.Zero, width, height, pixelFormatType, IntPtr.Zero, 0, num, array, planeWidths, planeHeights, planeBytesPerRow, releasePlanarBytesCallback, releaseRefCon, pixelBufferAttributes.GetHandle(), out var pixelBufferOut);
		if (status != 0)
		{
			ReleasePlanarBytesCallback(releaseRefCon, IntPtr.Zero, 0, 0, IntPtr.Zero);
			return null;
		}
		return new CVPixelBuffer(pixelBufferOut, owns: true);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern void CVPixelBufferGetExtendedPixels(IntPtr pixelBuffer, ref nuint extraColumnsOnLeft, ref nuint extraColumnsOnRight, ref nuint extraRowsOnTop, ref nuint extraRowsOnBottom);

	public void GetExtendedPixels(ref nuint extraColumnsOnLeft, ref nuint extraColumnsOnRight, ref nuint extraRowsOnTop, ref nuint extraRowsOnBottom)
	{
		CVPixelBufferGetExtendedPixels(handle, ref extraColumnsOnLeft, ref extraColumnsOnRight, ref extraRowsOnTop, ref extraRowsOnBottom);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVPixelBufferFillExtendedPixels(IntPtr pixelBuffer);

	public CVReturn FillExtendedPixels()
	{
		return CVPixelBufferFillExtendedPixels(handle);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVPixelBufferGetBaseAddress(IntPtr pixelBuffer);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern nint CVPixelBufferGetBytesPerRow(IntPtr pixelBuffer);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern nint CVPixelBufferGetDataSize(IntPtr pixelBuffer);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern nint CVPixelBufferGetHeight(IntPtr pixelBuffer);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern nint CVPixelBufferGetWidth(IntPtr pixelBuffer);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern nint CVPixelBufferGetPlaneCount(IntPtr pixelBuffer);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern bool CVPixelBufferIsPlanar(IntPtr pixelBuffer);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVPixelFormatType CVPixelBufferGetPixelFormatType(IntPtr pixelBuffer);

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern IntPtr CVPixelBufferGetBaseAddressOfPlane(IntPtr pixelBuffer, nint planeIndex);

	public IntPtr GetBaseAddress(nint planeIndex)
	{
		return CVPixelBufferGetBaseAddressOfPlane(handle, planeIndex);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern nint CVPixelBufferGetBytesPerRowOfPlane(IntPtr pixelBuffer, nint planeIndex);

	public nint GetBytesPerRowOfPlane(nint planeIndex)
	{
		return CVPixelBufferGetBytesPerRowOfPlane(handle, planeIndex);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern nint CVPixelBufferGetHeightOfPlane(IntPtr pixelBuffer, nint planeIndex);

	public nint GetHeightOfPlane(nint planeIndex)
	{
		return CVPixelBufferGetHeightOfPlane(handle, planeIndex);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern nint CVPixelBufferGetWidthOfPlane(IntPtr pixelBuffer, nint planeIndex);

	public nint GetWidthOfPlane(nint planeIndex)
	{
		return CVPixelBufferGetWidthOfPlane(handle, planeIndex);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVPixelBufferLockBaseAddress(IntPtr pixelBuffer, CVPixelBufferLock lockFlags);

	[Obsolete("Use 'Lock (CVPixelBufferLock)' instead.")]
	public CVReturn Lock(CVOptionFlags lockFlags)
	{
		return CVPixelBufferLockBaseAddress(handle, (CVPixelBufferLock)lockFlags);
	}

	public CVReturn Lock(CVPixelBufferLock lockFlags)
	{
		return CVPixelBufferLockBaseAddress(handle, lockFlags);
	}

	[DllImport("/System/Library/Frameworks/CoreVideo.framework/CoreVideo")]
	private static extern CVReturn CVPixelBufferUnlockBaseAddress(IntPtr pixelBuffer, CVPixelBufferLock unlockFlags);

	[Obsolete("Use 'Unlock (CVPixelBufferLock)'.")]
	public CVReturn Unlock(CVOptionFlags unlockFlags)
	{
		return CVPixelBufferUnlockBaseAddress(handle, (CVPixelBufferLock)unlockFlags);
	}

	public CVReturn Unlock(CVPixelBufferLock unlockFlags)
	{
		return CVPixelBufferUnlockBaseAddress(handle, unlockFlags);
	}
}

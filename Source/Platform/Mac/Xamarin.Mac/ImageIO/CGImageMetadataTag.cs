using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace ImageIO;

[iOS(7, 0)]
public class CGImageMetadataTag : INativeObject, IDisposable
{
	public IntPtr Handle { get; internal set; }

	public NSString Namespace
	{
		get
		{
			IntPtr intPtr = CGImageMetadataTagCopyNamespace(Handle);
			return (intPtr == IntPtr.Zero) ? null : new NSString(intPtr, alloced: true);
		}
	}

	public NSString Prefix
	{
		get
		{
			IntPtr intPtr = CGImageMetadataTagCopyPrefix(Handle);
			return (intPtr == IntPtr.Zero) ? null : new NSString(intPtr, alloced: true);
		}
	}

	public NSString Name
	{
		get
		{
			IntPtr intPtr = CGImageMetadataTagCopyName(Handle);
			return (intPtr == IntPtr.Zero) ? null : new NSString(intPtr, alloced: true);
		}
	}

	public NSObject Value => Runtime.GetNSObject(CGImageMetadataTagCopyValue(Handle));

	public CGImageMetadataType Type => CGImageMetadataTagGetType(Handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageMetadataTagCreate(IntPtr xmlns, IntPtr prefix, IntPtr name, CGImageMetadataType type, IntPtr value);

	public CGImageMetadataTag(IntPtr handle)
		: this(handle, owns: false)
	{
	}

	[Preserve(Conditional = true)]
	internal CGImageMetadataTag(IntPtr handle, bool owns)
	{
		if (handle == IntPtr.Zero)
		{
			throw new Exception("Invalid handle");
		}
		Handle = handle;
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
	}

	public CGImageMetadataTag(NSString xmlns, NSString prefix, NSString name, CGImageMetadataType type, NSObject value)
		: this(xmlns, prefix, name, type, value?.Handle ?? IntPtr.Zero)
	{
	}

	public CGImageMetadataTag(NSString xmlns, NSString prefix, NSString name, CGImageMetadataType type, bool value)
		: this(xmlns, prefix, name, type, value ? CFBoolean.TrueHandle : CFBoolean.FalseHandle)
	{
	}

	private CGImageMetadataTag(NSString xmlns, NSString prefix, NSString name, CGImageMetadataType type, IntPtr value)
	{
		if (xmlns == null)
		{
			throw new ArgumentNullException("xmlns");
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (value == IntPtr.Zero)
		{
			throw new ArgumentNullException("value");
		}
		IntPtr prefix2 = ((prefix == null) ? IntPtr.Zero : prefix.Handle);
		Handle = CGImageMetadataTagCreate(xmlns.Handle, prefix2, name.Handle, type, value);
	}

	~CGImageMetadataTag()
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
		if (Handle != IntPtr.Zero)
		{
			CFObject.CFRelease(Handle);
			Handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO", EntryPoint = "CGImageMetadataTagGetTypeID")]
	public static extern nint GetTypeID();

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageMetadataTagCopyNamespace(IntPtr tag);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageMetadataTagCopyPrefix(IntPtr tag);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageMetadataTagCopyName(IntPtr tag);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageMetadataTagCopyValue(IntPtr tag);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern CGImageMetadataType CGImageMetadataTagGetType(IntPtr tag);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageMetadataTagCopyQualifiers(IntPtr tag);

	public CGImageMetadataTag[] GetQualifiers()
	{
		IntPtr intPtr = CGImageMetadataTagCopyQualifiers(Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		using CFArray cFArray = new CFArray(intPtr);
		CGImageMetadataTag[] array = new CGImageMetadataTag[(long)cFArray.Count];
		for (int i = 0; i < cFArray.Count; i++)
		{
			array[i] = new CGImageMetadataTag(cFArray.GetValue(i), owns: true);
		}
		return array;
	}
}

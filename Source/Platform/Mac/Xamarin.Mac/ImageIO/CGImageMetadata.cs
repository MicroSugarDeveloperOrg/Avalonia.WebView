using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace ImageIO;

[iOS(7, 0)]
public class CGImageMetadata : INativeObject, IDisposable
{
	public IntPtr Handle { get; internal set; }

	public CGImageMetadata(IntPtr handle)
	{
		Handle = handle;
	}

	[Preserve(Conditional = true)]
	internal CGImageMetadata(IntPtr handle, bool owns)
	{
		Handle = handle;
		if (!owns)
		{
			CFObject.CFRetain(Handle);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageMetadataCreateFromXMPData(IntPtr data);

	public CGImageMetadata(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		Handle = CGImageMetadataCreateFromXMPData(data.Handle);
		if (Handle == IntPtr.Zero)
		{
			throw new ArgumentException("data");
		}
	}

	~CGImageMetadata()
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

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO", EntryPoint = "CGImageMetadataGetTypeID")]
	public static extern nint GetTypeID();

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageMetadataCopyStringValueWithPath(IntPtr metadata, IntPtr parent, IntPtr path);

	public NSString GetStringValue(CGImageMetadata parent, NSString path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr parent2 = parent?.Handle ?? IntPtr.Zero;
		IntPtr intPtr = CGImageMetadataCopyStringValueWithPath(Handle, parent2, path.Handle);
		return (intPtr == IntPtr.Zero) ? null : new NSString(intPtr);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageMetadataCopyTags(IntPtr metadata);

	public CGImageMetadataTag[] GetTags()
	{
		IntPtr intPtr = CGImageMetadataCopyTags(Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		using CFArray cFArray = new CFArray(intPtr);
		CGImageMetadataTag[] array = new CGImageMetadataTag[(long)cFArray.Count];
		for (int i = 0; i < cFArray.Count; i++)
		{
			array[i] = new CGImageMetadataTag(cFArray.GetValue(i));
		}
		return array;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageMetadataCopyTagWithPath(IntPtr metadata, IntPtr parent, IntPtr path);

	public CGImageMetadataTag GetTag(CGImageMetadata parent, NSString path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr parent2 = parent?.Handle ?? IntPtr.Zero;
		IntPtr intPtr = CGImageMetadataCopyTagWithPath(Handle, parent2, path.Handle);
		return (intPtr == IntPtr.Zero) ? null : new CGImageMetadataTag(intPtr);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern void CGImageMetadataEnumerateTagsUsingBlock(IntPtr metadata, IntPtr rootPath, IntPtr options, CGImageMetadataTagBlock block);

	public void EnumerateTags(NSString rootPath, CGImageMetadataEnumerateOptions options, CGImageMetadataTagBlock block)
	{
		IntPtr rootPath2 = ((rootPath == null) ? IntPtr.Zero : rootPath.Handle);
		NSDictionary nSDictionary = null;
		if (options != null)
		{
			nSDictionary = options.ToDictionary();
		}
		CGImageMetadataEnumerateTagsUsingBlock(Handle, rootPath2, nSDictionary?.Handle ?? IntPtr.Zero, block);
		if (options != null)
		{
			nSDictionary.Dispose();
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageMetadataCreateXMPData(IntPtr metadata, IntPtr options);

	public NSData CreateXMPData()
	{
		IntPtr intPtr = CGImageMetadataCreateXMPData(Handle, IntPtr.Zero);
		return (intPtr == IntPtr.Zero) ? null : new NSData(intPtr);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageMetadataCopyTagMatchingImageProperty(IntPtr metadata, IntPtr dictionaryName, IntPtr propertyName);

	public CGImageMetadataTag CopyTagMatchingImageProperty(NSString dictionaryName, NSString propertyName)
	{
		if (dictionaryName == null)
		{
			throw new ArgumentNullException("dictionaryName");
		}
		if (propertyName == null)
		{
			throw new ArgumentNullException("propertyName");
		}
		IntPtr intPtr = CGImageMetadataCopyTagMatchingImageProperty(Handle, dictionaryName.Handle, propertyName.Handle);
		return (intPtr == IntPtr.Zero) ? null : new CGImageMetadataTag(intPtr);
	}
}

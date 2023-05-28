using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;

namespace ImageIO;

[iOS(7, 0)]
public class CGMutableImageMetadata : CGImageMetadata
{
	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageMetadataCreateMutable();

	public CGMutableImageMetadata()
		: base(CGImageMetadataCreateMutable())
	{
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	private static extern IntPtr CGImageMetadataCreateMutableCopy(IntPtr metadata);

	public CGMutableImageMetadata(CGImageMetadata metadata)
		: base(CGImageMetadataCreateMutableCopy(metadata.Handle))
	{
		if (metadata == null)
		{
			throw new ArgumentNullException("metadata");
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool CGImageMetadataRegisterNamespaceForPrefix(IntPtr metadata, IntPtr xmlns, IntPtr prefix, out IntPtr error);

	public bool RegisterNamespace(NSString xmlns, NSString prefix, out NSError error)
	{
		if (xmlns == null)
		{
			throw new ArgumentNullException("xmlns");
		}
		if (prefix == null)
		{
			throw new ArgumentNullException("prefix");
		}
		IntPtr error2;
		bool result = CGImageMetadataRegisterNamespaceForPrefix(base.Handle, xmlns.Handle, prefix.Handle, out error2);
		error = ((error2 == IntPtr.Zero) ? null : new NSError(error2));
		return result;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool CGImageMetadataSetTagWithPath(IntPtr metadata, IntPtr parent, IntPtr path, IntPtr tag);

	public bool SetTag(CGImageMetadataTag parent, NSString path, CGImageMetadataTag tag)
	{
		IntPtr parent2 = parent?.Handle ?? IntPtr.Zero;
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (tag == null)
		{
			throw new ArgumentNullException("tag");
		}
		return CGImageMetadataSetTagWithPath(base.Handle, parent2, path.Handle, tag.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool CGImageMetadataSetValueWithPath(IntPtr metadata, IntPtr parent, IntPtr path, IntPtr value);

	public bool SetValue(CGImageMetadataTag parent, NSString path, NSObject value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return SetValue(parent, path, value.Handle);
	}

	public bool SetValue(CGImageMetadataTag parent, NSString path, bool value)
	{
		return SetValue(parent, path, value ? CFBoolean.TrueHandle : CFBoolean.FalseHandle);
	}

	private bool SetValue(CGImageMetadataTag parent, NSString path, IntPtr value)
	{
		IntPtr parent2 = parent?.Handle ?? IntPtr.Zero;
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		return CGImageMetadataSetValueWithPath(base.Handle, parent2, path.Handle, value);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool CGImageMetadataRemoveTagWithPath(IntPtr metadata, IntPtr parent, IntPtr path);

	public bool RemoveTag(CGImageMetadataTag parent, NSString path)
	{
		IntPtr parent2 = parent?.Handle ?? IntPtr.Zero;
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		return CGImageMetadataRemoveTagWithPath(base.Handle, parent2, path.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/ImageIO.framework/ImageIO")]
	[return: MarshalAs(UnmanagedType.I1)]
	private static extern bool CGImageMetadataSetValueMatchingImageProperty(IntPtr metadata, IntPtr dictionaryName, IntPtr propertyName, IntPtr value);

	public bool SetValueMatchingImageProperty(NSString dictionaryName, NSString propertyName, NSObject value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		return SetValueMatchingImageProperty(dictionaryName, propertyName, value.Handle);
	}

	public bool SetValueMatchingImageProperty(NSString dictionaryName, NSString propertyName, bool value)
	{
		return SetValueMatchingImageProperty(dictionaryName, propertyName, value ? CFBoolean.TrueHandle : CFBoolean.FalseHandle);
	}

	private bool SetValueMatchingImageProperty(NSString dictionaryName, NSString propertyName, IntPtr value)
	{
		if (dictionaryName == null)
		{
			throw new ArgumentNullException("dictionaryName");
		}
		if (propertyName == null)
		{
			throw new ArgumentNullException("propertyName");
		}
		return CGImageMetadataSetValueMatchingImageProperty(base.Handle, dictionaryName.Handle, propertyName.Handle, value);
	}
}

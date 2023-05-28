using System.Runtime.InteropServices;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreGraphics;

public class CGPDFObject : INativeObject
{
	public IntPtr Handle { get; private set; }

	public CGPDFObjectType Type => CGPDFObjectGetType(Handle);

	public bool IsNull => Type == CGPDFObjectType.Null;

	public CGPDFObject(IntPtr handle)
	{
		Handle = handle;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern CGPDFObjectType CGPDFObjectGetType(IntPtr pdfobj);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFObjectGetValue(IntPtr pdfobj, CGPDFObjectType type, out byte value);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFObjectGetValue(IntPtr pdfobj, CGPDFObjectType type, out nint value);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFObjectGetValue(IntPtr pdfobj, CGPDFObjectType type, out nfloat value);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFObjectGetValue(IntPtr pdfobj, CGPDFObjectType type, out IntPtr value);

	public bool TryGetValue(out bool value)
	{
		if (CGPDFObjectGetValue(Handle, CGPDFObjectType.Boolean, out byte value2))
		{
			value = value2 != 0;
			return true;
		}
		value = false;
		return false;
	}

	public bool TryGetValue(out nint value)
	{
		return CGPDFObjectGetValue(Handle, CGPDFObjectType.Integer, out value);
	}

	public bool TryGetValue(out nfloat value)
	{
		return CGPDFObjectGetValue(Handle, CGPDFObjectType.Real, out value);
	}

	public bool TryGetValue(out string value)
	{
		if (CGPDFObjectGetValue(Handle, CGPDFObjectType.String, out IntPtr value2))
		{
			value = CGPDFString.ToString(value2);
			return true;
		}
		value = null;
		return false;
	}

	public bool TryGetValue(out CGPDFArray value)
	{
		if (CGPDFObjectGetValue(Handle, CGPDFObjectType.Array, out IntPtr value2))
		{
			value = new CGPDFArray(value2);
			return true;
		}
		value = null;
		return false;
	}

	public bool TryGetValue(out CGPDFDictionary value)
	{
		if (CGPDFObjectGetValue(Handle, CGPDFObjectType.Dictionary, out IntPtr value2))
		{
			value = new CGPDFDictionary(value2);
			return true;
		}
		value = null;
		return false;
	}

	public bool TryGetValue(out CGPDFStream value)
	{
		if (CGPDFObjectGetValue(Handle, CGPDFObjectType.Stream, out IntPtr value2))
		{
			value = new CGPDFStream(value2);
			return true;
		}
		value = null;
		return false;
	}

	public bool TryGetName(out string name)
	{
		if (CGPDFObjectGetValue(Handle, CGPDFObjectType.Name, out IntPtr value))
		{
			name = Marshal.PtrToStringAnsi(value);
			return true;
		}
		name = null;
		return false;
	}

	internal static object FromHandle(IntPtr handle)
	{
		CGPDFObjectType cGPDFObjectType = CGPDFObjectGetType(handle);
		IntPtr value;
		switch (cGPDFObjectType)
		{
		case CGPDFObjectType.Null:
			return null;
		case CGPDFObjectType.Boolean:
		{
			if (CGPDFObjectGetValue(handle, cGPDFObjectType, out byte value3))
			{
				return value3 != 0;
			}
			return null;
		}
		case CGPDFObjectType.Integer:
		{
			if (CGPDFObjectGetValue(handle, cGPDFObjectType, out nint value4))
			{
				return value4;
			}
			return null;
		}
		case CGPDFObjectType.Real:
		{
			if (CGPDFObjectGetValue(handle, cGPDFObjectType, out nfloat value2))
			{
				return value2;
			}
			return null;
		}
		case CGPDFObjectType.Name:
			if (CGPDFObjectGetValue(handle, cGPDFObjectType, out value))
			{
				return Marshal.PtrToStringAnsi(value);
			}
			return null;
		case CGPDFObjectType.String:
			if (CGPDFObjectGetValue(handle, cGPDFObjectType, out value))
			{
				return CGPDFString.ToString(value);
			}
			return null;
		case CGPDFObjectType.Array:
			if (CGPDFObjectGetValue(handle, cGPDFObjectType, out value))
			{
				return new CGPDFArray(value);
			}
			return null;
		case CGPDFObjectType.Dictionary:
			if (CGPDFObjectGetValue(handle, cGPDFObjectType, out value))
			{
				return new CGPDFDictionary(value);
			}
			return null;
		case CGPDFObjectType.Stream:
			if (CGPDFObjectGetValue(handle, cGPDFObjectType, out value))
			{
				return new CGPDFStream(value);
			}
			return null;
		default:
			return null;
		}
	}
}

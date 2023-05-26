using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CoreGraphics;

public class CGPDFDictionary : INativeObject
{
	private delegate void ApplierFunction(string key, IntPtr pdfObject, IntPtr info);

	internal IntPtr handle;

	public IntPtr Handle => handle;

	public int Count => (int)CGPDFDictionaryGetCount(handle);

	public CGPDFDictionary(IntPtr handle)
	{
		this.handle = handle;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFDictionaryGetCount(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFDictionaryGetBoolean(IntPtr handle, string key, out bool result);

	public bool GetBoolean(string key, out bool result)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return CGPDFDictionaryGetBoolean(handle, key, out result);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFDictionaryGetInteger(IntPtr handle, string key, out int result);

	public bool GetInt(string key, out int result)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return CGPDFDictionaryGetInteger(handle, key, out result);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFDictionaryGetNumber(IntPtr handle, string key, out double result);

	public bool GetFloat(string key, out double result)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return CGPDFDictionaryGetNumber(handle, key, out result);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFDictionaryGetName(IntPtr handle, string key, out IntPtr result);

	public bool GetName(string key, out string result)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!CGPDFDictionaryGetName(handle, key, out var result2))
		{
			result = null;
			return false;
		}
		result = Marshal.PtrToStringAnsi(result2);
		return true;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFDictionaryGetDictionary(IntPtr handle, string key, out IntPtr result);

	public bool GetDictionary(string key, out CGPDFDictionary result)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!CGPDFDictionaryGetDictionary(handle, key, out var result2))
		{
			result = null;
			return false;
		}
		result = new CGPDFDictionary(result2);
		return true;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFDictionaryGetStream(IntPtr handle, string key, out IntPtr result);

	public bool GetStream(string key, out CGPDFStream result)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!CGPDFDictionaryGetStream(handle, key, out var result2))
		{
			result = null;
			return false;
		}
		result = new CGPDFStream(result2);
		return true;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFDictionaryGetArray(IntPtr handle, string key, out IntPtr result);

	public bool GetArray(string key, out CGPDFArray array)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!CGPDFDictionaryGetArray(handle, key, out var result))
		{
			array = null;
			return false;
		}
		array = new CGPDFArray(result);
		return true;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFDictionaryApplyFunction(IntPtr dictRef, ApplierFunction function, IntPtr info);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern int CGPDFObjectGetType(IntPtr pdfobj);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFObjectGetValue(IntPtr pdfobj, int type, out byte bvar);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFObjectGetValue(IntPtr pdfobj, int type, out int ivar);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFObjectGetValue(IntPtr pdfobj, int type, out float rvar);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFObjectGetValue(IntPtr pdfobj, int type, out IntPtr ptrvar);

	private static object MapFromCGPdfObject(IntPtr pdfObj)
	{
		IntPtr ptrvar;
		switch (CGPDFObjectGetType(pdfObj))
		{
		case 1:
			return null;
		case 2:
		{
			if (CGPDFObjectGetValue(pdfObj, 2, out byte bvar))
			{
				return bvar != 0;
			}
			return null;
		}
		case 3:
		{
			if (CGPDFObjectGetValue(pdfObj, 3, out int ivar))
			{
				return ivar;
			}
			return null;
		}
		case 4:
		{
			if (CGPDFObjectGetValue(pdfObj, 4, out float rvar))
			{
				return rvar;
			}
			return null;
		}
		case 5:
			if (CGPDFObjectGetValue(pdfObj, 5, out ptrvar))
			{
				return Marshal.PtrToStringAnsi(ptrvar);
			}
			return null;
		case 6:
			if (CGPDFObjectGetValue(pdfObj, 6, out ptrvar))
			{
				return CGPDFString.ToString(ptrvar);
			}
			return null;
		case 7:
			if (CGPDFObjectGetValue(pdfObj, 7, out ptrvar))
			{
				return new CGPDFArray(ptrvar);
			}
			return null;
		case 8:
			if (CGPDFObjectGetValue(pdfObj, 8, out ptrvar))
			{
				return new CGPDFDictionary(ptrvar);
			}
			return null;
		case 9:
			if (CGPDFObjectGetValue(pdfObj, 9, out ptrvar))
			{
				return new CGPDFStream(ptrvar);
			}
			return null;
		default:
			return null;
		}
	}

	private static void ApplyBridge(string key, IntPtr pdfObject, IntPtr info)
	{
		((Action<string, object>)GCHandle.FromIntPtr(info).Target)(key, MapFromCGPdfObject(pdfObject));
	}

	public void Apply(Action<string, object> callback)
	{
		GCHandle value = GCHandle.Alloc(callback);
		CGPDFDictionaryApplyFunction(Handle, ApplyBridge, GCHandle.ToIntPtr(value));
		value.Free();
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFDictionaryGetString(IntPtr handle, string key, out IntPtr result);

	public bool GetString(string key, out string result)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (CGPDFDictionaryGetString(handle, key, out var result2))
		{
			result = CGPDFString.ToString(result2);
			return true;
		}
		result = null;
		return false;
	}
}

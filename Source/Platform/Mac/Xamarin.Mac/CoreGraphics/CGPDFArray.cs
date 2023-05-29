using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace CoreGraphics;

public class CGPDFArray : INativeObject
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public int Count => (int)CGPDFArrayGetCount(handle);

	public CGPDFArray(IntPtr handle)
	{
		this.handle = handle;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFArrayGetCount(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFArrayGetBoolean(IntPtr handle, IntPtr idx, out bool result);

	public bool GetBoolean(int idx, out bool result)
	{
		return CGPDFArrayGetBoolean(handle, (IntPtr)idx, out result);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFArrayGetInteger(IntPtr handle, IntPtr idx, out int result);

	public bool GetInt(int idx, out int result)
	{
		return CGPDFArrayGetInteger(handle, (IntPtr)idx, out result);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFArrayGetNumber(IntPtr handle, IntPtr idx, out double result);

	public bool GetFloat(int idx, out double result)
	{
		return CGPDFArrayGetNumber(handle, (IntPtr)idx, out result);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFArrayGetName(IntPtr handle, IntPtr idx, out IntPtr result);

	public bool GetName(int idx, out string result)
	{
		if (!CGPDFArrayGetName(handle, (IntPtr)idx, out var result2))
		{
			result = null;
			return false;
		}
		result = Marshal.PtrToStringAnsi(result2);
		return true;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFArrayGetDictionary(IntPtr handle, IntPtr idx, out IntPtr result);

	public bool GetDictionary(int idx, out CGPDFDictionary result)
	{
		if (!CGPDFArrayGetDictionary(handle, (IntPtr)idx, out var result2))
		{
			result = null;
			return false;
		}
		result = new CGPDFDictionary(result2);
		return true;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFArrayGetStream(IntPtr handle, IntPtr idx, out IntPtr result);

	public bool GetStream(int idx, out CGPDFStream result)
	{
		if (!CGPDFArrayGetStream(handle, (IntPtr)idx, out var result2))
		{
			result = null;
			return false;
		}
		result = new CGPDFStream(result2);
		return true;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFArrayGetArray(IntPtr handle, IntPtr idx, out IntPtr result);

	public bool GetArray(int idx, out CGPDFArray array)
	{
		if (!CGPDFArrayGetArray(handle, (IntPtr)idx, out var result))
		{
			array = null;
			return false;
		}
		array = new CGPDFArray(result);
		return true;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFArrayGetString(IntPtr handle, IntPtr idx, out IntPtr result);

	public bool GetString(int idx, out string result)
	{
		if (CGPDFArrayGetString(handle, (IntPtr)idx, out var result2))
		{
			result = CGPDFString.ToString(result2);
			return true;
		}
		result = null;
		return false;
	}
}

using System.Runtime.InteropServices;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreGraphics;

public class CGPDFDictionary : INativeObject
{
	private delegate void ApplierFunction(string key, IntPtr value, IntPtr info);

	public delegate void ApplyCallback(string key, object value, object info);

	internal IntPtr handle;

	private static readonly ApplierFunction applyblock_handler = ApplyBridge;

	public IntPtr Handle => handle;

	public int Count => (int)CGPDFDictionaryGetCount(handle);

	public CGPDFDictionary(IntPtr handle)
	{
		this.handle = handle;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nint CGPDFDictionaryGetCount(IntPtr dict);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFDictionaryGetBoolean(IntPtr dict, string key, out bool value);

	public bool GetBoolean(string key, out bool result)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return CGPDFDictionaryGetBoolean(handle, key, out result);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFDictionaryGetInteger(IntPtr dict, string key, out nint value);

	public bool GetInt(string key, out nint result)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return CGPDFDictionaryGetInteger(handle, key, out result);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFDictionaryGetNumber(IntPtr dict, string key, out nfloat value);

	public bool GetFloat(string key, out nfloat result)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return CGPDFDictionaryGetNumber(handle, key, out result);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFDictionaryGetName(IntPtr dict, string key, out IntPtr value);

	public bool GetName(string key, out string result)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr value;
		bool flag = CGPDFDictionaryGetName(handle, key, out value);
		result = (flag ? Marshal.PtrToStringAnsi(value) : null);
		return flag;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFDictionaryGetDictionary(IntPtr dict, string key, out IntPtr result);

	public bool GetDictionary(string key, out CGPDFDictionary result)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr result2;
		bool flag = CGPDFDictionaryGetDictionary(handle, key, out result2);
		result = (flag ? new CGPDFDictionary(result2) : null);
		return flag;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFDictionaryGetStream(IntPtr dict, string key, out IntPtr value);

	public bool GetStream(string key, out CGPDFStream result)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr value;
		bool flag = CGPDFDictionaryGetStream(handle, key, out value);
		result = (flag ? new CGPDFStream(value) : null);
		return flag;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFDictionaryGetArray(IntPtr dict, string key, out IntPtr value);

	public bool GetArray(string key, out CGPDFArray array)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr value;
		bool flag = CGPDFDictionaryGetArray(handle, key, out value);
		array = (flag ? new CGPDFArray(value) : null);
		return flag;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFDictionaryApplyFunction(IntPtr dic, ApplierFunction function, IntPtr info);

	private static void ApplyBridge(string key, IntPtr pdfObject, IntPtr info)
	{
		Tuple<ApplyCallback, object> tuple = (Tuple<ApplyCallback, object>)GCHandle.FromIntPtr(info).Target;
		ApplyCallback item = tuple.Item1;
		item(key, CGPDFObject.FromHandle(pdfObject), tuple.Item2);
	}

	public void Apply(ApplyCallback callback, object info = null)
	{
		Tuple<ApplyCallback, object> value = new Tuple<ApplyCallback, object>(callback, info);
		GCHandle value2 = GCHandle.Alloc(value);
		try
		{
			CGPDFDictionaryApplyFunction(Handle, applyblock_handler, GCHandle.ToIntPtr(value2));
		}
		finally
		{
			value2.Free();
		}
	}

	private static void ApplyBridge2(string key, IntPtr pdfObject, IntPtr info)
	{
		Action<string, CGPDFObject> action = (Action<string, CGPDFObject>)GCHandle.FromIntPtr(info).Target;
		action(key, new CGPDFObject(pdfObject));
	}

	public void Apply(Action<string, CGPDFObject> callback)
	{
		GCHandle value = GCHandle.Alloc(callback);
		CGPDFDictionaryApplyFunction(Handle, ApplyBridge2, GCHandle.ToIntPtr(value));
		value.Free();
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFDictionaryGetString(IntPtr dict, string key, out IntPtr value);

	public bool GetString(string key, out string result)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr value;
		bool flag = CGPDFDictionaryGetString(handle, key, out value);
		result = (flag ? CGPDFString.ToString(value) : null);
		return flag;
	}
}

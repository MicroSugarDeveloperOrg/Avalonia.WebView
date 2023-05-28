using System.Runtime.InteropServices;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreGraphics;

public class CGPDFArray : INativeObject
{
	private delegate bool ApplyBlockHandlerDelegate(IntPtr block, nint index, IntPtr value, IntPtr info);

	public delegate bool ApplyCallback(nint index, object value, object info);

	internal IntPtr handle;

	private static readonly ApplyBlockHandlerDelegate applyblock_handler = ApplyBlockHandler;

	public IntPtr Handle => handle;

	public nint Count => CGPDFArrayGetCount(handle);

	public CGPDFArray(IntPtr handle)
	{
		this.handle = handle;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern nint CGPDFArrayGetCount(IntPtr array);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFArrayGetBoolean(IntPtr array, nint index, out bool value);

	public bool GetBoolean(nint idx, out bool result)
	{
		return CGPDFArrayGetBoolean(handle, idx, out result);
	}

	public bool GetBoolean(int idx, out bool result)
	{
		return CGPDFArrayGetBoolean(handle, idx, out result);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFArrayGetInteger(IntPtr array, nint index, out nint value);

	public bool GetInt(nint idx, out nint result)
	{
		return CGPDFArrayGetInteger(handle, idx, out result);
	}

	public bool GetInt(int idx, out nint result)
	{
		return CGPDFArrayGetInteger(handle, idx, out result);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFArrayGetNumber(IntPtr array, nint index, out nfloat value);

	public bool GetFloat(nint idx, out nfloat result)
	{
		return CGPDFArrayGetNumber(handle, idx, out result);
	}

	public bool GetFloat(int idx, out nfloat result)
	{
		return CGPDFArrayGetNumber(handle, idx, out result);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFArrayGetName(IntPtr array, nint index, out IntPtr value);

	public bool GetName(nint idx, out string result)
	{
		IntPtr value;
		bool flag = CGPDFArrayGetName(handle, idx, out value);
		result = (flag ? Marshal.PtrToStringAnsi(value) : null);
		return flag;
	}

	public bool GetName(int idx, out string result)
	{
		return GetName((nint)idx, out result);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFArrayGetDictionary(IntPtr array, nint index, out IntPtr value);

	public bool GetDictionary(nint idx, out CGPDFDictionary result)
	{
		IntPtr value;
		bool flag = CGPDFArrayGetDictionary(handle, idx, out value);
		result = (flag ? new CGPDFDictionary(value) : null);
		return flag;
	}

	public bool GetDictionary(int idx, out CGPDFDictionary result)
	{
		return GetDictionary((nint)idx, out result);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFArrayGetStream(IntPtr array, nint index, out IntPtr value);

	public bool GetStream(nint idx, out CGPDFStream result)
	{
		IntPtr value;
		bool flag = CGPDFArrayGetStream(handle, idx, out value);
		result = (flag ? new CGPDFStream(value) : null);
		return flag;
	}

	public bool GetStream(int idx, out CGPDFStream result)
	{
		return GetStream((nint)idx, out result);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFArrayGetArray(IntPtr array, nint index, out IntPtr value);

	public bool GetArray(nint idx, out CGPDFArray array)
	{
		IntPtr value;
		bool flag = CGPDFArrayGetArray(handle, idx, out value);
		array = (flag ? new CGPDFArray(value) : null);
		return flag;
	}

	public bool GetArray(int idx, out CGPDFArray array)
	{
		return GetArray((nint)idx, out array);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern bool CGPDFArrayGetString(IntPtr array, nint index, out IntPtr value);

	public bool GetString(nint idx, out string result)
	{
		IntPtr value;
		bool flag = CGPDFArrayGetString(handle, idx, out value);
		result = (flag ? CGPDFString.ToString(value) : null);
		return flag;
	}

	public bool GetString(int idx, out string result)
	{
		return GetString((nint)idx, out result);
	}

	private unsafe static bool ApplyBlockHandler(IntPtr block, nint index, IntPtr value, IntPtr info)
	{
		return ((ApplyCallback)((BlockLiteral*)(void*)block)->Target)?.Invoke(index, CGPDFObject.FromHandle(value), (info == IntPtr.Zero) ? null : GCHandle.FromIntPtr(info).Target) ?? false;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	[iOS(12, 0)]
	[Mac(10, 14)]
	[TV(12, 0)]
	[Watch(5, 0)]
	private static extern bool CGPDFArrayApplyBlock(IntPtr array, ref BlockLiteral block, IntPtr info);

	[iOS(12, 0)]
	[Mac(10, 14)]
	[TV(12, 0)]
	[Watch(5, 0)]
	[BindingImpl(BindingImplOptions.Optimizable)]
	public bool Apply(ApplyCallback callback, object info = null)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral block = default(BlockLiteral);
		block.SetupBlockUnsafe(applyblock_handler, callback);
		GCHandle value = ((info == null) ? default(GCHandle) : GCHandle.Alloc(info));
		try
		{
			return CGPDFArrayApplyBlock(handle, ref block, (info == null) ? IntPtr.Zero : GCHandle.ToIntPtr(value));
		}
		finally
		{
			block.CleanupBlock();
			if (info != null)
			{
				value.Free();
			}
		}
	}
}

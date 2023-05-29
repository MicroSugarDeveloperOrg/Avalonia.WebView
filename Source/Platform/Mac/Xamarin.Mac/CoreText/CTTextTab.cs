using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreText;

[Since(3, 2)]
public class CTTextTab : INativeObject, IDisposable
{
	internal IntPtr handle;

	public IntPtr Handle => handle;

	public CTTextAlignment TextAlignment => CTTextTabGetAlignment(handle);

	public double Location => CTTextTabGetLocation(handle);

	internal CTTextTab(IntPtr handle, bool owns)
	{
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.ArgumentNull(this, "handle");
		}
		this.handle = handle;
		if (!owns)
		{
			CFObject.CFRetain(handle);
		}
	}

	~CTTextTab()
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

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTTextTabCreate(CTTextAlignment alignment, double location, IntPtr options);

	public CTTextTab(CTTextAlignment alignment, double location)
		: this(alignment, location, null)
	{
	}

	public CTTextTab(CTTextAlignment alignment, double location, CTTextTabOptions options)
	{
		handle = CTTextTabCreate(alignment, location, options?.Dictionary.Handle ?? IntPtr.Zero);
		if (handle == IntPtr.Zero)
		{
			throw ConstructorError.Unknown(this);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern CTTextAlignment CTTextTabGetAlignment(IntPtr tab);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern double CTTextTabGetLocation(IntPtr tab);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTTextTabGetOptions(IntPtr tab);

	public CTTextTabOptions GetOptions()
	{
		IntPtr intPtr = CTTextTabGetOptions(handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CTTextTabOptions((NSDictionary)Runtime.GetNSObject(intPtr));
	}
}

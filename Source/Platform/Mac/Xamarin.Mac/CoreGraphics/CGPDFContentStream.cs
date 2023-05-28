using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGPDFContentStream : INativeObject, IDisposable
{
	public IntPtr Handle { get; private set; }

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFContentStreamCreateWithPage(IntPtr page);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFContentStreamCreateWithStream(IntPtr stream, IntPtr streamResources, IntPtr parent);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFContentStreamRetain(IntPtr cs);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern void CGPDFContentStreamRelease(IntPtr cs);

	public CGPDFContentStream(IntPtr handle)
	{
		CGPDFContentStreamRetain(handle);
		Handle = handle;
	}

	[Preserve(Conditional = true)]
	internal CGPDFContentStream(IntPtr handle, bool owns)
	{
		if (!owns)
		{
			CGPDFContentStreamRetain(handle);
		}
		Handle = handle;
	}

	public CGPDFContentStream(CGPDFPage page)
	{
		if (page == null)
		{
			throw new ArgumentNullException("page");
		}
		Handle = CGPDFContentStreamCreateWithPage(page.Handle);
	}

	public CGPDFContentStream(CGPDFStream stream, NSDictionary streamResources = null, CGPDFContentStream parent = null)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		IntPtr streamResources2 = streamResources?.Handle ?? IntPtr.Zero;
		IntPtr parent2 = parent?.Handle ?? IntPtr.Zero;
		Handle = CGPDFContentStreamCreateWithStream(stream.Handle, streamResources2, parent2);
	}

	~CGPDFContentStream()
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
			CGPDFContentStreamRelease(Handle);
			Handle = IntPtr.Zero;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFContentStreamGetStreams(IntPtr cs);

	public CGPDFStream[] GetStreams()
	{
		using CFArray cFArray = new CFArray(CGPDFContentStreamGetStreams(Handle));
		CGPDFStream[] array = new CGPDFStream[(long)cFArray.Count];
		for (int i = 0; i < cFArray.Count; i++)
		{
			array[i] = new CGPDFStream(cFArray.GetValue(i));
		}
		return array;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics")]
	private static extern IntPtr CGPDFContentStreamGetResource(IntPtr cs, string category, string name);

	public CGPDFObject GetResource(string category, string name)
	{
		if (category == null)
		{
			throw new ArgumentNullException("category");
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr intPtr = CGPDFContentStreamGetResource(Handle, category, name);
		return (intPtr == IntPtr.Zero) ? null : new CGPDFObject(intPtr);
	}
}

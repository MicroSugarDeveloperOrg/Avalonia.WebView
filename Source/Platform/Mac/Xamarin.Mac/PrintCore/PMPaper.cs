using System;
using System.Runtime.InteropServices;
using CoreFoundation;

namespace PrintCore;

public class PMPaper : PMPrintCoreBase
{
	public string ID
	{
		get
		{
			if (PMPaperGetID(handle, out var str) != 0)
			{
				return null;
			}
			return CFString.FetchString(str);
		}
	}

	public double Width
	{
		get
		{
			if (PMPaperGetWidth(handle, out var v) != 0)
			{
				return 0.0;
			}
			return v;
		}
	}

	public double Height
	{
		get
		{
			if (PMPaperGetHeight(handle, out var v) != 0)
			{
				return 0.0;
			}
			return v;
		}
	}

	public PMPaperMargins? Margins
	{
		get
		{
			if (PMPaperGetMargins(handle, out var margins) != 0)
			{
				return null;
			}
			return margins;
		}
	}

	internal PMPaper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMPaperGetID(IntPtr handle, out IntPtr str);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMPaperGetWidth(IntPtr handle, out double v);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMPaperGetHeight(IntPtr handle, out double v);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMPaperGetMargins(IntPtr handle, out PMPaperMargins margins);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMPaperCreateLocalizedName(IntPtr handle, IntPtr printer, out IntPtr name);

	public string GetLocalizedName(PMPrinter printer)
	{
		if (printer == null)
		{
			throw new ArgumentNullException("printer");
		}
		if (PMPaperCreateLocalizedName(handle, printer.handle, out var name) != 0)
		{
			return null;
		}
		string result = CFString.FetchString(name);
		CFObject.CFRelease(name);
		return result;
	}
}

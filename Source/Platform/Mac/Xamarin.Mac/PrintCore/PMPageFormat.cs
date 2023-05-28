using System;
using System.Runtime.InteropServices;

namespace PrintCore;

public class PMPageFormat : PMPrintCoreBase
{
	public PMOrientation Orientation
	{
		get
		{
			if (PMGetOrientation(handle, out var orientation) == PMStatusCode.Ok)
			{
				return orientation;
			}
			return PMOrientation.Portrait;
		}
		set
		{
			PMSetOrientation(handle, value, 0);
		}
	}

	public PMRect AdjustedPageRect
	{
		get
		{
			if (PMGetAdjustedPageRect(handle, out var pageRect) == PMStatusCode.Ok)
			{
				return pageRect;
			}
			return new PMRect(0.0, 0.0, 0.0, 0.0);
		}
	}

	public PMRect AdjustedPaperRect
	{
		get
		{
			if (PMGetAdjustedPaperRect(handle, out var pageRect) == PMStatusCode.Ok)
			{
				return pageRect;
			}
			return new PMRect(0.0, 0.0, 0.0, 0.0);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMCreatePageFormat(out IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMCreatePageFormatWithPMPaper(out IntPtr handle, IntPtr paper);

	internal PMPageFormat(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	public PMPageFormat(PMPaper paper = null)
	{
		IntPtr intPtr;
		PMStatusCode pMStatusCode = ((paper != null) ? PMCreatePageFormatWithPMPaper(out intPtr, paper.Handle) : PMCreatePageFormat(out intPtr));
		if (pMStatusCode == PMStatusCode.Ok)
		{
			handle = intPtr;
			return;
		}
		throw new PMPrintException(pMStatusCode);
	}

	public static PMStatusCode TryCreate(out PMPageFormat pageFormat, PMPaper paper = null)
	{
		IntPtr intPtr;
		PMStatusCode pMStatusCode = ((paper != null) ? PMCreatePageFormatWithPMPaper(out intPtr, paper.Handle) : PMCreatePageFormat(out intPtr));
		if (pMStatusCode == PMStatusCode.Ok)
		{
			pageFormat = new PMPageFormat(intPtr, owns: true);
			return PMStatusCode.Ok;
		}
		pageFormat = null;
		return pMStatusCode;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMSetOrientation(IntPtr handle, PMOrientation orientation, byte setToFalse);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMGetOrientation(IntPtr handle, out PMOrientation orientation);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMGetAdjustedPageRect(IntPtr pageFormat, out PMRect pageRect);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMGetAdjustedPaperRect(IntPtr pageFormat, out PMRect pageRect);
}

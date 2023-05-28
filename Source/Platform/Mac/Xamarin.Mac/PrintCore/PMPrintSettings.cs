using System;
using System.Runtime.InteropServices;

namespace PrintCore;

public class PMPrintSettings : PMPrintCoreBase
{
	public uint FirstPage
	{
		get
		{
			uint first = 0u;
			PMGetFirstPage(handle, out first);
			return first;
		}
		set
		{
			PMSetFirstPage(handle, value, 0);
		}
	}

	public uint LastPage
	{
		get
		{
			uint last = 0u;
			PMGetLastPage(handle, out last);
			return last;
		}
		set
		{
			PMSetLastPage(handle, value, 0);
		}
	}

	public uint Copies
	{
		get
		{
			if (PMGetCopies(handle, out var copies) == PMStatusCode.Ok)
			{
				return copies;
			}
			return 0u;
		}
		set
		{
			PMSetCopies(handle, value, 0);
		}
	}

	public bool Collate
	{
		get
		{
			if (PMGetCollate(handle, out var collate) == PMStatusCode.Ok)
			{
				return collate != 0;
			}
			return false;
		}
		set
		{
			PMSetCollate(handle, (byte)(value ? 1u : 0u));
		}
	}

	public PMDuplexMode DuplexMode
	{
		get
		{
			if (PMGetDuplex(handle, out var mode) == PMStatusCode.Ok)
			{
				return mode;
			}
			return PMDuplexMode.None;
		}
		set
		{
			PMSetDuplex(handle, value);
		}
	}

	public double Scale
	{
		get
		{
			if (PMGetScale(handle, out var mode) == PMStatusCode.Ok)
			{
				return mode;
			}
			return 100.0;
		}
		set
		{
			PMSetScale(handle, value);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMCreatePrintSettings(out IntPtr session);

	internal PMPrintSettings(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	public PMPrintSettings()
	{
		IntPtr session;
		PMStatusCode pMStatusCode = PMCreatePrintSettings(out session);
		if (pMStatusCode == PMStatusCode.Ok)
		{
			handle = session;
			return;
		}
		throw new PMPrintException(pMStatusCode);
	}

	public static PMStatusCode TryCreate(out PMPrintSettings settings)
	{
		IntPtr session;
		PMStatusCode pMStatusCode = PMCreatePrintSettings(out session);
		if (pMStatusCode == PMStatusCode.Ok)
		{
			settings = new PMPrintSettings(session, owns: true);
			return PMStatusCode.Ok;
		}
		settings = null;
		return pMStatusCode;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMGetFirstPage(IntPtr handle, out uint first);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMSetFirstPage(IntPtr handle, uint first, byte lockb);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMGetLastPage(IntPtr handle, out uint last);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMSetLastPage(IntPtr handle, uint last, byte lockb);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMGetPageRange(IntPtr handle, out uint minPage, out uint maxPage);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMSetPageRange(IntPtr handle, uint minPage, uint maxPage);

	public PMStatusCode GetPageRange(out uint minPage, out uint maxPage)
	{
		return PMGetPageRange(handle, out minPage, out maxPage);
	}

	public PMStatusCode SetPageRange(uint minPage, uint maxPage)
	{
		return PMSetPageRange(handle, minPage, maxPage);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMCopyPrintSettings(IntPtr source, IntPtr dest);

	public PMStatusCode CopySettings(PMPrintSettings destination)
	{
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		return PMCopyPrintSettings(handle, destination.handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMGetCopies(IntPtr handle, out uint copies);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMSetCopies(IntPtr handle, uint copies, byte elock);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMGetCollate(IntPtr handle, out byte collate);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMSetCollate(IntPtr handle, byte collate);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMGetDuplex(IntPtr handle, out PMDuplexMode mode);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMSetDuplex(IntPtr handle, PMDuplexMode mode);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMGetScale(IntPtr handle, out double mode);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMSetScale(IntPtr handle, double scale);
}

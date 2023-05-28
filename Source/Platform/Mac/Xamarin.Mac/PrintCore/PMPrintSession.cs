using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using Foundation;

namespace PrintCore;

public class PMPrintSession : PMPrintCoreBase
{
	public PMStatusCode SessionError
	{
		get
		{
			return PMSessionError(handle);
		}
		set
		{
			PMSessionSetError(handle, value);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMCreateSession(out IntPtr session);

	internal PMPrintSession(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	public PMPrintSession()
	{
		IntPtr session;
		PMStatusCode pMStatusCode = PMCreateSession(out session);
		if (pMStatusCode == PMStatusCode.Ok)
		{
			handle = session;
			return;
		}
		throw new PMPrintException(pMStatusCode);
	}

	public static PMStatusCode TryCreate(out PMPrintSession session)
	{
		IntPtr session2;
		PMStatusCode pMStatusCode = PMCreateSession(out session2);
		if (pMStatusCode == PMStatusCode.Ok)
		{
			session = new PMPrintSession(session2, owns: true);
			return PMStatusCode.Ok;
		}
		session = null;
		return pMStatusCode;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMSessionError(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMSessionSetError(IntPtr handle, PMStatusCode code);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMSessionDefaultPrintSettings(IntPtr session, IntPtr settings);

	public void AssignDefaultSettings(PMPrintSettings settings)
	{
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		PMSessionDefaultPrintSettings(handle, settings.handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMSessionDefaultPageFormat(IntPtr session, IntPtr pageFormat);

	public void AssignDefaultPageFormat(PMPageFormat pageFormat)
	{
		if (pageFormat == null)
		{
			throw new ArgumentNullException("pageFormat");
		}
		PMSessionDefaultPageFormat(handle, pageFormat.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMSessionCreatePrinterList(IntPtr printSession, out IntPtr printerListArray, out int index, out IntPtr printer);

	internal static string[] FetchArray(IntPtr cfArrayString, bool owns)
	{
		CFArray cFArray = new CFArray(cfArrayString, owns);
		int num = (int)cFArray.Count;
		string[] array = new string[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = CFString.FetchString(cFArray.GetValue(i));
		}
		cFArray.Dispose();
		return array;
	}

	public PMStatusCode CreatePrinterList(out string[] printerList, out int index, out PMPrinter printer)
	{
		IntPtr printerListArray;
		IntPtr printer2;
		PMStatusCode pMStatusCode = PMSessionCreatePrinterList(handle, out printerListArray, out index, out printer2);
		if (pMStatusCode != 0)
		{
			printerList = null;
			printer = null;
			return pMStatusCode;
		}
		printerList = NSArray.StringArrayFromHandle(printerListArray);
		CFObject.CFRelease(printerListArray);
		if (printer2 != IntPtr.Zero)
		{
			printer = new PMPrinter(printer2, owns: false);
		}
		else
		{
			printer = null;
		}
		return PMStatusCode.Ok;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMSessionValidatePrintSettings(IntPtr handle, IntPtr printSettings, out byte changed);

	public PMStatusCode ValidatePrintSettings(PMPrintSettings settings, out bool changed)
	{
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		byte changed2;
		PMStatusCode pMStatusCode = PMSessionValidatePrintSettings(handle, settings.handle, out changed2);
		if (pMStatusCode != 0)
		{
			changed = false;
			return pMStatusCode;
		}
		changed = changed2 != 0;
		return pMStatusCode;
	}
}

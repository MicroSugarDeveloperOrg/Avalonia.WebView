using System;
using System.Runtime.InteropServices;
using CoreFoundation;

namespace PrintCore;

public class PMServer : PMPrintCoreBase
{
	private PMServer()
	{
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMServerLaunchPrinterBrowser(IntPtr server, IntPtr dictFutureUse);

	public static PMStatusCode LaunchPrinterBrowser()
	{
		return PMServerLaunchPrinterBrowser(IntPtr.Zero, IntPtr.Zero);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMServerCreatePrinterList(IntPtr server, out IntPtr printerListArray);

	public static PMStatusCode CreatePrinterList(out PMPrinter[] printerList)
	{
		IntPtr printerListArray;
		PMStatusCode pMStatusCode = PMServerCreatePrinterList(IntPtr.Zero, out printerListArray);
		if (pMStatusCode != 0)
		{
			printerList = null;
			return pMStatusCode;
		}
		int num = (int)CFArray.GetCount(printerListArray);
		printerList = new PMPrinter[num];
		for (int i = 0; i < num; i++)
		{
			printerList[i] = new PMPrinter(CFArray.CFArrayGetValueAtIndex(printerListArray, i), owns: false);
		}
		CFObject.CFRelease(printerListArray);
		return PMStatusCode.Ok;
	}
}

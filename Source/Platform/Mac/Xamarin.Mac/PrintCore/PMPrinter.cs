using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace PrintCore;

public class PMPrinter : PMPrintCoreBase
{
	public string Name => CFString.FetchString(PMPrinterGetName(handle));

	public NSUrl DeviceUrl
	{
		get
		{
			if (PMPrinterCopyDeviceURI(handle, out var url) != 0)
			{
				return null;
			}
			return Runtime.GetNSObject<NSUrl>(url, owns: true);
		}
	}

	public string MakeAndModel
	{
		get
		{
			if (PMPrinterGetMakeAndModelName(handle, out var makeAndModel) == PMStatusCode.Ok)
			{
				return CFString.FetchString(makeAndModel);
			}
			return null;
		}
	}

	public PMPrinterState PrinterState
	{
		get
		{
			PMPrinterState state;
			PMStatusCode pMStatusCode = PMPrinterGetState(handle, out state);
			if (pMStatusCode == PMStatusCode.Ok)
			{
				return state;
			}
			return (PMPrinterState)pMStatusCode;
		}
	}

	public PMPaper[] PaperList
	{
		get
		{
			if (PMPrinterGetPaperList(handle, out var arrayStr) != 0)
			{
				return new PMPaper[0];
			}
			int num = (int)CFArray.GetCount(arrayStr);
			PMPaper[] array = new PMPaper[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = new PMPaper(CFArray.CFArrayGetValueAtIndex(arrayStr, i), owns: false);
			}
			return array;
		}
	}

	public bool IsFavorite => PMPrinterIsFavorite(handle) != 0;

	public bool IsDefault => PMPrinterIsDefault(handle) != 0;

	public bool IsPostScriptCapable => PMPrinterIsPostScriptCapable(handle) != 0;

	public bool IsPostScriptPrinter
	{
		get
		{
			if (PMPrinterIsPostScriptPrinter(handle, out var isps) == PMStatusCode.Ok)
			{
				return isps != 0;
			}
			return false;
		}
	}

	public bool IsRemote
	{
		get
		{
			if (PMPrinterIsRemote(handle, out var isrem) == PMStatusCode.Ok)
			{
				return isrem != 0;
			}
			return false;
		}
	}

	public string Id => CFString.FetchString(PMPrinterGetID(handle));

	public string HostName
	{
		get
		{
			if (PMPrinterCopyHostName(handle, out var hostName) != 0)
			{
				return null;
			}
			return CFString.FetchString(hostName, releaseHandle: true);
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMCreateGenericPrinter(out IntPtr session);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern IntPtr PMPrinterCreateFromPrinterID(IntPtr id);

	internal PMPrinter(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	public PMPrinter()
	{
		IntPtr session;
		PMStatusCode pMStatusCode = PMCreateGenericPrinter(out session);
		if (pMStatusCode == PMStatusCode.Ok)
		{
			handle = session;
			return;
		}
		throw new PMPrintException(pMStatusCode);
	}

	public PMPrinter(string printerId)
	{
		using CFString cFString = new CFString(printerId);
		IntPtr intPtr = PMPrinterCreateFromPrinterID(cFString.Handle);
		if (intPtr == IntPtr.Zero)
		{
			throw new PMPrintException(PMStatusCode.InvalidPrinter);
		}
		handle = intPtr;
	}

	public static PMStatusCode TryCreate(out PMPrinter printer)
	{
		IntPtr session;
		PMStatusCode pMStatusCode = PMCreateGenericPrinter(out session);
		if (pMStatusCode == PMStatusCode.Ok)
		{
			printer = new PMPrinter(session, owns: true);
			return PMStatusCode.Ok;
		}
		printer = null;
		return pMStatusCode;
	}

	public static PMPrinter TryCreate(string printerId)
	{
		using CFString cFString = new CFString(printerId);
		IntPtr intPtr = PMPrinterCreateFromPrinterID(cFString.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new PMPrinter(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern IntPtr PMPrinterGetName(IntPtr handle);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMPrinterCopyDeviceURI(IntPtr handle, out IntPtr url);

	public PMStatusCode TryGetDeviceUrl(out NSUrl url)
	{
		IntPtr url2;
		PMStatusCode pMStatusCode = PMPrinterCopyDeviceURI(handle, out url2);
		if (pMStatusCode != 0)
		{
			url = null;
			return pMStatusCode;
		}
		url = Runtime.GetNSObject<NSUrl>(url2, owns: true);
		return PMStatusCode.Ok;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMPrinterGetMakeAndModelName(IntPtr printer, out IntPtr makeAndModel);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMPrinterGetState(IntPtr printer, out PMPrinterState state);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMPrinterGetMimeTypes(IntPtr printer, IntPtr settings, out IntPtr arrayStr);

	public PMStatusCode TryGetMimeTypes(PMPrintSettings settings, out string[] mimeTypes)
	{
		IntPtr arrayStr;
		PMStatusCode pMStatusCode = PMPrinterGetMimeTypes(handle, settings?.Handle ?? IntPtr.Zero, out arrayStr);
		if (pMStatusCode != 0)
		{
			mimeTypes = null;
			return pMStatusCode;
		}
		mimeTypes = NSArray.StringArrayFromHandle(arrayStr);
		return PMStatusCode.Ok;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMPrinterGetPaperList(IntPtr printer, out IntPtr arrayStr);

	public PMStatusCode TryGetPaperList(out PMPaper[] paperList)
	{
		IntPtr arrayStr;
		PMStatusCode pMStatusCode = PMPrinterGetPaperList(handle, out arrayStr);
		if (pMStatusCode != 0)
		{
			paperList = null;
			return pMStatusCode;
		}
		int num = (int)CFArray.GetCount(arrayStr);
		paperList = new PMPaper[num];
		for (int i = 0; i < num; i++)
		{
			paperList[i] = new PMPaper(CFArray.CFArrayGetValueAtIndex(arrayStr, i), owns: false);
		}
		return PMStatusCode.Ok;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMPrinterPrintWithFile(IntPtr handle, IntPtr settings, IntPtr pageFormat, IntPtr strMimeType, IntPtr fileUrl);

	public PMStatusCode TryPrintFile(PMPrintSettings settings, PMPageFormat pageFormat, NSUrl fileUrl, string mimeType = null)
	{
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		if (fileUrl == null)
		{
			throw new ArgumentNullException("fileUrl");
		}
		IntPtr intPtr = CFString.LowLevelCreate(mimeType);
		PMStatusCode result = PMPrinterPrintWithFile(handle, settings.handle, pageFormat?.handle ?? IntPtr.Zero, intPtr, fileUrl.Handle);
		if (intPtr != IntPtr.Zero)
		{
			CFObject.CFRelease(intPtr);
		}
		return result;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMPrinterPrintWithProvider(IntPtr printer, IntPtr settings, IntPtr pageFormat, IntPtr strMimeType, IntPtr cgDataProvider);

	public PMStatusCode TryPrintFromProvider(PMPrintSettings settings, PMPageFormat pageFormat, CGDataProvider provider, string mimeType = null)
	{
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		if (provider == null)
		{
			throw new ArgumentNullException("provider");
		}
		IntPtr intPtr = CFString.LowLevelCreate(mimeType);
		PMStatusCode result = PMPrinterPrintWithProvider(handle, settings.handle, pageFormat?.handle ?? IntPtr.Zero, intPtr, provider.Handle);
		if (intPtr != IntPtr.Zero)
		{
			CFObject.CFRelease(intPtr);
		}
		return result;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMPrinterGetOutputResolution(IntPtr printer, IntPtr printSettings, out PMResolution resolutionP);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMPrinterSetOutputResolution(IntPtr printer, IntPtr printSettings, ref PMResolution resolutionP);

	public PMResolution GetOutputResolution(PMPrintSettings settings)
	{
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		if (PMPrinterGetOutputResolution(handle, settings.Handle, out var resolutionP) == PMStatusCode.Ok)
		{
			return resolutionP;
		}
		return new PMResolution(0.0, 0.0);
	}

	public void SetOutputResolution(PMPrintSettings settings, PMResolution res)
	{
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		PMPrinterSetOutputResolution(handle, settings.Handle, ref res);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMPrinterSetDefault(IntPtr printer);

	public PMStatusCode SetDefault()
	{
		return PMPrinterSetDefault(handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern byte PMPrinterIsFavorite(IntPtr printer);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern byte PMPrinterIsDefault(IntPtr printer);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern byte PMPrinterIsPostScriptCapable(IntPtr printer);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMPrinterIsPostScriptPrinter(IntPtr printer, out byte isps);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMPrinterIsRemote(IntPtr printer, out byte isrem);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern IntPtr PMPrinterGetID(IntPtr printer);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/PrintCore.framework/PrintCore")]
	private static extern PMStatusCode PMPrinterCopyHostName(IntPtr printer, out IntPtr hostName);
}

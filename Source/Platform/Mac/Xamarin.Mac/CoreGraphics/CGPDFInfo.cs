using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGPDFInfo : CGPDFPageInfo
{
	private static IntPtr kCGPDFContextTitle;

	private static IntPtr kCGPDFContextAuthor;

	private static IntPtr kCGPDFContextSubject;

	private static IntPtr kCGPDFContextKeywords;

	private static IntPtr kCGPDFContextCreator;

	private static IntPtr kCGPDFContextOwnerPassword;

	private static IntPtr kCGPDFContextUserPassword;

	private static IntPtr kCGPDFContextEncryptionKeyLength;

	private static IntPtr kCGPDFContextAllowsPrinting;

	private static IntPtr kCGPDFContextAllowsCopying;

	public string Title { get; set; }

	public string Author { get; set; }

	public string Subject { get; set; }

	public string[] Keywords { get; set; }

	public string Creator { get; set; }

	public string OwnerPassword { get; set; }

	public string UserPassword { get; set; }

	public int? EncryptionKeyLength { get; set; }

	public bool? AllowsPrinting { get; set; }

	public bool? AllowsCopying { get; set; }

	static CGPDFInfo()
	{
		IntPtr handle = Dlfcn.dlopen("/System/Library/Frameworks/ApplicationServices.framework/Versions/A/Frameworks/CoreGraphics.framework/CoreGraphics", 0);
		try
		{
			kCGPDFContextTitle = Dlfcn.GetIntPtr(handle, "kCGPDFContextTitle");
			kCGPDFContextAuthor = Dlfcn.GetIntPtr(handle, "kCGPDFContextAuthor");
			kCGPDFContextSubject = Dlfcn.GetIntPtr(handle, "kCGPDFContextSubject");
			kCGPDFContextKeywords = Dlfcn.GetIntPtr(handle, "kCGPDFContextKeywords");
			kCGPDFContextCreator = Dlfcn.GetIntPtr(handle, "kCGPDFContextCreator");
			kCGPDFContextOwnerPassword = Dlfcn.GetIntPtr(handle, "kCGPDFContextOwnerPassword");
			kCGPDFContextUserPassword = Dlfcn.GetIntPtr(handle, "kCGPDFContextUserPassword");
			kCGPDFContextEncryptionKeyLength = Dlfcn.GetIntPtr(handle, "kCGPDFContextEncryptionKeyLength");
			kCGPDFContextAllowsPrinting = Dlfcn.GetIntPtr(handle, "kCGPDFContextAllowsPrinting");
			kCGPDFContextAllowsCopying = Dlfcn.GetIntPtr(handle, "kCGPDFContextAllowsCopying");
		}
		finally
		{
			Dlfcn.dlclose(handle);
		}
	}

	internal override NSMutableDictionary ToDictionary()
	{
		NSMutableDictionary nSMutableDictionary = base.ToDictionary();
		if (Title != null)
		{
			nSMutableDictionary.LowlevelSetObject((NSString)Title, kCGPDFContextTitle);
		}
		if (Author != null)
		{
			nSMutableDictionary.LowlevelSetObject((NSString)Author, kCGPDFContextAuthor);
		}
		if (Subject != null)
		{
			nSMutableDictionary.LowlevelSetObject((NSString)Subject, kCGPDFContextSubject);
		}
		if (Keywords != null && Keywords.Length != 0)
		{
			if (Keywords.Length == 1)
			{
				nSMutableDictionary.LowlevelSetObject((NSString)Keywords[0], kCGPDFContextKeywords);
			}
			else
			{
				nSMutableDictionary.LowlevelSetObject(NSArray.FromStrings(Keywords), kCGPDFContextKeywords);
			}
		}
		if (Creator != null)
		{
			nSMutableDictionary.LowlevelSetObject((NSString)Creator, kCGPDFContextCreator);
		}
		if (OwnerPassword != null)
		{
			nSMutableDictionary.LowlevelSetObject((NSString)OwnerPassword, kCGPDFContextOwnerPassword);
		}
		if (UserPassword != null)
		{
			nSMutableDictionary.LowlevelSetObject((NSString)UserPassword, kCGPDFContextUserPassword);
		}
		if (EncryptionKeyLength.HasValue)
		{
			nSMutableDictionary.LowlevelSetObject(NSNumber.FromInt32(EncryptionKeyLength.Value), kCGPDFContextEncryptionKeyLength);
		}
		if (AllowsPrinting.HasValue && !AllowsPrinting.Value)
		{
			nSMutableDictionary.LowlevelSetObject(CFBoolean.False.Handle, kCGPDFContextAllowsPrinting);
		}
		if (AllowsCopying.HasValue && !AllowsCopying.Value)
		{
			nSMutableDictionary.LowlevelSetObject(CFBoolean.False.Handle, kCGPDFContextAllowsCopying);
		}
		return nSMutableDictionary;
	}
}

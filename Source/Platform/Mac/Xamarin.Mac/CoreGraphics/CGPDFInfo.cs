using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreGraphics;

public class CGPDFInfo : CGPDFPageInfo
{
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

	public CGPDFAccessPermissions? AccessPermissions { get; set; }

	[Field("kCGPDFContextAccessPermissions", "CoreGraphics")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	internal static IntPtr kCGPDFContextAccessPermissions
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.CoreGraphics.Handle, "kCGPDFContextAccessPermissions");
		}
	}

	[Field("kCGPDFContextAllowsCopying", "CoreGraphics")]
	internal static IntPtr kCGPDFContextAllowsCopying => Dlfcn.GetIntPtr(Libraries.CoreGraphics.Handle, "kCGPDFContextAllowsCopying");

	[Field("kCGPDFContextAllowsPrinting", "CoreGraphics")]
	internal static IntPtr kCGPDFContextAllowsPrinting => Dlfcn.GetIntPtr(Libraries.CoreGraphics.Handle, "kCGPDFContextAllowsPrinting");

	[Field("kCGPDFContextAuthor", "CoreGraphics")]
	internal static IntPtr kCGPDFContextAuthor => Dlfcn.GetIntPtr(Libraries.CoreGraphics.Handle, "kCGPDFContextAuthor");

	[Field("kCGPDFContextCreator", "CoreGraphics")]
	internal static IntPtr kCGPDFContextCreator => Dlfcn.GetIntPtr(Libraries.CoreGraphics.Handle, "kCGPDFContextCreator");

	[Field("kCGPDFContextEncryptionKeyLength", "CoreGraphics")]
	internal static IntPtr kCGPDFContextEncryptionKeyLength => Dlfcn.GetIntPtr(Libraries.CoreGraphics.Handle, "kCGPDFContextEncryptionKeyLength");

	[Field("kCGPDFContextKeywords", "CoreGraphics")]
	internal static IntPtr kCGPDFContextKeywords => Dlfcn.GetIntPtr(Libraries.CoreGraphics.Handle, "kCGPDFContextKeywords");

	[Field("kCGPDFContextOwnerPassword", "CoreGraphics")]
	internal static IntPtr kCGPDFContextOwnerPassword => Dlfcn.GetIntPtr(Libraries.CoreGraphics.Handle, "kCGPDFContextOwnerPassword");

	[Field("kCGPDFContextSubject", "CoreGraphics")]
	internal static IntPtr kCGPDFContextSubject => Dlfcn.GetIntPtr(Libraries.CoreGraphics.Handle, "kCGPDFContextSubject");

	[Field("kCGPDFContextTitle", "CoreGraphics")]
	internal static IntPtr kCGPDFContextTitle => Dlfcn.GetIntPtr(Libraries.CoreGraphics.Handle, "kCGPDFContextTitle");

	[Field("kCGPDFContextUserPassword", "CoreGraphics")]
	internal static IntPtr kCGPDFContextUserPassword => Dlfcn.GetIntPtr(Libraries.CoreGraphics.Handle, "kCGPDFContextUserPassword");

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
			nSMutableDictionary.LowlevelSetObject(CFBoolean.FalseHandle, kCGPDFContextAllowsPrinting);
		}
		if (AllowsCopying.HasValue && !AllowsCopying.Value)
		{
			nSMutableDictionary.LowlevelSetObject(CFBoolean.FalseHandle, kCGPDFContextAllowsCopying);
		}
		if (AccessPermissions.HasValue)
		{
			nSMutableDictionary.LowlevelSetObject(NSNumber.FromInt32((int)AccessPermissions.Value), kCGPDFContextAccessPermissions);
		}
		return nSMutableDictionary;
	}
}

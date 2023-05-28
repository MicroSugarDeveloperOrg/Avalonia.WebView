using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace Security;

public class SecImportExport
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CertChain;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Identity;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeyId;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Label;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Passphrase;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Trust;

	[Field("kSecImportItemCertChain", "Security")]
	public static NSString CertChain
	{
		get
		{
			if (_CertChain == null)
			{
				_CertChain = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecImportItemCertChain");
			}
			return _CertChain;
		}
	}

	[Field("kSecImportItemIdentity", "Security")]
	public static NSString Identity
	{
		get
		{
			if (_Identity == null)
			{
				_Identity = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecImportItemIdentity");
			}
			return _Identity;
		}
	}

	[Field("kSecImportItemKeyID", "Security")]
	public static NSString KeyId
	{
		get
		{
			if (_KeyId == null)
			{
				_KeyId = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecImportItemKeyID");
			}
			return _KeyId;
		}
	}

	[Field("kSecImportItemLabel", "Security")]
	public static NSString Label
	{
		get
		{
			if (_Label == null)
			{
				_Label = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecImportItemLabel");
			}
			return _Label;
		}
	}

	[Field("kSecImportExportPassphrase", "Security")]
	public static NSString Passphrase
	{
		get
		{
			if (_Passphrase == null)
			{
				_Passphrase = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecImportExportPassphrase");
			}
			return _Passphrase;
		}
	}

	[Field("kSecImportItemTrust", "Security")]
	public static NSString Trust
	{
		get
		{
			if (_Trust == null)
			{
				_Trust = Dlfcn.GetStringConstant(Libraries.Security.Handle, "kSecImportItemTrust");
			}
			return _Trust;
		}
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecPKCS12Import(IntPtr pkcs12_data, IntPtr options, out IntPtr items);

	public static SecStatusCode ImportPkcs12(byte[] buffer, NSDictionary options, out NSDictionary[] array)
	{
		using NSData data = NSData.FromArray(buffer);
		return ImportPkcs12(data, options, out array);
	}

	public static SecStatusCode ImportPkcs12(NSData data, NSDictionary options, out NSDictionary[] array)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		IntPtr items;
		SecStatusCode result = SecPKCS12Import(data.Handle, options.Handle, out items);
		array = NSArray.ArrayFromHandle<NSDictionary>(items);
		NSObject.DangerousRelease(items);
		return result;
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace Security;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class SecKeyAlgorithmExtensions
{
	private static IntPtr[] values = new IntPtr[76];

	[Field("kSecKeyAlgorithmRSASignatureRaw", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureRaw
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureRaw", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmRSASignatureDigestPKCS1v15Raw", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureDigestPKCS1v15Raw
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureDigestPKCS1v15Raw", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA1", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA1
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA1", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA224", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA224
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA224", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA256", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA256
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA256", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA384", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA384
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA384", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA512", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA512
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA512", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA1", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA1
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA1", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA224", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA224
	{
		get
		{
			fixed (IntPtr* storage = &values[8])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA224", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA256", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA256
	{
		get
		{
			fixed (IntPtr* storage = &values[9])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA256", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA384", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA384
	{
		get
		{
			fixed (IntPtr* storage = &values[10])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA384", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA512", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA512
	{
		get
		{
			fixed (IntPtr* storage = &values[11])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA512", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECDSASignatureRFC4754", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureRFC4754
	{
		get
		{
			fixed (IntPtr* storage = &values[12])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureRFC4754", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECDSASignatureDigestX962", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureDigestX962
	{
		get
		{
			fixed (IntPtr* storage = &values[13])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureDigestX962", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECDSASignatureDigestX962SHA1", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureDigestX962SHA1
	{
		get
		{
			fixed (IntPtr* storage = &values[14])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureDigestX962SHA1", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECDSASignatureDigestX962SHA224", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureDigestX962SHA224
	{
		get
		{
			fixed (IntPtr* storage = &values[15])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureDigestX962SHA224", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECDSASignatureDigestX962SHA256", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureDigestX962SHA256
	{
		get
		{
			fixed (IntPtr* storage = &values[16])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureDigestX962SHA256", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECDSASignatureDigestX962SHA384", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureDigestX962SHA384
	{
		get
		{
			fixed (IntPtr* storage = &values[17])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureDigestX962SHA384", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECDSASignatureDigestX962SHA512", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureDigestX962SHA512
	{
		get
		{
			fixed (IntPtr* storage = &values[18])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureDigestX962SHA512", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECDSASignatureMessageX962SHA1", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureMessageX962SHA1
	{
		get
		{
			fixed (IntPtr* storage = &values[19])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureMessageX962SHA1", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECDSASignatureMessageX962SHA224", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureMessageX962SHA224
	{
		get
		{
			fixed (IntPtr* storage = &values[20])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureMessageX962SHA224", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECDSASignatureMessageX962SHA256", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureMessageX962SHA256
	{
		get
		{
			fixed (IntPtr* storage = &values[21])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureMessageX962SHA256", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECDSASignatureMessageX962SHA384", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureMessageX962SHA384
	{
		get
		{
			fixed (IntPtr* storage = &values[22])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureMessageX962SHA384", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECDSASignatureMessageX962SHA512", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECDSASignatureMessageX962SHA512
	{
		get
		{
			fixed (IntPtr* storage = &values[23])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECDSASignatureMessageX962SHA512", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmRSAEncryptionRaw", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSAEncryptionRaw
	{
		get
		{
			fixed (IntPtr* storage = &values[24])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSAEncryptionRaw", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmRSAEncryptionPKCS1", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSAEncryptionPKCS1
	{
		get
		{
			fixed (IntPtr* storage = &values[25])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSAEncryptionPKCS1", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmRSAEncryptionOAEPSHA1", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSAEncryptionOAEPSHA1
	{
		get
		{
			fixed (IntPtr* storage = &values[26])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSAEncryptionOAEPSHA1", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmRSAEncryptionOAEPSHA224", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSAEncryptionOAEPSHA224
	{
		get
		{
			fixed (IntPtr* storage = &values[27])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSAEncryptionOAEPSHA224", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmRSAEncryptionOAEPSHA256", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSAEncryptionOAEPSHA256
	{
		get
		{
			fixed (IntPtr* storage = &values[28])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSAEncryptionOAEPSHA256", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmRSAEncryptionOAEPSHA384", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSAEncryptionOAEPSHA384
	{
		get
		{
			fixed (IntPtr* storage = &values[29])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSAEncryptionOAEPSHA384", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmRSAEncryptionOAEPSHA512", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSAEncryptionOAEPSHA512
	{
		get
		{
			fixed (IntPtr* storage = &values[30])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSAEncryptionOAEPSHA512", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmRSAEncryptionOAEPSHA1AESGCM", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSAEncryptionOAEPSHA1AESGCM
	{
		get
		{
			fixed (IntPtr* storage = &values[31])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSAEncryptionOAEPSHA1AESGCM", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmRSAEncryptionOAEPSHA224AESGCM", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSAEncryptionOAEPSHA224AESGCM
	{
		get
		{
			fixed (IntPtr* storage = &values[32])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSAEncryptionOAEPSHA224AESGCM", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmRSAEncryptionOAEPSHA256AESGCM", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSAEncryptionOAEPSHA256AESGCM
	{
		get
		{
			fixed (IntPtr* storage = &values[33])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSAEncryptionOAEPSHA256AESGCM", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmRSAEncryptionOAEPSHA384AESGCM", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSAEncryptionOAEPSHA384AESGCM
	{
		get
		{
			fixed (IntPtr* storage = &values[34])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSAEncryptionOAEPSHA384AESGCM", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmRSAEncryptionOAEPSHA512AESGCM", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSAEncryptionOAEPSHA512AESGCM
	{
		get
		{
			fixed (IntPtr* storage = &values[35])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSAEncryptionOAEPSHA512AESGCM", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECIESEncryptionStandardX963SHA1AESGCM", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionStandardX963SHA1AESGCM
	{
		get
		{
			fixed (IntPtr* storage = &values[36])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionStandardX963SHA1AESGCM", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECIESEncryptionStandardX963SHA224AESGCM", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionStandardX963SHA224AESGCM
	{
		get
		{
			fixed (IntPtr* storage = &values[37])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionStandardX963SHA224AESGCM", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECIESEncryptionStandardX963SHA256AESGCM", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionStandardX963SHA256AESGCM
	{
		get
		{
			fixed (IntPtr* storage = &values[38])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionStandardX963SHA256AESGCM", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECIESEncryptionStandardX963SHA384AESGCM", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionStandardX963SHA384AESGCM
	{
		get
		{
			fixed (IntPtr* storage = &values[39])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionStandardX963SHA384AESGCM", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECIESEncryptionStandardX963SHA512AESGCM", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionStandardX963SHA512AESGCM
	{
		get
		{
			fixed (IntPtr* storage = &values[40])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionStandardX963SHA512AESGCM", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECIESEncryptionCofactorX963SHA1AESGCM", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionCofactorX963SHA1AESGCM
	{
		get
		{
			fixed (IntPtr* storage = &values[41])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionCofactorX963SHA1AESGCM", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECIESEncryptionCofactorX963SHA224AESGCM", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionCofactorX963SHA224AESGCM
	{
		get
		{
			fixed (IntPtr* storage = &values[42])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionCofactorX963SHA224AESGCM", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECIESEncryptionCofactorX963SHA256AESGCM", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionCofactorX963SHA256AESGCM
	{
		get
		{
			fixed (IntPtr* storage = &values[43])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionCofactorX963SHA256AESGCM", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECIESEncryptionCofactorX963SHA384AESGCM", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionCofactorX963SHA384AESGCM
	{
		get
		{
			fixed (IntPtr* storage = &values[44])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionCofactorX963SHA384AESGCM", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECIESEncryptionCofactorX963SHA512AESGCM", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionCofactorX963SHA512AESGCM
	{
		get
		{
			fixed (IntPtr* storage = &values[45])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionCofactorX963SHA512AESGCM", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECDHKeyExchangeStandard", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECDHKeyExchangeStandard
	{
		get
		{
			fixed (IntPtr* storage = &values[46])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECDHKeyExchangeStandard", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA1", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA1
	{
		get
		{
			fixed (IntPtr* storage = &values[47])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA1", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA224", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA224
	{
		get
		{
			fixed (IntPtr* storage = &values[48])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA224", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA256", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA256
	{
		get
		{
			fixed (IntPtr* storage = &values[49])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA256", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA384", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA384
	{
		get
		{
			fixed (IntPtr* storage = &values[50])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA384", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA512", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA512
	{
		get
		{
			fixed (IntPtr* storage = &values[51])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA512", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECDHKeyExchangeCofactor", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECDHKeyExchangeCofactor
	{
		get
		{
			fixed (IntPtr* storage = &values[52])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECDHKeyExchangeCofactor", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA1", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA1
	{
		get
		{
			fixed (IntPtr* storage = &values[53])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA1", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA224", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA224
	{
		get
		{
			fixed (IntPtr* storage = &values[54])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA224", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA256", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA256
	{
		get
		{
			fixed (IntPtr* storage = &values[55])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA256", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA384", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA384
	{
		get
		{
			fixed (IntPtr* storage = &values[56])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA384", storage);
			}
		}
	}

	[Field("kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA512", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA512
	{
		get
		{
			fixed (IntPtr* storage = &values[57])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA512", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("kSecKeyAlgorithmRSASignatureDigestPSSSHA1", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureDigestPSSSHA1
	{
		get
		{
			fixed (IntPtr* storage = &values[58])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureDigestPSSSHA1", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("kSecKeyAlgorithmRSASignatureDigestPSSSHA224", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureDigestPSSSHA224
	{
		get
		{
			fixed (IntPtr* storage = &values[59])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureDigestPSSSHA224", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("kSecKeyAlgorithmRSASignatureDigestPSSSHA256", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureDigestPSSSHA256
	{
		get
		{
			fixed (IntPtr* storage = &values[60])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureDigestPSSSHA256", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("kSecKeyAlgorithmRSASignatureDigestPSSSHA384", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureDigestPSSSHA384
	{
		get
		{
			fixed (IntPtr* storage = &values[61])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureDigestPSSSHA384", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("kSecKeyAlgorithmRSASignatureDigestPSSSHA512", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureDigestPSSSHA512
	{
		get
		{
			fixed (IntPtr* storage = &values[62])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureDigestPSSSHA512", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("kSecKeyAlgorithmRSASignatureMessagePSSSHA1", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureMessagePSSSHA1
	{
		get
		{
			fixed (IntPtr* storage = &values[63])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureMessagePSSSHA1", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("kSecKeyAlgorithmRSASignatureMessagePSSSHA224", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureMessagePSSSHA224
	{
		get
		{
			fixed (IntPtr* storage = &values[64])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureMessagePSSSHA224", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("kSecKeyAlgorithmRSASignatureMessagePSSSHA256", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureMessagePSSSHA256
	{
		get
		{
			fixed (IntPtr* storage = &values[65])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureMessagePSSSHA256", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("kSecKeyAlgorithmRSASignatureMessagePSSSHA384", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureMessagePSSSHA384
	{
		get
		{
			fixed (IntPtr* storage = &values[66])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureMessagePSSSHA384", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("kSecKeyAlgorithmRSASignatureMessagePSSSHA512", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmRSASignatureMessagePSSSHA512
	{
		get
		{
			fixed (IntPtr* storage = &values[67])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmRSASignatureMessagePSSSHA512", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA224AESGCM", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA224AESGCM
	{
		get
		{
			fixed (IntPtr* storage = &values[68])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA224AESGCM", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA256AESGCM", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA256AESGCM
	{
		get
		{
			fixed (IntPtr* storage = &values[69])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA256AESGCM", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA384AESGCM", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA384AESGCM
	{
		get
		{
			fixed (IntPtr* storage = &values[70])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA384AESGCM", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA512AESGCM", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA512AESGCM
	{
		get
		{
			fixed (IntPtr* storage = &values[71])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA512AESGCM", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA224AESGCM", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA224AESGCM
	{
		get
		{
			fixed (IntPtr* storage = &values[72])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA224AESGCM", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA256AESGCM", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA256AESGCM
	{
		get
		{
			fixed (IntPtr* storage = &values[73])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA256AESGCM", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA384AESGCM", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA384AESGCM
	{
		get
		{
			fixed (IntPtr* storage = &values[74])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA384AESGCM", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Field("kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA512AESGCM", "Security")]
	internal unsafe static IntPtr kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA512AESGCM
	{
		get
		{
			fixed (IntPtr* storage = &values[75])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA512AESGCM", storage);
			}
		}
	}

	public static NSString? GetConstant(this SecKeyAlgorithm self)
	{
		IntPtr zero = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			zero = kSecKeyAlgorithmRSASignatureRaw;
			break;
		case 1:
			zero = kSecKeyAlgorithmRSASignatureDigestPKCS1v15Raw;
			break;
		case 2:
			zero = kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA1;
			break;
		case 3:
			zero = kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA224;
			break;
		case 4:
			zero = kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA256;
			break;
		case 5:
			zero = kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA384;
			break;
		case 6:
			zero = kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA512;
			break;
		case 7:
			zero = kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA1;
			break;
		case 8:
			zero = kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA224;
			break;
		case 9:
			zero = kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA256;
			break;
		case 10:
			zero = kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA384;
			break;
		case 11:
			zero = kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA512;
			break;
		case 12:
			zero = kSecKeyAlgorithmECDSASignatureRFC4754;
			break;
		case 13:
			zero = kSecKeyAlgorithmECDSASignatureDigestX962;
			break;
		case 14:
			zero = kSecKeyAlgorithmECDSASignatureDigestX962SHA1;
			break;
		case 15:
			zero = kSecKeyAlgorithmECDSASignatureDigestX962SHA224;
			break;
		case 16:
			zero = kSecKeyAlgorithmECDSASignatureDigestX962SHA256;
			break;
		case 17:
			zero = kSecKeyAlgorithmECDSASignatureDigestX962SHA384;
			break;
		case 18:
			zero = kSecKeyAlgorithmECDSASignatureDigestX962SHA512;
			break;
		case 19:
			zero = kSecKeyAlgorithmECDSASignatureMessageX962SHA1;
			break;
		case 20:
			zero = kSecKeyAlgorithmECDSASignatureMessageX962SHA224;
			break;
		case 21:
			zero = kSecKeyAlgorithmECDSASignatureMessageX962SHA256;
			break;
		case 22:
			zero = kSecKeyAlgorithmECDSASignatureMessageX962SHA384;
			break;
		case 23:
			zero = kSecKeyAlgorithmECDSASignatureMessageX962SHA512;
			break;
		case 24:
			zero = kSecKeyAlgorithmRSAEncryptionRaw;
			break;
		case 25:
			zero = kSecKeyAlgorithmRSAEncryptionPKCS1;
			break;
		case 26:
			zero = kSecKeyAlgorithmRSAEncryptionOAEPSHA1;
			break;
		case 27:
			zero = kSecKeyAlgorithmRSAEncryptionOAEPSHA224;
			break;
		case 28:
			zero = kSecKeyAlgorithmRSAEncryptionOAEPSHA256;
			break;
		case 29:
			zero = kSecKeyAlgorithmRSAEncryptionOAEPSHA384;
			break;
		case 30:
			zero = kSecKeyAlgorithmRSAEncryptionOAEPSHA512;
			break;
		case 31:
			zero = kSecKeyAlgorithmRSAEncryptionOAEPSHA1AESGCM;
			break;
		case 32:
			zero = kSecKeyAlgorithmRSAEncryptionOAEPSHA224AESGCM;
			break;
		case 33:
			zero = kSecKeyAlgorithmRSAEncryptionOAEPSHA256AESGCM;
			break;
		case 34:
			zero = kSecKeyAlgorithmRSAEncryptionOAEPSHA384AESGCM;
			break;
		case 35:
			zero = kSecKeyAlgorithmRSAEncryptionOAEPSHA512AESGCM;
			break;
		case 36:
			zero = kSecKeyAlgorithmECIESEncryptionStandardX963SHA1AESGCM;
			break;
		case 37:
			zero = kSecKeyAlgorithmECIESEncryptionStandardX963SHA224AESGCM;
			break;
		case 38:
			zero = kSecKeyAlgorithmECIESEncryptionStandardX963SHA256AESGCM;
			break;
		case 39:
			zero = kSecKeyAlgorithmECIESEncryptionStandardX963SHA384AESGCM;
			break;
		case 40:
			zero = kSecKeyAlgorithmECIESEncryptionStandardX963SHA512AESGCM;
			break;
		case 41:
			zero = kSecKeyAlgorithmECIESEncryptionCofactorX963SHA1AESGCM;
			break;
		case 42:
			zero = kSecKeyAlgorithmECIESEncryptionCofactorX963SHA224AESGCM;
			break;
		case 43:
			zero = kSecKeyAlgorithmECIESEncryptionCofactorX963SHA256AESGCM;
			break;
		case 44:
			zero = kSecKeyAlgorithmECIESEncryptionCofactorX963SHA384AESGCM;
			break;
		case 45:
			zero = kSecKeyAlgorithmECIESEncryptionCofactorX963SHA512AESGCM;
			break;
		case 46:
			zero = kSecKeyAlgorithmECDHKeyExchangeStandard;
			break;
		case 47:
			zero = kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA1;
			break;
		case 48:
			zero = kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA224;
			break;
		case 49:
			zero = kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA256;
			break;
		case 50:
			zero = kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA384;
			break;
		case 51:
			zero = kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA512;
			break;
		case 52:
			zero = kSecKeyAlgorithmECDHKeyExchangeCofactor;
			break;
		case 53:
			zero = kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA1;
			break;
		case 54:
			zero = kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA224;
			break;
		case 55:
			zero = kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA256;
			break;
		case 56:
			zero = kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA384;
			break;
		case 57:
			zero = kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA512;
			break;
		case 58:
			zero = kSecKeyAlgorithmRSASignatureDigestPSSSHA1;
			break;
		case 59:
			zero = kSecKeyAlgorithmRSASignatureDigestPSSSHA224;
			break;
		case 60:
			zero = kSecKeyAlgorithmRSASignatureDigestPSSSHA256;
			break;
		case 61:
			zero = kSecKeyAlgorithmRSASignatureDigestPSSSHA384;
			break;
		case 62:
			zero = kSecKeyAlgorithmRSASignatureDigestPSSSHA512;
			break;
		case 63:
			zero = kSecKeyAlgorithmRSASignatureMessagePSSSHA1;
			break;
		case 64:
			zero = kSecKeyAlgorithmRSASignatureMessagePSSSHA224;
			break;
		case 65:
			zero = kSecKeyAlgorithmRSASignatureMessagePSSSHA256;
			break;
		case 66:
			zero = kSecKeyAlgorithmRSASignatureMessagePSSSHA384;
			break;
		case 67:
			zero = kSecKeyAlgorithmRSASignatureMessagePSSSHA512;
			break;
		case 68:
			zero = kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA224AESGCM;
			break;
		case 69:
			zero = kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA256AESGCM;
			break;
		case 70:
			zero = kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA384AESGCM;
			break;
		case 71:
			zero = kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA512AESGCM;
			break;
		case 72:
			zero = kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA224AESGCM;
			break;
		case 73:
			zero = kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA256AESGCM;
			break;
		case 74:
			zero = kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA384AESGCM;
			break;
		case 75:
			zero = kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA512AESGCM;
			break;
		}
		return (NSString)Runtime.GetNSObject(zero);
	}

	public static SecKeyAlgorithm GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSASignatureRaw))
		{
			return SecKeyAlgorithm.RsaSignatureRaw;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSASignatureDigestPKCS1v15Raw))
		{
			return SecKeyAlgorithm.RsaSignatureDigestPkcs1v15Raw;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA1))
		{
			return SecKeyAlgorithm.RsaSignatureDigestPkcs1v15Sha1;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA224))
		{
			return SecKeyAlgorithm.RsaSignatureDigestPkcs1v15Sha224;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA256))
		{
			return SecKeyAlgorithm.RsaSignatureDigestPkcs1v15Sha256;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA384))
		{
			return SecKeyAlgorithm.RsaSignatureDigestPkcs1v15Sha384;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSASignatureDigestPKCS1v15SHA512))
		{
			return SecKeyAlgorithm.RsaSignatureDigestPkcs1v15Sha512;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA1))
		{
			return SecKeyAlgorithm.RsaSignatureMessagePkcs1v15Sha1;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA224))
		{
			return SecKeyAlgorithm.RsaSignatureMessagePkcs1v15Sha224;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA256))
		{
			return SecKeyAlgorithm.RsaSignatureMessagePkcs1v15Sha256;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA384))
		{
			return SecKeyAlgorithm.RsaSignatureMessagePkcs1v15Sha384;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSASignatureMessagePKCS1v15SHA512))
		{
			return SecKeyAlgorithm.RsaSignatureMessagePkcs1v15Sha512;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECDSASignatureRFC4754))
		{
			return SecKeyAlgorithm.EcdsaSignatureRfc4754;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECDSASignatureDigestX962))
		{
			return SecKeyAlgorithm.EcdsaSignatureDigestX962;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECDSASignatureDigestX962SHA1))
		{
			return SecKeyAlgorithm.EcdsaSignatureDigestX962Sha1;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECDSASignatureDigestX962SHA224))
		{
			return SecKeyAlgorithm.EcdsaSignatureDigestX962Sha224;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECDSASignatureDigestX962SHA256))
		{
			return SecKeyAlgorithm.EcdsaSignatureDigestX962Sha256;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECDSASignatureDigestX962SHA384))
		{
			return SecKeyAlgorithm.EcdsaSignatureDigestX962Sha384;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECDSASignatureDigestX962SHA512))
		{
			return SecKeyAlgorithm.EcdsaSignatureDigestX962Sha512;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECDSASignatureMessageX962SHA1))
		{
			return SecKeyAlgorithm.EcdsaSignatureMessageX962Sha1;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECDSASignatureMessageX962SHA224))
		{
			return SecKeyAlgorithm.EcdsaSignatureMessageX962Sha224;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECDSASignatureMessageX962SHA256))
		{
			return SecKeyAlgorithm.EcdsaSignatureMessageX962Sha256;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECDSASignatureMessageX962SHA384))
		{
			return SecKeyAlgorithm.EcdsaSignatureMessageX962Sha384;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECDSASignatureMessageX962SHA512))
		{
			return SecKeyAlgorithm.EcdsaSignatureMessageX962Sha512;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSAEncryptionRaw))
		{
			return SecKeyAlgorithm.RsaEncryptionRaw;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSAEncryptionPKCS1))
		{
			return SecKeyAlgorithm.RsaEncryptionPkcs1;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSAEncryptionOAEPSHA1))
		{
			return SecKeyAlgorithm.RsaEncryptionOaepSha1;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSAEncryptionOAEPSHA224))
		{
			return SecKeyAlgorithm.RsaEncryptionOaepSha224;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSAEncryptionOAEPSHA256))
		{
			return SecKeyAlgorithm.RsaEncryptionOaepSha256;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSAEncryptionOAEPSHA384))
		{
			return SecKeyAlgorithm.RsaEncryptionOaepSha384;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSAEncryptionOAEPSHA512))
		{
			return SecKeyAlgorithm.RsaEncryptionOaepSha512;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSAEncryptionOAEPSHA1AESGCM))
		{
			return SecKeyAlgorithm.RsaEncryptionOaepSha1AesCgm;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSAEncryptionOAEPSHA224AESGCM))
		{
			return SecKeyAlgorithm.RsaEncryptionOaepSha224AesGcm;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSAEncryptionOAEPSHA256AESGCM))
		{
			return SecKeyAlgorithm.RsaEncryptionOaepSha256AesGcm;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSAEncryptionOAEPSHA384AESGCM))
		{
			return SecKeyAlgorithm.RsaEncryptionOaepSha384AesGcm;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSAEncryptionOAEPSHA512AESGCM))
		{
			return SecKeyAlgorithm.RsaEncryptionOaepSha512AesGcm;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECIESEncryptionStandardX963SHA1AESGCM))
		{
			return SecKeyAlgorithm.EciesEncryptionStandardX963Sha1AesGcm;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECIESEncryptionStandardX963SHA224AESGCM))
		{
			return SecKeyAlgorithm.EciesEncryptionStandardX963Sha224AesGcm;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECIESEncryptionStandardX963SHA256AESGCM))
		{
			return SecKeyAlgorithm.EciesEncryptionStandardX963Sha256AesGcm;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECIESEncryptionStandardX963SHA384AESGCM))
		{
			return SecKeyAlgorithm.EciesEncryptionStandardX963Sha384AesGcm;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECIESEncryptionStandardX963SHA512AESGCM))
		{
			return SecKeyAlgorithm.EciesEncryptionStandardX963Sha512AesGcm;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECIESEncryptionCofactorX963SHA1AESGCM))
		{
			return SecKeyAlgorithm.EciesEncryptionCofactorX963Sha1AesGcm;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECIESEncryptionCofactorX963SHA224AESGCM))
		{
			return SecKeyAlgorithm.EciesEncryptionCofactorX963Sha224AesGcm;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECIESEncryptionCofactorX963SHA256AESGCM))
		{
			return SecKeyAlgorithm.EciesEncryptionCofactorX963Sha256AesGcm;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECIESEncryptionCofactorX963SHA384AESGCM))
		{
			return SecKeyAlgorithm.EciesEncryptionCofactorX963Sha384AesGcm;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECIESEncryptionCofactorX963SHA512AESGCM))
		{
			return SecKeyAlgorithm.EciesEncryptionCofactorX963Sha512AesGcm;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECDHKeyExchangeStandard))
		{
			return SecKeyAlgorithm.EcdhKeyExchangeStandard;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA1))
		{
			return SecKeyAlgorithm.EcdhKeyExchangeStandardX963Sha1;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA224))
		{
			return SecKeyAlgorithm.EcdhKeyExchangeStandardX963Sha224;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA256))
		{
			return SecKeyAlgorithm.EcdhKeyExchangeStandardX963Sha256;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA384))
		{
			return SecKeyAlgorithm.EcdhKeyExchangeStandardX963Sha384;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECDHKeyExchangeStandardX963SHA512))
		{
			return SecKeyAlgorithm.EcdhKeyExchangeStandardX963Sha512;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECDHKeyExchangeCofactor))
		{
			return SecKeyAlgorithm.EcdhKeyExchangeCofactor;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA1))
		{
			return SecKeyAlgorithm.EcdhKeyExchangeCofactorX963Sha1;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA224))
		{
			return SecKeyAlgorithm.EcdhKeyExchangeCofactorX963Sha224;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA256))
		{
			return SecKeyAlgorithm.EcdhKeyExchangeCofactorX963Sha256;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA384))
		{
			return SecKeyAlgorithm.EcdhKeyExchangeCofactorX963Sha384;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECDHKeyExchangeCofactorX963SHA512))
		{
			return SecKeyAlgorithm.EcdhKeyExchangeCofactorX963Sha512;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSASignatureDigestPSSSHA1))
		{
			return SecKeyAlgorithm.RsaSignatureDigestPssSha1;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSASignatureDigestPSSSHA224))
		{
			return SecKeyAlgorithm.RsaSignatureDigestPssSha224;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSASignatureDigestPSSSHA256))
		{
			return SecKeyAlgorithm.RsaSignatureDigestPssSha256;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSASignatureDigestPSSSHA384))
		{
			return SecKeyAlgorithm.RsaSignatureDigestPssSha384;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSASignatureDigestPSSSHA512))
		{
			return SecKeyAlgorithm.RsaSignatureDigestPssSha512;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSASignatureMessagePSSSHA1))
		{
			return SecKeyAlgorithm.RsaSignatureMessagePssSha1;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSASignatureMessagePSSSHA224))
		{
			return SecKeyAlgorithm.RsaSignatureMessagePssSha224;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSASignatureMessagePSSSHA256))
		{
			return SecKeyAlgorithm.RsaSignatureMessagePssSha256;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSASignatureMessagePSSSHA384))
		{
			return SecKeyAlgorithm.RsaSignatureMessagePssSha384;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmRSASignatureMessagePSSSHA512))
		{
			return SecKeyAlgorithm.RsaSignatureMessagePssSha512;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA224AESGCM))
		{
			return SecKeyAlgorithm.EciesEncryptionStandardVariableIvx963Sha224AesGcm;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA256AESGCM))
		{
			return SecKeyAlgorithm.EciesEncryptionStandardVariableIvx963Sha256AesGcm;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA384AESGCM))
		{
			return SecKeyAlgorithm.EciesEncryptionStandardVariableIvx963Sha384AesGcm;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECIESEncryptionStandardVariableIVX963SHA512AESGCM))
		{
			return SecKeyAlgorithm.EciesEncryptionStandardVariableIvx963Sha512AesGcm;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA224AESGCM))
		{
			return SecKeyAlgorithm.EciesEncryptionCofactorVariableIvx963Sha224AesGcm;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA256AESGCM))
		{
			return SecKeyAlgorithm.EciesEncryptionCofactorVariableIvx963Sha256AesGcm;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA384AESGCM))
		{
			return SecKeyAlgorithm.EciesEncryptionCofactorVariableIvx963Sha384AesGcm;
		}
		if (constant.IsEqualTo(kSecKeyAlgorithmECIESEncryptionCofactorVariableIVX963SHA512AESGCM))
		{
			return SecKeyAlgorithm.EciesEncryptionCofactorVariableIvx963Sha512AesGcm;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}

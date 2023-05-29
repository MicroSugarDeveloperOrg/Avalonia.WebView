using System;
using ObjCRuntime;

namespace Security;

internal static class SecAttributeKey
{
	private static IntPtr _AttrAccessible;

	private static IntPtr _AttrAccessGroup;

	private static IntPtr _AttrCreationDate;

	private static IntPtr _AttrModificationDate;

	private static IntPtr _AttrDescription;

	private static IntPtr _AttrComment;

	private static IntPtr _AttrCreator;

	private static IntPtr _AttrType;

	private static IntPtr _AttrLabel;

	private static IntPtr _AttrIsInvisible;

	private static IntPtr _AttrIsNegative;

	private static IntPtr _AttrAccount;

	private static IntPtr _AttrService;

	private static IntPtr _AttrGeneric;

	private static IntPtr _AttrSecurityDomain;

	private static IntPtr _AttrServer;

	private static IntPtr _AttrProtocol;

	private static IntPtr _AttrAuthenticationType;

	private static IntPtr _AttrPort;

	private static IntPtr _AttrPath;

	private static IntPtr _AttrSubject;

	private static IntPtr _AttrIssuer;

	private static IntPtr _AttrSerialNumber;

	private static IntPtr _AttrSubjectKeyID;

	private static IntPtr _AttrPublicKeyHash;

	private static IntPtr _AttrCertificateType;

	private static IntPtr _AttrCertificateEncoding;

	private static IntPtr _AttrKeyClass;

	private static IntPtr _AttrApplicationLabel;

	private static IntPtr _AttrIsPermanent;

	private static IntPtr _AttrApplicationTag;

	private static IntPtr _AttrKeyType;

	private static IntPtr _AttrKeySizeInBits;

	private static IntPtr _AttrEffectiveKeySize;

	private static IntPtr _AttrCanEncrypt;

	private static IntPtr _AttrCanDecrypt;

	private static IntPtr _AttrCanDerive;

	private static IntPtr _AttrCanSign;

	private static IntPtr _AttrCanVerify;

	private static IntPtr _AttrCanWrap;

	private static IntPtr _AttrCanUnwrap;

	public static IntPtr AttrAccessible
	{
		get
		{
			if (_AttrAccessible == IntPtr.Zero)
			{
				_AttrAccessible = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrAccessible");
			}
			return _AttrAccessible;
		}
	}

	public static IntPtr AttrAccessGroup
	{
		get
		{
			if (_AttrAccessGroup == IntPtr.Zero)
			{
				_AttrAccessGroup = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrAccessGroup");
			}
			return _AttrAccessGroup;
		}
	}

	public static IntPtr AttrCreationDate
	{
		get
		{
			if (_AttrCreationDate == IntPtr.Zero)
			{
				_AttrCreationDate = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrCreationDate");
			}
			return _AttrCreationDate;
		}
	}

	public static IntPtr AttrModificationDate
	{
		get
		{
			if (_AttrModificationDate == IntPtr.Zero)
			{
				_AttrModificationDate = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrModificationDate");
			}
			return _AttrModificationDate;
		}
	}

	public static IntPtr AttrDescription
	{
		get
		{
			if (_AttrDescription == IntPtr.Zero)
			{
				_AttrDescription = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrDescription");
			}
			return _AttrDescription;
		}
	}

	public static IntPtr AttrComment
	{
		get
		{
			if (_AttrComment == IntPtr.Zero)
			{
				_AttrComment = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrComment");
			}
			return _AttrComment;
		}
	}

	public static IntPtr AttrCreator
	{
		get
		{
			if (_AttrCreator == IntPtr.Zero)
			{
				_AttrCreator = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrCreator");
			}
			return _AttrCreator;
		}
	}

	public static IntPtr AttrType
	{
		get
		{
			if (_AttrType == IntPtr.Zero)
			{
				_AttrType = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrType");
			}
			return _AttrType;
		}
	}

	public static IntPtr AttrLabel
	{
		get
		{
			if (_AttrLabel == IntPtr.Zero)
			{
				_AttrLabel = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrLabel");
			}
			return _AttrLabel;
		}
	}

	public static IntPtr AttrIsInvisible
	{
		get
		{
			if (_AttrIsInvisible == IntPtr.Zero)
			{
				_AttrIsInvisible = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrIsInvisible");
			}
			return _AttrIsInvisible;
		}
	}

	public static IntPtr AttrIsNegative
	{
		get
		{
			if (_AttrIsNegative == IntPtr.Zero)
			{
				_AttrIsNegative = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrIsNegative");
			}
			return _AttrIsNegative;
		}
	}

	public static IntPtr AttrAccount
	{
		get
		{
			if (_AttrAccount == IntPtr.Zero)
			{
				_AttrAccount = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrAccount");
			}
			return _AttrAccount;
		}
	}

	public static IntPtr AttrService
	{
		get
		{
			if (_AttrService == IntPtr.Zero)
			{
				_AttrService = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrService");
			}
			return _AttrService;
		}
	}

	public static IntPtr AttrGeneric
	{
		get
		{
			if (_AttrGeneric == IntPtr.Zero)
			{
				_AttrGeneric = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrGeneric");
			}
			return _AttrGeneric;
		}
	}

	public static IntPtr AttrSecurityDomain
	{
		get
		{
			if (_AttrSecurityDomain == IntPtr.Zero)
			{
				_AttrSecurityDomain = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrSecurityDomain");
			}
			return _AttrSecurityDomain;
		}
	}

	public static IntPtr AttrServer
	{
		get
		{
			if (_AttrServer == IntPtr.Zero)
			{
				_AttrServer = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrServer");
			}
			return _AttrServer;
		}
	}

	public static IntPtr AttrProtocol
	{
		get
		{
			if (_AttrProtocol == IntPtr.Zero)
			{
				_AttrProtocol = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrProtocol");
			}
			return _AttrProtocol;
		}
	}

	public static IntPtr AttrAuthenticationType
	{
		get
		{
			if (_AttrAuthenticationType == IntPtr.Zero)
			{
				_AttrAuthenticationType = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrAuthenticationType");
			}
			return _AttrAuthenticationType;
		}
	}

	public static IntPtr AttrPort
	{
		get
		{
			if (_AttrPort == IntPtr.Zero)
			{
				_AttrPort = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrPort");
			}
			return _AttrPort;
		}
	}

	public static IntPtr AttrPath
	{
		get
		{
			if (_AttrPath == IntPtr.Zero)
			{
				_AttrPath = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrPath");
			}
			return _AttrPath;
		}
	}

	public static IntPtr AttrSubject
	{
		get
		{
			if (_AttrSubject == IntPtr.Zero)
			{
				_AttrSubject = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrSubject");
			}
			return _AttrSubject;
		}
	}

	public static IntPtr AttrIssuer
	{
		get
		{
			if (_AttrIssuer == IntPtr.Zero)
			{
				_AttrIssuer = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrIssuer");
			}
			return _AttrIssuer;
		}
	}

	public static IntPtr AttrSerialNumber
	{
		get
		{
			if (_AttrSerialNumber == IntPtr.Zero)
			{
				_AttrSerialNumber = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrSerialNumber");
			}
			return _AttrSerialNumber;
		}
	}

	public static IntPtr AttrSubjectKeyID
	{
		get
		{
			if (_AttrSubjectKeyID == IntPtr.Zero)
			{
				_AttrSubjectKeyID = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrSubjectKeyID");
			}
			return _AttrSubjectKeyID;
		}
	}

	public static IntPtr AttrPublicKeyHash
	{
		get
		{
			if (_AttrPublicKeyHash == IntPtr.Zero)
			{
				_AttrPublicKeyHash = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrPublicKeyHash");
			}
			return _AttrPublicKeyHash;
		}
	}

	public static IntPtr AttrCertificateType
	{
		get
		{
			if (_AttrCertificateType == IntPtr.Zero)
			{
				_AttrCertificateType = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrCertificateType");
			}
			return _AttrCertificateType;
		}
	}

	public static IntPtr AttrCertificateEncoding
	{
		get
		{
			if (_AttrCertificateEncoding == IntPtr.Zero)
			{
				_AttrCertificateEncoding = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrCertificateEncoding");
			}
			return _AttrCertificateEncoding;
		}
	}

	public static IntPtr AttrKeyClass
	{
		get
		{
			if (_AttrKeyClass == IntPtr.Zero)
			{
				_AttrKeyClass = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrKeyClass");
			}
			return _AttrKeyClass;
		}
	}

	public static IntPtr AttrApplicationLabel
	{
		get
		{
			if (_AttrApplicationLabel == IntPtr.Zero)
			{
				_AttrApplicationLabel = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrApplicationLabel");
			}
			return _AttrApplicationLabel;
		}
	}

	public static IntPtr AttrIsPermanent
	{
		get
		{
			if (_AttrIsPermanent == IntPtr.Zero)
			{
				_AttrIsPermanent = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrIsPermanent");
			}
			return _AttrIsPermanent;
		}
	}

	public static IntPtr AttrApplicationTag
	{
		get
		{
			if (_AttrApplicationTag == IntPtr.Zero)
			{
				_AttrApplicationTag = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrApplicationTag");
			}
			return _AttrApplicationTag;
		}
	}

	public static IntPtr AttrKeyType
	{
		get
		{
			if (_AttrKeyType == IntPtr.Zero)
			{
				_AttrKeyType = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrKeyType");
			}
			return _AttrKeyType;
		}
	}

	public static IntPtr AttrKeySizeInBits
	{
		get
		{
			if (_AttrKeySizeInBits == IntPtr.Zero)
			{
				_AttrKeySizeInBits = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrKeySizeInBits");
			}
			return _AttrKeySizeInBits;
		}
	}

	public static IntPtr AttrEffectiveKeySize
	{
		get
		{
			if (_AttrEffectiveKeySize == IntPtr.Zero)
			{
				_AttrEffectiveKeySize = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrEffectiveKeySize");
			}
			return _AttrEffectiveKeySize;
		}
	}

	public static IntPtr AttrCanEncrypt
	{
		get
		{
			if (_AttrCanEncrypt == IntPtr.Zero)
			{
				_AttrCanEncrypt = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrCanEncrypt");
			}
			return _AttrCanEncrypt;
		}
	}

	public static IntPtr AttrCanDecrypt
	{
		get
		{
			if (_AttrCanDecrypt == IntPtr.Zero)
			{
				_AttrCanDecrypt = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrCanDecrypt");
			}
			return _AttrCanDecrypt;
		}
	}

	public static IntPtr AttrCanDerive
	{
		get
		{
			if (_AttrCanDerive == IntPtr.Zero)
			{
				_AttrCanDerive = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrCanDerive");
			}
			return _AttrCanDerive;
		}
	}

	public static IntPtr AttrCanSign
	{
		get
		{
			if (_AttrCanSign == IntPtr.Zero)
			{
				_AttrCanSign = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrCanSign");
			}
			return _AttrCanSign;
		}
	}

	public static IntPtr AttrCanVerify
	{
		get
		{
			if (_AttrCanVerify == IntPtr.Zero)
			{
				_AttrCanVerify = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrCanVerify");
			}
			return _AttrCanVerify;
		}
	}

	public static IntPtr AttrCanWrap
	{
		get
		{
			if (_AttrCanWrap == IntPtr.Zero)
			{
				_AttrCanWrap = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrCanWrap");
			}
			return _AttrCanWrap;
		}
	}

	public static IntPtr AttrCanUnwrap
	{
		get
		{
			if (_AttrCanUnwrap == IntPtr.Zero)
			{
				_AttrCanUnwrap = Dlfcn.GetIntPtr(SecItem.securityLibrary, "kSecAttrCanUnwrap");
			}
			return _AttrCanUnwrap;
		}
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace Security;

internal static class SecAttributeKey
{
	[Field("kSecAttrAccessGroup", "Security")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static IntPtr AccessGroup
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrAccessGroup");
		}
	}

	[Field("kSecAttrAccessGroupToken", "Security")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public static IntPtr AccessGroupToken
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrAccessGroupToken");
		}
	}

	[Field("kSecAttrAccessible", "Security")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static IntPtr Accessible
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrAccessible");
		}
	}

	[Field("kSecAttrAccount", "Security")]
	public static IntPtr Account => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrAccount");

	[Field("kSecAttrApplicationLabel", "Security")]
	public static IntPtr ApplicationLabel => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrApplicationLabel");

	[Field("kSecAttrAuthenticationType", "Security")]
	public static IntPtr AuthenticationType => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrAuthenticationType");

	[Field("kSecAttrCertificateEncoding", "Security")]
	public static IntPtr CertificateEncoding => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrCertificateEncoding");

	[Field("kSecAttrCertificateType", "Security")]
	public static IntPtr CertificateType => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrCertificateType");

	[Field("kSecAttrComment", "Security")]
	public static IntPtr Comment => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrComment");

	[Field("kSecAttrCreationDate", "Security")]
	public static IntPtr CreationDate => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrCreationDate");

	[Field("kSecAttrCreator", "Security")]
	public static IntPtr Creator => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrCreator");

	[Field("kSecAttrDescription", "Security")]
	public static IntPtr Description => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrDescription");

	[Field("kSecAttrGeneric", "Security")]
	public static IntPtr Generic => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrGeneric");

	[Field("kSecAttrIsExtractable", "Security")]
	public static IntPtr IsExtractable => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrIsExtractable");

	[Field("kSecAttrIsInvisible", "Security")]
	public static IntPtr IsInvisible => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrIsInvisible");

	[Field("kSecAttrIsNegative", "Security")]
	public static IntPtr IsNegative => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrIsNegative");

	[Field("kSecAttrIsSensitive", "Security")]
	public static IntPtr IsSensitive => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrIsSensitive");

	[Field("kSecAttrIssuer", "Security")]
	public static IntPtr Issuer => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrIssuer");

	[Field("kSecAttrKeyClass", "Security")]
	public static IntPtr KeyClass => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrKeyClass");

	[Field("kSecAttrModificationDate", "Security")]
	public static IntPtr ModificationDate => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrModificationDate");

	[Field("kSecAttrPath", "Security")]
	public static IntPtr Path => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrPath");

	[Field("kSecAttrPersistentReference", "Security")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	public static IntPtr PersistentReference
	{
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrPersistentReference");
		}
	}

	[Field("kSecAttrPort", "Security")]
	public static IntPtr Port => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrPort");

	[Field("kSecAttrProtocol", "Security")]
	public static IntPtr Protocol => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrProtocol");

	[Field("kSecAttrPublicKeyHash", "Security")]
	public static IntPtr PublicKeyHash => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrPublicKeyHash");

	[Field("kSecAttrTokenIDSecureEnclave", "Security")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static IntPtr SecureEnclave
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrTokenIDSecureEnclave");
		}
	}

	[Field("kSecAttrSecurityDomain", "Security")]
	public static IntPtr SecurityDomain => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrSecurityDomain");

	[Field("kSecAttrSerialNumber", "Security")]
	public static IntPtr SerialNumber => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrSerialNumber");

	[Field("kSecAttrServer", "Security")]
	public static IntPtr Server => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrServer");

	[Field("kSecAttrService", "Security")]
	public static IntPtr Service => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrService");

	[Field("kSecAttrSubject", "Security")]
	public static IntPtr Subject => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrSubject");

	[Field("kSecAttrSubjectKeyID", "Security")]
	public static IntPtr SubjectKeyID => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrSubjectKeyID");

	[Field("kSecAttrSyncViewHint", "Security")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static IntPtr SyncViewHint
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrSyncViewHint");
		}
	}

	[Field("kSecAttrSynchronizable", "Security")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static IntPtr Synchronizable
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrSynchronizable");
		}
	}

	[Field("kSecAttrSynchronizableAny", "Security")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static IntPtr SynchronizableAny
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrSynchronizableAny");
		}
	}

	[Field("kSecAttrType", "Security")]
	public static IntPtr Type => Dlfcn.GetIntPtr(Libraries.Security.Handle, "kSecAttrType");
}

using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace Security;

public class SecRecord : IDisposable
{
	internal NSMutableDictionary queryDict;

	public SecAccessible Accessible
	{
		get
		{
			return KeysAccessible.ToSecAccessible(Fetch(SecAttributeKey.AttrAccessible));
		}
		set
		{
			SetValue(KeysAccessible.FromSecAccessible(value), SecAttributeKey.AttrAccessible);
		}
	}

	public NSDate CreationDate
	{
		get
		{
			return (NSDate)FetchObject(SecAttributeKey.AttrCreationDate);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(value, SecAttributeKey.AttrCreationDate);
		}
	}

	public NSDate ModificationDate
	{
		get
		{
			return (NSDate)FetchObject(SecAttributeKey.AttrModificationDate);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(value, SecAttributeKey.AttrModificationDate);
		}
	}

	public string Description
	{
		get
		{
			return FetchString(SecAttributeKey.AttrDescription);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(new NSString(value), SecAttributeKey.AttrDescription);
		}
	}

	public string Comment
	{
		get
		{
			return FetchString(SecAttributeKey.AttrComment);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(new NSString(value), SecAttributeKey.AttrComment);
		}
	}

	public int Creator
	{
		get
		{
			return FetchNumber(SecAttributeKey.AttrCreator).Int32Value;
		}
		set
		{
			SetValue(new NSNumber(value), SecAttributeKey.AttrCreator);
		}
	}

	public int CreatorType
	{
		get
		{
			return FetchNumber(SecAttributeKey.AttrType).Int32Value;
		}
		set
		{
			SetValue(new NSNumber(value), SecAttributeKey.AttrType);
		}
	}

	public string Label
	{
		get
		{
			return FetchString(SecAttributeKey.AttrLabel);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(new NSString(value), SecAttributeKey.AttrLabel);
		}
	}

	public bool Invisible
	{
		get
		{
			return Fetch(SecAttributeKey.AttrIsInvisible) == CFBoolean.True.Handle;
		}
		set
		{
			SetValue(CFBoolean.FromBoolean(value).Handle, SecAttributeKey.AttrIsInvisible);
		}
	}

	public bool IsNegative
	{
		get
		{
			return Fetch(SecAttributeKey.AttrIsNegative) == CFBoolean.True.Handle;
		}
		set
		{
			SetValue(CFBoolean.FromBoolean(value).Handle, SecAttributeKey.AttrIsNegative);
		}
	}

	public string Account
	{
		get
		{
			return FetchString(SecAttributeKey.AttrAccount);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(new NSString(value), SecAttributeKey.AttrAccount);
		}
	}

	public string Service
	{
		get
		{
			return FetchString(SecAttributeKey.AttrService);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(new NSString(value), SecAttributeKey.AttrService);
		}
	}

	public NSData Generic
	{
		get
		{
			return FetchData(SecAttributeKey.AttrGeneric);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(value, SecAttributeKey.AttrGeneric);
		}
	}

	public string SecurityDomain
	{
		get
		{
			return FetchString(SecAttributeKey.AttrSecurityDomain);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(new NSString(value), SecAttributeKey.AttrSecurityDomain);
		}
	}

	public string Server
	{
		get
		{
			return FetchString(SecAttributeKey.AttrServer);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(new NSString(value), SecAttributeKey.AttrServer);
		}
	}

	public SecProtocol Protocol
	{
		get
		{
			return SecProtocolKeys.ToSecProtocol(Fetch(SecAttributeKey.AttrProtocol));
		}
		set
		{
			SetValue(SecProtocolKeys.FromSecProtocol(value), SecAttributeKey.AttrProtocol);
		}
	}

	public SecAuthenticationType AuthenticationType
	{
		get
		{
			IntPtr intPtr = Fetch(SecAttributeKey.AttrAuthenticationType);
			if (intPtr == IntPtr.Zero)
			{
				return SecAuthenticationType.Default;
			}
			return KeysAuthenticationType.ToSecAuthenticationType(intPtr);
		}
		set
		{
			SetValue(KeysAuthenticationType.FromSecAuthenticationType(value), SecAttributeKey.AttrAuthenticationType);
		}
	}

	public int Port
	{
		get
		{
			return FetchNumber(SecAttributeKey.AttrPort).Int32Value;
		}
		set
		{
			SetValue(new NSNumber(value), SecAttributeKey.AttrPort);
		}
	}

	public string Path
	{
		get
		{
			return FetchString(SecAttributeKey.AttrPath);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(new NSString(value), SecAttributeKey.AttrPath);
		}
	}

	public string Subject => FetchString(SecAttributeKey.AttrSubject);

	public NSData Issuer => FetchData(SecAttributeKey.AttrIssuer);

	public NSData SerialNumber => FetchData(SecAttributeKey.AttrSerialNumber);

	public NSData SubjectKeyID => FetchData(SecAttributeKey.AttrSubjectKeyID);

	public NSData PublicKeyHash => FetchData(SecAttributeKey.AttrPublicKeyHash);

	public NSNumber CertificateType => FetchNumber(SecAttributeKey.AttrCertificateType);

	public NSNumber CertificateEncoding => FetchNumber(SecAttributeKey.AttrCertificateEncoding);

	public SecKeyClass KeyClass
	{
		get
		{
			IntPtr intPtr = Fetch(SecAttributeKey.AttrKeyClass);
			if (intPtr == ClassKeys.Public)
			{
				return SecKeyClass.Public;
			}
			if (intPtr == ClassKeys.Private)
			{
				return SecKeyClass.Private;
			}
			if (intPtr == ClassKeys.Symmetric)
			{
				return SecKeyClass.Symmetric;
			}
			throw new Exception("Unknown value");
		}
		set
		{
			SetValue(value switch
			{
				SecKeyClass.Private => ClassKeys.Private, 
				SecKeyClass.Public => ClassKeys.Public, 
				_ => ClassKeys.Symmetric, 
			}, SecAttributeKey.AttrKeyClass);
		}
	}

	public string ApplicationLabel
	{
		get
		{
			return FetchString(SecAttributeKey.AttrApplicationLabel);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(new NSString(value), SecAttributeKey.AttrApplicationLabel);
		}
	}

	public bool IsPermanent
	{
		get
		{
			return Fetch(SecAttributeKey.AttrIsPermanent) == CFBoolean.True.Handle;
		}
		set
		{
			SetValue(CFBoolean.FromBoolean(value).Handle, SecAttributeKey.AttrIsPermanent);
		}
	}

	public NSData ApplicationTag
	{
		get
		{
			return FetchData(SecAttributeKey.AttrApplicationTag);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(value, SecAttributeKey.AttrApplicationTag);
		}
	}

	public SecKeyType KeyType
	{
		get
		{
			if (Fetch(SecAttributeKey.AttrKeyType) == KeyTypeKeys.RSA)
			{
				return SecKeyType.RSA;
			}
			return SecKeyType.EC;
		}
		set
		{
			SetValue((value == SecKeyType.RSA) ? KeyTypeKeys.RSA : KeyTypeKeys.EC, SecAttributeKey.AttrKeyType);
		}
	}

	public int KeySizeInBits
	{
		get
		{
			return FetchNumber(SecAttributeKey.AttrKeySizeInBits).Int32Value;
		}
		set
		{
			SetValue(new NSNumber(value), SecAttributeKey.AttrKeySizeInBits);
		}
	}

	public int EffectiveKeySize
	{
		get
		{
			return FetchNumber(SecAttributeKey.AttrEffectiveKeySize).Int32Value;
		}
		set
		{
			SetValue(new NSNumber(value), SecAttributeKey.AttrEffectiveKeySize);
		}
	}

	public bool CanEncrypt
	{
		get
		{
			return Fetch(SecAttributeKey.AttrCanEncrypt) == CFBoolean.True.Handle;
		}
		set
		{
			SetValue(CFBoolean.FromBoolean(value).Handle, SecAttributeKey.AttrCanEncrypt);
		}
	}

	public bool CanDecrypt
	{
		get
		{
			return Fetch(SecAttributeKey.AttrCanDecrypt) == CFBoolean.True.Handle;
		}
		set
		{
			SetValue(CFBoolean.FromBoolean(value).Handle, SecAttributeKey.AttrCanDecrypt);
		}
	}

	public bool CanDerive
	{
		get
		{
			return Fetch(SecAttributeKey.AttrCanDerive) == CFBoolean.True.Handle;
		}
		set
		{
			SetValue(CFBoolean.FromBoolean(value).Handle, SecAttributeKey.AttrCanDerive);
		}
	}

	public bool CanSign
	{
		get
		{
			return Fetch(SecAttributeKey.AttrCanSign) == CFBoolean.True.Handle;
		}
		set
		{
			SetValue(CFBoolean.FromBoolean(value).Handle, SecAttributeKey.AttrCanSign);
		}
	}

	public bool CanVerify
	{
		get
		{
			return Fetch(SecAttributeKey.AttrCanVerify) == CFBoolean.True.Handle;
		}
		set
		{
			SetValue(CFBoolean.FromBoolean(value).Handle, SecAttributeKey.AttrCanVerify);
		}
	}

	public bool CanWrap
	{
		get
		{
			return Fetch(SecAttributeKey.AttrCanWrap) == CFBoolean.True.Handle;
		}
		set
		{
			SetValue(CFBoolean.FromBoolean(value).Handle, SecAttributeKey.AttrCanWrap);
		}
	}

	public bool CanUnwrap
	{
		get
		{
			return Fetch(SecAttributeKey.AttrCanUnwrap) == CFBoolean.True.Handle;
		}
		set
		{
			SetValue(CFBoolean.FromBoolean(value).Handle, SecAttributeKey.AttrCanUnwrap);
		}
	}

	public string AccessGroup
	{
		get
		{
			return FetchString(SecAttributeKey.AttrAccessGroup);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(new NSString(value), SecAttributeKey.AttrAccessGroup);
		}
	}

	public SecPolicy MatchPolicy
	{
		get
		{
			return new SecPolicy(Fetch(SecItem.MatchPolicy));
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(value.Handle, SecItem.MatchPolicy);
		}
	}

	public NSArray MatchItemList
	{
		get
		{
			return (NSArray)Runtime.GetNSObject(Fetch(SecItem.MatchItemList));
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(value, SecItem.MatchItemList);
		}
	}

	public NSData[] MatchIssuers
	{
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(NSArray.FromNSObjects(value), SecItem.MatchIssuers);
		}
	}

	public string MatchEmailAddressIfPresent
	{
		get
		{
			return FetchString(SecItem.MatchEmailAddressIfPresent);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(new NSString(value), SecItem.MatchEmailAddressIfPresent);
		}
	}

	public string MatchSubjectContains
	{
		get
		{
			return FetchString(SecItem.MatchSubjectContains);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(new NSString(value), SecItem.MatchSubjectContains);
		}
	}

	public bool MatchCaseInsensitive
	{
		get
		{
			return Fetch(SecItem.MatchCaseInsensitive) == CFBoolean.True.Handle;
		}
		set
		{
			SetValue(CFBoolean.FromBoolean(value).Handle, SecItem.MatchCaseInsensitive);
		}
	}

	public bool MatchTrustedOnly
	{
		get
		{
			return Fetch(SecItem.MatchTrustedOnly) == CFBoolean.True.Handle;
		}
		set
		{
			SetValue(CFBoolean.FromBoolean(value).Handle, SecItem.MatchTrustedOnly);
		}
	}

	public NSDate MatchValidOnDate
	{
		get
		{
			return (NSDate)Runtime.GetNSObject(Fetch(SecItem.MatchValidOnDate));
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(value, SecItem.MatchValidOnDate);
		}
	}

	public NSData ValueData
	{
		get
		{
			return FetchData(SecItem.ValueData);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(value, SecItem.ValueData);
		}
	}

	public NSObject ValueRef
	{
		get
		{
			return FetchObject(SecItem.ValueRef);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(value, SecItem.ValueRef);
		}
	}

	internal SecRecord(NSMutableDictionary dict)
	{
		queryDict = dict;
	}

	public SecRecord(SecKind secKind)
	{
		IntPtr intPtr = SecClass.FromSecKind(secKind);
		if (intPtr == SecClass.Identity)
		{
			queryDict = new NSMutableDictionary();
		}
		else
		{
			queryDict = NSMutableDictionary.LowlevelFromObjectAndKey(intPtr, SecClass.SecClassKey);
		}
	}

	public SecRecord Clone()
	{
		return new SecRecord(NSMutableDictionary.FromDictionary(queryDict));
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	public virtual void Dispose(bool disposing)
	{
		if (queryDict != null && disposing)
		{
			queryDict.Dispose();
			queryDict = null;
		}
	}

	~SecRecord()
	{
		Dispose(disposing: false);
	}

	private IntPtr Fetch(IntPtr key)
	{
		return queryDict.LowlevelObjectForKey(key);
	}

	private NSObject FetchObject(IntPtr key)
	{
		return Runtime.GetNSObject(queryDict.LowlevelObjectForKey(key));
	}

	private string FetchString(IntPtr key)
	{
		return (NSString)Runtime.GetNSObject(queryDict.LowlevelObjectForKey(key));
	}

	private NSNumber FetchNumber(IntPtr key)
	{
		return (NSNumber)Runtime.GetNSObject(queryDict.LowlevelObjectForKey(key));
	}

	private NSData FetchData(IntPtr key)
	{
		return (NSData)Runtime.GetNSObject(queryDict.LowlevelObjectForKey(key));
	}

	private void SetValue(NSObject val, IntPtr key)
	{
		queryDict.LowlevelSetObject(val, key);
	}

	private void SetValue(IntPtr val, IntPtr key)
	{
		queryDict.LowlevelSetObject(val, key);
	}
}

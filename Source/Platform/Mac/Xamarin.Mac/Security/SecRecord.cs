using System;
using CoreFoundation;
using Foundation;
using LocalAuthentication;
using ObjCRuntime;

namespace Security;

public class SecRecord : IDisposable
{
	private NSMutableDictionary _queryDict;

	private SecAccessControl _secAccessControl;

	internal NSMutableDictionary queryDict
	{
		get
		{
			return _queryDict;
		}
		set
		{
			_queryDict = ((value != null) ? ((NSMutableDictionary)value.MutableCopy()) : null);
		}
	}

	public SecAccessible Accessible
	{
		get
		{
			return KeysAccessible.ToSecAccessible(Fetch(SecAttributeKey.Accessible));
		}
		set
		{
			SetValue(KeysAccessible.FromSecAccessible(value), SecAttributeKey.Accessible);
		}
	}

	public bool Synchronizable
	{
		get
		{
			return FetchBool(SecAttributeKey.Synchronizable, defaultValue: false);
		}
		set
		{
			SetValue(new NSNumber(value ? 1 : 0), SecAttributeKey.Synchronizable);
		}
	}

	public bool SynchronizableAny
	{
		get
		{
			return FetchBool(SecAttributeKey.SynchronizableAny, defaultValue: false);
		}
		set
		{
			SetValue(new NSNumber(value ? 1 : 0), SecAttributeKey.SynchronizableAny);
		}
	}

	public NSDate CreationDate
	{
		get
		{
			return (NSDate)FetchObject(SecAttributeKey.CreationDate);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(value, SecAttributeKey.CreationDate);
		}
	}

	public NSDate ModificationDate
	{
		get
		{
			return (NSDate)FetchObject(SecAttributeKey.ModificationDate);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(value, SecAttributeKey.ModificationDate);
		}
	}

	public string Description
	{
		get
		{
			return FetchString(SecAttributeKey.Description);
		}
		set
		{
			SetValue(value, SecAttributeKey.Description);
		}
	}

	public string Comment
	{
		get
		{
			return FetchString(SecAttributeKey.Comment);
		}
		set
		{
			SetValue(value, SecAttributeKey.Comment);
		}
	}

	public int Creator
	{
		get
		{
			return FetchInt(SecAttributeKey.Creator);
		}
		set
		{
			SetValue(new NSNumber(value), SecAttributeKey.Creator);
		}
	}

	public int CreatorType
	{
		get
		{
			return FetchInt(SecAttributeKey.Type);
		}
		set
		{
			SetValue(new NSNumber(value), SecAttributeKey.Type);
		}
	}

	public string Label
	{
		get
		{
			return FetchString(SecAttributeKeys.LabelKey.Handle);
		}
		set
		{
			SetValue(value, SecAttributeKeys.LabelKey.Handle);
		}
	}

	public bool Invisible
	{
		get
		{
			return Fetch(SecAttributeKey.IsInvisible) == CFBoolean.TrueHandle;
		}
		set
		{
			SetValue(CFBoolean.ToHandle(value), SecAttributeKey.IsInvisible);
		}
	}

	public bool IsNegative
	{
		get
		{
			return Fetch(SecAttributeKey.IsNegative) == CFBoolean.TrueHandle;
		}
		set
		{
			SetValue(CFBoolean.ToHandle(value), SecAttributeKey.IsNegative);
		}
	}

	public string Account
	{
		get
		{
			return FetchString(SecAttributeKey.Account);
		}
		set
		{
			SetValue(value, SecAttributeKey.Account);
		}
	}

	public string Service
	{
		get
		{
			return FetchString(SecAttributeKey.Service);
		}
		set
		{
			SetValue(value, SecAttributeKey.Service);
		}
	}

	[iOS(9, 0)]
	[Mac(10, 11)]
	public SecAuthenticationUI AuthenticationUI
	{
		get
		{
			NSString nSString = Fetch<NSString>(SecItem.UseAuthenticationUI);
			return (nSString == null) ? SecAuthenticationUI.NotSet : SecAuthenticationUIExtensions.GetValue(nSString);
		}
		set
		{
			SetValue((NSObject)value.GetConstant(), SecItem.UseAuthenticationUI);
		}
	}

	[iOS(9, 0)]
	[Mac(10, 11)]
	public LAContext AuthenticationContext
	{
		get
		{
			return Fetch<LAContext>(SecItem.UseAuthenticationContext);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(value.Handle, SecItem.UseAuthenticationContext);
		}
	}

	public SecAccessControl AccessControl
	{
		get
		{
			return _secAccessControl;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			_secAccessControl = value;
			SetValue(value.Handle, SecAttributeKeys.AccessControlKey.Handle);
		}
	}

	public NSData Generic
	{
		get
		{
			return Fetch<NSData>(SecAttributeKey.Generic);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(value, SecAttributeKey.Generic);
		}
	}

	public string SecurityDomain
	{
		get
		{
			return FetchString(SecAttributeKey.SecurityDomain);
		}
		set
		{
			SetValue(value, SecAttributeKey.SecurityDomain);
		}
	}

	public string Server
	{
		get
		{
			return FetchString(SecAttributeKey.Server);
		}
		set
		{
			SetValue(value, SecAttributeKey.Server);
		}
	}

	public SecProtocol Protocol
	{
		get
		{
			return SecProtocolKeys.ToSecProtocol(Fetch(SecAttributeKey.Protocol));
		}
		set
		{
			SetValue(SecProtocolKeys.FromSecProtocol(value), SecAttributeKey.Protocol);
		}
	}

	public SecAuthenticationType AuthenticationType
	{
		get
		{
			IntPtr intPtr = Fetch(SecAttributeKey.AuthenticationType);
			if (intPtr == IntPtr.Zero)
			{
				return SecAuthenticationType.Default;
			}
			return KeysAuthenticationType.ToSecAuthenticationType(intPtr);
		}
		set
		{
			SetValue(KeysAuthenticationType.FromSecAuthenticationType(value), SecAttributeKey.AuthenticationType);
		}
	}

	public int Port
	{
		get
		{
			return FetchInt(SecAttributeKey.Port);
		}
		set
		{
			SetValue(new NSNumber(value), SecAttributeKey.Port);
		}
	}

	public string Path
	{
		get
		{
			return FetchString(SecAttributeKey.Path);
		}
		set
		{
			SetValue(value, SecAttributeKey.Path);
		}
	}

	public string Subject => FetchString(SecAttributeKey.Subject);

	public NSData Issuer => Fetch<NSData>(SecAttributeKey.Issuer);

	public NSData SerialNumber => Fetch<NSData>(SecAttributeKey.SerialNumber);

	public NSData SubjectKeyID => Fetch<NSData>(SecAttributeKey.SubjectKeyID);

	public NSData PublicKeyHash => Fetch<NSData>(SecAttributeKey.PublicKeyHash);

	public NSNumber CertificateType => Fetch<NSNumber>(SecAttributeKey.CertificateType);

	public NSNumber CertificateEncoding => Fetch<NSNumber>(SecAttributeKey.CertificateEncoding);

	public SecKeyClass KeyClass
	{
		get
		{
			IntPtr intPtr = Fetch(SecAttributeKey.KeyClass);
			if (intPtr == IntPtr.Zero)
			{
				return SecKeyClass.Invalid;
			}
			using NSString constant = new NSString(intPtr);
			return SecKeyClassExtensions.GetValue(constant);
		}
		set
		{
			NSString constant = value.GetConstant();
			if (constant == null)
			{
				throw new ArgumentException("Unknown value");
			}
			SetValue((NSObject)constant, SecAttributeKey.KeyClass);
		}
	}

	public string ApplicationLabel
	{
		get
		{
			return FetchString(SecAttributeKey.ApplicationLabel);
		}
		set
		{
			SetValue(value, SecAttributeKey.ApplicationLabel);
		}
	}

	public bool IsPermanent
	{
		get
		{
			return Fetch(SecAttributeKeys.IsPermanentKey.Handle) == CFBoolean.TrueHandle;
		}
		set
		{
			SetValue(CFBoolean.ToHandle(value), SecAttributeKeys.IsPermanentKey.Handle);
		}
	}

	public bool IsSensitive
	{
		get
		{
			return Fetch(SecAttributeKey.IsSensitive) == CFBoolean.TrueHandle;
		}
		set
		{
			SetValue(CFBoolean.ToHandle(value), SecAttributeKey.IsSensitive);
		}
	}

	public bool IsExtractable
	{
		get
		{
			return Fetch(SecAttributeKey.IsExtractable) == CFBoolean.TrueHandle;
		}
		set
		{
			SetValue(CFBoolean.ToHandle(value), SecAttributeKey.IsExtractable);
		}
	}

	public NSData ApplicationTag
	{
		get
		{
			return Fetch<NSData>(SecAttributeKeys.ApplicationTagKey.Handle);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			SetValue(value, SecAttributeKeys.ApplicationTagKey.Handle);
		}
	}

	public SecKeyType KeyType
	{
		get
		{
			IntPtr intPtr = Fetch(SecKeyGenerationAttributeKeys.KeyTypeKey.Handle);
			if (intPtr == IntPtr.Zero)
			{
				return SecKeyType.Invalid;
			}
			using NSString constant = new NSString(intPtr);
			return SecKeyTypeExtensions.GetValue(constant);
		}
		set
		{
			NSString constant = value.GetConstant();
			if (constant == null)
			{
				throw new ArgumentException("Unknown value");
			}
			SetValue((NSObject)constant, SecKeyGenerationAttributeKeys.KeyTypeKey.Handle);
		}
	}

	public int KeySizeInBits
	{
		get
		{
			return FetchInt(SecKeyGenerationAttributeKeys.KeySizeInBitsKey.Handle);
		}
		set
		{
			SetValue(new NSNumber(value), SecKeyGenerationAttributeKeys.KeySizeInBitsKey.Handle);
		}
	}

	public int EffectiveKeySize
	{
		get
		{
			return FetchInt(SecAttributeKeys.EffectiveKeySizeKey.Handle);
		}
		set
		{
			SetValue(new NSNumber(value), SecAttributeKeys.EffectiveKeySizeKey.Handle);
		}
	}

	public bool CanEncrypt
	{
		get
		{
			return Fetch(SecAttributeKeys.CanEncryptKey.Handle) == CFBoolean.TrueHandle;
		}
		set
		{
			SetValue(CFBoolean.ToHandle(value), SecAttributeKeys.CanEncryptKey.Handle);
		}
	}

	public bool CanDecrypt
	{
		get
		{
			return Fetch(SecAttributeKeys.CanDecryptKey.Handle) == CFBoolean.TrueHandle;
		}
		set
		{
			SetValue(CFBoolean.ToHandle(value), SecAttributeKeys.CanDecryptKey.Handle);
		}
	}

	public bool CanDerive
	{
		get
		{
			return Fetch(SecAttributeKeys.CanDeriveKey.Handle) == CFBoolean.TrueHandle;
		}
		set
		{
			SetValue(CFBoolean.ToHandle(value), SecAttributeKeys.CanDeriveKey.Handle);
		}
	}

	public bool CanSign
	{
		get
		{
			return Fetch(SecAttributeKeys.CanSignKey.Handle) == CFBoolean.TrueHandle;
		}
		set
		{
			SetValue(CFBoolean.ToHandle(value), SecAttributeKeys.CanSignKey.Handle);
		}
	}

	public bool CanVerify
	{
		get
		{
			return Fetch(SecAttributeKeys.CanVerifyKey.Handle) == CFBoolean.TrueHandle;
		}
		set
		{
			SetValue(CFBoolean.ToHandle(value), SecAttributeKeys.CanVerifyKey.Handle);
		}
	}

	public bool CanWrap
	{
		get
		{
			return Fetch(SecKeyGenerationAttributeKeys.CanWrapKey.Handle) == CFBoolean.TrueHandle;
		}
		set
		{
			SetValue(CFBoolean.ToHandle(value), SecKeyGenerationAttributeKeys.CanWrapKey.Handle);
		}
	}

	public bool CanUnwrap
	{
		get
		{
			return Fetch(SecAttributeKeys.CanUnwrapKey.Handle) == CFBoolean.TrueHandle;
		}
		set
		{
			SetValue(CFBoolean.ToHandle(value), SecAttributeKeys.CanUnwrapKey.Handle);
		}
	}

	public string AccessGroup
	{
		get
		{
			return FetchString(SecAttributeKey.AccessGroup);
		}
		set
		{
			SetValue(value, SecAttributeKey.AccessGroup);
		}
	}

	[iOS(11, 0)]
	[TV(11, 0)]
	[Watch(4, 0)]
	[Mac(10, 13)]
	public bool PersistentReference
	{
		get
		{
			return Fetch(SecAttributeKey.PersistentReference) == CFBoolean.TrueHandle;
		}
		set
		{
			SetValue(CFBoolean.ToHandle(value), SecAttributeKey.PersistentReference);
		}
	}

	public SecPolicy MatchPolicy
	{
		get
		{
			IntPtr intPtr = Fetch(SecItem.MatchPolicy);
			return (intPtr == IntPtr.Zero) ? null : new SecPolicy(intPtr);
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

	public SecKeyChain[] MatchItemList
	{
		get
		{
			return NSArray.ArrayFromHandle<SecKeyChain>(Fetch(SecItem.MatchItemList));
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			using NSArray val = NSArray.FromNativeObjects(value);
			SetValue(val, SecItem.MatchItemList);
		}
	}

	public NSData[] MatchIssuers
	{
		get
		{
			return NSArray.ArrayFromHandle<NSData>(Fetch(SecItem.MatchIssuers));
		}
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
			SetValue(value, SecItem.MatchEmailAddressIfPresent);
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
			SetValue(value, SecItem.MatchSubjectContains);
		}
	}

	public bool MatchCaseInsensitive
	{
		get
		{
			return Fetch(SecItem.MatchCaseInsensitive) == CFBoolean.TrueHandle;
		}
		set
		{
			SetValue(CFBoolean.ToHandle(value), SecItem.MatchCaseInsensitive);
		}
	}

	public bool MatchTrustedOnly
	{
		get
		{
			return Fetch(SecItem.MatchTrustedOnly) == CFBoolean.TrueHandle;
		}
		set
		{
			SetValue(CFBoolean.ToHandle(value), SecItem.MatchTrustedOnly);
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
			return Fetch<NSData>(SecItem.ValueData);
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

	internal SecRecord(NSMutableDictionary dict)
	{
		queryDict = dict;
	}

	public SecRecord()
	{
		queryDict = new NSMutableDictionary();
	}

	public SecRecord(SecKind secKind)
	{
		IntPtr obj = SecClass.FromSecKind(secKind);
		queryDict = NSMutableDictionary.LowlevelFromObjectAndKey(obj, SecClass.SecClassKey);
	}

	public SecRecord(SecCertificate certificate)
		: this(SecKind.Certificate)
	{
		SetCertificate(certificate);
	}

	public SecRecord(SecIdentity identity)
		: this(SecKind.Identity)
	{
		SetIdentity(identity);
	}

	public SecRecord(SecKey key)
		: this(SecKind.Key)
	{
		SetKey(key);
	}

	public SecCertificate GetCertificate()
	{
		CheckClass(SecClass.Certificate);
		return GetValueRef<SecCertificate>();
	}

	public SecIdentity GetIdentity()
	{
		CheckClass(SecClass.Identity);
		return GetValueRef<SecIdentity>();
	}

	public SecKey GetKey()
	{
		CheckClass(SecClass.Key);
		return GetValueRef<SecKey>();
	}

	private void CheckClass(IntPtr secClass)
	{
		IntPtr intPtr = queryDict.LowlevelObjectForKey(SecClass.SecClassKey);
		if (intPtr != secClass)
		{
			throw new InvalidOperationException("SecRecord of incompatible SecClass");
		}
	}

	public SecRecord Clone()
	{
		return new SecRecord(NSMutableDictionary.FromDictionary(queryDict));
	}

	public NSDictionary ToDictionary()
	{
		return queryDict;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
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
		return Runtime.GetNSObject(Fetch(key));
	}

	private string FetchString(IntPtr key)
	{
		return (NSString)FetchObject(key);
	}

	private int FetchInt(IntPtr key)
	{
		return ((NSNumber)FetchObject(key))?.Int32Value ?? (-1);
	}

	private bool FetchBool(IntPtr key, bool defaultValue)
	{
		NSNumber nSNumber = (NSNumber)FetchObject(key);
		return (nSNumber == null) ? defaultValue : (nSNumber.Int32Value != 0);
	}

	private T Fetch<T>(IntPtr key) where T : NSObject
	{
		return (T)FetchObject(key);
	}

	private void SetValue(NSObject val, IntPtr key)
	{
		queryDict.LowlevelSetObject(val, key);
	}

	private void SetValue(IntPtr val, IntPtr key)
	{
		queryDict.LowlevelSetObject(val, key);
	}

	private void SetValue(string value, IntPtr key)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		IntPtr intPtr = NSString.CreateNative(value);
		queryDict.LowlevelSetObject(intPtr, key);
		NSString.ReleaseNative(intPtr);
	}

	public T GetValueRef<T>() where T : class, INativeObject
	{
		return Runtime.GetINativeObject<T>(queryDict.LowlevelObjectForKey(SecItem.ValueRef), owns: false);
	}

	public void SetValueRef(INativeObject value)
	{
		SetValue(value?.Handle ?? IntPtr.Zero, SecItem.ValueRef);
	}

	public void SetCertificate(SecCertificate cert)
	{
		SetValueRef(cert);
	}

	public void SetIdentity(SecIdentity identity)
	{
		SetValueRef(identity);
	}

	public void SetKey(SecKey key)
	{
		SetValueRef(key);
	}
}

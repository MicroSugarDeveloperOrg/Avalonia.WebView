using System;
using System.Runtime.InteropServices;
using System.Text;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace Security;

public class SecKeyChain : INativeObject
{
	public IntPtr Handle { get; internal set; }

	internal SecKeyChain(IntPtr handle)
	{
		Handle = handle;
	}

	private static NSNumber SetLimit(NSMutableDictionary dict, int max)
	{
		NSNumber nSNumber = null;
		IntPtr obj;
		switch (max)
		{
		case -1:
			obj = SecMatchLimit.MatchLimitAll;
			break;
		case 1:
			obj = SecMatchLimit.MatchLimitOne;
			break;
		default:
			nSNumber = NSNumber.FromInt32(max);
			obj = nSNumber.Handle;
			break;
		}
		dict.LowlevelSetObject(obj, SecItem.MatchLimit);
		return nSNumber;
	}

	public static NSData QueryAsData(SecRecord query, bool wantPersistentReference, out SecStatusCode status)
	{
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		using NSMutableDictionary nSMutableDictionary = NSMutableDictionary.FromDictionary(query.queryDict);
		SetLimit(nSMutableDictionary, 1);
		if (wantPersistentReference)
		{
			nSMutableDictionary.LowlevelSetObject(CFBoolean.TrueHandle, SecItem.ReturnPersistentRef);
		}
		else
		{
			nSMutableDictionary.LowlevelSetObject(CFBoolean.TrueHandle, SecItem.ReturnData);
		}
		status = SecItem.SecItemCopyMatching(nSMutableDictionary.Handle, out var result);
		if (status == SecStatusCode.Success)
		{
			return new NSData(result, owns: false);
		}
		return null;
	}

	public static NSData[] QueryAsData(SecRecord query, bool wantPersistentReference, int max, out SecStatusCode status)
	{
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		using NSMutableDictionary nSMutableDictionary = NSMutableDictionary.FromDictionary(query.queryDict);
		NSNumber nSNumber = SetLimit(nSMutableDictionary, max);
		if (wantPersistentReference)
		{
			nSMutableDictionary.LowlevelSetObject(CFBoolean.TrueHandle, SecItem.ReturnPersistentRef);
		}
		else
		{
			nSMutableDictionary.LowlevelSetObject(CFBoolean.TrueHandle, SecItem.ReturnData);
		}
		status = SecItem.SecItemCopyMatching(nSMutableDictionary.Handle, out var result);
		nSNumber = null;
		if (status == SecStatusCode.Success)
		{
			if (max == 1)
			{
				return new NSData[1]
				{
					new NSData(result, owns: false)
				};
			}
			using NSArray nSArray = new NSArray(result);
			NSData[] array = new NSData[(ulong)nSArray.Count];
			for (uint num = 0u; num < array.Length; num++)
			{
				array[num] = new NSData(nSArray.ValueAt(num), owns: false);
			}
			return array;
		}
		return null;
	}

	public static NSData QueryAsData(SecRecord query)
	{
		SecStatusCode status;
		return QueryAsData(query, wantPersistentReference: false, out status);
	}

	public static NSData[] QueryAsData(SecRecord query, int max)
	{
		SecStatusCode status;
		return QueryAsData(query, wantPersistentReference: false, max, out status);
	}

	public static SecRecord QueryAsRecord(SecRecord query, out SecStatusCode result)
	{
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		using NSMutableDictionary nSMutableDictionary = NSMutableDictionary.FromDictionary(query.queryDict);
		SetLimit(nSMutableDictionary, 1);
		nSMutableDictionary.LowlevelSetObject(CFBoolean.TrueHandle, SecItem.ReturnAttributes);
		nSMutableDictionary.LowlevelSetObject(CFBoolean.TrueHandle, SecItem.ReturnData);
		result = SecItem.SecItemCopyMatching(nSMutableDictionary.Handle, out var result2);
		if (result == SecStatusCode.Success)
		{
			return new SecRecord(new NSMutableDictionary(result2, owns: false));
		}
		return null;
	}

	public static SecRecord[] QueryAsRecord(SecRecord query, int max, out SecStatusCode result)
	{
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		using NSMutableDictionary nSMutableDictionary = NSMutableDictionary.FromDictionary(query.queryDict);
		nSMutableDictionary.LowlevelSetObject(CFBoolean.TrueHandle, SecItem.ReturnAttributes);
		nSMutableDictionary.LowlevelSetObject(CFBoolean.TrueHandle, SecItem.ReturnData);
		NSNumber nSNumber = SetLimit(nSMutableDictionary, max);
		result = SecItem.SecItemCopyMatching(nSMutableDictionary.Handle, out var result2);
		nSNumber = null;
		if (result == SecStatusCode.Success)
		{
			using (NSArray nSArray = new NSArray(result2))
			{
				SecRecord[] array = new SecRecord[(ulong)nSArray.Count];
				for (uint num = 0u; num < array.Length; num++)
				{
					array[num] = new SecRecord(new NSMutableDictionary(nSArray.ValueAt(num), owns: false));
				}
				return array;
			}
		}
		return null;
	}

	public static INativeObject[] QueryAsReference(SecRecord query, int max, out SecStatusCode result)
	{
		if (query == null)
		{
			result = SecStatusCode.Param;
			return null;
		}
		using NSMutableDictionary nSMutableDictionary = NSMutableDictionary.FromDictionary(query.queryDict);
		nSMutableDictionary.LowlevelSetObject(CFBoolean.TrueHandle, SecItem.ReturnRef);
		SetLimit(nSMutableDictionary, max);
		result = SecItem.SecItemCopyMatching(nSMutableDictionary.Handle, out var result2);
		if (result == SecStatusCode.Success && result2 != IntPtr.Zero)
		{
			return NSArray.ArrayFromHandle(result2, (Converter<IntPtr, INativeObject>)delegate(IntPtr p)
			{
				nint typeID = CFType.GetTypeID(p);
				if (typeID == SecCertificate.GetTypeID())
				{
					return new SecCertificate(p, owns: true);
				}
				if (typeID == SecKey.GetTypeID())
				{
					return new SecKey(p, owns: true);
				}
				if (!(typeID == SecIdentity.GetTypeID()))
				{
					throw new Exception($"Unexpected type: 0x{typeID:x}");
				}
				return new SecIdentity(p, owns: true);
			});
		}
		return null;
	}

	public static SecStatusCode Add(SecRecord record)
	{
		if (record == null)
		{
			throw new ArgumentNullException("record");
		}
		return SecItem.SecItemAdd(record.queryDict.Handle, IntPtr.Zero);
	}

	public static SecStatusCode Remove(SecRecord record)
	{
		if (record == null)
		{
			throw new ArgumentNullException("record");
		}
		return SecItem.SecItemDelete(record.queryDict.Handle);
	}

	public static SecStatusCode Update(SecRecord query, SecRecord newAttributes)
	{
		if (query == null)
		{
			throw new ArgumentNullException("record");
		}
		if (newAttributes == null)
		{
			throw new ArgumentNullException("newAttributes");
		}
		return SecItem.SecItemUpdate(query.queryDict.Handle, newAttributes.queryDict.Handle);
	}

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecKeychainAddGenericPassword(IntPtr keychain, int serviceNameLength, byte[] serviceName, int accountNameLength, byte[] accountName, int passwordLength, byte[] passwordData, IntPtr itemRef);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecKeychainFindGenericPassword(IntPtr keychainOrArray, int serviceNameLength, byte[] serviceName, int accountNameLength, byte[] accountName, out int passwordLength, out IntPtr passwordData, IntPtr itemRef);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecKeychainAddInternetPassword(IntPtr keychain, int serverNameLength, byte[] serverName, int securityDomainLength, byte[] securityDomain, int accountNameLength, byte[] accountName, int pathLength, byte[] path, short port, IntPtr protocol, IntPtr authenticationType, int passwordLength, byte[] passwordData, IntPtr itemRef);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecKeychainFindInternetPassword(IntPtr keychain, int serverNameLength, byte[] serverName, int securityDomainLength, byte[] securityDomain, int accountNameLength, byte[] accountName, int pathLength, byte[] path, short port, IntPtr protocol, IntPtr authenticationType, out int passwordLength, out IntPtr passwordData, IntPtr itemRef);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecKeychainItemFreeContent(IntPtr attrList, IntPtr data);

	public static SecStatusCode AddInternetPassword(string serverName, string accountName, byte[] password, SecProtocol protocolType = SecProtocol.Http, short port = 0, string path = null, SecAuthenticationType authenticationType = SecAuthenticationType.Default, string securityDomain = null)
	{
		byte[] array = null;
		byte[] array2 = null;
		byte[] array3 = null;
		byte[] array4 = null;
		if (!string.IsNullOrEmpty(serverName))
		{
			array = Encoding.UTF8.GetBytes(serverName);
		}
		if (!string.IsNullOrEmpty(securityDomain))
		{
			array2 = Encoding.UTF8.GetBytes(securityDomain);
		}
		if (!string.IsNullOrEmpty(accountName))
		{
			array3 = Encoding.UTF8.GetBytes(accountName);
		}
		if (!string.IsNullOrEmpty(path))
		{
			array4 = Encoding.UTF8.GetBytes(path);
		}
		return SecKeychainAddInternetPassword(IntPtr.Zero, (array != null) ? array.Length : 0, array, (array2 != null) ? array2.Length : 0, array2, (array3 != null) ? array3.Length : 0, array3, (array4 != null) ? array4.Length : 0, array4, port, SecProtocolKeys.FromSecProtocol(protocolType), KeysAuthenticationType.FromSecAuthenticationType(authenticationType), (password != null) ? password.Length : 0, password, IntPtr.Zero);
	}

	public static SecStatusCode FindInternetPassword(string serverName, string accountName, out byte[] password, SecProtocol protocolType = SecProtocol.Http, short port = 0, string path = null, SecAuthenticationType authenticationType = SecAuthenticationType.Default, string securityDomain = null)
	{
		password = null;
		byte[] array = null;
		byte[] array2 = null;
		byte[] array3 = null;
		byte[] array4 = null;
		IntPtr passwordData = IntPtr.Zero;
		try
		{
			if (!string.IsNullOrEmpty(serverName))
			{
				array = Encoding.UTF8.GetBytes(serverName);
			}
			if (!string.IsNullOrEmpty(securityDomain))
			{
				array2 = Encoding.UTF8.GetBytes(securityDomain);
			}
			if (!string.IsNullOrEmpty(accountName))
			{
				array3 = Encoding.UTF8.GetBytes(accountName);
			}
			if (!string.IsNullOrEmpty(path))
			{
				array4 = Encoding.UTF8.GetBytes(path);
			}
			int passwordLength = 0;
			SecStatusCode secStatusCode = SecKeychainFindInternetPassword(IntPtr.Zero, (array != null) ? array.Length : 0, array, (array2 != null) ? array2.Length : 0, array2, (array3 != null) ? array3.Length : 0, array3, (array4 != null) ? array4.Length : 0, array4, port, SecProtocolKeys.FromSecProtocol(protocolType), KeysAuthenticationType.FromSecAuthenticationType(authenticationType), out passwordLength, out passwordData, IntPtr.Zero);
			if (secStatusCode == SecStatusCode.Success && passwordLength > 0)
			{
				password = new byte[passwordLength];
				Marshal.Copy(passwordData, password, 0, passwordLength);
			}
			return secStatusCode;
		}
		finally
		{
			if (passwordData != IntPtr.Zero)
			{
				SecKeychainItemFreeContent(IntPtr.Zero, passwordData);
			}
		}
	}

	public static SecStatusCode AddGenericPassword(string serviceName, string accountName, byte[] password)
	{
		byte[] array = null;
		byte[] array2 = null;
		if (!string.IsNullOrEmpty(serviceName))
		{
			array = Encoding.UTF8.GetBytes(serviceName);
		}
		if (!string.IsNullOrEmpty(accountName))
		{
			array2 = Encoding.UTF8.GetBytes(accountName);
		}
		return SecKeychainAddGenericPassword(IntPtr.Zero, (array != null) ? array.Length : 0, array, (array2 != null) ? array2.Length : 0, array2, (password != null) ? password.Length : 0, password, IntPtr.Zero);
	}

	public static SecStatusCode FindGenericPassword(string serviceName, string accountName, out byte[] password)
	{
		password = null;
		byte[] array = null;
		byte[] array2 = null;
		IntPtr passwordData = IntPtr.Zero;
		try
		{
			if (!string.IsNullOrEmpty(serviceName))
			{
				array = Encoding.UTF8.GetBytes(serviceName);
			}
			if (!string.IsNullOrEmpty(accountName))
			{
				array2 = Encoding.UTF8.GetBytes(accountName);
			}
			int passwordLength = 0;
			SecStatusCode secStatusCode = SecKeychainFindGenericPassword(IntPtr.Zero, (array != null) ? array.Length : 0, array, (array2 != null) ? array2.Length : 0, array2, out passwordLength, out passwordData, IntPtr.Zero);
			if (secStatusCode == SecStatusCode.Success && passwordLength > 0)
			{
				password = new byte[passwordLength];
				Marshal.Copy(passwordData, password, 0, passwordLength);
			}
			return secStatusCode;
		}
		finally
		{
			if (passwordData != IntPtr.Zero)
			{
				SecKeychainItemFreeContent(IntPtr.Zero, passwordData);
			}
		}
	}

	public static void AddIdentity(SecIdentity identity)
	{
		if (identity == null)
		{
			throw new ArgumentNullException("identity");
		}
		using SecRecord secRecord = new SecRecord();
		secRecord.SetValueRef(identity);
		SecStatusCode secStatusCode = Add(secRecord);
		if (secStatusCode != SecStatusCode.DuplicateItem && secStatusCode != 0)
		{
			throw new InvalidOperationException(secStatusCode.ToString());
		}
	}

	public static void RemoveIdentity(SecIdentity identity)
	{
		if (identity == null)
		{
			throw new ArgumentNullException("identity");
		}
		using SecRecord secRecord = new SecRecord();
		secRecord.SetValueRef(identity);
		SecStatusCode secStatusCode = Remove(secRecord);
		if (secStatusCode != SecStatusCode.ItemNotFound && secStatusCode != 0)
		{
			throw new InvalidOperationException(secStatusCode.ToString());
		}
	}

	public static SecIdentity FindIdentity(SecCertificate certificate, bool throwOnError = false)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		SecIdentity secIdentity = FindIdentity((SecCertificate cert) => SecCertificate.Equals(certificate, cert));
		if (!throwOnError || secIdentity != null)
		{
			return secIdentity;
		}
		throw new InvalidOperationException($"Could not find SecIdentity for certificate '{certificate.SubjectSummary}' in keychain.");
	}

	private static SecIdentity FindIdentity(Predicate<SecCertificate> filter)
	{
		using (SecRecord query = new SecRecord(SecKind.Identity))
		{
			SecStatusCode result;
			INativeObject[] array = QueryAsReference(query, -1, out result);
			if (result != 0 || array == null)
			{
				return null;
			}
			for (int i = 0; i < array.Length; i++)
			{
				SecIdentity secIdentity = (SecIdentity)array[i];
				if (filter(secIdentity.Certificate))
				{
					return secIdentity;
				}
			}
		}
		return null;
	}
}

using System;
using System.Runtime.InteropServices;
using System.Text;
using CoreFoundation;
using Foundation;

namespace Security;

public static class SecKeyChain
{
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
		nSMutableDictionary.LowlevelSetObject(CFBoolean.True.Handle, SecItem.ReturnData);
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
		SetLimit(nSMutableDictionary, max);
		nSMutableDictionary.LowlevelSetObject(CFBoolean.True.Handle, SecItem.ReturnData);
		status = SecItem.SecItemCopyMatching(nSMutableDictionary.Handle, out var result);
		if (status == SecStatusCode.Success)
		{
			if (max == 1)
			{
				return new NSData[1]
				{
					new NSData(result, owns: false)
				};
			}
			NSArray nSArray = new NSArray(result);
			NSData[] array = new NSData[nSArray.Count];
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
		nSMutableDictionary.LowlevelSetObject(CFBoolean.True.Handle, SecItem.ReturnAttributes);
		nSMutableDictionary.LowlevelSetObject(CFBoolean.True.Handle, SecItem.ReturnData);
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
		nSMutableDictionary.LowlevelSetObject(CFBoolean.True.Handle, SecItem.ReturnAttributes);
		SetLimit(nSMutableDictionary, max);
		result = SecItem.SecItemCopyMatching(nSMutableDictionary.Handle, out var result2);
		if (result == SecStatusCode.Success)
		{
			NSArray nSArray = new NSArray(result2);
			SecRecord[] array = new SecRecord[nSArray.Count];
			for (uint num = 0u; num < array.Length; num++)
			{
				array[num] = new SecRecord(new NSMutableDictionary(nSArray.ValueAt(num), owns: false));
			}
			return array;
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
	private static extern SecStatusCode SecKeychainAddGenericPassword(IntPtr keychain, int serviceNameLength, IntPtr serviceName, int accountNameLength, IntPtr accountName, int passwordLength, IntPtr passwordData, IntPtr itemRef);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecKeychainFindGenericPassword(IntPtr keychainOrArray, int serviceNameLength, IntPtr serviceName, int accountNameLength, IntPtr accountName, out int passwordLength, out IntPtr passwordData, IntPtr itemRef);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecKeychainAddInternetPassword(IntPtr keychain, int serverNameLength, IntPtr serverName, int securityDomainLength, IntPtr securityDomain, int accountNameLength, IntPtr accountName, int pathLength, IntPtr path, short port, IntPtr protocol, IntPtr authenticationType, int passwordLength, IntPtr passwordData, IntPtr itemRef);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecKeychainFindInternetPassword(IntPtr keychain, int serverNameLength, IntPtr serverName, int securityDomainLength, IntPtr securityDomain, int accountNameLength, IntPtr accountName, int pathLength, IntPtr path, short port, IntPtr protocol, IntPtr authenticationType, out int passwordLength, out IntPtr passwordData, IntPtr itemRef);

	[DllImport("/System/Library/Frameworks/Security.framework/Security")]
	private static extern SecStatusCode SecKeychainItemFreeContent(IntPtr attrList, IntPtr data);

	public static SecStatusCode AddInternetPassword(string serverName, string accountName, byte[] password, SecProtocol protocolType = SecProtocol.Http, short port = 0, string path = null, SecAuthenticationType authenticationType = SecAuthenticationType.Default, string securityDomain = null)
	{
		GCHandle gCHandle = default(GCHandle);
		GCHandle gCHandle2 = default(GCHandle);
		GCHandle gCHandle3 = default(GCHandle);
		GCHandle gCHandle4 = default(GCHandle);
		GCHandle gCHandle5 = default(GCHandle);
		int serverNameLength = 0;
		IntPtr serverName2 = IntPtr.Zero;
		int securityDomainLength = 0;
		IntPtr zero = IntPtr.Zero;
		int accountNameLength = 0;
		IntPtr accountName2 = IntPtr.Zero;
		int pathLength = 0;
		IntPtr path2 = IntPtr.Zero;
		int passwordLength = 0;
		IntPtr passwordData = IntPtr.Zero;
		try
		{
			if (!string.IsNullOrEmpty(serverName))
			{
				byte[] bytes = Encoding.UTF8.GetBytes(serverName);
				serverNameLength = bytes.Length;
				gCHandle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
				serverName2 = gCHandle.AddrOfPinnedObject();
			}
			if (!string.IsNullOrEmpty(securityDomain))
			{
				byte[] bytes2 = Encoding.UTF8.GetBytes(securityDomain);
				securityDomainLength = bytes2.Length;
				gCHandle2 = GCHandle.Alloc(bytes2, GCHandleType.Pinned);
			}
			if (!string.IsNullOrEmpty(accountName))
			{
				byte[] bytes3 = Encoding.UTF8.GetBytes(accountName);
				accountNameLength = bytes3.Length;
				gCHandle3 = GCHandle.Alloc(bytes3, GCHandleType.Pinned);
				accountName2 = gCHandle3.AddrOfPinnedObject();
			}
			if (!string.IsNullOrEmpty(path))
			{
				byte[] bytes4 = Encoding.UTF8.GetBytes(path);
				pathLength = bytes4.Length;
				gCHandle4 = GCHandle.Alloc(bytes4, GCHandleType.Pinned);
				path2 = gCHandle4.AddrOfPinnedObject();
			}
			if (password != null && password.Length != 0)
			{
				passwordLength = password.Length;
				gCHandle5 = GCHandle.Alloc(password, GCHandleType.Pinned);
				passwordData = gCHandle5.AddrOfPinnedObject();
			}
			return SecKeychainAddInternetPassword(IntPtr.Zero, serverNameLength, serverName2, securityDomainLength, zero, accountNameLength, accountName2, pathLength, path2, port, SecProtocolKeys.FromSecProtocol(protocolType), KeysAuthenticationType.FromSecAuthenticationType(authenticationType), passwordLength, passwordData, IntPtr.Zero);
		}
		finally
		{
			if (gCHandle.IsAllocated)
			{
				gCHandle.Free();
			}
			if (gCHandle3.IsAllocated)
			{
				gCHandle3.Free();
			}
			if (gCHandle5.IsAllocated)
			{
				gCHandle5.Free();
			}
			if (gCHandle2.IsAllocated)
			{
				gCHandle2.Free();
			}
			if (gCHandle4.IsAllocated)
			{
				gCHandle4.Free();
			}
		}
	}

	public static SecStatusCode FindInternetPassword(string serverName, string accountName, out byte[] password, SecProtocol protocolType = SecProtocol.Http, short port = 0, string path = null, SecAuthenticationType authenticationType = SecAuthenticationType.Default, string securityDomain = null)
	{
		password = null;
		GCHandle gCHandle = default(GCHandle);
		GCHandle gCHandle2 = default(GCHandle);
		GCHandle gCHandle3 = default(GCHandle);
		GCHandle gCHandle4 = default(GCHandle);
		int serverNameLength = 0;
		IntPtr serverName2 = IntPtr.Zero;
		int securityDomainLength = 0;
		IntPtr zero = IntPtr.Zero;
		int accountNameLength = 0;
		IntPtr accountName2 = IntPtr.Zero;
		int pathLength = 0;
		IntPtr path2 = IntPtr.Zero;
		IntPtr passwordData = IntPtr.Zero;
		try
		{
			if (!string.IsNullOrEmpty(serverName))
			{
				byte[] bytes = Encoding.UTF8.GetBytes(serverName);
				serverNameLength = bytes.Length;
				gCHandle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
				serverName2 = gCHandle.AddrOfPinnedObject();
			}
			if (!string.IsNullOrEmpty(securityDomain))
			{
				byte[] bytes2 = Encoding.UTF8.GetBytes(securityDomain);
				securityDomainLength = bytes2.Length;
				gCHandle2 = GCHandle.Alloc(bytes2, GCHandleType.Pinned);
			}
			if (!string.IsNullOrEmpty(accountName))
			{
				byte[] bytes3 = Encoding.UTF8.GetBytes(accountName);
				accountNameLength = bytes3.Length;
				gCHandle3 = GCHandle.Alloc(bytes3, GCHandleType.Pinned);
				accountName2 = gCHandle3.AddrOfPinnedObject();
			}
			if (!string.IsNullOrEmpty(path))
			{
				byte[] bytes4 = Encoding.UTF8.GetBytes(path);
				pathLength = bytes4.Length;
				gCHandle4 = GCHandle.Alloc(bytes4, GCHandleType.Pinned);
				path2 = gCHandle4.AddrOfPinnedObject();
			}
			int passwordLength = 0;
			SecStatusCode num = SecKeychainFindInternetPassword(IntPtr.Zero, serverNameLength, serverName2, securityDomainLength, zero, accountNameLength, accountName2, pathLength, path2, port, SecProtocolKeys.FromSecProtocol(protocolType), KeysAuthenticationType.FromSecAuthenticationType(authenticationType), out passwordLength, out passwordData, IntPtr.Zero);
			if (num == SecStatusCode.Success && passwordLength > 0)
			{
				password = new byte[passwordLength];
				Marshal.Copy(passwordData, password, 0, passwordLength);
			}
			return num;
		}
		finally
		{
			if (gCHandle.IsAllocated)
			{
				gCHandle.Free();
			}
			if (gCHandle3.IsAllocated)
			{
				gCHandle3.Free();
			}
			if (gCHandle2.IsAllocated)
			{
				gCHandle2.Free();
			}
			if (gCHandle4.IsAllocated)
			{
				gCHandle4.Free();
			}
			if (passwordData != IntPtr.Zero)
			{
				SecKeychainItemFreeContent(IntPtr.Zero, passwordData);
			}
		}
	}

	public static SecStatusCode AddGenericPassword(string serviceName, string accountName, byte[] password)
	{
		GCHandle gCHandle = default(GCHandle);
		GCHandle gCHandle2 = default(GCHandle);
		GCHandle gCHandle3 = default(GCHandle);
		int serviceNameLength = 0;
		IntPtr serviceName2 = IntPtr.Zero;
		int accountNameLength = 0;
		IntPtr accountName2 = IntPtr.Zero;
		int passwordLength = 0;
		IntPtr passwordData = IntPtr.Zero;
		try
		{
			if (!string.IsNullOrEmpty(serviceName))
			{
				byte[] bytes = Encoding.UTF8.GetBytes(serviceName);
				serviceNameLength = bytes.Length;
				gCHandle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
				serviceName2 = gCHandle.AddrOfPinnedObject();
			}
			if (!string.IsNullOrEmpty(accountName))
			{
				byte[] bytes2 = Encoding.UTF8.GetBytes(accountName);
				accountNameLength = bytes2.Length;
				gCHandle2 = GCHandle.Alloc(bytes2, GCHandleType.Pinned);
				accountName2 = gCHandle2.AddrOfPinnedObject();
			}
			if (password != null && password.Length != 0)
			{
				passwordLength = password.Length;
				gCHandle3 = GCHandle.Alloc(password, GCHandleType.Pinned);
				passwordData = gCHandle3.AddrOfPinnedObject();
			}
			return SecKeychainAddGenericPassword(IntPtr.Zero, serviceNameLength, serviceName2, accountNameLength, accountName2, passwordLength, passwordData, IntPtr.Zero);
		}
		finally
		{
			if (gCHandle.IsAllocated)
			{
				gCHandle.Free();
			}
			if (gCHandle2.IsAllocated)
			{
				gCHandle2.Free();
			}
			if (gCHandle3.IsAllocated)
			{
				gCHandle3.Free();
			}
		}
	}

	public static SecStatusCode FindGenericPassword(string serviceName, string accountName, out byte[] password)
	{
		password = null;
		GCHandle gCHandle = default(GCHandle);
		GCHandle gCHandle2 = default(GCHandle);
		int serviceNameLength = 0;
		IntPtr serviceName2 = IntPtr.Zero;
		int accountNameLength = 0;
		IntPtr accountName2 = IntPtr.Zero;
		IntPtr passwordData = IntPtr.Zero;
		try
		{
			if (!string.IsNullOrEmpty(serviceName))
			{
				byte[] bytes = Encoding.UTF8.GetBytes(serviceName);
				serviceNameLength = bytes.Length;
				gCHandle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
				serviceName2 = gCHandle.AddrOfPinnedObject();
			}
			if (!string.IsNullOrEmpty(accountName))
			{
				byte[] bytes2 = Encoding.UTF8.GetBytes(accountName);
				accountNameLength = bytes2.Length;
				gCHandle2 = GCHandle.Alloc(bytes2, GCHandleType.Pinned);
				accountName2 = gCHandle2.AddrOfPinnedObject();
			}
			int passwordLength = 0;
			SecStatusCode num = SecKeychainFindGenericPassword(IntPtr.Zero, serviceNameLength, serviceName2, accountNameLength, accountName2, out passwordLength, out passwordData, IntPtr.Zero);
			if (num == SecStatusCode.Success && passwordLength > 0)
			{
				password = new byte[passwordLength];
				Marshal.Copy(passwordData, password, 0, passwordLength);
			}
			return num;
		}
		finally
		{
			if (gCHandle.IsAllocated)
			{
				gCHandle.Free();
			}
			if (gCHandle2.IsAllocated)
			{
				gCHandle2.Free();
			}
			if (passwordData != IntPtr.Zero)
			{
				SecKeychainItemFreeContent(IntPtr.Zero, passwordData);
			}
		}
	}
}

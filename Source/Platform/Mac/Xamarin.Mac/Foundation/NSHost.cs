using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using ObjCRuntime;

namespace Foundation;

[Register("NSHost", true)]
public class NSHost : NSObject, IEquatable<NSHost>, IEnumerable<IPAddress>, IEnumerable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddress = "address";

	private static readonly IntPtr selAddressHandle = Selector.GetHandle("address");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddresses = "addresses";

	private static readonly IntPtr selAddressesHandle = Selector.GetHandle("addresses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentHost = "currentHost";

	private static readonly IntPtr selCurrentHostHandle = Selector.GetHandle("currentHost");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHash = "hash";

	private static readonly IntPtr selHashHandle = Selector.GetHandle("hash");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHostWithAddress_ = "hostWithAddress:";

	private static readonly IntPtr selHostWithAddress_Handle = Selector.GetHandle("hostWithAddress:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHostWithName_ = "hostWithName:";

	private static readonly IntPtr selHostWithName_Handle = Selector.GetHandle("hostWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEqualToHost_ = "isEqualToHost:";

	private static readonly IntPtr selIsEqualToHost_Handle = Selector.GetHandle("isEqualToHost:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedName = "localizedName";

	private static readonly IntPtr selLocalizedNameHandle = Selector.GetHandle("localizedName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNames = "names";

	private static readonly IntPtr selNamesHandle = Selector.GetHandle("names");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSHost");

	public static NSHost Current => CheckNull(_Current);

	public IPAddress Address => IPAddress.Parse(_Address);

	public IPAddress[] Addresses
	{
		get
		{
			IPAddress[] array = new IPAddress[_Addresses.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = IPAddress.Parse(_Addresses[i]);
			}
			return array;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string LocalizedName
	{
		[Export("localizedName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] Names
	{
		[Export("names")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNamesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNamesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual string _Address
	{
		[Export("address")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAddressHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAddressHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual string[] _Addresses
	{
		[Export("addresses")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAddressesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAddressesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSHost _Current
	{
		[Export("currentHost")]
		get
		{
			return Runtime.GetNSObject<NSHost>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentHostHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual nuint _Hash
	{
		[Export("hash")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selHashHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selHashHandle);
		}
	}

	private static NSHost CheckNull(NSHost host)
	{
		if (host == null)
		{
			return null;
		}
		string[] addresses = host._Addresses;
		if (addresses == null || addresses.Length == 0)
		{
			return null;
		}
		return host;
	}

	public static NSHost FromAddress(string address)
	{
		if (address == null)
		{
			return null;
		}
		return CheckNull(_FromAddress(address));
	}

	public static NSHost FromName(string name)
	{
		if (name == null)
		{
			return null;
		}
		return CheckNull(_FromName(name));
	}

	public static explicit operator IPAddress(NSHost host)
	{
		return host.Address;
	}

	public static explicit operator NSHost(IPAddress address)
	{
		return FromAddress(address);
	}

	public static explicit operator IPHostEntry(NSHost host)
	{
		return host.ToIPHostEntry();
	}

	public static explicit operator NSHost(IPHostEntry hostEntry)
	{
		return FromIPHostEntry(hostEntry);
	}

	public static NSHost FromIPHostEntry(IPHostEntry hostEntry)
	{
		if (hostEntry == null)
		{
			return null;
		}
		if (hostEntry.AddressList != null)
		{
			IPAddress[] addressList = hostEntry.AddressList;
			foreach (IPAddress address in addressList)
			{
				NSHost nSHost = FromAddress(address);
				if (nSHost != null)
				{
					return nSHost;
				}
			}
		}
		if (hostEntry.HostName != null)
		{
			NSHost nSHost2 = FromName(hostEntry.HostName);
			if (nSHost2 != null)
			{
				return nSHost2;
			}
		}
		if (hostEntry.Aliases != null)
		{
			string[] aliases = hostEntry.Aliases;
			foreach (string name in aliases)
			{
				NSHost nSHost3 = FromName(name);
				if (nSHost3 != null)
				{
					return nSHost3;
				}
			}
		}
		return null;
	}

	public IPHostEntry ToIPHostEntry()
	{
		return new IPHostEntry
		{
			HostName = Name,
			AddressList = Addresses,
			Aliases = Names
		};
	}

	public static NSHost FromAddress(IPAddress address)
	{
		if (address == null)
		{
			return null;
		}
		return FromAddress(address.ToString());
	}

	public override int GetHashCode()
	{
		return (int)_Hash;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (obj is NSHost host)
		{
			return Equals(host);
		}
		return false;
	}

	public IEnumerator<IPAddress> GetEnumerator()
	{
		IPAddress[] addresses = Addresses;
		for (int i = 0; i < addresses.Length; i++)
		{
			yield return addresses[i];
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSHost(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSHost(IntPtr handle)
		: base(handle)
	{
	}

	[Export("isEqualToHost:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Equals(NSHost host)
	{
		if (host == null)
		{
			throw new ArgumentNullException("host");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToHost_Handle, host.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToHost_Handle, host.Handle);
	}

	[Export("hostWithAddress:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSHost _FromAddress(string address)
	{
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		IntPtr arg = NSString.CreateNative(address);
		NSHost nSObject = Runtime.GetNSObject<NSHost>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selHostWithAddress_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("hostWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSHost _FromName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSHost nSObject = Runtime.GetNSObject<NSHost>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selHostWithName_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}

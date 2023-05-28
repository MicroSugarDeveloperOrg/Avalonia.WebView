using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NEIPv6Settings", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NEIPv6Settings : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddresses = "addresses";

	private static readonly IntPtr selAddressesHandle = Selector.GetHandle("addresses");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExcludedRoutes = "excludedRoutes";

	private static readonly IntPtr selExcludedRoutesHandle = Selector.GetHandle("excludedRoutes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncludedRoutes = "includedRoutes";

	private static readonly IntPtr selIncludedRoutesHandle = Selector.GetHandle("includedRoutes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAddresses_NetworkPrefixLengths_ = "initWithAddresses:networkPrefixLengths:";

	private static readonly IntPtr selInitWithAddresses_NetworkPrefixLengths_Handle = Selector.GetHandle("initWithAddresses:networkPrefixLengths:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNetworkPrefixLengths = "networkPrefixLengths";

	private static readonly IntPtr selNetworkPrefixLengthsHandle = Selector.GetHandle("networkPrefixLengths");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExcludedRoutes_ = "setExcludedRoutes:";

	private static readonly IntPtr selSetExcludedRoutes_Handle = Selector.GetHandle("setExcludedRoutes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIncludedRoutes_ = "setIncludedRoutes:";

	private static readonly IntPtr selSetIncludedRoutes_Handle = Selector.GetHandle("setIncludedRoutes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NEIPv6Settings");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] Addresses
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
	public virtual NEIPv6Route[]? ExcludedRoutes
	{
		[Export("excludedRoutes", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NEIPv6Route>(Messaging.IntPtr_objc_msgSend(base.Handle, selExcludedRoutesHandle));
			}
			return NSArray.ArrayFromHandle<NEIPv6Route>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExcludedRoutesHandle));
		}
		[Export("setExcludedRoutes:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetExcludedRoutes_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetExcludedRoutes_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEIPv6Route[]? IncludedRoutes
	{
		[Export("includedRoutes", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NEIPv6Route>(Messaging.IntPtr_objc_msgSend(base.Handle, selIncludedRoutesHandle));
			}
			return NSArray.ArrayFromHandle<NEIPv6Route>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIncludedRoutesHandle));
		}
		[Export("setIncludedRoutes:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetIncludedRoutes_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetIncludedRoutes_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[] NetworkPrefixLengths
	{
		[Export("networkPrefixLengths")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selNetworkPrefixLengthsHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNetworkPrefixLengthsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NEIPv6Settings(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NEIPv6Settings(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NEIPv6Settings(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAddresses:networkPrefixLengths:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NEIPv6Settings(string[] addresses, NSNumber[] networkPrefixLengths)
		: base(NSObjectFlag.Empty)
	{
		if (addresses == null)
		{
			throw new ArgumentNullException("addresses");
		}
		if (networkPrefixLengths == null)
		{
			throw new ArgumentNullException("networkPrefixLengths");
		}
		NSArray nSArray = NSArray.FromStrings(addresses);
		NSArray nSArray2 = NSArray.FromNSObjects(networkPrefixLengths);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithAddresses_NetworkPrefixLengths_Handle, nSArray.Handle, nSArray2.Handle), "initWithAddresses:networkPrefixLengths:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithAddresses_NetworkPrefixLengths_Handle, nSArray.Handle, nSArray2.Handle), "initWithAddresses:networkPrefixLengths:");
		}
		nSArray.Dispose();
		nSArray2.Dispose();
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}
}

using System;
using ObjCRuntime;

namespace Foundation;

public static class NSUrlUtilities_NSCharacterSet
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLFragmentAllowedCharacterSet = "URLFragmentAllowedCharacterSet";

	private static readonly IntPtr selURLFragmentAllowedCharacterSetHandle = Selector.GetHandle("URLFragmentAllowedCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLHostAllowedCharacterSet = "URLHostAllowedCharacterSet";

	private static readonly IntPtr selURLHostAllowedCharacterSetHandle = Selector.GetHandle("URLHostAllowedCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLPasswordAllowedCharacterSet = "URLPasswordAllowedCharacterSet";

	private static readonly IntPtr selURLPasswordAllowedCharacterSetHandle = Selector.GetHandle("URLPasswordAllowedCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLPathAllowedCharacterSet = "URLPathAllowedCharacterSet";

	private static readonly IntPtr selURLPathAllowedCharacterSetHandle = Selector.GetHandle("URLPathAllowedCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLQueryAllowedCharacterSet = "URLQueryAllowedCharacterSet";

	private static readonly IntPtr selURLQueryAllowedCharacterSetHandle = Selector.GetHandle("URLQueryAllowedCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLUserAllowedCharacterSet = "URLUserAllowedCharacterSet";

	private static readonly IntPtr selURLUserAllowedCharacterSetHandle = Selector.GetHandle("URLUserAllowedCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSCharacterSet UrlFragmentAllowedCharacterSet
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("URLFragmentAllowedCharacterSet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selURLFragmentAllowedCharacterSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSCharacterSet UrlHostAllowedCharacterSet
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("URLHostAllowedCharacterSet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selURLHostAllowedCharacterSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSCharacterSet UrlPasswordAllowedCharacterSet
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("URLPasswordAllowedCharacterSet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selURLPasswordAllowedCharacterSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSCharacterSet UrlPathAllowedCharacterSet
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("URLPathAllowedCharacterSet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selURLPathAllowedCharacterSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSCharacterSet UrlQueryAllowedCharacterSet
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("URLQueryAllowedCharacterSet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selURLQueryAllowedCharacterSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSCharacterSet UrlUserAllowedCharacterSet
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Export("URLUserAllowedCharacterSet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selURLUserAllowedCharacterSetHandle));
		}
	}
}

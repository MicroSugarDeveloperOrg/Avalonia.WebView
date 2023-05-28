using System;
using ObjCRuntime;

namespace Foundation;

public static class NSUrlUtilities_NSString
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringByAddingPercentEncodingWithAllowedCharacters_ = "stringByAddingPercentEncodingWithAllowedCharacters:";

	private static readonly IntPtr selStringByAddingPercentEncodingWithAllowedCharacters_Handle = Selector.GetHandle("stringByAddingPercentEncodingWithAllowedCharacters:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringByAddingPercentEscapesUsingEncoding_ = "stringByAddingPercentEscapesUsingEncoding:";

	private static readonly IntPtr selStringByAddingPercentEscapesUsingEncoding_Handle = Selector.GetHandle("stringByAddingPercentEscapesUsingEncoding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringByRemovingPercentEncoding = "stringByRemovingPercentEncoding";

	private static readonly IntPtr selStringByRemovingPercentEncodingHandle = Selector.GetHandle("stringByRemovingPercentEncoding");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringByReplacingPercentEscapesUsingEncoding_ = "stringByReplacingPercentEscapesUsingEncoding:";

	private static readonly IntPtr selStringByReplacingPercentEscapesUsingEncoding_Handle = Selector.GetHandle("stringByReplacingPercentEscapesUsingEncoding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSString");

	[Export("stringByAddingPercentEncodingWithAllowedCharacters:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString CreateStringByAddingPercentEncoding(this NSString This, NSCharacterSet allowedCharacters)
	{
		if (allowedCharacters == null)
		{
			throw new ArgumentNullException("allowedCharacters");
		}
		return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, selStringByAddingPercentEncodingWithAllowedCharacters_Handle, allowedCharacters.Handle));
	}

	[Export("stringByAddingPercentEscapesUsingEncoding:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString CreateStringByAddingPercentEscapes(this NSString This, NSStringEncoding enc)
	{
		return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend_UInt64(This.Handle, selStringByAddingPercentEscapesUsingEncoding_Handle, (ulong)enc));
	}

	[Export("stringByRemovingPercentEncoding")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString CreateStringByRemovingPercentEncoding(this NSString This)
	{
		return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(This.Handle, selStringByRemovingPercentEncodingHandle));
	}

	[Export("stringByReplacingPercentEscapesUsingEncoding:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString CreateStringByReplacingPercentEscapes(this NSString This, NSStringEncoding enc)
	{
		return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend_UInt64(This.Handle, selStringByReplacingPercentEscapesUsingEncoding_Handle, (ulong)enc));
	}
}

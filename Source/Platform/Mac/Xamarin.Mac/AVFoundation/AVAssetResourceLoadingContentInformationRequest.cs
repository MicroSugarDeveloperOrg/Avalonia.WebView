using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetResourceLoadingContentInformationRequest", true)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVAssetResourceLoadingContentInformationRequest : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowedContentTypes = "allowedContentTypes";

	private static readonly IntPtr selAllowedContentTypesHandle = Selector.GetHandle("allowedContentTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentLength = "contentLength";

	private static readonly IntPtr selContentLengthHandle = Selector.GetHandle("contentLength");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentType = "contentType";

	private static readonly IntPtr selContentTypeHandle = Selector.GetHandle("contentType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsByteRangeAccessSupported = "isByteRangeAccessSupported";

	private static readonly IntPtr selIsByteRangeAccessSupportedHandle = Selector.GetHandle("isByteRangeAccessSupported");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenewalDate = "renewalDate";

	private static readonly IntPtr selRenewalDateHandle = Selector.GetHandle("renewalDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetByteRangeAccessSupported_ = "setByteRangeAccessSupported:";

	private static readonly IntPtr selSetByteRangeAccessSupported_Handle = Selector.GetHandle("setByteRangeAccessSupported:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentLength_ = "setContentLength:";

	private static readonly IntPtr selSetContentLength_Handle = Selector.GetHandle("setContentLength:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentType_ = "setContentType:";

	private static readonly IntPtr selSetContentType_Handle = Selector.GetHandle("setContentType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRenewalDate_ = "setRenewalDate:";

	private static readonly IntPtr selSetRenewalDate_Handle = Selector.GetHandle("setRenewalDate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAssetResourceLoadingContentInformationRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 2, PlatformArchitecture.All, null)]
	public virtual string[]? AllowedContentTypes
	{
		[Introduced(PlatformName.WatchOS, 4, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 2, PlatformArchitecture.All, null)]
		[Export("allowedContentTypes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAllowedContentTypesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllowedContentTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ByteRangeAccessSupported
	{
		[Export("isByteRangeAccessSupported")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsByteRangeAccessSupportedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsByteRangeAccessSupportedHandle);
		}
		[Export("setByteRangeAccessSupported:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetByteRangeAccessSupported_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetByteRangeAccessSupported_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long ContentLength
	{
		[Export("contentLength")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selContentLengthHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selContentLengthHandle);
		}
		[Export("setContentLength:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetContentLength_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetContentLength_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? ContentType
	{
		[Export("contentType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selContentTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentTypeHandle));
		}
		[Export("setContentType:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContentType_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContentType_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual NSDate? RenewalDate
	{
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("renewalDate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selRenewalDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRenewalDateHandle));
		}
		[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setRenewalDate:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRenewalDate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRenewalDate_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAssetResourceLoadingContentInformationRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAssetResourceLoadingContentInformationRequest(IntPtr handle)
		: base(handle)
	{
	}
}

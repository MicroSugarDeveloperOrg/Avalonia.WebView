using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace StoreKit;

[Register("SKDownload", true)]
[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
public class SKDownload : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentIdentifier = "contentIdentifier";

	private static readonly IntPtr selContentIdentifierHandle = Selector.GetHandle("contentIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentLength = "contentLength";

	private static readonly IntPtr selContentLengthHandle = Selector.GetHandle("contentLength");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentURL = "contentURL";

	private static readonly IntPtr selContentURLHandle = Selector.GetHandle("contentURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentURLForProductID_ = "contentURLForProductID:";

	private static readonly IntPtr selContentURLForProductID_Handle = Selector.GetHandle("contentURLForProductID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentVersion = "contentVersion";

	private static readonly IntPtr selContentVersionHandle = Selector.GetHandle("contentVersion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteContentForProductID_ = "deleteContentForProductID:";

	private static readonly IntPtr selDeleteContentForProductID_Handle = Selector.GetHandle("deleteContentForProductID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selError = "error";

	private static readonly IntPtr selErrorHandle = Selector.GetHandle("error");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpectedContentLength = "expectedContentLength";

	private static readonly IntPtr selExpectedContentLengthHandle = Selector.GetHandle("expectedContentLength");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProgress = "progress";

	private static readonly IntPtr selProgressHandle = Selector.GetHandle("progress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selState = "state";

	private static readonly IntPtr selStateHandle = Selector.GetHandle("state");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeRemaining = "timeRemaining";

	private static readonly IntPtr selTimeRemainingHandle = Selector.GetHandle("timeRemaining");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransaction = "transaction";

	private static readonly IntPtr selTransactionHandle = Selector.GetHandle("transaction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKDownload");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ContentIdentifier
	{
		[Export("contentIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selContentIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'ExpectedContentLength' instead.")]
	public virtual NSNumber ContentLength
	{
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'ExpectedContentLength' instead.")]
		[Export("contentLength", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selContentLengthHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentLengthHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? ContentUrl
	{
		[Export("contentURL", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selContentURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ContentVersion
	{
		[Export("contentVersion", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selContentVersionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentVersionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsolete("Use 'State' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual SKDownloadState DownloadState => State;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSError? Error
	{
		[Export("error", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend(base.Handle, selErrorHandle));
			}
			return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selErrorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	public virtual long ExpectedContentLength
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		[Export("expectedContentLength")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selExpectedContentLengthHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selExpectedContentLengthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Progress
	{
		[Export("progress")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selProgressHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selProgressHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual SKDownloadState State
	{
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("state")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SKDownloadState)Messaging.Int64_objc_msgSend(base.Handle, selStateHandle);
			}
			return (SKDownloadState)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double TimeRemaining
	{
		[Export("timeRemaining")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTimeRemainingHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimeRemainingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual SKPaymentTransaction Transaction
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("transaction")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKPaymentTransaction>(Messaging.IntPtr_objc_msgSend(base.Handle, selTransactionHandle));
			}
			return Runtime.GetNSObject<SKPaymentTransaction>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTransactionHandle));
		}
	}

	[Field("SKDownloadTimeRemainingUnknown", "StoreKit")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public static double TimeRemainingUnknown
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetDouble(Libraries.StoreKit.Handle, "SKDownloadTimeRemainingUnknown");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKDownload()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SKDownload(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKDownload(IntPtr handle)
		: base(handle)
	{
	}

	[Export("deleteContentForProductID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DeleteContentForProduct(string productId)
	{
		if (productId == null)
		{
			throw new ArgumentNullException("productId");
		}
		IntPtr arg = NSString.CreateNative(productId);
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selDeleteContentForProductID_Handle, arg);
		NSString.ReleaseNative(arg);
	}

	[Export("contentURLForProductID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl? GetContentUrlForProduct(string productId)
	{
		if (productId == null)
		{
			throw new ArgumentNullException("productId");
		}
		IntPtr arg = NSString.CreateNative(productId);
		NSUrl nSObject = Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selContentURLForProductID_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}

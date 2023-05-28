using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Accounts;
using Foundation;
using ObjCRuntime;

namespace Social;

[Register("SLRequest", true)]
public class SLRequest : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURL = "URL";

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccount = "account";

	private static readonly IntPtr selAccountHandle = Selector.GetHandle("account");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddMultipartData_WithName_Type_ = "addMultipartData:withName:type:";

	private static readonly IntPtr selAddMultipartData_WithName_Type_Handle = Selector.GetHandle("addMultipartData:withName:type:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddMultipartData_WithName_Type_Filename_ = "addMultipartData:withName:type:filename:";

	private static readonly IntPtr selAddMultipartData_WithName_Type_Filename_Handle = Selector.GetHandle("addMultipartData:withName:type:filename:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParameters = "parameters";

	private static readonly IntPtr selParametersHandle = Selector.GetHandle("parameters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformRequestWithHandler_ = "performRequestWithHandler:";

	private static readonly IntPtr selPerformRequestWithHandler_Handle = Selector.GetHandle("performRequestWithHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreparedURLRequest = "preparedURLRequest";

	private static readonly IntPtr selPreparedURLRequestHandle = Selector.GetHandle("preparedURLRequest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestForServiceType_RequestMethod_URL_Parameters_ = "requestForServiceType:requestMethod:URL:parameters:";

	private static readonly IntPtr selRequestForServiceType_RequestMethod_URL_Parameters_Handle = Selector.GetHandle("requestForServiceType:requestMethod:URL:parameters:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestMethod = "requestMethod";

	private static readonly IntPtr selRequestMethodHandle = Selector.GetHandle("requestMethod");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccount_ = "setAccount:";

	private static readonly IntPtr selSetAccount_Handle = Selector.GetHandle("setAccount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SLRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ACAccount? Account
	{
		[Export("account", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<ACAccount>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccountHandle));
			}
			return Runtime.GetNSObject<ACAccount>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccountHandle));
		}
		[Export("setAccount:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccount_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccount_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary Parameters
	{
		[Export("parameters")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selParametersHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParametersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SLRequestMethod RequestMethod
	{
		[Export("requestMethod")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SLRequestMethod)Messaging.Int64_objc_msgSend(base.Handle, selRequestMethodHandle);
			}
			return (SLRequestMethod)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selRequestMethodHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl Url
	{
		[Export("URL")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle));
		}
	}

	internal static NSString KindToType(SLServiceKind kind)
	{
		return kind switch
		{
			SLServiceKind.Facebook => SLServiceType.Facebook, 
			SLServiceKind.Twitter => SLServiceType.Twitter, 
			SLServiceKind.SinaWeibo => SLServiceType.SinaWeibo, 
			SLServiceKind.TencentWeibo => SLServiceType.TencentWeibo, 
			SLServiceKind.LinkedIn => SLServiceType.LinkedIn, 
			_ => null, 
		};
	}

	public static SLRequest Create(SLServiceKind serviceKind, SLRequestMethod method, NSUrl url, NSDictionary parameters)
	{
		return Create(KindToType(serviceKind), method, url, parameters);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SLRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SLRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addMultipartData:withName:type:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddMultipartData(NSData data, string partName, string partType)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (partName == null)
		{
			throw new ArgumentNullException("partName");
		}
		if (partType == null)
		{
			throw new ArgumentNullException("partType");
		}
		IntPtr arg = NSString.CreateNative(partName);
		IntPtr arg2 = NSString.CreateNative(partType);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selAddMultipartData_WithName_Type_Handle, data.Handle, arg, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selAddMultipartData_WithName_Type_Handle, data.Handle, arg, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("addMultipartData:withName:type:filename:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddMultipartData(NSData data, string partName, string partType, string filename)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (partName == null)
		{
			throw new ArgumentNullException("partName");
		}
		if (partType == null)
		{
			throw new ArgumentNullException("partType");
		}
		if (filename == null)
		{
			throw new ArgumentNullException("filename");
		}
		IntPtr arg = NSString.CreateNative(partName);
		IntPtr arg2 = NSString.CreateNative(partType);
		IntPtr arg3 = NSString.CreateNative(filename);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selAddMultipartData_WithName_Type_Filename_Handle, data.Handle, arg, arg2, arg3);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selAddMultipartData_WithName_Type_Filename_Handle, data.Handle, arg, arg2, arg3);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
	}

	[Export("requestForServiceType:requestMethod:URL:parameters:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SLRequest Create(NSString serviceType, SLRequestMethod requestMethod, NSUrl url, NSDictionary? parameters)
	{
		if (serviceType == null)
		{
			throw new ArgumentNullException("serviceType");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Runtime.GetNSObject<SLRequest>(Messaging.IntPtr_objc_msgSend_IntPtr_Int64_IntPtr_IntPtr(class_ptr, selRequestForServiceType_RequestMethod_URL_Parameters_Handle, serviceType.Handle, (long)requestMethod, url.Handle, parameters?.Handle ?? IntPtr.Zero));
	}

	[Export("preparedURLRequest")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlRequest GetPreparedUrlRequest()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSUrlRequest>(Messaging.IntPtr_objc_msgSend(base.Handle, selPreparedURLRequestHandle));
		}
		return Runtime.GetNSObject<NSUrlRequest>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreparedURLRequestHandle));
	}

	[Export("performRequestWithHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void PerformRequest([BlockProxy(typeof(Trampolines.NIDActionArity3V6))] Action<NSData, NSHttpUrlResponse, NSError> handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity3V6.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformRequestWithHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformRequestWithHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<SLRequestResult> PerformRequestAsync()
	{
		TaskCompletionSource<SLRequestResult> tcs = new TaskCompletionSource<SLRequestResult>();
		PerformRequest(delegate(NSData arg1_, NSHttpUrlResponse arg2_, NSError arg3_)
		{
			if (arg3_ != null)
			{
				tcs.SetException(new NSErrorException(arg3_));
			}
			else
			{
				tcs.SetResult(new SLRequestResult(arg1_, arg2_));
			}
		});
		return tcs.Task;
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CloudKit;

[Register("CKOperation", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class CKOperation : NSOperation
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsCellularAccess = "allowsCellularAccess";

	private static readonly IntPtr selAllowsCellularAccessHandle = Selector.GetHandle("allowsCellularAccess");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfiguration = "configuration";

	private static readonly IntPtr selConfigurationHandle = Selector.GetHandle("configuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainer = "container";

	private static readonly IntPtr selContainerHandle = Selector.GetHandle("container");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroup = "group";

	private static readonly IntPtr selGroupHandle = Selector.GetHandle("group");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsLongLived = "isLongLived";

	private static readonly IntPtr selIsLongLivedHandle = Selector.GetHandle("isLongLived");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLongLivedOperationWasPersistedBlock = "longLivedOperationWasPersistedBlock";

	private static readonly IntPtr selLongLivedOperationWasPersistedBlockHandle = Selector.GetHandle("longLivedOperationWasPersistedBlock");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOperationID = "operationID";

	private static readonly IntPtr selOperationIDHandle = Selector.GetHandle("operationID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsCellularAccess_ = "setAllowsCellularAccess:";

	private static readonly IntPtr selSetAllowsCellularAccess_Handle = Selector.GetHandle("setAllowsCellularAccess:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetConfiguration_ = "setConfiguration:";

	private static readonly IntPtr selSetConfiguration_Handle = Selector.GetHandle("setConfiguration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContainer_ = "setContainer:";

	private static readonly IntPtr selSetContainer_Handle = Selector.GetHandle("setContainer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGroup_ = "setGroup:";

	private static readonly IntPtr selSetGroup_Handle = Selector.GetHandle("setGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLongLived_ = "setLongLived:";

	private static readonly IntPtr selSetLongLived_Handle = Selector.GetHandle("setLongLived:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLongLivedOperationWasPersistedBlock_ = "setLongLivedOperationWasPersistedBlock:";

	private static readonly IntPtr selSetLongLivedOperationWasPersistedBlock_Handle = Selector.GetHandle("setLongLivedOperationWasPersistedBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeoutIntervalForRequest_ = "setTimeoutIntervalForRequest:";

	private static readonly IntPtr selSetTimeoutIntervalForRequest_Handle = Selector.GetHandle("setTimeoutIntervalForRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeoutIntervalForResource_ = "setTimeoutIntervalForResource:";

	private static readonly IntPtr selSetTimeoutIntervalForResource_Handle = Selector.GetHandle("setTimeoutIntervalForResource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeoutIntervalForRequest = "timeoutIntervalForRequest";

	private static readonly IntPtr selTimeoutIntervalForRequestHandle = Selector.GetHandle("timeoutIntervalForRequest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeoutIntervalForResource = "timeoutIntervalForResource";

	private static readonly IntPtr selTimeoutIntervalForResourceHandle = Selector.GetHandle("timeoutIntervalForResource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CKOperation");

	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Empty stub (rejected by Apple). Use 'QualityOfService' property.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Empty stub (rejected by Apple). Use 'QualityOfService' property.")]
	public virtual bool UsesBackgroundSession { get; set; }

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
	public virtual bool AllowsCellularAccess
	{
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Export("allowsCellularAccess")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsCellularAccessHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsCellularAccessHandle);
		}
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Export("setAllowsCellularAccess:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsCellularAccess_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsCellularAccess_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual CKOperationConfiguration? Configuration
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("configuration", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CKOperationConfiguration>(Messaging.IntPtr_objc_msgSend(base.Handle, selConfigurationHandle));
			}
			return Runtime.GetNSObject<CKOperationConfiguration>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConfigurationHandle));
		}
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setConfiguration:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetConfiguration_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetConfiguration_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
	public virtual CKContainer? Container
	{
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Export("container", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CKContainer>(Messaging.IntPtr_objc_msgSend(base.Handle, selContainerHandle));
			}
			return Runtime.GetNSObject<CKContainer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContainerHandle));
		}
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Export("setContainer:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContainer_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContainer_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual CKOperationGroup? Group
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("group", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CKOperationGroup>(Messaging.IntPtr_objc_msgSend(base.Handle, selGroupHandle));
			}
			return Runtime.GetNSObject<CKOperationGroup>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGroupHandle));
		}
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setGroup:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetGroup_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetGroup_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
	public virtual bool LongLived
	{
		[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Export("isLongLived")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsLongLivedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsLongLivedHandle);
		}
		[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Export("setLongLived:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetLongLived_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetLongLived_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
	public unsafe virtual Action? LongLivedOperationWasPersistedCallback
	{
		[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
		[Export("longLivedOperationWasPersistedBlock", ArgumentSemantic.Retain)]
		[return: DelegateProxy(typeof(Trampolines.SDAction))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLongLivedOperationWasPersistedBlockHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selLongLivedOperationWasPersistedBlockHandle));
			return Trampolines.NIDAction.Create(block);
		}
		[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
		[Export("setLongLivedOperationWasPersistedBlock:", ArgumentSemantic.Retain)]
		[param: BlockProxy(typeof(Trampolines.NIDAction))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLongLivedOperationWasPersistedBlock_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLongLivedOperationWasPersistedBlock_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, 4, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
	public virtual string OperationID
	{
		[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, 4, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
		[Export("operationID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selOperationIDHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOperationIDHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
	public virtual double TimeoutIntervalForRequest
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Export("timeoutIntervalForRequest")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTimeoutIntervalForRequestHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimeoutIntervalForRequestHandle);
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Export("setTimeoutIntervalForRequest:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetTimeoutIntervalForRequest_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetTimeoutIntervalForRequest_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
	public virtual double TimeoutIntervalForResource
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Export("timeoutIntervalForResource")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTimeoutIntervalForResourceHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimeoutIntervalForResourceHandle);
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'CKOperationConfiguration' instead.")]
		[Export("setTimeoutIntervalForResource:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetTimeoutIntervalForResource_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetTimeoutIntervalForResource_Handle, value);
			}
		}
	}

	[Obsoleted(PlatformName.iOS, 9, 3, PlatformArchitecture.None, "Do not use; this API was removed and will always return 0.")]
	public virtual ulong ActivityStart()
	{
		return 0uL;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CKOperation(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CKOperation(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected CKOperation()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInitHandle), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitHandle), "init");
		}
	}
}

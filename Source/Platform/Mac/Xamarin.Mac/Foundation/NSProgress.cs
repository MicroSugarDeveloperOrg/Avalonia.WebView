using System.ComponentModel;
using System.Threading.Tasks;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSProgress", true)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class NSProgress : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcknowledgeWithSuccess_ = "acknowledgeWithSuccess:";

	private static readonly IntPtr selAcknowledgeWithSuccess_Handle = Selector.GetHandle("acknowledgeWithSuccess:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddChild_WithPendingUnitCount_ = "addChild:withPendingUnitCount:";

	private static readonly IntPtr selAddChild_WithPendingUnitCount_Handle = Selector.GetHandle("addChild:withPendingUnitCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddSubscriberForFileURL_WithPublishingHandler_ = "addSubscriberForFileURL:withPublishingHandler:";

	private static readonly IntPtr selAddSubscriberForFileURL_WithPublishingHandler_Handle = Selector.GetHandle("addSubscriberForFileURL:withPublishingHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBecomeCurrentWithPendingUnitCount_ = "becomeCurrentWithPendingUnitCount:";

	private static readonly IntPtr selBecomeCurrentWithPendingUnitCount_Handle = Selector.GetHandle("becomeCurrentWithPendingUnitCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancel = "cancel";

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompletedUnitCount = "completedUnitCount";

	private static readonly IntPtr selCompletedUnitCountHandle = Selector.GetHandle("completedUnitCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentProgress = "currentProgress";

	private static readonly IntPtr selCurrentProgressHandle = Selector.GetHandle("currentProgress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscreteProgressWithTotalUnitCount_ = "discreteProgressWithTotalUnitCount:";

	private static readonly IntPtr selDiscreteProgressWithTotalUnitCount_Handle = Selector.GetHandle("discreteProgressWithTotalUnitCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEstimatedTimeRemaining = "estimatedTimeRemaining";

	private static readonly IntPtr selEstimatedTimeRemainingHandle = Selector.GetHandle("estimatedTimeRemaining");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileCompletedCount = "fileCompletedCount";

	private static readonly IntPtr selFileCompletedCountHandle = Selector.GetHandle("fileCompletedCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileOperationKind = "fileOperationKind";

	private static readonly IntPtr selFileOperationKindHandle = Selector.GetHandle("fileOperationKind");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileTotalCount = "fileTotalCount";

	private static readonly IntPtr selFileTotalCountHandle = Selector.GetHandle("fileTotalCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileURL = "fileURL";

	private static readonly IntPtr selFileURLHandle = Selector.GetHandle("fileURL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFractionCompleted = "fractionCompleted";

	private static readonly IntPtr selFractionCompletedHandle = Selector.GetHandle("fractionCompleted");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithParent_UserInfo_ = "initWithParent:userInfo:";

	private static readonly IntPtr selInitWithParent_UserInfo_Handle = Selector.GetHandle("initWithParent:userInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCancellable = "isCancellable";

	private static readonly IntPtr selIsCancellableHandle = Selector.GetHandle("isCancellable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCancelled = "isCancelled";

	private static readonly IntPtr selIsCancelledHandle = Selector.GetHandle("isCancelled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFinished = "isFinished";

	private static readonly IntPtr selIsFinishedHandle = Selector.GetHandle("isFinished");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsIndeterminate = "isIndeterminate";

	private static readonly IntPtr selIsIndeterminateHandle = Selector.GetHandle("isIndeterminate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsOld = "isOld";

	private static readonly IntPtr selIsOldHandle = Selector.GetHandle("isOld");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPausable = "isPausable";

	private static readonly IntPtr selIsPausableHandle = Selector.GetHandle("isPausable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPaused = "isPaused";

	private static readonly IntPtr selIsPausedHandle = Selector.GetHandle("isPaused");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKind = "kind";

	private static readonly IntPtr selKindHandle = Selector.GetHandle("kind");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedAdditionalDescription = "localizedAdditionalDescription";

	private static readonly IntPtr selLocalizedAdditionalDescriptionHandle = Selector.GetHandle("localizedAdditionalDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedDescription = "localizedDescription";

	private static readonly IntPtr selLocalizedDescriptionHandle = Selector.GetHandle("localizedDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPause = "pause";

	private static readonly IntPtr selPauseHandle = Selector.GetHandle("pause");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformAsCurrentWithPendingUnitCount_UsingBlock_ = "performAsCurrentWithPendingUnitCount:usingBlock:";

	private static readonly IntPtr selPerformAsCurrentWithPendingUnitCount_UsingBlock_Handle = Selector.GetHandle("performAsCurrentWithPendingUnitCount:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProgressWithTotalUnitCount_ = "progressWithTotalUnitCount:";

	private static readonly IntPtr selProgressWithTotalUnitCount_Handle = Selector.GetHandle("progressWithTotalUnitCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProgressWithTotalUnitCount_Parent_PendingUnitCount_ = "progressWithTotalUnitCount:parent:pendingUnitCount:";

	private static readonly IntPtr selProgressWithTotalUnitCount_Parent_PendingUnitCount_Handle = Selector.GetHandle("progressWithTotalUnitCount:parent:pendingUnitCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPublish = "publish";

	private static readonly IntPtr selPublishHandle = Selector.GetHandle("publish");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveSubscriber_ = "removeSubscriber:";

	private static readonly IntPtr selRemoveSubscriber_Handle = Selector.GetHandle("removeSubscriber:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResignCurrent = "resignCurrent";

	private static readonly IntPtr selResignCurrentHandle = Selector.GetHandle("resignCurrent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResume = "resume";

	private static readonly IntPtr selResumeHandle = Selector.GetHandle("resume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAcknowledgementHandler_ForAppBundleIdentifier_ = "setAcknowledgementHandler:forAppBundleIdentifier:";

	private static readonly IntPtr selSetAcknowledgementHandler_ForAppBundleIdentifier_Handle = Selector.GetHandle("setAcknowledgementHandler:forAppBundleIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCancellable_ = "setCancellable:";

	private static readonly IntPtr selSetCancellable_Handle = Selector.GetHandle("setCancellable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCancellationHandler_ = "setCancellationHandler:";

	private static readonly IntPtr selSetCancellationHandler_Handle = Selector.GetHandle("setCancellationHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCompletedUnitCount_ = "setCompletedUnitCount:";

	private static readonly IntPtr selSetCompletedUnitCount_Handle = Selector.GetHandle("setCompletedUnitCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEstimatedTimeRemaining_ = "setEstimatedTimeRemaining:";

	private static readonly IntPtr selSetEstimatedTimeRemaining_Handle = Selector.GetHandle("setEstimatedTimeRemaining:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFileCompletedCount_ = "setFileCompletedCount:";

	private static readonly IntPtr selSetFileCompletedCount_Handle = Selector.GetHandle("setFileCompletedCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFileOperationKind_ = "setFileOperationKind:";

	private static readonly IntPtr selSetFileOperationKind_Handle = Selector.GetHandle("setFileOperationKind:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFileTotalCount_ = "setFileTotalCount:";

	private static readonly IntPtr selSetFileTotalCount_Handle = Selector.GetHandle("setFileTotalCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFileURL_ = "setFileURL:";

	private static readonly IntPtr selSetFileURL_Handle = Selector.GetHandle("setFileURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKind_ = "setKind:";

	private static readonly IntPtr selSetKind_Handle = Selector.GetHandle("setKind:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocalizedAdditionalDescription_ = "setLocalizedAdditionalDescription:";

	private static readonly IntPtr selSetLocalizedAdditionalDescription_Handle = Selector.GetHandle("setLocalizedAdditionalDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocalizedDescription_ = "setLocalizedDescription:";

	private static readonly IntPtr selSetLocalizedDescription_Handle = Selector.GetHandle("setLocalizedDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPausable_ = "setPausable:";

	private static readonly IntPtr selSetPausable_Handle = Selector.GetHandle("setPausable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPausingHandler_ = "setPausingHandler:";

	private static readonly IntPtr selSetPausingHandler_Handle = Selector.GetHandle("setPausingHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResumingHandler_ = "setResumingHandler:";

	private static readonly IntPtr selSetResumingHandler_Handle = Selector.GetHandle("setResumingHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetThroughput_ = "setThroughput:";

	private static readonly IntPtr selSetThroughput_Handle = Selector.GetHandle("setThroughput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTotalUnitCount_ = "setTotalUnitCount:";

	private static readonly IntPtr selSetTotalUnitCount_Handle = Selector.GetHandle("setTotalUnitCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUserInfoObject_ForKey_ = "setUserInfoObject:forKey:";

	private static readonly IntPtr selSetUserInfoObject_ForKey_Handle = Selector.GetHandle("setUserInfoObject:forKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selThroughput = "throughput";

	private static readonly IntPtr selThroughputHandle = Selector.GetHandle("throughput");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTotalUnitCount = "totalUnitCount";

	private static readonly IntPtr selTotalUnitCountHandle = Selector.GetHandle("totalUnitCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnpublish = "unpublish";

	private static readonly IntPtr selUnpublishHandle = Selector.GetHandle("unpublish");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserInfo = "userInfo";

	private static readonly IntPtr selUserInfoHandle = Selector.GetHandle("userInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSProgress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _EstimatedTimeRemainingKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileAnimationImageKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileAnimationImageOriginalRectKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileCompletedCountKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileIconKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileOperationKindCopying;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileOperationKindDecompressingAfterDownloading;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileOperationKindDownloading;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileOperationKindKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileOperationKindReceiving;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileTotalCountKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _FileURLKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KindFile;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ThroughputKey;

	public nint? EstimatedTimeRemaining
	{
		get
		{
			return _EstimatedTimeRemaining?.NIntValue;
		}
		set
		{
			_EstimatedTimeRemaining = (value.HasValue ? new NSNumber(value.Value) : null);
		}
	}

	public nint? Throughput
	{
		get
		{
			return _Throughput?.NIntValue;
		}
		set
		{
			_Throughput = (value.HasValue ? new NSNumber(value.Value) : null);
		}
	}

	public nint? FileTotalCount
	{
		get
		{
			return _FileTotalCount?.NIntValue;
		}
		set
		{
			_FileTotalCount = (value.HasValue ? new NSNumber(value.Value) : null);
		}
	}

	public nint? FileCompletedCount
	{
		get
		{
			return _FileCompletedCount?.NIntValue;
		}
		set
		{
			_FileCompletedCount = (value.HasValue ? new NSNumber(value.Value) : null);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Cancellable
	{
		[Export("isCancellable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCancellableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCancellableHandle);
		}
		[Export("setCancellable:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCancellable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCancellable_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Cancelled
	{
		[Export("isCancelled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsCancelledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsCancelledHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long CompletedUnitCount
	{
		[Export("completedUnitCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selCompletedUnitCountHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selCompletedUnitCountHandle);
		}
		[Export("setCompletedUnitCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetCompletedUnitCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetCompletedUnitCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSProgress CurrentProgress
	{
		[Export("currentProgress")]
		get
		{
			return Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSend(class_ptr, selCurrentProgressHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual string? FileOperationKind
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("fileOperationKind")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFileOperationKindHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileOperationKindHandle));
		}
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setFileOperationKind:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFileOperationKind_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFileOperationKind_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual NSUrl? FileUrl
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("fileURL", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selFileURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileURLHandle));
		}
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setFileURL:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFileURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFileURL_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Finished
	{
		[Export("isFinished")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFinishedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFinishedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double FractionCompleted
	{
		[Export("fractionCompleted")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selFractionCompletedHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selFractionCompletedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Indeterminate
	{
		[Export("isIndeterminate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsIndeterminateHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsIndeterminateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString? Kind
	{
		[Export("kind", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selKindHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKindHandle));
		}
		[Export("setKind:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetKind_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetKind_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? LocalizedAdditionalDescription
	{
		[Export("localizedAdditionalDescription", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedAdditionalDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedAdditionalDescriptionHandle));
		}
		[Export("setLocalizedAdditionalDescription:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLocalizedAdditionalDescription_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLocalizedAdditionalDescription_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? LocalizedDescription
	{
		[Export("localizedDescription", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedDescriptionHandle));
		}
		[Export("setLocalizedDescription:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLocalizedDescription_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLocalizedDescription_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Old
	{
		[Export("isOld")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOldHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOldHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Pausable
	{
		[Export("isPausable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPausableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPausableHandle);
		}
		[Export("setPausable:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPausable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPausable_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Paused
	{
		[Export("isPaused")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPausedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPausedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual long TotalUnitCount
	{
		[Export("totalUnitCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selTotalUnitCountHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTotalUnitCountHandle);
		}
		[Export("setTotalUnitCount:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetTotalUnitCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetTotalUnitCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary UserInfo
	{
		[Export("userInfo")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selUserInfoHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserInfoHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	internal virtual NSNumber? _EstimatedTimeRemaining
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("estimatedTimeRemaining", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selEstimatedTimeRemainingHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEstimatedTimeRemainingHandle));
		}
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setEstimatedTimeRemaining:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEstimatedTimeRemaining_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEstimatedTimeRemaining_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	internal virtual NSNumber? _FileCompletedCount
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("fileCompletedCount", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selFileCompletedCountHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileCompletedCountHandle));
		}
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setFileCompletedCount:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFileCompletedCount_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFileCompletedCount_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	internal virtual NSNumber? _FileTotalCount
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("fileTotalCount", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selFileTotalCountHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFileTotalCountHandle));
		}
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setFileTotalCount:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFileTotalCount_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFileTotalCount_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	internal virtual NSNumber? _Throughput
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("throughput", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selThroughputHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selThroughputHandle));
		}
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setThroughput:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetThroughput_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetThroughput_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[Field("NSProgressEstimatedTimeRemainingKey", "Foundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString EstimatedTimeRemainingKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_EstimatedTimeRemainingKey == null)
			{
				_EstimatedTimeRemainingKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSProgressEstimatedTimeRemainingKey");
			}
			return _EstimatedTimeRemainingKey;
		}
	}

	[Field("NSProgressFileAnimationImageKey", "Foundation")]
	public static NSString FileAnimationImageKey
	{
		get
		{
			if (_FileAnimationImageKey == null)
			{
				_FileAnimationImageKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSProgressFileAnimationImageKey");
			}
			return _FileAnimationImageKey;
		}
	}

	[Field("NSProgressFileAnimationImageOriginalRectKey", "Foundation")]
	public static NSString FileAnimationImageOriginalRectKey
	{
		get
		{
			if (_FileAnimationImageOriginalRectKey == null)
			{
				_FileAnimationImageOriginalRectKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSProgressFileAnimationImageOriginalRectKey");
			}
			return _FileAnimationImageOriginalRectKey;
		}
	}

	[Field("NSProgressFileCompletedCountKey", "Foundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString FileCompletedCountKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_FileCompletedCountKey == null)
			{
				_FileCompletedCountKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSProgressFileCompletedCountKey");
			}
			return _FileCompletedCountKey;
		}
	}

	[Field("NSProgressFileIconKey", "Foundation")]
	public static NSString FileIconKey
	{
		get
		{
			if (_FileIconKey == null)
			{
				_FileIconKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSProgressFileIconKey");
			}
			return _FileIconKey;
		}
	}

	[Field("NSProgressFileOperationKindCopying", "Foundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString FileOperationKindCopying
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_FileOperationKindCopying == null)
			{
				_FileOperationKindCopying = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSProgressFileOperationKindCopying");
			}
			return _FileOperationKindCopying;
		}
	}

	[Field("NSProgressFileOperationKindDecompressingAfterDownloading", "Foundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString FileOperationKindDecompressingAfterDownloading
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_FileOperationKindDecompressingAfterDownloading == null)
			{
				_FileOperationKindDecompressingAfterDownloading = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSProgressFileOperationKindDecompressingAfterDownloading");
			}
			return _FileOperationKindDecompressingAfterDownloading;
		}
	}

	[Field("NSProgressFileOperationKindDownloading", "Foundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString FileOperationKindDownloading
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_FileOperationKindDownloading == null)
			{
				_FileOperationKindDownloading = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSProgressFileOperationKindDownloading");
			}
			return _FileOperationKindDownloading;
		}
	}

	[Field("NSProgressFileOperationKindKey", "Foundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString FileOperationKindKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_FileOperationKindKey == null)
			{
				_FileOperationKindKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSProgressFileOperationKindKey");
			}
			return _FileOperationKindKey;
		}
	}

	[Field("NSProgressFileOperationKindReceiving", "Foundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString FileOperationKindReceiving
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_FileOperationKindReceiving == null)
			{
				_FileOperationKindReceiving = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSProgressFileOperationKindReceiving");
			}
			return _FileOperationKindReceiving;
		}
	}

	[Field("NSProgressFileTotalCountKey", "Foundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString FileTotalCountKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_FileTotalCountKey == null)
			{
				_FileTotalCountKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSProgressFileTotalCountKey");
			}
			return _FileTotalCountKey;
		}
	}

	[Field("NSProgressFileURLKey", "Foundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString FileURLKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_FileURLKey == null)
			{
				_FileURLKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSProgressFileURLKey");
			}
			return _FileURLKey;
		}
	}

	[Field("NSProgressKindFile", "Foundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString KindFile
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_KindFile == null)
			{
				_KindFile = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSProgressKindFile");
			}
			return _KindFile;
		}
	}

	[Field("NSProgressThroughputKey", "Foundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString ThroughputKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_ThroughputKey == null)
			{
				_ThroughputKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSProgressThroughputKey");
			}
			return _ThroughputKey;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSProgress()
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
	protected NSProgress(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSProgress(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithParent:userInfo:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSProgress(NSProgress? parentProgress, NSDictionary? userInfo)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithParent_UserInfo_Handle, parentProgress?.Handle ?? IntPtr.Zero, userInfo?.Handle ?? IntPtr.Zero), "initWithParent:userInfo:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithParent_UserInfo_Handle, parentProgress?.Handle ?? IntPtr.Zero, userInfo?.Handle ?? IntPtr.Zero), "initWithParent:userInfo:");
		}
	}

	[Export("acknowledgeWithSuccess:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AcknowledgeWithSuccess(bool success)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selAcknowledgeWithSuccess_Handle, success);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selAcknowledgeWithSuccess_Handle, success);
		}
	}

	[Export("addChild:withPendingUnitCount:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddChild(NSProgress child, long pendingUnitCount)
	{
		if (child == null)
		{
			throw new ArgumentNullException("child");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selAddChild_WithPendingUnitCount_Handle, child.Handle, pendingUnitCount);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selAddChild_WithPendingUnitCount_Handle, child.Handle, pendingUnitCount);
		}
	}

	[Export("addSubscriberForFileURL:withPublishingHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static NSObject AddSubscriberForFile(NSUrl url, [BlockProxy(typeof(Trampolines.NIDActionArity1V33))] Action<NSProgress> publishingHandler)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (publishingHandler == null)
		{
			throw new ArgumentNullException("publishingHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V33.Handler, publishingHandler);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selAddSubscriberForFileURL_WithPublishingHandler_Handle, url.Handle, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
	}

	[Export("becomeCurrentWithPendingUnitCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BecomeCurrent(long pendingUnitCount)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selBecomeCurrentWithPendingUnitCount_Handle, pendingUnitCount);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selBecomeCurrentWithPendingUnitCount_Handle, pendingUnitCount);
		}
	}

	[Export("cancel")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Cancel()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelHandle);
		}
	}

	[Export("progressWithTotalUnitCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSProgress FromTotalUnitCount(long unitCount)
	{
		return Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSend_Int64(class_ptr, selProgressWithTotalUnitCount_Handle, unitCount));
	}

	[Export("progressWithTotalUnitCount:parent:pendingUnitCount:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSProgress FromTotalUnitCount(long unitCount, NSProgress parent, long portionOfParentTotalUnitCount)
	{
		if (parent == null)
		{
			throw new ArgumentNullException("parent");
		}
		return Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSend_Int64_IntPtr_Int64(class_ptr, selProgressWithTotalUnitCount_Parent_PendingUnitCount_Handle, unitCount, parent.Handle, portionOfParentTotalUnitCount));
	}

	[Export("discreteProgressWithTotalUnitCount:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSProgress GetDiscreteProgress(long unitCount)
	{
		return Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSend_Int64(class_ptr, selDiscreteProgressWithTotalUnitCount_Handle, unitCount));
	}

	[Export("pause")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Pause()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPauseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPauseHandle);
		}
	}

	[Export("performAsCurrentWithPendingUnitCount:usingBlock:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void PerformAsCurrent(long unitCount, [BlockProxy(typeof(Trampolines.NIDAction))] Action work)
	{
		if (work == null)
		{
			throw new ArgumentNullException("work");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, work);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_IntPtr(base.Handle, selPerformAsCurrentWithPendingUnitCount_UsingBlock_Handle, unitCount, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr(base.SuperHandle, selPerformAsCurrentWithPendingUnitCount_UsingBlock_Handle, unitCount, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task PerformAsCurrentAsync(long unitCount)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		PerformAsCurrent(unitCount, delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Export("publish")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Publish()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPublishHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPublishHandle);
		}
	}

	[Export("removeSubscriber:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RemoveSubscriber(NSObject subscriber)
	{
		if (subscriber == null)
		{
			throw new ArgumentNullException("subscriber");
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selRemoveSubscriber_Handle, subscriber.Handle);
	}

	[Export("resignCurrent")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ResignCurrent()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResignCurrentHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResignCurrentHandle);
		}
	}

	[Export("resume")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Resume()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResumeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResumeHandle);
		}
	}

	[Export("setAcknowledgementHandler:forAppBundleIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SetAcknowledgementHandler([BlockProxy(typeof(Trampolines.NIDActionArity1V0))] Action<bool> acknowledgementHandler, string appBundleIdentifier)
	{
		if (acknowledgementHandler == null)
		{
			throw new ArgumentNullException("acknowledgementHandler");
		}
		if (appBundleIdentifier == null)
		{
			throw new ArgumentNullException("appBundleIdentifier");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V0.Handler, acknowledgementHandler);
		IntPtr arg = NSString.CreateNative(appBundleIdentifier);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetAcknowledgementHandler_ForAppBundleIdentifier_Handle, (IntPtr)ptr, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetAcknowledgementHandler_ForAppBundleIdentifier_Handle, (IntPtr)ptr, arg);
		}
		ptr->CleanupBlock();
		NSString.ReleaseNative(arg);
	}

	[Export("setCancellationHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SetCancellationHandler([BlockProxy(typeof(Trampolines.NIDAction))] Action handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCancellationHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCancellationHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("setPausingHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SetPauseHandler([BlockProxy(typeof(Trampolines.NIDAction))] Action handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPausingHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPausingHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("setResumingHandler:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SetResumingHandler([BlockProxy(typeof(Trampolines.NIDAction))] Action handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetResumingHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetResumingHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("setUserInfoObject:forKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetUserInfo(NSObject? obj, NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetUserInfoObject_ForKey_Handle, obj?.Handle ?? IntPtr.Zero, key.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetUserInfoObject_ForKey_Handle, obj?.Handle ?? IntPtr.Zero, key.Handle);
		}
	}

	[Export("unpublish")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Unpublish()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUnpublishHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUnpublishHandle);
		}
	}
}

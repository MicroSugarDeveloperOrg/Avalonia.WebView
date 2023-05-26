using System;
using System.ComponentModel;
using System.Threading.Tasks;
using CoreFoundation;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVPlayer", true)]
public class AVPlayer : NSObject
{
	private static readonly IntPtr selCurrentItemHandle = Selector.GetHandle("currentItem");

	private static readonly IntPtr selRateHandle = Selector.GetHandle("rate");

	private static readonly IntPtr selSetRate_Handle = Selector.GetHandle("setRate:");

	private static readonly IntPtr selCurrentTimeHandle = Selector.GetHandle("currentTime");

	private static readonly IntPtr selActionAtItemEndHandle = Selector.GetHandle("actionAtItemEnd");

	private static readonly IntPtr selSetActionAtItemEnd_Handle = Selector.GetHandle("setActionAtItemEnd:");

	private static readonly IntPtr selIsClosedCaptionDisplayEnabledHandle = Selector.GetHandle("isClosedCaptionDisplayEnabled");

	private static readonly IntPtr selSetClosedCaptionDisplayEnabled_Handle = Selector.GetHandle("setClosedCaptionDisplayEnabled:");

	private static readonly IntPtr selErrorHandle = Selector.GetHandle("error");

	private static readonly IntPtr selStatusHandle = Selector.GetHandle("status");

	private static readonly IntPtr selMasterClockHandle = Selector.GetHandle("masterClock");

	private static readonly IntPtr selSetMasterClock_Handle = Selector.GetHandle("setMasterClock:");

	private static readonly IntPtr selPlayerWithURL_Handle = Selector.GetHandle("playerWithURL:");

	private static readonly IntPtr selPlayerWithPlayerItem_Handle = Selector.GetHandle("playerWithPlayerItem:");

	private static readonly IntPtr selInitWithURL_Handle = Selector.GetHandle("initWithURL:");

	private static readonly IntPtr selInitWithPlayerItem_Handle = Selector.GetHandle("initWithPlayerItem:");

	private static readonly IntPtr selPlayHandle = Selector.GetHandle("play");

	private static readonly IntPtr selPauseHandle = Selector.GetHandle("pause");

	private static readonly IntPtr selReplaceCurrentItemWithPlayerItem_Handle = Selector.GetHandle("replaceCurrentItemWithPlayerItem:");

	private static readonly IntPtr selAddPeriodicTimeObserverForIntervalQueueUsingBlock_Handle = Selector.GetHandle("addPeriodicTimeObserverForInterval:queue:usingBlock:");

	private static readonly IntPtr selAddBoundaryTimeObserverForTimesQueueUsingBlock_Handle = Selector.GetHandle("addBoundaryTimeObserverForTimes:queue:usingBlock:");

	private static readonly IntPtr selRemoveTimeObserver_Handle = Selector.GetHandle("removeTimeObserver:");

	private static readonly IntPtr selSeekToTime_Handle = Selector.GetHandle("seekToTime:");

	private static readonly IntPtr selSeekToTimeToleranceBeforeToleranceAfter_Handle = Selector.GetHandle("seekToTime:toleranceBefore:toleranceAfter:");

	private static readonly IntPtr selSeekToTimeCompletionHandler_Handle = Selector.GetHandle("seekToTime:completionHandler:");

	private static readonly IntPtr selSeekToTimeToleranceBeforeToleranceAfterCompletionHandler_Handle = Selector.GetHandle("seekToTime:toleranceBefore:toleranceAfter:completionHandler:");

	private static readonly IntPtr selSetRateTimeAtHostTime_Handle = Selector.GetHandle("setRate:time:atHostTime:");

	private static readonly IntPtr selPrerollAtRateCompletionHandler_Handle = Selector.GetHandle("prerollAtRate:completionHandler:");

	private static readonly IntPtr selCancelPendingPrerollsHandle = Selector.GetHandle("cancelPendingPrerolls");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVPlayer");

	private object __mt_CurrentItem_var;

	private object __mt_Error_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual AVPlayerItem CurrentItem
	{
		[Export("currentItem")]
		get
		{
			return (AVPlayerItem)(__mt_CurrentItem_var = ((!IsDirectBinding) ? ((AVPlayerItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentItemHandle))) : ((AVPlayerItem)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentItemHandle)))));
		}
	}

	public virtual float Rate
	{
		[Export("rate")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selRateHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selRateHandle);
		}
		[Export("setRate:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetRate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetRate_Handle, value);
			}
		}
	}

	public virtual CMTime CurrentTime
	{
		[Export("currentTime")]
		get
		{
			CMTime retval;
			if (IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selCurrentTimeHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selCurrentTimeHandle);
			}
			return retval;
		}
	}

	public virtual AVPlayerActionAtItemEnd ActionAtItemEnd
	{
		[Export("actionAtItemEnd")]
		get
		{
			if (IsDirectBinding)
			{
				return (AVPlayerActionAtItemEnd)Messaging.int_objc_msgSend(base.Handle, selActionAtItemEndHandle);
			}
			return (AVPlayerActionAtItemEnd)Messaging.int_objc_msgSendSuper(base.SuperHandle, selActionAtItemEndHandle);
		}
		[Export("setActionAtItemEnd:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetActionAtItemEnd_Handle, (int)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetActionAtItemEnd_Handle, (int)value);
			}
		}
	}

	public virtual bool ClosedCaptionDisplayEnabled
	{
		[Export("isClosedCaptionDisplayEnabled")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsClosedCaptionDisplayEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsClosedCaptionDisplayEnabledHandle);
		}
		[Export("setClosedCaptionDisplayEnabled:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetClosedCaptionDisplayEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetClosedCaptionDisplayEnabled_Handle, value);
			}
		}
	}

	public virtual NSError Error
	{
		[Export("error")]
		get
		{
			return (NSError)(__mt_Error_var = ((!IsDirectBinding) ? ((NSError)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selErrorHandle))) : ((NSError)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selErrorHandle)))));
		}
	}

	public virtual AVPlayerStatus Status
	{
		[Export("status")]
		get
		{
			if (IsDirectBinding)
			{
				return (AVPlayerStatus)Messaging.int_objc_msgSend(base.Handle, selStatusHandle);
			}
			return (AVPlayerStatus)Messaging.int_objc_msgSendSuper(base.SuperHandle, selStatusHandle);
		}
	}

	[Since(6, 0)]
	public virtual CMClock MasterClock
	{
		[Export("masterClock")]
		get
		{
			if (IsDirectBinding)
			{
				return new CMClock(Messaging.IntPtr_objc_msgSend(base.Handle, selMasterClockHandle));
			}
			return new CMClock(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMasterClockHandle));
		}
		[Export("setMasterClock:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMasterClock_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMasterClock_Handle, value.Handle);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVPlayer()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVPlayer(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVPlayer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVPlayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("playerWithURL:")]
	public static AVPlayer FromUrl(NSUrl URL)
	{
		if (URL == null)
		{
			throw new ArgumentNullException("URL");
		}
		return (AVPlayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPlayerWithURL_Handle, URL.Handle));
	}

	[Export("playerWithPlayerItem:")]
	public static AVPlayer FromPlayerItem(AVPlayerItem item)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		return (AVPlayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPlayerWithPlayerItem_Handle, item.Handle));
	}

	[Export("initWithURL:")]
	public AVPlayer(NSUrl URL)
		: base(NSObjectFlag.Empty)
	{
		if (URL == null)
		{
			throw new ArgumentNullException("URL");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithURL_Handle, URL.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithURL_Handle, URL.Handle);
		}
	}

	[Export("initWithPlayerItem:")]
	public AVPlayer(AVPlayerItem item)
		: base(NSObjectFlag.Empty)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPlayerItem_Handle, item.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPlayerItem_Handle, item.Handle);
		}
	}

	[Export("play")]
	public virtual void Play()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPlayHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPlayHandle);
		}
	}

	[Export("pause")]
	public virtual void Pause()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPauseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPauseHandle);
		}
	}

	[Export("replaceCurrentItemWithPlayerItem:")]
	public virtual void ReplaceCurrentItemWithPlayerItem(AVPlayerItem item)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReplaceCurrentItemWithPlayerItem_Handle, item.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReplaceCurrentItemWithPlayerItem_Handle, item.Handle);
		}
	}

	[Export("addPeriodicTimeObserverForInterval:queue:usingBlock:")]
	public unsafe virtual NSObject AddPeriodicTimeObserver(CMTime interval, DispatchQueue queue, AVTimeHandler handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDAVTimeHandler.Handler, handler);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_CMTime_IntPtr_IntPtr(base.SuperHandle, selAddPeriodicTimeObserverForIntervalQueueUsingBlock_Handle, interval, queue.Handle, (IntPtr)ptr)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_CMTime_IntPtr_IntPtr(base.Handle, selAddPeriodicTimeObserverForIntervalQueueUsingBlock_Handle, interval, queue.Handle, (IntPtr)ptr)));
		ptr->CleanupBlock();
		return result;
	}

	[Export("addBoundaryTimeObserverForTimes:queue:usingBlock:")]
	public unsafe virtual NSObject AddBoundaryTimeObserver(NSValue[] times, DispatchQueue queue, NSAction handler)
	{
		if (times == null)
		{
			throw new ArgumentNullException("times");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		NSArray nSArray = NSArray.FromNSObjects(times);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSAction.Handler, handler);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selAddBoundaryTimeObserverForTimesQueueUsingBlock_Handle, nSArray.Handle, queue.Handle, (IntPtr)ptr)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selAddBoundaryTimeObserverForTimesQueueUsingBlock_Handle, nSArray.Handle, queue.Handle, (IntPtr)ptr)));
		nSArray.Dispose();
		ptr->CleanupBlock();
		return result;
	}

	[Export("removeTimeObserver:")]
	public virtual void RemoveTimeObserver(NSObject observer)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveTimeObserver_Handle, observer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveTimeObserver_Handle, observer.Handle);
		}
	}

	[Export("seekToTime:")]
	public virtual void Seek(CMTime toTime)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTime(base.Handle, selSeekToTime_Handle, toTime);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSeekToTime_Handle, toTime);
		}
	}

	[Export("seekToTime:toleranceBefore:toleranceAfter:")]
	public virtual void Seek(CMTime toTime, CMTime toleranceBefore, CMTime toleranceAfter)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTime_CMTime_CMTime(base.Handle, selSeekToTimeToleranceBeforeToleranceAfter_Handle, toTime, toleranceBefore, toleranceAfter);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTime_CMTime_CMTime(base.SuperHandle, selSeekToTimeToleranceBeforeToleranceAfter_Handle, toTime, toleranceBefore, toleranceAfter);
		}
	}

	[Export("seekToTime:completionHandler:")]
	public unsafe virtual void Seek(CMTime time, AVCompletion completion)
	{
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDAVCompletion.Handler, completion);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTime_IntPtr(base.Handle, selSeekToTimeCompletionHandler_Handle, time, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTime_IntPtr(base.SuperHandle, selSeekToTimeCompletionHandler_Handle, time, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	public virtual Task<bool> SeekAsync(CMTime time)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Seek(time, delegate(bool finished)
		{
			tcs.SetResult(finished);
		});
		return tcs.Task;
	}

	[Export("seekToTime:toleranceBefore:toleranceAfter:completionHandler:")]
	public unsafe virtual void Seek(CMTime time, CMTime toleranceBefore, CMTime toleranceAfter, AVCompletion completion)
	{
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDAVCompletion.Handler, completion);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CMTime_CMTime_CMTime_IntPtr(base.Handle, selSeekToTimeToleranceBeforeToleranceAfterCompletionHandler_Handle, time, toleranceBefore, toleranceAfter, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CMTime_CMTime_CMTime_IntPtr(base.SuperHandle, selSeekToTimeToleranceBeforeToleranceAfterCompletionHandler_Handle, time, toleranceBefore, toleranceAfter, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	public virtual Task<bool> SeekAsync(CMTime time, CMTime toleranceBefore, CMTime toleranceAfter)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Seek(time, toleranceBefore, toleranceAfter, delegate(bool finished)
		{
			tcs.SetResult(finished);
		});
		return tcs.Task;
	}

	[Export("setRate:time:atHostTime:")]
	public virtual void SetRate(float rate, CMTime itemTime, CMTime hostClockTime)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_CMTime_CMTime(base.Handle, selSetRateTimeAtHostTime_Handle, rate, itemTime, hostClockTime);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_CMTime_CMTime(base.SuperHandle, selSetRateTimeAtHostTime_Handle, rate, itemTime, hostClockTime);
		}
	}

	[Export("prerollAtRate:completionHandler:")]
	public unsafe virtual void Preroll(float rate, AVCompletion onComplete)
	{
		if (onComplete == null)
		{
			throw new ArgumentNullException("onComplete");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDAVCompletion.Handler, onComplete);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_IntPtr(base.Handle, selPrerollAtRateCompletionHandler_Handle, rate, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_IntPtr(base.SuperHandle, selPrerollAtRateCompletionHandler_Handle, rate, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	public virtual Task<bool> PrerollAsync(float rate)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Preroll(rate, delegate(bool finished)
		{
			tcs.SetResult(finished);
		});
		return tcs.Task;
	}

	[Export("cancelPendingPrerolls")]
	public virtual void CancelPendingPrerolls()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelPendingPrerollsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelPendingPrerollsHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_CurrentItem_var = null;
			__mt_Error_var = null;
		}
	}
}

using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AVFoundation;

[Register("AVPlayerLooper", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class AVPlayerLooper : NSObject
{
	private bool loopingEnabled = true;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisableLooping = "disableLooping";

	private static readonly IntPtr selDisableLoopingHandle = Selector.GetHandle("disableLooping");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selError = "error";

	private static readonly IntPtr selErrorHandle = Selector.GetHandle("error");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPlayer_TemplateItem_TimeRange_ = "initWithPlayer:templateItem:timeRange:";

	private static readonly IntPtr selInitWithPlayer_TemplateItem_TimeRange_Handle = Selector.GetHandle("initWithPlayer:templateItem:timeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoopCount = "loopCount";

	private static readonly IntPtr selLoopCountHandle = Selector.GetHandle("loopCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoopingPlayerItems = "loopingPlayerItems";

	private static readonly IntPtr selLoopingPlayerItemsHandle = Selector.GetHandle("loopingPlayerItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayerLooperWithPlayer_TemplateItem_ = "playerLooperWithPlayer:templateItem:";

	private static readonly IntPtr selPlayerLooperWithPlayer_TemplateItem_Handle = Selector.GetHandle("playerLooperWithPlayer:templateItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayerLooperWithPlayer_TemplateItem_TimeRange_ = "playerLooperWithPlayer:templateItem:timeRange:";

	private static readonly IntPtr selPlayerLooperWithPlayer_TemplateItem_TimeRange_Handle = Selector.GetHandle("playerLooperWithPlayer:templateItem:timeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStatus = "status";

	private static readonly IntPtr selStatusHandle = Selector.GetHandle("status");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVPlayerLooper");

	[Obsolete("This selector does not exist in the header and was wrongly added.")]
	public virtual bool LoopingEnabled => loopingEnabled;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSError? Error
	{
		[Export("error")]
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
	public virtual nint LoopCount
	{
		[Export("loopCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selLoopCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selLoopCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVPlayerItem[] LoopingPlayerItems
	{
		[Export("loopingPlayerItems")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVPlayerItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selLoopingPlayerItemsHandle));
			}
			return NSArray.ArrayFromHandle<AVPlayerItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLoopingPlayerItemsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVPlayerLooperStatus Status
	{
		[Export("status")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVPlayerLooperStatus)Messaging.Int64_objc_msgSend(base.Handle, selStatusHandle);
			}
			return (AVPlayerLooperStatus)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStatusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVPlayerLooper(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVPlayerLooper(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPlayer:templateItem:timeRange:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVPlayerLooper(AVQueuePlayer player, AVPlayerItem itemToLoop, CMTimeRange loopRange)
		: base(NSObjectFlag.Empty)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (itemToLoop == null)
		{
			throw new ArgumentNullException("itemToLoop");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_CMTimeRange(base.Handle, selInitWithPlayer_TemplateItem_TimeRange_Handle, player.Handle, itemToLoop.Handle, loopRange), "initWithPlayer:templateItem:timeRange:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_CMTimeRange(base.SuperHandle, selInitWithPlayer_TemplateItem_TimeRange_Handle, player.Handle, itemToLoop.Handle, loopRange), "initWithPlayer:templateItem:timeRange:");
		}
	}

	[Export("disableLooping")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DisableLooping()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDisableLoopingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDisableLoopingHandle);
		}
		loopingEnabled = false;
	}

	[Export("playerLooperWithPlayer:templateItem:timeRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVPlayerLooper FromPlayer(AVQueuePlayer player, AVPlayerItem itemToLoop, CMTimeRange loopRange)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (itemToLoop == null)
		{
			throw new ArgumentNullException("itemToLoop");
		}
		return Runtime.GetNSObject<AVPlayerLooper>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_CMTimeRange(class_ptr, selPlayerLooperWithPlayer_TemplateItem_TimeRange_Handle, player.Handle, itemToLoop.Handle, loopRange));
	}

	[Export("playerLooperWithPlayer:templateItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVPlayerLooper FromPlayer(AVQueuePlayer player, AVPlayerItem itemToLoop)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (itemToLoop == null)
		{
			throw new ArgumentNullException("itemToLoop");
		}
		return Runtime.GetNSObject<AVPlayerLooper>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selPlayerLooperWithPlayer_TemplateItem_Handle, player.Handle, itemToLoop.Handle));
	}
}

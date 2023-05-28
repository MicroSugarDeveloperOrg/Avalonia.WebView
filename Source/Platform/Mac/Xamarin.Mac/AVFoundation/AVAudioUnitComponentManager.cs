using System;
using System.ComponentModel;
using AudioUnit;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAudioUnitComponentManager", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class AVAudioUnitComponentManager : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveRegistrationsChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RegistrationsChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveRegistrationsChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(RegistrationsChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponentsMatchingDescription_ = "componentsMatchingDescription:";

	private static readonly IntPtr selComponentsMatchingDescription_Handle = Selector.GetHandle("componentsMatchingDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponentsMatchingPredicate_ = "componentsMatchingPredicate:";

	private static readonly IntPtr selComponentsMatchingPredicate_Handle = Selector.GetHandle("componentsMatchingPredicate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponentsPassingTest_ = "componentsPassingTest:";

	private static readonly IntPtr selComponentsPassingTest_Handle = Selector.GetHandle("componentsPassingTest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedAudioUnitComponentManager = "sharedAudioUnitComponentManager";

	private static readonly IntPtr selSharedAudioUnitComponentManagerHandle = Selector.GetHandle("sharedAudioUnitComponentManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStandardLocalizedTagNames = "standardLocalizedTagNames";

	private static readonly IntPtr selStandardLocalizedTagNamesHandle = Selector.GetHandle("standardLocalizedTagNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTagNames = "tagNames";

	private static readonly IntPtr selTagNamesHandle = Selector.GetHandle("tagNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioUnitComponentManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RegistrationsChangedNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAudioUnitComponentManager SharedInstance
	{
		[Export("sharedAudioUnitComponentManager")]
		get
		{
			return Runtime.GetNSObject<AVAudioUnitComponentManager>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedAudioUnitComponentManagerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] StandardLocalizedTagNames
	{
		[Export("standardLocalizedTagNames")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStandardLocalizedTagNamesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStandardLocalizedTagNamesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] TagNames
	{
		[Export("tagNames")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTagNamesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTagNamesHandle));
		}
	}

	[Field("AVAudioUnitComponentManagerRegistrationsChangedNotification", "AVFoundation")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Advice("Use AVAudioUnitComponentManager.Notifications.ObserveRegistrationsChanged helper method instead.")]
	public static NSString RegistrationsChangedNotification
	{
		[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_RegistrationsChangedNotification == null)
			{
				_RegistrationsChangedNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVAudioUnitComponentManagerRegistrationsChangedNotification");
			}
			return _RegistrationsChangedNotification;
		}
	}

	[Obsolete("Please use the static 'SharedInstance' property as this type is not meant to be created.")]
	public AVAudioUnitComponentManager()
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAudioUnitComponentManager(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioUnitComponentManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("componentsMatchingPredicate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioUnitComponent[] GetComponents(NSPredicate predicate)
	{
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<AVAudioUnitComponent>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selComponentsMatchingPredicate_Handle, predicate.Handle));
		}
		return NSArray.ArrayFromHandle<AVAudioUnitComponent>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selComponentsMatchingPredicate_Handle, predicate.Handle));
	}

	[Export("componentsPassingTest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual AVAudioUnitComponent[] GetComponents([BlockProxy(typeof(Trampolines.NIDAVAudioUnitComponentFilter))] AVAudioUnitComponentFilter testHandler)
	{
		if (testHandler == null)
		{
			throw new ArgumentNullException("testHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAVAudioUnitComponentFilter.Handler, testHandler);
		AVAudioUnitComponent[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<AVAudioUnitComponent>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selComponentsPassingTest_Handle, (IntPtr)ptr)) : NSArray.ArrayFromHandle<AVAudioUnitComponent>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selComponentsPassingTest_Handle, (IntPtr)ptr)));
		ptr->CleanupBlock();
		return result;
	}

	[Export("componentsMatchingDescription:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioUnitComponent[] GetComponents(AudioComponentDescription desc)
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<AVAudioUnitComponent>(Messaging.IntPtr_objc_msgSend_AudioComponentDescription(base.Handle, selComponentsMatchingDescription_Handle, desc));
		}
		return NSArray.ArrayFromHandle<AVAudioUnitComponent>(Messaging.IntPtr_objc_msgSendSuper_AudioComponentDescription(base.SuperHandle, selComponentsMatchingDescription_Handle, desc));
	}
}

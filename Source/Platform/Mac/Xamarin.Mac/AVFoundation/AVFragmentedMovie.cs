using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVFragmentedMovie", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public class AVFragmentedMovie : AVMovie, IAVFragmentMinding, INativeObject, IDisposable
{
	public new static class Notifications
	{
		public static NSObject ObserveContainsMovieFragmentsDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ContainsMovieFragmentsDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveContainsMovieFragmentsDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ContainsMovieFragmentsDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDurationDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DurationDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDurationDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DurationDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveWasDefragmented(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WasDefragmentedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveWasDefragmented(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(WasDefragmentedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_Options_ = "initWithData:options:";

	private static readonly IntPtr selInitWithData_Options_Handle = Selector.GetHandle("initWithData:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_Options_ = "initWithURL:options:";

	private static readonly IntPtr selInitWithURL_Options_Handle = Selector.GetHandle("initWithURL:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAssociatedWithFragmentMinder = "isAssociatedWithFragmentMinder";

	private static readonly IntPtr selIsAssociatedWithFragmentMinderHandle = Selector.GetHandle("isAssociatedWithFragmentMinder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTracks = "tracks";

	private static readonly IntPtr selTracksHandle = Selector.GetHandle("tracks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVFragmentedMovie");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContainsMovieFragmentsDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DurationDidChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _WasDefragmentedNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual AVFragmentedMovieTrack[] Tracks
	{
		[Export("tracks")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVFragmentedMovieTrack>(Messaging.IntPtr_objc_msgSend(base.Handle, selTracksHandle));
			}
			return NSArray.ArrayFromHandle<AVFragmentedMovieTrack>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTracksHandle));
		}
	}

	[Field("AVFragmentedMovieContainsMovieFragmentsDidChangeNotification", "AVFoundation")]
	[Advice("Use AVFragmentedMovie.Notifications.ObserveContainsMovieFragmentsDidChange helper method instead.")]
	public static NSString ContainsMovieFragmentsDidChangeNotification
	{
		get
		{
			if (_ContainsMovieFragmentsDidChangeNotification == null)
			{
				_ContainsMovieFragmentsDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFragmentedMovieContainsMovieFragmentsDidChangeNotification");
			}
			return _ContainsMovieFragmentsDidChangeNotification;
		}
	}

	[Field("AVFragmentedMovieDurationDidChangeNotification", "AVFoundation")]
	[Advice("Use AVFragmentedMovie.Notifications.ObserveDurationDidChange helper method instead.")]
	public new static NSString DurationDidChangeNotification
	{
		get
		{
			if (_DurationDidChangeNotification == null)
			{
				_DurationDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFragmentedMovieDurationDidChangeNotification");
			}
			return _DurationDidChangeNotification;
		}
	}

	[Field("AVFragmentedMovieWasDefragmentedNotification", "AVFoundation")]
	[Advice("Use AVFragmentedMovie.Notifications.ObserveWasDefragmented helper method instead.")]
	public new static NSString WasDefragmentedNotification
	{
		get
		{
			if (_WasDefragmentedNotification == null)
			{
				_WasDefragmentedNotification = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVFragmentedMovieWasDefragmentedNotification");
			}
			return _WasDefragmentedNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVFragmentedMovie(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVFragmentedMovie(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:options:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVFragmentedMovie(NSUrl URL, NSDictionary<NSString, NSObject>? options)
		: base(NSObjectFlag.Empty)
	{
		if (URL == null)
		{
			throw new ArgumentNullException("URL");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithURL_Options_Handle, URL.Handle, options?.Handle ?? IntPtr.Zero), "initWithURL:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithURL_Options_Handle, URL.Handle, options?.Handle ?? IntPtr.Zero), "initWithURL:options:");
		}
	}

	[Export("initWithData:options:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVFragmentedMovie(NSData data, NSDictionary<NSString, NSObject>? options)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithData_Options_Handle, data.Handle, options?.Handle ?? IntPtr.Zero), "initWithData:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithData_Options_Handle, data.Handle, options?.Handle ?? IntPtr.Zero), "initWithData:options:");
		}
	}

	[Export("isAssociatedWithFragmentMinder")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsAssociatedWithFragmentMinder()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selIsAssociatedWithFragmentMinderHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAssociatedWithFragmentMinderHandle);
	}
}

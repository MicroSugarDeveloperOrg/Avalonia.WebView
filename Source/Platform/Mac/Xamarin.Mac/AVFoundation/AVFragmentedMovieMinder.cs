using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVFragmentedMovieMinder", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public class AVFragmentedMovieMinder : AVFragmentedAssetMinder
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddFragmentedMovie_ = "addFragmentedMovie:";

	private static readonly IntPtr selAddFragmentedMovie_Handle = Selector.GetHandle("addFragmentedMovie:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFragmentedMovieMinderWithMovie_MindingInterval_ = "fragmentedMovieMinderWithMovie:mindingInterval:";

	private static readonly IntPtr selFragmentedMovieMinderWithMovie_MindingInterval_Handle = Selector.GetHandle("fragmentedMovieMinderWithMovie:mindingInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMovie_MindingInterval_ = "initWithMovie:mindingInterval:";

	private static readonly IntPtr selInitWithMovie_MindingInterval_Handle = Selector.GetHandle("initWithMovie:mindingInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMindingInterval = "mindingInterval";

	private static readonly IntPtr selMindingIntervalHandle = Selector.GetHandle("mindingInterval");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovies = "movies";

	private static readonly IntPtr selMoviesHandle = Selector.GetHandle("movies");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveFragmentedMovie_ = "removeFragmentedMovie:";

	private static readonly IntPtr selRemoveFragmentedMovie_Handle = Selector.GetHandle("removeFragmentedMovie:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMindingInterval_ = "setMindingInterval:";

	private static readonly IntPtr selSetMindingInterval_Handle = Selector.GetHandle("setMindingInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVFragmentedMovieMinder");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual double MindingInterval
	{
		[Export("mindingInterval")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selMindingIntervalHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selMindingIntervalHandle);
		}
		[Export("setMindingInterval:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetMindingInterval_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetMindingInterval_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVFragmentedMovie[] Movies
	{
		[Export("movies")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVFragmentedMovie>(Messaging.IntPtr_objc_msgSend(base.Handle, selMoviesHandle));
			}
			return NSArray.ArrayFromHandle<AVFragmentedMovie>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMoviesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVFragmentedMovieMinder()
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
	protected AVFragmentedMovieMinder(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVFragmentedMovieMinder(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithMovie:mindingInterval:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVFragmentedMovieMinder(AVFragmentedMovie movie, double mindingInterval)
		: base(NSObjectFlag.Empty)
	{
		if (movie == null)
		{
			throw new ArgumentNullException("movie");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_Double(base.Handle, selInitWithMovie_MindingInterval_Handle, movie.Handle, mindingInterval), "initWithMovie:mindingInterval:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_Double(base.SuperHandle, selInitWithMovie_MindingInterval_Handle, movie.Handle, mindingInterval), "initWithMovie:mindingInterval:");
		}
	}

	[Export("addFragmentedMovie:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Add(AVFragmentedMovie movie)
	{
		if (movie == null)
		{
			throw new ArgumentNullException("movie");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddFragmentedMovie_Handle, movie.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddFragmentedMovie_Handle, movie.Handle);
		}
	}

	[Export("fragmentedMovieMinderWithMovie:mindingInterval:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVFragmentedMovieMinder FromMovie(AVFragmentedMovie movie, double mindingInterval)
	{
		if (movie == null)
		{
			throw new ArgumentNullException("movie");
		}
		return Runtime.GetNSObject<AVFragmentedMovieMinder>(Messaging.IntPtr_objc_msgSend_IntPtr_Double(class_ptr, selFragmentedMovieMinderWithMovie_MindingInterval_Handle, movie.Handle, mindingInterval));
	}

	[Export("removeFragmentedMovie:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Remove(AVFragmentedMovie movie)
	{
		if (movie == null)
		{
			throw new ArgumentNullException("movie");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveFragmentedMovie_Handle, movie.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveFragmentedMovie_Handle, movie.Handle);
		}
	}
}

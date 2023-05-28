using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MediaLibrary;

[Register("MLMediaLibrary", true)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
public class MLMediaLibrary : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithOptions_ = "initWithOptions:";

	private static readonly IntPtr selInitWithOptions_Handle = Selector.GetHandle("initWithOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaSources = "mediaSources";

	private static readonly IntPtr selMediaSourcesHandle = Selector.GetHandle("mediaSources");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MLMediaLibrary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaLoadAppFoldersKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaLoadAppleLoops;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaLoadExcludeSourcesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaLoadFoldersKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaLoadIncludeSourcesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaLoadMoviesFolder;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MediaLoadSourceTypesKey;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<NSString, MLMediaSource>? MediaSources
	{
		[Export("mediaSources", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<NSString, MLMediaSource>>(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaSourcesHandle));
			}
			return Runtime.GetNSObject<NSDictionary<NSString, MLMediaSource>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaSourcesHandle));
		}
	}

	[Field("MLMediaLoadAppFoldersKey", "MediaLibrary")]
	public static NSString MediaLoadAppFoldersKey
	{
		get
		{
			if (_MediaLoadAppFoldersKey == null)
			{
				_MediaLoadAppFoldersKey = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaLoadAppFoldersKey");
			}
			return _MediaLoadAppFoldersKey;
		}
	}

	[Field("MLMediaLoadAppleLoops", "MediaLibrary")]
	public static NSString MediaLoadAppleLoops
	{
		get
		{
			if (_MediaLoadAppleLoops == null)
			{
				_MediaLoadAppleLoops = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaLoadAppleLoops");
			}
			return _MediaLoadAppleLoops;
		}
	}

	[Field("MLMediaLoadExcludeSourcesKey", "MediaLibrary")]
	public static NSString MediaLoadExcludeSourcesKey
	{
		get
		{
			if (_MediaLoadExcludeSourcesKey == null)
			{
				_MediaLoadExcludeSourcesKey = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaLoadExcludeSourcesKey");
			}
			return _MediaLoadExcludeSourcesKey;
		}
	}

	[Field("MLMediaLoadFoldersKey", "MediaLibrary")]
	public static NSString MediaLoadFoldersKey
	{
		get
		{
			if (_MediaLoadFoldersKey == null)
			{
				_MediaLoadFoldersKey = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaLoadFoldersKey");
			}
			return _MediaLoadFoldersKey;
		}
	}

	[Field("MLMediaLoadIncludeSourcesKey", "MediaLibrary")]
	public static NSString MediaLoadIncludeSourcesKey
	{
		get
		{
			if (_MediaLoadIncludeSourcesKey == null)
			{
				_MediaLoadIncludeSourcesKey = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaLoadIncludeSourcesKey");
			}
			return _MediaLoadIncludeSourcesKey;
		}
	}

	[Field("MLMediaLoadMoviesFolder", "MediaLibrary")]
	public static NSString MediaLoadMoviesFolder
	{
		get
		{
			if (_MediaLoadMoviesFolder == null)
			{
				_MediaLoadMoviesFolder = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaLoadMoviesFolder");
			}
			return _MediaLoadMoviesFolder;
		}
	}

	[Field("MLMediaLoadSourceTypesKey", "MediaLibrary")]
	public static NSString MediaLoadSourceTypesKey
	{
		get
		{
			if (_MediaLoadSourceTypesKey == null)
			{
				_MediaLoadSourceTypesKey = Dlfcn.GetStringConstant(Libraries.MediaLibrary.Handle, "MLMediaLoadSourceTypesKey");
			}
			return _MediaLoadSourceTypesKey;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MLMediaLibrary(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MLMediaLibrary(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithOptions:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MLMediaLibrary(NSDictionary<NSString, NSObject> options)
		: base(NSObjectFlag.Empty)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithOptions_Handle, options.Handle), "initWithOptions:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithOptions_Handle, options.Handle), "initWithOptions:");
		}
	}
}

using System;
using System.ComponentModel;
using CoreAnimation;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTMovieLayer", true)]
public class QTMovieLayer : CALayer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithMovie_ = "initWithMovie:";

	private static readonly IntPtr selInitWithMovie_Handle = Selector.GetHandle("initWithMovie:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayerWithMovie_ = "layerWithMovie:";

	private static readonly IntPtr selLayerWithMovie_Handle = Selector.GetHandle("layerWithMovie:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMovie = "movie";

	private static readonly IntPtr selMovieHandle = Selector.GetHandle("movie");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMovie_ = "setMovie:";

	private static readonly IntPtr selSetMovie_Handle = Selector.GetHandle("setMovie:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QTMovieLayer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTMovie Movie
	{
		[Export("movie")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<QTMovie>(Messaging.IntPtr_objc_msgSend(base.Handle, selMovieHandle));
			}
			return Runtime.GetNSObject<QTMovie>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMovieHandle));
		}
		[Export("setMovie:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMovie_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMovie_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTMovieLayer()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public QTMovieLayer(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected QTMovieLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QTMovieLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithMovie:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public QTMovieLayer(QTMovie movie)
		: base(NSObjectFlag.Empty)
	{
		if (movie == null)
		{
			throw new ArgumentNullException("movie");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithMovie_Handle, movie.Handle), "initWithMovie:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithMovie_Handle, movie.Handle), "initWithMovie:");
		}
	}

	[Export("layerWithMovie:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static QTMovieLayer FromMovie(QTMovie movie)
	{
		if (movie == null)
		{
			throw new ArgumentNullException("movie");
		}
		return Runtime.GetNSObject<QTMovieLayer>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLayerWithMovie_Handle, movie.Handle));
	}
}

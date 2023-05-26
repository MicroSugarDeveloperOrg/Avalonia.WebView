using System;
using System.ComponentModel;
using CoreAnimation;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTMovieLayer", true)]
public class QTMovieLayer : CALayer
{
	private static readonly IntPtr selMovieHandle = Selector.GetHandle("movie");

	private static readonly IntPtr selSetMovie_Handle = Selector.GetHandle("setMovie:");

	private static readonly IntPtr selLayerWithMovie_Handle = Selector.GetHandle("layerWithMovie:");

	private static readonly IntPtr selInitWithMovie_Handle = Selector.GetHandle("initWithMovie:");

	private static readonly IntPtr class_ptr = Class.GetHandle("QTMovieLayer");

	private object __mt_Movie_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual QTMovie Movie
	{
		[Export("movie")]
		get
		{
			return (QTMovie)(__mt_Movie_var = ((!IsDirectBinding) ? ((QTMovie)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMovieHandle))) : ((QTMovie)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selMovieHandle)))));
		}
		[Export("setMovie:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMovie_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMovie_Handle, value.Handle);
			}
			__mt_Movie_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTMovieLayer()
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
	public QTMovieLayer(NSCoder coder)
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
	public QTMovieLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QTMovieLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("layerWithMovie:")]
	public static QTMovieLayer FromMovie(QTMovie movie)
	{
		if (movie == null)
		{
			throw new ArgumentNullException("movie");
		}
		return (QTMovieLayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLayerWithMovie_Handle, movie.Handle));
	}

	[Export("initWithMovie:")]
	public QTMovieLayer(QTMovie movie)
		: base(NSObjectFlag.Empty)
	{
		if (movie == null)
		{
			throw new ArgumentNullException("movie");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithMovie_Handle, movie.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithMovie_Handle, movie.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Movie_var = null;
		}
	}
}

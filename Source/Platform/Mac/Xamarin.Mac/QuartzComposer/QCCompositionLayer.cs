using System;
using System.ComponentModel;
using CoreAnimation;
using Foundation;
using ObjCRuntime;

namespace QuartzComposer;

[Register("QCCompositionLayer", true)]
public class QCCompositionLayer : CAOpenGLLayer
{
	private static readonly IntPtr selCompositionHandle = Selector.GetHandle("composition");

	private static readonly IntPtr selCompositionLayerWithFile_Handle = Selector.GetHandle("compositionLayerWithFile:");

	private static readonly IntPtr selCompositionLayerWithComposition_Handle = Selector.GetHandle("compositionLayerWithComposition:");

	private static readonly IntPtr selInitWithFile_Handle = Selector.GetHandle("initWithFile:");

	private static readonly IntPtr selInitWithComposition_Handle = Selector.GetHandle("initWithComposition:");

	private static readonly IntPtr class_ptr = Class.GetHandle("QCCompositionLayer");

	private object __mt_Composition_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual QCComposition Composition
	{
		[Export("composition")]
		get
		{
			return (QCComposition)(__mt_Composition_var = ((!IsDirectBinding) ? ((QCComposition)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCompositionHandle))) : ((QCComposition)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCompositionHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public QCCompositionLayer(NSCoder coder)
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
	public QCCompositionLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QCCompositionLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("compositionLayerWithFile:")]
	public static QCCompositionLayer Create(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		QCCompositionLayer result = (QCCompositionLayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCompositionLayerWithFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("compositionLayerWithComposition:")]
	public static QCCompositionLayer Create(QCComposition composition)
	{
		if (composition == null)
		{
			throw new ArgumentNullException("composition");
		}
		return (QCCompositionLayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCompositionLayerWithComposition_Handle, composition.Handle));
	}

	[Export("initWithFile:")]
	public QCCompositionLayer(string path)
		: base(NSObjectFlag.Empty)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithFile_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithFile_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithComposition:")]
	public QCCompositionLayer(QCComposition composition)
		: base(NSObjectFlag.Empty)
	{
		if (composition == null)
		{
			throw new ArgumentNullException("composition");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithComposition_Handle, composition.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithComposition_Handle, composition.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Composition_var = null;
		}
	}
}

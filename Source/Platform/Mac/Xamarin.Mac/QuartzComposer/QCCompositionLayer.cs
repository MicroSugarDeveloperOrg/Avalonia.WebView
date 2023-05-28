using System;
using System.ComponentModel;
using CoreAnimation;
using Foundation;
using ObjCRuntime;

namespace QuartzComposer;

[Register("QCCompositionLayer", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
public class QCCompositionLayer : CAOpenGLLayer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComposition = "composition";

	private static readonly IntPtr selCompositionHandle = Selector.GetHandle("composition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompositionLayerWithComposition_ = "compositionLayerWithComposition:";

	private static readonly IntPtr selCompositionLayerWithComposition_Handle = Selector.GetHandle("compositionLayerWithComposition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompositionLayerWithFile_ = "compositionLayerWithFile:";

	private static readonly IntPtr selCompositionLayerWithFile_Handle = Selector.GetHandle("compositionLayerWithFile:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithComposition_ = "initWithComposition:";

	private static readonly IntPtr selInitWithComposition_Handle = Selector.GetHandle("initWithComposition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFile_ = "initWithFile:";

	private static readonly IntPtr selInitWithFile_Handle = Selector.GetHandle("initWithFile:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QCCompositionLayer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QCComposition Composition
	{
		[Export("composition")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<QCComposition>(Messaging.IntPtr_objc_msgSend(base.Handle, selCompositionHandle));
			}
			return Runtime.GetNSObject<QCComposition>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCompositionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public QCCompositionLayer(NSCoder coder)
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
	protected QCCompositionLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QCCompositionLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFile:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public QCCompositionLayer(string path)
		: base(NSObjectFlag.Empty)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithFile_Handle, arg), "initWithFile:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithFile_Handle, arg), "initWithFile:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithComposition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public QCCompositionLayer(QCComposition composition)
		: base(NSObjectFlag.Empty)
	{
		if (composition == null)
		{
			throw new ArgumentNullException("composition");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithComposition_Handle, composition.Handle), "initWithComposition:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithComposition_Handle, composition.Handle), "initWithComposition:");
		}
	}

	[Export("compositionLayerWithFile:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static QCCompositionLayer Create(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		QCCompositionLayer nSObject = Runtime.GetNSObject<QCCompositionLayer>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCompositionLayerWithFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("compositionLayerWithComposition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static QCCompositionLayer Create(QCComposition composition)
	{
		if (composition == null)
		{
			throw new ArgumentNullException("composition");
		}
		return Runtime.GetNSObject<QCCompositionLayer>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCompositionLayerWithComposition_Handle, composition.Handle));
	}
}

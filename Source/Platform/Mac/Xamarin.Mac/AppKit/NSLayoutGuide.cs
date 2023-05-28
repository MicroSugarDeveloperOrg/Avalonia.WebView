using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSLayoutGuide", true)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NSLayoutGuide : NSObject, INSCoding, INativeObject, IDisposable, INSUserInterfaceItemIdentification
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBottomAnchor = "bottomAnchor";

	private static readonly IntPtr selBottomAnchorHandle = Selector.GetHandle("bottomAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCenterXAnchor = "centerXAnchor";

	private static readonly IntPtr selCenterXAnchorHandle = Selector.GetHandle("centerXAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCenterYAnchor = "centerYAnchor";

	private static readonly IntPtr selCenterYAnchorHandle = Selector.GetHandle("centerYAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConstraintsAffectingLayoutForOrientation_ = "constraintsAffectingLayoutForOrientation:";

	private static readonly IntPtr selConstraintsAffectingLayoutForOrientation_Handle = Selector.GetHandle("constraintsAffectingLayoutForOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrame = "frame";

	private static readonly IntPtr selFrameHandle = Selector.GetHandle("frame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasAmbiguousLayout = "hasAmbiguousLayout";

	private static readonly IntPtr selHasAmbiguousLayoutHandle = Selector.GetHandle("hasAmbiguousLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeightAnchor = "heightAnchor";

	private static readonly IntPtr selHeightAnchorHandle = Selector.GetHandle("heightAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeadingAnchor = "leadingAnchor";

	private static readonly IntPtr selLeadingAnchorHandle = Selector.GetHandle("leadingAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeftAnchor = "leftAnchor";

	private static readonly IntPtr selLeftAnchorHandle = Selector.GetHandle("leftAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOwningView = "owningView";

	private static readonly IntPtr selOwningViewHandle = Selector.GetHandle("owningView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRightAnchor = "rightAnchor";

	private static readonly IntPtr selRightAnchorHandle = Selector.GetHandle("rightAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIdentifier_ = "setIdentifier:";

	private static readonly IntPtr selSetIdentifier_Handle = Selector.GetHandle("setIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOwningView_ = "setOwningView:";

	private static readonly IntPtr selSetOwningView_Handle = Selector.GetHandle("setOwningView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTopAnchor = "topAnchor";

	private static readonly IntPtr selTopAnchorHandle = Selector.GetHandle("topAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrailingAnchor = "trailingAnchor";

	private static readonly IntPtr selTrailingAnchorHandle = Selector.GetHandle("trailingAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWidthAnchor = "widthAnchor";

	private static readonly IntPtr selWidthAnchorHandle = Selector.GetHandle("widthAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSLayoutGuide");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_OwningView_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutYAxisAnchor BottomAnchor
	{
		[Export("bottomAnchor", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutYAxisAnchor>(Messaging.IntPtr_objc_msgSend(base.Handle, selBottomAnchorHandle));
			}
			return Runtime.GetNSObject<NSLayoutYAxisAnchor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBottomAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutXAxisAnchor CenterXAnchor
	{
		[Export("centerXAnchor", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutXAxisAnchor>(Messaging.IntPtr_objc_msgSend(base.Handle, selCenterXAnchorHandle));
			}
			return Runtime.GetNSObject<NSLayoutXAxisAnchor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCenterXAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutYAxisAnchor CenterYAnchor
	{
		[Export("centerYAnchor", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutYAxisAnchor>(Messaging.IntPtr_objc_msgSend(base.Handle, selCenterYAnchorHandle));
			}
			return Runtime.GetNSObject<NSLayoutYAxisAnchor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCenterYAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect Frame
	{
		[Export("frame")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selFrameHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual bool HasAmbiguousLayout
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("hasAmbiguousLayout")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasAmbiguousLayoutHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasAmbiguousLayoutHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutDimension HeightAnchor
	{
		[Export("heightAnchor", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutDimension>(Messaging.IntPtr_objc_msgSend(base.Handle, selHeightAnchorHandle));
			}
			return Runtime.GetNSObject<NSLayoutDimension>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHeightAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Identifier
	{
		[Export("identifier", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
		[Export("setIdentifier:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutXAxisAnchor LeadingAnchor
	{
		[Export("leadingAnchor", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutXAxisAnchor>(Messaging.IntPtr_objc_msgSend(base.Handle, selLeadingAnchorHandle));
			}
			return Runtime.GetNSObject<NSLayoutXAxisAnchor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLeadingAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutXAxisAnchor LeftAnchor
	{
		[Export("leftAnchor", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutXAxisAnchor>(Messaging.IntPtr_objc_msgSend(base.Handle, selLeftAnchorHandle));
			}
			return Runtime.GetNSObject<NSLayoutXAxisAnchor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLeftAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView? OwningView
	{
		[Export("owningView", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSView nSView = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOwningViewHandle)) : Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selOwningViewHandle)));
			MarkDirty();
			__mt_OwningView_var = nSView;
			return nSView;
		}
		[Export("setOwningView:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOwningView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOwningView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_OwningView_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutXAxisAnchor RightAnchor
	{
		[Export("rightAnchor", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutXAxisAnchor>(Messaging.IntPtr_objc_msgSend(base.Handle, selRightAnchorHandle));
			}
			return Runtime.GetNSObject<NSLayoutXAxisAnchor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRightAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutYAxisAnchor TopAnchor
	{
		[Export("topAnchor", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutYAxisAnchor>(Messaging.IntPtr_objc_msgSend(base.Handle, selTopAnchorHandle));
			}
			return Runtime.GetNSObject<NSLayoutYAxisAnchor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTopAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutXAxisAnchor TrailingAnchor
	{
		[Export("trailingAnchor", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutXAxisAnchor>(Messaging.IntPtr_objc_msgSend(base.Handle, selTrailingAnchorHandle));
			}
			return Runtime.GetNSObject<NSLayoutXAxisAnchor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTrailingAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutDimension WidthAnchor
	{
		[Export("widthAnchor", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutDimension>(Messaging.IntPtr_objc_msgSend(base.Handle, selWidthAnchorHandle));
			}
			return Runtime.GetNSObject<NSLayoutDimension>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWidthAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSLayoutGuide()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	public NSLayoutGuide(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected NSLayoutGuide(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSLayoutGuide(IntPtr handle)
		: base(handle)
	{
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("constraintsAffectingLayoutForOrientation:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutConstraint[] GetConstraintsAffectingLayout(NSLayoutConstraintOrientation orientation)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selConstraintsAffectingLayoutForOrientation_Handle, (long)orientation));
		}
		return NSArray.ArrayFromHandle<NSLayoutConstraint>(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selConstraintsAffectingLayoutForOrientation_Handle, (long)orientation));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_OwningView_var = null;
		}
	}
}

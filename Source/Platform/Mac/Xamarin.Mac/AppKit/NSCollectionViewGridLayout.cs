using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCollectionViewGridLayout", true)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NSCollectionViewGridLayout : NSCollectionViewLayout
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundColors = "backgroundColors";

	private static readonly IntPtr selBackgroundColorsHandle = Selector.GetHandle("backgroundColors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMargins = "margins";

	private static readonly IntPtr selMarginsHandle = Selector.GetHandle("margins");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumItemSize = "maximumItemSize";

	private static readonly IntPtr selMaximumItemSizeHandle = Selector.GetHandle("maximumItemSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumNumberOfColumns = "maximumNumberOfColumns";

	private static readonly IntPtr selMaximumNumberOfColumnsHandle = Selector.GetHandle("maximumNumberOfColumns");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumNumberOfRows = "maximumNumberOfRows";

	private static readonly IntPtr selMaximumNumberOfRowsHandle = Selector.GetHandle("maximumNumberOfRows");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumInteritemSpacing = "minimumInteritemSpacing";

	private static readonly IntPtr selMinimumInteritemSpacingHandle = Selector.GetHandle("minimumInteritemSpacing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumItemSize = "minimumItemSize";

	private static readonly IntPtr selMinimumItemSizeHandle = Selector.GetHandle("minimumItemSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumLineSpacing = "minimumLineSpacing";

	private static readonly IntPtr selMinimumLineSpacingHandle = Selector.GetHandle("minimumLineSpacing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundColors_ = "setBackgroundColors:";

	private static readonly IntPtr selSetBackgroundColors_Handle = Selector.GetHandle("setBackgroundColors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMargins_ = "setMargins:";

	private static readonly IntPtr selSetMargins_Handle = Selector.GetHandle("setMargins:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumItemSize_ = "setMaximumItemSize:";

	private static readonly IntPtr selSetMaximumItemSize_Handle = Selector.GetHandle("setMaximumItemSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumNumberOfColumns_ = "setMaximumNumberOfColumns:";

	private static readonly IntPtr selSetMaximumNumberOfColumns_Handle = Selector.GetHandle("setMaximumNumberOfColumns:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumNumberOfRows_ = "setMaximumNumberOfRows:";

	private static readonly IntPtr selSetMaximumNumberOfRows_Handle = Selector.GetHandle("setMaximumNumberOfRows:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumInteritemSpacing_ = "setMinimumInteritemSpacing:";

	private static readonly IntPtr selSetMinimumInteritemSpacing_Handle = Selector.GetHandle("setMinimumInteritemSpacing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumItemSize_ = "setMinimumItemSize:";

	private static readonly IntPtr selSetMinimumItemSize_Handle = Selector.GetHandle("setMinimumItemSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumLineSpacing_ = "setMinimumLineSpacing:";

	private static readonly IntPtr selSetMinimumLineSpacing_Handle = Selector.GetHandle("setMinimumLineSpacing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCollectionViewGridLayout");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor[] BackgroundColors
	{
		[Export("backgroundColors", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorsHandle));
			}
			return NSArray.ArrayFromHandle<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorsHandle));
		}
		[Export("setBackgroundColors:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColors_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColors_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEdgeInsets Margins
	{
		[Export("margins", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSEdgeInsets retval;
			if (base.IsDirectBinding)
			{
				Messaging.NSEdgeInsets_objc_msgSend_stret(out retval, base.Handle, selMarginsHandle);
			}
			else
			{
				Messaging.NSEdgeInsets_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMarginsHandle);
			}
			return retval;
		}
		[Export("setMargins:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_NSEdgeInsets(base.Handle, selSetMargins_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_NSEdgeInsets(base.SuperHandle, selSetMargins_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize MaximumItemSize
	{
		[Export("maximumItemSize", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMaximumItemSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMaximumItemSizeHandle);
		}
		[Export("setMaximumItemSize:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetMaximumItemSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetMaximumItemSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint MaximumNumberOfColumns
	{
		[Export("maximumNumberOfColumns", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMaximumNumberOfColumnsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMaximumNumberOfColumnsHandle);
		}
		[Export("setMaximumNumberOfColumns:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetMaximumNumberOfColumns_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetMaximumNumberOfColumns_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint MaximumNumberOfRows
	{
		[Export("maximumNumberOfRows", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMaximumNumberOfRowsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMaximumNumberOfRowsHandle);
		}
		[Export("setMaximumNumberOfRows:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetMaximumNumberOfRows_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetMaximumNumberOfRows_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MinimumInteritemSpacing
	{
		[Export("minimumInteritemSpacing", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMinimumInteritemSpacingHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMinimumInteritemSpacingHandle);
		}
		[Export("setMinimumInteritemSpacing:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMinimumInteritemSpacing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMinimumInteritemSpacing_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize MinimumItemSize
	{
		[Export("minimumItemSize", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selMinimumItemSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selMinimumItemSizeHandle);
		}
		[Export("setMinimumItemSize:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetMinimumItemSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetMinimumItemSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MinimumLineSpacing
	{
		[Export("minimumLineSpacing", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMinimumLineSpacingHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMinimumLineSpacingHandle);
		}
		[Export("setMinimumLineSpacing:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMinimumLineSpacing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMinimumLineSpacing_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCollectionViewGridLayout()
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
	public NSCollectionViewGridLayout(NSCoder coder)
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
	protected NSCollectionViewGridLayout(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCollectionViewGridLayout(IntPtr handle)
		: base(handle)
	{
	}
}

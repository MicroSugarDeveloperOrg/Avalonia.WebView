using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSTextContainer", true)]
public class NSTextContainer : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainerSize = "containerSize";

	private static readonly IntPtr selContainerSizeHandle = Selector.GetHandle("containerSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainsPoint_ = "containsPoint:";

	private static readonly IntPtr selContainsPoint_Handle = Selector.GetHandle("containsPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExclusionPaths = "exclusionPaths";

	private static readonly IntPtr selExclusionPathsHandle = Selector.GetHandle("exclusionPaths");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeightTracksTextView = "heightTracksTextView";

	private static readonly IntPtr selHeightTracksTextViewHandle = Selector.GetHandle("heightTracksTextView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContainerSize_ = "initWithContainerSize:";

	private static readonly IntPtr selInitWithContainerSize_Handle = Selector.GetHandle("initWithContainerSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSize_ = "initWithSize:";

	private static readonly IntPtr selInitWithSize_Handle = Selector.GetHandle("initWithSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSimpleRectangularTextContainer = "isSimpleRectangularTextContainer";

	private static readonly IntPtr selIsSimpleRectangularTextContainerHandle = Selector.GetHandle("isSimpleRectangularTextContainer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutManager = "layoutManager";

	private static readonly IntPtr selLayoutManagerHandle = Selector.GetHandle("layoutManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineBreakMode = "lineBreakMode";

	private static readonly IntPtr selLineBreakModeHandle = Selector.GetHandle("lineBreakMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineFragmentPadding = "lineFragmentPadding";

	private static readonly IntPtr selLineFragmentPaddingHandle = Selector.GetHandle("lineFragmentPadding");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineFragmentRectForProposedRect_AtIndex_WritingDirection_RemainingRect_ = "lineFragmentRectForProposedRect:atIndex:writingDirection:remainingRect:";

	private static readonly IntPtr selLineFragmentRectForProposedRect_AtIndex_WritingDirection_RemainingRect_Handle = Selector.GetHandle("lineFragmentRectForProposedRect:atIndex:writingDirection:remainingRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumNumberOfLines = "maximumNumberOfLines";

	private static readonly IntPtr selMaximumNumberOfLinesHandle = Selector.GetHandle("maximumNumberOfLines");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceLayoutManager_ = "replaceLayoutManager:";

	private static readonly IntPtr selReplaceLayoutManager_Handle = Selector.GetHandle("replaceLayoutManager:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContainerSize_ = "setContainerSize:";

	private static readonly IntPtr selSetContainerSize_Handle = Selector.GetHandle("setContainerSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExclusionPaths_ = "setExclusionPaths:";

	private static readonly IntPtr selSetExclusionPaths_Handle = Selector.GetHandle("setExclusionPaths:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHeightTracksTextView_ = "setHeightTracksTextView:";

	private static readonly IntPtr selSetHeightTracksTextView_Handle = Selector.GetHandle("setHeightTracksTextView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLayoutManager_ = "setLayoutManager:";

	private static readonly IntPtr selSetLayoutManager_Handle = Selector.GetHandle("setLayoutManager:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineBreakMode_ = "setLineBreakMode:";

	private static readonly IntPtr selSetLineBreakMode_Handle = Selector.GetHandle("setLineBreakMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLineFragmentPadding_ = "setLineFragmentPadding:";

	private static readonly IntPtr selSetLineFragmentPadding_Handle = Selector.GetHandle("setLineFragmentPadding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumNumberOfLines_ = "setMaximumNumberOfLines:";

	private static readonly IntPtr selSetMaximumNumberOfLines_Handle = Selector.GetHandle("setMaximumNumberOfLines:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSize_ = "setSize:";

	private static readonly IntPtr selSetSize_Handle = Selector.GetHandle("setSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextView_ = "setTextView:";

	private static readonly IntPtr selSetTextView_Handle = Selector.GetHandle("setTextView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWidthTracksTextView_ = "setWidthTracksTextView:";

	private static readonly IntPtr selSetWidthTracksTextView_Handle = Selector.GetHandle("setWidthTracksTextView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSize = "size";

	private static readonly IntPtr selSizeHandle = Selector.GetHandle("size");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextView = "textView";

	private static readonly IntPtr selTextViewHandle = Selector.GetHandle("textView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWidthTracksTextView = "widthTracksTextView";

	private static readonly IntPtr selWidthTracksTextViewHandle = Selector.GetHandle("widthTracksTextView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTextContainer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_TextView_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "Use Size instead.")]
	public virtual CGSize ContainerSize
	{
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "Use Size instead.")]
		[Export("containerSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selContainerSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selContainerSizeHandle);
		}
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "Use Size instead.")]
		[Export("setContainerSize:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetContainerSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetContainerSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSBezierPath[] ExclusionPaths
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("exclusionPaths", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSBezierPath>(Messaging.IntPtr_objc_msgSend(base.Handle, selExclusionPathsHandle));
			}
			return NSArray.ArrayFromHandle<NSBezierPath>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExclusionPathsHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setExclusionPaths:", ArgumentSemantic.Copy)]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetExclusionPaths_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetExclusionPaths_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HeightTracksTextView
	{
		[Export("heightTracksTextView")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHeightTracksTextViewHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHeightTracksTextViewHandle);
		}
		[Export("setHeightTracksTextView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHeightTracksTextView_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHeightTracksTextView_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsSimpleRectangularTextContainer
	{
		[Export("isSimpleRectangularTextContainer")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSimpleRectangularTextContainerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSimpleRectangularTextContainerHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutManager LayoutManager
	{
		[Export("layoutManager")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLayoutManager>(Messaging.IntPtr_objc_msgSend(base.Handle, selLayoutManagerHandle));
			}
			return Runtime.GetNSObject<NSLayoutManager>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLayoutManagerHandle));
		}
		[Export("setLayoutManager:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLayoutManager_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLayoutManager_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSLineBreakMode LineBreakMode
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("lineBreakMode", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSLineBreakMode)Messaging.UInt64_objc_msgSend(base.Handle, selLineBreakModeHandle);
			}
			return (NSLineBreakMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLineBreakModeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setLineBreakMode:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetLineBreakMode_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetLineBreakMode_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat LineFragmentPadding
	{
		[Export("lineFragmentPadding")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selLineFragmentPaddingHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selLineFragmentPaddingHandle);
		}
		[Export("setLineFragmentPadding:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetLineFragmentPadding_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetLineFragmentPadding_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual nuint MaximumNumberOfLines
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("maximumNumberOfLines", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMaximumNumberOfLinesHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMaximumNumberOfLinesHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setMaximumNumberOfLines:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetMaximumNumberOfLines_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetMaximumNumberOfLines_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual CGSize Size
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("size", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selSizeHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setSize:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextView TextView
	{
		[Export("textView", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSTextView nSTextView = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSTextView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextViewHandle)) : Runtime.GetNSObject<NSTextView>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextViewHandle)));
			MarkDirty();
			__mt_TextView_var = nSTextView;
			return nSTextView;
		}
		[Export("setTextView:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextView_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextView_Handle, value.Handle);
			}
			MarkDirty();
			__mt_TextView_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WidthTracksTextView
	{
		[Export("widthTracksTextView")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWidthTracksTextViewHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWidthTracksTextViewHandle);
		}
		[Export("setWidthTracksTextView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetWidthTracksTextView_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetWidthTracksTextView_Handle, value);
			}
		}
	}

	[Obsoleted(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use NSTextContainer.FromSize instead.")]
	public NSTextContainer(CGSize size)
	{
		base.Handle = InitWithContainerSize(size);
	}

	internal NSTextContainer(CGSize size, bool isContainer)
	{
		if (isContainer)
		{
			base.Handle = InitWithContainerSize(size);
		}
		else
		{
			base.Handle = InitWithSize(size);
		}
	}

	[Mac(10, 11)]
	public static NSTextContainer FromSize(CGSize size)
	{
		return new NSTextContainer(size, isContainer: false);
	}

	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use NSTextContainer.FromSize instead.")]
	public static NSTextContainer FromContainerSize(CGSize containerSize)
	{
		return new NSTextContainer(containerSize, isContainer: true);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextContainer()
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
	public NSTextContainer(NSCoder coder)
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
	protected NSTextContainer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTextContainer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("containsPoint:")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ContainsPoint(CGPoint point)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGPoint(base.Handle, selContainsPoint_Handle, point);
		}
		return Messaging.bool_objc_msgSendSuper_CGPoint(base.SuperHandle, selContainsPoint_Handle, point);
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

	[Export("lineFragmentRectForProposedRect:atIndex:writingDirection:remainingRect:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetLineFragmentRect(CGRect proposedRect, nuint characterIndex, NSWritingDirection baseWritingDirection, ref CGRect remainingRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect_nuint_Int64_ref_CGRect(out retval, base.Handle, selLineFragmentRectForProposedRect_AtIndex_WritingDirection_RemainingRect_Handle, proposedRect, characterIndex, (long)baseWritingDirection, ref remainingRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect_nuint_Int64_ref_CGRect(out retval, base.SuperHandle, selLineFragmentRectForProposedRect_AtIndex_WritingDirection_RemainingRect_Handle, proposedRect, characterIndex, (long)baseWritingDirection, ref remainingRect);
		}
		return retval;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal IntPtr InitWithContainerSize(CGSize size)
	{
		NSApplication.EnsureUIThread();
		return Messaging.IntPtr_objc_msgSend_CGSize(base.Handle, selInitWithContainerSize_Handle, size);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal IntPtr InitWithSize(CGSize size)
	{
		NSApplication.EnsureUIThread();
		return Messaging.IntPtr_objc_msgSend_CGSize(base.Handle, selInitWithSize_Handle, size);
	}

	[Export("replaceLayoutManager:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplaceLayoutManager(NSLayoutManager newLayoutManager)
	{
		NSApplication.EnsureUIThread();
		if (newLayoutManager == null)
		{
			throw new ArgumentNullException("newLayoutManager");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReplaceLayoutManager_Handle, newLayoutManager.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReplaceLayoutManager_Handle, newLayoutManager.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_TextView_var = null;
		}
	}
}

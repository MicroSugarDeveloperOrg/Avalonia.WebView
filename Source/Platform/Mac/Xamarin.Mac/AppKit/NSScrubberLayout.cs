using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSScrubberLayout", true)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
public class NSScrubberLayout : NSObject, INSCoding, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutomaticallyMirrorsInRightToLeftLayout = "automaticallyMirrorsInRightToLeftLayout";

	private static readonly IntPtr selAutomaticallyMirrorsInRightToLeftLayoutHandle = Selector.GetHandle("automaticallyMirrorsInRightToLeftLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateLayout = "invalidateLayout";

	private static readonly IntPtr selInvalidateLayoutHandle = Selector.GetHandle("invalidateLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutAttributesClass = "layoutAttributesClass";

	private static readonly IntPtr selLayoutAttributesClassHandle = Selector.GetHandle("layoutAttributesClass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutAttributesForItemAtIndex_ = "layoutAttributesForItemAtIndex:";

	private static readonly IntPtr selLayoutAttributesForItemAtIndex_Handle = Selector.GetHandle("layoutAttributesForItemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutAttributesForItemsInRect_ = "layoutAttributesForItemsInRect:";

	private static readonly IntPtr selLayoutAttributesForItemsInRect_Handle = Selector.GetHandle("layoutAttributesForItemsInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareLayout = "prepareLayout";

	private static readonly IntPtr selPrepareLayoutHandle = Selector.GetHandle("prepareLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrubber = "scrubber";

	private static readonly IntPtr selScrubberHandle = Selector.GetHandle("scrubber");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrubberContentSize = "scrubberContentSize";

	private static readonly IntPtr selScrubberContentSizeHandle = Selector.GetHandle("scrubberContentSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldInvalidateLayoutForChangeFromVisibleRect_ToVisibleRect_ = "shouldInvalidateLayoutForChangeFromVisibleRect:toVisibleRect:";

	private static readonly IntPtr selShouldInvalidateLayoutForChangeFromVisibleRect_ToVisibleRect_Handle = Selector.GetHandle("shouldInvalidateLayoutForChangeFromVisibleRect:toVisibleRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldInvalidateLayoutForHighlightChange = "shouldInvalidateLayoutForHighlightChange";

	private static readonly IntPtr selShouldInvalidateLayoutForHighlightChangeHandle = Selector.GetHandle("shouldInvalidateLayoutForHighlightChange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldInvalidateLayoutForSelectionChange = "shouldInvalidateLayoutForSelectionChange";

	private static readonly IntPtr selShouldInvalidateLayoutForSelectionChangeHandle = Selector.GetHandle("shouldInvalidateLayoutForSelectionChange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVisibleRect = "visibleRect";

	private static readonly IntPtr selVisibleRectHandle = Selector.GetHandle("visibleRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSScrubberLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Scrubber_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutomaticallyMirrorsInRightToLeftLayout
	{
		[Export("automaticallyMirrorsInRightToLeftLayout")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutomaticallyMirrorsInRightToLeftLayoutHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutomaticallyMirrorsInRightToLeftLayoutHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Class LayoutAttributesClass
	{
		[Export("layoutAttributesClass")]
		get
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = Messaging.IntPtr_objc_msgSend(class_ptr, selLayoutAttributesClassHandle);
			return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSScrubber? Scrubber
	{
		[Export("scrubber", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSScrubber nSScrubber = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSScrubber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selScrubberHandle)) : Runtime.GetNSObject<NSScrubber>(Messaging.IntPtr_objc_msgSend(base.Handle, selScrubberHandle)));
			MarkDirty();
			__mt_Scrubber_var = nSScrubber;
			return nSScrubber;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize ScrubberContentSize
	{
		[Export("scrubberContentSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selScrubberContentSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selScrubberContentSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect VisibleRect
	{
		[Export("visibleRect")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selVisibleRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selVisibleRectHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSScrubberLayout()
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
	public NSScrubberLayout(NSCoder coder)
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
	protected NSScrubberLayout(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSScrubberLayout(IntPtr handle)
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

	[Export("invalidateLayout")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Overriding this method requires a call to the overriden method.")]
	[RequiresSuper]
	public virtual void InvalidateLayout()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateLayoutHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateLayoutHandle);
		}
	}

	[Export("layoutAttributesForItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSScrubberLayoutAttributes LayoutAttributesForItem(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSScrubberLayoutAttributes>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selLayoutAttributesForItemAtIndex_Handle, index));
		}
		return Runtime.GetNSObject<NSScrubberLayoutAttributes>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selLayoutAttributesForItemAtIndex_Handle, index));
	}

	[Export("layoutAttributesForItemsInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet<NSScrubberLayoutAttributes> LayoutAttributesForItems(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSSet<NSScrubberLayoutAttributes>>(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selLayoutAttributesForItemsInRect_Handle, rect));
		}
		return Runtime.GetNSObject<NSSet<NSScrubberLayoutAttributes>>(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selLayoutAttributesForItemsInRect_Handle, rect));
	}

	[Export("prepareLayout")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PrepareLayout()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPrepareLayoutHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPrepareLayoutHandle);
		}
	}

	[Export("shouldInvalidateLayoutForChangeFromVisibleRect:toVisibleRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldInvalidateLayoutForChangeFromVisibleRect(CGRect fromVisibleRect, CGRect toVisibleRect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGRect_CGRect(base.Handle, selShouldInvalidateLayoutForChangeFromVisibleRect_ToVisibleRect_Handle, fromVisibleRect, toVisibleRect);
		}
		return Messaging.bool_objc_msgSendSuper_CGRect_CGRect(base.SuperHandle, selShouldInvalidateLayoutForChangeFromVisibleRect_ToVisibleRect_Handle, fromVisibleRect, toVisibleRect);
	}

	[Export("shouldInvalidateLayoutForHighlightChange")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldInvalidateLayoutForHighlightChange()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selShouldInvalidateLayoutForHighlightChangeHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldInvalidateLayoutForHighlightChangeHandle);
	}

	[Export("shouldInvalidateLayoutForSelectionChange")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldInvalidateLayoutForSelectionChange()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selShouldInvalidateLayoutForSelectionChangeHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShouldInvalidateLayoutForSelectionChangeHandle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Scrubber_var = null;
		}
	}
}

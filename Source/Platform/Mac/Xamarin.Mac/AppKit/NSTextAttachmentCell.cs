using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSTextAttachmentCell", true)]
public class NSTextAttachmentCell : NSCell
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttachment = "attachment";

	private static readonly IntPtr selAttachmentHandle = Selector.GetHandle("attachment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellBaselineOffset = "cellBaselineOffset";

	private static readonly IntPtr selCellBaselineOffsetHandle = Selector.GetHandle("cellBaselineOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellFrameForTextContainer_ProposedLineFragment_GlyphPosition_CharacterIndex_ = "cellFrameForTextContainer:proposedLineFragment:glyphPosition:characterIndex:";

	private static readonly IntPtr selCellFrameForTextContainer_ProposedLineFragment_GlyphPosition_CharacterIndex_Handle = Selector.GetHandle("cellFrameForTextContainer:proposedLineFragment:glyphPosition:characterIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCellSize = "cellSize";

	private static readonly IntPtr selCellSizeHandle = Selector.GetHandle("cellSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawWithFrame_InView_CharacterIndex_ = "drawWithFrame:inView:characterIndex:";

	private static readonly IntPtr selDrawWithFrame_InView_CharacterIndex_Handle = Selector.GetHandle("drawWithFrame:inView:characterIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawWithFrame_InView_CharacterIndex_LayoutManager_ = "drawWithFrame:inView:characterIndex:layoutManager:";

	private static readonly IntPtr selDrawWithFrame_InView_CharacterIndex_LayoutManager_Handle = Selector.GetHandle("drawWithFrame:inView:characterIndex:layoutManager:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHighlight_WithFrame_InView_ = "highlight:withFrame:inView:";

	private static readonly IntPtr selHighlight_WithFrame_InView_Handle = Selector.GetHandle("highlight:withFrame:inView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitImageCell_ = "initImageCell:";

	private static readonly IntPtr selInitImageCell_Handle = Selector.GetHandle("initImageCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitTextCell_ = "initTextCell:";

	private static readonly IntPtr selInitTextCell_Handle = Selector.GetHandle("initTextCell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttachment_ = "setAttachment:";

	private static readonly IntPtr selSetAttachment_Handle = Selector.GetHandle("setAttachment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrackMouse_InRect_OfView_AtCharacterIndex_UntilMouseUp_ = "trackMouse:inRect:ofView:atCharacterIndex:untilMouseUp:";

	private static readonly IntPtr selTrackMouse_InRect_OfView_AtCharacterIndex_UntilMouseUp_Handle = Selector.GetHandle("trackMouse:inRect:ofView:atCharacterIndex:untilMouseUp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrackMouse_InRect_OfView_UntilMouseUp_ = "trackMouse:inRect:ofView:untilMouseUp:";

	private static readonly IntPtr selTrackMouse_InRect_OfView_UntilMouseUp_Handle = Selector.GetHandle("trackMouse:inRect:ofView:untilMouseUp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWantsToTrackMouse = "wantsToTrackMouse";

	private static readonly IntPtr selWantsToTrackMouseHandle = Selector.GetHandle("wantsToTrackMouse");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWantsToTrackMouseForEvent_InRect_OfView_AtCharacterIndex_ = "wantsToTrackMouseForEvent:inRect:ofView:atCharacterIndex:";

	private static readonly IntPtr selWantsToTrackMouseForEvent_InRect_OfView_AtCharacterIndex_Handle = Selector.GetHandle("wantsToTrackMouseForEvent:inRect:ofView:atCharacterIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSTextAttachmentCell");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextAttachment? Attachment
	{
		[Export("attachment")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSTextAttachment>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttachmentHandle));
			}
			return Runtime.GetNSObject<NSTextAttachment>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttachmentHandle));
		}
		[Export("setAttachment:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttachment_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttachment_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint CellBaselineOffset
	{
		[Export("cellBaselineOffset")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selCellBaselineOffsetHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selCellBaselineOffsetHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CGSize CellSize
	{
		[Export("cellSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selCellSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selCellSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSTextAttachmentCell()
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
	public NSTextAttachmentCell(NSCoder coder)
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
	protected NSTextAttachmentCell(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTextAttachmentCell(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initImageCell:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTextAttachmentCell(NSImage image)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitImageCell_Handle, image.Handle), "initImageCell:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitImageCell_Handle, image.Handle), "initImageCell:");
		}
	}

	[Export("initTextCell:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTextAttachmentCell(string aString)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitTextCell_Handle, arg), "initTextCell:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitTextCell_Handle, arg), "initTextCell:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("cellFrameForTextContainer:proposedLineFragment:glyphPosition:characterIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect CellFrameForTextContainer(NSTextContainer textContainer, CGRect lineFrag, CGPoint position, nuint charIndex)
	{
		NSApplication.EnsureUIThread();
		if (textContainer == null)
		{
			throw new ArgumentNullException("textContainer");
		}
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr_CGRect_CGPoint_nuint(out retval, base.Handle, selCellFrameForTextContainer_ProposedLineFragment_GlyphPosition_CharacterIndex_Handle, textContainer.Handle, lineFrag, position, charIndex);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_CGRect_CGPoint_nuint(out retval, base.SuperHandle, selCellFrameForTextContainer_ProposedLineFragment_GlyphPosition_CharacterIndex_Handle, textContainer.Handle, lineFrag, position, charIndex);
		}
		return retval;
	}

	[Export("drawWithFrame:inView:characterIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawWithFrame(CGRect cellFrame, NSView controlView, nuint charIndex)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_nuint(base.Handle, selDrawWithFrame_InView_CharacterIndex_Handle, cellFrame, controlView.Handle, charIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_nuint(base.SuperHandle, selDrawWithFrame_InView_CharacterIndex_Handle, cellFrame, controlView.Handle, charIndex);
		}
	}

	[Export("drawWithFrame:inView:characterIndex:layoutManager:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawWithFrame(CGRect cellFrame, NSView controlView, nuint charIndex, NSLayoutManager layoutManager)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (layoutManager == null)
		{
			throw new ArgumentNullException("layoutManager");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_nuint_IntPtr(base.Handle, selDrawWithFrame_InView_CharacterIndex_LayoutManager_Handle, cellFrame, controlView.Handle, charIndex, layoutManager.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_nuint_IntPtr(base.SuperHandle, selDrawWithFrame_InView_CharacterIndex_LayoutManager_Handle, cellFrame, controlView.Handle, charIndex, layoutManager.Handle);
		}
	}

	[Export("highlight:withFrame:inView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void Highlight(bool highlight, CGRect cellFrame, NSView controlView)
	{
		NSApplication.EnsureUIThread();
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_CGRect_IntPtr(base.Handle, selHighlight_WithFrame_InView_Handle, highlight, cellFrame, controlView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_CGRect_IntPtr(base.SuperHandle, selHighlight_WithFrame_InView_Handle, highlight, cellFrame, controlView.Handle);
		}
	}

	[Export("trackMouse:inRect:ofView:untilMouseUp:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual bool TrackMouse(NSEvent theEvent, CGRect cellFrame, NSView controlView, bool untilMouseUp)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_CGRect_IntPtr_bool(base.Handle, selTrackMouse_InRect_OfView_UntilMouseUp_Handle, theEvent.Handle, cellFrame, controlView.Handle, untilMouseUp);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_CGRect_IntPtr_bool(base.SuperHandle, selTrackMouse_InRect_OfView_UntilMouseUp_Handle, theEvent.Handle, cellFrame, controlView.Handle, untilMouseUp);
	}

	[Export("trackMouse:inRect:ofView:atCharacterIndex:untilMouseUp:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool TrackMouse(NSEvent theEvent, CGRect cellFrame, NSView controlView, nuint charIndex, bool untilMouseUp)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_CGRect_IntPtr_nuint_bool(base.Handle, selTrackMouse_InRect_OfView_AtCharacterIndex_UntilMouseUp_Handle, theEvent.Handle, cellFrame, controlView.Handle, charIndex, untilMouseUp);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_CGRect_IntPtr_nuint_bool(base.SuperHandle, selTrackMouse_InRect_OfView_AtCharacterIndex_UntilMouseUp_Handle, theEvent.Handle, cellFrame, controlView.Handle, charIndex, untilMouseUp);
	}

	[Export("wantsToTrackMouse")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WantsToTrackMouse()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selWantsToTrackMouseHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWantsToTrackMouseHandle);
	}

	[Export("wantsToTrackMouseForEvent:inRect:ofView:atCharacterIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WantsToTrackMouse(NSEvent theEvent, CGRect cellFrame, NSView controlView, nuint charIndex)
	{
		NSApplication.EnsureUIThread();
		if (theEvent == null)
		{
			throw new ArgumentNullException("theEvent");
		}
		if (controlView == null)
		{
			throw new ArgumentNullException("controlView");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_CGRect_IntPtr_nuint(base.Handle, selWantsToTrackMouseForEvent_InRect_OfView_AtCharacterIndex_Handle, theEvent.Handle, cellFrame, controlView.Handle, charIndex);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_CGRect_IntPtr_nuint(base.SuperHandle, selWantsToTrackMouseForEvent_InRect_OfView_AtCharacterIndex_Handle, theEvent.Handle, cellFrame, controlView.Handle, charIndex);
	}
}

using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSDraggingSession", true)]
public class NSDraggingSession : NSObject
{
	private static readonly IntPtr selDraggingFormationHandle = Selector.GetHandle("draggingFormation");

	private static readonly IntPtr selSetDraggingFormation_Handle = Selector.GetHandle("setDraggingFormation:");

	private static readonly IntPtr selAnimatesToStartingPositionsOnCancelOrFailHandle = Selector.GetHandle("animatesToStartingPositionsOnCancelOrFail");

	private static readonly IntPtr selSetAnimatesToStartingPositionsOnCancelOrFail_Handle = Selector.GetHandle("setAnimatesToStartingPositionsOnCancelOrFail:");

	private static readonly IntPtr selDraggingLeaderIndexHandle = Selector.GetHandle("draggingLeaderIndex");

	private static readonly IntPtr selSetDraggingLeaderIndex_Handle = Selector.GetHandle("setDraggingLeaderIndex:");

	private static readonly IntPtr selDraggingPasteboardHandle = Selector.GetHandle("draggingPasteboard");

	private static readonly IntPtr selDraggingSequenceNumberHandle = Selector.GetHandle("draggingSequenceNumber");

	private static readonly IntPtr selDraggingLocationHandle = Selector.GetHandle("draggingLocation");

	private static readonly IntPtr selEnumerateDraggingItemsWithOptionsForViewClassesSearchOptionsUsingBlock_Handle = Selector.GetHandle("enumerateDraggingItemsWithOptions:forView:classes:searchOptions:usingBlock:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSDraggingSession");

	private object __mt_DraggingPasteboard_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSDraggingFormation DraggingFormation
	{
		[Export("draggingFormation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSDraggingFormation)Messaging.Int64_objc_msgSend(base.Handle, selDraggingFormationHandle);
			}
			return (NSDraggingFormation)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDraggingFormationHandle);
		}
		[Export("setDraggingFormation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDraggingFormation_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDraggingFormation_Handle, (long)value);
			}
		}
	}

	public virtual bool AnimatesToStartingPositionsOnCancelOrFail
	{
		[Export("animatesToStartingPositionsOnCancelOrFail")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAnimatesToStartingPositionsOnCancelOrFailHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAnimatesToStartingPositionsOnCancelOrFailHandle);
		}
		[Export("setAnimatesToStartingPositionsOnCancelOrFail:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAnimatesToStartingPositionsOnCancelOrFail_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAnimatesToStartingPositionsOnCancelOrFail_Handle, value);
			}
		}
	}

	public virtual long DraggingLeaderIndex
	{
		[Export("draggingLeaderIndex")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selDraggingLeaderIndexHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDraggingLeaderIndexHandle);
		}
		[Export("setDraggingLeaderIndex:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDraggingLeaderIndex_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDraggingLeaderIndex_Handle, value);
			}
		}
	}

	public virtual NSPasteboard DraggingPasteboard
	{
		[Export("draggingPasteboard")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSPasteboard)(__mt_DraggingPasteboard_var = ((!IsDirectBinding) ? ((NSPasteboard)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDraggingPasteboardHandle))) : ((NSPasteboard)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDraggingPasteboardHandle)))));
		}
	}

	public virtual long DraggingSequenceNumber
	{
		[Export("draggingSequenceNumber")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selDraggingSequenceNumberHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDraggingSequenceNumberHandle);
		}
	}

	public virtual CGPoint DraggingLocation
	{
		[Export("draggingLocation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selDraggingLocationHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selDraggingLocationHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSDraggingSession(NSCoder coder)
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
	public NSDraggingSession(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSDraggingSession(IntPtr handle)
		: base(handle)
	{
	}

	[Export("enumerateDraggingItemsWithOptions:forView:classes:searchOptions:usingBlock:")]
	public unsafe virtual void EnumerateDraggingItems(NSDraggingItemEnumerationOptions enumOpts, NSView view, NSPasteboardReading[] classArray, NSDictionary searchOptions, NSDraggingEnumerator enumerator)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (classArray == null)
		{
			throw new ArgumentNullException("classArray");
		}
		if (searchOptions == null)
		{
			throw new ArgumentNullException("searchOptions");
		}
		if (enumerator == null)
		{
			throw new ArgumentNullException("enumerator");
		}
		NSArray nSArray = NSArray.FromNSObjects(classArray);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSDraggingEnumerator.Handler, enumerator);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEnumerateDraggingItemsWithOptionsForViewClassesSearchOptionsUsingBlock_Handle, (ulong)enumOpts, view.Handle, nSArray.Handle, searchOptions.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEnumerateDraggingItemsWithOptionsForViewClassesSearchOptionsUsingBlock_Handle, (ulong)enumOpts, view.Handle, nSArray.Handle, searchOptions.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		ptr->CleanupBlock();
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_DraggingPasteboard_var = null;
		}
	}
}

using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSDraggingSession", true)]
public class NSDraggingSession : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimatesToStartingPositionsOnCancelOrFail = "animatesToStartingPositionsOnCancelOrFail";

	private static readonly IntPtr selAnimatesToStartingPositionsOnCancelOrFailHandle = Selector.GetHandle("animatesToStartingPositionsOnCancelOrFail");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingFormation = "draggingFormation";

	private static readonly IntPtr selDraggingFormationHandle = Selector.GetHandle("draggingFormation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingLeaderIndex = "draggingLeaderIndex";

	private static readonly IntPtr selDraggingLeaderIndexHandle = Selector.GetHandle("draggingLeaderIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingLocation = "draggingLocation";

	private static readonly IntPtr selDraggingLocationHandle = Selector.GetHandle("draggingLocation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingPasteboard = "draggingPasteboard";

	private static readonly IntPtr selDraggingPasteboardHandle = Selector.GetHandle("draggingPasteboard");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDraggingSequenceNumber = "draggingSequenceNumber";

	private static readonly IntPtr selDraggingSequenceNumberHandle = Selector.GetHandle("draggingSequenceNumber");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateDraggingItemsWithOptions_ForView_Classes_SearchOptions_UsingBlock_ = "enumerateDraggingItemsWithOptions:forView:classes:searchOptions:usingBlock:";

	private static readonly IntPtr selEnumerateDraggingItemsWithOptions_ForView_Classes_SearchOptions_UsingBlock_Handle = Selector.GetHandle("enumerateDraggingItemsWithOptions:forView:classes:searchOptions:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnimatesToStartingPositionsOnCancelOrFail_ = "setAnimatesToStartingPositionsOnCancelOrFail:";

	private static readonly IntPtr selSetAnimatesToStartingPositionsOnCancelOrFail_Handle = Selector.GetHandle("setAnimatesToStartingPositionsOnCancelOrFail:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDraggingFormation_ = "setDraggingFormation:";

	private static readonly IntPtr selSetDraggingFormation_Handle = Selector.GetHandle("setDraggingFormation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDraggingLeaderIndex_ = "setDraggingLeaderIndex:";

	private static readonly IntPtr selSetDraggingLeaderIndex_Handle = Selector.GetHandle("setDraggingLeaderIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSDraggingSession");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AnimatesToStartingPositionsOnCancelOrFail
	{
		[Export("animatesToStartingPositionsOnCancelOrFail")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAnimatesToStartingPositionsOnCancelOrFailHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAnimatesToStartingPositionsOnCancelOrFailHandle);
		}
		[Export("setAnimatesToStartingPositionsOnCancelOrFail:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAnimatesToStartingPositionsOnCancelOrFail_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAnimatesToStartingPositionsOnCancelOrFail_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDraggingFormation DraggingFormation
	{
		[Export("draggingFormation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSDraggingFormation)Messaging.Int64_objc_msgSend(base.Handle, selDraggingFormationHandle);
			}
			return (NSDraggingFormation)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDraggingFormationHandle);
		}
		[Export("setDraggingFormation:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDraggingFormation_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDraggingFormation_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint DraggingLeaderIndex
	{
		[Export("draggingLeaderIndex")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selDraggingLeaderIndexHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selDraggingLeaderIndexHandle);
		}
		[Export("setDraggingLeaderIndex:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetDraggingLeaderIndex_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetDraggingLeaderIndex_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint DraggingLocation
	{
		[Export("draggingLocation")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selDraggingLocationHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selDraggingLocationHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPasteboard DraggingPasteboard
	{
		[Export("draggingPasteboard")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPasteboard>(Messaging.IntPtr_objc_msgSend(base.Handle, selDraggingPasteboardHandle));
			}
			return Runtime.GetNSObject<NSPasteboard>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDraggingPasteboardHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint DraggingSequenceNumber
	{
		[Export("draggingSequenceNumber")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selDraggingSequenceNumberHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selDraggingSequenceNumberHandle);
		}
	}

	public void EnumerateDraggingItems(NSDraggingItemEnumerationOptions enumOpts, NSView view, NSPasteboardReading[] classArray, NSDictionary searchOptions, NSDraggingEnumerator enumerator)
	{
		NSArray nSArray = NSArray.FromNSObjects(classArray);
		EnumerateDraggingItems(enumOpts, view, nSArray.Handle, searchOptions, enumerator);
		nSArray.Dispose();
	}

	public void EnumerateDraggingItems(NSDraggingItemEnumerationOptions enumOpts, NSView view, NSArray classArray, NSDictionary searchOptions, NSDraggingEnumerator enumerator)
	{
		EnumerateDraggingItems(enumOpts, view, classArray.Handle, searchOptions, enumerator);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSDraggingSession(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSDraggingSession(IntPtr handle)
		: base(handle)
	{
	}

	[Export("enumerateDraggingItemsWithOptions:forView:classes:searchOptions:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal unsafe virtual void EnumerateDraggingItems(NSDraggingItemEnumerationOptions enumOpts, NSView view, IntPtr classArray, NSDictionary? searchOptions, [BlockProxy(typeof(Trampolines.NIDNSDraggingEnumerator))] NSDraggingEnumerator enumerator)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (enumerator == null)
		{
			throw new ArgumentNullException("enumerator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSDraggingEnumerator.Handler, enumerator);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selEnumerateDraggingItemsWithOptions_ForView_Classes_SearchOptions_UsingBlock_Handle, (ulong)enumOpts, view.Handle, classArray, searchOptions?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selEnumerateDraggingItemsWithOptions_ForView_Classes_SearchOptions_UsingBlock_Handle, (ulong)enumOpts, view.Handle, classArray, searchOptions?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}
}

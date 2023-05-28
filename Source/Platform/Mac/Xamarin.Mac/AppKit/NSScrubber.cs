using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSScrubber", true)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
public class NSScrubber : NSView
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundColor = "backgroundColor";

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundView = "backgroundView";

	private static readonly IntPtr selBackgroundViewHandle = Selector.GetHandle("backgroundView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataSource = "dataSource";

	private static readonly IntPtr selDataSourceHandle = Selector.GetHandle("dataSource");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFloatsSelectionViews = "floatsSelectionViews";

	private static readonly IntPtr selFloatsSelectionViewsHandle = Selector.GetHandle("floatsSelectionViews");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHighlightedIndex = "highlightedIndex";

	private static readonly IntPtr selHighlightedIndexHandle = Selector.GetHandle("highlightedIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertItemsAtIndexes_ = "insertItemsAtIndexes:";

	private static readonly IntPtr selInsertItemsAtIndexes_Handle = Selector.GetHandle("insertItemsAtIndexes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsContinuous = "isContinuous";

	private static readonly IntPtr selIsContinuousHandle = Selector.GetHandle("isContinuous");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemAlignment = "itemAlignment";

	private static readonly IntPtr selItemAlignmentHandle = Selector.GetHandle("itemAlignment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemViewForItemAtIndex_ = "itemViewForItemAtIndex:";

	private static readonly IntPtr selItemViewForItemAtIndex_Handle = Selector.GetHandle("itemViewForItemAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeItemWithIdentifier_Owner_ = "makeItemWithIdentifier:owner:";

	private static readonly IntPtr selMakeItemWithIdentifier_Owner_Handle = Selector.GetHandle("makeItemWithIdentifier:owner:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMode = "mode";

	private static readonly IntPtr selModeHandle = Selector.GetHandle("mode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMoveItemAtIndex_ToIndex_ = "moveItemAtIndex:toIndex:";

	private static readonly IntPtr selMoveItemAtIndex_ToIndex_Handle = Selector.GetHandle("moveItemAtIndex:toIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfItems = "numberOfItems";

	private static readonly IntPtr selNumberOfItemsHandle = Selector.GetHandle("numberOfItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPerformSequentialBatchUpdates_ = "performSequentialBatchUpdates:";

	private static readonly IntPtr selPerformSequentialBatchUpdates_Handle = Selector.GetHandle("performSequentialBatchUpdates:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterClass_ForItemIdentifier_ = "registerClass:forItemIdentifier:";

	private static readonly IntPtr selRegisterClass_ForItemIdentifier_Handle = Selector.GetHandle("registerClass:forItemIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterNib_ForItemIdentifier_ = "registerNib:forItemIdentifier:";

	private static readonly IntPtr selRegisterNib_ForItemIdentifier_Handle = Selector.GetHandle("registerNib:forItemIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadData = "reloadData";

	private static readonly IntPtr selReloadDataHandle = Selector.GetHandle("reloadData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadItemsAtIndexes_ = "reloadItemsAtIndexes:";

	private static readonly IntPtr selReloadItemsAtIndexes_Handle = Selector.GetHandle("reloadItemsAtIndexes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveItemsAtIndexes_ = "removeItemsAtIndexes:";

	private static readonly IntPtr selRemoveItemsAtIndexes_Handle = Selector.GetHandle("removeItemsAtIndexes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollItemAtIndex_ToAlignment_ = "scrollItemAtIndex:toAlignment:";

	private static readonly IntPtr selScrollItemAtIndex_ToAlignment_Handle = Selector.GetHandle("scrollItemAtIndex:toAlignment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrubberLayout = "scrubberLayout";

	private static readonly IntPtr selScrubberLayoutHandle = Selector.GetHandle("scrubberLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedIndex = "selectedIndex";

	private static readonly IntPtr selSelectedIndexHandle = Selector.GetHandle("selectedIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionBackgroundStyle = "selectionBackgroundStyle";

	private static readonly IntPtr selSelectionBackgroundStyleHandle = Selector.GetHandle("selectionBackgroundStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectionOverlayStyle = "selectionOverlayStyle";

	private static readonly IntPtr selSelectionOverlayStyleHandle = Selector.GetHandle("selectionOverlayStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundColor_ = "setBackgroundColor:";

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundView_ = "setBackgroundView:";

	private static readonly IntPtr selSetBackgroundView_Handle = Selector.GetHandle("setBackgroundView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContinuous_ = "setContinuous:";

	private static readonly IntPtr selSetContinuous_Handle = Selector.GetHandle("setContinuous:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDataSource_ = "setDataSource:";

	private static readonly IntPtr selSetDataSource_Handle = Selector.GetHandle("setDataSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloatsSelectionViews_ = "setFloatsSelectionViews:";

	private static readonly IntPtr selSetFloatsSelectionViews_Handle = Selector.GetHandle("setFloatsSelectionViews:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetItemAlignment_ = "setItemAlignment:";

	private static readonly IntPtr selSetItemAlignment_Handle = Selector.GetHandle("setItemAlignment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMode_ = "setMode:";

	private static readonly IntPtr selSetMode_Handle = Selector.GetHandle("setMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScrubberLayout_ = "setScrubberLayout:";

	private static readonly IntPtr selSetScrubberLayout_Handle = Selector.GetHandle("setScrubberLayout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedIndex_ = "setSelectedIndex:";

	private static readonly IntPtr selSetSelectedIndex_Handle = Selector.GetHandle("setSelectedIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectionBackgroundStyle_ = "setSelectionBackgroundStyle:";

	private static readonly IntPtr selSetSelectionBackgroundStyle_Handle = Selector.GetHandle("setSelectionBackgroundStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectionOverlayStyle_ = "setSelectionOverlayStyle:";

	private static readonly IntPtr selSetSelectionOverlayStyle_Handle = Selector.GetHandle("setSelectionOverlayStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsAdditionalContentIndicators_ = "setShowsAdditionalContentIndicators:";

	private static readonly IntPtr selSetShowsAdditionalContentIndicators_Handle = Selector.GetHandle("setShowsAdditionalContentIndicators:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShowsArrowButtons_ = "setShowsArrowButtons:";

	private static readonly IntPtr selSetShowsArrowButtons_Handle = Selector.GetHandle("setShowsArrowButtons:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsAdditionalContentIndicators = "showsAdditionalContentIndicators";

	private static readonly IntPtr selShowsAdditionalContentIndicatorsHandle = Selector.GetHandle("showsAdditionalContentIndicators");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowsArrowButtons = "showsArrowButtons";

	private static readonly IntPtr selShowsArrowButtonsHandle = Selector.GetHandle("showsArrowButtons");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSScrubber");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_DataSource_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Delegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColor? BackgroundColor
	{
		[Export("backgroundColor", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle));
			}
			return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle));
		}
		[Export("setBackgroundColor:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView? BackgroundView
	{
		[Export("backgroundView", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundViewHandle));
		}
		[Export("setBackgroundView:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundView_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Continuous
	{
		[Export("isContinuous")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsContinuousHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsContinuousHandle);
		}
		[Export("setContinuous:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetContinuous_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetContinuous_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSScrubberDataSource? DataSource
	{
		[Export("dataSource", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			INSScrubberDataSource iNSScrubberDataSource = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<INSScrubberDataSource>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataSourceHandle), owns: false) : Runtime.GetINativeObject<INSScrubberDataSource>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataSourceHandle), owns: false));
			MarkDirty();
			__mt_DataSource_var = iNSScrubberDataSource;
			return iNSScrubberDataSource;
		}
		[Export("setDataSource:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDataSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDataSource_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_DataSource_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSScrubberDelegate? Delegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			INSScrubberDelegate iNSScrubberDelegate = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<INSScrubberDelegate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle), owns: false) : Runtime.GetINativeObject<INSScrubberDelegate>(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle), owns: false));
			MarkDirty();
			__mt_Delegate_var = iNSScrubberDelegate;
			return iNSScrubberDelegate;
		}
		[Export("setDelegate:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_Delegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool FloatsSelectionViews
	{
		[Export("floatsSelectionViews")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selFloatsSelectionViewsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selFloatsSelectionViewsHandle);
		}
		[Export("setFloatsSelectionViews:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetFloatsSelectionViews_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetFloatsSelectionViews_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint HighlightedIndex
	{
		[Export("highlightedIndex")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selHighlightedIndexHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selHighlightedIndexHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSScrubberAlignment ItemAlignment
	{
		[Export("itemAlignment", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSScrubberAlignment)Messaging.Int64_objc_msgSend(base.Handle, selItemAlignmentHandle);
			}
			return (NSScrubberAlignment)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selItemAlignmentHandle);
		}
		[Export("setItemAlignment:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetItemAlignment_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetItemAlignment_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSScrubberMode Mode
	{
		[Export("mode", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSScrubberMode)Messaging.Int64_objc_msgSend(base.Handle, selModeHandle);
			}
			return (NSScrubberMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selModeHandle);
		}
		[Export("setMode:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint NumberOfItems
	{
		[Export("numberOfItems")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfItemsHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfItemsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSScrubberLayout ScrubberLayout
	{
		[Export("scrubberLayout", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSScrubberLayout>(Messaging.IntPtr_objc_msgSend(base.Handle, selScrubberLayoutHandle));
			}
			return Runtime.GetNSObject<NSScrubberLayout>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selScrubberLayoutHandle));
		}
		[Export("setScrubberLayout:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetScrubberLayout_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetScrubberLayout_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint SelectedIndex
	{
		[Export("selectedIndex")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selSelectedIndexHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSelectedIndexHandle);
		}
		[Export("setSelectedIndex:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetSelectedIndex_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetSelectedIndex_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSScrubberSelectionStyle? SelectionBackgroundStyle
	{
		[Export("selectionBackgroundStyle", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSScrubberSelectionStyle>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectionBackgroundStyleHandle));
			}
			return Runtime.GetNSObject<NSScrubberSelectionStyle>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectionBackgroundStyleHandle));
		}
		[Export("setSelectionBackgroundStyle:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSelectionBackgroundStyle_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectionBackgroundStyle_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSScrubberSelectionStyle? SelectionOverlayStyle
	{
		[Export("selectionOverlayStyle", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSScrubberSelectionStyle>(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectionOverlayStyleHandle));
			}
			return Runtime.GetNSObject<NSScrubberSelectionStyle>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectionOverlayStyleHandle));
		}
		[Export("setSelectionOverlayStyle:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSelectionOverlayStyle_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectionOverlayStyle_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsAdditionalContentIndicators
	{
		[Export("showsAdditionalContentIndicators")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsAdditionalContentIndicatorsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsAdditionalContentIndicatorsHandle);
		}
		[Export("setShowsAdditionalContentIndicators:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsAdditionalContentIndicators_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsAdditionalContentIndicators_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShowsArrowButtons
	{
		[Export("showsArrowButtons")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsArrowButtonsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsArrowButtonsHandle);
		}
		[Export("setShowsArrowButtons:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsArrowButtons_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsArrowButtons_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSScrubber()
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
	public NSScrubber(NSCoder coder)
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
	protected NSScrubber(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSScrubber(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSScrubber(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
	}

	[Export("itemViewForItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSScrubberItemView GetItemViewForItem(nint index)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSScrubberItemView>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selItemViewForItemAtIndex_Handle, index));
		}
		return Runtime.GetNSObject<NSScrubberItemView>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selItemViewForItemAtIndex_Handle, index));
	}

	[Export("insertItemsAtIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertItems(NSIndexSet indexes)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInsertItemsAtIndexes_Handle, indexes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInsertItemsAtIndexes_Handle, indexes.Handle);
		}
	}

	[Export("makeItemWithIdentifier:owner:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSScrubberItemView MakeItem(string itemIdentifier, NSObject? owner)
	{
		NSApplication.EnsureUIThread();
		if (itemIdentifier == null)
		{
			throw new ArgumentNullException("itemIdentifier");
		}
		IntPtr arg = NSString.CreateNative(itemIdentifier);
		NSScrubberItemView result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSScrubberItemView>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selMakeItemWithIdentifier_Owner_Handle, arg, owner?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject<NSScrubberItemView>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selMakeItemWithIdentifier_Owner_Handle, arg, owner?.Handle ?? IntPtr.Zero)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("moveItemAtIndex:toIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MoveItem(nint oldIndex, nint newIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_nint(base.Handle, selMoveItemAtIndex_ToIndex_Handle, oldIndex, newIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_nint(base.SuperHandle, selMoveItemAtIndex_ToIndex_Handle, oldIndex, newIndex);
		}
	}

	[Export("performSequentialBatchUpdates:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void PerformSequentialBatchUpdates([BlockProxy(typeof(Trampolines.NIDAction))] Action updateHandler)
	{
		NSApplication.EnsureUIThread();
		if (updateHandler == null)
		{
			throw new ArgumentNullException("updateHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, updateHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPerformSequentialBatchUpdates_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPerformSequentialBatchUpdates_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("registerClass:forItemIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RegisterClass(Class? itemViewClass, string itemIdentifier)
	{
		NSApplication.EnsureUIThread();
		if (itemIdentifier == null)
		{
			throw new ArgumentNullException("itemIdentifier");
		}
		IntPtr arg = NSString.CreateNative(itemIdentifier);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRegisterClass_ForItemIdentifier_Handle, itemViewClass?.Handle ?? IntPtr.Zero, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRegisterClass_ForItemIdentifier_Handle, itemViewClass?.Handle ?? IntPtr.Zero, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("registerNib:forItemIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RegisterNib(NSNib? nib, string itemIdentifier)
	{
		NSApplication.EnsureUIThread();
		if (itemIdentifier == null)
		{
			throw new ArgumentNullException("itemIdentifier");
		}
		IntPtr arg = NSString.CreateNative(itemIdentifier);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRegisterNib_ForItemIdentifier_Handle, nib?.Handle ?? IntPtr.Zero, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRegisterNib_ForItemIdentifier_Handle, nib?.Handle ?? IntPtr.Zero, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("reloadData")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadData()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReloadDataHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReloadDataHandle);
		}
	}

	[Export("reloadItemsAtIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReloadItems(NSIndexSet indexes)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReloadItemsAtIndexes_Handle, indexes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReloadItemsAtIndexes_Handle, indexes.Handle);
		}
	}

	[Export("removeItemsAtIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveItems(NSIndexSet indexes)
	{
		NSApplication.EnsureUIThread();
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveItemsAtIndexes_Handle, indexes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveItemsAtIndexes_Handle, indexes.Handle);
		}
	}

	[Export("scrollItemAtIndex:toAlignment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollItem(nint index, NSScrubberAlignment alignment)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_Int64(base.Handle, selScrollItemAtIndex_ToAlignment_Handle, index, (long)alignment);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_Int64(base.SuperHandle, selScrollItemAtIndex_ToAlignment_Handle, index, (long)alignment);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_DataSource_var = null;
			__mt_Delegate_var = null;
		}
	}
}

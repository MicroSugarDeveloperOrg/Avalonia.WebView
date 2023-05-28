using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public static class NSLayoutManager_NSTextViewSupport
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFirstTextView = "firstTextView";

	private static readonly IntPtr selFirstTextViewHandle = Selector.GetHandle("firstTextView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutManagerOwnsFirstResponderInWindow_ = "layoutManagerOwnsFirstResponderInWindow:";

	private static readonly IntPtr selLayoutManagerOwnsFirstResponderInWindow_Handle = Selector.GetHandle("layoutManagerOwnsFirstResponderInWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRulerAccessoryViewForTextView_ParagraphStyle_Ruler_Enabled_ = "rulerAccessoryViewForTextView:paragraphStyle:ruler:enabled:";

	private static readonly IntPtr selRulerAccessoryViewForTextView_ParagraphStyle_Ruler_Enabled_Handle = Selector.GetHandle("rulerAccessoryViewForTextView:paragraphStyle:ruler:enabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRulerMarkersForTextView_ParagraphStyle_Ruler_ = "rulerMarkersForTextView:paragraphStyle:ruler:";

	private static readonly IntPtr selRulerMarkersForTextView_ParagraphStyle_Ruler_Handle = Selector.GetHandle("rulerMarkersForTextView:paragraphStyle:ruler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextViewForBeginningOfSelection = "textViewForBeginningOfSelection";

	private static readonly IntPtr selTextViewForBeginningOfSelectionHandle = Selector.GetHandle("textViewForBeginningOfSelection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSLayoutManager");

	[Export("firstTextView")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextView? GetFirstTextView(this NSLayoutManager This)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSTextView>(Messaging.IntPtr_objc_msgSend(This.Handle, selFirstTextViewHandle));
	}

	[Export("rulerAccessoryViewForTextView:paragraphStyle:ruler:enabled:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSView? GetRulerAccessoryView(this NSLayoutManager This, NSTextView textView, NSParagraphStyle paragraphStyle, NSRulerView ruler, bool enabled)
	{
		NSApplication.EnsureUIThread();
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (paragraphStyle == null)
		{
			throw new ArgumentNullException("paragraphStyle");
		}
		if (ruler == null)
		{
			throw new ArgumentNullException("ruler");
		}
		return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_bool(This.Handle, selRulerAccessoryViewForTextView_ParagraphStyle_Ruler_Enabled_Handle, textView.Handle, paragraphStyle.Handle, ruler.Handle, enabled));
	}

	[Export("rulerMarkersForTextView:paragraphStyle:ruler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSRulerMarker[] GetRulerMarkers(this NSLayoutManager This, NSTextView textView, NSParagraphStyle paragraphStyle, NSRulerView ruler)
	{
		NSApplication.EnsureUIThread();
		if (textView == null)
		{
			throw new ArgumentNullException("textView");
		}
		if (paragraphStyle == null)
		{
			throw new ArgumentNullException("paragraphStyle");
		}
		if (ruler == null)
		{
			throw new ArgumentNullException("ruler");
		}
		return NSArray.ArrayFromHandle<NSRulerMarker>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, selRulerMarkersForTextView_ParagraphStyle_Ruler_Handle, textView.Handle, paragraphStyle.Handle, ruler.Handle));
	}

	[Export("textViewForBeginningOfSelection")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSTextView? GetTextViewForBeginningOfSelection(this NSLayoutManager This)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSTextView>(Messaging.IntPtr_objc_msgSend(This.Handle, selTextViewForBeginningOfSelectionHandle));
	}

	[Export("layoutManagerOwnsFirstResponderInWindow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool LayoutManagerOwnsFirstResponder(this NSLayoutManager This, NSWindow window)
	{
		NSApplication.EnsureUIThread();
		if (window == null)
		{
			throw new ArgumentNullException("window");
		}
		return Messaging.bool_objc_msgSend_IntPtr(This.Handle, selLayoutManagerOwnsFirstResponderInWindow_Handle, window.Handle);
	}
}

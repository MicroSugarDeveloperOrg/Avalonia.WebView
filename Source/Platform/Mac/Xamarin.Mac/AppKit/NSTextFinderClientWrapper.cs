using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSTextFinderClientWrapper : BaseWrapper, INSTextFinderClient, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool AllowsMultipleSelection
	{
		[Export("allowsMultipleSelection")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("allowsMultipleSelection"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool Editable
	{
		[Export("isEditable")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isEditable"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string String
	{
		[Export("string", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("string")));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSRange FirstSelectedRange
	{
		[Export("firstSelectedRange")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.NSRange_objc_msgSend(base.Handle, Selector.GetHandle("firstSelectedRange"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSArray SelectedRanges
	{
		[Export("selectedRanges", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("selectedRanges")));
		}
		[Export("setSelectedRanges:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setSelectedRanges:"), value.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSArray VisibleCharacterRanges
	{
		[Export("visibleCharacterRanges", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("visibleCharacterRanges")));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool Selectable
	{
		[Export("isSelectable")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isSelectable"));
		}
	}

	[Preserve(Conditional = true)]
	public NSTextFinderClientWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("stringAtIndex:effectiveRange:endsWithSearchBoundary:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string StringAtIndexeffectiveRangeendsWithSearchBoundary(nuint characterIndex, ref NSRange outRange, bool outFlag)
	{
		NSApplication.EnsureUIThread();
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_nuint_ref_NSRange_bool(base.Handle, Selector.GetHandle("stringAtIndex:effectiveRange:endsWithSearchBoundary:"), characterIndex, ref outRange, outFlag));
	}

	[Export("stringLength")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nuint StringLength()
	{
		NSApplication.EnsureUIThread();
		return Messaging.nuint_objc_msgSend(base.Handle, Selector.GetHandle("stringLength"));
	}

	[Export("scrollRangeToVisible:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void ScrollRangeToVisible(NSRange range)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_NSRange(base.Handle, Selector.GetHandle("scrollRangeToVisible:"), range);
	}

	[Export("shouldReplaceCharactersInRanges:withStrings:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool ShouldReplaceCharactersInRangeswithStrings(NSArray ranges, NSArray strings)
	{
		NSApplication.EnsureUIThread();
		if (ranges == null)
		{
			throw new ArgumentNullException("ranges");
		}
		if (strings == null)
		{
			throw new ArgumentNullException("strings");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("shouldReplaceCharactersInRanges:withStrings:"), ranges.Handle, strings.Handle);
	}

	[Export("replaceCharactersInRange:withString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void ReplaceCharactersInRangewithString(NSRange range, string str)
	{
		NSApplication.EnsureUIThread();
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr intPtr = NSString.CreateNative(str);
		Messaging.void_objc_msgSend_NSRange_IntPtr(base.Handle, Selector.GetHandle("replaceCharactersInRange:withString:"), range, intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[Export("didReplaceCharacters")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DidReplaceCharacters()
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("didReplaceCharacters"));
	}

	[Export("contentViewAtIndex:effectiveCharacterRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSView ContentViewAtIndexeffectiveCharacterRange(nuint index, ref NSRange outRange)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend_nuint_ref_NSRange(base.Handle, Selector.GetHandle("contentViewAtIndex:effectiveCharacterRange:"), index, ref outRange));
	}

	[Export("rectsForCharacterRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSArray RectsForCharacterRange(NSRange range)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, Selector.GetHandle("rectsForCharacterRange:"), range));
	}

	[Export("drawCharactersInRange:forContentView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void DrawCharactersInRangeforContentView(NSRange range, NSView view)
	{
		NSApplication.EnsureUIThread();
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		Messaging.void_objc_msgSend_NSRange_IntPtr(base.Handle, Selector.GetHandle("drawCharactersInRange:forContentView:"), range, view.Handle);
	}
}

using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSTextCheckingClientWrapper : BaseWrapper, INSTextCheckingClient, INativeObject, IDisposable, INSTextInputClient, INSTextInputTraits
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSCandidateListTouchBarItem? CandidateListTouchBarItem
	{
		[Export("candidateListTouchBarItem")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSCandidateListTouchBarItem>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("candidateListTouchBarItem")));
		}
	}

	[Preserve(Conditional = true)]
	public NSTextCheckingClientWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("annotatedSubstringForProposedRange:actualRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAttributedString? GetAnnotatedSubstring(NSRange range, ref NSRange actualRange)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend_NSRange_ref_NSRange(base.Handle, Selector.GetHandle("annotatedSubstringForProposedRange:actualRange:"), range, ref actualRange));
	}

	[Export("setAnnotations:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetAnnotations(NSDictionary<NSString, NSString> annotations, NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (annotations == null)
		{
			throw new ArgumentNullException("annotations");
		}
		Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, Selector.GetHandle("setAnnotations:range:"), annotations.Handle, range);
	}

	[Export("addAnnotations:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void AddAnnotations(NSDictionary<NSString, NSString> annotations, NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (annotations == null)
		{
			throw new ArgumentNullException("annotations");
		}
		Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, Selector.GetHandle("addAnnotations:range:"), annotations.Handle, range);
	}

	[Export("removeAnnotation:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void RemoveAnnotation(string annotationName, NSRange range)
	{
		NSApplication.EnsureUIThread();
		if (annotationName == null)
		{
			throw new ArgumentNullException("annotationName");
		}
		IntPtr intPtr = NSString.CreateNative(annotationName);
		Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, Selector.GetHandle("removeAnnotation:range:"), intPtr, range);
		NSString.ReleaseNative(intPtr);
	}

	[Export("replaceCharactersInRange:withAnnotatedString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void ReplaceCharacters(NSRange range, NSAttributedString annotatedString)
	{
		NSApplication.EnsureUIThread();
		if (annotatedString == null)
		{
			throw new ArgumentNullException("annotatedString");
		}
		Messaging.void_objc_msgSend_NSRange_IntPtr(base.Handle, Selector.GetHandle("replaceCharactersInRange:withAnnotatedString:"), range, annotatedString.Handle);
	}

	[Export("selectAndShowRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SelectAndShow(NSRange range)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_NSRange(base.Handle, Selector.GetHandle("selectAndShowRange:"), range);
	}

	[Export("viewForRange:firstRect:actualRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSView? GetView(NSRange range, ref CGRect firstRect, ref NSRange actualRange)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend_NSRange_ref_CGRect_ref_NSRange(base.Handle, Selector.GetHandle("viewForRange:firstRect:actualRange:"), range, ref firstRect, ref actualRange));
	}
}

using System;
using ObjCRuntime;

namespace AppKit;

public static class NSCollectionViewElement_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PrepareForReuse(this INSCollectionViewElement This)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend(This.Handle, Selector.GetHandle("prepareForReuse"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ApplyLayoutAttributes(this INSCollectionViewElement This, NSCollectionViewLayoutAttributes layoutAttributes)
	{
		NSApplication.EnsureUIThread();
		if (layoutAttributes == null)
		{
			throw new ArgumentNullException("layoutAttributes");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("applyLayoutAttributes:"), layoutAttributes.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillTransition(this INSCollectionViewElement This, NSCollectionViewLayout oldLayout, NSCollectionViewLayout newLayout)
	{
		NSApplication.EnsureUIThread();
		if (oldLayout == null)
		{
			throw new ArgumentNullException("oldLayout");
		}
		if (newLayout == null)
		{
			throw new ArgumentNullException("newLayout");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("willTransitionFromLayout:toLayout:"), oldLayout.Handle, newLayout.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidTransition(this INSCollectionViewElement This, NSCollectionViewLayout oldLayout, NSCollectionViewLayout newLayout)
	{
		NSApplication.EnsureUIThread();
		if (oldLayout == null)
		{
			throw new ArgumentNullException("oldLayout");
		}
		if (newLayout == null)
		{
			throw new ArgumentNullException("newLayout");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("didTransitionFromLayout:toLayout:"), oldLayout.Handle, newLayout.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionViewLayoutAttributes GetPreferredLayoutAttributes(this INSCollectionViewElement This, NSCollectionViewLayoutAttributes layoutAttributes)
	{
		NSApplication.EnsureUIThread();
		if (layoutAttributes == null)
		{
			throw new ArgumentNullException("layoutAttributes");
		}
		return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("preferredLayoutAttributesFittingAttributes:"), layoutAttributes.Handle));
	}
}

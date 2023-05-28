using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSCollectionViewElement", false)]
[Model]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NSCollectionViewElement : NSObject, INSCollectionViewElement, INativeObject, IDisposable, INSUserInterfaceItemIdentification
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Identifier
	{
		[Export("identifier", ArgumentSemantic.Copy)]
		get
		{
			throw new ModelNotImplementedException();
		}
		[Export("setIdentifier:", ArgumentSemantic.Copy)]
		set
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCollectionViewElement()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSCollectionViewElement(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCollectionViewElement(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("applyLayoutAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ApplyLayoutAttributes(NSCollectionViewLayoutAttributes layoutAttributes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("didTransitionFromLayout:toLayout:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidTransition(NSCollectionViewLayout oldLayout, NSCollectionViewLayout newLayout)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("preferredLayoutAttributesFittingAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewLayoutAttributes GetPreferredLayoutAttributes(NSCollectionViewLayoutAttributes layoutAttributes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("prepareForReuse")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PrepareForReuse()
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("willTransitionFromLayout:toLayout:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillTransition(NSCollectionViewLayout oldLayout, NSCollectionViewLayout newLayout)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSTextFinderBarContainer", false)]
[Model]
public abstract class NSTextFinderBarContainer : NSObject, INSTextFinderBarContainer, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView ContentView
	{
		[Export("contentView")]
		get
		{
			throw new ModelNotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract NSView FindBarView
	{
		[Export("findBarView", ArgumentSemantic.Retain)]
		get;
		[Export("setFindBarView:", ArgumentSemantic.Retain)]
		set;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract bool FindBarVisible
	{
		[Export("isFindBarVisible")]
		get;
		[Export("setFindBarVisible:")]
		set;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected NSTextFinderBarContainer()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSTextFinderBarContainer(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSTextFinderBarContainer(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("findBarViewDidChangeHeight")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void FindBarViewDidChangeHeight();
}

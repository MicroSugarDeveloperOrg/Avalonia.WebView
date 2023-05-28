using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

internal sealed class NSCollectionLayoutVisibleItemWrapper : BaseWrapper, INSCollectionLayoutVisibleItem, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nfloat Alpha
	{
		[Export("alpha")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.nfloat_objc_msgSend(base.Handle, Selector.GetHandle("alpha"));
		}
		[Export("setAlpha:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_nfloat(base.Handle, Selector.GetHandle("setAlpha:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nint ZIndex
	{
		[Export("zIndex")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.nint_objc_msgSend(base.Handle, Selector.GetHandle("zIndex"));
		}
		[Export("setZIndex:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_nint(base.Handle, Selector.GetHandle("setZIndex:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool Hidden
	{
		[Export("isHidden")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("isHidden"));
		}
		[Export("setHidden:")]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_bool(base.Handle, Selector.GetHandle("setHidden:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGPoint Center
	{
		[Export("center", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.CGPoint_objc_msgSend(base.Handle, Selector.GetHandle("center"));
		}
		[Export("setCenter:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			Messaging.void_objc_msgSend_CGPoint(base.Handle, Selector.GetHandle("setCenter:"), value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string Name
	{
		[Export("name")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("name")));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSIndexPath IndexPath
	{
		[Export("indexPath")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("indexPath")));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect Frame
	{
		[Export("frame")]
		get
		{
			NSApplication.EnsureUIThread();
			Messaging.CGRect_objc_msgSend_stret(out var retval, base.Handle, Selector.GetHandle("frame"));
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGRect Bounds
	{
		[Export("bounds")]
		get
		{
			NSApplication.EnsureUIThread();
			Messaging.CGRect_objc_msgSend_stret(out var retval, base.Handle, Selector.GetHandle("bounds"));
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSCollectionElementCategory RepresentedElementCategory
	{
		[Export("representedElementCategory")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSCollectionElementCategory)Messaging.Int64_objc_msgSend(base.Handle, Selector.GetHandle("representedElementCategory"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string? RepresentedElementKind
	{
		[Export("representedElementKind")]
		get
		{
			NSApplication.EnsureUIThread();
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("representedElementKind")));
		}
	}

	[Preserve(Conditional = true)]
	public NSCollectionLayoutVisibleItemWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}

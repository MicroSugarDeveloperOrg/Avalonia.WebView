using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCollectionLayoutSection", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NSCollectionLayoutSection : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundarySupplementaryItems = "boundarySupplementaryItems";

	private static readonly IntPtr selBoundarySupplementaryItemsHandle = Selector.GetHandle("boundarySupplementaryItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentInsets = "contentInsets";

	private static readonly IntPtr selContentInsetsHandle = Selector.GetHandle("contentInsets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecorationItems = "decorationItems";

	private static readonly IntPtr selDecorationItemsHandle = Selector.GetHandle("decorationItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterGroupSpacing = "interGroupSpacing";

	private static readonly IntPtr selInterGroupSpacingHandle = Selector.GetHandle("interGroupSpacing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrthogonalScrollingBehavior = "orthogonalScrollingBehavior";

	private static readonly IntPtr selOrthogonalScrollingBehaviorHandle = Selector.GetHandle("orthogonalScrollingBehavior");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSectionWithGroup_ = "sectionWithGroup:";

	private static readonly IntPtr selSectionWithGroup_Handle = Selector.GetHandle("sectionWithGroup:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBoundarySupplementaryItems_ = "setBoundarySupplementaryItems:";

	private static readonly IntPtr selSetBoundarySupplementaryItems_Handle = Selector.GetHandle("setBoundarySupplementaryItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentInsets_ = "setContentInsets:";

	private static readonly IntPtr selSetContentInsets_Handle = Selector.GetHandle("setContentInsets:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDecorationItems_ = "setDecorationItems:";

	private static readonly IntPtr selSetDecorationItems_Handle = Selector.GetHandle("setDecorationItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInterGroupSpacing_ = "setInterGroupSpacing:";

	private static readonly IntPtr selSetInterGroupSpacing_Handle = Selector.GetHandle("setInterGroupSpacing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOrthogonalScrollingBehavior_ = "setOrthogonalScrollingBehavior:";

	private static readonly IntPtr selSetOrthogonalScrollingBehavior_Handle = Selector.GetHandle("setOrthogonalScrollingBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSupplementariesFollowContentInsets_ = "setSupplementariesFollowContentInsets:";

	private static readonly IntPtr selSetSupplementariesFollowContentInsets_Handle = Selector.GetHandle("setSupplementariesFollowContentInsets:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVisibleItemsInvalidationHandler_ = "setVisibleItemsInvalidationHandler:";

	private static readonly IntPtr selSetVisibleItemsInvalidationHandler_Handle = Selector.GetHandle("setVisibleItemsInvalidationHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupplementariesFollowContentInsets = "supplementariesFollowContentInsets";

	private static readonly IntPtr selSupplementariesFollowContentInsetsHandle = Selector.GetHandle("supplementariesFollowContentInsets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVisibleItemsInvalidationHandler = "visibleItemsInvalidationHandler";

	private static readonly IntPtr selVisibleItemsInvalidationHandlerHandle = Selector.GetHandle("visibleItemsInvalidationHandler");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCollectionLayoutSection");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionLayoutBoundarySupplementaryItem[] BoundarySupplementaryItems
	{
		[Export("boundarySupplementaryItems", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSCollectionLayoutBoundarySupplementaryItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selBoundarySupplementaryItemsHandle));
			}
			return NSArray.ArrayFromHandle<NSCollectionLayoutBoundarySupplementaryItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBoundarySupplementaryItemsHandle));
		}
		[Export("setBoundarySupplementaryItems:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBoundarySupplementaryItems_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBoundarySupplementaryItems_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDirectionalEdgeInsets ContentInsets
	{
		[Export("contentInsets", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSDirectionalEdgeInsets retval;
			if (base.IsDirectBinding)
			{
				Messaging.NSDirectionalEdgeInsets_objc_msgSend_stret(out retval, base.Handle, selContentInsetsHandle);
			}
			else
			{
				Messaging.NSDirectionalEdgeInsets_objc_msgSendSuper_stret(out retval, base.SuperHandle, selContentInsetsHandle);
			}
			return retval;
		}
		[Export("setContentInsets:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_NSDirectionalEdgeInsets(base.Handle, selSetContentInsets_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_NSDirectionalEdgeInsets(base.SuperHandle, selSetContentInsets_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionLayoutDecorationItem[] DecorationItems
	{
		[Export("decorationItems", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSCollectionLayoutDecorationItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selDecorationItemsHandle));
			}
			return NSArray.ArrayFromHandle<NSCollectionLayoutDecorationItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDecorationItemsHandle));
		}
		[Export("setDecorationItems:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDecorationItems_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDecorationItems_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat InterGroupSpacing
	{
		[Export("interGroupSpacing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selInterGroupSpacingHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selInterGroupSpacingHandle);
		}
		[Export("setInterGroupSpacing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetInterGroupSpacing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetInterGroupSpacing_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionLayoutSectionOrthogonalScrollingBehavior OrthogonalScrollingBehavior
	{
		[Export("orthogonalScrollingBehavior", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSCollectionLayoutSectionOrthogonalScrollingBehavior)Messaging.Int64_objc_msgSend(base.Handle, selOrthogonalScrollingBehaviorHandle);
			}
			return (NSCollectionLayoutSectionOrthogonalScrollingBehavior)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selOrthogonalScrollingBehaviorHandle);
		}
		[Export("setOrthogonalScrollingBehavior:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetOrthogonalScrollingBehavior_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetOrthogonalScrollingBehavior_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SupplementariesFollowContentInsets
	{
		[Export("supplementariesFollowContentInsets")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSupplementariesFollowContentInsetsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSupplementariesFollowContentInsetsHandle);
		}
		[Export("setSupplementariesFollowContentInsets:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSupplementariesFollowContentInsets_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSupplementariesFollowContentInsets_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSCollectionLayoutSectionVisibleItemsInvalidationHandler? VisibleItemsInvalidationHandler
	{
		[Export("visibleItemsInvalidationHandler", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDNSCollectionLayoutSectionVisibleItemsInvalidationHandler))]
		get
		{
			NSApplication.EnsureUIThread();
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVisibleItemsInvalidationHandlerHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selVisibleItemsInvalidationHandlerHandle));
			return Trampolines.NIDNSCollectionLayoutSectionVisibleItemsInvalidationHandler.Create(block);
		}
		[Export("setVisibleItemsInvalidationHandler:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDNSCollectionLayoutSectionVisibleItemsInvalidationHandler))]
		set
		{
			NSApplication.EnsureUIThread();
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDNSCollectionLayoutSectionVisibleItemsInvalidationHandler.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVisibleItemsInvalidationHandler_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVisibleItemsInvalidationHandler_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSCollectionLayoutSection(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCollectionLayoutSection(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSApplication.EnsureUIThread();
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("sectionWithGroup:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionLayoutSection Create(NSCollectionLayoutGroup group)
	{
		NSApplication.EnsureUIThread();
		if (group == null)
		{
			throw new ArgumentNullException("group");
		}
		return Runtime.GetNSObject<NSCollectionLayoutSection>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSectionWithGroup_Handle, group.Handle));
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace iTunesLibrary;

[Register("ITLibPlaylist", true)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
public class ITLibPlaylist : ITLibMediaEntity
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDistinguishedKind = "distinguishedKind";

	private static readonly IntPtr selDistinguishedKindHandle = Selector.GetHandle("distinguishedKind");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAllItemsPlaylist = "isAllItemsPlaylist";

	private static readonly IntPtr selIsAllItemsPlaylistHandle = Selector.GetHandle("isAllItemsPlaylist");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsMaster = "isMaster";

	private static readonly IntPtr selIsMasterHandle = Selector.GetHandle("isMaster");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsVisible = "isVisible";

	private static readonly IntPtr selIsVisibleHandle = Selector.GetHandle("isVisible");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItems = "items";

	private static readonly IntPtr selItemsHandle = Selector.GetHandle("items");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKind = "kind";

	private static readonly IntPtr selKindHandle = Selector.GetHandle("kind");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParentID = "parentID";

	private static readonly IntPtr selParentIDHandle = Selector.GetHandle("parentID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ITLibPlaylist");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllItemsPlaylist
	{
		[Export("isAllItemsPlaylist")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAllItemsPlaylistHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAllItemsPlaylistHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ITLibDistinguishedPlaylistKind DistinguishedKind
	{
		[Export("distinguishedKind", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (ITLibDistinguishedPlaylistKind)Messaging.UInt64_objc_msgSend(base.Handle, selDistinguishedKindHandle);
			}
			return (ITLibDistinguishedPlaylistKind)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDistinguishedKindHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ITLibMediaItem[] Items
	{
		[Export("items", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<ITLibMediaItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selItemsHandle));
			}
			return NSArray.ArrayFromHandle<ITLibMediaItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ITLibPlaylistKind Kind
	{
		[Export("kind", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (ITLibPlaylistKind)Messaging.UInt64_objc_msgSend(base.Handle, selKindHandle);
			}
			return (ITLibPlaylistKind)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selKindHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Master
	{
		[Export("isMaster")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsMasterHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsMasterHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber? ParentId
	{
		[Export("parentID", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selParentIDHandle));
			}
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentIDHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Visible
	{
		[Export("isVisible")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsVisibleHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsVisibleHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public ITLibPlaylist()
		: base(NSObjectFlag.Empty)
	{
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected ITLibPlaylist(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ITLibPlaylist(IntPtr handle)
		: base(handle)
	{
	}
}

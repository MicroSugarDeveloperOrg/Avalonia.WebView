using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace MediaLibrary;

[Register("MLMediaGroup", true)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, null)]
public class MLMediaGroup : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURL = "URL";

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributes = "attributes";

	private static readonly IntPtr selAttributesHandle = Selector.GetHandle("attributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChildGroups = "childGroups";

	private static readonly IntPtr selChildGroupsHandle = Selector.GetHandle("childGroups");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIconImage = "iconImage";

	private static readonly IntPtr selIconImageHandle = Selector.GetHandle("iconImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaLibrary = "mediaLibrary";

	private static readonly IntPtr selMediaLibraryHandle = Selector.GetHandle("mediaLibrary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaObjects = "mediaObjects";

	private static readonly IntPtr selMediaObjectsHandle = Selector.GetHandle("mediaObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMediaSourceIdentifier = "mediaSourceIdentifier";

	private static readonly IntPtr selMediaSourceIdentifierHandle = Selector.GetHandle("mediaSourceIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModificationDate = "modificationDate";

	private static readonly IntPtr selModificationDateHandle = Selector.GetHandle("modificationDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParent = "parent";

	private static readonly IntPtr selParentHandle = Selector.GetHandle("parent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTypeIdentifier = "typeIdentifier";

	private static readonly IntPtr selTypeIdentifierHandle = Selector.GetHandle("typeIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MLMediaGroup");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_MediaLibrary_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Parent_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<NSString, NSObject> Attributes
	{
		[Export("attributes", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MLMediaGroup[]? ChildGroups
	{
		[Export("childGroups", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<MLMediaGroup>(Messaging.IntPtr_objc_msgSend(base.Handle, selChildGroupsHandle));
			}
			return NSArray.ArrayFromHandle<MLMediaGroup>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChildGroupsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage? IconImage
	{
		[Export("iconImage", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selIconImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIconImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString Identifier
	{
		[Export("identifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MLMediaLibrary? MediaLibrary
	{
		[Export("mediaLibrary", ArgumentSemantic.Assign)]
		get
		{
			MLMediaLibrary mLMediaLibrary = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MLMediaLibrary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaLibraryHandle)) : Runtime.GetNSObject<MLMediaLibrary>(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaLibraryHandle)));
			MarkDirty();
			__mt_MediaLibrary_var = mLMediaLibrary;
			return mLMediaLibrary;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MLMediaObject[]? MediaObjects
	{
		[Export("mediaObjects", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<MLMediaObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaObjectsHandle));
			}
			return NSArray.ArrayFromHandle<MLMediaObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaObjectsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString MediaSourceIdentifier
	{
		[Export("mediaSourceIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaSourceIdentifierHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaSourceIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate? ModificationDate
	{
		[Export("modificationDate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selModificationDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selModificationDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Name
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
	public virtual MLMediaGroup? Parent
	{
		[Export("parent", ArgumentSemantic.Assign)]
		get
		{
			MLMediaGroup mLMediaGroup = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MLMediaGroup>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentHandle)) : Runtime.GetNSObject<MLMediaGroup>(Messaging.IntPtr_objc_msgSend(base.Handle, selParentHandle)));
			MarkDirty();
			__mt_Parent_var = mLMediaGroup;
			return mLMediaGroup;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString TypeIdentifier
	{
		[Export("typeIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selTypeIdentifierHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypeIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? Url
	{
		[Export("URL", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MLMediaGroup(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MLMediaGroup(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_MediaLibrary_var = null;
			__mt_Parent_var = null;
		}
	}
}

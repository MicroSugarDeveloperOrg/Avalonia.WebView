using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Photos;

[Register("PHFetchOptions", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class PHFetchOptions : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchLimit = "fetchLimit";

	private static readonly IntPtr selFetchLimitHandle = Selector.GetHandle("fetchLimit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncludeAllBurstAssets = "includeAllBurstAssets";

	private static readonly IntPtr selIncludeAllBurstAssetsHandle = Selector.GetHandle("includeAllBurstAssets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncludeAssetSourceTypes = "includeAssetSourceTypes";

	private static readonly IntPtr selIncludeAssetSourceTypesHandle = Selector.GetHandle("includeAssetSourceTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncludeHiddenAssets = "includeHiddenAssets";

	private static readonly IntPtr selIncludeHiddenAssetsHandle = Selector.GetHandle("includeHiddenAssets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicate = "predicate";

	private static readonly IntPtr selPredicateHandle = Selector.GetHandle("predicate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFetchLimit_ = "setFetchLimit:";

	private static readonly IntPtr selSetFetchLimit_Handle = Selector.GetHandle("setFetchLimit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIncludeAllBurstAssets_ = "setIncludeAllBurstAssets:";

	private static readonly IntPtr selSetIncludeAllBurstAssets_Handle = Selector.GetHandle("setIncludeAllBurstAssets:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIncludeAssetSourceTypes_ = "setIncludeAssetSourceTypes:";

	private static readonly IntPtr selSetIncludeAssetSourceTypes_Handle = Selector.GetHandle("setIncludeAssetSourceTypes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIncludeHiddenAssets_ = "setIncludeHiddenAssets:";

	private static readonly IntPtr selSetIncludeHiddenAssets_Handle = Selector.GetHandle("setIncludeHiddenAssets:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPredicate_ = "setPredicate:";

	private static readonly IntPtr selSetPredicate_Handle = Selector.GetHandle("setPredicate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSortDescriptors_ = "setSortDescriptors:";

	private static readonly IntPtr selSetSortDescriptors_Handle = Selector.GetHandle("setSortDescriptors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWantsIncrementalChangeDetails_ = "setWantsIncrementalChangeDetails:";

	private static readonly IntPtr selSetWantsIncrementalChangeDetails_Handle = Selector.GetHandle("setWantsIncrementalChangeDetails:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSortDescriptors = "sortDescriptors";

	private static readonly IntPtr selSortDescriptorsHandle = Selector.GetHandle("sortDescriptors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWantsIncrementalChangeDetails = "wantsIncrementalChangeDetails";

	private static readonly IntPtr selWantsIncrementalChangeDetailsHandle = Selector.GetHandle("wantsIncrementalChangeDetails");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHFetchOptions");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public virtual nuint FetchLimit
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("fetchLimit", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selFetchLimitHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selFetchLimitHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("setFetchLimit:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetFetchLimit_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetFetchLimit_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual bool IncludeAllBurstAssets
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("includeAllBurstAssets")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIncludeAllBurstAssetsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIncludeAllBurstAssetsHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("setIncludeAllBurstAssets:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIncludeAllBurstAssets_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIncludeAllBurstAssets_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	public virtual PHAssetSourceType IncludeAssetSourceTypes
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("includeAssetSourceTypes", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PHAssetSourceType)Messaging.UInt64_objc_msgSend(base.Handle, selIncludeAssetSourceTypesHandle);
			}
			return (PHAssetSourceType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selIncludeAssetSourceTypesHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Export("setIncludeAssetSourceTypes:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetIncludeAssetSourceTypes_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetIncludeAssetSourceTypes_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IncludeHiddenAssets
	{
		[Export("includeHiddenAssets")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIncludeHiddenAssetsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIncludeHiddenAssetsHandle);
		}
		[Export("setIncludeHiddenAssets:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIncludeHiddenAssets_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIncludeHiddenAssets_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPredicate? Predicate
	{
		[Export("predicate", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend(base.Handle, selPredicateHandle));
			}
			return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPredicateHandle));
		}
		[Export("setPredicate:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPredicate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPredicate_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSortDescriptor[]? SortDescriptors
	{
		[Export("sortDescriptors", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSSortDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selSortDescriptorsHandle));
			}
			return NSArray.ArrayFromHandle<NSSortDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSortDescriptorsHandle));
		}
		[Export("setSortDescriptors:", ArgumentSemantic.Retain)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSortDescriptors_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSortDescriptors_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WantsIncrementalChangeDetails
	{
		[Export("wantsIncrementalChangeDetails")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selWantsIncrementalChangeDetailsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selWantsIncrementalChangeDetailsHandle);
		}
		[Export("setWantsIncrementalChangeDetails:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetWantsIncrementalChangeDetails_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetWantsIncrementalChangeDetails_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PHFetchOptions()
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
	protected PHFetchOptions(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHFetchOptions(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}
}

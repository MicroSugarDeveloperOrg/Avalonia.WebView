using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Photos;

[Register("PHAssetResource", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class PHAssetResource : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetLocalIdentifier = "assetLocalIdentifier";

	private static readonly IntPtr selAssetLocalIdentifierHandle = Selector.GetHandle("assetLocalIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetResourcesForAsset_ = "assetResourcesForAsset:";

	private static readonly IntPtr selAssetResourcesForAsset_Handle = Selector.GetHandle("assetResourcesForAsset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetResourcesForLivePhoto_ = "assetResourcesForLivePhoto:";

	private static readonly IntPtr selAssetResourcesForLivePhoto_Handle = Selector.GetHandle("assetResourcesForLivePhoto:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOriginalFilename = "originalFilename";

	private static readonly IntPtr selOriginalFilenameHandle = Selector.GetHandle("originalFilename");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUniformTypeIdentifier = "uniformTypeIdentifier";

	private static readonly IntPtr selUniformTypeIdentifierHandle = Selector.GetHandle("uniformTypeIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHAssetResource");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string AssetLocalIdentifier
	{
		[Export("assetLocalIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAssetLocalIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAssetLocalIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string OriginalFilename
	{
		[Export("originalFilename")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selOriginalFilenameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOriginalFilenameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHAssetResourceType ResourceType
	{
		[Export("type", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (PHAssetResourceType)Messaging.Int64_objc_msgSend(base.Handle, selTypeHandle);
			}
			return (PHAssetResourceType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string UniformTypeIdentifier
	{
		[Export("uniformTypeIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUniformTypeIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUniformTypeIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected PHAssetResource(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHAssetResource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("assetResourcesForAsset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHAssetResource[] GetAssetResources(PHAsset forAsset)
	{
		if (forAsset == null)
		{
			throw new ArgumentNullException("forAsset");
		}
		return NSArray.ArrayFromHandle<PHAssetResource>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAssetResourcesForAsset_Handle, forAsset.Handle));
	}

	[Export("assetResourcesForLivePhoto:")]
	[Introduced(PlatformName.iOS, 9, 1, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHAssetResource[] GetAssetResources(PHLivePhoto livePhoto)
	{
		if (livePhoto == null)
		{
			throw new ArgumentNullException("livePhoto");
		}
		return NSArray.ArrayFromHandle<PHAssetResource>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAssetResourcesForLivePhoto_Handle, livePhoto.Handle));
	}
}

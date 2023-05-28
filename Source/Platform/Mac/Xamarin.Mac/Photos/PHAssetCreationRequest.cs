using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Photos;

[Register("PHAssetCreationRequest", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class PHAssetCreationRequest : PHAssetChangeRequest
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddResourceWithType_Data_Options_ = "addResourceWithType:data:options:";

	private static readonly IntPtr selAddResourceWithType_Data_Options_Handle = Selector.GetHandle("addResourceWithType:data:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddResourceWithType_FileURL_Options_ = "addResourceWithType:fileURL:options:";

	private static readonly IntPtr selAddResourceWithType_FileURL_Options_Handle = Selector.GetHandle("addResourceWithType:fileURL:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreationRequestForAsset = "creationRequestForAsset";

	private static readonly IntPtr selCreationRequestForAssetHandle = Selector.GetHandle("creationRequestForAsset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportsAssetResourceTypes_ = "supportsAssetResourceTypes:";

	private static readonly IntPtr selSupportsAssetResourceTypes_Handle = Selector.GetHandle("supportsAssetResourceTypes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHAssetCreationRequest");

	public override IntPtr ClassHandle => class_ptr;

	public bool SupportsAssetResourceTypes(params PHAssetResourceType[] resourceTypes)
	{
		int num = resourceTypes.Length;
		if (num == 0)
		{
			return false;
		}
		NSNumber[] array = new NSNumber[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = new NSNumber((int)resourceTypes[i]);
		}
		return _SupportsAssetResourceTypes(array);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected PHAssetCreationRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHAssetCreationRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addResourceWithType:fileURL:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddResource(PHAssetResourceType type, NSUrl fileURL, PHAssetResourceCreationOptions? options)
	{
		if (fileURL == null)
		{
			throw new ArgumentNullException("fileURL");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_IntPtr_IntPtr(base.Handle, selAddResourceWithType_FileURL_Options_Handle, (long)type, fileURL.Handle, options?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr_IntPtr(base.SuperHandle, selAddResourceWithType_FileURL_Options_Handle, (long)type, fileURL.Handle, options?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("addResourceWithType:data:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddResource(PHAssetResourceType type, NSData data, PHAssetResourceCreationOptions? options)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_IntPtr_IntPtr(base.Handle, selAddResourceWithType_Data_Options_Handle, (long)type, data.Handle, options?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr_IntPtr(base.SuperHandle, selAddResourceWithType_Data_Options_Handle, (long)type, data.Handle, options?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("creationRequestForAsset")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHAssetCreationRequest CreationRequestForAsset()
	{
		return Runtime.GetNSObject<PHAssetCreationRequest>(Messaging.IntPtr_objc_msgSend(class_ptr, selCreationRequestForAssetHandle));
	}

	[Export("supportsAssetResourceTypes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static bool _SupportsAssetResourceTypes(NSNumber[] types)
	{
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		NSArray nSArray = NSArray.FromNSObjects(types);
		bool result = Messaging.bool_objc_msgSend_IntPtr(class_ptr, selSupportsAssetResourceTypes_Handle, nSArray.Handle);
		nSArray.Dispose();
		return result;
	}
}

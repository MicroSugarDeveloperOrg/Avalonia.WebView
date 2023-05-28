using System;
using Foundation;
using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
[Advice("This API is not available when using UIKit on macOS.")]
public static class PHPhotoLibrary_CloudIdentifiers
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCloudIdentifiersForLocalIdentifiers_ = "cloudIdentifiersForLocalIdentifiers:";

	private static readonly IntPtr selCloudIdentifiersForLocalIdentifiers_Handle = Selector.GetHandle("cloudIdentifiersForLocalIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalIdentifiersForCloudIdentifiers_ = "localIdentifiersForCloudIdentifiers:";

	private static readonly IntPtr selLocalIdentifiersForCloudIdentifiers_Handle = Selector.GetHandle("localIdentifiersForCloudIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("PHPhotoLibrary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LocalIdentifierNotFound;

	[Field("PHLocalIdentifierNotFound", "Photos")]
	public static NSString LocalIdentifierNotFound
	{
		get
		{
			if (_LocalIdentifierNotFound == null)
			{
				_LocalIdentifierNotFound = Dlfcn.GetStringConstant(Libraries.Photos.Handle, "PHLocalIdentifierNotFound");
			}
			return _LocalIdentifierNotFound;
		}
	}

	[Export("cloudIdentifiersForLocalIdentifiers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHCloudIdentifier[] GetCloudIdentifiers(this PHPhotoLibrary This, string[] localIdentifiers)
	{
		if (localIdentifiers == null)
		{
			throw new ArgumentNullException("localIdentifiers");
		}
		NSArray nSArray = NSArray.FromStrings(localIdentifiers);
		PHCloudIdentifier[] result = NSArray.ArrayFromHandle<PHCloudIdentifier>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, selCloudIdentifiersForLocalIdentifiers_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("localIdentifiersForCloudIdentifiers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] GetLocalIdentifiers(this PHPhotoLibrary This, PHCloudIdentifier[] cloudIdentifiers)
	{
		if (cloudIdentifiers == null)
		{
			throw new ArgumentNullException("cloudIdentifiers");
		}
		NSArray nSArray = NSArray.FromNSObjects(cloudIdentifiers);
		string[] result = NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, selLocalIdentifiersForCloudIdentifiers_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}
}

using System;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

internal sealed class MDLAssetResolverWrapper : BaseWrapper, IMDLAssetResolver, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public MDLAssetResolverWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("canResolveAssetNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool CanResolveAsset(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr intPtr = NSString.CreateNative(name);
		bool result = Messaging.bool_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("canResolveAssetNamed:"), intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[Export("resolveAssetNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUrl ResolveAsset(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr intPtr = NSString.CreateNative(name);
		NSUrl nSObject = Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("resolveAssetNamed:"), intPtr));
		NSString.ReleaseNative(intPtr);
		return nSObject;
	}
}

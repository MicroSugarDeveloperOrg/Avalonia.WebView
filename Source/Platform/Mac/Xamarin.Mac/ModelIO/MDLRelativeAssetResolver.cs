using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

[Register("MDLRelativeAssetResolver", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class MDLRelativeAssetResolver : NSObject, IMDLAssetResolver, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAsset = "asset";

	private static readonly IntPtr selAssetHandle = Selector.GetHandle("asset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanResolveAssetNamed_ = "canResolveAssetNamed:";

	private static readonly IntPtr selCanResolveAssetNamed_Handle = Selector.GetHandle("canResolveAssetNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAsset_ = "initWithAsset:";

	private static readonly IntPtr selInitWithAsset_Handle = Selector.GetHandle("initWithAsset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResolveAssetNamed_ = "resolveAssetNamed:";

	private static readonly IntPtr selResolveAssetNamed_Handle = Selector.GetHandle("resolveAssetNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAsset_ = "setAsset:";

	private static readonly IntPtr selSetAsset_Handle = Selector.GetHandle("setAsset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLRelativeAssetResolver");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Asset_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLAsset? Asset
	{
		[Export("asset", ArgumentSemantic.Weak)]
		get
		{
			MDLAsset mDLAsset = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MDLAsset>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAssetHandle)) : Runtime.GetNSObject<MDLAsset>(Messaging.IntPtr_objc_msgSend(base.Handle, selAssetHandle)));
			MarkDirty();
			__mt_Asset_var = mDLAsset;
			return mDLAsset;
		}
		[Export("setAsset:", ArgumentSemantic.Weak)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAsset_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAsset_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_Asset_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MDLRelativeAssetResolver(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLRelativeAssetResolver(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAsset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLRelativeAssetResolver(MDLAsset asset)
		: base(NSObjectFlag.Empty)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithAsset_Handle, asset.Handle), "initWithAsset:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithAsset_Handle, asset.Handle), "initWithAsset:");
		}
	}

	[Export("canResolveAssetNamed:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanResolveAsset(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selCanResolveAssetNamed_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selCanResolveAssetNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("resolveAssetNamed:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl ResolveAsset(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSUrl result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selResolveAssetNamed_Handle, arg)) : Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selResolveAssetNamed_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Asset_var = null;
		}
	}
}

using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

[Register("MDLPathAssetResolver", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class MDLPathAssetResolver : NSObject, IMDLAssetResolver, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanResolveAssetNamed_ = "canResolveAssetNamed:";

	private static readonly IntPtr selCanResolveAssetNamed_Handle = Selector.GetHandle("canResolveAssetNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPath_ = "initWithPath:";

	private static readonly IntPtr selInitWithPath_Handle = Selector.GetHandle("initWithPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPath = "path";

	private static readonly IntPtr selPathHandle = Selector.GetHandle("path");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResolveAssetNamed_ = "resolveAssetNamed:";

	private static readonly IntPtr selResolveAssetNamed_Handle = Selector.GetHandle("resolveAssetNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPath_ = "setPath:";

	private static readonly IntPtr selSetPath_Handle = Selector.GetHandle("setPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLPathAssetResolver");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Path
	{
		[Export("path")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathHandle));
		}
		[Export("setPath:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPath_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPath_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MDLPathAssetResolver(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLPathAssetResolver(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLPathAssetResolver(string path)
		: base(NSObjectFlag.Empty)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPath_Handle, arg), "initWithPath:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPath_Handle, arg), "initWithPath:");
		}
		NSString.ReleaseNative(arg);
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
}

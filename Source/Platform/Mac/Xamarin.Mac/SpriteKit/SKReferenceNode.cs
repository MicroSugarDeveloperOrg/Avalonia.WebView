using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKReferenceNode", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class SKReferenceNode : SKNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDidLoadReferenceNode_ = "didLoadReferenceNode:";

	private static readonly IntPtr selDidLoadReferenceNode_Handle = Selector.GetHandle("didLoadReferenceNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFileNamed_ = "initWithFileNamed:";

	private static readonly IntPtr selInitWithFileNamed_Handle = Selector.GetHandle("initWithFileNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_ = "initWithURL:";

	private static readonly IntPtr selInitWithURL_Handle = Selector.GetHandle("initWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReferenceNodeWithFileNamed_ = "referenceNodeWithFileNamed:";

	private static readonly IntPtr selReferenceNodeWithFileNamed_Handle = Selector.GetHandle("referenceNodeWithFileNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReferenceNodeWithURL_ = "referenceNodeWithURL:";

	private static readonly IntPtr selReferenceNodeWithURL_Handle = Selector.GetHandle("referenceNodeWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResolveReferenceNode = "resolveReferenceNode";

	private static readonly IntPtr selResolveReferenceNodeHandle = Selector.GetHandle("resolveReferenceNode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKReferenceNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SKReferenceNode(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SKReferenceNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKReferenceNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKReferenceNode(NSUrl? url)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithURL_Handle, (url == null) ? IntPtr.Zero : url.Handle), "initWithURL:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithURL_Handle, (url == null) ? IntPtr.Zero : url.Handle), "initWithURL:");
		}
	}

	[Export("initWithFileNamed:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKReferenceNode(string? fileName)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = NSString.CreateNative(fileName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithFileNamed_Handle, arg), "initWithFileNamed:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithFileNamed_Handle, arg), "initWithFileNamed:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("didLoadReferenceNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidLoadReferenceNode(SKNode? node)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDidLoadReferenceNode_Handle, node?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDidLoadReferenceNode_Handle, node?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("referenceNodeWithFileNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKReferenceNode FromFile(string fileName)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		IntPtr arg = NSString.CreateNative(fileName);
		SKReferenceNode nSObject = Runtime.GetNSObject<SKReferenceNode>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selReferenceNodeWithFileNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("referenceNodeWithURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKReferenceNode FromUrl(NSUrl referenceUrl)
	{
		if (referenceUrl == null)
		{
			throw new ArgumentNullException("referenceUrl");
		}
		return Runtime.GetNSObject<SKReferenceNode>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selReferenceNodeWithURL_Handle, referenceUrl.Handle));
	}

	[Export("resolveReferenceNode")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Resolve()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResolveReferenceNodeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResolveReferenceNodeHandle);
		}
	}
}

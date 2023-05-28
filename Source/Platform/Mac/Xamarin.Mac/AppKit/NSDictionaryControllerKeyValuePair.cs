using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSDictionaryControllerKeyValuePair", true)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NSDictionaryControllerKeyValuePair : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsExplicitlyIncluded = "isExplicitlyIncluded";

	private static readonly IntPtr selIsExplicitlyIncludedHandle = Selector.GetHandle("isExplicitlyIncluded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKey = "key";

	private static readonly IntPtr selKeyHandle = Selector.GetHandle("key");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedKey = "localizedKey";

	private static readonly IntPtr selLocalizedKeyHandle = Selector.GetHandle("localizedKey");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKey_ = "setKey:";

	private static readonly IntPtr selSetKey_Handle = Selector.GetHandle("setKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocalizedKey_ = "setLocalizedKey:";

	private static readonly IntPtr selSetLocalizedKey_Handle = Selector.GetHandle("setLocalizedKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValue_ = "setValue:";

	private static readonly IntPtr selSetValue_Handle = Selector.GetHandle("setValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValue = "value";

	private static readonly IntPtr selValueHandle = Selector.GetHandle("value");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSDictionaryControllerKeyValuePair");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ExplicitlyIncluded
	{
		[Export("isExplicitlyIncluded")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsExplicitlyIncludedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsExplicitlyIncludedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Key
	{
		[Export("key")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyHandle));
		}
		[Export("setKey:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetKey_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetKey_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? LocalizedKey
	{
		[Export("localizedKey")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedKeyHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedKeyHandle));
		}
		[Export("setLocalizedKey:")]
		set
		{
			NSApplication.EnsureUIThread();
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLocalizedKey_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLocalizedKey_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? Value
	{
		[Export("value", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selValueHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueHandle));
		}
		[Export("setValue:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetValue_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSDictionaryControllerKeyValuePair(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSDictionaryControllerKeyValuePair(IntPtr handle)
		: base(handle)
	{
	}
}

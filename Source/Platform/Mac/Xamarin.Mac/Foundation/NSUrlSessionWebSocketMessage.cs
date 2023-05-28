using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSURLSessionWebSocketMessage", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class NSUrlSessionWebSocketMessage : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selData = "data";

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_ = "initWithData:";

	private static readonly IntPtr selInitWithData_Handle = Selector.GetHandle("initWithData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithString_ = "initWithString:";

	private static readonly IntPtr selInitWithString_Handle = Selector.GetHandle("initWithString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selString = "string";

	private static readonly IntPtr selStringHandle = Selector.GetHandle("string");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSURLSessionWebSocketMessage");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? Data
	{
		[Export("data", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? String
	{
		[Export("string")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlSessionWebSocketMessageType Type
	{
		[Export("type")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSUrlSessionWebSocketMessageType)Messaging.Int64_objc_msgSend(base.Handle, selTypeHandle);
			}
			return (NSUrlSessionWebSocketMessageType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSUrlSessionWebSocketMessage(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUrlSessionWebSocketMessage(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithData:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUrlSessionWebSocketMessage(NSData data)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithData_Handle, data.Handle), "initWithData:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithData_Handle, data.Handle), "initWithData:");
		}
	}

	[Export("initWithString:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUrlSessionWebSocketMessage(string @string)
		: base(NSObjectFlag.Empty)
	{
		if (@string == null)
		{
			throw new ArgumentNullException("@string");
		}
		IntPtr arg = NSString.CreateNative(@string);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithString_Handle, arg), "initWithString:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithString_Handle, arg), "initWithString:");
		}
		NSString.ReleaseNative(arg);
	}
}

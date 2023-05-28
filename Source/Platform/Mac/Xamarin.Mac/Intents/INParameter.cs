using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INParameter", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class INParameter : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexForSubKeyPath_ = "indexForSubKeyPath:";

	private static readonly IntPtr selIndexForSubKeyPath_Handle = Selector.GetHandle("indexForSubKeyPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEqualToParameter_ = "isEqualToParameter:";

	private static readonly IntPtr selIsEqualToParameter_Handle = Selector.GetHandle("isEqualToParameter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParameterClass = "parameterClass";

	private static readonly IntPtr selParameterClassHandle = Selector.GetHandle("parameterClass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParameterForClass_KeyPath_ = "parameterForClass:keyPath:";

	private static readonly IntPtr selParameterForClass_KeyPath_Handle = Selector.GetHandle("parameterForClass:keyPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParameterKeyPath = "parameterKeyPath";

	private static readonly IntPtr selParameterKeyPathHandle = Selector.GetHandle("parameterKeyPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIndex_ForSubKeyPath_ = "setIndex:forSubKeyPath:";

	private static readonly IntPtr selSetIndex_ForSubKeyPath_Handle = Selector.GetHandle("setIndex:forSubKeyPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INParameter");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Class ParameterClass
	{
		[Export("parameterClass")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParameterClassHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selParameterClassHandle));
			return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ParameterKeyPath
	{
		[Export("parameterKeyPath")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selParameterKeyPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParameterKeyPathHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Type ParameterType => ObjCRuntime.Class.Lookup(ParameterClass);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public INParameter(NSCoder coder)
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
	protected INParameter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INParameter(IntPtr handle)
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

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("indexForSubKeyPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetIndex(string subKeyPath)
	{
		if (subKeyPath == null)
		{
			throw new ArgumentNullException("subKeyPath");
		}
		IntPtr arg = NSString.CreateNative(subKeyPath);
		nuint result = ((!base.IsDirectBinding) ? Messaging.nuint_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexForSubKeyPath_Handle, arg) : Messaging.nuint_objc_msgSend_IntPtr(base.Handle, selIndexForSubKeyPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("parameterForClass:keyPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INParameter GetParameter(Class aClass, string keyPath)
	{
		if (aClass == null)
		{
			throw new ArgumentNullException("aClass");
		}
		if (keyPath == null)
		{
			throw new ArgumentNullException("keyPath");
		}
		IntPtr arg = NSString.CreateNative(keyPath);
		INParameter nSObject = Runtime.GetNSObject<INParameter>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selParameterForClass_KeyPath_Handle, aClass.Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INParameter GetParameter(Type type, string keyPath)
	{
		return GetParameter(new Class(type), keyPath);
	}

	[Export("isEqualToParameter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEqualTo(INParameter parameter)
	{
		if (parameter == null)
		{
			throw new ArgumentNullException("parameter");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToParameter_Handle, parameter.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToParameter_Handle, parameter.Handle);
	}

	[Export("setIndex:forSubKeyPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetIndex(nuint index, string subKeyPath)
	{
		if (subKeyPath == null)
		{
			throw new ArgumentNullException("subKeyPath");
		}
		IntPtr arg = NSString.CreateNative(subKeyPath);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nuint_IntPtr(base.Handle, selSetIndex_ForSubKeyPath_Handle, index, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nuint_IntPtr(base.SuperHandle, selSetIndex_ForSubKeyPath_Handle, index, arg);
		}
		NSString.ReleaseNative(arg);
	}
}

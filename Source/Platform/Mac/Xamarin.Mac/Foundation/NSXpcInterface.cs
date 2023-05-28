using System.ComponentModel;
using System.Reflection;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSXPCInterface", true)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 2, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 9, 0, PlatformArchitecture.All, null)]
public class NSXpcInterface : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClassesForSelector_ArgumentIndex_OfReply_ = "classesForSelector:argumentIndex:ofReply:";

	private static readonly IntPtr selClassesForSelector_ArgumentIndex_OfReply_Handle = Selector.GetHandle("classesForSelector:argumentIndex:ofReply:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterfaceWithProtocol_ = "interfaceWithProtocol:";

	private static readonly IntPtr selInterfaceWithProtocol_Handle = Selector.GetHandle("interfaceWithProtocol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProtocol = "protocol";

	private static readonly IntPtr selProtocolHandle = Selector.GetHandle("protocol");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClasses_ForSelector_ArgumentIndex_OfReply_ = "setClasses:forSelector:argumentIndex:ofReply:";

	private static readonly IntPtr selSetClasses_ForSelector_ArgumentIndex_OfReply_Handle = Selector.GetHandle("setClasses:forSelector:argumentIndex:ofReply:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProtocol_ = "setProtocol:";

	private static readonly IntPtr selSetProtocol_Handle = Selector.GetHandle("setProtocol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSXPCInterface");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Protocol Protocol
	{
		[Export("protocol", ArgumentSemantic.Assign)]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProtocolHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selProtocolHandle));
			return (intPtr == IntPtr.Zero) ? null : new Protocol(intPtr);
		}
		[Export("setProtocol:", ArgumentSemantic.Assign)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetProtocol_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetProtocol_Handle, value.Handle);
			}
		}
	}

	public static NSXpcInterface Create(Type interfaceType)
	{
		if (interfaceType == null)
		{
			throw new ArgumentNullException("interfaceType");
		}
		return Create(new Protocol(interfaceType));
	}

	public NSSet<Class> GetAllowedClasses(MethodInfo method, nuint argumentIndex, bool forReplyBlock)
	{
		if (method == null)
		{
			throw new ArgumentNullException("method");
		}
		ExportAttribute customAttribute = method.GetCustomAttribute<ExportAttribute>();
		if (customAttribute == null)
		{
			throw new ArgumentException("Method " + method.Name + " is not exposed to Objective-C", "method");
		}
		Selector methodSelector = new Selector(customAttribute.Selector);
		return GetAllowedClasses(methodSelector, argumentIndex, forReplyBlock);
	}

	public void SetAllowedClasses(MethodInfo method, NSSet<Class> allowedClasses, nuint argumentIndex, bool forReplyBlock)
	{
		if (method == null)
		{
			throw new ArgumentNullException("method");
		}
		ExportAttribute customAttribute = method.GetCustomAttribute<ExportAttribute>();
		if (customAttribute == null)
		{
			throw new ArgumentException("Method " + method.Name + " is not exposed to Objective-C", "method");
		}
		Selector methodSelector = new Selector(customAttribute.Selector);
		SetAllowedClasses(allowedClasses, methodSelector, argumentIndex, forReplyBlock);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSXpcInterface(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSXpcInterface(IntPtr handle)
		: base(handle)
	{
	}

	[Export("interfaceWithProtocol:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSXpcInterface Create(Protocol protocol)
	{
		if (protocol == null)
		{
			throw new ArgumentNullException("protocol");
		}
		return Runtime.GetNSObject<NSXpcInterface>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selInterfaceWithProtocol_Handle, protocol.Handle));
	}

	[Export("classesForSelector:argumentIndex:ofReply:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet<Class> GetAllowedClasses(Selector methodSelector, nuint argumentIndex, bool forReplyBlock)
	{
		if (methodSelector == null)
		{
			throw new ArgumentNullException("methodSelector");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSSet<Class>>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_bool(base.Handle, selClassesForSelector_ArgumentIndex_OfReply_Handle, methodSelector.Handle, argumentIndex, forReplyBlock));
		}
		return Runtime.GetNSObject<NSSet<Class>>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_bool(base.SuperHandle, selClassesForSelector_ArgumentIndex_OfReply_Handle, methodSelector.Handle, argumentIndex, forReplyBlock));
	}

	[Export("setClasses:forSelector:argumentIndex:ofReply:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetAllowedClasses(NSSet<Class> allowedClasses, Selector methodSelector, nuint argumentIndex, bool forReplyBlock)
	{
		if (allowedClasses == null)
		{
			throw new ArgumentNullException("allowedClasses");
		}
		if (methodSelector == null)
		{
			throw new ArgumentNullException("methodSelector");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint_bool(base.Handle, selSetClasses_ForSelector_ArgumentIndex_OfReply_Handle, allowedClasses.Handle, methodSelector.Handle, argumentIndex, forReplyBlock);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint_bool(base.SuperHandle, selSetClasses_ForSelector_ArgumentIndex_OfReply_Handle, allowedClasses.Handle, methodSelector.Handle, argumentIndex, forReplyBlock);
		}
	}
}

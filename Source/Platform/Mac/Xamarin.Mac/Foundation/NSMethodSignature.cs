using System.ComponentModel;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSMethodSignature", true)]
public class NSMethodSignature : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameLength = "frameLength";

	private static readonly IntPtr selFrameLengthHandle = Selector.GetHandle("frameLength");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetArgumentTypeAtIndex_ = "getArgumentTypeAtIndex:";

	private static readonly IntPtr selGetArgumentTypeAtIndex_Handle = Selector.GetHandle("getArgumentTypeAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsOneway = "isOneway";

	private static readonly IntPtr selIsOnewayHandle = Selector.GetHandle("isOneway");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMethodReturnLength = "methodReturnLength";

	private static readonly IntPtr selMethodReturnLengthHandle = Selector.GetHandle("methodReturnLength");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMethodReturnType = "methodReturnType";

	private static readonly IntPtr selMethodReturnTypeHandle = Selector.GetHandle("methodReturnType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfArguments = "numberOfArguments";

	private static readonly IntPtr selNumberOfArgumentsHandle = Selector.GetHandle("numberOfArguments");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSignatureWithObjCTypes_ = "signatureWithObjCTypes:";

	private static readonly IntPtr selSignatureWithObjCTypes_Handle = Selector.GetHandle("signatureWithObjCTypes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMethodSignature");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint FrameLength
	{
		[Export("frameLength")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selFrameLengthHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selFrameLengthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsOneway
	{
		[Export("isOneway")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOnewayHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOnewayHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint MethodReturnLength
	{
		[Export("methodReturnLength")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMethodReturnLengthHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMethodReturnLengthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr MethodReturnType
	{
		[Export("methodReturnType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selMethodReturnTypeHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMethodReturnTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint NumberOfArguments
	{
		[Export("numberOfArguments")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNumberOfArgumentsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNumberOfArgumentsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSMethodSignature(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMethodSignature(IntPtr handle)
		: base(handle)
	{
	}

	[Export("signatureWithObjCTypes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSMethodSignature FromObjcTypes(IntPtr utf8objctypes)
	{
		return Runtime.GetNSObject<NSMethodSignature>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSignatureWithObjCTypes_Handle, utf8objctypes));
	}

	[Export("getArgumentTypeAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr GetArgumentType(nuint index)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selGetArgumentTypeAtIndex_Handle, index);
		}
		return Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selGetArgumentTypeAtIndex_Handle, index);
	}
}

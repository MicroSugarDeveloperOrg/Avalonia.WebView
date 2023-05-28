using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ScriptingBridge;

[Register("SBElementArray", true)]
public class SBElementArray : NSMutableArray
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArrayByApplyingSelector_ = "arrayByApplyingSelector:";

	private static readonly IntPtr selArrayByApplyingSelector_Handle = Selector.GetHandle("arrayByApplyingSelector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArrayByApplyingSelector_WithObject_ = "arrayByApplyingSelector:withObject:";

	private static readonly IntPtr selArrayByApplyingSelector_WithObject_Handle = Selector.GetHandle("arrayByApplyingSelector:withObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGet = "get";

	private static readonly IntPtr selGetHandle = Selector.GetHandle("get");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCapacity_ = "initWithCapacity:";

	private static readonly IntPtr selInitWithCapacity_Handle = Selector.GetHandle("initWithCapacity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectAtLocation_ = "objectAtLocation:";

	private static readonly IntPtr selObjectAtLocation_Handle = Selector.GetHandle("objectAtLocation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectWithID_ = "objectWithID:";

	private static readonly IntPtr selObjectWithID_Handle = Selector.GetHandle("objectWithID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectWithName_ = "objectWithName:";

	private static readonly IntPtr selObjectWithName_Handle = Selector.GetHandle("objectWithName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SBElementArray");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SBElementArray(NSCoder coder)
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
	protected SBElementArray(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SBElementArray(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCapacity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SBElementArray(nuint capacity)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selInitWithCapacity_Handle, capacity), "initWithCapacity:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selInitWithCapacity_Handle, capacity), "initWithCapacity:");
		}
	}

	[Export("arrayByApplyingSelector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] ArrayByApplyingSelector(Selector selector)
	{
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selArrayByApplyingSelector_Handle, selector.Handle));
		}
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selArrayByApplyingSelector_Handle, selector.Handle));
	}

	[Export("arrayByApplyingSelector:withObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] ArrayByApplyingSelector(Selector aSelector, NSObject argument)
	{
		if (aSelector == null)
		{
			throw new ArgumentNullException("aSelector");
		}
		if (argument == null)
		{
			throw new ArgumentNullException("argument");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selArrayByApplyingSelector_WithObject_Handle, aSelector.Handle, argument.Handle));
		}
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selArrayByApplyingSelector_WithObject_Handle, aSelector.Handle, argument.Handle));
	}

	[Export("get")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject[] Get()
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selGetHandle));
		}
		return NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGetHandle));
	}

	[Export("objectAtLocation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ObjectAtLocation(NSObject location)
	{
		if (location == null)
		{
			throw new ArgumentNullException("location");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectAtLocation_Handle, location.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectAtLocation_Handle, location.Handle));
	}

	[Export("objectWithID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ObjectWithID(NSObject identifier)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectWithID_Handle, identifier.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectWithID_Handle, identifier.Handle));
	}

	[Export("objectWithName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ObjectWithName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectWithName_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectWithName_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}
}

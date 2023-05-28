using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSMutableCharacterSet", true)]
public class NSMutableCharacterSet : NSCharacterSet
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddCharactersInString_ = "addCharactersInString:";

	private static readonly IntPtr selAddCharactersInString_Handle = Selector.GetHandle("addCharactersInString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormIntersectionWithCharacterSet_ = "formIntersectionWithCharacterSet:";

	private static readonly IntPtr selFormIntersectionWithCharacterSet_Handle = Selector.GetHandle("formIntersectionWithCharacterSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormUnionWithCharacterSet_ = "formUnionWithCharacterSet:";

	private static readonly IntPtr selFormUnionWithCharacterSet_Handle = Selector.GetHandle("formUnionWithCharacterSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvert = "invert";

	private static readonly IntPtr selInvertHandle = Selector.GetHandle("invert");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveCharactersInRange_ = "removeCharactersInRange:";

	private static readonly IntPtr selRemoveCharactersInRange_Handle = Selector.GetHandle("removeCharactersInRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveCharactersInString_ = "removeCharactersInString:";

	private static readonly IntPtr selRemoveCharactersInString_Handle = Selector.GetHandle("removeCharactersInString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMutableCharacterSet");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMutableCharacterSet()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSMutableCharacterSet(NSCoder coder)
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
	protected NSMutableCharacterSet(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMutableCharacterSet(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addCharactersInString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddCharacters(string aString)
	{
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddCharactersInString_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddCharactersInString_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("formIntersectionWithCharacterSet:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void IntersectWith(NSCharacterSet otherSet)
	{
		if (otherSet == null)
		{
			throw new ArgumentNullException("otherSet");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFormIntersectionWithCharacterSet_Handle, otherSet.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFormIntersectionWithCharacterSet_Handle, otherSet.Handle);
		}
	}

	[Export("invert")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Invert()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvertHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvertHandle);
		}
	}

	[Export("removeCharactersInRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveCharacters(NSRange aRange)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selRemoveCharactersInRange_Handle, aRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selRemoveCharactersInRange_Handle, aRange);
		}
	}

	[Export("removeCharactersInString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveCharacters(string aString)
	{
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveCharactersInString_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveCharactersInString_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("formUnionWithCharacterSet:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UnionWith(NSCharacterSet otherSet)
	{
		if (otherSet == null)
		{
			throw new ArgumentNullException("otherSet");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFormUnionWithCharacterSet_Handle, otherSet.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFormUnionWithCharacterSet_Handle, otherSet.Handle);
		}
	}
}

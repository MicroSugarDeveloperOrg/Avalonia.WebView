using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSMutableCharacterSet", true)]
public class NSMutableCharacterSet : NSCharacterSet
{
	private static readonly IntPtr selRemoveCharactersInRange_Handle = Selector.GetHandle("removeCharactersInRange:");

	private static readonly IntPtr selAddCharactersInString_Handle = Selector.GetHandle("addCharactersInString:");

	private static readonly IntPtr selRemoveCharactersInString_Handle = Selector.GetHandle("removeCharactersInString:");

	private static readonly IntPtr selFormUnionWithCharacterSet_Handle = Selector.GetHandle("formUnionWithCharacterSet:");

	private static readonly IntPtr selFormIntersectionWithCharacterSet_Handle = Selector.GetHandle("formIntersectionWithCharacterSet:");

	private static readonly IntPtr selInvertHandle = Selector.GetHandle("invert");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMutableCharacterSet");

	public override IntPtr ClassHandle => class_ptr;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMutableCharacterSet()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSMutableCharacterSet(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMutableCharacterSet(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMutableCharacterSet(IntPtr handle)
		: base(handle)
	{
	}

	[Export("removeCharactersInRange:")]
	public virtual void RemoveCharacters(NSRange aRange)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selRemoveCharactersInRange_Handle, aRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selRemoveCharactersInRange_Handle, aRange);
		}
	}

	[Export("addCharactersInString:")]
	public virtual void AddCharacters(string aString)
	{
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddCharactersInString_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddCharactersInString_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removeCharactersInString:")]
	public virtual void RemoveCharacters(string aString)
	{
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (IsDirectBinding)
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
	public virtual void UnionWith(NSCharacterSet otherSet)
	{
		if (otherSet == null)
		{
			throw new ArgumentNullException("otherSet");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFormUnionWithCharacterSet_Handle, otherSet.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFormUnionWithCharacterSet_Handle, otherSet.Handle);
		}
	}

	[Export("formIntersectionWithCharacterSet:")]
	public virtual void IntersectWith(NSCharacterSet otherSet)
	{
		if (otherSet == null)
		{
			throw new ArgumentNullException("otherSet");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFormIntersectionWithCharacterSet_Handle, otherSet.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFormIntersectionWithCharacterSet_Handle, otherSet.Handle);
		}
	}

	[Export("invert")]
	public virtual void Invert()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvertHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvertHandle);
		}
	}
}

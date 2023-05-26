using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSColorList", true)]
public class NSColorList : NSObject
{
	private static readonly IntPtr selAvailableColorListsHandle = Selector.GetHandle("availableColorLists");

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selIsEditableHandle = Selector.GetHandle("isEditable");

	private static readonly IntPtr selColorListNamed_Handle = Selector.GetHandle("colorListNamed:");

	private static readonly IntPtr selInitWithName_Handle = Selector.GetHandle("initWithName:");

	private static readonly IntPtr selInitWithNameFromFile_Handle = Selector.GetHandle("initWithName:fromFile:");

	private static readonly IntPtr selSetColorForKey_Handle = Selector.GetHandle("setColor:forKey:");

	private static readonly IntPtr selInsertColorKeyAtIndex_Handle = Selector.GetHandle("insertColor:key:atIndex:");

	private static readonly IntPtr selRemoveColorWithKey_Handle = Selector.GetHandle("removeColorWithKey:");

	private static readonly IntPtr selColorWithKey_Handle = Selector.GetHandle("colorWithKey:");

	private static readonly IntPtr selAllKeysHandle = Selector.GetHandle("allKeys");

	private static readonly IntPtr selWriteToFile_Handle = Selector.GetHandle("writeToFile:");

	private static readonly IntPtr selRemoveFileHandle = Selector.GetHandle("removeFile");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSColorList");

	private static object __mt_AvailableColorLists_var_static;

	public override IntPtr ClassHandle => class_ptr;

	public static NSColorList[] AvailableColorLists
	{
		[Export("availableColorLists")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColorList[])(__mt_AvailableColorLists_var_static = NSArray.ArrayFromHandle<NSColorList>(Messaging.IntPtr_objc_msgSend(class_ptr, selAvailableColorListsHandle)));
		}
	}

	public virtual string Name
	{
		[Export("name")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	public virtual bool IsEditable
	{
		[Export("isEditable")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEditableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEditableHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSColorList()
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
	public NSColorList(NSCoder coder)
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
	public NSColorList(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSColorList(IntPtr handle)
		: base(handle)
	{
	}

	[Export("colorListNamed:")]
	public static NSColorList ColorListNamed(string name)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSColorList result = (NSColorList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selColorListNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithName:")]
	public NSColorList(string name)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithName_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithName_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithName:fromFile:")]
	public NSColorList(string name, string path)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(path);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithNameFromFile_Handle, arg, arg2);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithNameFromFile_Handle, arg, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("setColor:forKey:")]
	public virtual void SetColorForKey(NSColor color, string key)
	{
		NSApplication.EnsureUIThread();
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetColorForKey_Handle, color.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetColorForKey_Handle, color.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("insertColor:key:atIndex:")]
	public virtual void InsertColor(NSColor color, string key, long indexPos)
	{
		NSApplication.EnsureUIThread();
		if (color == null)
		{
			throw new ArgumentNullException("color");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_Int64(base.Handle, selInsertColorKeyAtIndex_Handle, color.Handle, arg, indexPos);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_Int64(base.SuperHandle, selInsertColorKeyAtIndex_Handle, color.Handle, arg, indexPos);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removeColorWithKey:")]
	public virtual void RemoveColor(string key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveColorWithKey_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveColorWithKey_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("colorWithKey:")]
	public virtual NSColor ColorWithKey(string key)
	{
		NSApplication.EnsureUIThread();
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSColor result = ((!IsDirectBinding) ? ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selColorWithKey_Handle, arg))) : ((NSColor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selColorWithKey_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("allKeys")]
	public virtual string[] AllKeys()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAllKeysHandle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllKeysHandle));
	}

	[Export("writeToFile:")]
	public virtual bool WriteToFile(string path)
	{
		NSApplication.EnsureUIThread();
		IntPtr arg = NSString.CreateNative(path);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selWriteToFile_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selWriteToFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("removeFile")]
	public virtual void RemoveFile()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveFileHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveFileHandle);
		}
	}
}

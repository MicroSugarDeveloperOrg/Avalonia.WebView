using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSKeyedArchiver", true)]
public class NSKeyedArchiver : NSCoder
{
	[Register]
	private sealed class _NSKeyedArchiverDelegate : NSKeyedArchiverDelegate
	{
		internal EventHandler<NSObjectEventArgs> encodedObject;

		internal EventHandler finished;

		internal NSEncodeHook willEncode;

		internal EventHandler finishing;

		internal EventHandler<NSArchiveReplaceEventArgs> replacingObject;

		[Preserve(Conditional = true)]
		public override void EncodedObject(NSKeyedArchiver archiver, NSObject obj)
		{
			EventHandler<NSObjectEventArgs> eventHandler = encodedObject;
			if (eventHandler != null)
			{
				NSObjectEventArgs e = new NSObjectEventArgs(obj);
				eventHandler(archiver, e);
			}
		}

		[Preserve(Conditional = true)]
		public override void Finished(NSKeyedArchiver archiver)
		{
			finished?.Invoke(archiver, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override NSObject WillEncode(NSKeyedArchiver archiver, NSObject obj)
		{
			return willEncode?.Invoke(archiver, obj);
		}

		[Preserve(Conditional = true)]
		public override void Finishing(NSKeyedArchiver archiver)
		{
			finishing?.Invoke(archiver, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void ReplacingObject(NSKeyedArchiver archiver, NSObject oldObject, NSObject newObject)
		{
			EventHandler<NSArchiveReplaceEventArgs> eventHandler = replacingObject;
			if (eventHandler != null)
			{
				NSArchiveReplaceEventArgs e = new NSArchiveReplaceEventArgs(oldObject, newObject);
				eventHandler(archiver, e);
			}
		}
	}

	private static readonly IntPtr selOutputFormatHandle = Selector.GetHandle("outputFormat");

	private static readonly IntPtr selSetOutputFormat_Handle = Selector.GetHandle("setOutputFormat:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selInitForWritingWithMutableData_Handle = Selector.GetHandle("initForWritingWithMutableData:");

	private static readonly IntPtr selArchivedDataWithRootObject_Handle = Selector.GetHandle("archivedDataWithRootObject:");

	private static readonly IntPtr selArchiveRootObjectToFile_Handle = Selector.GetHandle("archiveRootObject:toFile:");

	private static readonly IntPtr selFinishEncodingHandle = Selector.GetHandle("finishEncoding");

	private static readonly IntPtr selSetClassNameForClass_Handle = Selector.GetHandle("setClassName:forClass:");

	private static readonly IntPtr selClassNameForClass_Handle = Selector.GetHandle("classNameForClass:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSKeyedArchiver");

	private object __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSPropertyListFormat PropertyListFormat
	{
		[Export("outputFormat")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSPropertyListFormat)Messaging.UInt64_objc_msgSend(base.Handle, selOutputFormatHandle);
			}
			return (NSPropertyListFormat)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selOutputFormatHandle);
		}
		[Export("setOutputFormat:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetOutputFormat_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetOutputFormat_Handle, (ulong)value);
			}
		}
	}

	public NSKeyedArchiverDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSKeyedArchiverDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public NSEncodeHook WillEncode
	{
		get
		{
			return EnsureNSKeyedArchiverDelegate().willEncode;
		}
		set
		{
			EnsureNSKeyedArchiverDelegate().willEncode = value;
		}
	}

	public event EventHandler<NSObjectEventArgs> EncodedObject
	{
		add
		{
			_NSKeyedArchiverDelegate nSKeyedArchiverDelegate = EnsureNSKeyedArchiverDelegate();
			nSKeyedArchiverDelegate.encodedObject = (EventHandler<NSObjectEventArgs>)System.Delegate.Combine(nSKeyedArchiverDelegate.encodedObject, value);
		}
		remove
		{
			_NSKeyedArchiverDelegate nSKeyedArchiverDelegate = EnsureNSKeyedArchiverDelegate();
			nSKeyedArchiverDelegate.encodedObject = (EventHandler<NSObjectEventArgs>)System.Delegate.Remove(nSKeyedArchiverDelegate.encodedObject, value);
		}
	}

	public event EventHandler Finished
	{
		add
		{
			_NSKeyedArchiverDelegate nSKeyedArchiverDelegate = EnsureNSKeyedArchiverDelegate();
			nSKeyedArchiverDelegate.finished = (EventHandler)System.Delegate.Combine(nSKeyedArchiverDelegate.finished, value);
		}
		remove
		{
			_NSKeyedArchiverDelegate nSKeyedArchiverDelegate = EnsureNSKeyedArchiverDelegate();
			nSKeyedArchiverDelegate.finished = (EventHandler)System.Delegate.Remove(nSKeyedArchiverDelegate.finished, value);
		}
	}

	public event EventHandler Finishing
	{
		add
		{
			_NSKeyedArchiverDelegate nSKeyedArchiverDelegate = EnsureNSKeyedArchiverDelegate();
			nSKeyedArchiverDelegate.finishing = (EventHandler)System.Delegate.Combine(nSKeyedArchiverDelegate.finishing, value);
		}
		remove
		{
			_NSKeyedArchiverDelegate nSKeyedArchiverDelegate = EnsureNSKeyedArchiverDelegate();
			nSKeyedArchiverDelegate.finishing = (EventHandler)System.Delegate.Remove(nSKeyedArchiverDelegate.finishing, value);
		}
	}

	public event EventHandler<NSArchiveReplaceEventArgs> ReplacingObject
	{
		add
		{
			_NSKeyedArchiverDelegate nSKeyedArchiverDelegate = EnsureNSKeyedArchiverDelegate();
			nSKeyedArchiverDelegate.replacingObject = (EventHandler<NSArchiveReplaceEventArgs>)System.Delegate.Combine(nSKeyedArchiverDelegate.replacingObject, value);
		}
		remove
		{
			_NSKeyedArchiverDelegate nSKeyedArchiverDelegate = EnsureNSKeyedArchiverDelegate();
			nSKeyedArchiverDelegate.replacingObject = (EventHandler<NSArchiveReplaceEventArgs>)System.Delegate.Remove(nSKeyedArchiverDelegate.replacingObject, value);
		}
	}

	public static void GlobalSetClassName(string name, Class kls)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (kls == null)
		{
			throw new ArgumentNullException("kls");
		}
		NSString nSString = new NSString(name);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selSetClassNameForClass_Handle, nSString.Handle, kls.Handle);
		nSString.Dispose();
	}

	public static string GlobalGetClassName(Class kls)
	{
		if (kls == null)
		{
			throw new ArgumentNullException("kls");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selClassNameForClass_Handle, kls.Handle));
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSKeyedArchiver(NSCoder coder)
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
	public NSKeyedArchiver(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSKeyedArchiver(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initForWritingWithMutableData:")]
	public NSKeyedArchiver(NSMutableData data)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitForWritingWithMutableData_Handle, data.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitForWritingWithMutableData_Handle, data.Handle);
		}
	}

	[Export("archivedDataWithRootObject:")]
	public static NSData ArchivedDataWithRootObject(NSObject root)
	{
		if (root == null)
		{
			throw new ArgumentNullException("root");
		}
		return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selArchivedDataWithRootObject_Handle, root.Handle));
	}

	[Export("archiveRootObject:toFile:")]
	public static bool ArchiveRootObjectToFile(NSObject root, string file)
	{
		if (root == null)
		{
			throw new ArgumentNullException("root");
		}
		if (file == null)
		{
			throw new ArgumentNullException("file");
		}
		IntPtr arg = NSString.CreateNative(file);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(class_ptr, selArchiveRootObjectToFile_Handle, root.Handle, arg);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("finishEncoding")]
	public virtual void FinishEncoding()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFinishEncodingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFinishEncodingHandle);
		}
	}

	[Export("setClassName:forClass:")]
	public virtual void SetClassName(string name, Class kls)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (kls == null)
		{
			throw new ArgumentNullException("kls");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetClassNameForClass_Handle, arg, kls.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetClassNameForClass_Handle, arg, kls.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("classNameForClass:")]
	public virtual string GetClassName(Class kls)
	{
		if (kls == null)
		{
			throw new ArgumentNullException("kls");
		}
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selClassNameForClass_Handle, kls.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selClassNameForClass_Handle, kls.Handle));
	}

	private _NSKeyedArchiverDelegate EnsureNSKeyedArchiverDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _NSKeyedArchiverDelegate))
		{
			nSObject = (WeakDelegate = new _NSKeyedArchiverDelegate());
		}
		return (_NSKeyedArchiverDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}

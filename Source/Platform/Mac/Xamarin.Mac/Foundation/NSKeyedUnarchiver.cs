using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSKeyedUnarchiver", true)]
public class NSKeyedUnarchiver : NSCoder
{
	[Register]
	private sealed class _NSKeyedUnarchiverDelegate : NSKeyedUnarchiverDelegate
	{
		internal NSDecoderCallback decodedObject;

		internal EventHandler finished;

		internal NSDecoderHandler cannotDecodeClass;

		internal EventHandler finishing;

		internal EventHandler<NSArchiveReplaceEventArgs> replacingObject;

		[Preserve(Conditional = true)]
		public override NSObject DecodedObject(NSKeyedUnarchiver unarchiver, NSObject obj)
		{
			return decodedObject?.Invoke(unarchiver, obj);
		}

		[Preserve(Conditional = true)]
		public override void Finished(NSKeyedUnarchiver unarchiver)
		{
			finished?.Invoke(unarchiver, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override Class CannotDecodeClass(NSKeyedUnarchiver unarchiver, string klass, string[] classes)
		{
			return cannotDecodeClass?.Invoke(unarchiver, klass, classes);
		}

		[Preserve(Conditional = true)]
		public override void Finishing(NSKeyedUnarchiver unarchiver)
		{
			finishing?.Invoke(unarchiver, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		public override void ReplacingObject(NSKeyedUnarchiver unarchiver, NSObject oldObject, NSObject newObject)
		{
			EventHandler<NSArchiveReplaceEventArgs> eventHandler = replacingObject;
			if (eventHandler != null)
			{
				NSArchiveReplaceEventArgs e = new NSArchiveReplaceEventArgs(oldObject, newObject);
				eventHandler(unarchiver, e);
			}
		}
	}

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selInitForReadingWithData_Handle = Selector.GetHandle("initForReadingWithData:");

	private static readonly IntPtr selUnarchiveObjectWithData_Handle = Selector.GetHandle("unarchiveObjectWithData:");

	private static readonly IntPtr selUnarchiveObjectWithFile_Handle = Selector.GetHandle("unarchiveObjectWithFile:");

	private static readonly IntPtr selFinishDecodingHandle = Selector.GetHandle("finishDecoding");

	private static readonly IntPtr selSetClassForClassName_Handle = Selector.GetHandle("setClass:forClassName:");

	private static readonly IntPtr selClassForClassName_Handle = Selector.GetHandle("classForClassName:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSKeyedUnarchiver");

	private object __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public NSKeyedUnarchiverDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSKeyedUnarchiverDelegate;
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

	public NSDecoderCallback DecodedObject
	{
		get
		{
			return EnsureNSKeyedUnarchiverDelegate().decodedObject;
		}
		set
		{
			EnsureNSKeyedUnarchiverDelegate().decodedObject = value;
		}
	}

	public NSDecoderHandler CannotDecodeClass
	{
		get
		{
			return EnsureNSKeyedUnarchiverDelegate().cannotDecodeClass;
		}
		set
		{
			EnsureNSKeyedUnarchiverDelegate().cannotDecodeClass = value;
		}
	}

	public event EventHandler Finished
	{
		add
		{
			_NSKeyedUnarchiverDelegate nSKeyedUnarchiverDelegate = EnsureNSKeyedUnarchiverDelegate();
			nSKeyedUnarchiverDelegate.finished = (EventHandler)System.Delegate.Combine(nSKeyedUnarchiverDelegate.finished, value);
		}
		remove
		{
			_NSKeyedUnarchiverDelegate nSKeyedUnarchiverDelegate = EnsureNSKeyedUnarchiverDelegate();
			nSKeyedUnarchiverDelegate.finished = (EventHandler)System.Delegate.Remove(nSKeyedUnarchiverDelegate.finished, value);
		}
	}

	public event EventHandler Finishing
	{
		add
		{
			_NSKeyedUnarchiverDelegate nSKeyedUnarchiverDelegate = EnsureNSKeyedUnarchiverDelegate();
			nSKeyedUnarchiverDelegate.finishing = (EventHandler)System.Delegate.Combine(nSKeyedUnarchiverDelegate.finishing, value);
		}
		remove
		{
			_NSKeyedUnarchiverDelegate nSKeyedUnarchiverDelegate = EnsureNSKeyedUnarchiverDelegate();
			nSKeyedUnarchiverDelegate.finishing = (EventHandler)System.Delegate.Remove(nSKeyedUnarchiverDelegate.finishing, value);
		}
	}

	public event EventHandler<NSArchiveReplaceEventArgs> ReplacingObject
	{
		add
		{
			_NSKeyedUnarchiverDelegate nSKeyedUnarchiverDelegate = EnsureNSKeyedUnarchiverDelegate();
			nSKeyedUnarchiverDelegate.replacingObject = (EventHandler<NSArchiveReplaceEventArgs>)System.Delegate.Combine(nSKeyedUnarchiverDelegate.replacingObject, value);
		}
		remove
		{
			_NSKeyedUnarchiverDelegate nSKeyedUnarchiverDelegate = EnsureNSKeyedUnarchiverDelegate();
			nSKeyedUnarchiverDelegate.replacingObject = (EventHandler<NSArchiveReplaceEventArgs>)System.Delegate.Remove(nSKeyedUnarchiverDelegate.replacingObject, value);
		}
	}

	public static void GlobalSetClass(Class kls, string codedName)
	{
		if (codedName == null)
		{
			throw new ArgumentNullException("codedName");
		}
		if (kls == null)
		{
			throw new ArgumentNullException("kls");
		}
		using NSString nSString = new NSString(codedName);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selSetClassForClassName_Handle, kls.Handle, nSString.Handle);
	}

	public static Class GlobalGetClass(string codedName)
	{
		if (codedName == null)
		{
			throw new ArgumentNullException("codedName");
		}
		using NSString nSString = new NSString(codedName);
		return new Class(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selClassForClassName_Handle, nSString.Handle));
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSKeyedUnarchiver(NSCoder coder)
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
	public NSKeyedUnarchiver(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSKeyedUnarchiver(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initForReadingWithData:")]
	public NSKeyedUnarchiver(NSData data)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitForReadingWithData_Handle, data.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitForReadingWithData_Handle, data.Handle);
		}
	}

	[Export("unarchiveObjectWithData:")]
	public static NSObject UnarchiveObject(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selUnarchiveObjectWithData_Handle, data.Handle));
	}

	[Export("unarchiveObjectWithFile:")]
	public static NSObject UnarchiveFile(string file)
	{
		if (file == null)
		{
			throw new ArgumentNullException("file");
		}
		IntPtr arg = NSString.CreateNative(file);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selUnarchiveObjectWithFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("finishDecoding")]
	public virtual void FinishDecoding()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFinishDecodingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFinishDecodingHandle);
		}
	}

	[Export("setClass:forClassName:")]
	public virtual void SetClass(Class kls, string codedName)
	{
		if (kls == null)
		{
			throw new ArgumentNullException("kls");
		}
		if (codedName == null)
		{
			throw new ArgumentNullException("codedName");
		}
		IntPtr arg = NSString.CreateNative(codedName);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetClassForClassName_Handle, kls.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetClassForClassName_Handle, kls.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("classForClassName:")]
	public virtual Class GetClass(string codedName)
	{
		if (codedName == null)
		{
			throw new ArgumentNullException("codedName");
		}
		IntPtr arg = NSString.CreateNative(codedName);
		Class result = ((!IsDirectBinding) ? new Class(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selClassForClassName_Handle, arg)) : new Class(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selClassForClassName_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	private _NSKeyedUnarchiverDelegate EnsureNSKeyedUnarchiverDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _NSKeyedUnarchiverDelegate))
		{
			nSObject = (WeakDelegate = new _NSKeyedUnarchiverDelegate());
		}
		return (_NSKeyedUnarchiverDelegate)nSObject;
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

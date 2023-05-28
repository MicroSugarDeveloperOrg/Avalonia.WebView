using System;
using System.ComponentModel;
using AppKit;
using ObjCRuntime;

namespace Foundation;

[Register("NSKeyedUnarchiver", true)]
public class NSKeyedUnarchiver : NSCoder
{
	[Register]
	internal class _NSKeyedUnarchiverDelegate : NSObject, INSKeyedUnarchiverDelegate, INativeObject, IDisposable
	{
		internal NSDecoderHandler? cannotDecodeClass;

		internal NSDecoderCallback? decodedObject;

		internal EventHandler? finished;

		internal EventHandler? finishing;

		internal EventHandler<NSArchiveReplaceEventArgs>? replacingObject;

		public _NSKeyedUnarchiverDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("unarchiver:cannotDecodeObjectOfClassName:originalClasses:")]
		public Class CannotDecodeClass(NSKeyedUnarchiver unarchiver, string klass, string[] classes)
		{
			return cannotDecodeClass?.Invoke(unarchiver, klass, classes);
		}

		[Preserve(Conditional = true)]
		[Export("unarchiver:didDecodeObject:")]
		public NSObject DecodedObject(NSKeyedUnarchiver unarchiver, NSObject obj)
		{
			return decodedObject?.Invoke(unarchiver, obj);
		}

		[Preserve(Conditional = true)]
		[Export("unarchiverDidFinish:")]
		public void Finished(NSKeyedUnarchiver unarchiver)
		{
			finished?.Invoke(unarchiver, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("unarchiverWillFinish:")]
		public void Finishing(NSKeyedUnarchiver unarchiver)
		{
			finishing?.Invoke(unarchiver, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("unarchiver:willReplaceObject:withObject:")]
		public void ReplacingObject(NSKeyedUnarchiver unarchiver, NSObject oldObject, NSObject newObject)
		{
			EventHandler<NSArchiveReplaceEventArgs> eventHandler = replacingObject;
			if (eventHandler != null)
			{
				NSArchiveReplaceEventArgs e = new NSArchiveReplaceEventArgs(oldObject, newObject);
				eventHandler(unarchiver, e);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClassForClassName_ = "classForClassName:";

	private static readonly IntPtr selClassForClassName_Handle = Selector.GetHandle("classForClassName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFinishDecoding = "finishDecoding";

	private static readonly IntPtr selFinishDecodingHandle = Selector.GetHandle("finishDecoding");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitForReadingFromData_Error_ = "initForReadingFromData:error:";

	private static readonly IntPtr selInitForReadingFromData_Error_Handle = Selector.GetHandle("initForReadingFromData:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitForReadingWithData_ = "initForReadingWithData:";

	private static readonly IntPtr selInitForReadingWithData_Handle = Selector.GetHandle("initForReadingWithData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequiresSecureCoding = "requiresSecureCoding";

	private static readonly IntPtr selRequiresSecureCodingHandle = Selector.GetHandle("requiresSecureCoding");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClass_ForClassName_ = "setClass:forClassName:";

	private static readonly IntPtr selSetClass_ForClassName_Handle = Selector.GetHandle("setClass:forClassName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRequiresSecureCoding_ = "setRequiresSecureCoding:";

	private static readonly IntPtr selSetRequiresSecureCoding_Handle = Selector.GetHandle("setRequiresSecureCoding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnarchiveObjectWithData_ = "unarchiveObjectWithData:";

	private static readonly IntPtr selUnarchiveObjectWithData_Handle = Selector.GetHandle("unarchiveObjectWithData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnarchiveObjectWithFile_ = "unarchiveObjectWithFile:";

	private static readonly IntPtr selUnarchiveObjectWithFile_Handle = Selector.GetHandle("unarchiveObjectWithFile:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnarchiveTopLevelObjectWithData_Error_ = "unarchiveTopLevelObjectWithData:error:";

	private static readonly IntPtr selUnarchiveTopLevelObjectWithData_Error_Handle = Selector.GetHandle("unarchiveTopLevelObjectWithData:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnarchivedObjectOfClass_FromData_Error_ = "unarchivedObjectOfClass:fromData:error:";

	private static readonly IntPtr selUnarchivedObjectOfClass_FromData_Error_Handle = Selector.GetHandle("unarchivedObjectOfClass:fromData:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnarchivedObjectOfClasses_FromData_Error_ = "unarchivedObjectOfClasses:fromData:error:";

	private static readonly IntPtr selUnarchivedObjectOfClasses_FromData_Error_Handle = Selector.GetHandle("unarchivedObjectOfClasses:fromData:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSKeyedUnarchiver");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public new bool RequiresSecureCoding
	{
		get
		{
			return GetRequiresSecureCoding();
		}
		set
		{
			SetRequiresSecureCoding(value);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSKeyedUnarchiverDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSKeyedUnarchiverDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_NSKeyedUnarchiverDelegate);

	public NSDecoderHandler? CannotDecodeClass
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

	public NSDecoderCallback? DecodedObject
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, Selector.GetHandle("setClass:forClassName:"), kls.Handle, nSString.Handle);
	}

	public static Class GlobalGetClass(string codedName)
	{
		if (codedName == null)
		{
			throw new ArgumentNullException("codedName");
		}
		using NSString nSString = new NSString(codedName);
		return new Class(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, Selector.GetHandle("classForClassName:"), nSString.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSKeyedUnarchiver(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSKeyedUnarchiver(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initForReadingFromData:error:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSKeyedUnarchiver(NSData data, out NSError? error)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitForReadingFromData_Error_Handle, data.Handle, ref arg), "initForReadingFromData:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitForReadingFromData_Error_Handle, data.Handle, ref arg), "initForReadingFromData:error:");
		}
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("initForReadingWithData:")]
	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'NSKeyedUnarchiver (NSData, out NSError)' instead.")]
	[Deprecated(PlatformName.WatchOS, 5, 0, PlatformArchitecture.None, "Use 'NSKeyedUnarchiver (NSData, out NSError)' instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'NSKeyedUnarchiver (NSData, out NSError)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSKeyedUnarchiver (NSData, out NSError)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSKeyedUnarchiver(NSData data)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		try
		{
			if (base.IsDirectBinding)
			{
				InitializeHandle(Messaging.xamarin_IntPtr_objc_msgSend_IntPtr(base.Handle, selInitForReadingWithData_Handle, data.Handle), "initForReadingWithData:");
			}
			else
			{
				InitializeHandle(Messaging.xamarin_IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitForReadingWithData_Handle, data.Handle), "initForReadingWithData:");
			}
		}
		catch
		{
			base.Handle = IntPtr.Zero;
			throw;
		}
	}

	[Export("finishDecoding")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FinishDecoding()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFinishDecodingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFinishDecodingHandle);
		}
	}

	[Export("classForClassName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Class? GetClass(string codedName)
	{
		if (codedName == null)
		{
			throw new ArgumentNullException("codedName");
		}
		IntPtr arg = NSString.CreateNative(codedName);
		IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selClassForClassName_Handle, arg) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selClassForClassName_Handle, arg));
		NSString.ReleaseNative(arg);
		return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
	}

	[Export("requiresSecureCoding")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GetRequiresSecureCoding()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selRequiresSecureCodingHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRequiresSecureCodingHandle);
	}

	[Export("unarchivedObjectOfClass:fromData:error:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject? GetUnarchivedObject(Class cls, NSData data, out NSError? error)
	{
		if (cls == null)
		{
			throw new ArgumentNullException("cls");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selUnarchivedObjectOfClass_FromData_Error_Handle, cls.Handle, data.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject? GetUnarchivedObject(Type type, NSData data, out NSError? error)
	{
		return GetUnarchivedObject(new Class(type), data, out error);
	}

	[Export("unarchivedObjectOfClasses:fromData:error:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject? GetUnarchivedObject(NSSet<Class> classes, NSData data, out NSError? error)
	{
		if (classes == null)
		{
			throw new ArgumentNullException("classes");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selUnarchivedObjectOfClasses_FromData_Error_Handle, classes.Handle, data.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject? GetUnarchivedObject(Type[] types, NSData data, out NSError? error)
	{
		return GetUnarchivedObject(new NSSet<Class>(Array.ConvertAll(types, (Type t) => new Class(t))), data, out error);
	}

	[Export("setClass:forClassName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetClass_ForClassName_Handle, kls.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetClass_ForClassName_Handle, kls.Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setRequiresSecureCoding:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetRequiresSecureCoding(bool requireSecureEncoding)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selSetRequiresSecureCoding_Handle, requireSecureEncoding);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRequiresSecureCoding_Handle, requireSecureEncoding);
		}
	}

	[Export("unarchiveObjectWithFile:")]
	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'GetUnarchivedObject ()' instead.")]
	[Deprecated(PlatformName.WatchOS, 5, 0, PlatformArchitecture.None, "Use 'GetUnarchivedObject ()' instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'GetUnarchivedObject ()' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'GetUnarchivedObject ()' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject UnarchiveFile(string file)
	{
		if (file == null)
		{
			throw new ArgumentNullException("file");
		}
		IntPtr arg = NSString.CreateNative(file);
		NSObject nSObject = Runtime.GetNSObject(Messaging.xamarin_IntPtr_objc_msgSend_IntPtr(class_ptr, selUnarchiveObjectWithFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("unarchiveObjectWithData:")]
	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'GetUnarchivedObject ()' instead.")]
	[Deprecated(PlatformName.WatchOS, 5, 0, PlatformArchitecture.None, "Use 'GetUnarchivedObject ()' instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'GetUnarchivedObject ()' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'GetUnarchivedObject ()' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject UnarchiveObject(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Runtime.GetNSObject(Messaging.xamarin_IntPtr_objc_msgSend_IntPtr(class_ptr, selUnarchiveObjectWithData_Handle, data.Handle));
	}

	[Export("unarchiveTopLevelObjectWithData:error:")]
	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'GetUnarchivedObject ()' instead.")]
	[Deprecated(PlatformName.WatchOS, 5, 0, PlatformArchitecture.None, "Use 'GetUnarchivedObject ()' instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'GetUnarchivedObject ()' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'GetUnarchivedObject ()' instead.")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject UnarchiveTopLevelObject(NSData data, out NSError error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selUnarchiveTopLevelObjectWithData_Error_Handle, data.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	internal virtual _NSKeyedUnarchiverDelegate CreateInternalEventDelegateType()
	{
		return new _NSKeyedUnarchiverDelegate();
	}

	internal _NSKeyedUnarchiverDelegate EnsureNSKeyedUnarchiverDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSKeyedUnarchiverDelegate nSKeyedUnarchiverDelegate = Delegate as _NSKeyedUnarchiverDelegate;
		if (nSKeyedUnarchiverDelegate == null)
		{
			nSKeyedUnarchiverDelegate = (_NSKeyedUnarchiverDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSKeyedUnarchiverDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}

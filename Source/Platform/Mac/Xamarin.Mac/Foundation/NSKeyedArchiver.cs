using System;
using System.ComponentModel;
using AppKit;
using ObjCRuntime;

namespace Foundation;

[Register("NSKeyedArchiver", true)]
public class NSKeyedArchiver : NSCoder
{
	[Register]
	internal class _NSKeyedArchiverDelegate : NSObject, INSKeyedArchiverDelegate, INativeObject, IDisposable
	{
		internal EventHandler<NSObjectEventArgs>? encodedObject;

		internal EventHandler? finished;

		internal EventHandler? finishing;

		internal EventHandler<NSArchiveReplaceEventArgs>? replacingObject;

		internal NSEncodeHook? willEncode;

		public _NSKeyedArchiverDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("archiver:didEncodeObject:")]
		public void EncodedObject(NSKeyedArchiver archiver, NSObject obj)
		{
			EventHandler<NSObjectEventArgs> eventHandler = encodedObject;
			if (eventHandler != null)
			{
				NSObjectEventArgs e = new NSObjectEventArgs(obj);
				eventHandler(archiver, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("archiverDidFinish:")]
		public void Finished(NSKeyedArchiver archiver)
		{
			finished?.Invoke(archiver, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("archiverWillFinish:")]
		public void Finishing(NSKeyedArchiver archiver)
		{
			finishing?.Invoke(archiver, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("archiver:willReplaceObject:withObject:")]
		public void ReplacingObject(NSKeyedArchiver archiver, NSObject oldObject, NSObject newObject)
		{
			EventHandler<NSArchiveReplaceEventArgs> eventHandler = replacingObject;
			if (eventHandler != null)
			{
				NSArchiveReplaceEventArgs e = new NSArchiveReplaceEventArgs(oldObject, newObject);
				eventHandler(archiver, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("archiver:willEncodeObject:")]
		public NSObject WillEncode(NSKeyedArchiver archiver, NSObject obj)
		{
			return willEncode?.Invoke(archiver, obj);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArchiveRootObject_ToFile_ = "archiveRootObject:toFile:";

	private static readonly IntPtr selArchiveRootObject_ToFile_Handle = Selector.GetHandle("archiveRootObject:toFile:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArchivedDataWithRootObject_ = "archivedDataWithRootObject:";

	private static readonly IntPtr selArchivedDataWithRootObject_Handle = Selector.GetHandle("archivedDataWithRootObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArchivedDataWithRootObject_RequiringSecureCoding_Error_ = "archivedDataWithRootObject:requiringSecureCoding:error:";

	private static readonly IntPtr selArchivedDataWithRootObject_RequiringSecureCoding_Error_Handle = Selector.GetHandle("archivedDataWithRootObject:requiringSecureCoding:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClassNameForClass_ = "classNameForClass:";

	private static readonly IntPtr selClassNameForClass_Handle = Selector.GetHandle("classNameForClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodedData = "encodedData";

	private static readonly IntPtr selEncodedDataHandle = Selector.GetHandle("encodedData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFinishEncoding = "finishEncoding";

	private static readonly IntPtr selFinishEncodingHandle = Selector.GetHandle("finishEncoding");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitForWritingWithMutableData_ = "initForWritingWithMutableData:";

	private static readonly IntPtr selInitForWritingWithMutableData_Handle = Selector.GetHandle("initForWritingWithMutableData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitRequiringSecureCoding_ = "initRequiringSecureCoding:";

	private static readonly IntPtr selInitRequiringSecureCoding_Handle = Selector.GetHandle("initRequiringSecureCoding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputFormat = "outputFormat";

	private static readonly IntPtr selOutputFormatHandle = Selector.GetHandle("outputFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequiresSecureCoding = "requiresSecureCoding";

	private static readonly IntPtr selRequiresSecureCodingHandle = Selector.GetHandle("requiresSecureCoding");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClassName_ForClass_ = "setClassName:forClass:";

	private static readonly IntPtr selSetClassName_ForClass_Handle = Selector.GetHandle("setClassName:forClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOutputFormat_ = "setOutputFormat:";

	private static readonly IntPtr selSetOutputFormat_Handle = Selector.GetHandle("setOutputFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRequiresSecureCoding_ = "setRequiresSecureCoding:";

	private static readonly IntPtr selSetRequiresSecureCoding_Handle = Selector.GetHandle("setRequiresSecureCoding:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSKeyedArchiver");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RootObjectKey;

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
	public INSKeyedArchiverDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSKeyedArchiverDelegate;
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
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual NSData EncodedData
	{
		[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("encodedData", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selEncodedDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEncodedDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPropertyListFormat PropertyListFormat
	{
		[Export("outputFormat")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSPropertyListFormat)Messaging.UInt64_objc_msgSend(base.Handle, selOutputFormatHandle);
			}
			return (NSPropertyListFormat)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selOutputFormatHandle);
		}
		[Export("setOutputFormat:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetOutputFormat_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetOutputFormat_Handle, (ulong)value);
			}
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

	[Field("NSKeyedArchiveRootObjectKey", "Foundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString RootObjectKey
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_RootObjectKey == null)
			{
				_RootObjectKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSKeyedArchiveRootObjectKey");
			}
			return _RootObjectKey;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_NSKeyedArchiverDelegate);

	public NSEncodeHook? WillEncode
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, Selector.GetHandle("setClassName:forClass:"), nSString.Handle, kls.Handle);
		nSString.Dispose();
	}

	public static string GlobalGetClassName(Class kls)
	{
		if (kls == null)
		{
			throw new ArgumentNullException("kls");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, Selector.GetHandle("classNameForClass:"), kls.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSKeyedArchiver(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSKeyedArchiver(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initRequiringSecureCoding:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSKeyedArchiver(bool requiresSecureCoding)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_bool(base.Handle, selInitRequiringSecureCoding_Handle, requiresSecureCoding), "initRequiringSecureCoding:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_bool(base.SuperHandle, selInitRequiringSecureCoding_Handle, requiresSecureCoding), "initRequiringSecureCoding:");
		}
	}

	[Export("init")]
	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'NSKeyedArchiver (bool)' instead.")]
	[Deprecated(PlatformName.WatchOS, 5, 0, PlatformArchitecture.None, "Use 'NSKeyedArchiver (bool)' instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'NSKeyedArchiver (bool)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSKeyedArchiver (bool)' instead.")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSKeyedArchiver()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInitHandle), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitHandle), "init");
		}
	}

	[Export("initForWritingWithMutableData:")]
	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'NSKeyedArchiver (bool)' instead.")]
	[Deprecated(PlatformName.WatchOS, 5, 0, PlatformArchitecture.None, "Use 'NSKeyedArchiver (bool)' instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'NSKeyedArchiver (bool)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'NSKeyedArchiver (bool)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSKeyedArchiver(NSMutableData data)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitForWritingWithMutableData_Handle, data.Handle), "initForWritingWithMutableData:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitForWritingWithMutableData_Handle, data.Handle), "initForWritingWithMutableData:");
		}
	}

	[Export("archiveRootObject:toFile:")]
	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'ArchivedDataWithRootObject (NSObject, bool, out NSError)' instead.")]
	[Deprecated(PlatformName.WatchOS, 5, 0, PlatformArchitecture.None, "Use 'ArchivedDataWithRootObject (NSObject, bool, out NSError)' instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'ArchivedDataWithRootObject (NSObject, bool, out NSError)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'ArchivedDataWithRootObject (NSObject, bool, out NSError)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(class_ptr, selArchiveRootObject_ToFile_Handle, root.Handle, arg);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("archivedDataWithRootObject:requiringSecureCoding:error:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData? ArchivedDataWithRootObject(NSObject @object, bool requiresSecureCoding, out NSError? error)
	{
		if (@object == null)
		{
			throw new ArgumentNullException("@object");
		}
		IntPtr arg = IntPtr.Zero;
		NSData nSObject = Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr_bool_ref_IntPtr(class_ptr, selArchivedDataWithRootObject_RequiringSecureCoding_Error_Handle, @object.Handle, requiresSecureCoding, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("archivedDataWithRootObject:")]
	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'ArchivedDataWithRootObject (NSObject, bool, out NSError)' instead.")]
	[Deprecated(PlatformName.WatchOS, 5, 0, PlatformArchitecture.None, "Use 'ArchivedDataWithRootObject (NSObject, bool, out NSError)' instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'ArchivedDataWithRootObject (NSObject, bool, out NSError)' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'ArchivedDataWithRootObject (NSObject, bool, out NSError)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSData ArchivedDataWithRootObject(NSObject root)
	{
		if (root == null)
		{
			throw new ArgumentNullException("root");
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selArchivedDataWithRootObject_Handle, root.Handle));
	}

	[Export("finishEncoding")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FinishEncoding()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFinishEncodingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFinishEncodingHandle);
		}
	}

	[Export("classNameForClass:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetClassName(Class kls)
	{
		if (kls == null)
		{
			throw new ArgumentNullException("kls");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selClassNameForClass_Handle, kls.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selClassNameForClass_Handle, kls.Handle));
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

	[Export("setClassName:forClass:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetClassName_ForClass_Handle, arg, kls.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetClassName_ForClass_Handle, arg, kls.Handle);
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

	internal virtual _NSKeyedArchiverDelegate CreateInternalEventDelegateType()
	{
		return new _NSKeyedArchiverDelegate();
	}

	internal _NSKeyedArchiverDelegate EnsureNSKeyedArchiverDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSKeyedArchiverDelegate nSKeyedArchiverDelegate = Delegate as _NSKeyedArchiverDelegate;
		if (nSKeyedArchiverDelegate == null)
		{
			nSKeyedArchiverDelegate = (_NSKeyedArchiverDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSKeyedArchiverDelegate;
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

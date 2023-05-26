using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Contacts;

[Register("CNContactFetchRequest", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class CNContactFetchRequest : CNFetchRequest, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	private static IntPtr nsobject;

	private static IntPtr nssecurecoding;

	private static IntPtr nscopying;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithKeysToFetch_ = "initWithKeysToFetch:";

	private static readonly IntPtr selInitWithKeysToFetch_Handle = Selector.GetHandle("initWithKeysToFetch:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKeysToFetch = "keysToFetch";

	private static readonly IntPtr selKeysToFetchHandle = Selector.GetHandle("keysToFetch");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMutableObjects = "mutableObjects";

	private static readonly IntPtr selMutableObjectsHandle = Selector.GetHandle("mutableObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPredicate = "predicate";

	private static readonly IntPtr selPredicateHandle = Selector.GetHandle("predicate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetKeysToFetch_ = "setKeysToFetch:";

	private static readonly IntPtr selSetKeysToFetch_Handle = Selector.GetHandle("setKeysToFetch:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMutableObjects_ = "setMutableObjects:";

	private static readonly IntPtr selSetMutableObjects_Handle = Selector.GetHandle("setMutableObjects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPredicate_ = "setPredicate:";

	private static readonly IntPtr selSetPredicate_Handle = Selector.GetHandle("setPredicate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSortOrder_ = "setSortOrder:";

	private static readonly IntPtr selSetSortOrder_Handle = Selector.GetHandle("setSortOrder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUnifyResults_ = "setUnifyResults:";

	private static readonly IntPtr selSetUnifyResults_Handle = Selector.GetHandle("setUnifyResults:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSortOrder = "sortOrder";

	private static readonly IntPtr selSortOrderHandle = Selector.GetHandle("sortOrder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnifyResults = "unifyResults";

	private static readonly IntPtr selUnifyResultsHandle = Selector.GetHandle("unifyResults");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CNContactFetchRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSArray KeysToFetch
	{
		[Export("keysToFetch", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSend(base.Handle, selKeysToFetchHandle));
			}
			return Runtime.GetNSObject<NSArray>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeysToFetchHandle));
		}
		[Export("setKeysToFetch:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetKeysToFetch_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetKeysToFetch_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual bool MutableObjects
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("mutableObjects")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selMutableObjectsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selMutableObjectsHandle);
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setMutableObjects:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetMutableObjects_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetMutableObjects_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPredicate? Predicate
	{
		[Export("predicate", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSend(base.Handle, selPredicateHandle));
			}
			return Runtime.GetNSObject<NSPredicate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPredicateHandle));
		}
		[Export("setPredicate:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPredicate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPredicate_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CNContactSortOrder SortOrder
	{
		[Export("sortOrder")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CNContactSortOrder)Messaging.Int64_objc_msgSend(base.Handle, selSortOrderHandle);
			}
			return (CNContactSortOrder)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSortOrderHandle);
		}
		[Export("setSortOrder:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetSortOrder_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetSortOrder_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool UnifyResults
	{
		[Export("unifyResults")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUnifyResultsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUnifyResultsHandle);
		}
		[Export("setUnifyResults:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUnifyResults_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUnifyResults_Handle, value);
			}
		}
	}

	public CNContactFetchRequest(params ICNKeyDescriptor[] keysToFetch)
		: this(NSArray.FromNativeObjects(keysToFetch))
	{
	}

	public CNContactFetchRequest(params NSString[] keysToFetch)
		: this(NSArray.FromNSObjects(keysToFetch))
	{
	}

	public CNContactFetchRequest(params INativeObject[] keysToFetch)
		: this(Validate(keysToFetch))
	{
	}

	private static bool ConformsToProtocol(IntPtr handle, IntPtr protocol)
	{
		return Messaging.bool_objc_msgSend_IntPtr(handle, Selector.GetHandle("conformsToProtocol:"), protocol);
	}

	private static NSArray Validate(params INativeObject[] keysToFetch)
	{
		if (nsobject == IntPtr.Zero)
		{
			nsobject = Protocol.objc_getProtocol("NSObject");
		}
		if (nssecurecoding == IntPtr.Zero)
		{
			nssecurecoding = Protocol.objc_getProtocol("NSSecureCoding");
		}
		if (nscopying == IntPtr.Zero)
		{
			nscopying = Protocol.objc_getProtocol("NSCopying");
		}
		foreach (INativeObject nativeObject in keysToFetch)
		{
			IntPtr intPtr = nativeObject.Handle;
			if (!ConformsToProtocol(intPtr, nsobject) || !ConformsToProtocol(intPtr, nssecurecoding) || !ConformsToProtocol(intPtr, nscopying))
			{
				throw new InvalidOperationException("Keys do not conform to ICNKeyDescriptor");
			}
		}
		return NSArray.FromNativeObjects(keysToFetch);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CNContactFetchRequest(NSCoder coder)
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
	protected CNContactFetchRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CNContactFetchRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithKeysToFetch:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected CNContactFetchRequest(NSArray keysToFetch)
		: base(NSObjectFlag.Empty)
	{
		if (keysToFetch == null)
		{
			throw new ArgumentNullException("keysToFetch");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithKeysToFetch_Handle, keysToFetch.Handle), "initWithKeysToFetch:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithKeysToFetch_Handle, keysToFetch.Handle), "initWithKeysToFetch:");
		}
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}
}

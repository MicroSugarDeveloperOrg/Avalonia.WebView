using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSSortDescriptor", true)]
public class NSSortDescriptor : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowEvaluation = "allowEvaluation";

	private static readonly IntPtr selAllowEvaluationHandle = ObjCRuntime.Selector.GetHandle("allowEvaluation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAscending = "ascending";

	private static readonly IntPtr selAscendingHandle = ObjCRuntime.Selector.GetHandle("ascending");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompareObject_ToObject_ = "compareObject:toObject:";

	private static readonly IntPtr selCompareObject_ToObject_Handle = ObjCRuntime.Selector.GetHandle("compareObject:toObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = ObjCRuntime.Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = ObjCRuntime.Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = ObjCRuntime.Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithKey_Ascending_ = "initWithKey:ascending:";

	private static readonly IntPtr selInitWithKey_Ascending_Handle = ObjCRuntime.Selector.GetHandle("initWithKey:ascending:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithKey_Ascending_Comparator_ = "initWithKey:ascending:comparator:";

	private static readonly IntPtr selInitWithKey_Ascending_Comparator_Handle = ObjCRuntime.Selector.GetHandle("initWithKey:ascending:comparator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithKey_Ascending_Selector_ = "initWithKey:ascending:selector:";

	private static readonly IntPtr selInitWithKey_Ascending_Selector_Handle = ObjCRuntime.Selector.GetHandle("initWithKey:ascending:selector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selKey = "key";

	private static readonly IntPtr selKeyHandle = ObjCRuntime.Selector.GetHandle("key");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReversedSortDescriptor = "reversedSortDescriptor";

	private static readonly IntPtr selReversedSortDescriptorHandle = ObjCRuntime.Selector.GetHandle("reversedSortDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelector = "selector";

	private static readonly IntPtr selSelectorHandle = ObjCRuntime.Selector.GetHandle("selector");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSSortDescriptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Ascending
	{
		[Export("ascending")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAscendingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAscendingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Key
	{
		[Export("key")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selKeyHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selKeyHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ReversedSortDescriptor
	{
		[Export("reversedSortDescriptor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selReversedSortDescriptorHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReversedSortDescriptorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Selector Selector
	{
		[Export("selector")]
		get
		{
			if (base.IsDirectBinding)
			{
				return ObjCRuntime.Selector.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectorHandle));
			}
			return ObjCRuntime.Selector.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSortDescriptor()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, ObjCRuntime.Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, ObjCRuntime.Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSSortDescriptor(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, ObjCRuntime.Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, ObjCRuntime.Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSSortDescriptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSortDescriptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithKey:ascending:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSSortDescriptor(string key, bool ascending)
		: base(NSObjectFlag.Empty)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selInitWithKey_Ascending_Handle, arg, ascending), "initWithKey:ascending:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selInitWithKey_Ascending_Handle, arg, ascending), "initWithKey:ascending:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithKey:ascending:selector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSSortDescriptor(string key, bool ascending, Selector selector)
		: base(NSObjectFlag.Empty)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (selector == null)
		{
			throw new ArgumentNullException("selector");
		}
		IntPtr arg = NSString.CreateNative(key);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_bool_IntPtr(base.Handle, selInitWithKey_Ascending_Selector_Handle, arg, ascending, selector.Handle), "initWithKey:ascending:selector:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_IntPtr(base.SuperHandle, selInitWithKey_Ascending_Selector_Handle, arg, ascending, selector.Handle), "initWithKey:ascending:selector:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithKey:ascending:comparator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe NSSortDescriptor(string key, bool ascending, [BlockProxy(typeof(Trampolines.NIDNSComparator))] NSComparator comparator)
		: base(NSObjectFlag.Empty)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (comparator == null)
		{
			throw new ArgumentNullException("comparator");
		}
		IntPtr arg = NSString.CreateNative(key);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSComparator.Handler, comparator);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_bool_IntPtr(base.Handle, selInitWithKey_Ascending_Comparator_Handle, arg, ascending, (IntPtr)ptr), "initWithKey:ascending:comparator:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool_IntPtr(base.SuperHandle, selInitWithKey_Ascending_Comparator_Handle, arg, ascending, (IntPtr)ptr), "initWithKey:ascending:comparator:");
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Export("allowEvaluation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AllowEvaluation()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selAllowEvaluationHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selAllowEvaluationHandle);
		}
	}

	[Export("compareObject:toObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSComparisonResult Compare(NSObject object1, NSObject object2)
	{
		if (object1 == null)
		{
			throw new ArgumentNullException("object1");
		}
		if (object2 == null)
		{
			throw new ArgumentNullException("object2");
		}
		if (base.IsDirectBinding)
		{
			return (NSComparisonResult)Messaging.Int64_objc_msgSend_IntPtr_IntPtr(base.Handle, selCompareObject_ToObject_Handle, object1.Handle, object2.Handle);
		}
		return (NSComparisonResult)Messaging.Int64_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCompareObject_ToObject_Handle, object1.Handle, object2.Handle);
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, ObjCRuntime.Selector.GetHandle("release"));
		}
		return nSObject;
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

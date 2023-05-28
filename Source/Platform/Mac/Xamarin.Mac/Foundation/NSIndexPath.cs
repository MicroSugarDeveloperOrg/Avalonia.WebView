using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSIndexPath", true)]
public class NSIndexPath : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompare_ = "compare:";

	private static readonly IntPtr selCompare_Handle = Selector.GetHandle("compare:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetIndexes_ = "getIndexes:";

	private static readonly IntPtr selGetIndexes_Handle = Selector.GetHandle("getIndexes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetIndexes_Range_ = "getIndexes:range:";

	private static readonly IntPtr selGetIndexes_Range_Handle = Selector.GetHandle("getIndexes:range:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexAtPosition_ = "indexAtPosition:";

	private static readonly IntPtr selIndexAtPosition_Handle = Selector.GetHandle("indexAtPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexPathByAddingIndex_ = "indexPathByAddingIndex:";

	private static readonly IntPtr selIndexPathByAddingIndex_Handle = Selector.GetHandle("indexPathByAddingIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexPathByRemovingLastIndex = "indexPathByRemovingLastIndex";

	private static readonly IntPtr selIndexPathByRemovingLastIndexHandle = Selector.GetHandle("indexPathByRemovingLastIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexPathForItem_InSection_ = "indexPathForItem:inSection:";

	private static readonly IntPtr selIndexPathForItem_InSection_Handle = Selector.GetHandle("indexPathForItem:inSection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexPathWithIndex_ = "indexPathWithIndex:";

	private static readonly IntPtr selIndexPathWithIndex_Handle = Selector.GetHandle("indexPathWithIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexPathWithIndexes_Length_ = "indexPathWithIndexes:length:";

	private static readonly IntPtr selIndexPathWithIndexes_Length_Handle = Selector.GetHandle("indexPathWithIndexes:length:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItem = "item";

	private static readonly IntPtr selItemHandle = Selector.GetHandle("item");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLength = "length";

	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSection = "section";

	private static readonly IntPtr selSectionHandle = Selector.GetHandle("section");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSIndexPath");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual nint Item
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("item")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selItemHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selItemHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Length
	{
		[Export("length")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selLengthHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selLengthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual nint Section
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("section")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selSectionHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSectionHandle);
		}
	}

	public unsafe static NSIndexPath Create(params nint[] indexes)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		fixed (nint* ptr = indexes)
		{
			return _FromIndex((IntPtr)ptr, indexes.Length);
		}
	}

	public unsafe static NSIndexPath Create(params nuint[] indexes)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		fixed (nuint* ptr = indexes)
		{
			return _FromIndex((IntPtr)ptr, indexes.Length);
		}
	}

	public unsafe static NSIndexPath Create(params int[] indexes)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		fixed (nint* ptr = Array.ConvertAll(indexes, (Converter<int, nint>)((int v) => v)))
		{
			return _FromIndex((IntPtr)ptr, indexes.Length);
		}
	}

	public unsafe static NSIndexPath Create(params uint[] indexes)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		fixed (nuint* ptr = Array.ConvertAll(indexes, (Converter<uint, nuint>)((uint v) => v)))
		{
			return _FromIndex((IntPtr)ptr, indexes.Length);
		}
	}

	public unsafe nuint[] GetIndexes()
	{
		nuint[] array = new nuint[(long)Length];
		fixed (nuint* ptr = array)
		{
			_GetIndexes((IntPtr)ptr);
		}
		return array;
	}

	[iOS(9, 0)]
	[Mac(10, 11)]
	public unsafe nuint[] GetIndexes(NSRange range)
	{
		nuint[] array = new nuint[(long)range.Length];
		fixed (nuint* ptr = array)
		{
			_GetIndexes((IntPtr)ptr, range);
		}
		return array;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSIndexPath()
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
	public NSIndexPath(NSCoder coder)
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
	protected NSIndexPath(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSIndexPath(IntPtr handle)
		: base(handle)
	{
	}

	[Export("compare:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Compare(NSIndexPath other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selCompare_Handle, other.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompare_Handle, other.Handle);
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
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

	[Export("indexPathWithIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSIndexPath FromIndex(nuint index)
	{
		return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSend_nuint(class_ptr, selIndexPathWithIndex_Handle, index));
	}

	[Export("indexPathForItem:inSection:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSIndexPath FromItemSection(nint item, nint section)
	{
		return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSend_nint_nint(class_ptr, selIndexPathForItem_InSection_Handle, item, section));
	}

	[Export("indexAtPosition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint IndexAtPosition(nint position)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_nint(base.Handle, selIndexAtPosition_Handle, position);
		}
		return Messaging.nuint_objc_msgSendSuper_nint(base.SuperHandle, selIndexAtPosition_Handle, position);
	}

	[Export("indexPathByAddingIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexPath IndexPathByAddingIndex(nuint index)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selIndexPathByAddingIndex_Handle, index));
		}
		return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selIndexPathByAddingIndex_Handle, index));
	}

	[Export("indexPathByRemovingLastIndex")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexPath IndexPathByRemovingLastIndex()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSend(base.Handle, selIndexPathByRemovingLastIndexHandle));
		}
		return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIndexPathByRemovingLastIndexHandle));
	}

	[Export("indexPathWithIndexes:length:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSIndexPath _FromIndex(IntPtr indexes, nint len)
	{
		return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSend_IntPtr_nint(class_ptr, selIndexPathWithIndexes_Length_Handle, indexes, len));
	}

	[Export("getIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _GetIndexes(IntPtr target)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGetIndexes_Handle, target);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetIndexes_Handle, target);
		}
	}

	[Export("getIndexes:range:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _GetIndexes(IntPtr target, NSRange positionRange)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selGetIndexes_Range_Handle, target, positionRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selGetIndexes_Range_Handle, target, positionRange);
		}
	}
}

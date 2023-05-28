using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Photos;

[Register("PHFetchResult", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class PHFetchResult : NSObject, IEnumerable<NSObject>, IEnumerable, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainsObject_ = "containsObject:";

	private static readonly IntPtr selContainsObject_Handle = Selector.GetHandle("containsObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCount = "count";

	private static readonly IntPtr selCountHandle = Selector.GetHandle("count");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCountOfAssetsWithMediaType_ = "countOfAssetsWithMediaType:";

	private static readonly IntPtr selCountOfAssetsWithMediaType_Handle = Selector.GetHandle("countOfAssetsWithMediaType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateObjectsAtIndexes_Options_UsingBlock_ = "enumerateObjectsAtIndexes:options:usingBlock:";

	private static readonly IntPtr selEnumerateObjectsAtIndexes_Options_UsingBlock_Handle = Selector.GetHandle("enumerateObjectsAtIndexes:options:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateObjectsUsingBlock_ = "enumerateObjectsUsingBlock:";

	private static readonly IntPtr selEnumerateObjectsUsingBlock_Handle = Selector.GetHandle("enumerateObjectsUsingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateObjectsWithOptions_UsingBlock_ = "enumerateObjectsWithOptions:usingBlock:";

	private static readonly IntPtr selEnumerateObjectsWithOptions_UsingBlock_Handle = Selector.GetHandle("enumerateObjectsWithOptions:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFirstObject = "firstObject";

	private static readonly IntPtr selFirstObjectHandle = Selector.GetHandle("firstObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfObject_ = "indexOfObject:";

	private static readonly IntPtr selIndexOfObject_Handle = Selector.GetHandle("indexOfObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfObject_InRange_ = "indexOfObject:inRange:";

	private static readonly IntPtr selIndexOfObject_InRange_Handle = Selector.GetHandle("indexOfObject:inRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLastObject = "lastObject";

	private static readonly IntPtr selLastObjectHandle = Selector.GetHandle("lastObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectAtIndex_ = "objectAtIndex:";

	private static readonly IntPtr selObjectAtIndex_Handle = Selector.GetHandle("objectAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectAtIndexedSubscript_ = "objectAtIndexedSubscript:";

	private static readonly IntPtr selObjectAtIndexedSubscript_Handle = Selector.GetHandle("objectAtIndexedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectsAtIndexes_ = "objectsAtIndexes:";

	private static readonly IntPtr selObjectsAtIndexes_Handle = Selector.GetHandle("objectsAtIndexes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHFetchResult");

	public NSObject this[nint index] => _ObjectAtIndexedSubscript(index);

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint Count
	{
		[Export("count")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject LastObject
	{
		[Export("lastObject")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLastObjectHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLastObjectHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject firstObject
	{
		[Export("firstObject")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFirstObjectHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFirstObjectHandle));
		}
	}

	public IEnumerator<NSObject> GetEnumerator()
	{
		nint len = Count;
		for (nint i = 0; i < len; ++i)
		{
			yield return this[i];
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		nint len = Count;
		for (nint i = 0; i < len; ++i)
		{
			yield return this[i];
		}
	}

	public T[] ObjectsAt<T>(NSIndexSet indexes) where T : NSObject
	{
		IntPtr intPtr = _ObjectsAt(indexes);
		return NSArray.ArrayFromHandle<T>(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected PHFetchResult(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHFetchResult(IntPtr handle)
		: base(handle)
	{
	}

	[Export("containsObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Contains(NSObject id)
	{
		if (id == null)
		{
			throw new ArgumentNullException("id");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selContainsObject_Handle, id.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selContainsObject_Handle, id.Handle);
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

	[Export("countOfAssetsWithMediaType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint CountOfAssetsWithMediaType(PHAssetMediaType mediaType)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_Int64(base.Handle, selCountOfAssetsWithMediaType_Handle, (long)mediaType);
		}
		return Messaging.nuint_objc_msgSendSuper_Int64(base.SuperHandle, selCountOfAssetsWithMediaType_Handle, (long)mediaType);
	}

	[Export("enumerateObjectsUsingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Enumerate([BlockProxy(typeof(Trampolines.NIDPHFetchResultEnumerator))] PHFetchResultEnumerator handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDPHFetchResultEnumerator.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEnumerateObjectsUsingBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEnumerateObjectsUsingBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("enumerateObjectsWithOptions:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Enumerate(NSEnumerationOptions opts, [BlockProxy(typeof(Trampolines.NIDPHFetchResultEnumerator))] PHFetchResultEnumerator handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDPHFetchResultEnumerator.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_IntPtr(base.Handle, selEnumerateObjectsWithOptions_UsingBlock_Handle, (ulong)opts, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_IntPtr(base.SuperHandle, selEnumerateObjectsWithOptions_UsingBlock_Handle, (ulong)opts, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("enumerateObjectsAtIndexes:options:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Enumerate(NSIndexSet idx, NSEnumerationOptions opts, [BlockProxy(typeof(Trampolines.NIDPHFetchResultEnumerator))] PHFetchResultEnumerator handler)
	{
		if (idx == null)
		{
			throw new ArgumentNullException("idx");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDPHFetchResultEnumerator.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr(base.Handle, selEnumerateObjectsAtIndexes_Options_UsingBlock_Handle, idx.Handle, (ulong)opts, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_IntPtr(base.SuperHandle, selEnumerateObjectsAtIndexes_Options_UsingBlock_Handle, idx.Handle, (ulong)opts, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("indexOfObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOf(NSObject id)
	{
		if (id == null)
		{
			throw new ArgumentNullException("id");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr(base.Handle, selIndexOfObject_Handle, id.Handle);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexOfObject_Handle, id.Handle);
	}

	[Export("indexOfObject:inRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint IndexOf(NSObject id, NSRange range)
	{
		if (id == null)
		{
			throw new ArgumentNullException("id");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr_NSRange(base.Handle, selIndexOfObject_InRange_Handle, id.Handle, range);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selIndexOfObject_InRange_Handle, id.Handle, range);
	}

	[Export("objectAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject ObjectAt(nint index)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selObjectAtIndex_Handle, index));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selObjectAtIndex_Handle, index));
	}

	[Export("objectAtIndexedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSObject _ObjectAtIndexedSubscript(nint index)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selObjectAtIndexedSubscript_Handle, index));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selObjectAtIndexedSubscript_Handle, index));
	}

	[Export("objectsAtIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr _ObjectsAt(NSIndexSet indexes)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectsAtIndexes_Handle, indexes.Handle);
		}
		return Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectsAtIndexes_Handle, indexes.Handle);
	}
}

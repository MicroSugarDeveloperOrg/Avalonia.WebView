using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Photos;

[Register("PHFetchResultChangeDetails", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class PHFetchResultChangeDetails : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangeDetailsFromFetchResult_ToFetchResult_ChangedObjects_ = "changeDetailsFromFetchResult:toFetchResult:changedObjects:";

	private static readonly IntPtr selChangeDetailsFromFetchResult_ToFetchResult_ChangedObjects_Handle = Selector.GetHandle("changeDetailsFromFetchResult:toFetchResult:changedObjects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangedIndexes = "changedIndexes";

	private static readonly IntPtr selChangedIndexesHandle = Selector.GetHandle("changedIndexes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChangedObjects = "changedObjects";

	private static readonly IntPtr selChangedObjectsHandle = Selector.GetHandle("changedObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateMovesWithBlock_ = "enumerateMovesWithBlock:";

	private static readonly IntPtr selEnumerateMovesWithBlock_Handle = Selector.GetHandle("enumerateMovesWithBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchResultAfterChanges = "fetchResultAfterChanges";

	private static readonly IntPtr selFetchResultAfterChangesHandle = Selector.GetHandle("fetchResultAfterChanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchResultBeforeChanges = "fetchResultBeforeChanges";

	private static readonly IntPtr selFetchResultBeforeChangesHandle = Selector.GetHandle("fetchResultBeforeChanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasIncrementalChanges = "hasIncrementalChanges";

	private static readonly IntPtr selHasIncrementalChangesHandle = Selector.GetHandle("hasIncrementalChanges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasMoves = "hasMoves";

	private static readonly IntPtr selHasMovesHandle = Selector.GetHandle("hasMoves");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertedIndexes = "insertedIndexes";

	private static readonly IntPtr selInsertedIndexesHandle = Selector.GetHandle("insertedIndexes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertedObjects = "insertedObjects";

	private static readonly IntPtr selInsertedObjectsHandle = Selector.GetHandle("insertedObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemovedIndexes = "removedIndexes";

	private static readonly IntPtr selRemovedIndexesHandle = Selector.GetHandle("removedIndexes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemovedObjects = "removedObjects";

	private static readonly IntPtr selRemovedObjectsHandle = Selector.GetHandle("removedObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHFetchResultChangeDetails");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexSet ChangedIndexes
	{
		[Export("changedIndexes", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selChangedIndexesHandle));
			}
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChangedIndexesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHObject[] ChangedObjects
	{
		[Export("changedObjects", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<PHObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selChangedObjectsHandle));
			}
			return NSArray.ArrayFromHandle<PHObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChangedObjectsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHFetchResult FetchResultAfterChanges
	{
		[Export("fetchResultAfterChanges", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<PHFetchResult>(Messaging.IntPtr_objc_msgSend(base.Handle, selFetchResultAfterChangesHandle));
			}
			return Runtime.GetNSObject<PHFetchResult>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFetchResultAfterChangesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHFetchResult FetchResultBeforeChanges
	{
		[Export("fetchResultBeforeChanges", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<PHFetchResult>(Messaging.IntPtr_objc_msgSend(base.Handle, selFetchResultBeforeChangesHandle));
			}
			return Runtime.GetNSObject<PHFetchResult>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFetchResultBeforeChangesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasIncrementalChanges
	{
		[Export("hasIncrementalChanges")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasIncrementalChangesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasIncrementalChangesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasMoves
	{
		[Export("hasMoves")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasMovesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasMovesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexSet InsertedIndexes
	{
		[Export("insertedIndexes", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selInsertedIndexesHandle));
			}
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInsertedIndexesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHObject[] InsertedObjects
	{
		[Export("insertedObjects", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<PHObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selInsertedObjectsHandle));
			}
			return NSArray.ArrayFromHandle<PHObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInsertedObjectsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexSet RemovedIndexes
	{
		[Export("removedIndexes", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selRemovedIndexesHandle));
			}
			return Runtime.GetNSObject<NSIndexSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRemovedIndexesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHObject[] RemovedObjects
	{
		[Export("removedObjects", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<PHObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selRemovedObjectsHandle));
			}
			return NSArray.ArrayFromHandle<PHObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRemovedObjectsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PHFetchResultChangeDetails()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected PHFetchResultChangeDetails(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHFetchResultChangeDetails(IntPtr handle)
		: base(handle)
	{
	}

	[Export("changeDetailsFromFetchResult:toFetchResult:changedObjects:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHFetchResultChangeDetails ChangeDetails(PHFetchResult fromResult, PHFetchResult toResult, PHObject[] changedObjects)
	{
		if (fromResult == null)
		{
			throw new ArgumentNullException("fromResult");
		}
		if (toResult == null)
		{
			throw new ArgumentNullException("toResult");
		}
		if (changedObjects == null)
		{
			throw new ArgumentNullException("changedObjects");
		}
		NSArray nSArray = NSArray.FromNSObjects(changedObjects);
		PHFetchResultChangeDetails nSObject = Runtime.GetNSObject<PHFetchResultChangeDetails>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selChangeDetailsFromFetchResult_ToFetchResult_ChangedObjects_Handle, fromResult.Handle, toResult.Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("enumerateMovesWithBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateMoves([BlockProxy(typeof(Trampolines.NIDPHChangeDetailEnumerator))] PHChangeDetailEnumerator handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDPHChangeDetailEnumerator.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEnumerateMovesWithBlock_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEnumerateMovesWithBlock_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}
}

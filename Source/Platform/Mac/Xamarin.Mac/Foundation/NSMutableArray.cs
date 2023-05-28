using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSMutableArray", SkipRegistration = true)]
public sealed class NSMutableArray<TValue> : NSMutableArray, IEnumerable<TValue>, IEnumerable where TValue : class, INativeObject
{
	public TValue this[nuint index]
	{
		get
		{
			ValidateIndex(index);
			return GetItem<TValue>(index);
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			ValidateIndex(index);
			_ReplaceObject((nint)index, value.Handle);
		}
	}

	public NSMutableArray()
	{
	}

	public NSMutableArray(NSCoder coder)
		: base(coder)
	{
	}

	internal NSMutableArray(IntPtr handle)
		: base(handle)
	{
	}

	public NSMutableArray(nuint capacity)
		: base(capacity)
	{
	}

	public NSMutableArray(params TValue[] values)
	{
		if (values == null)
		{
			throw new ArgumentNullException("values");
		}
		for (int i = 0; i < values.Length; i++)
		{
			Add(values[i]);
		}
	}

	public bool Contains(TValue obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		return _Contains(obj.Handle);
	}

	public nuint IndexOf(TValue obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		return _IndexOf(obj.Handle);
	}

	public void Add(TValue obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		_Add(obj.Handle);
	}

	public void Insert(TValue obj, nint index)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		ValidateIndex(index);
		_Insert(obj.Handle, index);
	}

	public void ReplaceObject(nint index, TValue withObject)
	{
		if (withObject == null)
		{
			throw new ArgumentNullException("withObject");
		}
		ValidateIndex(index);
		_ReplaceObject(index, withObject.Handle);
	}

	public void AddObjects(params TValue[] source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		for (int i = 0; i < source.Length; i++)
		{
			if (source[i] == null)
			{
				throw new ArgumentNullException("source[" + i + "]");
			}
		}
		for (int j = 0; j < source.Length; j++)
		{
			_Add(source[j].Handle);
		}
	}

	public void InsertObjects(TValue[] objects, NSIndexSet atIndexes)
	{
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		if (atIndexes == null)
		{
			throw new ArgumentNullException("atIndexes");
		}
		if (objects.Length != atIndexes.Count)
		{
			throw new ArgumentOutOfRangeException("'objects' and 'atIndexes' must contain the same number of elements");
		}
		for (int i = 0; i < objects.Length; i++)
		{
			if (objects[i] == null)
			{
				throw new ArgumentNullException("objects[" + i + "]");
			}
		}
		nuint nuint = atIndexes.FirstIndex;
		for (int j = 0; j < objects.Length; j++)
		{
			if (j > 0)
			{
				nuint = atIndexes.IndexGreaterThan(nuint);
			}
			Insert(objects[j], (nint)nuint);
		}
	}

	private void ValidateIndex(nint index)
	{
		if (index < 0)
		{
			throw new IndexOutOfRangeException("index");
		}
		if ((nuint)index > Count)
		{
			throw new IndexOutOfRangeException("index");
		}
	}

	private void ValidateIndex(nuint index)
	{
		if (index >= Count)
		{
			throw new IndexOutOfRangeException("index");
		}
	}

	public IEnumerator<TValue> GetEnumerator()
	{
		return new NSFastEnumerator<TValue>(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
[Register("NSMutableArray", true)]
public class NSMutableArray : NSArray
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddObject_ = "addObject:";

	private static readonly IntPtr selAddObject_Handle = Selector.GetHandle("addObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddObjectsFromArray_ = "addObjectsFromArray:";

	private static readonly IntPtr selAddObjectsFromArray_Handle = Selector.GetHandle("addObjectsFromArray:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArrayWithContentsOfFile_ = "arrayWithContentsOfFile:";

	private static readonly IntPtr selArrayWithContentsOfFile_Handle = Selector.GetHandle("arrayWithContentsOfFile:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArrayWithContentsOfURL_ = "arrayWithContentsOfURL:";

	private static readonly IntPtr selArrayWithContentsOfURL_Handle = Selector.GetHandle("arrayWithContentsOfURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCapacity_ = "initWithCapacity:";

	private static readonly IntPtr selInitWithCapacity_Handle = Selector.GetHandle("initWithCapacity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertObject_AtIndex_ = "insertObject:atIndex:";

	private static readonly IntPtr selInsertObject_AtIndex_Handle = Selector.GetHandle("insertObject:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertObjects_AtIndexes_ = "insertObjects:atIndexes:";

	private static readonly IntPtr selInsertObjects_AtIndexes_Handle = Selector.GetHandle("insertObjects:atIndexes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllObjects = "removeAllObjects";

	private static readonly IntPtr selRemoveAllObjectsHandle = Selector.GetHandle("removeAllObjects");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveLastObject = "removeLastObject";

	private static readonly IntPtr selRemoveLastObjectHandle = Selector.GetHandle("removeLastObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObjectAtIndex_ = "removeObjectAtIndex:";

	private static readonly IntPtr selRemoveObjectAtIndex_Handle = Selector.GetHandle("removeObjectAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObjectsAtIndexes_ = "removeObjectsAtIndexes:";

	private static readonly IntPtr selRemoveObjectsAtIndexes_Handle = Selector.GetHandle("removeObjectsAtIndexes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceObjectAtIndex_WithObject_ = "replaceObjectAtIndex:withObject:";

	private static readonly IntPtr selReplaceObjectAtIndex_WithObject_Handle = Selector.GetHandle("replaceObjectAtIndex:withObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMutableArray");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMutableArray()
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
	public NSMutableArray(NSCoder coder)
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
	protected NSMutableArray(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMutableArray(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCapacity:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMutableArray(nuint capacity)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selInitWithCapacity_Handle, capacity), "initWithCapacity:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selInitWithCapacity_Handle, capacity), "initWithCapacity:");
		}
	}

	[Export("addObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Add(NSObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddObject_Handle, obj.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddObject_Handle, obj.Handle);
		}
	}

	[Export("addObjectsFromArray:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddObjects(NSObject[] source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		NSArray nSArray = NSArray.FromNSObjects(source);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddObjectsFromArray_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddObjectsFromArray_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("arrayWithContentsOfFile:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static NSMutableArray FromFile(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSMutableArray nSObject = Runtime.GetNSObject<NSMutableArray>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selArrayWithContentsOfFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("arrayWithContentsOfURL:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSMutableArray FromUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Runtime.GetNSObject<NSMutableArray>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selArrayWithContentsOfURL_Handle, url.Handle));
	}

	[Export("insertObject:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Insert(NSObject obj, nint index)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selInsertObject_AtIndex_Handle, obj.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selInsertObject_AtIndex_Handle, obj.Handle, index);
		}
	}

	[Export("insertObjects:atIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InsertObjects(NSObject[] objects, NSIndexSet atIndexes)
	{
		if (objects == null)
		{
			throw new ArgumentNullException("objects");
		}
		if (atIndexes == null)
		{
			throw new ArgumentNullException("atIndexes");
		}
		NSArray nSArray = NSArray.FromNSObjects(objects);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertObjects_AtIndexes_Handle, nSArray.Handle, atIndexes.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertObjects_AtIndexes_Handle, nSArray.Handle, atIndexes.Handle);
		}
		nSArray.Dispose();
	}

	[Export("removeAllObjects")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllObjects()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllObjectsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllObjectsHandle);
		}
	}

	[Export("removeLastObject")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveLastObject()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveLastObjectHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveLastObjectHandle);
		}
	}

	[Export("removeObjectAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveObject(nint index)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selRemoveObjectAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selRemoveObjectAtIndex_Handle, index);
		}
	}

	[Export("removeObjectsAtIndexes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveObjectsAtIndexes(NSIndexSet indexSet)
	{
		if (indexSet == null)
		{
			throw new ArgumentNullException("indexSet");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObjectsAtIndexes_Handle, indexSet.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObjectsAtIndexes_Handle, indexSet.Handle);
		}
	}

	[Export("replaceObjectAtIndex:withObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplaceObject(nint index, NSObject withObject)
	{
		if (withObject == null)
		{
			throw new ArgumentNullException("withObject");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint_IntPtr(base.Handle, selReplaceObjectAtIndex_WithObject_Handle, index, withObject.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint_IntPtr(base.SuperHandle, selReplaceObjectAtIndex_WithObject_Handle, index, withObject.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal void _Add(IntPtr obj)
	{
		Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddObject_Handle, obj);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal void _Insert(IntPtr obj, nint index)
	{
		Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selInsertObject_AtIndex_Handle, obj, index);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal void _InsertObjects(IntPtr objects, NSIndexSet atIndexes)
	{
		if (atIndexes == null)
		{
			throw new ArgumentNullException("atIndexes");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertObjects_AtIndexes_Handle, objects, atIndexes.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal void _ReplaceObject(nint index, IntPtr withObject)
	{
		Messaging.void_objc_msgSend_nint_IntPtr(base.Handle, selReplaceObjectAtIndex_WithObject_Handle, index, withObject);
	}
}

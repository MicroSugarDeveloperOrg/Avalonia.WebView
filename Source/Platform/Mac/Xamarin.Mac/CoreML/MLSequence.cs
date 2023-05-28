using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreML;

[Register("MLSequence", true)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class MLSequence : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEmptySequenceWithType_ = "emptySequenceWithType:";

	private static readonly IntPtr selEmptySequenceWithType_Handle = Selector.GetHandle("emptySequenceWithType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInt64Values = "int64Values";

	private static readonly IntPtr selInt64ValuesHandle = Selector.GetHandle("int64Values");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSequenceWithInt64Array_ = "sequenceWithInt64Array:";

	private static readonly IntPtr selSequenceWithInt64Array_Handle = Selector.GetHandle("sequenceWithInt64Array:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSequenceWithStringArray_ = "sequenceWithStringArray:";

	private static readonly IntPtr selSequenceWithStringArray_Handle = Selector.GetHandle("sequenceWithStringArray:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringValues = "stringValues";

	private static readonly IntPtr selStringValuesHandle = Selector.GetHandle("stringValues");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MLSequence");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[] Int64Values
	{
		[Export("int64Values")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selInt64ValuesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInt64ValuesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] StringValues
	{
		[Export("stringValues")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringValuesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringValuesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MLFeatureType Type
	{
		[Export("type")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MLFeatureType)Messaging.Int64_objc_msgSend(base.Handle, selTypeHandle);
			}
			return (MLFeatureType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MLSequence(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MLSequence(IntPtr handle)
		: base(handle)
	{
	}

	[Export("sequenceWithStringArray:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLSequence Create(string[] stringValues)
	{
		if (stringValues == null)
		{
			throw new ArgumentNullException("stringValues");
		}
		NSArray nSArray = NSArray.FromStrings(stringValues);
		MLSequence nSObject = Runtime.GetNSObject<MLSequence>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSequenceWithStringArray_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("sequenceWithInt64Array:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLSequence Create(NSNumber[] int64Values)
	{
		if (int64Values == null)
		{
			throw new ArgumentNullException("int64Values");
		}
		NSArray nSArray = NSArray.FromNSObjects(int64Values);
		MLSequence nSObject = Runtime.GetNSObject<MLSequence>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSequenceWithInt64Array_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("emptySequenceWithType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MLSequence CreateEmpty(MLFeatureType type)
	{
		return Runtime.GetNSObject<MLSequence>(Messaging.IntPtr_objc_msgSend_Int64(class_ptr, selEmptySequenceWithType_Handle, (long)type));
	}
}

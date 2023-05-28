using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using OpenTK;
using Xamarin.Mac.System.Mac;

namespace ModelIO;

[Register("MDLMatrix4x4Array", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
public class MDLMatrix4x4Array : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClear = "clear";

	private static readonly IntPtr selClearHandle = Selector.GetHandle("clear");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementCount = "elementCount";

	private static readonly IntPtr selElementCountHandle = Selector.GetHandle("elementCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetDouble4x4Array_MaxCount_ = "getDouble4x4Array:maxCount:";

	private static readonly IntPtr selGetDouble4x4Array_MaxCount_Handle = Selector.GetHandle("getDouble4x4Array:maxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetFloat4x4Array_MaxCount_ = "getFloat4x4Array:maxCount:";

	private static readonly IntPtr selGetFloat4x4Array_MaxCount_Handle = Selector.GetHandle("getFloat4x4Array:maxCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithElementCount_ = "initWithElementCount:";

	private static readonly IntPtr selInitWithElementCount_Handle = Selector.GetHandle("initWithElementCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrecision = "precision";

	private static readonly IntPtr selPrecisionHandle = Selector.GetHandle("precision");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDouble4x4Array_Count_ = "setDouble4x4Array:count:";

	private static readonly IntPtr selSetDouble4x4Array_Count_Handle = Selector.GetHandle("setDouble4x4Array:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFloat4x4Array_Count_ = "setFloat4x4Array:count:";

	private static readonly IntPtr selSetFloat4x4Array_Count_Handle = Selector.GetHandle("setFloat4x4Array:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLMatrix4x4Array");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ElementCount
	{
		[Export("elementCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selElementCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selElementCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLDataPrecision Precision
	{
		[Export("precision")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (MDLDataPrecision)Messaging.UInt64_objc_msgSend(base.Handle, selPrecisionHandle);
			}
			return (MDLDataPrecision)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPrecisionHandle);
		}
	}

	public unsafe virtual void SetValues(NMatrix4[] array)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		int typeSize = Marshal.SizeOf(typeof(NMatrix4));
		fixed (NMatrix4* ptr = array)
		{
			MDLMemoryHelper.SetValues(typeSize, (IntPtr)ptr, array.Length, _SetFloat4x4Array);
		}
	}

	public unsafe virtual void SetValues(NMatrix4d[] array)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		int typeSize = Marshal.SizeOf(typeof(NMatrix4d));
		fixed (NMatrix4d* ptr = array)
		{
			MDLMemoryHelper.SetValues(typeSize, (IntPtr)ptr, array.Length, _SetDouble4x4Array);
		}
	}

	public unsafe virtual NMatrix4[] GetNMatrix4Values()
	{
		nuint elementCount = ElementCount;
		NMatrix4[] array = new NMatrix4[(int)elementCount];
		int typeSize = sizeof(NMatrix4);
		fixed (NMatrix4* ptr = array)
		{
			MDLMemoryHelper.FetchValues(typeSize, (IntPtr)ptr, elementCount, _GetFloat4x4Array);
		}
		return array;
	}

	public unsafe virtual NMatrix4d[] GetNMatrix4dValues()
	{
		nuint elementCount = ElementCount;
		NMatrix4d[] array = new NMatrix4d[(int)elementCount];
		int typeSize = sizeof(NMatrix4d);
		fixed (NMatrix4d* ptr = array)
		{
			MDLMemoryHelper.FetchValues(typeSize, (IntPtr)ptr, elementCount, _GetDouble4x4Array);
		}
		return array;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MDLMatrix4x4Array(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLMatrix4x4Array(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithElementCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLMatrix4x4Array(nuint arrayElementCount)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selInitWithElementCount_Handle, arrayElementCount), "initWithElementCount:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selInitWithElementCount_Handle, arrayElementCount), "initWithElementCount:");
		}
	}

	[Export("clear")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Clear()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selClearHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selClearHandle);
		}
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

	[Export("getDouble4x4Array:maxCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual nuint _GetDouble4x4Array(IntPtr valuesArray, nuint maxCount)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_nuint(base.Handle, selGetDouble4x4Array_MaxCount_Handle, valuesArray, maxCount);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selGetDouble4x4Array_MaxCount_Handle, valuesArray, maxCount);
	}

	[Export("getFloat4x4Array:maxCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual nuint _GetFloat4x4Array(IntPtr valuesArray, nuint maxCount)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_nuint(base.Handle, selGetFloat4x4Array_MaxCount_Handle, valuesArray, maxCount);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selGetFloat4x4Array_MaxCount_Handle, valuesArray, maxCount);
	}

	[Export("setDouble4x4Array:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _SetDouble4x4Array(IntPtr valuesArray, nuint count)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, selSetDouble4x4Array_Count_Handle, valuesArray, count);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selSetDouble4x4Array_Count_Handle, valuesArray, count);
		}
	}

	[Export("setFloat4x4Array:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _SetFloat4x4Array(IntPtr valuesArray, nuint count)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, selSetFloat4x4Array_Count_Handle, valuesArray, count);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selSetFloat4x4Array_Count_Handle, valuesArray, count);
		}
	}
}

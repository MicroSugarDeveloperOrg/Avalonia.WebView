using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSValueTransformer", true)]
public abstract class NSValueTransformer : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsReverseTransformation = "allowsReverseTransformation";

	private static readonly IntPtr selAllowsReverseTransformationHandle = Selector.GetHandle("allowsReverseTransformation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReverseTransformedValue_ = "reverseTransformedValue:";

	private static readonly IntPtr selReverseTransformedValue_Handle = Selector.GetHandle("reverseTransformedValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetValueTransformer_ForName_ = "setValueTransformer:forName:";

	private static readonly IntPtr selSetValueTransformer_ForName_Handle = Selector.GetHandle("setValueTransformer:forName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransformedValue_ = "transformedValue:";

	private static readonly IntPtr selTransformedValue_Handle = Selector.GetHandle("transformedValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransformedValueClass = "transformedValueClass";

	private static readonly IntPtr selTransformedValueClassHandle = Selector.GetHandle("transformedValueClass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueTransformerForName_ = "valueTransformerForName:";

	private static readonly IntPtr selValueTransformerForName_Handle = Selector.GetHandle("valueTransformerForName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValueTransformerNames = "valueTransformerNames";

	private static readonly IntPtr selValueTransformerNamesHandle = Selector.GetHandle("valueTransformerNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSValueTransformer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _BooleanTransformerName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsNilTransformerName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _IsNotNilTransformerName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _KeyedUnarchiveFromDataTransformerName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SecureUnarchiveFromDataTransformerName;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _UnarchiveFromDataTransformerName;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool AllowsReverseTransformation
	{
		[Export("allowsReverseTransformation")]
		get
		{
			return Messaging.bool_objc_msgSend(class_ptr, selAllowsReverseTransformationHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Class TransformedValueClass
	{
		[Export("transformedValueClass")]
		get
		{
			IntPtr intPtr = Messaging.IntPtr_objc_msgSend(class_ptr, selTransformedValueClassHandle);
			return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] ValueTransformerNames
	{
		[Export("valueTransformerNames")]
		get
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selValueTransformerNamesHandle));
		}
	}

	[Field("NSNegateBooleanTransformerName", "Foundation")]
	public static NSString BooleanTransformerName
	{
		get
		{
			if (_BooleanTransformerName == null)
			{
				_BooleanTransformerName = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSNegateBooleanTransformerName");
			}
			return _BooleanTransformerName;
		}
	}

	[Field("NSIsNilTransformerName", "Foundation")]
	public static NSString IsNilTransformerName
	{
		get
		{
			if (_IsNilTransformerName == null)
			{
				_IsNilTransformerName = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSIsNilTransformerName");
			}
			return _IsNilTransformerName;
		}
	}

	[Field("NSIsNotNilTransformerName", "Foundation")]
	public static NSString IsNotNilTransformerName
	{
		get
		{
			if (_IsNotNilTransformerName == null)
			{
				_IsNotNilTransformerName = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSIsNotNilTransformerName");
			}
			return _IsNotNilTransformerName;
		}
	}

	[Field("NSKeyedUnarchiveFromDataTransformerName", "Foundation")]
	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'SecureUnarchiveFromDataTransformerName' instead.")]
	[Deprecated(PlatformName.WatchOS, 5, 0, PlatformArchitecture.None, "Use 'SecureUnarchiveFromDataTransformerName' instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'SecureUnarchiveFromDataTransformerName' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'SecureUnarchiveFromDataTransformerName' instead.")]
	public static NSString KeyedUnarchiveFromDataTransformerName
	{
		[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'SecureUnarchiveFromDataTransformerName' instead.")]
		[Deprecated(PlatformName.WatchOS, 5, 0, PlatformArchitecture.None, "Use 'SecureUnarchiveFromDataTransformerName' instead.")]
		[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'SecureUnarchiveFromDataTransformerName' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'SecureUnarchiveFromDataTransformerName' instead.")]
		get
		{
			if (_KeyedUnarchiveFromDataTransformerName == null)
			{
				_KeyedUnarchiveFromDataTransformerName = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSKeyedUnarchiveFromDataTransformerName");
			}
			return _KeyedUnarchiveFromDataTransformerName;
		}
	}

	[Field("NSSecureUnarchiveFromDataTransformerName", "Foundation")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public static NSString SecureUnarchiveFromDataTransformerName
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_SecureUnarchiveFromDataTransformerName == null)
			{
				_SecureUnarchiveFromDataTransformerName = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSSecureUnarchiveFromDataTransformerName");
			}
			return _SecureUnarchiveFromDataTransformerName;
		}
	}

	[Field("NSUnarchiveFromDataTransformerName", "Foundation")]
	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'SecureUnarchiveFromDataTransformerName' instead.")]
	[Deprecated(PlatformName.WatchOS, 5, 0, PlatformArchitecture.None, "Use 'SecureUnarchiveFromDataTransformerName' instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'SecureUnarchiveFromDataTransformerName' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'SecureUnarchiveFromDataTransformerName' instead.")]
	public static NSString UnarchiveFromDataTransformerName
	{
		[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'SecureUnarchiveFromDataTransformerName' instead.")]
		[Deprecated(PlatformName.WatchOS, 5, 0, PlatformArchitecture.None, "Use 'SecureUnarchiveFromDataTransformerName' instead.")]
		[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'SecureUnarchiveFromDataTransformerName' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'SecureUnarchiveFromDataTransformerName' instead.")]
		get
		{
			if (_UnarchiveFromDataTransformerName == null)
			{
				_UnarchiveFromDataTransformerName = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSUnarchiveFromDataTransformerName");
			}
			return _UnarchiveFromDataTransformerName;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected NSValueTransformer()
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
	protected NSValueTransformer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSValueTransformer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("valueTransformerForName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSValueTransformer? GetValueTransformer(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSValueTransformer nSObject = Runtime.GetNSObject<NSValueTransformer>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selValueTransformerForName_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("reverseTransformedValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? ReverseTransformedValue(NSObject? value)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selReverseTransformedValue_Handle, value?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selReverseTransformedValue_Handle, value?.Handle ?? IntPtr.Zero));
	}

	[Export("setValueTransformer:forName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetValueTransformer(NSValueTransformer? transformer, string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selSetValueTransformer_ForName_Handle, transformer?.Handle ?? IntPtr.Zero, arg);
		NSString.ReleaseNative(arg);
	}

	[Export("transformedValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? TransformedValue(NSObject? value)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selTransformedValue_Handle, value?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selTransformedValue_Handle, value?.Handle ?? IntPtr.Zero));
	}
}

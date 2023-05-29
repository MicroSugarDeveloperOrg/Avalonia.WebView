using Foundation;
using ObjCRuntime;

namespace JavaScriptCore;

public static class JSPropertyDescriptorKeys
{
	private static NSString? _Configurable;

	private static NSString? _Enumerable;

	private static NSString? _Get;

	private static NSString? _Set;

	private static NSString? _Value;

	private static NSString? _Writable;

	[Field("JSPropertyDescriptorConfigurableKey", "JavaScriptCore")]
	public static NSString Configurable
	{
		get
		{
			if (_Configurable == null)
			{
				_Configurable = Dlfcn.GetStringConstant(Libraries.JavaScriptCore.Handle, "JSPropertyDescriptorConfigurableKey");
			}
			return _Configurable;
		}
	}

	[Field("JSPropertyDescriptorEnumerableKey", "JavaScriptCore")]
	public static NSString Enumerable
	{
		get
		{
			if (_Enumerable == null)
			{
				_Enumerable = Dlfcn.GetStringConstant(Libraries.JavaScriptCore.Handle, "JSPropertyDescriptorEnumerableKey");
			}
			return _Enumerable;
		}
	}

	[Field("JSPropertyDescriptorGetKey", "JavaScriptCore")]
	public static NSString Get
	{
		get
		{
			if (_Get == null)
			{
				_Get = Dlfcn.GetStringConstant(Libraries.JavaScriptCore.Handle, "JSPropertyDescriptorGetKey");
			}
			return _Get;
		}
	}

	[Field("JSPropertyDescriptorSetKey", "JavaScriptCore")]
	public static NSString Set
	{
		get
		{
			if (_Set == null)
			{
				_Set = Dlfcn.GetStringConstant(Libraries.JavaScriptCore.Handle, "JSPropertyDescriptorSetKey");
			}
			return _Set;
		}
	}

	[Field("JSPropertyDescriptorValueKey", "JavaScriptCore")]
	public static NSString Value
	{
		get
		{
			if (_Value == null)
			{
				_Value = Dlfcn.GetStringConstant(Libraries.JavaScriptCore.Handle, "JSPropertyDescriptorValueKey");
			}
			return _Value;
		}
	}

	[Field("JSPropertyDescriptorWritableKey", "JavaScriptCore")]
	public static NSString Writable
	{
		get
		{
			if (_Writable == null)
			{
				_Writable = Dlfcn.GetStringConstant(Libraries.JavaScriptCore.Handle, "JSPropertyDescriptorWritableKey");
			}
			return _Writable;
		}
	}
}

using System;
using System.Collections.Generic;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreText;

internal static class Adapter
{
	public static void AssertWritable(NSDictionary dictionary)
	{
		if (!(dictionary is NSMutableDictionary))
		{
			throw new NotSupportedException();
		}
	}

	public static int? BitwiseOr(int? a, int? b)
	{
		if (!a.HasValue)
		{
			return b;
		}
		return a.Value | (b ?? 0);
	}

	public static uint? BitwiseOr(uint? a, uint? b)
	{
		if (!a.HasValue)
		{
			return b;
		}
		return a.Value | (b ?? 0);
	}

	public static int? GetInt32Value(IDictionary<NSObject, NSObject> dictionary, NSObject key)
	{
		NSObject nSObject = dictionary[key];
		if (nSObject == null)
		{
			return null;
		}
		return ((NSNumber)nSObject).Int32Value;
	}

	public static T[] GetNativeArray<T>(NSDictionary dictionary, NSObject key, Converter<IntPtr, T> converter)
	{
		IntPtr value = CFDictionary.GetValue(dictionary.Handle, key.Handle);
		if (value == IntPtr.Zero || CFArray.GetCount(value) == 0)
		{
			return new T[0];
		}
		return NSArray.ArrayFromHandle(value, converter);
	}

	public static float? GetSingleValue(IDictionary<NSObject, NSObject> dictionary, NSObject key)
	{
		NSObject nSObject = dictionary[key];
		if (nSObject == null)
		{
			return null;
		}
		return ((NSNumber)nSObject).FloatValue;
	}

	public static string[] GetStringArray(IDictionary<NSObject, NSObject> dictionary, NSObject key)
	{
		NSObject nSObject = dictionary[key];
		if (nSObject == null)
		{
			return new string[0];
		}
		return NSArray.StringArrayFromHandle(nSObject.Handle);
	}

	public static string GetStringValue(IDictionary<NSObject, NSObject> dictionary, NSObject key)
	{
		NSObject nSObject = dictionary[key];
		if (nSObject == null)
		{
			return null;
		}
		return ((NSString)nSObject).ToString();
	}

	public static uint? GetUInt32Value(IDictionary<NSObject, NSObject> dictionary, NSObject key)
	{
		NSObject nSObject = dictionary[key];
		if (nSObject == null)
		{
			return null;
		}
		return ((NSNumber)nSObject).UInt32Value;
	}

	public static void SetValue(IDictionary<NSObject, NSObject> dictionary, NSObject key, int? value)
	{
		if (value.HasValue)
		{
			dictionary[key] = new NSNumber(value.Value);
		}
		else
		{
			dictionary.Remove(key);
		}
	}

	public static void SetValue(IDictionary<NSObject, NSObject> dictionary, NSObject key, float? value)
	{
		if (value.HasValue)
		{
			dictionary[key] = new NSNumber(value.Value);
		}
		else
		{
			dictionary.Remove(key);
		}
	}

	public static void SetValue(IDictionary<NSObject, NSObject> dictionary, NSObject key, uint? value)
	{
		if (value.HasValue)
		{
			dictionary[key] = new NSNumber(value.Value);
		}
		else
		{
			dictionary.Remove(key);
		}
	}

	public static void SetValue(IDictionary<NSObject, NSObject> dictionary, NSObject key, IEnumerable<string> value)
	{
		List<string> list;
		if (value == null || (list = new List<string>(value)).Count == 0)
		{
			SetValue(dictionary, key, (NSObject)null);
			return;
		}
		using NSArray value2 = NSArray.FromStrings(list.ToArray());
		SetValue(dictionary, key, value2);
	}

	public static void SetValue(IDictionary<NSObject, NSObject> dictionary, NSObject key, NSObject value)
	{
		if (value != null)
		{
			dictionary[key] = value;
		}
		else
		{
			dictionary.Remove(key);
		}
	}

	public static void SetValue(IDictionary<NSObject, NSObject> dictionary, NSObject key, string value)
	{
		if (value == null)
		{
			SetValue(dictionary, key, (NSObject)null);
			return;
		}
		using NSString value2 = new NSString(value);
		SetValue(dictionary, key, (NSObject)value2);
	}

	public static void SetNativeValue<T>(NSDictionary dictionary, NSObject key, IEnumerable<T> value) where T : INativeObject
	{
		List<IntPtr> handles;
		if (value == null || (handles = GetHandles(value)).Count == 0)
		{
			SetNativeValue(dictionary, key, null);
			return;
		}
		using CFArray value2 = CFArray.FromIntPtrs(handles.ToArray());
		SetNativeValue(dictionary, key, value2);
	}

	private static List<IntPtr> GetHandles<T>(IEnumerable<T> value) where T : INativeObject
	{
		List<IntPtr> list = new List<IntPtr>();
		foreach (T item in value)
		{
			list.Add(item.Handle);
		}
		return list;
	}

	public static void SetNativeValue(NSDictionary dictionary, NSObject key, INativeObject value)
	{
		if (value != null)
		{
			AssertWritable(dictionary);
			CFMutableDictionary.SetValue(dictionary.Handle, key.Handle, value.Handle);
		}
		else
		{
			((IDictionary<NSObject, NSObject>)dictionary).Remove(key);
		}
	}
}

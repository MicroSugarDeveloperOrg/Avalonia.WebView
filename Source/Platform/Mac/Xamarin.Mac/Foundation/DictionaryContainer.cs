using System;
using CoreFoundation;
using ObjCRuntime;

namespace Foundation;

public abstract class DictionaryContainer
{
	public NSDictionary Dictionary { get; private set; }

	internal DictionaryContainer()
	{
		Dictionary = new NSMutableDictionary();
	}

	internal DictionaryContainer(NSDictionary dictionary)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		Dictionary = dictionary;
	}

	protected T[] GetArray<T>(NSString key) where T : NSObject
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr value = CFDictionary.GetValue(Dictionary.Handle, key.Handle);
		if (value == IntPtr.Zero)
		{
			return null;
		}
		return NSArray.ArrayFromHandle<T>(value);
	}

	protected T[] GetArray<T>(NSString key, Func<IntPtr, T> creator)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr value = CFDictionary.GetValue(Dictionary.Handle, key.Handle);
		if (value == IntPtr.Zero)
		{
			return null;
		}
		return NSArray.ArrayFromHandleFunc(value, creator);
	}

	protected int? GetInt32Value(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!Dictionary.TryGetValue(key, out var value))
		{
			return null;
		}
		return ((NSNumber)value).Int32Value;
	}

	protected long? GetLongValue(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!Dictionary.TryGetValue(key, out var value))
		{
			return null;
		}
		return ((NSNumber)value).Int64Value;
	}

	protected uint? GetUIntValue(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!Dictionary.TryGetValue(key, out var value))
		{
			return null;
		}
		return ((NSNumber)value).UInt32Value;
	}

	protected float? GetFloatValue(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!Dictionary.TryGetValue(key, out var value))
		{
			return null;
		}
		return ((NSNumber)value).FloatValue;
	}

	protected double? GetDoubleValue(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!Dictionary.TryGetValue(key, out var value))
		{
			return null;
		}
		return ((NSNumber)value).DoubleValue;
	}

	protected bool? GetBoolValue(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr value = CFDictionary.GetValue(Dictionary.Handle, key.Handle);
		if (value == IntPtr.Zero)
		{
			return null;
		}
		return CFBoolean.GetValue(value);
	}

	protected NSDictionary GetNSDictionary(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		Dictionary.TryGetValue(key, out var value);
		return value as NSDictionary;
	}

	protected string GetNSStringValue(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		Dictionary.TryGetValue(key, out var value);
		return value as NSString;
	}

	protected string GetStringValue(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!Dictionary.TryGetValue(key, out var value))
		{
			return null;
		}
		return CFString.FetchString(value.Handle);
	}

	protected string GetStringValue(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		using CFString cFString = new CFString(key);
		return CFString.FetchString(CFDictionary.GetValue(Dictionary.Handle, cFString.handle));
	}

	protected void SetArrayValue(NSString key, NSNumber[] values)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (values == null)
		{
			RemoveValue(key);
		}
		else
		{
			Dictionary[key] = NSArray.FromNSObjects(values);
		}
	}

	protected void SetArrayValue(NSString key, string[] values)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (values == null)
		{
			RemoveValue(key);
		}
		else
		{
			Dictionary[key] = NSArray.FromStrings(values);
		}
	}

	protected void SetArrayValue(NSString key, INativeObject[] values)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (values == null)
		{
			RemoveValue(key);
		}
		else
		{
			CFMutableDictionary.SetValue(Dictionary.Handle, key.Handle, CFArray.FromNativeObjects(values).Handle);
		}
	}

	protected void SetBooleanValue(NSString key, bool? value)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!value.HasValue)
		{
			RemoveValue(key);
		}
		else
		{
			CFMutableDictionary.SetValue(Dictionary.Handle, key.Handle, value.Value ? CFBoolean.True.Handle : CFBoolean.False.Handle);
		}
	}

	protected void SetNumberValue(NSString key, int? value)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!value.HasValue)
		{
			RemoveValue(key);
		}
		else
		{
			Dictionary[key] = new NSNumber(value.Value);
		}
	}

	protected void SetNumberValue(NSString key, uint? value)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!value.HasValue)
		{
			RemoveValue(key);
		}
		else
		{
			Dictionary[key] = new NSNumber(value.Value);
		}
	}

	protected void SetNumberValue(NSString key, long? value)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		Dictionary[key] = new NSNumber(value.Value);
	}

	protected void SetNumberValue(NSString key, float? value)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!value.HasValue)
		{
			RemoveValue(key);
		}
		else
		{
			Dictionary[key] = new NSNumber(value.Value);
		}
	}

	protected void SetNumberValue(NSString key, double? value)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!value.HasValue)
		{
			RemoveValue(key);
		}
		else
		{
			Dictionary[key] = new NSNumber(value.Value);
		}
	}

	protected void SetStringValue(NSString key, string value)
	{
		SetStringValue(key, (value == null) ? null : new NSString(value));
	}

	protected void SetStringValue(NSString key, NSString value)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (value == null)
		{
			RemoveValue(key);
		}
		else
		{
			Dictionary[key] = value;
		}
	}

	protected void SetNativeValue(NSString key, INativeObject value, bool removeNullValue = true)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (value == null && removeNullValue)
		{
			RemoveValue(key);
		}
		else
		{
			CFMutableDictionary.SetValue(Dictionary.Handle, key.Handle, value?.Handle ?? IntPtr.Zero);
		}
	}

	protected void RemoveValue(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		((NSMutableDictionary)Dictionary).Remove(key);
	}
}

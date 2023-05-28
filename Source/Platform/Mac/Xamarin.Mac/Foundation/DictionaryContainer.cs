using System;
using System.Linq;
using CoreFoundation;
using CoreGraphics;
using CoreMedia;
using ObjCRuntime;

namespace Foundation;

public abstract class DictionaryContainer
{
	public NSDictionary Dictionary { get; private set; }

	protected DictionaryContainer()
	{
		Dictionary = new NSMutableDictionary();
	}

	protected DictionaryContainer(NSDictionary? dictionary)
	{
		Dictionary = dictionary ?? new NSMutableDictionary();
	}

	protected T[]? GetArray<T>(NSString key) where T : NSObject
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

	protected T[]? GetArray<T>(NSString key, Func<IntPtr, T> creator)
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

	protected uint? GetUInt32Value(NSString key)
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

	protected nint? GetNIntValue(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!Dictionary.TryGetValue(key, out var value))
		{
			return null;
		}
		return ((NSNumber)value).NIntValue;
	}

	protected nuint? GetNUIntValue(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!Dictionary.TryGetValue(key, out var value))
		{
			return null;
		}
		return ((NSNumber)value).NUIntValue;
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

	protected T? GetNativeValue<T>(NSString key) where T : class, INativeObject
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		return Runtime.GetINativeObject<T>(Dictionary.LowlevelObjectForKey(key.Handle), owns: false);
	}

	protected NSDictionary? GetNSDictionary(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		Dictionary.TryGetValue(key, out var value);
		return value as NSDictionary;
	}

	protected NSDictionary<TKey, TValue>? GetNSDictionary<TKey, TValue>(NSString key) where TKey : class, INativeObject where TValue : class, INativeObject
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		Dictionary.TryGetValue(key, out var value);
		return value as NSDictionary<TKey, TValue>;
	}

	protected T? GetStrongDictionary<T>(NSString key) where T : DictionaryContainer
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		NSDictionary nSDictionary = GetNSDictionary(key);
		if (nSDictionary == null)
		{
			return null;
		}
		return (T)Activator.CreateInstance(typeof(T), nSDictionary);
	}

	protected NSString? GetNSStringValue(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		Dictionary.TryGetValue(key, out var value);
		return value as NSString;
	}

	protected string? GetStringValue(NSString key)
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

	protected string? GetStringValue(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		using CFString cFString = new CFString(key);
		return CFString.FetchString(CFDictionary.GetValue(Dictionary.Handle, cFString.Handle));
	}

	protected CGRect? GetCGRectValue(NSString key)
	{
		NSDictionary nSDictionary = GetNSDictionary(key);
		if (!CGRect.TryParse(nSDictionary, out var rect))
		{
			return null;
		}
		return rect;
	}

	protected CGSize? GetCGSizeValue(NSString key)
	{
		NSDictionary nSDictionary = GetNSDictionary(key);
		if (!CGSize.TryParse(nSDictionary, out var size))
		{
			return null;
		}
		return size;
	}

	protected CGPoint? GetCGPointValue(NSString key)
	{
		NSDictionary nSDictionary = GetNSDictionary(key);
		if (!CGPoint.TryParse(nSDictionary, out var point))
		{
			return null;
		}
		return point;
	}

	protected CMTime? GetCMTimeValue(NSString key)
	{
		NSDictionary nSDictionary = GetNSDictionary(key);
		CMTime value = CMTime.FromDictionary(nSDictionary);
		if (value.IsInvalid)
		{
			return null;
		}
		return value;
	}

	private bool NullCheckAndRemoveKey(NSString key, bool removeEntry)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (removeEntry)
		{
			RemoveValue(key);
		}
		return !removeEntry;
	}

	protected void SetArrayValue(NSString key, NSNumber[]? values)
	{
		if (NullCheckAndRemoveKey(key, values == null))
		{
			Dictionary[key] = NSArray.FromNSObjects(values);
		}
	}

	protected void SetArrayValue<T>(NSString key, T[]? values)
	{
		if (NullCheckAndRemoveKey(key, values == null))
		{
			Dictionary[key] = NSArray.FromNSObjects(values.Select((T x) => NSObject.FromObject(x)).ToArray());
		}
	}

	protected void SetArrayValue(NSString key, string[]? values)
	{
		if (NullCheckAndRemoveKey(key, values == null))
		{
			Dictionary[key] = NSArray.FromStrings(values);
		}
	}

	protected void SetArrayValue(NSString key, INativeObject[]? values)
	{
		if (NullCheckAndRemoveKey(key, values == null))
		{
			CFMutableDictionary.SetValue(Dictionary.Handle, key.Handle, CFArray.FromNativeObjects(values).Handle);
		}
	}

	protected void SetBooleanValue(NSString key, bool? value)
	{
		if (NullCheckAndRemoveKey(key, !value.HasValue))
		{
			CFMutableDictionary.SetValue(Dictionary.Handle, key.Handle, value.Value ? CFBoolean.TrueHandle : CFBoolean.FalseHandle);
		}
	}

	protected void SetNumberValue(NSString key, int? value)
	{
		if (NullCheckAndRemoveKey(key, !value.HasValue))
		{
			Dictionary[key] = new NSNumber(value.Value);
		}
	}

	protected void SetNumberValue(NSString key, uint? value)
	{
		if (NullCheckAndRemoveKey(key, !value.HasValue))
		{
			Dictionary[key] = new NSNumber(value.Value);
		}
	}

	protected void SetNumberValue(NSString key, nint? value)
	{
		if (NullCheckAndRemoveKey(key, !value.HasValue))
		{
			Dictionary[key] = new NSNumber(value.Value);
		}
	}

	protected void SetNumberValue(NSString key, nuint? value)
	{
		if (NullCheckAndRemoveKey(key, !value.HasValue))
		{
			Dictionary[key] = new NSNumber(value.Value);
		}
	}

	protected void SetNumberValue(NSString key, long? value)
	{
		if (NullCheckAndRemoveKey(key, !value.HasValue))
		{
			Dictionary[key] = new NSNumber(value.Value);
		}
	}

	protected void SetNumberValue(NSString key, float? value)
	{
		if (NullCheckAndRemoveKey(key, !value.HasValue))
		{
			Dictionary[key] = new NSNumber(value.Value);
		}
	}

	protected void SetNumberValue(NSString key, double? value)
	{
		if (NullCheckAndRemoveKey(key, !value.HasValue))
		{
			Dictionary[key] = new NSNumber(value.Value);
		}
	}

	protected void SetStringValue(NSString key, string? value)
	{
		SetStringValue(key, (value == null) ? null : new NSString(value));
	}

	protected void SetStringValue(NSString key, NSString? value)
	{
		if (NullCheckAndRemoveKey(key, value == null))
		{
			Dictionary[key] = value;
		}
	}

	protected void SetNativeValue(NSString key, INativeObject? value, bool removeNullValue = true)
	{
		if (NullCheckAndRemoveKey(key, removeNullValue && value == null))
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

	protected void SetCGRectValue(NSString key, CGRect? value)
	{
		if (NullCheckAndRemoveKey(key, !value.HasValue))
		{
			Dictionary[key] = value.Value.ToDictionary();
		}
	}

	protected void SetCGSizeValue(NSString key, CGSize? value)
	{
		if (NullCheckAndRemoveKey(key, !value.HasValue))
		{
			Dictionary[key] = value.Value.ToDictionary();
		}
	}

	protected void SetCGPointValue(NSString key, CGPoint? value)
	{
		if (NullCheckAndRemoveKey(key, !value.HasValue))
		{
			Dictionary[key] = value.Value.ToDictionary();
		}
	}

	protected void SetCMTimeValue(NSString key, CMTime? value)
	{
		if (NullCheckAndRemoveKey(key, !value.HasValue))
		{
			Dictionary[key] = value.Value.ToDictionary();
		}
	}
}

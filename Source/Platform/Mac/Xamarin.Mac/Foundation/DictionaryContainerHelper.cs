using System;

namespace Foundation;

internal static class DictionaryContainerHelper
{
	public static IntPtr GetHandle(this DictionaryContainer? self)
	{
		return self?.Dictionary.Handle ?? IntPtr.Zero;
	}

	public static NSDictionary? GetDictionary(this DictionaryContainer? self)
	{
		return self?.Dictionary;
	}
}

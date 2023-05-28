using System;

namespace Xamarin.Utils;

internal static class StringExtensions
{
	internal static string[] SplitLines(this string s)
	{
		return s.Split(new string[1] { Environment.NewLine }, StringSplitOptions.None);
	}

	internal static T[] CopyAndAdd<T>(this T[] array, T value)
	{
		if (array == null || array.Length == 0)
		{
			return new T[1] { value };
		}
		T[] array2 = array;
		Array.Resize(ref array, array.Length + 1);
		array2[array2.Length - 1] = value;
		return array2;
	}
}

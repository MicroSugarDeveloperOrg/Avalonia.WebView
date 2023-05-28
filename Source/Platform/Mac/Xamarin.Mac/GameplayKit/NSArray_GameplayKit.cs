using System;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[iOS(10, 0)]
[TV(10, 0)]
[Mac(10, 12)]
public static class NSArray_GameplayKit
{
	[Export("shuffledArrayWithRandomSource:")]
	public static T[] GetShuffledArray<T>(this NSArray This, GKRandomSource randomSource) where T : class, INativeObject
	{
		if (randomSource == null)
		{
			throw new ArgumentNullException("randomSource");
		}
		return NSArray.ArrayFromHandle<T>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("shuffledArrayWithRandomSource:"), randomSource.Handle));
	}

	[Export("shuffledArray")]
	public static T[] GetShuffledArray<T>(this NSArray This) where T : class, INativeObject
	{
		return NSArray.ArrayFromHandle<T>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("shuffledArray")));
	}
}

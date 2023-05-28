using System;
using System.Threading.Tasks;
using ObjCRuntime;

namespace Foundation;

public static class NSItemProviderWriting_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSItemProviderRepresentationVisibility GetItemProviderVisibilityForTypeIdentifier(this INSItemProviderWriting This, string typeIdentifier)
	{
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		IntPtr intPtr = NSString.CreateNative(typeIdentifier);
		NSItemProviderRepresentationVisibility result = (NSItemProviderRepresentationVisibility)Messaging.Int64_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("itemProviderVisibilityForRepresentationWithTypeIdentifier:"), intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<NSData> LoadDataAsync(this INSItemProviderWriting This, string typeIdentifier)
	{
		TaskCompletionSource<NSData> tcs = new TaskCompletionSource<NSData>();
		This.LoadData(typeIdentifier, delegate(NSData arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<NSData> LoadDataAsync(this INSItemProviderWriting This, string typeIdentifier, out NSProgress result)
	{
		TaskCompletionSource<NSData> tcs = new TaskCompletionSource<NSData>();
		result = This.LoadData(typeIdentifier, delegate(NSData arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] GetWritableTypeIdentifiersForItemProvider(this INSItemProviderWriting This)
	{
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("writableTypeIdentifiersForItemProvider")));
	}
}

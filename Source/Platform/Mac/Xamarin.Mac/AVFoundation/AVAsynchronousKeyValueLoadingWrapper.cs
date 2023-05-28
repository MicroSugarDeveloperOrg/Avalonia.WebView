using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

internal sealed class AVAsynchronousKeyValueLoadingWrapper : BaseWrapper, IAVAsynchronousKeyValueLoading, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public AVAsynchronousKeyValueLoadingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("statusOfValueForKey:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVKeyValueStatus StatusOfValueForKeyerror(string key, IntPtr outError)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr intPtr = NSString.CreateNative(key);
		AVKeyValueStatus result = (AVKeyValueStatus)Messaging.Int64_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("statusOfValueForKey:error:"), intPtr, outError);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[Export("loadValuesAsynchronouslyForKeys:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void LoadValuesAsynchronously(string[] keys, [BlockProxy(typeof(Trampolines.NIDAction))] Action? handler)
	{
		if (keys == null)
		{
			throw new ArgumentNullException("keys");
		}
		NSArray nSArray = NSArray.FromStrings(keys);
		BlockLiteral* ptr;
		if (handler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, handler);
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("loadValuesAsynchronouslyForKeys:completionHandler:"), nSArray.Handle, (IntPtr)ptr);
		nSArray.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}
}

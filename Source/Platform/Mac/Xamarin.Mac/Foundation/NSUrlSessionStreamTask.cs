using System.ComponentModel;
using System.Threading.Tasks;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSURLSessionStreamTask", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NSUrlSessionStreamTask : NSUrlSessionTask
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCaptureStreams = "captureStreams";

	private static readonly IntPtr selCaptureStreamsHandle = Selector.GetHandle("captureStreams");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCloseRead = "closeRead";

	private static readonly IntPtr selCloseReadHandle = Selector.GetHandle("closeRead");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCloseWrite = "closeWrite";

	private static readonly IntPtr selCloseWriteHandle = Selector.GetHandle("closeWrite");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadDataOfMinLength_MaxLength_Timeout_CompletionHandler_ = "readDataOfMinLength:maxLength:timeout:completionHandler:";

	private static readonly IntPtr selReadDataOfMinLength_MaxLength_Timeout_CompletionHandler_Handle = Selector.GetHandle("readDataOfMinLength:maxLength:timeout:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartSecureConnection = "startSecureConnection";

	private static readonly IntPtr selStartSecureConnectionHandle = Selector.GetHandle("startSecureConnection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopSecureConnection = "stopSecureConnection";

	private static readonly IntPtr selStopSecureConnectionHandle = Selector.GetHandle("stopSecureConnection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteData_Timeout_CompletionHandler_ = "writeData:timeout:completionHandler:";

	private static readonly IntPtr selWriteData_Timeout_CompletionHandler_Handle = Selector.GetHandle("writeData:timeout:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSURLSessionStreamTask");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSUrlSessionStreamTask(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUrlSessionStreamTask(IntPtr handle)
		: base(handle)
	{
	}

	[Export("captureStreams")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CaptureStreams()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCaptureStreamsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCaptureStreamsHandle);
		}
	}

	[Export("closeRead")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CloseRead()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCloseReadHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCloseReadHandle);
		}
	}

	[Export("closeWrite")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CloseWrite()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCloseWriteHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCloseWriteHandle);
		}
	}

	[Export("readDataOfMinLength:maxLength:timeout:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ReadData(nuint minBytes, nuint maxBytes, double timeout, [BlockProxy(typeof(Trampolines.NIDNSUrlSessionDataRead))] NSUrlSessionDataRead completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSUrlSessionDataRead.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nuint_nuint_Double_IntPtr(base.Handle, selReadDataOfMinLength_MaxLength_Timeout_CompletionHandler_Handle, minBytes, maxBytes, timeout, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nuint_nuint_Double_IntPtr(base.SuperHandle, selReadDataOfMinLength_MaxLength_Timeout_CompletionHandler_Handle, minBytes, maxBytes, timeout, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSUrlSessionStreamDataRead> ReadDataAsync(nuint minBytes, nuint maxBytes, double timeout)
	{
		TaskCompletionSource<NSUrlSessionStreamDataRead> tcs = new TaskCompletionSource<NSUrlSessionStreamDataRead>();
		ReadData(minBytes, maxBytes, timeout, delegate(NSData data_, bool atEof_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NSUrlSessionStreamDataRead(data_, atEof_));
			}
		});
		return tcs.Task;
	}

	[Export("startSecureConnection")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartSecureConnection()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStartSecureConnectionHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStartSecureConnectionHandle);
		}
	}

	[Export("stopSecureConnection")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "A secure (TLS) connection cannot become drop back to insecure (non-TLS).")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "A secure (TLS) connection cannot become drop back to insecure (non-TLS).")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "A secure (TLS) connection cannot become drop back to insecure (non-TLS).")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "A secure (TLS) connection cannot become drop back to insecure (non-TLS).")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StopSecureConnection()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopSecureConnectionHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopSecureConnectionHandle);
		}
	}

	[Export("writeData:timeout:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void WriteData(NSData data, double timeout, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Double_IntPtr(base.Handle, selWriteData_Timeout_CompletionHandler_Handle, data.Handle, timeout, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Double_IntPtr(base.SuperHandle, selWriteData_Timeout_CompletionHandler_Handle, data.Handle, timeout, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task WriteDataAsync(NSData data, double timeout)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		WriteData(data, timeout, delegate(NSError obj_)
		{
			if (obj_ != null)
			{
				tcs.SetException(new NSErrorException(obj_));
			}
			else
			{
				tcs.SetResult(result: true);
			}
		});
		return tcs.Task;
	}
}

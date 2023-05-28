using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSFileHandle", true)]
public class NSFileHandle : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	public static class Notifications
	{
		public static NSObject ObserveConnectionAccepted(EventHandler<NSFileHandleConnectionAcceptedEventArgs> handler)
		{
			EventHandler<NSFileHandleConnectionAcceptedEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ConnectionAcceptedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSFileHandleConnectionAcceptedEventArgs(notification));
			});
		}

		public static NSObject ObserveConnectionAccepted(NSObject objectToObserve, EventHandler<NSFileHandleConnectionAcceptedEventArgs> handler)
		{
			EventHandler<NSFileHandleConnectionAcceptedEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ConnectionAcceptedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSFileHandleConnectionAcceptedEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDataAvailable(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DataAvailableNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDataAvailable(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DataAvailableNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveReadCompletion(EventHandler<NSFileHandleReadEventArgs> handler)
		{
			EventHandler<NSFileHandleReadEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ReadCompletionNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSFileHandleReadEventArgs(notification));
			});
		}

		public static NSObject ObserveReadCompletion(NSObject objectToObserve, EventHandler<NSFileHandleReadEventArgs> handler)
		{
			EventHandler<NSFileHandleReadEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ReadCompletionNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSFileHandleReadEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveReadToEndOfFileCompletion(EventHandler<NSFileHandleReadEventArgs> handler)
		{
			EventHandler<NSFileHandleReadEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ReadToEndOfFileCompletionNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSFileHandleReadEventArgs(notification));
			});
		}

		public static NSObject ObserveReadToEndOfFileCompletion(NSObject objectToObserve, EventHandler<NSFileHandleReadEventArgs> handler)
		{
			EventHandler<NSFileHandleReadEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ReadToEndOfFileCompletionNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSFileHandleReadEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcceptConnectionInBackgroundAndNotify = "acceptConnectionInBackgroundAndNotify";

	private static readonly IntPtr selAcceptConnectionInBackgroundAndNotifyHandle = Selector.GetHandle("acceptConnectionInBackgroundAndNotify");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAcceptConnectionInBackgroundAndNotifyForModes_ = "acceptConnectionInBackgroundAndNotifyForModes:";

	private static readonly IntPtr selAcceptConnectionInBackgroundAndNotifyForModes_Handle = Selector.GetHandle("acceptConnectionInBackgroundAndNotifyForModes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableData = "availableData";

	private static readonly IntPtr selAvailableDataHandle = Selector.GetHandle("availableData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCloseAndReturnError_ = "closeAndReturnError:";

	private static readonly IntPtr selCloseAndReturnError_Handle = Selector.GetHandle("closeAndReturnError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCloseFile = "closeFile";

	private static readonly IntPtr selCloseFileHandle = Selector.GetHandle("closeFile");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileDescriptor = "fileDescriptor";

	private static readonly IntPtr selFileDescriptorHandle = Selector.GetHandle("fileDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileHandleForReadingAtPath_ = "fileHandleForReadingAtPath:";

	private static readonly IntPtr selFileHandleForReadingAtPath_Handle = Selector.GetHandle("fileHandleForReadingAtPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileHandleForReadingFromURL_Error_ = "fileHandleForReadingFromURL:error:";

	private static readonly IntPtr selFileHandleForReadingFromURL_Error_Handle = Selector.GetHandle("fileHandleForReadingFromURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileHandleForUpdatingAtPath_ = "fileHandleForUpdatingAtPath:";

	private static readonly IntPtr selFileHandleForUpdatingAtPath_Handle = Selector.GetHandle("fileHandleForUpdatingAtPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileHandleForUpdatingURL_Error_ = "fileHandleForUpdatingURL:error:";

	private static readonly IntPtr selFileHandleForUpdatingURL_Error_Handle = Selector.GetHandle("fileHandleForUpdatingURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileHandleForWritingAtPath_ = "fileHandleForWritingAtPath:";

	private static readonly IntPtr selFileHandleForWritingAtPath_Handle = Selector.GetHandle("fileHandleForWritingAtPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileHandleForWritingToURL_Error_ = "fileHandleForWritingToURL:error:";

	private static readonly IntPtr selFileHandleForWritingToURL_Error_Handle = Selector.GetHandle("fileHandleForWritingToURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileHandleWithNullDevice = "fileHandleWithNullDevice";

	private static readonly IntPtr selFileHandleWithNullDeviceHandle = Selector.GetHandle("fileHandleWithNullDevice");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileHandleWithStandardError = "fileHandleWithStandardError";

	private static readonly IntPtr selFileHandleWithStandardErrorHandle = Selector.GetHandle("fileHandleWithStandardError");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileHandleWithStandardInput = "fileHandleWithStandardInput";

	private static readonly IntPtr selFileHandleWithStandardInputHandle = Selector.GetHandle("fileHandleWithStandardInput");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileHandleWithStandardOutput = "fileHandleWithStandardOutput";

	private static readonly IntPtr selFileHandleWithStandardOutputHandle = Selector.GetHandle("fileHandleWithStandardOutput");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetOffset_Error_ = "getOffset:error:";

	private static readonly IntPtr selGetOffset_Error_Handle = Selector.GetHandle("getOffset:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFileDescriptor_ = "initWithFileDescriptor:";

	private static readonly IntPtr selInitWithFileDescriptor_Handle = Selector.GetHandle("initWithFileDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFileDescriptor_CloseOnDealloc_ = "initWithFileDescriptor:closeOnDealloc:";

	private static readonly IntPtr selInitWithFileDescriptor_CloseOnDealloc_Handle = Selector.GetHandle("initWithFileDescriptor:closeOnDealloc:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOffsetInFile = "offsetInFile";

	private static readonly IntPtr selOffsetInFileHandle = Selector.GetHandle("offsetInFile");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadDataOfLength_ = "readDataOfLength:";

	private static readonly IntPtr selReadDataOfLength_Handle = Selector.GetHandle("readDataOfLength:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadDataToEndOfFile = "readDataToEndOfFile";

	private static readonly IntPtr selReadDataToEndOfFileHandle = Selector.GetHandle("readDataToEndOfFile");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadDataToEndOfFileAndReturnError_ = "readDataToEndOfFileAndReturnError:";

	private static readonly IntPtr selReadDataToEndOfFileAndReturnError_Handle = Selector.GetHandle("readDataToEndOfFileAndReturnError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadDataUpToLength_Error_ = "readDataUpToLength:error:";

	private static readonly IntPtr selReadDataUpToLength_Error_Handle = Selector.GetHandle("readDataUpToLength:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadInBackgroundAndNotify = "readInBackgroundAndNotify";

	private static readonly IntPtr selReadInBackgroundAndNotifyHandle = Selector.GetHandle("readInBackgroundAndNotify");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadInBackgroundAndNotifyForModes_ = "readInBackgroundAndNotifyForModes:";

	private static readonly IntPtr selReadInBackgroundAndNotifyForModes_Handle = Selector.GetHandle("readInBackgroundAndNotifyForModes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadToEndOfFileInBackgroundAndNotify = "readToEndOfFileInBackgroundAndNotify";

	private static readonly IntPtr selReadToEndOfFileInBackgroundAndNotifyHandle = Selector.GetHandle("readToEndOfFileInBackgroundAndNotify");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadToEndOfFileInBackgroundAndNotifyForModes_ = "readToEndOfFileInBackgroundAndNotifyForModes:";

	private static readonly IntPtr selReadToEndOfFileInBackgroundAndNotifyForModes_Handle = Selector.GetHandle("readToEndOfFileInBackgroundAndNotifyForModes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSeekToEndOfFile = "seekToEndOfFile";

	private static readonly IntPtr selSeekToEndOfFileHandle = Selector.GetHandle("seekToEndOfFile");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSeekToEndReturningOffset_Error_ = "seekToEndReturningOffset:error:";

	private static readonly IntPtr selSeekToEndReturningOffset_Error_Handle = Selector.GetHandle("seekToEndReturningOffset:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSeekToFileOffset_ = "seekToFileOffset:";

	private static readonly IntPtr selSeekToFileOffset_Handle = Selector.GetHandle("seekToFileOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSeekToOffset_Error_ = "seekToOffset:error:";

	private static readonly IntPtr selSeekToOffset_Error_Handle = Selector.GetHandle("seekToOffset:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReadabilityHandler_ = "setReadabilityHandler:";

	private static readonly IntPtr selSetReadabilityHandler_Handle = Selector.GetHandle("setReadabilityHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWriteabilityHandler_ = "setWriteabilityHandler:";

	private static readonly IntPtr selSetWriteabilityHandler_Handle = Selector.GetHandle("setWriteabilityHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSynchronizeAndReturnError_ = "synchronizeAndReturnError:";

	private static readonly IntPtr selSynchronizeAndReturnError_Handle = Selector.GetHandle("synchronizeAndReturnError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSynchronizeFile = "synchronizeFile";

	private static readonly IntPtr selSynchronizeFileHandle = Selector.GetHandle("synchronizeFile");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTruncateAtOffset_Error_ = "truncateAtOffset:error:";

	private static readonly IntPtr selTruncateAtOffset_Error_Handle = Selector.GetHandle("truncateAtOffset:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTruncateFileAtOffset_ = "truncateFileAtOffset:";

	private static readonly IntPtr selTruncateFileAtOffset_Handle = Selector.GetHandle("truncateFileAtOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWaitForDataInBackgroundAndNotify = "waitForDataInBackgroundAndNotify";

	private static readonly IntPtr selWaitForDataInBackgroundAndNotifyHandle = Selector.GetHandle("waitForDataInBackgroundAndNotify");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWaitForDataInBackgroundAndNotifyForModes_ = "waitForDataInBackgroundAndNotifyForModes:";

	private static readonly IntPtr selWaitForDataInBackgroundAndNotifyForModes_Handle = Selector.GetHandle("waitForDataInBackgroundAndNotifyForModes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteData_ = "writeData:";

	private static readonly IntPtr selWriteData_Handle = Selector.GetHandle("writeData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteData_Error_ = "writeData:error:";

	private static readonly IntPtr selWriteData_Error_Handle = Selector.GetHandle("writeData:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSFileHandle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ConnectionAcceptedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DataAvailableNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OperationException;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ReadCompletionNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ReadToEndOfFileCompletionNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int FileDescriptor
	{
		[Export("fileDescriptor")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selFileDescriptorHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selFileDescriptorHandle);
		}
	}

	[Field("NSFileHandleConnectionAcceptedNotification", "Foundation")]
	[Advice("Use NSFileHandle.Notifications.ObserveConnectionAccepted helper method instead.")]
	public static NSString ConnectionAcceptedNotification
	{
		get
		{
			if (_ConnectionAcceptedNotification == null)
			{
				_ConnectionAcceptedNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileHandleConnectionAcceptedNotification");
			}
			return _ConnectionAcceptedNotification;
		}
	}

	[Field("NSFileHandleDataAvailableNotification", "Foundation")]
	[Advice("Use NSFileHandle.Notifications.ObserveDataAvailable helper method instead.")]
	public static NSString DataAvailableNotification
	{
		get
		{
			if (_DataAvailableNotification == null)
			{
				_DataAvailableNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileHandleDataAvailableNotification");
			}
			return _DataAvailableNotification;
		}
	}

	[Field("NSFileHandleOperationException", "Foundation")]
	public static NSString OperationException
	{
		get
		{
			if (_OperationException == null)
			{
				_OperationException = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileHandleOperationException");
			}
			return _OperationException;
		}
	}

	[Field("NSFileHandleReadCompletionNotification", "Foundation")]
	[Advice("Use NSFileHandle.Notifications.ObserveReadCompletion helper method instead.")]
	public static NSString ReadCompletionNotification
	{
		get
		{
			if (_ReadCompletionNotification == null)
			{
				_ReadCompletionNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileHandleReadCompletionNotification");
			}
			return _ReadCompletionNotification;
		}
	}

	[Field("NSFileHandleReadToEndOfFileCompletionNotification", "Foundation")]
	[Advice("Use NSFileHandle.Notifications.ObserveReadToEndOfFileCompletion helper method instead.")]
	public static NSString ReadToEndOfFileCompletionNotification
	{
		get
		{
			if (_ReadToEndOfFileCompletionNotification == null)
			{
				_ReadToEndOfFileCompletionNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSFileHandleReadToEndOfFileCompletionNotification");
			}
			return _ReadToEndOfFileCompletionNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSFileHandle(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSFileHandle(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSFileHandle(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFileDescriptor:closeOnDealloc:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSFileHandle(int fd, bool closeOnDealloc)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_int_bool(base.Handle, selInitWithFileDescriptor_CloseOnDealloc_Handle, fd, closeOnDealloc), "initWithFileDescriptor:closeOnDealloc:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_int_bool(base.SuperHandle, selInitWithFileDescriptor_CloseOnDealloc_Handle, fd, closeOnDealloc), "initWithFileDescriptor:closeOnDealloc:");
		}
	}

	[Export("initWithFileDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSFileHandle(int fd)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_int(base.Handle, selInitWithFileDescriptor_Handle, fd), "initWithFileDescriptor:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selInitWithFileDescriptor_Handle, fd), "initWithFileDescriptor:");
		}
	}

	[Export("acceptConnectionInBackgroundAndNotifyForModes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AcceptConnectionInBackground(NSString[] notifyRunLoopModes)
	{
		if (notifyRunLoopModes == null)
		{
			throw new ArgumentNullException("notifyRunLoopModes");
		}
		NSArray nSArray = NSArray.FromNSObjects(notifyRunLoopModes);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAcceptConnectionInBackgroundAndNotifyForModes_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAcceptConnectionInBackgroundAndNotifyForModes_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void AcceptConnectionInBackground(NSRunLoopMode[] notifyRunLoopModes)
	{
		AcceptConnectionInBackground(notifyRunLoopModes.GetConstants());
	}

	[Export("acceptConnectionInBackgroundAndNotify")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AcceptConnectionInBackground()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selAcceptConnectionInBackgroundAndNotifyHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selAcceptConnectionInBackgroundAndNotifyHandle);
		}
	}

	[Export("availableData")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData AvailableData()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableDataHandle));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableDataHandle));
	}

	[Export("closeAndReturnError:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Close(out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selCloseAndReturnError_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selCloseAndReturnError_Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("closeFile")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'Close (out NSError)' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'Close (out NSError)' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'Close (out NSError)' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'Close (out NSError)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CloseFile()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCloseFileHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCloseFileHandle);
		}
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("fileHandleWithNullDevice")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFileHandle FromNullDevice()
	{
		return Runtime.GetNSObject<NSFileHandle>(Messaging.IntPtr_objc_msgSend(class_ptr, selFileHandleWithNullDeviceHandle));
	}

	[Export("fileHandleWithStandardError")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFileHandle FromStandardError()
	{
		return Runtime.GetNSObject<NSFileHandle>(Messaging.IntPtr_objc_msgSend(class_ptr, selFileHandleWithStandardErrorHandle));
	}

	[Export("fileHandleWithStandardInput")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFileHandle FromStandardInput()
	{
		return Runtime.GetNSObject<NSFileHandle>(Messaging.IntPtr_objc_msgSend(class_ptr, selFileHandleWithStandardInputHandle));
	}

	[Export("fileHandleWithStandardOutput")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFileHandle FromStandardOutput()
	{
		return Runtime.GetNSObject<NSFileHandle>(Messaging.IntPtr_objc_msgSend(class_ptr, selFileHandleWithStandardOutputHandle));
	}

	[Export("getOffset:error:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GetOffset(out ulong offsetInFile, out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_out_UInt64_ref_IntPtr(base.SuperHandle, selGetOffset_Error_Handle, out offsetInFile, ref arg) : Messaging.bool_objc_msgSend_out_UInt64_ref_IntPtr(base.Handle, selGetOffset_Error_Handle, out offsetInFile, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("offsetInFile")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'GetOffset (out ulong, out NSError)' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'GetOffset (out ulong, out NSError)' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'GetOffset (out ulong, out NSError)' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'GetOffset (out ulong, out NSError)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ulong OffsetInFile()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.UInt64_objc_msgSend(base.Handle, selOffsetInFileHandle);
		}
		return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selOffsetInFileHandle);
	}

	[Export("fileHandleForReadingAtPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFileHandle OpenRead(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSFileHandle nSObject = Runtime.GetNSObject<NSFileHandle>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFileHandleForReadingAtPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("fileHandleForReadingFromURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFileHandle OpenReadUrl(NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		NSFileHandle nSObject = Runtime.GetNSObject<NSFileHandle>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selFileHandleForReadingFromURL_Error_Handle, url.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("fileHandleForUpdatingAtPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFileHandle OpenUpdate(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSFileHandle nSObject = Runtime.GetNSObject<NSFileHandle>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFileHandleForUpdatingAtPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("fileHandleForUpdatingURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFileHandle OpenUpdateUrl(NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		NSFileHandle nSObject = Runtime.GetNSObject<NSFileHandle>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selFileHandleForUpdatingURL_Error_Handle, url.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("fileHandleForWritingAtPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFileHandle OpenWrite(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSFileHandle nSObject = Runtime.GetNSObject<NSFileHandle>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFileHandleForWritingAtPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("fileHandleForWritingToURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFileHandle OpenWriteUrl(NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		NSFileHandle nSObject = Runtime.GetNSObject<NSFileHandle>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selFileHandleForWritingToURL_Error_Handle, url.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("readDataUpToLength:error:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? Read(nuint length, out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		NSData result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_nuint_ref_IntPtr(base.SuperHandle, selReadDataUpToLength_Error_Handle, length, ref arg)) : Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_nuint_ref_IntPtr(base.Handle, selReadDataUpToLength_Error_Handle, length, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("readDataOfLength:")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'Read (nuint, out NSError)' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'Read (nuint, out NSError)' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'Read (nuint, out NSError)' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'Read (nuint, out NSError)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData ReadDataOfLength(nuint length)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selReadDataOfLength_Handle, length));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selReadDataOfLength_Handle, length));
	}

	[Export("readDataToEndOfFile")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'ReadToEnd (out NSError)' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'ReadToEnd (out NSError)' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'ReadToEnd (out NSError)' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'ReadToEnd (out NSError)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData ReadDataToEndOfFile()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selReadDataToEndOfFileHandle));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReadDataToEndOfFileHandle));
	}

	[Export("readInBackgroundAndNotifyForModes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReadInBackground(NSString[] notifyRunLoopModes)
	{
		if (notifyRunLoopModes == null)
		{
			throw new ArgumentNullException("notifyRunLoopModes");
		}
		NSArray nSArray = NSArray.FromNSObjects(notifyRunLoopModes);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReadInBackgroundAndNotifyForModes_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReadInBackgroundAndNotifyForModes_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void ReadInBackground(NSRunLoopMode[] notifyRunLoopModes)
	{
		ReadInBackground(notifyRunLoopModes.GetConstants());
	}

	[Export("readInBackgroundAndNotify")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReadInBackground()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReadInBackgroundAndNotifyHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReadInBackgroundAndNotifyHandle);
		}
	}

	[Export("readDataToEndOfFileAndReturnError:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? ReadToEnd(out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		NSData result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selReadDataToEndOfFileAndReturnError_Handle, ref arg)) : Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_ref_IntPtr(base.Handle, selReadDataToEndOfFileAndReturnError_Handle, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("readToEndOfFileInBackgroundAndNotifyForModes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReadToEndOfFileInBackground(NSString[] notifyRunLoopModes)
	{
		if (notifyRunLoopModes == null)
		{
			throw new ArgumentNullException("notifyRunLoopModes");
		}
		NSArray nSArray = NSArray.FromNSObjects(notifyRunLoopModes);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReadToEndOfFileInBackgroundAndNotifyForModes_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReadToEndOfFileInBackgroundAndNotifyForModes_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void ReadToEndOfFileInBackground(NSRunLoopMode[] notifyRunLoopModes)
	{
		ReadToEndOfFileInBackground(notifyRunLoopModes.GetConstants());
	}

	[Export("readToEndOfFileInBackgroundAndNotify")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReadToEndOfFileInBackground()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReadToEndOfFileInBackgroundAndNotifyHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReadToEndOfFileInBackgroundAndNotifyHandle);
		}
	}

	[Export("seekToOffset:error:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Seek(ulong offset, out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_UInt64_ref_IntPtr(base.SuperHandle, selSeekToOffset_Error_Handle, offset, ref arg) : Messaging.bool_objc_msgSend_UInt64_ref_IntPtr(base.Handle, selSeekToOffset_Error_Handle, offset, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("seekToEndReturningOffset:error:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SeekToEnd(out ulong offsetInFile, out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_out_UInt64_ref_IntPtr(base.SuperHandle, selSeekToEndReturningOffset_Error_Handle, out offsetInFile, ref arg) : Messaging.bool_objc_msgSend_out_UInt64_ref_IntPtr(base.Handle, selSeekToEndReturningOffset_Error_Handle, out offsetInFile, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("seekToEndOfFile")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'SeekToEnd (out ulong, out NSError)' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'SeekToEnd (out ulong, out NSError)' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'SeekToEnd (out ulong, out NSError)' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'SeekToEnd (out ulong, out NSError)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ulong SeekToEndOfFile()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.UInt64_objc_msgSend(base.Handle, selSeekToEndOfFileHandle);
		}
		return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSeekToEndOfFileHandle);
	}

	[Export("seekToFileOffset:")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'Seek (ulong, out NSError)' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'Seek (ulong, out NSError)' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'Seek (ulong, out NSError)' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'Seek (ulong, out NSError)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SeekToFileOffset(ulong offset)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selSeekToFileOffset_Handle, offset);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSeekToFileOffset_Handle, offset);
		}
	}

	[Export("setReadabilityHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SetReadabilityHandler([BlockProxy(typeof(Trampolines.NIDActionArity1V30))] Action<NSFileHandle>? readCallback)
	{
		BlockLiteral* ptr;
		if (readCallback == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V30.Handler, readCallback);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetReadabilityHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetReadabilityHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Export("setWriteabilityHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SetWriteabilityHandle([BlockProxy(typeof(Trampolines.NIDActionArity1V30))] Action<NSFileHandle>? writeCallback)
	{
		BlockLiteral* ptr;
		if (writeCallback == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V30.Handler, writeCallback);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetWriteabilityHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetWriteabilityHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Export("synchronizeAndReturnError:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Synchronize(out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selSynchronizeAndReturnError_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selSynchronizeAndReturnError_Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("synchronizeFile")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'Synchronize (out NSError)' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'Synchronize (out NSError)' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'Synchronize (out NSError)' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'Synchronize (out NSError)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SynchronizeFile()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSynchronizeFileHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSynchronizeFileHandle);
		}
	}

	[Export("truncateAtOffset:error:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Truncate(ulong offset, out NSError? error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_UInt64_ref_IntPtr(base.SuperHandle, selTruncateAtOffset_Error_Handle, offset, ref arg) : Messaging.bool_objc_msgSend_UInt64_ref_IntPtr(base.Handle, selTruncateAtOffset_Error_Handle, offset, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("truncateFileAtOffset:")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'Truncate (ulong, out NSError)' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'Truncate (ulong, out NSError)' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'Truncate (ulong, out NSError)' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'Truncate (ulong, out NSError)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TruncateFileAtOffset(ulong offset)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selTruncateFileAtOffset_Handle, offset);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selTruncateFileAtOffset_Handle, offset);
		}
	}

	[Export("waitForDataInBackgroundAndNotifyForModes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WaitForDataInBackground(NSString[] notifyRunLoopModes)
	{
		if (notifyRunLoopModes == null)
		{
			throw new ArgumentNullException("notifyRunLoopModes");
		}
		NSArray nSArray = NSArray.FromNSObjects(notifyRunLoopModes);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWaitForDataInBackgroundAndNotifyForModes_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWaitForDataInBackgroundAndNotifyForModes_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void WaitForDataInBackground(NSRunLoopMode[] notifyRunLoopModes)
	{
		WaitForDataInBackground(notifyRunLoopModes.GetConstants());
	}

	[Export("waitForDataInBackgroundAndNotify")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WaitForDataInBackground()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selWaitForDataInBackgroundAndNotifyHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selWaitForDataInBackgroundAndNotifyHandle);
		}
	}

	[Export("writeData:error:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Write(NSData data, out NSError? error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selWriteData_Error_Handle, data.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selWriteData_Error_Handle, data.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("writeData:")]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'Write (out NSError)' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'Write (out NSError)' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'Write (out NSError)' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'Write (out NSError)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WriteData(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWriteData_Handle, data.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWriteData_Handle, data.Handle);
		}
	}
}

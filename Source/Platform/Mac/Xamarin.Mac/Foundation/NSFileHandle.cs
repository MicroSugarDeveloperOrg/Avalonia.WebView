using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Foundation;

[Register("NSFileHandle", true)]
public class NSFileHandle : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveReadCompletion(EventHandler<NSFileHandleReadEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(ReadCompletionNotification, delegate(NSNotification notification)
			{
				handler(null, new NSFileHandleReadEventArgs(notification));
			});
		}

		public static NSObject ObserveReadToEndOfFileCompletion(EventHandler<NSFileHandleReadEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(ReadToEndOfFileCompletionNotification, delegate(NSNotification notification)
			{
				handler(null, new NSFileHandleReadEventArgs(notification));
			});
		}

		public static NSObject ObserveConnectionAccepted(EventHandler<NSFileHandleConnectionAcceptedEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(ConnectionAcceptedNotification, delegate(NSNotification notification)
			{
				handler(null, new NSFileHandleConnectionAcceptedEventArgs(notification));
			});
		}

		public static NSObject ObserveDataAvailable(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(DataAvailableNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}
	}

	private static readonly IntPtr selFileDescriptorHandle = Selector.GetHandle("fileDescriptor");

	private static readonly IntPtr selAvailableDataHandle = Selector.GetHandle("availableData");

	private static readonly IntPtr selReadDataToEndOfFileHandle = Selector.GetHandle("readDataToEndOfFile");

	private static readonly IntPtr selReadDataOfLength_Handle = Selector.GetHandle("readDataOfLength:");

	private static readonly IntPtr selWriteData_Handle = Selector.GetHandle("writeData:");

	private static readonly IntPtr selOffsetInFileHandle = Selector.GetHandle("offsetInFile");

	private static readonly IntPtr selSeekToEndOfFileHandle = Selector.GetHandle("seekToEndOfFile");

	private static readonly IntPtr selSeekToFileOffset_Handle = Selector.GetHandle("seekToFileOffset:");

	private static readonly IntPtr selTruncateFileAtOffset_Handle = Selector.GetHandle("truncateFileAtOffset:");

	private static readonly IntPtr selSynchronizeFileHandle = Selector.GetHandle("synchronizeFile");

	private static readonly IntPtr selCloseFileHandle = Selector.GetHandle("closeFile");

	private static readonly IntPtr selFileHandleWithStandardInputHandle = Selector.GetHandle("fileHandleWithStandardInput");

	private static readonly IntPtr selFileHandleWithStandardOutputHandle = Selector.GetHandle("fileHandleWithStandardOutput");

	private static readonly IntPtr selFileHandleWithStandardErrorHandle = Selector.GetHandle("fileHandleWithStandardError");

	private static readonly IntPtr selFileHandleWithNullDeviceHandle = Selector.GetHandle("fileHandleWithNullDevice");

	private static readonly IntPtr selFileHandleForReadingAtPath_Handle = Selector.GetHandle("fileHandleForReadingAtPath:");

	private static readonly IntPtr selFileHandleForWritingAtPath_Handle = Selector.GetHandle("fileHandleForWritingAtPath:");

	private static readonly IntPtr selFileHandleForUpdatingAtPath_Handle = Selector.GetHandle("fileHandleForUpdatingAtPath:");

	private static readonly IntPtr selFileHandleForReadingFromURLError_Handle = Selector.GetHandle("fileHandleForReadingFromURL:error:");

	private static readonly IntPtr selFileHandleForWritingToURLError_Handle = Selector.GetHandle("fileHandleForWritingToURL:error:");

	private static readonly IntPtr selFileHandleForUpdatingURLError_Handle = Selector.GetHandle("fileHandleForUpdatingURL:error:");

	private static readonly IntPtr selReadInBackgroundAndNotifyForModes_Handle = Selector.GetHandle("readInBackgroundAndNotifyForModes:");

	private static readonly IntPtr selReadInBackgroundAndNotifyHandle = Selector.GetHandle("readInBackgroundAndNotify");

	private static readonly IntPtr selReadToEndOfFileInBackgroundAndNotifyForModes_Handle = Selector.GetHandle("readToEndOfFileInBackgroundAndNotifyForModes:");

	private static readonly IntPtr selReadToEndOfFileInBackgroundAndNotifyHandle = Selector.GetHandle("readToEndOfFileInBackgroundAndNotify");

	private static readonly IntPtr selAcceptConnectionInBackgroundAndNotifyForModes_Handle = Selector.GetHandle("acceptConnectionInBackgroundAndNotifyForModes:");

	private static readonly IntPtr selAcceptConnectionInBackgroundAndNotifyHandle = Selector.GetHandle("acceptConnectionInBackgroundAndNotify");

	private static readonly IntPtr selWaitForDataInBackgroundAndNotifyForModes_Handle = Selector.GetHandle("waitForDataInBackgroundAndNotifyForModes:");

	private static readonly IntPtr selWaitForDataInBackgroundAndNotifyHandle = Selector.GetHandle("waitForDataInBackgroundAndNotify");

	private static readonly IntPtr selInitWithFileDescriptorCloseOnDealloc_Handle = Selector.GetHandle("initWithFileDescriptor:closeOnDealloc:");

	private static readonly IntPtr selInitWithFileDescriptor_Handle = Selector.GetHandle("initWithFileDescriptor:");

	private static readonly IntPtr selSetReadabilityHandler_Handle = Selector.GetHandle("setReadabilityHandler:");

	private static readonly IntPtr selSetWriteabilityHandler_Handle = Selector.GetHandle("setWriteabilityHandler:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSFileHandle");

	private static NSString _OperationException;

	private static NSString _ReadCompletionNotification;

	private static NSString _ReadToEndOfFileCompletionNotification;

	private static NSString _ConnectionAcceptedNotification;

	private static NSString _DataAvailableNotification;

	public override IntPtr ClassHandle => class_ptr;

	public virtual int FileDescriptor
	{
		[Export("fileDescriptor")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selFileDescriptorHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selFileDescriptorHandle);
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

	[Field("NSFileHandleConnectionAcceptedNotification", "Foundation")]
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSFileHandle(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSFileHandle(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSFileHandle(IntPtr handle)
		: base(handle)
	{
	}

	[Export("availableData")]
	public virtual NSData AvailableData()
	{
		if (IsDirectBinding)
		{
			return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableDataHandle));
		}
		return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableDataHandle));
	}

	[Export("readDataToEndOfFile")]
	public virtual NSData ReadDataToEndOfFile()
	{
		if (IsDirectBinding)
		{
			return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selReadDataToEndOfFileHandle));
		}
		return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReadDataToEndOfFileHandle));
	}

	[Export("readDataOfLength:")]
	public virtual NSData ReadDataOfLength(ulong length)
	{
		if (IsDirectBinding)
		{
			return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64(base.Handle, selReadDataOfLength_Handle, length));
		}
		return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64(base.SuperHandle, selReadDataOfLength_Handle, length));
	}

	[Export("writeData:")]
	public virtual void WriteData(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWriteData_Handle, data.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWriteData_Handle, data.Handle);
		}
	}

	[Export("offsetInFile")]
	public virtual ulong OffsetInFile()
	{
		if (IsDirectBinding)
		{
			return Messaging.UInt64_objc_msgSend(base.Handle, selOffsetInFileHandle);
		}
		return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selOffsetInFileHandle);
	}

	[Export("seekToEndOfFile")]
	public virtual ulong SeekToEndOfFile()
	{
		if (IsDirectBinding)
		{
			return Messaging.UInt64_objc_msgSend(base.Handle, selSeekToEndOfFileHandle);
		}
		return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selSeekToEndOfFileHandle);
	}

	[Export("seekToFileOffset:")]
	public virtual void SeekToFileOffset(ulong offset)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selSeekToFileOffset_Handle, offset);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSeekToFileOffset_Handle, offset);
		}
	}

	[Export("truncateFileAtOffset:")]
	public virtual void TruncateFileAtOffset(ulong offset)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64(base.Handle, selTruncateFileAtOffset_Handle, offset);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selTruncateFileAtOffset_Handle, offset);
		}
	}

	[Export("synchronizeFile")]
	public virtual void SynchronizeFile()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selSynchronizeFileHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selSynchronizeFileHandle);
		}
	}

	[Export("closeFile")]
	public virtual void CloseFile()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCloseFileHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCloseFileHandle);
		}
	}

	[Export("fileHandleWithStandardInput")]
	public static NSFileHandle FromStandardInput()
	{
		return (NSFileHandle)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selFileHandleWithStandardInputHandle));
	}

	[Export("fileHandleWithStandardOutput")]
	public static NSFileHandle FromStandardOutput()
	{
		return (NSFileHandle)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selFileHandleWithStandardOutputHandle));
	}

	[Export("fileHandleWithStandardError")]
	public static NSFileHandle FromStandardError()
	{
		return (NSFileHandle)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selFileHandleWithStandardErrorHandle));
	}

	[Export("fileHandleWithNullDevice")]
	public static NSFileHandle FromNullDevice()
	{
		return (NSFileHandle)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selFileHandleWithNullDeviceHandle));
	}

	[Export("fileHandleForReadingAtPath:")]
	public static NSFileHandle OpenRead(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSFileHandle result = (NSFileHandle)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFileHandleForReadingAtPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("fileHandleForWritingAtPath:")]
	public static NSFileHandle OpenWrite(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSFileHandle result = (NSFileHandle)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFileHandleForWritingAtPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("fileHandleForUpdatingAtPath:")]
	public static NSFileHandle OpenUpdate(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSFileHandle result = (NSFileHandle)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selFileHandleForUpdatingAtPath_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("fileHandleForReadingFromURL:error:")]
	public static NSFileHandle OpenReadUrl(NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSFileHandle result = (NSFileHandle)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selFileHandleForReadingFromURLError_Handle, url.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("fileHandleForWritingToURL:error:")]
	public static NSFileHandle OpenWriteUrl(NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSFileHandle result = (NSFileHandle)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selFileHandleForWritingToURLError_Handle, url.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("fileHandleForUpdatingURL:error:")]
	public static NSFileHandle OpenUpdateUrl(NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		NSFileHandle result = (NSFileHandle)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selFileHandleForUpdatingURLError_Handle, url.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("readInBackgroundAndNotifyForModes:")]
	public virtual void ReadInBackground(NSString[] notifyRunLoopModes)
	{
		if (notifyRunLoopModes == null)
		{
			throw new ArgumentNullException("notifyRunLoopModes");
		}
		NSArray nSArray = NSArray.FromNSObjects(notifyRunLoopModes);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReadInBackgroundAndNotifyForModes_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReadInBackgroundAndNotifyForModes_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("readInBackgroundAndNotify")]
	public virtual void ReadInBackground()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReadInBackgroundAndNotifyHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReadInBackgroundAndNotifyHandle);
		}
	}

	[Export("readToEndOfFileInBackgroundAndNotifyForModes:")]
	public virtual void ReadToEndOfFileInBackground(NSString[] notifyRunLoopModes)
	{
		if (notifyRunLoopModes == null)
		{
			throw new ArgumentNullException("notifyRunLoopModes");
		}
		NSArray nSArray = NSArray.FromNSObjects(notifyRunLoopModes);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReadToEndOfFileInBackgroundAndNotifyForModes_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReadToEndOfFileInBackgroundAndNotifyForModes_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("readToEndOfFileInBackgroundAndNotify")]
	public virtual void ReadToEndOfFileInBackground()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReadToEndOfFileInBackgroundAndNotifyHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReadToEndOfFileInBackgroundAndNotifyHandle);
		}
	}

	[Export("acceptConnectionInBackgroundAndNotifyForModes:")]
	public virtual void AcceptConnectionInBackground(NSString[] notifyRunLoopModes)
	{
		if (notifyRunLoopModes == null)
		{
			throw new ArgumentNullException("notifyRunLoopModes");
		}
		NSArray nSArray = NSArray.FromNSObjects(notifyRunLoopModes);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAcceptConnectionInBackgroundAndNotifyForModes_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAcceptConnectionInBackgroundAndNotifyForModes_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("acceptConnectionInBackgroundAndNotify")]
	public virtual void AcceptConnectionInBackground()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selAcceptConnectionInBackgroundAndNotifyHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selAcceptConnectionInBackgroundAndNotifyHandle);
		}
	}

	[Export("waitForDataInBackgroundAndNotifyForModes:")]
	public virtual void WaitForDataInBackground(NSString[] notifyRunLoopModes)
	{
		if (notifyRunLoopModes == null)
		{
			throw new ArgumentNullException("notifyRunLoopModes");
		}
		NSArray nSArray = NSArray.FromNSObjects(notifyRunLoopModes);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWaitForDataInBackgroundAndNotifyForModes_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWaitForDataInBackgroundAndNotifyForModes_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("waitForDataInBackgroundAndNotify")]
	public virtual void WaitForDataInBackground()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selWaitForDataInBackgroundAndNotifyHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selWaitForDataInBackgroundAndNotifyHandle);
		}
	}

	[Export("initWithFileDescriptor:closeOnDealloc:")]
	public NSFileHandle(int fd, bool closeOnDealloc)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_int_bool(base.Handle, selInitWithFileDescriptorCloseOnDealloc_Handle, fd, closeOnDealloc);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_int_bool(base.SuperHandle, selInitWithFileDescriptorCloseOnDealloc_Handle, fd, closeOnDealloc);
		}
	}

	[Export("initWithFileDescriptor:")]
	public NSFileHandle(int fd)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_int(base.Handle, selInitWithFileDescriptor_Handle, fd);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selInitWithFileDescriptor_Handle, fd);
		}
	}

	[Export("setReadabilityHandler:")]
	public unsafe virtual void SetReadabilityHandler(NSFileHandleUpdateHandler readCallback)
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
			blockLiteral.SetupBlock(Trampolines.SDNSFileHandleUpdateHandler.Handler, readCallback);
		}
		if (IsDirectBinding)
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
	public unsafe virtual void SetWriteabilityHandle(NSFileHandleUpdateHandler writeCallback)
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
			blockLiteral.SetupBlock(Trampolines.SDNSFileHandleUpdateHandler.Handler, writeCallback);
		}
		if (IsDirectBinding)
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
}

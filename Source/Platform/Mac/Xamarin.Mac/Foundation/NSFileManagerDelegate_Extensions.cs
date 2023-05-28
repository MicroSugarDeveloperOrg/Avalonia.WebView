using System;
using ObjCRuntime;

namespace Foundation;

public static class NSFileManagerDelegate_Extensions
{
	public static bool ShouldCopyItemAtPath(this INSFileManagerDelegate This, NSFileManager fileManager, string srcPath, string dstPath)
	{
		return This.ShouldCopyItemAtPath(fileManager, (NSString)srcPath, (NSString)dstPath);
	}

	[Obsolete("API removed after iOS 2.0 / macOS 10.5. It will never be called by the OS.")]
	public static bool ShouldProceedAfterError(INSFileManagerDelegate This, NSFileManager fm, NSDictionary errorInfo)
	{
		return false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldCopyItemAtPath(this INSFileManagerDelegate This, NSFileManager fm, NSString srcPath, NSString dstPath)
	{
		if (fm == null)
		{
			throw new ArgumentNullException("fm");
		}
		if (srcPath == null)
		{
			throw new ArgumentNullException("srcPath");
		}
		if (dstPath == null)
		{
			throw new ArgumentNullException("dstPath");
		}
		return Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("fileManager:shouldCopyItemAtPath:toPath:"), fm.Handle, srcPath.Handle, dstPath.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldProceedAfterErrorCopyingItem(this INSFileManagerDelegate This, NSFileManager fileManager, NSError error, string srcPath, string dstPath)
	{
		if (fileManager == null)
		{
			throw new ArgumentNullException("fileManager");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (srcPath == null)
		{
			throw new ArgumentNullException("srcPath");
		}
		if (dstPath == null)
		{
			throw new ArgumentNullException("dstPath");
		}
		IntPtr intPtr = NSString.CreateNative(srcPath);
		IntPtr intPtr2 = NSString.CreateNative(dstPath);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("fileManager:shouldProceedAfterError:copyingItemAtPath:toPath:"), fileManager.Handle, error.Handle, intPtr, intPtr2);
		NSString.ReleaseNative(intPtr);
		NSString.ReleaseNative(intPtr2);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldMoveItemAtPath(this INSFileManagerDelegate This, NSFileManager fileManager, string srcPath, string dstPath)
	{
		if (fileManager == null)
		{
			throw new ArgumentNullException("fileManager");
		}
		if (srcPath == null)
		{
			throw new ArgumentNullException("srcPath");
		}
		if (dstPath == null)
		{
			throw new ArgumentNullException("dstPath");
		}
		IntPtr intPtr = NSString.CreateNative(srcPath);
		IntPtr intPtr2 = NSString.CreateNative(dstPath);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("fileManager:shouldMoveItemAtPath:toPath:"), fileManager.Handle, intPtr, intPtr2);
		NSString.ReleaseNative(intPtr);
		NSString.ReleaseNative(intPtr2);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldProceedAfterErrorMovingItem(this INSFileManagerDelegate This, NSFileManager fileManager, NSError error, string srcPath, string dstPath)
	{
		if (fileManager == null)
		{
			throw new ArgumentNullException("fileManager");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (srcPath == null)
		{
			throw new ArgumentNullException("srcPath");
		}
		if (dstPath == null)
		{
			throw new ArgumentNullException("dstPath");
		}
		IntPtr intPtr = NSString.CreateNative(srcPath);
		IntPtr intPtr2 = NSString.CreateNative(dstPath);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("fileManager:shouldProceedAfterError:movingItemAtPath:toPath:"), fileManager.Handle, error.Handle, intPtr, intPtr2);
		NSString.ReleaseNative(intPtr);
		NSString.ReleaseNative(intPtr2);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldLinkItemAtPath(this INSFileManagerDelegate This, NSFileManager fileManager, string srcPath, string dstPath)
	{
		if (fileManager == null)
		{
			throw new ArgumentNullException("fileManager");
		}
		if (srcPath == null)
		{
			throw new ArgumentNullException("srcPath");
		}
		if (dstPath == null)
		{
			throw new ArgumentNullException("dstPath");
		}
		IntPtr intPtr = NSString.CreateNative(srcPath);
		IntPtr intPtr2 = NSString.CreateNative(dstPath);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("fileManager:shouldLinkItemAtPath:toPath:"), fileManager.Handle, intPtr, intPtr2);
		NSString.ReleaseNative(intPtr);
		NSString.ReleaseNative(intPtr2);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldProceedAfterErrorLinkingItem(this INSFileManagerDelegate This, NSFileManager fileManager, NSError error, string srcPath, string dstPath)
	{
		if (fileManager == null)
		{
			throw new ArgumentNullException("fileManager");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (srcPath == null)
		{
			throw new ArgumentNullException("srcPath");
		}
		if (dstPath == null)
		{
			throw new ArgumentNullException("dstPath");
		}
		IntPtr intPtr = NSString.CreateNative(srcPath);
		IntPtr intPtr2 = NSString.CreateNative(dstPath);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("fileManager:shouldProceedAfterError:linkingItemAtPath:toPath:"), fileManager.Handle, error.Handle, intPtr, intPtr2);
		NSString.ReleaseNative(intPtr);
		NSString.ReleaseNative(intPtr2);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldRemoveItemAtPath(this INSFileManagerDelegate This, NSFileManager fileManager, string path)
	{
		if (fileManager == null)
		{
			throw new ArgumentNullException("fileManager");
		}
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr intPtr = NSString.CreateNative(path);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("fileManager:shouldRemoveItemAtPath:"), fileManager.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldProceedAfterErrorRemovingItem(this INSFileManagerDelegate This, NSFileManager fileManager, NSError error, string path)
	{
		if (fileManager == null)
		{
			throw new ArgumentNullException("fileManager");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr intPtr = NSString.CreateNative(path);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("fileManager:shouldProceedAfterError:removingItemAtPath:"), fileManager.Handle, error.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}
}

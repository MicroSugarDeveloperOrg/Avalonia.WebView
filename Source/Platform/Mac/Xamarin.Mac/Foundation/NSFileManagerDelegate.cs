using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSFileManagerDelegate", false)]
[Model]
public class NSFileManagerDelegate : NSObject, INSFileManagerDelegate, INativeObject, IDisposable
{
	public virtual bool ShouldCopyItemAtPath(NSFileManager fileManager, string srcPath, string dstPath)
	{
		return ShouldCopyItemAtPath(fileManager, (NSString)srcPath, (NSString)dstPath);
	}

	[Obsolete("API removed after iOS 2.0 / macOS 10.5. It will never be called by the OS.")]
	public virtual bool ShouldProceedAfterError(NSFileManager fm, NSDictionary errorInfo)
	{
		return false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSFileManagerDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSFileManagerDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSFileManagerDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("fileManager:shouldCopyItemAtPath:toPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldCopyItemAtPath(NSFileManager fm, NSString srcPath, NSString dstPath)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("fileManager:shouldLinkItemAtPath:toPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldLinkItemAtPath(NSFileManager fileManager, string srcPath, string dstPath)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("fileManager:shouldMoveItemAtPath:toPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldMoveItemAtPath(NSFileManager fileManager, string srcPath, string dstPath)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("fileManager:shouldProceedAfterError:copyingItemAtPath:toPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldProceedAfterErrorCopyingItem(NSFileManager fileManager, NSError error, string srcPath, string dstPath)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("fileManager:shouldProceedAfterError:linkingItemAtPath:toPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldProceedAfterErrorLinkingItem(NSFileManager fileManager, NSError error, string srcPath, string dstPath)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("fileManager:shouldProceedAfterError:movingItemAtPath:toPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldProceedAfterErrorMovingItem(NSFileManager fileManager, NSError error, string srcPath, string dstPath)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("fileManager:shouldProceedAfterError:removingItemAtPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldProceedAfterErrorRemovingItem(NSFileManager fileManager, NSError error, string path)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("fileManager:shouldRemoveItemAtPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldRemoveItemAtPath(NSFileManager fileManager, string path)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

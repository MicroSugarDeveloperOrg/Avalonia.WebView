using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSFontAssetRequest", true)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public class NSFontAssetRequest : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDownloadFontAssetsWithCompletionHandler_ = "downloadFontAssetsWithCompletionHandler:";

	private static readonly IntPtr selDownloadFontAssetsWithCompletionHandler_Handle = Selector.GetHandle("downloadFontAssetsWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDownloadedFontDescriptors = "downloadedFontDescriptors";

	private static readonly IntPtr selDownloadedFontDescriptorsHandle = Selector.GetHandle("downloadedFontDescriptors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFontDescriptors_Options_ = "initWithFontDescriptors:options:";

	private static readonly IntPtr selInitWithFontDescriptors_Options_Handle = Selector.GetHandle("initWithFontDescriptors:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProgress = "progress";

	private static readonly IntPtr selProgressHandle = Selector.GetHandle("progress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSFontAssetRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFontDescriptor[] DownloadedFontDescriptors
	{
		[Export("downloadedFontDescriptors", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selDownloadedFontDescriptorsHandle));
			}
			return NSArray.ArrayFromHandle<NSFontDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDownloadedFontDescriptorsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSProgress Progress
	{
		[Export("progress", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSend(base.Handle, selProgressHandle));
			}
			return Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProgressHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSFontAssetRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSFontAssetRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFontDescriptors:options:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSFontAssetRequest(NSFontDescriptor[] fontDescriptors, NSFontAssetRequestOptions options)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (fontDescriptors == null)
		{
			throw new ArgumentNullException("fontDescriptors");
		}
		NSArray nSArray = NSArray.FromNSObjects(fontDescriptors);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selInitWithFontDescriptors_Options_Handle, nSArray.Handle, (ulong)options), "initWithFontDescriptors:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selInitWithFontDescriptors_Options_Handle, nSArray.Handle, (ulong)options), "initWithFontDescriptors:options:");
		}
		nSArray.Dispose();
	}

	[Export("downloadFontAssetsWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void DownloadFontAssets([BlockProxy(typeof(Trampolines.NIDDownloadFontAssetsRequestCompletionHandler))] DownloadFontAssetsRequestCompletionHandler completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDDownloadFontAssetsRequestCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDownloadFontAssetsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDownloadFontAssetsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}
}

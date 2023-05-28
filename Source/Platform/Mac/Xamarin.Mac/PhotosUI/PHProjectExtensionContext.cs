using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;
using Photos;

namespace PhotosUI;

[Register("PHProjectExtensionContext", true)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public class PHProjectExtensionContext : NSExtensionContext, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhotoLibrary = "photoLibrary";

	private static readonly IntPtr selPhotoLibraryHandle = Selector.GetHandle("photoLibrary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProject = "project";

	private static readonly IntPtr selProjectHandle = Selector.GetHandle("project");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowEditorForAsset_ = "showEditorForAsset:";

	private static readonly IntPtr selShowEditorForAsset_Handle = Selector.GetHandle("showEditorForAsset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdatedProjectInfoFromProjectInfo_Completion_ = "updatedProjectInfoFromProjectInfo:completion:";

	private static readonly IntPtr selUpdatedProjectInfoFromProjectInfo_Completion_Handle = Selector.GetHandle("updatedProjectInfoFromProjectInfo:completion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHProjectExtensionContext");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHPhotoLibrary PhotoLibrary
	{
		[Export("photoLibrary")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<PHPhotoLibrary>(Messaging.IntPtr_objc_msgSend(base.Handle, selPhotoLibraryHandle));
			}
			return Runtime.GetNSObject<PHPhotoLibrary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPhotoLibraryHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual PHProject Project
	{
		[Export("project")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<PHProject>(Messaging.IntPtr_objc_msgSend(base.Handle, selProjectHandle));
			}
			return Runtime.GetNSObject<PHProject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProjectHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public PHProjectExtensionContext(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected PHProjectExtensionContext(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHProjectExtensionContext(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSApplication.EnsureUIThread();
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
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

	[Export("showEditorForAsset:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ShowEditor(PHAsset asset)
	{
		NSApplication.EnsureUIThread();
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selShowEditorForAsset_Handle, asset.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selShowEditorForAsset_Handle, asset.Handle);
		}
	}

	[Export("updatedProjectInfoFromProjectInfo:completion:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSProgress UpdatedProjectInfo(PHProjectInfo? existingProjectInfo, [BlockProxy(typeof(Trampolines.NIDActionArity1V73))] Action<PHProjectInfo> completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V73.Handler, completionHandler);
		NSProgress result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selUpdatedProjectInfoFromProjectInfo_Completion_Handle, existingProjectInfo?.Handle ?? IntPtr.Zero, (IntPtr)ptr)) : Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selUpdatedProjectInfoFromProjectInfo_Completion_Handle, existingProjectInfo?.Handle ?? IntPtr.Zero, (IntPtr)ptr)));
		ptr->CleanupBlock();
		return result;
	}
}

using System;
using System.ComponentModel;
using System.Threading.Tasks;
using AppKit;
using CoreGraphics;
using Foundation;
using Metal;
using ModelIO;
using ObjCRuntime;

namespace MetalKit;

[Register("MTKTextureLoader", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MTKTextureLoader : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDevice = "device";

	private static readonly IntPtr selDeviceHandle = Selector.GetHandle("device");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDevice_ = "initWithDevice:";

	private static readonly IntPtr selInitWithDevice_Handle = Selector.GetHandle("initWithDevice:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewTextureWithCGImage_Options_CompletionHandler_ = "newTextureWithCGImage:options:completionHandler:";

	private static readonly IntPtr selNewTextureWithCGImage_Options_CompletionHandler_Handle = Selector.GetHandle("newTextureWithCGImage:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewTextureWithCGImage_Options_Error_ = "newTextureWithCGImage:options:error:";

	private static readonly IntPtr selNewTextureWithCGImage_Options_Error_Handle = Selector.GetHandle("newTextureWithCGImage:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewTextureWithContentsOfURL_Options_CompletionHandler_ = "newTextureWithContentsOfURL:options:completionHandler:";

	private static readonly IntPtr selNewTextureWithContentsOfURL_Options_CompletionHandler_Handle = Selector.GetHandle("newTextureWithContentsOfURL:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewTextureWithContentsOfURL_Options_Error_ = "newTextureWithContentsOfURL:options:error:";

	private static readonly IntPtr selNewTextureWithContentsOfURL_Options_Error_Handle = Selector.GetHandle("newTextureWithContentsOfURL:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewTextureWithData_Options_CompletionHandler_ = "newTextureWithData:options:completionHandler:";

	private static readonly IntPtr selNewTextureWithData_Options_CompletionHandler_Handle = Selector.GetHandle("newTextureWithData:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewTextureWithData_Options_Error_ = "newTextureWithData:options:error:";

	private static readonly IntPtr selNewTextureWithData_Options_Error_Handle = Selector.GetHandle("newTextureWithData:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewTextureWithMDLTexture_Options_CompletionHandler_ = "newTextureWithMDLTexture:options:completionHandler:";

	private static readonly IntPtr selNewTextureWithMDLTexture_Options_CompletionHandler_Handle = Selector.GetHandle("newTextureWithMDLTexture:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewTextureWithMDLTexture_Options_Error_ = "newTextureWithMDLTexture:options:error:";

	private static readonly IntPtr selNewTextureWithMDLTexture_Options_Error_Handle = Selector.GetHandle("newTextureWithMDLTexture:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewTextureWithName_ScaleFactor_Bundle_Options_CompletionHandler_ = "newTextureWithName:scaleFactor:bundle:options:completionHandler:";

	private static readonly IntPtr selNewTextureWithName_ScaleFactor_Bundle_Options_CompletionHandler_Handle = Selector.GetHandle("newTextureWithName:scaleFactor:bundle:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewTextureWithName_ScaleFactor_Bundle_Options_Error_ = "newTextureWithName:scaleFactor:bundle:options:error:";

	private static readonly IntPtr selNewTextureWithName_ScaleFactor_Bundle_Options_Error_Handle = Selector.GetHandle("newTextureWithName:scaleFactor:bundle:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewTextureWithName_ScaleFactor_DisplayGamut_Bundle_Options_CompletionHandler_ = "newTextureWithName:scaleFactor:displayGamut:bundle:options:completionHandler:";

	private static readonly IntPtr selNewTextureWithName_ScaleFactor_DisplayGamut_Bundle_Options_CompletionHandler_Handle = Selector.GetHandle("newTextureWithName:scaleFactor:displayGamut:bundle:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewTextureWithName_ScaleFactor_DisplayGamut_Bundle_Options_Error_ = "newTextureWithName:scaleFactor:displayGamut:bundle:options:error:";

	private static readonly IntPtr selNewTextureWithName_ScaleFactor_DisplayGamut_Bundle_Options_Error_Handle = Selector.GetHandle("newTextureWithName:scaleFactor:displayGamut:bundle:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewTexturesWithContentsOfURLs_Options_CompletionHandler_ = "newTexturesWithContentsOfURLs:options:completionHandler:";

	private static readonly IntPtr selNewTexturesWithContentsOfURLs_Options_CompletionHandler_Handle = Selector.GetHandle("newTexturesWithContentsOfURLs:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewTexturesWithContentsOfURLs_Options_Error_ = "newTexturesWithContentsOfURLs:options:error:";

	private static readonly IntPtr selNewTexturesWithContentsOfURLs_Options_Error_Handle = Selector.GetHandle("newTexturesWithContentsOfURLs:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewTexturesWithNames_ScaleFactor_Bundle_Options_CompletionHandler_ = "newTexturesWithNames:scaleFactor:bundle:options:completionHandler:";

	private static readonly IntPtr selNewTexturesWithNames_ScaleFactor_Bundle_Options_CompletionHandler_Handle = Selector.GetHandle("newTexturesWithNames:scaleFactor:bundle:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewTexturesWithNames_ScaleFactor_DisplayGamut_Bundle_Options_CompletionHandler_ = "newTexturesWithNames:scaleFactor:displayGamut:bundle:options:completionHandler:";

	private static readonly IntPtr selNewTexturesWithNames_ScaleFactor_DisplayGamut_Bundle_Options_CompletionHandler_Handle = Selector.GetHandle("newTexturesWithNames:scaleFactor:displayGamut:bundle:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MTKTextureLoader");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLDevice Device
	{
		[Export("device")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, selDeviceHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeviceHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MTKTextureLoader(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MTKTextureLoader(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDevice:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MTKTextureLoader(IMTLDevice device)
		: base(NSObjectFlag.Empty)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithDevice_Handle, device.Handle), "initWithDevice:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithDevice_Handle, device.Handle), "initWithDevice:");
		}
	}

	[Export("newTextureWithCGImage:options:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal unsafe virtual void FromCGImage(CGImage cgImage, NSDictionary? options, [BlockProxy(typeof(Trampolines.NIDMTKTextureLoaderCallback))] MTKTextureLoaderCallback completionHandler)
	{
		if (cgImage == null)
		{
			throw new ArgumentNullException("cgImage");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMTKTextureLoaderCallback.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selNewTextureWithCGImage_Options_CompletionHandler_Handle, cgImage.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selNewTextureWithCGImage_Options_CompletionHandler_Handle, cgImage.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void FromCGImage(CGImage cgImage, MTKTextureLoaderOptions? options, [BlockProxy(typeof(Trampolines.NIDMTKTextureLoaderCallback))] MTKTextureLoaderCallback completionHandler)
	{
		FromCGImage(cgImage, options.GetDictionary(), completionHandler);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Task<IMTLTexture> FromCGImageAsync(CGImage cgImage, MTKTextureLoaderOptions? options)
	{
		TaskCompletionSource<IMTLTexture> tcs = new TaskCompletionSource<IMTLTexture>();
		FromCGImage(cgImage, options, delegate(IMTLTexture? texture_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(texture_);
			}
		});
		return tcs.Task;
	}

	[Export("newTextureWithCGImage:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IMTLTexture? FromCGImage(CGImage cgImage, NSDictionary? options, out NSError error)
	{
		if (cgImage == null)
		{
			throw new ArgumentNullException("cgImage");
		}
		IntPtr arg = IntPtr.Zero;
		IMTLTexture result = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selNewTextureWithCGImage_Options_Error_Handle, cgImage.Handle, options?.Handle ?? IntPtr.Zero, ref arg), owns: false) : Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selNewTextureWithCGImage_Options_Error_Handle, cgImage.Handle, options?.Handle ?? IntPtr.Zero, ref arg), owns: false));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMTLTexture? FromCGImage(CGImage cgImage, MTKTextureLoaderOptions? options, out NSError error)
	{
		return FromCGImage(cgImage, options.GetDictionary(), out error);
	}

	[Export("newTextureWithData:options:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal unsafe virtual void FromData(NSData data, NSDictionary? options, [BlockProxy(typeof(Trampolines.NIDMTKTextureLoaderCallback))] MTKTextureLoaderCallback completionHandler)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMTKTextureLoaderCallback.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selNewTextureWithData_Options_CompletionHandler_Handle, data.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selNewTextureWithData_Options_CompletionHandler_Handle, data.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void FromData(NSData data, MTKTextureLoaderOptions? options, [BlockProxy(typeof(Trampolines.NIDMTKTextureLoaderCallback))] MTKTextureLoaderCallback completionHandler)
	{
		FromData(data, options.GetDictionary(), completionHandler);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Task<IMTLTexture> FromDataAsync(NSData data, MTKTextureLoaderOptions? options)
	{
		TaskCompletionSource<IMTLTexture> tcs = new TaskCompletionSource<IMTLTexture>();
		FromData(data, options, delegate(IMTLTexture? texture_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(texture_);
			}
		});
		return tcs.Task;
	}

	[Export("newTextureWithData:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IMTLTexture? FromData(NSData data, NSDictionary? options, out NSError error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		IMTLTexture result = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selNewTextureWithData_Options_Error_Handle, data.Handle, options?.Handle ?? IntPtr.Zero, ref arg), owns: false) : Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selNewTextureWithData_Options_Error_Handle, data.Handle, options?.Handle ?? IntPtr.Zero, ref arg), owns: false));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMTLTexture? FromData(NSData data, MTKTextureLoaderOptions? options, out NSError error)
	{
		return FromData(data, options.GetDictionary(), out error);
	}

	[Export("newTextureWithName:scaleFactor:bundle:options:completionHandler:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FromName(string name, nfloat scaleFactor, NSBundle? bundle, NSDictionary? options, [BlockProxy(typeof(Trampolines.NIDMTKTextureLoaderCallback))] MTKTextureLoaderCallback completionHandler)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(name);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMTKTextureLoaderCallback.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nfloat_IntPtr_IntPtr_IntPtr(base.Handle, selNewTextureWithName_ScaleFactor_Bundle_Options_CompletionHandler_Handle, arg, scaleFactor, bundle?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nfloat_IntPtr_IntPtr_IntPtr(base.SuperHandle, selNewTextureWithName_ScaleFactor_Bundle_Options_CompletionHandler_Handle, arg, scaleFactor, bundle?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<IMTLTexture> FromNameAsync(string name, nfloat scaleFactor, NSBundle? bundle, NSDictionary? options)
	{
		TaskCompletionSource<IMTLTexture> tcs = new TaskCompletionSource<IMTLTexture>();
		FromName(name, scaleFactor, bundle, options, delegate(IMTLTexture? texture_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(texture_);
			}
		});
		return tcs.Task;
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void FromName(string name, nfloat scaleFactor, NSBundle? bundle, MTKTextureLoaderOptions? options, [BlockProxy(typeof(Trampolines.NIDMTKTextureLoaderCallback))] MTKTextureLoaderCallback completionHandler)
	{
		FromName(name, scaleFactor, bundle, options.GetDictionary(), completionHandler);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Task<IMTLTexture> FromNameAsync(string name, nfloat scaleFactor, NSBundle? bundle, MTKTextureLoaderOptions? options)
	{
		TaskCompletionSource<IMTLTexture> tcs = new TaskCompletionSource<IMTLTexture>();
		FromName(name, scaleFactor, bundle, options, delegate(IMTLTexture? texture_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(texture_);
			}
		});
		return tcs.Task;
	}

	[Export("newTextureWithName:scaleFactor:displayGamut:bundle:options:completionHandler:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FromName(string name, nfloat scaleFactor, NSDisplayGamut displayGamut, NSBundle? bundle, NSDictionary? options, [BlockProxy(typeof(Trampolines.NIDMTKTextureLoaderCallback))] MTKTextureLoaderCallback completionHandler)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(name);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMTKTextureLoaderCallback.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nfloat_Int64_IntPtr_IntPtr_IntPtr(base.Handle, selNewTextureWithName_ScaleFactor_DisplayGamut_Bundle_Options_CompletionHandler_Handle, arg, scaleFactor, (long)displayGamut, bundle?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nfloat_Int64_IntPtr_IntPtr_IntPtr(base.SuperHandle, selNewTextureWithName_ScaleFactor_DisplayGamut_Bundle_Options_CompletionHandler_Handle, arg, scaleFactor, (long)displayGamut, bundle?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<IMTLTexture> FromNameAsync(string name, nfloat scaleFactor, NSDisplayGamut displayGamut, NSBundle? bundle, NSDictionary? options)
	{
		TaskCompletionSource<IMTLTexture> tcs = new TaskCompletionSource<IMTLTexture>();
		FromName(name, scaleFactor, displayGamut, bundle, options, delegate(IMTLTexture? texture_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(texture_);
			}
		});
		return tcs.Task;
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void FromName(string name, nfloat scaleFactor, NSDisplayGamut displayGamut, NSBundle? bundle, MTKTextureLoaderOptions? options, [BlockProxy(typeof(Trampolines.NIDMTKTextureLoaderCallback))] MTKTextureLoaderCallback completionHandler)
	{
		FromName(name, scaleFactor, displayGamut, bundle, options.GetDictionary(), completionHandler);
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Task<IMTLTexture> FromNameAsync(string name, nfloat scaleFactor, NSDisplayGamut displayGamut, NSBundle? bundle, MTKTextureLoaderOptions? options)
	{
		TaskCompletionSource<IMTLTexture> tcs = new TaskCompletionSource<IMTLTexture>();
		FromName(name, scaleFactor, displayGamut, bundle, options, delegate(IMTLTexture? texture_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(texture_);
			}
		});
		return tcs.Task;
	}

	[Export("newTextureWithName:scaleFactor:bundle:options:error:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLTexture? FromName(string name, nfloat scaleFactor, NSBundle? bundle, NSDictionary? options, out NSError error)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(name);
		IMTLTexture result = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nfloat_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selNewTextureWithName_ScaleFactor_Bundle_Options_Error_Handle, arg2, scaleFactor, bundle?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero, ref arg), owns: false) : Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend_IntPtr_nfloat_IntPtr_IntPtr_ref_IntPtr(base.Handle, selNewTextureWithName_ScaleFactor_Bundle_Options_Error_Handle, arg2, scaleFactor, bundle?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero, ref arg), owns: false));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMTLTexture? FromName(string name, nfloat scaleFactor, NSBundle? bundle, MTKTextureLoaderOptions? options, out NSError error)
	{
		return FromName(name, scaleFactor, bundle, options.GetDictionary(), out error);
	}

	[Export("newTextureWithName:scaleFactor:displayGamut:bundle:options:error:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLTexture? FromName(string name, nfloat scaleFactor, NSDisplayGamut displayGamut, NSBundle? bundle, NSDictionary? options, out NSError? error)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(name);
		IMTLTexture result = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nfloat_Int64_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selNewTextureWithName_ScaleFactor_DisplayGamut_Bundle_Options_Error_Handle, arg2, scaleFactor, (long)displayGamut, bundle?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero, ref arg), owns: false) : Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend_IntPtr_nfloat_Int64_IntPtr_IntPtr_ref_IntPtr(base.Handle, selNewTextureWithName_ScaleFactor_DisplayGamut_Bundle_Options_Error_Handle, arg2, scaleFactor, (long)displayGamut, bundle?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero, ref arg), owns: false));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMTLTexture? FromName(string name, nfloat scaleFactor, NSDisplayGamut displayGamut, NSBundle? bundle, MTKTextureLoaderOptions? options, out NSError? error)
	{
		return FromName(name, scaleFactor, displayGamut, bundle, options.GetDictionary(), out error);
	}

	[Export("newTexturesWithNames:scaleFactor:bundle:options:completionHandler:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FromNames(string[] names, nfloat scaleFactor, NSBundle? bundle, NSDictionary? options, [BlockProxy(typeof(Trampolines.NIDMTKTextureLoaderArrayCallback))] MTKTextureLoaderArrayCallback completionHandler)
	{
		if (names == null)
		{
			throw new ArgumentNullException("names");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		NSArray nSArray = NSArray.FromStrings(names);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMTKTextureLoaderArrayCallback.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nfloat_IntPtr_IntPtr_IntPtr(base.Handle, selNewTexturesWithNames_ScaleFactor_Bundle_Options_CompletionHandler_Handle, nSArray.Handle, scaleFactor, bundle?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nfloat_IntPtr_IntPtr_IntPtr(base.SuperHandle, selNewTexturesWithNames_ScaleFactor_Bundle_Options_CompletionHandler_Handle, nSArray.Handle, scaleFactor, bundle?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		nSArray.Dispose();
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<IMTLTexture[]> FromNamesAsync(string[] names, nfloat scaleFactor, NSBundle? bundle, NSDictionary? options)
	{
		TaskCompletionSource<IMTLTexture[]> tcs = new TaskCompletionSource<IMTLTexture[]>();
		FromNames(names, scaleFactor, bundle, options, delegate(IMTLTexture[] textures_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(textures_);
			}
		});
		return tcs.Task;
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void FromNames(string[] names, nfloat scaleFactor, NSBundle? bundle, MTKTextureLoaderOptions? options, [BlockProxy(typeof(Trampolines.NIDMTKTextureLoaderArrayCallback))] MTKTextureLoaderArrayCallback completionHandler)
	{
		FromNames(names, scaleFactor, bundle, options.GetDictionary(), completionHandler);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Task<IMTLTexture[]> FromNamesAsync(string[] names, nfloat scaleFactor, NSBundle? bundle, MTKTextureLoaderOptions? options)
	{
		TaskCompletionSource<IMTLTexture[]> tcs = new TaskCompletionSource<IMTLTexture[]>();
		FromNames(names, scaleFactor, bundle, options, delegate(IMTLTexture[] textures_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(textures_);
			}
		});
		return tcs.Task;
	}

	[Export("newTexturesWithNames:scaleFactor:displayGamut:bundle:options:completionHandler:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FromNames(string[] names, nfloat scaleFactor, NSDisplayGamut displayGamut, NSBundle? bundle, NSDictionary? options, [BlockProxy(typeof(Trampolines.NIDMTKTextureLoaderArrayCallback))] MTKTextureLoaderArrayCallback completionHandler)
	{
		if (names == null)
		{
			throw new ArgumentNullException("names");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		NSArray nSArray = NSArray.FromStrings(names);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMTKTextureLoaderArrayCallback.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nfloat_Int64_IntPtr_IntPtr_IntPtr(base.Handle, selNewTexturesWithNames_ScaleFactor_DisplayGamut_Bundle_Options_CompletionHandler_Handle, nSArray.Handle, scaleFactor, (long)displayGamut, bundle?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nfloat_Int64_IntPtr_IntPtr_IntPtr(base.SuperHandle, selNewTexturesWithNames_ScaleFactor_DisplayGamut_Bundle_Options_CompletionHandler_Handle, nSArray.Handle, scaleFactor, (long)displayGamut, bundle?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		nSArray.Dispose();
		ptr->CleanupBlock();
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<IMTLTexture[]> FromNamesAsync(string[] names, nfloat scaleFactor, NSDisplayGamut displayGamut, NSBundle? bundle, NSDictionary? options)
	{
		TaskCompletionSource<IMTLTexture[]> tcs = new TaskCompletionSource<IMTLTexture[]>();
		FromNames(names, scaleFactor, displayGamut, bundle, options, delegate(IMTLTexture[] textures_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(textures_);
			}
		});
		return tcs.Task;
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void FromNames(string[] names, nfloat scaleFactor, NSDisplayGamut displayGamut, NSBundle? bundle, MTKTextureLoaderOptions? options, [BlockProxy(typeof(Trampolines.NIDMTKTextureLoaderArrayCallback))] MTKTextureLoaderArrayCallback completionHandler)
	{
		FromNames(names, scaleFactor, displayGamut, bundle, options.GetDictionary(), completionHandler);
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Task<IMTLTexture[]> FromNamesAsync(string[] names, nfloat scaleFactor, NSDisplayGamut displayGamut, NSBundle? bundle, MTKTextureLoaderOptions? options)
	{
		TaskCompletionSource<IMTLTexture[]> tcs = new TaskCompletionSource<IMTLTexture[]>();
		FromNames(names, scaleFactor, displayGamut, bundle, options, delegate(IMTLTexture[] textures_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(textures_);
			}
		});
		return tcs.Task;
	}

	[Export("newTextureWithMDLTexture:options:completionHandler:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FromTexture(MDLTexture texture, NSDictionary? options, [BlockProxy(typeof(Trampolines.NIDMTKTextureLoaderCallback))] MTKTextureLoaderCallback completionHandler)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMTKTextureLoaderCallback.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selNewTextureWithMDLTexture_Options_CompletionHandler_Handle, texture.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selNewTextureWithMDLTexture_Options_CompletionHandler_Handle, texture.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<IMTLTexture> FromTextureAsync(MDLTexture texture, NSDictionary? options)
	{
		TaskCompletionSource<IMTLTexture> tcs = new TaskCompletionSource<IMTLTexture>();
		FromTexture(texture, options, delegate(IMTLTexture? texture_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(texture_);
			}
		});
		return tcs.Task;
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void FromTexture(MDLTexture texture, MTKTextureLoaderOptions? options, [BlockProxy(typeof(Trampolines.NIDMTKTextureLoaderCallback))] MTKTextureLoaderCallback completionHandler)
	{
		FromTexture(texture, options.GetDictionary(), completionHandler);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Task<IMTLTexture> FromTextureAsync(MDLTexture texture, MTKTextureLoaderOptions? options)
	{
		TaskCompletionSource<IMTLTexture> tcs = new TaskCompletionSource<IMTLTexture>();
		FromTexture(texture, options, delegate(IMTLTexture? texture_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(texture_);
			}
		});
		return tcs.Task;
	}

	[Export("newTextureWithMDLTexture:options:error:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLTexture? FromTexture(MDLTexture texture, NSDictionary? options, out NSError error)
	{
		if (texture == null)
		{
			throw new ArgumentNullException("texture");
		}
		IntPtr arg = IntPtr.Zero;
		IMTLTexture result = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selNewTextureWithMDLTexture_Options_Error_Handle, texture.Handle, options?.Handle ?? IntPtr.Zero, ref arg), owns: false) : Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selNewTextureWithMDLTexture_Options_Error_Handle, texture.Handle, options?.Handle ?? IntPtr.Zero, ref arg), owns: false));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMTLTexture? FromTexture(MDLTexture texture, MTKTextureLoaderOptions? options, out NSError error)
	{
		return FromTexture(texture, options.GetDictionary(), out error);
	}

	[Export("newTextureWithContentsOfURL:options:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal unsafe virtual void FromUrl(NSUrl url, NSDictionary? options, [BlockProxy(typeof(Trampolines.NIDMTKTextureLoaderCallback))] MTKTextureLoaderCallback completionHandler)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMTKTextureLoaderCallback.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selNewTextureWithContentsOfURL_Options_CompletionHandler_Handle, url.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selNewTextureWithContentsOfURL_Options_CompletionHandler_Handle, url.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void FromUrl(NSUrl url, MTKTextureLoaderOptions? options, [BlockProxy(typeof(Trampolines.NIDMTKTextureLoaderCallback))] MTKTextureLoaderCallback completionHandler)
	{
		FromUrl(url, options.GetDictionary(), completionHandler);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Task<IMTLTexture> FromUrlAsync(NSUrl url, MTKTextureLoaderOptions? options)
	{
		TaskCompletionSource<IMTLTexture> tcs = new TaskCompletionSource<IMTLTexture>();
		FromUrl(url, options, delegate(IMTLTexture? texture_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(texture_);
			}
		});
		return tcs.Task;
	}

	[Export("newTextureWithContentsOfURL:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IMTLTexture? FromUrl(NSUrl url, NSDictionary? options, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		IMTLTexture result = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selNewTextureWithContentsOfURL_Options_Error_Handle, url.Handle, options?.Handle ?? IntPtr.Zero, ref arg), owns: false) : Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selNewTextureWithContentsOfURL_Options_Error_Handle, url.Handle, options?.Handle ?? IntPtr.Zero, ref arg), owns: false));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMTLTexture? FromUrl(NSUrl url, MTKTextureLoaderOptions? options, out NSError error)
	{
		return FromUrl(url, options.GetDictionary(), out error);
	}

	[Export("newTexturesWithContentsOfURLs:options:completionHandler:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FromUrls(NSUrl[] urls, NSDictionary? options, [BlockProxy(typeof(Trampolines.NIDMTKTextureLoaderArrayCallback))] MTKTextureLoaderArrayCallback completionHandler)
	{
		if (urls == null)
		{
			throw new ArgumentNullException("urls");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		NSArray nSArray = NSArray.FromNSObjects(urls);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMTKTextureLoaderArrayCallback.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selNewTexturesWithContentsOfURLs_Options_CompletionHandler_Handle, nSArray.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selNewTexturesWithContentsOfURLs_Options_CompletionHandler_Handle, nSArray.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		nSArray.Dispose();
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<IMTLTexture[]> FromUrlsAsync(NSUrl[] urls, NSDictionary? options)
	{
		TaskCompletionSource<IMTLTexture[]> tcs = new TaskCompletionSource<IMTLTexture[]>();
		FromUrls(urls, options, delegate(IMTLTexture[] textures_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(textures_);
			}
		});
		return tcs.Task;
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void FromUrls(NSUrl[] urls, MTKTextureLoaderOptions? options, [BlockProxy(typeof(Trampolines.NIDMTKTextureLoaderArrayCallback))] MTKTextureLoaderArrayCallback completionHandler)
	{
		FromUrls(urls, options.GetDictionary(), completionHandler);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Task<IMTLTexture[]> FromUrlsAsync(NSUrl[] urls, MTKTextureLoaderOptions? options)
	{
		TaskCompletionSource<IMTLTexture[]> tcs = new TaskCompletionSource<IMTLTexture[]>();
		FromUrls(urls, options, delegate(IMTLTexture[] textures_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(textures_);
			}
		});
		return tcs.Task;
	}

	[Export("newTexturesWithContentsOfURLs:options:error:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMTLTexture[] FromUrls(NSUrl[] urls, NSDictionary? options, out NSError error)
	{
		if (urls == null)
		{
			throw new ArgumentNullException("urls");
		}
		IntPtr arg = IntPtr.Zero;
		NSArray nSArray = NSArray.FromNSObjects(urls);
		IMTLTexture[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<IMTLTexture>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selNewTexturesWithContentsOfURLs_Options_Error_Handle, nSArray.Handle, options?.Handle ?? IntPtr.Zero, ref arg)) : NSArray.ArrayFromHandle<IMTLTexture>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selNewTexturesWithContentsOfURLs_Options_Error_Handle, nSArray.Handle, options?.Handle ?? IntPtr.Zero, ref arg)));
		nSArray.Dispose();
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMTLTexture[] FromUrls(NSUrl[] urls, MTKTextureLoaderOptions? options, out NSError error)
	{
		return FromUrls(urls, options.GetDictionary(), out error);
	}
}

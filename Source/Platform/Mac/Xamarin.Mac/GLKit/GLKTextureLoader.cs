using System;
using System.ComponentModel;
using System.Threading.Tasks;
using AppKit;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace GLKit;

[Register("GLKTextureLoader", true)]
[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
public class GLKTextureLoader : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCubeMapWithContentsOfFile_Options_Error_ = "cubeMapWithContentsOfFile:options:error:";

	private static readonly IntPtr selCubeMapWithContentsOfFile_Options_Error_Handle = Selector.GetHandle("cubeMapWithContentsOfFile:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCubeMapWithContentsOfFile_Options_Queue_CompletionHandler_ = "cubeMapWithContentsOfFile:options:queue:completionHandler:";

	private static readonly IntPtr selCubeMapWithContentsOfFile_Options_Queue_CompletionHandler_Handle = Selector.GetHandle("cubeMapWithContentsOfFile:options:queue:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCubeMapWithContentsOfFiles_Options_Error_ = "cubeMapWithContentsOfFiles:options:error:";

	private static readonly IntPtr selCubeMapWithContentsOfFiles_Options_Error_Handle = Selector.GetHandle("cubeMapWithContentsOfFiles:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCubeMapWithContentsOfFiles_Options_Queue_CompletionHandler_ = "cubeMapWithContentsOfFiles:options:queue:completionHandler:";

	private static readonly IntPtr selCubeMapWithContentsOfFiles_Options_Queue_CompletionHandler_Handle = Selector.GetHandle("cubeMapWithContentsOfFiles:options:queue:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCubeMapWithContentsOfURL_Options_Error_ = "cubeMapWithContentsOfURL:options:error:";

	private static readonly IntPtr selCubeMapWithContentsOfURL_Options_Error_Handle = Selector.GetHandle("cubeMapWithContentsOfURL:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCubeMapWithContentsOfURL_Options_Queue_CompletionHandler_ = "cubeMapWithContentsOfURL:options:queue:completionHandler:";

	private static readonly IntPtr selCubeMapWithContentsOfURL_Options_Queue_CompletionHandler_Handle = Selector.GetHandle("cubeMapWithContentsOfURL:options:queue:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithShareContext_ = "initWithShareContext:";

	private static readonly IntPtr selInitWithShareContext_Handle = Selector.GetHandle("initWithShareContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureWithCGImage_Options_Error_ = "textureWithCGImage:options:error:";

	private static readonly IntPtr selTextureWithCGImage_Options_Error_Handle = Selector.GetHandle("textureWithCGImage:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureWithCGImage_Options_Queue_CompletionHandler_ = "textureWithCGImage:options:queue:completionHandler:";

	private static readonly IntPtr selTextureWithCGImage_Options_Queue_CompletionHandler_Handle = Selector.GetHandle("textureWithCGImage:options:queue:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureWithContentsOfData_Options_Error_ = "textureWithContentsOfData:options:error:";

	private static readonly IntPtr selTextureWithContentsOfData_Options_Error_Handle = Selector.GetHandle("textureWithContentsOfData:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureWithContentsOfData_Options_Queue_CompletionHandler_ = "textureWithContentsOfData:options:queue:completionHandler:";

	private static readonly IntPtr selTextureWithContentsOfData_Options_Queue_CompletionHandler_Handle = Selector.GetHandle("textureWithContentsOfData:options:queue:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureWithContentsOfFile_Options_Error_ = "textureWithContentsOfFile:options:error:";

	private static readonly IntPtr selTextureWithContentsOfFile_Options_Error_Handle = Selector.GetHandle("textureWithContentsOfFile:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureWithContentsOfFile_Options_Queue_CompletionHandler_ = "textureWithContentsOfFile:options:queue:completionHandler:";

	private static readonly IntPtr selTextureWithContentsOfFile_Options_Queue_CompletionHandler_Handle = Selector.GetHandle("textureWithContentsOfFile:options:queue:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureWithContentsOfURL_Options_Error_ = "textureWithContentsOfURL:options:error:";

	private static readonly IntPtr selTextureWithContentsOfURL_Options_Error_Handle = Selector.GetHandle("textureWithContentsOfURL:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureWithContentsOfURL_Options_Queue_CompletionHandler_ = "textureWithContentsOfURL:options:queue:completionHandler:";

	private static readonly IntPtr selTextureWithContentsOfURL_Options_Queue_CompletionHandler_Handle = Selector.GetHandle("textureWithContentsOfURL:options:queue:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureWithName_ScaleFactor_Bundle_Options_Error_ = "textureWithName:scaleFactor:bundle:options:error:";

	private static readonly IntPtr selTextureWithName_ScaleFactor_Bundle_Options_Error_Handle = Selector.GetHandle("textureWithName:scaleFactor:bundle:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureWithName_ScaleFactor_Bundle_Options_Queue_CompletionHandler_ = "textureWithName:scaleFactor:bundle:options:queue:completionHandler:";

	private static readonly IntPtr selTextureWithName_ScaleFactor_Bundle_Options_Queue_CompletionHandler_Handle = Selector.GetHandle("textureWithName:scaleFactor:bundle:options:queue:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GLKTextureLoader");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ApplyPremultiplication;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ErrorDomain;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ErrorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GLErrorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GenerateMipmaps;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GrayscaleAsAlpha;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _OriginBottomLeft;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SRGB;

	public override IntPtr ClassHandle => class_ptr;

	[Field("GLKTextureLoaderApplyPremultiplication", "GLKit")]
	public static NSString ApplyPremultiplication
	{
		get
		{
			if (_ApplyPremultiplication == null)
			{
				_ApplyPremultiplication = Dlfcn.GetStringConstant(Libraries.GLKit.Handle, "GLKTextureLoaderApplyPremultiplication");
			}
			return _ApplyPremultiplication;
		}
	}

	[Field("GLKTextureLoaderErrorDomain", "GLKit")]
	public static NSString ErrorDomain
	{
		get
		{
			if (_ErrorDomain == null)
			{
				_ErrorDomain = Dlfcn.GetStringConstant(Libraries.GLKit.Handle, "GLKTextureLoaderErrorDomain");
			}
			return _ErrorDomain;
		}
	}

	[Field("GLKTextureLoaderErrorKey", "GLKit")]
	public static NSString ErrorKey
	{
		get
		{
			if (_ErrorKey == null)
			{
				_ErrorKey = Dlfcn.GetStringConstant(Libraries.GLKit.Handle, "GLKTextureLoaderErrorKey");
			}
			return _ErrorKey;
		}
	}

	[Field("GLKTextureLoaderGLErrorKey", "GLKit")]
	public static NSString GLErrorKey
	{
		get
		{
			if (_GLErrorKey == null)
			{
				_GLErrorKey = Dlfcn.GetStringConstant(Libraries.GLKit.Handle, "GLKTextureLoaderGLErrorKey");
			}
			return _GLErrorKey;
		}
	}

	[Field("GLKTextureLoaderGenerateMipmaps", "GLKit")]
	public static NSString GenerateMipmaps
	{
		get
		{
			if (_GenerateMipmaps == null)
			{
				_GenerateMipmaps = Dlfcn.GetStringConstant(Libraries.GLKit.Handle, "GLKTextureLoaderGenerateMipmaps");
			}
			return _GenerateMipmaps;
		}
	}

	[Field("GLKTextureLoaderGrayscaleAsAlpha", "GLKit")]
	public static NSString GrayscaleAsAlpha
	{
		get
		{
			if (_GrayscaleAsAlpha == null)
			{
				_GrayscaleAsAlpha = Dlfcn.GetStringConstant(Libraries.GLKit.Handle, "GLKTextureLoaderGrayscaleAsAlpha");
			}
			return _GrayscaleAsAlpha;
		}
	}

	[Field("GLKTextureLoaderOriginBottomLeft", "GLKit")]
	public static NSString OriginBottomLeft
	{
		get
		{
			if (_OriginBottomLeft == null)
			{
				_OriginBottomLeft = Dlfcn.GetStringConstant(Libraries.GLKit.Handle, "GLKTextureLoaderOriginBottomLeft");
			}
			return _OriginBottomLeft;
		}
	}

	[Field("GLKTextureLoaderSRGB", "GLKit")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	public static NSString SRGB
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		get
		{
			if (_SRGB == null)
			{
				_SRGB = Dlfcn.GetStringConstant(Libraries.GLKit.Handle, "GLKTextureLoaderSRGB");
			}
			return _SRGB;
		}
	}

	public static GLKTextureInfo CubeMapFromFiles(string[] files, NSDictionary textureOperations, out NSError error)
	{
		using NSArray paths = NSArray.FromStrings(files);
		return CubeMapFromFiles(paths, textureOperations, out error);
	}

	public static GLKTextureInfo CubeMapFromUrls(NSUrl[] urls, NSDictionary textureOperations, out NSError error)
	{
		using NSArray paths = NSArray.FromNSObjects(urls);
		return CubeMapFromFiles(paths, textureOperations, out error);
	}

	public void BeginLoadCubeMap(string[] files, NSDictionary textureOperations, DispatchQueue queue, GLKTextureLoaderCallback onComplete)
	{
		using NSArray filePaths = NSArray.FromStrings(files);
		BeginLoadCubeMap(filePaths, textureOperations, queue, onComplete);
	}

	public void BeginLoadCubeMap(NSUrl[] urls, NSDictionary textureOperations, DispatchQueue queue, GLKTextureLoaderCallback onComplete)
	{
		using NSArray filePaths = NSArray.FromNSObjects(urls);
		BeginLoadCubeMap(filePaths, textureOperations, queue, onComplete);
	}

	public static GLKTextureInfo FromFile(string path, GLKTextureOperations textureOperations, out NSError error)
	{
		return FromFile(path, textureOperations?.Dictionary, out error);
	}

	public static GLKTextureInfo FromUrl(NSUrl url, GLKTextureOperations textureOperations, out NSError error)
	{
		return FromUrl(url, textureOperations?.Dictionary, out error);
	}

	public static GLKTextureInfo FromData(NSData data, GLKTextureOperations textureOperations, out NSError error)
	{
		return FromData(data, textureOperations?.Dictionary, out error);
	}

	public static GLKTextureInfo FromImage(CGImage cgImage, GLKTextureOperations textureOperations, out NSError error)
	{
		return FromImage(cgImage, textureOperations?.Dictionary, out error);
	}

	public static GLKTextureInfo CubeMapFromFiles(string[] files, GLKTextureOperations textureOperations, out NSError error)
	{
		using (NSArray.FromStrings(files))
		{
			return CubeMapFromFiles(files, textureOperations?.Dictionary, out error);
		}
	}

	public static GLKTextureInfo CubeMapFromUrls(NSUrl[] urls, GLKTextureOperations textureOperations, out NSError error)
	{
		using NSArray paths = NSArray.FromNSObjects(urls);
		return CubeMapFromFiles(paths, textureOperations?.Dictionary, out error);
	}

	public static GLKTextureInfo CubeMapFromFile(string path, GLKTextureOperations textureOperations, out NSError error)
	{
		return CubeMapFromFile(path, textureOperations?.Dictionary, out error);
	}

	public static GLKTextureInfo CubeMapFromUrl(NSUrl url, GLKTextureOperations textureOperations, out NSError error)
	{
		return CubeMapFromUrl(url, textureOperations?.Dictionary, out error);
	}

	public void BeginTextureLoad(string file, GLKTextureOperations textureOperations, DispatchQueue queue, GLKTextureLoaderCallback onComplete)
	{
		BeginTextureLoad(file, textureOperations?.Dictionary, queue, onComplete);
	}

	public void BeginTextureLoad(NSUrl filePath, GLKTextureOperations textureOperations, DispatchQueue queue, GLKTextureLoaderCallback onComplete)
	{
		BeginTextureLoad(filePath, textureOperations?.Dictionary, queue, onComplete);
	}

	public void BeginTextureLoad(NSData data, GLKTextureOperations textureOperations, DispatchQueue queue, GLKTextureLoaderCallback onComplete)
	{
		BeginTextureLoad(data, textureOperations?.Dictionary, queue, onComplete);
	}

	public void BeginTextureLoad(CGImage image, GLKTextureOperations textureOperations, DispatchQueue queue, GLKTextureLoaderCallback onComplete)
	{
		BeginTextureLoad(image, textureOperations?.Dictionary, queue, onComplete);
	}

	public void BeginLoadCubeMap(string[] files, GLKTextureOperations textureOperations, DispatchQueue queue, GLKTextureLoaderCallback onComplete)
	{
		using NSArray filePaths = NSArray.FromStrings(files);
		BeginLoadCubeMap(filePaths, textureOperations?.Dictionary, queue, onComplete);
	}

	public void BeginLoadCubeMap(NSUrl[] urls, GLKTextureOperations textureOperations, DispatchQueue queue, GLKTextureLoaderCallback onComplete)
	{
		using NSArray filePaths = NSArray.FromNSObjects(urls);
		BeginLoadCubeMap(filePaths, textureOperations?.Dictionary, queue, onComplete);
	}

	public void BeginLoadCubeMap(string fileName, GLKTextureOperations textureOperations, DispatchQueue queue, GLKTextureLoaderCallback onComplete)
	{
		BeginLoadCubeMap(fileName, textureOperations?.Dictionary, queue, onComplete);
	}

	public void BeginLoadCubeMap(NSUrl filePath, GLKTextureOperations textureOperations, DispatchQueue queue, GLKTextureLoaderCallback onComplete)
	{
		BeginLoadCubeMap(filePath, textureOperations?.Dictionary, queue, onComplete);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GLKTextureLoader()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GLKTextureLoader(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GLKTextureLoader(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithShareContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GLKTextureLoader(NSOpenGLContext context)
		: base(NSObjectFlag.Empty)
	{
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithShareContext_Handle, context.Handle), "initWithShareContext:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithShareContext_Handle, context.Handle), "initWithShareContext:");
		}
	}

	[Export("cubeMapWithContentsOfFiles:options:queue:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal unsafe virtual void BeginLoadCubeMap(NSArray filePaths, NSDictionary? textureOperations, DispatchQueue? queue, [BlockProxy(typeof(Trampolines.NIDGLKTextureLoaderCallback))] GLKTextureLoaderCallback onComplete)
	{
		if (filePaths == null)
		{
			throw new ArgumentNullException("filePaths");
		}
		if (onComplete == null)
		{
			throw new ArgumentNullException("onComplete");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDGLKTextureLoaderCallback.Handler, onComplete);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selCubeMapWithContentsOfFiles_Options_Queue_CompletionHandler_Handle, filePaths.Handle, textureOperations?.Handle ?? IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCubeMapWithContentsOfFiles_Options_Queue_CompletionHandler_Handle, filePaths.Handle, textureOperations?.Handle ?? IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual Task<GLKTextureInfo> BeginLoadCubeMapAsync(NSArray filePaths, NSDictionary? textureOperations, DispatchQueue? queue)
	{
		TaskCompletionSource<GLKTextureInfo> tcs = new TaskCompletionSource<GLKTextureInfo>();
		BeginLoadCubeMap(filePaths, textureOperations, queue, delegate(GLKTextureInfo textureInfo_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(textureInfo_);
			}
		});
		return tcs.Task;
	}

	[Export("cubeMapWithContentsOfFile:options:queue:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void BeginLoadCubeMap(string fileName, NSDictionary? textureOperations, DispatchQueue? queue, [BlockProxy(typeof(Trampolines.NIDGLKTextureLoaderCallback))] GLKTextureLoaderCallback onComplete)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (onComplete == null)
		{
			throw new ArgumentNullException("onComplete");
		}
		IntPtr arg = NSString.CreateNative(fileName);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDGLKTextureLoaderCallback.Handler, onComplete);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selCubeMapWithContentsOfFile_Options_Queue_CompletionHandler_Handle, arg, textureOperations?.Handle ?? IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCubeMapWithContentsOfFile_Options_Queue_CompletionHandler_Handle, arg, textureOperations?.Handle ?? IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GLKTextureInfo> BeginLoadCubeMapAsync(string fileName, NSDictionary? textureOperations, DispatchQueue? queue)
	{
		TaskCompletionSource<GLKTextureInfo> tcs = new TaskCompletionSource<GLKTextureInfo>();
		BeginLoadCubeMap(fileName, textureOperations, queue, delegate(GLKTextureInfo textureInfo_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(textureInfo_);
			}
		});
		return tcs.Task;
	}

	[Export("cubeMapWithContentsOfURL:options:queue:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void BeginLoadCubeMap(NSUrl filePath, NSDictionary? textureOperations, DispatchQueue? queue, [BlockProxy(typeof(Trampolines.NIDGLKTextureLoaderCallback))] GLKTextureLoaderCallback onComplete)
	{
		if (filePath == null)
		{
			throw new ArgumentNullException("filePath");
		}
		if (onComplete == null)
		{
			throw new ArgumentNullException("onComplete");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDGLKTextureLoaderCallback.Handler, onComplete);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selCubeMapWithContentsOfURL_Options_Queue_CompletionHandler_Handle, filePath.Handle, textureOperations?.Handle ?? IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCubeMapWithContentsOfURL_Options_Queue_CompletionHandler_Handle, filePath.Handle, textureOperations?.Handle ?? IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GLKTextureInfo> BeginLoadCubeMapAsync(NSUrl filePath, NSDictionary? textureOperations, DispatchQueue? queue)
	{
		TaskCompletionSource<GLKTextureInfo> tcs = new TaskCompletionSource<GLKTextureInfo>();
		BeginLoadCubeMap(filePath, textureOperations, queue, delegate(GLKTextureInfo textureInfo_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(textureInfo_);
			}
		});
		return tcs.Task;
	}

	[Export("textureWithContentsOfFile:options:queue:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void BeginTextureLoad(string file, NSDictionary? textureOperations, DispatchQueue? queue, [BlockProxy(typeof(Trampolines.NIDGLKTextureLoaderCallback))] GLKTextureLoaderCallback onComplete)
	{
		if (file == null)
		{
			throw new ArgumentNullException("file");
		}
		if (onComplete == null)
		{
			throw new ArgumentNullException("onComplete");
		}
		IntPtr arg = NSString.CreateNative(file);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDGLKTextureLoaderCallback.Handler, onComplete);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selTextureWithContentsOfFile_Options_Queue_CompletionHandler_Handle, arg, textureOperations?.Handle ?? IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selTextureWithContentsOfFile_Options_Queue_CompletionHandler_Handle, arg, textureOperations?.Handle ?? IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GLKTextureInfo> BeginTextureLoadAsync(string file, NSDictionary? textureOperations, DispatchQueue? queue)
	{
		TaskCompletionSource<GLKTextureInfo> tcs = new TaskCompletionSource<GLKTextureInfo>();
		BeginTextureLoad(file, textureOperations, queue, delegate(GLKTextureInfo textureInfo_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(textureInfo_);
			}
		});
		return tcs.Task;
	}

	[Export("textureWithContentsOfURL:options:queue:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void BeginTextureLoad(NSUrl filePath, NSDictionary? textureOperations, DispatchQueue? queue, [BlockProxy(typeof(Trampolines.NIDGLKTextureLoaderCallback))] GLKTextureLoaderCallback onComplete)
	{
		if (filePath == null)
		{
			throw new ArgumentNullException("filePath");
		}
		if (onComplete == null)
		{
			throw new ArgumentNullException("onComplete");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDGLKTextureLoaderCallback.Handler, onComplete);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selTextureWithContentsOfURL_Options_Queue_CompletionHandler_Handle, filePath.Handle, textureOperations?.Handle ?? IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selTextureWithContentsOfURL_Options_Queue_CompletionHandler_Handle, filePath.Handle, textureOperations?.Handle ?? IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GLKTextureInfo> BeginTextureLoadAsync(NSUrl filePath, NSDictionary? textureOperations, DispatchQueue? queue)
	{
		TaskCompletionSource<GLKTextureInfo> tcs = new TaskCompletionSource<GLKTextureInfo>();
		BeginTextureLoad(filePath, textureOperations, queue, delegate(GLKTextureInfo textureInfo_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(textureInfo_);
			}
		});
		return tcs.Task;
	}

	[Export("textureWithContentsOfData:options:queue:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void BeginTextureLoad(NSData data, NSDictionary? textureOperations, DispatchQueue? queue, [BlockProxy(typeof(Trampolines.NIDGLKTextureLoaderCallback))] GLKTextureLoaderCallback onComplete)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (onComplete == null)
		{
			throw new ArgumentNullException("onComplete");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDGLKTextureLoaderCallback.Handler, onComplete);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selTextureWithContentsOfData_Options_Queue_CompletionHandler_Handle, data.Handle, textureOperations?.Handle ?? IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selTextureWithContentsOfData_Options_Queue_CompletionHandler_Handle, data.Handle, textureOperations?.Handle ?? IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GLKTextureInfo> BeginTextureLoadAsync(NSData data, NSDictionary? textureOperations, DispatchQueue? queue)
	{
		TaskCompletionSource<GLKTextureInfo> tcs = new TaskCompletionSource<GLKTextureInfo>();
		BeginTextureLoad(data, textureOperations, queue, delegate(GLKTextureInfo textureInfo_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(textureInfo_);
			}
		});
		return tcs.Task;
	}

	[Export("textureWithCGImage:options:queue:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void BeginTextureLoad(CGImage image, NSDictionary? textureOperations, DispatchQueue? queue, [BlockProxy(typeof(Trampolines.NIDGLKTextureLoaderCallback))] GLKTextureLoaderCallback onComplete)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (onComplete == null)
		{
			throw new ArgumentNullException("onComplete");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDGLKTextureLoaderCallback.Handler, onComplete);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selTextureWithCGImage_Options_Queue_CompletionHandler_Handle, image.Handle, textureOperations?.Handle ?? IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selTextureWithCGImage_Options_Queue_CompletionHandler_Handle, image.Handle, textureOperations?.Handle ?? IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GLKTextureInfo> BeginTextureLoadAsync(CGImage image, NSDictionary? textureOperations, DispatchQueue? queue)
	{
		TaskCompletionSource<GLKTextureInfo> tcs = new TaskCompletionSource<GLKTextureInfo>();
		BeginTextureLoad(image, textureOperations, queue, delegate(GLKTextureInfo textureInfo_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(textureInfo_);
			}
		});
		return tcs.Task;
	}

	[Export("textureWithName:scaleFactor:bundle:options:queue:completionHandler:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void BeginTextureLoad(string name, nfloat scaleFactor, NSBundle? bundle, NSDictionary<NSString, NSNumber>? options, DispatchQueue? queue, [BlockProxy(typeof(Trampolines.NIDGLKTextureLoaderCallback))] GLKTextureLoaderCallback block)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		IntPtr arg = NSString.CreateNative(name);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDGLKTextureLoaderCallback.Handler, block);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nfloat_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selTextureWithName_ScaleFactor_Bundle_Options_Queue_CompletionHandler_Handle, arg, scaleFactor, bundle?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nfloat_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selTextureWithName_ScaleFactor_Bundle_Options_Queue_CompletionHandler_Handle, arg, scaleFactor, bundle?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero, (queue == null) ? IntPtr.Zero : queue.Handle, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<GLKTextureInfo> BeginTextureLoadAsync(string name, nfloat scaleFactor, NSBundle? bundle, NSDictionary<NSString, NSNumber>? options, DispatchQueue? queue)
	{
		TaskCompletionSource<GLKTextureInfo> tcs = new TaskCompletionSource<GLKTextureInfo>();
		BeginTextureLoad(name, scaleFactor, bundle, options, queue, delegate(GLKTextureInfo textureInfo_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(textureInfo_);
			}
		});
		return tcs.Task;
	}

	[Export("cubeMapWithContentsOfFile:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GLKTextureInfo CubeMapFromFile(string path, NSDictionary? textureOperations, out NSError error)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(path);
		GLKTextureInfo nSObject = Runtime.GetNSObject<GLKTextureInfo>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selCubeMapWithContentsOfFile_Options_Error_Handle, arg2, textureOperations?.Handle ?? IntPtr.Zero, ref arg));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("cubeMapWithContentsOfFiles:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static GLKTextureInfo CubeMapFromFiles(NSArray paths, NSDictionary? textureOperations, out NSError error)
	{
		if (paths == null)
		{
			throw new ArgumentNullException("paths");
		}
		IntPtr arg = IntPtr.Zero;
		GLKTextureInfo nSObject = Runtime.GetNSObject<GLKTextureInfo>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selCubeMapWithContentsOfFiles_Options_Error_Handle, paths.Handle, textureOperations?.Handle ?? IntPtr.Zero, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("cubeMapWithContentsOfURL:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GLKTextureInfo CubeMapFromUrl(NSUrl url, NSDictionary? textureOperations, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		GLKTextureInfo nSObject = Runtime.GetNSObject<GLKTextureInfo>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selCubeMapWithContentsOfURL_Options_Error_Handle, url.Handle, textureOperations?.Handle ?? IntPtr.Zero, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("textureWithContentsOfData:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GLKTextureInfo FromData(NSData data, NSDictionary? textureOperations, out NSError error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		GLKTextureInfo nSObject = Runtime.GetNSObject<GLKTextureInfo>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selTextureWithContentsOfData_Options_Error_Handle, data.Handle, textureOperations?.Handle ?? IntPtr.Zero, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("textureWithContentsOfFile:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GLKTextureInfo FromFile(string path, NSDictionary? textureOperations, out NSError error)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(path);
		GLKTextureInfo nSObject = Runtime.GetNSObject<GLKTextureInfo>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selTextureWithContentsOfFile_Options_Error_Handle, arg2, textureOperations?.Handle ?? IntPtr.Zero, ref arg));
		NSString.ReleaseNative(arg2);
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("textureWithCGImage:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GLKTextureInfo FromImage(CGImage cgImage, NSDictionary? textureOperations, out NSError error)
	{
		if (cgImage == null)
		{
			throw new ArgumentNullException("cgImage");
		}
		IntPtr arg = IntPtr.Zero;
		GLKTextureInfo nSObject = Runtime.GetNSObject<GLKTextureInfo>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selTextureWithCGImage_Options_Error_Handle, cgImage.Handle, textureOperations?.Handle ?? IntPtr.Zero, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("textureWithName:scaleFactor:bundle:options:error:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GLKTextureInfo? FromName(string name, nfloat scaleFactor, NSBundle? bundle, NSDictionary<NSString, NSNumber>? options, out NSError outError)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(name);
		GLKTextureInfo nSObject = Runtime.GetNSObject<GLKTextureInfo>(Messaging.IntPtr_objc_msgSend_IntPtr_nfloat_IntPtr_IntPtr_ref_IntPtr(class_ptr, selTextureWithName_ScaleFactor_Bundle_Options_Error_Handle, arg2, scaleFactor, bundle?.Handle ?? IntPtr.Zero, options?.Handle ?? IntPtr.Zero, ref arg));
		NSString.ReleaseNative(arg2);
		outError = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("textureWithContentsOfURL:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GLKTextureInfo FromUrl(NSUrl url, NSDictionary? textureOperations, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		GLKTextureInfo nSObject = Runtime.GetNSObject<GLKTextureInfo>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selTextureWithContentsOfURL_Options_Error_Handle, url.Handle, textureOperations?.Handle ?? IntPtr.Zero, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}
}

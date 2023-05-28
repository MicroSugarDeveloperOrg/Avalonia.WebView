using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKTextureAtlas", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class SKTextureAtlas : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAtlasNamed_ = "atlasNamed:";

	private static readonly IntPtr selAtlasNamed_Handle = Selector.GetHandle("atlasNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAtlasWithDictionary_ = "atlasWithDictionary:";

	private static readonly IntPtr selAtlasWithDictionary_Handle = Selector.GetHandle("atlasWithDictionary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreloadTextureAtlases_WithCompletionHandler_ = "preloadTextureAtlases:withCompletionHandler:";

	private static readonly IntPtr selPreloadTextureAtlases_WithCompletionHandler_Handle = Selector.GetHandle("preloadTextureAtlases:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreloadTextureAtlasesNamed_WithCompletionHandler_ = "preloadTextureAtlasesNamed:withCompletionHandler:";

	private static readonly IntPtr selPreloadTextureAtlasesNamed_WithCompletionHandler_Handle = Selector.GetHandle("preloadTextureAtlasesNamed:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreloadWithCompletionHandler_ = "preloadWithCompletionHandler:";

	private static readonly IntPtr selPreloadWithCompletionHandler_Handle = Selector.GetHandle("preloadWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureNamed_ = "textureNamed:";

	private static readonly IntPtr selTextureNamed_Handle = Selector.GetHandle("textureNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureNames = "textureNames";

	private static readonly IntPtr selTextureNamesHandle = Selector.GetHandle("textureNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKTextureAtlas");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] TextureNames
	{
		[Export("textureNames")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTextureNamesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextureNamesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKTextureAtlas()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SKTextureAtlas(NSCoder coder)
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
	protected SKTextureAtlas(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKTextureAtlas(IntPtr handle)
		: base(handle)
	{
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

	[Export("atlasWithDictionary:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTextureAtlas FromDictionary(NSDictionary properties)
	{
		if (properties == null)
		{
			throw new ArgumentNullException("properties");
		}
		return Runtime.GetNSObject<SKTextureAtlas>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAtlasWithDictionary_Handle, properties.Handle));
	}

	[Export("atlasNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKTextureAtlas FromName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		SKTextureAtlas nSObject = Runtime.GetNSObject<SKTextureAtlas>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAtlasNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("preloadWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Preload([BlockProxy(typeof(Trampolines.NIDAction))] Action? completion)
	{
		BlockLiteral* ptr;
		if (completion == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completion);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPreloadWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPreloadWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task PreloadAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Preload(delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Export("preloadTextureAtlasesNamed:withCompletionHandler:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void PreloadTextureAtlases(string[] atlasNames, [BlockProxy(typeof(Trampolines.NIDSKTextureAtlasLoadCallback))] SKTextureAtlasLoadCallback completionHandler)
	{
		if (atlasNames == null)
		{
			throw new ArgumentNullException("atlasNames");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		NSArray nSArray = NSArray.FromStrings(atlasNames);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSKTextureAtlasLoadCallback.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selPreloadTextureAtlasesNamed_WithCompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		nSArray.Dispose();
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<SKTextureAtlasLoadResult> PreloadTextureAtlasesAsync(string[] atlasNames)
	{
		TaskCompletionSource<SKTextureAtlasLoadResult> tcs = new TaskCompletionSource<SKTextureAtlasLoadResult>();
		PreloadTextureAtlases(atlasNames, delegate(NSError error_, SKTextureAtlas foundAtlases_)
		{
			tcs.SetResult(new SKTextureAtlasLoadResult(error_, foundAtlases_));
		});
		return tcs.Task;
	}

	[Export("preloadTextureAtlases:withCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void PreloadTextures(SKTextureAtlas[] textures, [BlockProxy(typeof(Trampolines.NIDAction))] Action? completion)
	{
		if (textures == null)
		{
			throw new ArgumentNullException("textures");
		}
		NSArray nSArray = NSArray.FromNSObjects(textures);
		BlockLiteral* ptr;
		if (completion == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completion);
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selPreloadTextureAtlases_WithCompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		nSArray.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task PreloadTexturesAsync(SKTextureAtlas[] textures)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		PreloadTextures(textures, delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Export("textureNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKTexture TextureNamed(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		SKTexture result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextureNamed_Handle, arg)) : Runtime.GetNSObject<SKTexture>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selTextureNamed_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}
}

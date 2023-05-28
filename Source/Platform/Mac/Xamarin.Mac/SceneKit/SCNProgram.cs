using System;
using System.ComponentModel;
using Foundation;
using Metal;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNProgram", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class SCNProgram : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFragmentFunctionName = "fragmentFunctionName";

	private static readonly IntPtr selFragmentFunctionNameHandle = Selector.GetHandle("fragmentFunctionName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFragmentShader = "fragmentShader";

	private static readonly IntPtr selFragmentShaderHandle = Selector.GetHandle("fragmentShader");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHandleBindingOfBufferNamed_Frequency_UsingBlock_ = "handleBindingOfBufferNamed:frequency:usingBlock:";

	private static readonly IntPtr selHandleBindingOfBufferNamed_Frequency_UsingBlock_Handle = Selector.GetHandle("handleBindingOfBufferNamed:frequency:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsOpaque = "isOpaque";

	private static readonly IntPtr selIsOpaqueHandle = Selector.GetHandle("isOpaque");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLibrary = "library";

	private static readonly IntPtr selLibraryHandle = Selector.GetHandle("library");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProgram = "program";

	private static readonly IntPtr selProgramHandle = Selector.GetHandle("program");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSemanticForSymbol_ = "semanticForSymbol:";

	private static readonly IntPtr selSemanticForSymbol_Handle = Selector.GetHandle("semanticForSymbol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFragmentFunctionName_ = "setFragmentFunctionName:";

	private static readonly IntPtr selSetFragmentFunctionName_Handle = Selector.GetHandle("setFragmentFunctionName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFragmentShader_ = "setFragmentShader:";

	private static readonly IntPtr selSetFragmentShader_Handle = Selector.GetHandle("setFragmentShader:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLibrary_ = "setLibrary:";

	private static readonly IntPtr selSetLibrary_Handle = Selector.GetHandle("setLibrary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOpaque_ = "setOpaque:";

	private static readonly IntPtr selSetOpaque_Handle = Selector.GetHandle("setOpaque:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSemantic_ForSymbol_Options_ = "setSemantic:forSymbol:options:";

	private static readonly IntPtr selSetSemantic_ForSymbol_Options_Handle = Selector.GetHandle("setSemantic:forSymbol:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVertexFunctionName_ = "setVertexFunctionName:";

	private static readonly IntPtr selSetVertexFunctionName_Handle = Selector.GetHandle("setVertexFunctionName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVertexShader_ = "setVertexShader:";

	private static readonly IntPtr selSetVertexShader_Handle = Selector.GetHandle("setVertexShader:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVertexFunctionName = "vertexFunctionName";

	private static readonly IntPtr selVertexFunctionNameHandle = Selector.GetHandle("vertexFunctionName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVertexShader = "vertexShader";

	private static readonly IntPtr selVertexShaderHandle = Selector.GetHandle("vertexShader");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNProgram");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _MappingChannelKey;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public ISCNProgramDelegate Delegate
	{
		get
		{
			return WeakDelegate as ISCNProgramDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual string? FragmentFunctionName
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("fragmentFunctionName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFragmentFunctionNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFragmentFunctionNameHandle));
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setFragmentFunctionName:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFragmentFunctionName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFragmentFunctionName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? FragmentShader
	{
		[Export("fragmentShader", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFragmentShaderHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFragmentShaderHandle));
		}
		[Export("setFragmentShader:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFragmentShader_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFragmentShader_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual IMTLLibrary? Library
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("library", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMTLLibrary>(Messaging.IntPtr_objc_msgSend(base.Handle, selLibraryHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMTLLibrary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLibraryHandle), owns: false);
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setLibrary:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLibrary_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLibrary_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public virtual bool Opaque
	{
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("isOpaque")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOpaqueHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOpaqueHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		[Export("setOpaque:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetOpaque_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetOpaque_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual string? VertexFunctionName
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("vertexFunctionName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selVertexFunctionNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVertexFunctionNameHandle));
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setVertexFunctionName:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVertexFunctionName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVertexFunctionName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? VertexShader
	{
		[Export("vertexShader", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selVertexShaderHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVertexShaderHandle));
		}
		[Export("setVertexShader:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVertexShader_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVertexShader_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[Field("SCNProgramMappingChannelKey", "SceneKit")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public static NSString MappingChannelKey
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		get
		{
			if (_MappingChannelKey == null)
			{
				_MappingChannelKey = Dlfcn.GetStringConstant(Libraries.SceneKit.Handle, "SCNProgramMappingChannelKey");
			}
			return _MappingChannelKey;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SCNProgram()
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
	public SCNProgram(NSCoder coder)
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
	protected SCNProgram(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNProgram(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("program")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNProgram Create()
	{
		return Runtime.GetNSObject<SCNProgram>(Messaging.IntPtr_objc_msgSend(class_ptr, selProgramHandle));
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

	[Export("semanticForSymbol:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString GetSemanticForSymbol(string symbol)
	{
		if (symbol == null)
		{
			throw new ArgumentNullException("symbol");
		}
		IntPtr arg = NSString.CreateNative(symbol);
		NSString result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSemanticForSymbol_Handle, arg)) : Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSemanticForSymbol_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("handleBindingOfBufferNamed:frequency:usingBlock:")]
	[Obsolete("Use 'HandleBinding' overload with 'SCNBufferBindingHandler2' parameter instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void HandleBinding(string name, SCNBufferFrequency frequency, [BlockProxy(typeof(Trampolines.NIDSCNBufferBindingHandler))] SCNBufferBindingHandler handler)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		IntPtr arg = NSString.CreateNative(name);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSCNBufferBindingHandler.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64_IntPtr(base.Handle, selHandleBindingOfBufferNamed_Frequency_UsingBlock_Handle, arg, (long)frequency, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64_IntPtr(base.SuperHandle, selHandleBindingOfBufferNamed_Frequency_UsingBlock_Handle, arg, (long)frequency, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void HandleBinding(string name, SCNBufferFrequency frequency, [BlockProxy(typeof(Trampolines.NIDSCNBufferBindingHandler2))] SCNBufferBindingHandler2 handler)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		IntPtr arg = NSString.CreateNative(name);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSCNBufferBindingHandler2.Handler, handler);
		Messaging.void_objc_msgSend_IntPtr_Int64_IntPtr(base.Handle, selHandleBindingOfBufferNamed_Frequency_UsingBlock_Handle, arg, (long)frequency, (IntPtr)ptr);
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Export("setSemantic:forSymbol:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetSemantic(NSString geometrySourceSemantic, string symbol, NSDictionary? options)
	{
		if (geometrySourceSemantic == null)
		{
			throw new ArgumentNullException("geometrySourceSemantic");
		}
		if (symbol == null)
		{
			throw new ArgumentNullException("symbol");
		}
		IntPtr arg = NSString.CreateNative(symbol);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selSetSemantic_ForSymbol_Options_Handle, geometrySourceSemantic.Handle, arg, options?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSetSemantic_ForSymbol_Options_Handle, geometrySourceSemantic.Handle, arg, options?.Handle ?? IntPtr.Zero);
		}
		NSString.ReleaseNative(arg);
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetSemantic(NSString geometrySourceSemantic, string symbol, SCNProgramSemanticOptions options)
	{
		SetSemantic(geometrySourceSemantic, symbol, options.GetDictionary());
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}

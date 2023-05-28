using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKShader", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SKShader : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddUniform_ = "addUniform:";

	private static readonly IntPtr selAddUniform_Handle = Selector.GetHandle("addUniform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributes = "attributes";

	private static readonly IntPtr selAttributesHandle = Selector.GetHandle("attributes");

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
	private const string selInitWithSource_ = "initWithSource:";

	private static readonly IntPtr selInitWithSource_Handle = Selector.GetHandle("initWithSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSource_Uniforms_ = "initWithSource:uniforms:";

	private static readonly IntPtr selInitWithSource_Uniforms_Handle = Selector.GetHandle("initWithSource:uniforms:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveUniformNamed_ = "removeUniformNamed:";

	private static readonly IntPtr selRemoveUniformNamed_Handle = Selector.GetHandle("removeUniformNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributes_ = "setAttributes:";

	private static readonly IntPtr selSetAttributes_Handle = Selector.GetHandle("setAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSource_ = "setSource:";

	private static readonly IntPtr selSetSource_Handle = Selector.GetHandle("setSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUniforms_ = "setUniforms:";

	private static readonly IntPtr selSetUniforms_Handle = Selector.GetHandle("setUniforms:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShader = "shader";

	private static readonly IntPtr selShaderHandle = Selector.GetHandle("shader");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShaderWithFileNamed_ = "shaderWithFileNamed:";

	private static readonly IntPtr selShaderWithFileNamed_Handle = Selector.GetHandle("shaderWithFileNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShaderWithSource_ = "shaderWithSource:";

	private static readonly IntPtr selShaderWithSource_Handle = Selector.GetHandle("shaderWithSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShaderWithSource_Uniforms_ = "shaderWithSource:uniforms:";

	private static readonly IntPtr selShaderWithSource_Uniforms_Handle = Selector.GetHandle("shaderWithSource:uniforms:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSource = "source";

	private static readonly IntPtr selSourceHandle = Selector.GetHandle("source");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUniformNamed_ = "uniformNamed:";

	private static readonly IntPtr selUniformNamed_Handle = Selector.GetHandle("uniformNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUniforms = "uniforms";

	private static readonly IntPtr selUniformsHandle = Selector.GetHandle("uniforms");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKShader");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual SKAttribute[] Attributes
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("attributes", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SKAttribute>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributesHandle));
			}
			return NSArray.ArrayFromHandle<SKAttribute>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributesHandle));
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setAttributes:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributes_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributes_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Source
	{
		[Export("source")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceHandle));
		}
		[Export("setSource:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSource_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSource_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKUniform[] Uniforms
	{
		[Export("uniforms", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SKUniform>(Messaging.IntPtr_objc_msgSend(base.Handle, selUniformsHandle));
			}
			return NSArray.ArrayFromHandle<SKUniform>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUniformsHandle));
		}
		[Export("setUniforms:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetUniforms_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetUniforms_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKShader()
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
	public SKShader(NSCoder coder)
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
	protected SKShader(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKShader(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKShader(string shaderSourceCode)
		: base(NSObjectFlag.Empty)
	{
		if (shaderSourceCode == null)
		{
			throw new ArgumentNullException("shaderSourceCode");
		}
		IntPtr arg = NSString.CreateNative(shaderSourceCode);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSource_Handle, arg), "initWithSource:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSource_Handle, arg), "initWithSource:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithSource:uniforms:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKShader(string sharedSourceCode, SKUniform[] uniforms)
		: base(NSObjectFlag.Empty)
	{
		if (sharedSourceCode == null)
		{
			throw new ArgumentNullException("sharedSourceCode");
		}
		if (uniforms == null)
		{
			throw new ArgumentNullException("uniforms");
		}
		IntPtr arg = NSString.CreateNative(sharedSourceCode);
		NSArray nSArray = NSArray.FromNSObjects(uniforms);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithSource_Uniforms_Handle, arg, nSArray.Handle), "initWithSource:uniforms:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithSource_Uniforms_Handle, arg, nSArray.Handle), "initWithSource:uniforms:");
		}
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
	}

	[Export("addUniform:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddUniform(SKUniform uniform)
	{
		if (uniform == null)
		{
			throw new ArgumentNullException("uniform");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddUniform_Handle, uniform.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddUniform_Handle, uniform.Handle);
		}
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

	[Export("shader")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKShader Create()
	{
		return Runtime.GetNSObject<SKShader>(Messaging.IntPtr_objc_msgSend(class_ptr, selShaderHandle));
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

	[Export("shaderWithFileNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKShader FromFile(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		SKShader nSObject = Runtime.GetNSObject<SKShader>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selShaderWithFileNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("shaderWithSource:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKShader FromShaderSourceCode(string source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		IntPtr arg = NSString.CreateNative(source);
		SKShader nSObject = Runtime.GetNSObject<SKShader>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selShaderWithSource_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("shaderWithSource:uniforms:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKShader FromShaderSourceCode(string source, SKUniform[] uniforms)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (uniforms == null)
		{
			throw new ArgumentNullException("uniforms");
		}
		IntPtr arg = NSString.CreateNative(source);
		NSArray nSArray = NSArray.FromNSObjects(uniforms);
		SKShader nSObject = Runtime.GetNSObject<SKShader>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selShaderWithSource_Uniforms_Handle, arg, nSArray.Handle));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		return nSObject;
	}

	[Export("uniformNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKUniform GetUniform(string uniformName)
	{
		if (uniformName == null)
		{
			throw new ArgumentNullException("uniformName");
		}
		IntPtr arg = NSString.CreateNative(uniformName);
		SKUniform result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<SKUniform>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selUniformNamed_Handle, arg)) : Runtime.GetNSObject<SKUniform>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selUniformNamed_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("removeUniformNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveUniform(string uniforName)
	{
		if (uniforName == null)
		{
			throw new ArgumentNullException("uniforName");
		}
		IntPtr arg = NSString.CreateNative(uniforName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveUniformNamed_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveUniformNamed_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}
}

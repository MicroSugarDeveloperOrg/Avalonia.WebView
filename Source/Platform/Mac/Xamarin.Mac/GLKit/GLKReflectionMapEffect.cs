using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace GLKit;

[Register("GLKReflectionMapEffect", true)]
[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
public class GLKReflectionMapEffect : GLKBaseEffect, IGLKNamedEffect, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatrix = "matrix";

	private static readonly IntPtr selMatrixHandle = Selector.GetHandle("matrix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareToDraw = "prepareToDraw";

	private static readonly IntPtr selPrepareToDrawHandle = Selector.GetHandle("prepareToDraw");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMatrix_ = "setMatrix:";

	private static readonly IntPtr selSetMatrix_Handle = Selector.GetHandle("setMatrix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextureCubeMap = "textureCubeMap";

	private static readonly IntPtr selTextureCubeMapHandle = Selector.GetHandle("textureCubeMap");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GLKReflectionMapEffect");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Matrix3 Matrix
	{
		[Export("matrix", ArgumentSemantic.Assign)]
		get
		{
			Matrix3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.Matrix3_objc_msgSend_stret(out retval, base.Handle, selMatrixHandle);
			}
			else
			{
				Messaging.Matrix3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selMatrixHandle);
			}
			return retval;
		}
		[Export("setMatrix:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Matrix3(base.Handle, selSetMatrix_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Matrix3(base.SuperHandle, selSetMatrix_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GLKEffectPropertyTexture TextureCubeMap
	{
		[Export("textureCubeMap")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GLKEffectPropertyTexture>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextureCubeMapHandle));
			}
			return Runtime.GetNSObject<GLKEffectPropertyTexture>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextureCubeMapHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GLKReflectionMapEffect()
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
	protected GLKReflectionMapEffect(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GLKReflectionMapEffect(IntPtr handle)
		: base(handle)
	{
	}

	[Export("prepareToDraw")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
	[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void PrepareToDraw()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPrepareToDrawHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPrepareToDrawHandle);
		}
	}
}

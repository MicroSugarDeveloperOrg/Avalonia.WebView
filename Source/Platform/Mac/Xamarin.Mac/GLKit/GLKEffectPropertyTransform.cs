using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace GLKit;

[Register("GLKEffectPropertyTransform", true)]
[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'Metal' instead.")]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'Metal' instead.")]
public class GLKEffectPropertyTransform : GLKEffectProperty
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModelviewMatrix = "modelviewMatrix";

	private static readonly IntPtr selModelviewMatrixHandle = Selector.GetHandle("modelviewMatrix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNormalMatrix = "normalMatrix";

	private static readonly IntPtr selNormalMatrixHandle = Selector.GetHandle("normalMatrix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProjectionMatrix = "projectionMatrix";

	private static readonly IntPtr selProjectionMatrixHandle = Selector.GetHandle("projectionMatrix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetModelviewMatrix_ = "setModelviewMatrix:";

	private static readonly IntPtr selSetModelviewMatrix_Handle = Selector.GetHandle("setModelviewMatrix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProjectionMatrix_ = "setProjectionMatrix:";

	private static readonly IntPtr selSetProjectionMatrix_Handle = Selector.GetHandle("setProjectionMatrix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GLKEffectPropertyTransform");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Matrix4 ModelViewMatrix
	{
		[Export("modelviewMatrix", ArgumentSemantic.Assign)]
		get
		{
			Matrix4 result = default(Matrix4);
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Matrix4)) + 16);
			IntPtr intPtr2 = new IntPtr((nint)(intPtr + 15) >> 4 << 4);
			bool flag = false;
			if (base.IsDirectBinding)
			{
				Messaging.IntPtr_objc_msgSend_stret(intPtr2, base.Handle, selModelviewMatrixHandle);
				flag = true;
			}
			else
			{
				Messaging.IntPtr_objc_msgSendSuper_stret(intPtr2, base.SuperHandle, selModelviewMatrixHandle);
				flag = true;
			}
			if (flag)
			{
				result = *(Matrix4*)(void*)intPtr2;
			}
			Marshal.FreeHGlobal(intPtr);
			return result;
		}
		[Export("setModelviewMatrix:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Matrix4(base.Handle, selSetModelviewMatrix_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Matrix4(base.SuperHandle, selSetModelviewMatrix_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Matrix3 NormalMatrix
	{
		[Export("normalMatrix")]
		get
		{
			Matrix3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.Matrix3_objc_msgSend_stret(out retval, base.Handle, selNormalMatrixHandle);
			}
			else
			{
				Messaging.Matrix3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selNormalMatrixHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual Matrix4 ProjectionMatrix
	{
		[Export("projectionMatrix", ArgumentSemantic.Assign)]
		get
		{
			Matrix4 result = default(Matrix4);
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Matrix4)) + 16);
			IntPtr intPtr2 = new IntPtr((nint)(intPtr + 15) >> 4 << 4);
			bool flag = false;
			if (base.IsDirectBinding)
			{
				Messaging.IntPtr_objc_msgSend_stret(intPtr2, base.Handle, selProjectionMatrixHandle);
				flag = true;
			}
			else
			{
				Messaging.IntPtr_objc_msgSendSuper_stret(intPtr2, base.SuperHandle, selProjectionMatrixHandle);
				flag = true;
			}
			if (flag)
			{
				result = *(Matrix4*)(void*)intPtr2;
			}
			Marshal.FreeHGlobal(intPtr);
			return result;
		}
		[Export("setProjectionMatrix:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Matrix4(base.Handle, selSetProjectionMatrix_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Matrix4(base.SuperHandle, selSetProjectionMatrix_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GLKEffectPropertyTransform()
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
	protected GLKEffectPropertyTransform(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GLKEffectPropertyTransform(IntPtr handle)
		: base(handle)
	{
	}
}

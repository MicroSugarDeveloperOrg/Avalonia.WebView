using Foundation;
using ObjCRuntime;
using OpenTK;

namespace ModelIO;

public static class MDLTransformComponent_Extensions
{
	public static NMatrix4 GetMatrix4x4(this IMDLTransformComponent self)
	{
		return NMatrix4.Transpose((NMatrix4)self.Matrix);
	}

	public static void SetMatrix4x4(this IMDLTransformComponent self, NMatrix4 value)
	{
		self.Matrix = (Matrix4)NMatrix4.Transpose(value);
	}

	public static NMatrix4 GetLocalTransform4x4(this IMDLTransformComponent This, double time)
	{
		return NMatrix4.Transpose((NMatrix4)This.GetLocalTransform(time));
	}

	public static void SetLocalTransform4x4(this IMDLTransformComponent This, NMatrix4 transform, double time)
	{
		This.SetLocalTransform((Matrix4)NMatrix4.Transpose(transform), time);
	}

	public static void SetLocalTransform4x4(this IMDLTransformComponent This, NMatrix4 transform)
	{
		This.SetLocalTransform((Matrix4)NMatrix4.Transpose(transform));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetLocalTransform(this IMDLTransformComponent This, Matrix4 transform, double time)
	{
		Messaging.xamarin_simd__void_objc_msgSend_Matrix4_Double(This.Handle, Selector.GetHandle("setLocalTransform:forTime:"), transform, time);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetLocalTransform(this IMDLTransformComponent This, Matrix4 transform)
	{
		Messaging.xamarin_simd__void_objc_msgSend_Matrix4(This.Handle, Selector.GetHandle("setLocalTransform:"), transform);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Matrix4 GetLocalTransform(this IMDLTransformComponent This, double atTime)
	{
		Messaging.xamarin_simd__Matrix4_objc_msgSend_stret_Double(out var retval, This.Handle, Selector.GetHandle("localTransformAtTime:"), atTime);
		return retval;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetResetsTransform(this IMDLTransformComponent This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("resetsTransform"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetResetsTransform(this IMDLTransformComponent This, bool value)
	{
		Messaging.void_objc_msgSend_bool(This.Handle, Selector.GetHandle("setResetsTransform:"), value);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSNumber[] GetKeyTimes(this IMDLTransformComponent This)
	{
		return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("keyTimes")));
	}
}

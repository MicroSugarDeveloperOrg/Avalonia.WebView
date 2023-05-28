using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

public static class CAFillMode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Backwards;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Both;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Forwards;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _Removed;

	[Field("kCAFillModeBackwards", "CoreAnimation")]
	public static NSString Backwards
	{
		get
		{
			if (_Backwards == null)
			{
				_Backwards = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAFillModeBackwards");
			}
			return _Backwards;
		}
	}

	[Field("kCAFillModeBoth", "CoreAnimation")]
	public static NSString Both
	{
		get
		{
			if (_Both == null)
			{
				_Both = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAFillModeBoth");
			}
			return _Both;
		}
	}

	[Field("kCAFillModeForwards", "CoreAnimation")]
	public static NSString Forwards
	{
		get
		{
			if (_Forwards == null)
			{
				_Forwards = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAFillModeForwards");
			}
			return _Forwards;
		}
	}

	[Field("kCAFillModeRemoved", "CoreAnimation")]
	public static NSString Removed
	{
		get
		{
			if (_Removed == null)
			{
				_Removed = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAFillModeRemoved");
			}
			return _Removed;
		}
	}
}

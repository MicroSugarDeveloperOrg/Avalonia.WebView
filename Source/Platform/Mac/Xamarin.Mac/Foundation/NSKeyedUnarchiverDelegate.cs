using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSKeyedUnarchiverDelegate", false)]
[Model]
public class NSKeyedUnarchiverDelegate : NSObject, INSKeyedUnarchiverDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSKeyedUnarchiverDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSKeyedUnarchiverDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSKeyedUnarchiverDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("unarchiver:cannotDecodeObjectOfClassName:originalClasses:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Class CannotDecodeClass(NSKeyedUnarchiver unarchiver, string klass, string[] classes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("unarchiver:didDecodeObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject DecodedObject(NSKeyedUnarchiver unarchiver, NSObject obj)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("unarchiverDidFinish:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Finished(NSKeyedUnarchiver unarchiver)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("unarchiverWillFinish:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Finishing(NSKeyedUnarchiver unarchiver)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("unarchiver:willReplaceObject:withObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplacingObject(NSKeyedUnarchiver unarchiver, NSObject oldObject, NSObject newObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSKeyedArchiverDelegate", false)]
[Model]
public class NSKeyedArchiverDelegate : NSObject, INSKeyedArchiverDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSKeyedArchiverDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSKeyedArchiverDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSKeyedArchiverDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("archiver:didEncodeObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodedObject(NSKeyedArchiver archiver, NSObject obj)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("archiverDidFinish:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Finished(NSKeyedArchiver archiver)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("archiverWillFinish:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Finishing(NSKeyedArchiver archiver)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("archiver:willReplaceObject:withObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplacingObject(NSKeyedArchiver archiver, NSObject oldObject, NSObject newObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("archiver:willEncodeObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject WillEncode(NSKeyedArchiver archiver, NSObject obj)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}

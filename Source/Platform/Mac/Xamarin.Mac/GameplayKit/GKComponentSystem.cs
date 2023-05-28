using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace GameplayKit;

[Register("GKComponentSystem", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class GKComponentSystem<TComponent> : NSObject where TComponent : GKComponent
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddComponent_ = "addComponent:";

	private static readonly IntPtr selAddComponent_Handle = Selector.GetHandle("addComponent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddComponentWithEntity_ = "addComponentWithEntity:";

	private static readonly IntPtr selAddComponentWithEntity_Handle = Selector.GetHandle("addComponentWithEntity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClassForGenericArgumentAtIndex_ = "classForGenericArgumentAtIndex:";

	private static readonly IntPtr selClassForGenericArgumentAtIndex_Handle = Selector.GetHandle("classForGenericArgumentAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponentClass = "componentClass";

	private static readonly IntPtr selComponentClassHandle = Selector.GetHandle("componentClass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponents = "components";

	private static readonly IntPtr selComponentsHandle = Selector.GetHandle("components");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithComponentClass_ = "initWithComponentClass:";

	private static readonly IntPtr selInitWithComponentClass_Handle = Selector.GetHandle("initWithComponentClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectAtIndexedSubscript_ = "objectAtIndexedSubscript:";

	private static readonly IntPtr selObjectAtIndexedSubscript_Handle = Selector.GetHandle("objectAtIndexedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveComponent_ = "removeComponent:";

	private static readonly IntPtr selRemoveComponent_Handle = Selector.GetHandle("removeComponent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveComponentWithEntity_ = "removeComponentWithEntity:";

	private static readonly IntPtr selRemoveComponentWithEntity_Handle = Selector.GetHandle("removeComponentWithEntity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateWithDeltaTime_ = "updateWithDeltaTime:";

	private static readonly IntPtr selUpdateWithDeltaTime_Handle = Selector.GetHandle("updateWithDeltaTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKComponentSystem");

	public Type ComponentType => ObjCRuntime.Class.Lookup(ComponentClass);

	public TComponent this[nuint index] => ObjectAtIndexedSubscript(index);

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Class ComponentClass
	{
		[Export("componentClass")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selComponentClassHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selComponentClassHandle));
			return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual TComponent[] Components
	{
		[Export("components", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<TComponent>(Messaging.IntPtr_objc_msgSend(base.Handle, selComponentsHandle));
			}
			return NSArray.ArrayFromHandle<TComponent>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selComponentsHandle));
		}
	}

	public GKComponentSystem()
		: this(GKState.GetClass(typeof(TComponent), "componentType"))
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKComponentSystem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKComponentSystem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithComponentClass:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public GKComponentSystem(Class cls)
		: base(NSObjectFlag.Empty)
	{
		if (cls == null)
		{
			throw new ArgumentNullException("cls");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithComponentClass_Handle, cls.Handle), "initWithComponentClass:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithComponentClass_Handle, cls.Handle), "initWithComponentClass:");
		}
	}

	[Export("addComponent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddComponent(TComponent component)
	{
		if (component == null)
		{
			throw new ArgumentNullException("component");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddComponent_Handle, component.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddComponent_Handle, component.Handle);
		}
	}

	[Export("addComponentWithEntity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddComponent(GKEntity entity)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddComponentWithEntity_Handle, entity.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddComponentWithEntity_Handle, entity.Handle);
		}
	}

	[Export("classForGenericArgumentAtIndex:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Class GetClassForGenericArgument(nuint index)
	{
		IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selClassForGenericArgumentAtIndex_Handle, index) : Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selClassForGenericArgumentAtIndex_Handle, index));
		return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Type GetTypeForGenericArgument(nuint index)
	{
		return ObjCRuntime.Class.Lookup(GetClassForGenericArgument(index));
	}

	[Export("objectAtIndexedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual TComponent ObjectAtIndexedSubscript(nuint idx)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<TComponent>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selObjectAtIndexedSubscript_Handle, idx), owns: false);
		}
		return Runtime.GetINativeObject<TComponent>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selObjectAtIndexedSubscript_Handle, idx), owns: false);
	}

	[Export("removeComponentWithEntity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveComponent(GKEntity entity)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveComponentWithEntity_Handle, entity.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveComponentWithEntity_Handle, entity.Handle);
		}
	}

	[Export("removeComponent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveComponent(TComponent component)
	{
		if (component == null)
		{
			throw new ArgumentNullException("component");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveComponent_Handle, component.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveComponent_Handle, component.Handle);
		}
	}

	[Export("updateWithDeltaTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Update(double deltaTimeInSeconds)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double(base.Handle, selUpdateWithDeltaTime_Handle, deltaTimeInSeconds);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selUpdateWithDeltaTime_Handle, deltaTimeInSeconds);
		}
	}
}

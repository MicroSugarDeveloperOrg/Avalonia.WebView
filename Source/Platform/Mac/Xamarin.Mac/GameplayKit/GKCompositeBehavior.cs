using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace GameplayKit;

[Register("GKCompositeBehavior", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class GKCompositeBehavior : GKBehavior
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBehaviorCount = "behaviorCount";

	private static readonly IntPtr selBehaviorCountHandle = Selector.GetHandle("behaviorCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBehaviorWithBehaviors_ = "behaviorWithBehaviors:";

	private static readonly IntPtr selBehaviorWithBehaviors_Handle = Selector.GetHandle("behaviorWithBehaviors:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBehaviorWithBehaviors_AndWeights_ = "behaviorWithBehaviors:andWeights:";

	private static readonly IntPtr selBehaviorWithBehaviors_AndWeights_Handle = Selector.GetHandle("behaviorWithBehaviors:andWeights:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectAtIndexedSubscript_ = "objectAtIndexedSubscript:";

	private static readonly IntPtr selObjectAtIndexedSubscript_Handle = Selector.GetHandle("objectAtIndexedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectForKeyedSubscript_ = "objectForKeyedSubscript:";

	private static readonly IntPtr selObjectForKeyedSubscript_Handle = Selector.GetHandle("objectForKeyedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllBehaviors = "removeAllBehaviors";

	private static readonly IntPtr selRemoveAllBehaviorsHandle = Selector.GetHandle("removeAllBehaviors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveBehavior_ = "removeBehavior:";

	private static readonly IntPtr selRemoveBehavior_Handle = Selector.GetHandle("removeBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetObject_ForKeyedSubscript_ = "setObject:forKeyedSubscript:";

	private static readonly IntPtr selSetObject_ForKeyedSubscript_Handle = Selector.GetHandle("setObject:forKeyedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWeight_ForBehavior_ = "setWeight:forBehavior:";

	private static readonly IntPtr selSetWeight_ForBehavior_Handle = Selector.GetHandle("setWeight:forBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWeightForBehavior_ = "weightForBehavior:";

	private static readonly IntPtr selWeightForBehavior_Handle = Selector.GetHandle("weightForBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKCompositeBehavior");

	public new GKBehavior this[nuint index] => ObjectAtIndexedSubscript(index);

	public NSNumber this[GKBehavior behavior]
	{
		get
		{
			return ObjectForKeyedSubscript(behavior);
		}
		set
		{
			SetObject(value, behavior);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint BehaviorCount
	{
		[Export("behaviorCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selBehaviorCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selBehaviorCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKCompositeBehavior()
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
	protected GKCompositeBehavior(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKCompositeBehavior(IntPtr handle)
		: base(handle)
	{
	}

	[Export("behaviorWithBehaviors:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKCompositeBehavior FromBehaviors(GKBehavior[] behaviors)
	{
		if (behaviors == null)
		{
			throw new ArgumentNullException("behaviors");
		}
		NSArray nSArray = NSArray.FromNSObjects(behaviors);
		GKCompositeBehavior nSObject = Runtime.GetNSObject<GKCompositeBehavior>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selBehaviorWithBehaviors_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("behaviorWithBehaviors:andWeights:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKCompositeBehavior FromBehaviors(GKBehavior[] behaviors, NSNumber[] weights)
	{
		if (behaviors == null)
		{
			throw new ArgumentNullException("behaviors");
		}
		if (weights == null)
		{
			throw new ArgumentNullException("weights");
		}
		NSArray nSArray = NSArray.FromNSObjects(behaviors);
		NSArray nSArray2 = NSArray.FromNSObjects(weights);
		GKCompositeBehavior nSObject = Runtime.GetNSObject<GKCompositeBehavior>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selBehaviorWithBehaviors_AndWeights_Handle, nSArray.Handle, nSArray2.Handle));
		nSArray.Dispose();
		nSArray2.Dispose();
		return nSObject;
	}

	[Export("weightForBehavior:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float GetWeight(GKBehavior behavior)
	{
		if (behavior == null)
		{
			throw new ArgumentNullException("behavior");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.float_objc_msgSend_IntPtr(base.Handle, selWeightForBehavior_Handle, behavior.Handle);
		}
		return Messaging.float_objc_msgSendSuper_IntPtr(base.SuperHandle, selWeightForBehavior_Handle, behavior.Handle);
	}

	[Export("objectAtIndexedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal new virtual GKBehavior ObjectAtIndexedSubscript(nuint index)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<GKBehavior>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selObjectAtIndexedSubscript_Handle, index));
		}
		return Runtime.GetNSObject<GKBehavior>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selObjectAtIndexedSubscript_Handle, index));
	}

	[Export("objectForKeyedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSNumber ObjectForKeyedSubscript(GKBehavior behavior)
	{
		if (behavior == null)
		{
			throw new ArgumentNullException("behavior");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectForKeyedSubscript_Handle, behavior.Handle));
		}
		return Runtime.GetNSObject<NSNumber>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectForKeyedSubscript_Handle, behavior.Handle));
	}

	[Export("removeAllBehaviors")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllBehaviors()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllBehaviorsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllBehaviorsHandle);
		}
	}

	[Export("removeBehavior:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveBehavior(GKBehavior behavior)
	{
		if (behavior == null)
		{
			throw new ArgumentNullException("behavior");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveBehavior_Handle, behavior.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveBehavior_Handle, behavior.Handle);
		}
	}

	[Export("setObject:forKeyedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void SetObject(NSNumber weight, GKBehavior behavior)
	{
		if (weight == null)
		{
			throw new ArgumentNullException("weight");
		}
		if (behavior == null)
		{
			throw new ArgumentNullException("behavior");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetObject_ForKeyedSubscript_Handle, weight.Handle, behavior.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetObject_ForKeyedSubscript_Handle, weight.Handle, behavior.Handle);
		}
	}

	[Export("setWeight:forBehavior:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetWeight(float weight, GKBehavior behavior)
	{
		if (behavior == null)
		{
			throw new ArgumentNullException("behavior");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_float_IntPtr(base.Handle, selSetWeight_ForBehavior_Handle, weight, behavior.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_float_IntPtr(base.SuperHandle, selSetWeight_ForBehavior_Handle, weight, behavior.Handle);
		}
	}
}

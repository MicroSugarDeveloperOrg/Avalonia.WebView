using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNPhysicsWorld", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNPhysicsWorld : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[Register]
	internal class _SCNPhysicsContactDelegate : NSObject, ISCNPhysicsContactDelegate, INativeObject, IDisposable
	{
		internal EventHandler<SCNPhysicsContactEventArgs>? didBeginContact;

		internal EventHandler<SCNPhysicsContactEventArgs>? didEndContact;

		internal EventHandler<SCNPhysicsContactEventArgs>? didUpdateContact;

		public _SCNPhysicsContactDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("physicsWorld:didBeginContact:")]
		public void DidBeginContact(SCNPhysicsWorld world, SCNPhysicsContact contact)
		{
			EventHandler<SCNPhysicsContactEventArgs> eventHandler = didBeginContact;
			if (eventHandler != null)
			{
				SCNPhysicsContactEventArgs e = new SCNPhysicsContactEventArgs(contact);
				eventHandler(world, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("physicsWorld:didEndContact:")]
		public void DidEndContact(SCNPhysicsWorld world, SCNPhysicsContact contact)
		{
			EventHandler<SCNPhysicsContactEventArgs> eventHandler = didEndContact;
			if (eventHandler != null)
			{
				SCNPhysicsContactEventArgs e = new SCNPhysicsContactEventArgs(contact);
				eventHandler(world, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("physicsWorld:didUpdateContact:")]
		public void DidUpdateContact(SCNPhysicsWorld world, SCNPhysicsContact contact)
		{
			EventHandler<SCNPhysicsContactEventArgs> eventHandler = didUpdateContact;
			if (eventHandler != null)
			{
				SCNPhysicsContactEventArgs e = new SCNPhysicsContactEventArgs(contact);
				eventHandler(world, e);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddBehavior_ = "addBehavior:";

	private static readonly IntPtr selAddBehavior_Handle = Selector.GetHandle("addBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllBehaviors = "allBehaviors";

	private static readonly IntPtr selAllBehaviorsHandle = Selector.GetHandle("allBehaviors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContactDelegate = "contactDelegate";

	private static readonly IntPtr selContactDelegateHandle = Selector.GetHandle("contactDelegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContactTestBetweenBody_AndBody_Options_ = "contactTestBetweenBody:andBody:options:";

	private static readonly IntPtr selContactTestBetweenBody_AndBody_Options_Handle = Selector.GetHandle("contactTestBetweenBody:andBody:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContactTestWithBody_Options_ = "contactTestWithBody:options:";

	private static readonly IntPtr selContactTestWithBody_Options_Handle = Selector.GetHandle("contactTestWithBody:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvexSweepTestWithShape_FromTransform_ToTransform_Options_ = "convexSweepTestWithShape:fromTransform:toTransform:options:";

	private static readonly IntPtr selConvexSweepTestWithShape_FromTransform_ToTransform_Options_Handle = Selector.GetHandle("convexSweepTestWithShape:fromTransform:toTransform:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGravity = "gravity";

	private static readonly IntPtr selGravityHandle = Selector.GetHandle("gravity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRayTestWithSegmentFromPoint_ToPoint_Options_ = "rayTestWithSegmentFromPoint:toPoint:options:";

	private static readonly IntPtr selRayTestWithSegmentFromPoint_ToPoint_Options_Handle = Selector.GetHandle("rayTestWithSegmentFromPoint:toPoint:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllBehaviors = "removeAllBehaviors";

	private static readonly IntPtr selRemoveAllBehaviorsHandle = Selector.GetHandle("removeAllBehaviors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveBehavior_ = "removeBehavior:";

	private static readonly IntPtr selRemoveBehavior_Handle = Selector.GetHandle("removeBehavior:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContactDelegate_ = "setContactDelegate:";

	private static readonly IntPtr selSetContactDelegate_Handle = Selector.GetHandle("setContactDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGravity_ = "setGravity:";

	private static readonly IntPtr selSetGravity_Handle = Selector.GetHandle("setGravity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSpeed_ = "setSpeed:";

	private static readonly IntPtr selSetSpeed_Handle = Selector.GetHandle("setSpeed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeStep_ = "setTimeStep:";

	private static readonly IntPtr selSetTimeStep_Handle = Selector.GetHandle("setTimeStep:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpeed = "speed";

	private static readonly IntPtr selSpeedHandle = Selector.GetHandle("speed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeStep = "timeStep";

	private static readonly IntPtr selTimeStepHandle = Selector.GetHandle("timeStep");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateCollisionPairs = "updateCollisionPairs";

	private static readonly IntPtr selUpdateCollisionPairsHandle = Selector.GetHandle("updateCollisionPairs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNPhysicsWorld");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakContactDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNPhysicsBehavior[] AllBehaviors
	{
		[Export("allBehaviors")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SCNPhysicsBehavior>(Messaging.IntPtr_objc_msgSend(base.Handle, selAllBehaviorsHandle));
			}
			return NSArray.ArrayFromHandle<SCNPhysicsBehavior>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllBehaviorsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public ISCNPhysicsContactDelegate ContactDelegate
	{
		get
		{
			return WeakContactDelegate as ISCNPhysicsContactDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakContactDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNVector3 Gravity
	{
		[Export("gravity")]
		get
		{
			SCNVector3 retval;
			if (base.IsDirectBinding)
			{
				Messaging.SCNVector3_objc_msgSend_stret(out retval, base.Handle, selGravityHandle);
			}
			else
			{
				Messaging.SCNVector3_objc_msgSendSuper_stret(out retval, base.SuperHandle, selGravityHandle);
			}
			return retval;
		}
		[Export("setGravity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_SCNVector3(base.Handle, selSetGravity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_SCNVector3(base.SuperHandle, selSetGravity_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Speed
	{
		[Export("speed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selSpeedHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selSpeedHandle);
		}
		[Export("setSpeed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetSpeed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetSpeed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double TimeStep
	{
		[Export("timeStep")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTimeStepHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTimeStepHandle);
		}
		[Export("setTimeStep:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetTimeStep_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetTimeStep_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakContactDelegate
	{
		[Export("contactDelegate", ArgumentSemantic.Weak)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContactDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selContactDelegateHandle)));
			MarkDirty();
			__mt_WeakContactDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setContactDelegate:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakContactDelegate_var, value, GetInternalEventContactDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContactDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContactDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakContactDelegate_var = value;
		}
	}

	internal virtual Type GetInternalEventContactDelegateType => typeof(_SCNPhysicsContactDelegate);

	public event EventHandler<SCNPhysicsContactEventArgs> DidBeginContact
	{
		add
		{
			_SCNPhysicsContactDelegate sCNPhysicsContactDelegate = EnsureSCNPhysicsContactDelegate();
			sCNPhysicsContactDelegate.didBeginContact = (EventHandler<SCNPhysicsContactEventArgs>)Delegate.Combine(sCNPhysicsContactDelegate.didBeginContact, value);
		}
		remove
		{
			_SCNPhysicsContactDelegate sCNPhysicsContactDelegate = EnsureSCNPhysicsContactDelegate();
			sCNPhysicsContactDelegate.didBeginContact = (EventHandler<SCNPhysicsContactEventArgs>)Delegate.Remove(sCNPhysicsContactDelegate.didBeginContact, value);
		}
	}

	public event EventHandler<SCNPhysicsContactEventArgs> DidEndContact
	{
		add
		{
			_SCNPhysicsContactDelegate sCNPhysicsContactDelegate = EnsureSCNPhysicsContactDelegate();
			sCNPhysicsContactDelegate.didEndContact = (EventHandler<SCNPhysicsContactEventArgs>)Delegate.Combine(sCNPhysicsContactDelegate.didEndContact, value);
		}
		remove
		{
			_SCNPhysicsContactDelegate sCNPhysicsContactDelegate = EnsureSCNPhysicsContactDelegate();
			sCNPhysicsContactDelegate.didEndContact = (EventHandler<SCNPhysicsContactEventArgs>)Delegate.Remove(sCNPhysicsContactDelegate.didEndContact, value);
		}
	}

	public event EventHandler<SCNPhysicsContactEventArgs> DidUpdateContact
	{
		add
		{
			_SCNPhysicsContactDelegate sCNPhysicsContactDelegate = EnsureSCNPhysicsContactDelegate();
			sCNPhysicsContactDelegate.didUpdateContact = (EventHandler<SCNPhysicsContactEventArgs>)Delegate.Combine(sCNPhysicsContactDelegate.didUpdateContact, value);
		}
		remove
		{
			_SCNPhysicsContactDelegate sCNPhysicsContactDelegate = EnsureSCNPhysicsContactDelegate();
			sCNPhysicsContactDelegate.didUpdateContact = (EventHandler<SCNPhysicsContactEventArgs>)Delegate.Remove(sCNPhysicsContactDelegate.didUpdateContact, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SCNPhysicsWorld(NSCoder coder)
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
	protected SCNPhysicsWorld(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNPhysicsWorld(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addBehavior:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddBehavior(SCNPhysicsBehavior behavior)
	{
		if (behavior == null)
		{
			throw new ArgumentNullException("behavior");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddBehavior_Handle, behavior.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddBehavior_Handle, behavior.Handle);
		}
	}

	[Export("contactTestBetweenBody:andBody:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNPhysicsContact[] ContactTest(SCNPhysicsBody bodyA, SCNPhysicsBody bodyB, NSDictionary? options)
	{
		if (bodyA == null)
		{
			throw new ArgumentNullException("bodyA");
		}
		if (bodyB == null)
		{
			throw new ArgumentNullException("bodyB");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<SCNPhysicsContact>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selContactTestBetweenBody_AndBody_Options_Handle, bodyA.Handle, bodyB.Handle, options?.Handle ?? IntPtr.Zero));
		}
		return NSArray.ArrayFromHandle<SCNPhysicsContact>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selContactTestBetweenBody_AndBody_Options_Handle, bodyA.Handle, bodyB.Handle, options?.Handle ?? IntPtr.Zero));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SCNPhysicsContact[] ContactTest(SCNPhysicsBody bodyA, SCNPhysicsBody bodyB, SCNPhysicsTest? options)
	{
		return ContactTest(bodyA, bodyB, options.GetDictionary());
	}

	[Export("contactTestWithBody:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNPhysicsContact[] ContactTest(SCNPhysicsBody body, NSDictionary? options)
	{
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<SCNPhysicsContact>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selContactTestWithBody_Options_Handle, body.Handle, options?.Handle ?? IntPtr.Zero));
		}
		return NSArray.ArrayFromHandle<SCNPhysicsContact>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selContactTestWithBody_Options_Handle, body.Handle, options?.Handle ?? IntPtr.Zero));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SCNPhysicsContact[] ContactTest(SCNPhysicsBody body, SCNPhysicsTest? options)
	{
		return ContactTest(body, options.GetDictionary());
	}

	[Export("convexSweepTestWithShape:fromTransform:toTransform:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNPhysicsContact[] ConvexSweepTest(SCNPhysicsShape shape, SCNMatrix4 from, SCNMatrix4 to, NSDictionary? options)
	{
		if (shape == null)
		{
			throw new ArgumentNullException("shape");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<SCNPhysicsContact>(Messaging.IntPtr_objc_msgSend_IntPtr_SCNMatrix4_SCNMatrix4_IntPtr(base.Handle, selConvexSweepTestWithShape_FromTransform_ToTransform_Options_Handle, shape.Handle, from, to, options?.Handle ?? IntPtr.Zero));
		}
		return NSArray.ArrayFromHandle<SCNPhysicsContact>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_SCNMatrix4_SCNMatrix4_IntPtr(base.SuperHandle, selConvexSweepTestWithShape_FromTransform_ToTransform_Options_Handle, shape.Handle, from, to, options?.Handle ?? IntPtr.Zero));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SCNPhysicsContact[] ConvexSweepTest(SCNPhysicsShape shape, SCNMatrix4 from, SCNMatrix4 to, SCNPhysicsTest? options)
	{
		return ConvexSweepTest(shape, from, to, options.GetDictionary());
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

	[Export("rayTestWithSegmentFromPoint:toPoint:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNHitTestResult[] RayTestWithSegmentFromPoint(SCNVector3 origin, SCNVector3 dest, NSDictionary? options)
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<SCNHitTestResult>(Messaging.IntPtr_objc_msgSend_SCNVector3_SCNVector3_IntPtr(base.Handle, selRayTestWithSegmentFromPoint_ToPoint_Options_Handle, origin, dest, options?.Handle ?? IntPtr.Zero));
		}
		return NSArray.ArrayFromHandle<SCNHitTestResult>(Messaging.IntPtr_objc_msgSendSuper_SCNVector3_SCNVector3_IntPtr(base.SuperHandle, selRayTestWithSegmentFromPoint_ToPoint_Options_Handle, origin, dest, options?.Handle ?? IntPtr.Zero));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SCNHitTestResult[] RayTestWithSegmentFromPoint(SCNVector3 origin, SCNVector3 dest, SCNPhysicsTest? options)
	{
		return RayTestWithSegmentFromPoint(origin, dest, options.GetDictionary());
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
	public virtual void RemoveBehavior(SCNPhysicsBehavior behavior)
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

	[Export("updateCollisionPairs")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateCollisionPairs()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdateCollisionPairsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdateCollisionPairsHandle);
		}
	}

	internal virtual _SCNPhysicsContactDelegate CreateInternalEventContactDelegateType()
	{
		return new _SCNPhysicsContactDelegate();
	}

	internal _SCNPhysicsContactDelegate EnsureSCNPhysicsContactDelegate()
	{
		if (WeakContactDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakContactDelegate, GetInternalEventContactDelegateType);
		}
		_SCNPhysicsContactDelegate sCNPhysicsContactDelegate = ContactDelegate as _SCNPhysicsContactDelegate;
		if (sCNPhysicsContactDelegate == null)
		{
			sCNPhysicsContactDelegate = (_SCNPhysicsContactDelegate)(ContactDelegate = CreateInternalEventContactDelegateType());
		}
		return sCNPhysicsContactDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakContactDelegate_var = null;
		}
	}
}

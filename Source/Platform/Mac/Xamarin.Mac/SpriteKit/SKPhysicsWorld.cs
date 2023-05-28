using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace SpriteKit;

[Register("SKPhysicsWorld", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class SKPhysicsWorld : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[Register]
	internal class _SKPhysicsContactDelegate : NSObject, ISKPhysicsContactDelegate, INativeObject, IDisposable
	{
		internal EventHandler? didBeginContact;

		internal EventHandler? didEndContact;

		public _SKPhysicsContactDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("didBeginContact:")]
		public void DidBeginContact(SKPhysicsContact contact)
		{
			didBeginContact?.Invoke(contact, EventArgs.Empty);
		}

		[Preserve(Conditional = true)]
		[Export("didEndContact:")]
		public void DidEndContact(SKPhysicsContact contact)
		{
			didEndContact?.Invoke(contact, EventArgs.Empty);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddJoint_ = "addJoint:";

	private static readonly IntPtr selAddJoint_Handle = Selector.GetHandle("addJoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyAlongRayStart_End_ = "bodyAlongRayStart:end:";

	private static readonly IntPtr selBodyAlongRayStart_End_Handle = Selector.GetHandle("bodyAlongRayStart:end:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyAtPoint_ = "bodyAtPoint:";

	private static readonly IntPtr selBodyAtPoint_Handle = Selector.GetHandle("bodyAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBodyInRect_ = "bodyInRect:";

	private static readonly IntPtr selBodyInRect_Handle = Selector.GetHandle("bodyInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContactDelegate = "contactDelegate";

	private static readonly IntPtr selContactDelegateHandle = Selector.GetHandle("contactDelegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateBodiesAlongRayStart_End_UsingBlock_ = "enumerateBodiesAlongRayStart:end:usingBlock:";

	private static readonly IntPtr selEnumerateBodiesAlongRayStart_End_UsingBlock_Handle = Selector.GetHandle("enumerateBodiesAlongRayStart:end:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateBodiesAtPoint_UsingBlock_ = "enumerateBodiesAtPoint:usingBlock:";

	private static readonly IntPtr selEnumerateBodiesAtPoint_UsingBlock_Handle = Selector.GetHandle("enumerateBodiesAtPoint:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateBodiesInRect_UsingBlock_ = "enumerateBodiesInRect:usingBlock:";

	private static readonly IntPtr selEnumerateBodiesInRect_UsingBlock_Handle = Selector.GetHandle("enumerateBodiesInRect:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGravity = "gravity";

	private static readonly IntPtr selGravityHandle = Selector.GetHandle("gravity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllJoints = "removeAllJoints";

	private static readonly IntPtr selRemoveAllJointsHandle = Selector.GetHandle("removeAllJoints");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveJoint_ = "removeJoint:";

	private static readonly IntPtr selRemoveJoint_Handle = Selector.GetHandle("removeJoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSampleFieldsAt_ = "sampleFieldsAt:";

	private static readonly IntPtr selSampleFieldsAt_Handle = Selector.GetHandle("sampleFieldsAt:");

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
	private const string selSpeed = "speed";

	private static readonly IntPtr selSpeedHandle = Selector.GetHandle("speed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKPhysicsWorld");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakContactDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public ISKPhysicsContactDelegate ContactDelegate
	{
		get
		{
			return WeakContactDelegate as ISKPhysicsContactDelegate;
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
	public virtual CGVector Gravity
	{
		[Export("gravity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGVector_objc_msgSend(base.Handle, selGravityHandle);
			}
			return Messaging.CGVector_objc_msgSendSuper(base.SuperHandle, selGravityHandle);
		}
		[Export("setGravity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGVector(base.Handle, selSetGravity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGVector(base.SuperHandle, selSetGravity_Handle, value);
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
	public virtual NSObject? WeakContactDelegate
	{
		[Export("contactDelegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContactDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selContactDelegateHandle)));
			MarkDirty();
			__mt_WeakContactDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setContactDelegate:", ArgumentSemantic.Assign)]
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

	internal virtual Type GetInternalEventContactDelegateType => typeof(_SKPhysicsContactDelegate);

	public event EventHandler DidBeginContact
	{
		add
		{
			_SKPhysicsContactDelegate sKPhysicsContactDelegate = EnsureSKPhysicsContactDelegate();
			sKPhysicsContactDelegate.didBeginContact = (EventHandler)Delegate.Combine(sKPhysicsContactDelegate.didBeginContact, value);
		}
		remove
		{
			_SKPhysicsContactDelegate sKPhysicsContactDelegate = EnsureSKPhysicsContactDelegate();
			sKPhysicsContactDelegate.didBeginContact = (EventHandler)Delegate.Remove(sKPhysicsContactDelegate.didBeginContact, value);
		}
	}

	public event EventHandler DidEndContact
	{
		add
		{
			_SKPhysicsContactDelegate sKPhysicsContactDelegate = EnsureSKPhysicsContactDelegate();
			sKPhysicsContactDelegate.didEndContact = (EventHandler)Delegate.Combine(sKPhysicsContactDelegate.didEndContact, value);
		}
		remove
		{
			_SKPhysicsContactDelegate sKPhysicsContactDelegate = EnsureSKPhysicsContactDelegate();
			sKPhysicsContactDelegate.didEndContact = (EventHandler)Delegate.Remove(sKPhysicsContactDelegate.didEndContact, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SKPhysicsWorld(NSCoder coder)
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
	protected SKPhysicsWorld(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKPhysicsWorld(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addJoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddJoint(SKPhysicsJoint joint)
	{
		if (joint == null)
		{
			throw new ArgumentNullException("joint");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddJoint_Handle, joint.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddJoint_Handle, joint.Handle);
		}
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

	[Export("enumerateBodiesAtPoint:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateBodies(CGPoint point, [BlockProxy(typeof(Trampolines.NIDSKPhysicsWorldBodiesEnumeratorHandler))] SKPhysicsWorldBodiesEnumeratorHandler enumeratorHandler)
	{
		if (enumeratorHandler == null)
		{
			throw new ArgumentNullException("enumeratorHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSKPhysicsWorldBodiesEnumeratorHandler.Handler, enumeratorHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_IntPtr(base.Handle, selEnumerateBodiesAtPoint_UsingBlock_Handle, point, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selEnumerateBodiesAtPoint_UsingBlock_Handle, point, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("enumerateBodiesInRect:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateBodies(CGRect rect, [BlockProxy(typeof(Trampolines.NIDSKPhysicsWorldBodiesEnumeratorHandler))] SKPhysicsWorldBodiesEnumeratorHandler enumeratorHandler)
	{
		if (enumeratorHandler == null)
		{
			throw new ArgumentNullException("enumeratorHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSKPhysicsWorldBodiesEnumeratorHandler.Handler, enumeratorHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selEnumerateBodiesInRect_UsingBlock_Handle, rect, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selEnumerateBodiesInRect_UsingBlock_Handle, rect, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("enumerateBodiesAlongRayStart:end:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateBodies(CGPoint start, CGPoint end, [BlockProxy(typeof(Trampolines.NIDSKPhysicsWorldBodiesAlongRayStartEnumeratorHandler))] SKPhysicsWorldBodiesAlongRayStartEnumeratorHandler enumeratorHandler)
	{
		if (enumeratorHandler == null)
		{
			throw new ArgumentNullException("enumeratorHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSKPhysicsWorldBodiesAlongRayStartEnumeratorHandler.Handler, enumeratorHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_CGPoint_IntPtr(base.Handle, selEnumerateBodiesAlongRayStart_End_UsingBlock_Handle, start, end, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_CGPoint_IntPtr(base.SuperHandle, selEnumerateBodiesAlongRayStart_End_UsingBlock_Handle, start, end, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("bodyAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKPhysicsBody GetBody(CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<SKPhysicsBody>(Messaging.IntPtr_objc_msgSend_CGPoint(base.Handle, selBodyAtPoint_Handle, point));
		}
		return Runtime.GetNSObject<SKPhysicsBody>(Messaging.IntPtr_objc_msgSendSuper_CGPoint(base.SuperHandle, selBodyAtPoint_Handle, point));
	}

	[Export("bodyInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKPhysicsBody GetBody(CGRect rect)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<SKPhysicsBody>(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selBodyInRect_Handle, rect));
		}
		return Runtime.GetNSObject<SKPhysicsBody>(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selBodyInRect_Handle, rect));
	}

	[Export("bodyAlongRayStart:end:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKPhysicsBody GetBody(CGPoint rayStart, CGPoint rayEnd)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<SKPhysicsBody>(Messaging.IntPtr_objc_msgSend_CGPoint_CGPoint(base.Handle, selBodyAlongRayStart_End_Handle, rayStart, rayEnd));
		}
		return Runtime.GetNSObject<SKPhysicsBody>(Messaging.IntPtr_objc_msgSendSuper_CGPoint_CGPoint(base.SuperHandle, selBodyAlongRayStart_End_Handle, rayStart, rayEnd));
	}

	[Export("removeAllJoints")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllJoints()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllJointsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllJointsHandle);
		}
	}

	[Export("removeJoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveJoint(SKPhysicsJoint joint)
	{
		if (joint == null)
		{
			throw new ArgumentNullException("joint");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveJoint_Handle, joint.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveJoint_Handle, joint.Handle);
		}
	}

	[Export("sampleFieldsAt:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector3 SampleFields(Vector3 position)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__Vector3_objc_msgSend_Vector3(base.Handle, selSampleFieldsAt_Handle, position);
		}
		return Messaging.xamarin_simd__Vector3_objc_msgSendSuper_Vector3(base.SuperHandle, selSampleFieldsAt_Handle, position);
	}

	internal virtual _SKPhysicsContactDelegate CreateInternalEventContactDelegateType()
	{
		return new _SKPhysicsContactDelegate();
	}

	internal _SKPhysicsContactDelegate EnsureSKPhysicsContactDelegate()
	{
		if (WeakContactDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakContactDelegate, GetInternalEventContactDelegateType);
		}
		_SKPhysicsContactDelegate sKPhysicsContactDelegate = ContactDelegate as _SKPhysicsContactDelegate;
		if (sKPhysicsContactDelegate == null)
		{
			sKPhysicsContactDelegate = (_SKPhysicsContactDelegate)(ContactDelegate = CreateInternalEventContactDelegateType());
		}
		return sKPhysicsContactDelegate;
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

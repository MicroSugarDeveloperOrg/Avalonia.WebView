using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNPhysicsShape", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNPhysicsShape : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOptions = "options";

	private static readonly IntPtr selOptionsHandle = Selector.GetHandle("options");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShapeWithGeometry_Options_ = "shapeWithGeometry:options:";

	private static readonly IntPtr selShapeWithGeometry_Options_Handle = Selector.GetHandle("shapeWithGeometry:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShapeWithNode_Options_ = "shapeWithNode:options:";

	private static readonly IntPtr selShapeWithNode_Options_Handle = Selector.GetHandle("shapeWithNode:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShapeWithShapes_Transforms_ = "shapeWithShapes:transforms:";

	private static readonly IntPtr selShapeWithShapes_Transforms_Handle = Selector.GetHandle("shapeWithShapes:transforms:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceObject = "sourceObject";

	private static readonly IntPtr selSourceObjectHandle = Selector.GetHandle("sourceObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransforms = "transforms";

	private static readonly IntPtr selTransformsHandle = Selector.GetHandle("transforms");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNPhysicsShape");

	public SCNPhysicsShapeOptions Options
	{
		get
		{
			NSDictionary options = _Options;
			if (options == null)
			{
				return null;
			}
			return new SCNPhysicsShapeOptions(options);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSObject SourceObject
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("sourceObject")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceObjectHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceObjectHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSValue[]? Transforms
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("transforms")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSValue>(Messaging.IntPtr_objc_msgSend(base.Handle, selTransformsHandle));
			}
			return NSArray.ArrayFromHandle<NSValue>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTransformsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	internal virtual NSDictionary? _Options
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("options")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selOptionsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOptionsHandle));
		}
	}

	public static SCNPhysicsShape Create(SCNPhysicsShape[] shapes, SCNMatrix4[] transforms)
	{
		if (shapes == null)
		{
			throw new ArgumentNullException("shapes");
		}
		if (transforms == null)
		{
			throw new ArgumentNullException("transforms");
		}
		NSValue[] array = new NSValue[transforms.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = NSValue.FromSCNMatrix4(transforms[i]);
		}
		return Create(shapes, array);
	}

	[Obsolete("Use the 'Create' method that takes a 'SCNMatrix4 []'.")]
	public static SCNPhysicsShape Create(SCNPhysicsShape[] shapes, SCNVector3[] transforms)
	{
		if (shapes == null)
		{
			throw new ArgumentNullException("shapes");
		}
		if (transforms == null)
		{
			throw new ArgumentNullException("transforms");
		}
		NSValue[] array = new NSValue[transforms.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = NSValue.FromVector(transforms[i]);
		}
		return Create(shapes, array);
	}

	public static SCNPhysicsShape Create(SCNGeometry geometry, SCNPhysicsShapeType? shapeType = null, bool? keepAsCompound = null, SCNVector3? scale = null)
	{
		return Create(geometry, new SCNPhysicsShapeOptions
		{
			ShapeType = shapeType,
			KeepAsCompound = keepAsCompound,
			Scale = scale
		}.ToDictionary());
	}

	public static SCNPhysicsShape Create(SCNGeometry geometry, SCNPhysicsShapeOptions options)
	{
		return Create(geometry, options.ToDictionary());
	}

	public static SCNPhysicsShape Create(SCNNode node, SCNPhysicsShapeType? shapeType = null, bool? keepAsCompound = null, SCNVector3? scale = null)
	{
		return Create(node, new SCNPhysicsShapeOptions
		{
			ShapeType = shapeType,
			KeepAsCompound = keepAsCompound,
			Scale = scale
		}.ToDictionary());
	}

	public static SCNPhysicsShape Create(SCNNode node, SCNPhysicsShapeOptions options)
	{
		return Create(node, options.ToDictionary());
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SCNPhysicsShape(NSCoder coder)
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
	protected SCNPhysicsShape(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNPhysicsShape(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("shapeWithShapes:transforms:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static SCNPhysicsShape Create(SCNPhysicsShape[] shapes, NSValue[] transforms)
	{
		if (shapes == null)
		{
			throw new ArgumentNullException("shapes");
		}
		if (transforms == null)
		{
			throw new ArgumentNullException("transforms");
		}
		NSArray nSArray = NSArray.FromNSObjects(shapes);
		NSArray nSArray2 = NSArray.FromNSObjects(transforms);
		SCNPhysicsShape nSObject = Runtime.GetNSObject<SCNPhysicsShape>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selShapeWithShapes_Transforms_Handle, nSArray.Handle, nSArray2.Handle));
		nSArray.Dispose();
		nSArray2.Dispose();
		return nSObject;
	}

	[Export("shapeWithGeometry:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNPhysicsShape Create(SCNGeometry geometry, NSDictionary? options)
	{
		if (geometry == null)
		{
			throw new ArgumentNullException("geometry");
		}
		return Runtime.GetNSObject<SCNPhysicsShape>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selShapeWithGeometry_Options_Handle, geometry.Handle, options?.Handle ?? IntPtr.Zero));
	}

	[Export("shapeWithNode:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNPhysicsShape Create(SCNNode node, NSDictionary? options)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		return Runtime.GetNSObject<SCNPhysicsShape>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selShapeWithNode_Options_Handle, node.Handle, options?.Handle ?? IntPtr.Zero));
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
}

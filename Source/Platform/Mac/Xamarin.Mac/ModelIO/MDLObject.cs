using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using SceneKit;

namespace ModelIO;

[Register("MDLObject", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLObject : NSObject, IMDLNamed, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddChild_ = "addChild:";

	private static readonly IntPtr selAddChild_Handle = Selector.GetHandle("addChild:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundingBoxAtTime_ = "boundingBoxAtTime:";

	private static readonly IntPtr selBoundingBoxAtTime_Handle = Selector.GetHandle("boundingBoxAtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChildren = "children";

	private static readonly IntPtr selChildrenHandle = Selector.GetHandle("children");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponentConformingToProtocol_ = "componentConformingToProtocol:";

	private static readonly IntPtr selComponentConformingToProtocol_Handle = Selector.GetHandle("componentConformingToProtocol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponents = "components";

	private static readonly IntPtr selComponentsHandle = Selector.GetHandle("components");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateChildObjectsOfClass_Root_UsingBlock_StopPointer_ = "enumerateChildObjectsOfClass:root:usingBlock:stopPointer:";

	private static readonly IntPtr selEnumerateChildObjectsOfClass_Root_UsingBlock_StopPointer_Handle = Selector.GetHandle("enumerateChildObjectsOfClass:root:usingBlock:stopPointer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHidden = "hidden";

	private static readonly IntPtr selHiddenHandle = Selector.GetHandle("hidden");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInstance = "instance";

	private static readonly IntPtr selInstanceHandle = Selector.GetHandle("instance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectAtPath_ = "objectAtPath:";

	private static readonly IntPtr selObjectAtPath_Handle = Selector.GetHandle("objectAtPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectWithSCNNode_ = "objectWithSCNNode:";

	private static readonly IntPtr selObjectWithSCNNode_Handle = Selector.GetHandle("objectWithSCNNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectWithSCNNode_BufferAllocator_ = "objectWithSCNNode:bufferAllocator:";

	private static readonly IntPtr selObjectWithSCNNode_BufferAllocator_Handle = Selector.GetHandle("objectWithSCNNode:bufferAllocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParent = "parent";

	private static readonly IntPtr selParentHandle = Selector.GetHandle("parent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPath = "path";

	private static readonly IntPtr selPathHandle = Selector.GetHandle("path");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetChildren_ = "setChildren:";

	private static readonly IntPtr selSetChildren_Handle = Selector.GetHandle("setChildren:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetComponent_ForProtocol_ = "setComponent:forProtocol:";

	private static readonly IntPtr selSetComponent_ForProtocol_Handle = Selector.GetHandle("setComponent:forProtocol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHidden_ = "setHidden:";

	private static readonly IntPtr selSetHidden_Handle = Selector.GetHandle("setHidden:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInstance_ = "setInstance:";

	private static readonly IntPtr selSetInstance_Handle = Selector.GetHandle("setInstance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetParent_ = "setParent:";

	private static readonly IntPtr selSetParent_Handle = Selector.GetHandle("setParent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTransform_ = "setTransform:";

	private static readonly IntPtr selSetTransform_Handle = Selector.GetHandle("setTransform:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTransform = "transform";

	private static readonly IntPtr selTransformHandle = Selector.GetHandle("transform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLObject");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Parent_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMDLObjectContainerComponent? Children
	{
		[Export("children", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMDLObjectContainerComponent>(Messaging.IntPtr_objc_msgSend(base.Handle, selChildrenHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMDLObjectContainerComponent>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChildrenHandle), owns: false);
		}
		[Export("setChildren:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetChildren_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetChildren_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	public virtual IMDLComponent[] Components
	{
		[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
		[Export("components", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<IMDLComponent>(Messaging.IntPtr_objc_msgSend(base.Handle, selComponentsHandle));
			}
			return NSArray.ArrayFromHandle<IMDLComponent>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selComponentsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual bool Hidden
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("hidden")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHiddenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHiddenHandle);
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("setHidden:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHidden_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHidden_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual MDLObject? Instance
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("instance", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selInstanceHandle));
			}
			return Runtime.GetNSObject<MDLObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInstanceHandle));
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("setInstance:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInstance_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInstance_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
		[Export("setName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLObject? Parent
	{
		[Export("parent", ArgumentSemantic.Weak)]
		get
		{
			MDLObject mDLObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MDLObject>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentHandle)) : Runtime.GetNSObject<MDLObject>(Messaging.IntPtr_objc_msgSend(base.Handle, selParentHandle)));
			MarkDirty();
			__mt_Parent_var = mDLObject;
			return mDLObject;
		}
		[Export("setParent:", ArgumentSemantic.Weak)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetParent_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetParent_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_Parent_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual string Path
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("path")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPathHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMDLTransformComponent? Transform
	{
		[Export("transform", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMDLTransformComponent>(Messaging.IntPtr_objc_msgSend(base.Handle, selTransformHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMDLTransformComponent>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTransformHandle), owns: false);
		}
		[Export("setTransform:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTransform_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTransform_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLObject()
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
	protected MDLObject(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLObject(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addChild:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddChild(MDLObject child)
	{
		if (child == null)
		{
			throw new ArgumentNullException("child");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddChild_Handle, child.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddChild_Handle, child.Handle);
		}
	}

	[Export("enumerateChildObjectsOfClass:root:usingBlock:stopPointer:")]
	[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 1, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateChildObjects(Class objectClass, MDLObject root, [BlockProxy(typeof(Trampolines.NIDMDLObjectHandler))] MDLObjectHandler handler, ref bool stop)
	{
		if (objectClass == null)
		{
			throw new ArgumentNullException("objectClass");
		}
		if (root == null)
		{
			throw new ArgumentNullException("root");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMDLObjectHandler.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_Boolean(base.Handle, selEnumerateChildObjectsOfClass_Root_UsingBlock_StopPointer_Handle, objectClass.Handle, root.Handle, (IntPtr)ptr, ref stop);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_ref_Boolean(base.SuperHandle, selEnumerateChildObjectsOfClass_Root_UsingBlock_StopPointer_Handle, objectClass.Handle, root.Handle, (IntPtr)ptr, ref stop);
		}
		ptr->CleanupBlock();
	}

	[Export("objectWithSCNNode:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLObject FromNode(SCNNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		return Runtime.GetNSObject<MDLObject>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selObjectWithSCNNode_Handle, node.Handle));
	}

	[Export("objectWithSCNNode:bufferAllocator:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLObject FromNode(SCNNode node, IMDLMeshBufferAllocator? bufferAllocator)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		return Runtime.GetNSObject<MDLObject>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selObjectWithSCNNode_BufferAllocator_Handle, node.Handle, bufferAllocator?.Handle ?? IntPtr.Zero));
	}

	[Export("boundingBoxAtTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLAxisAlignedBoundingBox GetBoundingBox(double atTime)
	{
		MDLAxisAlignedBoundingBox retval;
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSend_stret_Double(out retval, base.Handle, selBoundingBoxAtTime_Handle, atTime);
		}
		else
		{
			Messaging.xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSendSuper_stret_Double(out retval, base.SuperHandle, selBoundingBoxAtTime_Handle, atTime);
		}
		return retval;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMDLComponent? GetComponent(Protocol protocol)
	{
		return IsComponentConforming(protocol);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMDLComponent? GetComponent(Type type)
	{
		return GetComponent(new Protocol(type));
	}

	[Export("objectAtPath:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLObject GetObject(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		MDLObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MDLObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectAtPath_Handle, arg)) : Runtime.GetNSObject<MDLObject>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectAtPath_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("componentConformingToProtocol:")]
	[Obsolete("Use 'GetComponent (Type type)'.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMDLComponent? IsComponentConforming(Protocol protocol)
	{
		if (protocol == null)
		{
			throw new ArgumentNullException("protocol");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<IMDLComponent>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selComponentConformingToProtocol_Handle, protocol.Handle), owns: false);
		}
		return Runtime.GetINativeObject<IMDLComponent>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selComponentConformingToProtocol_Handle, protocol.Handle), owns: false);
	}

	[Export("setComponent:forProtocol:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetComponent(IMDLComponent component, Protocol protocol)
	{
		if (component == null)
		{
			throw new ArgumentNullException("component");
		}
		if (protocol == null)
		{
			throw new ArgumentNullException("protocol");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetComponent_ForProtocol_Handle, component.Handle, protocol.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetComponent_ForProtocol_Handle, component.Handle, protocol.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetComponent(IMDLComponent component, Type type)
	{
		SetComponent(component, new Protocol(type));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Parent_var = null;
		}
	}
}

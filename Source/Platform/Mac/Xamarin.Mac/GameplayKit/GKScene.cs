using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameplayKit;

[Register("GKScene", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class GKScene : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddEntity_ = "addEntity:";

	private static readonly IntPtr selAddEntity_Handle = Selector.GetHandle("addEntity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddGraph_Name_ = "addGraph:name:";

	private static readonly IntPtr selAddGraph_Name_Handle = Selector.GetHandle("addGraph:name:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEntities = "entities";

	private static readonly IntPtr selEntitiesHandle = Selector.GetHandle("entities");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGraphs = "graphs";

	private static readonly IntPtr selGraphsHandle = Selector.GetHandle("graphs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveEntity_ = "removeEntity:";

	private static readonly IntPtr selRemoveEntity_Handle = Selector.GetHandle("removeEntity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveGraph_ = "removeGraph:";

	private static readonly IntPtr selRemoveGraph_Handle = Selector.GetHandle("removeGraph:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRootNode = "rootNode";

	private static readonly IntPtr selRootNodeHandle = Selector.GetHandle("rootNode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSceneWithFileNamed_ = "sceneWithFileNamed:";

	private static readonly IntPtr selSceneWithFileNamed_Handle = Selector.GetHandle("sceneWithFileNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSceneWithFileNamed_RootNode_ = "sceneWithFileNamed:rootNode:";

	private static readonly IntPtr selSceneWithFileNamed_RootNode_Handle = Selector.GetHandle("sceneWithFileNamed:rootNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRootNode_ = "setRootNode:";

	private static readonly IntPtr selSetRootNode_Handle = Selector.GetHandle("setRootNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKScene");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_RootNode_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKEntity[] Entities
	{
		[Export("entities")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<GKEntity>(Messaging.IntPtr_objc_msgSend(base.Handle, selEntitiesHandle));
			}
			return NSArray.ArrayFromHandle<GKEntity>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntitiesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<NSString, GKGraph> Graphs
	{
		[Export("graphs")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<NSString, GKGraph>>(Messaging.IntPtr_objc_msgSend(base.Handle, selGraphsHandle));
			}
			return Runtime.GetNSObject<NSDictionary<NSString, GKGraph>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGraphsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IGKSceneRootNodeType? RootNode
	{
		[Export("rootNode", ArgumentSemantic.Assign)]
		get
		{
			IGKSceneRootNodeType iGKSceneRootNodeType = ((!base.IsDirectBinding) ? Runtime.GetINativeObject<IGKSceneRootNodeType>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRootNodeHandle), owns: false) : Runtime.GetINativeObject<IGKSceneRootNodeType>(Messaging.IntPtr_objc_msgSend(base.Handle, selRootNodeHandle), owns: false));
			MarkDirty();
			__mt_RootNode_var = iGKSceneRootNodeType;
			return iGKSceneRootNodeType;
		}
		[Export("setRootNode:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRootNode_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRootNode_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_RootNode_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKScene()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public GKScene(NSCoder coder)
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
	protected GKScene(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKScene(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addEntity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddEntity(GKEntity entity)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddEntity_Handle, entity.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddEntity_Handle, entity.Handle);
		}
	}

	[Export("addGraph:name:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddGraph(GKGraph graph, string name)
	{
		if (graph == null)
		{
			throw new ArgumentNullException("graph");
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddGraph_Name_Handle, graph.Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddGraph_Name_Handle, graph.Handle, arg);
		}
		NSString.ReleaseNative(arg);
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

	[Export("sceneWithFileNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKScene? FromFile(string filename)
	{
		if (filename == null)
		{
			throw new ArgumentNullException("filename");
		}
		IntPtr arg = NSString.CreateNative(filename);
		GKScene nSObject = Runtime.GetNSObject<GKScene>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSceneWithFileNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("sceneWithFileNamed:rootNode:")]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static GKScene? FromFile(string filename, IGKSceneRootNodeType rootNode)
	{
		if (filename == null)
		{
			throw new ArgumentNullException("filename");
		}
		if (rootNode == null)
		{
			throw new ArgumentNullException("rootNode");
		}
		IntPtr arg = NSString.CreateNative(filename);
		GKScene nSObject = Runtime.GetNSObject<GKScene>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selSceneWithFileNamed_RootNode_Handle, arg, rootNode.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("removeEntity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveEntity(GKEntity entity)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveEntity_Handle, entity.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveEntity_Handle, entity.Handle);
		}
	}

	[Export("removeGraph:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveGraph(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveGraph_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveGraph_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_RootNode_var = null;
		}
	}
}

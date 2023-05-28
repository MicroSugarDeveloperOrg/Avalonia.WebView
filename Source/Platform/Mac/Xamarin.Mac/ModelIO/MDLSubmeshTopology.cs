using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace ModelIO;

[Register("MDLSubmeshTopology", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLSubmeshTopology : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEdgeCreaseCount = "edgeCreaseCount";

	private static readonly IntPtr selEdgeCreaseCountHandle = Selector.GetHandle("edgeCreaseCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEdgeCreaseIndices = "edgeCreaseIndices";

	private static readonly IntPtr selEdgeCreaseIndicesHandle = Selector.GetHandle("edgeCreaseIndices");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEdgeCreases = "edgeCreases";

	private static readonly IntPtr selEdgeCreasesHandle = Selector.GetHandle("edgeCreases");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFaceCount = "faceCount";

	private static readonly IntPtr selFaceCountHandle = Selector.GetHandle("faceCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFaceTopology = "faceTopology";

	private static readonly IntPtr selFaceTopologyHandle = Selector.GetHandle("faceTopology");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHoleCount = "holeCount";

	private static readonly IntPtr selHoleCountHandle = Selector.GetHandle("holeCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHoles = "holes";

	private static readonly IntPtr selHolesHandle = Selector.GetHandle("holes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSubmesh_ = "initWithSubmesh:";

	private static readonly IntPtr selInitWithSubmesh_Handle = Selector.GetHandle("initWithSubmesh:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEdgeCreaseCount_ = "setEdgeCreaseCount:";

	private static readonly IntPtr selSetEdgeCreaseCount_Handle = Selector.GetHandle("setEdgeCreaseCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEdgeCreaseIndices_ = "setEdgeCreaseIndices:";

	private static readonly IntPtr selSetEdgeCreaseIndices_Handle = Selector.GetHandle("setEdgeCreaseIndices:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEdgeCreases_ = "setEdgeCreases:";

	private static readonly IntPtr selSetEdgeCreases_Handle = Selector.GetHandle("setEdgeCreases:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFaceCount_ = "setFaceCount:";

	private static readonly IntPtr selSetFaceCount_Handle = Selector.GetHandle("setFaceCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFaceTopology_ = "setFaceTopology:";

	private static readonly IntPtr selSetFaceTopology_Handle = Selector.GetHandle("setFaceTopology:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHoleCount_ = "setHoleCount:";

	private static readonly IntPtr selSetHoleCount_Handle = Selector.GetHandle("setHoleCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHoles_ = "setHoles:";

	private static readonly IntPtr selSetHoles_Handle = Selector.GetHandle("setHoles:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVertexCreaseCount_ = "setVertexCreaseCount:";

	private static readonly IntPtr selSetVertexCreaseCount_Handle = Selector.GetHandle("setVertexCreaseCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVertexCreaseIndices_ = "setVertexCreaseIndices:";

	private static readonly IntPtr selSetVertexCreaseIndices_Handle = Selector.GetHandle("setVertexCreaseIndices:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVertexCreases_ = "setVertexCreases:";

	private static readonly IntPtr selSetVertexCreases_Handle = Selector.GetHandle("setVertexCreases:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVertexCreaseCount = "vertexCreaseCount";

	private static readonly IntPtr selVertexCreaseCountHandle = Selector.GetHandle("vertexCreaseCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVertexCreaseIndices = "vertexCreaseIndices";

	private static readonly IntPtr selVertexCreaseIndicesHandle = Selector.GetHandle("vertexCreaseIndices");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVertexCreases = "vertexCreases";

	private static readonly IntPtr selVertexCreasesHandle = Selector.GetHandle("vertexCreases");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLSubmeshTopology");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint EdgeCreaseCount
	{
		[Export("edgeCreaseCount", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selEdgeCreaseCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selEdgeCreaseCountHandle);
		}
		[Export("setEdgeCreaseCount:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetEdgeCreaseCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetEdgeCreaseCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMDLMeshBuffer? EdgeCreaseIndices
	{
		[Export("edgeCreaseIndices", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selEdgeCreaseIndicesHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEdgeCreaseIndicesHandle), owns: false);
		}
		[Export("setEdgeCreaseIndices:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEdgeCreaseIndices_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEdgeCreaseIndices_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMDLMeshBuffer? EdgeCreases
	{
		[Export("edgeCreases", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selEdgeCreasesHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEdgeCreasesHandle), owns: false);
		}
		[Export("setEdgeCreases:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEdgeCreases_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEdgeCreases_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint FaceCount
	{
		[Export("faceCount", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selFaceCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selFaceCountHandle);
		}
		[Export("setFaceCount:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetFaceCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetFaceCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMDLMeshBuffer? FaceTopology
	{
		[Export("faceTopology", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selFaceTopologyHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFaceTopologyHandle), owns: false);
		}
		[Export("setFaceTopology:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFaceTopology_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFaceTopology_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint HoleCount
	{
		[Export("holeCount", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selHoleCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selHoleCountHandle);
		}
		[Export("setHoleCount:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetHoleCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetHoleCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMDLMeshBuffer? Holes
	{
		[Export("holes", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selHolesHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHolesHandle), owns: false);
		}
		[Export("setHoles:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetHoles_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetHoles_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint VertexCreaseCount
	{
		[Export("vertexCreaseCount", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selVertexCreaseCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selVertexCreaseCountHandle);
		}
		[Export("setVertexCreaseCount:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetVertexCreaseCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetVertexCreaseCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMDLMeshBuffer? VertexCreaseIndices
	{
		[Export("vertexCreaseIndices", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selVertexCreaseIndicesHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVertexCreaseIndicesHandle), owns: false);
		}
		[Export("setVertexCreaseIndices:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVertexCreaseIndices_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVertexCreaseIndices_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMDLMeshBuffer? VertexCreases
	{
		[Export("vertexCreases", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selVertexCreasesHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVertexCreasesHandle), owns: false);
		}
		[Export("setVertexCreases:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVertexCreases_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVertexCreases_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLSubmeshTopology()
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
	protected MDLSubmeshTopology(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLSubmeshTopology(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithSubmesh:")]
	[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 1, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLSubmeshTopology(MDLSubmesh submesh)
		: base(NSObjectFlag.Empty)
	{
		if (submesh == null)
		{
			throw new ArgumentNullException("submesh");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithSubmesh_Handle, submesh.Handle), "initWithSubmesh:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithSubmesh_Handle, submesh.Handle), "initWithSubmesh:");
		}
	}
}

using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;
using SceneKit;
using Xamarin.Mac.System.Mac;

namespace ModelIO;

[Register("MDLAsset", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLAsset : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURL = "URL";

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddObject_ = "addObject:";

	private static readonly IntPtr selAddObject_Handle = Selector.GetHandle("addObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimations = "animations";

	private static readonly IntPtr selAnimationsHandle = Selector.GetHandle("animations");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetWithSCNScene_ = "assetWithSCNScene:";

	private static readonly IntPtr selAssetWithSCNScene_Handle = Selector.GetHandle("assetWithSCNScene:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetWithSCNScene_BufferAllocator_ = "assetWithSCNScene:bufferAllocator:";

	private static readonly IntPtr selAssetWithSCNScene_BufferAllocator_Handle = Selector.GetHandle("assetWithSCNScene:bufferAllocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundingBox = "boundingBox";

	private static readonly IntPtr selBoundingBoxHandle = Selector.GetHandle("boundingBox");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundingBoxAtTime_ = "boundingBoxAtTime:";

	private static readonly IntPtr selBoundingBoxAtTime_Handle = Selector.GetHandle("boundingBoxAtTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBufferAllocator = "bufferAllocator";

	private static readonly IntPtr selBufferAllocatorHandle = Selector.GetHandle("bufferAllocator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanExportFileExtension_ = "canExportFileExtension:";

	private static readonly IntPtr selCanExportFileExtension_Handle = Selector.GetHandle("canExportFileExtension:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanImportFileExtension_ = "canImportFileExtension:";

	private static readonly IntPtr selCanImportFileExtension_Handle = Selector.GetHandle("canImportFileExtension:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChildObjectsOfClass_ = "childObjectsOfClass:";

	private static readonly IntPtr selChildObjectsOfClass_Handle = Selector.GetHandle("childObjectsOfClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponentConformingToProtocol_ = "componentConformingToProtocol:";

	private static readonly IntPtr selComponentConformingToProtocol_Handle = Selector.GetHandle("componentConformingToProtocol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selComponents = "components";

	private static readonly IntPtr selComponentsHandle = Selector.GetHandle("components");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCount = "count";

	private static readonly IntPtr selCountHandle = Selector.GetHandle("count");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndTime = "endTime";

	private static readonly IntPtr selEndTimeHandle = Selector.GetHandle("endTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExportAssetToURL_Error_ = "exportAssetToURL:error:";

	private static readonly IntPtr selExportAssetToURL_Error_Handle = Selector.GetHandle("exportAssetToURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameInterval = "frameInterval";

	private static readonly IntPtr selFrameIntervalHandle = Selector.GetHandle("frameInterval");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithBufferAllocator_ = "initWithBufferAllocator:";

	private static readonly IntPtr selInitWithBufferAllocator_Handle = Selector.GetHandle("initWithBufferAllocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_ = "initWithURL:";

	private static readonly IntPtr selInitWithURL_Handle = Selector.GetHandle("initWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_VertexDescriptor_BufferAllocator_ = "initWithURL:vertexDescriptor:bufferAllocator:";

	private static readonly IntPtr selInitWithURL_VertexDescriptor_BufferAllocator_Handle = Selector.GetHandle("initWithURL:vertexDescriptor:bufferAllocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_VertexDescriptor_BufferAllocator_PreserveTopology_Error_ = "initWithURL:vertexDescriptor:bufferAllocator:preserveTopology:error:";

	private static readonly IntPtr selInitWithURL_VertexDescriptor_BufferAllocator_PreserveTopology_Error_Handle = Selector.GetHandle("initWithURL:vertexDescriptor:bufferAllocator:preserveTopology:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadTextures = "loadTextures";

	private static readonly IntPtr selLoadTexturesHandle = Selector.GetHandle("loadTextures");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMasters = "masters";

	private static readonly IntPtr selMastersHandle = Selector.GetHandle("masters");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectAtIndex_ = "objectAtIndex:";

	private static readonly IntPtr selObjectAtIndex_Handle = Selector.GetHandle("objectAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectAtIndexedSubscript_ = "objectAtIndexedSubscript:";

	private static readonly IntPtr selObjectAtIndexedSubscript_Handle = Selector.GetHandle("objectAtIndexedSubscript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectAtPath_ = "objectAtPath:";

	private static readonly IntPtr selObjectAtPath_Handle = Selector.GetHandle("objectAtPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlaceLightProbesWithDensity_Heuristic_UsingIrradianceDataSource_ = "placeLightProbesWithDensity:heuristic:usingIrradianceDataSource:";

	private static readonly IntPtr selPlaceLightProbesWithDensity_Heuristic_UsingIrradianceDataSource_Handle = Selector.GetHandle("placeLightProbesWithDensity:heuristic:usingIrradianceDataSource:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObject_ = "removeObject:";

	private static readonly IntPtr selRemoveObject_Handle = Selector.GetHandle("removeObject:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResolver = "resolver";

	private static readonly IntPtr selResolverHandle = Selector.GetHandle("resolver");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnimations_ = "setAnimations:";

	private static readonly IntPtr selSetAnimations_Handle = Selector.GetHandle("setAnimations:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetComponent_ForProtocol_ = "setComponent:forProtocol:";

	private static readonly IntPtr selSetComponent_ForProtocol_Handle = Selector.GetHandle("setComponent:forProtocol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEndTime_ = "setEndTime:";

	private static readonly IntPtr selSetEndTime_Handle = Selector.GetHandle("setEndTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrameInterval_ = "setFrameInterval:";

	private static readonly IntPtr selSetFrameInterval_Handle = Selector.GetHandle("setFrameInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMasters_ = "setMasters:";

	private static readonly IntPtr selSetMasters_Handle = Selector.GetHandle("setMasters:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetResolver_ = "setResolver:";

	private static readonly IntPtr selSetResolver_Handle = Selector.GetHandle("setResolver:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStartTime_ = "setStartTime:";

	private static readonly IntPtr selSetStartTime_Handle = Selector.GetHandle("setStartTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetUpAxis_ = "setUpAxis:";

	private static readonly IntPtr selSetUpAxis_Handle = Selector.GetHandle("setUpAxis:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartTime = "startTime";

	private static readonly IntPtr selStartTimeHandle = Selector.GetHandle("startTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpAxis = "upAxis";

	private static readonly IntPtr selUpAxisHandle = Selector.GetHandle("upAxis");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVertexDescriptor = "vertexDescriptor";

	private static readonly IntPtr selVertexDescriptorHandle = Selector.GetHandle("vertexDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLAsset");

	public MDLObject this[nuint index] => GetObject(index);

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual IMDLObjectContainerComponent Animations
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("animations", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMDLObjectContainerComponent>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationsHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMDLObjectContainerComponent>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationsHandle), owns: false);
		}
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setAnimations:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAnimations_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAnimations_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLAxisAlignedBoundingBox BoundingBox
	{
		[Export("boundingBox")]
		get
		{
			MDLAxisAlignedBoundingBox retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSend_stret(out retval, base.Handle, selBoundingBoxHandle);
			}
			else
			{
				Messaging.xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSendSuper_stret(out retval, base.SuperHandle, selBoundingBoxHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMDLMeshBufferAllocator BufferAllocator
	{
		[Export("bufferAllocator", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMDLMeshBufferAllocator>(Messaging.IntPtr_objc_msgSend(base.Handle, selBufferAllocatorHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMDLMeshBufferAllocator>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBufferAllocatorHandle), owns: false);
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
	public virtual nuint Count
	{
		[Export("count")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double EndTime
	{
		[Export("endTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selEndTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selEndTimeHandle);
		}
		[Export("setEndTime:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetEndTime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetEndTime_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double FrameInterval
	{
		[Export("frameInterval")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selFrameIntervalHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selFrameIntervalHandle);
		}
		[Export("setFrameInterval:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetFrameInterval_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetFrameInterval_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual IMDLObjectContainerComponent Masters
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("masters", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMDLObjectContainerComponent>(Messaging.IntPtr_objc_msgSend(base.Handle, selMastersHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMDLObjectContainerComponent>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMastersHandle), owns: false);
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("setMasters:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMasters_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMasters_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual IMDLAssetResolver? Resolver
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("resolver", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMDLAssetResolver>(Messaging.IntPtr_objc_msgSend(base.Handle, selResolverHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMDLAssetResolver>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResolverHandle), owns: false);
		}
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setResolver:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetResolver_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetResolver_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double StartTime
	{
		[Export("startTime")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selStartTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selStartTimeHandle);
		}
		[Export("setStartTime:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetStartTime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetStartTime_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual NVector3 UpAxis
	{
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("upAxis", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.xamarin_simd__NVector3_objc_msgSend(base.Handle, selUpAxisHandle);
			}
			return Messaging.xamarin_simd__NVector3_objc_msgSendSuper(base.SuperHandle, selUpAxisHandle);
		}
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setUpAxis:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__void_objc_msgSend_NVector3(base.Handle, selSetUpAxis_Handle, value);
			}
			else
			{
				Messaging.xamarin_simd__void_objc_msgSendSuper_NVector3(base.SuperHandle, selSetUpAxis_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl? Url
	{
		[Export("URL", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLVertexDescriptor? VertexDescriptor
	{
		[Export("vertexDescriptor", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLVertexDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selVertexDescriptorHandle));
			}
			return Runtime.GetNSObject<MDLVertexDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVertexDescriptorHandle));
		}
	}

	[Obsolete("Use the overload that takes an 'MDLLightProbeIrradianceDataSource' instead.")]
	public static MDLLightProbe[] PlaceLightProbes(float density, MDLProbePlacement type, MDLLightProbeIrradianceDataSource dataSource)
	{
		return PlaceLightProbes(density, type, (IMDLLightProbeIrradianceDataSource)dataSource);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLAsset()
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
	protected MDLAsset(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLAsset(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLAsset(NSUrl url)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithURL_Handle, url.Handle), "initWithURL:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithURL_Handle, url.Handle), "initWithURL:");
		}
	}

	[Export("initWithURL:vertexDescriptor:bufferAllocator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLAsset(NSUrl url, MDLVertexDescriptor? vertexDescriptor, IMDLMeshBufferAllocator? bufferAllocator)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithURL_VertexDescriptor_BufferAllocator_Handle, url.Handle, vertexDescriptor?.Handle ?? IntPtr.Zero, bufferAllocator?.Handle ?? IntPtr.Zero), "initWithURL:vertexDescriptor:bufferAllocator:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithURL_VertexDescriptor_BufferAllocator_Handle, url.Handle, vertexDescriptor?.Handle ?? IntPtr.Zero, bufferAllocator?.Handle ?? IntPtr.Zero), "initWithURL:vertexDescriptor:bufferAllocator:");
		}
	}

	[Export("initWithBufferAllocator:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLAsset(IMDLMeshBufferAllocator? bufferAllocator)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithBufferAllocator_Handle, bufferAllocator?.Handle ?? IntPtr.Zero), "initWithBufferAllocator:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithBufferAllocator_Handle, bufferAllocator?.Handle ?? IntPtr.Zero), "initWithBufferAllocator:");
		}
	}

	[Export("initWithURL:vertexDescriptor:bufferAllocator:preserveTopology:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLAsset(NSUrl? url, MDLVertexDescriptor? vertexDescriptor, IMDLMeshBufferAllocator? bufferAllocator, bool preserveTopology, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_bool_ref_IntPtr(base.Handle, selInitWithURL_VertexDescriptor_BufferAllocator_PreserveTopology_Error_Handle, (url == null) ? IntPtr.Zero : url.Handle, vertexDescriptor?.Handle ?? IntPtr.Zero, bufferAllocator?.Handle ?? IntPtr.Zero, preserveTopology, ref arg), "initWithURL:vertexDescriptor:bufferAllocator:preserveTopology:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool_ref_IntPtr(base.SuperHandle, selInitWithURL_VertexDescriptor_BufferAllocator_PreserveTopology_Error_Handle, (url == null) ? IntPtr.Zero : url.Handle, vertexDescriptor?.Handle ?? IntPtr.Zero, bufferAllocator?.Handle ?? IntPtr.Zero, preserveTopology, ref arg), "initWithURL:vertexDescriptor:bufferAllocator:preserveTopology:error:");
		}
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("addObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddObject(MDLObject @object)
	{
		if (@object == null)
		{
			throw new ArgumentNullException("@object");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddObject_Handle, @object.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddObject_Handle, @object.Handle);
		}
	}

	[Export("canExportFileExtension:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool CanExportFileExtension(string extension)
	{
		if (extension == null)
		{
			throw new ArgumentNullException("extension");
		}
		IntPtr arg = NSString.CreateNative(extension);
		bool result = Messaging.bool_objc_msgSend_IntPtr(class_ptr, selCanExportFileExtension_Handle, arg);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("canImportFileExtension:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool CanImportFileExtension(string extension)
	{
		if (extension == null)
		{
			throw new ArgumentNullException("extension");
		}
		IntPtr arg = NSString.CreateNative(extension);
		bool result = Messaging.bool_objc_msgSend_IntPtr(class_ptr, selCanImportFileExtension_Handle, arg);
		NSString.ReleaseNative(arg);
		return result;
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

	[Export("exportAssetToURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ExportAssetToUrl(NSUrl url, out NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selExportAssetToURL_Error_Handle, url.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selExportAssetToURL_Error_Handle, url.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("assetWithSCNScene:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLAsset FromScene(SCNScene scene)
	{
		if (scene == null)
		{
			throw new ArgumentNullException("scene");
		}
		return Runtime.GetNSObject<MDLAsset>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAssetWithSCNScene_Handle, scene.Handle));
	}

	[Export("assetWithSCNScene:bufferAllocator:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLAsset FromScene(SCNScene scene, IMDLMeshBufferAllocator? bufferAllocator)
	{
		if (scene == null)
		{
			throw new ArgumentNullException("scene");
		}
		return Runtime.GetNSObject<MDLAsset>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selAssetWithSCNScene_BufferAllocator_Handle, scene.Handle, bufferAllocator?.Handle ?? IntPtr.Zero));
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

	[Export("childObjectsOfClass:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLObject[] GetChildObjects(Class objectClass)
	{
		if (objectClass == null)
		{
			throw new ArgumentNullException("objectClass");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<MDLObject>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selChildObjectsOfClass_Handle, objectClass.Handle));
		}
		return NSArray.ArrayFromHandle<MDLObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selChildObjectsOfClass_Handle, objectClass.Handle));
	}

	[Export("componentConformingToProtocol:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMDLComponent? GetComponent(Protocol protocol)
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

	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMDLComponent? GetComponent(Type type)
	{
		return GetComponent(new Protocol(type));
	}

	[Export("objectAtPath:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLObject GetObject(string atPath)
	{
		if (atPath == null)
		{
			throw new ArgumentNullException("atPath");
		}
		IntPtr arg = NSString.CreateNative(atPath);
		MDLObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MDLObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectAtPath_Handle, arg)) : Runtime.GetNSObject<MDLObject>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selObjectAtPath_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("objectAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLObject GetObject(nuint index)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MDLObject>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selObjectAtIndex_Handle, index));
		}
		return Runtime.GetNSObject<MDLObject>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selObjectAtIndex_Handle, index));
	}

	[Export("objectAtIndexedSubscript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLObject? GetObjectAtIndexedSubscript(nuint index)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MDLObject>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selObjectAtIndexedSubscript_Handle, index));
		}
		return Runtime.GetNSObject<MDLObject>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selObjectAtIndexedSubscript_Handle, index));
	}

	[Export("loadTextures")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LoadTextures()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selLoadTexturesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selLoadTexturesHandle);
		}
	}

	[Export("placeLightProbesWithDensity:heuristic:usingIrradianceDataSource:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLLightProbe[] PlaceLightProbes(float density, MDLProbePlacement type, IMDLLightProbeIrradianceDataSource dataSource)
	{
		if (dataSource == null)
		{
			throw new ArgumentNullException("dataSource");
		}
		return NSArray.ArrayFromHandle<MDLLightProbe>(Messaging.IntPtr_objc_msgSend_float_Int64_IntPtr(class_ptr, selPlaceLightProbesWithDensity_Heuristic_UsingIrradianceDataSource_Handle, density, (long)type, dataSource.Handle));
	}

	[Export("removeObject:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveObject(MDLObject @object)
	{
		if (@object == null)
		{
			throw new ArgumentNullException("@object");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObject_Handle, @object.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObject_Handle, @object.Handle);
		}
	}

	[Export("setComponent:forProtocol:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
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

	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetComponent(IMDLComponent component, Type type)
	{
		SetComponent(component, new Protocol(type));
	}
}

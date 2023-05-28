using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;

namespace ModelIO;

[Register("MDLVoxelArray", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLVoxelArray : MDLObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundingBox = "boundingBox";

	private static readonly IntPtr selBoundingBoxHandle = Selector.GetHandle("boundingBox");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCoarseMesh = "coarseMesh";

	private static readonly IntPtr selCoarseMeshHandle = Selector.GetHandle("coarseMesh");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCoarseMeshUsingAllocator_ = "coarseMeshUsingAllocator:";

	private static readonly IntPtr selCoarseMeshUsingAllocator_Handle = Selector.GetHandle("coarseMeshUsingAllocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertToSignedShellField = "convertToSignedShellField";

	private static readonly IntPtr selConvertToSignedShellFieldHandle = Selector.GetHandle("convertToSignedShellField");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCount = "count";

	private static readonly IntPtr selCountHandle = Selector.GetHandle("count");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDifferenceWithVoxels_ = "differenceWithVoxels:";

	private static readonly IntPtr selDifferenceWithVoxels_Handle = Selector.GetHandle("differenceWithVoxels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexOfSpatialLocation_ = "indexOfSpatialLocation:";

	private static readonly IntPtr selIndexOfSpatialLocation_Handle = Selector.GetHandle("indexOfSpatialLocation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAsset_Divisions_InteriorNBWidth_ExteriorNBWidth_PatchRadius_ = "initWithAsset:divisions:interiorNBWidth:exteriorNBWidth:patchRadius:";

	private static readonly IntPtr selInitWithAsset_Divisions_InteriorNBWidth_ExteriorNBWidth_PatchRadius_Handle = Selector.GetHandle("initWithAsset:divisions:interiorNBWidth:exteriorNBWidth:patchRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAsset_Divisions_InteriorShells_ExteriorShells_PatchRadius_ = "initWithAsset:divisions:interiorShells:exteriorShells:patchRadius:";

	private static readonly IntPtr selInitWithAsset_Divisions_InteriorShells_ExteriorShells_PatchRadius_Handle = Selector.GetHandle("initWithAsset:divisions:interiorShells:exteriorShells:patchRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAsset_Divisions_PatchRadius_ = "initWithAsset:divisions:patchRadius:";

	private static readonly IntPtr selInitWithAsset_Divisions_PatchRadius_Handle = Selector.GetHandle("initWithAsset:divisions:patchRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_BoundingBox_VoxelExtent_ = "initWithData:boundingBox:voxelExtent:";

	private static readonly IntPtr selInitWithData_BoundingBox_VoxelExtent_Handle = Selector.GetHandle("initWithData:boundingBox:voxelExtent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntersectWithVoxels_ = "intersectWithVoxels:";

	private static readonly IntPtr selIntersectWithVoxels_Handle = Selector.GetHandle("intersectWithVoxels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsValidSignedShellField = "isValidSignedShellField";

	private static readonly IntPtr selIsValidSignedShellFieldHandle = Selector.GetHandle("isValidSignedShellField");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMeshUsingAllocator_ = "meshUsingAllocator:";

	private static readonly IntPtr selMeshUsingAllocator_Handle = Selector.GetHandle("meshUsingAllocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShellFieldExteriorThickness_ = "setShellFieldExteriorThickness:";

	private static readonly IntPtr selSetShellFieldExteriorThickness_Handle = Selector.GetHandle("setShellFieldExteriorThickness:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetShellFieldInteriorThickness_ = "setShellFieldInteriorThickness:";

	private static readonly IntPtr selSetShellFieldInteriorThickness_Handle = Selector.GetHandle("setShellFieldInteriorThickness:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVoxelAtIndex_ = "setVoxelAtIndex:";

	private static readonly IntPtr selSetVoxelAtIndex_Handle = Selector.GetHandle("setVoxelAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVoxelsForMesh_Divisions_InteriorNBWidth_ExteriorNBWidth_PatchRadius_ = "setVoxelsForMesh:divisions:interiorNBWidth:exteriorNBWidth:patchRadius:";

	private static readonly IntPtr selSetVoxelsForMesh_Divisions_InteriorNBWidth_ExteriorNBWidth_PatchRadius_Handle = Selector.GetHandle("setVoxelsForMesh:divisions:interiorNBWidth:exteriorNBWidth:patchRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVoxelsForMesh_Divisions_InteriorShells_ExteriorShells_PatchRadius_ = "setVoxelsForMesh:divisions:interiorShells:exteriorShells:patchRadius:";

	private static readonly IntPtr selSetVoxelsForMesh_Divisions_InteriorShells_ExteriorShells_PatchRadius_Handle = Selector.GetHandle("setVoxelsForMesh:divisions:interiorShells:exteriorShells:patchRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVoxelsForMesh_Divisions_PatchRadius_ = "setVoxelsForMesh:divisions:patchRadius:";

	private static readonly IntPtr selSetVoxelsForMesh_Divisions_PatchRadius_Handle = Selector.GetHandle("setVoxelsForMesh:divisions:patchRadius:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShellFieldExteriorThickness = "shellFieldExteriorThickness";

	private static readonly IntPtr selShellFieldExteriorThicknessHandle = Selector.GetHandle("shellFieldExteriorThickness");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShellFieldInteriorThickness = "shellFieldInteriorThickness";

	private static readonly IntPtr selShellFieldInteriorThicknessHandle = Selector.GetHandle("shellFieldInteriorThickness");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpatialLocationOfIndex_ = "spatialLocationOfIndex:";

	private static readonly IntPtr selSpatialLocationOfIndex_Handle = Selector.GetHandle("spatialLocationOfIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnionWithVoxels_ = "unionWithVoxels:";

	private static readonly IntPtr selUnionWithVoxels_Handle = Selector.GetHandle("unionWithVoxels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVoxelBoundingBoxAtIndex_ = "voxelBoundingBoxAtIndex:";

	private static readonly IntPtr selVoxelBoundingBoxAtIndex_Handle = Selector.GetHandle("voxelBoundingBoxAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVoxelExistsAtIndex_AllowAnyX_AllowAnyY_AllowAnyZ_AllowAnyShell_ = "voxelExistsAtIndex:allowAnyX:allowAnyY:allowAnyZ:allowAnyShell:";

	private static readonly IntPtr selVoxelExistsAtIndex_AllowAnyX_AllowAnyY_AllowAnyZ_AllowAnyShell_Handle = Selector.GetHandle("voxelExistsAtIndex:allowAnyX:allowAnyY:allowAnyZ:allowAnyShell:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVoxelIndexExtent = "voxelIndexExtent";

	private static readonly IntPtr selVoxelIndexExtentHandle = Selector.GetHandle("voxelIndexExtent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVoxelIndices = "voxelIndices";

	private static readonly IntPtr selVoxelIndicesHandle = Selector.GetHandle("voxelIndices");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVoxelsWithinExtent_ = "voxelsWithinExtent:";

	private static readonly IntPtr selVoxelsWithinExtent_Handle = Selector.GetHandle("voxelsWithinExtent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLVoxelArray");

	public override IntPtr ClassHandle => class_ptr;

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
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual bool IsValidSignedShellField
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("isValidSignedShellField")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsValidSignedShellFieldHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsValidSignedShellFieldHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual float ShellFieldExteriorThickness
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("shellFieldExteriorThickness")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selShellFieldExteriorThicknessHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selShellFieldExteriorThicknessHandle);
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("setShellFieldExteriorThickness:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetShellFieldExteriorThickness_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetShellFieldExteriorThickness_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual float ShellFieldInteriorThickness
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("shellFieldInteriorThickness")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selShellFieldInteriorThicknessHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selShellFieldInteriorThicknessHandle);
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("setShellFieldInteriorThickness:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetShellFieldInteriorThickness_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetShellFieldInteriorThickness_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Obsolete("Use 'VoxelIndexExtent2' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual MDLVoxelIndexExtent VoxelIndexExtent
	{
		[Export("voxelIndexExtent")]
		get
		{
			MDLVoxelIndexExtent retval;
			if (base.IsDirectBinding)
			{
				Messaging.MDLVoxelIndexExtent_objc_msgSend_stret(out retval, base.Handle, selVoxelIndexExtentHandle);
			}
			else
			{
				Messaging.MDLVoxelIndexExtent_objc_msgSendSuper_stret(out retval, base.SuperHandle, selVoxelIndexExtentHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLVoxelIndexExtent2 VoxelIndexExtent2
	{
		get
		{
			MDLVoxelIndexExtent2 retval;
			if (base.IsDirectBinding)
			{
				Messaging.xamarin_simd__MDLVoxelIndexExtent2_objc_msgSend_stret(out retval, base.Handle, selVoxelIndexExtentHandle);
			}
			else
			{
				Messaging.xamarin_simd__MDLVoxelIndexExtent2_objc_msgSendSuper_stret(out retval, base.SuperHandle, selVoxelIndexExtentHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MDLVoxelArray(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLVoxelArray(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAsset:divisions:interiorShells:exteriorShells:patchRadius:")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'new MDLVoxelArray (MDLAsset, int, float)'.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLVoxelArray(MDLAsset asset, int divisions, int interiorShells, int exteriorShells, float patchRadius)
		: base(NSObjectFlag.Empty)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_int_int_int_float(base.Handle, selInitWithAsset_Divisions_InteriorShells_ExteriorShells_PatchRadius_Handle, asset.Handle, divisions, interiorShells, exteriorShells, patchRadius), "initWithAsset:divisions:interiorShells:exteriorShells:patchRadius:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_int_int_float(base.SuperHandle, selInitWithAsset_Divisions_InteriorShells_ExteriorShells_PatchRadius_Handle, asset.Handle, divisions, interiorShells, exteriorShells, patchRadius), "initWithAsset:divisions:interiorShells:exteriorShells:patchRadius:");
		}
	}

	[Export("initWithAsset:divisions:interiorNBWidth:exteriorNBWidth:patchRadius:")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'new MDLVoxelArray (MDLAsset, int, float)'.")]
	[Obsoleted(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use new MDLVoxelArray (MDLAsset, int, float)")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLVoxelArray(MDLAsset asset, int divisions, float interiorNBWidth, float exteriorNBWidth, float patchRadius)
		: base(NSObjectFlag.Empty)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_int_float_float_float(base.Handle, selInitWithAsset_Divisions_InteriorNBWidth_ExteriorNBWidth_PatchRadius_Handle, asset.Handle, divisions, interiorNBWidth, exteriorNBWidth, patchRadius), "initWithAsset:divisions:interiorNBWidth:exteriorNBWidth:patchRadius:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_float_float_float(base.SuperHandle, selInitWithAsset_Divisions_InteriorNBWidth_ExteriorNBWidth_PatchRadius_Handle, asset.Handle, divisions, interiorNBWidth, exteriorNBWidth, patchRadius), "initWithAsset:divisions:interiorNBWidth:exteriorNBWidth:patchRadius:");
		}
	}

	[Export("initWithAsset:divisions:patchRadius:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLVoxelArray(MDLAsset asset, int divisions, float patchRadius)
		: base(NSObjectFlag.Empty)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_int_float(base.Handle, selInitWithAsset_Divisions_PatchRadius_Handle, asset.Handle, divisions, patchRadius), "initWithAsset:divisions:patchRadius:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_int_float(base.SuperHandle, selInitWithAsset_Divisions_PatchRadius_Handle, asset.Handle, divisions, patchRadius), "initWithAsset:divisions:patchRadius:");
		}
	}

	[Export("initWithData:boundingBox:voxelExtent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLVoxelArray(NSData voxelData, MDLAxisAlignedBoundingBox boundingBox, float voxelExtent)
		: base(NSObjectFlag.Empty)
	{
		if (voxelData == null)
		{
			throw new ArgumentNullException("voxelData");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_MDLAxisAlignedBoundingBox_float(base.Handle, selInitWithData_BoundingBox_VoxelExtent_Handle, voxelData.Handle, boundingBox, voxelExtent), "initWithData:boundingBox:voxelExtent:");
		}
		else
		{
			InitializeHandle(Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_MDLAxisAlignedBoundingBox_float(base.SuperHandle, selInitWithData_BoundingBox_VoxelExtent_Handle, voxelData.Handle, boundingBox, voxelExtent), "initWithData:boundingBox:voxelExtent:");
		}
	}

	[Export("convertToSignedShellField")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ConvertToSignedShellField()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selConvertToSignedShellFieldHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selConvertToSignedShellFieldHandle);
		}
	}

	[Export("meshUsingAllocator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMesh? CreateMesh(IMDLMeshBufferAllocator? allocator)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MDLMesh>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMeshUsingAllocator_Handle, allocator?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject<MDLMesh>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMeshUsingAllocator_Handle, allocator?.Handle ?? IntPtr.Zero));
	}

	[Export("differenceWithVoxels:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DifferenceWith(MDLVoxelArray voxels)
	{
		if (voxels == null)
		{
			throw new ArgumentNullException("voxels");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDifferenceWithVoxels_Handle, voxels.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDifferenceWithVoxels_Handle, voxels.Handle);
		}
	}

	[Export("coarseMesh")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMesh? GetCoarseMesh()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MDLMesh>(Messaging.IntPtr_objc_msgSend(base.Handle, selCoarseMeshHandle));
		}
		return Runtime.GetNSObject<MDLMesh>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCoarseMeshHandle));
	}

	[Export("coarseMeshUsingAllocator:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLMesh? GetCoarseMeshUsingAllocator(IMDLMeshBufferAllocator? allocator)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<MDLMesh>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCoarseMeshUsingAllocator_Handle, allocator?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject<MDLMesh>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCoarseMeshUsingAllocator_Handle, allocator?.Handle ?? IntPtr.Zero));
	}

	[Export("indexOfSpatialLocation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector4i GetIndex(Vector3 spatiallocation)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__Vector4i_objc_msgSend_Vector3(base.Handle, selIndexOfSpatialLocation_Handle, spatiallocation);
		}
		return Messaging.xamarin_simd__Vector4i_objc_msgSendSuper_Vector3(base.SuperHandle, selIndexOfSpatialLocation_Handle, spatiallocation);
	}

	[Export("spatialLocationOfIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Vector3 GetSpatialLocation(Vector4i index)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__Vector3_objc_msgSend_Vector4i(base.Handle, selSpatialLocationOfIndex_Handle, index);
		}
		return Messaging.xamarin_simd__Vector3_objc_msgSendSuper_Vector4i(base.SuperHandle, selSpatialLocationOfIndex_Handle, index);
	}

	[Export("voxelBoundingBoxAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLAxisAlignedBoundingBox GetVoxelBoundingBox(Vector4i index)
	{
		MDLAxisAlignedBoundingBox retval;
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSend_stret_Vector4i(out retval, base.Handle, selVoxelBoundingBoxAtIndex_Handle, index);
		}
		else
		{
			Messaging.xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSendSuper_stret_Vector4i(out retval, base.SuperHandle, selVoxelBoundingBoxAtIndex_Handle, index);
		}
		return retval;
	}

	[Export("voxelIndices")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? GetVoxelIndices()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selVoxelIndicesHandle));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVoxelIndicesHandle));
	}

	[Export("voxelsWithinExtent:")]
	[Obsolete("Use 'GetVoxels (MDLVoxelIndexExtent2)' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? GetVoxels(MDLVoxelIndexExtent withinExtent)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_MDLVoxelIndexExtent(base.Handle, selVoxelsWithinExtent_Handle, withinExtent));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_MDLVoxelIndexExtent(base.SuperHandle, selVoxelsWithinExtent_Handle, withinExtent));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSData? GetVoxels(MDLVoxelIndexExtent2 withinExtent)
	{
		return Runtime.GetNSObject<NSData>(Messaging.xamarin_simd__IntPtr_objc_msgSend_MDLVoxelIndexExtent2(base.Handle, selVoxelsWithinExtent_Handle, withinExtent));
	}

	[Export("intersectWithVoxels:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void IntersectWith(MDLVoxelArray voxels)
	{
		if (voxels == null)
		{
			throw new ArgumentNullException("voxels");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selIntersectWithVoxels_Handle, voxels.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selIntersectWithVoxels_Handle, voxels.Handle);
		}
	}

	[Export("setVoxelAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetVoxel(Vector4i index)
	{
		if (base.IsDirectBinding)
		{
			Messaging.xamarin_simd__void_objc_msgSend_Vector4i(base.Handle, selSetVoxelAtIndex_Handle, index);
		}
		else
		{
			Messaging.xamarin_simd__void_objc_msgSendSuper_Vector4i(base.SuperHandle, selSetVoxelAtIndex_Handle, index);
		}
	}

	[Export("setVoxelsForMesh:divisions:patchRadius:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetVoxels(MDLMesh mesh, int divisions, float patchRadius)
	{
		if (mesh == null)
		{
			throw new ArgumentNullException("mesh");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int_float(base.Handle, selSetVoxelsForMesh_Divisions_PatchRadius_Handle, mesh.Handle, divisions, patchRadius);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int_float(base.SuperHandle, selSetVoxelsForMesh_Divisions_PatchRadius_Handle, mesh.Handle, divisions, patchRadius);
		}
	}

	[Export("setVoxelsForMesh:divisions:interiorShells:exteriorShells:patchRadius:")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'SetVoxels (MDLMesh, int, float)' instead.")]
	[Obsoleted(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'SetVoxels (MDLMesh, int, float)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetVoxels(MDLMesh mesh, int divisions, int interiorShells, int exteriorShells, float patchRadius)
	{
		if (mesh == null)
		{
			throw new ArgumentNullException("mesh");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int_int_int_float(base.Handle, selSetVoxelsForMesh_Divisions_InteriorShells_ExteriorShells_PatchRadius_Handle, mesh.Handle, divisions, interiorShells, exteriorShells, patchRadius);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int_int_int_float(base.SuperHandle, selSetVoxelsForMesh_Divisions_InteriorShells_ExteriorShells_PatchRadius_Handle, mesh.Handle, divisions, interiorShells, exteriorShells, patchRadius);
		}
	}

	[Export("setVoxelsForMesh:divisions:interiorNBWidth:exteriorNBWidth:patchRadius:")]
	[Deprecated(PlatformName.MacOSX, 10, 12, PlatformArchitecture.None, "Use 'SetVoxels (MDLMesh, int, float)' instead.")]
	[Obsoleted(PlatformName.iOS, 10, 0, PlatformArchitecture.None, "Use 'SetVoxels (MDLMesh, int, float)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetVoxels(MDLMesh mesh, int divisions, float interiorNBWidth, float exteriorNBWidth, float patchRadius)
	{
		if (mesh == null)
		{
			throw new ArgumentNullException("mesh");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int_float_float_float(base.Handle, selSetVoxelsForMesh_Divisions_InteriorNBWidth_ExteriorNBWidth_PatchRadius_Handle, mesh.Handle, divisions, interiorNBWidth, exteriorNBWidth, patchRadius);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int_float_float_float(base.SuperHandle, selSetVoxelsForMesh_Divisions_InteriorNBWidth_ExteriorNBWidth_PatchRadius_Handle, mesh.Handle, divisions, interiorNBWidth, exteriorNBWidth, patchRadius);
		}
	}

	[Export("unionWithVoxels:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UnionWith(MDLVoxelArray voxels)
	{
		if (voxels == null)
		{
			throw new ArgumentNullException("voxels");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUnionWithVoxels_Handle, voxels.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUnionWithVoxels_Handle, voxels.Handle);
		}
	}

	[Export("voxelExistsAtIndex:allowAnyX:allowAnyY:allowAnyZ:allowAnyShell:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool VoxelExists(Vector4i atIndex, bool allowAnyX, bool allowAnyY, bool allowAnyZ, bool allowAnyShell)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__bool_objc_msgSend_Vector4i_bool_bool_bool_bool(base.Handle, selVoxelExistsAtIndex_AllowAnyX_AllowAnyY_AllowAnyZ_AllowAnyShell_Handle, atIndex, allowAnyX, allowAnyY, allowAnyZ, allowAnyShell);
		}
		return Messaging.xamarin_simd__bool_objc_msgSendSuper_Vector4i_bool_bool_bool_bool(base.SuperHandle, selVoxelExistsAtIndex_AllowAnyX_AllowAnyY_AllowAnyZ_AllowAnyShell_Handle, atIndex, allowAnyX, allowAnyY, allowAnyZ, allowAnyShell);
	}
}

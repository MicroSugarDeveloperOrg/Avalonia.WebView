using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using OpenTK;
using SceneKit;
using Xamarin.Mac.System.Mac;

namespace ModelIO;

[Register("MDLMesh", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLMesh : MDLObject
{
	public enum MDLMeshVectorType
	{
		Dimensions,
		Extent
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddAttributeWithName_Format_ = "addAttributeWithName:format:";

	private static readonly IntPtr selAddAttributeWithName_Format_Handle = Selector.GetHandle("addAttributeWithName:format:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddAttributeWithName_Format_Type_Data_Stride_ = "addAttributeWithName:format:type:data:stride:";

	private static readonly IntPtr selAddAttributeWithName_Format_Type_Data_Stride_Handle = Selector.GetHandle("addAttributeWithName:format:type:data:stride:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddAttributeWithName_Format_Type_Data_Stride_Time_ = "addAttributeWithName:format:type:data:stride:time:";

	private static readonly IntPtr selAddAttributeWithName_Format_Type_Data_Stride_Time_Handle = Selector.GetHandle("addAttributeWithName:format:type:data:stride:time:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddNormalsWithAttributeNamed_CreaseThreshold_ = "addNormalsWithAttributeNamed:creaseThreshold:";

	private static readonly IntPtr selAddNormalsWithAttributeNamed_CreaseThreshold_Handle = Selector.GetHandle("addNormalsWithAttributeNamed:creaseThreshold:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddOrthTanBasisForTextureCoordinateAttributeNamed_NormalAttributeNamed_TangentAttributeNamed_ = "addOrthTanBasisForTextureCoordinateAttributeNamed:normalAttributeNamed:tangentAttributeNamed:";

	private static readonly IntPtr selAddOrthTanBasisForTextureCoordinateAttributeNamed_NormalAttributeNamed_TangentAttributeNamed_Handle = Selector.GetHandle("addOrthTanBasisForTextureCoordinateAttributeNamed:normalAttributeNamed:tangentAttributeNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddTangentBasisForTextureCoordinateAttributeNamed_NormalAttributeNamed_TangentAttributeNamed_ = "addTangentBasisForTextureCoordinateAttributeNamed:normalAttributeNamed:tangentAttributeNamed:";

	private static readonly IntPtr selAddTangentBasisForTextureCoordinateAttributeNamed_NormalAttributeNamed_TangentAttributeNamed_Handle = Selector.GetHandle("addTangentBasisForTextureCoordinateAttributeNamed:normalAttributeNamed:tangentAttributeNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddTangentBasisForTextureCoordinateAttributeNamed_TangentAttributeNamed_BitangentAttributeNamed_ = "addTangentBasisForTextureCoordinateAttributeNamed:tangentAttributeNamed:bitangentAttributeNamed:";

	private static readonly IntPtr selAddTangentBasisForTextureCoordinateAttributeNamed_TangentAttributeNamed_BitangentAttributeNamed_Handle = Selector.GetHandle("addTangentBasisForTextureCoordinateAttributeNamed:tangentAttributeNamed:bitangentAttributeNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddUnwrappedTextureCoordinatesForAttributeNamed_ = "addUnwrappedTextureCoordinatesForAttributeNamed:";

	private static readonly IntPtr selAddUnwrappedTextureCoordinatesForAttributeNamed_Handle = Selector.GetHandle("addUnwrappedTextureCoordinatesForAttributeNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllocator = "allocator";

	private static readonly IntPtr selAllocatorHandle = Selector.GetHandle("allocator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundingBox = "boundingBox";

	private static readonly IntPtr selBoundingBoxHandle = Selector.GetHandle("boundingBox");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFlipTextureCoordinatesInAttributeNamed_ = "flipTextureCoordinatesInAttributeNamed:";

	private static readonly IntPtr selFlipTextureCoordinatesInAttributeNamed_Handle = Selector.GetHandle("flipTextureCoordinatesInAttributeNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGenerateAmbientOcclusionTextureWithQuality_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_ = "generateAmbientOcclusionTextureWithQuality:attenuationFactor:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:";

	private static readonly IntPtr selGenerateAmbientOcclusionTextureWithQuality_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_Handle = Selector.GetHandle("generateAmbientOcclusionTextureWithQuality:attenuationFactor:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGenerateAmbientOcclusionTextureWithSize_RaysPerSample_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_ = "generateAmbientOcclusionTextureWithSize:raysPerSample:attenuationFactor:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:";

	private static readonly IntPtr selGenerateAmbientOcclusionTextureWithSize_RaysPerSample_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_Handle = Selector.GetHandle("generateAmbientOcclusionTextureWithSize:raysPerSample:attenuationFactor:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGenerateAmbientOcclusionVertexColorsWithQuality_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_ = "generateAmbientOcclusionVertexColorsWithQuality:attenuationFactor:objectsToConsider:vertexAttributeNamed:";

	private static readonly IntPtr selGenerateAmbientOcclusionVertexColorsWithQuality_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_Handle = Selector.GetHandle("generateAmbientOcclusionVertexColorsWithQuality:attenuationFactor:objectsToConsider:vertexAttributeNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGenerateAmbientOcclusionVertexColorsWithRaysPerSample_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_ = "generateAmbientOcclusionVertexColorsWithRaysPerSample:attenuationFactor:objectsToConsider:vertexAttributeNamed:";

	private static readonly IntPtr selGenerateAmbientOcclusionVertexColorsWithRaysPerSample_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_Handle = Selector.GetHandle("generateAmbientOcclusionVertexColorsWithRaysPerSample:attenuationFactor:objectsToConsider:vertexAttributeNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGenerateLightMapTextureWithQuality_LightsToConsider_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_ = "generateLightMapTextureWithQuality:lightsToConsider:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:";

	private static readonly IntPtr selGenerateLightMapTextureWithQuality_LightsToConsider_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_Handle = Selector.GetHandle("generateLightMapTextureWithQuality:lightsToConsider:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGenerateLightMapTextureWithTextureSize_LightsToConsider_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_ = "generateLightMapTextureWithTextureSize:lightsToConsider:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:";

	private static readonly IntPtr selGenerateLightMapTextureWithTextureSize_LightsToConsider_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_Handle = Selector.GetHandle("generateLightMapTextureWithTextureSize:lightsToConsider:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGenerateLightMapVertexColorsWithLightsToConsider_ObjectsToConsider_VertexAttributeNamed_ = "generateLightMapVertexColorsWithLightsToConsider:objectsToConsider:vertexAttributeNamed:";

	private static readonly IntPtr selGenerateLightMapVertexColorsWithLightsToConsider_ObjectsToConsider_VertexAttributeNamed_Handle = Selector.GetHandle("generateLightMapVertexColorsWithLightsToConsider:objectsToConsider:vertexAttributeNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitBoxWithExtent_Segments_InwardNormals_GeometryType_Allocator_ = "initBoxWithExtent:segments:inwardNormals:geometryType:allocator:";

	private static readonly IntPtr selInitBoxWithExtent_Segments_InwardNormals_GeometryType_Allocator_Handle = Selector.GetHandle("initBoxWithExtent:segments:inwardNormals:geometryType:allocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitCapsuleWithExtent_CylinderSegments_HemisphereSegments_InwardNormals_GeometryType_Allocator_ = "initCapsuleWithExtent:cylinderSegments:hemisphereSegments:inwardNormals:geometryType:allocator:";

	private static readonly IntPtr selInitCapsuleWithExtent_CylinderSegments_HemisphereSegments_InwardNormals_GeometryType_Allocator_Handle = Selector.GetHandle("initCapsuleWithExtent:cylinderSegments:hemisphereSegments:inwardNormals:geometryType:allocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitConeWithExtent_Segments_InwardNormals_Cap_GeometryType_Allocator_ = "initConeWithExtent:segments:inwardNormals:cap:geometryType:allocator:";

	private static readonly IntPtr selInitConeWithExtent_Segments_InwardNormals_Cap_GeometryType_Allocator_Handle = Selector.GetHandle("initConeWithExtent:segments:inwardNormals:cap:geometryType:allocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitCylinderWithExtent_Segments_InwardNormals_TopCap_BottomCap_GeometryType_Allocator_ = "initCylinderWithExtent:segments:inwardNormals:topCap:bottomCap:geometryType:allocator:";

	private static readonly IntPtr selInitCylinderWithExtent_Segments_InwardNormals_TopCap_BottomCap_GeometryType_Allocator_Handle = Selector.GetHandle("initCylinderWithExtent:segments:inwardNormals:topCap:bottomCap:geometryType:allocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitHemisphereWithExtent_Segments_InwardNormals_Cap_GeometryType_Allocator_ = "initHemisphereWithExtent:segments:inwardNormals:cap:geometryType:allocator:";

	private static readonly IntPtr selInitHemisphereWithExtent_Segments_InwardNormals_Cap_GeometryType_Allocator_Handle = Selector.GetHandle("initHemisphereWithExtent:segments:inwardNormals:cap:geometryType:allocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitIcosahedronWithExtent_InwardNormals_GeometryType_Allocator_ = "initIcosahedronWithExtent:inwardNormals:geometryType:allocator:";

	private static readonly IntPtr selInitIcosahedronWithExtent_InwardNormals_GeometryType_Allocator_Handle = Selector.GetHandle("initIcosahedronWithExtent:inwardNormals:geometryType:allocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitMeshBySubdividingMesh_SubmeshIndex_SubdivisionLevels_Allocator_ = "initMeshBySubdividingMesh:submeshIndex:subdivisionLevels:allocator:";

	private static readonly IntPtr selInitMeshBySubdividingMesh_SubmeshIndex_SubdivisionLevels_Allocator_Handle = Selector.GetHandle("initMeshBySubdividingMesh:submeshIndex:subdivisionLevels:allocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitPlaneWithExtent_Segments_GeometryType_Allocator_ = "initPlaneWithExtent:segments:geometryType:allocator:";

	private static readonly IntPtr selInitPlaneWithExtent_Segments_GeometryType_Allocator_Handle = Selector.GetHandle("initPlaneWithExtent:segments:geometryType:allocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitSphereWithExtent_Segments_InwardNormals_GeometryType_Allocator_ = "initSphereWithExtent:segments:inwardNormals:geometryType:allocator:";

	private static readonly IntPtr selInitSphereWithExtent_Segments_InwardNormals_GeometryType_Allocator_Handle = Selector.GetHandle("initSphereWithExtent:segments:inwardNormals:geometryType:allocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithBufferAllocator_ = "initWithBufferAllocator:";

	private static readonly IntPtr selInitWithBufferAllocator_Handle = Selector.GetHandle("initWithBufferAllocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithVertexBuffer_VertexCount_Descriptor_Submeshes_ = "initWithVertexBuffer:vertexCount:descriptor:submeshes:";

	private static readonly IntPtr selInitWithVertexBuffer_VertexCount_Descriptor_Submeshes_Handle = Selector.GetHandle("initWithVertexBuffer:vertexCount:descriptor:submeshes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithVertexBuffers_VertexCount_Descriptor_Submeshes_ = "initWithVertexBuffers:vertexCount:descriptor:submeshes:";

	private static readonly IntPtr selInitWithVertexBuffers_VertexCount_Descriptor_Submeshes_Handle = Selector.GetHandle("initWithVertexBuffers:vertexCount:descriptor:submeshes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeVerticesUnique = "makeVerticesUnique";

	private static readonly IntPtr selMakeVerticesUniqueHandle = Selector.GetHandle("makeVerticesUnique");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMakeVerticesUniqueAndReturnError_ = "makeVerticesUniqueAndReturnError:";

	private static readonly IntPtr selMakeVerticesUniqueAndReturnError_Handle = Selector.GetHandle("makeVerticesUniqueAndReturnError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMeshWithSCNGeometry_ = "meshWithSCNGeometry:";

	private static readonly IntPtr selMeshWithSCNGeometry_Handle = Selector.GetHandle("meshWithSCNGeometry:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMeshWithSCNGeometry_BufferAllocator_ = "meshWithSCNGeometry:bufferAllocator:";

	private static readonly IntPtr selMeshWithSCNGeometry_BufferAllocator_Handle = Selector.GetHandle("meshWithSCNGeometry:bufferAllocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewBoxWithDimensions_Segments_GeometryType_InwardNormals_Allocator_ = "newBoxWithDimensions:segments:geometryType:inwardNormals:allocator:";

	private static readonly IntPtr selNewBoxWithDimensions_Segments_GeometryType_InwardNormals_Allocator_Handle = Selector.GetHandle("newBoxWithDimensions:segments:geometryType:inwardNormals:allocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewCapsuleWithHeight_Radii_RadialSegments_VerticalSegments_HemisphereSegments_GeometryType_InwardNormals_Allocator_ = "newCapsuleWithHeight:radii:radialSegments:verticalSegments:hemisphereSegments:geometryType:inwardNormals:allocator:";

	private static readonly IntPtr selNewCapsuleWithHeight_Radii_RadialSegments_VerticalSegments_HemisphereSegments_GeometryType_InwardNormals_Allocator_Handle = Selector.GetHandle("newCapsuleWithHeight:radii:radialSegments:verticalSegments:hemisphereSegments:geometryType:inwardNormals:allocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewCylinderWithHeight_Radii_RadialSegments_VerticalSegments_GeometryType_InwardNormals_Allocator_ = "newCylinderWithHeight:radii:radialSegments:verticalSegments:geometryType:inwardNormals:allocator:";

	private static readonly IntPtr selNewCylinderWithHeight_Radii_RadialSegments_VerticalSegments_GeometryType_InwardNormals_Allocator_Handle = Selector.GetHandle("newCylinderWithHeight:radii:radialSegments:verticalSegments:geometryType:inwardNormals:allocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewEllipsoidWithRadii_RadialSegments_VerticalSegments_GeometryType_InwardNormals_Hemisphere_Allocator_ = "newEllipsoidWithRadii:radialSegments:verticalSegments:geometryType:inwardNormals:hemisphere:allocator:";

	private static readonly IntPtr selNewEllipsoidWithRadii_RadialSegments_VerticalSegments_GeometryType_InwardNormals_Hemisphere_Allocator_Handle = Selector.GetHandle("newEllipsoidWithRadii:radialSegments:verticalSegments:geometryType:inwardNormals:hemisphere:allocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewEllipticalConeWithHeight_Radii_RadialSegments_VerticalSegments_GeometryType_InwardNormals_Allocator_ = "newEllipticalConeWithHeight:radii:radialSegments:verticalSegments:geometryType:inwardNormals:allocator:";

	private static readonly IntPtr selNewEllipticalConeWithHeight_Radii_RadialSegments_VerticalSegments_GeometryType_InwardNormals_Allocator_Handle = Selector.GetHandle("newEllipticalConeWithHeight:radii:radialSegments:verticalSegments:geometryType:inwardNormals:allocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewIcosahedronWithRadius_InwardNormals_Allocator_ = "newIcosahedronWithRadius:inwardNormals:allocator:";

	private static readonly IntPtr selNewIcosahedronWithRadius_InwardNormals_Allocator_Handle = Selector.GetHandle("newIcosahedronWithRadius:inwardNormals:allocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewIcosahedronWithRadius_InwardNormals_GeometryType_Allocator_ = "newIcosahedronWithRadius:inwardNormals:geometryType:allocator:";

	private static readonly IntPtr selNewIcosahedronWithRadius_InwardNormals_GeometryType_Allocator_Handle = Selector.GetHandle("newIcosahedronWithRadius:inwardNormals:geometryType:allocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewPlaneWithDimensions_Segments_GeometryType_Allocator_ = "newPlaneWithDimensions:segments:geometryType:allocator:";

	private static readonly IntPtr selNewPlaneWithDimensions_Segments_GeometryType_Allocator_Handle = Selector.GetHandle("newPlaneWithDimensions:segments:geometryType:allocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewSubdividedMesh_SubmeshIndex_SubdivisionLevels_ = "newSubdividedMesh:submeshIndex:subdivisionLevels:";

	private static readonly IntPtr selNewSubdividedMesh_SubmeshIndex_SubdivisionLevels_Handle = Selector.GetHandle("newSubdividedMesh:submeshIndex:subdivisionLevels:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAttributeNamed_ = "removeAttributeNamed:";

	private static readonly IntPtr selRemoveAttributeNamed_Handle = Selector.GetHandle("removeAttributeNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceAttributeNamed_WithData_ = "replaceAttributeNamed:withData:";

	private static readonly IntPtr selReplaceAttributeNamed_WithData_Handle = Selector.GetHandle("replaceAttributeNamed:withData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSubmeshes_ = "setSubmeshes:";

	private static readonly IntPtr selSetSubmeshes_Handle = Selector.GetHandle("setSubmeshes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVertexBuffers_ = "setVertexBuffers:";

	private static readonly IntPtr selSetVertexBuffers_Handle = Selector.GetHandle("setVertexBuffers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVertexCount_ = "setVertexCount:";

	private static readonly IntPtr selSetVertexCount_Handle = Selector.GetHandle("setVertexCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVertexDescriptor_ = "setVertexDescriptor:";

	private static readonly IntPtr selSetVertexDescriptor_Handle = Selector.GetHandle("setVertexDescriptor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubmeshes = "submeshes";

	private static readonly IntPtr selSubmeshesHandle = Selector.GetHandle("submeshes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateAttributeNamed_WithData_ = "updateAttributeNamed:withData:";

	private static readonly IntPtr selUpdateAttributeNamed_WithData_Handle = Selector.GetHandle("updateAttributeNamed:withData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVertexAttributeDataForAttributeNamed_ = "vertexAttributeDataForAttributeNamed:";

	private static readonly IntPtr selVertexAttributeDataForAttributeNamed_Handle = Selector.GetHandle("vertexAttributeDataForAttributeNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVertexAttributeDataForAttributeNamed_AsFormat_ = "vertexAttributeDataForAttributeNamed:asFormat:";

	private static readonly IntPtr selVertexAttributeDataForAttributeNamed_AsFormat_Handle = Selector.GetHandle("vertexAttributeDataForAttributeNamed:asFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVertexBuffers = "vertexBuffers";

	private static readonly IntPtr selVertexBuffersHandle = Selector.GetHandle("vertexBuffers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVertexCount = "vertexCount";

	private static readonly IntPtr selVertexCountHandle = Selector.GetHandle("vertexCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVertexDescriptor = "vertexDescriptor";

	private static readonly IntPtr selVertexDescriptorHandle = Selector.GetHandle("vertexDescriptor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLMesh");

	public MDLVertexAttributeData AnisotropyVertexData => GetVertexAttributeDataForAttribute(MDLVertexAttributes.Anisotropy);

	public MDLVertexAttributeData BinormalVertexData => GetVertexAttributeDataForAttribute(MDLVertexAttributes.Binormal);

	public MDLVertexAttributeData BitangentVertexData => GetVertexAttributeDataForAttribute(MDLVertexAttributes.Bitangent);

	public MDLVertexAttributeData ColorVertexData => GetVertexAttributeDataForAttribute(MDLVertexAttributes.Color);

	public MDLVertexAttributeData EdgeCreaseVertexData => GetVertexAttributeDataForAttribute(MDLVertexAttributes.EdgeCrease);

	public MDLVertexAttributeData JointIndicesVertexData => GetVertexAttributeDataForAttribute(MDLVertexAttributes.JointIndices);

	public MDLVertexAttributeData JointWeightsVertexData => GetVertexAttributeDataForAttribute(MDLVertexAttributes.JointWeights);

	public MDLVertexAttributeData NormalVertexData => GetVertexAttributeDataForAttribute(MDLVertexAttributes.Normal);

	public MDLVertexAttributeData OcclusionValueVertexData => GetVertexAttributeDataForAttribute(MDLVertexAttributes.OcclusionValue);

	public MDLVertexAttributeData PositionVertexData => GetVertexAttributeDataForAttribute(MDLVertexAttributes.Position);

	public MDLVertexAttributeData ShadingBasisUVertexData => GetVertexAttributeDataForAttribute(MDLVertexAttributes.ShadingBasisU);

	public MDLVertexAttributeData ShadingBasisVVertexData => GetVertexAttributeDataForAttribute(MDLVertexAttributes.ShadingBasisV);

	public MDLVertexAttributeData SubdivisionStencilVertexData => GetVertexAttributeDataForAttribute(MDLVertexAttributes.SubdivisionStencil);

	public MDLVertexAttributeData TangentVertexData => GetVertexAttributeDataForAttribute(MDLVertexAttributes.Tangent);

	public MDLVertexAttributeData TextureCoordinateVertexData => GetVertexAttributeDataForAttribute(MDLVertexAttributes.TextureCoordinate);

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual IMDLMeshBufferAllocator Allocator
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("allocator", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IMDLMeshBufferAllocator>(Messaging.IntPtr_objc_msgSend(base.Handle, selAllocatorHandle), owns: false);
			}
			return Runtime.GetINativeObject<IMDLMeshBufferAllocator>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllocatorHandle), owns: false);
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
	public virtual NSMutableArray<MDLSubmesh>? Submeshes
	{
		[Export("submeshes", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMutableArray<MDLSubmesh>>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubmeshesHandle));
			}
			return Runtime.GetNSObject<NSMutableArray<MDLSubmesh>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubmeshesHandle));
		}
		[Export("setSubmeshes:", ArgumentSemantic.Copy)]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSubmeshes_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSubmeshes_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IMDLMeshBuffer[] VertexBuffers
	{
		[Export("vertexBuffers", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selVertexBuffersHandle));
			}
			return NSArray.ArrayFromHandle<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVertexBuffersHandle));
		}
		[Export("setVertexBuffers:", ArgumentSemantic.Retain)]
		[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 1, PlatformArchitecture.All, null)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVertexBuffers_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVertexBuffers_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint VertexCount
	{
		[Export("vertexCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selVertexCountHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selVertexCountHandle);
		}
		[Export("setVertexCount:")]
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nuint(base.Handle, selSetVertexCount_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selSetVertexCount_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLVertexDescriptor? VertexDescriptor
	{
		[Export("vertexDescriptor", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MDLVertexDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selVertexDescriptorHandle));
			}
			return Runtime.GetNSObject<MDLVertexDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVertexDescriptorHandle));
		}
		[Export("setVertexDescriptor:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVertexDescriptor_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVertexDescriptor_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	internal MDLMesh(Vector3 extent, Vector2i segments, bool inwardNormals, MDLGeometryType geometryType, IMDLMeshBufferAllocator allocator, int? hemisphereSegments, bool? cap, bool? isCone)
	{
		if (hemisphereSegments.HasValue)
		{
			InitializeHandle(InitCapsule(extent, segments, hemisphereSegments.Value, inwardNormals, geometryType, allocator), "initCapsuleWithExtent:cylinderSegments:hemisphereSegments:inwardNormals:geometryType:allocator:");
		}
		else if (cap.HasValue && isCone.HasValue)
		{
			if (isCone.Value)
			{
				InitializeHandle(InitCone(extent, segments, inwardNormals, cap.Value, geometryType, allocator), "initConeWithExtent:segments:inwardNormals:cap:geometryType:allocator:");
			}
			else
			{
				InitializeHandle(InitHemisphere(extent, segments, inwardNormals, cap.Value, geometryType, allocator), "initHemisphereWithExtent:segments:inwardNormals:cap:geometryType:allocator:");
			}
		}
		else
		{
			InitializeHandle(InitSphere(extent, segments, inwardNormals, geometryType, allocator), "initSphereWithExtent:segments:inwardNormals:geometryType:allocator:");
		}
	}

	internal MDLMesh(Vector3 extent, Vector3i segments, bool inwardNormals, MDLGeometryType geometryType, IMDLMeshBufferAllocator allocator)
	{
		InitializeHandle(InitBox(extent, segments, inwardNormals, geometryType, allocator), "initBoxWithExtent:segments:inwardNormals:geometryType:allocator:");
	}

	internal MDLMesh(Vector3 extent, Vector2i segments, bool inwardNormals, bool topCap, bool bottomCap, MDLGeometryType geometryType, IMDLMeshBufferAllocator allocator)
	{
		InitializeHandle(InitCylinder(extent, segments, inwardNormals, topCap, bottomCap, geometryType, allocator), "initCylinderWithExtent:segments:inwardNormals:topCap:bottomCap:geometryType:allocator:");
	}

	internal MDLMesh(Vector3 extent, Vector2i segments, MDLGeometryType geometryType, IMDLMeshBufferAllocator allocator)
	{
		InitializeHandle(InitPlane(extent, segments, geometryType, allocator), "initPlaneWithExtent:segments:geometryType:allocator:");
	}

	internal MDLMesh(Vector3 extent, bool inwardNormals, MDLGeometryType geometryType, IMDLMeshBufferAllocator allocator)
	{
		InitializeHandle(InitIcosahedron(extent, inwardNormals, geometryType, allocator), "initIcosahedronWithExtent:inwardNormals:geometryType:allocator:");
	}

	internal MDLMesh(MDLMesh mesh, int submeshIndex, uint subdivisionLevels, IMDLMeshBufferAllocator allocator)
	{
		InitializeHandle(InitMesh(mesh, submeshIndex, subdivisionLevels, allocator), "initMeshBySubdividingMesh:submeshIndex:subdivisionLevels:allocator:");
	}

	[iOS(10, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	public static MDLMesh CreateBox(Vector3 dimensions, Vector3i segments, MDLGeometryType geometryType, bool inwardNormals, IMDLMeshBufferAllocator allocator)
	{
		return CreateBox(dimensions, segments, geometryType, inwardNormals, allocator, MDLMeshVectorType.Dimensions);
	}

	[iOS(10, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	public static MDLMesh CreateBox(Vector3 vector, Vector3i segments, MDLGeometryType geometryType, bool inwardNormals, IMDLMeshBufferAllocator allocator, MDLMeshVectorType type = MDLMeshVectorType.Dimensions)
	{
		return type switch
		{
			MDLMeshVectorType.Dimensions => NewBoxWithDimensions(vector, segments, geometryType, inwardNormals, allocator), 
			MDLMeshVectorType.Extent => new MDLMesh(vector, segments, inwardNormals, geometryType, allocator), 
			_ => throw new ArgumentException("The 'MDLMeshVectorType type' argument needs a value."), 
		};
	}

	[iOS(10, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	public static MDLMesh CreateSphere(Vector3 dimensions, Vector2i segments, MDLGeometryType geometryType, bool inwardNormals, IMDLMeshBufferAllocator allocator)
	{
		return new MDLMesh(dimensions, segments, inwardNormals, geometryType, allocator, null, null, null);
	}

	[iOS(10, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	public static MDLMesh CreateHemisphere(Vector3 dimensions, Vector2i segments, MDLGeometryType geometryType, bool inwardNormals, bool cap, IMDLMeshBufferAllocator allocator)
	{
		return new MDLMesh(dimensions, segments, inwardNormals, geometryType, allocator, null, cap, false);
	}

	[iOS(10, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	public static MDLMesh CreateCylinder(Vector3 extent, Vector2i segments, bool inwardNormals, bool topCap, bool bottomCap, MDLGeometryType geometryType, IMDLMeshBufferAllocator allocator)
	{
		return new MDLMesh(extent, segments, inwardNormals, topCap, bottomCap, geometryType, allocator);
	}

	[iOS(10, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	public static MDLMesh CreateCapsule(Vector3 dimensions, Vector2i segments, MDLGeometryType geometryType, bool inwardNormals, int hemisphereSegments, IMDLMeshBufferAllocator allocator)
	{
		return new MDLMesh(dimensions, segments, inwardNormals, geometryType, allocator, hemisphereSegments, null, null);
	}

	[iOS(10, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	public static MDLMesh CreateCone(Vector3 dimensions, Vector2i segments, MDLGeometryType geometryType, bool inwardNormals, bool cap, IMDLMeshBufferAllocator allocator)
	{
		return new MDLMesh(dimensions, segments, inwardNormals, geometryType, allocator, null, cap, true);
	}

	[iOS(10, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	public static MDLMesh CreatePlane(Vector3 extent, Vector2i segments, MDLGeometryType geometryType, IMDLMeshBufferAllocator allocator)
	{
		return new MDLMesh(extent, segments, geometryType, allocator);
	}

	[iOS(10, 0)]
	[TV(10, 0)]
	[Mac(10, 12)]
	public static MDLMesh CreateIcosahedron(Vector3 extent, bool inwardNormals, MDLGeometryType geometryType, IMDLMeshBufferAllocator allocator)
	{
		return new MDLMesh(extent, inwardNormals, geometryType, allocator);
	}

	public static MDLMesh CreateSubdividedMesh(MDLMesh mesh, int submeshIndex, uint subdivisionLevels, IMDLMeshBufferAllocator allocator)
	{
		return new MDLMesh(mesh, submeshIndex, subdivisionLevels, allocator);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLMesh()
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
	protected MDLMesh(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLMesh(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithBufferAllocator:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLMesh(IMDLMeshBufferAllocator? bufferAllocator)
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

	[Export("initWithVertexBuffer:vertexCount:descriptor:submeshes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLMesh(IMDLMeshBuffer vertexBuffer, nuint vertexCount, MDLVertexDescriptor descriptor, MDLSubmesh[] submeshes)
		: base(NSObjectFlag.Empty)
	{
		if (vertexBuffer == null)
		{
			throw new ArgumentNullException("vertexBuffer");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (submeshes == null)
		{
			throw new ArgumentNullException("submeshes");
		}
		NSArray nSArray = NSArray.FromNSObjects(submeshes);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_IntPtr_IntPtr(base.Handle, selInitWithVertexBuffer_VertexCount_Descriptor_Submeshes_Handle, vertexBuffer.Handle, vertexCount, descriptor.Handle, nSArray.Handle), "initWithVertexBuffer:vertexCount:descriptor:submeshes:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_IntPtr_IntPtr(base.SuperHandle, selInitWithVertexBuffer_VertexCount_Descriptor_Submeshes_Handle, vertexBuffer.Handle, vertexCount, descriptor.Handle, nSArray.Handle), "initWithVertexBuffer:vertexCount:descriptor:submeshes:");
		}
		nSArray.Dispose();
	}

	[Export("initWithVertexBuffers:vertexCount:descriptor:submeshes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MDLMesh(IMDLMeshBuffer[] vertexBuffers, nuint vertexCount, MDLVertexDescriptor descriptor, MDLSubmesh[] submeshes)
		: base(NSObjectFlag.Empty)
	{
		if (vertexBuffers == null)
		{
			throw new ArgumentNullException("vertexBuffers");
		}
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (submeshes == null)
		{
			throw new ArgumentNullException("submeshes");
		}
		NSArray nSArray = NSArray.FromNSObjects(vertexBuffers);
		NSArray nSArray2 = NSArray.FromNSObjects(submeshes);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_IntPtr_IntPtr(base.Handle, selInitWithVertexBuffers_VertexCount_Descriptor_Submeshes_Handle, nSArray.Handle, vertexCount, descriptor.Handle, nSArray2.Handle), "initWithVertexBuffers:vertexCount:descriptor:submeshes:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint_IntPtr_IntPtr(base.SuperHandle, selInitWithVertexBuffers_VertexCount_Descriptor_Submeshes_Handle, nSArray.Handle, vertexCount, descriptor.Handle, nSArray2.Handle), "initWithVertexBuffers:vertexCount:descriptor:submeshes:");
		}
		nSArray.Dispose();
		nSArray2.Dispose();
	}

	[Export("addAttributeWithName:format:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddAttribute(string name, MDLVertexFormat format)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selAddAttributeWithName_Format_Handle, arg, (ulong)format);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selAddAttributeWithName_Format_Handle, arg, (ulong)format);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("addAttributeWithName:format:type:data:stride:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddAttribute(string name, MDLVertexFormat format, string type, NSData data, nint stride)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(type);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr_IntPtr_nint(base.Handle, selAddAttributeWithName_Format_Type_Data_Stride_Handle, arg, (ulong)format, arg2, data.Handle, stride);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_IntPtr_IntPtr_nint(base.SuperHandle, selAddAttributeWithName_Format_Type_Data_Stride_Handle, arg, (ulong)format, arg2, data.Handle, stride);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("addAttributeWithName:format:type:data:stride:time:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddAttribute(string name, MDLVertexFormat format, string type, NSData data, nint stride, double time)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(type);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr_IntPtr_nint_Double(base.Handle, selAddAttributeWithName_Format_Type_Data_Stride_Time_Handle, arg, (ulong)format, arg2, data.Handle, stride, time);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_IntPtr_IntPtr_nint_Double(base.SuperHandle, selAddAttributeWithName_Format_Type_Data_Stride_Time_Handle, arg, (ulong)format, arg2, data.Handle, stride, time);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("addNormalsWithAttributeNamed:creaseThreshold:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddNormals(string? name, float creaseThreshold)
	{
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_float(base.Handle, selAddNormalsWithAttributeNamed_CreaseThreshold_Handle, arg, creaseThreshold);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_float(base.SuperHandle, selAddNormalsWithAttributeNamed_CreaseThreshold_Handle, arg, creaseThreshold);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("addOrthTanBasisForTextureCoordinateAttributeNamed:normalAttributeNamed:tangentAttributeNamed:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddOrthTanBasis(string textureCoordinateAttributeName, string normalAttributeName, string tangentAttributeName)
	{
		if (textureCoordinateAttributeName == null)
		{
			throw new ArgumentNullException("textureCoordinateAttributeName");
		}
		if (normalAttributeName == null)
		{
			throw new ArgumentNullException("normalAttributeName");
		}
		if (tangentAttributeName == null)
		{
			throw new ArgumentNullException("tangentAttributeName");
		}
		IntPtr arg = NSString.CreateNative(textureCoordinateAttributeName);
		IntPtr arg2 = NSString.CreateNative(normalAttributeName);
		IntPtr arg3 = NSString.CreateNative(tangentAttributeName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selAddOrthTanBasisForTextureCoordinateAttributeNamed_NormalAttributeNamed_TangentAttributeNamed_Handle, arg, arg2, arg3);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selAddOrthTanBasisForTextureCoordinateAttributeNamed_NormalAttributeNamed_TangentAttributeNamed_Handle, arg, arg2, arg3);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
	}

	[Export("addTangentBasisForTextureCoordinateAttributeNamed:tangentAttributeNamed:bitangentAttributeNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddTangentBasis(string textureCoordinateAttributeName, string tangentAttributeName, string? bitangentAttributeName)
	{
		if (textureCoordinateAttributeName == null)
		{
			throw new ArgumentNullException("textureCoordinateAttributeName");
		}
		if (tangentAttributeName == null)
		{
			throw new ArgumentNullException("tangentAttributeName");
		}
		IntPtr arg = NSString.CreateNative(textureCoordinateAttributeName);
		IntPtr arg2 = NSString.CreateNative(tangentAttributeName);
		IntPtr arg3 = NSString.CreateNative(bitangentAttributeName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selAddTangentBasisForTextureCoordinateAttributeNamed_TangentAttributeNamed_BitangentAttributeNamed_Handle, arg, arg2, arg3);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selAddTangentBasisForTextureCoordinateAttributeNamed_TangentAttributeNamed_BitangentAttributeNamed_Handle, arg, arg2, arg3);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
	}

	[Export("addTangentBasisForTextureCoordinateAttributeNamed:normalAttributeNamed:tangentAttributeNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddTangentBasisWithNormals(string textureCoordinateAttributeName, string normalAttributeName, string tangentAttributeName)
	{
		if (textureCoordinateAttributeName == null)
		{
			throw new ArgumentNullException("textureCoordinateAttributeName");
		}
		if (normalAttributeName == null)
		{
			throw new ArgumentNullException("normalAttributeName");
		}
		if (tangentAttributeName == null)
		{
			throw new ArgumentNullException("tangentAttributeName");
		}
		IntPtr arg = NSString.CreateNative(textureCoordinateAttributeName);
		IntPtr arg2 = NSString.CreateNative(normalAttributeName);
		IntPtr arg3 = NSString.CreateNative(tangentAttributeName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selAddTangentBasisForTextureCoordinateAttributeNamed_NormalAttributeNamed_TangentAttributeNamed_Handle, arg, arg2, arg3);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selAddTangentBasisForTextureCoordinateAttributeNamed_NormalAttributeNamed_TangentAttributeNamed_Handle, arg, arg2, arg3);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
	}

	[Export("addUnwrappedTextureCoordinatesForAttributeNamed:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddUnwrappedTextureCoordinates(string textureCoordinateAttributeName)
	{
		if (textureCoordinateAttributeName == null)
		{
			throw new ArgumentNullException("textureCoordinateAttributeName");
		}
		IntPtr arg = NSString.CreateNative(textureCoordinateAttributeName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddUnwrappedTextureCoordinatesForAttributeNamed_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddUnwrappedTextureCoordinatesForAttributeNamed_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("newCapsuleWithHeight:radii:radialSegments:verticalSegments:hemisphereSegments:geometryType:inwardNormals:allocator:")]
	[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 1, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLMesh CreateCapsule(float height, Vector2 radii, nuint radialSegments, nuint verticalSegments, nuint hemisphereSegments, MDLGeometryType geometryType, bool inwardNormals, IMDLMeshBufferAllocator? allocator)
	{
		return Runtime.GetNSObject<MDLMesh>(Messaging.xamarin_simd__IntPtr_objc_msgSend_float_Vector2_nuint_nuint_nuint_Int64_bool_IntPtr(class_ptr, selNewCapsuleWithHeight_Radii_RadialSegments_VerticalSegments_HemisphereSegments_GeometryType_InwardNormals_Allocator_Handle, height, radii, radialSegments, verticalSegments, hemisphereSegments, (long)geometryType, inwardNormals, allocator?.Handle ?? IntPtr.Zero));
	}

	[Export("newCylinderWithHeight:radii:radialSegments:verticalSegments:geometryType:inwardNormals:allocator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLMesh CreateCylindroid(float height, Vector2 radii, nuint radialSegments, nuint verticalSegments, MDLGeometryType geometryType, bool inwardNormals, IMDLMeshBufferAllocator? allocator)
	{
		return Runtime.GetNSObject<MDLMesh>(Messaging.xamarin_simd__IntPtr_objc_msgSend_float_Vector2_nuint_nuint_Int64_bool_IntPtr(class_ptr, selNewCylinderWithHeight_Radii_RadialSegments_VerticalSegments_GeometryType_InwardNormals_Allocator_Handle, height, radii, radialSegments, verticalSegments, (long)geometryType, inwardNormals, allocator?.Handle ?? IntPtr.Zero));
	}

	[Export("newEllipsoidWithRadii:radialSegments:verticalSegments:geometryType:inwardNormals:hemisphere:allocator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLMesh CreateEllipsoid(Vector3 radii, nuint radialSegments, nuint verticalSegments, MDLGeometryType geometryType, bool inwardNormals, bool hemisphere, IMDLMeshBufferAllocator? allocator)
	{
		return Runtime.GetNSObject<MDLMesh>(Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector3_nuint_nuint_Int64_bool_bool_IntPtr(class_ptr, selNewEllipsoidWithRadii_RadialSegments_VerticalSegments_GeometryType_InwardNormals_Hemisphere_Allocator_Handle, radii, radialSegments, verticalSegments, (long)geometryType, inwardNormals, hemisphere, allocator?.Handle ?? IntPtr.Zero));
	}

	[Export("newEllipticalConeWithHeight:radii:radialSegments:verticalSegments:geometryType:inwardNormals:allocator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLMesh CreateEllipticalCone(float height, Vector2 radii, nuint radialSegments, nuint verticalSegments, MDLGeometryType geometryType, bool inwardNormals, IMDLMeshBufferAllocator? allocator)
	{
		return Runtime.GetNSObject<MDLMesh>(Messaging.xamarin_simd__IntPtr_objc_msgSend_float_Vector2_nuint_nuint_Int64_bool_IntPtr(class_ptr, selNewEllipticalConeWithHeight_Radii_RadialSegments_VerticalSegments_GeometryType_InwardNormals_Allocator_Handle, height, radii, radialSegments, verticalSegments, (long)geometryType, inwardNormals, allocator?.Handle ?? IntPtr.Zero));
	}

	[Export("newIcosahedronWithRadius:inwardNormals:allocator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLMesh CreateIcosahedron(float radius, bool inwardNormals, IMDLMeshBufferAllocator? allocator)
	{
		return Runtime.GetNSObject<MDLMesh>(Messaging.IntPtr_objc_msgSend_float_bool_IntPtr(class_ptr, selNewIcosahedronWithRadius_InwardNormals_Allocator_Handle, radius, inwardNormals, allocator?.Handle ?? IntPtr.Zero));
	}

	[Export("newIcosahedronWithRadius:inwardNormals:geometryType:allocator:")]
	[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 1, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLMesh CreateIcosahedron(float radius, bool inwardNormals, MDLGeometryType geometryType, IMDLMeshBufferAllocator? allocator)
	{
		return Runtime.GetNSObject<MDLMesh>(Messaging.IntPtr_objc_msgSend_float_bool_Int64_IntPtr(class_ptr, selNewIcosahedronWithRadius_InwardNormals_GeometryType_Allocator_Handle, radius, inwardNormals, (long)geometryType, allocator?.Handle ?? IntPtr.Zero));
	}

	[Export("newPlaneWithDimensions:segments:geometryType:allocator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLMesh CreatePlane(Vector2 dimensions, Vector2i segments, MDLGeometryType geometryType, IMDLMeshBufferAllocator? allocator)
	{
		return Runtime.GetNSObject<MDLMesh>(Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector2_Vector2i_Int64_IntPtr(class_ptr, selNewPlaneWithDimensions_Segments_GeometryType_Allocator_Handle, dimensions, segments, (long)geometryType, allocator?.Handle ?? IntPtr.Zero));
	}

	[Export("newSubdividedMesh:submeshIndex:subdivisionLevels:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLMesh CreateSubdividedMesh(MDLMesh mesh, nuint submeshIndex, nuint subdivisionLevels)
	{
		if (mesh == null)
		{
			throw new ArgumentNullException("mesh");
		}
		return Runtime.GetNSObject<MDLMesh>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_nuint(class_ptr, selNewSubdividedMesh_SubmeshIndex_SubdivisionLevels_Handle, mesh.Handle, submeshIndex, subdivisionLevels));
	}

	[Export("flipTextureCoordinatesInAttributeNamed:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FlipTextureCoordinates(string inTextureCoordinateAttributeNamed)
	{
		if (inTextureCoordinateAttributeNamed == null)
		{
			throw new ArgumentNullException("inTextureCoordinateAttributeNamed");
		}
		IntPtr arg = NSString.CreateNative(inTextureCoordinateAttributeNamed);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFlipTextureCoordinatesInAttributeNamed_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFlipTextureCoordinatesInAttributeNamed_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("meshWithSCNGeometry:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLMesh FromGeometry(SCNGeometry geometry)
	{
		if (geometry == null)
		{
			throw new ArgumentNullException("geometry");
		}
		return Runtime.GetNSObject<MDLMesh>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selMeshWithSCNGeometry_Handle, geometry.Handle));
	}

	[Export("meshWithSCNGeometry:bufferAllocator:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MDLMesh FromGeometry(SCNGeometry geometry, IMDLMeshBufferAllocator? bufferAllocator)
	{
		if (geometry == null)
		{
			throw new ArgumentNullException("geometry");
		}
		return Runtime.GetNSObject<MDLMesh>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selMeshWithSCNGeometry_BufferAllocator_Handle, geometry.Handle, bufferAllocator?.Handle ?? IntPtr.Zero));
	}

	[Export("generateAmbientOcclusionTextureWithSize:raysPerSample:attenuationFactor:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GenerateAmbientOcclusionTexture(Vector2i textureSize, nint raysPerSample, float attenuationFactor, MDLObject[] objectsToConsider, string vertexAttributeName, string materialPropertyName)
	{
		if (objectsToConsider == null)
		{
			throw new ArgumentNullException("objectsToConsider");
		}
		if (vertexAttributeName == null)
		{
			throw new ArgumentNullException("vertexAttributeName");
		}
		if (materialPropertyName == null)
		{
			throw new ArgumentNullException("materialPropertyName");
		}
		NSArray nSArray = NSArray.FromNSObjects(objectsToConsider);
		IntPtr arg = NSString.CreateNative(vertexAttributeName);
		IntPtr arg2 = NSString.CreateNative(materialPropertyName);
		bool result = ((!base.IsDirectBinding) ? Messaging.xamarin_simd__bool_objc_msgSendSuper_Vector2i_nint_float_IntPtr_IntPtr_IntPtr(base.SuperHandle, selGenerateAmbientOcclusionTextureWithSize_RaysPerSample_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_Handle, textureSize, raysPerSample, attenuationFactor, nSArray.Handle, arg, arg2) : Messaging.xamarin_simd__bool_objc_msgSend_Vector2i_nint_float_IntPtr_IntPtr_IntPtr(base.Handle, selGenerateAmbientOcclusionTextureWithSize_RaysPerSample_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_Handle, textureSize, raysPerSample, attenuationFactor, nSArray.Handle, arg, arg2));
		nSArray.Dispose();
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("generateAmbientOcclusionTextureWithQuality:attenuationFactor:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GenerateAmbientOcclusionTexture(float bakeQuality, float attenuationFactor, MDLObject[] objectsToConsider, string vertexAttributeName, string materialPropertyName)
	{
		if (objectsToConsider == null)
		{
			throw new ArgumentNullException("objectsToConsider");
		}
		if (vertexAttributeName == null)
		{
			throw new ArgumentNullException("vertexAttributeName");
		}
		if (materialPropertyName == null)
		{
			throw new ArgumentNullException("materialPropertyName");
		}
		NSArray nSArray = NSArray.FromNSObjects(objectsToConsider);
		IntPtr arg = NSString.CreateNative(vertexAttributeName);
		IntPtr arg2 = NSString.CreateNative(materialPropertyName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_float_float_IntPtr_IntPtr_IntPtr(base.SuperHandle, selGenerateAmbientOcclusionTextureWithQuality_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_Handle, bakeQuality, attenuationFactor, nSArray.Handle, arg, arg2) : Messaging.bool_objc_msgSend_float_float_IntPtr_IntPtr_IntPtr(base.Handle, selGenerateAmbientOcclusionTextureWithQuality_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_Handle, bakeQuality, attenuationFactor, nSArray.Handle, arg, arg2));
		nSArray.Dispose();
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("generateAmbientOcclusionVertexColorsWithRaysPerSample:attenuationFactor:objectsToConsider:vertexAttributeNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GenerateAmbientOcclusionVertexColors(nint raysPerSample, float attenuationFactor, MDLObject[] objectsToConsider, string vertexAttributeName)
	{
		if (objectsToConsider == null)
		{
			throw new ArgumentNullException("objectsToConsider");
		}
		if (vertexAttributeName == null)
		{
			throw new ArgumentNullException("vertexAttributeName");
		}
		NSArray nSArray = NSArray.FromNSObjects(objectsToConsider);
		IntPtr arg = NSString.CreateNative(vertexAttributeName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_nint_float_IntPtr_IntPtr(base.SuperHandle, selGenerateAmbientOcclusionVertexColorsWithRaysPerSample_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_Handle, raysPerSample, attenuationFactor, nSArray.Handle, arg) : Messaging.bool_objc_msgSend_nint_float_IntPtr_IntPtr(base.Handle, selGenerateAmbientOcclusionVertexColorsWithRaysPerSample_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_Handle, raysPerSample, attenuationFactor, nSArray.Handle, arg));
		nSArray.Dispose();
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("generateAmbientOcclusionVertexColorsWithQuality:attenuationFactor:objectsToConsider:vertexAttributeNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GenerateAmbientOcclusionVertexColors(float bakeQuality, float attenuationFactor, MDLObject[] objectsToConsider, string vertexAttributeName)
	{
		if (objectsToConsider == null)
		{
			throw new ArgumentNullException("objectsToConsider");
		}
		if (vertexAttributeName == null)
		{
			throw new ArgumentNullException("vertexAttributeName");
		}
		NSArray nSArray = NSArray.FromNSObjects(objectsToConsider);
		IntPtr arg = NSString.CreateNative(vertexAttributeName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_float_float_IntPtr_IntPtr(base.SuperHandle, selGenerateAmbientOcclusionVertexColorsWithQuality_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_Handle, bakeQuality, attenuationFactor, nSArray.Handle, arg) : Messaging.bool_objc_msgSend_float_float_IntPtr_IntPtr(base.Handle, selGenerateAmbientOcclusionVertexColorsWithQuality_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_Handle, bakeQuality, attenuationFactor, nSArray.Handle, arg));
		nSArray.Dispose();
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("generateLightMapTextureWithTextureSize:lightsToConsider:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GenerateLightMapTexture(Vector2i textureSize, MDLLight[] lightsToConsider, MDLObject[] objectsToConsider, string vertexAttributeName, string materialPropertyName)
	{
		if (lightsToConsider == null)
		{
			throw new ArgumentNullException("lightsToConsider");
		}
		if (objectsToConsider == null)
		{
			throw new ArgumentNullException("objectsToConsider");
		}
		if (vertexAttributeName == null)
		{
			throw new ArgumentNullException("vertexAttributeName");
		}
		if (materialPropertyName == null)
		{
			throw new ArgumentNullException("materialPropertyName");
		}
		NSArray nSArray = NSArray.FromNSObjects(lightsToConsider);
		NSArray nSArray2 = NSArray.FromNSObjects(objectsToConsider);
		IntPtr arg = NSString.CreateNative(vertexAttributeName);
		IntPtr arg2 = NSString.CreateNative(materialPropertyName);
		bool result = ((!base.IsDirectBinding) ? Messaging.xamarin_simd__bool_objc_msgSendSuper_Vector2i_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selGenerateLightMapTextureWithTextureSize_LightsToConsider_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_Handle, textureSize, nSArray.Handle, nSArray2.Handle, arg, arg2) : Messaging.xamarin_simd__bool_objc_msgSend_Vector2i_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selGenerateLightMapTextureWithTextureSize_LightsToConsider_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_Handle, textureSize, nSArray.Handle, nSArray2.Handle, arg, arg2));
		nSArray.Dispose();
		nSArray2.Dispose();
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("generateLightMapTextureWithQuality:lightsToConsider:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GenerateLightMapTexture(float bakeQuality, MDLLight[] lightsToConsider, MDLObject[] objectsToConsider, string vertexAttributeName, string materialPropertyName)
	{
		if (lightsToConsider == null)
		{
			throw new ArgumentNullException("lightsToConsider");
		}
		if (objectsToConsider == null)
		{
			throw new ArgumentNullException("objectsToConsider");
		}
		if (vertexAttributeName == null)
		{
			throw new ArgumentNullException("vertexAttributeName");
		}
		if (materialPropertyName == null)
		{
			throw new ArgumentNullException("materialPropertyName");
		}
		NSArray nSArray = NSArray.FromNSObjects(lightsToConsider);
		NSArray nSArray2 = NSArray.FromNSObjects(objectsToConsider);
		IntPtr arg = NSString.CreateNative(vertexAttributeName);
		IntPtr arg2 = NSString.CreateNative(materialPropertyName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_float_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selGenerateLightMapTextureWithQuality_LightsToConsider_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_Handle, bakeQuality, nSArray.Handle, nSArray2.Handle, arg, arg2) : Messaging.bool_objc_msgSend_float_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selGenerateLightMapTextureWithQuality_LightsToConsider_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_Handle, bakeQuality, nSArray.Handle, nSArray2.Handle, arg, arg2));
		nSArray.Dispose();
		nSArray2.Dispose();
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("generateLightMapVertexColorsWithLightsToConsider:objectsToConsider:vertexAttributeNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GenerateLightMapVertexColors(MDLLight[] lightsToConsider, MDLObject[] objectsToConsider, string vertexAttributeName)
	{
		if (lightsToConsider == null)
		{
			throw new ArgumentNullException("lightsToConsider");
		}
		if (objectsToConsider == null)
		{
			throw new ArgumentNullException("objectsToConsider");
		}
		if (vertexAttributeName == null)
		{
			throw new ArgumentNullException("vertexAttributeName");
		}
		NSArray nSArray = NSArray.FromNSObjects(lightsToConsider);
		NSArray nSArray2 = NSArray.FromNSObjects(objectsToConsider);
		IntPtr arg = NSString.CreateNative(vertexAttributeName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selGenerateLightMapVertexColorsWithLightsToConsider_ObjectsToConsider_VertexAttributeNamed_Handle, nSArray.Handle, nSArray2.Handle, arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selGenerateLightMapVertexColorsWithLightsToConsider_ObjectsToConsider_VertexAttributeNamed_Handle, nSArray.Handle, nSArray2.Handle, arg));
		nSArray.Dispose();
		nSArray2.Dispose();
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("vertexAttributeDataForAttributeNamed:asFormat:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MDLVertexAttributeData? GetVertexAttributeData(string attributeName, MDLVertexFormat format)
	{
		if (attributeName == null)
		{
			throw new ArgumentNullException("attributeName");
		}
		IntPtr arg = NSString.CreateNative(attributeName);
		MDLVertexAttributeData result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MDLVertexAttributeData>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selVertexAttributeDataForAttributeNamed_AsFormat_Handle, arg, (ulong)format)) : Runtime.GetNSObject<MDLVertexAttributeData>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selVertexAttributeDataForAttributeNamed_AsFormat_Handle, arg, (ulong)format)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("vertexAttributeDataForAttributeNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual MDLVertexAttributeData? GetVertexAttributeDataForAttribute(string attributeName)
	{
		if (attributeName == null)
		{
			throw new ArgumentNullException("attributeName");
		}
		IntPtr arg = NSString.CreateNative(attributeName);
		MDLVertexAttributeData result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<MDLVertexAttributeData>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selVertexAttributeDataForAttributeNamed_Handle, arg)) : Runtime.GetNSObject<MDLVertexAttributeData>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selVertexAttributeDataForAttributeNamed_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initBoxWithExtent:segments:inwardNormals:geometryType:allocator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitBox(Vector3 extent, Vector3i segments, bool inwardNormals, MDLGeometryType geometryType, IMDLMeshBufferAllocator? allocator)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector3_Vector3i_bool_Int64_IntPtr(base.Handle, selInitBoxWithExtent_Segments_InwardNormals_GeometryType_Allocator_Handle, extent, segments, inwardNormals, (long)geometryType, allocator?.Handle ?? IntPtr.Zero);
		}
		return Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector3_Vector3i_bool_Int64_IntPtr(base.SuperHandle, selInitBoxWithExtent_Segments_InwardNormals_GeometryType_Allocator_Handle, extent, segments, inwardNormals, (long)geometryType, allocator?.Handle ?? IntPtr.Zero);
	}

	[Export("initCapsuleWithExtent:cylinderSegments:hemisphereSegments:inwardNormals:geometryType:allocator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitCapsule(Vector3 extent, Vector2i segments, int hemisphereSegments, bool inwardNormals, MDLGeometryType geometryType, IMDLMeshBufferAllocator? allocator)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector3_Vector2i_int_bool_Int64_IntPtr(base.Handle, selInitCapsuleWithExtent_CylinderSegments_HemisphereSegments_InwardNormals_GeometryType_Allocator_Handle, extent, segments, hemisphereSegments, inwardNormals, (long)geometryType, allocator?.Handle ?? IntPtr.Zero);
		}
		return Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector3_Vector2i_int_bool_Int64_IntPtr(base.SuperHandle, selInitCapsuleWithExtent_CylinderSegments_HemisphereSegments_InwardNormals_GeometryType_Allocator_Handle, extent, segments, hemisphereSegments, inwardNormals, (long)geometryType, allocator?.Handle ?? IntPtr.Zero);
	}

	[Export("initConeWithExtent:segments:inwardNormals:cap:geometryType:allocator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitCone(Vector3 extent, Vector2i segments, bool inwardNormals, bool cap, MDLGeometryType geometryType, IMDLMeshBufferAllocator? allocator)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector3_Vector2i_bool_bool_Int64_IntPtr(base.Handle, selInitConeWithExtent_Segments_InwardNormals_Cap_GeometryType_Allocator_Handle, extent, segments, inwardNormals, cap, (long)geometryType, allocator?.Handle ?? IntPtr.Zero);
		}
		return Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector3_Vector2i_bool_bool_Int64_IntPtr(base.SuperHandle, selInitConeWithExtent_Segments_InwardNormals_Cap_GeometryType_Allocator_Handle, extent, segments, inwardNormals, cap, (long)geometryType, allocator?.Handle ?? IntPtr.Zero);
	}

	[Export("initCylinderWithExtent:segments:inwardNormals:topCap:bottomCap:geometryType:allocator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitCylinder(Vector3 extent, Vector2i segments, bool inwardNormals, bool topCap, bool bottomCap, MDLGeometryType geometryType, IMDLMeshBufferAllocator? allocator)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector3_Vector2i_bool_bool_bool_Int64_IntPtr(base.Handle, selInitCylinderWithExtent_Segments_InwardNormals_TopCap_BottomCap_GeometryType_Allocator_Handle, extent, segments, inwardNormals, topCap, bottomCap, (long)geometryType, allocator?.Handle ?? IntPtr.Zero);
		}
		return Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector3_Vector2i_bool_bool_bool_Int64_IntPtr(base.SuperHandle, selInitCylinderWithExtent_Segments_InwardNormals_TopCap_BottomCap_GeometryType_Allocator_Handle, extent, segments, inwardNormals, topCap, bottomCap, (long)geometryType, allocator?.Handle ?? IntPtr.Zero);
	}

	[Export("initHemisphereWithExtent:segments:inwardNormals:cap:geometryType:allocator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitHemisphere(Vector3 extent, Vector2i segments, bool inwardNormals, bool cap, MDLGeometryType geometryType, IMDLMeshBufferAllocator? allocator)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector3_Vector2i_bool_bool_Int64_IntPtr(base.Handle, selInitHemisphereWithExtent_Segments_InwardNormals_Cap_GeometryType_Allocator_Handle, extent, segments, inwardNormals, cap, (long)geometryType, allocator?.Handle ?? IntPtr.Zero);
		}
		return Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector3_Vector2i_bool_bool_Int64_IntPtr(base.SuperHandle, selInitHemisphereWithExtent_Segments_InwardNormals_Cap_GeometryType_Allocator_Handle, extent, segments, inwardNormals, cap, (long)geometryType, allocator?.Handle ?? IntPtr.Zero);
	}

	[Export("initIcosahedronWithExtent:inwardNormals:geometryType:allocator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitIcosahedron(Vector3 extent, bool inwardNormals, MDLGeometryType geometryType, IMDLMeshBufferAllocator? allocator)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector3_bool_Int64_IntPtr(base.Handle, selInitIcosahedronWithExtent_InwardNormals_GeometryType_Allocator_Handle, extent, inwardNormals, (long)geometryType, allocator?.Handle ?? IntPtr.Zero);
		}
		return Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector3_bool_Int64_IntPtr(base.SuperHandle, selInitIcosahedronWithExtent_InwardNormals_GeometryType_Allocator_Handle, extent, inwardNormals, (long)geometryType, allocator?.Handle ?? IntPtr.Zero);
	}

	[Export("initMeshBySubdividingMesh:submeshIndex:subdivisionLevels:allocator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitMesh(MDLMesh mesh, int submeshIndex, uint subdivisionLevels, IMDLMeshBufferAllocator? allocator)
	{
		if (mesh == null)
		{
			throw new ArgumentNullException("mesh");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__IntPtr_objc_msgSend_IntPtr_int_UInt32_IntPtr(base.Handle, selInitMeshBySubdividingMesh_SubmeshIndex_SubdivisionLevels_Allocator_Handle, mesh.Handle, submeshIndex, subdivisionLevels, allocator?.Handle ?? IntPtr.Zero);
		}
		return Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_int_UInt32_IntPtr(base.SuperHandle, selInitMeshBySubdividingMesh_SubmeshIndex_SubdivisionLevels_Allocator_Handle, mesh.Handle, submeshIndex, subdivisionLevels, allocator?.Handle ?? IntPtr.Zero);
	}

	[Export("initPlaneWithExtent:segments:geometryType:allocator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitPlane(Vector3 extent, Vector2i segments, MDLGeometryType geometryType, IMDLMeshBufferAllocator? allocator)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector3_Vector2i_Int64_IntPtr(base.Handle, selInitPlaneWithExtent_Segments_GeometryType_Allocator_Handle, extent, segments, (long)geometryType, allocator?.Handle ?? IntPtr.Zero);
		}
		return Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector3_Vector2i_Int64_IntPtr(base.SuperHandle, selInitPlaneWithExtent_Segments_GeometryType_Allocator_Handle, extent, segments, (long)geometryType, allocator?.Handle ?? IntPtr.Zero);
	}

	[Export("initSphereWithExtent:segments:inwardNormals:geometryType:allocator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitSphere(Vector3 extent, Vector2i segments, bool inwardNormals, MDLGeometryType geometryType, IMDLMeshBufferAllocator? allocator)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector3_Vector2i_bool_Int64_IntPtr(base.Handle, selInitSphereWithExtent_Segments_InwardNormals_GeometryType_Allocator_Handle, extent, segments, inwardNormals, (long)geometryType, allocator?.Handle ?? IntPtr.Zero);
		}
		return Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector3_Vector2i_bool_Int64_IntPtr(base.SuperHandle, selInitSphereWithExtent_Segments_InwardNormals_GeometryType_Allocator_Handle, extent, segments, inwardNormals, (long)geometryType, allocator?.Handle ?? IntPtr.Zero);
	}

	[Export("makeVerticesUnique")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use the 'NSError' overload.")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use the 'NSError' overload.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void MakeVerticesUnique()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selMakeVerticesUniqueHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selMakeVerticesUniqueHandle);
		}
	}

	[Export("makeVerticesUniqueAndReturnError:")]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool MakeVerticesUnique(out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selMakeVerticesUniqueAndReturnError_Handle, ref arg) : Messaging.bool_objc_msgSend_ref_IntPtr(base.Handle, selMakeVerticesUniqueAndReturnError_Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("newBoxWithDimensions:segments:geometryType:inwardNormals:allocator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static MDLMesh NewBoxWithDimensions(Vector3 dimensions, Vector3i segments, MDLGeometryType geometryType, bool inwardNormals, IMDLMeshBufferAllocator? allocator)
	{
		return Runtime.GetNSObject<MDLMesh>(Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector3_Vector3i_Int64_bool_IntPtr(class_ptr, selNewBoxWithDimensions_Segments_GeometryType_InwardNormals_Allocator_Handle, dimensions, segments, (long)geometryType, inwardNormals, allocator?.Handle ?? IntPtr.Zero));
	}

	[Export("removeAttributeNamed:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAttribute(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveAttributeNamed_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveAttributeNamed_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("replaceAttributeNamed:withData:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplaceAttribute(string name, MDLVertexAttributeData newData)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (newData == null)
		{
			throw new ArgumentNullException("newData");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selReplaceAttributeNamed_WithData_Handle, arg, newData.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReplaceAttributeNamed_WithData_Handle, arg, newData.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("updateAttributeNamed:withData:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateAttribute(string name, MDLVertexAttributeData newData)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (newData == null)
		{
			throw new ArgumentNullException("newData");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selUpdateAttributeNamed_WithData_Handle, arg, newData.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selUpdateAttributeNamed_WithData_Handle, arg, newData.Handle);
		}
		NSString.ReleaseNative(arg);
	}
}

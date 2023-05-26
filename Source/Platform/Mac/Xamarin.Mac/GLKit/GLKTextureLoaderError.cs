namespace GLKit;

public enum GLKTextureLoaderError
{
	FileOrURLNotFound,
	InvalidNSData,
	InvalidCGImage,
	UnknownPathType,
	UnknownFileType,
	PVRAtlasUnsupported,
	CubeMapInvalidNumFiles,
	CompressedTextureUpload,
	UncompressedTextureUpload,
	UnsupportedCubeMapDimensions,
	UnsupportedBitDepth,
	UnsupportedPVRFormat,
	DataPreprocessingFailure,
	MipmapUnsupported,
	UnsupportedOrientation,
	ReorientationFailure,
	AlphaPremultiplicationFailure,
	InvalidEAGLContext,
	IncompatibleFormatSRGB,
	UnsupportedTextureTarget
}

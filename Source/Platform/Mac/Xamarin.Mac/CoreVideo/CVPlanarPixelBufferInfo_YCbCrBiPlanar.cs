using ObjCRuntime;

namespace CoreVideo;

[Watch(4, 0)]
public struct CVPlanarPixelBufferInfo_YCbCrBiPlanar
{
	public CVPlanarComponentInfo ComponentInfoY;

	public CVPlanarComponentInfo ComponentInfoCbCr;
}

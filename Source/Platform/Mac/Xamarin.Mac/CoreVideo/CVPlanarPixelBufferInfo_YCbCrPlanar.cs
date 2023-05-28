using ObjCRuntime;

namespace CoreVideo;

[Watch(4, 0)]
public struct CVPlanarPixelBufferInfo_YCbCrPlanar
{
	public CVPlanarComponentInfo ComponentInfoY;

	public CVPlanarComponentInfo ComponentInfoCb;

	public CVPlanarComponentInfo ComponentInfoCr;
}

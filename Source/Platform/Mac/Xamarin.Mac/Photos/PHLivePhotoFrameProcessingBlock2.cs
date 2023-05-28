using CoreImage;
using Foundation;

namespace Photos;

public delegate CIImage PHLivePhotoFrameProcessingBlock2(IPHLivePhotoFrame frame, ref NSError error);

using System;
using CoreImage;
using Foundation;

namespace Photos;

[Obsolete("Use 'PHLivePhotoFrameProcessingBlock2' instead.")]
public delegate CIImage PHLivePhotoFrameProcessingBlock(IPHLivePhotoFrame frame, NSError error);

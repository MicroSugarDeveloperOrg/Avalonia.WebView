using AVFoundation;
using Foundation;

namespace Photos;

public delegate void PHImageManagerRequestExportHandler(AVAssetExportSession exportSession, NSDictionary info);

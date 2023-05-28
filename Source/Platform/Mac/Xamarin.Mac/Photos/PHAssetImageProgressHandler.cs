using Foundation;

namespace Photos;

public delegate void PHAssetImageProgressHandler(double progress, NSError error, out bool stop, NSDictionary info);

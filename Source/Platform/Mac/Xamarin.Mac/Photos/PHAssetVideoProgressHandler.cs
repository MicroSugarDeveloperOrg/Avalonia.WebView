using Foundation;

namespace Photos;

public delegate void PHAssetVideoProgressHandler(double progress, NSError error, out bool stop, NSDictionary info);

using Foundation;
using ImageIO;

namespace Photos;

public delegate void PHImageDataHandler(NSData data, NSString dataUti, CGImagePropertyOrientation orientation, NSDictionary info);

using Foundation;
using ImageIO;

namespace Photos;

public delegate void PHImageManagerRequestImageDataHandler(NSData? imageData, string? dataUti, CGImagePropertyOrientation orientation, NSDictionary? info);

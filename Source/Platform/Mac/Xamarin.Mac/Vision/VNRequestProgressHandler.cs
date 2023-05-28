using Foundation;

namespace Vision;

public delegate void VNRequestProgressHandler(VNRequest request, double fractionCompleted, NSError? error);

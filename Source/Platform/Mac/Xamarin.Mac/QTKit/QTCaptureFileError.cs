using Foundation;

namespace QTKit;

public delegate bool QTCaptureFileError(QTCaptureFileOutput captureOutput, NSUrl outputFileURL, QTCaptureConnection[] connections, NSError reason);

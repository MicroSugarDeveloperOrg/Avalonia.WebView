using System;
using CoreMedia;
using Foundation;

namespace AVFoundation;

public delegate void AVAssetImageGeneratorCompletionHandler(CMTime requestedTime, IntPtr imageRef, CMTime actualTime, AVAssetImageGeneratorResult result, NSError error);

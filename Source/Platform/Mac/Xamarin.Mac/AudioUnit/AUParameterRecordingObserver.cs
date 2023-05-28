using Xamarin.Mac.System.Mac;

namespace AudioUnit;

public delegate void AUParameterRecordingObserver(nint numberOfEvents, ref AURecordedParameterEvent events);

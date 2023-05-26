using System;

namespace AudioUnit;

public delegate void AUParameterRecordingObserver(nint numberOfEvents, ref AURecordedParameterEvent events);

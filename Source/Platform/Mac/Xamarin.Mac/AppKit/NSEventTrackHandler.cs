using System;

namespace AppKit;

public delegate void NSEventTrackHandler(nfloat gestureAmount, NSEventPhase eventPhase, bool isComplete, ref bool stop);

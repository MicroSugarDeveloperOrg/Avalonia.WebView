using System;

namespace AudioUnit;

public delegate int AUMidiOutputEventBlock(long eventSampleTime, byte cable, nint length, IntPtr midiBytes);

using System;

namespace CoreMidi;

internal delegate void MidiReadProc(IntPtr packetList, IntPtr context, IntPtr srcPtr);

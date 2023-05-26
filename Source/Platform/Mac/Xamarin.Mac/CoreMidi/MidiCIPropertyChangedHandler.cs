using Foundation;

namespace CoreMidi;

public delegate void MidiCIPropertyChangedHandler(MidiCISession session, byte channel, NSData data);

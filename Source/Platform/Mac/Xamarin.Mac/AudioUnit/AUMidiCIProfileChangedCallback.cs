using CoreMidi;

namespace AudioUnit;

public delegate void AUMidiCIProfileChangedCallback(byte cable, byte channel, MidiCIProfile profile, bool enabled);

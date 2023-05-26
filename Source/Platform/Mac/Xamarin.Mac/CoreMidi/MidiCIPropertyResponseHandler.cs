using Foundation;

namespace CoreMidi;

public delegate void MidiCIPropertyResponseHandler(MidiCISession session, byte channel, NSData response, NSError error);

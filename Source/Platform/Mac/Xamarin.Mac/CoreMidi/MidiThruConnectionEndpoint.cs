namespace CoreMidi;

public struct MidiThruConnectionEndpoint
{
	public int EndpointRef;

	public int UniqueID;

	public MidiThruConnectionEndpoint(int endpointRef, int uniqueID)
	{
		EndpointRef = endpointRef;
		UniqueID = uniqueID;
	}
}

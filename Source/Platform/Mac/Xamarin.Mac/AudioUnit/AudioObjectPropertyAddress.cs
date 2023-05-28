namespace AudioUnit;

internal struct AudioObjectPropertyAddress
{
	public uint Selector;

	public uint Scope;

	public uint Element;

	public AudioObjectPropertyAddress(uint selector, uint scope, uint element)
	{
		Selector = selector;
		Scope = scope;
		Element = element;
	}

	public AudioObjectPropertyAddress(AudioObjectPropertySelector selector, AudioObjectPropertyScope scope, AudioObjectPropertyElement element)
	{
		Selector = (uint)selector;
		Scope = (uint)scope;
		Element = (uint)element;
	}
}

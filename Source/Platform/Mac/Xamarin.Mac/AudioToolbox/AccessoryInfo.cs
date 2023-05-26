namespace AudioToolbox;

public class AccessoryInfo
{
	public int ID { get; private set; }

	public string Description { get; private set; }

	internal AccessoryInfo(int id, string description)
	{
		ID = id;
		Description = description;
	}
}

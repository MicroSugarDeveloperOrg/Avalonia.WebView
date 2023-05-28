using Foundation;

namespace AudioToolbox;

public class InstrumentInfo
{
	public const string NameKey = "name";

	public const string MSBKey = "MSB";

	public const string LSBKey = "LSB";

	public const string ProgramKey = "program";

	public string Name => Dictionary["name"].ToString();

	public int MSB => (Dictionary["MSB"] as NSNumber).Int32Value;

	public int LSB => (Dictionary["LSB"] as NSNumber).Int32Value;

	public int Program => (Dictionary["program"] as NSNumber).Int32Value;

	public NSDictionary Dictionary { get; private set; }

	internal InstrumentInfo(NSDictionary d)
	{
		Dictionary = d;
	}
}

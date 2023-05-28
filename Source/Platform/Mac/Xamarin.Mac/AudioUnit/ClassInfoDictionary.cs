using Foundation;

namespace AudioUnit;

public class ClassInfoDictionary : DictionaryContainer
{
	private const string VersionKey = "version";

	private const string TypeKey = "type";

	private const string SubtypeKey = "subtype";

	private const string ManufacturerKey = "manufacturer";

	private const string DataKey = "data";

	private const string NameKey = "name";

	private const string RenderQualityKey = "render-quality";

	private const string CPULoadKey = "cpu-load";

	private const string ElementNameKey = "element-name";

	private const string ExternalFileRefs = "file-references";

	public AudioComponentManufacturerType? Manufacturer
	{
		get
		{
			using NSString key = new NSString("manufacturer");
			return (AudioComponentManufacturerType?)GetInt32Value(key);
		}
	}

	public string Name => GetStringValue("name");

	public AudioComponentType? Type
	{
		get
		{
			using NSString key = new NSString("type");
			return (AudioComponentType?)GetInt32Value(key);
		}
	}

	public ClassInfoDictionary()
		: base(new NSMutableDictionary())
	{
	}

	public ClassInfoDictionary(NSDictionary dictionary)
		: base(dictionary)
	{
	}
}

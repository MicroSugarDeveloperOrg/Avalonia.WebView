using Foundation;

namespace QTKit;

public class QTMovieSaveOptions
{
	public bool Flatten { get; set; }

	public QTFileType? ExportType { get; set; }

	public NSData ExportSettings { get; set; }

	public int? ManufacturerCode { get; set; }

	public NSDictionary ToDictionary()
	{
		NSMutableDictionary nSMutableDictionary = new NSMutableDictionary();
		if (Flatten)
		{
			nSMutableDictionary.SetObject(NSNumber.FromInt32(1), QTMovie.KeyFlatten);
		}
		if (ExportType.HasValue)
		{
			nSMutableDictionary.SetObject(NSNumber.FromInt32(1), QTMovie.KeyExport);
			nSMutableDictionary.SetObject(NSNumber.FromInt32((int)ExportType.Value), QTMovie.KeyExportType);
		}
		if (ExportSettings != null)
		{
			nSMutableDictionary.SetObject(ExportSettings, QTMovie.KeyExportSettings);
		}
		if (ManufacturerCode.HasValue)
		{
			nSMutableDictionary.SetObject(NSNumber.FromInt32(ManufacturerCode.Value), QTMovie.KeyExportManufacturer);
		}
		return nSMutableDictionary;
	}
}

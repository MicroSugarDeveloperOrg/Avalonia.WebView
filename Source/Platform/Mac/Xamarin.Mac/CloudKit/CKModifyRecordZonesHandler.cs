using Foundation;

namespace CloudKit;

public delegate void CKModifyRecordZonesHandler(CKRecordZone[] savedRecordZones, CKRecordZoneID[] deletedRecordZoneIds, NSError operationError);

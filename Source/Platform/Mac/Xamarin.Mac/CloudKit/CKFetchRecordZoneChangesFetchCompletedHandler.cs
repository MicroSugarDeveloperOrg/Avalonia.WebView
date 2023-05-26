using Foundation;

namespace CloudKit;

public delegate void CKFetchRecordZoneChangesFetchCompletedHandler(CKRecordZoneID recordZoneID, CKServerChangeToken serverChangeToken, NSData clientChangeTokenData, bool moreComing, NSError recordZoneError);

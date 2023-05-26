using Foundation;

namespace CloudKit;

public delegate void CKFetchRecordZoneChangesTokensUpdatedHandler(CKRecordZoneID recordZoneID, CKServerChangeToken serverChangeToken, NSData clientChangeTokenData);

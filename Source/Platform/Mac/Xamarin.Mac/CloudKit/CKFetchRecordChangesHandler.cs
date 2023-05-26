using Foundation;

namespace CloudKit;

public delegate void CKFetchRecordChangesHandler(CKServerChangeToken serverChangeToken, NSData clientChangeTokenData, NSError operationError);

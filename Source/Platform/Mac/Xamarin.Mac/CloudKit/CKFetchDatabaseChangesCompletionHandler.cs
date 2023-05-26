using Foundation;

namespace CloudKit;

public delegate void CKFetchDatabaseChangesCompletionHandler(CKServerChangeToken serverChangeToken, bool moreComing, NSError operationError);

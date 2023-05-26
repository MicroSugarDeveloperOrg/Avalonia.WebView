using Foundation;

namespace CloudKit;

public delegate void CKDiscoverUserInfosCompletionHandler(NSDictionary emailsToUserInfos, NSDictionary userRecordIdsToUserInfos, NSError operationError);

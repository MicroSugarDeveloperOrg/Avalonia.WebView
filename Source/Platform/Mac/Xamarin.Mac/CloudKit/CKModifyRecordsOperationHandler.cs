using Foundation;

namespace CloudKit;

public delegate void CKModifyRecordsOperationHandler(CKRecord[] savedRecords, CKRecordID[] deletedRecordIds, NSError operationError);

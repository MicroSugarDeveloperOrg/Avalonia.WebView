using Foundation;

namespace CloudKit;

public delegate void CKAcceptPerShareCompletionHandler(CKShareMetadata shareMetadata, CKShare acceptedShare, NSError error);

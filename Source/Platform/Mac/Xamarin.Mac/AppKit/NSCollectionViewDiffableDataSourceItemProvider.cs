using Foundation;

namespace AppKit;

public delegate NSCollectionViewItem NSCollectionViewDiffableDataSourceItemProvider(NSCollectionView collectionView, NSIndexPath indexPath, NSObject itemIdentifierType);

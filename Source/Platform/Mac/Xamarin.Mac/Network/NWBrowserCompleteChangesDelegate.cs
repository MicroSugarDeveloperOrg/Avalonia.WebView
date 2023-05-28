using System.Collections.Generic;

namespace Network;

public delegate void NWBrowserCompleteChangesDelegate(List<(NWBrowseResult result, NWBrowseResultChange change)> changes);

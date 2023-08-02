using Foundation;

namespace WebKit;

public delegate NSObject WebResourceIdentifierRequest(WebView sender, NSUrlRequest request, WebDataSource dataSource);

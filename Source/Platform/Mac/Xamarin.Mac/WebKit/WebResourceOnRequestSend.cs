using Foundation;

namespace WebKit;

public delegate NSUrlRequest WebResourceOnRequestSend(WebView sender, NSObject identifier, NSUrlRequest request, NSUrlResponse redirectResponse, WebDataSource dataSource);

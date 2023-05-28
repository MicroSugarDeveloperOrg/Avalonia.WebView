using System;
using System.Globalization;
using System.Text;

namespace Foundation;

internal static class NSHttpCookieExtensions
{
	private static void AppendSegment(StringBuilder builder, string name, string value)
	{
		if (builder.Length > 0)
		{
			builder.Append("; ");
		}
		builder.Append(name);
		if (value != null)
		{
			builder.Append("=").Append(value);
		}
	}

	public static string GetHeaderValue(this NSHttpCookie cookie)
	{
		StringBuilder stringBuilder = new StringBuilder();
		AppendSegment(stringBuilder, cookie.Name, cookie.Value);
		AppendSegment(stringBuilder, NSHttpCookie.KeyPath.ToString(), cookie.Path.ToString());
		AppendSegment(stringBuilder, NSHttpCookie.KeyDomain.ToString(), cookie.Domain.ToString());
		AppendSegment(stringBuilder, NSHttpCookie.KeyVersion.ToString(), cookie.Version.ToString());
		if (cookie.Comment != null)
		{
			AppendSegment(stringBuilder, NSHttpCookie.KeyComment.ToString(), cookie.Comment.ToString());
		}
		if (cookie.CommentUrl != null)
		{
			AppendSegment(stringBuilder, NSHttpCookie.KeyCommentUrl.ToString(), cookie.CommentUrl.ToString());
		}
		if (cookie.Properties.ContainsKey(NSHttpCookie.KeyDiscard))
		{
			AppendSegment(stringBuilder, NSHttpCookie.KeyDiscard.ToString(), null);
		}
		if (cookie.ExpiresDate != null)
		{
			string value = ((DateTime)cookie.ExpiresDate).ToUniversalTime().ToString("r", CultureInfo.InvariantCulture);
			AppendSegment(stringBuilder, NSHttpCookie.KeyExpires.ToString(), value);
		}
		if (cookie.Properties.ContainsKey(NSHttpCookie.KeyMaximumAge))
		{
			NSString nSString = (NSString)cookie.Properties[NSHttpCookie.KeyMaximumAge];
			AppendSegment(stringBuilder, NSHttpCookie.KeyMaximumAge.ToString(), nSString);
		}
		if (cookie.IsSecure)
		{
			AppendSegment(stringBuilder, NSHttpCookie.KeySecure.ToString(), null);
		}
		if (cookie.IsHttpOnly)
		{
			AppendSegment(stringBuilder, "httponly", null);
		}
		return stringBuilder.ToString();
	}
}

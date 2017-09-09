namespace SocialNetwork.Common.Extensions
{
    using System.Text;
    using System.Text.Encodings.Web;

    public static class StringExtensions
    {
        public static string GetFormattedString(this string format, params object[] parameters)
        {
            return string.Format(format, parameters);
        }

        public static string FormatKey(this string unformattedKey)
        {
            var result = new StringBuilder();
            int currentPosition = 0;
            while (currentPosition + 4 < unformattedKey.Length)
            {
                result.Append(unformattedKey.Substring(currentPosition, 4)).Append(" ");
                currentPosition += 4;
            }

            if (currentPosition < unformattedKey.Length)
            {
                result.Append(unformattedKey.Substring(currentPosition));
            }

            return result.ToString().ToLowerInvariant();
        }

        public static string GenerateQrCodeUri(
            this string email,
            string unformattedKey,
            string authenicatorUriFormat,
            UrlEncoder urlEncoder,
            string encodedFor)
        {
            return string.Format(
                authenicatorUriFormat,
                urlEncoder.Encode(encodedFor),
                urlEncoder.Encode(email),
                unformattedKey);
        }
    }
}
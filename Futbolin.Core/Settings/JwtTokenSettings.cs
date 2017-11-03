namespace Futbolin.Core.Settings
{
    public class JwtTokenSettings
    {
        public string Issuer { get; set; }
        public string Key { get; set; }
        public int ExpiryMinutes { get; set; }
    }
}

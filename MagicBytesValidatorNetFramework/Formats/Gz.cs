using MagicBytesValidatorNetFramework.Models;

namespace MagicBytesValidatorNetFramework.Formats
{
    public class Gz : FileType
    {
        public Gz() : base(
            new[] { "application/gzip" },
            new[] { "gz" },
            new[]
            {
                new byte[] { 31, 139 }
            })
        {
        }
    }
}
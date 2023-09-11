using MagicBytesValidatorNetFramework.Models;

namespace MagicBytesValidatorNetFramework.Formats
{
    public class Ppm : FileType
    {
        public Ppm() : base(
            new[] { "image/x-portable-pixmap" },
            new[] { "ppm" },
            new[]
            {
                new byte[] { 80, 51, 10 }
            })
        {
        }
    }
}
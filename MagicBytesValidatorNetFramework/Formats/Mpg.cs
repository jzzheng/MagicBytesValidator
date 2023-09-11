using MagicBytesValidatorNetFramework.Models;

namespace MagicBytesValidatorNetFramework.Formats
{
    public class Mpg : FileType
    {
        public Mpg() : base(
            new[] { "video/mpeg" },
            new[] { "mpg", "mpeg", "mpe" },
            new[]
            {
                new byte[] { 71 },
                new byte[] { 0, 0, 1, 186 },
                new byte[] { 0, 0, 1, 179 }
            })
        {
        }
    }
}
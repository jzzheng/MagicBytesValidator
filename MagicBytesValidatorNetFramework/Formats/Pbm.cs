using MagicBytesValidatorNetFramework.Models;

namespace MagicBytesValidatorNetFramework.Formats
{
    public class Pbm : FileType
    {
        public Pbm() : base(
            new[] { "image/x-portable-bitmap" },
            new[] { "pbm" },
            new[]
            {
                new byte[] { 80, 49, 10 }
            })
        {
        }
    }
}
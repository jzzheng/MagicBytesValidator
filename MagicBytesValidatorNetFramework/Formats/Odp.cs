using MagicBytesValidatorNetFramework.Models;

namespace MagicBytesValidatorNetFramework.Formats
{
    public class Odp : FileType
    {
        public Odp() : base(
            new[] { "application/vnd.oasis.opendocument.presentation" },
            new[] { "odp" },
            new[]
            {
                new byte[] { 80, 75, 7, 8 }
            })
        {
        }
    }
}
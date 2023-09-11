using MagicBytesValidatorNetFramework.Models;

namespace MagicBytesValidatorNetFramework.Formats
{
    public class Odt : FileType
    {
        public Odt() : base(
            new[] { "application/vnd.oasis.opendocument.text" },
            new[] { "odt" },
            new[]
            {
                new byte[] { 80, 75, 3, 4 },
                new byte[] { 80, 75, 5, 6 },
                new byte[] { 80, 75, 7, 8 }
            })
        {
        }
    }
}
using MagicBytesValidatorNetFramework.Models;

namespace MagicBytesValidatorNetFramework.Formats
{
    public class Ico : FileType
    {
        public Ico() : base(
            new[] { "image/x-icon" },
            new[] { "ico" },
            new[]
            {
                new byte[] { 0, 0, 1, 0 }
            })
        {
        }
    }
}
using MagicBytesValidatorNetFramework.Models;

namespace MagicBytesValidatorNetFramework.Formats
{
    public class Aif : FileType
    {
        public Aif() : base(
            new[] { "audio/x-aiff" },
            new[] { "aif", "aiff", "aifc" },
            new[]
            {
                new byte[] { 65, 73, 70, 70 }
            }
        )
        {
        }
    }
}
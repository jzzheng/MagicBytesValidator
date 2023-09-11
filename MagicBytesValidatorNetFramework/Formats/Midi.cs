using MagicBytesValidatorNetFramework.Models;

namespace MagicBytesValidatorNetFramework.Formats
{
    public class Midi : FileType
    {
        public Midi() : base(
            new[] { "audio/x-midi" },
            new[] { "midi", "mid" },
            new[]
            {
                new byte[] { 77, 84, 104, 100 }
            })
        {
        }
    }
}
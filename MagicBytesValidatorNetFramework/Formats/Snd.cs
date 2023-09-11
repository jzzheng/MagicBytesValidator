using MagicBytesValidatorNetFramework.Models;

namespace MagicBytesValidatorNetFramework.Formats
{
    public class Snd : FileType
    {
        public Snd() : base(
            new[] { "audio/basic" },
            new[] { "snd", "au" },
            new[]
            {
                new byte[] { 56, 83, 86, 88 },
                new byte[] { 65, 73, 70, 70 }
            })
        {
        }
    }
}
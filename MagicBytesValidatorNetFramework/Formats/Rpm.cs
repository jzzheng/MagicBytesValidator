using MagicBytesValidatorNetFramework.Models;

namespace MagicBytesValidatorNetFramework.Formats
{
    public class Rpm : FileType
    {
        public Rpm() : base(
            new[] { "audio/x-pn-realaudio-plugin" },
            new[] { "rpm" },
            new[]
            {
                new byte[] { 237, 171, 238, 219 }
            })
        {
        }
    }
}
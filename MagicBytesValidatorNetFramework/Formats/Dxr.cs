using MagicBytesValidatorNetFramework.Models;

namespace MagicBytesValidatorNetFramework.Formats
{
    public class Dxr : FileType
    {
        public Dxr() : base(
            new[] { "application/x-director" },
            new[] { "dxr", "dcr", "dir" },
            new[]
            {
                new byte[] { 77, 86, 57, 51 }
            })
        {
        }
    }
}
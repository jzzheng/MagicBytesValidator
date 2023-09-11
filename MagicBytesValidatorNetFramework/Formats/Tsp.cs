using MagicBytesValidatorNetFramework.Models;

namespace MagicBytesValidatorNetFramework.Formats
{
    public class Tsp : FileType
    {
        public Tsp() : base(
            new[] { "application/dsptype" },
            new[] { "tsp" },
            new[]
            {
                new byte[] { 77, 90 }
            })
        {
        }
    }
}
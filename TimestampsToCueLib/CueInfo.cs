using System.Collections.Generic;
using System.Text;
using TimeStampsToCueAbstractions;

namespace TimestampsToCueLib
{
    public class CueInfo : ICueInfo
    {
        public string FilePath { get; init; }
        public string Title { get; init; }
        public ICollection<ICueElement> Elements { get; } = new List<ICueElement>();

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"TITLE \"{Title}\"");
            sb.AppendLine($"FILE \"{FilePath}\"");

            var trackNumber = 0;
            foreach (var cueElement in Elements)
            {
                ++trackNumber;
                sb.AppendLine($"  TRACK {trackNumber:D2} AUDIO");
                sb.AppendLine($"    TITLE \"{cueElement.Title}\"");
                sb.AppendLine($"    INDEX 01 {cueElement.Time}");
            }

            return sb.ToString();
        }
    }
}
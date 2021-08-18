using TimeStampsToCueAbstractions;

namespace TimestampsToCueLib
{
    public class CueElement : ICueElement
    {
        public string Time { get; set; }
        public string Title { get; set; }
    }
}
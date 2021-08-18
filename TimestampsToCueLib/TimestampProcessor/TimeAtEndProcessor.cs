using TimeStampsToCueAbstractions;
using TimeStampsToCueAbstractions.TimestampProcessor;

namespace TimestampsToCueLib.TimestampProcessor
{
    public class TimeAtEndProcessor : ITimestampProcessor
    {
        private readonly TimeStampFormatConverter _timeStampFormatConverter;

        public TimeAtEndProcessor(TimeStampFormatConverter timeStampFormatConverter)
        {
            _timeStampFormatConverter = timeStampFormatConverter;
        }

        public ICueElement ProcessTimestamp(string timeStampString)
        {
            var lastSpaceIndex = timeStampString.LastIndexOf(' ');
            var date = timeStampString.Substring(lastSpaceIndex);
            var convertedTime = _timeStampFormatConverter.ToCueFormat(date);
            var title = timeStampString.Substring(0, lastSpaceIndex).Trim();

            return new CueElement
            {
                Title = title,
                Time = convertedTime
            };
        }
    }
}
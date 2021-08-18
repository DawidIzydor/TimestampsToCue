using TimeStampsToCueAbstractions;
using TimeStampsToCueAbstractions.TimestampProcessor;

namespace TimestampsToCueLib.TimestampProcessor
{
    public class TimeBeforeTitleProcessor : ITimestampProcessor
    {
        private readonly TimeStampFormatConverter _timeStampFormatConverter;
        private readonly ColonIndexCalculator _colonIndexCalculator;

        public TimeBeforeTitleProcessor(TimeStampFormatConverter timeStampFormatConverter, ColonIndexCalculator colonIndexCalculator)
        {
            _timeStampFormatConverter = timeStampFormatConverter;
            _colonIndexCalculator = colonIndexCalculator;
        }

        private static string GetTitleAfterTime(string timeStampString, int startingIndex)
        {
            var title = timeStampString.Substring(startingIndex).Trim();
            return title;
        }

        private string GetTimeBeforeTitle(string timeStampString, int startingIndex, int endingIndex)
        {
            var timeString = timeStampString.Substring(startingIndex,
                endingIndex - startingIndex);

            return _timeStampFormatConverter.ToCueFormat(timeString);
        }

        public ICueElement ProcessTimestamp(string timeStampString)
        {
            var colonIndex = _colonIndexCalculator.GetTimeColonIndex(timeStampString);
            var firstDateStringIndex = timeStampString.Substring(0, colonIndex).LastIndexOf(' ') + 1;
            var firstSpaceAfterDateIndex = timeStampString.IndexOf(' ', colonIndex);

            var timeConverted = GetTimeBeforeTitle(timeStampString, firstDateStringIndex, firstSpaceAfterDateIndex);
            var title = GetTitleAfterTime(timeStampString, firstSpaceAfterDateIndex).Trim();

            return new CueElement
            {
                Time = timeConverted,
                Title = title
            };
        }
    }
}
using TimeStampsToCueAbstractions;
using TimeStampsToCueAbstractions.TimestampProcessor;

namespace TimestampsToCueLib.TimestampProcessor
{
    public class AutoProcessor : ITimestampProcessor
    {
        private readonly ColonIndexCalculator _colonIndexCalculator;
        private readonly TimeAtEndProcessor _timeAtEndProcessor;
        private readonly TimeBeforeTitleProcessor _timeBeforeTitleProcessor;

        public AutoProcessor(TimeStampFormatConverter timeStampFormatConverter, ColonIndexCalculator colonIndexCalculator)
        {
            _colonIndexCalculator = colonIndexCalculator;
            _timeAtEndProcessor = new TimeAtEndProcessor(timeStampFormatConverter);
            _timeBeforeTitleProcessor = new TimeBeforeTitleProcessor(timeStampFormatConverter, _colonIndexCalculator);
        }

        public ICueElement ProcessTimestamp(string timeStampString)
        {
            var mode = GetActualProcessor(timeStampString);

            return mode.ProcessTimestamp(timeStampString);
        }

        private ITimestampProcessor GetActualProcessor(string timeStampString)
        {
            int colonIndex = _colonIndexCalculator.GetTimeColonIndex(timeStampString);
            if (colonIndex == timeStampString.Length - 3 || colonIndex == timeStampString.Length - 6)
            {
                return _timeAtEndProcessor;
            }

            return _timeBeforeTitleProcessor;
        }
    }
}
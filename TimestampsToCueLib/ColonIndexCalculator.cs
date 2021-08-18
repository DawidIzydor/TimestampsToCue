using System.Linq;
using TimeStampsToCueAbstractions;

namespace TimestampsToCueLib
{
    public class ColonIndexCalculator
    {
        private readonly WordExtractor _wordExtractor = new();

        public int GetTimeColonIndex(string timeStampString)
        {
            if (timeStampString.Length < 3)
            {
                throw new TimestampFormatException($"Time stamp string too short {timeStampString}",
                    nameof(timeStampString));
            }

            int colonIndex = 0;
            do
            {
                colonIndex = timeStampString.IndexOf(':', colonIndex+1);
                if(colonIndex < 0) break;

                var possibleTimeStamp = _wordExtractor.GetWordAtIndex(timeStampString, colonIndex);

                if (CorrectSymbolsInWord(possibleTimeStamp) && NoMoreThanTwoColonsInWord(possibleTimeStamp))
                {
                    return colonIndex;
                }

                colonIndex++;
            } while (colonIndex > 0);

            throw new TimestampFormatException("timeStampString contains no time stamp", nameof(timeStampString));
        }

        private bool NoMoreThanTwoColonsInWord(string possibleTimeStamp)
        {
            return possibleTimeStamp.Count(c => c == ':') <= 2;
        }

        private bool CorrectSymbolsInWord(string possibleTimeStamp)
        {
            return possibleTimeStamp.All(c => c is >= '0' and <= '9' or ':');
        }

    }
}
using TimeStampsToCueAbstractions;

namespace TimestampsToCueLib.TimestampProcessor
{
    public class TimeStampFormatConverter
    {
        public string ToCueFormat(string timeString)
        {
            var split = timeString.Split(':');

            int hours;
            int minutes;
            int seconds;

            switch (split.Length)
            {
                case 2:
                    hours = 0;
                    minutes = int.Parse(split[0]);
                    seconds = int.Parse(split[1]);
                    break;
                case 3:
                    hours = int.Parse(split[0]);
                    minutes = int.Parse(split[1]);
                    seconds = int.Parse(split[2]);
                    break;
                default:
                    throw new TimestampFormatException("Time string wrong format", nameof(timeString));
            }

            if (minutes is < 0 or > 60)
            {
                throw new TimestampFormatException($"Wrong number of minutes: {minutes}", nameof(timeString));
            }

            if (seconds is < 0 or > 60)
            {
                throw new TimestampFormatException($"Wrong number of seconds {seconds}", nameof(timeString));
            }

            var minutesParsed = hours * 60 + minutes;

            return $"{minutesParsed:D2}:{seconds:D2}:00";
        }
    }
}
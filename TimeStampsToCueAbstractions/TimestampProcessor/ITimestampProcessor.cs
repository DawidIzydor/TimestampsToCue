namespace TimeStampsToCueAbstractions.TimestampProcessor
{
    public interface ITimestampProcessor
    {
        ICueElement ProcessTimestamp(string timeStampString);
    }
}